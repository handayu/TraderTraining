using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingStrategyInfomation
{
	public class BaseEngineStrategy
	{
		/// <summary>
		/// BUY发布
		/// </summary>
		public delegate void HandelBuy();
		public event HandelBuy EventBuy;

		/// <summary>
		/// 卖发布
		/// </summary>
		public delegate void HandelSell();
		public event HandelSell EventSell;

		/// <summary>
		/// 平仓发布
		/// </summary>
		public delegate void HandelCover();
		public event HandelCover EventCover;


		public void SafeRiseBuySingle()
		{
			if(EventBuy != null)
			{
				EventBuy();
			}
		}

		public void SafeRiseSellSingle()
		{
			if (EventSell != null)
			{
				EventSell();
			}
		}

		public void SafeRiseCoverSingle()
		{
			if (EventCover != null)
			{
				EventCover();
			}
		}
	}
}
