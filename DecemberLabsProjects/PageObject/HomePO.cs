using DecemberLabsProjects.Bases;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace DecemberLabsProjects.PageObject
{
    public class HomePO : BasePageObject
    {
        public IEnumerable<IWebElement> UpperMenu => Driver.FindElements(By.XPath("//ul[@id='menu-header-main-menu']/li[contains(@class,'menu-item-object-page')]"));
        public string[] MenuTitles => new string[] { "About", "Services", "Our Work", "Blog", "FAQ", "Careers" };
        
        public void ClickMenuLink(string linkText) 
        {
            var link = UpperMenu.Where(x => x.Text.Contains(linkText)).FirstOrDefault();
            var ourWorkLinkText = "Work";

            if ( link != null)
            {
                if (link.Text.Contains(ourWorkLinkText))
                {
                    var linkTitle = ourWorkLinkText.ToLower();
                    MoveToElement(link);
                    link?.Click();
                    Wait(TimeSpan.FromSeconds(10)).Until(ExpectedConditions.UrlContains(linkTitle));
                }
                else
                {
                    var linkTitle = link.Text.ToLower();
                    MoveToElement(link);
                    link?.Click();
                    Wait(TimeSpan.FromSeconds(10)).Until(ExpectedConditions.UrlContains(linkTitle));
                }
            }
        }
    }
}
