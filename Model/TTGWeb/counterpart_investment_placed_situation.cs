using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// counterpart_investment_placed_situation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class counterpart_investment_placed_situation
	{
		public counterpart_investment_placed_situation()
		{}
		#region Model
		private string _project_id;
		private int _year;
		private decimal? _march_investment;
		private decimal? _june_investment;
		private decimal? _september_investment;
		private decimal? _december_investment;
		private DateTime _fill_time;
		/// <summary>
		/// 
		/// </summary>
		public string project_id
		{
			set{ _project_id=value;}
			get{return _project_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int year
		{
			set{ _year=value;}
			get{return _year;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? march_investment
		{
			set{ _march_investment=value;}
			get{return _march_investment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? june_investment
		{
			set{ _june_investment=value;}
			get{return _june_investment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? september_investment
		{
			set{ _september_investment=value;}
			get{return _september_investment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? december_investment
		{
			set{ _december_investment=value;}
			get{return _december_investment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime fill_time
		{
			set{ _fill_time=value;}
			get{return _fill_time;}
		}
		#endregion Model

	}
}

