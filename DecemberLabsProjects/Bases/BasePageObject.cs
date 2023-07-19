using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace DecemberLabsProjects.Bases
{
    public class BasePageObject
    {
        protected IWebDriver Driver => BaseDriver.Driver;
        public string GetTitle => Driver.Title;
        public string GetUrl => Driver.Url;
        public void SwitchToIframe(IWebElement iframe) => Driver.SwitchTo().Frame(iframe);
        public WebDriverWait Wait(TimeSpan time) => new WebDriverWait(Driver, time);
        public void MoveToElement(IWebElement element)
        {
            var action = new Actions(Driver);
            
            action.MoveToElement(element)
                .Perform();
        }
    }
}
