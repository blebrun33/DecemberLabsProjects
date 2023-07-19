using DecemberLabsProjects.Bases;
using DecemberLabsProjects.PageObject;
using NUnit.Framework;

namespace DecemberLabsProjects.Tests
{
    public class CalendarIFrame : BaseTest
    {
        [Test]
        public void AustinOffice_CalendarScreenCompleteness_CalendarElementsAreCorrectlyDisplayed()
        {
            var austinPO = new AustinPO();
            var calendarPO = new CalendarPO();
            var bottomBanner = new BottomBanner();

            var officeText = "Austin";
            var iframeTitle = "Schedule free consultation with Elisabeth Bohlmann - VP Client Strategy";
            var iframeSubTitle = "Please pick a time slot below.";
            var days = new string[] { "Thu", "Fri", "Sat", "Sun", "Mon" };
            var timeZone = "Montevideo";

            bottomBanner.GoToOffice(officeText);
            austinPO.OpenCalendar();

            Assert.True(calendarPO.Calendar.Displayed);
            Assert.True(calendarPO.PopUpSubTitle.Displayed);
            Assert.True(calendarPO.PopUpTextTitle.Displayed);
            Assert.True(calendarPO.PopUpSubTitle.Text.Equals(iframeSubTitle));
            Assert.True(calendarPO.PopUpTextTitle.Text.Contains(iframeTitle));
            Assert.True(calendarPO.ScheduleDays.Count() == 5);
            Assert.True(calendarPO.ButtonsSchedules.Count() == 6);
            Assert.True(calendarPO.SelectTimezone.Displayed);
            Assert.True(calendarPO.SelectTimezone.Text.Contains(timeZone));

            foreach (var day in calendarPO.ScheduleDays)
            {
                Assert.True(day.Displayed);
                Assert.True(days.Contains(day.Text));
            }

            foreach (var time in calendarPO.ButtonsSchedules)
            {
                Assert.True(time.Displayed);
            }

            austinPO.CloseCalendar();
        }

        [Test]
        public void AustinOffice_OpenAndCloseModal_WorksAsExpected()
        {
            var austinPO = new AustinPO();
            var calendarPO = new CalendarPO();
            var bottomBanner = new BottomBanner();
            var officeText = "Austin";

            bottomBanner.GoToOffice(officeText);
            austinPO.OpenCalendar();

            Assert.True(calendarPO.Calendar.Displayed);
            austinPO.CloseCalendar();
            Assert.True(austinPO.ScheduleFreeConsultationBtn.Displayed);
        }
    }
}