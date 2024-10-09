using System.Linq;

using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Model.Platform.WebElements.AutoComplete;
using Selenium.Automation.Platform.Element;

using SeleniumExtras.PageObjects;

namespace Selenium.Automation.Platform.WebElements.AutoComplete
{
	public class HtmlAutocompleteDropdown : HtmlElement, IHtmlAutocompleteDropdown
	{
		private HtmlLink[] Items =>
			FindAll<HtmlLink>(new Locator(How.XPath, ".//div[@id='autocomplete-results']")).ToArray();

		public HtmlLink[] GetItems() => Items;

		public string[] GetValues() => Items.Select(x => x.GetText()).ToArray();

		public void Select(string value) => Items.First(i => i.GetText().Equals(value)).Click();
	}
}
