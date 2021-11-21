Feature: SellerEducation
	Simple calculator for adding two numbers

As a Seller 
I want a feature to add Education for my profile Details
So that
The people seeking for my Education can look into details
Acceptance creteria
Seller is able to add the Education Details.

@mytag
Scenario: 01 Test Adding Education succesfully
	Given Seller enter Education Country as "New Zealand"                     
	And  Seller enter University as "Auckland"
	And  Seller enter Title as "B.Tech"
	And Seller enter Degree as "Computers"
	And Seller enter Graduation year as "2021"
	When Seller clicks on Add button on AddEducation page
	Then Education should be added to the profile.The Alert message "Education has been added" should pop up on right side of the screen.

	@mytag
Scenario: 02 Test Update Education succesfully
	Given Seller Update Education Country as "New Zealand"                     
	And  Seller Update University as "Auckland"
	And  Seller Update Title as "BE"
	And Seller Update Degree as "Computers"
	And Seller Update Graduation year as "2020"
	When clicks on Update button on AddEducation page
	Then Education should be updated to the profile.The Alert message "Education has been updated" should pop up on right side of the screen.

	
@mytag
Scenario: 03 Test Delete Education succesfully
	Given Seller Delete Education Country as "New Zealand"                     
	And  Seller Delete University as "Auckland"
	And  Seller Delete Title as "BE"
	And Seller Delete Degree as "Computers"
	And Seller Delete Graduation year as "2020"
	When clicks on Delete button on AddEducation page
	Then Education should be delete to the profile.The Alert message "Education entery successfully removed" should pop up on right side of the screen.


	