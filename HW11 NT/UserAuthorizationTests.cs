using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace HW11_NT
{
    public class UserAuthorizationTests
    {
        private IWebDriver _webDriver;
        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            _webDriver = new FirefoxDriver();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);

        }
        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
        [Test]
        public void RegistrationPartOne()
        {
           
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/join/");

            _webDriver.FindElement(By.CssSelector("[name = first_name]")).SendKeys("Will");

            _webDriver.FindElement(By.CssSelector("[name = last_name]")).SendKeys("Smith");

            _webDriver.FindElement(By.CssSelector("[name = email]")).SendKeys($"sosixo{_email}5@quossum.com");

            _webDriver.FindElement(By.CssSelector("[name = phone_number]")).SendKeys("4444444444");

            _webDriver.FindElement(By.CssSelector("[name = password]")).SendKeys("@123Will@");

            _webDriver.FindElement(By.CssSelector("[name = password_confirm]")).SendKeys("@123Will@");

            _webDriver.FindElement(By.CssSelector(".SignupForm__submitButton--1m1C2")).Click();

            var result = _webDriver.Url;

            Thread.Sleep(3000);

            Assert.AreEqual("https://newbookmodels.com/join/company", result);

        }
    }
}