Feature: SellerCertificate
	Add seller certificate details

@mytag
Scenario: Add new certificate to seller profile
	Given I am on the Profile page
	And I click on the Certifications tab
	And I click on the Add New button
	And I enter a Certificate or Award
	And I enter Certified From
	And I select the Year from drop down
	When I click on the Add button for certification
	Then the certification will be added

@mytag
Scenario: Edit certificate in the seller profile
	Given I am on the Profile page
	And I click on the Certifications tab
	And I can see certificates in the profile
	And I click on the Certificate Edit icon
	And I edit certificate details
	When I click on the certificate Update button
	Then the certificate will be updated

@mytag
Scenario: Delete certificate from the seller profile
	Given I am on the Profile page
	And I click on the Certifications tab
	And I can see certificates in the profile
	When I click on the Certificate delete icon 
	Then the certificate will be deleted