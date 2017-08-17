Feature: Content
	Verify the display content in all the web pages

@smoke_test
Scenario: Verify display content
	Given The User has Launched URL
	 

    
@smoke_test
@Browser:Chrome
Scenario: Verify login
	Given The User has Launched URL
	When The User click on Apply button	    
    Then The User enters LoanAmount entry
    Then The User click on Continue button

	@Smoke_test
	Scenario: : Nimble
	Given Navigate to URL
Then Click on Apply button.
And Click on Start application button.
And Select loan Amount (MAAC-3000)
And Select purpose of loan (Households)
And Enter purpose of loan amount (MAAC-3000)
And Enter Personal Details & contact details
And Select bank (Dag bank).
And Enter bank credentials 
And Choose bank account
And Enter bank details (BSB- 012004 , Account no 123456789 - ,Account name- TestUser)
And Select Income Category (Primary income)
And Select Other Debt Repayments Option as (No)
And Select Dependents List as (0)
And Click Govt. Benefits Options List as (NO)
And Click Agree App Submit Button
And Verify SMS OTP.
And Verify Approved Amount with Applied Amount "5000"
And Choose Loan Amount Slider (950)
And Choose Frequency (Fortnightly)
And Change First Repayment Date (loanAmount)
And Move Slider Middle Amount RL (180)
And Click Detailed Repayment Schedule.
And Verify first date
And Verify last Date
And Verify repayment Amount
And Verify no of repayments count
And Verify repayment schedule amount
And Getting a list of repayment count.
And Select Spend less Reason
And Click on Loan contract
And Click on Confirm Accepting Contract
And Click On Agree Button
And Click on No-thanks Button
And Click on Loan Dashboard Button
And Click on Logout Button
And Click on Logout Button
