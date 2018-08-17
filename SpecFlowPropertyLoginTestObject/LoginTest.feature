Feature: LoginTest

@ignore
Scenario: Login
	Given I launch the url in the Browser
	And I am on the Login page
	And I am inserting a valid User 
	And I am inserting a valid Password 
	When I press Login button
	Then I should see the My Properties page