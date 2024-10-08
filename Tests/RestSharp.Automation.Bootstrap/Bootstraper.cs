﻿using System;

using Autofac;
using Automation.Common.Environment;
using Microsoft.Extensions.Configuration;
using RestSharp.Automation.Domain.Users;
using RestSharp.Automation.Model.Domain.Users;
using Serilog;
using Serilog.Events;


namespace RestSharp.Automation.Bootstrap
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
			Builder.Register<IEnvironmentConfiguration>(context => 
				configurationRoot.Get<EnvironmentConfiguration>())
				.SingleInstance();

			// Api Clients
			Builder.RegisterType<UsersApiClient>().As<IUsersApiClient>().SingleInstance();

			// Logic Steps
            Builder.RegisterType<UsersSteps>().As<IUsersSteps>().InstancePerDependency();

            // Logic Context
        }
	}
}
