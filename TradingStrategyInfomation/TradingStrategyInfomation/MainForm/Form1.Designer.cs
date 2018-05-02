namespace TradingStrategyInfomation
{
	partial class Form1
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.kLine1 = new TradingStrategyInfomation.KLine();
			this.orderInsertControl1 = new TradingStrategyInfomation.MainForm.OrderInsertControl();
			this.tradeControl1 = new TradingStrategyInfomation.MainForm.TradeControl();
			this.netDrowControl1 = new TradingStrategyInfomation.MainForm.NetDrowControl();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 288F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1060, 636);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.29032F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.70968F));
			this.tableLayoutPanel2.Controls.Add(this.kLine1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.orderInsertControl1, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1054, 342);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.tradeControl1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.netDrowControl1, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 351);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(1054, 282);
			this.tableLayoutPanel3.TabIndex = 3;
			// 
			// kLine1
			// 
			this.kLine1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kLine1.Location = new System.Drawing.Point(3, 4);
			this.kLine1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.kLine1.Name = "kLine1";
			this.kLine1.Size = new System.Drawing.Size(639, 334);
			this.kLine1.TabIndex = 0;
			// 
			// orderInsertControl1
			// 
			this.orderInsertControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.orderInsertControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.orderInsertControl1.Location = new System.Drawing.Point(648, 4);
			this.orderInsertControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.orderInsertControl1.Name = "orderInsertControl1";
			this.orderInsertControl1.Size = new System.Drawing.Size(403, 334);
			this.orderInsertControl1.TabIndex = 1;
			// 
			// tradeControl1
			// 
			this.tradeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tradeControl1.Location = new System.Drawing.Point(3, 4);
			this.tradeControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tradeControl1.Name = "tradeControl1";
			this.tradeControl1.Size = new System.Drawing.Size(521, 274);
			this.tradeControl1.TabIndex = 0;
			// 
			// netDrowControl1
			// 
			this.netDrowControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.netDrowControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.netDrowControl1.Location = new System.Drawing.Point(530, 4);
			this.netDrowControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.netDrowControl1.Name = "netDrowControl1";
			this.netDrowControl1.Size = new System.Drawing.Size(521, 274);
			this.netDrowControl1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1060, 636);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form1";
			this.Text = "交易员训练系统";
			this.Load += new System.EventHandler(this.FormLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private KLine kLine1;
		private MainForm.OrderInsertControl orderInsertControl1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private MainForm.TradeControl tradeControl1;
		private MainForm.NetDrowControl netDrowControl1;


	}
}

