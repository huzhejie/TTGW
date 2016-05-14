using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// project_community:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class project_community
	{
		public project_community()
		{}
		#region Model
		private string _project_id;
		private string _county_name;
		private string _community_name;
		private DateTime _fill_time;
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
		public string county_name
		{
			set{ _county_name=value;}
			get{return _county_name;}
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
		public DateTime fill_time
		{
			set{ _fill_time=value;}
			get{return _fill_time;}
		}
		#endregion Model

	}
}

