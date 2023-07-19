using DecemberLabsProjects.Bases;
using OpenQA.Selenium;

namespace DecemberLabsProjects.PageObject
{
    public class CalendarPO : BasePageObject
    {
        public IWebElement CalendarIFrame => Driver.FindElement(By.CssSelector(".dl-modal-content iframe"));
        public IWebElement PopUpTextTitle => Driver.FindElement(By.CssSelector("h3.text-medium"));
        public IWebElement PopUpSubTitle => Driver.FindElement(By.CssSelector("div[class='sc-dsHJmm bBXjfv'] span"));
        public IWebElement SelectTimezone => Driver.FindElement(By.CssSelector("div[class='select-wrapper noshadow']"));
        public IWebElement Calendar => Driver.FindElement(By.CssSelector("div[class='flexbox  flexbox--column']"));
        public IEnumerable<IWebElement> ButtonsSchedules => Calendar.FindElements(By.CssSelector("div[role='button']"));
        public IEnumerable<IWebElement> ScheduleDays => Calendar.FindElements(By.CssSelector("div[class='text-black text-medium mr zeta']"));
    }
}
