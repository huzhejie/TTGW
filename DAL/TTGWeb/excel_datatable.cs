using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
using System.Collections.Generic;
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:excel_datatable
	/// </summary>
	public partial class excel_datatable
	{
		public excel_datatable()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string table_name)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_excel_datatable");
			strSql.Append(" where table_name=@table_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@table_name", SqlDbType.VarChar,128)			};
			parameters[0].Value = table_name;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.excel_datatable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_excel_datatable(");
			strSql.Append("excel_name,table_name,table_start_column,table_start_row,table_end_column,table_end_row)");
			strSql.Append(" values (");
			strSql.Append("@excel_name,@table_name,@table_start_column,@table_start_row,@table_end_column,@table_end_row)");
			SqlParameter[] parameters = {
					new SqlParameter("@excel_name", SqlDbType.VarChar,128),
					new SqlParameter("@table_name", SqlDbType.VarChar,128),
					new SqlParameter("@table_start_column", SqlDbType.Int,4),
					new SqlParameter("@table_start_row", SqlDbType.Int,4),
					new SqlParameter("@table_end_column", SqlDbType.Int,4),
					new SqlParameter("@table_end_row", SqlDbType.Int,4)};
			parameters[0].Value = model.excel_name;
			parameters[1].Value = model.table_name;
			parameters[2].Value = model.table_start_column;
			parameters[3].Value = model.table_start_row;
			parameters[4].Value = model.table_end_column;
			parameters[5].Value = model.table_end_row;

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
		public bool Update(TTG.Model.TTGWeb.excel_datatable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_excel_datatable set ");
			strSql.Append("excel_name=@excel_name,");
			strSql.Append("table_start_column=@table_start_column,");
			strSql.Append("table_start_row=@table_start_row,");
			strSql.Append("table_end_column=@table_end_column,");
			strSql.Append("table_end_row=@table_end_row");
			strSql.Append(" where table_name=@table_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@excel_name", SqlDbType.VarChar,128),
					new SqlParameter("@table_start_column", SqlDbType.Int,4),
					new SqlParameter("@table_start_row", SqlDbType.Int,4),
					new SqlParameter("@table_end_column", SqlDbType.Int,4),
					new SqlParameter("@table_end_row", SqlDbType.Int,4),
					new SqlParameter("@table_name", SqlDbType.VarChar,128)};
			parameters[0].Value = model.excel_name;
			parameters[1].Value = model.table_start_column;
			parameters[2].Value = model.table_start_row;
			parameters[3].Value = model.table_end_column;
			parameters[4].Value = model.table_end_row;
			parameters[5].Value = model.table_name;

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
		public bool Delete(string table_name)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_excel_datatable ");
			strSql.Append(" where table_name=@table_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@table_name", SqlDbType.VarChar,128)			};
			parameters[0].Value = table_name;

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
		public bool DeleteList(string table_namelist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_excel_datatable ");
			strSql.Append(" where table_name in ("+table_namelist + ")  ");
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
		public TTG.Model.TTGWeb.excel_datatable GetModel(string table_name)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 excel_name,table_name,table_start_column,table_start_row,table_end_column,table_end_row from T_excel_datatable ");
			strSql.Append(" where table_name=@table_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@table_name", SqlDbType.VarChar,128)			};
			parameters[0].Value = table_name;

			TTG.Model.TTGWeb.excel_datatable model=new TTG.Model.TTGWeb.excel_datatable();
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
		public TTG.Model.TTGWeb.excel_datatable DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.excel_datatable model=new TTG.Model.TTGWeb.excel_datatable();
			if (row != null)
			{
				if(row["excel_name"]!=null)
				{
					model.excel_name=row["excel_name"].ToString();
				}
				if(row["table_name"]!=null)
				{
					model.table_name=row["table_name"].ToString();
				}
				if(row["table_start_column"]!=null && row["table_start_column"].ToString()!="")
				{
					model.table_start_column=int.Parse(row["table_start_column"].ToString());
				}
				if(row["table_start_row"]!=null && row["table_start_row"].ToString()!="")
				{
					model.table_start_row=int.Parse(row["table_start_row"].ToString());
				}
				if(row["table_end_column"]!=null && row["table_end_column"].ToString()!="")
				{
					model.table_end_column=int.Parse(row["table_end_column"].ToString());
				}
				if(row["table_end_row"]!=null && row["table_end_row"].ToString()!="")
				{
					model.table_end_row=int.Parse(row["table_end_row"].ToString());
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
			strSql.Append("select excel_name,table_name,table_start_column,table_start_row,table_end_column,table_end_row ");
			strSql.Append(" FROM T_excel_datatable ");
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
			strSql.Append(" excel_name,table_name,table_start_column,table_start_row,table_end_column,table_end_row ");
			strSql.Append(" FROM T_excel_datatable ");
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
			strSql.Append("select count(1) FROM T_excel_datatable ");
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
			strSql.Append(")AS Row, T.*  from T_excel_datatable T ");
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
			parameters[0].Value = "T_excel_datatable";
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
        /// 获取将要增加字段的数据表名
        /// </summary>
        /// <param name="excel_name"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public string getTableName(string excel_name, int row, int column)
        {
            string sql = "select * from T_excel_datatable where excel_name='" + excel_name + "' and (table_start_column=" + column + " or table_end_column=" + column + ")";
            DataSet ds = DbHelperSQL.Query(sql);
            List<TTG.Model.TTGWeb.excel_datatable> list = new List<Model.TTGWeb.excel_datatable>();
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                list.Add(DataRowToModel(ds.Tables[0].Rows[i]));
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].table_start_column == list[i].table_end_column)
                {
                    if (row > list[i].table_start_row && row < (list[i].table_end_row + 1))
                        return list[i].table_name;
                }
                else
                {
                    if (column == list[i].table_start_column && row > list[i].table_start_row)
                    {
                        return list[i].table_name;
                    }
                    else if (column == list[i].table_end_column && row < (list[i].table_end_row + 1))
                    {
                        return list[i].table_name;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// 获取特定表的表名
        /// </summary>
        /// <param name="excel_name"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public string getTable(string excel_name, int column, int flag)
        {
            string sql = "select * from T_excel_datatable where excel_name = '" + excel_name + "' and table_start_column<=" + (column + 1) + " and table_end_column>" + column + " and table_start_row = " + flag;
            DataSet ds = DbHelperSQL.Query(sql);
            Model.TTGWeb.excel_datatable ed = DataRowToModel(ds.Tables[0].Rows[0]);
            return ed.table_name;
        }
        /// <summary>
        /// 获取被插入数据表之下的同一列的数据表列表
        /// </summary>
        /// <param name="column"></param>
        /// <param name="excel_name"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public List<TTG.Model.TTGWeb.excel_datatable> getModel(int column, string excel_name, int row)
        {
            List<TTG.Model.TTGWeb.excel_datatable> list = new List<Model.TTGWeb.excel_datatable>();
            string sql = "select * from T_excel_datatable where excel_name = '" + excel_name + "' and table_start_column = " + column + " and table_start_row>" + row;
            DataSet ds = DbHelperSQL.Query(sql);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                list.Add(DataRowToModel(ds.Tables[0].Rows[i]));
            }
            return list;
        }
        /// <summary>
        /// 更新某一行
        /// </summary>
        /// <param name="excel_name"></param>
        /// <param name="table_name"></param>
        /// <param name="end_row"></param>
        /// <returns></returns>
        public bool update_table(string excel_name, string table_name, int end_row)
        {
            string sql = "update excel_datatable set table_end_row = " + end_row + " where excel_name=" + excel_name + "and table_name=" + table_name;
            int rows = DbHelperSQL.ExecuteSql(sql);
            if (rows != 1)
                return false;
            else
                return true;
        }
        /// <summary>
        /// 获取排在column之后的表的信息
        /// </summary>
        /// <param name="excel_name"></param>
        /// <param name="column"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public List<Model.TTGWeb.excel_datatable> getModelList(string excel_name, int column, int flag)
        {
            List<TTG.Model.TTGWeb.excel_datatable> list = new List<Model.TTGWeb.excel_datatable>();
            string sql = "select * from T_excel_datatable where excel_name = '" + excel_name + "' and table_start_column > " + column + " and table_start_row = " + flag;
            DataSet ds = DbHelperSQL.Query(sql);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                list.Add(DataRowToModel(ds.Tables[0].Rows[i]));
            }
            return list;
        }
		#endregion  ExtensionMethod
	}
}

