namespace Selenium.Automation.Model.Platform.WebElements
{
	public interface IHtmlCombobox
	{
		void Select(string value);
		string[] GetValues();
		string GetSelected();
	}
}
