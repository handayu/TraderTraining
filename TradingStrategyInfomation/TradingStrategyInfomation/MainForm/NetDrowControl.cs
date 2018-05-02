/********************************************************************
	created:	2018/04/16
	created:	16:4:2018   16:22
	filename: 	D:\Desktop\TradingStrategyInfomation\TradingStrategyInfomation\MainForm\NetDrowControl.cs
	file path:	D:\Desktop\TradingStrategyInfomation\TradingStrategyInfomation\MainForm
	file base:	NetDrowControl
	file ext:	cs
	author:		Hanyu
	
	purpose:	根据进出场画出计算出的资金值和回撤曲线
*********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingStrategyInfomation.DataType;
using System.Windows.Forms.DataVisualization.Charting;

namespace TradingStrategyInfomation.MainForm
{
	public partial class NetDrowControl : UserControl
	{
		private int m_nowCal = 0;
		private double m_wholeNet = 0;

		public NetDrowControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 收到平仓消息，则获取全局的交易明细计算资金值
		/// </summary>
		public void CalNewQualityValue()
		{
			//其他线程调用
			if (this.InvokeRequired)
			{
				IAsyncResult result = this.BeginInvoke(new Action(CalNewQualityValue));
				return;
			}

			List<XYKline> kSingleList = KlineHandel.Instance.SINGLEREALKLINE;
			if (kSingleList == null || kSingleList.Count <= 0) return;

			//最新一笔明细
			XYKline newKSingle = KlineHandel.Instance.SINGLEREALKLINE[KlineHandel.Instance.SINGLEREALKLINE.Count - 1];

			if(KlineHandel.Instance.SINGLEREALKLINE.Count >= 2)
			{
				//倒数第二笔明细
				XYKline lastKSingle = KlineHandel.Instance.SINGLEREALKLINE[KlineHandel.Instance.SINGLEREALKLINE.Count - 2];

				if (lastKSingle.BUYOrSell == "买入持仓")
				{
					m_wholeNet = m_wholeNet + newKSingle.Price - lastKSingle.Price;
				}

				if (lastKSingle.BUYOrSell == "卖空持仓")
				{
					m_wholeNet = m_wholeNet + lastKSingle.Price - newKSingle.Price;
				}

				this.chart1.Series["净值"].Points.AddXY(m_nowCal, m_wholeNet);

				CalMaxDrowDownRadio();
			}
		}

		/// <summary>
		/// 计算净值最大的回撤幅度
		/// 求出历史上的Point最高值,最高值减去目前的值除以最高值
		/// </summary>
		private void CalMaxDrowDownRadio()
		{
			DataPointCollection pColl = this.chart1.Series["净值"].Points;
			if (pColl.Count <= 0) return;

			List<double> maxChooseList = new List<double>();
			double maxNet = 0;
			if(pColl.Count > 1)
			{
				foreach(DataPoint p in pColl)
				{
					maxChooseList.Add(p.YValues[0]);
				}

				maxNet = maxChooseList.Max();

				double nowNet = this.chart1.Series["净值"].Points[this.chart1.Series["净值"].Points.Count - 1].YValues[0];

				//无回撤增长
				if(nowNet - maxNet >= 0)
				{
					this.chart1.Series["回撤率"].Points.AddXY(m_nowCal, 0);
				}
				else
				{
					if (maxNet != 0)
					{
						double drowDownRadio = (maxNet - nowNet) / maxNet;
						this.chart1.Series["回撤率"].Points.AddXY(m_nowCal, drowDownRadio);
					}
					else
					{
						this.chart1.Series["回撤率"].Points.AddXY(m_nowCal, 0);
					}
				}

				m_nowCal++;
 			}

		}
	}
}
