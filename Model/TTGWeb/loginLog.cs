using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// loginLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class loginLog
	{
		public loginLog()
		{}
		#region Model
		private int _loginlog_id;
		private DateTime _createtime;
		private string _loginloglevel;
		private string _loginlogmessage;
		/// <summary>
		/// 
		/// </summary>
		public int loginLog_id
		{
			set{ _loginlog_id=value;}
			get{return _loginlog_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime createTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string loginLogLevel
		{
			set{ _loginloglevel=value;}
			get{return _loginloglevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string loginLogMessage
		{
			set{ _loginlogmessage=value;}
			get{return _loginlogmessage;}
		}
		#endregion Model

	}
}

