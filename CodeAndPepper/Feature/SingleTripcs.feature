Feature: SingleTripcs


@UI @smoke
Scenario: Single Trip
		Given I open application
		Then I click Single Trip cover
		Then I'm on correct "https://pluto-customer-web-app-staging.herokuapp.com/single-annual" page