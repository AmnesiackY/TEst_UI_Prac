﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test_UI_Practice
{
    public class SignIn : Header
    {
        public SignIn(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
