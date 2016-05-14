using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_geologic_hazard:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_geologic_hazard
	{
		public community_geologic_hazard()
		{}
		#region Model
		private string _community_id;
		private int? _serious_geologic_hazard_num;
		private int? _serious_geologic_hazard_handle_num;
		private decimal? _influence_house_area;
		private decimal? _protect_house_area;
		private DateTime _statistics_date;
		private string _tcghunset1;
		private string _tcghunset2;
		private string _tcghunset3;
		private string _tcghunset4;
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
		public int? serious_geologic_hazard_num
		{
			set{ _serious_geologic_hazard_num=value;}
			get{return _serious_geologic_hazard_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? serious_geologic_hazard_handle_num
		{
			set{ _serious_geologic_hazard_handle_num=value;}
			get{return _serious_geologic_hazard_handle_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? influence_house_area
		{
			set{ _influence_house_area=value;}
			get{return _influence_house_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? protect_house_area
		{
			set{ _protect_house_area=value;}
			get{return _protect_house_area;}
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
		public string tcghunset1
		{
			set{ _tcghunset1=value;}
			get{return _tcghunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcghunset2
		{
			set{ _tcghunset2=value;}
			get{return _tcghunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcghunset3
		{
			set{ _tcghunset3=value;}
			get{return _tcghunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcghunset4
		{
			set{ _tcghunset4=value;}
			get{return _tcghunset4;}
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

