Feature: VerifyCarLoan
	 

@Smoke_Run
Scenario: Car Loan
	Given navigate to url
Then click on home loans
And click on  talk to a smartline adviser
And enter firstname
And enter phone number
And enter last name
And enter post code
And check subscribe checkbox
And click on submit button
Then verify error message
And enter email id
And click on submit button
