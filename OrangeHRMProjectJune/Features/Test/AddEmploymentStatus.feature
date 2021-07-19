Feature: AddEmploymentStatus
	

@mytag
Scenario: Add Employmnent Status
	Given I navigate to "https://opensource-demo.orangehrmlive.com/2"
	And I enter the admin username "Admin"
	And I enter the admin password "admin123"
	And I click on the login button
	And I click on Admin
	And I click on Job
	And I click on Employment Status
	And I click on Add
	And I enter Name "contractor"
	When I click on Save
	Then I confirm it has been successfully added
	And I tick the checkbox beside the newly created employee
	And I click on delete
	When I click on Okay
	Then I confirm Employment status has been successfully deleted
