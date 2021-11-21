Feature: SellerLanguageDetails
As a Seller 
I want a feature to add Language for my profile Details
So that
The people seeking for my Language can look into details
Acceptance creteria
Seller is able to add/update the Language Details.

@mytag
Scenario: Seller adding language
	Given Seller select language tab
	And Seller click on Add button
	And Seller enter Language as 'English'
	And select level 'Basic'
	When click on Add button
	Then Language added successfully and pop up message displayed "English has been added to your languages" on the top right of web page.

	@mytag
Scenario: Seller andupdating language
	Given Seller click on Update Icon
	And I update Language as 'Hindi'
	And I select level 'Fluent'
	When click on Update button
	Then Languageupdated successfully and pop up message displayed "Hindi has been updated to your languages" on the top right of web page.

	@mytag
Scenario: Seller delete language
Given I click on languageTab 
When I click on Delete button
Then Language deleted successfully and pop up message displayed "Hindi has been deleted from your languages" on the top right of web page.

