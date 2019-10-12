Feature: MessageBoard
	In order to keep a history of games checked
	As a user of the Ozark website
	I want to be able to post info of games checked to the message board

@SmokeTest
Scenario: Modern Warfare 3 submitted to the message board
	Given the web application is at the Home page
	And the Modern Warfare Three checkbox is checked
	When the Submit Games button is clicked
	Then the message board displays 'Modern Warfare 3'

@ExecutingStepsWithinSteps
Scenario: All games are submitted to the message board
	Given the web application is at the Home page
	And all games are checked
	When the Submit Games button is clicked
	Then all games appear in the messageboard
	And the message board displays 'All games are checked'
		