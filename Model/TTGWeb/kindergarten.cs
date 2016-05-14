using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// kindergarten:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class kindergarten
	{
		public kindergarten()
		{}
		#region Model
		private string _name;
		private string _community;
		private string _type;
		private decimal? _floor_space;
		private decimal? _gross_floor_area;
		private int? _students_amount;
		private int? _teachers_amount;
		private int? _class_amount;
		private decimal? _teachers_students_rate;
		private decimal? _activity_room_area;
		private string _activity_room_area_if_suff;
		private decimal? _otds_activity_room_area;
		private string _otds_activity_room_area_if_suff;
		private decimal? _afforest_area;
		private string _afforest_area_if_suff;
		private int? _school_bus_amount;
		private decimal? _pick_up_students_amount_daily;
		private string _note_information;
		private DateTime _statistics_date;
		private int _lock_tables=0;
		private int _check_status=0;
		private string _tkunset1;
		private string _tkunset2;
		private string _tkunset3;
		private string _tkunset4;
		private string _tkunset5;
		private string _tkunset6;
		private string _tkunset7;
		private string _tkunset8;
		private string _tkunset9;
		private string _tkunset10;
		private string _tkunset11;
		private string _tkunset12;
		private string _tkunset13;
		private string _tkunset14;
		private string _tkunset15;
		private string _tkunset16;
		private string _tkunset17;
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
		public string type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? floor_space
		{
			set{ _floor_space=value;}
			get{return _floor_space;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? gross_floor_area
		{
			set{ _gross_floor_area=value;}
			get{return _gross_floor_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? students_amount
		{
			set{ _students_amount=value;}
			get{return _students_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? teachers_amount
		{
			set{ _teachers_amount=value;}
			get{return _teachers_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? class_amount
		{
			set{ _class_amount=value;}
			get{return _class_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? teachers_students_rate
		{
			set{ _teachers_students_rate=value;}
			get{return _teachers_students_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? activity_room_area
		{
			set{ _activity_room_area=value;}
			get{return _activity_room_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string activity_room_area_if_suff
		{
			set{ _activity_room_area_if_suff=value;}
			get{return _activity_room_area_if_suff;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? otds_activity_room_area
		{
			set{ _otds_activity_room_area=value;}
			get{return _otds_activity_room_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string otds_activity_room_area_if_suff
		{
			set{ _otds_activity_room_area_if_suff=value;}
			get{return _otds_activity_room_area_if_suff;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? afforest_area
		{
			set{ _afforest_area=value;}
			get{return _afforest_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string afforest_area_if_suff
		{
			set{ _afforest_area_if_suff=value;}
			get{return _afforest_area_if_suff;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? school_bus_amount
		{
			set{ _school_bus_amount=value;}
			get{return _school_bus_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? pick_up_students_amount_daily
		{
			set{ _pick_up_students_amount_daily=value;}
			get{return _pick_up_students_amount_daily;}
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
		public string tkunset1
		{
			set{ _tkunset1=value;}
			get{return _tkunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset2
		{
			set{ _tkunset2=value;}
			get{return _tkunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset3
		{
			set{ _tkunset3=value;}
			get{return _tkunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset4
		{
			set{ _tkunset4=value;}
			get{return _tkunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset5
		{
			set{ _tkunset5=value;}
			get{return _tkunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset6
		{
			set{ _tkunset6=value;}
			get{return _tkunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset7
		{
			set{ _tkunset7=value;}
			get{return _tkunset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset8
		{
			set{ _tkunset8=value;}
			get{return _tkunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset9
		{
			set{ _tkunset9=value;}
			get{return _tkunset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset10
		{
			set{ _tkunset10=value;}
			get{return _tkunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset11
		{
			set{ _tkunset11=value;}
			get{return _tkunset11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset12
		{
			set{ _tkunset12=value;}
			get{return _tkunset12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset13
		{
			set{ _tkunset13=value;}
			get{return _tkunset13;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset14
		{
			set{ _tkunset14=value;}
			get{return _tkunset14;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset15
		{
			set{ _tkunset15=value;}
			get{return _tkunset15;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset16
		{
			set{ _tkunset16=value;}
			get{return _tkunset16;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tkunset17
		{
			set{ _tkunset17=value;}
			get{return _tkunset17;}
		}
		#endregion Model

	}
}

