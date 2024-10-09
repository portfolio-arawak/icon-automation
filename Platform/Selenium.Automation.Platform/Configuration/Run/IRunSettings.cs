using Selenium.Automation.Model.Domain.Run;

namespace Selenium.Automation.Platform.Configuration.Run
{
	public interface IRunSettings
	{
		SeleniumGrid SeleniumGrid { get; set; }
		RunType RunType { get; set; }
	}
}
