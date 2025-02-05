﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//Делал Ярык
namespace Test_UI_Practice.tests
{
    public class BaseTest : IDisposable
    {
        private IWebDriver _driver;
        
        public void Dispose()
        {
            _driver.Quit();
        }
        public IWebDriver StartDriverWithUrl(string url)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Navigate().GoToUrl(url);
            return _driver;
        }
    }
}
