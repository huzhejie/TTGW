using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:grandson_project
	/// </summary>
	public partial class grandson_project
	{
		public grandson_project()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.grandson_project model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.grandson_project_id != null)
			{
				strSql1.Append("grandson_project_id,");
				strSql2.Append("'"+model.grandson_project_id+"',");
			}
			if (model.grandson_project_type != null)
			{
				strSql1.Append("grandson_project_type,");
				strSql2.Append("'"+model.grandson_project_type+"',");
			}
			if (model.subproject_id != null)
			{
				strSql1.Append("subproject_id,");
				strSql2.Append("'"+model.subproject_id+"',");
			}
			
			if (model.total_investment != null)
			{
				strSql1.Append("total_investment,");
				strSql2.Append(""+model.total_investment+",");
			}
			if (model.special_founds != null)
			{
				strSql1.Append("special_founds,");
				strSql2.Append(""+model.special_founds+",");
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
			
			if (model.remark != null)
			{
				strSql1.Append("remark,");
				strSql2.Append("'"+model.remark+"',");
			}
			if (model.lock_tables != null)
			{
				strSql1.Append("lock_tables,");
				strSql2.Append(""+model.lock_tables+",");
			}
			if (model.check_status != null)
			{
				strSql1.Append("check_status,");
				strSql2.Append(""+model.check_status+",");
			}
			if (model.fill_time != null)
			{
				strSql1.Append("fill_time,");
				strSql2.Append("'"+model.fill_time+"',");
			}
			strSql.Append("insert into T_grand_project(");
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
		public bool Update(TTG.Model.TTGWeb.grandson_project model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_grand_project set ");
			if (model.grandson_project_id != null)
			{
				strSql.Append("grandson_project_id='"+model.grandson_project_id+"',");
			}
			
			if (model.grandson_project_type != null)
			{
				strSql.Append("grandson_project_type='"+model.grandson_project_type+"',");
			}
			else
			{
				strSql.Append("grandson_project_type= null ,");
			}
			if (model.subproject_id != null)
			{
				strSql.Append("subproject_id='"+model.subproject_id+"',");
			}
			
			if (model.total_investment != null)
			{
				strSql.Append("total_investment="+model.total_investment+",");
			}
			else
			{
				strSql.Append("total_investment= null ,");
			}
			if (model.special_founds != null)
			{
				strSql.Append("special_founds="+model.special_founds+",");
			}
			else
			{
				strSql.Append("special_founds= null ,");
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
			if (model.remark != null)
			{
				strSql.Append("remark='"+model.remark+"',");
			}
			else
			{
				strSql.Append("remark= null ,");
			}
			if (model.lock_tables != null)
			{
				strSql.Append("lock_tables="+model.lock_tables+",");
			}
			if (model.check_status != null)
			{
				strSql.Append("check_status="+model.check_status+",");
			}
			if (model.fill_time != null)
			{
				strSql.Append("fill_time='"+model.fill_time+"',");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where ");
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
		public bool Delete()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_grand_project ");
			strSql.Append(" where " );
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
		public TTG.Model.TTGWeb.grandson_project GetModel()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" grandson_project_id,ggrandson_project_type,subproject_id,total_investment,special_founds,conterpart_founds,other_matching_founds,remark,lock_tables,check_status,fill_time ");
			strSql.Append(" from T_grand_project ");
			strSql.Append(" where " );
			TTG.Model.TTGWeb.grandson_project model=new TTG.Model.TTGWeb.grandson_project();
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
		public TTG.Model.TTGWeb.grandson_project DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.grandson_project model=new TTG.Model.TTGWeb.grandson_project();
			if (row != null)
			{
				if(row["grandson_project_id"]!=null)
				{
					model.grandson_project_id=row["grandson_project_id"].ToString();
				}
				if(row["grandson_project_type"]!=null)
				{
					model.grandson_project_type=row["grandson_project_type"].ToString();
				}
				if(row["subproject_id"]!=null)
				{
					model.subproject_id=row["subproject_id"].ToString();
				}
				
				if(row["total_investment"]!=null && row["total_investment"].ToString()!="")
				{
					model.total_investment=decimal.Parse(row["total_investment"].ToString());
				}
				if(row["special_founds"]!=null && row["special_founds"].ToString()!="")
				{
					model.special_founds=decimal.Parse(row["special_founds"].ToString());
				}
				if(row["conterpart_founds"]!=null && row["conterpart_founds"].ToString()!="")
				{
					model.conterpart_founds=decimal.Parse(row["conterpart_founds"].ToString());
				}
                if (row["other_matching_founds"] != null && row["other_matching_founds"].ToString() != "")
                {
                    model.other_matching_founds = decimal.Parse(row["other_matching_founds"].ToString());
                }
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["fill_time"]!=null && row["fill_time"].ToString()!="")
				{
					model.fill_time=DateTime.Parse(row["fill_time"].ToString());
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
			strSql.Append("select grandson_project_id,grandson_project_type,subproject_id,total_investment,special_founds,conterpart_founds,other_matching_founds,remark,lock_tables,check_status,fill_time ");
			strSql.Append(" FROM T_grand_project ");
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
			strSql.Append(" grandson_project_id,grandson_project_type,subproject_id,total_investment,special_founds,conterpart_founds,other_matching_founds,remark,lock_tables,check_status,fill_time ");
			strSql.Append(" FROM T_grand_project ");
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
			strSql.Append("select count(1) FROM T_grand_project ");
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
			strSql.Append(")AS Row, T.*  from T_grand_project T ");
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
        /// 获取子项目id为subproject_id的项目的孙项目个数
        /// </summary>
        /// <param name="subproject_id">子项目id</param>
        /// <returns>孙项目个数</returns>
        public int GetProjectCount(string subproject_id)
        {
            SqlParameter parameter = new SqlParameter("@subproject", SqlDbType.VarChar, 50);
            parameter.Value = subproject_id;
            string sql = "select count(distinct grandson_project_id) from T_grand_project where subproject_id = @subproject";
            return Convert.ToInt32(DbHelperSQL.GetSingle(sql, parameter));
        }
		#endregion  MethodEx
	}
}

