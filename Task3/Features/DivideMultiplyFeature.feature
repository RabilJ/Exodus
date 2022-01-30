Feature: DivideMultiplyFeature
	Simple calculator for multiplying or dividing two numbers

Background: 
	Given the first number is 10
	And the second number is 2
	
Scenario: Multiply two numbers
	When the two numbers are multiplied
	Then the result should be 20
	
Scenario: Divide two numbers
	When the two numbers are divided
	Then the result should be 5