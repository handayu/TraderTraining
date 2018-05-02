namespace TradingStrategyInfomation.MainForm
{
	partial class TradeControl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView_Traded = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BUYOrSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.avg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.K = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Volumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Traded)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView_Traded
			// 
			this.dataGridView_Traded.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView_Traded.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView_Traded.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dataGridView_Traded.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridView_Traded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Traded.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column16,
            this.Column17,
            this.BUYOrSell,
            this.avg,
            this.K,
            this.D,
            this.Volumn});
			this.dataGridView_Traded.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_Traded.Location = new System.Drawing.Point(3, 19);
			this.dataGridView_Traded.MultiSelect = false;
			this.dataGridView_Traded.Name = "dataGridView_Traded";
			this.dataGridView_Traded.ReadOnly = true;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_Traded.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_Traded.RowHeadersVisible = false;
			this.dataGridView_Traded.RowHeadersWidth = 51;
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridView_Traded.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_Traded.RowTemplate.Height = 23;
			this.dataGridView_Traded.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_Traded.Size = new System.Drawing.Size(748, 312);
			this.dataGridView_Traded.TabIndex = 9;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox1.Controls.Add(this.dataGridView_Traded);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(754, 334);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "成交回报";
			// 
			// Column16
			// 
			this.Column16.DataPropertyName = "DateTimeStr";
			this.Column16.HeaderText = "委托时间";
			this.Column16.Name = "Column16";
			this.Column16.ReadOnly = true;
			// 
			// Column17
			// 
			this.Column17.DataPropertyName = "Price";
			this.Column17.HeaderText = "委托价格";
			this.Column17.Name = "Column17";
			this.Column17.ReadOnly = true;
			// 
			// BUYOrSell
			// 
			this.BUYOrSell.DataPropertyName = "BUYOrSell";
			this.BUYOrSell.HeaderText = "买卖方向";
			this.BUYOrSell.Name = "BUYOrSell";
			this.BUYOrSell.ReadOnly = true;
			// 
			// avg
			// 
			this.avg.DataPropertyName = "avg";
			this.avg.HeaderText = "avg";
			this.avg.Name = "avg";
			this.avg.ReadOnly = true;
			// 
			// K
			// 
			this.K.DataPropertyName = "K";
			this.K.HeaderText = "K";
			this.K.Name = "K";
			this.K.ReadOnly = true;
			// 
			// D
			// 
			this.D.DataPropertyName = "D";
			this.D.HeaderText = "D";
			this.D.Name = "D";
			this.D.ReadOnly = true;
			// 
			// Volumn
			// 
			this.Volumn.DataPropertyName = "Volumn";
			this.Volumn.HeaderText = "Volumn";
			this.Volumn.Name = "Volumn";
			this.Volumn.ReadOnly = true;
			// 
			// TradeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Name = "TradeControl";
			this.Size = new System.Drawing.Size(754, 334);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Traded)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_Traded;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
		private System.Windows.Forms.DataGridViewTextBoxColumn BUYOrSell;
		private System.Windows.Forms.DataGridViewTextBoxColumn avg;
		private System.Windows.Forms.DataGridViewTextBoxColumn K;
		private System.Windows.Forms.DataGridViewTextBoxColumn D;
		private System.Windows.Forms.DataGridViewTextBoxColumn Volumn;
	}
}
