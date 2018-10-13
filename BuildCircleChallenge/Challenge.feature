Feature: Search for Build Circle
	In order to search for Build Circle in Google
	As a user with internet
	I want to see the result outcomes of my search

@home
Scenario: Search Build Circle in Google's Search bar
	Given I have opened Google page
	And I have entered Build Circle on the Search bar
	When I press Search button
	Then a new page showing the search results should appear
