using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_elec_supply:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_elec_supply
	{
		public community_elec_supply()
		{}
		#region Model
		private string _community_id;
		private int? _community_load_dispatching_office_num;
		private int? _community_transformer_num;
		private int? _below_100kva_transformer_num;
		private int? _at_100_500kva_transformer_num;
		private int? _at_500_1000kva_transformer_num;
		private int? _more_1000kva_transformer_num;
		private decimal? _community_elec_supply_wireways_length;
		private decimal? _community_power_transmission_line_length;
		private decimal? _community_high_voltage_distr_line_legth;
		private decimal? _community_low_voltage_distr_line_legth;
		private decimal? _community_elec_supply_consumption;
		private decimal? _community_resident_elec_consumption;
		private int? _no_elec_days;
		private DateTime _statistics_date;
		private string _tcesunset1;
		private string _tcesunset2;
		private string _tcesunset3;
		private string _tcesunset4;
		private string _tcesunset5;
		private string _tcesunset6;
		private string _tcesunset7;
		private string _tcesunset8;
		private string _tcesunset9;
		private string _tcesunset10;
		private string _tcesunset11;
		private string _tcesunset12;
		private string _tcesunset13;
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
		public int? community_load_dispatching_office_num
		{
			set{ _community_load_dispatching_office_num=value;}
			get{return _community_load_dispatching_office_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_transformer_num
		{
			set{ _community_transformer_num=value;}
			get{return _community_transformer_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? below_100kva_transformer_num
		{
			set{ _below_100kva_transformer_num=value;}
			get{return _below_100kva_transformer_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? at_100_500kva_transformer_num
		{
			set{ _at_100_500kva_transformer_num=value;}
			get{return _at_100_500kva_transformer_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? at_500_1000kva_transformer_num
		{
			set{ _at_500_1000kva_transformer_num=value;}
			get{return _at_500_1000kva_transformer_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? more_1000kva_transformer_num
		{
			set{ _more_1000kva_transformer_num=value;}
			get{return _more_1000kva_transformer_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_elec_supply_wireways_length
		{
			set{ _community_elec_supply_wireways_length=value;}
			get{return _community_elec_supply_wireways_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_power_transmission_line_length
		{
			set{ _community_power_transmission_line_length=value;}
			get{return _community_power_transmission_line_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_high_voltage_distr_line_legth
		{
			set{ _community_high_voltage_distr_line_legth=value;}
			get{return _community_high_voltage_distr_line_legth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_low_voltage_distr_line_legth
		{
			set{ _community_low_voltage_distr_line_legth=value;}
			get{return _community_low_voltage_distr_line_legth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_elec_supply_consumption
		{
			set{ _community_elec_supply_consumption=value;}
			get{return _community_elec_supply_consumption;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_resident_elec_consumption
		{
			set{ _community_resident_elec_consumption=value;}
			get{return _community_resident_elec_consumption;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? no_elec_days
		{
			set{ _no_elec_days=value;}
			get{return _no_elec_days;}
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
		public string tcesunset1
		{
			set{ _tcesunset1=value;}
			get{return _tcesunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcesunset2
		{
			set{ _tcesunset2=value;}
			get{return _tcesunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcesunset3
		{
			set{ _tcesunset3=value;}
			get{return _tcesunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcesunset4
		{
			set{ _tcesunset4=value;}
			get{return _tcesunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcesunset5
		{
			set{ _tcesunset5=value;}
			get{return _tcesunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcesunset6
		{
			set{ _tcesunset6=value;}
			get{return _tcesunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcesunset7
		{
			set{ _tcesunset7=value;}
			get{return _tcesunset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcesunset8
		{
			set{ _tcesunset8=value;}
			get{return _tcesunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcesunset9
		{
			set{ _tcesunset9=value;}
			get{return _tcesunset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcesunset10
		{
			set{ _tcesunset10=value;}
			get{return _tcesunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcesunset11
		{
			set{ _tcesunset11=value;}
			get{return _tcesunset11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcesunset12
		{
			set{ _tcesunset12=value;}
			get{return _tcesunset12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcesunset13
		{
			set{ _tcesunset13=value;}
			get{return _tcesunset13;}
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

