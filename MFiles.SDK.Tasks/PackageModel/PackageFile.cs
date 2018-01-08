using System;
using Microsoft.Build.Framework;

namespace MFiles.SDK.Tasks.PackageModel
{
	public enum TargetEnvironment { None, ShellUI, VaultUI, VaultCore, All }
	public enum BuildAction { None, Compile }

	public class PackageFile
	{
		public string FullPath { get; set; }
		public string PathInProject { get; set; }
		public TargetEnvironment Environment { get; set; }
		public bool IsDashboard { get; set; }
		public BuildAction BuildAction { get; set; }

		/// <summary>
		/// These files do not get compiled
		/// </summary>
		public bool CopyToOutputDirectory { get; set; }

		public PackageFile( ITaskItem item ) : this( item, (BuildAction)Enum.Parse(typeof(BuildAction), item.GetMetadata("BuildAction") ))
		{
		}

		public PackageFile( ITaskItem item, BuildAction buildAction )
		{
			FullPath = item.GetMetadata( "FullPath" );
			PathInProject = item.ItemSpec;

			var environmentData = item.GetMetadata( "Environment" );
			if( string.IsNullOrEmpty( environmentData ) )
				environmentData = "None";

			var isDashboardData = item.GetMetadata( "IsDashboard" );
			if( string.IsNullOrEmpty( isDashboardData ) )
				isDashboardData = "false";

			var copyToOutputDirectoryData = item.GetMetadata( "CopyToOutputDirectory" );
			if( string.IsNullOrEmpty( copyToOutputDirectoryData ) )
				copyToOutputDirectoryData = "DoNotCopy";

			Environment = ( TargetEnvironment )Enum.Parse( typeof( TargetEnvironment ), environmentData, true );
			IsDashboard = bool.Parse( isDashboardData );
			CopyToOutputDirectory = copyToOutputDirectoryData != "DoNotCopy"; // TODO: we should support the PreserveNewest properly
			BuildAction = buildAction;
		}
	}
}
