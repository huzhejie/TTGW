using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// download:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class download
	{
		public download()
		{}
		#region Model
		private string _name;
		private string _address;
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		#endregion Model

	}
}

