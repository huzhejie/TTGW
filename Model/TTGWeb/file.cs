using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// file:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class file
	{
		public file()
		{}
		#region Model
		private int _file_no;
		private string _file_name;
		private string _file_address;
		private DateTime? _time;
        private string _file_type;

        /// <summary>
        /// 
        /// </summary>
        public string file_type
        {
            set { _file_type = value; }
            get { return _file_type; }
        }
		/// <summary>
		/// 
		/// </summary>
		public int file_no
		{
			set{ _file_no=value;}
			get{return _file_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_name
		{
			set{ _file_name=value;}
			get{return _file_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_address
		{
			set{ _file_address=value;}
			get{return _file_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? time
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

