using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:counterpart_and_other_project
	/// </summary>
	public partial class counterpart_and_other_project
	{
		public counterpart_and_other_project()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "T_counterpart_and_other_project"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(DateTime fill_time,int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_counterpart_and_other_project");
			strSql.Append(" where fill_time=@fill_time and id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@fill_time", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = fill_time;
			parameters[1].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(TTG.Model.TTGWeb.counterpart_and_other_project model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_counterpart_and_other_project(");
			strSql.Append("project_id,county_name,project_name,is_counterpart_project,year,project_type,total_investment,counterpart_founds,other_matching_founds,start_date,finish_date,finish_accept_date,remark,lock_table,check_status,fill_time,radial_project)");
			strSql.Append(" values (");
			strSql.Append("@project_id,@county_name,@project_name,@is_counterpart_project,@year,@project_type,@total_investment,@counterpart_founds,@other_matching_founds,@start_date,@finish_date,@finish_accept_date,@remark,@lock_table,@check_status,@fill_time,@radial_project)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,50),
					new SqlParameter("@county_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_name", SqlDbType.VarChar,50),
					new SqlParameter("@is_counterpart_project", SqlDbType.VarChar,20),
					new SqlParameter("@year", SqlDbType.Int,4),
					new SqlParameter("@project_type", SqlDbType.VarChar,50),
					new SqlParameter("@total_investment", SqlDbType.Float,8),
					new SqlParameter("@counterpart_founds", SqlDbType.Float,8),
					new SqlParameter("@other_matching_founds", SqlDbType.Float,8),
					new SqlParameter("@start_date", SqlDbType.DateTime),
					new SqlParameter("@finish_date", SqlDbType.DateTime),
					new SqlParameter("@finish_accept_date", SqlDbType.DateTime),
					new SqlParameter("@remark", SqlDbType.NVarChar,200),
					new SqlParameter("@lock_table", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@fill_time", SqlDbType.DateTime),
                    new SqlParameter("@radial_project",SqlDbType.VarChar,20)};
			parameters[0].Value = model.project_id;
			parameters[1].Value = model.county_name;
			parameters[2].Value = model.project_name;
			parameters[3].Value = model.is_counterpart_project;
			parameters[4].Value = model.year;
			parameters[5].Value = model.project_type;
			parameters[6].Value = model.total_investment;
			parameters[7].Value = model.counterpart_founds;
			parameters[8].Value = model.other_matching_founds;
			parameters[9].Value = model.start_date;
			parameters[10].Value = model.finish_date;
			parameters[11].Value = model.finish_accept_date;
			parameters[12].Value = model.remark;
			parameters[13].Value = model.lock_table;
			parameters[14].Value = model.check_status;
			parameters[15].Value = model.fill_time;
            parameters[16].Value = model.radial_project;

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
		public bool Update(TTG.Model.TTGWeb.counterpart_and_other_project model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_counterpart_and_other_project set ");
			strSql.Append("project_id=@project_id,");
			strSql.Append("county_name=@county_name,");
			strSql.Append("project_name=@project_name,");
			strSql.Append("is_counterpart_project=@is_counterpart_project,");
			strSql.Append("year=@year,");
			strSql.Append("project_type=@project_type,");
			strSql.Append("total_investment=@total_investment,");
			strSql.Append("counterpart_founds=@counterpart_founds,");
			strSql.Append("other_matching_founds=@other_matching_founds,");
			strSql.Append("start_date=@start_date,");
			strSql.Append("finish_date=@finish_date,");
			strSql.Append("finish_accept_date=@finish_accept_date,");
			strSql.Append("remark=@remark,");
			strSql.Append("lock_table=@lock_table,");
			strSql.Append("check_status=@check_status");
            strSql.Append("radial_project = @radial_project");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,50),
					new SqlParameter("@county_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_name", SqlDbType.VarChar,50),
					new SqlParameter("@is_counterpart_project", SqlDbType.VarChar,20),
					new SqlParameter("@year", SqlDbType.Int,4),
					new SqlParameter("@project_type", SqlDbType.VarChar,50),
					new SqlParameter("@total_investment", SqlDbType.Float,8),
					new SqlParameter("@counterpart_founds", SqlDbType.Float,8),
					new SqlParameter("@other_matching_founds", SqlDbType.Float,8),
					new SqlParameter("@start_date", SqlDbType.DateTime),
					new SqlParameter("@finish_date", SqlDbType.DateTime),
					new SqlParameter("@finish_accept_date", SqlDbType.DateTime),
					new SqlParameter("@remark", SqlDbType.NVarChar,200),
					new SqlParameter("@lock_table", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@fill_time", SqlDbType.DateTime),
                    new SqlParameter("@radial_project",SqlDbType.VarChar,20)
                           };
            parameters[0].Value = model.project_id;
            parameters[1].Value = model.county_name;
            parameters[2].Value = model.project_name;
            parameters[3].Value = model.is_counterpart_project;
            parameters[4].Value = model.year;
            parameters[5].Value = model.project_type;
            parameters[6].Value = model.total_investment;
            parameters[7].Value = model.counterpart_founds;
            parameters[8].Value = model.other_matching_founds;
            parameters[9].Value = model.start_date;
            parameters[10].Value = model.finish_date;
            parameters[11].Value = model.finish_accept_date;
            parameters[12].Value = model.remark;
            parameters[13].Value = model.lock_table;
            parameters[14].Value = model.check_status;
            parameters[15].Value = model.fill_time;
            parameters[16].Value = model.radial_project;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_counterpart_and_other_project ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

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
		public bool Delete(DateTime fill_time,int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_counterpart_and_other_project ");
			strSql.Append(" where fill_time=@fill_time and id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@fill_time", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = fill_time;
			parameters[1].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_counterpart_and_other_project ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public TTG.Model.TTGWeb.counterpart_and_other_project GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,project_id,county_name,project_name,is_counterpart_project,year,project_type,total_investment,counterpart_founds,other_matching_founds,start_date,finish_date,finish_accept_date,remark,lock_table,check_status,fill_time,radial_project from T_counterpart_and_other_project ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			TTG.Model.TTGWeb.counterpart_and_other_project model=new TTG.Model.TTGWeb.counterpart_and_other_project();
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
		public TTG.Model.TTGWeb.counterpart_and_other_project DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.counterpart_and_other_project model=new TTG.Model.TTGWeb.counterpart_and_other_project();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["project_id"]!=null)
				{
					model.project_id=row["project_id"].ToString();
				}
				if(row["county_name"]!=null)
				{
					model.county_name=row["county_name"].ToString();
				}
				if(row["project_name"]!=null)
				{
					model.project_name=row["project_name"].ToString();
				}
				if(row["is_counterpart_project"]!=null)
				{
					model.is_counterpart_project=row["is_counterpart_project"].ToString();
				}
				if(row["year"]!=null && row["year"].ToString()!="")
				{
					model.year=int.Parse(row["year"].ToString());
				}
				if(row["project_type"]!=null)
				{
					model.project_type=row["project_type"].ToString();
				}
				if(row["total_investment"]!=null && row["total_investment"].ToString()!="")
				{
					model.total_investment=decimal.Parse(row["total_investment"].ToString());
				}
				if(row["counterpart_founds"]!=null && row["counterpart_founds"].ToString()!="")
				{
					model.counterpart_founds=decimal.Parse(row["counterpart_founds"].ToString());
				}
				if(row["other_matching_founds"]!=null && row["other_matching_founds"].ToString()!="")
				{
					model.other_matching_founds=decimal.Parse(row["other_matching_founds"].ToString());
				}
				if(row["start_date"]!=null && row["start_date"].ToString()!="")
				{
					model.start_date=DateTime.Parse(row["start_date"].ToString());
				}
				if(row["finish_date"]!=null && row["finish_date"].ToString()!="")
				{
					model.finish_date=DateTime.Parse(row["finish_date"].ToString());
				}
				
				if(row["finish_accept_date"]!=null && row["finish_accept_date"].ToString()!="")
				{
					model.finish_accept_date=DateTime.Parse(row["finish_accept_date"].ToString());
				}
				
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["lock_table"]!=null && row["lock_table"].ToString()!="")
				{
					model.lock_table=int.Parse(row["lock_table"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["fill_time"]!=null && row["fill_time"].ToString()!="")
				{
					model.fill_time=DateTime.Parse(row["fill_time"].ToString());
				}
                if (row["radial_project"] != null)
                {
                    model.is_counterpart_project = row["radial_project"].ToString();
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
			strSql.Append("select id,project_id,county_name,project_name,is_counterpart_project,year,project_type,total_investment,counterpart_founds,other_matching_founds,start_date,finish_date,finish_accept_date,remark,lock_table,check_status,fill_time,radial_project ");
			strSql.Append(" FROM T_counterpart_and_other_project ");
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
			strSql.Append(" id,project_id,county_name,project_name,is_counterpart_project,year,project_type,total_investment,counterpart_founds,other_matching_founds,start_date,finish_date,finish_accept_date,remark,lock_table,check_status,fill_time,radial_project ");
			strSql.Append(" FROM T_counterpart_and_other_project ");
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
			strSql.Append("select count(1) FROM T_counterpart_and_other_project ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from T_counterpart_and_other_project T ");
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
			parameters[0].Value = "T_counterpart_and_other_project";
			parameters[1].Value = "id";
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
        /// 获取符合特定条件的项目个数
        /// </summary>
        /// <param name="county">区县名</param>
        /// <param name="counterpart">是否对口支援项目</param>
        /// <param name="year">年份</param>
        /// <returns>项目个数</returns>
        public int GetProjectCount(string county, string counterpart, int year)
        {
            SqlParameter[] parameters = {
                                            new SqlParameter("@county", SqlDbType.VarChar, 50),
                                            new SqlParameter("@counterpart", SqlDbType.VarChar, 20),
                                            new SqlParameter("@year", SqlDbType.Int,4)
                                        };
            parameters[0].Value = county;
            parameters[1].Value = counterpart;
            parameters[2].Value = year;
            string sql = "select count(distinct project_id) from T_counterpart_and_other_project where county_name = @county and is_counterpart_project = @counterpart and year=@year";
            return Convert.ToInt32(DbHelperSQL.GetSingle(sql, parameters));
        }
		#endregion  ExtensionMethod
	}
}

