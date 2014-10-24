Feature: SelectLanguages
	In order to change the language
	On the login page



@positive @languages
Scenario: [1]Try to select languages on the login page
	Given I go to the login page
	And Language on this page is 'Ru'
	When I change the language to 'En'
	Then Language on the login page is changed to english
	When I change the language to 'Ru'
	Then Language on the login page is changed to russian

Scenario: [2]Login on the main and try to select languages on the page
	
	Given I have login as below user
		| field     | value    |
		| LoginName | fls7     |
		| Password  | fls7fls7 |
	And Language on this page is 'Ru'
	When I change the language to 'En'
	Then Language on this page is changed to english
	When I change the language to 'Ru'
	Then Language on this page is changed to russian

Scenario: [3]Login to the site and try to select languages on the edit my profile page

	Given I go to the edit my profile page
	And Language on this page is 'Ru'
	When I change the language to 'En'
	Then Language on the edit profile page is changed to english
	When I change the language to 'Ru'
	Then Language on the edit profile page is changed to russian

