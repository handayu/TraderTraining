using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using TradingStrategyInfomation.DataType;

namespace TradingStrategyInfomation
{
	public partial class KLine : UserControl
	{
		private int m_xValue = 0;

		private EngineStrategy m_myStrategy1 = new EngineStrategy();

		/// <summary>
		/// 发布成交明细通知
		/// </summary>
		public delegate void HandelTradingItem(XYKline kSingle);
		public event HandelTradingItem EventTradingItem;

		public KLine()
		{
			InitializeComponent();

			//AddSeries();

			m_myStrategy1.EventBuy += BuySingle;
			m_myStrategy1.EventSell += SellSingle;
			m_myStrategy1.EventCover += CoverSingle;
		}


		//public List<XYKline> GetUseMarketData()
		//{
		//	string filePath = Environment.CurrentDirectory + "/Test.txt";

		//	List<XYKline> klineList = new List<XYKline>();

		//	string[] marketDataLines = File.ReadAllLines(filePath);
		//	int index = 0;
		//	while (index < marketDataLines.Count())
		//	{
		//		XYKline kline = new XYKline();

		//		string[] klineDataArray = marketDataLines[index].Split(',');   //截取","分割

		//		kline.DateTimeStr = klineDataArray[0] + " " + klineDataArray[1];
		//		kline.Price = klineDataArray[2];
		//		kline.Volumn = klineDataArray[6];

		//		klineList.Add(kline);
		//		index++;
		//	}

		//	return klineList;
		//}

		//public void AddSeries()
		//{
		//	List<XYKline> kLineList = GetUseMarketData();

		//	List<string> dateTimeList = new List<string>();
		//	List<double> priceList = new List<double>();
		//	List<double> volumnList = new List<double>();
		//	List<double> avgList = new List<double>();

		//	double sumPrice = 0;
		//	for (int i = 0; i < 160; i++)
		//	{
		//		dateTimeList.Add(kLineList[i].DateTimeStr);
		//		priceList.Add(Convert.ToDouble(kLineList[i].Price));
		//		volumnList.Add(Convert.ToDouble(kLineList[i].Volumn));

		//		if (i == 0)
		//		{
		//			sumPrice = Convert.ToDouble(kLineList[i].Price);
		//			avgList.Add(sumPrice);
		//		}
		//		else
		//		{
		//			sumPrice = (sumPrice + Convert.ToDouble(kLineList[i].Price));
		//			avgList.Add(sumPrice / (i + 1));
		//		}

		//	}

		//	double max = priceList.Max();
		//	double min = priceList.Min();

		//	this.chart1.ChartAreas[0].AxisY.Maximum = max;//设定y轴的最大值
		//	this.chart1.ChartAreas[0].AxisY.Minimum = min;//设定y轴的最小值

		//	this.chart1.Series["实时走势"].Points.DataBindXY(dateTimeList, priceList);
		//	this.chart1.Series["均线"].Points.DataBindXY(dateTimeList, avgList);

		//}

		private void Engine(int iAdd)
		{
			//获取现在前一个点的Y的值，在前一个Y值的基础上加减才是对的
			int cout = this.chart1.Series["实时走势"].Points.Count;
			if (cout == 0)
			{
				XYKline kline = new XYKline()
				{
					DateTimeStr = DateTime.Now,
					Price = iAdd,
					avg = 0,
					K = 0,
					D = 0,
					Volumn = "0",
					BUYOrSell = "无持仓"
				};

				this.chart1.Series["实时走势"].Points.AddXY(m_xValue, kline.Price);
				KlineHandel.Instance.AddWholeXYKline(kline);
				EngineIndicatorsKDJ(kline);
				EngineIndicatorsAvger(kline);
				m_xValue++;
			}
			else
			{
			
				DataPoint p = this.chart1.Series["实时走势"].Points[cout - 1];

				XYKline kline = new XYKline()
				{
					DateTimeStr = DateTime.Now,
					Price =Convert.ToInt32(p.YValues[0]) + iAdd,
					avg = 0,
					K = 0,
					D = 0,
					Volumn = "0",
					BUYOrSell = "无持仓"
				};


				this.chart1.Series["实时走势"].Points.AddXY(m_xValue,kline.Price);
				KlineHandel.Instance.AddWholeXYKline(kline);
				EngineIndicatorsKDJ(kline);
				EngineIndicatorsAvger(kline);
				m_xValue++;
			}
		}

