using ModusTempus.GUI.Statistic;
using System.Windows.Forms;
using System;
using System.Windows.Forms.DataVisualization.Charting;
using ModusTempus.Domain.ValueObjects;

namespace ModusTempus.GUI.Forms
{
	using Statistic = Domain.ValueObjects.Statistic;

	public partial class StatisticForm : Form, IStatisticView
	{
		public StatisticController Controller { get; set; }

		
		public Statistic Statistic { get; set; }

		public string StatisticName
		{
			get { return Text; }
			set { Text = value; }
		}

		public void DrawStatistic()
		{
			string[] seriesArray = { "Personal", "Average", "Expected" };
			TimeSpan[] pointsArray = { Statistic.Personal, Statistic.Average, Statistic.Expected };

			int divisor = 1;
			switch (Statistic.Unit)
			{
				case TimeUnit.Seconds:
					divisor = 1;
					break;
				case TimeUnit.Minutes:
					divisor = 60;
					break;
				case TimeUnit.Hours:
					divisor = 60 * 60;
					break;
			}

			chart.Series.Clear();

			for (int i = 0; i < seriesArray.Length; i++)
			{
				var series = chart.Series.Add(seriesArray[i]);
				series.Points.Clear();
				series.Points.Add(pointsArray[i].TotalSeconds / divisor);
			}

			chart.Series[0].Legend = "Personal";
			chart.Series[1].Legend = "Average";
			chart.Series[2].Legend = "Expected";
		}

		public StatisticForm()
		{
			InitializeComponent();

			// Set hours by default.
			timeUnitComboBox.SelectedIndex = 2;
			chart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
			Statistic = null;
		}

		private void timeUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			TimeUnit unit = (TimeUnit)Enum.Parse(typeof(TimeUnit), timeUnitComboBox.SelectedItem.ToString(), true);
			if (Statistic != null)
			{
				Statistic.Unit = unit;
				DrawStatistic();
			}
		}
	}
}
