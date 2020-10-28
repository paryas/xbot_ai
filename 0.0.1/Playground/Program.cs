//using HtmlAgilityPack;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace Playground
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Start ...");

			var startDate = Utility.GetFirstDayOfCurrentWeek();
			var endDate = Utility.GetLastDayOfCurrentWeek();
			//var calendarType = CalendarType.Metal;
			var calendarType = CalendarType.Forex;

			//var link = @"C:\Users\Pouyan\Downloads\mm_calendar_thisweek.csv";
			var link = @"C:\Users\Pouyan\Downloads\ff_calendar_thisweek.csv";
			var lines = File.ReadAllLines(link).ToList();
			lines.RemoveAt(0);

			var forexFactoryCalendarList = new List<ForexFactoryCalendarItem>();
			foreach (var line in lines)
			{
				string[] values = line.Split(',');
				var forexFactoryCalendarItem = new ForexFactoryCalendarItem();
				forexFactoryCalendarItem.Title = values[0];
				if (calendarType == CalendarType.Metal)
				{
					forexFactoryCalendarItem.Country = values[1].ToCountryCode();
				}
				else if (calendarType == CalendarType.Forex)
				{
					forexFactoryCalendarItem.Currency = values[1].ToCurrencyCode();
				}
				forexFactoryCalendarItem.DateTime = Convert.ToDateTime(values[2] + " " + values[3]);
				forexFactoryCalendarItem.Impact = values[4].ToImpact();
				forexFactoryCalendarItem.Forecast = values[5];
				forexFactoryCalendarItem.Previous = values[6];

				forexFactoryCalendarList.Add(forexFactoryCalendarItem);
			}

			//var unknown = forexFactoryCalendarList.Where(s => s.Country == CountryCode.Unknown).ToList();
			var unknown = forexFactoryCalendarList.Where(s => s.Currency == CurrencyCode.Unknown).ToList();

			#region HtmlAgilityPack
			/*
			HtmlNode nodesS;

			var link = @"C:\Users\Pouyan\Documents\Calendar _ Forex Factory.html";

			using (var myWebClient = new WebClient())
			{
				//myWebClient.Headers["User-Agent"] = "MOZILLA/5.0 (WINDOWS NT 6.1; WOW64) APPLEWEBKIT/537.1 (KHTML, LIKE GECKO) CHROME/21.0.1180.75 SAFARI/537.1";

				string page = myWebClient.DownloadString(link);

				HtmlDocument doc = new HtmlDocument();
				doc.LoadHtml(page);

				HtmlNode tableRows = doc.DocumentNode.SelectSingleNode("//table[@class='calendar__table']//tr");


			}

			System.Net.WebClient wc = new System.Net.WebClient();
			wc.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 6.0; " +
								  "Windows NT 5.2; .NET CLR 1.0.3705;)");
			byte[] raw = wc.DownloadData(link);

			string webData = System.Text.Encoding.UTF8.GetString(raw);



			//var doc = new HtmlDocument();
			//doc.LoadHtml(link);



			//const string classValue = "calendar__row calendar_row calendar__row--grey calendar__row--alt alt";

			//var link = @"https://www.forexfactory.com/calendar.php?month=last";

			//var web = new HtmlWeb();
			//var doc = web.Load(link);

			////var doc = new HtmlAgilityPack.HtmlDocument();
			//doc.LoadHtml(link);

			//var nodesB = doc.DocumentNode.SelectNodes("//body//div"); //$"//*[@class='{classValue}']");
			//var nodesD = doc.DocumentNode.SelectNodes("//div[@class='site--isdesktop']"); //$"//*[@class='{classValue}']");
			//var nodes = doc.DocumentNode.SelectNodes("//table[@class='calendar__table']"); //$"//*[@class='{classValue}']");
			////var nodesS = doc.DocumentNode.SelectSingleNode("(//table[@class='calendar__table'])"); //$"//*[@class='{classValue}']");
			//var nodes0 = doc.DocumentNode.SelectNodes("//table[0]"); //$"//*[@class='{classValue}']");
			//var nodes1 = doc.DocumentNode.SelectNodes("//table[1]"); //$"//*[@class='{classValue}']");
			//var nodes2 = doc.DocumentNode.SelectNodes("//table[2]"); //$"//*[@class='{classValue}']");
			*/
			#endregion

			Console.WriteLine("End ...");
			Console.ReadLine();
		}
	}
}
