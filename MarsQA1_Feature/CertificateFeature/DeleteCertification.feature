Feature: DeleteCertification
	As a Seller I want to delete my Exsisting Certification Details



	@mytag
Scenario: Seller deleting Certification
	Given I select Certification tab 
	Given I select 'ISTQBCertificate' Certificate 
	When I click on delete button
	Then Certification details are deleted successfully and a message should display saying "ISTQBCertificate has been deleted from your certification"