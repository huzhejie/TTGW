using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_immigrant:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_immigrant
	{
		public community_immigrant()
		{}
		#region Model
		private string _community_id;
		private int? _immigrant_total_family_num;
		private int? _immigrant_total_population;
		private int? _community_pure_resident_pop;
		private int? _community_depart_pop;
		private int? _community_enp_staves;
		private int? _community_enp_laidoff_staves;
		private int? _community_have_land_pop;
		private int? _community_rural_to_town_pop;
		private DateTime _statistics_date;
		private string _tcimunset1;
		private string _tcimunset2;
		private string _tcimunset3;
		private string _tcimunset4;
		private string _tcimunset5;
		private string _tcimunset6;
		private string _tcimunset7;
		private int _check_status=0;
		private int _lock_tables=0;
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
		public int? immigrant_total_family_num
		{
			set{ _immigrant_total_family_num=value;}
			get{return _immigrant_total_family_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? immigrant_total_population
		{
			set{ _immigrant_total_population=value;}
			get{return _immigrant_total_population;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_pure_resident_pop
		{
			set{ _community_pure_resident_pop=value;}
			get{return _community_pure_resident_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_depart_pop
		{
			set{ _community_depart_pop=value;}
			get{return _community_depart_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_enp_staves
		{
			set{ _community_enp_staves=value;}
			get{return _community_enp_staves;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_enp_laidoff_staves
		{
			set{ _community_enp_laidoff_staves=value;}
			get{return _community_enp_laidoff_staves;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_have_land_pop
		{
			set{ _community_have_land_pop=value;}
			get{return _community_have_land_pop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_rural_to_town_pop
		{
			set{ _community_rural_to_town_pop=value;}
			get{return _community_rural_to_town_pop;}
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
		public string tcimunset1
		{
			set{ _tcimunset1=value;}
			get{return _tcimunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcimunset2
		{
			set{ _tcimunset2=value;}
			get{return _tcimunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcimunset3
		{
			set{ _tcimunset3=value;}
			get{return _tcimunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcimunset4
		{
			set{ _tcimunset4=value;}
			get{return _tcimunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcimunset5
		{
			set{ _tcimunset5=value;}
			get{return _tcimunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcimunset6
		{
			set{ _tcimunset6=value;}
			get{return _tcimunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcimunset7
		{
			set{ _tcimunset7=value;}
			get{return _tcimunset7;}
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

