using System;
using System.Collections.Generic;
using System.Text;

namespace My.Calendars.DTO.ForexFactory
{
	public class CalendarObject
	{
		public List<ForexFactoryCalendarData> CalendarDataList { get; set; }
		public CalendarSource Source { get; set; }
		public CalendarType Type { get; set; }
	}
}
