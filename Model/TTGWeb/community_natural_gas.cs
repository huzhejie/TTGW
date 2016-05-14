using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_natural_gas:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_natural_gas
	{
		public community_natural_gas()
		{}
		#region Model
		private string _community_id;
		private int? _community_gas_regulating_station_num;
		private decimal? _community_natural_gas_pipe_length;
		private decimal? _low_pressure_natural_gas_pipe_length;
		private decimal? _middle_pressuse_natural_gas_pipe_length;
		private decimal? _intermediate_pressure_natural_gas_pipe_length;
		private DateTime _statistics_date;
		private string _tcngunset1;
		private string _tcngunset2;
		private string _tcngunset3;
		private string _tcngunset4;
		private string _tcngunset5;
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
		public int? community_gas_regulating_station_num
		{
			set{ _community_gas_regulating_station_num=value;}
			get{return _community_gas_regulating_station_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_natural_gas_pipe_length
		{
			set{ _community_natural_gas_pipe_length=value;}
			get{return _community_natural_gas_pipe_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? low_pressure_natural_gas_pipe_length
		{
			set{ _low_pressure_natural_gas_pipe_length=value;}
			get{return _low_pressure_natural_gas_pipe_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? middle_pressuse_natural_gas_pipe_length
		{
			set{ _middle_pressuse_natural_gas_pipe_length=value;}
			get{return _middle_pressuse_natural_gas_pipe_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? intermediate_pressure_natural_gas_pipe_length
		{
			set{ _intermediate_pressure_natural_gas_pipe_length=value;}
			get{return _intermediate_pressure_natural_gas_pipe_length;}
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
		public string tcngunset1
		{
			set{ _tcngunset1=value;}
			get{return _tcngunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcngunset2
		{
			set{ _tcngunset2=value;}
			get{return _tcngunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcngunset3
		{
			set{ _tcngunset3=value;}
			get{return _tcngunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcngunset4
		{
			set{ _tcngunset4=value;}
			get{return _tcngunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcngunset5
		{
			set{ _tcngunset5=value;}
			get{return _tcngunset5;}
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

