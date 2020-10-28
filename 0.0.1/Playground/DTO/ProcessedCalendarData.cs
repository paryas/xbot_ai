using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.DTO
{
	public class ProcessedCalendarData
	{
		public ProcessedImpact Impact { get; set; }
		public CurrencyCode CurrencyCode { get; set; }
		public CurrencyCode CountryCode { get; set; }
	}

}
