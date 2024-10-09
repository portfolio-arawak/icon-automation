using System.Collections.Generic;

using OpenQA.Selenium;

namespace Selenium.Automation.Model.Platform.Element
{
	public interface INative
	{
		IWebElement FindElement(Locator.Locator locator, int index);
		IReadOnlyCollection<IWebElement> FindElements(Locator.Locator locator);
	}
}
