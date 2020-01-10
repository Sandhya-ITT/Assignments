using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace ClassLibUnitTest.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            ScenarioContext.Current["driver"] = driver;
            driver.Url = "https://www.flipkart.com/";
            Thread.Sleep(2000);
            driver.Manage().Window.Maximize();

        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
