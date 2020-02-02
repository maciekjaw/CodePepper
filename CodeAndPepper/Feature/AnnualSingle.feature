Feature: AnnualSingle

@ui @smoke
Scenario: Next Btn Availability
		Given I open application
		Then I click Single Trip cover
		Then I check if Next button is disable

@ui @smoke
Scenario: Inputing country and Next Btn availability
		Given I open application
		Then I click Single Trip cover
		Then I type country
		Then I check if Next button is not disable