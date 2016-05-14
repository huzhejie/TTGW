using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_culture_sports
	/// </summary>
	public partial class community_culture_sports
	{
		public community_culture_sports()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_culture_sports");
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
		public bool Add(TTG.Model.TTGWeb.community_culture_sports model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_culture_sports(");
			strSql.Append("community_id,community_culture_sports_fs,community_culture_sports_gfa,community_otd_cul_spo_fac_num,community_otd_cul_spo_fac_gfa,community_cul_squ_num,community_cul_squ_fs,community_otd_entm_num,community_otd_entm_fs,community_child_plg_num,community_child_plg_fs,community_ind_actv_spa_num,community_ind_actv_spa_fs,community_ind_actv_spa_gfa,community_cul_sta_num,community_cul_sta_fs,community_cul_sta_gfa,community_cul_room_num,community_cul_room_fs,community_cul_room_gfa,community_fit_fac_num,community_fit_fac_intact_rate,statistics_date,tccsunset1,tccsunset2,tccsunset3,tccsunset4,tccsunset5,tccsunset6,tccsunset7,tccsunset8,tccsunset9,tccsunset10,tccsunset11,tccsunset12,tccsunset13,tccsunset14,tccsunset15,tccsunset16,tccsunset17,tccsunset18,tccsunset19,tccsunset20,tccsunset21,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_culture_sports_fs,@community_culture_sports_gfa,@community_otd_cul_spo_fac_num,@community_otd_cul_spo_fac_gfa,@community_cul_squ_num,@community_cul_squ_fs,@community_otd_entm_num,@community_otd_entm_fs,@community_child_plg_num,@community_child_plg_fs,@community_ind_actv_spa_num,@community_ind_actv_spa_fs,@community_ind_actv_spa_gfa,@community_cul_sta_num,@community_cul_sta_fs,@community_cul_sta_gfa,@community_cul_room_num,@community_cul_room_fs,@community_cul_room_gfa,@community_fit_fac_num,@community_fit_fac_intact_rate,@statistics_date,@tccsunset1,@tccsunset2,@tccsunset3,@tccsunset4,@tccsunset5,@tccsunset6,@tccsunset7,@tccsunset8,@tccsunset9,@tccsunset10,@tccsunset11,@tccsunset12,@tccsunset13,@tccsunset14,@tccsunset15,@tccsunset16,@tccsunset17,@tccsunset18,@tccsunset19,@tccsunset20,@tccsunset21,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_culture_sports_fs", SqlDbType.Float,8),
					new SqlParameter("@community_culture_sports_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_otd_cul_spo_fac_num", SqlDbType.Int,4),
					new SqlParameter("@community_otd_cul_spo_fac_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_cul_squ_num", SqlDbType.Int,4),
					new SqlParameter("@community_cul_squ_fs", SqlDbType.Float,8),
					new SqlParameter("@community_otd_entm_num", SqlDbType.Int,4),
					new SqlParameter("@community_otd_entm_fs", SqlDbType.Float,8),
					new SqlParameter("@community_child_plg_num", SqlDbType.Int,4),
					new SqlParameter("@community_child_plg_fs", SqlDbType.Float,8),
					new SqlParameter("@community_ind_actv_spa_num", SqlDbType.Int,4),
					new SqlParameter("@community_ind_actv_spa_fs", SqlDbType.Float,8),
					new SqlParameter("@community_ind_actv_spa_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_cul_sta_num", SqlDbType.Int,4),
					new SqlParameter("@community_cul_sta_fs", SqlDbType.Float,8),
					new SqlParameter("@community_cul_sta_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_cul_room_num", SqlDbType.Int,4),
					new SqlParameter("@community_cul_room_fs", SqlDbType.Float,8),
					new SqlParameter("@community_cul_room_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_fit_fac_num", SqlDbType.Int,4),
					new SqlParameter("@community_fit_fac_intact_rate", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tccsunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset21", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_culture_sports_fs;
			parameters[2].Value = model.community_culture_sports_gfa;
			parameters[3].Value = model.community_otd_cul_spo_fac_num;
			parameters[4].Value = model.community_otd_cul_spo_fac_gfa;
			parameters[5].Value = model.community_cul_squ_num;
			parameters[6].Value = model.community_cul_squ_fs;
			parameters[7].Value = model.community_otd_entm_num;
			parameters[8].Value = model.community_otd_entm_fs;
			parameters[9].Value = model.community_child_plg_num;
			parameters[10].Value = model.community_child_plg_fs;
			parameters[11].Value = model.community_ind_actv_spa_num;
			parameters[12].Value = model.community_ind_actv_spa_fs;
			parameters[13].Value = model.community_ind_actv_spa_gfa;
			parameters[14].Value = model.community_cul_sta_num;
			parameters[15].Value = model.community_cul_sta_fs;
			parameters[16].Value = model.community_cul_sta_gfa;
			parameters[17].Value = model.community_cul_room_num;
			parameters[18].Value = model.community_cul_room_fs;
			parameters[19].Value = model.community_cul_room_gfa;
			parameters[20].Value = model.community_fit_fac_num;
			parameters[21].Value = model.community_fit_fac_intact_rate;
			parameters[22].Value = model.statistics_date;
			parameters[23].Value = model.tccsunset1;
			parameters[24].Value = model.tccsunset2;
			parameters[25].Value = model.tccsunset3;
			parameters[26].Value = model.tccsunset4;
			parameters[27].Value = model.tccsunset5;
			parameters[28].Value = model.tccsunset6;
			parameters[29].Value = model.tccsunset7;
			parameters[30].Value = model.tccsunset8;
			parameters[31].Value = model.tccsunset9;
			parameters[32].Value = model.tccsunset10;
			parameters[33].Value = model.tccsunset11;
			parameters[34].Value = model.tccsunset12;
			parameters[35].Value = model.tccsunset13;
			parameters[36].Value = model.tccsunset14;
			parameters[37].Value = model.tccsunset15;
			parameters[38].Value = model.tccsunset16;
			parameters[39].Value = model.tccsunset17;
			parameters[40].Value = model.tccsunset18;
			parameters[41].Value = model.tccsunset19;
			parameters[42].Value = model.tccsunset20;
			parameters[43].Value = model.tccsunset21;
			parameters[44].Value = model.lock_tables;
			parameters[45].Value = model.check_status;

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
		public bool Update(TTG.Model.TTGWeb.community_culture_sports model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_culture_sports set ");
			strSql.Append("community_culture_sports_fs=@community_culture_sports_fs,");
			strSql.Append("community_culture_sports_gfa=@community_culture_sports_gfa,");
			strSql.Append("community_otd_cul_spo_fac_num=@community_otd_cul_spo_fac_num,");
			strSql.Append("community_otd_cul_spo_fac_gfa=@community_otd_cul_spo_fac_gfa,");
			strSql.Append("community_cul_squ_num=@community_cul_squ_num,");
			strSql.Append("community_cul_squ_fs=@community_cul_squ_fs,");
			strSql.Append("community_otd_entm_num=@community_otd_entm_num,");
			strSql.Append("community_otd_entm_fs=@community_otd_entm_fs,");
			strSql.Append("community_child_plg_num=@community_child_plg_num,");
			strSql.Append("community_child_plg_fs=@community_child_plg_fs,");
			strSql.Append("community_ind_actv_spa_num=@community_ind_actv_spa_num,");
			strSql.Append("community_ind_actv_spa_fs=@community_ind_actv_spa_fs,");
			strSql.Append("community_ind_actv_spa_gfa=@community_ind_actv_spa_gfa,");
			strSql.Append("community_cul_sta_num=@community_cul_sta_num,");
			strSql.Append("community_cul_sta_fs=@community_cul_sta_fs,");
			strSql.Append("community_cul_sta_gfa=@community_cul_sta_gfa,");
			strSql.Append("community_cul_room_num=@community_cul_room_num,");
			strSql.Append("community_cul_room_fs=@community_cul_room_fs,");
			strSql.Append("community_cul_room_gfa=@community_cul_room_gfa,");
			strSql.Append("community_fit_fac_num=@community_fit_fac_num,");
			strSql.Append("community_fit_fac_intact_rate=@community_fit_fac_intact_rate,");
			strSql.Append("tccsunset1=@tccsunset1,");
			strSql.Append("tccsunset2=@tccsunset2,");
			strSql.Append("tccsunset3=@tccsunset3,");
			strSql.Append("tccsunset4=@tccsunset4,");
			strSql.Append("tccsunset5=@tccsunset5,");
			strSql.Append("tccsunset6=@tccsunset6,");
			strSql.Append("tccsunset7=@tccsunset7,");
			strSql.Append("tccsunset8=@tccsunset8,");
			strSql.Append("tccsunset9=@tccsunset9,");
			strSql.Append("tccsunset10=@tccsunset10,");
			strSql.Append("tccsunset11=@tccsunset11,");
			strSql.Append("tccsunset12=@tccsunset12,");
			strSql.Append("tccsunset13=@tccsunset13,");
			strSql.Append("tccsunset14=@tccsunset14,");
			strSql.Append("tccsunset15=@tccsunset15,");
			strSql.Append("tccsunset16=@tccsunset16,");
			strSql.Append("tccsunset17=@tccsunset17,");
			strSql.Append("tccsunset18=@tccsunset18,");
			strSql.Append("tccsunset19=@tccsunset19,");
			strSql.Append("tccsunset20=@tccsunset20,");
			strSql.Append("tccsunset21=@tccsunset21,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_culture_sports_fs", SqlDbType.Float,8),
					new SqlParameter("@community_culture_sports_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_otd_cul_spo_fac_num", SqlDbType.Int,4),
					new SqlParameter("@community_otd_cul_spo_fac_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_cul_squ_num", SqlDbType.Int,4),
					new SqlParameter("@community_cul_squ_fs", SqlDbType.Float,8),
					new SqlParameter("@community_otd_entm_num", SqlDbType.Int,4),
					new SqlParameter("@community_otd_entm_fs", SqlDbType.Float,8),
					new SqlParameter("@community_child_plg_num", SqlDbType.Int,4),
					new SqlParameter("@community_child_plg_fs", SqlDbType.Float,8),
					new SqlParameter("@community_ind_actv_spa_num", SqlDbType.Int,4),
					new SqlParameter("@community_ind_actv_spa_fs", SqlDbType.Float,8),
					new SqlParameter("@community_ind_actv_spa_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_cul_sta_num", SqlDbType.Int,4),
					new SqlParameter("@community_cul_sta_fs", SqlDbType.Float,8),
					new SqlParameter("@community_cul_sta_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_cul_room_num", SqlDbType.Int,4),
					new SqlParameter("@community_cul_room_fs", SqlDbType.Float,8),
					new SqlParameter("@community_cul_room_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_fit_fac_num", SqlDbType.Int,4),
					new SqlParameter("@community_fit_fac_intact_rate", SqlDbType.Float,8),
					new SqlParameter("@tccsunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tccsunset21", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_culture_sports_fs;
			parameters[1].Value = model.community_culture_sports_gfa;
			parameters[2].Value = model.community_otd_cul_spo_fac_num;
			parameters[3].Value = model.community_otd_cul_spo_fac_gfa;
			parameters[4].Value = model.community_cul_squ_num;
			parameters[5].Value = model.community_cul_squ_fs;
			parameters[6].Value = model.community_otd_entm_num;
			parameters[7].Value = model.community_otd_entm_fs;
			parameters[8].Value = model.community_child_plg_num;
			parameters[9].Value = model.community_child_plg_fs;
			parameters[10].Value = model.community_ind_actv_spa_num;
			parameters[11].Value = model.community_ind_actv_spa_fs;
			parameters[12].Value = model.community_ind_actv_spa_gfa;
			parameters[13].Value = model.community_cul_sta_num;
			parameters[14].Value = model.community_cul_sta_fs;
			parameters[15].Value = model.community_cul_sta_gfa;
			parameters[16].Value = model.community_cul_room_num;
			parameters[17].Value = model.community_cul_room_fs;
			parameters[18].Value = model.community_cul_room_gfa;
			parameters[19].Value = model.community_fit_fac_num;
			parameters[20].Value = model.community_fit_fac_intact_rate;
			parameters[21].Value = model.tccsunset1;
			parameters[22].Value = model.tccsunset2;
			parameters[23].Value = model.tccsunset3;
			parameters[24].Value = model.tccsunset4;
			parameters[25].Value = model.tccsunset5;
			parameters[26].Value = model.tccsunset6;
			parameters[27].Value = model.tccsunset7;
			parameters[28].Value = model.tccsunset8;
			parameters[29].Value = model.tccsunset9;
			parameters[30].Value = model.tccsunset10;
			parameters[31].Value = model.tccsunset11;
			parameters[32].Value = model.tccsunset12;
			parameters[33].Value = model.tccsunset13;
			parameters[34].Value = model.tccsunset14;
			parameters[35].Value = model.tccsunset15;
			parameters[36].Value = model.tccsunset16;
			parameters[37].Value = model.tccsunset17;
			parameters[38].Value = model.tccsunset18;
			parameters[39].Value = model.tccsunset19;
			parameters[40].Value = model.tccsunset20;
			parameters[41].Value = model.tccsunset21;
			parameters[42].Value = model.lock_tables;
			parameters[43].Value = model.check_status;
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
			strSql.Append("delete from T_community_culture_sports ");
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
		public TTG.Model.TTGWeb.community_culture_sports GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_culture_sports_fs,community_culture_sports_gfa,community_otd_cul_spo_fac_num,community_otd_cul_spo_fac_gfa,community_cul_squ_num,community_cul_squ_fs,community_otd_entm_num,community_otd_entm_fs,community_child_plg_num,community_child_plg_fs,community_ind_actv_spa_num,community_ind_actv_spa_fs,community_ind_actv_spa_gfa,community_cul_sta_num,community_cul_sta_fs,community_cul_sta_gfa,community_cul_room_num,community_cul_room_fs,community_cul_room_gfa,community_fit_fac_num,community_fit_fac_intact_rate,statistics_date,tccsunset1,tccsunset2,tccsunset3,tccsunset4,tccsunset5,tccsunset6,tccsunset7,tccsunset8,tccsunset9,tccsunset10,tccsunset11,tccsunset12,tccsunset13,tccsunset14,tccsunset15,tccsunset16,tccsunset17,tccsunset18,tccsunset19,tccsunset20,tccsunset21,lock_tables,check_status from T_community_culture_sports ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_culture_sports model=new TTG.Model.TTGWeb.community_culture_sports();
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
		public TTG.Model.TTGWeb.community_culture_sports DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_culture_sports model=new TTG.Model.TTGWeb.community_culture_sports();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_culture_sports_fs"]!=null && row["community_culture_sports_fs"].ToString()!="")
				{
					model.community_culture_sports_fs=decimal.Parse(row["community_culture_sports_fs"].ToString());
				}
				if(row["community_culture_sports_gfa"]!=null && row["community_culture_sports_gfa"].ToString()!="")
				{
					model.community_culture_sports_gfa=decimal.Parse(row["community_culture_sports_gfa"].ToString());
				}
				if(row["community_otd_cul_spo_fac_num"]!=null && row["community_otd_cul_spo_fac_num"].ToString()!="")
				{
					model.community_otd_cul_spo_fac_num=int.Parse(row["community_otd_cul_spo_fac_num"].ToString());
				}
				if(row["community_otd_cul_spo_fac_gfa"]!=null && row["community_otd_cul_spo_fac_gfa"].ToString()!="")
				{
					model.community_otd_cul_spo_fac_gfa=decimal.Parse(row["community_otd_cul_spo_fac_gfa"].ToString());
				}
				if(row["community_cul_squ_num"]!=null && row["community_cul_squ_num"].ToString()!="")
				{
					model.community_cul_squ_num=int.Parse(row["community_cul_squ_num"].ToString());
				}
				if(row["community_cul_squ_fs"]!=null && row["community_cul_squ_fs"].ToString()!="")
				{
					model.community_cul_squ_fs=decimal.Parse(row["community_cul_squ_fs"].ToString());
				}
				if(row["community_otd_entm_num"]!=null && row["community_otd_entm_num"].ToString()!="")
				{
					model.community_otd_entm_num=int.Parse(row["community_otd_entm_num"].ToString());
				}
				if(row["community_otd_entm_fs"]!=null && row["community_otd_entm_fs"].ToString()!="")
				{
					model.community_otd_entm_fs=decimal.Parse(row["community_otd_entm_fs"].ToString());
				}
				if(row["community_child_plg_num"]!=null && row["community_child_plg_num"].ToString()!="")
				{
					model.community_child_plg_num=int.Parse(row["community_child_plg_num"].ToString());
				}
				if(row["community_child_plg_fs"]!=null && row["community_child_plg_fs"].ToString()!="")
				{
					model.community_child_plg_fs=decimal.Parse(row["community_child_plg_fs"].ToString());
				}
				if(row["community_ind_actv_spa_num"]!=null && row["community_ind_actv_spa_num"].ToString()!="")
				{
					model.community_ind_actv_spa_num=int.Parse(row["community_ind_actv_spa_num"].ToString());
				}
				if(row["community_ind_actv_spa_fs"]!=null && row["community_ind_actv_spa_fs"].ToString()!="")
				{
					model.community_ind_actv_spa_fs=decimal.Parse(row["community_ind_actv_spa_fs"].ToString());
				}
				if(row["community_ind_actv_spa_gfa"]!=null && row["community_ind_actv_spa_gfa"].ToString()!="")
				{
					model.community_ind_actv_spa_gfa=decimal.Parse(row["community_ind_actv_spa_gfa"].ToString());
				}
				if(row["community_cul_sta_num"]!=null && row["community_cul_sta_num"].ToString()!="")
				{
					model.community_cul_sta_num=int.Parse(row["community_cul_sta_num"].ToString());
				}
				if(row["community_cul_sta_fs"]!=null && row["community_cul_sta_fs"].ToString()!="")
				{
					model.community_cul_sta_fs=decimal.Parse(row["community_cul_sta_fs"].ToString());
				}
				if(row["community_cul_sta_gfa"]!=null && row["community_cul_sta_gfa"].ToString()!="")
				{
					model.community_cul_sta_gfa=decimal.Parse(row["community_cul_sta_gfa"].ToString());
				}
				if(row["community_cul_room_num"]!=null && row["community_cul_room_num"].ToString()!="")
				{
					model.community_cul_room_num=int.Parse(row["community_cul_room_num"].ToString());
				}
				if(row["community_cul_room_fs"]!=null && row["community_cul_room_fs"].ToString()!="")
				{
					model.community_cul_room_fs=decimal.Parse(row["community_cul_room_fs"].ToString());
				}
				if(row["community_cul_room_gfa"]!=null && row["community_cul_room_gfa"].ToString()!="")
				{
					model.community_cul_room_gfa=decimal.Parse(row["community_cul_room_gfa"].ToString());
				}
				if(row["community_fit_fac_num"]!=null && row["community_fit_fac_num"].ToString()!="")
				{
					model.community_fit_fac_num=int.Parse(row["community_fit_fac_num"].ToString());
				}
				if(row["community_fit_fac_intact_rate"]!=null && row["community_fit_fac_intact_rate"].ToString()!="")
				{
					model.community_fit_fac_intact_rate=decimal.Parse(row["community_fit_fac_intact_rate"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tccsunset1"]!=null)
				{
					model.tccsunset1=row["tccsunset1"].ToString();
				}
				if(row["tccsunset2"]!=null)
				{
					model.tccsunset2=row["tccsunset2"].ToString();
				}
				if(row["tccsunset3"]!=null)
				{
					model.tccsunset3=row["tccsunset3"].ToString();
				}
				if(row["tccsunset4"]!=null)
				{
					model.tccsunset4=row["tccsunset4"].ToString();
				}
				if(row["tccsunset5"]!=null)
				{
					model.tccsunset5=row["tccsunset5"].ToString();
				}
				if(row["tccsunset6"]!=null)
				{
					model.tccsunset6=row["tccsunset6"].ToString();
				}
				if(row["tccsunset7"]!=null)
				{
					model.tccsunset7=row["tccsunset7"].ToString();
				}
				if(row["tccsunset8"]!=null)
				{
					model.tccsunset8=row["tccsunset8"].ToString();
				}
				if(row["tccsunset9"]!=null)
				{
					model.tccsunset9=row["tccsunset9"].ToString();
				}
				if(row["tccsunset10"]!=null)
				{
					model.tccsunset10=row["tccsunset10"].ToString();
				}
				if(row["tccsunset11"]!=null)
				{
					model.tccsunset11=row["tccsunset11"].ToString();
				}
				if(row["tccsunset12"]!=null)
				{
					model.tccsunset12=row["tccsunset12"].ToString();
				}
				if(row["tccsunset13"]!=null)
				{
					model.tccsunset13=row["tccsunset13"].ToString();
				}
				if(row["tccsunset14"]!=null)
				{
					model.tccsunset14=row["tccsunset14"].ToString();
				}
				if(row["tccsunset15"]!=null)
				{
					model.tccsunset15=row["tccsunset15"].ToString();
				}
				if(row["tccsunset16"]!=null)
				{
					model.tccsunset16=row["tccsunset16"].ToString();
				}
				if(row["tccsunset17"]!=null)
				{
					model.tccsunset17=row["tccsunset17"].ToString();
				}
				if(row["tccsunset18"]!=null)
				{
					model.tccsunset18=row["tccsunset18"].ToString();
				}
				if(row["tccsunset19"]!=null)
				{
					model.tccsunset19=row["tccsunset19"].ToString();
				}
				if(row["tccsunset20"]!=null)
				{
					model.tccsunset20=row["tccsunset20"].ToString();
				}
				if(row["tccsunset21"]!=null)
				{
					model.tccsunset21=row["tccsunset21"].ToString();
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
			strSql.Append("select community_id,community_culture_sports_fs,community_culture_sports_gfa,community_otd_cul_spo_fac_num,community_otd_cul_spo_fac_gfa,community_cul_squ_num,community_cul_squ_fs,community_otd_entm_num,community_otd_entm_fs,community_child_plg_num,community_child_plg_fs,community_ind_actv_spa_num,community_ind_actv_spa_fs,community_ind_actv_spa_gfa,community_cul_sta_num,community_cul_sta_fs,community_cul_sta_gfa,community_cul_room_num,community_cul_room_fs,community_cul_room_gfa,community_fit_fac_num,community_fit_fac_intact_rate,statistics_date,tccsunset1,tccsunset2,tccsunset3,tccsunset4,tccsunset5,tccsunset6,tccsunset7,tccsunset8,tccsunset9,tccsunset10,tccsunset11,tccsunset12,tccsunset13,tccsunset14,tccsunset15,tccsunset16,tccsunset17,tccsunset18,tccsunset19,tccsunset20,tccsunset21,lock_tables,check_status ");
			strSql.Append(" FROM T_community_culture_sports ");
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
			strSql.Append(" community_id,community_culture_sports_fs,community_culture_sports_gfa,community_otd_cul_spo_fac_num,community_otd_cul_spo_fac_gfa,community_cul_squ_num,community_cul_squ_fs,community_otd_entm_num,community_otd_entm_fs,community_child_plg_num,community_child_plg_fs,community_ind_actv_spa_num,community_ind_actv_spa_fs,community_ind_actv_spa_gfa,community_cul_sta_num,community_cul_sta_fs,community_cul_sta_gfa,community_cul_room_num,community_cul_room_fs,community_cul_room_gfa,community_fit_fac_num,community_fit_fac_intact_rate,statistics_date,tccsunset1,tccsunset2,tccsunset3,tccsunset4,tccsunset5,tccsunset6,tccsunset7,tccsunset8,tccsunset9,tccsunset10,tccsunset11,tccsunset12,tccsunset13,tccsunset14,tccsunset15,tccsunset16,tccsunset17,tccsunset18,tccsunset19,tccsunset20,tccsunset21,lock_tables,check_status ");
			strSql.Append(" FROM T_community_culture_sports ");
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
			strSql.Append("select count(1) FROM T_community_culture_sports ");
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
			strSql.Append(")AS Row, T.*  from T_community_culture_sports T ");
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
			parameters[0].Value = "T_community_culture_sports";
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

