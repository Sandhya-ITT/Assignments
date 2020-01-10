using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    class HomePage
    {
        private IWebDriver driver;
        public HomePage()
        {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@name='q']")]
        public IWebElement searchField;

        [FindsBy(How = How.XPath, Using = "//img[@alt='Apple iPhone 11 (Black, 128 GB)']")]
        public IWebElement productSelected;

        [FindsBy(How = How.CssSelector, Using = "._2AkmmA._2Npkh4._2MWPVK")]
        public IWebElement addtoCart;

        [FindsBy(How = How.CssSelector, Using = "._3wU53n")]
        public IWebElement oneproductSelected;

        [FindsBy(How = How.CssSelector, Using = "._3ko_Ud")]
        public IWebElement carticon;

        [FindsBy(How = How.XPath, Using = "(//a[contains(@href,'/apple-iphone-11-black-128-gb')])[2]")]
        public IWebElement itemInCart;

        [FindsBy(How = How.XPath, Using = "(//div[contains(text(),'Remove')])[1]")]
        public IWebElement removeButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[1]/div/div[3]/div/div[2]")]
        public IWebElement popoutmsg;

        public void SearchBox(string searchString)
        {
            searchField.SendKeys(searchString);
            searchField.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            productSelected.Click();
            Thread.Sleep(2000);
        }

        public void AddingProductToCart()
        {
            //To Handle multiple windows
            IList<string> list = driver.WindowHandles;
            driver.SwitchTo().Window(list[1]);
            addtoCart.Click();
            Thread.Sleep(2000);
        }

        public void ClickOnCartIcon()
        {
            carticon.Click();
            carticon.Click();
        }

        public void RemoveTheItemFromCart()
        {
            removeButton.Click();
            Thread.Sleep(2000);
            popoutmsg.Click();
            Thread.Sleep(2000);
        }

        public void ProductRemovedFromCart()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[contains(text(),'Your cart is empty!')]"));
            Assert.IsTrue(element.Displayed, "cart is not empty");
        }

        public void ProductToBeDispalyed()
        {
            Assert.IsTrue(itemInCart.Displayed, "Item is not displayed in cart");
        }
    }
}
