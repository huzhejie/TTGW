using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_green_fields:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_green_fields
	{
		public community_green_fields()
		{}
		#region Model
		private string _community_id;
		private decimal? _community_green_fields_area;
		private decimal? _community_park_green_fields_area;
		private decimal? _community_garden_green_fields_area;
		private decimal? _community_other_green_fields_area;
		private DateTime _statistics_date;
		private decimal? _community_green_fields_bet_dwellings_area;
		private decimal? _community_road_green_fields_area;
		private decimal? _community_public_accomm_green_fields_area;
		private string _tcgfunset1;
		private string _tcgfunset2;
		private string _tcgfunset3;
		private string _tcgfunset4;
		private string _tcgfunset5;
		private string _tcgfunset6;
		private string _tcgfunset7;
		private int _lock_tables=0;
		private int _check_status=0;
		private decimal? _green_rate_goal;
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
		public decimal? community_green_fields_area
		{
			set{ _community_green_fields_area=value;}
			get{return _community_green_fields_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_park_green_fields_area
		{
			set{ _community_park_green_fields_area=value;}
			get{return _community_park_green_fields_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_garden_green_fields_area
		{
			set{ _community_garden_green_fields_area=value;}
			get{return _community_garden_green_fields_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_other_green_fields_area
		{
			set{ _community_other_green_fields_area=value;}
			get{return _community_other_green_fields_area;}
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
		public decimal? community_green_fields_bet_dwellings_area
		{
			set{ _community_green_fields_bet_dwellings_area=value;}
			get{return _community_green_fields_bet_dwellings_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_road_green_fields_area
		{
			set{ _community_road_green_fields_area=value;}
			get{return _community_road_green_fields_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_public_accomm_green_fields_area
		{
			set{ _community_public_accomm_green_fields_area=value;}
			get{return _community_public_accomm_green_fields_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcgfunset1
		{
			set{ _tcgfunset1=value;}
			get{return _tcgfunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcgfunset2
		{
			set{ _tcgfunset2=value;}
			get{return _tcgfunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcgfunset3
		{
			set{ _tcgfunset3=value;}
			get{return _tcgfunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcgfunset4
		{
			set{ _tcgfunset4=value;}
			get{return _tcgfunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcgfunset5
		{
			set{ _tcgfunset5=value;}
			get{return _tcgfunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcgfunset6
		{
			set{ _tcgfunset6=value;}
			get{return _tcgfunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcgfunset7
		{
			set{ _tcgfunset7=value;}
			get{return _tcgfunset7;}
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
		public decimal? green_rate_goal
		{
			set{ _green_rate_goal=value;}
			get{return _green_rate_goal;}
		}
		#endregion Model

	}
}

