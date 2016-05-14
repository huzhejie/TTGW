using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_project_associate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_project_associate
	{
		public community_project_associate()
		{}
		#region Model
		private string _project_id;
		private string _project_name;
		private string _community_name;
		private string _community_id;
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
		public string community_name
		{
			set{ _community_name=value;}
			get{return _community_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_id
		{
			set{ _community_id=value;}
			get{return _community_id;}
		}
		#endregion Model

	}
}

