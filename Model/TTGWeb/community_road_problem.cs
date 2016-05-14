using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_road_problem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_road_problem
	{
		public community_road_problem()
		{}
		#region Model
		private string _community_id;
		private string _community_fill_type;
		private decimal? _community_road_not_hardening_area;
		private decimal? _community_road_large_slope_length;
		private decimal? _community_road_insuf_width_length;
		private decimal? _community_road_pavement_damage_area;
		private decimal? _community_sidewalk_cb_damage_area;
		private int? _community_broken_road_num;
		private int? _community_sarea_lack_lroad;
		private decimal? _community_to_city_pasway_pavement_damage;
		private decimal? _community_to_city_pasway_pavement_insuf_width;
		private DateTime _statistics_date;
		private int _check_status=0;
		private string _tciunset1;
		private string _tciunset2;
		private string _tciunset3;
		private string _tciunset4;
		private string _tciunset5;
		private string _tciunset6;
		private string _tciunset7;
		private string _tciunset8;
		private string _tciunset9;
		private string _tciunset10;
		private string _tciunset11;
		private string _tciunset12;
		private string _tciunset13;
		private int _lock_tables=0;
		private int _complete_year;
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
		public string community_fill_type
		{
			set{ _community_fill_type=value;}
			get{return _community_fill_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_road_not_hardening_area
		{
			set{ _community_road_not_hardening_area=value;}
			get{return _community_road_not_hardening_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_road_large_slope_length
		{
			set{ _community_road_large_slope_length=value;}
			get{return _community_road_large_slope_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_road_insuf_width_length
		{
			set{ _community_road_insuf_width_length=value;}
			get{return _community_road_insuf_width_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_road_pavement_damage_area
		{
			set{ _community_road_pavement_damage_area=value;}
			get{return _community_road_pavement_damage_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_sidewalk_cb_damage_area
		{
			set{ _community_sidewalk_cb_damage_area=value;}
			get{return _community_sidewalk_cb_damage_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_broken_road_num
		{
			set{ _community_broken_road_num=value;}
			get{return _community_broken_road_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_sarea_lack_lroad
		{
			set{ _community_sarea_lack_lroad=value;}
			get{return _community_sarea_lack_lroad;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_to_city_pasway_pavement_damage
		{
			set{ _community_to_city_pasway_pavement_damage=value;}
			get{return _community_to_city_pasway_pavement_damage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_to_city_pasway_pavement_insuf_width
		{
			set{ _community_to_city_pasway_pavement_insuf_width=value;}
			get{return _community_to_city_pasway_pavement_insuf_width;}
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
		public int check_status
		{
			set{ _check_status=value;}
			get{return _check_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset1
		{
			set{ _tciunset1=value;}
			get{return _tciunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset2
		{
			set{ _tciunset2=value;}
			get{return _tciunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset3
		{
			set{ _tciunset3=value;}
			get{return _tciunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset4
		{
			set{ _tciunset4=value;}
			get{return _tciunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset5
		{
			set{ _tciunset5=value;}
			get{return _tciunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset6
		{
			set{ _tciunset6=value;}
			get{return _tciunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset7
		{
			set{ _tciunset7=value;}
			get{return _tciunset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset8
		{
			set{ _tciunset8=value;}
			get{return _tciunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset9
		{
			set{ _tciunset9=value;}
			get{return _tciunset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset10
		{
			set{ _tciunset10=value;}
			get{return _tciunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset11
		{
			set{ _tciunset11=value;}
			get{return _tciunset11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset12
		{
			set{ _tciunset12=value;}
			get{return _tciunset12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset13
		{
			set{ _tciunset13=value;}
			get{return _tciunset13;}
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
		public int complete_year
		{
			set{ _complete_year=value;}
			get{return _complete_year;}
		}
		#endregion Model

	}
}

