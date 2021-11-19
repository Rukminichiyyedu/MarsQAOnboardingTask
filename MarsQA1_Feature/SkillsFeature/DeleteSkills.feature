Feature: DeleteSkills
	As a Seller I want to Delete my exsisting Skills Details


	 
@mytag
Scenario: Seller delete skill
Given I click on SkillTab for delete
When I click on cross icon
Then "Java has been deleted" message is displayed
