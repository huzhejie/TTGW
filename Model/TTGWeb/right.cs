using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// right:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class right
	{
		public right()
		{}
		#region Model
		private string _community_id;
		private string _investigator_id;
		private string _areachief_id;
        private string _community_name;
        private string _community_county;
        private string _community_province;
        /// <summary>
        /// 
        /// </summary>
        public string community_name
        {
            get { return _community_name; }
            set { _community_name = value; }
        }
     
        /// <summary>
        /// 
        /// </summary>
        public string community_county
        {
            get { return _community_county; }
            set { _community_county = value; }
        }
       

        public string community_province
        {
            get { return _community_province; }
            set { _community_province = value; }
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
		public string investigator_id
		{
			set{ _investigator_id=value;}
			get{return _investigator_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string areaChief_id
		{
			set{ _areachief_id=value;}
			get{return _areachief_id;}
		}
		#endregion Model

	}
}

