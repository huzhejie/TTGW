using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// construction_phase:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class construction_phase
	{
		public construction_phase()
		{}
		#region Model
		private string _project_id;
		private int _year;
		private string _march_phase;
		private string _june_phase;
		private string _september_phase;
		private string _december_phase;
		private DateTime _fill_time;
		/// <summary>
		/// 
		/// </summary>
		public string project_id
		{
			set{ _project_id=value;}
			get{return _project_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int year
		{
			set{ _year=value;}
			get{return _year;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string march_phase
		{
			set{ _march_phase=value;}
			get{return _march_phase;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string june_phase
		{
			set{ _june_phase=value;}
			get{return _june_phase;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string september_phase
		{
			set{ _september_phase=value;}
			get{return _september_phase;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string december_phase
		{
			set{ _december_phase=value;}
			get{return _december_phase;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime fill_time
		{
			set{ _fill_time=value;}
			get{return _fill_time;}
		}
		#endregion Model

	}
}

