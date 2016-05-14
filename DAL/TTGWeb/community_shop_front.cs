using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_shop_front
	/// </summary>
	public partial class community_shop_front
	{
		public community_shop_front()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_shop_front");
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
		public bool Add(TTG.Model.TTGWeb.community_shop_front model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_shop_front(");
			strSql.Append("community_id,community_shop_front_num,community_shop_front_in_main_street_num,community_shop_front_in_collector_street_num,community_shop_front_in_alley_num,community_back_street_shop_front_num,community_shop_front_area,community_immigrant_shop_front_num,community_immigrant_shop_front_area,community_immigrant_run_shop_front_num,community_immigrant_run_shop_front_area,community_immigrant_rent_out_shop_front_num,community_immigrant_rent_out_shop_front_area,community_immigrant_unused_shop_front_num,community_immigrant_unused_shop_front_area,community_shop_front_amount,community_catering_shop_front_num,community_accommodation_shop_front_num,community_commodity_shop_front_num,community_means_of_production_shop_front_num,community_automobile_service_shop_front_num,community_other__shop_front_num,community_average_rent_of_shop_front,community_average_rent_time_of_shop_front,community_average_price_shop_front,statistics_date,community_immigrant_sm_shop_front_num,community_immigrant_sm_shop_front_area,tcsfunset1,tcsfunset2,tcsfunset3,tcsfunset4,tcsfunset5,tcsfunset6,tcsfunset7,tcsfunset8,tcsfunset9,tcsfunset10,tcsfunset11,tcsfunset12,tcsfunset13,tcsfunset14,tcsfunset15,tcsfunset16,tcsfunset17,tcsfunset18,tcsfunset19,tcsfunset20,tcsfunset21,tcsfunset22,tcsfunset23,tcsfunset24,tcsfunset25,tcsfunset26,lock_tables,check_status,county_average_rent)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_shop_front_num,@community_shop_front_in_main_street_num,@community_shop_front_in_collector_street_num,@community_shop_front_in_alley_num,@community_back_street_shop_front_num,@community_shop_front_area,@community_immigrant_shop_front_num,@community_immigrant_shop_front_area,@community_immigrant_run_shop_front_num,@community_immigrant_run_shop_front_area,@community_immigrant_rent_out_shop_front_num,@community_immigrant_rent_out_shop_front_area,@community_immigrant_unused_shop_front_num,@community_immigrant_unused_shop_front_area,@community_shop_front_amount,@community_catering_shop_front_num,@community_accommodation_shop_front_num,@community_commodity_shop_front_num,@community_means_of_production_shop_front_num,@community_automobile_service_shop_front_num,@community_other__shop_front_num,@community_average_rent_of_shop_front,@community_average_rent_time_of_shop_front,@community_average_price_shop_front,@statistics_date,@community_immigrant_sm_shop_front_num,@community_immigrant_sm_shop_front_area,@tcsfunset1,@tcsfunset2,@tcsfunset3,@tcsfunset4,@tcsfunset5,@tcsfunset6,@tcsfunset7,@tcsfunset8,@tcsfunset9,@tcsfunset10,@tcsfunset11,@tcsfunset12,@tcsfunset13,@tcsfunset14,@tcsfunset15,@tcsfunset16,@tcsfunset17,@tcsfunset18,@tcsfunset19,@tcsfunset20,@tcsfunset21,@tcsfunset22,@tcsfunset23,@tcsfunset24,@tcsfunset25,@tcsfunset26,@lock_tables,@check_status,@county_average_rent)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_shop_front_in_main_street_num", SqlDbType.Int,4),
					new SqlParameter("@community_shop_front_in_collector_street_num", SqlDbType.Int,4),
					new SqlParameter("@community_shop_front_in_alley_num", SqlDbType.Int,4),
					new SqlParameter("@community_back_street_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_shop_front_area", SqlDbType.Float,8),
					new SqlParameter("@community_immigrant_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_immigrant_shop_front_area", SqlDbType.Float,8),
					new SqlParameter("@community_immigrant_run_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_immigrant_run_shop_front_area", SqlDbType.Float,8),
					new SqlParameter("@community_immigrant_rent_out_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_immigrant_rent_out_shop_front_area", SqlDbType.Float,8),
					new SqlParameter("@community_immigrant_unused_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_immigrant_unused_shop_front_area", SqlDbType.Float,8),
					new SqlParameter("@community_shop_front_amount", SqlDbType.Int,4),
					new SqlParameter("@community_catering_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_accommodation_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_commodity_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_means_of_production_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_automobile_service_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_other__shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_average_rent_of_shop_front", SqlDbType.Float,8),
					new SqlParameter("@community_average_rent_time_of_shop_front", SqlDbType.VarChar,50),
					new SqlParameter("@community_average_price_shop_front", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@community_immigrant_sm_shop_front_num", SqlDbType.Float,8),
					new SqlParameter("@community_immigrant_sm_shop_front_area", SqlDbType.Float,8),
					new SqlParameter("@tcsfunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset21", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset22", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset23", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset24", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset25", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset26", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@county_average_rent", SqlDbType.Float,8)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_shop_front_num;
			parameters[2].Value = model.community_shop_front_in_main_street_num;
			parameters[3].Value = model.community_shop_front_in_collector_street_num;
			parameters[4].Value = model.community_shop_front_in_alley_num;
			parameters[5].Value = model.community_back_street_shop_front_num;
			parameters[6].Value = model.community_shop_front_area;
			parameters[7].Value = model.community_immigrant_shop_front_num;
			parameters[8].Value = model.community_immigrant_shop_front_area;
			parameters[9].Value = model.community_immigrant_run_shop_front_num;
			parameters[10].Value = model.community_immigrant_run_shop_front_area;
			parameters[11].Value = model.community_immigrant_rent_out_shop_front_num;
			parameters[12].Value = model.community_immigrant_rent_out_shop_front_area;
			parameters[13].Value = model.community_immigrant_unused_shop_front_num;
			parameters[14].Value = model.community_immigrant_unused_shop_front_area;
			parameters[15].Value = model.community_shop_front_amount;
			parameters[16].Value = model.community_catering_shop_front_num;
			parameters[17].Value = model.community_accommodation_shop_front_num;
			parameters[18].Value = model.community_commodity_shop_front_num;
			parameters[19].Value = model.community_means_of_production_shop_front_num;
			parameters[20].Value = model.community_automobile_service_shop_front_num;
			parameters[21].Value = model.community_other__shop_front_num;
			parameters[22].Value = model.community_average_rent_of_shop_front;
			parameters[23].Value = model.community_average_rent_time_of_shop_front;
			parameters[24].Value = model.community_average_price_shop_front;
			parameters[25].Value = model.statistics_date;
			parameters[26].Value = model.community_immigrant_sm_shop_front_num;
			parameters[27].Value = model.community_immigrant_sm_shop_front_area;
			parameters[28].Value = model.tcsfunset1;
			parameters[29].Value = model.tcsfunset2;
			parameters[30].Value = model.tcsfunset3;
			parameters[31].Value = model.tcsfunset4;
			parameters[32].Value = model.tcsfunset5;
			parameters[33].Value = model.tcsfunset6;
			parameters[34].Value = model.tcsfunset7;
			parameters[35].Value = model.tcsfunset8;
			parameters[36].Value = model.tcsfunset9;
			parameters[37].Value = model.tcsfunset10;
			parameters[38].Value = model.tcsfunset11;
			parameters[39].Value = model.tcsfunset12;
			parameters[40].Value = model.tcsfunset13;
			parameters[41].Value = model.tcsfunset14;
			parameters[42].Value = model.tcsfunset15;
			parameters[43].Value = model.tcsfunset16;
			parameters[44].Value = model.tcsfunset17;
			parameters[45].Value = model.tcsfunset18;
			parameters[46].Value = model.tcsfunset19;
			parameters[47].Value = model.tcsfunset20;
			parameters[48].Value = model.tcsfunset21;
			parameters[49].Value = model.tcsfunset22;
			parameters[50].Value = model.tcsfunset23;
			parameters[51].Value = model.tcsfunset24;
			parameters[52].Value = model.tcsfunset25;
			parameters[53].Value = model.tcsfunset26;
			parameters[54].Value = model.lock_tables;
			parameters[55].Value = model.check_status;
			parameters[56].Value = model.county_average_rent;

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
		public bool Update(TTG.Model.TTGWeb.community_shop_front model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_shop_front set ");
			strSql.Append("community_shop_front_num=@community_shop_front_num,");
			strSql.Append("community_shop_front_in_main_street_num=@community_shop_front_in_main_street_num,");
			strSql.Append("community_shop_front_in_collector_street_num=@community_shop_front_in_collector_street_num,");
			strSql.Append("community_shop_front_in_alley_num=@community_shop_front_in_alley_num,");
			strSql.Append("community_back_street_shop_front_num=@community_back_street_shop_front_num,");
			strSql.Append("community_shop_front_area=@community_shop_front_area,");
			strSql.Append("community_immigrant_shop_front_num=@community_immigrant_shop_front_num,");
			strSql.Append("community_immigrant_shop_front_area=@community_immigrant_shop_front_area,");
			strSql.Append("community_immigrant_run_shop_front_num=@community_immigrant_run_shop_front_num,");
			strSql.Append("community_immigrant_run_shop_front_area=@community_immigrant_run_shop_front_area,");
			strSql.Append("community_immigrant_rent_out_shop_front_num=@community_immigrant_rent_out_shop_front_num,");
			strSql.Append("community_immigrant_rent_out_shop_front_area=@community_immigrant_rent_out_shop_front_area,");
			strSql.Append("community_immigrant_unused_shop_front_num=@community_immigrant_unused_shop_front_num,");
			strSql.Append("community_immigrant_unused_shop_front_area=@community_immigrant_unused_shop_front_area,");
			strSql.Append("community_shop_front_amount=@community_shop_front_amount,");
			strSql.Append("community_catering_shop_front_num=@community_catering_shop_front_num,");
			strSql.Append("community_accommodation_shop_front_num=@community_accommodation_shop_front_num,");
			strSql.Append("community_commodity_shop_front_num=@community_commodity_shop_front_num,");
			strSql.Append("community_means_of_production_shop_front_num=@community_means_of_production_shop_front_num,");
			strSql.Append("community_automobile_service_shop_front_num=@community_automobile_service_shop_front_num,");
			strSql.Append("community_other__shop_front_num=@community_other__shop_front_num,");
			strSql.Append("community_average_rent_of_shop_front=@community_average_rent_of_shop_front,");
			strSql.Append("community_average_rent_time_of_shop_front=@community_average_rent_time_of_shop_front,");
			strSql.Append("community_average_price_shop_front=@community_average_price_shop_front,");
			strSql.Append("community_immigrant_sm_shop_front_num=@community_immigrant_sm_shop_front_num,");
			strSql.Append("community_immigrant_sm_shop_front_area=@community_immigrant_sm_shop_front_area,");
			strSql.Append("tcsfunset1=@tcsfunset1,");
			strSql.Append("tcsfunset2=@tcsfunset2,");
			strSql.Append("tcsfunset3=@tcsfunset3,");
			strSql.Append("tcsfunset4=@tcsfunset4,");
			strSql.Append("tcsfunset5=@tcsfunset5,");
			strSql.Append("tcsfunset6=@tcsfunset6,");
			strSql.Append("tcsfunset7=@tcsfunset7,");
			strSql.Append("tcsfunset8=@tcsfunset8,");
			strSql.Append("tcsfunset9=@tcsfunset9,");
			strSql.Append("tcsfunset10=@tcsfunset10,");
			strSql.Append("tcsfunset11=@tcsfunset11,");
			strSql.Append("tcsfunset12=@tcsfunset12,");
			strSql.Append("tcsfunset13=@tcsfunset13,");
			strSql.Append("tcsfunset14=@tcsfunset14,");
			strSql.Append("tcsfunset15=@tcsfunset15,");
			strSql.Append("tcsfunset16=@tcsfunset16,");
			strSql.Append("tcsfunset17=@tcsfunset17,");
			strSql.Append("tcsfunset18=@tcsfunset18,");
			strSql.Append("tcsfunset19=@tcsfunset19,");
			strSql.Append("tcsfunset20=@tcsfunset20,");
			strSql.Append("tcsfunset21=@tcsfunset21,");
			strSql.Append("tcsfunset22=@tcsfunset22,");
			strSql.Append("tcsfunset23=@tcsfunset23,");
			strSql.Append("tcsfunset24=@tcsfunset24,");
			strSql.Append("tcsfunset25=@tcsfunset25,");
			strSql.Append("tcsfunset26=@tcsfunset26,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("county_average_rent=@county_average_rent");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_shop_front_in_main_street_num", SqlDbType.Int,4),
					new SqlParameter("@community_shop_front_in_collector_street_num", SqlDbType.Int,4),
					new SqlParameter("@community_shop_front_in_alley_num", SqlDbType.Int,4),
					new SqlParameter("@community_back_street_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_shop_front_area", SqlDbType.Float,8),
					new SqlParameter("@community_immigrant_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_immigrant_shop_front_area", SqlDbType.Float,8),
					new SqlParameter("@community_immigrant_run_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_immigrant_run_shop_front_area", SqlDbType.Float,8),
					new SqlParameter("@community_immigrant_rent_out_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_immigrant_rent_out_shop_front_area", SqlDbType.Float,8),
					new SqlParameter("@community_immigrant_unused_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_immigrant_unused_shop_front_area", SqlDbType.Float,8),
					new SqlParameter("@community_shop_front_amount", SqlDbType.Int,4),
					new SqlParameter("@community_catering_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_accommodation_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_commodity_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_means_of_production_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_automobile_service_shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_other__shop_front_num", SqlDbType.Int,4),
					new SqlParameter("@community_average_rent_of_shop_front", SqlDbType.Float,8),
					new SqlParameter("@community_average_rent_time_of_shop_front", SqlDbType.VarChar,50),
					new SqlParameter("@community_average_price_shop_front", SqlDbType.Float,8),
					new SqlParameter("@community_immigrant_sm_shop_front_num", SqlDbType.Float,8),
					new SqlParameter("@community_immigrant_sm_shop_front_area", SqlDbType.Float,8),
					new SqlParameter("@tcsfunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset21", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset22", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset23", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset24", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset25", SqlDbType.VarChar,50),
					new SqlParameter("@tcsfunset26", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@county_average_rent", SqlDbType.Float,8),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_shop_front_num;
			parameters[1].Value = model.community_shop_front_in_main_street_num;
			parameters[2].Value = model.community_shop_front_in_collector_street_num;
			parameters[3].Value = model.community_shop_front_in_alley_num;
			parameters[4].Value = model.community_back_street_shop_front_num;
			parameters[5].Value = model.community_shop_front_area;
			parameters[6].Value = model.community_immigrant_shop_front_num;
			parameters[7].Value = model.community_immigrant_shop_front_area;
			parameters[8].Value = model.community_immigrant_run_shop_front_num;
			parameters[9].Value = model.community_immigrant_run_shop_front_area;
			parameters[10].Value = model.community_immigrant_rent_out_shop_front_num;
			parameters[11].Value = model.community_immigrant_rent_out_shop_front_area;
			parameters[12].Value = model.community_immigrant_unused_shop_front_num;
			parameters[13].Value = model.community_immigrant_unused_shop_front_area;
			parameters[14].Value = model.community_shop_front_amount;
			parameters[15].Value = model.community_catering_shop_front_num;
			parameters[16].Value = model.community_accommodation_shop_front_num;
			parameters[17].Value = model.community_commodity_shop_front_num;
			parameters[18].Value = model.community_means_of_production_shop_front_num;
			parameters[19].Value = model.community_automobile_service_shop_front_num;
			parameters[20].Value = model.community_other__shop_front_num;
			parameters[21].Value = model.community_average_rent_of_shop_front;
			parameters[22].Value = model.community_average_rent_time_of_shop_front;
			parameters[23].Value = model.community_average_price_shop_front;
			parameters[24].Value = model.community_immigrant_sm_shop_front_num;
			parameters[25].Value = model.community_immigrant_sm_shop_front_area;
			parameters[26].Value = model.tcsfunset1;
			parameters[27].Value = model.tcsfunset2;
			parameters[28].Value = model.tcsfunset3;
			parameters[29].Value = model.tcsfunset4;
			parameters[30].Value = model.tcsfunset5;
			parameters[31].Value = model.tcsfunset6;
			parameters[32].Value = model.tcsfunset7;
			parameters[33].Value = model.tcsfunset8;
			parameters[34].Value = model.tcsfunset9;
			parameters[35].Value = model.tcsfunset10;
			parameters[36].Value = model.tcsfunset11;
			parameters[37].Value = model.tcsfunset12;
			parameters[38].Value = model.tcsfunset13;
			parameters[39].Value = model.tcsfunset14;
			parameters[40].Value = model.tcsfunset15;
			parameters[41].Value = model.tcsfunset16;
			parameters[42].Value = model.tcsfunset17;
			parameters[43].Value = model.tcsfunset18;
			parameters[44].Value = model.tcsfunset19;
			parameters[45].Value = model.tcsfunset20;
			parameters[46].Value = model.tcsfunset21;
			parameters[47].Value = model.tcsfunset22;
			parameters[48].Value = model.tcsfunset23;
			parameters[49].Value = model.tcsfunset24;
			parameters[50].Value = model.tcsfunset25;
			parameters[51].Value = model.tcsfunset26;
			parameters[52].Value = model.lock_tables;
			parameters[53].Value = model.check_status;
			parameters[54].Value = model.county_average_rent;
			parameters[55].Value = model.community_id;
			parameters[56].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_shop_front ");
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
		public TTG.Model.TTGWeb.community_shop_front GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_shop_front_num,community_shop_front_in_main_street_num,community_shop_front_in_collector_street_num,community_shop_front_in_alley_num,community_back_street_shop_front_num,community_shop_front_area,community_immigrant_shop_front_num,community_immigrant_shop_front_area,community_immigrant_run_shop_front_num,community_immigrant_run_shop_front_area,community_immigrant_rent_out_shop_front_num,community_immigrant_rent_out_shop_front_area,community_immigrant_unused_shop_front_num,community_immigrant_unused_shop_front_area,community_shop_front_amount,community_catering_shop_front_num,community_accommodation_shop_front_num,community_commodity_shop_front_num,community_means_of_production_shop_front_num,community_automobile_service_shop_front_num,community_other__shop_front_num,community_average_rent_of_shop_front,community_average_rent_time_of_shop_front,community_average_price_shop_front,statistics_date,community_immigrant_sm_shop_front_num,community_immigrant_sm_shop_front_area,tcsfunset1,tcsfunset2,tcsfunset3,tcsfunset4,tcsfunset5,tcsfunset6,tcsfunset7,tcsfunset8,tcsfunset9,tcsfunset10,tcsfunset11,tcsfunset12,tcsfunset13,tcsfunset14,tcsfunset15,tcsfunset16,tcsfunset17,tcsfunset18,tcsfunset19,tcsfunset20,tcsfunset21,tcsfunset22,tcsfunset23,tcsfunset24,tcsfunset25,tcsfunset26,lock_tables,check_status,county_average_rent from T_community_shop_front ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_shop_front model=new TTG.Model.TTGWeb.community_shop_front();
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
		public TTG.Model.TTGWeb.community_shop_front DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_shop_front model=new TTG.Model.TTGWeb.community_shop_front();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_shop_front_num"]!=null && row["community_shop_front_num"].ToString()!="")
				{
					model.community_shop_front_num=int.Parse(row["community_shop_front_num"].ToString());
				}
				if(row["community_shop_front_in_main_street_num"]!=null && row["community_shop_front_in_main_street_num"].ToString()!="")
				{
					model.community_shop_front_in_main_street_num=int.Parse(row["community_shop_front_in_main_street_num"].ToString());
				}
				if(row["community_shop_front_in_collector_street_num"]!=null && row["community_shop_front_in_collector_street_num"].ToString()!="")
				{
					model.community_shop_front_in_collector_street_num=int.Parse(row["community_shop_front_in_collector_street_num"].ToString());
				}
				if(row["community_shop_front_in_alley_num"]!=null && row["community_shop_front_in_alley_num"].ToString()!="")
				{
					model.community_shop_front_in_alley_num=int.Parse(row["community_shop_front_in_alley_num"].ToString());
				}
				if(row["community_back_street_shop_front_num"]!=null && row["community_back_street_shop_front_num"].ToString()!="")
				{
					model.community_back_street_shop_front_num=int.Parse(row["community_back_street_shop_front_num"].ToString());
				}
				if(row["community_shop_front_area"]!=null && row["community_shop_front_area"].ToString()!="")
				{
					model.community_shop_front_area=decimal.Parse(row["community_shop_front_area"].ToString());
				}
				if(row["community_immigrant_shop_front_num"]!=null && row["community_immigrant_shop_front_num"].ToString()!="")
				{
					model.community_immigrant_shop_front_num=int.Parse(row["community_immigrant_shop_front_num"].ToString());
				}
				if(row["community_immigrant_shop_front_area"]!=null && row["community_immigrant_shop_front_area"].ToString()!="")
				{
					model.community_immigrant_shop_front_area=decimal.Parse(row["community_immigrant_shop_front_area"].ToString());
				}
				if(row["community_immigrant_run_shop_front_num"]!=null && row["community_immigrant_run_shop_front_num"].ToString()!="")
				{
					model.community_immigrant_run_shop_front_num=int.Parse(row["community_immigrant_run_shop_front_num"].ToString());
				}
				if(row["community_immigrant_run_shop_front_area"]!=null && row["community_immigrant_run_shop_front_area"].ToString()!="")
				{
					model.community_immigrant_run_shop_front_area=decimal.Parse(row["community_immigrant_run_shop_front_area"].ToString());
				}
				if(row["community_immigrant_rent_out_shop_front_num"]!=null && row["community_immigrant_rent_out_shop_front_num"].ToString()!="")
				{
					model.community_immigrant_rent_out_shop_front_num=int.Parse(row["community_immigrant_rent_out_shop_front_num"].ToString());
				}
				if(row["community_immigrant_rent_out_shop_front_area"]!=null && row["community_immigrant_rent_out_shop_front_area"].ToString()!="")
				{
					model.community_immigrant_rent_out_shop_front_area=decimal.Parse(row["community_immigrant_rent_out_shop_front_area"].ToString());
				}
				if(row["community_immigrant_unused_shop_front_num"]!=null && row["community_immigrant_unused_shop_front_num"].ToString()!="")
				{
					model.community_immigrant_unused_shop_front_num=int.Parse(row["community_immigrant_unused_shop_front_num"].ToString());
				}
				if(row["community_immigrant_unused_shop_front_area"]!=null && row["community_immigrant_unused_shop_front_area"].ToString()!="")
				{
					model.community_immigrant_unused_shop_front_area=decimal.Parse(row["community_immigrant_unused_shop_front_area"].ToString());
				}
				if(row["community_shop_front_amount"]!=null && row["community_shop_front_amount"].ToString()!="")
				{
					model.community_shop_front_amount=int.Parse(row["community_shop_front_amount"].ToString());
				}
				if(row["community_catering_shop_front_num"]!=null && row["community_catering_shop_front_num"].ToString()!="")
				{
					model.community_catering_shop_front_num=int.Parse(row["community_catering_shop_front_num"].ToString());
				}
				if(row["community_accommodation_shop_front_num"]!=null && row["community_accommodation_shop_front_num"].ToString()!="")
				{
					model.community_accommodation_shop_front_num=int.Parse(row["community_accommodation_shop_front_num"].ToString());
				}
				if(row["community_commodity_shop_front_num"]!=null && row["community_commodity_shop_front_num"].ToString()!="")
				{
					model.community_commodity_shop_front_num=int.Parse(row["community_commodity_shop_front_num"].ToString());
				}
				if(row["community_means_of_production_shop_front_num"]!=null && row["community_means_of_production_shop_front_num"].ToString()!="")
				{
					model.community_means_of_production_shop_front_num=int.Parse(row["community_means_of_production_shop_front_num"].ToString());
				}
				if(row["community_automobile_service_shop_front_num"]!=null && row["community_automobile_service_shop_front_num"].ToString()!="")
				{
					model.community_automobile_service_shop_front_num=int.Parse(row["community_automobile_service_shop_front_num"].ToString());
				}
				if(row["community_other__shop_front_num"]!=null && row["community_other__shop_front_num"].ToString()!="")
				{
					model.community_other__shop_front_num=int.Parse(row["community_other__shop_front_num"].ToString());
				}
				if(row["community_average_rent_of_shop_front"]!=null && row["community_average_rent_of_shop_front"].ToString()!="")
				{
					model.community_average_rent_of_shop_front=decimal.Parse(row["community_average_rent_of_shop_front"].ToString());
				}
				if(row["community_average_rent_time_of_shop_front"]!=null)
				{
					model.community_average_rent_time_of_shop_front=row["community_average_rent_time_of_shop_front"].ToString();
				}
				if(row["community_average_price_shop_front"]!=null && row["community_average_price_shop_front"].ToString()!="")
				{
					model.community_average_price_shop_front=decimal.Parse(row["community_average_price_shop_front"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["community_immigrant_sm_shop_front_num"]!=null && row["community_immigrant_sm_shop_front_num"].ToString()!="")
				{
					model.community_immigrant_sm_shop_front_num=decimal.Parse(row["community_immigrant_sm_shop_front_num"].ToString());
				}
				if(row["community_immigrant_sm_shop_front_area"]!=null && row["community_immigrant_sm_shop_front_area"].ToString()!="")
				{
					model.community_immigrant_sm_shop_front_area=decimal.Parse(row["community_immigrant_sm_shop_front_area"].ToString());
				}
				if(row["tcsfunset1"]!=null)
				{
					model.tcsfunset1=row["tcsfunset1"].ToString();
				}
				if(row["tcsfunset2"]!=null)
				{
					model.tcsfunset2=row["tcsfunset2"].ToString();
				}
				if(row["tcsfunset3"]!=null)
				{
					model.tcsfunset3=row["tcsfunset3"].ToString();
				}
				if(row["tcsfunset4"]!=null)
				{
					model.tcsfunset4=row["tcsfunset4"].ToString();
				}
				if(row["tcsfunset5"]!=null)
				{
					model.tcsfunset5=row["tcsfunset5"].ToString();
				}
				if(row["tcsfunset6"]!=null)
				{
					model.tcsfunset6=row["tcsfunset6"].ToString();
				}
				if(row["tcsfunset7"]!=null)
				{
					model.tcsfunset7=row["tcsfunset7"].ToString();
				}
				if(row["tcsfunset8"]!=null)
				{
					model.tcsfunset8=row["tcsfunset8"].ToString();
				}
				if(row["tcsfunset9"]!=null)
				{
					model.tcsfunset9=row["tcsfunset9"].ToString();
				}
				if(row["tcsfunset10"]!=null)
				{
					model.tcsfunset10=row["tcsfunset10"].ToString();
				}
				if(row["tcsfunset11"]!=null)
				{
					model.tcsfunset11=row["tcsfunset11"].ToString();
				}
				if(row["tcsfunset12"]!=null)
				{
					model.tcsfunset12=row["tcsfunset12"].ToString();
				}
				if(row["tcsfunset13"]!=null)
				{
					model.tcsfunset13=row["tcsfunset13"].ToString();
				}
				if(row["tcsfunset14"]!=null)
				{
					model.tcsfunset14=row["tcsfunset14"].ToString();
				}
				if(row["tcsfunset15"]!=null)
				{
					model.tcsfunset15=row["tcsfunset15"].ToString();
				}
				if(row["tcsfunset16"]!=null)
				{
					model.tcsfunset16=row["tcsfunset16"].ToString();
				}
				if(row["tcsfunset17"]!=null)
				{
					model.tcsfunset17=row["tcsfunset17"].ToString();
				}
				if(row["tcsfunset18"]!=null)
				{
					model.tcsfunset18=row["tcsfunset18"].ToString();
				}
				if(row["tcsfunset19"]!=null)
				{
					model.tcsfunset19=row["tcsfunset19"].ToString();
				}
				if(row["tcsfunset20"]!=null)
				{
					model.tcsfunset20=row["tcsfunset20"].ToString();
				}
				if(row["tcsfunset21"]!=null)
				{
					model.tcsfunset21=row["tcsfunset21"].ToString();
				}
				if(row["tcsfunset22"]!=null)
				{
					model.tcsfunset22=row["tcsfunset22"].ToString();
				}
				if(row["tcsfunset23"]!=null)
				{
					model.tcsfunset23=row["tcsfunset23"].ToString();
				}
				if(row["tcsfunset24"]!=null)
				{
					model.tcsfunset24=row["tcsfunset24"].ToString();
				}
				if(row["tcsfunset25"]!=null)
				{
					model.tcsfunset25=row["tcsfunset25"].ToString();
				}
				if(row["tcsfunset26"]!=null)
				{
					model.tcsfunset26=row["tcsfunset26"].ToString();
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["county_average_rent"]!=null && row["county_average_rent"].ToString()!="")
				{
					model.county_average_rent=decimal.Parse(row["county_average_rent"].ToString());
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
			strSql.Append("select community_id,community_shop_front_num,community_shop_front_in_main_street_num,community_shop_front_in_collector_street_num,community_shop_front_in_alley_num,community_back_street_shop_front_num,community_shop_front_area,community_immigrant_shop_front_num,community_immigrant_shop_front_area,community_immigrant_run_shop_front_num,community_immigrant_run_shop_front_area,community_immigrant_rent_out_shop_front_num,community_immigrant_rent_out_shop_front_area,community_immigrant_unused_shop_front_num,community_immigrant_unused_shop_front_area,community_shop_front_amount,community_catering_shop_front_num,community_accommodation_shop_front_num,community_commodity_shop_front_num,community_means_of_production_shop_front_num,community_automobile_service_shop_front_num,community_other__shop_front_num,community_average_rent_of_shop_front,community_average_rent_time_of_shop_front,community_average_price_shop_front,statistics_date,community_immigrant_sm_shop_front_num,community_immigrant_sm_shop_front_area,tcsfunset1,tcsfunset2,tcsfunset3,tcsfunset4,tcsfunset5,tcsfunset6,tcsfunset7,tcsfunset8,tcsfunset9,tcsfunset10,tcsfunset11,tcsfunset12,tcsfunset13,tcsfunset14,tcsfunset15,tcsfunset16,tcsfunset17,tcsfunset18,tcsfunset19,tcsfunset20,tcsfunset21,tcsfunset22,tcsfunset23,tcsfunset24,tcsfunset25,tcsfunset26,lock_tables,check_status,county_average_rent ");
			strSql.Append(" FROM T_community_shop_front ");
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
			strSql.Append(" community_id,community_shop_front_num,community_shop_front_in_main_street_num,community_shop_front_in_collector_street_num,community_shop_front_in_alley_num,community_back_street_shop_front_num,community_shop_front_area,community_immigrant_shop_front_num,community_immigrant_shop_front_area,community_immigrant_run_shop_front_num,community_immigrant_run_shop_front_area,community_immigrant_rent_out_shop_front_num,community_immigrant_rent_out_shop_front_area,community_immigrant_unused_shop_front_num,community_immigrant_unused_shop_front_area,community_shop_front_amount,community_catering_shop_front_num,community_accommodation_shop_front_num,community_commodity_shop_front_num,community_means_of_production_shop_front_num,community_automobile_service_shop_front_num,community_other__shop_front_num,community_average_rent_of_shop_front,community_average_rent_time_of_shop_front,community_average_price_shop_front,statistics_date,community_immigrant_sm_shop_front_num,community_immigrant_sm_shop_front_area,tcsfunset1,tcsfunset2,tcsfunset3,tcsfunset4,tcsfunset5,tcsfunset6,tcsfunset7,tcsfunset8,tcsfunset9,tcsfunset10,tcsfunset11,tcsfunset12,tcsfunset13,tcsfunset14,tcsfunset15,tcsfunset16,tcsfunset17,tcsfunset18,tcsfunset19,tcsfunset20,tcsfunset21,tcsfunset22,tcsfunset23,tcsfunset24,tcsfunset25,tcsfunset26,lock_tables,check_status,county_average_rent ");
			strSql.Append(" FROM T_community_shop_front ");
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
			strSql.Append("select count(1) FROM T_community_shop_front ");
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
			strSql.Append(")AS Row, T.*  from T_community_shop_front T ");
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
			parameters[0].Value = "T_community_shop_front";
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

