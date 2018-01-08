using System;
using System.Xml.Serialization;

namespace MFiles.SDK.Tasks.PackageDefinition
{
	[XmlRoot( ElementName = "platform" )]
	public class Platform
	{
		[XmlText]
		public string Name { get; set; }

		public Platform()
		{
		}

		public Platform( string name )
		{
			Name = name;
		}
	}
}
