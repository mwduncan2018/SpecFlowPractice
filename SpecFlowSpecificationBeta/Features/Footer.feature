Feature: Footer
	In order to get familiar with SpecFlow
	As myself
	I want to verify the footer on the SpecFlowWebSiteProject page

@SmokeTest
Scenario: My name should be in the footer
	Given I have navigated to the SpecFlowWebSiteProject website
	Then the footer should contain the name 'Michael Duncan'

Scenario: The current date should be in the footer
	Given the web application is at the Home page
	Then the footer should contain the current year

Scenario: George Carlin should not be in the footer
	Given the web application is at the Home page
	Then the footer should not contain the name 'George Carlin'