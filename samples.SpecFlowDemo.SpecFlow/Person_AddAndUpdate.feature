Feature: Person_AddAndUpdate
	In order track person records
	As a records manager
	I need to add new persons and then update them

Scenario: Add and update a person
	Given I created and saved a person record with the following properties
		| id  | name   | date of birth |
		| 100 | Rodney | 2/20/1950     |
	When I change the person name to "Rocko"
	And I save the person
	Then the person is saved successfully
	And I can retrieve the person by ID
	And the person name was saved as "Rocko"