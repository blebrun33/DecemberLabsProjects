using DecemberLabsProjects.Bases;
using OpenQA.Selenium;

namespace DecemberLabsProjects.PageObject
{
    public class AustinPO : BasePageObject
    {
        public IWebElement ScheduleFreeConsultationBtn => Driver.FindElement(By.CssSelector("div.left div.buttons a"));
        public IWebElement ClosePopUp => Driver.FindElement(By.CssSelector("div[class='dl-modal calendar-modal open'] div.btn-close-modal"));

        public void OpenCalendar()
        {
            var calendar = new CalendarPO();
            ScheduleFreeConsultationBtn.Click();
            SwitchToIframe(calendar.CalendarIFrame);
            Wait(TimeSpan.FromSeconds(5)).Until(Driver => calendar.PopUpTextTitle.Displayed);
        }

        public void CloseCalendar()
        {
            Driver.SwitchTo().DefaultContent();
            ClosePopUp.Click();
            Wait(TimeSpan.FromSeconds(5)).Until(Driver => ScheduleFreeConsultationBtn.Displayed);
        }

        public void GoToAustinOffice()
        {
            var bottomBanner = new BottomBanner();
            var officeText = "Austin";
            bottomBanner.GoToOffice(officeText);
        }
    }
}
