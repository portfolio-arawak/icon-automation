using System;

using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Model.Platform.Page;
using Selenium.Automation.Platform.Element;

namespace Selenium.Automation.Platform.Factory
{
	public static class PageFactory
	{
		public static TPage Get<TPage>(IWebDriver driver)
			where TPage : IWebPage
		{
			IWebPage page = (TPage)Activator.CreateInstance(typeof(TPage), driver);
			InitPage(page);
			return (TPage)page;
		}

		private static void InitPage(IWebPage page)
		{
			if (page.GetType().HasUrlAttribute())
			{
				page.Address = page.GetType().GetUrlAttribute().Url;
			}

			ElementFactory.InitProperties(page);
		}
	}
}
