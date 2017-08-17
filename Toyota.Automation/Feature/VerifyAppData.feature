Feature: Data
	Launches the URL and verify the contents

	@Smoke_test
	Scenario: : Verify App Data
        Given The User Navigate to URL
        When The User Clicks on Apply button
        And The User Click on Start application button
        Then The User Select loan Amount 
		| loan       | Approval |
		| 1000       | 900      |
		| 2000       | 300      |
        | 3000       | 2000     |
		| 4000       | 3000     |
        And The User Enters Personal Details