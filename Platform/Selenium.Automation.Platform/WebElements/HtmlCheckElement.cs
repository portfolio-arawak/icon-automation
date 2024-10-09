using Selenium.Automation.Model.Platform.WebElements;
using Selenium.Automation.Platform.Element;

namespace Selenium.Automation.Platform.WebElements
{
	public class HtmlCheckElement : HtmlElement, IHtmlCheckbox
	{
		public void Check()
		{
			if (!IsChecked())
			{
				Click();
			}
		}

		public void Uncheck()
		{
			if (IsChecked())
			{
				Click();
			}
		}

		public void SetValue(bool value)
		{
			if (IsChecked() != value)
			{
				Click();
			}
		}

		public bool IsChecked() => HasClass("checked");
	}
}
