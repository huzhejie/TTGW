using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:subproject_project_associate
	/// </summary>
	public partial class subproject_project_associate
	{
		public subproject_project_associate()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string project_id,string subproject_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_subproject_project_associate");
			strSql.Append(" where project_id=@project_id and subproject_id=@subproject_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@subproject_id", SqlDbType.VarChar,20)			};
			parameters[0].Value = project_id;
			parameters[1].Value = subproject_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.subproject_project_associate model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_subproject_project_associate(");
			strSql.Append("project_id,project_name,subproject_name,subproject_id)");
			strSql.Append(" values (");
			strSql.Append("@project_id,@project_name,@subproject_name,@subproject_id)");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@project_name", SqlDbType.VarChar,50),
					new SqlParameter("@subproject_name", SqlDbType.VarChar,50),
					new SqlParameter("@subproject_id", SqlDbType.VarChar,20)};
			parameters[0].Value = model.project_id;
			parameters[1].Value = model.project_name;
			parameters[2].Value = model.subproject_name;
			parameters[3].Value = model.subproject_id;

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
		public bool Update(TTG.Model.TTGWeb.subproject_project_associate model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_subproject_project_associate set ");
			strSql.Append("project_name=@project_name,");
			strSql.Append("subproject_name=@subproject_name");
			strSql.Append(" where project_id=@project_id and subproject_id=@subproject_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_name", SqlDbType.VarChar,50),
					new SqlParameter("@subproject_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@subproject_id", SqlDbType.VarChar,20)};
			parameters[0].Value = model.project_name;
			parameters[1].Value = model.subproject_name;
			parameters[2].Value = model.project_id;
			parameters[3].Value = model.subproject_id;

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
		public bool Delete(string project_id,string subproject_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_subproject_project_associate ");
			strSql.Append(" where project_id=@project_id and subproject_id=@subproject_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@subproject_id", SqlDbType.VarChar,20)			};
			parameters[0].Value = project_id;
			parameters[1].Value = subproject_id;

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
		public TTG.Model.TTGWeb.subproject_project_associate GetModel(string project_id,string subproject_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 project_id,project_name,subproject_name,subproject_id from T_subproject_project_associate ");
			strSql.Append(" where project_id=@project_id and subproject_id=@subproject_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@subproject_id", SqlDbType.VarChar,20)			};
			parameters[0].Value = project_id;
			parameters[1].Value = subproject_id;

			TTG.Model.TTGWeb.subproject_project_associate model=new TTG.Model.TTGWeb.subproject_project_associate();
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
		public TTG.Model.TTGWeb.subproject_project_associate DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.subproject_project_associate model=new TTG.Model.TTGWeb.subproject_project_associate();
			if (row != null)
			{
				if(row["project_id"]!=null)
				{
					model.project_id=row["project_id"].ToString();
				}
				if(row["project_name"]!=null)
				{
					model.project_name=row["project_name"].ToString();
				}
				if(row["subproject_name"]!=null)
				{
					model.subproject_name=row["subproject_name"].ToString();
				}
				if(row["subproject_id"]!=null)
				{
					model.subproject_id=row["subproject_id"].ToString();
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
			strSql.Append("select project_id,project_name,subproject_name,subproject_id ");
			strSql.Append(" FROM T_subproject_project_associate ");
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
			strSql.Append(" project_id,project_name,subproject_name,subproject_id ");
			strSql.Append(" FROM T_subproject_project_associate ");
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
			strSql.Append("select count(1) FROM T_subproject_project_associate ");
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
				strSql.Append("order by T.subproject_id desc");
			}
			strSql.Append(")AS Row, T.*  from T_subproject_project_associate T ");
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
			parameters[0].Value = "T_subproject_project_associate";
			parameters[1].Value = "subproject_id";
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

