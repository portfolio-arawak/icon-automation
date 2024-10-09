using System.Linq;

using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Model.Platform.WebElements.Mat;
using Selenium.Automation.Platform.Element;
using Selenium.Automation.Platform.Waiter;

using SeleniumExtras.PageObjects;

namespace Selenium.Automation.Platform.WebElements.Mat
{
	public class MatSelect : HtmlElement, IMatSelect
	{
		private HtmlElement[] Options =>
			FindAll<HtmlElement>(new Locator(How.XPath, ".//ancestor::body//mat-option"))
				.ToArray();

		public void Open()
		{
			Click();
			WaitFor.Condition(
				() =>
				Options.Any(i => i.GetDisplayed()),
				"No Any mat select options.");
		}

		public void Select(string option) =>
			Options.Single(
				i => i.GetText().Contains(option))
				.Click();

		public string[] GetOptions() =>
			Options.Select(i => i.GetText().Trim())
				.ToArray();
	}
}
