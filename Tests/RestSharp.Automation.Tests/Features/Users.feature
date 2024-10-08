Feature: Users

A short summary of the feature

@tag1
Scenario: 1. Validate api response for users enpoint returns successful response
	Given I have access to the '/api/users'
	When I receive response 
	Then I see '' status code

Scenario: 1. Validate api response for users enpoint with different pages
	Given I have access to the '/api/users?page=1'
	When 
	Then [outcome]
