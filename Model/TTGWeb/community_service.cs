using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_service:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_service
	{
		public community_service()
		{}
		#region Model
		private string _community_id;
		private decimal? _community_comm_serv_fac_fs;
		private decimal? _community_comm_serv_fac_gfa;
		private decimal? _community_comm_serv_cen_fs;
		private decimal? _community_comm_serv_cen_gfa;
		private decimal? _community_comm_serv_cen_dis_ots;
		private decimal? _community_empm_supt_cen_fs;
		private decimal? _community_empm_supt_cen_gfa;
		private decimal? _community_empm_supt_cen_dis_ots;
		private decimal? _community_police_sta_fs;
		private decimal? _community_police_sta_gfa;
		private decimal? _community_police_sta_dis_ots;
		private int? _community_prop_magm_unit_num;
		private int? _community_no_prop_magm_unit_num;
		private DateTime _statistics_date;
		private string _tcsrunset1;
		private string _tcsrunset2;
		private string _tcsrunset3;
		private string _tcsrunset4;
		private string _tcsrunset5;
		private string _tcsrunset6;
		private string _tcsrunset7;
		private string _tcsrunset8;
		private string _tcsrunset9;
		private string _tcsrunset10;
		private string _tcsrunset11;
		private string _tcsrunset12;
		private string _tcsrunset13;
		private int _lock_tables=0;
		private int _check_status=0;
		private decimal? _community_old_fs;
		private decimal? _community_old_gfa;
		private decimal? _community_old_dis_ots;
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
		public decimal? community_comm_serv_fac_fs
		{
			set{ _community_comm_serv_fac_fs=value;}
			get{return _community_comm_serv_fac_fs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_comm_serv_fac_gfa
		{
			set{ _community_comm_serv_fac_gfa=value;}
			get{return _community_comm_serv_fac_gfa;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_comm_serv_cen_fs
		{
			set{ _community_comm_serv_cen_fs=value;}
			get{return _community_comm_serv_cen_fs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_comm_serv_cen_gfa
		{
			set{ _community_comm_serv_cen_gfa=value;}
			get{return _community_comm_serv_cen_gfa;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_comm_serv_cen_dis_ots
		{
			set{ _community_comm_serv_cen_dis_ots=value;}
			get{return _community_comm_serv_cen_dis_ots;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_empm_supt_cen_fs
		{
			set{ _community_empm_supt_cen_fs=value;}
			get{return _community_empm_supt_cen_fs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_empm_supt_cen_gfa
		{
			set{ _community_empm_supt_cen_gfa=value;}
			get{return _community_empm_supt_cen_gfa;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_empm_supt_cen_dis_ots
		{
			set{ _community_empm_supt_cen_dis_ots=value;}
			get{return _community_empm_supt_cen_dis_ots;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_police_sta_fs
		{
			set{ _community_police_sta_fs=value;}
			get{return _community_police_sta_fs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_police_sta_gfa
		{
			set{ _community_police_sta_gfa=value;}
			get{return _community_police_sta_gfa;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_police_sta_dis_ots
		{
			set{ _community_police_sta_dis_ots=value;}
			get{return _community_police_sta_dis_ots;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_prop_magm_unit_num
		{
			set{ _community_prop_magm_unit_num=value;}
			get{return _community_prop_magm_unit_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_no_prop_magm_unit_num
		{
			set{ _community_no_prop_magm_unit_num=value;}
			get{return _community_no_prop_magm_unit_num;}
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
		public string tcsrunset1
		{
			set{ _tcsrunset1=value;}
			get{return _tcsrunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsrunset2
		{
			set{ _tcsrunset2=value;}
			get{return _tcsrunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsrunset3
		{
			set{ _tcsrunset3=value;}
			get{return _tcsrunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsrunset4
		{
			set{ _tcsrunset4=value;}
			get{return _tcsrunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsrunset5
		{
			set{ _tcsrunset5=value;}
			get{return _tcsrunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsrunset6
		{
			set{ _tcsrunset6=value;}
			get{return _tcsrunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsrunset7
		{
			set{ _tcsrunset7=value;}
			get{return _tcsrunset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsrunset8
		{
			set{ _tcsrunset8=value;}
			get{return _tcsrunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsrunset9
		{
			set{ _tcsrunset9=value;}
			get{return _tcsrunset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsrunset10
		{
			set{ _tcsrunset10=value;}
			get{return _tcsrunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsrunset11
		{
			set{ _tcsrunset11=value;}
			get{return _tcsrunset11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsrunset12
		{
			set{ _tcsrunset12=value;}
			get{return _tcsrunset12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcsrunset13
		{
			set{ _tcsrunset13=value;}
			get{return _tcsrunset13;}
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
		public decimal? community_old_fs
		{
			set{ _community_old_fs=value;}
			get{return _community_old_fs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_old_gfa
		{
			set{ _community_old_gfa=value;}
			get{return _community_old_gfa;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_old_dis_ots
		{
			set{ _community_old_dis_ots=value;}
			get{return _community_old_dis_ots;}
		}
		#endregion Model

	}
}

