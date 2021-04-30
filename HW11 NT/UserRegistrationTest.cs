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
    public class UserRegistrationTest
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
        public void Test1()
        {

            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/join/");
            
            _webDriver.FindElement(By.CssSelector("div.SignupFormLayout__fieldRow--bGt25:nth-child(1) > div:nth-child(1) > label:nth-child(1) > input:nth-child(2)")).SendKeys("Will");
          
           _webDriver.FindElement(By.CssSelector("div.SignupFormLayout__fieldRow--bGt25:nth-child(1) > div:nth-child(2) > label:nth-child(1) > input:nth-child(2)")).SendKeys("Smith");

            _webDriver.FindElement(By.CssSelector("div.SignupFormLayout__fieldRow--bGt25:nth-child(2) > div:nth-child(1) > label:nth-child(1) > input:nth-child(2)")).SendKeys("sosixof555@quossum.com");
            _webDriver.FindElement(By.CssSelector("div.SignupFormLayout__fieldRow--bGt25:nth-child(4) > div:nth-child(1) > label:nth-child(1) > input:nth-child(2)")).SendKeys("4444444444");
            _webDriver.FindElement(By.CssSelector("div.SignupFormLayout__fieldRow--bGt25:nth-child(3) > div:nth-child(1) > label:nth-child(1) > input:nth-child(2)")).SendKeys("@123Will@");

             _webDriver.FindElement(By.CssSelector("div.SignupFormLayout__fieldRow--bGt25:nth-child(3) > div:nth-child(2) > label:nth-child(1) > input:nth-child(2)")).SendKeys("@123Will@");
            
            _webDriver.FindElement(By.CssSelector(".SignupForm__submitButton--1m1C2")).Click();
            var result = _webDriver.Url;
            Thread.Sleep(3000);
            Assert.Equals("https://newbookmodels.com/join", result);
            
            //  _webDriver.FindElement(By.CssSelector("button.button:nth-child(2)")).Click();
            //  var fristPosition = _webDriver.FindElement(By.CssSelector("li.catalog-grid__cell:nth-child(1) > app-goods-tile-default:nth-child(1) > div:nth-child(1) > div:nth-child(2) > a:nth-child(5) > span:nth-child(1)"));
            //  Assert.AreEqual("Шоколадний набір до Великодня TRUFFLE BRO, пасхальний кролик №3, 160 грам", fristPosition.Text.Trim());
        }
        [Test]
        public void Test2()
        {

            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/join/");

            _webDriver.FindElement(By.CssSelector("div.SignupFormLayout__fieldRow--bGt25:nth-child(1) > div:nth-child(1) > label:nth-child(1) > input:nth-child(2)")).SendKeys("Will");

            _webDriver.FindElement(By.CssSelector("div.SignupFormLayout__fieldRow--bGt25:nth-child(1) > div:nth-child(2) > label:nth-child(1) > input:nth-child(2)")).SendKeys("Smith");

            _webDriver.FindElement(By.CssSelector("div.SignupFormLayout__fieldRow--bGt25:nth-child(2) > div:nth-child(1) > label:nth-child(1) > input:nth-child(2)")).SendKeys("sosixof555@quossum.com");
            _webDriver.FindElement(By.CssSelector("div.SignupFormLayout__fieldRow--bGt25:nth-child(4) > div:nth-child(1) > label:nth-child(1) > input:nth-child(2)")).SendKeys("4444444444");
            _webDriver.FindElement(By.CssSelector("div.SignupFormLayout__fieldRow--bGt25:nth-child(3) > div:nth-child(1) > label:nth-child(1) > input:nth-child(2)")).SendKeys("@123Will@");

            _webDriver.FindElement(By.CssSelector("div.SignupFormLayout__fieldRow--bGt25:nth-child(3) > div:nth-child(2) > label:nth-child(1) > input:nth-child(2)")).SendKeys("@123Will@");

            _webDriver.FindElement(By.CssSelector(".SignupForm__submitButton--1m1C2")).Click();

            _webDriver.FindElement(By.CssSelector("div.SignupFormLayout__fieldRow--bGt25: nth - child(1) > div:nth - child(1) > label:nth - child(1) > input:nth - child(2)")).SendKeys("WWWWW");
            _webDriver.FindElement(By.CssSelector("div.SignupFormLayout__fieldRow--bGt25: nth - child(1) > div:nth - child(1) > label:nth - child(1) > input:nth - child(2)")).SendKeys("wweer.com");
            _webDriver.FindElement(By.CssSelector("div.SignupFormLayout__fieldRow--bGt25: nth - child(1) > div:nth - child(1) > label:nth - child(1) > input:nth - child(2)")).SendKeys("3333 Echols Road, Cumming, GA, USA");

            _webDriver.FindElement(By.CssSelector(".SignupCompanyForm__submitButton--3mz3p")).Click();
            Thread.Sleep(3000);
           // Assert.Equals("https://newbookmodels.com/join", result);

            //  _webDriver.FindElement(By.CssSelector("button.button:nth-child(2)")).Click();
            //  var fristPosition = _webDriver.FindElement(By.CssSelector("li.catalog-grid__cell:nth-child(1) > app-goods-tile-default:nth-child(1) > div:nth-child(1) > div:nth-child(2) > a:nth-child(5) > span:nth-child(1)"));
            //  Assert.AreEqual("Шоколадний набір до Великодня TRUFFLE BRO, пасхальний кролик №3, 160 грам", fristPosition.Text.Trim());
        }
    }
}