using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ClassLibUnitTest.PageObjects
{
    class LoginPage
    {
        private IWebDriver driver;
        public LoginPage()
        {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "_2zrpKA")]
        public IWebElement txtemailid;

        [FindsBy(How = How.XPath, Using = "//input[@type=\"password\"]")]
        public IWebElement txtpassword;

        [FindsBy(How = How.CssSelector, Using = "._2AkmmA._1LctnI._7UHT_c")]
        public IWebElement loginbutton;

        public void LoginCredentials(string emailid, string password)
        {
            txtemailid.SendKeys(emailid);
            txtpassword.SendKeys(password);
            Thread.Sleep(2000);
            loginbutton.Click();
        }
    }
}
