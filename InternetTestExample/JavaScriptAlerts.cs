using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace InternetTestExample
{
	public class JavaScriptAlerts
	{
		public WebDriverWait Wait { get; private set; }
		protected IWebDriver driver;

		[SetUp]
		public void Initialise()
		{
			ChromeOptions options = new ChromeOptions();
			driver = new ChromeDriver();
		}

		[Test, Order(1)]
		public void JSConfirm()

		// Scenario: User accepts JavaScript Confirm message


		{
			driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
			driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Confirm')]")).Click();
			driver.SwitchTo().Alert().Accept();
			Assert.IsTrue(driver.FindElement(By.XPath("//*[text()='You clicked: Ok']")).Displayed);
		}

		[Test, Order(2)]
		public void JSCancel()

		// Scenario: User cancels JavaScript Confirm message

		{

			driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
			driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Confirm')]")).Click();
			driver.SwitchTo().Alert().Dismiss();
			Assert.IsTrue(driver.FindElement(By.XPath("//*[text()='You clicked: Cancel']")).Displayed);
		}

		[TearDown]
		public void Teardown()
		{
			driver.Close();
		}

	}
}
