using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// effiect_translate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class effiect_translate
	{
		public effiect_translate()
		{}
		#region Model
		private string _chinese;
		private string _english;
		private int _elevel;
		/// <summary>
		/// 
		/// </summary>
		public string chinese
		{
			set{ _chinese=value;}
			get{return _chinese;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string english
		{
			set{ _english=value;}
			get{return _english;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int elevel
		{
			set{ _elevel=value;}
			get{return _elevel;}
		}
		#endregion Model

	}
}

