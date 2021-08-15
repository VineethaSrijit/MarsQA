Feature: SellerEducation
	Add seller education details

@mytag
Scenario: Add education details to seller profile
	Given I am on the Profile page
	And I click on the Education tab
	And I click on the Add New button for Education
	And I enter a College or University Name
	And I select from Country drop down
	And I select the from Title drop down
	And I enter a Degree
	And I select from Year drop down
	When I click on the Add button for education
	Then the education will be added

@mytag
Scenario: Edit education details for seller profile
	Given I am on the Profile page
	And I click on the Education tab
	And I can see education added to the profile
	And I click on the edit icon for Education
	And I edit the education details
	When I click on the Update button for education
	Then the education will be updated

@mytag
Scenario: Delete education record from seller profile
	Given I am on the Profile page
	And I click on the Education tab
	And I can see education record available for deleting
	When I click on the remove icon for Education
	Then the education will be deleted