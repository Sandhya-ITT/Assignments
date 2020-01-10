using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ClassLibUnitTest.PageObjects
{
    class NotificationPreferencesPage
    {
        private IWebDriver driver;
        public NotificationPreferencesPage()
        {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//div[@class='_2aUbKa'])[2]")]
        public IWebElement moreDropdownOption;

        [FindsBy(How = How.XPath, Using = "//a[@class='_2k68Dy']/div[contains(text(),'Notification Preferences')]")]
        public IWebElement notificationPreferencesField;

        [FindsBy(How = How.LinkText, Using = "In-App Notifications")]
        public IWebElement inAppNotificationField;

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']")]
        public IWebElement myordersField;

        IWebElement ele;

        public void ClickOnMoreOption()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//div[@class='_2aUbKa'])[2]")));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(2000);
        }

        public void ClickOnNotificationPreferencesField()
        {
            notificationPreferencesField.Click();
            Thread.Sleep(2000);
        }

        public void ClickOnInAppNotificationField()
        {
            Thread.Sleep(2000);
            inAppNotificationField.Click();
            Thread.Sleep(3000);
        }

        public void UncheckMyOrdersField()
        {
            Thread.Sleep(5000);
            ele = driver.FindElement(By.XPath("//input[@type='checkbox']"));
            if (ele.Selected == true)
            {
                Actions action = new Actions(driver);
                action.MoveToElement(myordersField).Click().Perform();
            }
        }

        public void VerifyingMyOrdersFieldIsUnchecked()
        {
            Assert.IsTrue(!ele.Selected, "Not Matched");
        }
    }
}

