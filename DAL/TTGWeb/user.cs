using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:user
	/// </summary>
	public partial class user
	{
		public user()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string userName)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_user");
			strSql.Append(" where userName=@userName ");
			SqlParameter[] parameters = {
					new SqlParameter("@userName", SqlDbType.VarChar,50)			};
			parameters[0].Value = userName;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_user(");
			strSql.Append("userName,userPwd,userType,userId)");
			strSql.Append(" values (");
			strSql.Append("@userName,@userPwd,@userType,@userId)");
			SqlParameter[] parameters = {
					new SqlParameter("@userName", SqlDbType.VarChar,50),
					new SqlParameter("@userPwd", SqlDbType.VarChar,50),
                    new SqlParameter("@userType", SqlDbType.VarChar,50),
					new SqlParameter("@userId", SqlDbType.VarChar,50)};
			parameters[0].Value = model.userName;
			parameters[1].Value = model.userPwd;
			parameters[2].Value = model.userType;
            parameters[3].Value = model.userId;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(TTG.Model.TTGWeb.user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_user set ");
			strSql.Append("userPwd=@userPwd,");
			strSql.Append("userType=@userType,");
            strSql.Append("userName=@userName");
			strSql.Append(" where userId=@userId ");
			SqlParameter[] parameters = {
					new SqlParameter("@userPwd", SqlDbType.VarChar,50),
					new SqlParameter("@userType", SqlDbType.VarChar,50),
                    new SqlParameter("@userName", SqlDbType.VarChar,50),
					new SqlParameter("@userId", SqlDbType.VarChar,50)};
			parameters[0].Value = model.userPwd;
			parameters[1].Value = model.userType;
			parameters[2].Value = model.userName;
            parameters[3].Value = model.userId;
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
        public bool Delete(string userId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_user ");
            strSql.Append(" where userId=@userId ");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.VarChar,50)			};
            parameters[0].Value = userId;

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
		public bool DeleteList(string userNamelist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_user ");
			strSql.Append(" where userName in ("+userNamelist + ")  ");
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
		public TTG.Model.TTGWeb.user GetModel(string userName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 userName,userPwd,userType from T_user ");
			strSql.Append(" where userName=@userName ");
			SqlParameter[] parameters = {
					new SqlParameter("@userName", SqlDbType.VarChar,50)			};
			parameters[0].Value = userName;

			TTG.Model.TTGWeb.user model=new TTG.Model.TTGWeb.user();
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
		public TTG.Model.TTGWeb.user DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.user model=new TTG.Model.TTGWeb.user();
			if (row != null)
			{
				if(row["userName"]!=null)
				{
					model.userName=row["userName"].ToString();
				}
				if(row["userPwd"]!=null)
				{
					model.userPwd=row["userPwd"].ToString();
				}
				if(row["userType"]!=null)
				{
					model.userType=row["userType"].ToString();
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
			strSql.Append("select userName,userPwd,userType ");
			strSql.Append(" FROM T_user ");
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
			strSql.Append(" userName,userPwd,userType ");
			strSql.Append(" FROM T_user ");
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
			strSql.Append("select count(1) FROM T_user ");
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
				strSql.Append("order by T.userName desc");
			}
			strSql.Append(")AS Row, T.*  from T_user T ");
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
			parameters[0].Value = "T_user";
			parameters[1].Value = "userName";
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
        /// 获得某一行数据
        /// </summary>
        public DataSet GetOne(string strWhereUser, string strWherePass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM T_user");           
            strSql.Append(" where userId='" + strWhereUser.Trim() + "'");
            strSql.Append(" AND userPwd='" + strWherePass .Trim()+ "'");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM T_user");
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 按条件获得数据
        /// </summary>
        public DataSet GetConditionalData(string strWhereId, string strWhereName,string strWhereType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *");                    
            strSql.Append(" FROM T_user where 1=1");
            if (strWhereId.Trim() != "")
            {
                strSql.Append(" AND userId='" + strWhereId+"'");
            }
            if (strWhereName.Trim() != "")
            {
                strSql.Append(" AND userName='" + strWhereName + "'");
            }
            if (strWhereType.Trim() != "")
            {
                strSql.Append(" AND userType='" + strWhereType + "'");
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetOneName(string strWhereUserId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select userName FROM T_user");
            strSql.Append(" where userId='" + strWhereUserId + "'");         
            return DbHelperSQL.Query(strSql.ToString());
        }
		#endregion  ExtensionMethod
	}
}

