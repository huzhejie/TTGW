using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// figure_progress:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class figure_progress
	{
		public figure_progress()
		{}
		#region Model
		private string _project_id;
		private int _year;
		private decimal? _march_progress;
		private decimal? _june_progress;
		private decimal? _september_progress;
		private decimal? _december_progress;
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
		public decimal? march_progress
		{
			set{ _march_progress=value;}
			get{return _march_progress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? june_progress
		{
			set{ _june_progress=value;}
			get{return _june_progress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? september_progress
		{
			set{ _september_progress=value;}
			get{return _september_progress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? december_progress
		{
			set{ _december_progress=value;}
			get{return _december_progress;}
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

