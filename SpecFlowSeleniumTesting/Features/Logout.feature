Feature: Logout
	In order to test the logout feature
	As a user
	I want to log out of the site

Background: 
	Given I have login as test user
	| field    | value    |
	| LoginName | fls7    |
	| Password | fls7fls7 |

@positive @logout @loginpage
Scenario: Login with valid credentials and logout successfull
	Given I am at the home page
	When I click logout button
	Then I am at the login page
