Feature: Budget
	In order to practice SpecFlow
	As a Software Engineer specializing in Test Automation
	I want to be able estimate my paycheck based on salary, 401k contribution, and tax rate

@BudgetValidations
Scenario: Salary is required
	Given I have navigated to the Budget page
	And the salary is not populated
	When the budget is calculated
	Then the validation message 'Salary is required.' is displayed

@BudgetValidations
Scenario: Traditional 401k is required
	Given I have navigated to the Budget page
	And the traditional 401k value is not populated
	When the budget is calculated
	Then the validation message '401k is required.' is displayed

