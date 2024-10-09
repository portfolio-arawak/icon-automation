using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Element;

using SeleniumExtras.PageObjects;

namespace Selenium.Automation.Platform.WebElements.Dropdowns
{
	public class SelectDropdown : HtmlElement
	{
		[FindBy(How.XPath, ".//et-deposit-payment-method-dropdown")]
		public MethodDropDown MethodDropDown { get; set; }
	}
}
