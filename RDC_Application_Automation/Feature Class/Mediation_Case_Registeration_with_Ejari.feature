Feature: Mediation_Case_Registration
	

@mytag
Scenario: b2-User should be able to register the mediation case with ejari and tenancy contract
	Given Click at New Case Link
	And Click the Mediation Case
	And Click at the EJARI button
	And Enter Text in Contract No and Dewa No 
	When Click at Retrieve Ejari Information 
	Then Ejari related Information should be retrieved or check for the exception that Ejari Service is down

Scenario: c3-User_can_enter_the_parties
	Given Select the First party and Edit
	And Select the Second party and Edit it
	When Acknowledge the Information as Corrected
	Then Click at Next  button

Scenario: d4_User_should_be_able_to_add_request
	Given User should add the Request
	Then Click at Next  button

Scenario: e5_User_should_be_able_to_add_document
	Given User should add the document
	Then Click at Next  button

Scenario: f6_User_Should_be_able_to_add_voucher
	Given User landed on the page
	Then Click at Next  button
	

Scenario: g7_User_Should_be_able_to_add_mediation_case
	Given User landed on the page
	Then Click at Submit button

Scenario: h8_user_should_be_able_to_pay
	Given Click at Pay button
	And Select Disclaimer and Click at Online button
	And Verify that naqoodi page loaded properly
	And Enter the username,password and click at login at wallet 
	And Make the Payment
	Then Make sure payment done successfully
