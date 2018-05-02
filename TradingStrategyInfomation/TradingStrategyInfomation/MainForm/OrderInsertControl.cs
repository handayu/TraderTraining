using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingStrategyInfomation.MainForm
{
	public partial class OrderInsertControl : UserControl
	{
		#region 三类事件通知给主窗口订阅更改成交明细

		public delegate void HandelBuy();
		public event HandelBuy EventBuy;

		public delegate void HandelSell();
		public event HandelSell EventSell;

		public delegate void HandelCover();
		public event HandelCover EventCover;

		public delegate void HandelSingleCheck(bool iResult);
		public event HandelSingleCheck EventSingleCheck;

		#endregion

		public OrderInsertControl()
		{
			InitializeComponent();

			this.button_COVER.Enabled = false;
		}

		private void button_Strategy_Click(object sender, EventArgs e)
		{
			StrategtySystem form = new StrategtySystem();
			form.Show();
		}

		private void button_BUY_Click(object sender, EventArgs e)
		{
			this.button_BUY.Enabled = false;
			this.button_SELL.Enabled = false;
			this.button_COVER.Enabled = true;

			if(EventBuy != null)
			{
				EventBuy();
			}
		}

		private void button_SELL_Click(object sender, EventArgs e)
		{
			this.button_SELL.Enabled = false;
			this.button_BUY.Enabled = false;
			this.button_COVER.Enabled = true;

			if (EventSell != null)
			{
				EventSell();
			}
		}

		private void button_COVER_Click(object sender, EventArgs e)
		{
			this.button_COVER.Enabled = false;
			this.button_SELL.Enabled = true;
			this.button_BUY.Enabled = true;

			if (EventCover != null)
			{
				EventCover();
			}

		}

		private void ISShowBUYSELL(object sender, EventArgs e)
		{
			if(this.radioButton_ISVISUALBS.Checked)
			{
				if (EventSingleCheck != null)
				{
					EventSingleCheck(true);
				}
			}
			else
			{
				if (EventSingleCheck != null)
				{
					EventSingleCheck(false);
				}
			}
		}
	}
}
