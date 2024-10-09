using System;

using Automation.Common.Environment;

using Selenium.Automation.Model.Domain.Login;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Platform.Factory;

namespace Selenium.Automation.UI.Login
{
	public class LoginSteps : StepsBase, ILoginSteps
	{
		private static string LoginUrl = "https://accounts.evernote.com/login";
		private readonly IWebDriver _webDriver;
		private readonly IEnvironmentConfiguration _environmentConfiguration;

		public LoginSteps(
			IWebDriver webDriver,
			IEnvironmentConfiguration environmentConfiguration)
			: base(webDriver, environmentConfiguration)
		{
			_webDriver = webDriver;
			_environmentConfiguration = environmentConfiguration;
		}

		private LoginPage LoginPage => PageFactory.Get<LoginPage>(_webDriver);

		private MainPage MainPage => PageFactory.Get<MainPage>(_webDriver);

		public void SetEmail(string email)
		{
			LoginPage.EmailTextBox.SetText(email);
		}

		public void Continue()
		{
			LoginPage.ContinueButton.Click();
		}
		
		public void OpenLoginPage()
		{
			OpenMainView();
			OpenLoginView();
		}

		public void SetPassword(string password)
		{
			LoginPage.PasswordTextBox.SetText(password);
		}

		public string GetValidationMessage()
		{
			return LoginPage.EmailValidationMessage.GetText();
		}

		public bool IsLoginSuccessful()
		{
			throw new NotImplementedException();
		}

		private void OpenLoginView()
		{
			//_webDriver.Get(LoginUrl);
			LoginPage.AcceptCookiesButton.Click();
			LoginPage.LoginButton.Click();
		}
	}
}
