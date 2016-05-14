using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// investment_place_situation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class investment_place_situation
	{
		public investment_place_situation()
		{}
		#region Model
		private string _project_id;
		private int _year;
		private int _month;
		private decimal? _special_support_founds;
		private decimal? _conterpart_founds;
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
		public decimal? special_support_founds
		{
			set{ _special_support_founds=value;}
			get{return _special_support_founds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? conterpart_founds
		{
			set{ _conterpart_founds=value;}
			get{return _conterpart_founds;}
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

