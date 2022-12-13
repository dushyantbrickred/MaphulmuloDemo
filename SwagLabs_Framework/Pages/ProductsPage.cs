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
   public class ProductsPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        BasePage basePage = new BasePage();
        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        public void select_Drowdown_And_Click_LowToHigh()
        {
            IWebElement sortDropdown = driver.FindElement(Constants.Constants.sortDropdown);
            sortDropdown.Click();

            IWebElement lowToHighOption = driver.FindElement(Constants.Constants.lowToHighOption);
            lowToHighOption.Click();

        }

        public void Add_Items_To_Cart()
        {
            IList<IWebElement> findAddToCartBtns = driver.FindElements(Constants.Constants.addToCartBtns);
            findAddToCartBtns[0].Click();
            findAddToCartBtns[findAddToCartBtns.Count].Click();
            IWebElement clickCart = driver.FindElement(By.Id("shopping_cart_container"));
            clickCart.Click();
        }

        public bool Assert_Cart_Has_Two_Items()
        {
            IList<IWebElement> cartItems = driver.FindElements(Constants.Constants.cartItem);
            if (cartItems.Count > 2)
                return true;
            return false;
        }

    }
}
