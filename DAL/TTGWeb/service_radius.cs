using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:service_radius
	/// </summary>
	public partial class service_radius
	{
		public service_radius()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string facilities_type,string facilities_level)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_service_radius");
			strSql.Append(" where facilities_type=@facilities_type and facilities_level=@facilities_level ");
			SqlParameter[] parameters = {
					new SqlParameter("@facilities_type", SqlDbType.VarChar,50),
					new SqlParameter("@facilities_level", SqlDbType.VarChar,20)			};
			parameters[0].Value = facilities_type;
			parameters[1].Value = facilities_level;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.service_radius model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_service_radius(");
			strSql.Append("facilities_type,facilities_level,service_radius_value)");
			strSql.Append(" values (");
			strSql.Append("@facilities_type,@facilities_level,@service_radius_value)");
			SqlParameter[] parameters = {
					new SqlParameter("@facilities_type", SqlDbType.VarChar,50),
					new SqlParameter("@facilities_level", SqlDbType.VarChar,20),
					new SqlParameter("@service_radius_value", SqlDbType.Float,8)};
			parameters[0].Value = model.facilities_type;
			parameters[1].Value = model.facilities_level;
			parameters[2].Value = model.service_radius_value;

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
		public bool Update(TTG.Model.TTGWeb.service_radius model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_service_radius set ");
			strSql.Append("service_radius_value=@service_radius_value");
			strSql.Append(" where facilities_type=@facilities_type and facilities_level=@facilities_level ");
			SqlParameter[] parameters = {
					new SqlParameter("@service_radius_value", SqlDbType.Float,8),
					new SqlParameter("@facilities_type", SqlDbType.VarChar,50),
					new SqlParameter("@facilities_level", SqlDbType.VarChar,20)};
			parameters[0].Value = model.service_radius_value;
			parameters[1].Value = model.facilities_type;
			parameters[2].Value = model.facilities_level;

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
		public bool Delete(string facilities_type,string facilities_level)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_service_radius ");
			strSql.Append(" where facilities_type=@facilities_type and facilities_level=@facilities_level ");
			SqlParameter[] parameters = {
					new SqlParameter("@facilities_type", SqlDbType.VarChar,50),
					new SqlParameter("@facilities_level", SqlDbType.VarChar,20)			};
			parameters[0].Value = facilities_type;
			parameters[1].Value = facilities_level;

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
		public TTG.Model.TTGWeb.service_radius GetModel(string facilities_type,string facilities_level)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 facilities_type,facilities_level,service_radius_value from T_service_radius ");
			strSql.Append(" where facilities_type=@facilities_type and facilities_level=@facilities_level ");
			SqlParameter[] parameters = {
					new SqlParameter("@facilities_type", SqlDbType.VarChar,50),
					new SqlParameter("@facilities_level", SqlDbType.VarChar,20)			};
			parameters[0].Value = facilities_type;
			parameters[1].Value = facilities_level;

			TTG.Model.TTGWeb.service_radius model=new TTG.Model.TTGWeb.service_radius();
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
		public TTG.Model.TTGWeb.service_radius DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.service_radius model=new TTG.Model.TTGWeb.service_radius();
			if (row != null)
			{
				if(row["facilities_type"]!=null)
				{
					model.facilities_type=row["facilities_type"].ToString();
				}
				if(row["facilities_level"]!=null)
				{
					model.facilities_level=row["facilities_level"].ToString();
				}
				if(row["service_radius_value"]!=null && row["service_radius_value"].ToString()!="")
				{
					model.service_radius_value=decimal.Parse(row["service_radius_value"].ToString());
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
			strSql.Append("select facilities_type,facilities_level,service_radius_value ");
			strSql.Append(" FROM T_service_radius ");
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
			strSql.Append(" facilities_type,facilities_level,service_radius_value ");
			strSql.Append(" FROM T_service_radius ");
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
			strSql.Append("select count(1) FROM T_service_radius ");
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
				strSql.Append("order by T.facilities_level desc");
			}
			strSql.Append(")AS Row, T.*  from T_service_radius T ");
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
			parameters[0].Value = "T_service_radius";
			parameters[1].Value = "facilities_level";
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

