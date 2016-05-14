using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_water_supply:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_water_supply
	{
		public community_water_supply()
		{}
		#region Model
		private string _community_id;
		private decimal? _community_water_supply_pipe_length;
		private decimal? _community_water_supply_main_pipe_length;
		private decimal? _community_water_supply_pipe_branch_length;
		private decimal? _community_water_supply_service_pipe_length;
		private decimal? _community_water_supply_consumption;
		private decimal? _community_per_capita_water_supply_consumption;
		private DateTime _statistics_date;
		private string _tcwsunset1;
		private string _tcwsunset2;
		private string _tcwsunset3;
		private string _tcwsunset4;
		private string _tcwsunset5;
		private string _tcwsunset6;
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
		public decimal? community_water_supply_pipe_length
		{
			set{ _community_water_supply_pipe_length=value;}
			get{return _community_water_supply_pipe_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_water_supply_main_pipe_length
		{
			set{ _community_water_supply_main_pipe_length=value;}
			get{return _community_water_supply_main_pipe_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_water_supply_pipe_branch_length
		{
			set{ _community_water_supply_pipe_branch_length=value;}
			get{return _community_water_supply_pipe_branch_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_water_supply_service_pipe_length
		{
			set{ _community_water_supply_service_pipe_length=value;}
			get{return _community_water_supply_service_pipe_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_water_supply_consumption
		{
			set{ _community_water_supply_consumption=value;}
			get{return _community_water_supply_consumption;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_per_capita_water_supply_consumption
		{
			set{ _community_per_capita_water_supply_consumption=value;}
			get{return _community_per_capita_water_supply_consumption;}
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
		public string tcwsunset1
		{
			set{ _tcwsunset1=value;}
			get{return _tcwsunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcwsunset2
		{
			set{ _tcwsunset2=value;}
			get{return _tcwsunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcwsunset3
		{
			set{ _tcwsunset3=value;}
			get{return _tcwsunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcwsunset4
		{
			set{ _tcwsunset4=value;}
			get{return _tcwsunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcwsunset5
		{
			set{ _tcwsunset5=value;}
			get{return _tcwsunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcwsunset6
		{
			set{ _tcwsunset6=value;}
			get{return _tcwsunset6;}
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

