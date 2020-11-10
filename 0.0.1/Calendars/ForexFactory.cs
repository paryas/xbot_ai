using My.Calendars.Common.ForexFactory;
using My.Calendars.DTO.ForexFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
			var dialog = new OpenFileDialog();
			dialog.Filter = "CSV files (*.csv)|*.csv";
			dialog.Multiselect = false;
			var calendarDataList = new List<ForexFactoryCalendarData>();

			#region Load the calendar file
			if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
			{
				String path = dialog.FileName; // get name of file
				var lines = File.ReadAllLines(path).ToList();
				lines.RemoveAt(0);

				var calendarType = cboCalendarType.SelectedValue.ToString().ToCalendarType();

				foreach (var line in lines)
				{
					string[] values = line.Split(',');
					var forexFactoryCalendarItem = new ForexFactoryCalendarData();
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

					calendarDataList.Add(forexFactoryCalendarItem);
				}
			}
			#endregion

			#region Process Calendar List

			#endregion
		}

		private void ForexFactory_Load(object sender, EventArgs e)
		{
			#region Load Combos
			var calendarTypes = Enum.GetValues(typeof(CalendarType));
			cboCalendarType.DataSource = calendarTypes;
			cboCalendarType.SelectedIndex = 0;

			var currencyCodes1 = Enum.GetValues(typeof(CurrencyCode));
			cboFirstPair.DataSource = currencyCodes1;
			cboFirstPair.SelectedIndex = 5;

			var currencyCodes2 = Enum.GetValues(typeof(CurrencyCode));
			cboSecondPair.DataSource = currencyCodes2;
			cboSecondPair.SelectedIndex = 9;

			var countryCodes1 = Enum.GetValues(typeof(CountryCode));
			cboFirstCountry.DataSource = countryCodes1;
			cboFirstCountry.SelectedIndex = 17;

			var countryCodes2 = Enum.GetValues(typeof(CountryCode));
			cboSecondCountry.DataSource = countryCodes2;
			cboSecondCountry.SelectedIndex = 19;
			#endregion
		}

		private void cboCalendarType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboCalendarType.SelectedIndex == 0)
			{
				cboFirstPair.Enabled = true;
				cboSecondPair.Enabled = true;

				cboFirstCountry.Enabled = false;
				cboSecondCountry.Enabled = false;
			}
			else if (cboCalendarType.SelectedIndex == 1)
			{
				cboFirstPair.Enabled = false;
				cboSecondPair.Enabled = false;

				cboFirstCountry.Enabled = true;
				cboSecondCountry.Enabled = true;
			}
		}

		private void btnFolder_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					txtFolder.Text = fbd.SelectedPath;
				}
			}
		}
	}
}
