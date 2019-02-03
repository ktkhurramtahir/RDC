Feature: Login_RDC
	IUser's first step is to login to the page.

@mytag
Scenario: 	a1-Application URL will be launched for RDC

	Given Go to the URL of RDC
	And Change the Language from Arabic to English
	And Enter the User Name and Password
	When User Clicked at Login button
	Then He should be redirected to the login page
	
