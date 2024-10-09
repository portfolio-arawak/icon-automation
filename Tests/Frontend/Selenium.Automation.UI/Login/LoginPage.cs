using System.Linq;

using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Page;
using Selenium.Automation.Platform.WebElements;

using SeleniumExtras.PageObjects;

namespace Selenium.Automation.UI.Login
{
	public class LoginPage : WebPage
	{
		public LoginPage(IWebDriver webDriver)
			: base(webDriver)
		{
		}

		[FindBy(How.XPath, ".//input[@id='email']")]
		public HtmlTextBox EmailTextBox { get; set; }

		[FindBy(How.XPath, ".//button[@type='submit']")]
		public HtmlButton ContinueButton { get; set; }

		[FindBy(How.XPath, ".//button[.//span[text()='Accept all cookies']]")]
		public HtmlButton AcceptCookiesButton { get; set; }
		
		[FindBy(How.XPath, ".//a[.//span[text()='Log in']]")]
		public HtmlButton LoginButton { get; set; }

		[FindBy(How.XPath, ".//input[@placeholder='Password']")]
		public HtmlTextBox PasswordTextBox { get; set; }

		[FindBy(How.XPath, ".//div[input[@id='email']]//span")]
		public HtmlLabel EmailValidationMessage { get; set; }
	}
}
