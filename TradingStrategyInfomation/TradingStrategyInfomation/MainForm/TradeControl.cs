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
	public partial class TradeControl : UserControl
	{
		private BindingList<XYKline> m_kSingle= new BindingList<XYKline>();

		public delegate void HandelRecodeChanged();
		public event HandelRecodeChanged EventRecodeChanged;

		public TradeControl()
		{
			InitializeComponent();
			this.dataGridView_Traded.AutoGenerateColumns = false;//不自动  
			this.dataGridView_Traded.DataSource = m_kSingle;

			dataGridView_Traded.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 27, 27);//列头
			dataGridView_Traded.RowsDefaultCellStyle.BackColor = Color.FromArgb(7, 8, 8);//行 背景色
			dataGridView_Traded.RowsDefaultCellStyle.ForeColor = Color.White;//行 前景色
			dataGridView_Traded.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridView_Traded.AlternatingRowsDefaultCellStyle = null;
			dataGridView_Traded.DefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 47, 51);
			dataGridView_Traded.DefaultCellStyle.SelectionForeColor = Color.White;
			for (int i = 0; i < dataGridView_Traded.Columns.Count; i++)
			{
				dataGridView_Traded.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			}
		}

		/// <summary>
		/// 往表里添加成交明细记录
		/// </summary>
		/// <param name="KSingle"></param>
		public void SetTradingItems(XYKline KSingle)
		{
			//其他线程调用
			if (this.InvokeRequired)
			{
				IAsyncResult result = this.BeginInvoke(new Action<XYKline>(SetTradingItems), KSingle);
				return;
			}

			m_kSingle.Add(KSingle);

			if(EventRecodeChanged != null)
			{
				EventRecodeChanged();
			}

		}

	}
}
