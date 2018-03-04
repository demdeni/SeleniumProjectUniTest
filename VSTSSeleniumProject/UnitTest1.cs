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
        public IWebDriver driver;
        public RemoteWebDriver driver1;
        private string browser;
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void RunChromeDriverHeadless()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            driver = new ChromeDriver(option);

            driver.Navigate().GoToUrl(baseURL);

            var element = driver.FindElement(By.ClassName("wlcm-title"));
            Assert.IsTrue(element.Displayed);

            driver.FindElement(By.Id("cboxClose")).Click();

            var logo = driver.FindElement(By.Id("logo"));
            Assert.IsTrue(logo.Displayed);
        }



        //[TestMethod]
        //[TestCategory("Selenium")]
        //[TestCategory("Headless")]
        //public void BingSearch_Headless()
        //{
        //    driver1 = new ChromeDriver();
        //    driver1.Navigate().GoToUrl(baseURL);

        //    var element = driver1.FindElement(By.ClassName("wlcm-title"));
        //    Assert.IsTrue(element.Displayed);

        //    driver1.FindElement(By.Id("cboxClose")).Click();

        //    var logo = driver1.FindElement(By.Id("logo"));
        //    Assert.IsTrue(logo.Displayed);

        //    //driver1.FindElement(By.Id("txtEmail")).SendKeys("andy@andykelk.net");
        //    //driver1.FindElement(By.Id("txtPassword")).SendKeys("xxxxx");
        //    //driver1.FindElement(By.Id("imgbtnLogin")).Submit();

        //    //var driver = new PhantomJSDriver();
        //    //driver.Navigate(baseURL);
        //    //page.GoTo().SearchFor("Brian Harry Blog");
        //    //Assert.AreEqual("Brian Harry's blog - Site Home - MSDN Blogs", page.FirstSearchResult.Text, "site done broke.");
        //    //driver.Quit();
        //}



        //[TestMethod]
        //[TestCategory("Selenium")]
        //[Priority(1)]
        //[Owner("Chrome")]
        //public void FirstTest()
        //{
        //    driver = new ChromeDriver();
        //    Assert.IsNotNull(driver);
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
        //    driver.Navigate().GoToUrl(baseURL);

        //    var element = driver.FindElement(By.ClassName("wlcm-title"));
        //    Assert.IsTrue(element.Displayed);

        //    driver.FindElement(By.Id("cboxClose")).Click();

        //    var logo = driver.FindElement(By.Id("logo"));
        //    Assert.IsTrue(logo.Displayed);

        //}

        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //    driver.Quit();
        //}

        [TestInitialize()]
        public void MyTestInitialize()
        {
        }
    }
}