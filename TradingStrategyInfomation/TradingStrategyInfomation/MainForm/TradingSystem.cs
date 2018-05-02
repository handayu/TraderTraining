using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingStrategyInfomation
{
	public partial class TradingSystem : UserControl
	{
		#region 各个button的点击作为状态切换，以标识在Tik事件中是否显示
		//1
		private bool IButton_1AvgUpBuy_Click = false;
		private bool IButton_1StopLoss_Click = false;
		private bool IButton_1BrokenLoss_Click = false;

		//2
		private bool IButton_2AvgDownBuy_Click = false;
		private bool IButton_2BrokenEven_Click = false;
		private bool IButton_2StopLoss_Click = false;
		private bool IButton_2KD80Cross_Click = false;

		//3
		private bool IButton_3AvgUpSell_Click = false;
		private bool IButton_3KD20Buy_Click = false;
		private bool IButton_3StopLoss_Click = false;
		private bool IButton_3BrokenEven_Click = false;

		//4
		private bool IButton_4AvgDownSell_Click = false;
		private bool IButton_4BrokenEven_Click = false;
		private bool IButton_4StopLoss_Click = false;

		private bool iFlag11 = true;
		private bool iFlag12 = true;
		private bool iFlag13 = true;


		private bool iFlag21 = true;
		private bool iFlag22 = true;
		private bool iFlag23 = true;
		private bool iFlag24 = true;


		private bool iFlag31 = true;
		private bool iFlag32 = true;
		private bool iFlag33 = true;
		private bool iFlag34 = true;


		private bool iFlag41 = true;
		private bool iFlag42 = true;
		private bool iFlag43 = true;

		#endregion


		public TradingSystem()
		{
			InitializeComponent();

			this.timer1.Enabled = true;
			this.timer1.Start();
		}

		private void Ticker(object sender, EventArgs e)
		{
			#region 1
			//1Buy
			if (IButton_1AvgUpBuy_Click)
			{
				if (iFlag11)
				{
					this.button_1AvgUpBuy.BackColor = Color.Red;
					label_1ToStopLoss.ForeColor = Color.Red;
					label_1ToBrokenEven.ForeColor = Color.Red;
					iFlag11 = false;
				}
				else
				{
					this.button_1AvgUpBuy.BackColor = Color.Blue;
					label_1ToStopLoss.ForeColor = Color.Blue;
					label_1ToBrokenEven.ForeColor = Color.Blue;
					iFlag11 = true;
				}
			}

			//1StopLoss
			if (IButton_1StopLoss_Click)
			{
				if (iFlag12)
				{
					label_1LossToOpenAgain.ForeColor = Color.Red;
					label_1To2.ForeColor = Color.Red;
					label_1To2_2.ForeColor = Color.Red;
					iFlag12 = false;
				}
				else
				{
					label_1LossToOpenAgain.ForeColor = Color.Blue;
					label_1To2.ForeColor = Color.Blue;
					label_1To2_2.ForeColor = Color.Blue;
					iFlag12 = true;
				}
			}

			//1-BrokenEvent
			if (IButton_1BrokenLoss_Click)
			{
				if (iFlag13)
				{
					label_1BrokenEvenToOpenAgain.ForeColor = Color.Red;
					iFlag13 = false;
				}
				else
				{
					label_1BrokenEvenToOpenAgain.ForeColor = Color.Blue;
					iFlag13 = true;
				}
			}
			#endregion

			#region 2
			if (IButton_2AvgDownBuy_Click)
			{
				if (iFlag21)
				{
					label_2ToStopLoss.ForeColor = Color.Red;
					label_2ToBrokenEven.ForeColor = Color.Red;
					label_2KD80Sell.ForeColor = Color.Red;
					iFlag21 = false;	
				}
				else
				{
					label_2ToStopLoss.ForeColor = Color.Blue;
					label_2ToBrokenEven.ForeColor = Color.Blue;
					label_2KD80Sell.ForeColor = Color.Blue;
					iFlag21 = true;
				}
			}


			if (IButton_2BrokenEven_Click)
			{
				if (iFlag22)
				{
					label_2BrokenEvenToOpenAgain.ForeColor = Color.Red;
					iFlag22 = false;
				}
				else
				{
					label_2BrokenEvenToOpenAgain.ForeColor = Color.Blue;
					iFlag22 = true;
				}
			}

			if (IButton_2StopLoss_Click)
			{
				if (iFlag23)
				{
					label_2LossToOpenAgain.ForeColor = Color.Red;
					iFlag23 = false;
				}
				else
				{
					label_2LossToOpenAgain.ForeColor = Color.Blue;
					iFlag23 = true;
				}
			}

			if (IButton_2KD80Cross_Click)
			{
				if (iFlag24)
				{
					label_2To34_1.ForeColor = Color.Red;
					label_2To34_2.ForeColor = Color.Red;
					label_2To34_3.ForeColor = Color.Red;
					label_2To34_4.ForeColor = Color.Red;

					iFlag24 = false;
				}
				else
				{
					label_2To34_1.ForeColor = Color.Blue;
					label_2To34_2.ForeColor = Color.Blue;
					label_2To34_3.ForeColor = Color.Blue;
					label_2To34_4.ForeColor = Color.Blue;
					iFlag24 = true;
				}
			}

			#endregion

			#region 3
			if (IButton_3AvgUpSell_Click)
			{
				if (iFlag31)
				{
					label_3ToStopLoss.ForeColor = Color.Red;
					label_3ToBrokenEven.ForeColor = Color.Red;
					label_3ToKD20Buy.ForeColor = Color.Red;
					iFlag31 = false;			
				}
				else
				{
					label_3ToStopLoss.ForeColor = Color.Blue;
					label_3ToBrokenEven.ForeColor = Color.Blue;
					label_3ToKD20Buy.ForeColor = Color.Blue;
					iFlag31 = true;
				}
			}


			if (IButton_3BrokenEven_Click)
			{
				if (iFlag32)
				{
					label_3BrokenEvenToOpenAgain.ForeColor = Color.Red;
					iFlag32 = false;
					
				}
				else
				{
					label_3BrokenEvenToOpenAgain.ForeColor = Color.Blue;
					iFlag32 = true;
				}
			}

			if (IButton_3StopLoss_Click)
			{
				if (iFlag33)
				{
					label_3LossToOpenAgain.ForeColor = Color.Red;
					iFlag33 = false;
					
				}
				else
				{
					label_3LossToOpenAgain.ForeColor = Color.Blue;
					iFlag33 = true;
				}
			}

			if (IButton_3KD20Buy_Click)
			{
				if (iFlag34)
				{
					label_3To12_1.ForeColor = Color.Red;
					label_3To12_2.ForeColor = Color.Red;
					label_3To12_3.ForeColor = Color.Red;
					label_3To12_4.ForeColor = Color.Red;

					iFlag34 = false;
				}
				else
				{
					label_3To12_1.ForeColor = Color.Blue;
					label_3To12_2.ForeColor = Color.Blue;
					label_3To12_3.ForeColor = Color.Blue;
					label_3To12_4.ForeColor = Color.Blue;
					iFlag34 = true;
				}
			}

			#endregion

			#region 4
			if (IButton_4AvgDownSell_Click)
			{
				if (iFlag41)
				{
					label_4ToBrokenEven.ForeColor = Color.Red;
					label_4ToStopLoss.ForeColor = Color.Red;
					iFlag41 = false;				
				}
				else
				{
					label_4ToBrokenEven.ForeColor = Color.Blue;
					label_4ToStopLoss.ForeColor = Color.Blue;
					iFlag41 = true;
				}
			}

			if (IButton_4StopLoss_Click)
			{
				if (iFlag42)
				{
					label_4LossToOpenAgain.ForeColor = Color.Red;
					label_4To3.ForeColor = Color.Red;
					label_4To3_2.ForeColor = Color.Red;		
					iFlag42 = false;
				}
				else
				{
					label_4LossToOpenAgain.ForeColor = Color.Blue;
					label_4To3.ForeColor = Color.Blue;
					label_4To3_2.ForeColor = Color.Blue;		
					iFlag42 = true;
				}
			}

			//1-BrokenEvent
			if (IButton_4BrokenEven_Click)
			{
				if (iFlag43)
				{
					label_4BrokenEvenToOpenAgain.ForeColor = Color.Red;
					iFlag43 = false;
				}
				else
				{
					label_4BrokenEvenToOpenAgain.ForeColor = Color.Blue;
					iFlag43 = true;
				}
			}

			#endregion

		}

		#region 1区间-均线以上买入
		private void button_1AvgUpBuy_Click(object sender, EventArgs e)
		{
			this.button_1AvgUpBuy.BackColor = Color.Red;
			IButton_1AvgUpBuy_Click = true;
		}

		private void button_1StopLoss_Click(object sender, EventArgs e)
		{
			this.button_1StopLoss.BackColor = Color.Red;
			IButton_1StopLoss_Click = true;
		}

		private void button_1BrokenLoss_Click(object sender, EventArgs e)
		{
			this.button_1BrokenLoss.BackColor = Color.Red;
			IButton_1BrokenLoss_Click = true;
		}
		#endregion

		#region 2区间-均线以下买入
		private void button_2AvgDownBuy_Click(object sender, EventArgs e)
		{
			this.button_2AvgDownBuy.BackColor = Color.Red;
			IButton_2AvgDownBuy_Click = true;
		}

		private void button_2BrokenEven_Click(object sender, EventArgs e)
		{
			this.button_2BrokenEven.BackColor = Color.Red;
			IButton_2BrokenEven_Click = true;

		}

		private void button_2StopLoss_Click(object sender, EventArgs e)
		{
			this.button_2StopLoss.BackColor = Color.Red;
			IButton_2StopLoss_Click = true;

		}

		private void button_2KD80Cross_Click(object sender, EventArgs e)
		{
			this.button_2KD80Cross.BackColor = Color.Red;
			IButton_2KD80Cross_Click = true;

		}
		#endregion

		#region 3区间-均线以上卖出
		private void button_3AvgUpSell_Click(object sender, EventArgs e)
		{
			this.button_3AvgUpSell.BackColor = Color.Red;
			IButton_3AvgUpSell_Click = true;

		}

		private void button_3KD20Buy_Click(object sender, EventArgs e)
		{
			this.button_3KD20Buy.BackColor = Color.Red;
			IButton_3KD20Buy_Click = true;

		}

		private void button_3StopLoss_Click(object sender, EventArgs e)
		{
			this.button_3StopLoss.BackColor = Color.Red;
			IButton_3StopLoss_Click = true;

		}

		private void button_3BrokenEven_Click(object sender, EventArgs e)
		{
			this.button_3BrokenEven.BackColor = Color.Red;
			IButton_3BrokenEven_Click = true;

		}
		#endregion

		#region 4区间-均线以下卖出
		private void button_4AvgDownSell_Click(object sender, EventArgs e)
		{
			this.button_4AvgDownSell.BackColor = Color.Red;
			IButton_4AvgDownSell_Click = true;

		}

		private void button_4BrokenEven_Click(object sender, EventArgs e)
		{
			this.button_4BrokenEven.BackColor = Color.Red;
			IButton_4BrokenEven_Click = true;

		}

		private void button_4StopLoss_Click(object sender, EventArgs e)
		{
			this.button_4StopLoss.BackColor = Color.Red;
			IButton_4StopLoss_Click = true;

		}
		#endregion

		/// <summary>
		/// 重置所有的状态
		/// </summary>
		private void ResetClient()
		{

		}
	}
}
