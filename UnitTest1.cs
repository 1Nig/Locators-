using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Locators_
{
    public class BrowserOps
    {
        private IWebDriver driver;

        public void InitBrowser()
        {
            driver = new ChromeDriver();
        }
        public void Goto(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void Close()
        {
            driver.Quit();
        }
        public IWebDriver GetDriver()
        {
            return driver;
        }
    }

    [TestFixture]
    public class NUnitLocators
    {
        private const string TestUrl = "https://www.bbc.com/sport";
        private BrowserOps browserOps;
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            browserOps = new BrowserOps();
            browserOps.InitBrowser();
            driver = browserOps.GetDriver();
        }

        [TearDown]
        public void Teardown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }

        [Test]
        public void TestSearchButton()
        {
            browserOps.Goto(TestUrl);
            IWebElement searchButton = driver.FindElement(By.XPath("//*[@id=\"global-navigation\"]/div[3]/div[2]/a"));
            searchButton.Click();
        }

        [Test]
        public void TestBBCButton()
        {
            browserOps.Goto(TestUrl);
            IWebElement bbcButton = driver.FindElement(By.XPath("//*[@id=\"global-navigation\"]/div[1]/a"));
            bbcButton.Click();
        }

        [Test]
        public void TestAllSportsButton()
        {
            browserOps.Goto(TestUrl);
            IWebElement allSportsButton = driver.FindElement(By.Id("more-menu-button"));
            allSportsButton.Click();
        }

        [Test]
        public void TestBBCIcon()
        {
            browserOps.Goto(TestUrl);
            IWebElement bbcIcon = driver.FindElement(By.LinkText("BBC Homepage"));
            bbcIcon.Click();
        }
    }
}
