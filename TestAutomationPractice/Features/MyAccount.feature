Feature: MyAccount
	In order to menage personal information
	As a user
	I want to be able to use sign in functionality

@mytag
Scenario: User can sign in
	Given user opens sign in page
	And enters correct credentials
	When user submits the login form
	Then user will be logged in