using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// excel_status:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class excel_status
	{
		public excel_status()
		{}
		#region Model
		private DateTime _fill_time;
		private string _community_id;
		private string _community_name;
		private int _state=0;
		private string _excel_name;
		private string _investigator_id;
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
		/// <summary>
		/// 
		/// </summary>
		public DateTime fill_time
		{
			set{ _fill_time=value;}
			get{return _fill_time;}
		}
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
		public string community_name
		{
			set{ _community_name=value;}
			get{return _community_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int state
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string excel_name
		{
			set{ _excel_name=value;}
			get{return _excel_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string investigator_id
		{
			set{ _investigator_id=value;}
			get{return _investigator_id;}
		}
		#endregion Model

	}
}

