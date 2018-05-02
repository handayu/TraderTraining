namespace TradingStrategyInfomation.MainForm
{
	partial class OrderInsertControl
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton_ISVISUALBS = new System.Windows.Forms.RadioButton();
			this.button_COVER = new System.Windows.Forms.Button();
			this.button_SELL = new System.Windows.Forms.Button();
			this.button_BUY = new System.Windows.Forms.Button();
			this.button_Strategy = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button_Strategy);
			this.groupBox1.Controls.Add(this.radioButton_ISVISUALBS);
			this.groupBox1.Controls.Add(this.button_COVER);
			this.groupBox1.Controls.Add(this.button_SELL);
			this.groupBox1.Controls.Add(this.button_BUY);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(326, 218);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "手动下单区";
			// 
			// radioButton_ISVISUALBS
			// 
			this.radioButton_ISVISUALBS.AutoSize = true;
			this.radioButton_ISVISUALBS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.radioButton_ISVISUALBS.ForeColor = System.Drawing.SystemColors.Highlight;
			this.radioButton_ISVISUALBS.Location = new System.Drawing.Point(41, 124);
			this.radioButton_ISVISUALBS.Name = "radioButton_ISVISUALBS";
			this.radioButton_ISVISUALBS.Size = new System.Drawing.Size(145, 21);
			this.radioButton_ISVISUALBS.TabIndex = 7;
			this.radioButton_ISVISUALBS.TabStop = true;
			this.radioButton_ISVISUALBS.Text = "是否显示开平仓买卖点";
			this.radioButton_ISVISUALBS.UseVisualStyleBackColor = true;
			this.radioButton_ISVISUALBS.CheckedChanged += new System.EventHandler(this.ISShowBUYSELL);
			// 
			// button_COVER
			// 
			this.button_COVER.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button_COVER.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_COVER.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_COVER.ForeColor = System.Drawing.Color.FloralWhite;
			this.button_COVER.Location = new System.Drawing.Point(150, 54);
			this.button_COVER.Name = "button_COVER";
			this.button_COVER.Size = new System.Drawing.Size(83, 24);
			this.button_COVER.TabIndex = 6;
			this.button_COVER.Text = "COVER";
			this.button_COVER.UseVisualStyleBackColor = false;
			this.button_COVER.Click += new System.EventHandler(this.button_COVER_Click);
			// 
			// button_SELL
			// 
			this.button_SELL.BackColor = System.Drawing.Color.IndianRed;
			this.button_SELL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_SELL.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_SELL.ForeColor = System.Drawing.Color.FloralWhite;
			this.button_SELL.Location = new System.Drawing.Point(41, 75);
			this.button_SELL.Name = "button_SELL";
			this.button_SELL.Size = new System.Drawing.Size(83, 24);
			this.button_SELL.TabIndex = 5;
			this.button_SELL.Text = "SELL";
			this.button_SELL.UseVisualStyleBackColor = false;
			this.button_SELL.Click += new System.EventHandler(this.button_SELL_Click);
			// 
			// button_BUY
			// 
			this.button_BUY.BackColor = System.Drawing.Color.IndianRed;
			this.button_BUY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_BUY.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_BUY.ForeColor = System.Drawing.Color.FloralWhite;
			this.button_BUY.Location = new System.Drawing.Point(41, 30);
			this.button_BUY.Name = "button_BUY";
			this.button_BUY.Size = new System.Drawing.Size(83, 24);
			this.button_BUY.TabIndex = 4;
			this.button_BUY.Text = "BUY";
			this.button_BUY.UseVisualStyleBackColor = false;
			this.button_BUY.Click += new System.EventHandler(this.button_BUY_Click);
			// 
			// button_Strategy
			// 
			this.button_Strategy.BackColor = System.Drawing.Color.Red;
			this.button_Strategy.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button_Strategy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Strategy.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_Strategy.ForeColor = System.Drawing.SystemColors.InfoText;
			this.button_Strategy.Location = new System.Drawing.Point(3, 186);
			this.button_Strategy.Name = "button_Strategy";
			this.button_Strategy.Size = new System.Drawing.Size(320, 29);
			this.button_Strategy.TabIndex = 8;
			this.button_Strategy.Text = "策略训练";
			this.button_Strategy.UseVisualStyleBackColor = false;
			this.button_Strategy.Click += new System.EventHandler(this.button_Strategy_Click);
			// 
			// OrderInsertControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Controls.Add(this.groupBox1);
			this.Name = "OrderInsertControl";
			this.Size = new System.Drawing.Size(326, 218);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton_ISVISUALBS;
		private System.Windows.Forms.Button button_COVER;
		private System.Windows.Forms.Button button_SELL;
		private System.Windows.Forms.Button button_BUY;
		private System.Windows.Forms.Button button_Strategy;

	}
}
