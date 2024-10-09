using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Model.Platform.WebElements.Mat;
using Selenium.Automation.Platform.Element;

using SeleniumExtras.PageObjects;

namespace Selenium.Automation.Platform.WebElements.Mat
{
	public class MatDropDown : HtmlElement, IMatDropDown
	{
		[FindBy(How.XPath, ".//mat-select[@id='mat-select-0']")]
		private MatSelect MatSelect { get; set; }

		public void SetValue(string value)
		{
			MatSelect.Open();
			MatSelect.Select(value);
		}

		public string[] GetOptions() =>
			MatSelect.GetOptions();
	}
}
