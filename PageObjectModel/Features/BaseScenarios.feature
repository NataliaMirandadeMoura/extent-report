Feature: BaseScenarios
	These scenarios can be used in any projects

Background: 
Given I navigate to the homepage

@Chrome
Scenario: 1. Validate the title of a website
Then I see the page title contains "Wiki"


@Chrome
Scenario: 2. Validate existence of multiple texts in PageSource
Then I see
| expectedText          |
| The Free Encyclopedia |
| Русский               |
| Français              |
| Deutsch               |


