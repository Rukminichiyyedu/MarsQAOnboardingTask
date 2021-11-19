

Feature: LoginFeature
    In order to go to my website
	As a seller 
	I want to Login to the website
	Success Criteria
	User should Login to the site

	
@mytag
  Scenario: login User as  Seller
    Given I navigate to application
	And I enter username and password
		| UserName                       | Password |
		| rukku.chiyyedu970@gmail.com    | Testing123    |
	And I click login
	Then I should see user logged in to the application

    
