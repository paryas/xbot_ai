using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Playground
{
	public static class Utility
	{
		public static Impact ToImpact(this string input)
		{
			switch (input.ToLower())
			{
				case "holiday":
					return Impact.Holiday;
				case "low":
					return Impact.Low;
				case "medium":
					return Impact.Medium;
				case "high":
					return Impact.High;
				default:
					return Impact.Unknown;
			}
		}

		public static DateTime GetFirstDayOfCurrentWeek()
		{
			var day = DateTime.Now.DayOfWeek;
			var days = day - DayOfWeek.Sunday;
			var start = DateTime.Now.AddDays(-days);
			return start;
		}

		public static DateTime GetLastDayOfCurrentWeek()
		{
			var day = DateTime.Now.DayOfWeek;
			var days = day - DayOfWeek.Sunday;
			var end = DateTime.Now.AddDays(-days+6);
			return end;
		}
	}
}
