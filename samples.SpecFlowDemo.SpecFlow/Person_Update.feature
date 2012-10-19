Feature: Person_Update
	In order track person records
	As a records manager
	I need to update existing persons

Scenario: Update a person
	Given I have an existing person record
	When I change the person name to "Rocko"
	And I save the person
	Then the person is saved successfully
	And I can retrieve the person by ID
	And the person name was saved as "Rocko"
