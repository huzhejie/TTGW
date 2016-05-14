using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_road_problem_finished
	/// </summary>
	public partial class community_road_problem_finished
	{
		public community_road_problem_finished()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date,string project_name)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_road_problem_finished");
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
		public bool Add(TTG.Model.TTGWeb.community_road_problem_finished model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_road_problem_finished(");
			strSql.Append("community_id,community_road_hardening_area,community_road_maintain_reform_num,community_road_maintain_reform_len,community_road_maintain_reform_area,community_pavement_colorful_brick_len,community_pavement_colorful_brick_area,community_added_road_num,community_added_road_area,community_road_maintain_reform_num_ots,community_road_maintain_reform_len_ots,community_road_maintain_reform_area_ots,community_added_vehicles_road_num,community_added_vehicles_road_area,community_white_change_black_road_num,community_white_change_black_road_area,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,tciunset15,tciunset16,tciunset17,lock_tables,community_added_road_num_for_update,community_added_road_area_for_update,project_name)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_road_hardening_area,@community_road_maintain_reform_num,@community_road_maintain_reform_len,@community_road_maintain_reform_area,@community_pavement_colorful_brick_len,@community_pavement_colorful_brick_area,@community_added_road_num,@community_added_road_area,@community_road_maintain_reform_num_ots,@community_road_maintain_reform_len_ots,@community_road_maintain_reform_area_ots,@community_added_vehicles_road_num,@community_added_vehicles_road_area,@community_white_change_black_road_num,@community_white_change_black_road_area,@statistics_date,@check_status,@tciunset1,@tciunset2,@tciunset3,@tciunset4,@tciunset5,@tciunset6,@tciunset7,@tciunset8,@tciunset9,@tciunset10,@tciunset11,@tciunset12,@tciunset13,@tciunset14,@tciunset15,@tciunset16,@tciunset17,@lock_tables,@community_added_road_num_for_update,@community_added_road_area_for_update,@project_name)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_road_hardening_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_maintain_reform_num", SqlDbType.Int,4),
					new SqlParameter("@community_road_maintain_reform_len", SqlDbType.Float,8),
					new SqlParameter("@community_road_maintain_reform_area", SqlDbType.Float,8),
					new SqlParameter("@community_pavement_colorful_brick_len", SqlDbType.Float,8),
					new SqlParameter("@community_pavement_colorful_brick_area", SqlDbType.Float,8),
					new SqlParameter("@community_added_road_num", SqlDbType.Int,4),
					new SqlParameter("@community_added_road_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_maintain_reform_num_ots", SqlDbType.Float,8),
					new SqlParameter("@community_road_maintain_reform_len_ots", SqlDbType.Float,8),
					new SqlParameter("@community_road_maintain_reform_area_ots", SqlDbType.Float,8),
					new SqlParameter("@community_added_vehicles_road_num", SqlDbType.Int,4),
					new SqlParameter("@community_added_vehicles_road_area", SqlDbType.Float,8),
					new SqlParameter("@community_white_change_black_road_num", SqlDbType.Int,4),
					new SqlParameter("@community_white_change_black_road_area", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset17", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@community_added_road_num_for_update", SqlDbType.Int,4),
					new SqlParameter("@community_added_road_area_for_update", SqlDbType.Float,8),
					new SqlParameter("@project_name", SqlDbType.VarChar,50)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_road_hardening_area;
			parameters[2].Value = model.community_road_maintain_reform_num;
			parameters[3].Value = model.community_road_maintain_reform_len;
			parameters[4].Value = model.community_road_maintain_reform_area;
			parameters[5].Value = model.community_pavement_colorful_brick_len;
			parameters[6].Value = model.community_pavement_colorful_brick_area;
			parameters[7].Value = model.community_added_road_num;
			parameters[8].Value = model.community_added_road_area;
			parameters[9].Value = model.community_road_maintain_reform_num_ots;
			parameters[10].Value = model.community_road_maintain_reform_len_ots;
			parameters[11].Value = model.community_road_maintain_reform_area_ots;
			parameters[12].Value = model.community_added_vehicles_road_num;
			parameters[13].Value = model.community_added_vehicles_road_area;
			parameters[14].Value = model.community_white_change_black_road_num;
			parameters[15].Value = model.community_white_change_black_road_area;
			parameters[16].Value = model.statistics_date;
			parameters[17].Value = model.check_status;
			parameters[18].Value = model.tciunset1;
			parameters[19].Value = model.tciunset2;
			parameters[20].Value = model.tciunset3;
			parameters[21].Value = model.tciunset4;
			parameters[22].Value = model.tciunset5;
			parameters[23].Value = model.tciunset6;
			parameters[24].Value = model.tciunset7;
			parameters[25].Value = model.tciunset8;
			parameters[26].Value = model.tciunset9;
			parameters[27].Value = model.tciunset10;
			parameters[28].Value = model.tciunset11;
			parameters[29].Value = model.tciunset12;
			parameters[30].Value = model.tciunset13;
			parameters[31].Value = model.tciunset14;
			parameters[32].Value = model.tciunset15;
			parameters[33].Value = model.tciunset16;
			parameters[34].Value = model.tciunset17;
			parameters[35].Value = model.lock_tables;
			parameters[36].Value = model.community_added_road_num_for_update;
			parameters[37].Value = model.community_added_road_area_for_update;
			parameters[38].Value = model.project_name;

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
		public bool Update(TTG.Model.TTGWeb.community_road_problem_finished model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_road_problem_finished set ");
			strSql.Append("community_road_hardening_area=@community_road_hardening_area,");
			strSql.Append("community_road_maintain_reform_num=@community_road_maintain_reform_num,");
			strSql.Append("community_road_maintain_reform_len=@community_road_maintain_reform_len,");
			strSql.Append("community_road_maintain_reform_area=@community_road_maintain_reform_area,");
			strSql.Append("community_pavement_colorful_brick_len=@community_pavement_colorful_brick_len,");
			strSql.Append("community_pavement_colorful_brick_area=@community_pavement_colorful_brick_area,");
			strSql.Append("community_added_road_num=@community_added_road_num,");
			strSql.Append("community_added_road_area=@community_added_road_area,");
			strSql.Append("community_road_maintain_reform_num_ots=@community_road_maintain_reform_num_ots,");
			strSql.Append("community_road_maintain_reform_len_ots=@community_road_maintain_reform_len_ots,");
			strSql.Append("community_road_maintain_reform_area_ots=@community_road_maintain_reform_area_ots,");
			strSql.Append("community_added_vehicles_road_num=@community_added_vehicles_road_num,");
			strSql.Append("community_added_vehicles_road_area=@community_added_vehicles_road_area,");
			strSql.Append("community_white_change_black_road_num=@community_white_change_black_road_num,");
			strSql.Append("community_white_change_black_road_area=@community_white_change_black_road_area,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("tciunset1=@tciunset1,");
			strSql.Append("tciunset2=@tciunset2,");
			strSql.Append("tciunset3=@tciunset3,");
			strSql.Append("tciunset4=@tciunset4,");
			strSql.Append("tciunset5=@tciunset5,");
			strSql.Append("tciunset6=@tciunset6,");
			strSql.Append("tciunset7=@tciunset7,");
			strSql.Append("tciunset8=@tciunset8,");
			strSql.Append("tciunset9=@tciunset9,");
			strSql.Append("tciunset10=@tciunset10,");
			strSql.Append("tciunset11=@tciunset11,");
			strSql.Append("tciunset12=@tciunset12,");
			strSql.Append("tciunset13=@tciunset13,");
			strSql.Append("tciunset14=@tciunset14,");
			strSql.Append("tciunset15=@tciunset15,");
			strSql.Append("tciunset16=@tciunset16,");
			strSql.Append("tciunset17=@tciunset17,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("community_added_road_num_for_update=@community_added_road_num_for_update,");
			strSql.Append("community_added_road_area_for_update=@community_added_road_area_for_update");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date and project_name=@project_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_road_hardening_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_maintain_reform_num", SqlDbType.Int,4),
					new SqlParameter("@community_road_maintain_reform_len", SqlDbType.Float,8),
					new SqlParameter("@community_road_maintain_reform_area", SqlDbType.Float,8),
					new SqlParameter("@community_pavement_colorful_brick_len", SqlDbType.Float,8),
					new SqlParameter("@community_pavement_colorful_brick_area", SqlDbType.Float,8),
					new SqlParameter("@community_added_road_num", SqlDbType.Int,4),
					new SqlParameter("@community_added_road_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_maintain_reform_num_ots", SqlDbType.Float,8),
					new SqlParameter("@community_road_maintain_reform_len_ots", SqlDbType.Float,8),
					new SqlParameter("@community_road_maintain_reform_area_ots", SqlDbType.Float,8),
					new SqlParameter("@community_added_vehicles_road_num", SqlDbType.Int,4),
					new SqlParameter("@community_added_vehicles_road_area", SqlDbType.Float,8),
					new SqlParameter("@community_white_change_black_road_num", SqlDbType.Int,4),
					new SqlParameter("@community_white_change_black_road_area", SqlDbType.Float,8),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset17", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@community_added_road_num_for_update", SqlDbType.Int,4),
					new SqlParameter("@community_added_road_area_for_update", SqlDbType.Float,8),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@project_name", SqlDbType.VarChar,50)};
			parameters[0].Value = model.community_road_hardening_area;
			parameters[1].Value = model.community_road_maintain_reform_num;
			parameters[2].Value = model.community_road_maintain_reform_len;
			parameters[3].Value = model.community_road_maintain_reform_area;
			parameters[4].Value = model.community_pavement_colorful_brick_len;
			parameters[5].Value = model.community_pavement_colorful_brick_area;
			parameters[6].Value = model.community_added_road_num;
			parameters[7].Value = model.community_added_road_area;
			parameters[8].Value = model.community_road_maintain_reform_num_ots;
			parameters[9].Value = model.community_road_maintain_reform_len_ots;
			parameters[10].Value = model.community_road_maintain_reform_area_ots;
			parameters[11].Value = model.community_added_vehicles_road_num;
			parameters[12].Value = model.community_added_vehicles_road_area;
			parameters[13].Value = model.community_white_change_black_road_num;
			parameters[14].Value = model.community_white_change_black_road_area;
			parameters[15].Value = model.check_status;
			parameters[16].Value = model.tciunset1;
			parameters[17].Value = model.tciunset2;
			parameters[18].Value = model.tciunset3;
			parameters[19].Value = model.tciunset4;
			parameters[20].Value = model.tciunset5;
			parameters[21].Value = model.tciunset6;
			parameters[22].Value = model.tciunset7;
			parameters[23].Value = model.tciunset8;
			parameters[24].Value = model.tciunset9;
			parameters[25].Value = model.tciunset10;
			parameters[26].Value = model.tciunset11;
			parameters[27].Value = model.tciunset12;
			parameters[28].Value = model.tciunset13;
			parameters[29].Value = model.tciunset14;
			parameters[30].Value = model.tciunset15;
			parameters[31].Value = model.tciunset16;
			parameters[32].Value = model.tciunset17;
			parameters[33].Value = model.lock_tables;
			parameters[34].Value = model.community_added_road_num_for_update;
			parameters[35].Value = model.community_added_road_area_for_update;
			parameters[36].Value = model.community_id;
			parameters[37].Value = model.statistics_date;
			parameters[38].Value = model.project_name;

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
			strSql.Append("delete from T_community_road_problem_finished ");
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
		public TTG.Model.TTGWeb.community_road_problem_finished GetModel(string community_id,DateTime statistics_date,string project_name)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_road_hardening_area,community_road_maintain_reform_num,community_road_maintain_reform_len,community_road_maintain_reform_area,community_pavement_colorful_brick_len,community_pavement_colorful_brick_area,community_added_road_num,community_added_road_area,community_road_maintain_reform_num_ots,community_road_maintain_reform_len_ots,community_road_maintain_reform_area_ots,community_added_vehicles_road_num,community_added_vehicles_road_area,community_white_change_black_road_num,community_white_change_black_road_area,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,tciunset15,tciunset16,tciunset17,lock_tables,community_added_road_num_for_update,community_added_road_area_for_update,project_name from T_community_road_problem_finished ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date and project_name=@project_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@project_name", SqlDbType.VarChar,50)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;
			parameters[2].Value = project_name;

			TTG.Model.TTGWeb.community_road_problem_finished model=new TTG.Model.TTGWeb.community_road_problem_finished();
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
		public TTG.Model.TTGWeb.community_road_problem_finished DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_road_problem_finished model=new TTG.Model.TTGWeb.community_road_problem_finished();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_road_hardening_area"]!=null && row["community_road_hardening_area"].ToString()!="")
				{
					model.community_road_hardening_area=decimal.Parse(row["community_road_hardening_area"].ToString());
				}
				if(row["community_road_maintain_reform_num"]!=null && row["community_road_maintain_reform_num"].ToString()!="")
				{
					model.community_road_maintain_reform_num=int.Parse(row["community_road_maintain_reform_num"].ToString());
				}
				if(row["community_road_maintain_reform_len"]!=null && row["community_road_maintain_reform_len"].ToString()!="")
				{
					model.community_road_maintain_reform_len=decimal.Parse(row["community_road_maintain_reform_len"].ToString());
				}
				if(row["community_road_maintain_reform_area"]!=null && row["community_road_maintain_reform_area"].ToString()!="")
				{
					model.community_road_maintain_reform_area=decimal.Parse(row["community_road_maintain_reform_area"].ToString());
				}
				if(row["community_pavement_colorful_brick_len"]!=null && row["community_pavement_colorful_brick_len"].ToString()!="")
				{
					model.community_pavement_colorful_brick_len=decimal.Parse(row["community_pavement_colorful_brick_len"].ToString());
				}
				if(row["community_pavement_colorful_brick_area"]!=null && row["community_pavement_colorful_brick_area"].ToString()!="")
				{
					model.community_pavement_colorful_brick_area=decimal.Parse(row["community_pavement_colorful_brick_area"].ToString());
				}
				if(row["community_added_road_num"]!=null && row["community_added_road_num"].ToString()!="")
				{
					model.community_added_road_num=int.Parse(row["community_added_road_num"].ToString());
				}
				if(row["community_added_road_area"]!=null && row["community_added_road_area"].ToString()!="")
				{
					model.community_added_road_area=decimal.Parse(row["community_added_road_area"].ToString());
				}
				if(row["community_road_maintain_reform_num_ots"]!=null && row["community_road_maintain_reform_num_ots"].ToString()!="")
				{
					model.community_road_maintain_reform_num_ots=decimal.Parse(row["community_road_maintain_reform_num_ots"].ToString());
				}
				if(row["community_road_maintain_reform_len_ots"]!=null && row["community_road_maintain_reform_len_ots"].ToString()!="")
				{
					model.community_road_maintain_reform_len_ots=decimal.Parse(row["community_road_maintain_reform_len_ots"].ToString());
				}
				if(row["community_road_maintain_reform_area_ots"]!=null && row["community_road_maintain_reform_area_ots"].ToString()!="")
				{
					model.community_road_maintain_reform_area_ots=decimal.Parse(row["community_road_maintain_reform_area_ots"].ToString());
				}
				if(row["community_added_vehicles_road_num"]!=null && row["community_added_vehicles_road_num"].ToString()!="")
				{
					model.community_added_vehicles_road_num=int.Parse(row["community_added_vehicles_road_num"].ToString());
				}
				if(row["community_added_vehicles_road_area"]!=null && row["community_added_vehicles_road_area"].ToString()!="")
				{
					model.community_added_vehicles_road_area=decimal.Parse(row["community_added_vehicles_road_area"].ToString());
				}
				if(row["community_white_change_black_road_num"]!=null && row["community_white_change_black_road_num"].ToString()!="")
				{
					model.community_white_change_black_road_num=int.Parse(row["community_white_change_black_road_num"].ToString());
				}
				if(row["community_white_change_black_road_area"]!=null && row["community_white_change_black_road_area"].ToString()!="")
				{
					model.community_white_change_black_road_area=decimal.Parse(row["community_white_change_black_road_area"].ToString());
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
				if(row["tciunset7"]!=null)
				{
					model.tciunset7=row["tciunset7"].ToString();
				}
				if(row["tciunset8"]!=null)
				{
					model.tciunset8=row["tciunset8"].ToString();
				}
				if(row["tciunset9"]!=null)
				{
					model.tciunset9=row["tciunset9"].ToString();
				}
				if(row["tciunset10"]!=null)
				{
					model.tciunset10=row["tciunset10"].ToString();
				}
				if(row["tciunset11"]!=null)
				{
					model.tciunset11=row["tciunset11"].ToString();
				}
				if(row["tciunset12"]!=null)
				{
					model.tciunset12=row["tciunset12"].ToString();
				}
				if(row["tciunset13"]!=null)
				{
					model.tciunset13=row["tciunset13"].ToString();
				}
				if(row["tciunset14"]!=null)
				{
					model.tciunset14=row["tciunset14"].ToString();
				}
				if(row["tciunset15"]!=null)
				{
					model.tciunset15=row["tciunset15"].ToString();
				}
				if(row["tciunset16"]!=null)
				{
					model.tciunset16=row["tciunset16"].ToString();
				}
				if(row["tciunset17"]!=null)
				{
					model.tciunset17=row["tciunset17"].ToString();
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["community_added_road_num_for_update"]!=null && row["community_added_road_num_for_update"].ToString()!="")
				{
					model.community_added_road_num_for_update=int.Parse(row["community_added_road_num_for_update"].ToString());
				}
				if(row["community_added_road_area_for_update"]!=null && row["community_added_road_area_for_update"].ToString()!="")
				{
					model.community_added_road_area_for_update=decimal.Parse(row["community_added_road_area_for_update"].ToString());
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
			strSql.Append("select community_id,community_road_hardening_area,community_road_maintain_reform_num,community_road_maintain_reform_len,community_road_maintain_reform_area,community_pavement_colorful_brick_len,community_pavement_colorful_brick_area,community_added_road_num,community_added_road_area,community_road_maintain_reform_num_ots,community_road_maintain_reform_len_ots,community_road_maintain_reform_area_ots,community_added_vehicles_road_num,community_added_vehicles_road_area,community_white_change_black_road_num,community_white_change_black_road_area,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,tciunset15,tciunset16,tciunset17,lock_tables,community_added_road_num_for_update,community_added_road_area_for_update,project_name ");
			strSql.Append(" FROM T_community_road_problem_finished ");
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
			strSql.Append(" community_id,community_road_hardening_area,community_road_maintain_reform_num,community_road_maintain_reform_len,community_road_maintain_reform_area,community_pavement_colorful_brick_len,community_pavement_colorful_brick_area,community_added_road_num,community_added_road_area,community_road_maintain_reform_num_ots,community_road_maintain_reform_len_ots,community_road_maintain_reform_area_ots,community_added_vehicles_road_num,community_added_vehicles_road_area,community_white_change_black_road_num,community_white_change_black_road_area,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,tciunset15,tciunset16,tciunset17,lock_tables,community_added_road_num_for_update,community_added_road_area_for_update,project_name ");
			strSql.Append(" FROM T_community_road_problem_finished ");
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
			strSql.Append("select count(1) FROM T_community_road_problem_finished ");
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
			strSql.Append(")AS Row, T.*  from T_community_road_problem_finished T ");
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
			parameters[0].Value = "T_community_road_problem_finished";
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

