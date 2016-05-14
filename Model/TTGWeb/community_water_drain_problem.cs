using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_water_drain_problem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_water_drain_problem
	{
		public community_water_drain_problem()
		{}
		#region Model
		private string _community_id;
		private string _community_fill_type;
		private int? _community_pipe_no_reasonable_num;
		private int? _community_form_warea_num;
		private int? _community_form_warea_affect_res_num;
		private int? _community_not_access_uspn_res_num;
		private int? _community_not_access_uspn_house_num;
		private int? _community_insuf_pipe_size_num;
		private int? _community_pipe_aging_corrosion_num;
		private int? _community_pipe_damage_num;
		private int? _community_septic_small_volume_num;
		private int? _community_septic_damage_leaking_num;
		private int? _community_sewage_straight_to_cj_num;
		private int? _community_gutter_damage;
		private string _community_insuf_gutter;
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
		private string _tciunset14;
		private string _tciunset15;
		private string _tciunset16;
		private int _lock_tables=0;
		private decimal? _community_pipe_damage_length;
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
		public int? community_pipe_no_reasonable_num
		{
			set{ _community_pipe_no_reasonable_num=value;}
			get{return _community_pipe_no_reasonable_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_form_warea_num
		{
			set{ _community_form_warea_num=value;}
			get{return _community_form_warea_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_form_warea_affect_res_num
		{
			set{ _community_form_warea_affect_res_num=value;}
			get{return _community_form_warea_affect_res_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_not_access_uspn_res_num
		{
			set{ _community_not_access_uspn_res_num=value;}
			get{return _community_not_access_uspn_res_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_not_access_uspn_house_num
		{
			set{ _community_not_access_uspn_house_num=value;}
			get{return _community_not_access_uspn_house_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_insuf_pipe_size_num
		{
			set{ _community_insuf_pipe_size_num=value;}
			get{return _community_insuf_pipe_size_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_pipe_aging_corrosion_num
		{
			set{ _community_pipe_aging_corrosion_num=value;}
			get{return _community_pipe_aging_corrosion_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_pipe_damage_num
		{
			set{ _community_pipe_damage_num=value;}
			get{return _community_pipe_damage_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_septic_small_volume_num
		{
			set{ _community_septic_small_volume_num=value;}
			get{return _community_septic_small_volume_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_septic_damage_leaking_num
		{
			set{ _community_septic_damage_leaking_num=value;}
			get{return _community_septic_damage_leaking_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_sewage_straight_to_cj_num
		{
			set{ _community_sewage_straight_to_cj_num=value;}
			get{return _community_sewage_straight_to_cj_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_gutter_damage
		{
			set{ _community_gutter_damage=value;}
			get{return _community_gutter_damage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_insuf_gutter
		{
			set{ _community_insuf_gutter=value;}
			get{return _community_insuf_gutter;}
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
		public string tciunset14
		{
			set{ _tciunset14=value;}
			get{return _tciunset14;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset15
		{
			set{ _tciunset15=value;}
			get{return _tciunset15;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset16
		{
			set{ _tciunset16=value;}
			get{return _tciunset16;}
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
		public decimal? community_pipe_damage_length
		{
			set{ _community_pipe_damage_length=value;}
			get{return _community_pipe_damage_length;}
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

