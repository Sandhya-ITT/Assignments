Feature: Verifying cart functionality

@mytag
Scenario: search for a product and add to cart
	Given User is on login page
	When User enters "sandhyaellango@gmail.com" and "sandhya@111"
	When User navigates to HomePage
	And User searches for "iphone 11"
	And User adds the product to cart
	Then Product should be added to cart