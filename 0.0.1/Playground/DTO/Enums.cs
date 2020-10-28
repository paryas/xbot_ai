using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.DTO
{
	public enum Impact
	{
		Unknown,
		Low,
		Medium,
		High,
		Holiday,
	}

	public enum ProcessedImpact
	{
		None = 0,
		VeryLow = 1,
		Low = 2,
		Medium = 3,
		High = 4,
		VeryHigh = 5,
		Severe = 6,
		Holliday = 7,
	}

	public enum CalendarSource
	{
		ForexFactory,
	}

	public enum CalendarType
	{
		Metal,
		Forex,
	}

	public enum CurrencyCode
	{
		Unknown,
		All,
		USD,
		JPY,
		NZD,
		EUR,
		AUD,
		CHF,
		GBP,
		CNY,
		CAD,
	}

	public enum CountryCode
	{
		Unknown,
		GE, //Germany
		UK, //United Kingdom
		MX, //Mexico
		US, //United States
		SZ, //Switzerland
		JN, //Japan
		SP, //Spain
		EZ, //Euro Zone
		AU, //Australia
		SA, //South Africa
		FR, //France
		IT, //Italy
		BZ, //Brazil
		CH, //China
		WW, //World Wide
		RU, //Russia
		IN, //India
		NZ, //New Zeland
		CA, //Canada
	}
}
