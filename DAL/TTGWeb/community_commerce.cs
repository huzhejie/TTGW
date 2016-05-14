using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_commerce
	/// </summary>
	public partial class community_commerce
	{
		public community_commerce()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_commerce");
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
		public bool Add(TTG.Model.TTGWeb.community_commerce model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_commerce(");
			strSql.Append("community_id,community_come_fac_num,community_come_fac_fs,community_come_fac_gfa,community_come_enp_num,community_come_enp_fs,community_come_enp_gfa,community_emporium_num,community_small_supermarket_num,community_CVS_num,community_restauran_num,community_household_appliances_store_num,community_agricultural_production_num,community_clothes_store_num,community_hardware_building_materials_store_num,community_drugstore_num,community_bookstore_num,community_other_come_enp_num,community_farm_produce_fair_num,community_farm_produce_fair_gfa,community_farm_produce_fair_fs,community_farm_produce_fair_dis_ots,community_pedlar_market_num,community_pedlar_market_gfa,community_pedlar_market_fs,community_pedlar_market_dis_ots,community_farm_whs_market_num,community_farm_whs_market_gfa,community_farm_whs_market_fs,community_farm_whs_market_dis_ots,statistics_date,tccunset1,tccunset2,tccunset3,tccunset4,tccunset5,tccunset6,tccunset7,tccunset8,tccunset9,tccunset10,tccunset11,tccunset12,tccunset13,tccunset14,tccunset15,tccunset16,tccunset17,tccunset18,tccunset19,tccunset20,tccunset21,tccunset22,tccunset23,tccunset24,tccunset25,tccunset26,tccunset27,tccunset28,tccunset29,lock_tables,check_status,community_convinent_market_num,community_convinent_market_gfa,community_convinent_market_fs,community_convinent_market_dis_ots)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_come_fac_num,@community_come_fac_fs,@community_come_fac_gfa,@community_come_enp_num,@community_come_enp_fs,@community_come_enp_gfa,@community_emporium_num,@community_small_supermarket_num,@community_CVS_num,@community_restauran_num,@community_household_appliances_store_num,@community_agricultural_production_num,@community_clothes_store_num,@community_hardware_building_materials_store_num,@community_drugstore_num,@community_bookstore_num,@community_other_come_enp_num,@community_farm_produce_fair_num,@community_farm_produce_fair_gfa,@community_farm_produce_fair_fs,@community_farm_produce_fair_dis_ots,@community_pedlar_market_num,@community_pedlar_market_gfa,@community_pedlar_market_fs,@community_pedlar_market_dis_ots,@community_farm_whs_market_num,@community_farm_whs_market_gfa,@community_farm_whs_market_fs,@community_farm_whs_market_dis_ots,@statistics_date,@tccunset1,@tccunset2,@tccunset3,@tccunset4,@tccunset5,@tccunset6,@tccunset7,@tccunset8,@tccunset9,@tccunset10,@tccunset11,@tccunset12,@tccunset13,@tccunset14,@tccunset15,@tccunset16,@tccunset17,@tccunset18,@tccunset19,@tccunset20,@tccunset21,@tccunset22,@tccunset23,@tccunset24,@tccunset25,@tccunset26,@tccunset27,@tccunset28,@tccunset29,@lock_tables,@check_status,@community_convinent_market_num,@community_convinent_market_gfa,@community_convinent_market_fs,@community_convinent_market_dis_ots)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_come_fac_num", SqlDbType.Int,4),
					new SqlParameter("@community_come_fac_fs", SqlDbType.Float,8),
					new SqlParameter("@community_come_fac_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_come_enp_num", SqlDbType.Int,4),
					new SqlParameter("@community_come_enp_fs", SqlDbType.Float,8),
					new SqlParameter("@community_come_enp_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_emporium_num", SqlDbType.Int,4),
					new SqlParameter("@community_small_supermarket_num", SqlDbType.Int,4),
					new SqlParameter("@community_CVS_num", SqlDbType.Int,4),
					new SqlParameter("@community_restauran_num", SqlDbType.Int,4),
					new SqlParameter("@community_household_appliances_store_num", SqlDbType.Int,4),
					new SqlParameter("@community_agricultural_production_num", SqlDbType.Int,4),
					new SqlParameter("@community_clothes_store_num", SqlDbType.Int,4),
					new SqlParameter("@community_hardware_building_materials_store_num", SqlDbType.Int,4),
					new SqlParameter("@community_drugstore_num", SqlDbType.Int,4),
					new SqlParameter("@community_bookstore_num", SqlDbType.Int,4),
					new SqlParameter("@community_other_come_enp_num", SqlDbType.Int,4),
					new SqlParameter("@community_farm_produce_fair_num", SqlDbType.Int,4),
					new SqlParameter("@community_farm_produce_fair_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_farm_produce_fair_fs", SqlDbType.Float,8),
					new SqlParameter("@community_farm_produce_fair_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_pedlar_market_num", SqlDbType.Int,4),
					new SqlParameter("@community_pedlar_market_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_pedlar_market_fs", SqlDbType.Float,8),
					new SqlParameter("@community_pedlar_market_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_farm_whs_market_num", SqlDbType.Int,4),
					new SqlParameter("@community_farm_whs_market_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_farm_whs_market_fs", SqlDbType.Float,8),
					new SqlParameter("@community_farm_whs_market_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tccunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset21", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset22", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset23", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset24", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset25", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset26", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset27", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset28", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset29", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_convinent_market_num", SqlDbType.Int,4),
					new SqlParameter("@community_convinent_market_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_convinent_market_fs", SqlDbType.Float,8),
					new SqlParameter("@community_convinent_market_dis_ots", SqlDbType.Float,8)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_come_fac_num;
			parameters[2].Value = model.community_come_fac_fs;
			parameters[3].Value = model.community_come_fac_gfa;
			parameters[4].Value = model.community_come_enp_num;
			parameters[5].Value = model.community_come_enp_fs;
			parameters[6].Value = model.community_come_enp_gfa;
			parameters[7].Value = model.community_emporium_num;
			parameters[8].Value = model.community_small_supermarket_num;
			parameters[9].Value = model.community_CVS_num;
			parameters[10].Value = model.community_restauran_num;
			parameters[11].Value = model.community_household_appliances_store_num;
			parameters[12].Value = model.community_agricultural_production_num;
			parameters[13].Value = model.community_clothes_store_num;
			parameters[14].Value = model.community_hardware_building_materials_store_num;
			parameters[15].Value = model.community_drugstore_num;
			parameters[16].Value = model.community_bookstore_num;
			parameters[17].Value = model.community_other_come_enp_num;
			parameters[18].Value = model.community_farm_produce_fair_num;
			parameters[19].Value = model.community_farm_produce_fair_gfa;
			parameters[20].Value = model.community_farm_produce_fair_fs;
			parameters[21].Value = model.community_farm_produce_fair_dis_ots;
			parameters[22].Value = model.community_pedlar_market_num;
			parameters[23].Value = model.community_pedlar_market_gfa;
			parameters[24].Value = model.community_pedlar_market_fs;
			parameters[25].Value = model.community_pedlar_market_dis_ots;
			parameters[26].Value = model.community_farm_whs_market_num;
			parameters[27].Value = model.community_farm_whs_market_gfa;
			parameters[28].Value = model.community_farm_whs_market_fs;
			parameters[29].Value = model.community_farm_whs_market_dis_ots;
			parameters[30].Value = model.statistics_date;
			parameters[31].Value = model.tccunset1;
			parameters[32].Value = model.tccunset2;
			parameters[33].Value = model.tccunset3;
			parameters[34].Value = model.tccunset4;
			parameters[35].Value = model.tccunset5;
			parameters[36].Value = model.tccunset6;
			parameters[37].Value = model.tccunset7;
			parameters[38].Value = model.tccunset8;
			parameters[39].Value = model.tccunset9;
			parameters[40].Value = model.tccunset10;
			parameters[41].Value = model.tccunset11;
			parameters[42].Value = model.tccunset12;
			parameters[43].Value = model.tccunset13;
			parameters[44].Value = model.tccunset14;
			parameters[45].Value = model.tccunset15;
			parameters[46].Value = model.tccunset16;
			parameters[47].Value = model.tccunset17;
			parameters[48].Value = model.tccunset18;
			parameters[49].Value = model.tccunset19;
			parameters[50].Value = model.tccunset20;
			parameters[51].Value = model.tccunset21;
			parameters[52].Value = model.tccunset22;
			parameters[53].Value = model.tccunset23;
			parameters[54].Value = model.tccunset24;
			parameters[55].Value = model.tccunset25;
			parameters[56].Value = model.tccunset26;
			parameters[57].Value = model.tccunset27;
			parameters[58].Value = model.tccunset28;
			parameters[59].Value = model.tccunset29;
			parameters[60].Value = model.lock_tables;
			parameters[61].Value = model.check_status;
			parameters[62].Value = model.community_convinent_market_num;
			parameters[63].Value = model.community_convinent_market_gfa;
			parameters[64].Value = model.community_convinent_market_fs;
			parameters[65].Value = model.community_convinent_market_dis_ots;

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
		public bool Update(TTG.Model.TTGWeb.community_commerce model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_commerce set ");
			strSql.Append("community_come_fac_num=@community_come_fac_num,");
			strSql.Append("community_come_fac_fs=@community_come_fac_fs,");
			strSql.Append("community_come_fac_gfa=@community_come_fac_gfa,");
			strSql.Append("community_come_enp_num=@community_come_enp_num,");
			strSql.Append("community_come_enp_fs=@community_come_enp_fs,");
			strSql.Append("community_come_enp_gfa=@community_come_enp_gfa,");
			strSql.Append("community_emporium_num=@community_emporium_num,");
			strSql.Append("community_small_supermarket_num=@community_small_supermarket_num,");
			strSql.Append("community_CVS_num=@community_CVS_num,");
			strSql.Append("community_restauran_num=@community_restauran_num,");
			strSql.Append("community_household_appliances_store_num=@community_household_appliances_store_num,");
			strSql.Append("community_agricultural_production_num=@community_agricultural_production_num,");
			strSql.Append("community_clothes_store_num=@community_clothes_store_num,");
			strSql.Append("community_hardware_building_materials_store_num=@community_hardware_building_materials_store_num,");
			strSql.Append("community_drugstore_num=@community_drugstore_num,");
			strSql.Append("community_bookstore_num=@community_bookstore_num,");
			strSql.Append("community_other_come_enp_num=@community_other_come_enp_num,");
			strSql.Append("community_farm_produce_fair_num=@community_farm_produce_fair_num,");
			strSql.Append("community_farm_produce_fair_gfa=@community_farm_produce_fair_gfa,");
			strSql.Append("community_farm_produce_fair_fs=@community_farm_produce_fair_fs,");
			strSql.Append("community_farm_produce_fair_dis_ots=@community_farm_produce_fair_dis_ots,");
			strSql.Append("community_pedlar_market_num=@community_pedlar_market_num,");
			strSql.Append("community_pedlar_market_gfa=@community_pedlar_market_gfa,");
			strSql.Append("community_pedlar_market_fs=@community_pedlar_market_fs,");
			strSql.Append("community_pedlar_market_dis_ots=@community_pedlar_market_dis_ots,");
			strSql.Append("community_farm_whs_market_num=@community_farm_whs_market_num,");
			strSql.Append("community_farm_whs_market_gfa=@community_farm_whs_market_gfa,");
			strSql.Append("community_farm_whs_market_fs=@community_farm_whs_market_fs,");
			strSql.Append("community_farm_whs_market_dis_ots=@community_farm_whs_market_dis_ots,");
			strSql.Append("tccunset1=@tccunset1,");
			strSql.Append("tccunset2=@tccunset2,");
			strSql.Append("tccunset3=@tccunset3,");
			strSql.Append("tccunset4=@tccunset4,");
			strSql.Append("tccunset5=@tccunset5,");
			strSql.Append("tccunset6=@tccunset6,");
			strSql.Append("tccunset7=@tccunset7,");
			strSql.Append("tccunset8=@tccunset8,");
			strSql.Append("tccunset9=@tccunset9,");
			strSql.Append("tccunset10=@tccunset10,");
			strSql.Append("tccunset11=@tccunset11,");
			strSql.Append("tccunset12=@tccunset12,");
			strSql.Append("tccunset13=@tccunset13,");
			strSql.Append("tccunset14=@tccunset14,");
			strSql.Append("tccunset15=@tccunset15,");
			strSql.Append("tccunset16=@tccunset16,");
			strSql.Append("tccunset17=@tccunset17,");
			strSql.Append("tccunset18=@tccunset18,");
			strSql.Append("tccunset19=@tccunset19,");
			strSql.Append("tccunset20=@tccunset20,");
			strSql.Append("tccunset21=@tccunset21,");
			strSql.Append("tccunset22=@tccunset22,");
			strSql.Append("tccunset23=@tccunset23,");
			strSql.Append("tccunset24=@tccunset24,");
			strSql.Append("tccunset25=@tccunset25,");
			strSql.Append("tccunset26=@tccunset26,");
			strSql.Append("tccunset27=@tccunset27,");
			strSql.Append("tccunset28=@tccunset28,");
			strSql.Append("tccunset29=@tccunset29,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("community_convinent_market_num=@community_convinent_market_num,");
			strSql.Append("community_convinent_market_gfa=@community_convinent_market_gfa,");
			strSql.Append("community_convinent_market_fs=@community_convinent_market_fs,");
			strSql.Append("community_convinent_market_dis_ots=@community_convinent_market_dis_ots");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_come_fac_num", SqlDbType.Int,4),
					new SqlParameter("@community_come_fac_fs", SqlDbType.Float,8),
					new SqlParameter("@community_come_fac_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_come_enp_num", SqlDbType.Int,4),
					new SqlParameter("@community_come_enp_fs", SqlDbType.Float,8),
					new SqlParameter("@community_come_enp_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_emporium_num", SqlDbType.Int,4),
					new SqlParameter("@community_small_supermarket_num", SqlDbType.Int,4),
					new SqlParameter("@community_CVS_num", SqlDbType.Int,4),
					new SqlParameter("@community_restauran_num", SqlDbType.Int,4),
					new SqlParameter("@community_household_appliances_store_num", SqlDbType.Int,4),
					new SqlParameter("@community_agricultural_production_num", SqlDbType.Int,4),
					new SqlParameter("@community_clothes_store_num", SqlDbType.Int,4),
					new SqlParameter("@community_hardware_building_materials_store_num", SqlDbType.Int,4),
					new SqlParameter("@community_drugstore_num", SqlDbType.Int,4),
					new SqlParameter("@community_bookstore_num", SqlDbType.Int,4),
					new SqlParameter("@community_other_come_enp_num", SqlDbType.Int,4),
					new SqlParameter("@community_farm_produce_fair_num", SqlDbType.Int,4),
					new SqlParameter("@community_farm_produce_fair_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_farm_produce_fair_fs", SqlDbType.Float,8),
					new SqlParameter("@community_farm_produce_fair_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_pedlar_market_num", SqlDbType.Int,4),
					new SqlParameter("@community_pedlar_market_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_pedlar_market_fs", SqlDbType.Float,8),
					new SqlParameter("@community_pedlar_market_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_farm_whs_market_num", SqlDbType.Int,4),
					new SqlParameter("@community_farm_whs_market_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_farm_whs_market_fs", SqlDbType.Float,8),
					new SqlParameter("@community_farm_whs_market_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@tccunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset21", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset22", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset23", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset24", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset25", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset26", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset27", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset28", SqlDbType.VarChar,50),
					new SqlParameter("@tccunset29", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_convinent_market_num", SqlDbType.Int,4),
					new SqlParameter("@community_convinent_market_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_convinent_market_fs", SqlDbType.Float,8),
					new SqlParameter("@community_convinent_market_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_come_fac_num;
			parameters[1].Value = model.community_come_fac_fs;
			parameters[2].Value = model.community_come_fac_gfa;
			parameters[3].Value = model.community_come_enp_num;
			parameters[4].Value = model.community_come_enp_fs;
			parameters[5].Value = model.community_come_enp_gfa;
			parameters[6].Value = model.community_emporium_num;
			parameters[7].Value = model.community_small_supermarket_num;
			parameters[8].Value = model.community_CVS_num;
			parameters[9].Value = model.community_restauran_num;
			parameters[10].Value = model.community_household_appliances_store_num;
			parameters[11].Value = model.community_agricultural_production_num;
			parameters[12].Value = model.community_clothes_store_num;
			parameters[13].Value = model.community_hardware_building_materials_store_num;
			parameters[14].Value = model.community_drugstore_num;
			parameters[15].Value = model.community_bookstore_num;
			parameters[16].Value = model.community_other_come_enp_num;
			parameters[17].Value = model.community_farm_produce_fair_num;
			parameters[18].Value = model.community_farm_produce_fair_gfa;
			parameters[19].Value = model.community_farm_produce_fair_fs;
			parameters[20].Value = model.community_farm_produce_fair_dis_ots;
			parameters[21].Value = model.community_pedlar_market_num;
			parameters[22].Value = model.community_pedlar_market_gfa;
			parameters[23].Value = model.community_pedlar_market_fs;
			parameters[24].Value = model.community_pedlar_market_dis_ots;
			parameters[25].Value = model.community_farm_whs_market_num;
			parameters[26].Value = model.community_farm_whs_market_gfa;
			parameters[27].Value = model.community_farm_whs_market_fs;
			parameters[28].Value = model.community_farm_whs_market_dis_ots;
			parameters[29].Value = model.tccunset1;
			parameters[30].Value = model.tccunset2;
			parameters[31].Value = model.tccunset3;
			parameters[32].Value = model.tccunset4;
			parameters[33].Value = model.tccunset5;
			parameters[34].Value = model.tccunset6;
			parameters[35].Value = model.tccunset7;
			parameters[36].Value = model.tccunset8;
			parameters[37].Value = model.tccunset9;
			parameters[38].Value = model.tccunset10;
			parameters[39].Value = model.tccunset11;
			parameters[40].Value = model.tccunset12;
			parameters[41].Value = model.tccunset13;
			parameters[42].Value = model.tccunset14;
			parameters[43].Value = model.tccunset15;
			parameters[44].Value = model.tccunset16;
			parameters[45].Value = model.tccunset17;
			parameters[46].Value = model.tccunset18;
			parameters[47].Value = model.tccunset19;
			parameters[48].Value = model.tccunset20;
			parameters[49].Value = model.tccunset21;
			parameters[50].Value = model.tccunset22;
			parameters[51].Value = model.tccunset23;
			parameters[52].Value = model.tccunset24;
			parameters[53].Value = model.tccunset25;
			parameters[54].Value = model.tccunset26;
			parameters[55].Value = model.tccunset27;
			parameters[56].Value = model.tccunset28;
			parameters[57].Value = model.tccunset29;
			parameters[58].Value = model.lock_tables;
			parameters[59].Value = model.check_status;
			parameters[60].Value = model.community_convinent_market_num;
			parameters[61].Value = model.community_convinent_market_gfa;
			parameters[62].Value = model.community_convinent_market_fs;
			parameters[63].Value = model.community_convinent_market_dis_ots;
			parameters[64].Value = model.community_id;
			parameters[65].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_commerce ");
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
		public TTG.Model.TTGWeb.community_commerce GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_come_fac_num,community_come_fac_fs,community_come_fac_gfa,community_come_enp_num,community_come_enp_fs,community_come_enp_gfa,community_emporium_num,community_small_supermarket_num,community_CVS_num,community_restauran_num,community_household_appliances_store_num,community_agricultural_production_num,community_clothes_store_num,community_hardware_building_materials_store_num,community_drugstore_num,community_bookstore_num,community_other_come_enp_num,community_farm_produce_fair_num,community_farm_produce_fair_gfa,community_farm_produce_fair_fs,community_farm_produce_fair_dis_ots,community_pedlar_market_num,community_pedlar_market_gfa,community_pedlar_market_fs,community_pedlar_market_dis_ots,community_farm_whs_market_num,community_farm_whs_market_gfa,community_farm_whs_market_fs,community_farm_whs_market_dis_ots,statistics_date,tccunset1,tccunset2,tccunset3,tccunset4,tccunset5,tccunset6,tccunset7,tccunset8,tccunset9,tccunset10,tccunset11,tccunset12,tccunset13,tccunset14,tccunset15,tccunset16,tccunset17,tccunset18,tccunset19,tccunset20,tccunset21,tccunset22,tccunset23,tccunset24,tccunset25,tccunset26,tccunset27,tccunset28,tccunset29,lock_tables,check_status,community_convinent_market_num,community_convinent_market_gfa,community_convinent_market_fs,community_convinent_market_dis_ots from T_community_commerce ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_commerce model=new TTG.Model.TTGWeb.community_commerce();
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
		public TTG.Model.TTGWeb.community_commerce DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_commerce model=new TTG.Model.TTGWeb.community_commerce();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_come_fac_num"]!=null && row["community_come_fac_num"].ToString()!="")
				{
					model.community_come_fac_num=int.Parse(row["community_come_fac_num"].ToString());
				}
				if(row["community_come_fac_fs"]!=null && row["community_come_fac_fs"].ToString()!="")
				{
					model.community_come_fac_fs=decimal.Parse(row["community_come_fac_fs"].ToString());
				}
				if(row["community_come_fac_gfa"]!=null && row["community_come_fac_gfa"].ToString()!="")
				{
					model.community_come_fac_gfa=decimal.Parse(row["community_come_fac_gfa"].ToString());
				}
				if(row["community_come_enp_num"]!=null && row["community_come_enp_num"].ToString()!="")
				{
					model.community_come_enp_num=int.Parse(row["community_come_enp_num"].ToString());
				}
				if(row["community_come_enp_fs"]!=null && row["community_come_enp_fs"].ToString()!="")
				{
					model.community_come_enp_fs=decimal.Parse(row["community_come_enp_fs"].ToString());
				}
				if(row["community_come_enp_gfa"]!=null && row["community_come_enp_gfa"].ToString()!="")
				{
					model.community_come_enp_gfa=decimal.Parse(row["community_come_enp_gfa"].ToString());
				}
				if(row["community_emporium_num"]!=null && row["community_emporium_num"].ToString()!="")
				{
					model.community_emporium_num=int.Parse(row["community_emporium_num"].ToString());
				}
				if(row["community_small_supermarket_num"]!=null && row["community_small_supermarket_num"].ToString()!="")
				{
					model.community_small_supermarket_num=int.Parse(row["community_small_supermarket_num"].ToString());
				}
				if(row["community_CVS_num"]!=null && row["community_CVS_num"].ToString()!="")
				{
					model.community_CVS_num=int.Parse(row["community_CVS_num"].ToString());
				}
				if(row["community_restauran_num"]!=null && row["community_restauran_num"].ToString()!="")
				{
					model.community_restauran_num=int.Parse(row["community_restauran_num"].ToString());
				}
				if(row["community_household_appliances_store_num"]!=null && row["community_household_appliances_store_num"].ToString()!="")
				{
					model.community_household_appliances_store_num=int.Parse(row["community_household_appliances_store_num"].ToString());
				}
				if(row["community_agricultural_production_num"]!=null && row["community_agricultural_production_num"].ToString()!="")
				{
					model.community_agricultural_production_num=int.Parse(row["community_agricultural_production_num"].ToString());
				}
				if(row["community_clothes_store_num"]!=null && row["community_clothes_store_num"].ToString()!="")
				{
					model.community_clothes_store_num=int.Parse(row["community_clothes_store_num"].ToString());
				}
				if(row["community_hardware_building_materials_store_num"]!=null && row["community_hardware_building_materials_store_num"].ToString()!="")
				{
					model.community_hardware_building_materials_store_num=int.Parse(row["community_hardware_building_materials_store_num"].ToString());
				}
				if(row["community_drugstore_num"]!=null && row["community_drugstore_num"].ToString()!="")
				{
					model.community_drugstore_num=int.Parse(row["community_drugstore_num"].ToString());
				}
				if(row["community_bookstore_num"]!=null && row["community_bookstore_num"].ToString()!="")
				{
					model.community_bookstore_num=int.Parse(row["community_bookstore_num"].ToString());
				}
				if(row["community_other_come_enp_num"]!=null && row["community_other_come_enp_num"].ToString()!="")
				{
					model.community_other_come_enp_num=int.Parse(row["community_other_come_enp_num"].ToString());
				}
				if(row["community_farm_produce_fair_num"]!=null && row["community_farm_produce_fair_num"].ToString()!="")
				{
					model.community_farm_produce_fair_num=int.Parse(row["community_farm_produce_fair_num"].ToString());
				}
				if(row["community_farm_produce_fair_gfa"]!=null && row["community_farm_produce_fair_gfa"].ToString()!="")
				{
					model.community_farm_produce_fair_gfa=decimal.Parse(row["community_farm_produce_fair_gfa"].ToString());
				}
				if(row["community_farm_produce_fair_fs"]!=null && row["community_farm_produce_fair_fs"].ToString()!="")
				{
					model.community_farm_produce_fair_fs=decimal.Parse(row["community_farm_produce_fair_fs"].ToString());
				}
				if(row["community_farm_produce_fair_dis_ots"]!=null && row["community_farm_produce_fair_dis_ots"].ToString()!="")
				{
					model.community_farm_produce_fair_dis_ots=decimal.Parse(row["community_farm_produce_fair_dis_ots"].ToString());
				}
				if(row["community_pedlar_market_num"]!=null && row["community_pedlar_market_num"].ToString()!="")
				{
					model.community_pedlar_market_num=int.Parse(row["community_pedlar_market_num"].ToString());
				}
				if(row["community_pedlar_market_gfa"]!=null && row["community_pedlar_market_gfa"].ToString()!="")
				{
					model.community_pedlar_market_gfa=decimal.Parse(row["community_pedlar_market_gfa"].ToString());
				}
				if(row["community_pedlar_market_fs"]!=null && row["community_pedlar_market_fs"].ToString()!="")
				{
					model.community_pedlar_market_fs=decimal.Parse(row["community_pedlar_market_fs"].ToString());
				}
				if(row["community_pedlar_market_dis_ots"]!=null && row["community_pedlar_market_dis_ots"].ToString()!="")
				{
					model.community_pedlar_market_dis_ots=decimal.Parse(row["community_pedlar_market_dis_ots"].ToString());
				}
				if(row["community_farm_whs_market_num"]!=null && row["community_farm_whs_market_num"].ToString()!="")
				{
					model.community_farm_whs_market_num=int.Parse(row["community_farm_whs_market_num"].ToString());
				}
				if(row["community_farm_whs_market_gfa"]!=null && row["community_farm_whs_market_gfa"].ToString()!="")
				{
					model.community_farm_whs_market_gfa=decimal.Parse(row["community_farm_whs_market_gfa"].ToString());
				}
				if(row["community_farm_whs_market_fs"]!=null && row["community_farm_whs_market_fs"].ToString()!="")
				{
					model.community_farm_whs_market_fs=decimal.Parse(row["community_farm_whs_market_fs"].ToString());
				}
				if(row["community_farm_whs_market_dis_ots"]!=null && row["community_farm_whs_market_dis_ots"].ToString()!="")
				{
					model.community_farm_whs_market_dis_ots=decimal.Parse(row["community_farm_whs_market_dis_ots"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tccunset1"]!=null)
				{
					model.tccunset1=row["tccunset1"].ToString();
				}
				if(row["tccunset2"]!=null)
				{
					model.tccunset2=row["tccunset2"].ToString();
				}
				if(row["tccunset3"]!=null)
				{
					model.tccunset3=row["tccunset3"].ToString();
				}
				if(row["tccunset4"]!=null)
				{
					model.tccunset4=row["tccunset4"].ToString();
				}
				if(row["tccunset5"]!=null)
				{
					model.tccunset5=row["tccunset5"].ToString();
				}
				if(row["tccunset6"]!=null)
				{
					model.tccunset6=row["tccunset6"].ToString();
				}
				if(row["tccunset7"]!=null)
				{
					model.tccunset7=row["tccunset7"].ToString();
				}
				if(row["tccunset8"]!=null)
				{
					model.tccunset8=row["tccunset8"].ToString();
				}
				if(row["tccunset9"]!=null)
				{
					model.tccunset9=row["tccunset9"].ToString();
				}
				if(row["tccunset10"]!=null)
				{
					model.tccunset10=row["tccunset10"].ToString();
				}
				if(row["tccunset11"]!=null)
				{
					model.tccunset11=row["tccunset11"].ToString();
				}
				if(row["tccunset12"]!=null)
				{
					model.tccunset12=row["tccunset12"].ToString();
				}
				if(row["tccunset13"]!=null)
				{
					model.tccunset13=row["tccunset13"].ToString();
				}
				if(row["tccunset14"]!=null)
				{
					model.tccunset14=row["tccunset14"].ToString();
				}
				if(row["tccunset15"]!=null)
				{
					model.tccunset15=row["tccunset15"].ToString();
				}
				if(row["tccunset16"]!=null)
				{
					model.tccunset16=row["tccunset16"].ToString();
				}
				if(row["tccunset17"]!=null)
				{
					model.tccunset17=row["tccunset17"].ToString();
				}
				if(row["tccunset18"]!=null)
				{
					model.tccunset18=row["tccunset18"].ToString();
				}
				if(row["tccunset19"]!=null)
				{
					model.tccunset19=row["tccunset19"].ToString();
				}
				if(row["tccunset20"]!=null)
				{
					model.tccunset20=row["tccunset20"].ToString();
				}
				if(row["tccunset21"]!=null)
				{
					model.tccunset21=row["tccunset21"].ToString();
				}
				if(row["tccunset22"]!=null)
				{
					model.tccunset22=row["tccunset22"].ToString();
				}
				if(row["tccunset23"]!=null)
				{
					model.tccunset23=row["tccunset23"].ToString();
				}
				if(row["tccunset24"]!=null)
				{
					model.tccunset24=row["tccunset24"].ToString();
				}
				if(row["tccunset25"]!=null)
				{
					model.tccunset25=row["tccunset25"].ToString();
				}
				if(row["tccunset26"]!=null)
				{
					model.tccunset26=row["tccunset26"].ToString();
				}
				if(row["tccunset27"]!=null)
				{
					model.tccunset27=row["tccunset27"].ToString();
				}
				if(row["tccunset28"]!=null)
				{
					model.tccunset28=row["tccunset28"].ToString();
				}
				if(row["tccunset29"]!=null)
				{
					model.tccunset29=row["tccunset29"].ToString();
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["community_convinent_market_num"]!=null && row["community_convinent_market_num"].ToString()!="")
				{
					model.community_convinent_market_num=int.Parse(row["community_convinent_market_num"].ToString());
				}
				if(row["community_convinent_market_gfa"]!=null && row["community_convinent_market_gfa"].ToString()!="")
				{
					model.community_convinent_market_gfa=decimal.Parse(row["community_convinent_market_gfa"].ToString());
				}
				if(row["community_convinent_market_fs"]!=null && row["community_convinent_market_fs"].ToString()!="")
				{
					model.community_convinent_market_fs=decimal.Parse(row["community_convinent_market_fs"].ToString());
				}
				if(row["community_convinent_market_dis_ots"]!=null && row["community_convinent_market_dis_ots"].ToString()!="")
				{
					model.community_convinent_market_dis_ots=decimal.Parse(row["community_convinent_market_dis_ots"].ToString());
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
			strSql.Append("select community_id,community_come_fac_num,community_come_fac_fs,community_come_fac_gfa,community_come_enp_num,community_come_enp_fs,community_come_enp_gfa,community_emporium_num,community_small_supermarket_num,community_CVS_num,community_restauran_num,community_household_appliances_store_num,community_agricultural_production_num,community_clothes_store_num,community_hardware_building_materials_store_num,community_drugstore_num,community_bookstore_num,community_other_come_enp_num,community_farm_produce_fair_num,community_farm_produce_fair_gfa,community_farm_produce_fair_fs,community_farm_produce_fair_dis_ots,community_pedlar_market_num,community_pedlar_market_gfa,community_pedlar_market_fs,community_pedlar_market_dis_ots,community_farm_whs_market_num,community_farm_whs_market_gfa,community_farm_whs_market_fs,community_farm_whs_market_dis_ots,statistics_date,tccunset1,tccunset2,tccunset3,tccunset4,tccunset5,tccunset6,tccunset7,tccunset8,tccunset9,tccunset10,tccunset11,tccunset12,tccunset13,tccunset14,tccunset15,tccunset16,tccunset17,tccunset18,tccunset19,tccunset20,tccunset21,tccunset22,tccunset23,tccunset24,tccunset25,tccunset26,tccunset27,tccunset28,tccunset29,lock_tables,check_status,community_convinent_market_num,community_convinent_market_gfa,community_convinent_market_fs,community_convinent_market_dis_ots ");
			strSql.Append(" FROM T_community_commerce ");
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
			strSql.Append(" community_id,community_come_fac_num,community_come_fac_fs,community_come_fac_gfa,community_come_enp_num,community_come_enp_fs,community_come_enp_gfa,community_emporium_num,community_small_supermarket_num,community_CVS_num,community_restauran_num,community_household_appliances_store_num,community_agricultural_production_num,community_clothes_store_num,community_hardware_building_materials_store_num,community_drugstore_num,community_bookstore_num,community_other_come_enp_num,community_farm_produce_fair_num,community_farm_produce_fair_gfa,community_farm_produce_fair_fs,community_farm_produce_fair_dis_ots,community_pedlar_market_num,community_pedlar_market_gfa,community_pedlar_market_fs,community_pedlar_market_dis_ots,community_farm_whs_market_num,community_farm_whs_market_gfa,community_farm_whs_market_fs,community_farm_whs_market_dis_ots,statistics_date,tccunset1,tccunset2,tccunset3,tccunset4,tccunset5,tccunset6,tccunset7,tccunset8,tccunset9,tccunset10,tccunset11,tccunset12,tccunset13,tccunset14,tccunset15,tccunset16,tccunset17,tccunset18,tccunset19,tccunset20,tccunset21,tccunset22,tccunset23,tccunset24,tccunset25,tccunset26,tccunset27,tccunset28,tccunset29,lock_tables,check_status,community_convinent_market_num,community_convinent_market_gfa,community_convinent_market_fs,community_convinent_market_dis_ots ");
			strSql.Append(" FROM T_community_commerce ");
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
			strSql.Append("select count(1) FROM T_community_commerce ");
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
			strSql.Append(")AS Row, T.*  from T_community_commerce T ");
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
			parameters[0].Value = "T_community_commerce";
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

