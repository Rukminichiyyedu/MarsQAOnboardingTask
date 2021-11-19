Feature: AddSkills
As a Seller 
I want a feature to add skills for my profile Details
So that
The people seeking for my Skills can look into details
Acceptance creteria
Seller is able to add the Skills.


	
	@mytag
Scenario: Seller add skill
Given I click on SkillTab
And I click AddNew ActionButton
And I enter 'Automation' in Skills
And I select 'Beginner' in Level
When I click Add ActionButton
Then "Automation has been added to your skills" message displayed.
	
	 

