using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace IndiceAcademico_TestCase
{
    public class Tests
    {

        string test_url = "https://intec-academic-system.netlify.app/";
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void close_browser()
        {
            driver.Quit();
        }


        [Test]
        public void Test1()
        {
            driver.Url = test_url;

            System.Threading.Thread.Sleep(2000);

            IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));

            searchText.SendKeys("LambdaTest");

            IWebElement searchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc tfB0Bf']//input[@name='btnK']"));

            searchButton.Click();

            System.Threading.Thread.Sleep(6000);

            Console.WriteLine("Test Passed");
        }
    }
}