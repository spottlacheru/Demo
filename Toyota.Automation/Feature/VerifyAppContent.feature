Feature: Content
	Verify the display content in all the web pages

@smoke_test
Scenario: Verify display content
	Given The User has Launched URL
	When The User click on "Home" button
	Then The Page Navigates to "Home" page
    And The User Sees "Display" image
    And The User Sees "Details" table

    
@smoke_test
@Browser:Chrome
Scenario: Verify login
	Given The User has Launched URL
	When The User click on Apply button
	Then The Page Navigates to "Login" page
    And The User Sees StartApplication button
    And The User Selects LoanAmount slider
    Then The User enters LoanAmount entry
    Then The User click on Continue button
