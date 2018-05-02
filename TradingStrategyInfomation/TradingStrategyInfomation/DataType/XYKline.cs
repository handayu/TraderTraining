using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingStrategyInfomation
{


	public class XYKline
	{
		public DateTime DateTimeStr
		{
			get;
			set;
		}

		public int Price
		{
					 
			get;
			set;
		 
		}

		public double avg
		{
			get;
			set;
		}

		public double K
		{
			get;
			set;
		}

		public double D
		{
			get;
			set;
		}

		public string Volumn
		{
			get;
			set;
		}
		/// <summary>
		/// 买卖
		/// </summary>
		public string BUYOrSell
		{
			get;
			set;
		}
	}

}
