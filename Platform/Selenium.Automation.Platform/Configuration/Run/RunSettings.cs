using Selenium.Automation.Model.Domain.Run;

namespace Selenium.Automation.Platform.Configuration.Run
{
	public class RunSettings : IRunSettings
	{
		public SeleniumGrid SeleniumGrid { get; set; }
		public RunType RunType { get; set; }
	}
}
