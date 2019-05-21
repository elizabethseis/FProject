Feature: AmazonTest


@mytag
Scenario: Add two products
	Given Launch Chrome
	And Login into the amazon
	And Search the first product 
	Then compare the prices
	And  add to the cart the first product
	Then search the second product
	Then add to the cart the second product
	And  validate the amount of products
	And clean the cart and close the browser
