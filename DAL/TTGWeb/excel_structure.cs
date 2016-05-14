using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
using System.Collections.Generic;
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:excel_structure
	/// </summary>
	public partial class excel_structure
	{
		public excel_structure()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string property,string table_name)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_excel_structure");
			strSql.Append(" where property=@property and table_name=@table_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@property", SqlDbType.VarChar,128),
					new SqlParameter("@table_name", SqlDbType.VarChar,128)			};
			parameters[0].Value = property;
			parameters[1].Value = table_name;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.excel_structure model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_excel_structure(");
			strSql.Append("property,excel_name,row_column_num,table_name)");
			strSql.Append(" values (");
			strSql.Append("@property,@excel_name,@row_column_num,@table_name)");
			SqlParameter[] parameters = {
					new SqlParameter("@property", SqlDbType.VarChar,128),
					new SqlParameter("@excel_name", SqlDbType.VarChar,128),
					new SqlParameter("@row_column_num", SqlDbType.Int,4),
					new SqlParameter("@table_name", SqlDbType.VarChar,128)};
			parameters[0].Value = model.property;
			parameters[1].Value = model.excel_name;
			parameters[2].Value = model.row_column_num;
			parameters[3].Value = model.table_name;

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
		public bool Update(TTG.Model.TTGWeb.excel_structure model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_excel_structure set ");
			strSql.Append("excel_name=@excel_name,");
			strSql.Append("row_column_num=@row_column_num");
			strSql.Append(" where property=@property and table_name=@table_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@excel_name", SqlDbType.VarChar,128),
					new SqlParameter("@row_column_num", SqlDbType.Int,4),
					new SqlParameter("@property", SqlDbType.VarChar,128),
					new SqlParameter("@table_name", SqlDbType.VarChar,128)};
			parameters[0].Value = model.excel_name;
			parameters[1].Value = model.row_column_num;
			parameters[2].Value = model.property;
			parameters[3].Value = model.table_name;

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
		public bool Delete(string property,string table_name)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_excel_structure ");
			strSql.Append(" where property=@property and table_name=@table_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@property", SqlDbType.VarChar,128),
					new SqlParameter("@table_name", SqlDbType.VarChar,128)			};
			parameters[0].Value = property;
			parameters[1].Value = table_name;

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
		/// 得到一个对象实体
		/// </summary>
		public TTG.Model.TTGWeb.excel_structure GetModel(string property,string table_name)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 property,excel_name,row_column_num,table_name from T_excel_structure ");
			strSql.Append(" where property=@property and table_name=@table_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@property", SqlDbType.VarChar,128),
					new SqlParameter("@table_name", SqlDbType.VarChar,128)			};
			parameters[0].Value = property;
			parameters[1].Value = table_name;

			TTG.Model.TTGWeb.excel_structure model=new TTG.Model.TTGWeb.excel_structure();
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
		public TTG.Model.TTGWeb.excel_structure DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.excel_structure model=new TTG.Model.TTGWeb.excel_structure();
			if (row != null)
			{
				if(row["property"]!=null)
				{
					model.property=row["property"].ToString();
				}
				if(row["excel_name"]!=null)
				{
					model.excel_name=row["excel_name"].ToString();
				}
				if(row["row_column_num"]!=null && row["row_column_num"].ToString()!="")
				{
					model.row_column_num=int.Parse(row["row_column_num"].ToString());
				}
				if(row["table_name"]!=null)
				{
					model.table_name=row["table_name"].ToString();
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
			strSql.Append("select property,excel_name,row_column_num,table_name ");
			strSql.Append(" FROM T_excel_structure ");
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
			strSql.Append(" property,excel_name,row_column_num,table_name ");
			strSql.Append(" FROM T_excel_structure ");
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
			strSql.Append("select count(1) FROM T_excel_structure ");
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
				strSql.Append("order by T.table_name desc");
			}
			strSql.Append(")AS Row, T.*  from T_excel_structure T ");
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
			parameters[0].Value = "T_excel_structure";
			parameters[1].Value = "table_name";
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
        /// 根据excel表名和数据库表名获取对应的全部信息。
        /// </summary>
        /// <param name="excel"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public List<TTG.Model.TTGWeb.excel_structure> getMessage(string excel, string table)
        {
            List<TTG.Model.TTGWeb.excel_structure> list = new List<Model.TTGWeb.excel_structure>();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select property,excel_name,row_column_num,table_name from T_excel_structure ");
            strSql.Append(" where excel_name=@excel_name and table_name=@table_name ");
            SqlParameter[] parameters = {
					new SqlParameter("@excel_name", SqlDbType.VarChar,128),
					new SqlParameter("@table_name", SqlDbType.VarChar,128)			};
            parameters[0].Value = excel;
            parameters[1].Value = table;

            TTG.Model.TTGWeb.excel_structure model = new TTG.Model.TTGWeb.excel_structure();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                list.Add(DataRowToModel(ds.Tables[0].Rows[i]));
            }
            return list;
        }
        /// <summary>
        /// 删除某一行数据
        /// </summary>
        /// <param name="row"></param>
        /// <param name="table_name"></param>
        /// <returns></returns>
        public bool delete(int row, string table_name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_excel_structure ");
            strSql.Append(" where row_column_num=@row and table_name=@table_name ");
            SqlParameter[] parameters = {
					new SqlParameter("@row", SqlDbType.Int, 32),
					new SqlParameter("@table_name", SqlDbType.VarChar,128)			};
            parameters[0].Value = row;
            parameters[1].Value = table_name;

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
        /// 获取某个字段名
        /// </summary>
        /// <param name="excel_name"></param>
        /// <param name="table_name"></param>
        /// <param name="row_num"></param>
        /// <returns></returns>
        public string getProperty(string excel_name, string table_name, int row_num)
        {
            string sql = "select property from T_excel_structure where excel_name = '" + excel_name + "' and table_name = '" +
                table_name + "' and row_column_num = " + row_num;
            DataSet ds = DbHelperSQL.Query(sql);
            string result = ds.Tables[0].Rows[0][0].ToString();
            return result;
        }
		#endregion  ExtensionMethod
	}
}

