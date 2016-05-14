using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// follow_up_investment_plan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class follow_up_investment_plan
	{
		public follow_up_investment_plan()
		{}
		#region Model
		private string _project_id;
		private int _year;
		private decimal _plan_investment;
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
		public decimal plan_investment
		{
			set{ _plan_investment=value;}
			get{return _plan_investment;}
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

