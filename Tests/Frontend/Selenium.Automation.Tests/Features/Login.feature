@Regression
@Login
Feature: Login

Scenario: 1. Validate unsuccessful login using email and assert that the proper error messages are returned
	Given I have opened the login page
	When I fill email by 'invalid@invalid.com' value
	When I proceed 'Continue' action
	And I fill password by 'invalid' value
	And I proceed 'Continue' action
	Then I see 'Check your credentials. We couldn’t match your email, username, or password.' validation message

@Bug
Scenario: 2. Validate successful login using email and assert
	Given I have opened the login page
	When I fill email by 'iconaqa@gmail.com' value
	When I proceed 'Continue' action
	And I fill password by 'Demo1q2w3e4r5t6y!' value
	And I proceed 'Continue' action
	Then I see that login is successful
