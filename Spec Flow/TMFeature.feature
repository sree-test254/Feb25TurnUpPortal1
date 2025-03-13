Feature: TMFeature

As a TurnUp portal admin user
I would like to create,edit and delete time and materials records
so that I can manage employees time and materials successfully.

@regression 
Scenario: create time record with valid data
	Given I logged into TurnUp portal successfully
	When I Navigate to Time and Materials page
	When I create a time record
	Then record created successfully
