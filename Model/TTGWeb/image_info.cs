using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// image_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class image_info
	{
		public image_info()
		{}
		#region Model
		private int _image_id;
		private string _image_name;
		private string _image_address;
		private string _community_id;
		private string _image_type;
		private DateTime _statistics_date;
		private int? _nf_id;
		/// <summary>
		/// 
		/// </summary>
		public int image_id
		{
			set{ _image_id=value;}
			get{return _image_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string image_name
		{
			set{ _image_name=value;}
			get{return _image_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string image_address
		{
			set{ _image_address=value;}
			get{return _image_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community_id
		{
			set{ _community_id=value;}
			get{return _community_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string image_type
		{
			set{ _image_type=value;}
			get{return _image_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime statistics_date
		{
			set{ _statistics_date=value;}
			get{return _statistics_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? nf_id
		{
			set{ _nf_id=value;}
			get{return _nf_id;}
		}
		#endregion Model

	}
}

