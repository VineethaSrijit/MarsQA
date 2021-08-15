Feature: Login to the Mars website
	
@mytag
Scenario: Login to website
	Given I go to the website
	And I click on the sign in button
	And I enter the login details
	When I click on the login button
	Then I am taken to the home page

