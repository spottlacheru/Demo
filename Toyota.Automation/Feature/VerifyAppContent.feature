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
	When The User click on "Login" button
	Then The Page Navigates to "Login" page
    And The User Sees "UserName" button
    And The User Sees "Password" button
    Then The User enters "" in "" entry
    Then The User enters "" in "" entry
