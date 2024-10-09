using Selenium.Automation.Model.Platform.Element;

namespace Selenium.Automation.Model.Platform.WebElements
{
	public interface IHtmlTextElement : IHtmlElement
	{
		void SetText(string text);
		string GetValue();
		string GetPlaceholder();
	}
}
