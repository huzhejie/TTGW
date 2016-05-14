using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_building
	/// </summary>
	public partial class community_building
	{
		public community_building()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_building");
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
		public bool Add(TTG.Model.TTGWeb.community_building model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_building(");
			strSql.Append("community_id,community_building_total_gfa,community_building_total_fs,community_building_total_num,community_house_gfa,community_house_fs,community_house_num,community_edu_gfa,community_edu_fs,community_edu_num,community_medical_gfa,community_medical_fs,community_medical_num,community_culture_sports_gfa,community_culture_sports_fs,community_culture_sports_num,community_service_gfa,community_service_fs,community_service_num,community_other_building_gfa,community_other_building_fs,community_other_building_num,statistics_date,tcbunset1,tcbunset2,tcbunset3,tcbunset4,tcbunset5,tcbunset6,tcbunset7,tcbunset8,tcbunset9,tcbunset10,tcbunset11,tcbunset12,tcbunset13,tcbunset14,tcbunset15,tcbunset16,tcbunset17,tcbunset18,tcbunset19,tcbunset20,tcbunset21,check_status,lock_tables)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_building_total_gfa,@community_building_total_fs,@community_building_total_num,@community_house_gfa,@community_house_fs,@community_house_num,@community_edu_gfa,@community_edu_fs,@community_edu_num,@community_medical_gfa,@community_medical_fs,@community_medical_num,@community_culture_sports_gfa,@community_culture_sports_fs,@community_culture_sports_num,@community_service_gfa,@community_service_fs,@community_service_num,@community_other_building_gfa,@community_other_building_fs,@community_other_building_num,@statistics_date,@tcbunset1,@tcbunset2,@tcbunset3,@tcbunset4,@tcbunset5,@tcbunset6,@tcbunset7,@tcbunset8,@tcbunset9,@tcbunset10,@tcbunset11,@tcbunset12,@tcbunset13,@tcbunset14,@tcbunset15,@tcbunset16,@tcbunset17,@tcbunset18,@tcbunset19,@tcbunset20,@tcbunset21,@check_status,@lock_tables)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_building_total_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_building_total_fs", SqlDbType.Float,8),
					new SqlParameter("@community_building_total_num", SqlDbType.Int,4),
					new SqlParameter("@community_house_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_house_fs", SqlDbType.Float,8),
					new SqlParameter("@community_house_num", SqlDbType.Int,4),
					new SqlParameter("@community_edu_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_edu_fs", SqlDbType.Float,8),
					new SqlParameter("@community_edu_num", SqlDbType.Int,4),
					new SqlParameter("@community_medical_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_medical_fs", SqlDbType.Float,8),
					new SqlParameter("@community_medical_num", SqlDbType.Int,4),
					new SqlParameter("@community_culture_sports_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_culture_sports_fs", SqlDbType.Float,8),
					new SqlParameter("@community_culture_sports_num", SqlDbType.Int,4),
					new SqlParameter("@community_service_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_service_fs", SqlDbType.Float,8),
					new SqlParameter("@community_service_num", SqlDbType.Int,4),
					new SqlParameter("@community_other_building_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_other_building_fs", SqlDbType.Float,8),
					new SqlParameter("@community_other_building_num", SqlDbType.Int,4),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcbunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset21", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_building_total_gfa;
			parameters[2].Value = model.community_building_total_fs;
			parameters[3].Value = model.community_building_total_num;
			parameters[4].Value = model.community_house_gfa;
			parameters[5].Value = model.community_house_fs;
			parameters[6].Value = model.community_house_num;
			parameters[7].Value = model.community_edu_gfa;
			parameters[8].Value = model.community_edu_fs;
			parameters[9].Value = model.community_edu_num;
			parameters[10].Value = model.community_medical_gfa;
			parameters[11].Value = model.community_medical_fs;
			parameters[12].Value = model.community_medical_num;
			parameters[13].Value = model.community_culture_sports_gfa;
			parameters[14].Value = model.community_culture_sports_fs;
			parameters[15].Value = model.community_culture_sports_num;
			parameters[16].Value = model.community_service_gfa;
			parameters[17].Value = model.community_service_fs;
			parameters[18].Value = model.community_service_num;
			parameters[19].Value = model.community_other_building_gfa;
			parameters[20].Value = model.community_other_building_fs;
			parameters[21].Value = model.community_other_building_num;
			parameters[22].Value = model.statistics_date;
			parameters[23].Value = model.tcbunset1;
			parameters[24].Value = model.tcbunset2;
			parameters[25].Value = model.tcbunset3;
			parameters[26].Value = model.tcbunset4;
			parameters[27].Value = model.tcbunset5;
			parameters[28].Value = model.tcbunset6;
			parameters[29].Value = model.tcbunset7;
			parameters[30].Value = model.tcbunset8;
			parameters[31].Value = model.tcbunset9;
			parameters[32].Value = model.tcbunset10;
			parameters[33].Value = model.tcbunset11;
			parameters[34].Value = model.tcbunset12;
			parameters[35].Value = model.tcbunset13;
			parameters[36].Value = model.tcbunset14;
			parameters[37].Value = model.tcbunset15;
			parameters[38].Value = model.tcbunset16;
			parameters[39].Value = model.tcbunset17;
			parameters[40].Value = model.tcbunset18;
			parameters[41].Value = model.tcbunset19;
			parameters[42].Value = model.tcbunset20;
			parameters[43].Value = model.tcbunset21;
			parameters[44].Value = model.check_status;
			parameters[45].Value = model.lock_tables;

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
		public bool Update(TTG.Model.TTGWeb.community_building model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_building set ");
			strSql.Append("community_building_total_gfa=@community_building_total_gfa,");
			strSql.Append("community_building_total_fs=@community_building_total_fs,");
			strSql.Append("community_building_total_num=@community_building_total_num,");
			strSql.Append("community_house_gfa=@community_house_gfa,");
			strSql.Append("community_house_fs=@community_house_fs,");
			strSql.Append("community_house_num=@community_house_num,");
			strSql.Append("community_edu_gfa=@community_edu_gfa,");
			strSql.Append("community_edu_fs=@community_edu_fs,");
			strSql.Append("community_edu_num=@community_edu_num,");
			strSql.Append("community_medical_gfa=@community_medical_gfa,");
			strSql.Append("community_medical_fs=@community_medical_fs,");
			strSql.Append("community_medical_num=@community_medical_num,");
			strSql.Append("community_culture_sports_gfa=@community_culture_sports_gfa,");
			strSql.Append("community_culture_sports_fs=@community_culture_sports_fs,");
			strSql.Append("community_culture_sports_num=@community_culture_sports_num,");
			strSql.Append("community_service_gfa=@community_service_gfa,");
			strSql.Append("community_service_fs=@community_service_fs,");
			strSql.Append("community_service_num=@community_service_num,");
			strSql.Append("community_other_building_gfa=@community_other_building_gfa,");
			strSql.Append("community_other_building_fs=@community_other_building_fs,");
			strSql.Append("community_other_building_num=@community_other_building_num,");
			strSql.Append("tcbunset1=@tcbunset1,");
			strSql.Append("tcbunset2=@tcbunset2,");
			strSql.Append("tcbunset3=@tcbunset3,");
			strSql.Append("tcbunset4=@tcbunset4,");
			strSql.Append("tcbunset5=@tcbunset5,");
			strSql.Append("tcbunset6=@tcbunset6,");
			strSql.Append("tcbunset7=@tcbunset7,");
			strSql.Append("tcbunset8=@tcbunset8,");
			strSql.Append("tcbunset9=@tcbunset9,");
			strSql.Append("tcbunset10=@tcbunset10,");
			strSql.Append("tcbunset11=@tcbunset11,");
			strSql.Append("tcbunset12=@tcbunset12,");
			strSql.Append("tcbunset13=@tcbunset13,");
			strSql.Append("tcbunset14=@tcbunset14,");
			strSql.Append("tcbunset15=@tcbunset15,");
			strSql.Append("tcbunset16=@tcbunset16,");
			strSql.Append("tcbunset17=@tcbunset17,");
			strSql.Append("tcbunset18=@tcbunset18,");
			strSql.Append("tcbunset19=@tcbunset19,");
			strSql.Append("tcbunset20=@tcbunset20,");
			strSql.Append("tcbunset21=@tcbunset21,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("lock_tables=@lock_tables");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_building_total_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_building_total_fs", SqlDbType.Float,8),
					new SqlParameter("@community_building_total_num", SqlDbType.Int,4),
					new SqlParameter("@community_house_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_house_fs", SqlDbType.Float,8),
					new SqlParameter("@community_house_num", SqlDbType.Int,4),
					new SqlParameter("@community_edu_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_edu_fs", SqlDbType.Float,8),
					new SqlParameter("@community_edu_num", SqlDbType.Int,4),
					new SqlParameter("@community_medical_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_medical_fs", SqlDbType.Float,8),
					new SqlParameter("@community_medical_num", SqlDbType.Int,4),
					new SqlParameter("@community_culture_sports_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_culture_sports_fs", SqlDbType.Float,8),
					new SqlParameter("@community_culture_sports_num", SqlDbType.Int,4),
					new SqlParameter("@community_service_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_service_fs", SqlDbType.Float,8),
					new SqlParameter("@community_service_num", SqlDbType.Int,4),
					new SqlParameter("@community_other_building_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_other_building_fs", SqlDbType.Float,8),
					new SqlParameter("@community_other_building_num", SqlDbType.Int,4),
					new SqlParameter("@tcbunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tcbunset21", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_building_total_gfa;
			parameters[1].Value = model.community_building_total_fs;
			parameters[2].Value = model.community_building_total_num;
			parameters[3].Value = model.community_house_gfa;
			parameters[4].Value = model.community_house_fs;
			parameters[5].Value = model.community_house_num;
			parameters[6].Value = model.community_edu_gfa;
			parameters[7].Value = model.community_edu_fs;
			parameters[8].Value = model.community_edu_num;
			parameters[9].Value = model.community_medical_gfa;
			parameters[10].Value = model.community_medical_fs;
			parameters[11].Value = model.community_medical_num;
			parameters[12].Value = model.community_culture_sports_gfa;
			parameters[13].Value = model.community_culture_sports_fs;
			parameters[14].Value = model.community_culture_sports_num;
			parameters[15].Value = model.community_service_gfa;
			parameters[16].Value = model.community_service_fs;
			parameters[17].Value = model.community_service_num;
			parameters[18].Value = model.community_other_building_gfa;
			parameters[19].Value = model.community_other_building_fs;
			parameters[20].Value = model.community_other_building_num;
			parameters[21].Value = model.tcbunset1;
			parameters[22].Value = model.tcbunset2;
			parameters[23].Value = model.tcbunset3;
			parameters[24].Value = model.tcbunset4;
			parameters[25].Value = model.tcbunset5;
			parameters[26].Value = model.tcbunset6;
			parameters[27].Value = model.tcbunset7;
			parameters[28].Value = model.tcbunset8;
			parameters[29].Value = model.tcbunset9;
			parameters[30].Value = model.tcbunset10;
			parameters[31].Value = model.tcbunset11;
			parameters[32].Value = model.tcbunset12;
			parameters[33].Value = model.tcbunset13;
			parameters[34].Value = model.tcbunset14;
			parameters[35].Value = model.tcbunset15;
			parameters[36].Value = model.tcbunset16;
			parameters[37].Value = model.tcbunset17;
			parameters[38].Value = model.tcbunset18;
			parameters[39].Value = model.tcbunset19;
			parameters[40].Value = model.tcbunset20;
			parameters[41].Value = model.tcbunset21;
			parameters[42].Value = model.check_status;
			parameters[43].Value = model.lock_tables;
			parameters[44].Value = model.community_id;
			parameters[45].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_building ");
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
		public TTG.Model.TTGWeb.community_building GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_building_total_gfa,community_building_total_fs,community_building_total_num,community_house_gfa,community_house_fs,community_house_num,community_edu_gfa,community_edu_fs,community_edu_num,community_medical_gfa,community_medical_fs,community_medical_num,community_culture_sports_gfa,community_culture_sports_fs,community_culture_sports_num,community_service_gfa,community_service_fs,community_service_num,community_other_building_gfa,community_other_building_fs,community_other_building_num,statistics_date,tcbunset1,tcbunset2,tcbunset3,tcbunset4,tcbunset5,tcbunset6,tcbunset7,tcbunset8,tcbunset9,tcbunset10,tcbunset11,tcbunset12,tcbunset13,tcbunset14,tcbunset15,tcbunset16,tcbunset17,tcbunset18,tcbunset19,tcbunset20,tcbunset21,check_status,lock_tables from T_community_building ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_building model=new TTG.Model.TTGWeb.community_building();
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
		public TTG.Model.TTGWeb.community_building DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_building model=new TTG.Model.TTGWeb.community_building();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_building_total_gfa"]!=null && row["community_building_total_gfa"].ToString()!="")
				{
					model.community_building_total_gfa=decimal.Parse(row["community_building_total_gfa"].ToString());
				}
				if(row["community_building_total_fs"]!=null && row["community_building_total_fs"].ToString()!="")
				{
					model.community_building_total_fs=decimal.Parse(row["community_building_total_fs"].ToString());
				}
				if(row["community_building_total_num"]!=null && row["community_building_total_num"].ToString()!="")
				{
					model.community_building_total_num=int.Parse(row["community_building_total_num"].ToString());
				}
				if(row["community_house_gfa"]!=null && row["community_house_gfa"].ToString()!="")
				{
					model.community_house_gfa=decimal.Parse(row["community_house_gfa"].ToString());
				}
				if(row["community_house_fs"]!=null && row["community_house_fs"].ToString()!="")
				{
					model.community_house_fs=decimal.Parse(row["community_house_fs"].ToString());
				}
				if(row["community_house_num"]!=null && row["community_house_num"].ToString()!="")
				{
					model.community_house_num=int.Parse(row["community_house_num"].ToString());
				}
				if(row["community_edu_gfa"]!=null && row["community_edu_gfa"].ToString()!="")
				{
					model.community_edu_gfa=decimal.Parse(row["community_edu_gfa"].ToString());
				}
				if(row["community_edu_fs"]!=null && row["community_edu_fs"].ToString()!="")
				{
					model.community_edu_fs=decimal.Parse(row["community_edu_fs"].ToString());
				}
				if(row["community_edu_num"]!=null && row["community_edu_num"].ToString()!="")
				{
					model.community_edu_num=int.Parse(row["community_edu_num"].ToString());
				}
				if(row["community_medical_gfa"]!=null && row["community_medical_gfa"].ToString()!="")
				{
					model.community_medical_gfa=decimal.Parse(row["community_medical_gfa"].ToString());
				}
				if(row["community_medical_fs"]!=null && row["community_medical_fs"].ToString()!="")
				{
					model.community_medical_fs=decimal.Parse(row["community_medical_fs"].ToString());
				}
				if(row["community_medical_num"]!=null && row["community_medical_num"].ToString()!="")
				{
					model.community_medical_num=int.Parse(row["community_medical_num"].ToString());
				}
				if(row["community_culture_sports_gfa"]!=null && row["community_culture_sports_gfa"].ToString()!="")
				{
					model.community_culture_sports_gfa=decimal.Parse(row["community_culture_sports_gfa"].ToString());
				}
				if(row["community_culture_sports_fs"]!=null && row["community_culture_sports_fs"].ToString()!="")
				{
					model.community_culture_sports_fs=decimal.Parse(row["community_culture_sports_fs"].ToString());
				}
				if(row["community_culture_sports_num"]!=null && row["community_culture_sports_num"].ToString()!="")
				{
					model.community_culture_sports_num=int.Parse(row["community_culture_sports_num"].ToString());
				}
				if(row["community_service_gfa"]!=null && row["community_service_gfa"].ToString()!="")
				{
					model.community_service_gfa=decimal.Parse(row["community_service_gfa"].ToString());
				}
				if(row["community_service_fs"]!=null && row["community_service_fs"].ToString()!="")
				{
					model.community_service_fs=decimal.Parse(row["community_service_fs"].ToString());
				}
				if(row["community_service_num"]!=null && row["community_service_num"].ToString()!="")
				{
					model.community_service_num=int.Parse(row["community_service_num"].ToString());
				}
				if(row["community_other_building_gfa"]!=null && row["community_other_building_gfa"].ToString()!="")
				{
					model.community_other_building_gfa=decimal.Parse(row["community_other_building_gfa"].ToString());
				}
				if(row["community_other_building_fs"]!=null && row["community_other_building_fs"].ToString()!="")
				{
					model.community_other_building_fs=decimal.Parse(row["community_other_building_fs"].ToString());
				}
				if(row["community_other_building_num"]!=null && row["community_other_building_num"].ToString()!="")
				{
					model.community_other_building_num=int.Parse(row["community_other_building_num"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcbunset1"]!=null)
				{
					model.tcbunset1=row["tcbunset1"].ToString();
				}
				if(row["tcbunset2"]!=null)
				{
					model.tcbunset2=row["tcbunset2"].ToString();
				}
				if(row["tcbunset3"]!=null)
				{
					model.tcbunset3=row["tcbunset3"].ToString();
				}
				if(row["tcbunset4"]!=null)
				{
					model.tcbunset4=row["tcbunset4"].ToString();
				}
				if(row["tcbunset5"]!=null)
				{
					model.tcbunset5=row["tcbunset5"].ToString();
				}
				if(row["tcbunset6"]!=null)
				{
					model.tcbunset6=row["tcbunset6"].ToString();
				}
				if(row["tcbunset7"]!=null)
				{
					model.tcbunset7=row["tcbunset7"].ToString();
				}
				if(row["tcbunset8"]!=null)
				{
					model.tcbunset8=row["tcbunset8"].ToString();
				}
				if(row["tcbunset9"]!=null)
				{
					model.tcbunset9=row["tcbunset9"].ToString();
				}
				if(row["tcbunset10"]!=null)
				{
					model.tcbunset10=row["tcbunset10"].ToString();
				}
				if(row["tcbunset11"]!=null)
				{
					model.tcbunset11=row["tcbunset11"].ToString();
				}
				if(row["tcbunset12"]!=null)
				{
					model.tcbunset12=row["tcbunset12"].ToString();
				}
				if(row["tcbunset13"]!=null)
				{
					model.tcbunset13=row["tcbunset13"].ToString();
				}
				if(row["tcbunset14"]!=null)
				{
					model.tcbunset14=row["tcbunset14"].ToString();
				}
				if(row["tcbunset15"]!=null)
				{
					model.tcbunset15=row["tcbunset15"].ToString();
				}
				if(row["tcbunset16"]!=null)
				{
					model.tcbunset16=row["tcbunset16"].ToString();
				}
				if(row["tcbunset17"]!=null)
				{
					model.tcbunset17=row["tcbunset17"].ToString();
				}
				if(row["tcbunset18"]!=null)
				{
					model.tcbunset18=row["tcbunset18"].ToString();
				}
				if(row["tcbunset19"]!=null)
				{
					model.tcbunset19=row["tcbunset19"].ToString();
				}
				if(row["tcbunset20"]!=null)
				{
					model.tcbunset20=row["tcbunset20"].ToString();
				}
				if(row["tcbunset21"]!=null)
				{
					model.tcbunset21=row["tcbunset21"].ToString();
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
			strSql.Append("select community_id,community_building_total_gfa,community_building_total_fs,community_building_total_num,community_house_gfa,community_house_fs,community_house_num,community_edu_gfa,community_edu_fs,community_edu_num,community_medical_gfa,community_medical_fs,community_medical_num,community_culture_sports_gfa,community_culture_sports_fs,community_culture_sports_num,community_service_gfa,community_service_fs,community_service_num,community_other_building_gfa,community_other_building_fs,community_other_building_num,statistics_date,tcbunset1,tcbunset2,tcbunset3,tcbunset4,tcbunset5,tcbunset6,tcbunset7,tcbunset8,tcbunset9,tcbunset10,tcbunset11,tcbunset12,tcbunset13,tcbunset14,tcbunset15,tcbunset16,tcbunset17,tcbunset18,tcbunset19,tcbunset20,tcbunset21,check_status,lock_tables ");
			strSql.Append(" FROM T_community_building ");
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
			strSql.Append(" community_id,community_building_total_gfa,community_building_total_fs,community_building_total_num,community_house_gfa,community_house_fs,community_house_num,community_edu_gfa,community_edu_fs,community_edu_num,community_medical_gfa,community_medical_fs,community_medical_num,community_culture_sports_gfa,community_culture_sports_fs,community_culture_sports_num,community_service_gfa,community_service_fs,community_service_num,community_other_building_gfa,community_other_building_fs,community_other_building_num,statistics_date,tcbunset1,tcbunset2,tcbunset3,tcbunset4,tcbunset5,tcbunset6,tcbunset7,tcbunset8,tcbunset9,tcbunset10,tcbunset11,tcbunset12,tcbunset13,tcbunset14,tcbunset15,tcbunset16,tcbunset17,tcbunset18,tcbunset19,tcbunset20,tcbunset21,check_status,lock_tables ");
			strSql.Append(" FROM T_community_building ");
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
			strSql.Append("select count(1) FROM T_community_building ");
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
			strSql.Append(")AS Row, T.*  from T_community_building T ");
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
			parameters[0].Value = "T_community_building";
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
        /// <returns></returns>
        public TTG.Model.TTGWeb.community_building getModel(string community_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 community_id,community_building_total_gfa,community_building_total_fs,community_building_total_num,community_house_gfa,community_house_fs,community_house_num,community_edu_gfa,community_edu_fs,community_edu_num,community_medical_gfa,community_medical_fs,community_medical_num,community_culture_sports_gfa,community_culture_sports_fs,community_culture_sports_num,community_service_gfa,community_service_fs,community_service_num,community_other_building_gfa,community_other_building_fs,community_other_building_num,statistics_date,tcbunset1,tcbunset2,tcbunset3,tcbunset4,tcbunset5,tcbunset6,tcbunset7,tcbunset8,tcbunset9,tcbunset10,tcbunset11,tcbunset12,tcbunset13,tcbunset14,tcbunset15,tcbunset16,tcbunset17,tcbunset18,tcbunset19,tcbunset20,tcbunset21,check_status,lock_tables from T_community_building ");
            strSql.Append(" where community_id=@community_id order by statistics_date desc");
            SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20)		};
            parameters[0].Value = community_id;

            TTG.Model.TTGWeb.community_building model = new TTG.Model.TTGWeb.community_building();
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

