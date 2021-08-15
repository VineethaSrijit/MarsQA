Feature: SellerProfileDetails
	Add seller profile details

@mytag
Scenario: Add first and last name for seller
	Given I am on the profile page
	And I click on the expand button for seller name
	And I enter the first name of seller
	And I enter the last name of seller
	When I click on the save button
	Then name should be saved and displayed

@mytag
Scenario: Add seller availibilty
	Given I am on the profile page
	And I click on the availibilty edit icon
	When I choose from the drop down
	Then availability will be added

@mytag
Scenario: Choose hours available for Seller
	Given I am on the profile page
	And I click on the hours edit icon
	When I choose from the drop down
	Then hours will be added

@mytag
Scenario: Choose earn taget for seller
	Given I am on the profile page
	And I click on the earn target edit icon
	When I choose from the drop down
	Then earn target will be added