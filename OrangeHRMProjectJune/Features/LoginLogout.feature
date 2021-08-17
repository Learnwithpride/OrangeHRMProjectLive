Feature: Login/Logout 
	In order to Login the Website 
	And to Logout successfully
	I will need to Login with valid credentials

@mytag
Scenario: Valid Login and Logout
	Given the user navigate to website "https://opensource-demo.orangehrmlive.com/index.php/auth/login"
	And the user enter Username
	And the user enter Password
	And the user click on Login
	And the confirm successfull Logged in 
	And the click on Profile Picture
	When the click on Logout
	And I click on logout
	Then I should successfully be Logged Out