using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace InternetTestExample
{
	public class JavaScriptAlerts
	{

		IWebDriver driver = new ChromeDriver();

		[Test]
		public void JSConfirm()

		//Scenario: User 
		//When User logs in
		//Given the login details are correct
		//Then User is logged in

		{
			driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
			driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Confirm')]")).Click();
			driver.SwitchTo().Alert().Accept();
		}

		[Test]
		public void JSCancel()

		//Scenario: User 
		//When User logs in
		//Given the login details are correct
		//Then User is logged in

		{
			driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
			driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Confirm')]")).Click();
			driver.SwitchTo().Alert().Dismiss();
		}

	}
}
