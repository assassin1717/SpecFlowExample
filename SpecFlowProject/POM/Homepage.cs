using OpenQA.Selenium;
using static SpecFlowProject.Drivers.Driver;

namespace SpecFlowProject.POM
{
    public class Homepage
    {
        private readonly IWebDriver driver;
        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement AcceptCookies { get => driver.FindElement(By.CssSelector("#L2AGLb > div")); }
        public IWebElement HomeSearchInput { get => driver.FindElement(By.CssSelector("#APjFqb")); }
        public IWebElement HomeSearchButton { get => driver.FindElement(By.CssSelector("body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(1) > div.A8SBwf > div.FPdoLc.lJ9FBc > center > input.gNO89b")); }
    }
}
