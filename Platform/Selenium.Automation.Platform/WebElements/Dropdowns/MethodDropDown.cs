using System;
using System.Linq;

using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Model.Platform.WebElements.Dropdowns;
using Selenium.Automation.Platform.Element;
using Selenium.Automation.Platform.Waiter;

using SeleniumExtras.PageObjects;

namespace Selenium.Automation.Platform.WebElements.Dropdowns
{
	public class MethodDropDown : HtmlElement, IMethodDropdown
	{
		[FindBy(How.XPath, ".//et-select")]
		private HtmlButton SelectButton { get; set; }

		[FindBy(How.XPath, ".//et-select-body")]
		private SelectBody SelectBody { get; set; }

		public void OpenDropdown()
		{
			SelectButton.Click();
			WaitFor.Condition(() => SelectBody.GetDisplayed(), "Dropdown wasn't opened", TimeSpan.FromSeconds(30));
		}

		public void Select(string value) =>
			SelectBody.SelectOptions
				.Single(i => i.Name.GetText().Trim().Equals(value))
				.Click();

		public string[] GetOptions() =>
			SelectBody.SelectOptions.Select(i => i.Name.GetText().Trim())
				.ToArray();
	}
}
