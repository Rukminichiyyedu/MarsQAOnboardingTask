Feature: AddLanguage
As a Seller 
I want a feature to add Language for my profile Details
So that
The people seeking for my Language can look into details
Acceptance creteria
Seller is able to add the Language Details.

@mytag
Scenario: Seller adding language
	Given Seller select language tab
	And Seller click on Add button
	And Seller enter Language as 'English'
	And select level 'Basic'
	When click on Add button
	Then Language added successfully and pop up message displayed "English has been added to your languages" on the top right of web page.