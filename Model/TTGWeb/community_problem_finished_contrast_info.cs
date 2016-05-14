using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_problem_finished_contrast_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_problem_finished_contrast_info
	{
		public community_problem_finished_contrast_info()
		{}
		#region Model
		private string _community_problem_content;
		private string _community_problem_unit;
		private string _community_finish_content;
		private string _community_finish_content_unit;
		private int _check_status=0;
		private string _tciunset1;
		private string _tciunset2;
		private string _tciunset3;
		private string _tciunset4;
		private int _lock_tables=0;
		private string _project_name;
		/// <summary>
		/// 
		/// </summary>
		public string community_problem_content
		{
			set{ _community_problem_content=value;}
			get{return _community_problem_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_problem_unit
		{
			set{ _community_problem_unit=value;}
			get{return _community_problem_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_finish_content
		{
			set{ _community_finish_content=value;}
			get{return _community_finish_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_finish_content_unit
		{
			set{ _community_finish_content_unit=value;}
			get{return _community_finish_content_unit;}
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
		/// <summary>
		/// 
		/// </summary>
		public string project_name
		{
			set{ _project_name=value;}
			get{return _project_name;}
		}
		#endregion Model

	}
}

