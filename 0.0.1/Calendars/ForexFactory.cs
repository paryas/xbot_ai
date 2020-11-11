using My.Calendars.Common.ForexFactory;
using My.Calendars.Domain.ForexFactory;
using My.Calendars.DTO;
using My.Calendars.DTO.ForexFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace My.Calendars
{
	public partial class ForexFactory : Form
	{
		public ForexFactory()
		{
			InitializeComponent();
		}

		private void btnUpload_Click(object sender, EventArgs e)
		{
			#region Init
			DefaultVariables.ProcessedFolderAddress = txtProcessedFolderAddress.Text;
			var dialog = new OpenFileDialog();
			dialog.Filter = "CSV files (*.csv)|*.csv";
			dialog.Multiselect = false;
			var calendarDataList = new List<ForexFactoryCalendarData>();

			var calendarType = cboCalendarType.SelectedValue.ToString().ToCalendarType();
			var strategy = cboStrategy.SelectedValue.ToString().ToProcessorStrategy();
			var currencyOne = cboCurrencyOne.Text;
			var currencyTwo = cboCurrencyTwo.Text;
			var countryOne = cboCountryOne.Text;
			var countryTwo = cboCountryTwo.Text;
			#endregion

			#region Load the calendar file
			if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
			{
				String path = dialog.FileName; // get name of file
				List<string> lines = null;
				if (calendarType == CalendarType.Forex)
					lines = File.ReadAllLines(path).Where(s => s.ToLower().Contains(currencyOne.ToLower()) || s.ToLower().Contains(currencyTwo.ToLower()) || s.ToLower().Contains(CurrencyCode.All.ToString().ToLower()))
						.Where(s => s.ToLower().Contains(Impact.High.ToString().ToLower()) || s.ToLower().Contains(Impact.Holiday.ToString().ToLower())).ToList();
				else if (calendarType == CalendarType.Metal)
					lines = File.ReadAllLines(path).Where(s => s.ToLower().Contains(countryOne.ToLower()) || s.ToLower().Contains(countryTwo.ToLower()) || s.ToLower().Contains(CountryCode.All.ToString().ToLower()))
						.Where(s => s.ToLower().Contains(Impact.High.ToString().ToLower()) || s.ToLower().Contains(Impact.Holiday.ToString().ToLower())).ToList();

				foreach (var line in lines)
				{
					string[] values = line.Split(',');
					var forexFactoryCalendarItem = new ForexFactoryCalendarData();
					forexFactoryCalendarItem.Title = values[0];
					if (calendarType == CalendarType.Forex)
					{
						forexFactoryCalendarItem.Currency = values[1].ToCurrencyCode();
						forexFactoryCalendarItem.Country = CountryCode.Unknown;
					}
					else if (calendarType == CalendarType.Metal)
					{
						forexFactoryCalendarItem.Country = values[1].ToCountryCode();
						forexFactoryCalendarItem.Currency = CurrencyCode.Unknown;
					}
					forexFactoryCalendarItem.CalendarType = calendarType;
					if (values[3].ToLower().Contains("all day"))
					{
						forexFactoryCalendarItem.DateTime = Convert.ToDateTime(values[2]);
						forexFactoryCalendarItem.AllDayImpact = true;
					}
					else
					{
						forexFactoryCalendarItem.DateTime = Convert.ToDateTime(values[2] + " " + values[3]);
						forexFactoryCalendarItem.AllDayImpact = false;
					}
					forexFactoryCalendarItem.Impact = values[4].ToImpact();
					forexFactoryCalendarItem.Forecast = values[5];
					forexFactoryCalendarItem.Previous = values[6];

					calendarDataList.Add(forexFactoryCalendarItem);
				}
			}
			#endregion

			#region Process Calendar List
			var processor = new Processor(calendarType, strategy);

			var processedResult = processor.ProcessForexCalendarData_StrategyOne(calendarDataList);
			#endregion
		}

		private void ForexFactory_Load(object sender, EventArgs e)
		{
			#region Load UI Objects
			var calendarTypes = Enum.GetValues(typeof(CalendarType));
			cboCalendarType.DataSource = calendarTypes;
			cboCalendarType.SelectedIndex = 0;

			var currencyCodes1 = Enum.GetValues(typeof(CurrencyCode));
			cboCurrencyOne.DataSource = currencyCodes1;
			cboCurrencyOne.SelectedIndex = 5;

			var currencyCodes2 = Enum.GetValues(typeof(CurrencyCode));
			cboCurrencyTwo.DataSource = currencyCodes2;
			cboCurrencyTwo.SelectedIndex = 9;

			var countryCodes1 = Enum.GetValues(typeof(CountryCode));
			cboCountryOne.DataSource = countryCodes1;
			cboCountryOne.SelectedIndex = 17;

			var countryCodes2 = Enum.GetValues(typeof(CountryCode));
			cboCountryTwo.DataSource = countryCodes2;
			cboCountryTwo.SelectedIndex = 19;

			var strategy = Enum.GetValues(typeof(ProcessorStrategy));
			cboStrategy.DataSource = strategy;
			cboStrategy.SelectedIndex = 1;

			txtProcessedFolderAddress.Text = DefaultVariables.ProcessedFolderAddress;
			#endregion
		}

		private void cboCalendarType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboCalendarType.SelectedIndex == 0)
			{
				cboCurrencyOne.Enabled = true;
				cboCurrencyTwo.Enabled = true;

				cboCountryOne.Enabled = false;
				cboCountryTwo.Enabled = false;
			}
			else if (cboCalendarType.SelectedIndex == 1)
			{
				cboCurrencyOne.Enabled = false;
				cboCurrencyTwo.Enabled = false;

				cboCountryOne.Enabled = true;
				cboCountryTwo.Enabled = true;
			}
		}

		private void btnFolder_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					txtProcessedFolderAddress.Text = fbd.SelectedPath;
				}
			}
		}
	}
}
