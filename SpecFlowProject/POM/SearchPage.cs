using OpenQA.Selenium;
using static SpecFlowProject.Drivers.Driver;

namespace SpecFlowProject.POM
{
    public class SearchPage
    {
        private readonly IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement SearchedResultsBreadCrumbs { get => driver.FindElement(By.CssSelector("#result-stats")); }
    }
}
