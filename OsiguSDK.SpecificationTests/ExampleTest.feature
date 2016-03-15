﻿Feature: ExampleTest
	In order to validate the REST service
	As SDK client
	I want to be able to request an endpoint

Scenario: Generic request to Endpoint
	Given I am a valid user
	And I have the values to my request
	When I request the endpoint
	Then the result should the expected


Scenario Outline: Outline example
	Given I am a valid user
	And I have the values <Values> to my request 
	When I request the endpoint
	Then the possible results should be the expected
	| TestId   | Value   | ExpectedResult   |
	| <TestId> | <Value> | <ExpectedResult> |

Scenarios: 
	| TestId | Value | Values | ExpectedResult |
	| 1      | asdf  | 123    | OK             |
	| 2      | 123   | 234    | BadRequest     |