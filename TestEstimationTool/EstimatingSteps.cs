using System;
using TechTalk.SpecFlow;
using EstimationLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEstimationTool
{
    [Binding]
    public class EstimatingSteps
    {
		private DevelopmentTask _task = new DevelopmentTask();
		int result = 0;

		[Given(@"I have entered a current estimate of (.*) hours")]
        public void GivenIHaveEnteredACurrentEstimateOfHours(int hours)
        {
			_task.CurrentEstimate = TimeSpan.FromHours(hours);
        }
        
        [Given(@"I have entered (.*) hours as time taken")]
        public void GivenIHaveEnteredHoursAsTimeTaken(int hours)
        {
			_task.TimeSpent = TimeSpan.FromHours(hours);
		}

		[When(@"I calculate remaining time")]
        public void WhenICalculateRemainingTime()
        {
			result = _task.CalculateRemaining();
        }
        
		[Then(@"the result should be (.*) hour\(s\)")]
		public void ThenTheResultShouldBeHourS(int hours)
		{
			Assert.AreEqual(hours, result);
		}

	}
}
