using DecemberLabsProjects.Bases;
using DecemberLabsProjects.PageObject;
using NUnit.Framework;


namespace DecemberLabsProjects.Tests
{
    public class Home : BaseTest
    {
        private HomePO homePO;
        
        [Test]
        public void DecemberLabs_HomePageTitle_CorrectlyDisplayed() 
        {
            homePO = new HomePO();            
            var homeTitle = "December Labs: UX/UI Design and Mobile App & Web Development";            
            Assert.True(homeTitle.Equals(Driver.Title));            
        }

        [Test]
        public void DecemberLabs_ValidateUpperMenuText_ContainsTheCorrectText()
        {
            homePO = new HomePO();
            foreach (var menu in homePO.UpperMenu)
            {
                Assert.True(menu.Displayed);
                Assert.True(homePO.MenuTitles.Contains(menu.Text));
            }
        }

        [Test]
        public void DecemberLabs_UpperMenuLinks_RedirectsToCorrectPages()
        {
            homePO = new HomePO();
            foreach (var menu in homePO.MenuTitles)
            {
                homePO.ClickMenuLink(menu);
                Assert.True(homePO.GetTitle.Contains(menu));
            }
        }

        [Test]
        public void DecemberLabs_GoToAustinPage_ValidateTitleAndUrl()
        {
            homePO = new HomePO();
            var bottomBanner = new BottomBanner();

            var officeText = "Austin";            
            var austinTitle = "Austin Web & App Developers | December Labs";

            bottomBanner.GoToOffice(officeText);

            Assert.True(austinTitle.Equals(homePO.GetTitle));            
            Assert.True(homePO.GetUrl.Equals(austinOfficeUrl));
        }
    }
}
