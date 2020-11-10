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

				var calendarType = groupBoxCalendarType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text.ToCalendarType();

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
	}
}
