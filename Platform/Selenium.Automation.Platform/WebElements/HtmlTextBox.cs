using Selenium.Automation.Model.Platform.WebElements;
using Selenium.Automation.Platform.Element;

namespace Selenium.Automation.Platform.WebElements
{
	public class HtmlTextBox : HtmlElement, IHtmlTextElement
	{
		public void SetText(string text)
		{
			NativeElement.Clear();
			NativeElement.SendKeys(text);
		}

		public string GetValue() => NativeElement.GetAttribute("value");

		public string GetPlaceholder() => NativeElement.GetAttribute("placeholder");
	}
}
