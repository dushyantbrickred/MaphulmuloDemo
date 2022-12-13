using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace SwagLabs_Framework.Pages
{
   public class LoginPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        BasePage basePage = new BasePage();

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }
        public void Type_Login_Values()
        {
            IWebElement userName_txtBx = driver.FindElement(Constants.Constants.userName_txtBx);
            IWebElement passWord_txtBx = driver.FindElement(Constants.Constants.passWord_txtBx);
            userName_txtBx.SendKeys("standard_user");
            passWord_txtBx.SendKeys("secret_sauce");
          
        }

        public bool Click_Login_Button()
        {
            IWebElement sign_Btn = driver.FindElement(Constants.Constants.sign_Btn);
            wait.Until(b => sign_Btn.Enabled);
            sign_Btn.Click();
            var exists = driver.FindElement(Constants.Constants.loginLogo).Displayed;
            return exists;
        }
    }
}
