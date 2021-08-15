Feature: SellerLanguages
    Add, edit and delete seller languages

@mytag
Scenario: Add new language to seller profile
Given I am on the Profile page
And I click on the Languages tab
And I click on Add New button
And I enter a string to Language textbox
And I choose from Language Level dropbox
When I click on the Add button
Then the language will be added

@mytag
Scenario: Edit language in the seller profile
Given I am on the Profile page
And I click on the Languages tab
And I can see a language in the list
And I click on the Edit icon
And the language row can be edited
When I click on the language Update button
Then the language row will be updated

@mytag
Scenario: Delete language in the seller profile
Given I am on the Profile page
And I click on the Languages tab
And I can see a language in the list
When I click on the delete icon
Then the language row will be deleted