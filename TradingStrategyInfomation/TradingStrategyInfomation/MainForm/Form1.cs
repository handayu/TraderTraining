using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingStrategyInfomation
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
		
		public const int WM_SYSCOMMAND = 0x0112;
		public const int SC_MOVE = 0xF010;
		public const int HTCAPTION = 0x0002;

		/// <summary>
		/// 为了是主界面能够移动
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
		}

		private void FormLoad(object sender, EventArgs e)
		{
			this.orderInsertControl1.EventBuy += this.kLine1.BuySingle;
			this.orderInsertControl1.EventSell += this.kLine1.SellSingle;
			this.orderInsertControl1.EventCover += this.kLine1.CoverSingle;
			this.orderInsertControl1.EventSingleCheck += this.kLine1.RadioCheckSingle;

			this.kLine1.EventTradingItem += this.tradeControl1.SetTradingItems;

			this.orderInsertControl1.EventCover += this.netDrowControl1.CalNewQualityValue;

			this.tradeControl1.EventRecodeChanged += this.netDrowControl1.CalNewQualityValue;
		}
	}
}
