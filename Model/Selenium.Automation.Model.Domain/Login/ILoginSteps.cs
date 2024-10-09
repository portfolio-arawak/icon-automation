namespace Selenium.Automation.Model.Domain.Login
{
	public interface ILoginSteps
	{
		void SetEmail(string email);
		void Continue();
		void OpenLoginPage();
		void SetPassword(string password);
		string GetValidationMessage();
		bool IsLoginSuccessful();
	}
}
