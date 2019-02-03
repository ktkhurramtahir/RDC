Feature: Rental_Case_Registration_without_Ejari
	

@mytag
Scenario: i9-User should be able to register the Rental Case without Ejari
	Given Click at New Case Link
	And Click the Rental Case
	And Click at Register a new request
	Then Click at Next  button
	And Click at the No EJARI button
	And Enter the Contract Tenancy Detial
	
Scenario: j1-User can add the party information for rental disputes
	Given User should click at Add Party button
	And User will add the first party
	And User should click at Add Party button
	When User will add the second party
	And User will click at decleration checkbox
	Then Click at Next  button
	
Scenario: k2_User_should_be_able_to_add_request
	Given User should add the Request
	Then Click at Next  button

Scenario: l3_User_should_be_able_to_add_document
	Given User should add the document
	Then Click at Next  button

Scenario: m4_User_Should_be_able_to_add_voucher
	Given User landed on the page and select party
	Then Click at Next  button
	Then Click at Submit button

Scenario: n5_user_should_be_able_to_pay
	Given Click at Pay button
	And Select Disclaimer and Click at Online button
	And Verify that naqoodi page loaded properly
	And Enter the username,password and click at login at wallet 
	And Make the Payment
	Then Make sure payment done successfully
	
