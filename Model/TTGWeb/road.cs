using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// road:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class road
	{
		public road()
		{}
		#region Model
		private string _id;
		private string _name;
		private string _community;
		private string _road_class;
		private decimal? _width;
		private decimal? _pavement_width;
		private decimal? _community_road_length;
		private string _structure;
		private string _is_dead_end_road;
		private decimal? _damage_road_length;
		private decimal? _large_slope_road_length;
		private decimal? _no_hard_road_length;
		private decimal? _lack_width_road_length;
		private string _is_somewhere_no_link;
		private decimal? _no_afforest_road_length;
		private decimal? _less_afforest_road_length;
		private int? _street_light_amount;
		private int? _good_street_light_amount;
		private int? _road_hydrant_amount;
		private int? _good_road_hydrant_amount;
		private int? _road_dustbin_amount;
		private int? _good_road_dustbin_amount;
		private int? _road_parking_space_num;
		private int? _parking_space_use_rate;
		private string _note_information;
		private DateTime _statistics_date;
		private int _check_status=0;
		private int _lock_tables=0;
		private string _trunset1;
		private string _trunset2;
		private string _trunset3;
		private string _trunset4;
		private string _trunset5;
		private string _trunset6;
		private string _trunset7;
		private string _trunset8;
		private string _trunset9;
		private string _trunset10;
		private string _trunset11;
		private string _trunset12;
		private string _trunset13;
		private string _trunset14;
		private string _trunset15;
		private string _trunset16;
		private string _trunset17;
		private string _trunset18;
		private string _trunset19;
		private string _trunset20;
		private string _trunset21;
		private string _trunset22;
		private string _trunset23;
		private string _trunset24;
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community
		{
			set{ _community=value;}
			get{return _community;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string road_class
		{
			set{ _road_class=value;}
			get{return _road_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? width
		{
			set{ _width=value;}
			get{return _width;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? pavement_width
		{
			set{ _pavement_width=value;}
			get{return _pavement_width;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_road_length
		{
			set{ _community_road_length=value;}
			get{return _community_road_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string structure
		{
			set{ _structure=value;}
			get{return _structure;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string is_dead_end_road
		{
			set{ _is_dead_end_road=value;}
			get{return _is_dead_end_road;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? damage_road_length
		{
			set{ _damage_road_length=value;}
			get{return _damage_road_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? large_slope_road_length
		{
			set{ _large_slope_road_length=value;}
			get{return _large_slope_road_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? no_hard_road_length
		{
			set{ _no_hard_road_length=value;}
			get{return _no_hard_road_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? lack_width_road_length
		{
			set{ _lack_width_road_length=value;}
			get{return _lack_width_road_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string is_somewhere_no_link
		{
			set{ _is_somewhere_no_link=value;}
			get{return _is_somewhere_no_link;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? no_afforest_road_length
		{
			set{ _no_afforest_road_length=value;}
			get{return _no_afforest_road_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? less_afforest_road_length
		{
			set{ _less_afforest_road_length=value;}
			get{return _less_afforest_road_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? street_light_amount
		{
			set{ _street_light_amount=value;}
			get{return _street_light_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? good_street_light_amount
		{
			set{ _good_street_light_amount=value;}
			get{return _good_street_light_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? road_hydrant_amount
		{
			set{ _road_hydrant_amount=value;}
			get{return _road_hydrant_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? good_road_hydrant_amount
		{
			set{ _good_road_hydrant_amount=value;}
			get{return _good_road_hydrant_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? road_dustbin_amount
		{
			set{ _road_dustbin_amount=value;}
			get{return _road_dustbin_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? good_road_dustbin_amount
		{
			set{ _good_road_dustbin_amount=value;}
			get{return _good_road_dustbin_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? road_parking_space_num
		{
			set{ _road_parking_space_num=value;}
			get{return _road_parking_space_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? parking_space_use_rate
		{
			set{ _parking_space_use_rate=value;}
			get{return _parking_space_use_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string note_information
		{
			set{ _note_information=value;}
			get{return _note_information;}
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
		public int lock_tables
		{
			set{ _lock_tables=value;}
			get{return _lock_tables;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset1
		{
			set{ _trunset1=value;}
			get{return _trunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset2
		{
			set{ _trunset2=value;}
			get{return _trunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset3
		{
			set{ _trunset3=value;}
			get{return _trunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset4
		{
			set{ _trunset4=value;}
			get{return _trunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset5
		{
			set{ _trunset5=value;}
			get{return _trunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset6
		{
			set{ _trunset6=value;}
			get{return _trunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset7
		{
			set{ _trunset7=value;}
			get{return _trunset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset8
		{
			set{ _trunset8=value;}
			get{return _trunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset9
		{
			set{ _trunset9=value;}
			get{return _trunset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset10
		{
			set{ _trunset10=value;}
			get{return _trunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset11
		{
			set{ _trunset11=value;}
			get{return _trunset11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset12
		{
			set{ _trunset12=value;}
			get{return _trunset12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset13
		{
			set{ _trunset13=value;}
			get{return _trunset13;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset14
		{
			set{ _trunset14=value;}
			get{return _trunset14;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset15
		{
			set{ _trunset15=value;}
			get{return _trunset15;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset16
		{
			set{ _trunset16=value;}
			get{return _trunset16;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset17
		{
			set{ _trunset17=value;}
			get{return _trunset17;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset18
		{
			set{ _trunset18=value;}
			get{return _trunset18;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset19
		{
			set{ _trunset19=value;}
			get{return _trunset19;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset20
		{
			set{ _trunset20=value;}
			get{return _trunset20;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset21
		{
			set{ _trunset21=value;}
			get{return _trunset21;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset22
		{
			set{ _trunset22=value;}
			get{return _trunset22;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset23
		{
			set{ _trunset23=value;}
			get{return _trunset23;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trunset24
		{
			set{ _trunset24=value;}
			get{return _trunset24;}
		}
		#endregion Model

	}
}

