using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace InternetTestExample
{
    public class DynamicLoadElements
    {

		public WebDriverWait Wait { get; private set; }
		protected IWebDriver driver;

		[SetUp]
		public void Initialise()
		{
			ChromeOptions options = new ChromeOptions();
			driver = new ChromeDriver();
		}

		[Test]
		public void LoadWaitTest()

		// Scenario: Page loads element after event
		  // When User clicks start
		  // Given the element has loaded
		  // Then the message 'Hello World!' should display

		{
			driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_loading/2");
			driver.FindElement(By.XPath("//button[contains(text(),'Start')]")).Click();
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@id='loading'][@style='display: none;']")));
			Assert.IsTrue(driver.FindElement(By.XPath("//h4[contains(text(),'Hello World!')]")).Displayed);
		}

		[Test]
		public void LoadWaitTest2()

		// Scenario: Page loads element that is hidden
		  // When User clicks start
		  // Given the element is no longer hidden
		  // Then the message 'Hello World!' should display

		{
			driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_loading/1");
			driver.FindElement(By.XPath("//button[contains(text(),'Start')]")).Click();
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@id='loading'][@style='display: none;']")));
			Assert.IsTrue(driver.FindElement(By.XPath("//h4[contains(text(),'Hello World!')]")).Displayed);
        }

		[TearDown]
		public void Teardown()
		{
			driver.Close();
		}

	}
}
