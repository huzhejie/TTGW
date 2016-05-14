using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// excel_special_structure:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class excel_special_structure
	{
		public excel_special_structure()
		{}
		#region Model
		private string _chinese_name;
		private string _property;
		private string _table_name;
		private string _excel_name;
		/// <summary>
		/// 
		/// </summary>
		public string chinese_name
		{
			set{ _chinese_name=value;}
			get{return _chinese_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string property
		{
			set{ _property=value;}
			get{return _property;}
		}
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
		public string excel_name
		{
			set{ _excel_name=value;}
			get{return _excel_name;}
		}
		#endregion Model

	}
}

