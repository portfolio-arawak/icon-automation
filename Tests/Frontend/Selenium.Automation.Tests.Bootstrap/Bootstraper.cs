using System;

using Autofac;

using Automation.Common.Environment;

using Microsoft.Extensions.Configuration;
using Selenium.Automation.Domain.Login;
using Selenium.Automation.Model.Domain.Login;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Platform.Configuration.Run;
using Selenium.Automation.Platform.Driver;
using Selenium.Automation.UI.Login;

using Serilog;
using Serilog.Events;

namespace Selenium.Automation.Tests.Bootstrap
{
	public class Bootstraper
	{
		private ContainerBuilder _builder;

		public ContainerBuilder Builder => _builder ??= new ContainerBuilder();

		public void ConfigureServices(IConfigurationBuilder configurationBuilder)
		{
			var configurationRoot = configurationBuilder.Build();
			Builder.Register<ILogger>((c, p) => new LoggerConfiguration()
				.WriteTo.File(
					$"Logs/log_{DateTime.UtcNow:yyyy_MM_dd_hh_mm_ss}.txt",
					LogEventLevel.Verbose,
					"{Timestamp:dd-MM-yyyy HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
				.CreateLogger())
				.SingleInstance();

			// Configurations
			Builder.Register<IEnvironmentConfiguration>(context => configurationRoot.Get<EnvironmentConfiguration>())
				.SingleInstance();
			Builder.Register<IRunSettings>(cont => configurationRoot.Get<RunSettings>())
				.SingleInstance();

			// Logic
			Builder.RegisterType<LoginContext>().As<ILoginContext>().SingleInstance();
			Builder.RegisterType<LoginSteps>().As<ILoginSteps>().SingleInstance();
			Builder.RegisterType<WebDriver>().As<IWebDriver>().SingleInstance();
		}
	}
}
