Feature: CalcFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: add two numbers
    Given a calculator object
    When adding 1 and 2
    Then should return 3

Scenario: subtract two numbers
    Given a calculator object
    When substracting 1 from  2
    Then should return 1


Scenario: multiply two numbers
    Given a calculator object
    When multypliing 1 with  2
    Then should return 2

Scenario: divide two numbers
    Given a calculator object
    When divide 2 with  1
    Then should return 2