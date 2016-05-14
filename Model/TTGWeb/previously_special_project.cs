using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// previously_special_project:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class previously_special_project
	{
		public previously_special_project()
		{}
		#region Model
		private int _id;
		private string _project_id;
		private string _county_name;
		private string _after_id;
		private string _project_name;
		private string _project_type;
		private int? _year_time;
		private decimal? _total_investment;
		private decimal? _follow_up_special_founds;
		private decimal? _plan_support_founds;
		private decimal? _other_matching_founds;
		private string _project_owner;
		private string _bidding_time;
		private int? _contract_period;
		private string _start_date;
		private string _finish_date;
		private string _project_lag_reason;
		private string _have_quality_safety_incident;
		private string _incidents_process_situation;
		private DateTime? _finish_accept_date;
		private string _finish_accept_quality_level;
		private string _is_transfer;
        private string _radial_project;

        public string radial_project
        {
            get { return _radial_project; }
            set { _radial_project = value; }
        }
		private string _remark;
		private int _lock_table=0;
		private int _check_status=0;
		private string _unset1;
		private string _unset2;
		private string _unset3;
		private string _unset4;
		private string _unset5;
		private string _unset6;
		private string _unset7;
		private string _unset8;
		private string _unset9;
		private string _unset10;
        private string _unset11;
		private DateTime _fill_time;
        private string _main_construct_properties;
        private string _project_community_description;

        public string project_community_description
        {
            get { return _project_community_description; }
            set { _project_community_description = value; }
        }
        public string main_construct_properties
        {
            get { return _main_construct_properties; }
            set { _main_construct_properties = value; }
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
		public string after_id
		{
			set{ _after_id=value;}
			get{return _after_id;}
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
		public string project_type
		{
			set{ _project_type=value;}
			get{return _project_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? year_time
		{
			set{ _year_time=value;}
			get{return _year_time;}
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
		public decimal? follow_up_special_founds
		{
			set{ _follow_up_special_founds=value;}
			get{return _follow_up_special_founds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? plan_support_founds
		{
			set{ _plan_support_founds=value;}
			get{return _plan_support_founds;}
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
		public string project_owner
		{
			set{ _project_owner=value;}
			get{return _project_owner;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bidding_time
		{
			set{ _bidding_time=value;}
			get{return _bidding_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? contract_period
		{
			set{ _contract_period=value;}
			get{return _contract_period;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string start_date
		{
			set{ _start_date=value;}
			get{return _start_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string finish_date
		{
			set{ _finish_date=value;}
			get{return _finish_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_lag_reason
		{
			set{ _project_lag_reason=value;}
			get{return _project_lag_reason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string have_quality_safety_incident
		{
			set{ _have_quality_safety_incident=value;}
			get{return _have_quality_safety_incident;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string incidents_process_situation
		{
			set{ _incidents_process_situation=value;}
			get{return _incidents_process_situation;}
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
		public string finish_accept_quality_level
		{
			set{ _finish_accept_quality_level=value;}
			get{return _finish_accept_quality_level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string is_transfer
		{
			set{ _is_transfer=value;}
			get{return _is_transfer;}
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
		public string unset1
		{
			set{ _unset1=value;}
			get{return _unset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset2
		{
			set{ _unset2=value;}
			get{return _unset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset3
		{
			set{ _unset3=value;}
			get{return _unset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset4
		{
			set{ _unset4=value;}
			get{return _unset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset5
		{
			set{ _unset5=value;}
			get{return _unset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset6
		{
			set{ _unset6=value;}
			get{return _unset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset7
		{
			set{ _unset7=value;}
			get{return _unset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset8
		{
			set{ _unset8=value;}
			get{return _unset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset9
		{
			set{ _unset9=value;}
			get{return _unset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset10
		{
			set{ _unset10=value;}
			get{return _unset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unset11
		{
			set{ _unset11=value;}
			get{return _unset11;}
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

