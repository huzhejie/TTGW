using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_problem_finished_contrast_info
	/// </summary>
	public partial class community_problem_finished_contrast_info
	{
		public community_problem_finished_contrast_info()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.community_problem_finished_contrast_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_problem_finished_contrast_info(");
			strSql.Append("community_problem_content,community_problem_unit,community_finish_content,community_finish_content_unit,check_status,tciunset1,tciunset2,tciunset3,tciunset4,lock_tables,project_name)");
			strSql.Append(" values (");
			strSql.Append("@community_problem_content,@community_problem_unit,@community_finish_content,@community_finish_content_unit,@check_status,@tciunset1,@tciunset2,@tciunset3,@tciunset4,@lock_tables,@project_name)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_problem_content", SqlDbType.VarChar,128),
					new SqlParameter("@community_problem_unit", SqlDbType.VarChar,20),
					new SqlParameter("@community_finish_content", SqlDbType.VarChar,128),
					new SqlParameter("@community_finish_content_unit", SqlDbType.VarChar,20),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@project_name", SqlDbType.VarChar,50)};
			parameters[0].Value = model.community_problem_content;
			parameters[1].Value = model.community_problem_unit;
			parameters[2].Value = model.community_finish_content;
			parameters[3].Value = model.community_finish_content_unit;
			parameters[4].Value = model.check_status;
			parameters[5].Value = model.tciunset1;
			parameters[6].Value = model.tciunset2;
			parameters[7].Value = model.tciunset3;
			parameters[8].Value = model.tciunset4;
			parameters[9].Value = model.lock_tables;
			parameters[10].Value = model.project_name;

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
		public bool Update(TTG.Model.TTGWeb.community_problem_finished_contrast_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_problem_finished_contrast_info set ");
			strSql.Append("community_problem_content=@community_problem_content,");
			strSql.Append("community_problem_unit=@community_problem_unit,");
			strSql.Append("community_finish_content=@community_finish_content,");
			strSql.Append("community_finish_content_unit=@community_finish_content_unit,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("tciunset1=@tciunset1,");
			strSql.Append("tciunset2=@tciunset2,");
			strSql.Append("tciunset3=@tciunset3,");
			strSql.Append("tciunset4=@tciunset4,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("project_name=@project_name");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_problem_content", SqlDbType.VarChar,128),
					new SqlParameter("@community_problem_unit", SqlDbType.VarChar,20),
					new SqlParameter("@community_finish_content", SqlDbType.VarChar,128),
					new SqlParameter("@community_finish_content_unit", SqlDbType.VarChar,20),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@project_name", SqlDbType.VarChar,50)};
			parameters[0].Value = model.community_problem_content;
			parameters[1].Value = model.community_problem_unit;
			parameters[2].Value = model.community_finish_content;
			parameters[3].Value = model.community_finish_content_unit;
			parameters[4].Value = model.check_status;
			parameters[5].Value = model.tciunset1;
			parameters[6].Value = model.tciunset2;
			parameters[7].Value = model.tciunset3;
			parameters[8].Value = model.tciunset4;
			parameters[9].Value = model.lock_tables;
			parameters[10].Value = model.project_name;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_community_problem_finished_contrast_info ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		public TTG.Model.TTGWeb.community_problem_finished_contrast_info GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_problem_content,community_problem_unit,community_finish_content,community_finish_content_unit,check_status,tciunset1,tciunset2,tciunset3,tciunset4,lock_tables,project_name from T_community_problem_finished_contrast_info ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			TTG.Model.TTGWeb.community_problem_finished_contrast_info model=new TTG.Model.TTGWeb.community_problem_finished_contrast_info();
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
		public TTG.Model.TTGWeb.community_problem_finished_contrast_info DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_problem_finished_contrast_info model=new TTG.Model.TTGWeb.community_problem_finished_contrast_info();
			if (row != null)
			{
				if(row["community_problem_content"]!=null)
				{
					model.community_problem_content=row["community_problem_content"].ToString();
				}
				if(row["community_problem_unit"]!=null)
				{
					model.community_problem_unit=row["community_problem_unit"].ToString();
				}
				if(row["community_finish_content"]!=null)
				{
					model.community_finish_content=row["community_finish_content"].ToString();
				}
				if(row["community_finish_content_unit"]!=null)
				{
					model.community_finish_content_unit=row["community_finish_content_unit"].ToString();
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["tciunset1"]!=null)
				{
					model.tciunset1=row["tciunset1"].ToString();
				}
				if(row["tciunset2"]!=null)
				{
					model.tciunset2=row["tciunset2"].ToString();
				}
				if(row["tciunset3"]!=null)
				{
					model.tciunset3=row["tciunset3"].ToString();
				}
				if(row["tciunset4"]!=null)
				{
					model.tciunset4=row["tciunset4"].ToString();
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["project_name"]!=null)
				{
					model.project_name=row["project_name"].ToString();
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
			strSql.Append("select community_problem_content,community_problem_unit,community_finish_content,community_finish_content_unit,check_status,tciunset1,tciunset2,tciunset3,tciunset4,lock_tables,project_name ");
			strSql.Append(" FROM T_community_problem_finished_contrast_info ");
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
			strSql.Append(" community_problem_content,community_problem_unit,community_finish_content,community_finish_content_unit,check_status,tciunset1,tciunset2,tciunset3,tciunset4,lock_tables,project_name ");
			strSql.Append(" FROM T_community_problem_finished_contrast_info ");
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
			strSql.Append("select count(1) FROM T_community_problem_finished_contrast_info ");
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
				strSql.Append("order by T.project_name desc");
			}
			strSql.Append(")AS Row, T.*  from T_community_problem_finished_contrast_info T ");
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
			parameters[0].Value = "T_community_problem_finished_contrast_info";
			parameters[1].Value = "project_name";
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

