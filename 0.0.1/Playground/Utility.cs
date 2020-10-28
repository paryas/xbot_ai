using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Playground
{
	public static class Utility
	{
		public static Impact ToImpact(this string input)
		{
			switch (input.ToLower())
			{
				case "holiday":
					return Impact.Holiday;
				case "low":
					return Impact.Low;
				case "medium":
					return Impact.Medium;
				case "high":
					return Impact.High;
				default:
					return Impact.Unknown;
			}
		}

		public static CountryCode ToCountryCode(this string input)
		{
			switch (input.ToLower())
			{
				case "ww":
					return CountryCode.WW;
				case "ge":
					return CountryCode.GE;
				case "uk":
					return CountryCode.UK;
				case "mx":
					return CountryCode.MX;
				case "us":
					return CountryCode.US;
				case "sz":
					return CountryCode.SZ;
				case "jn":
					return CountryCode.JN;
				case "sp":
					return CountryCode.SP;
				case "ez":
					return CountryCode.EZ;
				case "au":
					return CountryCode.AU;
				case "sa":
					return CountryCode.SA;
				case "fr":
					return CountryCode.FR;
				case "it":
					return CountryCode.IT;
				case "bz":
					return CountryCode.BZ;
				case "ch":
					return CountryCode.CH;
				case "ru":
					return CountryCode.RU;
				case "in":
					return CountryCode.IN;
				case "nz":
					return CountryCode.NZ;
				case "ca":
					return CountryCode.CA;
				default:
					return CountryCode.Unknown;
			}
		}

		public static CurrencyCode ToCurrencyCode(this string input)
		{
			switch (input.ToLower())
			{
				case "all":
					return CurrencyCode.All;
				case "usd":
					return CurrencyCode.USD;
				case "jpy":
					return CurrencyCode.JPY;
				case "nzd":
					return CurrencyCode.NZD;
				case "eur":
					return CurrencyCode.EUR;
				case "aud":
					return CurrencyCode.AUD;
				case "chf":
					return CurrencyCode.CHF;
				case "gbp":
					return CurrencyCode.GBP;
				case "cny":
					return CurrencyCode.CNY;
				case "cad":
					return CurrencyCode.CAD;
				default:
					return CurrencyCode.Unknown;
			}
		}

		public static DateTime GetFirstDayOfCurrentWeek()
		{
			var day = DateTime.Now.DayOfWeek;
			var days = day - DayOfWeek.Sunday;
			var start = DateTime.Now.AddDays(-days);
			return start;
		}

		public static DateTime GetLastDayOfCurrentWeek()
		{
			var day = DateTime.Now.DayOfWeek;
			var days = day - DayOfWeek.Sunday;
			var end = DateTime.Now.AddDays(-days+6);
			return end;
		}
	}
}
