using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// sample:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sample
	{
		public sample()
		{}
		#region Model
		private string _community_id;
		private int? _sample_house_num;
		private int? _sample_family_pop;
		private int? _sample_labor_force_pop;
		private int? _sample_employment_lf_pop;
		private int? _sample_primary_industry_lf_pop;
		private int? _sample_secondary_industry_lf_pop;
		private int? _sample_tertiary_industry_lf_pop;
		private decimal? _sample_pcdi;
		private decimal? _sample_wages_income;
		private decimal? _sample_family_run_pure_income;
		private decimal? _sample_property_income;
		private decimal? _sample_transfer_income;
		private decimal? _sample_consp;
		private string _tsunset1;
		private string _tsunset2;
		private string _tsunset3;
		private string _tsunset4;
		private string _tsunset5;
		private string _tsunset6;
		private string _tsunset7;
		private string _tsunset8;
		private string _tsunset9;
		private string _tsunset10;
		private string _tsunset11;
		private string _tsunset12;
		private int _lock_tables=0;
		private int _check_status=0;
		private DateTime _statistics_date;
		/// <summary>
		/// 
		/// </summary>
		public string community_id
		{
			set{ _community_id=value;}
			get{return _community_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sample_house_num
		{
			set{ _sample_house_num=value;}
			get{return _sample_house_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sample_family_pop
		{
			set{ _sample_family_pop=value;}
			get{return _sample_family_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sample_labor_force_pop
		{
			set{ _sample_labor_force_pop=value;}
			get{return _sample_labor_force_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sample_employment_lf_pop
		{
			set{ _sample_employment_lf_pop=value;}
			get{return _sample_employment_lf_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sample_primary_industry_lf_pop
		{
			set{ _sample_primary_industry_lf_pop=value;}
			get{return _sample_primary_industry_lf_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sample_secondary_industry_lf_pop
		{
			set{ _sample_secondary_industry_lf_pop=value;}
			get{return _sample_secondary_industry_lf_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sample_tertiary_industry_lf_pop
		{
			set{ _sample_tertiary_industry_lf_pop=value;}
			get{return _sample_tertiary_industry_lf_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? sample_PCDI
		{
			set{ _sample_pcdi=value;}
			get{return _sample_pcdi;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? sample_wages_income
		{
			set{ _sample_wages_income=value;}
			get{return _sample_wages_income;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? sample_family_run_pure_income
		{
			set{ _sample_family_run_pure_income=value;}
			get{return _sample_family_run_pure_income;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? sample_property_income
		{
			set{ _sample_property_income=value;}
			get{return _sample_property_income;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? sample_transfer_income
		{
			set{ _sample_transfer_income=value;}
			get{return _sample_transfer_income;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? sample_CONSP
		{
			set{ _sample_consp=value;}
			get{return _sample_consp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tsunset1
		{
			set{ _tsunset1=value;}
			get{return _tsunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tsunset2
		{
			set{ _tsunset2=value;}
			get{return _tsunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tsunset3
		{
			set{ _tsunset3=value;}
			get{return _tsunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tsunset4
		{
			set{ _tsunset4=value;}
			get{return _tsunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tsunset5
		{
			set{ _tsunset5=value;}
			get{return _tsunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tsunset6
		{
			set{ _tsunset6=value;}
			get{return _tsunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tsunset7
		{
			set{ _tsunset7=value;}
			get{return _tsunset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tsunset8
		{
			set{ _tsunset8=value;}
			get{return _tsunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tsunset9
		{
			set{ _tsunset9=value;}
			get{return _tsunset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tsunset10
		{
			set{ _tsunset10=value;}
			get{return _tsunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tsunset11
		{
			set{ _tsunset11=value;}
			get{return _tsunset11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tsunset12
		{
			set{ _tsunset12=value;}
			get{return _tsunset12;}
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
		public int check_status
		{
			set{ _check_status=value;}
			get{return _check_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime statistics_date
		{
			set{ _statistics_date=value;}
			get{return _statistics_date;}
		}
		#endregion Model

	}
}

