Feature: PDP
	In order to buy products
	As a user
	I want to be able to interact with details

@mytag
Scenario: User can add product to cart
	Given users opens 'Dresses' section
	And opens first product from list
	And increases quantity to 2
	When users click on add to cart buton
	And user proceeds to checkout
	Then cart summary is displayed and product is added to cart