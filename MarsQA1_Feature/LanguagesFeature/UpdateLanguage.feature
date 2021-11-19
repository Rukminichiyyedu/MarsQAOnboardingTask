Feature: UpdateLanguage
	As a Seller I want to Update my Language Details


	@mytag
Scenario: Seller updating language
	Given Seller click on Update Icon
	And I update Language as 'Hindi'
	And I select level 'Fluent'
	When click on Update button
	Then Languageupdated successfully and pop up message displayed "Hindi has been updated to your languages" on the top right of web page.
	