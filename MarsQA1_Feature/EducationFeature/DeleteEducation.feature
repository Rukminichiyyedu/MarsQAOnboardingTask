Feature: DeleteEducation
	As a Seller I want to Delete all my Exsisting Education Details.

@mytag
Scenario: 03 Test Delete Education succesfully
	Given Seller Delete Education Country as "New Zealand"                     
	And  Seller Delete University as "Auckland"
	And  Seller Delete Title as "BE"
	And Seller Delete Degree as "Computers"
	And Seller Delete Graduation year as "2020"
	When clicks on Delete button on AddEducation page
	Then Education should be delete to the profile.The Alert message "Education entery successfully removed" should pop up on right side of the screen.
