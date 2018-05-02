using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingStrategyInfomation.DataType
{
	public class KlineHandel
	{

		#region member

		private List<XYKline> m_wholeRealKline = new List<XYKline>();//所有K线的集合
		private List<XYKline> m_singleKline = new List<XYKline>();   //所有带信号的K线的集合

		private static object m_object = new object();  

		public List<XYKline> WHOLEREALKLINE
		{
			get
			{
				lock(m_object)
				{
					return m_wholeRealKline;
				}
			}
		}

		public List<XYKline> SINGLEREALKLINE
		{
			get
			{
				lock(m_object)
				{
					return m_singleKline;
				}
			}
		}

		#endregion  

		#region constuction
		private KlineHandel()
		{
		}

		private static KlineHandel m_instance = null;

		public static KlineHandel Instance
		{
			get
			{
				lock (m_object)
				{
					if (m_instance == null)
					{
						m_instance = new KlineHandel();
						return m_instance;
					}

					return m_instance;
				}
			}
		}
		#endregion

		public void AddXYKlineSingle(XYKline k)
		{
			lock(m_object)
			{
				this.m_singleKline.Add(k);
			}
		}

		public void AddWholeXYKline(XYKline k)
		{
			lock(m_object)
			{
				this.m_wholeRealKline.Add(k);
			}
		}
	}
}
