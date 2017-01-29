using System;

namespace ModusTempus.Domain.ValueObjects
{
	public class Statistic
	{
		public TimeSpan Personal { get; set; }
		public TimeSpan Average { get; set; }
		public TimeSpan Expected { get; set; }

		public TimeUnit Unit { get; set; }

		public Statistic(TimeSpan personal, TimeSpan average, TimeSpan expected)
		{
			Personal = personal;
			Average = average;
			Expected = expected;
			Unit = TimeUnit.Seconds;
		}
	}
}
