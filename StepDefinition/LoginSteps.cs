using ClassLibUnitTest.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace ClassLibUnitTest.StepDefinition
{
    [Binding]
    public class VerifyingLoginFunctionalitySteps
    {
        IWebDriver driver;
        LoginPage page = new LoginPage();
        public VerifyingLoginFunctionalitySteps()
        {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
        }

        [Given(@"User is on login page")]
        public void GivenUserIsOnLoginPage()
        {
            Console.WriteLine("Login page is displayed");
        }

        [When(@"User enters ""(.*)"" and ""(.*)""")]
        public void WhenUserEntersAnd(string emailid, string password)
        {
            page.LoginCredentials(emailid, password);
            Thread.Sleep(2000);
        }
        [Then(@"the user should be successfully logged in")]
        public void ThenTheUserShouldBeSuccessfullyLoggedIn()
        {
            driver.Close();
        }
    }
}

