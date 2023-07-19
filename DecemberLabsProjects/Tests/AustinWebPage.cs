using DecemberLabsProjects.Bases;
using DecemberLabsProjects.PageObject;
using NUnit.Framework;

namespace DecemberLabsProjects.Tests
{
    public class AustinWebPage : BaseTest
    {
        [Test]
        public void AustinOffice_ScheduleButton_IsCorrectlyDisplayed() 
        {
            var austinPO = new AustinPO();
            austinPO.GoToAustinOffice();

            var scheduleBtn = austinPO.ScheduleFreeConsultationBtn;
            var btnText = "Schedule free consultation";

            Assert.True(scheduleBtn.Displayed);
            Assert.True(scheduleBtn.Text.Equals(btnText));
        }
    }
}
