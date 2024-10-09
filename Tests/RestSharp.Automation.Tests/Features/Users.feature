@Regression
@Users
Feature: Users

Scenario: 1. Validate api response for users endpoint returns successful response
	Given I have access to the users api
	When I receive response from '/api/users?page=1' endpoint
	Then I see 'OK' status code
	And I see that content type is 'application/json'
	And I see the content of the response is not empty

Scenario Outline: 2. Validate that api response returned 6 users with correct data depends on the page number
	Given I have access to the users api
	When I receive model from '/api/users?page=<PageNumber>' endpoint
	Then I see '<ExpectedPreset>' data in response
	And I see that '6' users are returned in the response
Examples:
	| Id    | PageNumber | ExpectedPreset |
	| Page1 | 1          | Page1Preset    |
	| Page2 | 2          | Page2Preset    |

Scenario: 3. Validate that page number returned matches to the one specified in the URL
	Given I have access to the users api
	When I receive model from '/api/users?page=1' endpoint
	Then I see page number '1' in the response the same as in the URL

Scenario: 4. Validate that endpoint returns the user with details
	Given I have access to the users api
	When I receive model from '/api/users?page=2' endpoint
	Then I see 'ByronFields' users with details in the response

Scenario: 5. Validate that response for non-existent page returns empty data
	Given I have access to the users api
	When I receive model from '/api/users?page=100' endpoint
	Then I see that no any users are returned in the response