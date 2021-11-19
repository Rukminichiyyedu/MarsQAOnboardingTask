Feature: AddCertification
As a Seller 
I want a feature to add Certifications for my profile Details
So that
The people seeking for my Certificates can look into details
Acceptance creteria
Seller is able to add the Certificate Details.

@mytag
Scenario: Seller adding Certification
	Given I select Certification tab
	And I click on AddNew button.
	And I enter 'TestingCertificate' in Certificate/Award field
	And I enter 'Microsoft' in Certified  field
	And  I select '2012' in Year of Graduation field
	When I click on 'ADD'  button 
	Then Certification details should add successfully and a message "TestingCertificate has been added to your certification" should display on top of your screen.


	
	