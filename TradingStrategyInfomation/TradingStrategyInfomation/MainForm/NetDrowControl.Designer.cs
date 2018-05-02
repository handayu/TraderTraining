namespace TradingStrategyInfomation.MainForm
{
	partial class NetDrowControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.Color.Black;
			this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.chart1.BackSecondaryColor = System.Drawing.Color.White;
			this.chart1.BorderlineColor = System.Drawing.Color.Gray;
			this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea1.AxisX.InterlacedColor = System.Drawing.Color.Black;
			chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
			chartArea1.AxisX.LineColor = System.Drawing.Color.Gray;
			chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
			chartArea1.AxisX2.LineColor = System.Drawing.Color.Transparent;
			chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Red;
			chartArea1.AxisY.LineColor = System.Drawing.Color.Gray;
			chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			chartArea1.BackColor = System.Drawing.Color.Black;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.BackColor = System.Drawing.Color.Black;
			legend1.ForeColor = System.Drawing.Color.Silver;
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(3, 19);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Color = System.Drawing.Color.White;
			series1.LabelBackColor = System.Drawing.Color.Transparent;
			series1.Legend = "Legend1";
			series1.MarkerBorderColor = System.Drawing.Color.Transparent;
			series1.Name = "净值";
			series1.Points.Add(dataPoint1);
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series2.ChartArea = "ChartArea1";
			series2.Color = System.Drawing.Color.Yellow;
			series2.Legend = "Legend1";
			series2.Name = "回撤率";
			series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
			series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			this.chart1.Series.Add(series1);
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(698, 299);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chart1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(704, 321);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "资金曲线";
			// 
			// NetDrowControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Controls.Add(this.groupBox1);
			this.Name = "NetDrowControl";
			this.Size = new System.Drawing.Size(704, 321);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.GroupBox groupBox1;

	}
}
