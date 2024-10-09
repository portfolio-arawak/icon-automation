using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Model.Platform.WebElements.AutoComplete;
using Selenium.Automation.Platform.Element;
using Selenium.Automation.Platform.Waiter;

using SeleniumExtras.PageObjects;

namespace Selenium.Automation.Platform.WebElements.AutoComplete
{
	public class HtmlAutoCompleteTextField : HtmlElement, IHtmlAutoCompleteTextField
	{
		[FindBy(How.XPath, ".//input")]
		private HtmlTextBox Input { get; set; }

		[FindBy(How.XPath, ".//label")]
		private HtmlLabel HtmlLabel { get; set; }

		private HtmlAutocompleteDropdown HtmlAutocompleteDropdown =>
			Find<HtmlAutocompleteDropdown>(
				new Locator(How.XPath, ".//ancestor::body//div[@id='autocomplete-results']"));

		public void SetText(string value) => Input.SetText(value);

		public string GetLabel() => HtmlLabel.GetText();

		public string GetPlaceHolder() => Input.GetAttribute("placeholder");

		public string GetValue() => Input.GetText();

		public string[] GetDropdownValues() => HtmlAutocompleteDropdown.GetValues();

		public void SetValue(string value)
		{
			SetText(value);
			WaitFor.Condition(() => HtmlAutocompleteDropdown.GetDisplayed(), "The 'Autocomplete' dropdown was not displayed.");
			HtmlAutocompleteDropdown.Select(value);
		}
	}
}
