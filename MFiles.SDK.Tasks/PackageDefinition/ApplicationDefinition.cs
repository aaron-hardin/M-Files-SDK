using System.Collections.Generic;
using System.Xml.Serialization;

namespace MFiles.SDK.Tasks.PackageDefinition
{
	[XmlRoot( ElementName = "application" )]
	public class ApplicationDefinition
	{
		public ApplicationDefinition()
		{
			Platforms = new List<Platform>();
			Modules = new List<ApplicationModule>();
			Dashboards = new List<ApplicationDashboard>();
			ApplicationType = "client-application";
		}

		[XmlAttribute("type")]
		public string ApplicationType { get; set; }

		[XmlElement( ElementName = "guid" )]
		public string Guid { get; set; }

		[XmlElement( ElementName = "name" )]
		public string Name { get; set; }

		[XmlElement( ElementName = "version" )]
		public string Version { get; set; }

		[XmlElement( ElementName = "description" )]
		public string Description { get; set; }

		[XmlElement( ElementName = "publisher" )]
		public string Publisher { get; set; }

		[XmlElement( ElementName = "copyright" )]
		public string Copyright { get; set; }

		[XmlElement( ElementName = "enabled-by-default" )]
		public string EnabledByDefault { get; set; }

		[XmlElement( ElementName = "optional" )]
		public string Optional { get; set; }

		[XmlElement( ElementName = "required-mfiles-version" )]
		public string RequiredMFilesVersion { get; set; }

		[XmlElement( ElementName = "master-application-guid" )]
		public string MasterApplicationGuid { get; set; }

		[XmlArray( ElementName = "platforms" )]
		[XmlArrayItem( ElementName = "platform" )]
		public List<Platform> Platforms { get; set; }

		[XmlArray( ElementName = "modules" )]
		[XmlArrayItem( ElementName = "module" )]
		public List<ApplicationModule> Modules { get; set; }

		[XmlArray( ElementName = "dashboards" )]
		[XmlArrayItem( ElementName = "dashboard" )]
		public List<ApplicationDashboard> Dashboards { get; set; }

		public bool ShouldSerializeMasterApplicationGuid()
		{
			// Serialize if not empty
			return !string.IsNullOrEmpty( MasterApplicationGuid );
		}
	}
}
