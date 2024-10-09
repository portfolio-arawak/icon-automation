using Selenium.Automation.Model.Platform.Element;

namespace Selenium.Automation.Model.Platform.Page
{
	public interface IWebPage : ISearchable, INative
	{
		string Address { get; set; }
		string Title { get; set; }
		void Open();
		void Refresh();
	}
}
