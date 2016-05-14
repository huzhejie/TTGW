using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// counterpart_investment_finished_situation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class counterpart_investment_finished_situation
	{
		public counterpart_investment_finished_situation()
		{}
		#region Model
		private string _project_id;
		private int _year;
		private int _month;
		private decimal? _summary;
		private decimal? _counterpart_founds;
		private decimal? _other_matching_founds;
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
		public int month
		{
			set{ _month=value;}
			get{return _month;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? summary
		{
			set{ _summary=value;}
			get{return _summary;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? counterpart_founds
		{
			set{ _counterpart_founds=value;}
			get{return _counterpart_founds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? other_matching_founds
		{
			set{ _other_matching_founds=value;}
			get{return _other_matching_founds;}
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

