using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// errorLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class errorLog
	{
		public errorLog()
		{}
		#region Model
		private int _errorlog_id;
		private DateTime _createtime;
		private string _errorlogorigin;
		private string _errorlogmessage;
		private string _stacktrace;
		/// <summary>
		/// 
		/// </summary>
		public int errorLog_id
		{
			set{ _errorlog_id=value;}
			get{return _errorlog_id;}
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
		public string errorLogOrigin
		{
			set{ _errorlogorigin=value;}
			get{return _errorlogorigin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string errorLogMessage
		{
			set{ _errorlogmessage=value;}
			get{return _errorlogmessage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stackTrace
		{
			set{ _stacktrace=value;}
			get{return _stacktrace;}
		}
		#endregion Model

	}
}

