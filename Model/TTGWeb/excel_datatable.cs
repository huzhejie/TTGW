using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// excel_datatable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class excel_datatable
	{
		public excel_datatable()
		{}
		#region Model
		private string _excel_name;
		private string _table_name;
		private int _table_start_column;
		private int _table_start_row;
		private int _table_end_column;
		private int _table_end_row;
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
		public int table_start_column
		{
			set{ _table_start_column=value;}
			get{return _table_start_column;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int table_start_row
		{
			set{ _table_start_row=value;}
			get{return _table_start_row;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int table_end_column
		{
			set{ _table_end_column=value;}
			get{return _table_end_column;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int table_end_row
		{
			set{ _table_end_row=value;}
			get{return _table_end_row;}
		}
		#endregion Model

	}
}

