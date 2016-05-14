using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:subproject_new
	/// </summary>
	public partial class subproject_new
	{
		public subproject_new()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.subproject_new model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.subproject_id != null)
			{
				strSql1.Append("subproject_id,");
				strSql2.Append("'"+model.subproject_id+"',");
			}
            if (model.project_id != null)
            {
                strSql1.Append("project_id,");
                strSql2.Append("'" + model.project_id + "',");
            }
			if (model.subproject_name != null)
			{
				strSql1.Append("subproject_name,");
				strSql2.Append("'"+model.subproject_name+"',");
			}
            if (model.involve_community != null)
			{
				strSql1.Append("involve_community,");
                strSql2.Append("'" + model.involve_community + "',");
			}
            if (model.project_owner != null)
            {
                strSql1.Append("project_owner,");
                strSql2.Append("'" + model.project_owner + "',");
            }
            if(model.start_date !=null)
            {
                strSql1.Append("start_date,");
                strSql2.Append("'"+model.start_date+"',");
            }
            if (model.finish_date != null)
            {
                strSql1.Append("finish_date,");
                strSql2.Append("'" + model.finish_date + "',");
            }
            if (model.main_construct_content != null)
            {
                strSql1.Append("main_construct_content,");
                strSql2.Append("'" + model.main_construct_content + "',");
            }
            if (model.project_community_description != null)
            {
                strSql1.Append("project_community_description,");
                strSql2.Append("'" + model.project_community_description + "',");
            }
            if (model.radial_project != null)
            {
                strSql1.Append("radial_project,");
                strSql2.Append("'" + model.radial_project + "',");
            }
			if (model.fill_time != null)
			{
				strSql1.Append("fill_time,");
				strSql2.Append("'"+model.fill_time+"',");
			}
			strSql.Append("insert into T_subproject_new(");
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
		public bool Update(TTG.Model.TTGWeb.subproject_new model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_subproject_new set ");
			if (model.subproject_id != null)
			{
				strSql.Append("subproject_id='"+model.subproject_id+"',");
			}
			if (model.subproject_name != null)
			{
				strSql.Append("subproject_name='"+model.subproject_name+"',");
			}
			else
			{
				strSql.Append("subproject_name= null ,");
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
			strSql.Append("delete from T_subproject_new ");
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
		public TTG.Model.TTGWeb.subproject_new GetModel()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" subproject_id,subproject_name,project_id,fill_time ");
			strSql.Append(" from T_subproject_new ");
			strSql.Append(" where " );
			TTG.Model.TTGWeb.subproject_new model=new TTG.Model.TTGWeb.subproject_new();
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
		public TTG.Model.TTGWeb.subproject_new DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.subproject_new model=new TTG.Model.TTGWeb.subproject_new();
			if (row != null)
			{
				if(row["subproject_id"]!=null)
				{
					model.subproject_id=row["subproject_id"].ToString();
				}
				if(row["subproject_name"]!=null)
				{
					model.subproject_name=row["subproject_name"].ToString();
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
			strSql.Append("select subproject_id,subproject_name,project_id,fill_time ");
			strSql.Append(" FROM T_subproject_new ");
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
			strSql.Append(" subproject_id,subproject_name,project_id,fill_time ");
			strSql.Append(" FROM T_subproject_new ");
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
			strSql.Append("select count(1) FROM T_subproject_new ");
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
			strSql.Append(")AS Row, T.*  from T_subproject_new T ");
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
        /// 获取项目编号为project_id的项目的子项目个数
        /// </summary>
        /// <param name="project_id">项目编号</param>
        /// <returns>子项目编号</returns>
        public int GetProjectCount(string project_id)
        {
            SqlParameter parameter = new SqlParameter("@project", SqlDbType.VarChar, 50);
            parameter.Value = project_id;
            string sql = "select count(distinct subproject_id) from T_subproject_new where project_id = @project";
            return Convert.ToInt32(DbHelperSQL.GetSingle(sql, parameter));
        }
		#endregion  MethodEx
	}
}

