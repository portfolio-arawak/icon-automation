using System;

using SeleniumExtras.PageObjects;

namespace Selenium.Automation.Model.Platform.Locator
{
	public class FindByAttribute : Attribute
	{
		public FindByAttribute(How how, string @using)
		{
			How = how;
			Using = @using;
		}

		public How How { get; }

		public string Using { get; }
	}
}
