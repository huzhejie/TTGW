﻿using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_business_pop_problem_finished:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_business_pop_problem_finished
	{
		public community_business_pop_problem_finished()
		{}
		#region Model
		private string _community_id;
		private decimal? _community_recon_block_len;
		private int? _community_recon_shop_front_num;
		private decimal? _community_recon_shop_front_area;
		private int? _community_added_market_merchants_num;
		private decimal? _community_market_area;
		private DateTime _statistics_date;
		private int _check_status=0;
		private string _tciunset1;
		private string _tciunset2;
		private string _tciunset3;
		private string _tciunset4;
		private string _tciunset5;
		private string _tciunset6;
		private string _tciunset7;
		private int _lock_tables=0;
		private string _project_name;
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
		public decimal? community_recon_block_len
		{
			set{ _community_recon_block_len=value;}
			get{return _community_recon_block_len;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_recon_shop_front_num
		{
			set{ _community_recon_shop_front_num=value;}
			get{return _community_recon_shop_front_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_recon_shop_front_area
		{
			set{ _community_recon_shop_front_area=value;}
			get{return _community_recon_shop_front_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_added_market_merchants_num
		{
			set{ _community_added_market_merchants_num=value;}
			get{return _community_added_market_merchants_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_market_area
		{
			set{ _community_market_area=value;}
			get{return _community_market_area;}
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
		public int check_status
		{
			set{ _check_status=value;}
			get{return _check_status;}
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
		public int lock_tables
		{
			set{ _lock_tables=value;}
			get{return _lock_tables;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_name
		{
			set{ _project_name=value;}
			get{return _project_name;}
		}
		#endregion Model

	}
}

