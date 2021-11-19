Feature: UpdateCertification
As a Seller 
I want to edit the details of my certificate.

	@mytag
Scenario: Seller updating Certification
	Given I select Certification tab 
	Given I click on Update button
	And Enter 'ISTQBCertificate' in Certificate/Award field
	And Enter 'Testing' in Certified From field
	And Select '2020' in Year of Graduation field.
	When Click on 'Update' action button.
	Then Certification details should updated successfully and a message  "ISTQBCertificate has been updated to your certification" should display on top of your screen.