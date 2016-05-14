using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:errorLog
	/// </summary>
	public partial class errorLog
	{
		public errorLog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("errorLog_id", "T_errorLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int errorLog_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_errorLog");
			strSql.Append(" where errorLog_id=@errorLog_id");
			SqlParameter[] parameters = {
					new SqlParameter("@errorLog_id", SqlDbType.Int,4)
			};
			parameters[0].Value = errorLog_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(TTG.Model.TTGWeb.errorLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_errorLog(");
			strSql.Append("createTime,errorLogOrigin,errorLogMessage,stackTrace)");
			strSql.Append(" values (");
			strSql.Append("@createTime,@errorLogOrigin,@errorLogMessage,@stackTrace)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@createTime", SqlDbType.DateTime),
					new SqlParameter("@errorLogOrigin", SqlDbType.VarChar,100),
					new SqlParameter("@errorLogMessage", SqlDbType.VarChar,-1),
					new SqlParameter("@stackTrace", SqlDbType.VarChar,-1)};
			parameters[0].Value = model.createTime;
			parameters[1].Value = model.errorLogOrigin;
			parameters[2].Value = model.errorLogMessage;
			parameters[3].Value = model.stackTrace;

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
		public bool Update(TTG.Model.TTGWeb.errorLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_errorLog set ");
			strSql.Append("createTime=@createTime,");
			strSql.Append("errorLogOrigin=@errorLogOrigin,");
			strSql.Append("errorLogMessage=@errorLogMessage,");
			strSql.Append("stackTrace=@stackTrace");
			strSql.Append(" where errorLog_id=@errorLog_id");
			SqlParameter[] parameters = {
					new SqlParameter("@createTime", SqlDbType.DateTime),
					new SqlParameter("@errorLogOrigin", SqlDbType.VarChar,100),
					new SqlParameter("@errorLogMessage", SqlDbType.VarChar,-1),
					new SqlParameter("@stackTrace", SqlDbType.VarChar,-1),
					new SqlParameter("@errorLog_id", SqlDbType.Int,4)};
			parameters[0].Value = model.createTime;
			parameters[1].Value = model.errorLogOrigin;
			parameters[2].Value = model.errorLogMessage;
			parameters[3].Value = model.stackTrace;
			parameters[4].Value = model.errorLog_id;

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
		public bool Delete(int errorLog_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_errorLog ");
			strSql.Append(" where errorLog_id=@errorLog_id");
			SqlParameter[] parameters = {
					new SqlParameter("@errorLog_id", SqlDbType.Int,4)
			};
			parameters[0].Value = errorLog_id;

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
		public bool DeleteList(string errorLog_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_errorLog ");
			strSql.Append(" where errorLog_id in ("+errorLog_idlist + ")  ");
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
		public TTG.Model.TTGWeb.errorLog GetModel(int errorLog_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 errorLog_id,createTime,errorLogOrigin,errorLogMessage,stackTrace from T_errorLog ");
			strSql.Append(" where errorLog_id=@errorLog_id");
			SqlParameter[] parameters = {
					new SqlParameter("@errorLog_id", SqlDbType.Int,4)
			};
			parameters[0].Value = errorLog_id;

			TTG.Model.TTGWeb.errorLog model=new TTG.Model.TTGWeb.errorLog();
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
		public TTG.Model.TTGWeb.errorLog DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.errorLog model=new TTG.Model.TTGWeb.errorLog();
			if (row != null)
			{
				if(row["errorLog_id"]!=null && row["errorLog_id"].ToString()!="")
				{
					model.errorLog_id=int.Parse(row["errorLog_id"].ToString());
				}
				if(row["createTime"]!=null && row["createTime"].ToString()!="")
				{
					model.createTime=DateTime.Parse(row["createTime"].ToString());
				}
				if(row["errorLogOrigin"]!=null)
				{
					model.errorLogOrigin=row["errorLogOrigin"].ToString();
				}
				if(row["errorLogMessage"]!=null)
				{
					model.errorLogMessage=row["errorLogMessage"].ToString();
				}
				if(row["stackTrace"]!=null)
				{
					model.stackTrace=row["stackTrace"].ToString();
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
			strSql.Append("select errorLog_id,createTime,errorLogOrigin,errorLogMessage,stackTrace ");
			strSql.Append(" FROM T_errorLog ");
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
			strSql.Append(" errorLog_id,createTime,errorLogOrigin,errorLogMessage,stackTrace ");
			strSql.Append(" FROM T_errorLog ");
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
			strSql.Append("select count(1) FROM T_errorLog ");
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
				strSql.Append("order by T.errorLog_id desc");
			}
			strSql.Append(")AS Row, T.*  from T_errorLog T ");
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
			parameters[0].Value = "T_errorLog";
			parameters[1].Value = "errorLog_id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// 获得所有记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM T_errorLog");          
            return DbHelperSQL.Query(strSql.ToString());
        }
		#endregion  ExtensionMethod
	}
}

