using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace InternetTestExample
{
    public class Login
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
		public void LoginPagePass()

			// Scenario: User logs in

		{
			driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
            driver.FindElement(By.Id("username")).SendKeys("tomsmith");
			driver.FindElement(By.Id("password")).SendKeys("SuperSecretPassword!");
            driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/button[1]/i[1]")).Click();
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//h4[contains(text(),'Welcome to the Secure Area. When you are done clic')]")));
			Assert.IsTrue(driver.FindElement(By.XPath("//h4[contains(text(),'Welcome to the Secure Area. When you are done clic')]")).Displayed);
		}

		[Test]
		public void LoginPageUsernameFail()

			// Scenario: User logs in with incorrect Username

        {
			driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
			driver.FindElement(By.Id("username")).SendKeys("uweschmidt");
			driver.FindElement(By.Id("password")).SendKeys("SuperSecretPassword!");
			driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/button[1]/i[1]")).Click();
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class='flash error']")));
			Assert.IsTrue(driver.FindElement(By.XPath("//div[@class='flash error']")).Displayed);
		}

		[Test]
		public void LoginPagePassFail()

		// Scenario: User logs in with incorrect Password

		{
			driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
			driver.FindElement(By.Id("username")).SendKeys("tomsmith");
			driver.FindElement(By.Id("password")).SendKeys("B@dp45s");
			driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/button[1]/i[1]")).Click();
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class='flash error']")));
			Assert.IsTrue(driver.FindElement(By.XPath("//div[@class='flash error']")).Displayed);
		}
	

		[TearDown]
		public void Teardown()
		{
			driver.Close();
		}

	}
}