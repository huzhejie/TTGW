using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:excel_message
	/// </summary>
	public partial class excel_message
	{
		public excel_message()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("table_id", "T_excel_message"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int table_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_excel_message");
			strSql.Append(" where table_id=@table_id");
			SqlParameter[] parameters = {
					new SqlParameter("@table_id", SqlDbType.Int,4)
			};
			parameters[0].Value = table_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 更跟据table_path判断是否已经存在该文件
        /// </summary>
        /// <param name="table_id"></param>
        /// <returns></returns>
        public bool Exists(TTG.Model.TTGWeb.excel_message model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_excel_message");
            strSql.Append(" where table_path=@table_path");
            SqlParameter[] parameters = {
					new SqlParameter("@table_path", SqlDbType.NVarChar,100)
			};
            parameters[0].Value = model.table_path;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.excel_message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_excel_message(");
			strSql.Append("table_name,table_path)");
			strSql.Append(" values (");
			strSql.Append("@table_name,@table_path)");			
			SqlParameter[] parameters = {
					new SqlParameter("@table_name", SqlDbType.NVarChar,50),
					new SqlParameter("@table_path", SqlDbType.VarChar,100)};
			parameters[0].Value = model.table_name;
			parameters[1].Value = model.table_path;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
		public bool Update(TTG.Model.TTGWeb.excel_message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_excel_message set ");
			strSql.Append("table_name=@table_name,");
			strSql.Append("table_path=@table_path");
			strSql.Append(" where table_id=@table_id");
			SqlParameter[] parameters = {
					new SqlParameter("@table_name", SqlDbType.NVarChar,50),
					new SqlParameter("@table_path", SqlDbType.VarChar,100),
					new SqlParameter("@table_id", SqlDbType.Int,4)};
			parameters[0].Value = model.table_name;
			parameters[1].Value = model.table_path;
			parameters[2].Value = model.table_id;

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
		public bool Delete(int table_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_excel_message ");
			strSql.Append(" where table_id=@table_id");
			SqlParameter[] parameters = {
					new SqlParameter("@table_id", SqlDbType.Int,4)
			};
			parameters[0].Value = table_id;

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
		public bool DeleteList(string table_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_excel_message ");
			strSql.Append(" where table_id in ("+table_idlist + ")  ");
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
		public TTG.Model.TTGWeb.excel_message GetModel(int table_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 table_name,table_path,table_id from T_excel_message ");
			strSql.Append(" where table_id=@table_id");
			SqlParameter[] parameters = {
					new SqlParameter("@table_id", SqlDbType.Int,4)
			};
			parameters[0].Value = table_id;

			TTG.Model.TTGWeb.excel_message model=new TTG.Model.TTGWeb.excel_message();
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
		public TTG.Model.TTGWeb.excel_message DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.excel_message model=new TTG.Model.TTGWeb.excel_message();
			if (row != null)
			{
				if(row["table_name"]!=null)
				{
					model.table_name=row["table_name"].ToString();
				}
				if(row["table_path"]!=null)
				{
					model.table_path=row["table_path"].ToString();
				}
				if(row["table_id"]!=null && row["table_id"].ToString()!="")
				{
					model.table_id=int.Parse(row["table_id"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select table_name,table_path,table_id ");
			strSql.Append(" FROM T_excel_message");			
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
			strSql.Append(" table_name,table_path,table_id ");
			strSql.Append(" FROM T_excel_message ");
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
		public int GetRecordCount()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_excel_message");			
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
		public DataSet GetListByPage(int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");			
			strSql.Append("order by T.table_id desc");			
			strSql.Append(")AS Row, T.*  from T_excel_message T");			
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
			parameters[0].Value = "T_excel_message";
			parameters[1].Value = "table_id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

