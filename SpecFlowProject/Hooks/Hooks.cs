using BoDi;
using OpenQA.Selenium;
using SpecFlowProject.Drivers;

namespace SpecFlowProject.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _container;
        private IWebDriver _driver;
        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var driver = Driver.GetChromDriver();
            _driver = driver;
            _container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver?.Quit();
        }
    }
}
