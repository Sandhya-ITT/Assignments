using ClassLibUnitTest.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ClassLibUnitTest.StepDefinition
{
    [Binding]
    public class NotificationPreferencesSteps
    {
        NotificationPreferencesPage page = new NotificationPreferencesPage();
        [When(@"User clicks on more option")]
        public void WhenUserClicksOnMoreOption()
        {
            page.ClickOnMoreOption();
        }

        [When(@"User navigated to Notification Preferences")]
        public void WhenUserNavigatedToNotificationPreferences()
        {
            page.ClickOnNotificationPreferencesField();
        }

        [When(@"User selects In-App Notifications")]
        public void WhenUserSelectsIn_AppNotifications()
        {
            page.ClickOnInAppNotificationField();
        }

        [When(@"Uncheck the orders option")]
        public void WhenUncheckTheOrdersOption()
        {
            page.UncheckMyOrdersField();
        }

        [Then(@"orders option should be successfully unchecked")]
        public void ThenOrdersOptionShouldBeSuccessfullyUnchecked()
        {
            page.VerifyingMyOrdersFieldIsUnchecked();
        }
    }
}
