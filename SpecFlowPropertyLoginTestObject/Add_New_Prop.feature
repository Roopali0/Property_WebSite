Feature: Add_New_Prop

@ignore
Scenario: Create New Property
	Given I have logged in as a valid user
	And I Click on Owners menu 
	And  I Click on the Properties link in the dropdown menu displayed
	When I Click on the Add New Property button
	Then I should see the property details pagge 
@ignore
Scenario: Enter Valid Property Details
	Given the Property Details page is open
	And I Provide a valid Property Name
	And I Select a valid Property Type
	And I Provide a Valid Address
	And I Provide a valid Description
	And I Provide a valid Target Rent
	And I select a valid Rent Type
	And I  Provide a valid Land Area
	And I Provide a valid Floor Area
	And I Provide a valid data for Bedrooms
	And I Provide a valid data for Bathrooms
	And I Provide a valid data for CarParks
	And I Provide a valid data for Year Built
	And I Select a photo to upload
	And I Click on the Next button
	And I see the Finance Details Page 
	And the Finance Details page is open
	And I enter a valid Purchase Price
	And I Provide a valid Mortgage value 
	And I Provide a valid Home Value
	And I Select  a valid Home Value Type from the dropdown
	And I Click on the Add Repayments option
	And I Provide a valid Amount for the Repayment
	And I Select a valid Frequency for Repayment
	And I Provide a valid Start Date for Repayment
	And I Provide a valid End Date for Repaymet
	And I Click on the Add Expense option
	And I Provide a valid Amount for the Expense
	And I Provide a valid Description for the Expense
	And I Provide a valid Date for the Expense
	When I Click on the Next button to provide Tenant details
	Then I should see the Tenant Details page
@ignore
Scenario: Enter Valid Tenant Details
Given I am on the Tenant Details page
	And I Provide the Tenant Email
	And I Select option from Is Main Tenant dropdown
	And I Provide a valid First Name
	And I Provide a valid Last Name
	And I Provide a valid Start Date
	And I Provide a valid End Date
	And I Provide a valid Rent Amount 
	And I Provide a valid Payment Frequency 
	And I Provide a valid Payment start date 
	And I Provide a valid Payment due date 
	And I Click on the Add New Liability option
	And I Select a Liability Name from the dropdown
	And I Provide a valid amount for the corresponding Liability in the the amount field 
	When I Click on the Save button to create a New Property
	Then the newly created property should be available