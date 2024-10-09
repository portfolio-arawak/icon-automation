using System.Collections.Generic;
using System.Linq;

using OpenQA.Selenium.Support.UI;

using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Model.Platform.WebElements;
using Selenium.Automation.Platform.Element;

using SeleniumExtras.PageObjects;

namespace Selenium.Automation.Platform.WebElements
{
	public class HtmlCombobox : HtmlElement, IHtmlCombobox
	{
		private IEnumerable<HtmlElement> Options =>
			FindAll<HtmlElement>(new Locator(How.XPath, "./option")).ToArray();

		public string GetSelected() =>
			new SelectElement(NativeElement).SelectedOption.Text;

		public string[] GetValues() =>
			Options.Select(i => i.GetText().Trim()).ToArray();

		public void Select(string value) =>
			new SelectElement(NativeElement)
				.SelectByText(value);
	}
}
