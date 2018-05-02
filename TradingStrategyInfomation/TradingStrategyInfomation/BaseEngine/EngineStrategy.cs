/********************************************************************
	created:	2018/04/17
	created:	17:4:2018   8:40
	filename: 	D:\Desktop\TradingStrategyInfomation\TradingStrategyInfomation\EngineStrategy.cs
	file path:	D:\Desktop\TradingStrategyInfomation\TradingStrategyInfomation
	file base:	EngineStrategy
	file ext:	cs
	author:		Hanyu
	
	purpose:	策略驱动
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingStrategyInfomation.DataType;

namespace TradingStrategyInfomation
{
	public class EngineStrategy:BaseEngineStrategy
	{
		#region constuction 
		public EngineStrategy()
		{
		}
		#endregion

		private bool m_firCrossAvg = true;

		/// <summary>
		/// 策略交易驱动
		/// </summary>
		public void EngineStrategyTrading()
		{
			if (KlineHandel.Instance.WHOLEREALKLINE == null ||
					KlineHandel.Instance.WHOLEREALKLINE.Count <= 0)
			{
				return;
			}

			if (KlineHandel.Instance.SINGLEREALKLINE == null )
			{
				return;
			}

			//验证最后一根K线指标之间的关系，驱动交易驱动
			XYKline kLast = KlineHandel.Instance.WHOLEREALKLINE[KlineHandel.Instance.WHOLEREALKLINE.Count - 1];

			if (kLast.Price > kLast.avg && m_firCrossAvg && kLast.BUYOrSell == "无持仓"  && kLast.avg != 0)
			{
				SafeRiseBuySingle();
				m_firCrossAvg = false;
			}
			else if (kLast.Price < kLast.avg && m_firCrossAvg && kLast.BUYOrSell == "无持仓" && kLast.avg != 0)
			{
				SafeRiseSellSingle();
				m_firCrossAvg = false;
			}

			if(KlineHandel.Instance.SINGLEREALKLINE.Count > 0)
			{
				XYKline kLastSingle = KlineHandel.Instance.SINGLEREALKLINE[KlineHandel.Instance.SINGLEREALKLINE.Count - 1];

				if (kLastSingle.BUYOrSell == "买入持仓" && kLast.Price < kLast.avg && kLast.avg != 0)
				{
					SafeRiseCoverSingle();
					m_firCrossAvg = true;
				}

				if (kLastSingle.BUYOrSell == "卖空持仓" && kLast.Price > kLast.avg && kLast.avg != 0)
				{
					SafeRiseCoverSingle();
					m_firCrossAvg = true;
				}
			}

		}
	}
}
