Feature: UpdateSkills
	As a Seller I want to Update my Skills 

	Scenario: Seller update skill
Given I click on SkillTab for update
And I click on Pen icon
And I update 'Java' in Skills
And I select 'Intermediate' Level
When I click Update ActionButton
Then "Java has been updated to your skills" message displayed

	
	 