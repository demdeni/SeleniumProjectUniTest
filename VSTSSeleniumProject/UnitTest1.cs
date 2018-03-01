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

        public int TireSearch_Any()
        {



            //var path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            //string newPath = Path.GetFullPath(Path.Combine(path, @"..\"));
            //var sdf = Directory.GetDirectories(newPath);
            //var sfdds = sdf[4].ToString() + "\\bin\\Release";

            var item = 20;
            var item1 = 30;
            return item * item1;
            //driver = new ChromeDriver("C:\\Users\\denisd\\Downloads\\chrome");
            //driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            //driver.Navigate().GoToUrl(baseURL);
            //driver.FindElementById("search_link").Click();
            //do other Selenium things here!
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            //driver.Quit();
        }

        [TestInitialize()]
        public void MyTestInitialize()
        {
        }
    }
}