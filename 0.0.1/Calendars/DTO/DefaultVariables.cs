using System;
using System.Collections.Generic;
using System.Text;

namespace My.Calendars.DTO
{
	public static class DefaultVariables
	{
		static int HoursBeforeRedFlag_ToStopTrading = 10;
		static int HoursAfterRedFlag_ToStopTrading = 6;
		static int NumberOfRedFlagPerWindowTime_ToStopTradingTheSameDayAndTheDayBefore = 3;
		static int WindowTime_ToConsiderAsWhole = 1;
	}
}
