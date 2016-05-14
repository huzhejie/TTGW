using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_lf_employment
	/// </summary>
	public partial class community_lf_employment
	{
		public community_lf_employment()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_lf_employment");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.community_lf_employment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_lf_employment(");
			strSql.Append("community_id,community_total_lf_pop,community_student_lf_pop,community_lf_age_bet_16_and_29_pop,community_lf_age_bet_30_and_39_pop,community_lf_age_bet_40_and_49_pop,community_lf_age_larger_than_50_pop,community_illiterate_lf_pop,community_primary_school_education_lf_pop,community_middle_school_education_lf_pop,community_senior_school_education_lf_pop,community_college_graduate_lf_pop,community_lf_average_education_year,community_lf_with_no_skill_pop,community_lf_with_junior_skill_pop,community_lf_with_medium_grade_skill_pop,community_lf_with_senior_skill_pop,community_hou_with_no_job_num,community_immigrant_hou_with_no_job_num,community_lf_having_a_job_pop,community_ai_employee_pop,community_enterprise_employee_pop,community_part_time_job_pop,community_migrant_workers_pop,community_household_management_pop,community_no_job_pop,community_have_job_pop,community_farmer_pop,community_industrial_employment_pop,community_buil_industrial_employment_pop,community_transport_employment_pop,community_whs_and_retail_employment_pop,community_catering_accomm_employment_pop,community_other_service_employment_pop,community_empm_information_platform,community_entp_supportive_policy,community_enp_supportive_num,community_public_spirited_job_num,statistics_date,tcleunset1,tcleunset2,tcleunset3,tcleunset4,tcleunset5,tcleunset6,tcleunset7,tcleunset8,tcleunset9,tcleunset10,tcleunset11,tcleunset12,tcleunset13,tcleunset14,tcleunset15,tcleunset16,tcleunset17,tcleunset18,tcleunset19,tcleunset20,tcleunset21,tcleunset22,tcleunset23,tcleunset24,tcleunset25,tcleunset26,tcleunset27,tcleunset28,tcleunset29,tcleunset30,tcleunset31,tcleunset32,tcleunset33,tcleunset34,tcleunset35,tcleunset36,tcleunset37,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_total_lf_pop,@community_student_lf_pop,@community_lf_age_bet_16_and_29_pop,@community_lf_age_bet_30_and_39_pop,@community_lf_age_bet_40_and_49_pop,@community_lf_age_larger_than_50_pop,@community_illiterate_lf_pop,@community_primary_school_education_lf_pop,@community_middle_school_education_lf_pop,@community_senior_school_education_lf_pop,@community_college_graduate_lf_pop,@community_lf_average_education_year,@community_lf_with_no_skill_pop,@community_lf_with_junior_skill_pop,@community_lf_with_medium_grade_skill_pop,@community_lf_with_senior_skill_pop,@community_hou_with_no_job_num,@community_immigrant_hou_with_no_job_num,@community_lf_having_a_job_pop,@community_ai_employee_pop,@community_enterprise_employee_pop,@community_part_time_job_pop,@community_migrant_workers_pop,@community_household_management_pop,@community_no_job_pop,@community_have_job_pop,@community_farmer_pop,@community_industrial_employment_pop,@community_buil_industrial_employment_pop,@community_transport_employment_pop,@community_whs_and_retail_employment_pop,@community_catering_accomm_employment_pop,@community_other_service_employment_pop,@community_empm_information_platform,@community_entp_supportive_policy,@community_enp_supportive_num,@community_public_spirited_job_num,@statistics_date,@tcleunset1,@tcleunset2,@tcleunset3,@tcleunset4,@tcleunset5,@tcleunset6,@tcleunset7,@tcleunset8,@tcleunset9,@tcleunset10,@tcleunset11,@tcleunset12,@tcleunset13,@tcleunset14,@tcleunset15,@tcleunset16,@tcleunset17,@tcleunset18,@tcleunset19,@tcleunset20,@tcleunset21,@tcleunset22,@tcleunset23,@tcleunset24,@tcleunset25,@tcleunset26,@tcleunset27,@tcleunset28,@tcleunset29,@tcleunset30,@tcleunset31,@tcleunset32,@tcleunset33,@tcleunset34,@tcleunset35,@tcleunset36,@tcleunset37,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_total_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@community_student_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_age_bet_16_and_29_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_age_bet_30_and_39_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_age_bet_40_and_49_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_age_larger_than_50_pop", SqlDbType.Int,4),
					new SqlParameter("@community_illiterate_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@community_primary_school_education_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@community_middle_school_education_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@community_senior_school_education_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@community_college_graduate_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_average_education_year", SqlDbType.Float,8),
					new SqlParameter("@community_lf_with_no_skill_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_with_junior_skill_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_with_medium_grade_skill_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_with_senior_skill_pop", SqlDbType.Int,4),
					new SqlParameter("@community_hou_with_no_job_num", SqlDbType.Int,4),
					new SqlParameter("@community_immigrant_hou_with_no_job_num", SqlDbType.Int,4),
					new SqlParameter("@community_lf_having_a_job_pop", SqlDbType.Int,4),
					new SqlParameter("@community_ai_employee_pop", SqlDbType.Int,4),
					new SqlParameter("@community_enterprise_employee_pop", SqlDbType.Int,4),
					new SqlParameter("@community_part_time_job_pop", SqlDbType.Int,4),
					new SqlParameter("@community_migrant_workers_pop", SqlDbType.Int,4),
					new SqlParameter("@community_household_management_pop", SqlDbType.Int,4),
					new SqlParameter("@community_no_job_pop", SqlDbType.Int,4),
					new SqlParameter("@community_have_job_pop", SqlDbType.Int,4),
					new SqlParameter("@community_farmer_pop", SqlDbType.Int,4),
					new SqlParameter("@community_industrial_employment_pop", SqlDbType.Int,4),
					new SqlParameter("@community_buil_industrial_employment_pop", SqlDbType.Int,4),
					new SqlParameter("@community_transport_employment_pop", SqlDbType.Int,4),
					new SqlParameter("@community_whs_and_retail_employment_pop", SqlDbType.Int,4),
					new SqlParameter("@community_catering_accomm_employment_pop", SqlDbType.Int,4),
					new SqlParameter("@community_other_service_employment_pop", SqlDbType.Int,4),
					new SqlParameter("@community_empm_information_platform", SqlDbType.VarChar,5),
					new SqlParameter("@community_entp_supportive_policy", SqlDbType.VarChar,5),
					new SqlParameter("@community_enp_supportive_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_spirited_job_num", SqlDbType.Int,4),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcleunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset21", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset22", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset23", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset24", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset25", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset26", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset27", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset28", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset29", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset30", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset31", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset32", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset33", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset34", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset35", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset36", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset37", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_total_lf_pop;
			parameters[2].Value = model.community_student_lf_pop;
			parameters[3].Value = model.community_lf_age_bet_16_and_29_pop;
			parameters[4].Value = model.community_lf_age_bet_30_and_39_pop;
			parameters[5].Value = model.community_lf_age_bet_40_and_49_pop;
			parameters[6].Value = model.community_lf_age_larger_than_50_pop;
			parameters[7].Value = model.community_illiterate_lf_pop;
			parameters[8].Value = model.community_primary_school_education_lf_pop;
			parameters[9].Value = model.community_middle_school_education_lf_pop;
			parameters[10].Value = model.community_senior_school_education_lf_pop;
			parameters[11].Value = model.community_college_graduate_lf_pop;
			parameters[12].Value = model.community_lf_average_education_year;
			parameters[13].Value = model.community_lf_with_no_skill_pop;
			parameters[14].Value = model.community_lf_with_junior_skill_pop;
			parameters[15].Value = model.community_lf_with_medium_grade_skill_pop;
			parameters[16].Value = model.community_lf_with_senior_skill_pop;
			parameters[17].Value = model.community_hou_with_no_job_num;
			parameters[18].Value = model.community_immigrant_hou_with_no_job_num;
			parameters[19].Value = model.community_lf_having_a_job_pop;
			parameters[20].Value = model.community_ai_employee_pop;
			parameters[21].Value = model.community_enterprise_employee_pop;
			parameters[22].Value = model.community_part_time_job_pop;
			parameters[23].Value = model.community_migrant_workers_pop;
			parameters[24].Value = model.community_household_management_pop;
			parameters[25].Value = model.community_no_job_pop;
			parameters[26].Value = model.community_have_job_pop;
			parameters[27].Value = model.community_farmer_pop;
			parameters[28].Value = model.community_industrial_employment_pop;
			parameters[29].Value = model.community_buil_industrial_employment_pop;
			parameters[30].Value = model.community_transport_employment_pop;
			parameters[31].Value = model.community_whs_and_retail_employment_pop;
			parameters[32].Value = model.community_catering_accomm_employment_pop;
			parameters[33].Value = model.community_other_service_employment_pop;
			parameters[34].Value = model.community_empm_information_platform;
			parameters[35].Value = model.community_entp_supportive_policy;
			parameters[36].Value = model.community_enp_supportive_num;
			parameters[37].Value = model.community_public_spirited_job_num;
			parameters[38].Value = model.statistics_date;
			parameters[39].Value = model.tcleunset1;
			parameters[40].Value = model.tcleunset2;
			parameters[41].Value = model.tcleunset3;
			parameters[42].Value = model.tcleunset4;
			parameters[43].Value = model.tcleunset5;
			parameters[44].Value = model.tcleunset6;
			parameters[45].Value = model.tcleunset7;
			parameters[46].Value = model.tcleunset8;
			parameters[47].Value = model.tcleunset9;
			parameters[48].Value = model.tcleunset10;
			parameters[49].Value = model.tcleunset11;
			parameters[50].Value = model.tcleunset12;
			parameters[51].Value = model.tcleunset13;
			parameters[52].Value = model.tcleunset14;
			parameters[53].Value = model.tcleunset15;
			parameters[54].Value = model.tcleunset16;
			parameters[55].Value = model.tcleunset17;
			parameters[56].Value = model.tcleunset18;
			parameters[57].Value = model.tcleunset19;
			parameters[58].Value = model.tcleunset20;
			parameters[59].Value = model.tcleunset21;
			parameters[60].Value = model.tcleunset22;
			parameters[61].Value = model.tcleunset23;
			parameters[62].Value = model.tcleunset24;
			parameters[63].Value = model.tcleunset25;
			parameters[64].Value = model.tcleunset26;
			parameters[65].Value = model.tcleunset27;
			parameters[66].Value = model.tcleunset28;
			parameters[67].Value = model.tcleunset29;
			parameters[68].Value = model.tcleunset30;
			parameters[69].Value = model.tcleunset31;
			parameters[70].Value = model.tcleunset32;
			parameters[71].Value = model.tcleunset33;
			parameters[72].Value = model.tcleunset34;
			parameters[73].Value = model.tcleunset35;
			parameters[74].Value = model.tcleunset36;
			parameters[75].Value = model.tcleunset37;
			parameters[76].Value = model.lock_tables;
			parameters[77].Value = model.check_status;

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
		public bool Update(TTG.Model.TTGWeb.community_lf_employment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_lf_employment set ");
			strSql.Append("community_total_lf_pop=@community_total_lf_pop,");
			strSql.Append("community_student_lf_pop=@community_student_lf_pop,");
			strSql.Append("community_lf_age_bet_16_and_29_pop=@community_lf_age_bet_16_and_29_pop,");
			strSql.Append("community_lf_age_bet_30_and_39_pop=@community_lf_age_bet_30_and_39_pop,");
			strSql.Append("community_lf_age_bet_40_and_49_pop=@community_lf_age_bet_40_and_49_pop,");
			strSql.Append("community_lf_age_larger_than_50_pop=@community_lf_age_larger_than_50_pop,");
			strSql.Append("community_illiterate_lf_pop=@community_illiterate_lf_pop,");
			strSql.Append("community_primary_school_education_lf_pop=@community_primary_school_education_lf_pop,");
			strSql.Append("community_middle_school_education_lf_pop=@community_middle_school_education_lf_pop,");
			strSql.Append("community_senior_school_education_lf_pop=@community_senior_school_education_lf_pop,");
			strSql.Append("community_college_graduate_lf_pop=@community_college_graduate_lf_pop,");
			strSql.Append("community_lf_average_education_year=@community_lf_average_education_year,");
			strSql.Append("community_lf_with_no_skill_pop=@community_lf_with_no_skill_pop,");
			strSql.Append("community_lf_with_junior_skill_pop=@community_lf_with_junior_skill_pop,");
			strSql.Append("community_lf_with_medium_grade_skill_pop=@community_lf_with_medium_grade_skill_pop,");
			strSql.Append("community_lf_with_senior_skill_pop=@community_lf_with_senior_skill_pop,");
			strSql.Append("community_hou_with_no_job_num=@community_hou_with_no_job_num,");
			strSql.Append("community_immigrant_hou_with_no_job_num=@community_immigrant_hou_with_no_job_num,");
			strSql.Append("community_lf_having_a_job_pop=@community_lf_having_a_job_pop,");
			strSql.Append("community_ai_employee_pop=@community_ai_employee_pop,");
			strSql.Append("community_enterprise_employee_pop=@community_enterprise_employee_pop,");
			strSql.Append("community_part_time_job_pop=@community_part_time_job_pop,");
			strSql.Append("community_migrant_workers_pop=@community_migrant_workers_pop,");
			strSql.Append("community_household_management_pop=@community_household_management_pop,");
			strSql.Append("community_no_job_pop=@community_no_job_pop,");
			strSql.Append("community_have_job_pop=@community_have_job_pop,");
			strSql.Append("community_farmer_pop=@community_farmer_pop,");
			strSql.Append("community_industrial_employment_pop=@community_industrial_employment_pop,");
			strSql.Append("community_buil_industrial_employment_pop=@community_buil_industrial_employment_pop,");
			strSql.Append("community_transport_employment_pop=@community_transport_employment_pop,");
			strSql.Append("community_whs_and_retail_employment_pop=@community_whs_and_retail_employment_pop,");
			strSql.Append("community_catering_accomm_employment_pop=@community_catering_accomm_employment_pop,");
			strSql.Append("community_other_service_employment_pop=@community_other_service_employment_pop,");
			strSql.Append("community_empm_information_platform=@community_empm_information_platform,");
			strSql.Append("community_entp_supportive_policy=@community_entp_supportive_policy,");
			strSql.Append("community_enp_supportive_num=@community_enp_supportive_num,");
			strSql.Append("community_public_spirited_job_num=@community_public_spirited_job_num,");
			strSql.Append("tcleunset1=@tcleunset1,");
			strSql.Append("tcleunset2=@tcleunset2,");
			strSql.Append("tcleunset3=@tcleunset3,");
			strSql.Append("tcleunset4=@tcleunset4,");
			strSql.Append("tcleunset5=@tcleunset5,");
			strSql.Append("tcleunset6=@tcleunset6,");
			strSql.Append("tcleunset7=@tcleunset7,");
			strSql.Append("tcleunset8=@tcleunset8,");
			strSql.Append("tcleunset9=@tcleunset9,");
			strSql.Append("tcleunset10=@tcleunset10,");
			strSql.Append("tcleunset11=@tcleunset11,");
			strSql.Append("tcleunset12=@tcleunset12,");
			strSql.Append("tcleunset13=@tcleunset13,");
			strSql.Append("tcleunset14=@tcleunset14,");
			strSql.Append("tcleunset15=@tcleunset15,");
			strSql.Append("tcleunset16=@tcleunset16,");
			strSql.Append("tcleunset17=@tcleunset17,");
			strSql.Append("tcleunset18=@tcleunset18,");
			strSql.Append("tcleunset19=@tcleunset19,");
			strSql.Append("tcleunset20=@tcleunset20,");
			strSql.Append("tcleunset21=@tcleunset21,");
			strSql.Append("tcleunset22=@tcleunset22,");
			strSql.Append("tcleunset23=@tcleunset23,");
			strSql.Append("tcleunset24=@tcleunset24,");
			strSql.Append("tcleunset25=@tcleunset25,");
			strSql.Append("tcleunset26=@tcleunset26,");
			strSql.Append("tcleunset27=@tcleunset27,");
			strSql.Append("tcleunset28=@tcleunset28,");
			strSql.Append("tcleunset29=@tcleunset29,");
			strSql.Append("tcleunset30=@tcleunset30,");
			strSql.Append("tcleunset31=@tcleunset31,");
			strSql.Append("tcleunset32=@tcleunset32,");
			strSql.Append("tcleunset33=@tcleunset33,");
			strSql.Append("tcleunset34=@tcleunset34,");
			strSql.Append("tcleunset35=@tcleunset35,");
			strSql.Append("tcleunset36=@tcleunset36,");
			strSql.Append("tcleunset37=@tcleunset37,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_total_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@community_student_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_age_bet_16_and_29_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_age_bet_30_and_39_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_age_bet_40_and_49_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_age_larger_than_50_pop", SqlDbType.Int,4),
					new SqlParameter("@community_illiterate_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@community_primary_school_education_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@community_middle_school_education_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@community_senior_school_education_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@community_college_graduate_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_average_education_year", SqlDbType.Float,8),
					new SqlParameter("@community_lf_with_no_skill_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_with_junior_skill_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_with_medium_grade_skill_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lf_with_senior_skill_pop", SqlDbType.Int,4),
					new SqlParameter("@community_hou_with_no_job_num", SqlDbType.Int,4),
					new SqlParameter("@community_immigrant_hou_with_no_job_num", SqlDbType.Int,4),
					new SqlParameter("@community_lf_having_a_job_pop", SqlDbType.Int,4),
					new SqlParameter("@community_ai_employee_pop", SqlDbType.Int,4),
					new SqlParameter("@community_enterprise_employee_pop", SqlDbType.Int,4),
					new SqlParameter("@community_part_time_job_pop", SqlDbType.Int,4),
					new SqlParameter("@community_migrant_workers_pop", SqlDbType.Int,4),
					new SqlParameter("@community_household_management_pop", SqlDbType.Int,4),
					new SqlParameter("@community_no_job_pop", SqlDbType.Int,4),
					new SqlParameter("@community_have_job_pop", SqlDbType.Int,4),
					new SqlParameter("@community_farmer_pop", SqlDbType.Int,4),
					new SqlParameter("@community_industrial_employment_pop", SqlDbType.Int,4),
					new SqlParameter("@community_buil_industrial_employment_pop", SqlDbType.Int,4),
					new SqlParameter("@community_transport_employment_pop", SqlDbType.Int,4),
					new SqlParameter("@community_whs_and_retail_employment_pop", SqlDbType.Int,4),
					new SqlParameter("@community_catering_accomm_employment_pop", SqlDbType.Int,4),
					new SqlParameter("@community_other_service_employment_pop", SqlDbType.Int,4),
					new SqlParameter("@community_empm_information_platform", SqlDbType.VarChar,5),
					new SqlParameter("@community_entp_supportive_policy", SqlDbType.VarChar,5),
					new SqlParameter("@community_enp_supportive_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_spirited_job_num", SqlDbType.Int,4),
					new SqlParameter("@tcleunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset21", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset22", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset23", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset24", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset25", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset26", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset27", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset28", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset29", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset30", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset31", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset32", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset33", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset34", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset35", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset36", SqlDbType.VarChar,50),
					new SqlParameter("@tcleunset37", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_total_lf_pop;
			parameters[1].Value = model.community_student_lf_pop;
			parameters[2].Value = model.community_lf_age_bet_16_and_29_pop;
			parameters[3].Value = model.community_lf_age_bet_30_and_39_pop;
			parameters[4].Value = model.community_lf_age_bet_40_and_49_pop;
			parameters[5].Value = model.community_lf_age_larger_than_50_pop;
			parameters[6].Value = model.community_illiterate_lf_pop;
			parameters[7].Value = model.community_primary_school_education_lf_pop;
			parameters[8].Value = model.community_middle_school_education_lf_pop;
			parameters[9].Value = model.community_senior_school_education_lf_pop;
			parameters[10].Value = model.community_college_graduate_lf_pop;
			parameters[11].Value = model.community_lf_average_education_year;
			parameters[12].Value = model.community_lf_with_no_skill_pop;
			parameters[13].Value = model.community_lf_with_junior_skill_pop;
			parameters[14].Value = model.community_lf_with_medium_grade_skill_pop;
			parameters[15].Value = model.community_lf_with_senior_skill_pop;
			parameters[16].Value = model.community_hou_with_no_job_num;
			parameters[17].Value = model.community_immigrant_hou_with_no_job_num;
			parameters[18].Value = model.community_lf_having_a_job_pop;
			parameters[19].Value = model.community_ai_employee_pop;
			parameters[20].Value = model.community_enterprise_employee_pop;
			parameters[21].Value = model.community_part_time_job_pop;
			parameters[22].Value = model.community_migrant_workers_pop;
			parameters[23].Value = model.community_household_management_pop;
			parameters[24].Value = model.community_no_job_pop;
			parameters[25].Value = model.community_have_job_pop;
			parameters[26].Value = model.community_farmer_pop;
			parameters[27].Value = model.community_industrial_employment_pop;
			parameters[28].Value = model.community_buil_industrial_employment_pop;
			parameters[29].Value = model.community_transport_employment_pop;
			parameters[30].Value = model.community_whs_and_retail_employment_pop;
			parameters[31].Value = model.community_catering_accomm_employment_pop;
			parameters[32].Value = model.community_other_service_employment_pop;
			parameters[33].Value = model.community_empm_information_platform;
			parameters[34].Value = model.community_entp_supportive_policy;
			parameters[35].Value = model.community_enp_supportive_num;
			parameters[36].Value = model.community_public_spirited_job_num;
			parameters[37].Value = model.tcleunset1;
			parameters[38].Value = model.tcleunset2;
			parameters[39].Value = model.tcleunset3;
			parameters[40].Value = model.tcleunset4;
			parameters[41].Value = model.tcleunset5;
			parameters[42].Value = model.tcleunset6;
			parameters[43].Value = model.tcleunset7;
			parameters[44].Value = model.tcleunset8;
			parameters[45].Value = model.tcleunset9;
			parameters[46].Value = model.tcleunset10;
			parameters[47].Value = model.tcleunset11;
			parameters[48].Value = model.tcleunset12;
			parameters[49].Value = model.tcleunset13;
			parameters[50].Value = model.tcleunset14;
			parameters[51].Value = model.tcleunset15;
			parameters[52].Value = model.tcleunset16;
			parameters[53].Value = model.tcleunset17;
			parameters[54].Value = model.tcleunset18;
			parameters[55].Value = model.tcleunset19;
			parameters[56].Value = model.tcleunset20;
			parameters[57].Value = model.tcleunset21;
			parameters[58].Value = model.tcleunset22;
			parameters[59].Value = model.tcleunset23;
			parameters[60].Value = model.tcleunset24;
			parameters[61].Value = model.tcleunset25;
			parameters[62].Value = model.tcleunset26;
			parameters[63].Value = model.tcleunset27;
			parameters[64].Value = model.tcleunset28;
			parameters[65].Value = model.tcleunset29;
			parameters[66].Value = model.tcleunset30;
			parameters[67].Value = model.tcleunset31;
			parameters[68].Value = model.tcleunset32;
			parameters[69].Value = model.tcleunset33;
			parameters[70].Value = model.tcleunset34;
			parameters[71].Value = model.tcleunset35;
			parameters[72].Value = model.tcleunset36;
			parameters[73].Value = model.tcleunset37;
			parameters[74].Value = model.lock_tables;
			parameters[75].Value = model.check_status;
			parameters[76].Value = model.community_id;
			parameters[77].Value = model.statistics_date;

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
		public bool Delete(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_community_lf_employment ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

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
		public TTG.Model.TTGWeb.community_lf_employment GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_total_lf_pop,community_student_lf_pop,community_lf_age_bet_16_and_29_pop,community_lf_age_bet_30_and_39_pop,community_lf_age_bet_40_and_49_pop,community_lf_age_larger_than_50_pop,community_illiterate_lf_pop,community_primary_school_education_lf_pop,community_middle_school_education_lf_pop,community_senior_school_education_lf_pop,community_college_graduate_lf_pop,community_lf_average_education_year,community_lf_with_no_skill_pop,community_lf_with_junior_skill_pop,community_lf_with_medium_grade_skill_pop,community_lf_with_senior_skill_pop,community_hou_with_no_job_num,community_immigrant_hou_with_no_job_num,community_lf_having_a_job_pop,community_ai_employee_pop,community_enterprise_employee_pop,community_part_time_job_pop,community_migrant_workers_pop,community_household_management_pop,community_no_job_pop,community_have_job_pop,community_farmer_pop,community_industrial_employment_pop,community_buil_industrial_employment_pop,community_transport_employment_pop,community_whs_and_retail_employment_pop,community_catering_accomm_employment_pop,community_other_service_employment_pop,community_empm_information_platform,community_entp_supportive_policy,community_enp_supportive_num,community_public_spirited_job_num,statistics_date,tcleunset1,tcleunset2,tcleunset3,tcleunset4,tcleunset5,tcleunset6,tcleunset7,tcleunset8,tcleunset9,tcleunset10,tcleunset11,tcleunset12,tcleunset13,tcleunset14,tcleunset15,tcleunset16,tcleunset17,tcleunset18,tcleunset19,tcleunset20,tcleunset21,tcleunset22,tcleunset23,tcleunset24,tcleunset25,tcleunset26,tcleunset27,tcleunset28,tcleunset29,tcleunset30,tcleunset31,tcleunset32,tcleunset33,tcleunset34,tcleunset35,tcleunset36,tcleunset37,lock_tables,check_status from T_community_lf_employment ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_lf_employment model=new TTG.Model.TTGWeb.community_lf_employment();
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
		public TTG.Model.TTGWeb.community_lf_employment DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_lf_employment model=new TTG.Model.TTGWeb.community_lf_employment();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_total_lf_pop"]!=null && row["community_total_lf_pop"].ToString()!="")
				{
					model.community_total_lf_pop=int.Parse(row["community_total_lf_pop"].ToString());
				}
				if(row["community_student_lf_pop"]!=null && row["community_student_lf_pop"].ToString()!="")
				{
					model.community_student_lf_pop=int.Parse(row["community_student_lf_pop"].ToString());
				}
				if(row["community_lf_age_bet_16_and_29_pop"]!=null && row["community_lf_age_bet_16_and_29_pop"].ToString()!="")
				{
					model.community_lf_age_bet_16_and_29_pop=int.Parse(row["community_lf_age_bet_16_and_29_pop"].ToString());
				}
				if(row["community_lf_age_bet_30_and_39_pop"]!=null && row["community_lf_age_bet_30_and_39_pop"].ToString()!="")
				{
					model.community_lf_age_bet_30_and_39_pop=int.Parse(row["community_lf_age_bet_30_and_39_pop"].ToString());
				}
				if(row["community_lf_age_bet_40_and_49_pop"]!=null && row["community_lf_age_bet_40_and_49_pop"].ToString()!="")
				{
					model.community_lf_age_bet_40_and_49_pop=int.Parse(row["community_lf_age_bet_40_and_49_pop"].ToString());
				}
				if(row["community_lf_age_larger_than_50_pop"]!=null && row["community_lf_age_larger_than_50_pop"].ToString()!="")
				{
					model.community_lf_age_larger_than_50_pop=int.Parse(row["community_lf_age_larger_than_50_pop"].ToString());
				}
				if(row["community_illiterate_lf_pop"]!=null && row["community_illiterate_lf_pop"].ToString()!="")
				{
					model.community_illiterate_lf_pop=int.Parse(row["community_illiterate_lf_pop"].ToString());
				}
				if(row["community_primary_school_education_lf_pop"]!=null && row["community_primary_school_education_lf_pop"].ToString()!="")
				{
					model.community_primary_school_education_lf_pop=int.Parse(row["community_primary_school_education_lf_pop"].ToString());
				}
				if(row["community_middle_school_education_lf_pop"]!=null && row["community_middle_school_education_lf_pop"].ToString()!="")
				{
					model.community_middle_school_education_lf_pop=int.Parse(row["community_middle_school_education_lf_pop"].ToString());
				}
				if(row["community_senior_school_education_lf_pop"]!=null && row["community_senior_school_education_lf_pop"].ToString()!="")
				{
					model.community_senior_school_education_lf_pop=int.Parse(row["community_senior_school_education_lf_pop"].ToString());
				}
				if(row["community_college_graduate_lf_pop"]!=null && row["community_college_graduate_lf_pop"].ToString()!="")
				{
					model.community_college_graduate_lf_pop=int.Parse(row["community_college_graduate_lf_pop"].ToString());
				}
				if(row["community_lf_average_education_year"]!=null && row["community_lf_average_education_year"].ToString()!="")
				{
					model.community_lf_average_education_year=decimal.Parse(row["community_lf_average_education_year"].ToString());
				}
				if(row["community_lf_with_no_skill_pop"]!=null && row["community_lf_with_no_skill_pop"].ToString()!="")
				{
					model.community_lf_with_no_skill_pop=int.Parse(row["community_lf_with_no_skill_pop"].ToString());
				}
				if(row["community_lf_with_junior_skill_pop"]!=null && row["community_lf_with_junior_skill_pop"].ToString()!="")
				{
					model.community_lf_with_junior_skill_pop=int.Parse(row["community_lf_with_junior_skill_pop"].ToString());
				}
				if(row["community_lf_with_medium_grade_skill_pop"]!=null && row["community_lf_with_medium_grade_skill_pop"].ToString()!="")
				{
					model.community_lf_with_medium_grade_skill_pop=int.Parse(row["community_lf_with_medium_grade_skill_pop"].ToString());
				}
				if(row["community_lf_with_senior_skill_pop"]!=null && row["community_lf_with_senior_skill_pop"].ToString()!="")
				{
					model.community_lf_with_senior_skill_pop=int.Parse(row["community_lf_with_senior_skill_pop"].ToString());
				}
				if(row["community_hou_with_no_job_num"]!=null && row["community_hou_with_no_job_num"].ToString()!="")
				{
					model.community_hou_with_no_job_num=int.Parse(row["community_hou_with_no_job_num"].ToString());
				}
				if(row["community_immigrant_hou_with_no_job_num"]!=null && row["community_immigrant_hou_with_no_job_num"].ToString()!="")
				{
					model.community_immigrant_hou_with_no_job_num=int.Parse(row["community_immigrant_hou_with_no_job_num"].ToString());
				}
				if(row["community_lf_having_a_job_pop"]!=null && row["community_lf_having_a_job_pop"].ToString()!="")
				{
					model.community_lf_having_a_job_pop=int.Parse(row["community_lf_having_a_job_pop"].ToString());
				}
				if(row["community_ai_employee_pop"]!=null && row["community_ai_employee_pop"].ToString()!="")
				{
					model.community_ai_employee_pop=int.Parse(row["community_ai_employee_pop"].ToString());
				}
				if(row["community_enterprise_employee_pop"]!=null && row["community_enterprise_employee_pop"].ToString()!="")
				{
					model.community_enterprise_employee_pop=int.Parse(row["community_enterprise_employee_pop"].ToString());
				}
				if(row["community_part_time_job_pop"]!=null && row["community_part_time_job_pop"].ToString()!="")
				{
					model.community_part_time_job_pop=int.Parse(row["community_part_time_job_pop"].ToString());
				}
				if(row["community_migrant_workers_pop"]!=null && row["community_migrant_workers_pop"].ToString()!="")
				{
					model.community_migrant_workers_pop=int.Parse(row["community_migrant_workers_pop"].ToString());
				}
				if(row["community_household_management_pop"]!=null && row["community_household_management_pop"].ToString()!="")
				{
					model.community_household_management_pop=int.Parse(row["community_household_management_pop"].ToString());
				}
				if(row["community_no_job_pop"]!=null && row["community_no_job_pop"].ToString()!="")
				{
					model.community_no_job_pop=int.Parse(row["community_no_job_pop"].ToString());
				}
				if(row["community_have_job_pop"]!=null && row["community_have_job_pop"].ToString()!="")
				{
					model.community_have_job_pop=int.Parse(row["community_have_job_pop"].ToString());
				}
				if(row["community_farmer_pop"]!=null && row["community_farmer_pop"].ToString()!="")
				{
					model.community_farmer_pop=int.Parse(row["community_farmer_pop"].ToString());
				}
				if(row["community_industrial_employment_pop"]!=null && row["community_industrial_employment_pop"].ToString()!="")
				{
					model.community_industrial_employment_pop=int.Parse(row["community_industrial_employment_pop"].ToString());
				}
				if(row["community_buil_industrial_employment_pop"]!=null && row["community_buil_industrial_employment_pop"].ToString()!="")
				{
					model.community_buil_industrial_employment_pop=int.Parse(row["community_buil_industrial_employment_pop"].ToString());
				}
				if(row["community_transport_employment_pop"]!=null && row["community_transport_employment_pop"].ToString()!="")
				{
					model.community_transport_employment_pop=int.Parse(row["community_transport_employment_pop"].ToString());
				}
				if(row["community_whs_and_retail_employment_pop"]!=null && row["community_whs_and_retail_employment_pop"].ToString()!="")
				{
					model.community_whs_and_retail_employment_pop=int.Parse(row["community_whs_and_retail_employment_pop"].ToString());
				}
				if(row["community_catering_accomm_employment_pop"]!=null && row["community_catering_accomm_employment_pop"].ToString()!="")
				{
					model.community_catering_accomm_employment_pop=int.Parse(row["community_catering_accomm_employment_pop"].ToString());
				}
				if(row["community_other_service_employment_pop"]!=null && row["community_other_service_employment_pop"].ToString()!="")
				{
					model.community_other_service_employment_pop=int.Parse(row["community_other_service_employment_pop"].ToString());
				}
				if(row["community_empm_information_platform"]!=null)
				{
					model.community_empm_information_platform=row["community_empm_information_platform"].ToString();
				}
				if(row["community_entp_supportive_policy"]!=null)
				{
					model.community_entp_supportive_policy=row["community_entp_supportive_policy"].ToString();
				}
				if(row["community_enp_supportive_num"]!=null && row["community_enp_supportive_num"].ToString()!="")
				{
					model.community_enp_supportive_num=int.Parse(row["community_enp_supportive_num"].ToString());
				}
				if(row["community_public_spirited_job_num"]!=null && row["community_public_spirited_job_num"].ToString()!="")
				{
					model.community_public_spirited_job_num=int.Parse(row["community_public_spirited_job_num"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcleunset1"]!=null)
				{
					model.tcleunset1=row["tcleunset1"].ToString();
				}
				if(row["tcleunset2"]!=null)
				{
					model.tcleunset2=row["tcleunset2"].ToString();
				}
				if(row["tcleunset3"]!=null)
				{
					model.tcleunset3=row["tcleunset3"].ToString();
				}
				if(row["tcleunset4"]!=null)
				{
					model.tcleunset4=row["tcleunset4"].ToString();
				}
				if(row["tcleunset5"]!=null)
				{
					model.tcleunset5=row["tcleunset5"].ToString();
				}
				if(row["tcleunset6"]!=null)
				{
					model.tcleunset6=row["tcleunset6"].ToString();
				}
				if(row["tcleunset7"]!=null)
				{
					model.tcleunset7=row["tcleunset7"].ToString();
				}
				if(row["tcleunset8"]!=null)
				{
					model.tcleunset8=row["tcleunset8"].ToString();
				}
				if(row["tcleunset9"]!=null)
				{
					model.tcleunset9=row["tcleunset9"].ToString();
				}
				if(row["tcleunset10"]!=null)
				{
					model.tcleunset10=row["tcleunset10"].ToString();
				}
				if(row["tcleunset11"]!=null)
				{
					model.tcleunset11=row["tcleunset11"].ToString();
				}
				if(row["tcleunset12"]!=null)
				{
					model.tcleunset12=row["tcleunset12"].ToString();
				}
				if(row["tcleunset13"]!=null)
				{
					model.tcleunset13=row["tcleunset13"].ToString();
				}
				if(row["tcleunset14"]!=null)
				{
					model.tcleunset14=row["tcleunset14"].ToString();
				}
				if(row["tcleunset15"]!=null)
				{
					model.tcleunset15=row["tcleunset15"].ToString();
				}
				if(row["tcleunset16"]!=null)
				{
					model.tcleunset16=row["tcleunset16"].ToString();
				}
				if(row["tcleunset17"]!=null)
				{
					model.tcleunset17=row["tcleunset17"].ToString();
				}
				if(row["tcleunset18"]!=null)
				{
					model.tcleunset18=row["tcleunset18"].ToString();
				}
				if(row["tcleunset19"]!=null)
				{
					model.tcleunset19=row["tcleunset19"].ToString();
				}
				if(row["tcleunset20"]!=null)
				{
					model.tcleunset20=row["tcleunset20"].ToString();
				}
				if(row["tcleunset21"]!=null)
				{
					model.tcleunset21=row["tcleunset21"].ToString();
				}
				if(row["tcleunset22"]!=null)
				{
					model.tcleunset22=row["tcleunset22"].ToString();
				}
				if(row["tcleunset23"]!=null)
				{
					model.tcleunset23=row["tcleunset23"].ToString();
				}
				if(row["tcleunset24"]!=null)
				{
					model.tcleunset24=row["tcleunset24"].ToString();
				}
				if(row["tcleunset25"]!=null)
				{
					model.tcleunset25=row["tcleunset25"].ToString();
				}
				if(row["tcleunset26"]!=null)
				{
					model.tcleunset26=row["tcleunset26"].ToString();
				}
				if(row["tcleunset27"]!=null)
				{
					model.tcleunset27=row["tcleunset27"].ToString();
				}
				if(row["tcleunset28"]!=null)
				{
					model.tcleunset28=row["tcleunset28"].ToString();
				}
				if(row["tcleunset29"]!=null)
				{
					model.tcleunset29=row["tcleunset29"].ToString();
				}
				if(row["tcleunset30"]!=null)
				{
					model.tcleunset30=row["tcleunset30"].ToString();
				}
				if(row["tcleunset31"]!=null)
				{
					model.tcleunset31=row["tcleunset31"].ToString();
				}
				if(row["tcleunset32"]!=null)
				{
					model.tcleunset32=row["tcleunset32"].ToString();
				}
				if(row["tcleunset33"]!=null)
				{
					model.tcleunset33=row["tcleunset33"].ToString();
				}
				if(row["tcleunset34"]!=null)
				{
					model.tcleunset34=row["tcleunset34"].ToString();
				}
				if(row["tcleunset35"]!=null)
				{
					model.tcleunset35=row["tcleunset35"].ToString();
				}
				if(row["tcleunset36"]!=null)
				{
					model.tcleunset36=row["tcleunset36"].ToString();
				}
				if(row["tcleunset37"]!=null)
				{
					model.tcleunset37=row["tcleunset37"].ToString();
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
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
			strSql.Append("select community_id,community_total_lf_pop,community_student_lf_pop,community_lf_age_bet_16_and_29_pop,community_lf_age_bet_30_and_39_pop,community_lf_age_bet_40_and_49_pop,community_lf_age_larger_than_50_pop,community_illiterate_lf_pop,community_primary_school_education_lf_pop,community_middle_school_education_lf_pop,community_senior_school_education_lf_pop,community_college_graduate_lf_pop,community_lf_average_education_year,community_lf_with_no_skill_pop,community_lf_with_junior_skill_pop,community_lf_with_medium_grade_skill_pop,community_lf_with_senior_skill_pop,community_hou_with_no_job_num,community_immigrant_hou_with_no_job_num,community_lf_having_a_job_pop,community_ai_employee_pop,community_enterprise_employee_pop,community_part_time_job_pop,community_migrant_workers_pop,community_household_management_pop,community_no_job_pop,community_have_job_pop,community_farmer_pop,community_industrial_employment_pop,community_buil_industrial_employment_pop,community_transport_employment_pop,community_whs_and_retail_employment_pop,community_catering_accomm_employment_pop,community_other_service_employment_pop,community_empm_information_platform,community_entp_supportive_policy,community_enp_supportive_num,community_public_spirited_job_num,statistics_date,tcleunset1,tcleunset2,tcleunset3,tcleunset4,tcleunset5,tcleunset6,tcleunset7,tcleunset8,tcleunset9,tcleunset10,tcleunset11,tcleunset12,tcleunset13,tcleunset14,tcleunset15,tcleunset16,tcleunset17,tcleunset18,tcleunset19,tcleunset20,tcleunset21,tcleunset22,tcleunset23,tcleunset24,tcleunset25,tcleunset26,tcleunset27,tcleunset28,tcleunset29,tcleunset30,tcleunset31,tcleunset32,tcleunset33,tcleunset34,tcleunset35,tcleunset36,tcleunset37,lock_tables,check_status ");
			strSql.Append(" FROM T_community_lf_employment ");
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
			strSql.Append(" community_id,community_total_lf_pop,community_student_lf_pop,community_lf_age_bet_16_and_29_pop,community_lf_age_bet_30_and_39_pop,community_lf_age_bet_40_and_49_pop,community_lf_age_larger_than_50_pop,community_illiterate_lf_pop,community_primary_school_education_lf_pop,community_middle_school_education_lf_pop,community_senior_school_education_lf_pop,community_college_graduate_lf_pop,community_lf_average_education_year,community_lf_with_no_skill_pop,community_lf_with_junior_skill_pop,community_lf_with_medium_grade_skill_pop,community_lf_with_senior_skill_pop,community_hou_with_no_job_num,community_immigrant_hou_with_no_job_num,community_lf_having_a_job_pop,community_ai_employee_pop,community_enterprise_employee_pop,community_part_time_job_pop,community_migrant_workers_pop,community_household_management_pop,community_no_job_pop,community_have_job_pop,community_farmer_pop,community_industrial_employment_pop,community_buil_industrial_employment_pop,community_transport_employment_pop,community_whs_and_retail_employment_pop,community_catering_accomm_employment_pop,community_other_service_employment_pop,community_empm_information_platform,community_entp_supportive_policy,community_enp_supportive_num,community_public_spirited_job_num,statistics_date,tcleunset1,tcleunset2,tcleunset3,tcleunset4,tcleunset5,tcleunset6,tcleunset7,tcleunset8,tcleunset9,tcleunset10,tcleunset11,tcleunset12,tcleunset13,tcleunset14,tcleunset15,tcleunset16,tcleunset17,tcleunset18,tcleunset19,tcleunset20,tcleunset21,tcleunset22,tcleunset23,tcleunset24,tcleunset25,tcleunset26,tcleunset27,tcleunset28,tcleunset29,tcleunset30,tcleunset31,tcleunset32,tcleunset33,tcleunset34,tcleunset35,tcleunset36,tcleunset37,lock_tables,check_status ");
			strSql.Append(" FROM T_community_lf_employment ");
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
			strSql.Append("select count(1) FROM T_community_lf_employment ");
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
				strSql.Append("order by T.statistics_date desc");
			}
			strSql.Append(")AS Row, T.*  from T_community_lf_employment T ");
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
			parameters[0].Value = "T_community_lf_employment";
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
        /// <summary>
        /// 获取一个对象实体
        /// </summary>
        /// <param name="community_id"></param>
        /// <returns></returns>
        public TTG.Model.TTGWeb.community_lf_employment GetModel(string community_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 community_id,community_total_lf_pop,community_student_lf_pop,community_lf_age_bet_16_and_29_pop,community_lf_age_bet_30_and_39_pop,community_lf_age_bet_40_and_49_pop,community_lf_age_larger_than_50_pop,community_illiterate_lf_pop,community_primary_school_education_lf_pop,community_middle_school_education_lf_pop,community_senior_school_education_lf_pop,community_college_graduate_lf_pop,community_lf_average_education_year,community_lf_with_no_skill_pop,community_lf_with_junior_skill_pop,community_lf_with_medium_grade_skill_pop,community_lf_with_senior_skill_pop,community_hou_with_no_job_num,community_immigrant_hou_with_no_job_num,community_lf_having_a_job_pop,community_ai_employee_pop,community_enterprise_employee_pop,community_part_time_job_pop,community_migrant_workers_pop,community_household_management_pop,community_no_job_pop,community_have_job_pop,community_farmer_pop,community_industrial_employment_pop,community_buil_industrial_employment_pop,community_transport_employment_pop,community_whs_and_retail_employment_pop,community_catering_accomm_employment_pop,community_other_service_employment_pop,community_empm_information_platform,community_entp_supportive_policy,community_enp_supportive_num,community_public_spirited_job_num,statistics_date,tcleunset1,tcleunset2,tcleunset3,tcleunset4,tcleunset5,tcleunset6,tcleunset7,tcleunset8,tcleunset9,tcleunset10,tcleunset11,tcleunset12,tcleunset13,tcleunset14,tcleunset15,tcleunset16,tcleunset17,tcleunset18,tcleunset19,tcleunset20,tcleunset21,tcleunset22,tcleunset23,tcleunset24,tcleunset25,tcleunset26,tcleunset27,tcleunset28,tcleunset29,tcleunset30,tcleunset31,tcleunset32,tcleunset33,tcleunset34,tcleunset35,tcleunset36,tcleunset37,lock_tables,check_status from T_community_lf_employment ");
            strSql.Append(" where community_id=@community_id order by statistics_date desc");
            SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20)			};
            parameters[0].Value = community_id;

            TTG.Model.TTGWeb.community_lf_employment model = new TTG.Model.TTGWeb.community_lf_employment();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获取某一时间段内的数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="start_time"></param>
        /// <param name="end_time"></param>
        /// <returns></returns>
        public DataSet getListByTime(string id, DateTime start_time, DateTime end_time)
        {
            string sql = "select * from T_community_lf_employment" +
                "where community_id = '" + id + "' and statistics_date >= " + start_time + " and statistics_date<" + end_time;
            return DbHelperSQL.Query(sql);
        }
		#endregion  ExtensionMethod
	}
}

