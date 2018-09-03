Feature: Tenant Details onBoarding
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@ignore
Scenario: Enter Tenant Details Onboarding
	Given I Login to the application
	And the Tenant Details page is displayed
	And I enter a valid Date of Birth
	And I enter a valid Home Phone Number
	And I enter a valid Mobile Phone Number
	And I enter a valid Current Address
	And I select a valid file to upload
	When I Click on the Save button
	Then the Tenant details should be Saved	