using Automation.Common.Environment;

using Selenium.Automation.Model.Platform.Drivers;

namespace Selenium.Automation.UI
{
	public class StepsBase
	{
		private readonly IWebDriver _webDriver;
		private readonly IEnvironmentConfiguration _environmentConfiguration;

		protected StepsBase(
			IWebDriver webDriver,
			IEnvironmentConfiguration environmentConfiguration)
		{
			_webDriver = webDriver;
			_environmentConfiguration = environmentConfiguration;
		}

		public void OpenMainView() =>
			_webDriver.Get(_environmentConfiguration.EnvironmentUri);
	}
}
