Feature: Notification preferences

@mytag
Scenario: Navigate to notification preferences
	Given User is on login page
	When User enters "sandhyaellango@gmail.com" and "sandhya@111"
	And User clicks on more option
	And User navigated to Notification Preferences
	And User selects In-App Notifications
	And Uncheck the orders option
	Then orders option should be successfully unchecked