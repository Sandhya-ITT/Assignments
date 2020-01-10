Feature: Adding multiple products

@mytag
Scenario Outline: search for multiple products and add to cart
	Given User is on login page
	When User enters "sandhyaellango@gmail.com" and "sandhya@111"
	When User navigates to HomePage
	When User enters "<products>" in the search field
	And User removes the product from cart
	Then Product should be added to cart

	Examples:
		| products    |
		| iphone11    |
		| samsung M30 |