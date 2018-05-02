namespace TradingStrategyInfomation
{
	partial class KLine
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0,0,0");
			System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox_timer = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button_Timer = new System.Windows.Forms.Button();
			this.button_cusTick = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button_low4 = new System.Windows.Forms.Button();
			this.button_low3 = new System.Windows.Forms.Button();
			this.button_low2 = new System.Windows.Forms.Button();
			this.button_low1 = new System.Windows.Forms.Button();
			this.button_add4 = new System.Windows.Forms.Button();
			this.button_add3 = new System.Windows.Forms.Button();
			this.button_add2 = new System.Windows.Forms.Button();
			this.button_add1 = new System.Windows.Forms.Button();
			this.timer_RealMarket = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.80503F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.19497F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 321);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.chart1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.chart2, 0, 1);
			this.tableLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Cross;
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.21277F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.78723F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(460, 315);
			this.tableLayoutPanel2.TabIndex = 2;
			this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
			// 
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.Color.Black;
			this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.chart1.BackSecondaryColor = System.Drawing.Color.White;
			this.chart1.BorderlineColor = System.Drawing.Color.Gray;
			this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea5.AxisX.InterlacedColor = System.Drawing.Color.Black;
			chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
			chartArea5.AxisX.LineColor = System.Drawing.Color.Gray;
			chartArea5.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
			chartArea5.AxisX2.LineColor = System.Drawing.Color.Transparent;
			chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Red;
			chartArea5.AxisY.LineColor = System.Drawing.Color.Gray;
			chartArea5.AxisY.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			chartArea5.BackColor = System.Drawing.Color.Black;
			chartArea5.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea5);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			legend5.BackColor = System.Drawing.Color.Black;
			legend5.ForeColor = System.Drawing.Color.Silver;
			legend5.Name = "Legend1";
			this.chart1.Legends.Add(legend5);
			this.chart1.Location = new System.Drawing.Point(4, 4);
			this.chart1.Name = "chart1";
			series13.ChartArea = "ChartArea1";
			series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series13.Color = System.Drawing.Color.White;
			series13.LabelBackColor = System.Drawing.Color.Transparent;
			series13.Legend = "Legend1";
			series13.MarkerBorderColor = System.Drawing.Color.Transparent;
			series13.Name = "实时走势";
			series13.Points.Add(dataPoint3);
			series13.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
			series13.YValuesPerPoint = 4;
			series13.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
			series14.ChartArea = "ChartArea1";
			series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series14.Color = System.Drawing.Color.Yellow;
			series14.Legend = "Legend1";
			series14.Name = "均线";
			series14.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
			this.chart1.Series.Add(series13);
			this.chart1.Series.Add(series14);
			this.chart1.Size = new System.Drawing.Size(452, 213);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// chart2
			// 
			this.chart2.BackColor = System.Drawing.Color.Black;
			this.chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.chart2.BackSecondaryColor = System.Drawing.Color.White;
			this.chart2.BorderlineColor = System.Drawing.Color.Gray;
			this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea6.AxisX.InterlacedColor = System.Drawing.Color.Black;
			chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
			chartArea6.AxisX.LineColor = System.Drawing.Color.Gray;
			chartArea6.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
			chartArea6.AxisX2.LineColor = System.Drawing.Color.Transparent;
			chartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
			chartArea6.AxisY.LineColor = System.Drawing.Color.DarkGray;
			chartArea6.BackColor = System.Drawing.Color.Black;
			chartArea6.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea6);
			this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
			legend6.BackColor = System.Drawing.Color.Black;
			legend6.ForeColor = System.Drawing.Color.Silver;
			legend6.Name = "Legend1";
			this.chart2.Legends.Add(legend6);
			this.chart2.Location = new System.Drawing.Point(4, 224);
			this.chart2.Name = "chart2";
			series15.BorderColor = System.Drawing.Color.Transparent;
			series15.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			series15.ChartArea = "ChartArea1";
			series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series15.Color = System.Drawing.Color.Yellow;
			series15.LabelBackColor = System.Drawing.Color.Transparent;
			series15.Legend = "Legend1";
			series15.MarkerBorderColor = System.Drawing.Color.Transparent;
			series15.Name = "K";
			series15.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
			series15.YValuesPerPoint = 4;
			series15.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
			series16.ChartArea = "ChartArea1";
			series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series16.Legend = "Legend1";
			series16.Name = "D";
			series17.ChartArea = "ChartArea1";
			series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series17.Legend = "Legend1";
			series17.Name = "Uplimit";
			series18.ChartArea = "ChartArea1";
			series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series18.Legend = "Legend1";
			series18.Name = "Lowlimit";
			this.chart2.Series.Add(series15);
			this.chart2.Series.Add(series16);
			this.chart2.Series.Add(series17);
			this.chart2.Series.Add(series18);
			this.chart2.Size = new System.Drawing.Size(452, 87);
			this.chart2.TabIndex = 1;
			this.chart2.Text = "chart2";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBox_timer);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button_Timer);
			this.panel1.Controls.Add(this.button_cusTick);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.button_low4);
			this.panel1.Controls.Add(this.button_low3);
			this.panel1.Controls.Add(this.button_low2);
			this.panel1.Controls.Add(this.button_low1);
			this.panel1.Controls.Add(this.button_add4);
			this.panel1.Controls.Add(this.button_add3);
			this.panel1.Controls.Add(this.button_add2);
			this.panel1.Controls.Add(this.button_add1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(469, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(322, 315);
			this.panel1.TabIndex = 3;
			// 
			// textBox_timer
			// 
			this.textBox_timer.BackColor = System.Drawing.SystemColors.InfoText;
			this.textBox_timer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_timer.ForeColor = System.Drawing.SystemColors.Info;
			this.textBox_timer.Location = new System.Drawing.Point(16, 188);
			this.textBox_timer.Name = "textBox_timer";
			this.textBox_timer.Size = new System.Drawing.Size(117, 23);
			this.textBox_timer.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.ForeColor = System.Drawing.Color.Chocolate;
			this.label1.Location = new System.Drawing.Point(16, 170);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 17);
			this.label1.TabIndex = 11;
			this.label1.Text = "定时器间隔:";
			// 
			// button_Timer
			// 
			this.button_Timer.BackColor = System.Drawing.Color.Firebrick;
			this.button_Timer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Timer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_Timer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_Timer.Location = new System.Drawing.Point(139, 187);
			this.button_Timer.Name = "button_Timer";
			this.button_Timer.Size = new System.Drawing.Size(75, 23);
			this.button_Timer.TabIndex = 10;
			this.button_Timer.Text = "启动测试";
			this.button_Timer.UseVisualStyleBackColor = false;
			this.button_Timer.Click += new System.EventHandler(this.button_Timer_Click);
			// 
			// button_cusTick
			// 
			this.button_cusTick.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.button_cusTick.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_cusTick.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_cusTick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_cusTick.Location = new System.Drawing.Point(140, 136);
			this.button_cusTick.Name = "button_cusTick";
			this.button_cusTick.Size = new System.Drawing.Size(75, 23);
			this.button_cusTick.TabIndex = 9;
			this.button_cusTick.Text = "Cus-Tick";
			this.button_cusTick.UseVisualStyleBackColor = false;
			this.button_cusTick.Click += new System.EventHandler(this.button_cusTick_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
			this.textBox1.Location = new System.Drawing.Point(16, 136);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(118, 23);
			this.textBox1.TabIndex = 8;
			// 
			// button_low4
			// 
			this.button_low4.BackColor = System.Drawing.Color.Firebrick;
			this.button_low4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_low4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_low4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_low4.Location = new System.Drawing.Point(137, 107);
			this.button_low4.Name = "button_low4";
			this.button_low4.Size = new System.Drawing.Size(75, 23);
			this.button_low4.TabIndex = 7;
			this.button_low4.Text = "Low-4T";
			this.button_low4.UseVisualStyleBackColor = false;
			this.button_low4.Click += new System.EventHandler(this.button_low4_Click);
			// 
			// button_low3
			// 
			this.button_low3.BackColor = System.Drawing.Color.Firebrick;
			this.button_low3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_low3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_low3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_low3.Location = new System.Drawing.Point(137, 77);
			this.button_low3.Name = "button_low3";
			this.button_low3.Size = new System.Drawing.Size(75, 23);
			this.button_low3.TabIndex = 6;
			this.button_low3.Text = "Low-3T";
			this.button_low3.UseVisualStyleBackColor = false;
			this.button_low3.Click += new System.EventHandler(this.button_low3_Click);
			// 
			// button_low2
			// 
			this.button_low2.BackColor = System.Drawing.Color.Firebrick;
			this.button_low2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_low2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_low2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_low2.Location = new System.Drawing.Point(137, 45);
			this.button_low2.Name = "button_low2";
			this.button_low2.Size = new System.Drawing.Size(75, 23);
			this.button_low2.TabIndex = 5;
			this.button_low2.Text = "Low-2T";
			this.button_low2.UseVisualStyleBackColor = false;
			this.button_low2.Click += new System.EventHandler(this.button_low2_Click);
			// 
			// button_low1
			// 
			this.button_low1.BackColor = System.Drawing.Color.Firebrick;
			this.button_low1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_low1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_low1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_low1.Location = new System.Drawing.Point(137, 14);
			this.button_low1.Name = "button_low1";
			this.button_low1.Size = new System.Drawing.Size(75, 23);
			this.button_low1.TabIndex = 4;
			this.button_low1.Text = "Low-1T";
			this.button_low1.UseVisualStyleBackColor = false;
			this.button_low1.Click += new System.EventHandler(this.button_low1_Click);
			// 
			// button_add4
			// 
			this.button_add4.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button_add4.FlatAppearance.BorderSize = 0;
			this.button_add4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_add4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_add4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_add4.Location = new System.Drawing.Point(16, 107);
			this.button_add4.Name = "button_add4";
			this.button_add4.Size = new System.Drawing.Size(75, 23);
			this.button_add4.TabIndex = 3;
			this.button_add4.Text = "Add+4T";
			this.button_add4.UseVisualStyleBackColor = false;
			this.button_add4.Click += new System.EventHandler(this.button_add4_Click);
			// 
			// button_add3
			// 
			this.button_add3.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button_add3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_add3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_add3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_add3.Location = new System.Drawing.Point(16, 77);
			this.button_add3.Name = "button_add3";
			this.button_add3.Size = new System.Drawing.Size(75, 23);
			this.button_add3.TabIndex = 2;
			this.button_add3.Text = "Add+3T";
			this.button_add3.UseVisualStyleBackColor = false;
			this.button_add3.Click += new System.EventHandler(this.button_add3_Click);
			// 
			// button_add2
			// 
			this.button_add2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button_add2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_add2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_add2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_add2.Location = new System.Drawing.Point(16, 45);
			this.button_add2.Name = "button_add2";
			this.button_add2.Size = new System.Drawing.Size(75, 23);
			this.button_add2.TabIndex = 1;
			this.button_add2.Text = "Add+2T";
			this.button_add2.UseVisualStyleBackColor = false;
			this.button_add2.Click += new System.EventHandler(this.button_add2_Click);
			// 
			// button_add1
			// 
			this.button_add1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button_add1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_add1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_add1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_add1.Location = new System.Drawing.Point(16, 13);
			this.button_add1.Name = "button_add1";
			this.button_add1.Size = new System.Drawing.Size(75, 23);
			this.button_add1.TabIndex = 0;
			this.button_add1.Text = "Add+1T";
			this.button_add1.UseVisualStyleBackColor = false;
			this.button_add1.Click += new System.EventHandler(this.button_add1_Click);
			// 
			// timer_RealMarket
			// 
			this.timer_RealMarket.Interval = 1000;
			this.timer_RealMarket.Tick += new System.EventHandler(this.Tick_er);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.ForeColor = System.Drawing.Color.Gray;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(800, 343);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "行情驱动区";
			// 
			// KLine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Name = "KLine";
			this.Size = new System.Drawing.Size(800, 343);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button_cusTick;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button_low4;
		private System.Windows.Forms.Button button_low3;
		private System.Windows.Forms.Button button_low2;
		private System.Windows.Forms.Button button_low1;
		private System.Windows.Forms.Button button_add4;
		private System.Windows.Forms.Button button_add3;
		private System.Windows.Forms.Button button_add2;
		private System.Windows.Forms.Button button_add1;
		private System.Windows.Forms.TextBox textBox_timer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_Timer;
		private System.Windows.Forms.Timer timer_RealMarket;
		private System.Windows.Forms.GroupBox groupBox1;

	}
}
