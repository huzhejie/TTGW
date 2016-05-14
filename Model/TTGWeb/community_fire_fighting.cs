using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_fire_fighting:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_fire_fighting
	{
		public community_fire_fighting()
		{}
		#region Model
		private string _community_id;
		private int? _community_extinguisher_num;
		private decimal? _community_good_extinguisher_rate;
		private int? _community_hydrant_num;
		private int? _community_ots_hydrant_num;
		private decimal? _community_good_ots_hydrant_rate;
		private int? _community_ind_hydrant_num;
		private decimal? _community_good_ind_hydrant_rate;
		private decimal? _community_ff_pipe_length;
		private decimal? _community_ff_pipe_caliber_larger_than_100mm_length;
		private decimal? _community_ff_pipe_caliber_less_than_100mm_length;
		private int? _source_of_ff_water_num;
		private int? _natural_ff_water_source_num;
		private int? _municipal_administration_pipe_net_ff_water_source;
		private int? _ff_water_pool_num;
		private DateTime _statistics_date;
		private string _tcffunset1;
		private string _tcffunset2;
		private string _tcffunset3;
		private string _tcffunset4;
		private string _tcffunset5;
		private string _tcffunset6;
		private string _tcffunset7;
		private string _tcffunset8;
		private string _tcffunset9;
		private string _tcffunset10;
		private string _tcffunset11;
		private string _tcffunset12;
		private string _tcffunset13;
		private string _tcffunset14;
		private int _lock_tables=0;
		private int _check_status=0;
		private decimal? _community_ff_not_attain_pass_length;
		private decimal? _community_ff_pass_length;
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
		public int? community_extinguisher_num
		{
			set{ _community_extinguisher_num=value;}
			get{return _community_extinguisher_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_good_extinguisher_rate
		{
			set{ _community_good_extinguisher_rate=value;}
			get{return _community_good_extinguisher_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_hydrant_num
		{
			set{ _community_hydrant_num=value;}
			get{return _community_hydrant_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_ots_hydrant_num
		{
			set{ _community_ots_hydrant_num=value;}
			get{return _community_ots_hydrant_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_good_ots_hydrant_rate
		{
			set{ _community_good_ots_hydrant_rate=value;}
			get{return _community_good_ots_hydrant_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_ind_hydrant_num
		{
			set{ _community_ind_hydrant_num=value;}
			get{return _community_ind_hydrant_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_good_ind_hydrant_rate
		{
			set{ _community_good_ind_hydrant_rate=value;}
			get{return _community_good_ind_hydrant_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_ff_pipe_length
		{
			set{ _community_ff_pipe_length=value;}
			get{return _community_ff_pipe_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_ff_pipe_caliber_larger_than_100mm_length
		{
			set{ _community_ff_pipe_caliber_larger_than_100mm_length=value;}
			get{return _community_ff_pipe_caliber_larger_than_100mm_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_ff_pipe_caliber_less_than_100mm_length
		{
			set{ _community_ff_pipe_caliber_less_than_100mm_length=value;}
			get{return _community_ff_pipe_caliber_less_than_100mm_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? source_of_ff_water_num
		{
			set{ _source_of_ff_water_num=value;}
			get{return _source_of_ff_water_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? natural_ff_water_source_num
		{
			set{ _natural_ff_water_source_num=value;}
			get{return _natural_ff_water_source_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? municipal_administration_pipe_net_ff_water_source
		{
			set{ _municipal_administration_pipe_net_ff_water_source=value;}
			get{return _municipal_administration_pipe_net_ff_water_source;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ff_water_pool_num
		{
			set{ _ff_water_pool_num=value;}
			get{return _ff_water_pool_num;}
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
		public string tcffunset1
		{
			set{ _tcffunset1=value;}
			get{return _tcffunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcffunset2
		{
			set{ _tcffunset2=value;}
			get{return _tcffunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcffunset3
		{
			set{ _tcffunset3=value;}
			get{return _tcffunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcffunset4
		{
			set{ _tcffunset4=value;}
			get{return _tcffunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcffunset5
		{
			set{ _tcffunset5=value;}
			get{return _tcffunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcffunset6
		{
			set{ _tcffunset6=value;}
			get{return _tcffunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcffunset7
		{
			set{ _tcffunset7=value;}
			get{return _tcffunset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcffunset8
		{
			set{ _tcffunset8=value;}
			get{return _tcffunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcffunset9
		{
			set{ _tcffunset9=value;}
			get{return _tcffunset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcffunset10
		{
			set{ _tcffunset10=value;}
			get{return _tcffunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcffunset11
		{
			set{ _tcffunset11=value;}
			get{return _tcffunset11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcffunset12
		{
			set{ _tcffunset12=value;}
			get{return _tcffunset12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcffunset13
		{
			set{ _tcffunset13=value;}
			get{return _tcffunset13;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcffunset14
		{
			set{ _tcffunset14=value;}
			get{return _tcffunset14;}
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
		public decimal? community_ff_not_attain_pass_length
		{
			set{ _community_ff_not_attain_pass_length=value;}
			get{return _community_ff_not_attain_pass_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_ff_pass_length
		{
			set{ _community_ff_pass_length=value;}
			get{return _community_ff_pass_length;}
		}
		#endregion Model

	}
}

