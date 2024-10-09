using System;
using System.Linq;

using Autofac;

using Microsoft.Extensions.Configuration;

using Selenium.Automation.Tests.Bootstrap;

using SpecFlow.Autofac;

using TechTalk.SpecFlow;

namespace Selenium.Automation.Tests.Hooks
{
	public class TestDependencies
	{
		[ScenarioDependencies]
		public static ContainerBuilder CreateContainerBuilder()
		{
			var builder = new Bootstraper();
			builder.ConfigureServices(GetConfiguration());
			builder.Builder.RegisterTypes(
				typeof(TestDependencies)
					.Assembly.GetTypes()
					.Where(t => Attribute.IsDefined(t, typeof(BindingAttribute)))
					.ToArray()).InstancePerLifetimeScope();
			return builder.Builder;
		}

		private static IConfigurationBuilder GetConfiguration()
		{
			var ciEnv = Environment.GetEnvironmentVariable("testrun.environment");
			var val = string.IsNullOrEmpty(ciEnv) ? "chrome.int" : ciEnv;

			return new ConfigurationBuilder()
				.AddJsonFile($"env.{val}.json", optional: true, reloadOnChange: true)
				.AddJsonFile("runsettings.json", optional: true, reloadOnChange: true);
		}
	}
}
