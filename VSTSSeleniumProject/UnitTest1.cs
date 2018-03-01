namespace VSTSSeleniumProject.UITests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.PhantomJS;
    using System;
    using System.IO;
    using System.Reflection;

    [TestClass]
    public class ChucksClass1
    {

        private string baseURL = "https://syneron-candela.com/int";
        public RemoteWebDriver driver;
        private string browser;
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("Selenium")]
        [Priority(1)]
        [Owner("Chrome")]
        public void FirstTest()
        {
            driver = new ChromeDriver();
            Assert.IsNotNull(driver);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(baseURL);

            var element = driver.FindElement(By.ClassName("wlcm-title"));
            Assert.IsTrue(element.Displayed);

            driver.FindElement(By.Id("cboxClose")).Click();

            var element1 = driver.FindElement(By.Id("logo"));
            Assert.IsTrue(element1.Displayed);

        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            driver.Quit();
        }

        [TestInitialize()]
        public void MyTestInitialize()
        {
        }
    }
}