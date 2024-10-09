using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Page;
using Selenium.Automation.Platform.WebElements;

using SeleniumExtras.PageObjects;

namespace Selenium.Automation.UI
{
	public class MainPage : WebPage
	{
		public MainPage(IWebDriver webDriver)
			: base(webDriver)
		{
		}

		[FindBy(How.XPath, ".//rz-user//button")]
		public HtmlButton OpenLoginButton { get; set; }
	}
}
