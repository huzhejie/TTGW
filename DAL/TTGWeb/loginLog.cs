using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:loginLog
	/// </summary>
	public partial class loginLog
	{
		public loginLog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("loginLog_id", "T_loginLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int loginLog_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_loginLog");
			strSql.Append(" where loginLog_id=@loginLog_id");
			SqlParameter[] parameters = {
					new SqlParameter("@loginLog_id", SqlDbType.Int,4)
			};
			parameters[0].Value = loginLog_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(TTG.Model.TTGWeb.loginLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_loginLog(");
			strSql.Append("createTime,loginLogLevel,loginLogMessage)");
			strSql.Append(" values (");
			strSql.Append("@createTime,@loginLogLevel,@loginLogMessage)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@createTime", SqlDbType.DateTime),
					new SqlParameter("@loginLogLevel", SqlDbType.VarChar,50),
					new SqlParameter("@loginLogMessage", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.createTime;
			parameters[1].Value = model.loginLogLevel;
			parameters[2].Value = model.loginLogMessage;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(TTG.Model.TTGWeb.loginLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_loginLog set ");
			strSql.Append("createTime=@createTime,");
			strSql.Append("loginLogLevel=@loginLogLevel,");
			strSql.Append("loginLogMessage=@loginLogMessage");
			strSql.Append(" where loginLog_id=@loginLog_id");
			SqlParameter[] parameters = {
					new SqlParameter("@createTime", SqlDbType.DateTime),
					new SqlParameter("@loginLogLevel", SqlDbType.VarChar,50),
					new SqlParameter("@loginLogMessage", SqlDbType.NVarChar,100),
					new SqlParameter("@loginLog_id", SqlDbType.Int,4)};
			parameters[0].Value = model.createTime;
			parameters[1].Value = model.loginLogLevel;
			parameters[2].Value = model.loginLogMessage;
			parameters[3].Value = model.loginLog_id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int loginLog_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_loginLog ");
			strSql.Append(" where loginLog_id=@loginLog_id");
			SqlParameter[] parameters = {
					new SqlParameter("@loginLog_id", SqlDbType.Int,4)
			};
			parameters[0].Value = loginLog_id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string loginLog_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_loginLog ");
			strSql.Append(" where loginLog_id in ("+loginLog_idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TTG.Model.TTGWeb.loginLog GetModel(int loginLog_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 loginLog_id,createTime,loginLogLevel,loginLogMessage from T_loginLog ");
			strSql.Append(" where loginLog_id=@loginLog_id");
			SqlParameter[] parameters = {
					new SqlParameter("@loginLog_id", SqlDbType.Int,4)
			};
			parameters[0].Value = loginLog_id;

			TTG.Model.TTGWeb.loginLog model=new TTG.Model.TTGWeb.loginLog();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TTG.Model.TTGWeb.loginLog DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.loginLog model=new TTG.Model.TTGWeb.loginLog();
			if (row != null)
			{
				if(row["loginLog_id"]!=null && row["loginLog_id"].ToString()!="")
				{
					model.loginLog_id=int.Parse(row["loginLog_id"].ToString());
				}
				if(row["createTime"]!=null && row["createTime"].ToString()!="")
				{
					model.createTime=DateTime.Parse(row["createTime"].ToString());
				}
				if(row["loginLogLevel"]!=null)
				{
					model.loginLogLevel=row["loginLogLevel"].ToString();
				}
				if(row["loginLogMessage"]!=null)
				{
					model.loginLogMessage=row["loginLogMessage"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select loginLog_id,createTime,loginLogLevel,loginLogMessage ");
			strSql.Append(" FROM T_loginLog ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" loginLog_id,createTime,loginLogLevel,loginLogMessage ");
			strSql.Append(" FROM T_loginLog ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_loginLog ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.loginLog_id desc");
			}
			strSql.Append(")AS Row, T.*  from T_loginLog T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "T_loginLog";
			parameters[1].Value = "loginLog_id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        public DataSet GetAll()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM T_loginLog ");
            return DbHelperSQL.Query(strSql.ToString());
        }
		#endregion  ExtensionMethod
	}
}

