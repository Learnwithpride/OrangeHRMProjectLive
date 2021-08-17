Feature: AddSkill
	In order to Login the Website
	And add Skill successful
	I will follow all steps

@mytag
Scenario: Add Skill Admin
	Given the user navigate to website "https://opensource-demo.orangehrmlive.com/index.php/auth/login"
	#Given that I navigate to "https://opensource-demo.orangehrmlive.com/"
	And the user enter Username
	And the user enter Password
	And the user click on Login
	#And I CLick on Admin 
    And the user clicks on admin tab
	And I Click on Qualifications 
	And I  Click on Skills
	And I Click on Add
	And I enter the Skill Name "Lucas"
	And I enter Description 
	When I clicks on the Save button
	Then I Confirm the Skill as been succesfully added
	And I Tick the checkbox beside the skill you created
    When I Click on Delete
	Then I should confirm Skill as been successfully deleted 