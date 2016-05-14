using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:subsequent_project
	/// </summary>
	public partial class subsequent_project
	{
		public subsequent_project()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "T_subsequent_project"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id,DateTime fill_time)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_subsequent_project");
			strSql.Append(" where id="+id+" and fill_time='"+fill_time+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.subsequent_project model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.project_id != null)
			{
				strSql1.Append("project_id,");
				strSql2.Append("'"+model.project_id+"',");
			}
			if (model.county_name != null)
			{
				strSql1.Append("county_name,");
				strSql2.Append("'"+model.county_name+"',");
			}
			if (model.after_id != null)
			{
				strSql1.Append("after_id,");
				strSql2.Append("'"+model.after_id+"',");
			}
			if (model.project_name != null)
			{
				strSql1.Append("project_name,");
				strSql2.Append("'"+model.project_name+"',");
			}
			if (model.year != null)
			{
				strSql1.Append("year,");
				strSql2.Append(""+model.year+",");
			}
			if (model.total_investment != null)
			{
				strSql1.Append("total_investment,");
				strSql2.Append(""+model.total_investment+",");
			}
			if (model.follow_up_special_founds != null)
			{
				strSql1.Append("follow_up_special_founds,");
				strSql2.Append(""+model.follow_up_special_founds+",");
			}
			if (model.conterpart_founds != null)
			{
				strSql1.Append("conterpart_founds,");
				strSql2.Append(""+model.conterpart_founds+",");
			}
			if (model.other_matching_founds != null)
			{
				strSql1.Append("other_matching_founds,");
				strSql2.Append(""+model.other_matching_founds+",");
			}
			if (model.apply_for_founds != null)
			{
				strSql1.Append("apply_for_founds,");
				strSql2.Append(""+model.apply_for_founds+",");
			}
			if (model.plan_implementation_date != null)
			{
				strSql1.Append("plan_implementation_date,");
				strSql2.Append(""+model.plan_implementation_date+",");
			}
			if (model.fill_time != null)
			{
				strSql1.Append("fill_time,");
				strSql2.Append("'"+model.fill_time+"',");
			}
			if (model.check_status != null)
			{
				strSql1.Append("check_status,");
				strSql2.Append(""+model.check_status+",");
			}
			if (model.lock_tables != null)
			{
				strSql1.Append("lock_tables,");
				strSql2.Append(""+model.lock_tables+",");
			}
			if (model.unset1 != null)
			{
				strSql1.Append("unset1,");
				strSql2.Append("'"+model.unset1+"',");
			}
			if (model.unset2 != null)
			{
				strSql1.Append("unset2,");
				strSql2.Append("'"+model.unset2+"',");
			}
			if (model.unset3 != null)
			{
				strSql1.Append("unset3,");
				strSql2.Append("'"+model.unset3+"',");
			}
			if (model.unset4 != null)
			{
				strSql1.Append("unset4,");
				strSql2.Append("'"+model.unset4+"',");
			}
			if (model.unset5 != null)
			{
				strSql1.Append("unset5,");
				strSql2.Append("'"+model.unset5+"',");
			}
			if (model.unset6 != null)
			{
				strSql1.Append("unset6,");
				strSql2.Append("'"+model.unset6+"',");
			}
			if (model.unset7 != null)
			{
				strSql1.Append("unset7,");
				strSql2.Append("'"+model.unset7+"',");
			}
			strSql.Append("insert into T_subsequent_project(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
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
		/// 更新一条数据
		/// </summary>
		public bool Update(TTG.Model.TTGWeb.subsequent_project model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_subsequent_project set ");
			if (model.project_id != null)
			{
				strSql.Append("project_id='"+model.project_id+"',");
			}
			if (model.county_name != null)
			{
				strSql.Append("county_name='"+model.county_name+"',");
			}
			if (model.after_id != null)
			{
				strSql.Append("after_id='"+model.after_id+"',");
			}
			else
			{
				strSql.Append("after_id= null ,");
			}
			if (model.project_name != null)
			{
				strSql.Append("project_name='"+model.project_name+"',");
			}
			else
			{
				strSql.Append("project_name= null ,");
			}
			if (model.year != null)
			{
				strSql.Append("year="+model.year+",");
			}
			if (model.total_investment != null)
			{
				strSql.Append("total_investment="+model.total_investment+",");
			}
			else
			{
				strSql.Append("total_investment= null ,");
			}
			if (model.follow_up_special_founds != null)
			{
				strSql.Append("follow_up_special_founds="+model.follow_up_special_founds+",");
			}
			else
			{
				strSql.Append("follow_up_special_founds= null ,");
			}
			if (model.conterpart_founds != null)
			{
				strSql.Append("conterpart_founds="+model.conterpart_founds+",");
			}
			else
			{
				strSql.Append("conterpart_founds= null ,");
			}
			if (model.other_matching_founds != null)
			{
				strSql.Append("other_matching_founds="+model.other_matching_founds+",");
			}
			else
			{
				strSql.Append("other_matching_founds= null ,");
			}
			if (model.apply_for_founds != null)
			{
				strSql.Append("apply_for_founds="+model.apply_for_founds+",");
			}
			else
			{
				strSql.Append("apply_for_founds= null ,");
			}
			if (model.plan_implementation_date != null)
			{
				strSql.Append("plan_implementation_date="+model.plan_implementation_date+",");
			}
			else
			{
				strSql.Append("plan_implementation_date= null ,");
			}
			if (model.check_status != null)
			{
				strSql.Append("check_status="+model.check_status+",");
			}
			if (model.lock_tables != null)
			{
				strSql.Append("lock_tables="+model.lock_tables+",");
			}
			if (model.unset1 != null)
			{
				strSql.Append("unset1='"+model.unset1+"',");
			}
			else
			{
				strSql.Append("unset1= null ,");
			}
			if (model.unset2 != null)
			{
				strSql.Append("unset2='"+model.unset2+"',");
			}
			else
			{
				strSql.Append("unset2= null ,");
			}
			if (model.unset3 != null)
			{
				strSql.Append("unset3='"+model.unset3+"',");
			}
			else
			{
				strSql.Append("unset3= null ,");
			}
			if (model.unset4 != null)
			{
				strSql.Append("unset4='"+model.unset4+"',");
			}
			else
			{
				strSql.Append("unset4= null ,");
			}
			if (model.unset5 != null)
			{
				strSql.Append("unset5='"+model.unset5+"',");
			}
			else
			{
				strSql.Append("unset5= null ,");
			}
			if (model.unset6 != null)
			{
				strSql.Append("unset6='"+model.unset6+"',");
			}
			else
			{
				strSql.Append("unset6= null ,");
			}
			if (model.unset7 != null)
			{
				strSql.Append("unset7='"+model.unset7+"',");
			}
			else
			{
				strSql.Append("unset7= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where id="+ model.id+" and fill_time='"+ model.fill_time+"' ");
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
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
		public bool Delete(int id,DateTime fill_time)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_subsequent_project ");
			strSql.Append(" where id="+id+" and fill_time='"+fill_time+"' " );
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
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
		public TTG.Model.TTGWeb.subsequent_project GetModel(int id,DateTime fill_time)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" id,project_id,county_name,after_id,project_name,year,total_investment,follow_up_special_founds,conterpart_founds,other_matching_founds,apply_for_founds,plan_implementation_date,fill_time,check_status,lock_tables,unset1,unset2,unset3,unset4,unset5,unset6,unset7 ");
			strSql.Append(" from T_subsequent_project ");
			strSql.Append(" where id="+id+" and fill_time='"+fill_time+"' " );
			TTG.Model.TTGWeb.subsequent_project model=new TTG.Model.TTGWeb.subsequent_project();
			DataSet ds=DbHelperSQL.Query(strSql.ToString());
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
		public TTG.Model.TTGWeb.subsequent_project DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.subsequent_project model=new TTG.Model.TTGWeb.subsequent_project();
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
				if(row["after_id"]!=null)
				{
					model.after_id=row["after_id"].ToString();
				}
				if(row["project_name"]!=null)
				{
					model.project_name=row["project_name"].ToString();
				}
				if(row["year"]!=null && row["year"].ToString()!="")
				{
					model.year=int.Parse(row["year"].ToString());
				}
				if(row["total_investment"]!=null && row["total_investment"].ToString()!="")
				{
					model.total_investment=decimal.Parse(row["total_investment"].ToString());
				}
				if(row["follow_up_special_founds"]!=null && row["follow_up_special_founds"].ToString()!="")
				{
					model.follow_up_special_founds=decimal.Parse(row["follow_up_special_founds"].ToString());
				}
				if(row["conterpart_founds"]!=null && row["conterpart_founds"].ToString()!="")
				{
					model.conterpart_founds=decimal.Parse(row["conterpart_founds"].ToString());
				}
				if(row["other_matching_founds"]!=null && row["other_matching_founds"].ToString()!="")
				{
					model.other_matching_founds=decimal.Parse(row["other_matching_founds"].ToString());
				}
				if(row["apply_for_founds"]!=null && row["apply_for_founds"].ToString()!="")
				{
					model.apply_for_founds=decimal.Parse(row["apply_for_founds"].ToString());
				}
				if(row["plan_implementation_date"]!=null && row["plan_implementation_date"].ToString()!="")
				{
					model.plan_implementation_date=int.Parse(row["plan_implementation_date"].ToString());
				}
				if(row["fill_time"]!=null && row["fill_time"].ToString()!="")
				{
					model.fill_time=DateTime.Parse(row["fill_time"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["unset1"]!=null)
				{
					model.unset1=row["unset1"].ToString();
				}
				if(row["unset2"]!=null)
				{
					model.unset2=row["unset2"].ToString();
				}
				if(row["unset3"]!=null)
				{
					model.unset3=row["unset3"].ToString();
				}
				if(row["unset4"]!=null)
				{
					model.unset4=row["unset4"].ToString();
				}
				if(row["unset5"]!=null)
				{
					model.unset5=row["unset5"].ToString();
				}
				if(row["unset6"]!=null)
				{
					model.unset6=row["unset6"].ToString();
				}
				if(row["unset7"]!=null)
				{
					model.unset7=row["unset7"].ToString();
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
			strSql.Append("select id,project_id,county_name,after_id,project_name,year,total_investment,follow_up_special_founds,conterpart_founds,other_matching_founds,apply_for_founds,plan_implementation_date,fill_time,check_status,lock_tables,unset1,unset2,unset3,unset4,unset5,unset6,unset7 ");
			strSql.Append(" FROM T_subsequent_project ");
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
			strSql.Append(" id,project_id,county_name,after_id,project_name,year,total_investment,follow_up_special_founds,conterpart_founds,other_matching_founds,apply_for_founds,plan_implementation_date,fill_time,check_status,lock_tables,unset1,unset2,unset3,unset4,unset5,unset6,unset7 ");
			strSql.Append(" FROM T_subsequent_project ");
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
			strSql.Append("select count(1) FROM T_subsequent_project ");
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
				strSql.Append("order by T.fill_time desc");
			}
			strSql.Append(")AS Row, T.*  from T_subsequent_project T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method
		#region  MethodEx

        /// <summary>
        /// 获取county县在year年份的项目数量
        /// </summary>
        /// <param name="county">区县名</param>
        /// <param name="year">项目年份</param>
        /// <returns>项目数目</returns>
        public int GetProjectCount(string county, int year)
        {
            SqlParameter[] parameters = {
                                            new SqlParameter("@county", SqlDbType.VarChar, 50),
                                            new SqlParameter("@year", SqlDbType.Int, 4)
                                        };
            parameters[0].Value = county;
            parameters[1].Value = year;
            string sql = "select count(distinct project_id) from T_previously_special_project where county_name = @county and year_time = @year";
            return Convert.ToInt32(DbHelperSQL.GetSingle(sql, parameters));
        }
		#endregion  MethodEx
	}
}

