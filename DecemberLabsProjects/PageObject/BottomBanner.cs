using DecemberLabsProjects.Bases;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace DecemberLabsProjects.PageObject
{
    public class BottomBanner : BasePageObject
    {
        public IEnumerable<IWebElement> OfficeMenu => Driver.FindElements(By.CssSelector("li.offices_section ul li .office_wrap .city"));

        public void GoToOffice(string office)
        {
            var officeElement = OfficeMenu.Where(x => x.Text.Contains(office)).FirstOrDefault();

            if (officeElement != null)
            {
                MoveToElement(officeElement);
                officeElement.Click();
                Wait(TimeSpan.FromSeconds(5)).Until(ExpectedConditions.UrlContains(office.ToLower()));
            }
        }
    }
}
