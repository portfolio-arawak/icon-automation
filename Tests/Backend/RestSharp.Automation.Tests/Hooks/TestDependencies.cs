using System;
using System.Linq;

using Autofac;

using Microsoft.Extensions.Configuration;

using RestSharp.Automation.Bootstrap;

using SpecFlow.Autofac;

using TechTalk.SpecFlow;

namespace RestSharp.Automation.Tests.Hooks
{
	public class TestDependencies
	{
		[ScenarioDependencies]
		public static ContainerBuilder CreateContainerBuilder()
		{
			var builder = new Bootstrapper();
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
			return new ConfigurationBuilder()
				.AddJsonFile($"env.demo.json", optional: true, reloadOnChange: true);
		}
	}
}