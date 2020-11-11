using System;
using System.Collections.Generic;
using System.Text;

namespace My.Calendars.DTO.ForexFactory
{
	public class ForexFactoryCalendarData
	{
		public CalendarType CalendarType { get; set; }
		public string Title { get; set; }
		public CountryCode Country { get; set; }
		public CurrencyCode Currency { get; set; }
		public DateTime DateTime { get; set; }
		public Impact Impact { get; set; }
		public bool AllDayImpact { get; set; }
		public string Forecast { get; set; }
		public string Previous { get; set; }
	}
}
