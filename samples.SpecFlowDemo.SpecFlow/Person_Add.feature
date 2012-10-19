Feature: Person_Add
	In order track person records
	As a records manager
	I need to add new persons

Scenario: Add a person
	Given I have a new person record with the following properties
		| id  | name   | date of birth |
		| 100 | Rodney | 2/20/1950     |
	When I save the person
	Then the person is saved successfully
	And I can retrieve the person by ID
