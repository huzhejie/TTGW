using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_social_insurance:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_social_insurance
	{
		public community_social_insurance()
		{}
		#region Model
		private string _community_id;
		private int? _community_urban_min_living_sec_pop;
		private int? _community_very_poor_household_pop;
		private int? _community_large_med_resv_immg_pop;
		private int? _community_chongqing_immg_poor_pop;
		private int? _community_medicare_pop;
		private int? _community_endow_insu_pop;
		private int? _community_unemp_insu_pop;
		private DateTime _statistics_date;
		private string _tcsiunset1;
		private string _tcsiunset2;
		private string _tcsiunset3;
		private string _tcsiunset4;
		private string _tcsiunset5;
		private string _tcsiunset6;
		private string _tcsiunset7;
		private int _lock_tables=0;
		private int _check_status=0;
		private decimal? _poor_people_rate;
		/// <summary>
		/// 
		/// </summary>
		public string community_id
		{
			set{ _community_id=value;}
			get{return _community_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_urban_min_living_sec_pop
		{
			set{ _community_urban_min_living_sec_pop=value;}
			get{return _community_urban_min_living_sec_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_very_poor_household_pop
		{
			set{ _community_very_poor_household_pop=value;}
			get{return _community_very_poor_household_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_large_med_resv_immg_pop
		{
			set{ _community_large_med_resv_immg_pop=value;}
			get{return _community_large_med_resv_immg_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_chongqing_immg_poor_pop
		{
			set{ _community_chongqing_immg_poor_pop=value;}
			get{return _community_chongqing_immg_poor_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_medicare_pop
		{
			set{ _community_medicare_pop=value;}
			get{return _community_medicare_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_endow_insu_pop
		{
			set{ _community_endow_insu_pop=value;}
			get{return _community_endow_insu_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_unemp_insu_pop
		{
			set{ _community_unemp_insu_pop=value;}
			get{return _community_unemp_insu_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime statistics_date
		{
			set{ _statistics_date=value;}
			get{return _statistics_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsiunset1
		{
			set{ _tcsiunset1=value;}
			get{return _tcsiunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsiunset2
		{
			set{ _tcsiunset2=value;}
			get{return _tcsiunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsiunset3
		{
			set{ _tcsiunset3=value;}
			get{return _tcsiunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsiunset4
		{
			set{ _tcsiunset4=value;}
			get{return _tcsiunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsiunset5
		{
			set{ _tcsiunset5=value;}
			get{return _tcsiunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsiunset6
		{
			set{ _tcsiunset6=value;}
			get{return _tcsiunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsiunset7
		{
			set{ _tcsiunset7=value;}
			get{return _tcsiunset7;}
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
		public int check_status
		{
			set{ _check_status=value;}
			get{return _check_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? poor_people_rate
		{
			set{ _poor_people_rate=value;}
			get{return _poor_people_rate;}
		}
		#endregion Model

	}
}

