using Playground.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace Playground
{
	public class Processor
	{
		public List<ProcessedCalendarData> ProcessCalendarData(CalendarObject calendarObject, CountryCode counryCodeToBeProcessed, CurrencyCode currencyCodeToBeProcessed)
		{
			List<ProcessedCalendarData> result = null;

			if (calendarObject.Source == CalendarSource.ForexFactory)
			{
				if (calendarObject.Type == CalendarType.Metal)
				{
					var imapactGroupedList = calendarObject.CalendarDataList.Where(s => s.Country == counryCodeToBeProcessed).GroupBy(s => s.Impact);
					var highImpactList = imapactGroupedList.Where(s => s.Key == Impact.High).FirstOrDefault();
					if (highImpactList != null && highImpactList.Any())
					{
						foreach (var item in highImpactList.OrderBy(s => s.DateTime))
						{

						}
					}
				}
				else if (calendarObject.Type == CalendarType.Forex)
				{

				}
			}

			return result;
		}
	}
}
