Feature: Estimating
	In order to give correct estimates
	As a software developer
	I want to be able to track times

@mytag
Scenario Outline: Track Time Remaining In Hours
	Given I have entered a current estimate of <CurrEst> hours
	And I have entered <TimeTaken> hours as time taken
	When I calculate remaining time
	Then the result should be <Result> hour(s)

Examples: 
	| CurrEst | TimeTaken | Result |
	| 4       | 3         | 1      |
	| 4       | 0         | 4      |
	| 4       | 4         | 0      |
	| 4       | 5         | 0      |



