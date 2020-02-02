Feature: AnnualSingle
	As a user
	I want to be able to add my partner

@ui @smoke
Scenario: Next Btn AAvailability
		Given I open application
		Then I click Single Trip cover
		Then I check if Next button is disable

@ui @smoke
Scenario: Inputing country and Next Btn availability
		Given I open application
		Then I click Single Trip cover
		Then I type country
		Then I check if Next button is not disable