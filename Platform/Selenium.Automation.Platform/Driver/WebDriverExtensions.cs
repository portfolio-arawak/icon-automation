using System;

using OpenQA.Selenium;

namespace Selenium.Automation.Platform.Driver
{
	internal static class WebDriverExtensions
	{
		public static bool Alive(this IWebDriver driver)
		{
			try
			{
				// Poke web driver.
				// ReSharper disable once UnusedVariable
				var handle = driver.CurrentWindowHandle;
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
