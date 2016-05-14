using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// subsequent_project:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class subsequent_project
	{
		public subsequent_project()
		{}
		#region Model
		private int _id;
		private string _project_id;
		private string _county_name;
		private string _after_id;
		private string _project_name;
		private int _year;
		private decimal? _total_investment;
		private decimal? _follow_up_special_founds;
		private decimal? _conterpart_founds;
		private decimal? _other_matching_founds;
		private decimal? _apply_for_founds;
		private int? _plan_implementation_date;
		private DateTime _fill_time;
		private int _check_status=0;
		private int _lock_tables=0;
		private string _unset1;
		private string _unset2;
		private string _unset3;
		private string _unset4;
		private string _unset5;
		private string _unset6;
		private string _unset7;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
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
		public string county_name
		{
			set{ _county_name=value;}
			get{return _county_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string after_id
		{
			set{ _after_id=value;}
			get{return _after_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_name
		{
			set{ _project_name=value;}
			get{return _project_name;}
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
		public decimal? total_investment
		{
			set{ _total_investment=value;}
			get{return _total_investment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? follow_up_special_founds
		{
			set{ _follow_up_special_founds=value;}
			get{return _follow_up_special_founds;}
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
		public decimal? other_matching_founds
		{
			set{ _other_matching_founds=value;}
			get{return _other_matching_founds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? apply_for_founds
		{
			set{ _apply_for_founds=value;}
			get{return _apply_for_founds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? plan_implementation_date
		{
			set{ _plan_implementation_date=value;}
			get{return _plan_implementation_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime fill_time
		{
			set{ _fill_time=value;}
			get{return _fill_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int check_status
		{
			set{ _check_status=value;}
			get{return _check_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int lock_tables
		{
			set{ _lock_tables=value;}
			get{return _lock_tables;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset1
		{
			set{ _unset1=value;}
			get{return _unset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset2
		{
			set{ _unset2=value;}
			get{return _unset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset3
		{
			set{ _unset3=value;}
			get{return _unset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset4
		{
			set{ _unset4=value;}
			get{return _unset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset5
		{
			set{ _unset5=value;}
			get{return _unset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset6
		{
			set{ _unset6=value;}
			get{return _unset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset7
		{
			set{ _unset7=value;}
			get{return _unset7;}
		}
		#endregion Model

	}
}

