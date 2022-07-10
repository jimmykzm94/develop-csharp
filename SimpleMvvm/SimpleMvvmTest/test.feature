Feature: Test simple MVVM

Scenario: Initial
	Given I launch the application
	Then label will be:
	"""
	Clicked 0 times
	"""

Scenario: Button clicked one time
	Given I launch the application
	When I press button 1 times
	Then label will be:
	"""
	Clicked 1 times
	"""

Scenario: Button clicked two time
	Given I launch the application
	When I press button 2 times
	Then label will be:
	"""
	Clicked 2 times
	"""