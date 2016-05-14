using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// excel_span_structure:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class excel_span_structure
	{
		public excel_span_structure()
		{}
		#region Model
		private string _property;
		private string _excel_name;
		private string _table_name;
		private int _row_num;
		private int _column_num;
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
		public string table_name
		{
			set{ _table_name=value;}
			get{return _table_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int row_num
		{
			set{ _row_num=value;}
			get{return _row_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int column_num
		{
			set{ _column_num=value;}
			get{return _column_num;}
		}
		#endregion Model

	}
}

