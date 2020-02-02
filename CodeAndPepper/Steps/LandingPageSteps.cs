using TechTalk.SpecFlow;
using CodePepper.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeAndPepper.Pages;

namespace CodePepper.Steps
{
    [Binding]
    public class LandingPageSteps
    {
        #region Given's

        [Given(@"I open application")]
        public void GivenIOpenApplication()
        {
            string applicationUrl = "https://pluto-customer-web-app-staging.herokuapp.com/tailored-annual-or-single";

            var basePage = new BaseTest(applicationUrl);
            basePage.TestSetup();
            var loginPage = new LandingPage(basePage.driver);
            ScenarioContext.Current.Set(loginPage);
            ScenarioContext.Current.Set(basePage);
            var annualSinglePage = new AnnualSinglePage(basePage.driver);
            ScenarioContext.Current.Set(annualSinglePage);
        }

        [Then(@"I'm on correct ""(.*)"" page")]
        public void ThenIMOnCorrectPage(string pageUrl)
        {
            var landingPage = ScenarioContext.Current.Get<LandingPage>();
            landingPage.WaitForUrlLoad(pageUrl,2);
            Assert.IsTrue(landingPage.GetPageUrl().Equals(pageUrl));
        }

        [Then(@"I click Single Trip cover")]
        public void ThenIClickSingleTripCover()
        {
            var landingPage = ScenarioContext.Current.Get<LandingPage>();
            landingPage.ClickSingleTripCover();
        }

        [Then(@"I click burger menu")]
        public void ThenIClickBurgerMenu()
        {
            var landingPage = ScenarioContext.Current.Get<LandingPage>();
            landingPage.WaitUntilBurgerMenuIsVisible();
            landingPage.ClickBurgerMenu();
        }

        [Then(@"I click return home")]
        public void ThenIClickReturnHome()
        {
            var landingPage = ScenarioContext.Current.Get<LandingPage>();
            landingPage.WaitUntilReturnHomeIsVisible();
            landingPage.ClickReturnHome();
        }

        [Then(@"I see ""(.*)"" string")]
        public void ThenISeeString(string welcomeMsg)
        {
            var landingPage = ScenarioContext.Current.Get<LandingPage>();
            var welcomeString = landingPage.GetWelcomeMsg();

            Assert.AreEqual(welcomeString, welcomeMsg);
        }


        #endregion
    }
}
