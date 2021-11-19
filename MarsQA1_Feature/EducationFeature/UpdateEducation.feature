Feature: UpdateEducation
 As a Seller I want to Update my Education Details


	@mytag
Scenario: 02 Test Update Education succesfully
	Given Seller Update Education Country as "New Zealand"                     
	And  Seller Update University as "Auckland"
	And  Seller Update Title as "BE"
	And Seller Update Degree as "Computers"
	And Seller Update Graduation year as "2020"
	When clicks on Update button on AddEducation page
	Then Education should be updated to the profile.The Alert message "Education has been updated" should pop up on right side of the screen.