using System;
using System.Reflection;
using React;
using React.TinyIoC;

namespace MFiles.SDK.Tasks
{
	public static class ReactConfig
	{
		public static void Configure()
		{
			AppDomain.CurrentDomain.AssemblyResolve += MyResolveEventHandler;

			Initialize();

			ReactSiteConfiguration.Configuration
				.SetReuseJavaScriptEngines( false );

			//ReactSiteConfiguration.Configuration
			//	.SetLoadBabel( true );
		}

		private static Assembly MyResolveEventHandler( object sender, ResolveEventArgs args )
		{
			return typeof( JavaScriptEngineSwitcher.Core.JsEngineBase ).Assembly;
		}

		private static void Initialize()
		{
			Initializer.Initialize( registration => registration.AsSingleton() );
			var container = AssemblyRegistration.Container;
			// Register some components that are normally provided by the integration library
			// (eg. React.AspNet or React.Web.Mvc6)
			container.Register<ICache, NullCache>();
			container.Register<IFileSystem, SimpleFileSystem>();
		}
	}
}
