Feature: Content
	Verify the display content in all the web pages

  	@Smoke_test
	Scenario: : Verify URL Launch
        Given The User Navigate to URL
        When The User Clicks on Apply button
        And The User Click on Start application button
        Then The User Select loan Amount "3000"
        And The User Enters Personal Details
        #And Select bank (Dag bank).
        #And Enter bank credentials 
        #And Choose bank account
        #And Enter bank details (BSB- 012004 , Account no 123456789 - ,Account name- TestUser)
        #And Select Income Category (Primary income)
        #And Select Other Debt Repayments Option as (No)
        #And Select Dependents List as (0)
        #And Click Govt. Benefits Options List as (NO)
        #And Click Agree App Submit Button
        #And Verify SMS OTP.
        #And Verify Approved Amount with Applied Amount "5000"
        #And Choose Loan Amount Slider (950)
        #And Choose Frequency (Fortnightly)
        #And Change First Repayment Date (loanAmount)
        #And Move Slider Middle Amount RL (180)
        #And Click Detailed Repayment Schedule.
        #And Verify first date
        #And Verify last Date
        #And Verify repayment Amount
        #And Verify no of repayments count
        #And Verify repayment schedule amount
        #And Getting a list of repayment count.
        #And Select Spend less Reason
        #And Click on Loan contract
        #And Click on Confirm Accepting Contract
        #And Click On Agree Button
        #And Click on No-thanks Button
        #And Click on Loan Dashboard Button
        #And Click on Logout Button
