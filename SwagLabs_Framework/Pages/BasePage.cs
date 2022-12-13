using System;
using System.Collections.Generic;
using System.Text;

namespace SwagLabs_Framework.Pages
{
        public enum WaitCondition
        {
            ToBeClickable,
            ToBeVisible,
            ToExist,
            ToBeSelected,
            ToBeSwitchable
        }
        public class BasePage
        {
            public string testUrl = "https://www.saucedemo.com/";

        }
    }
