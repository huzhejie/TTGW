using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_education
	/// </summary>
	public partial class community_education
	{
		public community_education()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_education");
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
		public bool Add(TTG.Model.TTGWeb.community_education model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_education(");
			strSql.Append("community_id,community_edu_inst_num,community_edu_fs,community_edu_gfa,community_kdg_num,community_pri_kdg_num,community_kdg_fs,community_kdg_gfa,community_kdg_stu_num,community_kdg_class_num,community_kdg_actv_room_area,community_kdg_otd_actv_spa_area,community_kdg_greenland_area,community_kdg_dist_ots,community_prim_school_num,community_prim_school_gfa,community_prim_school_fs,community_prim_school_stu_num,community_prim_school_class_num,community_prim_school_plg_area,community_prim_school_dist_ots,community_mid_school_num,community_mid_school_gfa,community_mid_school_fs,community_mid_school_stu_num,community_mid_school_class_num,community_mid_school_plg_area,community_mid_school_dist_ots,statistics_date,tceunset1,tceunset2,tceunset3,tceunset4,tceunset5,tceunset6,tceunset7,tceunset8,tceunset9,tceunset10,tceunset11,tceunset12,tceunset13,tceunset14,tceunset15,tceunset16,tceunset17,tceunset18,tceunset19,tceunset20,tceunset21,tceunset22,tceunset23,tceunset24,tceunset25,tceunset26,tceunset27,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_edu_inst_num,@community_edu_fs,@community_edu_gfa,@community_kdg_num,@community_pri_kdg_num,@community_kdg_fs,@community_kdg_gfa,@community_kdg_stu_num,@community_kdg_class_num,@community_kdg_actv_room_area,@community_kdg_otd_actv_spa_area,@community_kdg_greenland_area,@community_kdg_dist_ots,@community_prim_school_num,@community_prim_school_gfa,@community_prim_school_fs,@community_prim_school_stu_num,@community_prim_school_class_num,@community_prim_school_plg_area,@community_prim_school_dist_ots,@community_mid_school_num,@community_mid_school_gfa,@community_mid_school_fs,@community_mid_school_stu_num,@community_mid_school_class_num,@community_mid_school_plg_area,@community_mid_school_dist_ots,@statistics_date,@tceunset1,@tceunset2,@tceunset3,@tceunset4,@tceunset5,@tceunset6,@tceunset7,@tceunset8,@tceunset9,@tceunset10,@tceunset11,@tceunset12,@tceunset13,@tceunset14,@tceunset15,@tceunset16,@tceunset17,@tceunset18,@tceunset19,@tceunset20,@tceunset21,@tceunset22,@tceunset23,@tceunset24,@tceunset25,@tceunset26,@tceunset27,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_edu_inst_num", SqlDbType.Int,4),
					new SqlParameter("@community_edu_fs", SqlDbType.Float,8),
					new SqlParameter("@community_edu_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_kdg_num", SqlDbType.Int,4),
					new SqlParameter("@community_pri_kdg_num", SqlDbType.Int,4),
					new SqlParameter("@community_kdg_fs", SqlDbType.Float,8),
					new SqlParameter("@community_kdg_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_kdg_stu_num", SqlDbType.Int,4),
					new SqlParameter("@community_kdg_class_num", SqlDbType.Int,4),
					new SqlParameter("@community_kdg_actv_room_area", SqlDbType.Float,8),
					new SqlParameter("@community_kdg_otd_actv_spa_area", SqlDbType.Float,8),
					new SqlParameter("@community_kdg_greenland_area", SqlDbType.Float,8),
					new SqlParameter("@community_kdg_dist_ots", SqlDbType.Float,8),
					new SqlParameter("@community_prim_school_num", SqlDbType.Int,4),
					new SqlParameter("@community_prim_school_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_prim_school_fs", SqlDbType.Float,8),
					new SqlParameter("@community_prim_school_stu_num", SqlDbType.Int,4),
					new SqlParameter("@community_prim_school_class_num", SqlDbType.Int,4),
					new SqlParameter("@community_prim_school_plg_area", SqlDbType.Float,8),
					new SqlParameter("@community_prim_school_dist_ots", SqlDbType.Float,8),
					new SqlParameter("@community_mid_school_num", SqlDbType.Int,4),
					new SqlParameter("@community_mid_school_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_mid_school_fs", SqlDbType.Float,8),
					new SqlParameter("@community_mid_school_stu_num", SqlDbType.Int,4),
					new SqlParameter("@community_mid_school_class_num", SqlDbType.Int,4),
					new SqlParameter("@community_mid_school_plg_area", SqlDbType.Float,8),
					new SqlParameter("@community_mid_school_dist_ots", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tceunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset21", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset22", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset23", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset24", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset25", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset26", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset27", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_edu_inst_num;
			parameters[2].Value = model.community_edu_fs;
			parameters[3].Value = model.community_edu_gfa;
			parameters[4].Value = model.community_kdg_num;
			parameters[5].Value = model.community_pri_kdg_num;
			parameters[6].Value = model.community_kdg_fs;
			parameters[7].Value = model.community_kdg_gfa;
			parameters[8].Value = model.community_kdg_stu_num;
			parameters[9].Value = model.community_kdg_class_num;
			parameters[10].Value = model.community_kdg_actv_room_area;
			parameters[11].Value = model.community_kdg_otd_actv_spa_area;
			parameters[12].Value = model.community_kdg_greenland_area;
			parameters[13].Value = model.community_kdg_dist_ots;
			parameters[14].Value = model.community_prim_school_num;
			parameters[15].Value = model.community_prim_school_gfa;
			parameters[16].Value = model.community_prim_school_fs;
			parameters[17].Value = model.community_prim_school_stu_num;
			parameters[18].Value = model.community_prim_school_class_num;
			parameters[19].Value = model.community_prim_school_plg_area;
			parameters[20].Value = model.community_prim_school_dist_ots;
			parameters[21].Value = model.community_mid_school_num;
			parameters[22].Value = model.community_mid_school_gfa;
			parameters[23].Value = model.community_mid_school_fs;
			parameters[24].Value = model.community_mid_school_stu_num;
			parameters[25].Value = model.community_mid_school_class_num;
			parameters[26].Value = model.community_mid_school_plg_area;
			parameters[27].Value = model.community_mid_school_dist_ots;
			parameters[28].Value = model.statistics_date;
			parameters[29].Value = model.tceunset1;
			parameters[30].Value = model.tceunset2;
			parameters[31].Value = model.tceunset3;
			parameters[32].Value = model.tceunset4;
			parameters[33].Value = model.tceunset5;
			parameters[34].Value = model.tceunset6;
			parameters[35].Value = model.tceunset7;
			parameters[36].Value = model.tceunset8;
			parameters[37].Value = model.tceunset9;
			parameters[38].Value = model.tceunset10;
			parameters[39].Value = model.tceunset11;
			parameters[40].Value = model.tceunset12;
			parameters[41].Value = model.tceunset13;
			parameters[42].Value = model.tceunset14;
			parameters[43].Value = model.tceunset15;
			parameters[44].Value = model.tceunset16;
			parameters[45].Value = model.tceunset17;
			parameters[46].Value = model.tceunset18;
			parameters[47].Value = model.tceunset19;
			parameters[48].Value = model.tceunset20;
			parameters[49].Value = model.tceunset21;
			parameters[50].Value = model.tceunset22;
			parameters[51].Value = model.tceunset23;
			parameters[52].Value = model.tceunset24;
			parameters[53].Value = model.tceunset25;
			parameters[54].Value = model.tceunset26;
			parameters[55].Value = model.tceunset27;
			parameters[56].Value = model.lock_tables;
			parameters[57].Value = model.check_status;

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
		public bool Update(TTG.Model.TTGWeb.community_education model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_education set ");
			strSql.Append("community_edu_inst_num=@community_edu_inst_num,");
			strSql.Append("community_edu_fs=@community_edu_fs,");
			strSql.Append("community_edu_gfa=@community_edu_gfa,");
			strSql.Append("community_kdg_num=@community_kdg_num,");
			strSql.Append("community_pri_kdg_num=@community_pri_kdg_num,");
			strSql.Append("community_kdg_fs=@community_kdg_fs,");
			strSql.Append("community_kdg_gfa=@community_kdg_gfa,");
			strSql.Append("community_kdg_stu_num=@community_kdg_stu_num,");
			strSql.Append("community_kdg_class_num=@community_kdg_class_num,");
			strSql.Append("community_kdg_actv_room_area=@community_kdg_actv_room_area,");
			strSql.Append("community_kdg_otd_actv_spa_area=@community_kdg_otd_actv_spa_area,");
			strSql.Append("community_kdg_greenland_area=@community_kdg_greenland_area,");
			strSql.Append("community_kdg_dist_ots=@community_kdg_dist_ots,");
			strSql.Append("community_prim_school_num=@community_prim_school_num,");
			strSql.Append("community_prim_school_gfa=@community_prim_school_gfa,");
			strSql.Append("community_prim_school_fs=@community_prim_school_fs,");
			strSql.Append("community_prim_school_stu_num=@community_prim_school_stu_num,");
			strSql.Append("community_prim_school_class_num=@community_prim_school_class_num,");
			strSql.Append("community_prim_school_plg_area=@community_prim_school_plg_area,");
			strSql.Append("community_prim_school_dist_ots=@community_prim_school_dist_ots,");
			strSql.Append("community_mid_school_num=@community_mid_school_num,");
			strSql.Append("community_mid_school_gfa=@community_mid_school_gfa,");
			strSql.Append("community_mid_school_fs=@community_mid_school_fs,");
			strSql.Append("community_mid_school_stu_num=@community_mid_school_stu_num,");
			strSql.Append("community_mid_school_class_num=@community_mid_school_class_num,");
			strSql.Append("community_mid_school_plg_area=@community_mid_school_plg_area,");
			strSql.Append("community_mid_school_dist_ots=@community_mid_school_dist_ots,");
			strSql.Append("tceunset1=@tceunset1,");
			strSql.Append("tceunset2=@tceunset2,");
			strSql.Append("tceunset3=@tceunset3,");
			strSql.Append("tceunset4=@tceunset4,");
			strSql.Append("tceunset5=@tceunset5,");
			strSql.Append("tceunset6=@tceunset6,");
			strSql.Append("tceunset7=@tceunset7,");
			strSql.Append("tceunset8=@tceunset8,");
			strSql.Append("tceunset9=@tceunset9,");
			strSql.Append("tceunset10=@tceunset10,");
			strSql.Append("tceunset11=@tceunset11,");
			strSql.Append("tceunset12=@tceunset12,");
			strSql.Append("tceunset13=@tceunset13,");
			strSql.Append("tceunset14=@tceunset14,");
			strSql.Append("tceunset15=@tceunset15,");
			strSql.Append("tceunset16=@tceunset16,");
			strSql.Append("tceunset17=@tceunset17,");
			strSql.Append("tceunset18=@tceunset18,");
			strSql.Append("tceunset19=@tceunset19,");
			strSql.Append("tceunset20=@tceunset20,");
			strSql.Append("tceunset21=@tceunset21,");
			strSql.Append("tceunset22=@tceunset22,");
			strSql.Append("tceunset23=@tceunset23,");
			strSql.Append("tceunset24=@tceunset24,");
			strSql.Append("tceunset25=@tceunset25,");
			strSql.Append("tceunset26=@tceunset26,");
			strSql.Append("tceunset27=@tceunset27,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_edu_inst_num", SqlDbType.Int,4),
					new SqlParameter("@community_edu_fs", SqlDbType.Float,8),
					new SqlParameter("@community_edu_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_kdg_num", SqlDbType.Int,4),
					new SqlParameter("@community_pri_kdg_num", SqlDbType.Int,4),
					new SqlParameter("@community_kdg_fs", SqlDbType.Float,8),
					new SqlParameter("@community_kdg_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_kdg_stu_num", SqlDbType.Int,4),
					new SqlParameter("@community_kdg_class_num", SqlDbType.Int,4),
					new SqlParameter("@community_kdg_actv_room_area", SqlDbType.Float,8),
					new SqlParameter("@community_kdg_otd_actv_spa_area", SqlDbType.Float,8),
					new SqlParameter("@community_kdg_greenland_area", SqlDbType.Float,8),
					new SqlParameter("@community_kdg_dist_ots", SqlDbType.Float,8),
					new SqlParameter("@community_prim_school_num", SqlDbType.Int,4),
					new SqlParameter("@community_prim_school_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_prim_school_fs", SqlDbType.Float,8),
					new SqlParameter("@community_prim_school_stu_num", SqlDbType.Int,4),
					new SqlParameter("@community_prim_school_class_num", SqlDbType.Int,4),
					new SqlParameter("@community_prim_school_plg_area", SqlDbType.Float,8),
					new SqlParameter("@community_prim_school_dist_ots", SqlDbType.Float,8),
					new SqlParameter("@community_mid_school_num", SqlDbType.Int,4),
					new SqlParameter("@community_mid_school_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_mid_school_fs", SqlDbType.Float,8),
					new SqlParameter("@community_mid_school_stu_num", SqlDbType.Int,4),
					new SqlParameter("@community_mid_school_class_num", SqlDbType.Int,4),
					new SqlParameter("@community_mid_school_plg_area", SqlDbType.Float,8),
					new SqlParameter("@community_mid_school_dist_ots", SqlDbType.Float,8),
					new SqlParameter("@tceunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset21", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset22", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset23", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset24", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset25", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset26", SqlDbType.VarChar,50),
					new SqlParameter("@tceunset27", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_edu_inst_num;
			parameters[1].Value = model.community_edu_fs;
			parameters[2].Value = model.community_edu_gfa;
			parameters[3].Value = model.community_kdg_num;
			parameters[4].Value = model.community_pri_kdg_num;
			parameters[5].Value = model.community_kdg_fs;
			parameters[6].Value = model.community_kdg_gfa;
			parameters[7].Value = model.community_kdg_stu_num;
			parameters[8].Value = model.community_kdg_class_num;
			parameters[9].Value = model.community_kdg_actv_room_area;
			parameters[10].Value = model.community_kdg_otd_actv_spa_area;
			parameters[11].Value = model.community_kdg_greenland_area;
			parameters[12].Value = model.community_kdg_dist_ots;
			parameters[13].Value = model.community_prim_school_num;
			parameters[14].Value = model.community_prim_school_gfa;
			parameters[15].Value = model.community_prim_school_fs;
			parameters[16].Value = model.community_prim_school_stu_num;
			parameters[17].Value = model.community_prim_school_class_num;
			parameters[18].Value = model.community_prim_school_plg_area;
			parameters[19].Value = model.community_prim_school_dist_ots;
			parameters[20].Value = model.community_mid_school_num;
			parameters[21].Value = model.community_mid_school_gfa;
			parameters[22].Value = model.community_mid_school_fs;
			parameters[23].Value = model.community_mid_school_stu_num;
			parameters[24].Value = model.community_mid_school_class_num;
			parameters[25].Value = model.community_mid_school_plg_area;
			parameters[26].Value = model.community_mid_school_dist_ots;
			parameters[27].Value = model.tceunset1;
			parameters[28].Value = model.tceunset2;
			parameters[29].Value = model.tceunset3;
			parameters[30].Value = model.tceunset4;
			parameters[31].Value = model.tceunset5;
			parameters[32].Value = model.tceunset6;
			parameters[33].Value = model.tceunset7;
			parameters[34].Value = model.tceunset8;
			parameters[35].Value = model.tceunset9;
			parameters[36].Value = model.tceunset10;
			parameters[37].Value = model.tceunset11;
			parameters[38].Value = model.tceunset12;
			parameters[39].Value = model.tceunset13;
			parameters[40].Value = model.tceunset14;
			parameters[41].Value = model.tceunset15;
			parameters[42].Value = model.tceunset16;
			parameters[43].Value = model.tceunset17;
			parameters[44].Value = model.tceunset18;
			parameters[45].Value = model.tceunset19;
			parameters[46].Value = model.tceunset20;
			parameters[47].Value = model.tceunset21;
			parameters[48].Value = model.tceunset22;
			parameters[49].Value = model.tceunset23;
			parameters[50].Value = model.tceunset24;
			parameters[51].Value = model.tceunset25;
			parameters[52].Value = model.tceunset26;
			parameters[53].Value = model.tceunset27;
			parameters[54].Value = model.lock_tables;
			parameters[55].Value = model.check_status;
			parameters[56].Value = model.community_id;
			parameters[57].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_education ");
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
		public TTG.Model.TTGWeb.community_education GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_edu_inst_num,community_edu_fs,community_edu_gfa,community_kdg_num,community_pri_kdg_num,community_kdg_fs,community_kdg_gfa,community_kdg_stu_num,community_kdg_class_num,community_kdg_actv_room_area,community_kdg_otd_actv_spa_area,community_kdg_greenland_area,community_kdg_dist_ots,community_prim_school_num,community_prim_school_gfa,community_prim_school_fs,community_prim_school_stu_num,community_prim_school_class_num,community_prim_school_plg_area,community_prim_school_dist_ots,community_mid_school_num,community_mid_school_gfa,community_mid_school_fs,community_mid_school_stu_num,community_mid_school_class_num,community_mid_school_plg_area,community_mid_school_dist_ots,statistics_date,tceunset1,tceunset2,tceunset3,tceunset4,tceunset5,tceunset6,tceunset7,tceunset8,tceunset9,tceunset10,tceunset11,tceunset12,tceunset13,tceunset14,tceunset15,tceunset16,tceunset17,tceunset18,tceunset19,tceunset20,tceunset21,tceunset22,tceunset23,tceunset24,tceunset25,tceunset26,tceunset27,lock_tables,check_status from T_community_education ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_education model=new TTG.Model.TTGWeb.community_education();
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
		public TTG.Model.TTGWeb.community_education DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_education model=new TTG.Model.TTGWeb.community_education();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_edu_inst_num"]!=null && row["community_edu_inst_num"].ToString()!="")
				{
					model.community_edu_inst_num=int.Parse(row["community_edu_inst_num"].ToString());
				}
				if(row["community_edu_fs"]!=null && row["community_edu_fs"].ToString()!="")
				{
					model.community_edu_fs=decimal.Parse(row["community_edu_fs"].ToString());
				}
				if(row["community_edu_gfa"]!=null && row["community_edu_gfa"].ToString()!="")
				{
					model.community_edu_gfa=decimal.Parse(row["community_edu_gfa"].ToString());
				}
				if(row["community_kdg_num"]!=null && row["community_kdg_num"].ToString()!="")
				{
					model.community_kdg_num=int.Parse(row["community_kdg_num"].ToString());
				}
				if(row["community_pri_kdg_num"]!=null && row["community_pri_kdg_num"].ToString()!="")
				{
					model.community_pri_kdg_num=int.Parse(row["community_pri_kdg_num"].ToString());
				}
				if(row["community_kdg_fs"]!=null && row["community_kdg_fs"].ToString()!="")
				{
					model.community_kdg_fs=decimal.Parse(row["community_kdg_fs"].ToString());
				}
				if(row["community_kdg_gfa"]!=null && row["community_kdg_gfa"].ToString()!="")
				{
					model.community_kdg_gfa=decimal.Parse(row["community_kdg_gfa"].ToString());
				}
				if(row["community_kdg_stu_num"]!=null && row["community_kdg_stu_num"].ToString()!="")
				{
					model.community_kdg_stu_num=int.Parse(row["community_kdg_stu_num"].ToString());
				}
				if(row["community_kdg_class_num"]!=null && row["community_kdg_class_num"].ToString()!="")
				{
					model.community_kdg_class_num=int.Parse(row["community_kdg_class_num"].ToString());
				}
				if(row["community_kdg_actv_room_area"]!=null && row["community_kdg_actv_room_area"].ToString()!="")
				{
					model.community_kdg_actv_room_area=decimal.Parse(row["community_kdg_actv_room_area"].ToString());
				}
				if(row["community_kdg_otd_actv_spa_area"]!=null && row["community_kdg_otd_actv_spa_area"].ToString()!="")
				{
					model.community_kdg_otd_actv_spa_area=decimal.Parse(row["community_kdg_otd_actv_spa_area"].ToString());
				}
				if(row["community_kdg_greenland_area"]!=null && row["community_kdg_greenland_area"].ToString()!="")
				{
					model.community_kdg_greenland_area=decimal.Parse(row["community_kdg_greenland_area"].ToString());
				}
				if(row["community_kdg_dist_ots"]!=null && row["community_kdg_dist_ots"].ToString()!="")
				{
					model.community_kdg_dist_ots=decimal.Parse(row["community_kdg_dist_ots"].ToString());
				}
				if(row["community_prim_school_num"]!=null && row["community_prim_school_num"].ToString()!="")
				{
					model.community_prim_school_num=int.Parse(row["community_prim_school_num"].ToString());
				}
				if(row["community_prim_school_gfa"]!=null && row["community_prim_school_gfa"].ToString()!="")
				{
					model.community_prim_school_gfa=decimal.Parse(row["community_prim_school_gfa"].ToString());
				}
				if(row["community_prim_school_fs"]!=null && row["community_prim_school_fs"].ToString()!="")
				{
					model.community_prim_school_fs=decimal.Parse(row["community_prim_school_fs"].ToString());
				}
				if(row["community_prim_school_stu_num"]!=null && row["community_prim_school_stu_num"].ToString()!="")
				{
					model.community_prim_school_stu_num=int.Parse(row["community_prim_school_stu_num"].ToString());
				}
				if(row["community_prim_school_class_num"]!=null && row["community_prim_school_class_num"].ToString()!="")
				{
					model.community_prim_school_class_num=int.Parse(row["community_prim_school_class_num"].ToString());
				}
				if(row["community_prim_school_plg_area"]!=null && row["community_prim_school_plg_area"].ToString()!="")
				{
					model.community_prim_school_plg_area=decimal.Parse(row["community_prim_school_plg_area"].ToString());
				}
				if(row["community_prim_school_dist_ots"]!=null && row["community_prim_school_dist_ots"].ToString()!="")
				{
					model.community_prim_school_dist_ots=decimal.Parse(row["community_prim_school_dist_ots"].ToString());
				}
				if(row["community_mid_school_num"]!=null && row["community_mid_school_num"].ToString()!="")
				{
					model.community_mid_school_num=int.Parse(row["community_mid_school_num"].ToString());
				}
				if(row["community_mid_school_gfa"]!=null && row["community_mid_school_gfa"].ToString()!="")
				{
					model.community_mid_school_gfa=decimal.Parse(row["community_mid_school_gfa"].ToString());
				}
				if(row["community_mid_school_fs"]!=null && row["community_mid_school_fs"].ToString()!="")
				{
					model.community_mid_school_fs=decimal.Parse(row["community_mid_school_fs"].ToString());
				}
				if(row["community_mid_school_stu_num"]!=null && row["community_mid_school_stu_num"].ToString()!="")
				{
					model.community_mid_school_stu_num=int.Parse(row["community_mid_school_stu_num"].ToString());
				}
				if(row["community_mid_school_class_num"]!=null && row["community_mid_school_class_num"].ToString()!="")
				{
					model.community_mid_school_class_num=int.Parse(row["community_mid_school_class_num"].ToString());
				}
				if(row["community_mid_school_plg_area"]!=null && row["community_mid_school_plg_area"].ToString()!="")
				{
					model.community_mid_school_plg_area=decimal.Parse(row["community_mid_school_plg_area"].ToString());
				}
				if(row["community_mid_school_dist_ots"]!=null && row["community_mid_school_dist_ots"].ToString()!="")
				{
					model.community_mid_school_dist_ots=decimal.Parse(row["community_mid_school_dist_ots"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tceunset1"]!=null)
				{
					model.tceunset1=row["tceunset1"].ToString();
				}
				if(row["tceunset2"]!=null)
				{
					model.tceunset2=row["tceunset2"].ToString();
				}
				if(row["tceunset3"]!=null)
				{
					model.tceunset3=row["tceunset3"].ToString();
				}
				if(row["tceunset4"]!=null)
				{
					model.tceunset4=row["tceunset4"].ToString();
				}
				if(row["tceunset5"]!=null)
				{
					model.tceunset5=row["tceunset5"].ToString();
				}
				if(row["tceunset6"]!=null)
				{
					model.tceunset6=row["tceunset6"].ToString();
				}
				if(row["tceunset7"]!=null)
				{
					model.tceunset7=row["tceunset7"].ToString();
				}
				if(row["tceunset8"]!=null)
				{
					model.tceunset8=row["tceunset8"].ToString();
				}
				if(row["tceunset9"]!=null)
				{
					model.tceunset9=row["tceunset9"].ToString();
				}
				if(row["tceunset10"]!=null)
				{
					model.tceunset10=row["tceunset10"].ToString();
				}
				if(row["tceunset11"]!=null)
				{
					model.tceunset11=row["tceunset11"].ToString();
				}
				if(row["tceunset12"]!=null)
				{
					model.tceunset12=row["tceunset12"].ToString();
				}
				if(row["tceunset13"]!=null)
				{
					model.tceunset13=row["tceunset13"].ToString();
				}
				if(row["tceunset14"]!=null)
				{
					model.tceunset14=row["tceunset14"].ToString();
				}
				if(row["tceunset15"]!=null)
				{
					model.tceunset15=row["tceunset15"].ToString();
				}
				if(row["tceunset16"]!=null)
				{
					model.tceunset16=row["tceunset16"].ToString();
				}
				if(row["tceunset17"]!=null)
				{
					model.tceunset17=row["tceunset17"].ToString();
				}
				if(row["tceunset18"]!=null)
				{
					model.tceunset18=row["tceunset18"].ToString();
				}
				if(row["tceunset19"]!=null)
				{
					model.tceunset19=row["tceunset19"].ToString();
				}
				if(row["tceunset20"]!=null)
				{
					model.tceunset20=row["tceunset20"].ToString();
				}
				if(row["tceunset21"]!=null)
				{
					model.tceunset21=row["tceunset21"].ToString();
				}
				if(row["tceunset22"]!=null)
				{
					model.tceunset22=row["tceunset22"].ToString();
				}
				if(row["tceunset23"]!=null)
				{
					model.tceunset23=row["tceunset23"].ToString();
				}
				if(row["tceunset24"]!=null)
				{
					model.tceunset24=row["tceunset24"].ToString();
				}
				if(row["tceunset25"]!=null)
				{
					model.tceunset25=row["tceunset25"].ToString();
				}
				if(row["tceunset26"]!=null)
				{
					model.tceunset26=row["tceunset26"].ToString();
				}
				if(row["tceunset27"]!=null)
				{
					model.tceunset27=row["tceunset27"].ToString();
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
			strSql.Append("select community_id,community_edu_inst_num,community_edu_fs,community_edu_gfa,community_kdg_num,community_pri_kdg_num,community_kdg_fs,community_kdg_gfa,community_kdg_stu_num,community_kdg_class_num,community_kdg_actv_room_area,community_kdg_otd_actv_spa_area,community_kdg_greenland_area,community_kdg_dist_ots,community_prim_school_num,community_prim_school_gfa,community_prim_school_fs,community_prim_school_stu_num,community_prim_school_class_num,community_prim_school_plg_area,community_prim_school_dist_ots,community_mid_school_num,community_mid_school_gfa,community_mid_school_fs,community_mid_school_stu_num,community_mid_school_class_num,community_mid_school_plg_area,community_mid_school_dist_ots,statistics_date,tceunset1,tceunset2,tceunset3,tceunset4,tceunset5,tceunset6,tceunset7,tceunset8,tceunset9,tceunset10,tceunset11,tceunset12,tceunset13,tceunset14,tceunset15,tceunset16,tceunset17,tceunset18,tceunset19,tceunset20,tceunset21,tceunset22,tceunset23,tceunset24,tceunset25,tceunset26,tceunset27,lock_tables,check_status ");
			strSql.Append(" FROM T_community_education ");
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
			strSql.Append(" community_id,community_edu_inst_num,community_edu_fs,community_edu_gfa,community_kdg_num,community_pri_kdg_num,community_kdg_fs,community_kdg_gfa,community_kdg_stu_num,community_kdg_class_num,community_kdg_actv_room_area,community_kdg_otd_actv_spa_area,community_kdg_greenland_area,community_kdg_dist_ots,community_prim_school_num,community_prim_school_gfa,community_prim_school_fs,community_prim_school_stu_num,community_prim_school_class_num,community_prim_school_plg_area,community_prim_school_dist_ots,community_mid_school_num,community_mid_school_gfa,community_mid_school_fs,community_mid_school_stu_num,community_mid_school_class_num,community_mid_school_plg_area,community_mid_school_dist_ots,statistics_date,tceunset1,tceunset2,tceunset3,tceunset4,tceunset5,tceunset6,tceunset7,tceunset8,tceunset9,tceunset10,tceunset11,tceunset12,tceunset13,tceunset14,tceunset15,tceunset16,tceunset17,tceunset18,tceunset19,tceunset20,tceunset21,tceunset22,tceunset23,tceunset24,tceunset25,tceunset26,tceunset27,lock_tables,check_status ");
			strSql.Append(" FROM T_community_education ");
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
			strSql.Append("select count(1) FROM T_community_education ");
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
			strSql.Append(")AS Row, T.*  from T_community_education T ");
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
			parameters[0].Value = "T_community_education";
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

