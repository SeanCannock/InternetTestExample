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

		IWebDriver driver = new ChromeDriver();

		[Test]
		public void LoadWaitTest()

		//Scenario: User 
		//When User logs in
		//Given the login details are correct
		//Then User is logged in

		{
			driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_loading/2");
			driver.FindElement(By.XPath("//button[contains(text(),'Start')]")).Click();
			Thread.Sleep(8000);
			driver.FindElement(By.XPath("//h4[contains(text(),'Hello World!')]"));
		}

		[Test]
		public void LoadWaitTest2()

		//Scenario: User 
		//When User logs in
		//Given the login details are correct
		//Then User is logged in

		{
			driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_loading/1");
			driver.FindElement(By.XPath("//button[contains(text(),'Start')]")).Click();
			Thread.Sleep(8000);
			driver.FindElement(By.XPath("//div[@id='loading'][@style='display: none;']"));
			driver.FindElement(By.XPath("//h4[contains(text(),'Hello World!')]"));
		}

	}
}
