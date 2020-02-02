using CodePepper.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;


namespace CodePepper.Helper
{

    [Binding]
    public class CleanUp
    {
        [AfterScenario]
        public void Cleanup()
        {
            ScenarioContext.Current.Get<BaseTest>().TestCleanUp();
        }
    }
}
