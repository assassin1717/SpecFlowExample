using NUnit.Framework;
using OpenQA.Selenium;

namespace SpecFlowProject.Helpers
{
    public class Actions
    {
        private readonly IWebDriver driver;
        public Actions(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void SetText(IWebElement element, string text)
        {
            element.SendKeys(text);
            element.SendKeys(Keys.Escape);
        }

        public string GetText(IWebElement element)
        {
            return element.Text;
        }

        public void Click(IWebElement element)
        {
            element.Click();
        }

        public void AssertIsVisble(IWebElement element)
        {
            Assert.IsTrue(element.Displayed, "Element is not visible.");
        }

        public void Scroll(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void CloseBrowser()
        {
            driver.Close();
        }

        public void Pause(int num)
        {
            Thread.Sleep(num);
        }

    }
}
