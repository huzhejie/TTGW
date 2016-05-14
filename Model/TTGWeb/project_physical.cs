using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// project_physical:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class project_physical
	{
		public project_physical()
		{}
		#region Model
		private string _project_id;
		private string _county_name;
		private string _project_name;
		private int? _project_time;
		private string _project_investment_type;
		private string _sub_project_id;
		private string _sub_project_name;
        private string _sub_project_type;

        public string sub_project_type
        {
            get { return _sub_project_type; }
            set { _sub_project_type = value; }
        }
		private string _community;
		private string _physical_class;
		private string _physical_subclass;
		private string _physical_class_content;
		private string _tciunset1;
		private string _tciunset2;
		private string _tciunset3;
		private string _tciunset4;
		private string _tciunset5;
		private string _tciunset6;
		private string _tciunset7;
		private string _tciunset8;
		private string _tciunset9;
		private string _tciunset10;
		private string _tciunset11;
		private string _tciunset12;
		private string _tciunset13;
		private string _tciunset14;
		private int _check_status=0;
		private int _lock_tables=0;
		private decimal? _last_year_quantity;
		private int? _year;
		private decimal? _june_quantity;
		private decimal? _december_quantity;
		private string _remark;
		private DateTime _fill_time;
        private decimal? _solve_question_objects;

        public decimal? solve_question_objects
        {
            get { return _solve_question_objects; }
            set { _solve_question_objects = value; }
        }
        private decimal? _improve_objects;

        public decimal? improve_objects
        {
            get { return _improve_objects; }
            set { _improve_objects = value; }
        }
        private decimal? _summary;

        public decimal? summary
        {
            get { return _summary; }
            set { _summary = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		public string project_id
		{
			set{ _project_id=value;}
			get{return _project_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string county_name
		{
			set{ _county_name=value;}
			get{return _county_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_name
		{
			set{ _project_name=value;}
			get{return _project_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? project_time
		{
			set{ _project_time=value;}
			get{return _project_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_investment_type
		{
			set{ _project_investment_type=value;}
			get{return _project_investment_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sub_project_id
		{
			set{ _sub_project_id=value;}
			get{return _sub_project_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sub_project_name
		{
			set{ _sub_project_name=value;}
			get{return _sub_project_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string community
		{
			set{ _community=value;}
			get{return _community;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string physical_class
		{
			set{ _physical_class=value;}
			get{return _physical_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string physical_subclass
		{
			set{ _physical_subclass=value;}
			get{return _physical_subclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string physical_class_content
		{
			set{ _physical_class_content=value;}
			get{return _physical_class_content;}
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
		public string tciunset8
		{
			set{ _tciunset8=value;}
			get{return _tciunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset9
		{
			set{ _tciunset9=value;}
			get{return _tciunset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset10
		{
			set{ _tciunset10=value;}
			get{return _tciunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset11
		{
			set{ _tciunset11=value;}
			get{return _tciunset11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset12
		{
			set{ _tciunset12=value;}
			get{return _tciunset12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset13
		{
			set{ _tciunset13=value;}
			get{return _tciunset13;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset14
		{
			set{ _tciunset14=value;}
			get{return _tciunset14;}
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
		/// <summary>
		/// 
		/// </summary>
		public decimal? last_year_quantity
		{
			set{ _last_year_quantity=value;}
			get{return _last_year_quantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? year
		{
			set{ _year=value;}
			get{return _year;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? june_quantity
		{
			set{ _june_quantity=value;}
			get{return _june_quantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? december_quantity
		{
			set{ _december_quantity=value;}
			get{return _december_quantity;}
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
		public DateTime fill_time
		{
			set{ _fill_time=value;}
			get{return _fill_time;}
		}
		#endregion Model

	}
}

