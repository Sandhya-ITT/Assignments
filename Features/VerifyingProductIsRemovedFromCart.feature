Feature: Verifying product is removed from cart

Scenario: Remove a product from cart
	Given User is on login page
	When User enters "sandhyaellango@gmail.com" and "sandhya@111"
	When User navigates to HomePage
	And User searches for "iphone 11"
	And User adds the product to cart
	And User removes the product from cart
	Then The product should be successfully removed from cart