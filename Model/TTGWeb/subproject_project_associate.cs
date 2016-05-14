using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// subproject_project_associate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class subproject_project_associate
	{
		public subproject_project_associate()
		{}
		#region Model
		private string _project_id;
		private string _project_name;
		private string _subproject_name;
		private string _subproject_id;
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
		public string subproject_name
		{
			set{ _subproject_name=value;}
			get{return _subproject_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string subproject_id
		{
			set{ _subproject_id=value;}
			get{return _subproject_id;}
		}
		#endregion Model

	}
}

