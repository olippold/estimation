using System;
using TechTalk.SpecFlow;

namespace TestEstimationTool
{
    [Binding]
    public class EstimatingSteps
    {
        [Given(@"I have entered a current estimate of (.*) hours")]
        public void GivenIHaveEnteredACurrentEstimateOfHours(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered (.*) hours as time taken")]
        public void GivenIHaveEnteredHoursAsTimeTaken(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I calculate remaining time")]
        public void WhenICalculateRemainingTime()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) hour")]
        public void ThenTheResultShouldBeHour(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
