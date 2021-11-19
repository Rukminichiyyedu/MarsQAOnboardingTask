Feature: AddEducation
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

	

	
	
