using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DecemberLabsProjects.Bases
{
    public class BaseDriver
    {
        private static IWebDriver driver;

        public static IWebDriver Driver { 
            get
            {
                if (driver == null) 
                {
                    InitDriver();                
                }

                return driver;
            }
        }      

        private static void InitDriver()
        {
            var waitingTime = TimeSpan.FromSeconds(20);
            var option = new ChromeOptions();
            var argument = "incognito";
            option.AddArgument(argument);
            driver = new ChromeDriver(option);
            driver.Manage().Timeouts().PageLoad = waitingTime;
            driver.Manage().Timeouts().AsynchronousJavaScript = waitingTime;
            driver.Manage().Timeouts().ImplicitWait = waitingTime;
            driver.Manage().Window.Maximize();
        }

        public static void DestroyDriver() 
        {
            driver.Close();
            driver.Quit();                    
        }
    }
}
