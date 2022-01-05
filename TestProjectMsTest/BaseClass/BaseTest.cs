using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Configuration;
using System.IO;

namespace TestProjectMsTest
{
    public class BaseTest
    {
        private static string baseURL = ConfigurationManager.AppSettings["url"];
        private static string browser = ConfigurationManager.AppSettings["browser"];
        public TestContext TestContext { get; set; }
        public  IWebDriver driver { get; set; }
        [TestInitialize]
        public void Setup()
        {
            switch (browser)
            {
                case "Chrome":
                    ChromeOptions option = new ChromeOptions();
                    option.AddArgument("-headless");
                    option.PageLoadStrategy = PageLoadStrategy.Eager;
                    driver = new ChromeDriver(option);
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;

            }
            driver.Manage().Window.Maximize();
            Goto(baseURL);
        }
        [TestCleanup]
        public void Cleanup()
        {
            Reports createreport = new Reports(browser, baseURL);
            TakeScreenShot();
            createreport.addLine(TestContext.TestName, TestContext.CurrentTestOutcome.ToString(), "No");
            driver.Quit();
        }
        public void TakeScreenShot()
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            string path = Directory.GetCurrentDirectory() + TestContext.TestName + ".png";
            ss.SaveAsFile(path);
            this.TestContext.AddResultFile(path);
        }
        public void Goto(string url)
        {
            driver.Url = url;
        }

    }
}
