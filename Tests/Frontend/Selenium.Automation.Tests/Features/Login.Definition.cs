using FluentAssertions;
using Selenium.Automation.Model.Domain.Login;
using TechTalk.SpecFlow;

namespace Selenium.Automation.Tests.Features
{
	[Binding, Scope(Feature = "Login")]
	public class LoginDefinition
	{
		private readonly ILoginSteps _loginSteps;

		public LoginDefinition(
			ILoginSteps loginSteps)
		{
			_loginSteps = loginSteps;
		}

		[Given(@"I have opened the login page")]
		public void GivenIHaveOpenedTheLoginPage()
		{
			_loginSteps.OpenLoginPage();
		}

		[When(@"I fill email by '([^']*)' value")]
		public void WhenIFillEmailByValue(string email)
		{
			_loginSteps.SetEmail(email);
		}

		[When(@"I proceed 'Continue' action")]
		public void WhenIProceedAction()
		{
			_loginSteps.Continue();
		}

		[When(@"I fill password by '([^']*)' value")]
		public void WhenIFillPasswordByValue(string password)
		{
			_loginSteps.SetPassword(password);
		}

		[Then(@"I see '([^']*)' validation message")]
		public void ThenISeeValidationMessage(string expectedValidationMessage)
		{
			var actualValidationMessage = _loginSteps.GetValidationMessage();
			actualValidationMessage
				.Should()
				.Be(expectedValidationMessage);
		}

		[Then(@"I see that login is successful")]
		public void ThenISeeThatMainViewIsOpened()
		{
			var actualValue = _loginSteps.IsLoginSuccessful();
			actualValue
				.Should()
				.BeTrue("The login should be successful.");
		}

	}
}