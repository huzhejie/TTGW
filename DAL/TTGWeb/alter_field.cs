using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:alter_field
	/// </summary>
	public partial class alter_field
	{
		public alter_field()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string field_name,string table_name)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_alter_field");
			strSql.Append(" where field_name=@field_name and table_name=@table_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@field_name", SqlDbType.VarChar,128),
					new SqlParameter("@table_name", SqlDbType.VarChar,128)			};
			parameters[0].Value = field_name;
			parameters[1].Value = table_name;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.alter_field model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_alter_field(");
			strSql.Append("field_name,table_name,alter_field_name,alter_field_unit,alter_type)");
			strSql.Append(" values (");
			strSql.Append("@field_name,@table_name,@alter_field_name,@alter_field_unit,@alter_type)");
			SqlParameter[] parameters = {
					new SqlParameter("@field_name", SqlDbType.VarChar,128),
					new SqlParameter("@table_name", SqlDbType.VarChar,128),
					new SqlParameter("@alter_field_name", SqlDbType.VarChar,128),
					new SqlParameter("@alter_field_unit", SqlDbType.VarChar,20),
					new SqlParameter("@alter_type", SqlDbType.VarChar,20)};
			parameters[0].Value = model.field_name;
			parameters[1].Value = model.table_name;
			parameters[2].Value = model.alter_field_name;
			parameters[3].Value = model.alter_field_unit;
			parameters[4].Value = model.alter_type;

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
		public bool Update(TTG.Model.TTGWeb.alter_field model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_alter_field set ");
			strSql.Append("alter_field_name=@alter_field_name,");
			strSql.Append("alter_field_unit=@alter_field_unit,");
			strSql.Append("alter_type=@alter_type");
			strSql.Append(" where field_name=@field_name and table_name=@table_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@alter_field_name", SqlDbType.VarChar,128),
					new SqlParameter("@alter_field_unit", SqlDbType.VarChar,20),
					new SqlParameter("@alter_type", SqlDbType.VarChar,20),
					new SqlParameter("@field_name", SqlDbType.VarChar,128),
					new SqlParameter("@table_name", SqlDbType.VarChar,128)};
			parameters[0].Value = model.alter_field_name;
			parameters[1].Value = model.alter_field_unit;
			parameters[2].Value = model.alter_type;
			parameters[3].Value = model.field_name;
			parameters[4].Value = model.table_name;

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
		public bool Delete(string field_name,string table_name)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_alter_field ");
			strSql.Append(" where field_name=@field_name and table_name=@table_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@field_name", SqlDbType.VarChar,128),
					new SqlParameter("@table_name", SqlDbType.VarChar,128)			};
			parameters[0].Value = field_name;
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
		public TTG.Model.TTGWeb.alter_field GetModel(string field_name,string table_name)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 field_name,table_name,alter_field_name,alter_field_unit,alter_type from T_alter_field ");
			strSql.Append(" where field_name=@field_name and table_name=@table_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@field_name", SqlDbType.VarChar,128),
					new SqlParameter("@table_name", SqlDbType.VarChar,128)			};
			parameters[0].Value = field_name;
			parameters[1].Value = table_name;

			TTG.Model.TTGWeb.alter_field model=new TTG.Model.TTGWeb.alter_field();
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
		public TTG.Model.TTGWeb.alter_field DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.alter_field model=new TTG.Model.TTGWeb.alter_field();
			if (row != null)
			{
				if(row["field_name"]!=null)
				{
					model.field_name=row["field_name"].ToString();
				}
				if(row["table_name"]!=null)
				{
					model.table_name=row["table_name"].ToString();
				}
				if(row["alter_field_name"]!=null)
				{
					model.alter_field_name=row["alter_field_name"].ToString();
				}
				if(row["alter_field_unit"]!=null)
				{
					model.alter_field_unit=row["alter_field_unit"].ToString();
				}
				if(row["alter_type"]!=null)
				{
					model.alter_type=row["alter_type"].ToString();
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
			strSql.Append("select field_name,table_name,alter_field_name,alter_field_unit,alter_type ");
			strSql.Append(" FROM T_alter_field ");
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
			strSql.Append(" field_name,table_name,alter_field_name,alter_field_unit,alter_type ");
			strSql.Append(" FROM T_alter_field ");
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
			strSql.Append("select count(1) FROM T_alter_field ");
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
			strSql.Append(")AS Row, T.*  from T_alter_field T ");
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
			parameters[0].Value = "T_alter_field";
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
        /// 获取某个表已用的预留字段个数
        /// </summary>
        /// <param name="excel_name"></param>
        /// <returns></returns>
        public int getCount(string table_name)
        {
            string sql = "select count(1) from T_alter_field where table_name = '" + table_name+"'";
            object obj = DbHelperSQL.GetSingle(sql);
            if (obj == null)
            {
                return 0;
            }
            else
                return Convert.ToInt32(obj);
        }
        /// <summary>
        /// 判断一个字段是否存在
        /// </summary>
        /// <param name="fild"></param>
        /// <param name="table_name"></param>
        /// <returns></returns>
        public bool isExist(string fild, string table_name)
        {
            string sql = "select count(1) from T_alter_field where table_name = '" + table_name + "' and field_name = '"+fild+"'";
            int count = Convert.ToInt32(DbHelperSQL.GetSingle(sql));
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		#endregion  ExtensionMethod
	}
}

