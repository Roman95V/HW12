using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace HW11_NT
{
    public class Tests
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

          // _webDriver.Navigate().GoToUrl("https://rozetka.com.ua/");
          // var sea = _webDriver.FindElement(By.CssSelector(".search-form__input"));
          // sea.SendKeys("Пасхальний набір");
          // _webDriver.FindElement(By.CssSelector("button.button:nth-child(2)")).Click();
          // var fristPosition = _webDriver.FindElement(By.CssSelector("li.catalog-grid__cell:nth-child(1) > app-goods-tile-default:nth-child(1) > div:nth-child(1) > div:nth-child(2) > a:nth-child(5) > span:nth-child(1)"));
          // Assert.AreEqual("Шоколадний набір до Великодня TRUFFLE BRO, пасхальний кролик №3, 160 грам", fristPosition.Text.Trim());
        }
        [Test]
        public void Test2()
        {
          //  _webDriver.Navigate().GoToUrl("https://rozetka.com.ua/");
          //  var sea = _webDriver.FindElement(By.CssSelector(".search-form__input"));
          //  sea.SendKeys("Флешка 32 ГБ");
          //  _webDriver.FindElement(By.CssSelector("button.button:nth-child(2)")).Click();
          //  var fristPosition = _webDriver.FindElement(By.CssSelector("li.catalog-grid__cell:nth-child(1) > app-goods-tile-default:nth-child(1) > div:nth-child(1) > div:nth-child(2) > a:nth-child(5) > span:nth-child(1)"));
          //  Assert.AreEqual("Samsung Bar Plus 32GB USB 3.1 Silver (MUF-32BE3/APC)", fristPosition.Text.Trim());
        }
    }
}