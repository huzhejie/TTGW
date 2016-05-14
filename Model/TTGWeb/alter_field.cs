using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// alter_field:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class alter_field
	{
		public alter_field()
		{}
		#region Model
		private string _field_name;
		private string _table_name;
		private string _alter_field_name;
		private string _alter_field_unit;
		private string _alter_type;
		/// <summary>
		/// 
		/// </summary>
		public string field_name
		{
			set{ _field_name=value;}
			get{return _field_name;}
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
		public string alter_field_name
		{
			set{ _alter_field_name=value;}
			get{return _alter_field_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string alter_field_unit
		{
			set{ _alter_field_unit=value;}
			get{return _alter_field_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string alter_type
		{
			set{ _alter_type=value;}
			get{return _alter_type;}
		}
		#endregion Model

	}
}

