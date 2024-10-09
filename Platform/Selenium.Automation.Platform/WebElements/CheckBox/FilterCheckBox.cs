using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Model.Platform.WebElements.CheckBox;
using Selenium.Automation.Platform.Element;

using SeleniumExtras.PageObjects;

namespace Selenium.Automation.Platform.WebElements.CheckBox
{
	public class FilterCheckBox : HtmlElement, IFilterCheckbox
    {

        private HtmlLink GetFilterLink(string optionLink)
        {
            string locator = $".//a[@data-id='{optionLink}']";
            HtmlLink element = Find<HtmlLink>(new Locator(How.XPath, locator));
            return element;
        }

        private bool IsChecked(string name)
        {
            var filterLink = GetFilterLink(name);
            var returnedValue = filterLink.HasClass("checked");
            return returnedValue;
        }
        public void SetFilter(bool value, string name)
        {
            if (IsChecked(name) == value)
                return;
            GetFilterLink(name)
                .Click();
        }
    }
}
