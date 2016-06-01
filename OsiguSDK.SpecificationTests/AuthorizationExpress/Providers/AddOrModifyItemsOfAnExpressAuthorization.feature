﻿Feature: Add Or Modify products Of An Express Authorization
	In order to add or modify products of an express authorization
	As a Provider
	I want to be able to add or modify products of an express authorization

Scenario: Add many valid products of an express authorization
	Given I have the provider express authorization client
	And I have entered a valid provider slug
	And I have entered a valid authorization id
	And I have entered many valid products
	And I have the request data for add items of an express authorization
	When I make the add items of an express authorization request to the endpoint
	Then the result should be ok
	And the result should be the express authorization with all products approved

Scenario: Add one valid product of an express authorization
	Given I have the provider express authorization client
	And I have entered a valid provider slug
	And I have entered a valid authorization id
	And I have entered one valid product
	And I have the request data for add items of an express authorization
	When I make the add items of an express authorization request to the endpoint
	Then the result should be ok
	And the result should be the express authorization with the product approved

Scenario: Add many valid and invalid products of an express authorization
	Given I have the provider express authorization client
	And I have entered a valid provider slug
	And I have entered a valid authorization id
	And I have entered many valid products
	And I have entered many invalid products
	And I have the request data for add items of an express authorization
	When I make the add items of an express authorization request to the endpoint
	Then the result should be ok
	And the result should be the express authorization with all valid products approved

Scenario: Add many invalid products of an express authorization
	Given I have the provider express authorization client
	And I have entered a valid provider slug
	And I have entered a valid authorization id
	And I have entered many invalid products
	And I have the request data for add items of an express authorization
	When I make the add items of an express authorization request to the endpoint
	Then the result should be ok
	And the result should be the express authorization with all products denied

Scenario: Add one invalid product of an express authorization
	Given I have the provider express authorization client
	And I have entered a valid provider slug
	And I have entered a valid authorization id
	And I have entered one invalid product
	And I have the request data for add items of an express authorization
	When I make the add items of an express authorization request to the endpoint
	Then the result should be ok
	And the result should be the express authorization with the product denied

Scenario: Add many products with an invalid product id of an express authorization
	Given I have the provider express authorization client
	And I have entered a valid provider slug
	And I have entered a valid authorization id
	And I have entered many valid products
	And I have entered one invalid product id
	And I have the request data for add items of an express authorization
	When I make the add items of an express authorization request to the endpoint
	Then the result should be bad request
	

Scenario: Add one invalid product id of an express authorization
	Given I have the provider express authorization client
	And I have entered a valid provider slug
	And I have entered a valid authorization id
	And I have entered one invalid product id
	And I have the request data for add items of an express authorization
	When I make the add items of an express authorization request to the endpoint
	Then the result should be bad request

Scenario: Add many products with one product with quantity equal to cero of an express authorization
	Given I have the provider express authorization client
	And I have entered a valid provider slug
	And I have entered a valid authorization id
	And I have entered many valid products
	And I have entered one product with quantity equal to cero
	And I have the request data for add items of an express authorization
	When I make the add items of an express authorization request to the endpoint
	Then the result should be bad request

Scenario: Add one product with quantity equal to cero of an express authorization
	Given I have the provider express authorization client
	And I have entered a valid provider slug
	And I have entered a valid authorization id
	And I have entered one product with quantity equal to cero
	And I have the request data for add items of an express authorization
	When I make the add items of an express authorization request to the endpoint
	Then the result should be bad request

Scenario: Add many products with one negative product quantity of an express authorization
	Given I have the provider express authorization client
	And I have entered a valid provider slug
	And I have entered a valid authorization id
	And I have entered many valid products
	And I have entered one product with negative quantity
	And I have the request data for add items of an express authorization
	When I make the add items of an express authorization request to the endpoint
	Then the result should be bad request

Scenario: Add one product with negative quantity of an express authorization
	Given I have the provider express authorization client
	And I have entered a valid provider slug
	And I have entered a valid authorization id
	And I have entered one product with negative quantity
	And I have the request data for add items of an express authorization
	When I make the add items of an express authorization request to the endpoint
	Then the result should be bad request

Scenario: Add many products with one product price equal to cero of an express authorization
	Given I have the provider express authorization client
	And I have entered a valid provider slug
	And I have entered a valid authorization id
	And I have entered many valid products
	And I have entered one product with price equal to cero
	And I have the request data for add items of an express authorization
	When I make the add items of an express authorization request to the endpoint
	Then the result should be bad request

Scenario: Add one product with price equal to cero of an express authorization
	Given I have the provider express authorization client
	And I have entered a valid provider slug
	And I have entered a valid authorization id
	And I have entered one product with price equal to cero
	And I have the request data for add items of an express authorization
	When I make the add items of an express authorization request to the endpoint
	Then the result should be bad request