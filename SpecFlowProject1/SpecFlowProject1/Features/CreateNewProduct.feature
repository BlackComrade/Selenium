Feature: Adding a product
	As a user 
	I need to create a new product and check the correctness of its creation 


Scenario: New Product
	Given I open "http://localhost:5000/" url
	And I login
	And I click on button All Product
	And I click on button Create New
	And I enter info of product and create it 
	When I click on button Edit of the created product 
	Then Check info new product and end test