		private void button_add1_Click(object sender, EventArgs e)
		{
	
			Engine(1);
		}

		private void button_add2_Click(object sender, EventArgs e)
		{
		 
			Engine(2);

		}

		private void button_add3_Click(object sender, EventArgs e)
		{
			 

			Engine(3);

		}

		private void button_add4_Click(object sender, EventArgs e)
		{
			 
			Engine(4);

		}

		private void button_low1_Click(object sender, EventArgs e)
		{
			 
			Engine(-1);
		}

		private void button_low2_Click(object sender, EventArgs e)
		{
			 
			Engine(-2);
		}

		private void button_low3_Click(object sender, EventArgs e)
		{
		 
			Engine(-3);
		}

		private void button_low4_Click(object sender, EventArgs e)
		{
	 
			Engine(-4);
		}

		private void button_cusTick_Click(object sender, EventArgs e)
		{
			try
			{
				int i = 0;
				int.TryParse(this.textBox1.Text, out i);

				 
				Engine(i);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// 每一次调用行情实时数据都应该驱动一次指标计算 --KDJ
		/// </summary>
		private void EngineIndicatorsKDJ(XYKline kline)
		{
			this.chart2.Series["Uplimit"].Points.AddXY(m_xValue, 80);
			this.chart2.Series["Lowlimit"].Points.AddXY(m_xValue, 20);

			//14,3,3
			//以9日为周期的KD线为例。首先须计算出最近9日的RSV值，即未成熟随机值，计算公式为 
			//9日RSV=（C－L9）÷（H9－L9）×100 
			//公式中，C为第9日的收盘价；L9为9日内的最低价；H9为9日内的最高价。 
			//K值=2/3×第8日K值＋1/3×第9日RSV   
			//D值=2/3×第8日D值＋1/3×第9日K值   
			//若无前一日K值与D值，则可以分别用50代替
			int wholeSize = KlineHandel.Instance.WHOLEREALKLINE.Count;
			if (wholeSize == 14)
			{
				kline.K = 50;
				kline.D = 50;
			}

			double nRsv = 0;
			if (wholeSize > 14)
			{
				List<int> kList = new List<int>();
				for (int i = wholeSize - 1; i >= wholeSize - 13; i--)
				{
					kList.Add(KlineHandel.Instance.WHOLEREALKLINE[i].Price);
				}

				double nMax = kList.Max();
				double nMin = kList.Min();

				if (nMax - nMin != 0)
				{
					nRsv = (kline.Price - nMin) / (nMax - nMin);

					double k = (2 / 3) * KlineHandel.Instance.WHOLEREALKLINE[KlineHandel.Instance.WHOLEREALKLINE.Count - 1].K
						+ (1 / 3) * nRsv;

					double d = (2 / 3) * KlineHandel.Instance.WHOLEREALKLINE[KlineHandel.Instance.WHOLEREALKLINE.Count - 1].D
	                    + (1 / 3) * k;

					kline.K = k;
					kline.D = d;

					this.chart2.Series["Uplimit"].Points.AddXY(m_xValue, k);
					this.chart2.Series["Lowlimit"].Points.AddXY(m_xValue, d);
				}
				else
				{
					kline.K = 0;
					kline.D = 0;

					this.chart2.Series["Uplimit"].Points.AddXY(m_xValue, 0);
					this.chart2.Series["Lowlimit"].Points.AddXY(m_xValue, 0);
				}
			}
		}

		/// <summary>
		/// 每一次调用行情实时数据都应该驱动一次指标计算 --Avg
		/// </summary>
		private void EngineIndicatorsAvger(XYKline kline)
		{
			int cout = this.chart1.Series["实时走势"].Points.Count;
			if (cout >= 10)
			{
				double sum = 0;
				double avg = 0;

				for (int i = cout - 1; i >= cout - 9; i--)
				{
					sum = sum + this.chart1.Series["实时走势"].Points[i].YValues[0];
				}

				avg = sum / 10;

				kline.avg = avg;

				this.chart1.Series["均线"].Points.AddXY(m_xValue, avg);
			}
		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{

		}

		/// <summary>
		/// 随机行情即时驱动
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Tick_er(object sender, EventArgs e)
		{
			Random Random1 = new Random();
			int i = Random1.Next(-10, 10);
			Engine(i);

			//策略执行器
			m_myStrategy1.EngineStrategyTrading();
   		}

		private void button_Timer_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.timer_RealMarket.Enabled == true)
				{
					this.timer_RealMarket.Enabled = false;
					this.timer_RealMarket.Stop();
					return;
				}

				if (textBox_timer.Text == "")
				{
					MessageBox.Show("请输入实时行情的模拟时间间隔");
					return;
				}

				int i = 0;
				int.TryParse(this.textBox_timer.Text, out i);

				this.timer_RealMarket.Interval = i;
				this.timer_RealMarket.Enabled = true;
				this.timer_RealMarket.Start();
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		#region 接受买卖信号用于处理数据
		//获取k线表里最后一笔最新的数据，添加到信号K线列表里去
		public void BuySingle()
		{
			if (KlineHandel.Instance.WHOLEREALKLINE == null ||
				KlineHandel.Instance.WHOLEREALKLINE.Count <= 0)
			{
				return;
			}

			XYKline kLast = KlineHandel.Instance.WHOLEREALKLINE[KlineHandel.Instance.WHOLEREALKLINE.Count - 1];
			kLast.BUYOrSell = "买入持仓";

			KlineHandel.Instance.SINGLEREALKLINE.Add(kLast);

			SafeRiseTradingEvent(kLast);
		}

		public void SellSingle()
		{
			if (KlineHandel.Instance.WHOLEREALKLINE == null ||
					KlineHandel.Instance.WHOLEREALKLINE.Count <= 0)
			{
				return;
			}

			XYKline kLast = KlineHandel.Instance.WHOLEREALKLINE[KlineHandel.Instance.WHOLEREALKLINE.Count - 1];
			kLast.BUYOrSell = "卖空持仓";

			KlineHandel.Instance.SINGLEREALKLINE.Add(kLast);

			SafeRiseTradingEvent(kLast);

		}

		public void CoverSingle()
		{
			if (KlineHandel.Instance.WHOLEREALKLINE == null ||
					KlineHandel.Instance.WHOLEREALKLINE.Count <= 0)
			{
				return;
			}

			XYKline kLast = KlineHandel.Instance.WHOLEREALKLINE[KlineHandel.Instance.WHOLEREALKLINE.Count - 1];
			kLast.BUYOrSell = "平仓";

			KlineHandel.Instance.SINGLEREALKLINE.Add(kLast);

			SafeRiseTradingEvent(kLast);

		}

		private bool m_isVisibleSingle = false;
		public void RadioCheckSingle(bool iResult)
		{
			//在这里给K线图表上的信号添加箭头信号点
			if (iResult)
			{
				m_isVisibleSingle = true;
			}
			else
			{
				m_isVisibleSingle = false;
			}
		}

		/// <summary>
		/// 安全的发布成交信息
		/// </summary>
		/// <param name="kSIngle"></param>
		private void SafeRiseTradingEvent(XYKline kSIngle)
		{
			if (EventTradingItem != null)
			{
				EventTradingItem(kSIngle);
			}
		}

		#endregion
	}
}
