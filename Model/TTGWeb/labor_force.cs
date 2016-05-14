using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// labor_force:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class labor_force
	{
		public labor_force()
		{}
		#region Model
		private string _id;
		private string _county;
		private string _community;
		private int? _lf_have_a_job_pop;
		private int? _lf_have_a_steady_job_pop;
		private int? _empm_information_platform_num;
		private int? _empm_information_platform_information_num;
		private int? _public_spirited_job_pop;
		private int? _clean_keeping_pop;
		private int? _security_guard_pop;
		private int? _farm_produce_fair_administrator_pop;
		private int? _other_job_pop;
		private int? _enp_supportive_num;
		private int? _small_manual_processing_enp_num;
		private int? _food_enp_num;
		private int? _sewing_embroidery_enp_num;
		private int? _other_enp_supportive_num;
		private string _note_information;
		private DateTime _statistics_date;
		private string _tlfunset1;
		private string _tlfunset2;
		private string _tlfunset3;
		private string _tlfunset4;
		private string _tlfunset5;
		private string _tlfunset6;
		private string _tlfunset7;
		private string _tlfunset8;
		private string _tlfunset9;
		private string _tlfunset10;
		private string _tlfunset11;
		private string _tlfunset12;
		private string _tlfunset13;
		private string _tlfunset14;
		private string _tlfunset15;
		private string _tlfunset16;
		private string _tlfunset17;
		private int _check_status=0;
		private int _lock_tables=0;
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string county
		{
			set{ _county=value;}
			get{return _county;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community
		{
			set{ _community=value;}
			get{return _community;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? lf_have_a_job_pop
		{
			set{ _lf_have_a_job_pop=value;}
			get{return _lf_have_a_job_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? lf_have_a_steady_job_pop
		{
			set{ _lf_have_a_steady_job_pop=value;}
			get{return _lf_have_a_steady_job_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? empm_information_platform_num
		{
			set{ _empm_information_platform_num=value;}
			get{return _empm_information_platform_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? empm_information_platform_information_num
		{
			set{ _empm_information_platform_information_num=value;}
			get{return _empm_information_platform_information_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? public_spirited_job_pop
		{
			set{ _public_spirited_job_pop=value;}
			get{return _public_spirited_job_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? clean_keeping_pop
		{
			set{ _clean_keeping_pop=value;}
			get{return _clean_keeping_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? security_guard_pop
		{
			set{ _security_guard_pop=value;}
			get{return _security_guard_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? farm_produce_fair_administrator_pop
		{
			set{ _farm_produce_fair_administrator_pop=value;}
			get{return _farm_produce_fair_administrator_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? other_job_pop
		{
			set{ _other_job_pop=value;}
			get{return _other_job_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? enp_supportive_num
		{
			set{ _enp_supportive_num=value;}
			get{return _enp_supportive_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? small_manual_processing_enp_num
		{
			set{ _small_manual_processing_enp_num=value;}
			get{return _small_manual_processing_enp_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? food_enp_num
		{
			set{ _food_enp_num=value;}
			get{return _food_enp_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sewing_embroidery_enp_num
		{
			set{ _sewing_embroidery_enp_num=value;}
			get{return _sewing_embroidery_enp_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? other_enp_supportive_num
		{
			set{ _other_enp_supportive_num=value;}
			get{return _other_enp_supportive_num;}
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
		public DateTime statistics_date
		{
			set{ _statistics_date=value;}
			get{return _statistics_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset1
		{
			set{ _tlfunset1=value;}
			get{return _tlfunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset2
		{
			set{ _tlfunset2=value;}
			get{return _tlfunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset3
		{
			set{ _tlfunset3=value;}
			get{return _tlfunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset4
		{
			set{ _tlfunset4=value;}
			get{return _tlfunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset5
		{
			set{ _tlfunset5=value;}
			get{return _tlfunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset6
		{
			set{ _tlfunset6=value;}
			get{return _tlfunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset7
		{
			set{ _tlfunset7=value;}
			get{return _tlfunset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset8
		{
			set{ _tlfunset8=value;}
			get{return _tlfunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset9
		{
			set{ _tlfunset9=value;}
			get{return _tlfunset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset10
		{
			set{ _tlfunset10=value;}
			get{return _tlfunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset11
		{
			set{ _tlfunset11=value;}
			get{return _tlfunset11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset12
		{
			set{ _tlfunset12=value;}
			get{return _tlfunset12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset13
		{
			set{ _tlfunset13=value;}
			get{return _tlfunset13;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset14
		{
			set{ _tlfunset14=value;}
			get{return _tlfunset14;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset15
		{
			set{ _tlfunset15=value;}
			get{return _tlfunset15;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset16
		{
			set{ _tlfunset16=value;}
			get{return _tlfunset16;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tlfunset17
		{
			set{ _tlfunset17=value;}
			get{return _tlfunset17;}
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

