Feature: Verifying login functionality

@mytag
Scenario: Login to flipkart application
	Given User is on login page
	When User enters "sandhyaellango@gmail.com" and "sandhya@111"
	Then the user should be successfully logged in