using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// service_radius:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class service_radius
	{
		public service_radius()
		{}
		#region Model
		private string _facilities_type;
		private string _facilities_level;
		private decimal? _service_radius_value;
		/// <summary>
		/// 
		/// </summary>
		public string facilities_type
		{
			set{ _facilities_type=value;}
			get{return _facilities_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string facilities_level
		{
			set{ _facilities_level=value;}
			get{return _facilities_level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? service_radius_value
		{
			set{ _service_radius_value=value;}
			get{return _service_radius_value;}
		}
		#endregion Model

	}
}

