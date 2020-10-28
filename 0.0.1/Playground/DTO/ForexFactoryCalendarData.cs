using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.DTO
{
	public class ForexFactoryCalendarData
	{
		public string Title { get; set; }
		public CountryCode Country { get; set; }
		public CurrencyCode Currency { get; set; }
		public DateTime DateTime { get; set; }
		public Impact Impact { get; set; }
		public string Forecast { get; set; }
		public string Previous { get; set; }
	}
}
