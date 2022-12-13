using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SwagLabs_Framework.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagLabs_Framework.TestScripts
{

    [TestClass]
   public class ProductTests
    {
        BasePage basePage = new BasePage();
        IWebDriver driver;

        [TestInitialize]
        public void testInitialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(basePage.testUrl);

        }

        [Priority(1)]
        [TestMethod]
        public void Assert_Select_LowToHigh_OnDropDown()
        {
            ProductsPage productsPage = new ProductsPage(driver);
            LoginPage login = new LoginPage(driver);

            login.Type_Login_Values(Constants.Constants.userName, Constants.Constants.passWord);
            login.Click_Login_Button();
            productsPage.select_Drowdown_And_Click_LowToHigh();
            productsPage.Add_Items_To_Cart();
            Assert.IsTrue(productsPage.Assert_Cart_Has_Two_Items());
        }

        [TestCleanup]
        public void browser_Cleanup()
        {
            driver.Quit();
        }
    }
}
