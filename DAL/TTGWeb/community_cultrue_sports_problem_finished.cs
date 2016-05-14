using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_cultrue_sports_problem_finished
	/// </summary>
	public partial class community_cultrue_sports_problem_finished
	{
		public community_cultrue_sports_problem_finished()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date,string project_name)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_cultrue_sports_problem_finished");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date and project_name=@project_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@project_name", SqlDbType.VarChar,50)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;
			parameters[2].Value = project_name;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.community_cultrue_sports_problem_finished model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_cultrue_sports_problem_finished(");
			strSql.Append("community_id,community_otd_exercise_yard_area,community_added_fitness_equipment_num,community_ind_exercise_yard_area,community_added_ind_exercise_yard_faci_num,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,lock_tables,project_name)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_otd_exercise_yard_area,@community_added_fitness_equipment_num,@community_ind_exercise_yard_area,@community_added_ind_exercise_yard_faci_num,@statistics_date,@check_status,@tciunset1,@tciunset2,@tciunset3,@tciunset4,@tciunset5,@tciunset6,@lock_tables,@project_name)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_otd_exercise_yard_area", SqlDbType.Float,8),
					new SqlParameter("@community_added_fitness_equipment_num", SqlDbType.Int,4),
					new SqlParameter("@community_ind_exercise_yard_area", SqlDbType.Float,8),
					new SqlParameter("@community_added_ind_exercise_yard_faci_num", SqlDbType.Int,4),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset6", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@project_name", SqlDbType.VarChar,50)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_otd_exercise_yard_area;
			parameters[2].Value = model.community_added_fitness_equipment_num;
			parameters[3].Value = model.community_ind_exercise_yard_area;
			parameters[4].Value = model.community_added_ind_exercise_yard_faci_num;
			parameters[5].Value = model.statistics_date;
			parameters[6].Value = model.check_status;
			parameters[7].Value = model.tciunset1;
			parameters[8].Value = model.tciunset2;
			parameters[9].Value = model.tciunset3;
			parameters[10].Value = model.tciunset4;
			parameters[11].Value = model.tciunset5;
			parameters[12].Value = model.tciunset6;
			parameters[13].Value = model.lock_tables;
			parameters[14].Value = model.project_name;

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
		public bool Update(TTG.Model.TTGWeb.community_cultrue_sports_problem_finished model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_cultrue_sports_problem_finished set ");
			strSql.Append("community_otd_exercise_yard_area=@community_otd_exercise_yard_area,");
			strSql.Append("community_added_fitness_equipment_num=@community_added_fitness_equipment_num,");
			strSql.Append("community_ind_exercise_yard_area=@community_ind_exercise_yard_area,");
			strSql.Append("community_added_ind_exercise_yard_faci_num=@community_added_ind_exercise_yard_faci_num,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("tciunset1=@tciunset1,");
			strSql.Append("tciunset2=@tciunset2,");
			strSql.Append("tciunset3=@tciunset3,");
			strSql.Append("tciunset4=@tciunset4,");
			strSql.Append("tciunset5=@tciunset5,");
			strSql.Append("tciunset6=@tciunset6,");
			strSql.Append("lock_tables=@lock_tables");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date and project_name=@project_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_otd_exercise_yard_area", SqlDbType.Float,8),
					new SqlParameter("@community_added_fitness_equipment_num", SqlDbType.Int,4),
					new SqlParameter("@community_ind_exercise_yard_area", SqlDbType.Float,8),
					new SqlParameter("@community_added_ind_exercise_yard_faci_num", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset6", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@project_name", SqlDbType.VarChar,50)};
			parameters[0].Value = model.community_otd_exercise_yard_area;
			parameters[1].Value = model.community_added_fitness_equipment_num;
			parameters[2].Value = model.community_ind_exercise_yard_area;
			parameters[3].Value = model.community_added_ind_exercise_yard_faci_num;
			parameters[4].Value = model.check_status;
			parameters[5].Value = model.tciunset1;
			parameters[6].Value = model.tciunset2;
			parameters[7].Value = model.tciunset3;
			parameters[8].Value = model.tciunset4;
			parameters[9].Value = model.tciunset5;
			parameters[10].Value = model.tciunset6;
			parameters[11].Value = model.lock_tables;
			parameters[12].Value = model.community_id;
			parameters[13].Value = model.statistics_date;
			parameters[14].Value = model.project_name;

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
		public bool Delete(string community_id,DateTime statistics_date,string project_name)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_community_cultrue_sports_problem_finished ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date and project_name=@project_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@project_name", SqlDbType.VarChar,50)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;
			parameters[2].Value = project_name;

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
		public TTG.Model.TTGWeb.community_cultrue_sports_problem_finished GetModel(string community_id,DateTime statistics_date,string project_name)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_otd_exercise_yard_area,community_added_fitness_equipment_num,community_ind_exercise_yard_area,community_added_ind_exercise_yard_faci_num,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,lock_tables,project_name from T_community_cultrue_sports_problem_finished ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date and project_name=@project_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@project_name", SqlDbType.VarChar,50)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;
			parameters[2].Value = project_name;

			TTG.Model.TTGWeb.community_cultrue_sports_problem_finished model=new TTG.Model.TTGWeb.community_cultrue_sports_problem_finished();
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
		public TTG.Model.TTGWeb.community_cultrue_sports_problem_finished DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_cultrue_sports_problem_finished model=new TTG.Model.TTGWeb.community_cultrue_sports_problem_finished();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_otd_exercise_yard_area"]!=null && row["community_otd_exercise_yard_area"].ToString()!="")
				{
					model.community_otd_exercise_yard_area=decimal.Parse(row["community_otd_exercise_yard_area"].ToString());
				}
				if(row["community_added_fitness_equipment_num"]!=null && row["community_added_fitness_equipment_num"].ToString()!="")
				{
					model.community_added_fitness_equipment_num=int.Parse(row["community_added_fitness_equipment_num"].ToString());
				}
				if(row["community_ind_exercise_yard_area"]!=null && row["community_ind_exercise_yard_area"].ToString()!="")
				{
					model.community_ind_exercise_yard_area=decimal.Parse(row["community_ind_exercise_yard_area"].ToString());
				}
				if(row["community_added_ind_exercise_yard_faci_num"]!=null && row["community_added_ind_exercise_yard_faci_num"].ToString()!="")
				{
					model.community_added_ind_exercise_yard_faci_num=int.Parse(row["community_added_ind_exercise_yard_faci_num"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
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
				if(row["tciunset5"]!=null)
				{
					model.tciunset5=row["tciunset5"].ToString();
				}
				if(row["tciunset6"]!=null)
				{
					model.tciunset6=row["tciunset6"].ToString();
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
			strSql.Append("select community_id,community_otd_exercise_yard_area,community_added_fitness_equipment_num,community_ind_exercise_yard_area,community_added_ind_exercise_yard_faci_num,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,lock_tables,project_name ");
			strSql.Append(" FROM T_community_cultrue_sports_problem_finished ");
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
			strSql.Append(" community_id,community_otd_exercise_yard_area,community_added_fitness_equipment_num,community_ind_exercise_yard_area,community_added_ind_exercise_yard_faci_num,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,lock_tables,project_name ");
			strSql.Append(" FROM T_community_cultrue_sports_problem_finished ");
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
			strSql.Append("select count(1) FROM T_community_cultrue_sports_problem_finished ");
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
			strSql.Append(")AS Row, T.*  from T_community_cultrue_sports_problem_finished T ");
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
			parameters[0].Value = "T_community_cultrue_sports_problem_finished";
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

