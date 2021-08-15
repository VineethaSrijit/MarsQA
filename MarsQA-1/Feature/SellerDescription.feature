Feature: SellerDescription
	Edit description for the seller

@mytag
Scenario: Edit seller description
	Given I am on the profile page
	And I click on the description edit icon
	And I edit the description
	When I click on the Save button
	Then description should be saved