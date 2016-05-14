﻿using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_kindergarten_problem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_kindergarten_problem
	{
		public community_kindergarten_problem()
		{}
		#region Model
		private string _community_id;
		private string _community_fill_type;
		private int? _community_child_not_atts_due_to_insuf_capacity_num;
		private int? _community_large_class_num;
		private DateTime _statistics_date;
		private int _check_status=0;
		private int _lock_tables=0;
		private string _tciunset1;
		private string _tciunset2;
		private string _tciunset3;
		private string _tciunset4;
		private string _tciunset5;
		private string _tciunset6;
		private string _tciunset7;
		private string _tciunset8;
		private string _tciunset9;
		private string _community_lack_teaching_area;
		private string _community_lack_outdoor_playground;
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
		public int? community_child_not_atts_due_to_insuf_capacity_num
		{
			set{ _community_child_not_atts_due_to_insuf_capacity_num=value;}
			get{return _community_child_not_atts_due_to_insuf_capacity_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_large_class_num
		{
			set{ _community_large_class_num=value;}
			get{return _community_large_class_num;}
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
		public string community_lack_teaching_area
		{
			set{ _community_lack_teaching_area=value;}
			get{return _community_lack_teaching_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_lack_outdoor_playground
		{
			set{ _community_lack_outdoor_playground=value;}
			get{return _community_lack_outdoor_playground;}
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
