using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_ff_problem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_ff_problem
	{
		public community_ff_problem()
		{}
		#region Model
		private string _community_id;
		private string _community_fill_type;
		private int? _community_road_lack_outdoor_fh_num;
		private decimal? _community_road_lack_outdoor_fh_length;
		private int? _community_lack_indoor_fh_building_num;
		private int? _community_lack_fe_building_num;
		private int? _community_fp_damage_num;
		private decimal? _community_fp_damage_length;
		private int? _community_fr_less_4_4_building;
		private int? _community_mer_wout_12_12_by_building_num;
		private int? _community_oo_beside_fr_building;
		private int? _community_outdoor_ff_damage_num;
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
		private decimal? _community_unreach_length;
		private int? _community_ff_damage_indoors;
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
		public int? community_road_lack_outdoor_fh_num
		{
			set{ _community_road_lack_outdoor_fh_num=value;}
			get{return _community_road_lack_outdoor_fh_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_road_lack_outdoor_fh_length
		{
			set{ _community_road_lack_outdoor_fh_length=value;}
			get{return _community_road_lack_outdoor_fh_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_lack_indoor_fh_building_num
		{
			set{ _community_lack_indoor_fh_building_num=value;}
			get{return _community_lack_indoor_fh_building_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_lack_fe_building_num
		{
			set{ _community_lack_fe_building_num=value;}
			get{return _community_lack_fe_building_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_fp_damage_num
		{
			set{ _community_fp_damage_num=value;}
			get{return _community_fp_damage_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_fp_damage_length
		{
			set{ _community_fp_damage_length=value;}
			get{return _community_fp_damage_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_fr_less_4_4_building
		{
			set{ _community_fr_less_4_4_building=value;}
			get{return _community_fr_less_4_4_building;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_mer_wout_12_12_by_building_num
		{
			set{ _community_mer_wout_12_12_by_building_num=value;}
			get{return _community_mer_wout_12_12_by_building_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_oo_beside_fr_building
		{
			set{ _community_oo_beside_fr_building=value;}
			get{return _community_oo_beside_fr_building;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_outdoor_ff_damage_num
		{
			set{ _community_outdoor_ff_damage_num=value;}
			get{return _community_outdoor_ff_damage_num;}
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
		public decimal? community_unreach_length
		{
			set{ _community_unreach_length=value;}
			get{return _community_unreach_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_ff_damage_indoors
		{
			set{ _community_ff_damage_indoors=value;}
			get{return _community_ff_damage_indoors;}
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

