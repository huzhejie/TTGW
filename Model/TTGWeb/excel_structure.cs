using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// excel_structure:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class excel_structure
	{
		public excel_structure()
		{}
		#region Model
		private string _property;
		private string _excel_name;
		private int _row_column_num;
		private string _table_name;
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
		public string excel_name
		{
			set{ _excel_name=value;}
			get{return _excel_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int row_column_num
		{
			set{ _row_column_num=value;}
			get{return _row_column_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string table_name
		{
			set{ _table_name=value;}
			get{return _table_name;}
		}
		#endregion Model

	}
}

