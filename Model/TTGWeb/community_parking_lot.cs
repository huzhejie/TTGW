using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_parking_lot:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_parking_lot
	{
		public community_parking_lot()
		{}
		#region Model
		private string _community_id;
		private int? _community_parking_space_num;
		private decimal? _community_parking_rate;
		private decimal? _community_parking_space_use_rate;
		private int? _community_public_parking_lot_num;
		private int? _community_public_grand_parking_lot_num;
		private int? _community_public_underg_parking_lot_num;
		private int? _community_public_overg_parking_lot_num;
		private decimal? _community_public_parking_lot_area;
		private int? _community_public_parking_space_num;
		private decimal? _community_public_parking_lot_area_rate;
		private int? _dis_150m_public_parking_lot_num;
		private decimal? _dis_150m_public_parking_lot_area;
		private int? _dis_150m_public_parking_space_num;
		private DateTime _statistics_date;
		private string _tcplunset1;
		private string _tcplunset2;
		private string _tcplunset3;
		private string _tcplunset4;
		private string _tcplunset5;
		private string _tcplunset6;
		private string _tcplunset7;
		private string _tcplunset8;
		private string _tcplunset9;
		private string _tcplunset10;
		private string _tcplunset11;
		private string _tcplunset12;
		private string _tcplunset13;
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
		public int? community_parking_space_num
		{
			set{ _community_parking_space_num=value;}
			get{return _community_parking_space_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_parking_rate
		{
			set{ _community_parking_rate=value;}
			get{return _community_parking_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_parking_space_use_rate
		{
			set{ _community_parking_space_use_rate=value;}
			get{return _community_parking_space_use_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_public_parking_lot_num
		{
			set{ _community_public_parking_lot_num=value;}
			get{return _community_public_parking_lot_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_public_grand_parking_lot_num
		{
			set{ _community_public_grand_parking_lot_num=value;}
			get{return _community_public_grand_parking_lot_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_public_underg_parking_lot_num
		{
			set{ _community_public_underg_parking_lot_num=value;}
			get{return _community_public_underg_parking_lot_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_public_overg_parking_lot_num
		{
			set{ _community_public_overg_parking_lot_num=value;}
			get{return _community_public_overg_parking_lot_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_public_parking_lot_area
		{
			set{ _community_public_parking_lot_area=value;}
			get{return _community_public_parking_lot_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_public_parking_space_num
		{
			set{ _community_public_parking_space_num=value;}
			get{return _community_public_parking_space_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_public_parking_lot_area_rate
		{
			set{ _community_public_parking_lot_area_rate=value;}
			get{return _community_public_parking_lot_area_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? dis_150m_public_parking_lot_num
		{
			set{ _dis_150m_public_parking_lot_num=value;}
			get{return _dis_150m_public_parking_lot_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? dis_150m_public_parking_lot_area
		{
			set{ _dis_150m_public_parking_lot_area=value;}
			get{return _dis_150m_public_parking_lot_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? dis_150m_public_parking_space_num
		{
			set{ _dis_150m_public_parking_space_num=value;}
			get{return _dis_150m_public_parking_space_num;}
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
		public string tcplunset1
		{
			set{ _tcplunset1=value;}
			get{return _tcplunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcplunset2
		{
			set{ _tcplunset2=value;}
			get{return _tcplunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcplunset3
		{
			set{ _tcplunset3=value;}
			get{return _tcplunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcplunset4
		{
			set{ _tcplunset4=value;}
			get{return _tcplunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcplunset5
		{
			set{ _tcplunset5=value;}
			get{return _tcplunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcplunset6
		{
			set{ _tcplunset6=value;}
			get{return _tcplunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcplunset7
		{
			set{ _tcplunset7=value;}
			get{return _tcplunset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcplunset8
		{
			set{ _tcplunset8=value;}
			get{return _tcplunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcplunset9
		{
			set{ _tcplunset9=value;}
			get{return _tcplunset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcplunset10
		{
			set{ _tcplunset10=value;}
			get{return _tcplunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcplunset11
		{
			set{ _tcplunset11=value;}
			get{return _tcplunset11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcplunset12
		{
			set{ _tcplunset12=value;}
			get{return _tcplunset12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcplunset13
		{
			set{ _tcplunset13=value;}
			get{return _tcplunset13;}
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

