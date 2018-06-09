using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimationLibrary
{
	public class DevelopmentTask
	{
		public TimeSpan CurrentEstimate { get; set; }
		public TimeSpan TimeSpent { get; set; }

		public int CalculateRemaining()
		{
			if (CurrentEstimate >= TimeSpent)
				return CurrentEstimate.Subtract(TimeSpent).Hours;
			else
				return new TimeSpan(0).Hours;
		}
	}
}
