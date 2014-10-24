Feature: ManageMyProfile


@negative @profile_management
Scenario: [1]Try to edit my profile without filling one mandatory field

	Given I have login as below testuser
		| field     | value    |
		| LoginName | fls9     |
		| Password  | fls9fls9 |
	And I go to manage my profile
	When I should try to edit my profile without password
		| field     | value        |
		| LoginName | fls9 		   |
		| Password  |              |
		| Email     | fls9@fls.com |
	Then I will get a password validation error
	When I should try to edit my profile without email
		| field     | value        |
		| LoginName | fls9 		   |
		| Password  | fls9fls9     |
		| Email     |              |
	Then I will get an email validation error


@positive @profile_management
Scenario: [2]Edit my profile
	Given I am at the manage profile page
	When I should try to edit my profile correctly
		| field     | value        |
		| LoginName | fls9		   |
		| Password  | fls9fls9     |
		| Email     | fls9@fls.com |
	Then the result will be saved and I will be redirected to the home page