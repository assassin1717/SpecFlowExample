using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SpecFlowProject.Drivers
{
    public static class Driver
    {
        public static IWebDriver GetChromDriver()
        {
            return new ChromeDriver();
        }

        public static IWebDriver GetFirefoxDriver()
        {
            return new FirefoxDriver();
        }
    }
}
