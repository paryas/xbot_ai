using System;
using System.Collections.Generic;
using System.Text;

namespace My.Calendars.DTO.ForexFactory
{
	public enum ProcessorStrategy
	{
		Unknown,
		StrategyOne,
	}

	public enum Impact
	{
		Unknown,
		Low,
		Medium,
		High,
		Holiday,
	}

	public enum CalendarType
	{
		Forex,
		Metal,
	}

	public enum CurrencyCode
	{
		All,
		AUD,
		CAD,
		CHF,
		CNY,
		EUR,
		GBP,
		JPY,
		NZD,
		USD,
		Unknown,
	}

	public enum CountryCode
	{
		All,
		AU, //Australia
		BZ, //Brazil
		CA, //Canada
		CH, //China
		EZ, //Euro Zone
		FR, //France
		GE, //Germany
		IN, //India
		IT, //Italy
		JN, //Japan
		MX, //Mexico
		NZ, //New Zeland
		RU, //Russia
		SA, //South Africa
		SP, //Spain
		SZ, //Switzerland
		UK, //United Kingdom
		US, //United States
		WW, //World Wide
		Unknown,
	}

	#region Removed
	//public enum ProcessedImpact
	//{
	//	None = 0,
	//	VeryLow = 1,
	//	Low = 2,
	//	Medium = 3,
	//	High = 4,
	//	VeryHigh = 5,
	//	Severe = 6,
	//	Holliday = 7,
	//}

	//public enum CalendarSource
	//{
	//	ForexFactory,
	//}
	#endregion
}
