Feature: AddSubFeature
	Simple calculator for adding or subtracting two numbers

Scenario Template: Add two numbers
	Given the first number is <firstNum>
	And the second number is <secondNum>
	When the two numbers are added
	Then the result should be <result>
	
	Examples:
	| firstNum | secondNum | result |
	| 5        | 6         | 11     |
	| 1        | -5        | -4     | 
 

Scenario: Subtract two numbers
	Given the first number is 3
	And the second number is 6
	When the two numbers are subtracted
	Then the result should be -3