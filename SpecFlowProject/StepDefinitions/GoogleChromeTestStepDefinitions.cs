using OpenQA.Selenium;
using SpecFlowProject.Drivers;
using SpecFlowProject.Helpers;
using SpecFlowProject.POM;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class GoogleChromeTestStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly Actions _actions;
        private readonly Homepage _homepage;
        private readonly SearchPage _searchpage;

        public GoogleChromeTestStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
            _actions = new Actions(driver);
            _homepage = new Homepage(driver);
            _searchpage = new SearchPage(driver);
        }

        [Given(@"I am in Google home page")]
        public void GivenIAmInGoogleHomePage()
        {
            _actions.Navigate(Globals.BaseUrl);
        }

        [Given(@"I accept the cookies")]
        public void GivenIAcceptTheCookies()
        {
            _actions.Click(_homepage.AcceptCookies);
        }

        [When(@"I type in ""([^""]*)""")]
        public void WhenITypeIn(string text)
        {
            _actions.SetText(_homepage.HomeSearchInput, text);
        }

        [When(@"I click search button")]
        public void WhenIClickSearchButton()
        {
            _actions.Click(_homepage.HomeSearchButton);
        }

        [When(@"I should be redirected to the search page")]
        public void WhenIShouldBeRedirectedToTheSearchPage()
        {
            _actions.AssertIsVisble(_searchpage.SearchedResultsBreadCrumbs);
        }

        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            _actions.CloseBrowser();
        }
    }
}
