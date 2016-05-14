using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_project:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_project
	{
		public community_project()
        { }
		#region Model
		private string _county_name;
		private string _project_id;
		private string _project_name;
		private string _project_category;
		private DateTime? _project_add_time;
		private decimal? _project_total_investment;
		private string _project_proprietor;
		private string _plan_to_bulid;
		private DateTime? _biding_finish_time;
		private string _contract_period;
		private DateTime? _project_start_time;
		private string _not_started_reason_analysis;
		private DateTime? _complete_time;
		private string _project_delay_reason_analysis;
		private string _if_major_quality_or_security_accident_happened;
		private DateTime? _project_complete_acceptance_time;
		private string _complete_acceptance_quality_level;
		private string _if_transfer;
		private string _project_community_correlation_description;
		private string _note_information;
		private string _project_type;
		private DateTime _statistics_date;
		private string _major_quality_or_security_accident;
		private string _tciunset1;
		private string _tciunset2;
		private string _tciunset3;
		private string _tciunset4;
		private string _tciunset5;
		private string _tciunset6;
		private string _tciunset7;
		private string _tciunset8;
		private string _tciunset9;
		private string _tciunset10;
		private string _tciunset11;
		private string _tciunset12;
		private string _tciunset13;
		private string _tciunset14;
		private string _tciunset15;
		private string _tciunset16;
		private string _tciunset17;
		private string _tciunset18;
		private string _tciunset19;
		private string _tciunset20;
		private string _tciunset21;
		private int _check_status=0;
		private int _lock_tables=0;
		private string _after_id;
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
		public string project_category
		{
			set{ _project_category=value;}
			get{return _project_category;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? project_add_time
		{
			set{ _project_add_time=value;}
			get{return _project_add_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? project_total_investment
		{
			set{ _project_total_investment=value;}
			get{return _project_total_investment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_proprietor
		{
			set{ _project_proprietor=value;}
			get{return _project_proprietor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string plan_to_bulid
		{
			set{ _plan_to_bulid=value;}
			get{return _plan_to_bulid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? biding_finish_time
		{
			set{ _biding_finish_time=value;}
			get{return _biding_finish_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string contract_period
		{
			set{ _contract_period=value;}
			get{return _contract_period;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? project_start_time
		{
			set{ _project_start_time=value;}
			get{return _project_start_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string not_started_reason_analysis
		{
			set{ _not_started_reason_analysis=value;}
			get{return _not_started_reason_analysis;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? complete_time
		{
			set{ _complete_time=value;}
			get{return _complete_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_delay_reason_analysis
		{
			set{ _project_delay_reason_analysis=value;}
			get{return _project_delay_reason_analysis;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string if_major_quality_or_security_accident_happened
		{
			set{ _if_major_quality_or_security_accident_happened=value;}
			get{return _if_major_quality_or_security_accident_happened;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? project_complete_acceptance_time
		{
			set{ _project_complete_acceptance_time=value;}
			get{return _project_complete_acceptance_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string complete_acceptance_quality_level
		{
			set{ _complete_acceptance_quality_level=value;}
			get{return _complete_acceptance_quality_level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string if_transfer
		{
			set{ _if_transfer=value;}
			get{return _if_transfer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_community_correlation_description
		{
			set{ _project_community_correlation_description=value;}
			get{return _project_community_correlation_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string note_information
		{
			set{ _note_information=value;}
			get{return _note_information;}
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
		public DateTime statistics_date
		{
			set{ _statistics_date=value;}
			get{return _statistics_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string major_quality_or_security_accident
		{
			set{ _major_quality_or_security_accident=value;}
			get{return _major_quality_or_security_accident;}
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
		public string tciunset9
		{
			set{ _tciunset9=value;}
			get{return _tciunset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset10
		{
			set{ _tciunset10=value;}
			get{return _tciunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset11
		{
			set{ _tciunset11=value;}
			get{return _tciunset11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset12
		{
			set{ _tciunset12=value;}
			get{return _tciunset12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset13
		{
			set{ _tciunset13=value;}
			get{return _tciunset13;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset14
		{
			set{ _tciunset14=value;}
			get{return _tciunset14;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset15
		{
			set{ _tciunset15=value;}
			get{return _tciunset15;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset16
		{
			set{ _tciunset16=value;}
			get{return _tciunset16;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset17
		{
			set{ _tciunset17=value;}
			get{return _tciunset17;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset18
		{
			set{ _tciunset18=value;}
			get{return _tciunset18;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset19
		{
			set{ _tciunset19=value;}
			get{return _tciunset19;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset20
		{
			set{ _tciunset20=value;}
			get{return _tciunset20;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset21
		{
			set{ _tciunset21=value;}
			get{return _tciunset21;}
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
		/// <summary>
		/// 
		/// </summary>
		public string after_id
		{
			set{ _after_id=value;}
			get{return _after_id;}
		}
		#endregion Model

	}
}

