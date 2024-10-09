using Selenium.Automation.Model.Platform.WebElements;
using Selenium.Automation.Platform.Element;

namespace Selenium.Automation.Platform.WebElements
{
	public class HtmlLink : HtmlElement, IHtmlLink
	{
		public string GetLink() => GetAttribute("href");

		public new void Click() => base.Click();
	}
}
