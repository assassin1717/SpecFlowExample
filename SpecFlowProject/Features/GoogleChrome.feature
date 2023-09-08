Feature: Google Chrome test

@smoke
Scenario: Search in browser
	Given I am in Google home page
	And I accept the cookies
	When I type in "<searchText>"
	When I click search button
	And I should be redirected to the search page
	Then I close the browser

Examples:
	| searchText |
	| abola      |
	| facebook   |