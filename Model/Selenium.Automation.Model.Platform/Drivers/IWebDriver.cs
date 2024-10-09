using System;

namespace Selenium.Automation.Model.Platform.Drivers
{
	public interface IWebDriver : IDisposable
	{
		void Get(string url);
		void Close();
		void Refresh();
	}
}
