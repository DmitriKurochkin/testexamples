Feature: CheckPaginationOnTheMainPage
	

@positive @pagination
Scenario: Logon as user and check all pages of users
		
	Given I am at the start page
	When I fill into the following form
	| field    | value    |
	| LoginName | fls7    |
	| Password | fls7fls7 |
	And I click login button
	Then I should be at home page	
	And I click paginators, all that are there