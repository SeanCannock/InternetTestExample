using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace InternetTestExample
{
    public class Login
	{
		IWebDriver driver = new ChromeDriver();
		
		[Test]
		public void LoginPagePass()

			// Scenario: User logs in
			  // When User logs in
			  // Given the login details are correct
			  // Then User is logged in

		{
			driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
            driver.FindElement(By.Id("username")).SendKeys("tomsmith");
			driver.FindElement(By.Id("password")).SendKeys("SuperSecretPassword!");
            driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/button[1]/i[1]")).Click();
			Thread.Sleep(2000);
			driver.FindElement(By.XPath("//h4[contains(text(),'Welcome to the Secure Area. When you are done clic')]"));
			
		}

		[Test]
		public void LoginPageUsernameFail()

			// Scenario: User logs in
			  // When User logs in
			  // Given the username is incorrect
			  // Then User is not logged in

        {
			driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
			driver.FindElement(By.Id("username")).SendKeys("uweschmidt");
			driver.FindElement(By.Id("password")).SendKeys("SuperSecretPassword!");
			driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/button[1]/i[1]")).Click();
			Thread.Sleep(2000);
			driver.FindElement(By.XPath("//div[@class='flash error']"));

		}

		[Test]
		public void LoginPagePassFail()

		// Scenario: User logs in
		  // When User logs in
		  // Given the password is incorrect
		  // Then User is not logged in

		{
			driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
			driver.FindElement(By.Id("username")).SendKeys("tomsmith");
			driver.FindElement(By.Id("password")).SendKeys("B@dp45s");
			driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/button[1]/i[1]")).Click();
			Thread.Sleep(2000);
			driver.FindElement(By.XPath("//div[@class='flash error']"));
		}
	}
}