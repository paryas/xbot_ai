using System;
using System.Collections.Generic;
using System.Text;

namespace My.Calendars.DTO.ForexFactory
{
	public class ProcessedCalendarData
	{
		public ProcessedImpact Impact { get; set; }
		public CurrencyCode CurrencyCode { get; set; }
		public CurrencyCode CountryCode { get; set; }
	}

}
