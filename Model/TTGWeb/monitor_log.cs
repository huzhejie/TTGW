using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// monitor_log:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class monitor_log
	{
		public monitor_log()
		{}
		#region Model
		private int _id;
		private string _investigator_id;
		private string _file_name;
		private DateTime? _fill_time;
		private string _file_path;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string investigator_id
		{
			set{ _investigator_id=value;}
			get{return _investigator_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_name
		{
			set{ _file_name=value;}
			get{return _file_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? fill_time
		{
			set{ _fill_time=value;}
			get{return _fill_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_path
		{
			set{ _file_path=value;}
			get{return _file_path;}
		}
		#endregion Model

	}
}

