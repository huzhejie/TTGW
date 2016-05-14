using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// community_traffic:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class community_traffic
	{
		public community_traffic()
		{}
		#region Model
		private string _community_id;
		private int? _community_passenger_station_num;
		private decimal? _community_station_waiting_room_area;
		private decimal? _community_station_parking_lot_area;
		private int? _community_bus_trips;
		private int? _community_quay_num;
		private int? _community_passenger_and_goods_quay_num;
		private int? _community_goods_quay_num;
		private int? _community_passenger_quay_num;
		private int? _community_docking_point;
		private decimal? _community_passenger_quay_waiting_room_area;
		private decimal? _community_passenger_quay_parking_lot_area;
		private decimal? _community_passenger_quay_ship_trips;
		private decimal? _community_passenger_quay_dis_to_county;
		private DateTime _statistics_date;
		private string _tctunset1;
		private string _tctunset2;
		private string _tctunset3;
		private string _tctunset4;
		private string _tctunset5;
		private string _tctunset6;
		private string _tctunset7;
		private string _tctunset8;
		private string _tctunset9;
		private string _tctunset10;
		private string _tctunset11;
		private string _tctunset12;
		private string _tctunset13;
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
		public int? community_passenger_station_num
		{
			set{ _community_passenger_station_num=value;}
			get{return _community_passenger_station_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_station_waiting_room_area
		{
			set{ _community_station_waiting_room_area=value;}
			get{return _community_station_waiting_room_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_station_parking_lot_area
		{
			set{ _community_station_parking_lot_area=value;}
			get{return _community_station_parking_lot_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_bus_trips
		{
			set{ _community_bus_trips=value;}
			get{return _community_bus_trips;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_quay_num
		{
			set{ _community_quay_num=value;}
			get{return _community_quay_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_passenger_and_goods_quay_num
		{
			set{ _community_passenger_and_goods_quay_num=value;}
			get{return _community_passenger_and_goods_quay_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_goods_quay_num
		{
			set{ _community_goods_quay_num=value;}
			get{return _community_goods_quay_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_passenger_quay_num
		{
			set{ _community_passenger_quay_num=value;}
			get{return _community_passenger_quay_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? community_docking_point
		{
			set{ _community_docking_point=value;}
			get{return _community_docking_point;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_passenger_quay_waiting_room_area
		{
			set{ _community_passenger_quay_waiting_room_area=value;}
			get{return _community_passenger_quay_waiting_room_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_passenger_quay_parking_lot_area
		{
			set{ _community_passenger_quay_parking_lot_area=value;}
			get{return _community_passenger_quay_parking_lot_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_passenger_quay_ship_trips
		{
			set{ _community_passenger_quay_ship_trips=value;}
			get{return _community_passenger_quay_ship_trips;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_passenger_quay_dis_to_county
		{
			set{ _community_passenger_quay_dis_to_county=value;}
			get{return _community_passenger_quay_dis_to_county;}
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
		public string tctunset1
		{
			set{ _tctunset1=value;}
			get{return _tctunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tctunset2
		{
			set{ _tctunset2=value;}
			get{return _tctunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tctunset3
		{
			set{ _tctunset3=value;}
			get{return _tctunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tctunset4
		{
			set{ _tctunset4=value;}
			get{return _tctunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tctunset5
		{
			set{ _tctunset5=value;}
			get{return _tctunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tctunset6
		{
			set{ _tctunset6=value;}
			get{return _tctunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tctunset7
		{
			set{ _tctunset7=value;}
			get{return _tctunset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tctunset8
		{
			set{ _tctunset8=value;}
			get{return _tctunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tctunset9
		{
			set{ _tctunset9=value;}
			get{return _tctunset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tctunset10
		{
			set{ _tctunset10=value;}
			get{return _tctunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tctunset11
		{
			set{ _tctunset11=value;}
			get{return _tctunset11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tctunset12
		{
			set{ _tctunset12=value;}
			get{return _tctunset12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tctunset13
		{
			set{ _tctunset13=value;}
			get{return _tctunset13;}
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

