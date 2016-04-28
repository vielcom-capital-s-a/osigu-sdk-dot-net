﻿Feature: Get A Claim As Insurer
	In order to obtain the of a Claim
	As Insurer
	I want to be able to view the status of a claim

Scenario: Authentication Error
	Given I have the provider claims client
	And I have the insurer claims client
	And I have the insurer authorizations client
	And I have the queue client 
	And I have the request data for a new authorization
	When I make the new authorization request to the endpoint
	And the create a claim request with repeated products
	And I request the create a claim endpoint
	And I delay the check status request
	And I request the check claim status endpoint
	Given I have the insurer claims client without authorization
	When I request the get a claim endpoint as insurer
	Then the result should be unauthorized

Scenario: Slug Does Not Exists
	Given I have the provider claims client
	And I have the insurer authorizations client
	And I have the queue client 
	And I have the request data for a new authorization
	When I make the new authorization request to the endpoint
	And the create a claim request with repeated products
	And I request the create a claim endpoint
	And I delay the check status request
	And I request the check claim status endpoint
	Given I have the insurer claim client without valid slug
	When I request the get a claim endpoint as insurer
	Then the result should be no permission

Scenario: Invalid Claim Id
	Given I have the provider claims client
	And I have the insurer claims client
	And I have the insurer authorizations client
	And I have the queue client 
	And I have the request data for a new authorization
	When I make the new authorization request to the endpoint
	And the create a claim request with repeated products
	And I request the create a claim endpoint
	And I delay the check status request
	And I request the check claim status endpoint
	And I request the get a claim endpoint as insurer with an invalid claim id
	Then the result should be not existing 

Scenario: Successfully Get Claim
	Given I have the provider claims client
	And I have the insurer claims client
	And I have the insurer authorizations client
	And I have the queue client 
	And I have the request data for a new authorization
	When I make the new authorization request to the endpoint
	And the create a claim request
	And I request the create a claim endpoint
	And I delay the check status request
	And I request the check claim status endpoint
	And I request the get a claim endpoint as insurer
	Then the result should be ok 
	And the insurer claim should not be null
	And the insurer claim should have the needed values