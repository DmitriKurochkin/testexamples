Feature: Login
	In order to access my account
	As a user of the website
	I want to log into the website

@positive
Scenario: [2]Loging with valid credentials
	Given I am at the login page
	When I fill in the form
	| field    | value    |
	| LoginName | fls7    |
	| Password | fls7fls7 |
	And I click this login button
	Then I should be at user home page

@negative
Scenario: [1]Loging with invalid credentials
	Given I am at the login page
	When I fill in the form
	| field    | value    |
	| LoginName | fls100    |
	| Password | fls100fls100 |
	And I click this login button
	Then I have a login error