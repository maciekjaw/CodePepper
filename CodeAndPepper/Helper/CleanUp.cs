using CodePepper.Tests;
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
