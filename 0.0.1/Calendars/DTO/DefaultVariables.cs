﻿using System;
using System.Collections.Generic;
using System.Text;

namespace My.Calendars.DTO
{
	public static class DefaultVariables
	{
		public static string ProcessedFolderAddress = "C:\\xbot\\ai";
		public static int HoursBeforeRedFlag_ToStopTrading = 10;
		public static int HoursAfterRedFlag_ToStopTrading = 6;
		public static int NumberOfRedFlagPerWindowTime_ToStopTradingTheSameDayAndTheDayBefore = 3;
		public static int WindowTime_ToConsiderAsWhole = 1;
	}
}
