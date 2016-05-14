using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_security:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_security
	{
		public community_security()
		{}
		#region Model
		private string _community_id;
		private int? _community_unit_can_build_guard_room_num;
		private int? _community_unit_with_guard_room_num;
		private int? _community_unit_can_install_mf_num;
		private int? _community_unit_with_mf_num;
		private int? _community_unit_can_build_fence_num;
		private int? _community_unit_with_fence_num;
		private decimal? _community_emergency_shelter_area;
		private int? _community_civil_air_defence_facilities_num;
		private decimal? _community_civil_air_defence_facilities_area;
		private DateTime _statistics_date;
		private int? _community_unit_can_build_gate_num;
		private int? _community_with_gate_num;
		private string _tcsunset1;
		private string _tcsunset2;
		private string _tcsunset3;
		private string _tcsunset4;
		private string _tcsunset5;
		private string _tcsunset6;
		private string _tcsunset7;
		private string _tcsunset8;
		private string _tcsunset9;
		private string _tcsunset10;
		private string _tcsunset11;
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
		public int? community_unit_can_build_guard_room_num
		{
			set{ _community_unit_can_build_guard_room_num=value;}
			get{return _community_unit_can_build_guard_room_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_unit_with_guard_room_num
		{
			set{ _community_unit_with_guard_room_num=value;}
			get{return _community_unit_with_guard_room_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_unit_can_install_mf_num
		{
			set{ _community_unit_can_install_mf_num=value;}
			get{return _community_unit_can_install_mf_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_unit_with_mf_num
		{
			set{ _community_unit_with_mf_num=value;}
			get{return _community_unit_with_mf_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_unit_can_build_fence_num
		{
			set{ _community_unit_can_build_fence_num=value;}
			get{return _community_unit_can_build_fence_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_unit_with_fence_num
		{
			set{ _community_unit_with_fence_num=value;}
			get{return _community_unit_with_fence_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_emergency_shelter_area
		{
			set{ _community_emergency_shelter_area=value;}
			get{return _community_emergency_shelter_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_civil_air_defence_facilities_num
		{
			set{ _community_civil_air_defence_facilities_num=value;}
			get{return _community_civil_air_defence_facilities_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_civil_air_defence_facilities_area
		{
			set{ _community_civil_air_defence_facilities_area=value;}
			get{return _community_civil_air_defence_facilities_area;}
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
		public int? community_unit_can_build_gate_num
		{
			set{ _community_unit_can_build_gate_num=value;}
			get{return _community_unit_can_build_gate_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_with_gate_num
		{
			set{ _community_with_gate_num=value;}
			get{return _community_with_gate_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsunset1
		{
			set{ _tcsunset1=value;}
			get{return _tcsunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsunset2
		{
			set{ _tcsunset2=value;}
			get{return _tcsunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsunset3
		{
			set{ _tcsunset3=value;}
			get{return _tcsunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsunset4
		{
			set{ _tcsunset4=value;}
			get{return _tcsunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsunset5
		{
			set{ _tcsunset5=value;}
			get{return _tcsunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsunset6
		{
			set{ _tcsunset6=value;}
			get{return _tcsunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsunset7
		{
			set{ _tcsunset7=value;}
			get{return _tcsunset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsunset8
		{
			set{ _tcsunset8=value;}
			get{return _tcsunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsunset9
		{
			set{ _tcsunset9=value;}
			get{return _tcsunset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsunset10
		{
			set{ _tcsunset10=value;}
			get{return _tcsunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsunset11
		{
			set{ _tcsunset11=value;}
			get{return _tcsunset11;}
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

