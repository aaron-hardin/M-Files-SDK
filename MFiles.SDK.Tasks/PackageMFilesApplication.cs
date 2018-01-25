using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Ionic.Zip;
using MFiles.SDK.Tasks.PackageDefinition;
using MFiles.SDK.Tasks.PackageModel;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using React;

namespace MFiles.SDK.Tasks
{
	public class PackageMFilesApplication : Task
	{
		public override bool Execute()
		{
			Log.LogMessage( MessageImportance.Low, "Packing M-Files Application." );

			// Make sure the collections are never null.
			References = References ?? new ITaskItem[ 0 ];
			SourceFiles = SourceFiles ?? new ITaskItem[ 0 ];
			NoBuildFiles = NoBuildFiles ?? new ITaskItem[ 0 ];
			DefaultEnvironments = DefaultEnvironments ?? new string[ 0 ];

			// Create the application package contents.
			var references = References.Select( item => new Reference( item ) ).ToList();
			var files = SourceFiles.Select( item => new PackageFile( item, BuildAction.Compile ) ).ToList();
			files.AddRange(NoBuildFiles.Select(item => new PackageFile( item, BuildAction.None )).Where(file => file.CopyToOutputDirectory));

			var appDef = CreateApplicationDefinition( references, files );
			var outputZip = CreatePackage( references, files );

			// Serialize the application definition file.
			var namespaces = new XmlSerializerNamespaces();
			namespaces.Add( "xsi", "http://www.w3.org/2001/XMLSchema-instance" ); // TODO: is this correct?
			namespaces.Add( "noNamespaceSchemaLocation", "http://www.m-files.com/schemas/appdef-client-v3.xsd" ); // TODO: is this correct?
			var stream = new MemoryStream();
			var serializer = new XmlSerializer( typeof( ApplicationDefinition ) );
			serializer.Serialize( stream, appDef, namespaces );
			stream.Flush();
			stream.Position = 0;
			outputZip.AddEntry( "appdef.xml", stream );

			// Save the zip.
			outputZip.Save();

			return true;
		}

		private ZipFile CreatePackage( List<Reference> references, List<PackageFile> files )
		{
			// Create the package.
			if( File.Exists( OutputFile ) )
				File.Delete( OutputFile );
			var outputZip = new ZipFile( OutputFile );

			ReactConfig.Configure();

			// Add the project files.
			Dictionary<string, string> packages = new Dictionary<string, string>();
			foreach( var file in files )
			{
				if( file.BuildAction == BuildAction.None && file.CopyToOutputDirectory == false )
				{
					continue;
				}

				var fileName = Path.GetFileName( file.FullPath );
				var shouldProcess = file.BuildAction == BuildAction.Compile && fileName != null && Regex.IsMatch(fileName, @".+\.jsx?$");
				Log.LogMessage( MessageImportance.High, $"Processing: {fileName} - {shouldProcess}" );
				if( shouldProcess )
				{
					var babel = ReactEnvironment.Current.Babel;
					Log.LogMessage( MessageImportance.Low, $"Transforming: {fileName}" );
					var result = babel.TransformFile( file.FullPath );
					Log.LogMessage( MessageImportance.Low, $"Transformed: {fileName}" );
					int indexOfNewLine = result.IndexOfAny(new [] { '\r', '\n' });
					string firstLine = indexOfNewLine == -1 ? result : result.Substring(0, indexOfNewLine);
					if (firstLine.StartsWith("//#package:"))
					{
						// TODO: consider replacing firstLine here with the filename
						var packageName = firstLine.Substring(11).Trim();
						if (packages.ContainsKey(packageName))
						{
							packages[packageName] += Environment.NewLine + result;
						}
						else
						{
							packages.Add(packageName, result);
						}
						continue;
					}
					var path = file.PathInProject;
					if( Path.GetExtension( fileName ) == ".jsx" )
					{
						fileName = Path.ChangeExtension( fileName, "js" );
						path = Path.ChangeExtension( path, "js" );
					}

					outputZip.AddEntry( fileName, result ).FileName = path;
					Log.LogMessage( MessageImportance.Low, $"AddedToZip: {fileName}" );
				}
				else
				{
					outputZip.AddFile( file.FullPath ).FileName = file.PathInProject;
				}
			}

			foreach (var packageKvp in packages)
			{
				var fileName = Path.GetFileName(packageKvp.Key);
				outputZip.AddEntry(fileName, packageKvp.Value).FileName = packageKvp.Key;
			}

			// Add the referenced scripts.
			foreach( var reference in references )
			{
				foreach( var e in reference.Zip )
				{
					var filename = Path.GetFileName( e.FileName ).ToLower();

					// There are some files that shouldn't be included from the references.
					if( filename == "appdef.xml" ) continue;
					if( filename == "libdef.xml" ) continue;
					if( filename == "_package_start.js" ) continue;
					if( filename == "_package_end.js" ) continue;

					var tempStream = new MemoryStream();
					e.Extract( tempStream );
					tempStream.Position = 0;

					var entryPath = string.Format( "{0}/{1}", reference.PackageName, e.FileName );
					outputZip.AddEntry( entryPath, tempStream );
				}
			}

			// Add the bootstrap libraries.
			var packageStartStream = this.GetType().Assembly.GetManifestResourceStream( "MFiles.SDK.Tasks.Scripts.package_start.js" );
			outputZip.AddEntry( "_package_start.js", packageStartStream );
			var packageEndStream = this.GetType().Assembly.GetManifestResourceStream( "MFiles.SDK.Tasks.Scripts.package_end.js" );
			outputZip.AddEntry( "_package_end.js", packageEndStream );
			return outputZip;
		}

