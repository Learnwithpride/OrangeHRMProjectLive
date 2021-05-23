Feature: AddDeletePayGrades
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add And Delete Paygrade
	Given that I navigate to "https://opensource-demo.orangehrmlive.com/"
	And the user enter admin username "Admin"
	And the user enter admin password "admin123"
	And the user clicks the orange login button
	And the user clicks on admin tab
	And the user clicks on the job drop down list
	And the user clicks on Pay Grades
	And the user clicks on the green Add tab
	And the user enters name "Grade 6"
	And the user clicks on the save button
	And the user clicks on the Add button
	And the user enters currency details "USD - United States Dollar"
	When the user clicks on save
	Then user paygrade should be added successfully
	When the user clicks on admin tab
	And the user clicks on the job drop down list
	And the user clicks on Pay Grades
	And the user click in the radio button for fefe
	And the user clicks on the red Delete tab
	When the user clicks on the green OK button
	#Then the pay grade should be successfully deleted
	