using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_medical
	/// </summary>
	public partial class community_medical
	{
		public community_medical()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_medical");
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
		public bool Add(TTG.Model.TTGWeb.community_medical model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_medical(");
			strSql.Append("community_id,community_medical_inst_num,community_medical_inst_fs,community_medical_inst_gfa,community_hospital_num,community_hospital_gfa,community_hospital_fs,community_hospital_bed_num,community_hospital_dis_ots,community_heal_sta_num,community_heal_sta_fs,community_heal_sta_gfa,community_heal_sta_bed_num,community_heal_sta_dis_ots,community_clinic_num,community_clinic_fs,community_clinic_gfa,community_clinic_bed_num,community_clinic_dis_ots,statistics_date,tcmunset1,tcmunset2,tcmunset3,tcmunset4,tcmunset5,tcmunset6,tcmunset7,tcmunset8,tcmunset9,tcmunset10,tcmunset11,tcmunset12,tcmunset13,tcmunset14,tcmunset15,tcmunset16,tcmunset17,tcmunset18,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_medical_inst_num,@community_medical_inst_fs,@community_medical_inst_gfa,@community_hospital_num,@community_hospital_gfa,@community_hospital_fs,@community_hospital_bed_num,@community_hospital_dis_ots,@community_heal_sta_num,@community_heal_sta_fs,@community_heal_sta_gfa,@community_heal_sta_bed_num,@community_heal_sta_dis_ots,@community_clinic_num,@community_clinic_fs,@community_clinic_gfa,@community_clinic_bed_num,@community_clinic_dis_ots,@statistics_date,@tcmunset1,@tcmunset2,@tcmunset3,@tcmunset4,@tcmunset5,@tcmunset6,@tcmunset7,@tcmunset8,@tcmunset9,@tcmunset10,@tcmunset11,@tcmunset12,@tcmunset13,@tcmunset14,@tcmunset15,@tcmunset16,@tcmunset17,@tcmunset18,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_medical_inst_num", SqlDbType.Int,4),
					new SqlParameter("@community_medical_inst_fs", SqlDbType.Float,8),
					new SqlParameter("@community_medical_inst_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_hospital_num", SqlDbType.Int,4),
					new SqlParameter("@community_hospital_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_hospital_fs", SqlDbType.Float,8),
					new SqlParameter("@community_hospital_bed_num", SqlDbType.Int,4),
					new SqlParameter("@community_hospital_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_heal_sta_num", SqlDbType.Int,4),
					new SqlParameter("@community_heal_sta_fs", SqlDbType.Float,8),
					new SqlParameter("@community_heal_sta_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_heal_sta_bed_num", SqlDbType.Int,4),
					new SqlParameter("@community_heal_sta_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_clinic_num", SqlDbType.Int,4),
					new SqlParameter("@community_clinic_fs", SqlDbType.Float,8),
					new SqlParameter("@community_clinic_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_clinic_bed_num", SqlDbType.Int,4),
					new SqlParameter("@community_clinic_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcmunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset18", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_medical_inst_num;
			parameters[2].Value = model.community_medical_inst_fs;
			parameters[3].Value = model.community_medical_inst_gfa;
			parameters[4].Value = model.community_hospital_num;
			parameters[5].Value = model.community_hospital_gfa;
			parameters[6].Value = model.community_hospital_fs;
			parameters[7].Value = model.community_hospital_bed_num;
			parameters[8].Value = model.community_hospital_dis_ots;
			parameters[9].Value = model.community_heal_sta_num;
			parameters[10].Value = model.community_heal_sta_fs;
			parameters[11].Value = model.community_heal_sta_gfa;
			parameters[12].Value = model.community_heal_sta_bed_num;
			parameters[13].Value = model.community_heal_sta_dis_ots;
			parameters[14].Value = model.community_clinic_num;
			parameters[15].Value = model.community_clinic_fs;
			parameters[16].Value = model.community_clinic_gfa;
			parameters[17].Value = model.community_clinic_bed_num;
			parameters[18].Value = model.community_clinic_dis_ots;
			parameters[19].Value = model.statistics_date;
			parameters[20].Value = model.tcmunset1;
			parameters[21].Value = model.tcmunset2;
			parameters[22].Value = model.tcmunset3;
			parameters[23].Value = model.tcmunset4;
			parameters[24].Value = model.tcmunset5;
			parameters[25].Value = model.tcmunset6;
			parameters[26].Value = model.tcmunset7;
			parameters[27].Value = model.tcmunset8;
			parameters[28].Value = model.tcmunset9;
			parameters[29].Value = model.tcmunset10;
			parameters[30].Value = model.tcmunset11;
			parameters[31].Value = model.tcmunset12;
			parameters[32].Value = model.tcmunset13;
			parameters[33].Value = model.tcmunset14;
			parameters[34].Value = model.tcmunset15;
			parameters[35].Value = model.tcmunset16;
			parameters[36].Value = model.tcmunset17;
			parameters[37].Value = model.tcmunset18;
			parameters[38].Value = model.lock_tables;
			parameters[39].Value = model.check_status;

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
		public bool Update(TTG.Model.TTGWeb.community_medical model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_medical set ");
			strSql.Append("community_medical_inst_num=@community_medical_inst_num,");
			strSql.Append("community_medical_inst_fs=@community_medical_inst_fs,");
			strSql.Append("community_medical_inst_gfa=@community_medical_inst_gfa,");
			strSql.Append("community_hospital_num=@community_hospital_num,");
			strSql.Append("community_hospital_gfa=@community_hospital_gfa,");
			strSql.Append("community_hospital_fs=@community_hospital_fs,");
			strSql.Append("community_hospital_bed_num=@community_hospital_bed_num,");
			strSql.Append("community_hospital_dis_ots=@community_hospital_dis_ots,");
			strSql.Append("community_heal_sta_num=@community_heal_sta_num,");
			strSql.Append("community_heal_sta_fs=@community_heal_sta_fs,");
			strSql.Append("community_heal_sta_gfa=@community_heal_sta_gfa,");
			strSql.Append("community_heal_sta_bed_num=@community_heal_sta_bed_num,");
			strSql.Append("community_heal_sta_dis_ots=@community_heal_sta_dis_ots,");
			strSql.Append("community_clinic_num=@community_clinic_num,");
			strSql.Append("community_clinic_fs=@community_clinic_fs,");
			strSql.Append("community_clinic_gfa=@community_clinic_gfa,");
			strSql.Append("community_clinic_bed_num=@community_clinic_bed_num,");
			strSql.Append("community_clinic_dis_ots=@community_clinic_dis_ots,");
			strSql.Append("tcmunset1=@tcmunset1,");
			strSql.Append("tcmunset2=@tcmunset2,");
			strSql.Append("tcmunset3=@tcmunset3,");
			strSql.Append("tcmunset4=@tcmunset4,");
			strSql.Append("tcmunset5=@tcmunset5,");
			strSql.Append("tcmunset6=@tcmunset6,");
			strSql.Append("tcmunset7=@tcmunset7,");
			strSql.Append("tcmunset8=@tcmunset8,");
			strSql.Append("tcmunset9=@tcmunset9,");
			strSql.Append("tcmunset10=@tcmunset10,");
			strSql.Append("tcmunset11=@tcmunset11,");
			strSql.Append("tcmunset12=@tcmunset12,");
			strSql.Append("tcmunset13=@tcmunset13,");
			strSql.Append("tcmunset14=@tcmunset14,");
			strSql.Append("tcmunset15=@tcmunset15,");
			strSql.Append("tcmunset16=@tcmunset16,");
			strSql.Append("tcmunset17=@tcmunset17,");
			strSql.Append("tcmunset18=@tcmunset18,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_medical_inst_num", SqlDbType.Int,4),
					new SqlParameter("@community_medical_inst_fs", SqlDbType.Float,8),
					new SqlParameter("@community_medical_inst_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_hospital_num", SqlDbType.Int,4),
					new SqlParameter("@community_hospital_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_hospital_fs", SqlDbType.Float,8),
					new SqlParameter("@community_hospital_bed_num", SqlDbType.Int,4),
					new SqlParameter("@community_hospital_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_heal_sta_num", SqlDbType.Int,4),
					new SqlParameter("@community_heal_sta_fs", SqlDbType.Float,8),
					new SqlParameter("@community_heal_sta_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_heal_sta_bed_num", SqlDbType.Int,4),
					new SqlParameter("@community_heal_sta_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_clinic_num", SqlDbType.Int,4),
					new SqlParameter("@community_clinic_fs", SqlDbType.Float,8),
					new SqlParameter("@community_clinic_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_clinic_bed_num", SqlDbType.Int,4),
					new SqlParameter("@community_clinic_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@tcmunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tcmunset18", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_medical_inst_num;
			parameters[1].Value = model.community_medical_inst_fs;
			parameters[2].Value = model.community_medical_inst_gfa;
			parameters[3].Value = model.community_hospital_num;
			parameters[4].Value = model.community_hospital_gfa;
			parameters[5].Value = model.community_hospital_fs;
			parameters[6].Value = model.community_hospital_bed_num;
			parameters[7].Value = model.community_hospital_dis_ots;
			parameters[8].Value = model.community_heal_sta_num;
			parameters[9].Value = model.community_heal_sta_fs;
			parameters[10].Value = model.community_heal_sta_gfa;
			parameters[11].Value = model.community_heal_sta_bed_num;
			parameters[12].Value = model.community_heal_sta_dis_ots;
			parameters[13].Value = model.community_clinic_num;
			parameters[14].Value = model.community_clinic_fs;
			parameters[15].Value = model.community_clinic_gfa;
			parameters[16].Value = model.community_clinic_bed_num;
			parameters[17].Value = model.community_clinic_dis_ots;
			parameters[18].Value = model.tcmunset1;
			parameters[19].Value = model.tcmunset2;
			parameters[20].Value = model.tcmunset3;
			parameters[21].Value = model.tcmunset4;
			parameters[22].Value = model.tcmunset5;
			parameters[23].Value = model.tcmunset6;
			parameters[24].Value = model.tcmunset7;
			parameters[25].Value = model.tcmunset8;
			parameters[26].Value = model.tcmunset9;
			parameters[27].Value = model.tcmunset10;
			parameters[28].Value = model.tcmunset11;
			parameters[29].Value = model.tcmunset12;
			parameters[30].Value = model.tcmunset13;
			parameters[31].Value = model.tcmunset14;
			parameters[32].Value = model.tcmunset15;
			parameters[33].Value = model.tcmunset16;
			parameters[34].Value = model.tcmunset17;
			parameters[35].Value = model.tcmunset18;
			parameters[36].Value = model.lock_tables;
			parameters[37].Value = model.check_status;
			parameters[38].Value = model.community_id;
			parameters[39].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_medical ");
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
		public TTG.Model.TTGWeb.community_medical GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_medical_inst_num,community_medical_inst_fs,community_medical_inst_gfa,community_hospital_num,community_hospital_gfa,community_hospital_fs,community_hospital_bed_num,community_hospital_dis_ots,community_heal_sta_num,community_heal_sta_fs,community_heal_sta_gfa,community_heal_sta_bed_num,community_heal_sta_dis_ots,community_clinic_num,community_clinic_fs,community_clinic_gfa,community_clinic_bed_num,community_clinic_dis_ots,statistics_date,tcmunset1,tcmunset2,tcmunset3,tcmunset4,tcmunset5,tcmunset6,tcmunset7,tcmunset8,tcmunset9,tcmunset10,tcmunset11,tcmunset12,tcmunset13,tcmunset14,tcmunset15,tcmunset16,tcmunset17,tcmunset18,lock_tables,check_status from T_community_medical ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_medical model=new TTG.Model.TTGWeb.community_medical();
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
		public TTG.Model.TTGWeb.community_medical DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_medical model=new TTG.Model.TTGWeb.community_medical();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_medical_inst_num"]!=null && row["community_medical_inst_num"].ToString()!="")
				{
					model.community_medical_inst_num=int.Parse(row["community_medical_inst_num"].ToString());
				}
				if(row["community_medical_inst_fs"]!=null && row["community_medical_inst_fs"].ToString()!="")
				{
					model.community_medical_inst_fs=decimal.Parse(row["community_medical_inst_fs"].ToString());
				}
				if(row["community_medical_inst_gfa"]!=null && row["community_medical_inst_gfa"].ToString()!="")
				{
					model.community_medical_inst_gfa=decimal.Parse(row["community_medical_inst_gfa"].ToString());
				}
				if(row["community_hospital_num"]!=null && row["community_hospital_num"].ToString()!="")
				{
					model.community_hospital_num=int.Parse(row["community_hospital_num"].ToString());
				}
				if(row["community_hospital_gfa"]!=null && row["community_hospital_gfa"].ToString()!="")
				{
					model.community_hospital_gfa=decimal.Parse(row["community_hospital_gfa"].ToString());
				}
				if(row["community_hospital_fs"]!=null && row["community_hospital_fs"].ToString()!="")
				{
					model.community_hospital_fs=decimal.Parse(row["community_hospital_fs"].ToString());
				}
				if(row["community_hospital_bed_num"]!=null && row["community_hospital_bed_num"].ToString()!="")
				{
					model.community_hospital_bed_num=int.Parse(row["community_hospital_bed_num"].ToString());
				}
				if(row["community_hospital_dis_ots"]!=null && row["community_hospital_dis_ots"].ToString()!="")
				{
					model.community_hospital_dis_ots=decimal.Parse(row["community_hospital_dis_ots"].ToString());
				}
				if(row["community_heal_sta_num"]!=null && row["community_heal_sta_num"].ToString()!="")
				{
					model.community_heal_sta_num=int.Parse(row["community_heal_sta_num"].ToString());
				}
				if(row["community_heal_sta_fs"]!=null && row["community_heal_sta_fs"].ToString()!="")
				{
					model.community_heal_sta_fs=decimal.Parse(row["community_heal_sta_fs"].ToString());
				}
				if(row["community_heal_sta_gfa"]!=null && row["community_heal_sta_gfa"].ToString()!="")
				{
					model.community_heal_sta_gfa=decimal.Parse(row["community_heal_sta_gfa"].ToString());
				}
				if(row["community_heal_sta_bed_num"]!=null && row["community_heal_sta_bed_num"].ToString()!="")
				{
					model.community_heal_sta_bed_num=int.Parse(row["community_heal_sta_bed_num"].ToString());
				}
				if(row["community_heal_sta_dis_ots"]!=null && row["community_heal_sta_dis_ots"].ToString()!="")
				{
					model.community_heal_sta_dis_ots=decimal.Parse(row["community_heal_sta_dis_ots"].ToString());
				}
				if(row["community_clinic_num"]!=null && row["community_clinic_num"].ToString()!="")
				{
					model.community_clinic_num=int.Parse(row["community_clinic_num"].ToString());
				}
				if(row["community_clinic_fs"]!=null && row["community_clinic_fs"].ToString()!="")
				{
					model.community_clinic_fs=decimal.Parse(row["community_clinic_fs"].ToString());
				}
				if(row["community_clinic_gfa"]!=null && row["community_clinic_gfa"].ToString()!="")
				{
					model.community_clinic_gfa=decimal.Parse(row["community_clinic_gfa"].ToString());
				}
				if(row["community_clinic_bed_num"]!=null && row["community_clinic_bed_num"].ToString()!="")
				{
					model.community_clinic_bed_num=int.Parse(row["community_clinic_bed_num"].ToString());
				}
				if(row["community_clinic_dis_ots"]!=null && row["community_clinic_dis_ots"].ToString()!="")
				{
					model.community_clinic_dis_ots=decimal.Parse(row["community_clinic_dis_ots"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcmunset1"]!=null)
				{
					model.tcmunset1=row["tcmunset1"].ToString();
				}
				if(row["tcmunset2"]!=null)
				{
					model.tcmunset2=row["tcmunset2"].ToString();
				}
				if(row["tcmunset3"]!=null)
				{
					model.tcmunset3=row["tcmunset3"].ToString();
				}
				if(row["tcmunset4"]!=null)
				{
					model.tcmunset4=row["tcmunset4"].ToString();
				}
				if(row["tcmunset5"]!=null)
				{
					model.tcmunset5=row["tcmunset5"].ToString();
				}
				if(row["tcmunset6"]!=null)
				{
					model.tcmunset6=row["tcmunset6"].ToString();
				}
				if(row["tcmunset7"]!=null)
				{
					model.tcmunset7=row["tcmunset7"].ToString();
				}
				if(row["tcmunset8"]!=null)
				{
					model.tcmunset8=row["tcmunset8"].ToString();
				}
				if(row["tcmunset9"]!=null)
				{
					model.tcmunset9=row["tcmunset9"].ToString();
				}
				if(row["tcmunset10"]!=null)
				{
					model.tcmunset10=row["tcmunset10"].ToString();
				}
				if(row["tcmunset11"]!=null)
				{
					model.tcmunset11=row["tcmunset11"].ToString();
				}
				if(row["tcmunset12"]!=null)
				{
					model.tcmunset12=row["tcmunset12"].ToString();
				}
				if(row["tcmunset13"]!=null)
				{
					model.tcmunset13=row["tcmunset13"].ToString();
				}
				if(row["tcmunset14"]!=null)
				{
					model.tcmunset14=row["tcmunset14"].ToString();
				}
				if(row["tcmunset15"]!=null)
				{
					model.tcmunset15=row["tcmunset15"].ToString();
				}
				if(row["tcmunset16"]!=null)
				{
					model.tcmunset16=row["tcmunset16"].ToString();
				}
				if(row["tcmunset17"]!=null)
				{
					model.tcmunset17=row["tcmunset17"].ToString();
				}
				if(row["tcmunset18"]!=null)
				{
					model.tcmunset18=row["tcmunset18"].ToString();
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
			strSql.Append("select community_id,community_medical_inst_num,community_medical_inst_fs,community_medical_inst_gfa,community_hospital_num,community_hospital_gfa,community_hospital_fs,community_hospital_bed_num,community_hospital_dis_ots,community_heal_sta_num,community_heal_sta_fs,community_heal_sta_gfa,community_heal_sta_bed_num,community_heal_sta_dis_ots,community_clinic_num,community_clinic_fs,community_clinic_gfa,community_clinic_bed_num,community_clinic_dis_ots,statistics_date,tcmunset1,tcmunset2,tcmunset3,tcmunset4,tcmunset5,tcmunset6,tcmunset7,tcmunset8,tcmunset9,tcmunset10,tcmunset11,tcmunset12,tcmunset13,tcmunset14,tcmunset15,tcmunset16,tcmunset17,tcmunset18,lock_tables,check_status ");
			strSql.Append(" FROM T_community_medical ");
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
			strSql.Append(" community_id,community_medical_inst_num,community_medical_inst_fs,community_medical_inst_gfa,community_hospital_num,community_hospital_gfa,community_hospital_fs,community_hospital_bed_num,community_hospital_dis_ots,community_heal_sta_num,community_heal_sta_fs,community_heal_sta_gfa,community_heal_sta_bed_num,community_heal_sta_dis_ots,community_clinic_num,community_clinic_fs,community_clinic_gfa,community_clinic_bed_num,community_clinic_dis_ots,statistics_date,tcmunset1,tcmunset2,tcmunset3,tcmunset4,tcmunset5,tcmunset6,tcmunset7,tcmunset8,tcmunset9,tcmunset10,tcmunset11,tcmunset12,tcmunset13,tcmunset14,tcmunset15,tcmunset16,tcmunset17,tcmunset18,lock_tables,check_status ");
			strSql.Append(" FROM T_community_medical ");
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
			strSql.Append("select count(1) FROM T_community_medical ");
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
			strSql.Append(")AS Row, T.*  from T_community_medical T ");
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
			parameters[0].Value = "T_community_medical";
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

