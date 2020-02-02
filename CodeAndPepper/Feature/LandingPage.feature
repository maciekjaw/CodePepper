Feature: LandingPage

@smoke
Scenario: Landing Page
		Given I open application
		Then I'm on correct "https://pluto-customer-web-app-staging.herokuapp.com/tailored-annual-or-single" page

@ui @smoke
Scenario: Going back to landing page
		Given I open application
		Then I click Single Trip cover
		Then I click burger menu
		Then I click return home
		Then I see "Travel cover for the travel lover" string
