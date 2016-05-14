using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_concil_house:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_concil_house
	{
		public community_concil_house()
		{}
		#region Model
		private string _community_id;
		private int? _community_council_buil_num;
		private decimal? _community_conhou_gfa;
		private decimal? _community_conhou_fs;
		private int? _community_conhou_unit_num;
		private int? _community_conhou_floor_num;
		private int? _community_conhou_suite_num;
		private int? _community_conhou_family_num;
		private int? _community_conhou_people_num;
		private DateTime _statistics_date;
		private string _tcchunset1;
		private string _tcchunset2;
		private string _tcchunset3;
		private string _tcchunset4;
		private string _tcchunset5;
		private string _tcchunset6;
		private string _tcchunset8;
		private int _lock_tables=0;
		private int _check_status=0;
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
		public int? community_council_buil_num
		{
			set{ _community_council_buil_num=value;}
			get{return _community_council_buil_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_conhou_gfa
		{
			set{ _community_conhou_gfa=value;}
			get{return _community_conhou_gfa;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_conhou_fs
		{
			set{ _community_conhou_fs=value;}
			get{return _community_conhou_fs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_conhou_unit_num
		{
			set{ _community_conhou_unit_num=value;}
			get{return _community_conhou_unit_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_conhou_floor_num
		{
			set{ _community_conhou_floor_num=value;}
			get{return _community_conhou_floor_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_conhou_suite_num
		{
			set{ _community_conhou_suite_num=value;}
			get{return _community_conhou_suite_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_conhou_family_num
		{
			set{ _community_conhou_family_num=value;}
			get{return _community_conhou_family_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_conhou_people_num
		{
			set{ _community_conhou_people_num=value;}
			get{return _community_conhou_people_num;}
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
		public string tcchunset1
		{
			set{ _tcchunset1=value;}
			get{return _tcchunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcchunset2
		{
			set{ _tcchunset2=value;}
			get{return _tcchunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcchunset3
		{
			set{ _tcchunset3=value;}
			get{return _tcchunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcchunset4
		{
			set{ _tcchunset4=value;}
			get{return _tcchunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcchunset5
		{
			set{ _tcchunset5=value;}
			get{return _tcchunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcchunset6
		{
			set{ _tcchunset6=value;}
			get{return _tcchunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcchunset8
		{
			set{ _tcchunset8=value;}
			get{return _tcchunset8;}
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
		#endregion Model

	}
}

