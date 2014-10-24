Feature: Edit user profile
	In order to edit account data
	As a user of the website
	I want to log into the website
	And click on "Edit" button
	And edit name, surname and email of the user
	And save changes

Background:
	Given I have login as user
	| field    | value    |
	| LoginName | fls7    |
	| Password | fls7fls7 |
	

@positive
Scenario: Logging in with valid credentials and try to edit some profile

	Given I am at the home page
	When I should try to edit first user profile

         | field     | value               |
         | FirstName | TestFirstName       |
         | LastName  | TestLastName        |
         | Email     | testmvc@testmvc.com |

	And I submit changes
	Then Edited form will be saved

		 | field     | value               |
         | FirstName | TestFirstName       |
         | LastName  | TestLastName        |
         | Email     | testmvc@testmvc.com |