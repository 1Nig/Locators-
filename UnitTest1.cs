using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locators_
{
    public class Browser_ops
    {
        EdgeDriver driver;
        public void Init_Browser()
        {
            driver = new EdgeDriver();
        }
        public void Goto(string test_url)
        {
            driver.Url = test_url;
        }
        public void Close()
        {
            driver.Quit();
        }
        public EdgeDriver getDriver
        {
            get { return driver; }
        }
    }
    class NUnit_Locators
    {
        string test_url = "https://www.bbc.com/sport";
        EdgeDriver driver;
     
            [SetUp]   
        public void Tests()
    {        
        driver = new EdgeDriver("C:\\Users\\37529\\Downloads\\edgedriver_win64\\msedgedriver.exe");
                }
        [Test]
        public void Test1()
        {
            driver.Url = test_url;
            IWebElement searchButton = driver.FindElement(By.XPath("//*[@id=\"global-navigation\"]/div[3]/div[2]/a"));
            searchButton.Click();            
        }
        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
        [SetUp]
        public void Test()
        {
            driver = new EdgeDriver("C:\\Users\\37529\\Downloads\\edgedriver_win64\\msedgedriver.exe");
        }
        [Test]
        public void Test2()
        {
            driver.Url = test_url;
           IWebElement BBCButton = driver.FindElement(By.XPath("//*[@id=\"global-navigation\"]/div[1]/a"));
            BBCButton.Click();
            
        }
        [Test]
        public void Test3()
        {
            driver.Url = test_url;
            IWebElement AllSportsButton = driver.FindElement(By.Id("more-menu-button"));
            AllSportsButton.Click();
        }
        [Test]
        public void Test4()
        {
            driver.Url = test_url;
            IWebElement BBCIcon = driver.FindElement(By.LinkText("BBC Homepage"));           
        }
        [TearDown]
        public void close_Browser2()
        {
            driver.Quit();
        }


        
        }
    }
    
    