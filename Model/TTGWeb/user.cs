using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class user
	{
		public user()
		{}
		#region Model
		private string _username;
		private string _userpwd;
		private string _usertype;
        private string _userid;
        /// <summary>
        /// 
        /// </summary>
        public string userId
        {
            set { _userid = value; }
            get { return _userid; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string userName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userPwd
		{
			set{ _userpwd=value;}
			get{return _userpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userType
		{
			set{ _usertype=value;}
			get{return _usertype;}
		}
		#endregion Model

	}
}

