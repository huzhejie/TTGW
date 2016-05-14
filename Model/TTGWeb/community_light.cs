using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_light:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_light
	{
		public community_light()
		{}
		#region Model
		private string _community_id;
		private int? _community_streetlight_num;
		private int? _community_energy_efficient_streetlight_num;
		private decimal? _community_good_streetlight_rate;
		private int? _community_otd_exercise_yard_light_num;
		private decimal? _community_otd_good_exercise_yard_light_rate;
		private int? _community_passageway_light_num;
		private decimal? _community_good_passageway_light_rate;
		private DateTime _statistics_date;
		private string _tcltunset1;
		private string _tcltunset2;
		private string _tcltunset3;
		private string _tcltunset4;
		private string _tcltunset5;
		private string _tcltunset6;
		private string _tcltunset7;
		private int _lock_tables=0;
		private int _check_status=0;
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
		public int? community_streetlight_num
		{
			set{ _community_streetlight_num=value;}
			get{return _community_streetlight_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_energy_efficient_streetlight_num
		{
			set{ _community_energy_efficient_streetlight_num=value;}
			get{return _community_energy_efficient_streetlight_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_good_streetlight_rate
		{
			set{ _community_good_streetlight_rate=value;}
			get{return _community_good_streetlight_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_otd_exercise_yard_light_num
		{
			set{ _community_otd_exercise_yard_light_num=value;}
			get{return _community_otd_exercise_yard_light_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_otd_good_exercise_yard_light_rate
		{
			set{ _community_otd_good_exercise_yard_light_rate=value;}
			get{return _community_otd_good_exercise_yard_light_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_passageway_light_num
		{
			set{ _community_passageway_light_num=value;}
			get{return _community_passageway_light_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_good_passageway_light_rate
		{
			set{ _community_good_passageway_light_rate=value;}
			get{return _community_good_passageway_light_rate;}
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
		public string tcltunset1
		{
			set{ _tcltunset1=value;}
			get{return _tcltunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcltunset2
		{
			set{ _tcltunset2=value;}
			get{return _tcltunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcltunset3
		{
			set{ _tcltunset3=value;}
			get{return _tcltunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcltunset4
		{
			set{ _tcltunset4=value;}
			get{return _tcltunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcltunset5
		{
			set{ _tcltunset5=value;}
			get{return _tcltunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcltunset6
		{
			set{ _tcltunset6=value;}
			get{return _tcltunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcltunset7
		{
			set{ _tcltunset7=value;}
			get{return _tcltunset7;}
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
		#endregion Model

	}
}

