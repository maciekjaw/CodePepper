using TechTalk.SpecFlow;
using CodeAndPepper.Pages;
using CodePepper.Pages;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeAndPepper.Steps
{
    [Binding]
    public class AnnualSingleSteps
    {

        [Then(@"I check if Next button is disable")]
        public void ThenICheckIfNextButtonIsDisable()
        {
            var annualSinglePage = ScenarioContext.Current.Get<AnnualSinglePage>();
            annualSinglePage.WaitUntilNextBtnIsVisible();
            bool IsNextBtnEnabled = annualSinglePage.IsNextBtnEnabled();

            Assert.IsFalse(IsNextBtnEnabled);
        }

        [Then(@"I check if Next button is not disable")]
        public void ThenICheckIfNextButtonIsNotDisable()
        {
            var annualSinglePage = ScenarioContext.Current.Get<AnnualSinglePage>();
            annualSinglePage.WaitUntilNextBtnIsVisible();
            bool IsNextBtnEnabled = annualSinglePage.IsNextBtnEnabled();

            Assert.IsTrue(IsNextBtnEnabled);
        }

        [Then(@"I type country")]
        public void ThenITypeCountry()
        {
            var annualSinglePage = ScenarioContext.Current.Get<AnnualSinglePage>();
            annualSinglePage.WaitUntilCountryPlaceholderIsVisible();
            annualSinglePage.TypeInCountry();
        }
    }
}
