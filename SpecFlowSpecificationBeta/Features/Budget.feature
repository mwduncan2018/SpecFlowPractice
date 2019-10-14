Feature: Budget
	In order to practice SpecFlow
	As a Software Engineer specializing in Test Automation
	I want to be able estimate my paycheck based on salary, 401k contribution, and tax rate

@BudgetValidations
Scenario: Salary is required
	Given I have navigated to the budget page
	And the salary is not populated
	When the budget is calculated
	Then the validation message Salary is required. is displayed

@BudgetValidations
Scenario: Traditional 401k is required
	Given I have navigated to the budget page
	And the traditional 401k is not populated
	When the budget is calculated
	Then the validation message 401k is required. is displayed

@BudgetValidations
Scenario: Tax rate is required
	Given I have navigated to the budget page
	And the tax rate is not populated
	When the budget is calculated
	Then the validation message Tax Rate is required. is displayed

@SmokeTest
Scenario: Basic smoke for Budget page
	Given I have navigated to the budget page
	And the salary is set to 100000
	And the traditional 401k is set to 19000
	And the tax rate is set to 30
	When the budget is calculated
	Then no validation messages should be displayed
	And salary by year should be 100000.00
	And 401k by year should be 19000.00
	And taxes by year should be 24300.00
	And cash by year should be 56700.00

@CustomConversionOfAStepParameter
Scenario: Custom conversion for from Euro to Dollar
	Given I have navigated to the budget page
	And I have entered 150000 Euros
	And the traditional 401k is not populated
	And the tax rate is set to 30
	When the budget is calculated
	Then salary by year should be 165000.00
	And cash by year should be 115500.00