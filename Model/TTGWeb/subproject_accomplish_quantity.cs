using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// subproject_accomplish_quantity:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class subproject_accomplish_quantity
	{
		public subproject_accomplish_quantity()
		{}
		#region Model
		private string _subproject_id;
		private string _subproject_name;
		private decimal? _subproject_finish_quantity;
		private DateTime _statistics_date;
		private string _tciunset1;
		private string _tciunset2;
		private string _tciunset3;
		private string _tciunset4;
		private int _check_status=0;
		private int _lock_tables=0;
		/// <summary>
		/// 
		/// </summary>
		public string subproject_id
		{
			set{ _subproject_id=value;}
			get{return _subproject_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string subproject_name
		{
			set{ _subproject_name=value;}
			get{return _subproject_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? subproject_finish_quantity
		{
			set{ _subproject_finish_quantity=value;}
			get{return _subproject_finish_quantity;}
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

