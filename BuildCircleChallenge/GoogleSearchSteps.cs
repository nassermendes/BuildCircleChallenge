using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace BuildCircleChallenge
{
    [Binding]
    public class GoogleSearchSteps
    {
            IWebDriver driver = new ChromeDriver();
            private IWebElement searchInput;


            [Given(@"I have opened Google page")]
            public void GivenIHaveOpenedGooglePage()
            {
                driver.Navigate().GoToUrl("https://www.google.co.uk");
            }
        
            [Given(@"I have entered Build Circle on the Search bar")]
            public void GivenIHaveEnteredBuildCircleOnTheSearchBar()
            {
                searchInput = driver.FindElement(By.Name("q"));
                    searchInput.SendKeys("Build Circle");
            }
        
            [When(@"I press Search button")]
            public void WhenIPressSearchButton()
            {
                driver.FindElement(By.Name("btnK")).Click();
            }
        
            [Then(@"a new page showing the search results should appear")]
            public void ThenANewPageShowingTheSearchResultsShouldAppear()
            {
                Assert.IsNotNull(searchInput);
            }

    }
}
