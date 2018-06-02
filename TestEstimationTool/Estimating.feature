Feature: Estimating
	In order to give correct estimates
	As a software developer
	I want to be able to track times

@mytag
Scenario: Track Time Remaining
	Given I have entered a current estimate of 4 hours
	And I have entered 3 hours as time taken
	When I calculate remaining time
	Then the result should be 1 hour
