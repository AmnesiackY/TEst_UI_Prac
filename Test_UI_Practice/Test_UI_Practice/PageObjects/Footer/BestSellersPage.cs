﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Test_UI_Practice.tests
{ 
    public class BestSellersPage : Footer
    {
        public BestSellersPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
