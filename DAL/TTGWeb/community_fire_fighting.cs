using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_fire_fighting
	/// </summary>
	public partial class community_fire_fighting
	{
		public community_fire_fighting()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_fire_fighting");
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
		public bool Add(TTG.Model.TTGWeb.community_fire_fighting model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_fire_fighting(");
			strSql.Append("community_id,community_extinguisher_num,community_good_extinguisher_rate,community_hydrant_num,community_ots_hydrant_num,community_good_ots_hydrant_rate,community_ind_hydrant_num,community_good_ind_hydrant_rate,community_ff_pipe_length,community_ff_pipe_caliber_larger_than_100mm_length,community_ff_pipe_caliber_less_than_100mm_length,source_of_ff_water_num,natural_ff_water_source_num,municipal_administration_pipe_net_ff_water_source,ff_water_pool_num,statistics_date,tcffunset1,tcffunset2,tcffunset3,tcffunset4,tcffunset5,tcffunset6,tcffunset7,tcffunset8,tcffunset9,tcffunset10,tcffunset11,tcffunset12,tcffunset13,tcffunset14,lock_tables,check_status,community_ff_not_attain_pass_length,community_ff_pass_length)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_extinguisher_num,@community_good_extinguisher_rate,@community_hydrant_num,@community_ots_hydrant_num,@community_good_ots_hydrant_rate,@community_ind_hydrant_num,@community_good_ind_hydrant_rate,@community_ff_pipe_length,@community_ff_pipe_caliber_larger_than_100mm_length,@community_ff_pipe_caliber_less_than_100mm_length,@source_of_ff_water_num,@natural_ff_water_source_num,@municipal_administration_pipe_net_ff_water_source,@ff_water_pool_num,@statistics_date,@tcffunset1,@tcffunset2,@tcffunset3,@tcffunset4,@tcffunset5,@tcffunset6,@tcffunset7,@tcffunset8,@tcffunset9,@tcffunset10,@tcffunset11,@tcffunset12,@tcffunset13,@tcffunset14,@lock_tables,@check_status,@community_ff_not_attain_pass_length,@community_ff_pass_length)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_extinguisher_num", SqlDbType.Int,4),
					new SqlParameter("@community_good_extinguisher_rate", SqlDbType.Float,8),
					new SqlParameter("@community_hydrant_num", SqlDbType.Int,4),
					new SqlParameter("@community_ots_hydrant_num", SqlDbType.Int,4),
					new SqlParameter("@community_good_ots_hydrant_rate", SqlDbType.Float,8),
					new SqlParameter("@community_ind_hydrant_num", SqlDbType.Int,4),
					new SqlParameter("@community_good_ind_hydrant_rate", SqlDbType.Float,8),
					new SqlParameter("@community_ff_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@community_ff_pipe_caliber_larger_than_100mm_length", SqlDbType.Float,8),
					new SqlParameter("@community_ff_pipe_caliber_less_than_100mm_length", SqlDbType.Float,8),
					new SqlParameter("@source_of_ff_water_num", SqlDbType.Int,4),
					new SqlParameter("@natural_ff_water_source_num", SqlDbType.Int,4),
					new SqlParameter("@municipal_administration_pipe_net_ff_water_source", SqlDbType.Int,4),
					new SqlParameter("@ff_water_pool_num", SqlDbType.Int,4),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcffunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset14", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_ff_not_attain_pass_length", SqlDbType.Float,8),
					new SqlParameter("@community_ff_pass_length", SqlDbType.Float,8)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_extinguisher_num;
			parameters[2].Value = model.community_good_extinguisher_rate;
			parameters[3].Value = model.community_hydrant_num;
			parameters[4].Value = model.community_ots_hydrant_num;
			parameters[5].Value = model.community_good_ots_hydrant_rate;
			parameters[6].Value = model.community_ind_hydrant_num;
			parameters[7].Value = model.community_good_ind_hydrant_rate;
			parameters[8].Value = model.community_ff_pipe_length;
			parameters[9].Value = model.community_ff_pipe_caliber_larger_than_100mm_length;
			parameters[10].Value = model.community_ff_pipe_caliber_less_than_100mm_length;
			parameters[11].Value = model.source_of_ff_water_num;
			parameters[12].Value = model.natural_ff_water_source_num;
			parameters[13].Value = model.municipal_administration_pipe_net_ff_water_source;
			parameters[14].Value = model.ff_water_pool_num;
			parameters[15].Value = model.statistics_date;
			parameters[16].Value = model.tcffunset1;
			parameters[17].Value = model.tcffunset2;
			parameters[18].Value = model.tcffunset3;
			parameters[19].Value = model.tcffunset4;
			parameters[20].Value = model.tcffunset5;
			parameters[21].Value = model.tcffunset6;
			parameters[22].Value = model.tcffunset7;
			parameters[23].Value = model.tcffunset8;
			parameters[24].Value = model.tcffunset9;
			parameters[25].Value = model.tcffunset10;
			parameters[26].Value = model.tcffunset11;
			parameters[27].Value = model.tcffunset12;
			parameters[28].Value = model.tcffunset13;
			parameters[29].Value = model.tcffunset14;
			parameters[30].Value = model.lock_tables;
			parameters[31].Value = model.check_status;
			parameters[32].Value = model.community_ff_not_attain_pass_length;
			parameters[33].Value = model.community_ff_pass_length;

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
		public bool Update(TTG.Model.TTGWeb.community_fire_fighting model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_fire_fighting set ");
			strSql.Append("community_extinguisher_num=@community_extinguisher_num,");
			strSql.Append("community_good_extinguisher_rate=@community_good_extinguisher_rate,");
			strSql.Append("community_hydrant_num=@community_hydrant_num,");
			strSql.Append("community_ots_hydrant_num=@community_ots_hydrant_num,");
			strSql.Append("community_good_ots_hydrant_rate=@community_good_ots_hydrant_rate,");
			strSql.Append("community_ind_hydrant_num=@community_ind_hydrant_num,");
			strSql.Append("community_good_ind_hydrant_rate=@community_good_ind_hydrant_rate,");
			strSql.Append("community_ff_pipe_length=@community_ff_pipe_length,");
			strSql.Append("community_ff_pipe_caliber_larger_than_100mm_length=@community_ff_pipe_caliber_larger_than_100mm_length,");
			strSql.Append("community_ff_pipe_caliber_less_than_100mm_length=@community_ff_pipe_caliber_less_than_100mm_length,");
			strSql.Append("source_of_ff_water_num=@source_of_ff_water_num,");
			strSql.Append("natural_ff_water_source_num=@natural_ff_water_source_num,");
			strSql.Append("municipal_administration_pipe_net_ff_water_source=@municipal_administration_pipe_net_ff_water_source,");
			strSql.Append("ff_water_pool_num=@ff_water_pool_num,");
			strSql.Append("tcffunset1=@tcffunset1,");
			strSql.Append("tcffunset2=@tcffunset2,");
			strSql.Append("tcffunset3=@tcffunset3,");
			strSql.Append("tcffunset4=@tcffunset4,");
			strSql.Append("tcffunset5=@tcffunset5,");
			strSql.Append("tcffunset6=@tcffunset6,");
			strSql.Append("tcffunset7=@tcffunset7,");
			strSql.Append("tcffunset8=@tcffunset8,");
			strSql.Append("tcffunset9=@tcffunset9,");
			strSql.Append("tcffunset10=@tcffunset10,");
			strSql.Append("tcffunset11=@tcffunset11,");
			strSql.Append("tcffunset12=@tcffunset12,");
			strSql.Append("tcffunset13=@tcffunset13,");
			strSql.Append("tcffunset14=@tcffunset14,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("community_ff_not_attain_pass_length=@community_ff_not_attain_pass_length,");
			strSql.Append("community_ff_pass_length=@community_ff_pass_length");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_extinguisher_num", SqlDbType.Int,4),
					new SqlParameter("@community_good_extinguisher_rate", SqlDbType.Float,8),
					new SqlParameter("@community_hydrant_num", SqlDbType.Int,4),
					new SqlParameter("@community_ots_hydrant_num", SqlDbType.Int,4),
					new SqlParameter("@community_good_ots_hydrant_rate", SqlDbType.Float,8),
					new SqlParameter("@community_ind_hydrant_num", SqlDbType.Int,4),
					new SqlParameter("@community_good_ind_hydrant_rate", SqlDbType.Float,8),
					new SqlParameter("@community_ff_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@community_ff_pipe_caliber_larger_than_100mm_length", SqlDbType.Float,8),
					new SqlParameter("@community_ff_pipe_caliber_less_than_100mm_length", SqlDbType.Float,8),
					new SqlParameter("@source_of_ff_water_num", SqlDbType.Int,4),
					new SqlParameter("@natural_ff_water_source_num", SqlDbType.Int,4),
					new SqlParameter("@municipal_administration_pipe_net_ff_water_source", SqlDbType.Int,4),
					new SqlParameter("@ff_water_pool_num", SqlDbType.Int,4),
					new SqlParameter("@tcffunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tcffunset14", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_ff_not_attain_pass_length", SqlDbType.Float,8),
					new SqlParameter("@community_ff_pass_length", SqlDbType.Float,8),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_extinguisher_num;
			parameters[1].Value = model.community_good_extinguisher_rate;
			parameters[2].Value = model.community_hydrant_num;
			parameters[3].Value = model.community_ots_hydrant_num;
			parameters[4].Value = model.community_good_ots_hydrant_rate;
			parameters[5].Value = model.community_ind_hydrant_num;
			parameters[6].Value = model.community_good_ind_hydrant_rate;
			parameters[7].Value = model.community_ff_pipe_length;
			parameters[8].Value = model.community_ff_pipe_caliber_larger_than_100mm_length;
			parameters[9].Value = model.community_ff_pipe_caliber_less_than_100mm_length;
			parameters[10].Value = model.source_of_ff_water_num;
			parameters[11].Value = model.natural_ff_water_source_num;
			parameters[12].Value = model.municipal_administration_pipe_net_ff_water_source;
			parameters[13].Value = model.ff_water_pool_num;
			parameters[14].Value = model.tcffunset1;
			parameters[15].Value = model.tcffunset2;
			parameters[16].Value = model.tcffunset3;
			parameters[17].Value = model.tcffunset4;
			parameters[18].Value = model.tcffunset5;
			parameters[19].Value = model.tcffunset6;
			parameters[20].Value = model.tcffunset7;
			parameters[21].Value = model.tcffunset8;
			parameters[22].Value = model.tcffunset9;
			parameters[23].Value = model.tcffunset10;
			parameters[24].Value = model.tcffunset11;
			parameters[25].Value = model.tcffunset12;
			parameters[26].Value = model.tcffunset13;
			parameters[27].Value = model.tcffunset14;
			parameters[28].Value = model.lock_tables;
			parameters[29].Value = model.check_status;
			parameters[30].Value = model.community_ff_not_attain_pass_length;
			parameters[31].Value = model.community_ff_pass_length;
			parameters[32].Value = model.community_id;
			parameters[33].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_fire_fighting ");
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
		public TTG.Model.TTGWeb.community_fire_fighting GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_extinguisher_num,community_good_extinguisher_rate,community_hydrant_num,community_ots_hydrant_num,community_good_ots_hydrant_rate,community_ind_hydrant_num,community_good_ind_hydrant_rate,community_ff_pipe_length,community_ff_pipe_caliber_larger_than_100mm_length,community_ff_pipe_caliber_less_than_100mm_length,source_of_ff_water_num,natural_ff_water_source_num,municipal_administration_pipe_net_ff_water_source,ff_water_pool_num,statistics_date,tcffunset1,tcffunset2,tcffunset3,tcffunset4,tcffunset5,tcffunset6,tcffunset7,tcffunset8,tcffunset9,tcffunset10,tcffunset11,tcffunset12,tcffunset13,tcffunset14,lock_tables,check_status,community_ff_not_attain_pass_length,community_ff_pass_length from T_community_fire_fighting ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_fire_fighting model=new TTG.Model.TTGWeb.community_fire_fighting();
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
		public TTG.Model.TTGWeb.community_fire_fighting DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_fire_fighting model=new TTG.Model.TTGWeb.community_fire_fighting();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_extinguisher_num"]!=null && row["community_extinguisher_num"].ToString()!="")
				{
					model.community_extinguisher_num=int.Parse(row["community_extinguisher_num"].ToString());
				}
				if(row["community_good_extinguisher_rate"]!=null && row["community_good_extinguisher_rate"].ToString()!="")
				{
					model.community_good_extinguisher_rate=decimal.Parse(row["community_good_extinguisher_rate"].ToString());
				}
				if(row["community_hydrant_num"]!=null && row["community_hydrant_num"].ToString()!="")
				{
					model.community_hydrant_num=int.Parse(row["community_hydrant_num"].ToString());
				}
				if(row["community_ots_hydrant_num"]!=null && row["community_ots_hydrant_num"].ToString()!="")
				{
					model.community_ots_hydrant_num=int.Parse(row["community_ots_hydrant_num"].ToString());
				}
				if(row["community_good_ots_hydrant_rate"]!=null && row["community_good_ots_hydrant_rate"].ToString()!="")
				{
					model.community_good_ots_hydrant_rate=decimal.Parse(row["community_good_ots_hydrant_rate"].ToString());
				}
				if(row["community_ind_hydrant_num"]!=null && row["community_ind_hydrant_num"].ToString()!="")
				{
					model.community_ind_hydrant_num=int.Parse(row["community_ind_hydrant_num"].ToString());
				}
				if(row["community_good_ind_hydrant_rate"]!=null && row["community_good_ind_hydrant_rate"].ToString()!="")
				{
					model.community_good_ind_hydrant_rate=decimal.Parse(row["community_good_ind_hydrant_rate"].ToString());
				}
				if(row["community_ff_pipe_length"]!=null && row["community_ff_pipe_length"].ToString()!="")
				{
					model.community_ff_pipe_length=decimal.Parse(row["community_ff_pipe_length"].ToString());
				}
				if(row["community_ff_pipe_caliber_larger_than_100mm_length"]!=null && row["community_ff_pipe_caliber_larger_than_100mm_length"].ToString()!="")
				{
					model.community_ff_pipe_caliber_larger_than_100mm_length=decimal.Parse(row["community_ff_pipe_caliber_larger_than_100mm_length"].ToString());
				}
				if(row["community_ff_pipe_caliber_less_than_100mm_length"]!=null && row["community_ff_pipe_caliber_less_than_100mm_length"].ToString()!="")
				{
					model.community_ff_pipe_caliber_less_than_100mm_length=decimal.Parse(row["community_ff_pipe_caliber_less_than_100mm_length"].ToString());
				}
				if(row["source_of_ff_water_num"]!=null && row["source_of_ff_water_num"].ToString()!="")
				{
					model.source_of_ff_water_num=int.Parse(row["source_of_ff_water_num"].ToString());
				}
				if(row["natural_ff_water_source_num"]!=null && row["natural_ff_water_source_num"].ToString()!="")
				{
					model.natural_ff_water_source_num=int.Parse(row["natural_ff_water_source_num"].ToString());
				}
				if(row["municipal_administration_pipe_net_ff_water_source"]!=null && row["municipal_administration_pipe_net_ff_water_source"].ToString()!="")
				{
					model.municipal_administration_pipe_net_ff_water_source=int.Parse(row["municipal_administration_pipe_net_ff_water_source"].ToString());
				}
				if(row["ff_water_pool_num"]!=null && row["ff_water_pool_num"].ToString()!="")
				{
					model.ff_water_pool_num=int.Parse(row["ff_water_pool_num"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcffunset1"]!=null)
				{
					model.tcffunset1=row["tcffunset1"].ToString();
				}
				if(row["tcffunset2"]!=null)
				{
					model.tcffunset2=row["tcffunset2"].ToString();
				}
				if(row["tcffunset3"]!=null)
				{
					model.tcffunset3=row["tcffunset3"].ToString();
				}
				if(row["tcffunset4"]!=null)
				{
					model.tcffunset4=row["tcffunset4"].ToString();
				}
				if(row["tcffunset5"]!=null)
				{
					model.tcffunset5=row["tcffunset5"].ToString();
				}
				if(row["tcffunset6"]!=null)
				{
					model.tcffunset6=row["tcffunset6"].ToString();
				}
				if(row["tcffunset7"]!=null)
				{
					model.tcffunset7=row["tcffunset7"].ToString();
				}
				if(row["tcffunset8"]!=null)
				{
					model.tcffunset8=row["tcffunset8"].ToString();
				}
				if(row["tcffunset9"]!=null)
				{
					model.tcffunset9=row["tcffunset9"].ToString();
				}
				if(row["tcffunset10"]!=null)
				{
					model.tcffunset10=row["tcffunset10"].ToString();
				}
				if(row["tcffunset11"]!=null)
				{
					model.tcffunset11=row["tcffunset11"].ToString();
				}
				if(row["tcffunset12"]!=null)
				{
					model.tcffunset12=row["tcffunset12"].ToString();
				}
				if(row["tcffunset13"]!=null)
				{
					model.tcffunset13=row["tcffunset13"].ToString();
				}
				if(row["tcffunset14"]!=null)
				{
					model.tcffunset14=row["tcffunset14"].ToString();
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["community_ff_not_attain_pass_length"]!=null && row["community_ff_not_attain_pass_length"].ToString()!="")
				{
					model.community_ff_not_attain_pass_length=decimal.Parse(row["community_ff_not_attain_pass_length"].ToString());
				}
				if(row["community_ff_pass_length"]!=null && row["community_ff_pass_length"].ToString()!="")
				{
					model.community_ff_pass_length=decimal.Parse(row["community_ff_pass_length"].ToString());
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
			strSql.Append("select community_id,community_extinguisher_num,community_good_extinguisher_rate,community_hydrant_num,community_ots_hydrant_num,community_good_ots_hydrant_rate,community_ind_hydrant_num,community_good_ind_hydrant_rate,community_ff_pipe_length,community_ff_pipe_caliber_larger_than_100mm_length,community_ff_pipe_caliber_less_than_100mm_length,source_of_ff_water_num,natural_ff_water_source_num,municipal_administration_pipe_net_ff_water_source,ff_water_pool_num,statistics_date,tcffunset1,tcffunset2,tcffunset3,tcffunset4,tcffunset5,tcffunset6,tcffunset7,tcffunset8,tcffunset9,tcffunset10,tcffunset11,tcffunset12,tcffunset13,tcffunset14,lock_tables,check_status,community_ff_not_attain_pass_length,community_ff_pass_length ");
			strSql.Append(" FROM T_community_fire_fighting ");
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
			strSql.Append(" community_id,community_extinguisher_num,community_good_extinguisher_rate,community_hydrant_num,community_ots_hydrant_num,community_good_ots_hydrant_rate,community_ind_hydrant_num,community_good_ind_hydrant_rate,community_ff_pipe_length,community_ff_pipe_caliber_larger_than_100mm_length,community_ff_pipe_caliber_less_than_100mm_length,source_of_ff_water_num,natural_ff_water_source_num,municipal_administration_pipe_net_ff_water_source,ff_water_pool_num,statistics_date,tcffunset1,tcffunset2,tcffunset3,tcffunset4,tcffunset5,tcffunset6,tcffunset7,tcffunset8,tcffunset9,tcffunset10,tcffunset11,tcffunset12,tcffunset13,tcffunset14,lock_tables,check_status,community_ff_not_attain_pass_length,community_ff_pass_length ");
			strSql.Append(" FROM T_community_fire_fighting ");
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
			strSql.Append("select count(1) FROM T_community_fire_fighting ");
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
			strSql.Append(")AS Row, T.*  from T_community_fire_fighting T ");
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
			parameters[0].Value = "T_community_fire_fighting";
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

