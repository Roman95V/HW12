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
    class AuthorizationTest
    {
        public class UserAuthorizationTest
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
                //email  WillSmith@gmail.com
                //password 123Qwe@321

                _webDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");

                _webDriver.FindElement(By.CssSelector("[name = email]")).SendKeys("WillSmith@gmail.com");

                _webDriver.FindElement(By.CssSelector("[name = password]")).SendKeys("123Qwe@321");

                _webDriver.FindElement(By.CssSelector(".SignInForm__submitButton--cUdOV")).Click();

                var result = _webDriver.Url;

                Thread.Sleep(3000);

                Assert.Equals("https://newbookmodels.com/join/company", result);

            }
        }
    }
}
