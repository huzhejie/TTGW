﻿using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// project_investment_plan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class project_investment_plan
	{
		public project_investment_plan()
		{}
		#region Model
		private string _project_id;
		private string _project_name;
		private decimal? _investment_plan;
		private string _investment_year;
		private string _tciunset1;
		private string _tciunset2;
		private string _tciunset3;
		private string _tciunset4;
		private int _check_status=0;
		private int _lock_tables=0;
		/// <summary>
		/// 
		/// </summary>
		public string project_id
		{
			set{ _project_id=value;}
			get{return _project_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_name
		{
			set{ _project_name=value;}
			get{return _project_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? investment_plan
		{
			set{ _investment_plan=value;}
			get{return _investment_plan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string investment_year
		{
			set{ _investment_year=value;}
			get{return _investment_year;}
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
		#endregion Model

	}
}

