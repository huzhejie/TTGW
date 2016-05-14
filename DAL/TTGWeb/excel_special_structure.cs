using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:excel_special_structure
	/// </summary>
	public partial class excel_special_structure
	{
		public excel_special_structure()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string chinese_name,string excel_name)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_excel_special_structure");
			strSql.Append(" where chinese_name=@chinese_name and excel_name=@excel_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@chinese_name", SqlDbType.VarChar,128),
					new SqlParameter("@excel_name", SqlDbType.VarChar,50)			};
			parameters[0].Value = chinese_name;
			parameters[1].Value = excel_name;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.excel_special_structure model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_excel_special_structure(");
			strSql.Append("chinese_name,property,table_name,excel_name)");
			strSql.Append(" values (");
			strSql.Append("@chinese_name,@property,@table_name,@excel_name)");
			SqlParameter[] parameters = {
					new SqlParameter("@chinese_name", SqlDbType.VarChar,128),
					new SqlParameter("@property", SqlDbType.VarChar,128),
					new SqlParameter("@table_name", SqlDbType.VarChar,50),
					new SqlParameter("@excel_name", SqlDbType.VarChar,50)};
			parameters[0].Value = model.chinese_name;
			parameters[1].Value = model.property;
			parameters[2].Value = model.table_name;
			parameters[3].Value = model.excel_name;

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
		public bool Update(TTG.Model.TTGWeb.excel_special_structure model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_excel_special_structure set ");
			strSql.Append("property=@property,");
			strSql.Append("table_name=@table_name");
			strSql.Append(" where chinese_name=@chinese_name and excel_name=@excel_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@property", SqlDbType.VarChar,128),
					new SqlParameter("@table_name", SqlDbType.VarChar,50),
					new SqlParameter("@chinese_name", SqlDbType.VarChar,128),
					new SqlParameter("@excel_name", SqlDbType.VarChar,50)};
			parameters[0].Value = model.property;
			parameters[1].Value = model.table_name;
			parameters[2].Value = model.chinese_name;
			parameters[3].Value = model.excel_name;

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
		public bool Delete(string chinese_name,string excel_name)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_excel_special_structure ");
			strSql.Append(" where chinese_name=@chinese_name and excel_name=@excel_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@chinese_name", SqlDbType.VarChar,128),
					new SqlParameter("@excel_name", SqlDbType.VarChar,50)			};
			parameters[0].Value = chinese_name;
			parameters[1].Value = excel_name;

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
		public TTG.Model.TTGWeb.excel_special_structure GetModel(string chinese_name,string excel_name)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 chinese_name,property,table_name,excel_name from T_excel_special_structure ");
			strSql.Append(" where chinese_name=@chinese_name and excel_name=@excel_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@chinese_name", SqlDbType.VarChar,128),
					new SqlParameter("@excel_name", SqlDbType.VarChar,50)			};
			parameters[0].Value = chinese_name;
			parameters[1].Value = excel_name;

			TTG.Model.TTGWeb.excel_special_structure model=new TTG.Model.TTGWeb.excel_special_structure();
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
		public TTG.Model.TTGWeb.excel_special_structure DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.excel_special_structure model=new TTG.Model.TTGWeb.excel_special_structure();
			if (row != null)
			{
				if(row["chinese_name"]!=null)
				{
					model.chinese_name=row["chinese_name"].ToString();
				}
				if(row["property"]!=null)
				{
					model.property=row["property"].ToString();
				}
				if(row["table_name"]!=null)
				{
					model.table_name=row["table_name"].ToString();
				}
				if(row["excel_name"]!=null)
				{
					model.excel_name=row["excel_name"].ToString();
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
			strSql.Append("select chinese_name,property,table_name,excel_name ");
			strSql.Append(" FROM T_excel_special_structure ");
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
			strSql.Append(" chinese_name,property,table_name,excel_name ");
			strSql.Append(" FROM T_excel_special_structure ");
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
			strSql.Append("select count(1) FROM T_excel_special_structure ");
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
				strSql.Append("order by T.excel_name desc");
			}
			strSql.Append(")AS Row, T.*  from T_excel_special_structure T ");
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
			parameters[0].Value = "T_excel_special_structure";
			parameters[1].Value = "excel_name";
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

