using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_service
	/// </summary>
	public partial class community_service
	{
		public community_service()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_service");
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
		public bool Add(TTG.Model.TTGWeb.community_service model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_service(");
			strSql.Append("community_id,community_comm_serv_fac_fs,community_comm_serv_fac_gfa,community_comm_serv_cen_fs,community_comm_serv_cen_gfa,community_comm_serv_cen_dis_ots,community_empm_supt_cen_fs,community_empm_supt_cen_gfa,community_empm_supt_cen_dis_ots,community_police_sta_fs,community_police_sta_gfa,community_police_sta_dis_ots,community_prop_magm_unit_num,community_no_prop_magm_unit_num,statistics_date,tcsrunset1,tcsrunset2,tcsrunset3,tcsrunset4,tcsrunset5,tcsrunset6,tcsrunset7,tcsrunset8,tcsrunset9,tcsrunset10,tcsrunset11,tcsrunset12,tcsrunset13,lock_tables,check_status,community_old_fs,community_old_gfa,community_old_dis_ots)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_comm_serv_fac_fs,@community_comm_serv_fac_gfa,@community_comm_serv_cen_fs,@community_comm_serv_cen_gfa,@community_comm_serv_cen_dis_ots,@community_empm_supt_cen_fs,@community_empm_supt_cen_gfa,@community_empm_supt_cen_dis_ots,@community_police_sta_fs,@community_police_sta_gfa,@community_police_sta_dis_ots,@community_prop_magm_unit_num,@community_no_prop_magm_unit_num,@statistics_date,@tcsrunset1,@tcsrunset2,@tcsrunset3,@tcsrunset4,@tcsrunset5,@tcsrunset6,@tcsrunset7,@tcsrunset8,@tcsrunset9,@tcsrunset10,@tcsrunset11,@tcsrunset12,@tcsrunset13,@lock_tables,@check_status,@community_old_fs,@community_old_gfa,@community_old_dis_ots)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_comm_serv_fac_fs", SqlDbType.Float,8),
					new SqlParameter("@community_comm_serv_fac_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_comm_serv_cen_fs", SqlDbType.Float,8),
					new SqlParameter("@community_comm_serv_cen_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_comm_serv_cen_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_empm_supt_cen_fs", SqlDbType.Float,8),
					new SqlParameter("@community_empm_supt_cen_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_empm_supt_cen_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_police_sta_fs", SqlDbType.Float,8),
					new SqlParameter("@community_police_sta_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_police_sta_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_prop_magm_unit_num", SqlDbType.Int,4),
					new SqlParameter("@community_no_prop_magm_unit_num", SqlDbType.Int,4),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcsrunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset13", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_old_fs", SqlDbType.Float,8),
					new SqlParameter("@community_old_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_old_dis_ots", SqlDbType.Float,8)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_comm_serv_fac_fs;
			parameters[2].Value = model.community_comm_serv_fac_gfa;
			parameters[3].Value = model.community_comm_serv_cen_fs;
			parameters[4].Value = model.community_comm_serv_cen_gfa;
			parameters[5].Value = model.community_comm_serv_cen_dis_ots;
			parameters[6].Value = model.community_empm_supt_cen_fs;
			parameters[7].Value = model.community_empm_supt_cen_gfa;
			parameters[8].Value = model.community_empm_supt_cen_dis_ots;
			parameters[9].Value = model.community_police_sta_fs;
			parameters[10].Value = model.community_police_sta_gfa;
			parameters[11].Value = model.community_police_sta_dis_ots;
			parameters[12].Value = model.community_prop_magm_unit_num;
			parameters[13].Value = model.community_no_prop_magm_unit_num;
			parameters[14].Value = model.statistics_date;
			parameters[15].Value = model.tcsrunset1;
			parameters[16].Value = model.tcsrunset2;
			parameters[17].Value = model.tcsrunset3;
			parameters[18].Value = model.tcsrunset4;
			parameters[19].Value = model.tcsrunset5;
			parameters[20].Value = model.tcsrunset6;
			parameters[21].Value = model.tcsrunset7;
			parameters[22].Value = model.tcsrunset8;
			parameters[23].Value = model.tcsrunset9;
			parameters[24].Value = model.tcsrunset10;
			parameters[25].Value = model.tcsrunset11;
			parameters[26].Value = model.tcsrunset12;
			parameters[27].Value = model.tcsrunset13;
			parameters[28].Value = model.lock_tables;
			parameters[29].Value = model.check_status;
			parameters[30].Value = model.community_old_fs;
			parameters[31].Value = model.community_old_gfa;
			parameters[32].Value = model.community_old_dis_ots;

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
		public bool Update(TTG.Model.TTGWeb.community_service model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_service set ");
			strSql.Append("community_comm_serv_fac_fs=@community_comm_serv_fac_fs,");
			strSql.Append("community_comm_serv_fac_gfa=@community_comm_serv_fac_gfa,");
			strSql.Append("community_comm_serv_cen_fs=@community_comm_serv_cen_fs,");
			strSql.Append("community_comm_serv_cen_gfa=@community_comm_serv_cen_gfa,");
			strSql.Append("community_comm_serv_cen_dis_ots=@community_comm_serv_cen_dis_ots,");
			strSql.Append("community_empm_supt_cen_fs=@community_empm_supt_cen_fs,");
			strSql.Append("community_empm_supt_cen_gfa=@community_empm_supt_cen_gfa,");
			strSql.Append("community_empm_supt_cen_dis_ots=@community_empm_supt_cen_dis_ots,");
			strSql.Append("community_police_sta_fs=@community_police_sta_fs,");
			strSql.Append("community_police_sta_gfa=@community_police_sta_gfa,");
			strSql.Append("community_police_sta_dis_ots=@community_police_sta_dis_ots,");
			strSql.Append("community_prop_magm_unit_num=@community_prop_magm_unit_num,");
			strSql.Append("community_no_prop_magm_unit_num=@community_no_prop_magm_unit_num,");
			strSql.Append("tcsrunset1=@tcsrunset1,");
			strSql.Append("tcsrunset2=@tcsrunset2,");
			strSql.Append("tcsrunset3=@tcsrunset3,");
			strSql.Append("tcsrunset4=@tcsrunset4,");
			strSql.Append("tcsrunset5=@tcsrunset5,");
			strSql.Append("tcsrunset6=@tcsrunset6,");
			strSql.Append("tcsrunset7=@tcsrunset7,");
			strSql.Append("tcsrunset8=@tcsrunset8,");
			strSql.Append("tcsrunset9=@tcsrunset9,");
			strSql.Append("tcsrunset10=@tcsrunset10,");
			strSql.Append("tcsrunset11=@tcsrunset11,");
			strSql.Append("tcsrunset12=@tcsrunset12,");
			strSql.Append("tcsrunset13=@tcsrunset13,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("community_old_fs=@community_old_fs,");
			strSql.Append("community_old_gfa=@community_old_gfa,");
			strSql.Append("community_old_dis_ots=@community_old_dis_ots");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_comm_serv_fac_fs", SqlDbType.Float,8),
					new SqlParameter("@community_comm_serv_fac_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_comm_serv_cen_fs", SqlDbType.Float,8),
					new SqlParameter("@community_comm_serv_cen_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_comm_serv_cen_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_empm_supt_cen_fs", SqlDbType.Float,8),
					new SqlParameter("@community_empm_supt_cen_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_empm_supt_cen_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_police_sta_fs", SqlDbType.Float,8),
					new SqlParameter("@community_police_sta_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_police_sta_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_prop_magm_unit_num", SqlDbType.Int,4),
					new SqlParameter("@community_no_prop_magm_unit_num", SqlDbType.Int,4),
					new SqlParameter("@tcsrunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcsrunset13", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_old_fs", SqlDbType.Float,8),
					new SqlParameter("@community_old_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_old_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_comm_serv_fac_fs;
			parameters[1].Value = model.community_comm_serv_fac_gfa;
			parameters[2].Value = model.community_comm_serv_cen_fs;
			parameters[3].Value = model.community_comm_serv_cen_gfa;
			parameters[4].Value = model.community_comm_serv_cen_dis_ots;
			parameters[5].Value = model.community_empm_supt_cen_fs;
			parameters[6].Value = model.community_empm_supt_cen_gfa;
			parameters[7].Value = model.community_empm_supt_cen_dis_ots;
			parameters[8].Value = model.community_police_sta_fs;
			parameters[9].Value = model.community_police_sta_gfa;
			parameters[10].Value = model.community_police_sta_dis_ots;
			parameters[11].Value = model.community_prop_magm_unit_num;
			parameters[12].Value = model.community_no_prop_magm_unit_num;
			parameters[13].Value = model.tcsrunset1;
			parameters[14].Value = model.tcsrunset2;
			parameters[15].Value = model.tcsrunset3;
			parameters[16].Value = model.tcsrunset4;
			parameters[17].Value = model.tcsrunset5;
			parameters[18].Value = model.tcsrunset6;
			parameters[19].Value = model.tcsrunset7;
			parameters[20].Value = model.tcsrunset8;
			parameters[21].Value = model.tcsrunset9;
			parameters[22].Value = model.tcsrunset10;
			parameters[23].Value = model.tcsrunset11;
			parameters[24].Value = model.tcsrunset12;
			parameters[25].Value = model.tcsrunset13;
			parameters[26].Value = model.lock_tables;
			parameters[27].Value = model.check_status;
			parameters[28].Value = model.community_old_fs;
			parameters[29].Value = model.community_old_gfa;
			parameters[30].Value = model.community_old_dis_ots;
			parameters[31].Value = model.community_id;
			parameters[32].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_service ");
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
		public TTG.Model.TTGWeb.community_service GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_comm_serv_fac_fs,community_comm_serv_fac_gfa,community_comm_serv_cen_fs,community_comm_serv_cen_gfa,community_comm_serv_cen_dis_ots,community_empm_supt_cen_fs,community_empm_supt_cen_gfa,community_empm_supt_cen_dis_ots,community_police_sta_fs,community_police_sta_gfa,community_police_sta_dis_ots,community_prop_magm_unit_num,community_no_prop_magm_unit_num,statistics_date,tcsrunset1,tcsrunset2,tcsrunset3,tcsrunset4,tcsrunset5,tcsrunset6,tcsrunset7,tcsrunset8,tcsrunset9,tcsrunset10,tcsrunset11,tcsrunset12,tcsrunset13,lock_tables,check_status,community_old_fs,community_old_gfa,community_old_dis_ots from T_community_service ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_service model=new TTG.Model.TTGWeb.community_service();
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
		public TTG.Model.TTGWeb.community_service DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_service model=new TTG.Model.TTGWeb.community_service();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_comm_serv_fac_fs"]!=null && row["community_comm_serv_fac_fs"].ToString()!="")
				{
					model.community_comm_serv_fac_fs=decimal.Parse(row["community_comm_serv_fac_fs"].ToString());
				}
				if(row["community_comm_serv_fac_gfa"]!=null && row["community_comm_serv_fac_gfa"].ToString()!="")
				{
					model.community_comm_serv_fac_gfa=decimal.Parse(row["community_comm_serv_fac_gfa"].ToString());
				}
				if(row["community_comm_serv_cen_fs"]!=null && row["community_comm_serv_cen_fs"].ToString()!="")
				{
					model.community_comm_serv_cen_fs=decimal.Parse(row["community_comm_serv_cen_fs"].ToString());
				}
				if(row["community_comm_serv_cen_gfa"]!=null && row["community_comm_serv_cen_gfa"].ToString()!="")
				{
					model.community_comm_serv_cen_gfa=decimal.Parse(row["community_comm_serv_cen_gfa"].ToString());
				}
				if(row["community_comm_serv_cen_dis_ots"]!=null && row["community_comm_serv_cen_dis_ots"].ToString()!="")
				{
					model.community_comm_serv_cen_dis_ots=decimal.Parse(row["community_comm_serv_cen_dis_ots"].ToString());
				}
				if(row["community_empm_supt_cen_fs"]!=null && row["community_empm_supt_cen_fs"].ToString()!="")
				{
					model.community_empm_supt_cen_fs=decimal.Parse(row["community_empm_supt_cen_fs"].ToString());
				}
				if(row["community_empm_supt_cen_gfa"]!=null && row["community_empm_supt_cen_gfa"].ToString()!="")
				{
					model.community_empm_supt_cen_gfa=decimal.Parse(row["community_empm_supt_cen_gfa"].ToString());
				}
				if(row["community_empm_supt_cen_dis_ots"]!=null && row["community_empm_supt_cen_dis_ots"].ToString()!="")
				{
					model.community_empm_supt_cen_dis_ots=decimal.Parse(row["community_empm_supt_cen_dis_ots"].ToString());
				}
				if(row["community_police_sta_fs"]!=null && row["community_police_sta_fs"].ToString()!="")
				{
					model.community_police_sta_fs=decimal.Parse(row["community_police_sta_fs"].ToString());
				}
				if(row["community_police_sta_gfa"]!=null && row["community_police_sta_gfa"].ToString()!="")
				{
					model.community_police_sta_gfa=decimal.Parse(row["community_police_sta_gfa"].ToString());
				}
				if(row["community_police_sta_dis_ots"]!=null && row["community_police_sta_dis_ots"].ToString()!="")
				{
					model.community_police_sta_dis_ots=decimal.Parse(row["community_police_sta_dis_ots"].ToString());
				}
				if(row["community_prop_magm_unit_num"]!=null && row["community_prop_magm_unit_num"].ToString()!="")
				{
					model.community_prop_magm_unit_num=int.Parse(row["community_prop_magm_unit_num"].ToString());
				}
				if(row["community_no_prop_magm_unit_num"]!=null && row["community_no_prop_magm_unit_num"].ToString()!="")
				{
					model.community_no_prop_magm_unit_num=int.Parse(row["community_no_prop_magm_unit_num"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcsrunset1"]!=null)
				{
					model.tcsrunset1=row["tcsrunset1"].ToString();
				}
				if(row["tcsrunset2"]!=null)
				{
					model.tcsrunset2=row["tcsrunset2"].ToString();
				}
				if(row["tcsrunset3"]!=null)
				{
					model.tcsrunset3=row["tcsrunset3"].ToString();
				}
				if(row["tcsrunset4"]!=null)
				{
					model.tcsrunset4=row["tcsrunset4"].ToString();
				}
				if(row["tcsrunset5"]!=null)
				{
					model.tcsrunset5=row["tcsrunset5"].ToString();
				}
				if(row["tcsrunset6"]!=null)
				{
					model.tcsrunset6=row["tcsrunset6"].ToString();
				}
				if(row["tcsrunset7"]!=null)
				{
					model.tcsrunset7=row["tcsrunset7"].ToString();
				}
				if(row["tcsrunset8"]!=null)
				{
					model.tcsrunset8=row["tcsrunset8"].ToString();
				}
				if(row["tcsrunset9"]!=null)
				{
					model.tcsrunset9=row["tcsrunset9"].ToString();
				}
				if(row["tcsrunset10"]!=null)
				{
					model.tcsrunset10=row["tcsrunset10"].ToString();
				}
				if(row["tcsrunset11"]!=null)
				{
					model.tcsrunset11=row["tcsrunset11"].ToString();
				}
				if(row["tcsrunset12"]!=null)
				{
					model.tcsrunset12=row["tcsrunset12"].ToString();
				}
				if(row["tcsrunset13"]!=null)
				{
					model.tcsrunset13=row["tcsrunset13"].ToString();
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["community_old_fs"]!=null && row["community_old_fs"].ToString()!="")
				{
					model.community_old_fs=decimal.Parse(row["community_old_fs"].ToString());
				}
				if(row["community_old_gfa"]!=null && row["community_old_gfa"].ToString()!="")
				{
					model.community_old_gfa=decimal.Parse(row["community_old_gfa"].ToString());
				}
				if(row["community_old_dis_ots"]!=null && row["community_old_dis_ots"].ToString()!="")
				{
					model.community_old_dis_ots=decimal.Parse(row["community_old_dis_ots"].ToString());
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
			strSql.Append("select community_id,community_comm_serv_fac_fs,community_comm_serv_fac_gfa,community_comm_serv_cen_fs,community_comm_serv_cen_gfa,community_comm_serv_cen_dis_ots,community_empm_supt_cen_fs,community_empm_supt_cen_gfa,community_empm_supt_cen_dis_ots,community_police_sta_fs,community_police_sta_gfa,community_police_sta_dis_ots,community_prop_magm_unit_num,community_no_prop_magm_unit_num,statistics_date,tcsrunset1,tcsrunset2,tcsrunset3,tcsrunset4,tcsrunset5,tcsrunset6,tcsrunset7,tcsrunset8,tcsrunset9,tcsrunset10,tcsrunset11,tcsrunset12,tcsrunset13,lock_tables,check_status,community_old_fs,community_old_gfa,community_old_dis_ots ");
			strSql.Append(" FROM T_community_service ");
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
			strSql.Append(" community_id,community_comm_serv_fac_fs,community_comm_serv_fac_gfa,community_comm_serv_cen_fs,community_comm_serv_cen_gfa,community_comm_serv_cen_dis_ots,community_empm_supt_cen_fs,community_empm_supt_cen_gfa,community_empm_supt_cen_dis_ots,community_police_sta_fs,community_police_sta_gfa,community_police_sta_dis_ots,community_prop_magm_unit_num,community_no_prop_magm_unit_num,statistics_date,tcsrunset1,tcsrunset2,tcsrunset3,tcsrunset4,tcsrunset5,tcsrunset6,tcsrunset7,tcsrunset8,tcsrunset9,tcsrunset10,tcsrunset11,tcsrunset12,tcsrunset13,lock_tables,check_status,community_old_fs,community_old_gfa,community_old_dis_ots ");
			strSql.Append(" FROM T_community_service ");
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
			strSql.Append("select count(1) FROM T_community_service ");
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
			strSql.Append(")AS Row, T.*  from T_community_service T ");
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
			parameters[0].Value = "T_community_service";
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

