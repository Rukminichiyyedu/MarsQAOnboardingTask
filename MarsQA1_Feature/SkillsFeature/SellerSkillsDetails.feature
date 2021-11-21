Feature: Seller Skills Details
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

@mytag
	Scenario: Seller andupdate skill
Given I click on SkillTab for update
And I click on Pen icon
And I update 'Java' in Skills
And I select 'Intermediate' Level
When I click Update ActionButton
Then "Java has been updated to your skills" message displayed	
	 
@mytag
Scenario: Seller delete skill
Given I click on Skill Tab 
When I click on deletebutton
Then Skill details are deleted successfully and message displayed "Java has been deleted".



