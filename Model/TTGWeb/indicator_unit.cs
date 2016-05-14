using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// indicator_unit:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class indicator_unit
	{
		public indicator_unit()
		{}
		#region Model
		private string _indicator;
		private string _translation;
		private string _unit;
		/// <summary>
		/// 
		/// </summary>
		public string indicator
		{
			set{ _indicator=value;}
			get{return _indicator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string translation
		{
			set{ _translation=value;}
			get{return _translation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		#endregion Model

	}
}

