Feature: SearchTests
	Tests for searching restaurants by postcode

Scenario: Search for restaurants in an area
	Given I want food in "AR51 1AA"
    When I search for restaurants
    Then I should see some restaurants in "AR51 1AA"

Scenario: Search with invalid postcode
	Given I want see restaurants in "AR51"
	When I search for restaurant
	Then I sould see validation message


Scenario Outline: Making an order
	Given I want food in "AR51 1AA"
	When I search for restaurants
	And I select first restaurant
	And I add items to basket
	And I proceed with checkout
	And I login with "<email>" and "<password>"
	And I fill in delivery details with data:
	| Key     | Value       |
	| mobile  | 02890712345 |
	| address | new Street  |
	| city    | london      |

	And I proceed to confirmation time and date
	And I choose pay with cash
	Then I see confirmation message
	Examples: 
	| email                    | password |
	| test@testforhometask.com | Q1w2e3r4 |