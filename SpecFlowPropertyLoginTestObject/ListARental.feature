Feature: Owners_List_A_Rental
	

Scenario: Owner_List A Rental
	Given I Login to the application successfully
	And I Navigate to the Owners menu and Rental Listings and Applications menu
	And I Click on the List A Rental button
	And I Select a property to list the rental
	And I Enter a Title
	And I Enter the moving cost
	And I Enter the description
	And I Enter the target rent
	And I Enter the Furnishing
	And I Enter the Available Date
	And I Enter the Ideal Tenant
	And I Enter the Occupants Count 
	And I select a value in the Pets Allowed dropdown
	And I click on the Choose Files button to upload a photo of the Rental property
	When I click on the Save button 
	Then the property should be listed and should be available in the listing