		private ApplicationDefinition CreateApplicationDefinition( List<Reference> references, IEnumerable<PackageFile> files )
		{
			var defaultEnvironments = DefaultEnvironments.Select(
				e => ( TargetEnvironment )Enum.Parse( typeof( TargetEnvironment ), e ) );

			var scripts = files.Where( f => f.Environment != TargetEnvironment.None );
			var specifiedEnvironments = scripts.Where( f => f.Environment != TargetEnvironment.All ).Select( f => f.Environment ).Distinct();
			specifiedEnvironments = specifiedEnvironments.Union( defaultEnvironments );

			Guid = Guid.Replace( "{", "" ).Replace( "}", "" );
			ApplicationDefinition appdef = new ApplicationDefinition
			{
				Name = ApplicationName,
				Guid = Guid,
				Version = ApplicationVersion,
				Description = Description,
				Publisher = Publisher,
				Copyright = Copyright,
				RequiredMFilesVersion = MFilesVersion,
				EnabledByDefault = EnabledByDefault,
				Optional = Optional,
				MasterApplicationGuid = MasterApplicationGuid,
				Platforms = Platforms.Select(platformName => new Platform(platformName)).ToList()
			};

			// Create the module elements.
			foreach( var env in specifiedEnvironments )
			{
				var module = new ApplicationModule { Environment = env.ToString().ToLower() };
				appdef.Modules.Add( module );

				// Add the bootstrap scripts.
				module.Files.Add( new ApplicationFile { Name = "_package_start.js" } );

				// Add javascript files from the references.
				foreach( var r in references )
				{
					var referencedScripts = r.GetScriptsForEnvironment( env );
					foreach( var script in referencedScripts )
					{
						var file = new ApplicationFile { Name = r.PackageName + "/" + script };
						module.Files.Add( file );
					}
				}

				// Add the application's own javascript files.
				var environmentScripts = scripts.Where( s => s.Environment == TargetEnvironment.All || s.Environment == env );
				foreach( var script in environmentScripts )
				{
					var file = new ApplicationFile { Name = script.PathInProject };
					module.Files.Add( file );
				}

				module.Files.Add( new ApplicationFile { Name = "_package_end.js" } );
			}

			foreach( var db in files.Where(f => f.IsDashboard ) )
			{
				var dashboard = new ApplicationDashboard
				{
					Id = Path.GetFileNameWithoutExtension(db.PathInProject),
					Content = db.PathInProject
				};
				appdef.Dashboards.Add(dashboard);
			}

			foreach( var r in references )
			{
				foreach( var db in r.GetDashboards() )
				{
					var dashboard = new ApplicationDashboard
					{
						Id = db.Key,
						Content = r.PackageName + "/" + db.Value
					};
					appdef.Dashboards.Add( dashboard );
				}
			}

			return appdef;
		}

		[Required]
		public string ApplicationName { get; set; }

		[Required]
		public string Guid { get; set; }

		[Required]
		public string ApplicationVersion { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public string Publisher { get; set; }

		[Required]
		public string Copyright { get; set; }

		[Required]
		public string MFilesVersion { get; set; }

		[Required]
		public string EnabledByDefault { get; set; }

		[Required]
		public string Optional { get; set; }

		[Required]
		public string MasterApplicationGuid { get; set; }

		[Required]
		public ITaskItem[] SourceFiles { get; set; }

		[Required]
		public ITaskItem[] NoBuildFiles { get; set; }

		[Required]
		public string OutputFile { get; set; }

		public string Version { get; set; }
		public ITaskItem[] References { get; set; }
		public string[] DefaultEnvironments { get; set; }
		public string[] Platforms { get; set; }
	}
}
