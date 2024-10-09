using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

using Selenium.Automation.Model.Platform.Element;

using IWebDriver = Selenium.Automation.Model.Platform.Drivers.IWebDriver;
using WebDriver = Selenium.Automation.Platform.Driver.WebDriver;

namespace Selenium.Automation.Platform.Element
{
	public static class ElementExtensions
	{
		public static void ScrollDown(this HtmlElement nativeElement, IWebDriver webDriver) =>
			new Actions(((WebDriver)webDriver).GetNativeDriver())
				.SendKeys(((IHtmlElement)nativeElement).GetNativeElement(), Keys.End)
				.Perform();

		public static void ScrollUp(this HtmlElement nativeElement, IWebDriver webDriver) =>
			new Actions(((WebDriver)webDriver).GetNativeDriver())
				.SendKeys(((IHtmlElement)nativeElement).GetNativeElement(), Keys.Up)
				.Perform();
	}
}
