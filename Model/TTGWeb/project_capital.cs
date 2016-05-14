using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// project_capital:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class project_capital
	{
		public project_capital()
		{}
		#region Model
		private string _project_id;
		private string _project_name;
		private string _furnished_type;
		private decimal? _total_investment;
		private decimal? _ttg_follow_up_work_approved_special_subsidies;
		private decimal? _plan_counterparts_support_funds;
		private decimal? _other_matching_funds;
		private decimal? _other_funds;
		private DateTime _time;
		private string _tciunset1;
		private string _tciunset2;
		private string _tciunset3;
		private string _tciunset4;
		private string _tciunset5;
		private string _tciunset6;
		private string _tciunset7;
		private string _tciunset8;
		private int _check_status=0;
		private int _lock_tables=0;
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
		public string project_name
		{
			set{ _project_name=value;}
			get{return _project_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string furnished_type
		{
			set{ _furnished_type=value;}
			get{return _furnished_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? total_investment
		{
			set{ _total_investment=value;}
			get{return _total_investment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TTG_follow_up_work_approved_special_subsidies
		{
			set{ _ttg_follow_up_work_approved_special_subsidies=value;}
			get{return _ttg_follow_up_work_approved_special_subsidies;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? plan_counterparts_support_funds
		{
			set{ _plan_counterparts_support_funds=value;}
			get{return _plan_counterparts_support_funds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? other_matching_funds
		{
			set{ _other_matching_funds=value;}
			get{return _other_matching_funds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? other_funds
		{
			set{ _other_funds=value;}
			get{return _other_funds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset1
		{
			set{ _tciunset1=value;}
			get{return _tciunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset2
		{
			set{ _tciunset2=value;}
			get{return _tciunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset3
		{
			set{ _tciunset3=value;}
			get{return _tciunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset4
		{
			set{ _tciunset4=value;}
			get{return _tciunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset5
		{
			set{ _tciunset5=value;}
			get{return _tciunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset6
		{
			set{ _tciunset6=value;}
			get{return _tciunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset7
		{
			set{ _tciunset7=value;}
			get{return _tciunset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset8
		{
			set{ _tciunset8=value;}
			get{return _tciunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int check_status
		{
			set{ _check_status=value;}
			get{return _check_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int lock_tables
		{
			set{ _lock_tables=value;}
			get{return _lock_tables;}
		}
		#endregion Model

	}
}

