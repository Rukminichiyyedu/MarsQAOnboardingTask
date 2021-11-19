Feature: DeleteLanguage
	As a Seller I want to Delete all my Exsisting Education Details
	
	@mytag
Scenario: Seller deleting language
	Given I select 'Hindi' language to delete
	Then Language is deleted successfully and pop up message displayed "Hindi has been deleted from your languages" on the top right of web page.