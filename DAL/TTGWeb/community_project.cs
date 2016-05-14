using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_project
	/// </summary>
	public partial class community_project
	{
		public community_project()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string county_name,string project_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_project");
			strSql.Append(" where county_name=@county_name and project_id=@project_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@county_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = county_name;
			parameters[1].Value = project_id;
			parameters[2].Value = statistics_date;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.community_project model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_project(");
			strSql.Append("county_name,project_id,project_name,project_category,project_add_time,project_total_investment,project_proprietor,plan_to_bulid,biding_finish_time,contract_period,project_start_time,not_started_reason_analysis,complete_time,project_delay_reason_analysis,if_major_quality_or_security_accident_happened,project_complete_acceptance_time,complete_acceptance_quality_level,if_transfer,project_community_correlation_description,note_information,project_type,statistics_date,major_quality_or_security_accident,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,tciunset15,tciunset16,tciunset17,tciunset18,tciunset19,tciunset20,tciunset21,check_status,lock_tables,after_id)");
			strSql.Append(" values (");
			strSql.Append("@county_name,@project_id,@project_name,@project_category,@project_add_time,@project_total_investment,@project_proprietor,@plan_to_bulid,@biding_finish_time,@contract_period,@project_start_time,@not_started_reason_analysis,@complete_time,@project_delay_reason_analysis,@if_major_quality_or_security_accident_happened,@project_complete_acceptance_time,@complete_acceptance_quality_level,@if_transfer,@project_community_correlation_description,@note_information,@project_type,@statistics_date,@major_quality_or_security_accident,@tciunset1,@tciunset2,@tciunset3,@tciunset4,@tciunset5,@tciunset6,@tciunset7,@tciunset8,@tciunset9,@tciunset10,@tciunset11,@tciunset12,@tciunset13,@tciunset14,@tciunset15,@tciunset16,@tciunset17,@tciunset18,@tciunset19,@tciunset20,@tciunset21,@check_status,@lock_tables,@after_id)");
			SqlParameter[] parameters = {
					new SqlParameter("@county_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@project_name", SqlDbType.VarChar,100),
					new SqlParameter("@project_category", SqlDbType.VarChar,20),
					new SqlParameter("@project_add_time", SqlDbType.Date,3),
					new SqlParameter("@project_total_investment", SqlDbType.Float,8),
					new SqlParameter("@project_proprietor", SqlDbType.VarChar,50),
					new SqlParameter("@plan_to_bulid", SqlDbType.VarChar,200),
					new SqlParameter("@biding_finish_time", SqlDbType.Date,3),
					new SqlParameter("@contract_period", SqlDbType.VarChar,20),
					new SqlParameter("@project_start_time", SqlDbType.Date,3),
					new SqlParameter("@not_started_reason_analysis", SqlDbType.VarChar,200),
					new SqlParameter("@complete_time", SqlDbType.Date,3),
					new SqlParameter("@project_delay_reason_analysis", SqlDbType.VarChar,200),
					new SqlParameter("@if_major_quality_or_security_accident_happened", SqlDbType.VarChar,20),
					new SqlParameter("@project_complete_acceptance_time", SqlDbType.Date,3),
					new SqlParameter("@complete_acceptance_quality_level", SqlDbType.VarChar,20),
					new SqlParameter("@if_transfer", SqlDbType.VarChar,20),
					new SqlParameter("@project_community_correlation_description", SqlDbType.VarChar,20),
					new SqlParameter("@note_information", SqlDbType.VarChar,200),
					new SqlParameter("@project_type", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@major_quality_or_security_accident", SqlDbType.VarChar,200),
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
					new SqlParameter("@tciunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset21", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@after_id", SqlDbType.VarChar,50)};
			parameters[0].Value = model.county_name;
			parameters[1].Value = model.project_id;
			parameters[2].Value = model.project_name;
			parameters[3].Value = model.project_category;
			parameters[4].Value = model.project_add_time;
			parameters[5].Value = model.project_total_investment;
			parameters[6].Value = model.project_proprietor;
			parameters[7].Value = model.plan_to_bulid;
			parameters[8].Value = model.biding_finish_time;
			parameters[9].Value = model.contract_period;
			parameters[10].Value = model.project_start_time;
			parameters[11].Value = model.not_started_reason_analysis;
			parameters[12].Value = model.complete_time;
			parameters[13].Value = model.project_delay_reason_analysis;
			parameters[14].Value = model.if_major_quality_or_security_accident_happened;
			parameters[15].Value = model.project_complete_acceptance_time;
			parameters[16].Value = model.complete_acceptance_quality_level;
			parameters[17].Value = model.if_transfer;
			parameters[18].Value = model.project_community_correlation_description;
			parameters[19].Value = model.note_information;
			parameters[20].Value = model.project_type;
			parameters[21].Value = model.statistics_date;
			parameters[22].Value = model.major_quality_or_security_accident;
			parameters[23].Value = model.tciunset1;
			parameters[24].Value = model.tciunset2;
			parameters[25].Value = model.tciunset3;
			parameters[26].Value = model.tciunset4;
			parameters[27].Value = model.tciunset5;
			parameters[28].Value = model.tciunset6;
			parameters[29].Value = model.tciunset7;
			parameters[30].Value = model.tciunset8;
			parameters[31].Value = model.tciunset9;
			parameters[32].Value = model.tciunset10;
			parameters[33].Value = model.tciunset11;
			parameters[34].Value = model.tciunset12;
			parameters[35].Value = model.tciunset13;
			parameters[36].Value = model.tciunset14;
			parameters[37].Value = model.tciunset15;
			parameters[38].Value = model.tciunset16;
			parameters[39].Value = model.tciunset17;
			parameters[40].Value = model.tciunset18;
			parameters[41].Value = model.tciunset19;
			parameters[42].Value = model.tciunset20;
			parameters[43].Value = model.tciunset21;
			parameters[44].Value = model.check_status;
			parameters[45].Value = model.lock_tables;
			parameters[46].Value = model.after_id;

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
		public bool Update(TTG.Model.TTGWeb.community_project model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_project set ");
			strSql.Append("project_name=@project_name,");
			strSql.Append("project_category=@project_category,");
			strSql.Append("project_add_time=@project_add_time,");
			strSql.Append("project_total_investment=@project_total_investment,");
			strSql.Append("project_proprietor=@project_proprietor,");
			strSql.Append("plan_to_bulid=@plan_to_bulid,");
			strSql.Append("biding_finish_time=@biding_finish_time,");
			strSql.Append("contract_period=@contract_period,");
			strSql.Append("project_start_time=@project_start_time,");
			strSql.Append("not_started_reason_analysis=@not_started_reason_analysis,");
			strSql.Append("complete_time=@complete_time,");
			strSql.Append("project_delay_reason_analysis=@project_delay_reason_analysis,");
			strSql.Append("if_major_quality_or_security_accident_happened=@if_major_quality_or_security_accident_happened,");
			strSql.Append("project_complete_acceptance_time=@project_complete_acceptance_time,");
			strSql.Append("complete_acceptance_quality_level=@complete_acceptance_quality_level,");
			strSql.Append("if_transfer=@if_transfer,");
			strSql.Append("project_community_correlation_description=@project_community_correlation_description,");
			strSql.Append("note_information=@note_information,");
			strSql.Append("project_type=@project_type,");
			strSql.Append("major_quality_or_security_accident=@major_quality_or_security_accident,");
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
			strSql.Append("tciunset18=@tciunset18,");
			strSql.Append("tciunset19=@tciunset19,");
			strSql.Append("tciunset20=@tciunset20,");
			strSql.Append("tciunset21=@tciunset21,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("after_id=@after_id");
			strSql.Append(" where county_name=@county_name and project_id=@project_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_name", SqlDbType.VarChar,100),
					new SqlParameter("@project_category", SqlDbType.VarChar,20),
					new SqlParameter("@project_add_time", SqlDbType.Date,3),
					new SqlParameter("@project_total_investment", SqlDbType.Float,8),
					new SqlParameter("@project_proprietor", SqlDbType.VarChar,50),
					new SqlParameter("@plan_to_bulid", SqlDbType.VarChar,200),
					new SqlParameter("@biding_finish_time", SqlDbType.Date,3),
					new SqlParameter("@contract_period", SqlDbType.VarChar,20),
					new SqlParameter("@project_start_time", SqlDbType.Date,3),
					new SqlParameter("@not_started_reason_analysis", SqlDbType.VarChar,200),
					new SqlParameter("@complete_time", SqlDbType.Date,3),
					new SqlParameter("@project_delay_reason_analysis", SqlDbType.VarChar,200),
					new SqlParameter("@if_major_quality_or_security_accident_happened", SqlDbType.VarChar,20),
					new SqlParameter("@project_complete_acceptance_time", SqlDbType.Date,3),
					new SqlParameter("@complete_acceptance_quality_level", SqlDbType.VarChar,20),
					new SqlParameter("@if_transfer", SqlDbType.VarChar,20),
					new SqlParameter("@project_community_correlation_description", SqlDbType.VarChar,20),
					new SqlParameter("@note_information", SqlDbType.VarChar,200),
					new SqlParameter("@project_type", SqlDbType.VarChar,20),
					new SqlParameter("@major_quality_or_security_accident", SqlDbType.VarChar,200),
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
					new SqlParameter("@tciunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset21", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@after_id", SqlDbType.VarChar,50),
					new SqlParameter("@county_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.project_name;
			parameters[1].Value = model.project_category;
			parameters[2].Value = model.project_add_time;
			parameters[3].Value = model.project_total_investment;
			parameters[4].Value = model.project_proprietor;
			parameters[5].Value = model.plan_to_bulid;
			parameters[6].Value = model.biding_finish_time;
			parameters[7].Value = model.contract_period;
			parameters[8].Value = model.project_start_time;
			parameters[9].Value = model.not_started_reason_analysis;
			parameters[10].Value = model.complete_time;
			parameters[11].Value = model.project_delay_reason_analysis;
			parameters[12].Value = model.if_major_quality_or_security_accident_happened;
			parameters[13].Value = model.project_complete_acceptance_time;
			parameters[14].Value = model.complete_acceptance_quality_level;
			parameters[15].Value = model.if_transfer;
			parameters[16].Value = model.project_community_correlation_description;
			parameters[17].Value = model.note_information;
			parameters[18].Value = model.project_type;
			parameters[19].Value = model.major_quality_or_security_accident;
			parameters[20].Value = model.tciunset1;
			parameters[21].Value = model.tciunset2;
			parameters[22].Value = model.tciunset3;
			parameters[23].Value = model.tciunset4;
			parameters[24].Value = model.tciunset5;
			parameters[25].Value = model.tciunset6;
			parameters[26].Value = model.tciunset7;
			parameters[27].Value = model.tciunset8;
			parameters[28].Value = model.tciunset9;
			parameters[29].Value = model.tciunset10;
			parameters[30].Value = model.tciunset11;
			parameters[31].Value = model.tciunset12;
			parameters[32].Value = model.tciunset13;
			parameters[33].Value = model.tciunset14;
			parameters[34].Value = model.tciunset15;
			parameters[35].Value = model.tciunset16;
			parameters[36].Value = model.tciunset17;
			parameters[37].Value = model.tciunset18;
			parameters[38].Value = model.tciunset19;
			parameters[39].Value = model.tciunset20;
			parameters[40].Value = model.tciunset21;
			parameters[41].Value = model.check_status;
			parameters[42].Value = model.lock_tables;
			parameters[43].Value = model.after_id;
			parameters[44].Value = model.county_name;
			parameters[45].Value = model.project_id;
			parameters[46].Value = model.statistics_date;

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
		public bool Delete(string county_name,string project_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_community_project ");
			strSql.Append(" where county_name=@county_name and project_id=@project_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@county_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = county_name;
			parameters[1].Value = project_id;
			parameters[2].Value = statistics_date;

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
		public TTG.Model.TTGWeb.community_project GetModel(string county_name,string project_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 county_name,project_id,project_name,project_category,project_add_time,project_total_investment,project_proprietor,plan_to_bulid,biding_finish_time,contract_period,project_start_time,not_started_reason_analysis,complete_time,project_delay_reason_analysis,if_major_quality_or_security_accident_happened,project_complete_acceptance_time,complete_acceptance_quality_level,if_transfer,project_community_correlation_description,note_information,project_type,statistics_date,major_quality_or_security_accident,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,tciunset15,tciunset16,tciunset17,tciunset18,tciunset19,tciunset20,tciunset21,check_status,lock_tables,after_id from T_community_project ");
			strSql.Append(" where county_name=@county_name and project_id=@project_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@county_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = county_name;
			parameters[1].Value = project_id;
			parameters[2].Value = statistics_date;

			TTG.Model.TTGWeb.community_project model=new TTG.Model.TTGWeb.community_project();
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
		public TTG.Model.TTGWeb.community_project DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_project model=new TTG.Model.TTGWeb.community_project();
			if (row != null)
			{
				if(row["county_name"]!=null)
				{
					model.county_name=row["county_name"].ToString();
				}
				if(row["project_id"]!=null)
				{
					model.project_id=row["project_id"].ToString();
				}
				if(row["project_name"]!=null)
				{
					model.project_name=row["project_name"].ToString();
				}
				if(row["project_category"]!=null)
				{
					model.project_category=row["project_category"].ToString();
				}
				if(row["project_add_time"]!=null && row["project_add_time"].ToString()!="")
				{
					model.project_add_time=DateTime.Parse(row["project_add_time"].ToString());
				}
				if(row["project_total_investment"]!=null && row["project_total_investment"].ToString()!="")
				{
					model.project_total_investment=decimal.Parse(row["project_total_investment"].ToString());
				}
				if(row["project_proprietor"]!=null)
				{
					model.project_proprietor=row["project_proprietor"].ToString();
				}
				if(row["plan_to_bulid"]!=null)
				{
					model.plan_to_bulid=row["plan_to_bulid"].ToString();
				}
				if(row["biding_finish_time"]!=null && row["biding_finish_time"].ToString()!="")
				{
					model.biding_finish_time=DateTime.Parse(row["biding_finish_time"].ToString());
				}
				if(row["contract_period"]!=null)
				{
					model.contract_period=row["contract_period"].ToString();
				}
				if(row["project_start_time"]!=null && row["project_start_time"].ToString()!="")
				{
					model.project_start_time=DateTime.Parse(row["project_start_time"].ToString());
				}
				if(row["not_started_reason_analysis"]!=null)
				{
					model.not_started_reason_analysis=row["not_started_reason_analysis"].ToString();
				}
				if(row["complete_time"]!=null && row["complete_time"].ToString()!="")
				{
					model.complete_time=DateTime.Parse(row["complete_time"].ToString());
				}
				if(row["project_delay_reason_analysis"]!=null)
				{
					model.project_delay_reason_analysis=row["project_delay_reason_analysis"].ToString();
				}
				if(row["if_major_quality_or_security_accident_happened"]!=null)
				{
					model.if_major_quality_or_security_accident_happened=row["if_major_quality_or_security_accident_happened"].ToString();
				}
				if(row["project_complete_acceptance_time"]!=null && row["project_complete_acceptance_time"].ToString()!="")
				{
					model.project_complete_acceptance_time=DateTime.Parse(row["project_complete_acceptance_time"].ToString());
				}
				if(row["complete_acceptance_quality_level"]!=null)
				{
					model.complete_acceptance_quality_level=row["complete_acceptance_quality_level"].ToString();
				}
				if(row["if_transfer"]!=null)
				{
					model.if_transfer=row["if_transfer"].ToString();
				}
				if(row["project_community_correlation_description"]!=null)
				{
					model.project_community_correlation_description=row["project_community_correlation_description"].ToString();
				}
				if(row["note_information"]!=null)
				{
					model.note_information=row["note_information"].ToString();
				}
				if(row["project_type"]!=null)
				{
					model.project_type=row["project_type"].ToString();
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["major_quality_or_security_accident"]!=null)
				{
					model.major_quality_or_security_accident=row["major_quality_or_security_accident"].ToString();
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
				if(row["tciunset18"]!=null)
				{
					model.tciunset18=row["tciunset18"].ToString();
				}
				if(row["tciunset19"]!=null)
				{
					model.tciunset19=row["tciunset19"].ToString();
				}
				if(row["tciunset20"]!=null)
				{
					model.tciunset20=row["tciunset20"].ToString();
				}
				if(row["tciunset21"]!=null)
				{
					model.tciunset21=row["tciunset21"].ToString();
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["after_id"]!=null)
				{
					model.after_id=row["after_id"].ToString();
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
			strSql.Append("select county_name,project_id,project_name,project_category,project_add_time,project_total_investment,project_proprietor,plan_to_bulid,biding_finish_time,contract_period,project_start_time,not_started_reason_analysis,complete_time,project_delay_reason_analysis,if_major_quality_or_security_accident_happened,project_complete_acceptance_time,complete_acceptance_quality_level,if_transfer,project_community_correlation_description,note_information,project_type,statistics_date,major_quality_or_security_accident,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,tciunset15,tciunset16,tciunset17,tciunset18,tciunset19,tciunset20,tciunset21,check_status,lock_tables,after_id ");
			strSql.Append(" FROM T_community_project ");
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
			strSql.Append(" county_name,project_id,project_name,project_category,project_add_time,project_total_investment,project_proprietor,plan_to_bulid,biding_finish_time,contract_period,project_start_time,not_started_reason_analysis,complete_time,project_delay_reason_analysis,if_major_quality_or_security_accident_happened,project_complete_acceptance_time,complete_acceptance_quality_level,if_transfer,project_community_correlation_description,note_information,project_type,statistics_date,major_quality_or_security_accident,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,tciunset15,tciunset16,tciunset17,tciunset18,tciunset19,tciunset20,tciunset21,check_status,lock_tables,after_id ");
			strSql.Append(" FROM T_community_project ");
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
			strSql.Append("select count(1) FROM T_community_project ");
			if(strWhere.Trim()!="")
			{
                strSql.Append(" where project_id in(select project_id from T_community_project_associate where community_id='" + strWhere+"'");
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
		public DataSet GetListByPage2(string strWhere,int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			strSql.Append("order by T.project_start_time");			
			strSql.Append(")AS Row, T.*  from T_community_project T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
                strSql.Append(" where project_id in(select project_id from T_community_project_associate where community_id='" + strWhere + "'");
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			DataSet ds= DbHelperSQL.Query(strSql.ToString());
            ds.Tables[0].Columns.Add("Project_status");
            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                if (DateTime.Now < Convert.ToDateTime(ds.Tables[0].Rows[i]["project_start_time"]))
                {
                    ds.Tables[0].Rows[i]["Project_status"] = "未开始";

                }
                else if (DateTime.Now > Convert.ToDateTime(ds.Tables[0].Rows[i]["project_start_time"]) && DateTime.Now < Convert.ToDateTime(ds.Tables[0].Rows[i]["complete_time"]))
                {
                    ds.Tables[0].Rows[i]["Project_status"] = "进行中";
                }
                else 
                {
                    ds.Tables[0].Rows[i]["Project_status"] = "已竣工";
                }
            }
            return ds;
		}
        /// <summary>
        /// 分页显示
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public DataSet GetListByPage(string strWhere, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            strSql.Append("order by T.project_id");
            strSql.Append(")AS Row, T.*  from T_community_project T "); 
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
			parameters[0].Value = "T_community_project";
			parameters[1].Value = "statistics_date";
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

