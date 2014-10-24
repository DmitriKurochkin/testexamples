Feature: Registration
	In order to create an account
	As a user of the website
	I want to register on the website
	http://localhost:6333/account/register

@negative @registration
Scenario: [1]I want to register a new user witout filling login name field
	Given I am at the register page
	When I fill in the following form
		| field                | value                      |
		| LoginName            |                            |
		| Email                | dmitry.kurochkin@gmail.com |
		| Password             | fls7fls7                   |
		| PasswordConfirmation | fls7fls7                   |
	And I click to the register button
	Then I should have an regisration error

@negative @registration
Scenario: [2]I want to register a new user witout filling email field
	Given I am at the register page
	When I fill in the following form
		| field                | value                      |
		| LoginName            | fls7                       |
		| Email                |                            |
		| Password             | fls7fls7                   |
		| PasswordConfirmation | fls7fls7                   |
	And I click to the register button
	Then I should have an regisration error

@negative @registration
Scenario: [3]I want to register a new user witout filling password field
	Given I am at the register page
	When I fill in the following form
		| field                | value                      |
		| LoginName            | fls7                       |
		| Email                | dmitry.kurochkin@gmail.com |
		| Password             |                            |
		| PasswordConfirmation | fls7fls7                   |
	And I click to the register button
	Then I should have an regisration error

@negative @registration
Scenario: [4]I want to register a new user witout filling password confirmation field
	Given I am at the register page
	When I fill in the following form
		| field                | value                      |
		| LoginName            | fls7                       |
		| Email                | dmitry.kurochkin@gmail.com |
		| Password             | fls7fls7                   |
		| PasswordConfirmation |                            |
	And I click to the register button
	Then I should have an regisration error

@positive @registration
Scenario: [5]I want to register a new user
	Given I am at the register page
	When I fill in the registration form
	#LoginName field here is with value [fls + random number of (10000)]
		| field                | value                     |
		| LoginName            | fls                       |
		| Email                | dmitry.kurochkin@gmail.com|
		| Password             | flsfls                    |
		| PasswordConfirmation | flsfls                    |
	And I click to the register button
	Then I should be at the home page