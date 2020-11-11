using My.Calendars.DTO;
using My.Calendars.DTO.ForexFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace My.Calendars.Domain.ForexFactory
{
	public class Processor
	{
		private ProcessorStrategy _ProcessorStrategy;
		CalendarType _calendarType;

		public Processor(CalendarType calendarType, ProcessorStrategy processorStrategy)
		{
			_ProcessorStrategy = processorStrategy;
			_calendarType = calendarType;
		}

		#region Forex Strategies
		public Dictionary<DateTime, bool> ProcessForexCalendarData_StrategyOne(List<ForexFactoryCalendarData> calendarDataList)
		{
			Dictionary<DateTime, bool> result = new Dictionary<DateTime, bool>();

			var noTradeDayList = calendarDataList.Where(s => s.Impact == Impact.High).GroupBy(s => new DateTime(s.DateTime.Year, s.DateTime.Month, s.DateTime.Day))
				.Select(s => new { s.Key, Count = s.Count() }).Where(s => s.Count >= DefaultVariables.NumberOfRedFlagPerDay_ToStopTradingTheSameDayAndTheDayBefore)
				.Select(s => s.Key).ToList();

			var holdaylist = calendarDataList.Where(s => s.Impact == Impact.Holiday).Select(s => new DateTime(s.DateTime.Year, s.DateTime.Month, s.DateTime.Day)).ToList();

			var allDaysImpactList = calendarDataList.Where(s => s.AllDayImpact).Select(s => new DateTime(s.DateTime.Year, s.DateTime.Month, s.DateTime.Day)).ToList();

			calendarDataList.RemoveAll(s => s.Impact == Impact.Holiday);
			calendarDataList.RemoveAll(s => s.AllDayImpact);

			var hourlyImpactList = calendarDataList.Select(s => s.DateTime).ToList();

			foreach (var item in calendarDataList)
			{

			}

			return result;
		}
		#endregion

		/*
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
		*/
	}
}
