using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// counterpart_and_other_project:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class counterpart_and_other_project
	{
		public counterpart_and_other_project()
		{}
		#region Model
		private int _id;
		private string _project_id;
		private string _county_name;
		private string _project_name;
		private string _is_counterpart_project;
		private int _year;
		private string _project_type;
		private decimal? _total_investment;
		private decimal? _counterpart_founds;
		private decimal? _other_matching_founds;
		private DateTime? _start_date;
		private DateTime? _finish_date;
		
		private DateTime? _finish_accept_date;
	
		private string _remark;
		private int _lock_table=0;
		private int _check_status=0;
		private DateTime _fill_time;
        private string _radial_project;

        public string radial_project
        {
            get { return _radial_project; }
            set { _radial_project = value; }
        }
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
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
		public string county_name
		{
			set{ _county_name=value;}
			get{return _county_name;}
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
		public string is_counterpart_project
		{
			set{ _is_counterpart_project=value;}
			get{return _is_counterpart_project;}
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
		public string project_type
		{
			set{ _project_type=value;}
			get{return _project_type;}
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
		public decimal? counterpart_founds
		{
			set{ _counterpart_founds=value;}
			get{return _counterpart_founds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? other_matching_founds
		{
			set{ _other_matching_founds=value;}
			get{return _other_matching_founds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? start_date
		{
			set{ _start_date=value;}
			get{return _start_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? finish_date
		{
			set{ _finish_date=value;}
			get{return _finish_date;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime? finish_accept_date
		{
			set{ _finish_accept_date=value;}
			get{return _finish_accept_date;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int lock_table
		{
			set{ _lock_table=value;}
			get{return _lock_table;}
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
		public DateTime fill_time
		{
			set{ _fill_time=value;}
			get{return _fill_time;}
		}
		#endregion Model

	}
}

