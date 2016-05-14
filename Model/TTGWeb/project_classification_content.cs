﻿using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// project_classification_content:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class project_classification_content
	{
		public project_classification_content()
		{}
		#region Model
		private string _project_content;
		private string _project_unit;
		private string _subclass;
		private string _superclass;
		private string _tciunset1;
		private string _tciunset2;
		private string _tciunset3;
		private string _tciunset4;
		private int _check_status=0;
		private int _lock_tables=0;
		/// <summary>
		/// 
		/// </summary>
		public string project_content
		{
			set{ _project_content=value;}
			get{return _project_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_unit
		{
			set{ _project_unit=value;}
			get{return _project_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string subclass
		{
			set{ _subclass=value;}
			get{return _subclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string superclass
		{
			set{ _superclass=value;}
			get{return _superclass;}
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
