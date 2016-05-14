using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// excel_message:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class excel_message
	{
		public excel_message()
		{}
		#region Model
		private string _table_name;
		private string _table_path;
		private int _table_id;
		/// <summary>
		/// 
		/// </summary>
		public string table_name
		{
			set{ _table_name=value;}
			get{return _table_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string table_path
		{
			set{ _table_path=value;}
			get{return _table_path;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int table_id
		{
			set{ _table_id=value;}
			get{return _table_id;}
		}
		#endregion Model

	}
}

