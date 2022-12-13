using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagLabs_Framework.Constants
{
   public static class Constants
    {
        public static By userName_txtBx = By.Id("user-name");
        public static By passWord_txtBx = By.Id("password");
        public static By sign_Btn = By.Id("login-button");
        public static By loginLogo = By.ClassName("peek");

        public static By sortDropdown = By.ClassName("product_sort_container");
        public static By lowToHighOption = By.XPath("//*[@id='header_container']/div[2]/div[2]/span/select/option[3]");

        public static By addToCartBtns = By.ClassName("btn btn_primary");
    }
}
