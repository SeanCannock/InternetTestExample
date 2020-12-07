using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace InternetTestExample
{

    public abstract partial class BaseTest
    {
        protected IWebDriver driver;

        public WebDriverWait Wait { get; private set; }

        protected WebDriverWait BaseTestWait;

        [SetUp]
        public void Initialise()
        {
            ChromeOptions options = new ChromeOptions();
            driver = new ChromeDriver();
            Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 0, 10));
            Wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }


    }
}
