using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_population
	/// </summary>
	public partial class community_population
	{
		public community_population()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_population");
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
		public bool Add(TTG.Model.TTGWeb.community_population model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_population(");
			strSql.Append("community_id,community_total_pop,community_reg_pop,community_perm_pop,community_man_pop,community_female_pop,community_younger_6_pop,community_bet_7_and_15_pop,community_bet_16_and_29_pop,community_bet_30_and_39_pop,community_bet_40_and_49_pop,community_older_50_pop,community_illiteracy_pop,community_prim_school_edu_pop,community_junior_high_school_edu_pop,community_senior_high_school_edu_pop,community_junior_college_edu_pop,average_education_time,statistics_date,tcpunset1,tcpunset2,tcpunset3,tcpunset4,tcpunset5,tcpunset6,tcpunset7,tcpunset8,tcpunset10,tcpunset11,tcpunset12,tcpunset13,tcpunset14,tcpunset15,tcpunset16,tcpunset17,check_status,lock_tables,community_family_num)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_total_pop,@community_reg_pop,@community_perm_pop,@community_man_pop,@community_female_pop,@community_younger_6_pop,@community_bet_7_and_15_pop,@community_bet_16_and_29_pop,@community_bet_30_and_39_pop,@community_bet_40_and_49_pop,@community_older_50_pop,@community_illiteracy_pop,@community_prim_school_edu_pop,@community_junior_high_school_edu_pop,@community_senior_high_school_edu_pop,@community_junior_college_edu_pop,@average_education_time,@statistics_date,@tcpunset1,@tcpunset2,@tcpunset3,@tcpunset4,@tcpunset5,@tcpunset6,@tcpunset7,@tcpunset8,@tcpunset10,@tcpunset11,@tcpunset12,@tcpunset13,@tcpunset14,@tcpunset15,@tcpunset16,@tcpunset17,@check_status,@lock_tables,@community_family_num)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_total_pop", SqlDbType.Int,4),
					new SqlParameter("@community_reg_pop", SqlDbType.Int,4),
					new SqlParameter("@community_perm_pop", SqlDbType.Int,4),
					new SqlParameter("@community_man_pop", SqlDbType.Int,4),
					new SqlParameter("@community_female_pop", SqlDbType.Int,4),
					new SqlParameter("@community_younger_6_pop", SqlDbType.Int,4),
					new SqlParameter("@community_bet_7_and_15_pop", SqlDbType.Int,4),
					new SqlParameter("@community_bet_16_and_29_pop", SqlDbType.Int,4),
					new SqlParameter("@community_bet_30_and_39_pop", SqlDbType.Int,4),
					new SqlParameter("@community_bet_40_and_49_pop", SqlDbType.Int,4),
					new SqlParameter("@community_older_50_pop", SqlDbType.Int,4),
					new SqlParameter("@community_illiteracy_pop", SqlDbType.Int,4),
					new SqlParameter("@community_prim_school_edu_pop", SqlDbType.Int,4),
					new SqlParameter("@community_junior_high_school_edu_pop", SqlDbType.Int,4),
					new SqlParameter("@community_senior_high_school_edu_pop", SqlDbType.Int,4),
					new SqlParameter("@community_junior_college_edu_pop", SqlDbType.Int,4),
					new SqlParameter("@average_education_time", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcpunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset17", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@community_family_num", SqlDbType.Float,8)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_total_pop;
			parameters[2].Value = model.community_reg_pop;
			parameters[3].Value = model.community_perm_pop;
			parameters[4].Value = model.community_man_pop;
			parameters[5].Value = model.community_female_pop;
			parameters[6].Value = model.community_younger_6_pop;
			parameters[7].Value = model.community_bet_7_and_15_pop;
			parameters[8].Value = model.community_bet_16_and_29_pop;
			parameters[9].Value = model.community_bet_30_and_39_pop;
			parameters[10].Value = model.community_bet_40_and_49_pop;
			parameters[11].Value = model.community_older_50_pop;
			parameters[12].Value = model.community_illiteracy_pop;
			parameters[13].Value = model.community_prim_school_edu_pop;
			parameters[14].Value = model.community_junior_high_school_edu_pop;
			parameters[15].Value = model.community_senior_high_school_edu_pop;
			parameters[16].Value = model.community_junior_college_edu_pop;
			parameters[17].Value = model.average_education_time;
			parameters[18].Value = model.statistics_date;
			parameters[19].Value = model.tcpunset1;
			parameters[20].Value = model.tcpunset2;
			parameters[21].Value = model.tcpunset3;
			parameters[22].Value = model.tcpunset4;
			parameters[23].Value = model.tcpunset5;
			parameters[24].Value = model.tcpunset6;
			parameters[25].Value = model.tcpunset7;
			parameters[26].Value = model.tcpunset8;
			parameters[27].Value = model.tcpunset10;
			parameters[28].Value = model.tcpunset11;
			parameters[29].Value = model.tcpunset12;
			parameters[30].Value = model.tcpunset13;
			parameters[31].Value = model.tcpunset14;
			parameters[32].Value = model.tcpunset15;
			parameters[33].Value = model.tcpunset16;
			parameters[34].Value = model.tcpunset17;
			parameters[35].Value = model.check_status;
			parameters[36].Value = model.lock_tables;
			parameters[37].Value = model.community_family_num;

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
		public bool Update(TTG.Model.TTGWeb.community_population model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_population set ");
			strSql.Append("community_total_pop=@community_total_pop,");
			strSql.Append("community_reg_pop=@community_reg_pop,");
			strSql.Append("community_perm_pop=@community_perm_pop,");
			strSql.Append("community_man_pop=@community_man_pop,");
			strSql.Append("community_female_pop=@community_female_pop,");
			strSql.Append("community_younger_6_pop=@community_younger_6_pop,");
			strSql.Append("community_bet_7_and_15_pop=@community_bet_7_and_15_pop,");
			strSql.Append("community_bet_16_and_29_pop=@community_bet_16_and_29_pop,");
			strSql.Append("community_bet_30_and_39_pop=@community_bet_30_and_39_pop,");
			strSql.Append("community_bet_40_and_49_pop=@community_bet_40_and_49_pop,");
			strSql.Append("community_older_50_pop=@community_older_50_pop,");
			strSql.Append("community_illiteracy_pop=@community_illiteracy_pop,");
			strSql.Append("community_prim_school_edu_pop=@community_prim_school_edu_pop,");
			strSql.Append("community_junior_high_school_edu_pop=@community_junior_high_school_edu_pop,");
			strSql.Append("community_senior_high_school_edu_pop=@community_senior_high_school_edu_pop,");
			strSql.Append("community_junior_college_edu_pop=@community_junior_college_edu_pop,");
			strSql.Append("average_education_time=@average_education_time,");
			strSql.Append("tcpunset1=@tcpunset1,");
			strSql.Append("tcpunset2=@tcpunset2,");
			strSql.Append("tcpunset3=@tcpunset3,");
			strSql.Append("tcpunset4=@tcpunset4,");
			strSql.Append("tcpunset5=@tcpunset5,");
			strSql.Append("tcpunset6=@tcpunset6,");
			strSql.Append("tcpunset7=@tcpunset7,");
			strSql.Append("tcpunset8=@tcpunset8,");
			strSql.Append("tcpunset10=@tcpunset10,");
			strSql.Append("tcpunset11=@tcpunset11,");
			strSql.Append("tcpunset12=@tcpunset12,");
			strSql.Append("tcpunset13=@tcpunset13,");
			strSql.Append("tcpunset14=@tcpunset14,");
			strSql.Append("tcpunset15=@tcpunset15,");
			strSql.Append("tcpunset16=@tcpunset16,");
			strSql.Append("tcpunset17=@tcpunset17,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("community_family_num=@community_family_num");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_total_pop", SqlDbType.Int,4),
					new SqlParameter("@community_reg_pop", SqlDbType.Int,4),
					new SqlParameter("@community_perm_pop", SqlDbType.Int,4),
					new SqlParameter("@community_man_pop", SqlDbType.Int,4),
					new SqlParameter("@community_female_pop", SqlDbType.Int,4),
					new SqlParameter("@community_younger_6_pop", SqlDbType.Int,4),
					new SqlParameter("@community_bet_7_and_15_pop", SqlDbType.Int,4),
					new SqlParameter("@community_bet_16_and_29_pop", SqlDbType.Int,4),
					new SqlParameter("@community_bet_30_and_39_pop", SqlDbType.Int,4),
					new SqlParameter("@community_bet_40_and_49_pop", SqlDbType.Int,4),
					new SqlParameter("@community_older_50_pop", SqlDbType.Int,4),
					new SqlParameter("@community_illiteracy_pop", SqlDbType.Int,4),
					new SqlParameter("@community_prim_school_edu_pop", SqlDbType.Int,4),
					new SqlParameter("@community_junior_high_school_edu_pop", SqlDbType.Int,4),
					new SqlParameter("@community_senior_high_school_edu_pop", SqlDbType.Int,4),
					new SqlParameter("@community_junior_college_edu_pop", SqlDbType.Int,4),
					new SqlParameter("@average_education_time", SqlDbType.Float,8),
					new SqlParameter("@tcpunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tcpunset17", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@community_family_num", SqlDbType.Float,8),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_total_pop;
			parameters[1].Value = model.community_reg_pop;
			parameters[2].Value = model.community_perm_pop;
			parameters[3].Value = model.community_man_pop;
			parameters[4].Value = model.community_female_pop;
			parameters[5].Value = model.community_younger_6_pop;
			parameters[6].Value = model.community_bet_7_and_15_pop;
			parameters[7].Value = model.community_bet_16_and_29_pop;
			parameters[8].Value = model.community_bet_30_and_39_pop;
			parameters[9].Value = model.community_bet_40_and_49_pop;
			parameters[10].Value = model.community_older_50_pop;
			parameters[11].Value = model.community_illiteracy_pop;
			parameters[12].Value = model.community_prim_school_edu_pop;
			parameters[13].Value = model.community_junior_high_school_edu_pop;
			parameters[14].Value = model.community_senior_high_school_edu_pop;
			parameters[15].Value = model.community_junior_college_edu_pop;
			parameters[16].Value = model.average_education_time;
			parameters[17].Value = model.tcpunset1;
			parameters[18].Value = model.tcpunset2;
			parameters[19].Value = model.tcpunset3;
			parameters[20].Value = model.tcpunset4;
			parameters[21].Value = model.tcpunset5;
			parameters[22].Value = model.tcpunset6;
			parameters[23].Value = model.tcpunset7;
			parameters[24].Value = model.tcpunset8;
			parameters[25].Value = model.tcpunset10;
			parameters[26].Value = model.tcpunset11;
			parameters[27].Value = model.tcpunset12;
			parameters[28].Value = model.tcpunset13;
			parameters[29].Value = model.tcpunset14;
			parameters[30].Value = model.tcpunset15;
			parameters[31].Value = model.tcpunset16;
			parameters[32].Value = model.tcpunset17;
			parameters[33].Value = model.check_status;
			parameters[34].Value = model.lock_tables;
			parameters[35].Value = model.community_family_num;
			parameters[36].Value = model.community_id;
			parameters[37].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_population ");
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
		public TTG.Model.TTGWeb.community_population GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_total_pop,community_reg_pop,community_perm_pop,community_man_pop,community_female_pop,community_younger_6_pop,community_bet_7_and_15_pop,community_bet_16_and_29_pop,community_bet_30_and_39_pop,community_bet_40_and_49_pop,community_older_50_pop,community_illiteracy_pop,community_prim_school_edu_pop,community_junior_high_school_edu_pop,community_senior_high_school_edu_pop,community_junior_college_edu_pop,average_education_time,statistics_date,tcpunset1,tcpunset2,tcpunset3,tcpunset4,tcpunset5,tcpunset6,tcpunset7,tcpunset8,tcpunset10,tcpunset11,tcpunset12,tcpunset13,tcpunset14,tcpunset15,tcpunset16,tcpunset17,check_status,lock_tables,community_family_num from T_community_population ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_population model=new TTG.Model.TTGWeb.community_population();
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
		public TTG.Model.TTGWeb.community_population DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_population model=new TTG.Model.TTGWeb.community_population();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_total_pop"]!=null && row["community_total_pop"].ToString()!="")
				{
					model.community_total_pop=int.Parse(row["community_total_pop"].ToString());
				}
				if(row["community_reg_pop"]!=null && row["community_reg_pop"].ToString()!="")
				{
					model.community_reg_pop=int.Parse(row["community_reg_pop"].ToString());
				}
				if(row["community_perm_pop"]!=null && row["community_perm_pop"].ToString()!="")
				{
					model.community_perm_pop=int.Parse(row["community_perm_pop"].ToString());
				}
				if(row["community_man_pop"]!=null && row["community_man_pop"].ToString()!="")
				{
					model.community_man_pop=int.Parse(row["community_man_pop"].ToString());
				}
				if(row["community_female_pop"]!=null && row["community_female_pop"].ToString()!="")
				{
					model.community_female_pop=int.Parse(row["community_female_pop"].ToString());
				}
				if(row["community_younger_6_pop"]!=null && row["community_younger_6_pop"].ToString()!="")
				{
					model.community_younger_6_pop=int.Parse(row["community_younger_6_pop"].ToString());
				}
				if(row["community_bet_7_and_15_pop"]!=null && row["community_bet_7_and_15_pop"].ToString()!="")
				{
					model.community_bet_7_and_15_pop=int.Parse(row["community_bet_7_and_15_pop"].ToString());
				}
				if(row["community_bet_16_and_29_pop"]!=null && row["community_bet_16_and_29_pop"].ToString()!="")
				{
					model.community_bet_16_and_29_pop=int.Parse(row["community_bet_16_and_29_pop"].ToString());
				}
				if(row["community_bet_30_and_39_pop"]!=null && row["community_bet_30_and_39_pop"].ToString()!="")
				{
					model.community_bet_30_and_39_pop=int.Parse(row["community_bet_30_and_39_pop"].ToString());
				}
				if(row["community_bet_40_and_49_pop"]!=null && row["community_bet_40_and_49_pop"].ToString()!="")
				{
					model.community_bet_40_and_49_pop=int.Parse(row["community_bet_40_and_49_pop"].ToString());
				}
				if(row["community_older_50_pop"]!=null && row["community_older_50_pop"].ToString()!="")
				{
					model.community_older_50_pop=int.Parse(row["community_older_50_pop"].ToString());
				}
				if(row["community_illiteracy_pop"]!=null && row["community_illiteracy_pop"].ToString()!="")
				{
					model.community_illiteracy_pop=int.Parse(row["community_illiteracy_pop"].ToString());
				}
				if(row["community_prim_school_edu_pop"]!=null && row["community_prim_school_edu_pop"].ToString()!="")
				{
					model.community_prim_school_edu_pop=int.Parse(row["community_prim_school_edu_pop"].ToString());
				}
				if(row["community_junior_high_school_edu_pop"]!=null && row["community_junior_high_school_edu_pop"].ToString()!="")
				{
					model.community_junior_high_school_edu_pop=int.Parse(row["community_junior_high_school_edu_pop"].ToString());
				}
				if(row["community_senior_high_school_edu_pop"]!=null && row["community_senior_high_school_edu_pop"].ToString()!="")
				{
					model.community_senior_high_school_edu_pop=int.Parse(row["community_senior_high_school_edu_pop"].ToString());
				}
				if(row["community_junior_college_edu_pop"]!=null && row["community_junior_college_edu_pop"].ToString()!="")
				{
					model.community_junior_college_edu_pop=int.Parse(row["community_junior_college_edu_pop"].ToString());
				}
				if(row["average_education_time"]!=null && row["average_education_time"].ToString()!="")
				{
					model.average_education_time=decimal.Parse(row["average_education_time"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcpunset1"]!=null)
				{
					model.tcpunset1=row["tcpunset1"].ToString();
				}
				if(row["tcpunset2"]!=null)
				{
					model.tcpunset2=row["tcpunset2"].ToString();
				}
				if(row["tcpunset3"]!=null)
				{
					model.tcpunset3=row["tcpunset3"].ToString();
				}
				if(row["tcpunset4"]!=null)
				{
					model.tcpunset4=row["tcpunset4"].ToString();
				}
				if(row["tcpunset5"]!=null)
				{
					model.tcpunset5=row["tcpunset5"].ToString();
				}
				if(row["tcpunset6"]!=null)
				{
					model.tcpunset6=row["tcpunset6"].ToString();
				}
				if(row["tcpunset7"]!=null)
				{
					model.tcpunset7=row["tcpunset7"].ToString();
				}
				if(row["tcpunset8"]!=null)
				{
					model.tcpunset8=row["tcpunset8"].ToString();
				}
				if(row["tcpunset10"]!=null)
				{
					model.tcpunset10=row["tcpunset10"].ToString();
				}
				if(row["tcpunset11"]!=null)
				{
					model.tcpunset11=row["tcpunset11"].ToString();
				}
				if(row["tcpunset12"]!=null)
				{
					model.tcpunset12=row["tcpunset12"].ToString();
				}
				if(row["tcpunset13"]!=null)
				{
					model.tcpunset13=row["tcpunset13"].ToString();
				}
				if(row["tcpunset14"]!=null)
				{
					model.tcpunset14=row["tcpunset14"].ToString();
				}
				if(row["tcpunset15"]!=null)
				{
					model.tcpunset15=row["tcpunset15"].ToString();
				}
				if(row["tcpunset16"]!=null)
				{
					model.tcpunset16=row["tcpunset16"].ToString();
				}
				if(row["tcpunset17"]!=null)
				{
					model.tcpunset17=row["tcpunset17"].ToString();
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["community_family_num"]!=null && row["community_family_num"].ToString()!="")
				{
					model.community_family_num=decimal.Parse(row["community_family_num"].ToString());
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
			strSql.Append("select community_id,community_total_pop,community_reg_pop,community_perm_pop,community_man_pop,community_female_pop,community_younger_6_pop,community_bet_7_and_15_pop,community_bet_16_and_29_pop,community_bet_30_and_39_pop,community_bet_40_and_49_pop,community_older_50_pop,community_illiteracy_pop,community_prim_school_edu_pop,community_junior_high_school_edu_pop,community_senior_high_school_edu_pop,community_junior_college_edu_pop,average_education_time,statistics_date,tcpunset1,tcpunset2,tcpunset3,tcpunset4,tcpunset5,tcpunset6,tcpunset7,tcpunset8,tcpunset10,tcpunset11,tcpunset12,tcpunset13,tcpunset14,tcpunset15,tcpunset16,tcpunset17,check_status,lock_tables,community_family_num ");
			strSql.Append(" FROM T_community_population ");
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
			strSql.Append(" community_id,community_total_pop,community_reg_pop,community_perm_pop,community_man_pop,community_female_pop,community_younger_6_pop,community_bet_7_and_15_pop,community_bet_16_and_29_pop,community_bet_30_and_39_pop,community_bet_40_and_49_pop,community_older_50_pop,community_illiteracy_pop,community_prim_school_edu_pop,community_junior_high_school_edu_pop,community_senior_high_school_edu_pop,community_junior_college_edu_pop,average_education_time,statistics_date,tcpunset1,tcpunset2,tcpunset3,tcpunset4,tcpunset5,tcpunset6,tcpunset7,tcpunset8,tcpunset10,tcpunset11,tcpunset12,tcpunset13,tcpunset14,tcpunset15,tcpunset16,tcpunset17,check_status,lock_tables,community_family_num ");
			strSql.Append(" FROM T_community_population ");
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
			strSql.Append("select count(1) FROM T_community_population ");
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
			strSql.Append(")AS Row, T.*  from T_community_population T ");
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
			parameters[0].Value = "T_community_population";
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
        /// 获取一个实体
        /// </summary>
        /// <param name="community_id"></param>
        /// <param name="statistics_date"></param>
        /// <returns></returns>
        public TTG.Model.TTGWeb.community_population getModel(string community_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 community_id,community_total_pop,community_reg_pop,community_perm_pop,community_man_pop,community_female_pop,community_younger_6_pop,community_bet_7_and_15_pop,community_bet_16_and_29_pop,community_bet_30_and_39_pop,community_bet_40_and_49_pop,community_older_50_pop,community_illiteracy_pop,community_prim_school_edu_pop,community_junior_high_school_edu_pop,community_senior_high_school_edu_pop,community_junior_college_edu_pop,average_education_time,statistics_date,tcpunset1,tcpunset2,tcpunset3,tcpunset4,tcpunset5,tcpunset6,tcpunset7,tcpunset8,tcpunset10,tcpunset11,tcpunset12,tcpunset13,tcpunset14,tcpunset15,tcpunset16,tcpunset17,check_status,lock_tables,community_family_num from T_community_population ");
            strSql.Append(" where community_id=@community_id order by statistics_date desc");
            SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20)			};
            parameters[0].Value = community_id;

            TTG.Model.TTGWeb.community_population model = new TTG.Model.TTGWeb.community_population();
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
		#endregion  ExtensionMethod
	}
}

