namespace TradingStrategyInfomation.MainForm
{
	partial class StrategtySystem
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
			this.tradingSystem1 = new TradingStrategyInfomation.TradingSystem();
			this.SuspendLayout();
			// 
			// tradingSystem1
			// 
			this.tradingSystem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tradingSystem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tradingSystem1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tradingSystem1.Location = new System.Drawing.Point(0, 0);
			this.tradingSystem1.Name = "tradingSystem1";
			this.tradingSystem1.Size = new System.Drawing.Size(1074, 413);
			this.tradingSystem1.TabIndex = 0;
			// 
			// StrategtySystem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1074, 413);
			this.Controls.Add(this.tradingSystem1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "StrategtySystem";
			this.Opacity = 0.9D;
			this.Text = "交易员策略决策体系[可对接交易，直接点击下单]";
			this.ResumeLayout(false);

		}

		#endregion

		private TradingSystem tradingSystem1;
	}
}