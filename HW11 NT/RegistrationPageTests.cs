using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace HW11_NT
{
    class RegistrationPageTests
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
        public void CheckTheTransitionToTheSecondStageOfRegistration()
        {
            var registrationPage = new RegistrationPage(_webDriver);


            var actualMessage = signInPage.GetUserAccountBlockMessage();

            Assert.AreEqual("User account is blocked.", actualMessage);

        }
    }
}
