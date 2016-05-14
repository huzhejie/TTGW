using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// grandson_project:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class grandson_project
	{
		public grandson_project()
		{}
		#region Model
		private string _grandson_project_id;
		private string _grandson_project_type;
		private decimal? _total_investment;
		private decimal? _special_founds;
		private decimal? _conterpart_founds;
		private decimal? _other_matching_founds;
		private string _remark;
		private int _lock_tables=0;
		private int _check_status=0;
		private DateTime _fill_time;
        private string _subproject_id;

        public string subproject_id
        {
            get { return _subproject_id; }
            set { _subproject_id = value; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string grandson_project_id
		{
			set{ _grandson_project_id=value;}
			get{return _grandson_project_id;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		public string grandson_project_type
		{
			set{ _grandson_project_type=value;}
			get{return _grandson_project_type;}
		}
		
		
		/// <summary>
		/// 
		/// </summary>
		public decimal? total_investment
		{
			set{ _total_investment=value;}
			get{return _total_investment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? special_founds
		{
			set{ _special_founds=value;}
			get{return _special_founds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? conterpart_founds
		{
			set{ _conterpart_founds=value;}
			get{return _conterpart_founds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? other_matching_founds
		{
			set{ _other_matching_founds=value;}
			get{return _other_matching_founds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
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
		public DateTime fill_time
		{
			set{ _fill_time=value;}
			get{return _fill_time;}
		}
		#endregion Model

	}
}

