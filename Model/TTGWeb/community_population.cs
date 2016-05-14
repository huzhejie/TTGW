using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_population:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_population
	{
		public community_population()
		{}
		#region Model
		private string _community_id;
		private int? _community_total_pop;
		private int? _community_reg_pop;
		private int? _community_perm_pop;
		private int? _community_man_pop;
		private int? _community_female_pop;
		private int? _community_younger_6_pop;
		private int? _community_bet_7_and_15_pop;
		private int? _community_bet_16_and_29_pop;
		private int? _community_bet_30_and_39_pop;
		private int? _community_bet_40_and_49_pop;
		private int? _community_older_50_pop;
		private int? _community_illiteracy_pop;
		private int? _community_prim_school_edu_pop;
		private int? _community_junior_high_school_edu_pop;
		private int? _community_senior_high_school_edu_pop;
		private int? _community_junior_college_edu_pop;
		private decimal? _average_education_time;
		private DateTime _statistics_date;
		private string _tcpunset1;
		private string _tcpunset2;
		private string _tcpunset3;
		private string _tcpunset4;
		private string _tcpunset5;
		private string _tcpunset6;
		private string _tcpunset7;
		private string _tcpunset8;
		private string _tcpunset10;
		private string _tcpunset11;
		private string _tcpunset12;
		private string _tcpunset13;
		private string _tcpunset14;
		private string _tcpunset15;
		private string _tcpunset16;
		private string _tcpunset17;
		private int _check_status=0;
		private int _lock_tables=0;
		private decimal? _community_family_num;
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
		public int? community_total_pop
		{
			set{ _community_total_pop=value;}
			get{return _community_total_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_reg_pop
		{
			set{ _community_reg_pop=value;}
			get{return _community_reg_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_perm_pop
		{
			set{ _community_perm_pop=value;}
			get{return _community_perm_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_man_pop
		{
			set{ _community_man_pop=value;}
			get{return _community_man_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_female_pop
		{
			set{ _community_female_pop=value;}
			get{return _community_female_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_younger_6_pop
		{
			set{ _community_younger_6_pop=value;}
			get{return _community_younger_6_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_bet_7_and_15_pop
		{
			set{ _community_bet_7_and_15_pop=value;}
			get{return _community_bet_7_and_15_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_bet_16_and_29_pop
		{
			set{ _community_bet_16_and_29_pop=value;}
			get{return _community_bet_16_and_29_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_bet_30_and_39_pop
		{
			set{ _community_bet_30_and_39_pop=value;}
			get{return _community_bet_30_and_39_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_bet_40_and_49_pop
		{
			set{ _community_bet_40_and_49_pop=value;}
			get{return _community_bet_40_and_49_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_older_50_pop
		{
			set{ _community_older_50_pop=value;}
			get{return _community_older_50_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_illiteracy_pop
		{
			set{ _community_illiteracy_pop=value;}
			get{return _community_illiteracy_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_prim_school_edu_pop
		{
			set{ _community_prim_school_edu_pop=value;}
			get{return _community_prim_school_edu_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_junior_high_school_edu_pop
		{
			set{ _community_junior_high_school_edu_pop=value;}
			get{return _community_junior_high_school_edu_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_senior_high_school_edu_pop
		{
			set{ _community_senior_high_school_edu_pop=value;}
			get{return _community_senior_high_school_edu_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_junior_college_edu_pop
		{
			set{ _community_junior_college_edu_pop=value;}
			get{return _community_junior_college_edu_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? average_education_time
		{
			set{ _average_education_time=value;}
			get{return _average_education_time;}
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
		public string tcpunset1
		{
			set{ _tcpunset1=value;}
			get{return _tcpunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcpunset2
		{
			set{ _tcpunset2=value;}
			get{return _tcpunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcpunset3
		{
			set{ _tcpunset3=value;}
			get{return _tcpunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcpunset4
		{
			set{ _tcpunset4=value;}
			get{return _tcpunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcpunset5
		{
			set{ _tcpunset5=value;}
			get{return _tcpunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcpunset6
		{
			set{ _tcpunset6=value;}
			get{return _tcpunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcpunset7
		{
			set{ _tcpunset7=value;}
			get{return _tcpunset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcpunset8
		{
			set{ _tcpunset8=value;}
			get{return _tcpunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcpunset10
		{
			set{ _tcpunset10=value;}
			get{return _tcpunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcpunset11
		{
			set{ _tcpunset11=value;}
			get{return _tcpunset11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcpunset12
		{
			set{ _tcpunset12=value;}
			get{return _tcpunset12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcpunset13
		{
			set{ _tcpunset13=value;}
			get{return _tcpunset13;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcpunset14
		{
			set{ _tcpunset14=value;}
			get{return _tcpunset14;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcpunset15
		{
			set{ _tcpunset15=value;}
			get{return _tcpunset15;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcpunset16
		{
			set{ _tcpunset16=value;}
			get{return _tcpunset16;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcpunset17
		{
			set{ _tcpunset17=value;}
			get{return _tcpunset17;}
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
		public decimal? community_family_num
		{
			set{ _community_family_num=value;}
			get{return _community_family_num;}
		}
		#endregion Model

	}
}

