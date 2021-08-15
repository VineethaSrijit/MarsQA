Feature: SellerSkills
    Add, edit and delete seller skills

@mytag
Scenario: Add new skill to seller profile
Given I am on the Profile page
And I click on the Skills tab
And I click on Add New button
And I enter a string to Skills textbox
And I choose from Skill Level dropbox
When I click on the Add button
Then the skill will be added

@mytag
Scenario: Edit skill in the seller profile
Given I am on the Profile page
And I click on the Skills tab
And I can see a skill in the list
And I click on the Edit icon
And the skill row can be edited
When I click on the Update button
Then the skill row will be updated

@mytag
Scenario: Delete skill in the seller profile
Given I am on the Profile page
And I click on the Skills tab
And I can see a skill in the list
When I click on the delete icon
Then the skill row will be deleted