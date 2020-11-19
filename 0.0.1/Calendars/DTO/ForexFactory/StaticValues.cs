using System;
using System.Collections.Generic;
using System.Text;

namespace My.Calendars.DTO.ForexFactory
{
	public static class StaticValues
	{
		static int _NoTrade_HoursBefore = 8;
		static int _NoTrade_MaxHoursBefore = 24;
		static int _NoTrade_HoursAfter = 8;
		static int _NoTrade_MaxHourseAfter = 12;

		public static int NoTrade_HoursBefore
		{
			get
			{
				return _NoTrade_HoursBefore;
			}
			set
			{
				_NoTrade_HoursBefore = value;
			}
		}
		public static int NoTrade_MaxHoursBefore {
			get
			{
				return _NoTrade_MaxHoursBefore;
			}
			set
			{
				_NoTrade_MaxHoursBefore = value;
			}
		}

		public static int NoTrade_HoursAfter {
			get
			{
				return _NoTrade_HoursAfter;
			}
			set
			{
				_NoTrade_HoursAfter = value;
			}
		}
		public static int NoTrade_MaxHourseAfter {
			get
			{
				return _NoTrade_MaxHourseAfter;
			}
			set
			{
				_NoTrade_MaxHourseAfter = value;
			}
		}
	}
}
