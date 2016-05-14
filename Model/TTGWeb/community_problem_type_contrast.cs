using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_problem_type_contrast:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_problem_type_contrast
	{
		public community_problem_type_contrast()
		{}
		#region Model
		private string _question_content;
		private string _table_belong_to;
		private string _unit;
		private string _problem_nature;
		private int _check_status=0;
		private string _tciunset1;
		private string _tciunset2;
		private string _tciunset3;
		private string _tciunset4;
		private int _lock_tables=0;
		/// <summary>
		/// 
		/// </summary>
		public string question_content
		{
			set{ _question_content=value;}
			get{return _question_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string table_belong_to
		{
			set{ _table_belong_to=value;}
			get{return _table_belong_to;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string problem_nature
		{
			set{ _problem_nature=value;}
			get{return _problem_nature;}
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
		public int lock_tables
		{
			set{ _lock_tables=value;}
			get{return _lock_tables;}
		}
		#endregion Model

	}
}

