using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// Community_Base:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Community_Base
	{
		public Community_Base()
		{}
		#region Model
		private string _community_id;
		private string _community_name;
		private string _community_location;
		private string _community_county;
		private string _community_type;
		private string _community_feature;
		private string _community_function_area;
		private string _community_function_type;
		private decimal? _distance_to_county;
		private decimal? _distance_to_street_committees;
		private decimal? _distance_to_main_business_area;
		private decimal? _distance_to_main_education_area;
		private decimal? _distance_to_railway_station;
		private decimal? _distance_to_coach_station;
		private decimal? _distance_to_passenger_quay;
		private decimal? _distance_to_main_street;
		private decimal? _distance_to_collector_street;
		private DateTime _statistics_date;
		private string _tbcunset1;
		private string _tbcunset2;
		private string _tbcunset3;
		private string _tbcunset4;
		private string _tbcunset5;
		private string _tbcunset6;
		private string _tbcunset7;
		private string _tbcunset8;
		private string _tbcunset9;
		private string _tbcunset10;
		private string _tbcunset11;
		private string _tbcunset12;
		private string _tbcunset13;
		private string _tbcunset14;
		private string _tbcunset15;
		private string _tbcunset16;
		private string _tbcunset17;
		private int _check_status=0;
		private int _lock_tables=0;
		private string _community_wcommunity;
		private string _community_category;
		private int? _community_construct_year;
		private string _community_province;
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
		public string community_name
		{
			set{ _community_name=value;}
			get{return _community_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_location
		{
			set{ _community_location=value;}
			get{return _community_location;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_county
		{
			set{ _community_county=value;}
			get{return _community_county;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_type
		{
			set{ _community_type=value;}
			get{return _community_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_feature
		{
			set{ _community_feature=value;}
			get{return _community_feature;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_function_area
		{
			set{ _community_function_area=value;}
			get{return _community_function_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_function_type
		{
			set{ _community_function_type=value;}
			get{return _community_function_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? distance_to_county
		{
			set{ _distance_to_county=value;}
			get{return _distance_to_county;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? distance_to_street_committees
		{
			set{ _distance_to_street_committees=value;}
			get{return _distance_to_street_committees;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? distance_to_main_business_area
		{
			set{ _distance_to_main_business_area=value;}
			get{return _distance_to_main_business_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? distance_to_main_education_area
		{
			set{ _distance_to_main_education_area=value;}
			get{return _distance_to_main_education_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? distance_to_railway_station
		{
			set{ _distance_to_railway_station=value;}
			get{return _distance_to_railway_station;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? distance_to_coach_station
		{
			set{ _distance_to_coach_station=value;}
			get{return _distance_to_coach_station;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? distance_to_passenger_quay
		{
			set{ _distance_to_passenger_quay=value;}
			get{return _distance_to_passenger_quay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? distance_to_main_street
		{
			set{ _distance_to_main_street=value;}
			get{return _distance_to_main_street;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? distance_to_collector_street
		{
			set{ _distance_to_collector_street=value;}
			get{return _distance_to_collector_street;}
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
		public string tbcunset1
		{
			set{ _tbcunset1=value;}
			get{return _tbcunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset2
		{
			set{ _tbcunset2=value;}
			get{return _tbcunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset3
		{
			set{ _tbcunset3=value;}
			get{return _tbcunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset4
		{
			set{ _tbcunset4=value;}
			get{return _tbcunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset5
		{
			set{ _tbcunset5=value;}
			get{return _tbcunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset6
		{
			set{ _tbcunset6=value;}
			get{return _tbcunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset7
		{
			set{ _tbcunset7=value;}
			get{return _tbcunset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset8
		{
			set{ _tbcunset8=value;}
			get{return _tbcunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset9
		{
			set{ _tbcunset9=value;}
			get{return _tbcunset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset10
		{
			set{ _tbcunset10=value;}
			get{return _tbcunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset11
		{
			set{ _tbcunset11=value;}
			get{return _tbcunset11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset12
		{
			set{ _tbcunset12=value;}
			get{return _tbcunset12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset13
		{
			set{ _tbcunset13=value;}
			get{return _tbcunset13;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset14
		{
			set{ _tbcunset14=value;}
			get{return _tbcunset14;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset15
		{
			set{ _tbcunset15=value;}
			get{return _tbcunset15;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset16
		{
			set{ _tbcunset16=value;}
			get{return _tbcunset16;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tbcunset17
		{
			set{ _tbcunset17=value;}
			get{return _tbcunset17;}
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
		public string community_wcommunity
		{
			set{ _community_wcommunity=value;}
			get{return _community_wcommunity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_category
		{
			set{ _community_category=value;}
			get{return _community_category;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_construct_year
		{
			set{ _community_construct_year=value;}
			get{return _community_construct_year;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_province
		{
			set{ _community_province=value;}
			get{return _community_province;}
		}
		#endregion Model

	}
}

