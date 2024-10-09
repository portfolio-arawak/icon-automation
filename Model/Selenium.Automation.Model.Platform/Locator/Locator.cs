using SeleniumExtras.PageObjects;

namespace Selenium.Automation.Model.Platform.Locator
{
	public class Locator
	{
		public Locator(How how, string @using)
		{
			How = how;
			Using = @using;
		}

		public How How { get; }

		public string Using { get; }
	}
}
