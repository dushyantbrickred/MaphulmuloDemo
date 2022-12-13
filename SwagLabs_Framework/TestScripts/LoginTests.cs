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
    public class LoginTests
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
        public void Assert_User_Can_Login()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Type_Login_Values();
            var logoExits = loginPage.Click_Login_Button();
            Assert.IsTrue(logoExits);
        }


        [TestCleanup]
        public void browser_Cleanup()
        {
            driver.Quit();
        }

    }
}
