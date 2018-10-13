using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildCircleChallenge;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

                GoogleSearchSteps steps = new GoogleSearchSteps();
                steps.GivenIHaveOpenedGooglePage();
                steps.GivenIHaveEnteredBuildCircleOnTheSearchBar();
                steps.WhenIPressSearchButton();
                steps.ThenANewPageShowingTheSearchResultsShouldAppear();
                //driver.Navigate().GoToUrl("https://www.google.co.uk");
                //driver.FindElement(By.Name("q")).SendKeys("Build Circle");
                //driver.FindElement(By.Name("btnK")).Click();

        }
    }
}
