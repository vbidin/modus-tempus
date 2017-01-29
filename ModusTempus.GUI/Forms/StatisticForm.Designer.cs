namespace ModusTempus.GUI.Forms
{
	partial class StatisticForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.timeUnitComboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.SuspendLayout();
			// 
			// chart
			// 
			this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea1);
			legend1.Alignment = System.Drawing.StringAlignment.Far;
			legend1.DockedToChartArea = "ChartArea1";
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.IsDockedInsideChartArea = false;
			legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
			legend1.Name = "Personal";
			legend2.Alignment = System.Drawing.StringAlignment.Far;
			legend2.DockedToChartArea = "ChartArea1";
			legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend2.IsDockedInsideChartArea = false;
			legend2.Name = "Average";
			legend3.Alignment = System.Drawing.StringAlignment.Far;
			legend3.DockedToChartArea = "ChartArea1";
			legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend3.IsDockedInsideChartArea = false;
			legend3.Name = "Expected";
			this.chart.Legends.Add(legend1);
			this.chart.Legends.Add(legend2);
			this.chart.Legends.Add(legend3);
			this.chart.Location = new System.Drawing.Point(0, 0);
			this.chart.Name = "chart";
			this.chart.Size = new System.Drawing.Size(268, 271);
			this.chart.TabIndex = 0;
			this.chart.Text = "chart1";
			// 
			// timeUnitComboBox
			// 
			this.timeUnitComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.timeUnitComboBox.FormattingEnabled = true;
			this.timeUnitComboBox.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours"});
			this.timeUnitComboBox.Location = new System.Drawing.Point(70, 277);
			this.timeUnitComboBox.Name = "timeUnitComboBox";
			this.timeUnitComboBox.Size = new System.Drawing.Size(121, 21);
			this.timeUnitComboBox.TabIndex = 1;
			this.timeUnitComboBox.SelectedIndexChanged += new System.EventHandler(this.timeUnitComboBox_SelectedIndexChanged);
			// 
			// StatisticForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(268, 300);
			this.Controls.Add(this.timeUnitComboBox);
			this.Controls.Add(this.chart);
			this.Name = "StatisticForm";
			this.Text = "StatisticForm";
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
		private System.Windows.Forms.ComboBox timeUnitComboBox;
	}
}