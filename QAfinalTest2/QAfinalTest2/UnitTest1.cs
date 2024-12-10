using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace QAfinalTest2
{
    [TestClass]
    public class LoginTests
    {
        private IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            // Set up the ChromeDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.letsusedata.com");
        }

        [TestMethod]
        public void TestSuccessfulLogin()
        {
            // Locate and fill in username and password
            driver.FindElement(By.Id("txtUser")).SendKeys("test1");
            driver.FindElement(By.Id("txtPassword")).SendKeys("Test12456");
            driver.FindElement(By.Id("javascriptLogin")).Click();

            // Allow time for login to process
            System.Threading.Thread.Sleep(3000);

            // Check if the user logged in
            var loggedIn = driver.FindElement(By.Id("ReactCourseSelection"));
            Assert.IsTrue(loggedIn.Displayed, "Login was not successful.");
        }

        [TestMethod]
        public void TestUnsuccessfulLogin()
        {
            // Locate and fill in username and password
            driver.FindElement(By.Id("txtUser")).SendKeys("test1");
            driver.FindElement(By.Id("txtPassword")).SendKeys("test1234");
            driver.FindElement(By.Id("javascriptLogin")).Click();

            // Allow time for login to process
            System.Threading.Thread.Sleep(3000);

            // Check if the welcome message is displayed
            var loggedIn = driver.FindElement(By.Id("lblMessage"));
            Assert.IsTrue(loggedIn.Displayed, "Login was successful.");
        }

        [TestCleanup]
        public void TearDown()
        {
            // Close the browser
            driver.Quit();
        }
    }
}
