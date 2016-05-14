using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:project_capital
	/// </summary>
	public partial class project_capital
	{
		public project_capital()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string project_id,string furnished_type,DateTime time)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_project_capital");
			strSql.Append(" where project_id=@project_id and furnished_type=@furnished_type and time=@time ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@furnished_type", SqlDbType.VarChar,20),
					new SqlParameter("@time", SqlDbType.Date,3)			};
			parameters[0].Value = project_id;
			parameters[1].Value = furnished_type;
			parameters[2].Value = time;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.project_capital model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_project_capital(");
			strSql.Append("project_id,project_name,furnished_type,total_investment,TTG_follow_up_work_approved_special_subsidies,plan_counterparts_support_funds,other_matching_funds,other_funds,time,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,check_status,lock_tables)");
			strSql.Append(" values (");
			strSql.Append("@project_id,@project_name,@furnished_type,@total_investment,@TTG_follow_up_work_approved_special_subsidies,@plan_counterparts_support_funds,@other_matching_funds,@other_funds,@time,@tciunset1,@tciunset2,@tciunset3,@tciunset4,@tciunset5,@tciunset6,@tciunset7,@tciunset8,@check_status,@lock_tables)");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@project_name", SqlDbType.VarChar,50),
					new SqlParameter("@furnished_type", SqlDbType.VarChar,20),
					new SqlParameter("@total_investment", SqlDbType.Float,8),
					new SqlParameter("@TTG_follow_up_work_approved_special_subsidies", SqlDbType.Float,8),
					new SqlParameter("@plan_counterparts_support_funds", SqlDbType.Float,8),
					new SqlParameter("@other_matching_funds", SqlDbType.Float,8),
					new SqlParameter("@other_funds", SqlDbType.Float,8),
					new SqlParameter("@time", SqlDbType.Date,3),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset8", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4)};
			parameters[0].Value = model.project_id;
			parameters[1].Value = model.project_name;
			parameters[2].Value = model.furnished_type;
			parameters[3].Value = model.total_investment;
			parameters[4].Value = model.TTG_follow_up_work_approved_special_subsidies;
			parameters[5].Value = model.plan_counterparts_support_funds;
			parameters[6].Value = model.other_matching_funds;
			parameters[7].Value = model.other_funds;
			parameters[8].Value = model.time;
			parameters[9].Value = model.tciunset1;
			parameters[10].Value = model.tciunset2;
			parameters[11].Value = model.tciunset3;
			parameters[12].Value = model.tciunset4;
			parameters[13].Value = model.tciunset5;
			parameters[14].Value = model.tciunset6;
			parameters[15].Value = model.tciunset7;
			parameters[16].Value = model.tciunset8;
			parameters[17].Value = model.check_status;
			parameters[18].Value = model.lock_tables;

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
		public bool Update(TTG.Model.TTGWeb.project_capital model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_project_capital set ");
			strSql.Append("project_name=@project_name,");
			strSql.Append("total_investment=@total_investment,");
			strSql.Append("TTG_follow_up_work_approved_special_subsidies=@TTG_follow_up_work_approved_special_subsidies,");
			strSql.Append("plan_counterparts_support_funds=@plan_counterparts_support_funds,");
			strSql.Append("other_matching_funds=@other_matching_funds,");
			strSql.Append("other_funds=@other_funds,");
			strSql.Append("tciunset1=@tciunset1,");
			strSql.Append("tciunset2=@tciunset2,");
			strSql.Append("tciunset3=@tciunset3,");
			strSql.Append("tciunset4=@tciunset4,");
			strSql.Append("tciunset5=@tciunset5,");
			strSql.Append("tciunset6=@tciunset6,");
			strSql.Append("tciunset7=@tciunset7,");
			strSql.Append("tciunset8=@tciunset8,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("lock_tables=@lock_tables");
			strSql.Append(" where project_id=@project_id and furnished_type=@furnished_type and time=@time ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_name", SqlDbType.VarChar,50),
					new SqlParameter("@total_investment", SqlDbType.Float,8),
					new SqlParameter("@TTG_follow_up_work_approved_special_subsidies", SqlDbType.Float,8),
					new SqlParameter("@plan_counterparts_support_funds", SqlDbType.Float,8),
					new SqlParameter("@other_matching_funds", SqlDbType.Float,8),
					new SqlParameter("@other_funds", SqlDbType.Float,8),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset8", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@furnished_type", SqlDbType.VarChar,20),
					new SqlParameter("@time", SqlDbType.Date,3)};
			parameters[0].Value = model.project_name;
			parameters[1].Value = model.total_investment;
			parameters[2].Value = model.TTG_follow_up_work_approved_special_subsidies;
			parameters[3].Value = model.plan_counterparts_support_funds;
			parameters[4].Value = model.other_matching_funds;
			parameters[5].Value = model.other_funds;
			parameters[6].Value = model.tciunset1;
			parameters[7].Value = model.tciunset2;
			parameters[8].Value = model.tciunset3;
			parameters[9].Value = model.tciunset4;
			parameters[10].Value = model.tciunset5;
			parameters[11].Value = model.tciunset6;
			parameters[12].Value = model.tciunset7;
			parameters[13].Value = model.tciunset8;
			parameters[14].Value = model.check_status;
			parameters[15].Value = model.lock_tables;
			parameters[16].Value = model.project_id;
			parameters[17].Value = model.furnished_type;
			parameters[18].Value = model.time;

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
		public bool Delete(string project_id,string furnished_type,DateTime time)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_project_capital ");
			strSql.Append(" where project_id=@project_id and furnished_type=@furnished_type and time=@time ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@furnished_type", SqlDbType.VarChar,20),
					new SqlParameter("@time", SqlDbType.Date,3)			};
			parameters[0].Value = project_id;
			parameters[1].Value = furnished_type;
			parameters[2].Value = time;

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
		public TTG.Model.TTGWeb.project_capital GetModel(string project_id,string furnished_type,DateTime time)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 project_id,project_name,furnished_type,total_investment,TTG_follow_up_work_approved_special_subsidies,plan_counterparts_support_funds,other_matching_funds,other_funds,time,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,check_status,lock_tables from T_project_capital ");
			strSql.Append(" where project_id=@project_id and furnished_type=@furnished_type and time=@time ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@furnished_type", SqlDbType.VarChar,20),
					new SqlParameter("@time", SqlDbType.Date,3)			};
			parameters[0].Value = project_id;
			parameters[1].Value = furnished_type;
			parameters[2].Value = time;

			TTG.Model.TTGWeb.project_capital model=new TTG.Model.TTGWeb.project_capital();
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
		public TTG.Model.TTGWeb.project_capital DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.project_capital model=new TTG.Model.TTGWeb.project_capital();
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
				if(row["furnished_type"]!=null)
				{
					model.furnished_type=row["furnished_type"].ToString();
				}
				if(row["total_investment"]!=null && row["total_investment"].ToString()!="")
				{
					model.total_investment=decimal.Parse(row["total_investment"].ToString());
				}
				if(row["TTG_follow_up_work_approved_special_subsidies"]!=null && row["TTG_follow_up_work_approved_special_subsidies"].ToString()!="")
				{
					model.TTG_follow_up_work_approved_special_subsidies=decimal.Parse(row["TTG_follow_up_work_approved_special_subsidies"].ToString());
				}
				if(row["plan_counterparts_support_funds"]!=null && row["plan_counterparts_support_funds"].ToString()!="")
				{
					model.plan_counterparts_support_funds=decimal.Parse(row["plan_counterparts_support_funds"].ToString());
				}
				if(row["other_matching_funds"]!=null && row["other_matching_funds"].ToString()!="")
				{
					model.other_matching_funds=decimal.Parse(row["other_matching_funds"].ToString());
				}
				if(row["other_funds"]!=null && row["other_funds"].ToString()!="")
				{
					model.other_funds=decimal.Parse(row["other_funds"].ToString());
				}
				if(row["time"]!=null && row["time"].ToString()!="")
				{
					model.time=DateTime.Parse(row["time"].ToString());
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
				if(row["tciunset5"]!=null)
				{
					model.tciunset5=row["tciunset5"].ToString();
				}
				if(row["tciunset6"]!=null)
				{
					model.tciunset6=row["tciunset6"].ToString();
				}
				if(row["tciunset7"]!=null)
				{
					model.tciunset7=row["tciunset7"].ToString();
				}
				if(row["tciunset8"]!=null)
				{
					model.tciunset8=row["tciunset8"].ToString();
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
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
			strSql.Append("select project_id,project_name,furnished_type,total_investment,TTG_follow_up_work_approved_special_subsidies,plan_counterparts_support_funds,other_matching_funds,other_funds,time,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,check_status,lock_tables ");
			strSql.Append(" FROM T_project_capital ");
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
			strSql.Append(" project_id,project_name,furnished_type,total_investment,TTG_follow_up_work_approved_special_subsidies,plan_counterparts_support_funds,other_matching_funds,other_funds,time,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,check_status,lock_tables ");
			strSql.Append(" FROM T_project_capital ");
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
			strSql.Append("select count(1) FROM T_project_capital ");
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
				strSql.Append("order by T.time desc");
			}
			strSql.Append(")AS Row, T.*  from T_project_capital T ");
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
			parameters[0].Value = "T_project_capital";
			parameters[1].Value = "time";
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

