using NUnit.Framework;
using OpenQA.Selenium;

namespace DecemberLabsProjects.Bases
{
    public class BaseTest
    {
        protected IWebDriver Driver => BaseDriver.Driver;
        private static string DecemberLabsUrl = "https://inhouse.decemberlabs.com/";
        protected static string austinOfficeUrl = "https://inhouse.decemberlabs.com/locations/austin/";

        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl(DecemberLabsUrl);
        }

        [TearDown]
        public void CloseBrowser()
        {
            BaseDriver.DestroyDriver();
        }
    }
}