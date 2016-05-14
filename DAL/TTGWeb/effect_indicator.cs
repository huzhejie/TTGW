using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:effect_indicator
	/// </summary>
	public partial class effect_indicator
	{
		public effect_indicator()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_effect_indicator");
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
		public bool Add(TTG.Model.TTGWeb.effect_indicator model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_effect_indicator(");
			strSql.Append("community_id,statistics_date,structure_safe_good_rate,roof_good_rate,wall_good_rate,slope_safe_rate,concil_house_validate,road_link_degree,road_good_degree,traffic_validate,water_capcity_degree,water_pipe_net_good_degree,one_hou_one_water_meter_rate,water_supply_validate,elec_capcity_degree,elec_wire_safe_degree,one_hou_one_elec_meter_rate,elec_supply_validate,road_light_suff_degree,passway_light_suff_degree,light_validate,outdoors_ff_good_rate,indoors_ff_good_rate,ff_way_good_rate,ff_validate,basic_facility_validate,refuse_collect_rate,toilet_cover_degree,sanitation_validate,sewage_collect_rate,drain_safe_degree,drain_validate,green_validate,environment_validate,service_gfs_good_rate,kindergarten_good_rate,medical_good_rate,parking_good_rate,CVS_good_rate,vegetable_market_good_rate,commerce_validate,cul_fitness_facility_good_rate,older_facility_good_rate,public_service_good_rate,shop_front_use_rate,shop_front_rent_level,shop_validate,community_validate,indicator1,indicator2,indicator3,indicator4,indicator5,indicator6,indicator7,indicator8,indicator9,indicator10,indicator11,indicator12,indicator13,indicator14,indicator15,indicator16,indicator17,indicator18,indicator19,indicator20,indicator21,indicator22,indicator23,indicator24,indicator25,indicator26,indicator27,indicator28,indicator29,indicator30,indicator31,indicator32,indicator33,indicator34,indicator35,indicator36,indicator37,indicator38,indicator39,indicator40,indicator41,indicator42,indicator43,indicator44,indicator45,indicator46,lock_tables,labor_employment_rate,disposable_money_per_people)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@statistics_date,@structure_safe_good_rate,@roof_good_rate,@wall_good_rate,@slope_safe_rate,@concil_house_validate,@road_link_degree,@road_good_degree,@traffic_validate,@water_capcity_degree,@water_pipe_net_good_degree,@one_hou_one_water_meter_rate,@water_supply_validate,@elec_capcity_degree,@elec_wire_safe_degree,@one_hou_one_elec_meter_rate,@elec_supply_validate,@road_light_suff_degree,@passway_light_suff_degree,@light_validate,@outdoors_ff_good_rate,@indoors_ff_good_rate,@ff_way_good_rate,@ff_validate,@basic_facility_validate,@refuse_collect_rate,@toilet_cover_degree,@sanitation_validate,@sewage_collect_rate,@drain_safe_degree,@drain_validate,@green_validate,@environment_validate,@service_gfs_good_rate,@kindergarten_good_rate,@medical_good_rate,@parking_good_rate,@CVS_good_rate,@vegetable_market_good_rate,@commerce_validate,@cul_fitness_facility_good_rate,@older_facility_good_rate,@public_service_good_rate,@shop_front_use_rate,@shop_front_rent_level,@shop_validate,@community_validate,@indicator1,@indicator2,@indicator3,@indicator4,@indicator5,@indicator6,@indicator7,@indicator8,@indicator9,@indicator10,@indicator11,@indicator12,@indicator13,@indicator14,@indicator15,@indicator16,@indicator17,@indicator18,@indicator19,@indicator20,@indicator21,@indicator22,@indicator23,@indicator24,@indicator25,@indicator26,@indicator27,@indicator28,@indicator29,@indicator30,@indicator31,@indicator32,@indicator33,@indicator34,@indicator35,@indicator36,@indicator37,@indicator38,@indicator39,@indicator40,@indicator41,@indicator42,@indicator43,@indicator44,@indicator45,@indicator46,@lock_tables,@labor_employment_rate,@disposable_money_per_people)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@structure_safe_good_rate", SqlDbType.Float,8),
					new SqlParameter("@roof_good_rate", SqlDbType.Float,8),
					new SqlParameter("@wall_good_rate", SqlDbType.Float,8),
					new SqlParameter("@slope_safe_rate", SqlDbType.Float,8),
					new SqlParameter("@concil_house_validate", SqlDbType.Float,8),
					new SqlParameter("@road_link_degree", SqlDbType.Float,8),
					new SqlParameter("@road_good_degree", SqlDbType.Float,8),
					new SqlParameter("@traffic_validate", SqlDbType.Float,8),
					new SqlParameter("@water_capcity_degree", SqlDbType.Float,8),
					new SqlParameter("@water_pipe_net_good_degree", SqlDbType.Float,8),
					new SqlParameter("@one_hou_one_water_meter_rate", SqlDbType.Float,8),
					new SqlParameter("@water_supply_validate", SqlDbType.Float,8),
					new SqlParameter("@elec_capcity_degree", SqlDbType.Float,8),
					new SqlParameter("@elec_wire_safe_degree", SqlDbType.Float,8),
					new SqlParameter("@one_hou_one_elec_meter_rate", SqlDbType.Float,8),
					new SqlParameter("@elec_supply_validate", SqlDbType.Float,8),
					new SqlParameter("@road_light_suff_degree", SqlDbType.Float,8),
					new SqlParameter("@passway_light_suff_degree", SqlDbType.Float,8),
					new SqlParameter("@light_validate", SqlDbType.Float,8),
					new SqlParameter("@outdoors_ff_good_rate", SqlDbType.Float,8),
					new SqlParameter("@indoors_ff_good_rate", SqlDbType.Float,8),
					new SqlParameter("@ff_way_good_rate", SqlDbType.Float,8),
					new SqlParameter("@ff_validate", SqlDbType.Float,8),
					new SqlParameter("@basic_facility_validate", SqlDbType.Float,8),
					new SqlParameter("@refuse_collect_rate", SqlDbType.Float,8),
					new SqlParameter("@toilet_cover_degree", SqlDbType.Float,8),
					new SqlParameter("@sanitation_validate", SqlDbType.Float,8),
					new SqlParameter("@sewage_collect_rate", SqlDbType.Float,8),
					new SqlParameter("@drain_safe_degree", SqlDbType.Float,8),
					new SqlParameter("@drain_validate", SqlDbType.Float,8),
					new SqlParameter("@green_validate", SqlDbType.Float,8),
					new SqlParameter("@environment_validate", SqlDbType.Float,8),
					new SqlParameter("@service_gfs_good_rate", SqlDbType.Float,8),
					new SqlParameter("@kindergarten_good_rate", SqlDbType.Float,8),
					new SqlParameter("@medical_good_rate", SqlDbType.Float,8),
					new SqlParameter("@parking_good_rate", SqlDbType.Float,8),
					new SqlParameter("@CVS_good_rate", SqlDbType.Float,8),
					new SqlParameter("@vegetable_market_good_rate", SqlDbType.Float,8),
					new SqlParameter("@commerce_validate", SqlDbType.Float,8),
					new SqlParameter("@cul_fitness_facility_good_rate", SqlDbType.Float,8),
					new SqlParameter("@older_facility_good_rate", SqlDbType.Float,8),
					new SqlParameter("@public_service_good_rate", SqlDbType.Float,8),
					new SqlParameter("@shop_front_use_rate", SqlDbType.Float,8),
					new SqlParameter("@shop_front_rent_level", SqlDbType.Float,8),
					new SqlParameter("@shop_validate", SqlDbType.Float,8),
					new SqlParameter("@community_validate", SqlDbType.Float,8),
					new SqlParameter("@indicator1", SqlDbType.Float,8),
					new SqlParameter("@indicator2", SqlDbType.Float,8),
					new SqlParameter("@indicator3", SqlDbType.Float,8),
					new SqlParameter("@indicator4", SqlDbType.Float,8),
					new SqlParameter("@indicator5", SqlDbType.Float,8),
					new SqlParameter("@indicator6", SqlDbType.Float,8),
					new SqlParameter("@indicator7", SqlDbType.Float,8),
					new SqlParameter("@indicator8", SqlDbType.Float,8),
					new SqlParameter("@indicator9", SqlDbType.Float,8),
					new SqlParameter("@indicator10", SqlDbType.Float,8),
					new SqlParameter("@indicator11", SqlDbType.Float,8),
					new SqlParameter("@indicator12", SqlDbType.Float,8),
					new SqlParameter("@indicator13", SqlDbType.Float,8),
					new SqlParameter("@indicator14", SqlDbType.Float,8),
					new SqlParameter("@indicator15", SqlDbType.Float,8),
					new SqlParameter("@indicator16", SqlDbType.Float,8),
					new SqlParameter("@indicator17", SqlDbType.Float,8),
					new SqlParameter("@indicator18", SqlDbType.Float,8),
					new SqlParameter("@indicator19", SqlDbType.Float,8),
					new SqlParameter("@indicator20", SqlDbType.Float,8),
					new SqlParameter("@indicator21", SqlDbType.Float,8),
					new SqlParameter("@indicator22", SqlDbType.Float,8),
					new SqlParameter("@indicator23", SqlDbType.Float,8),
					new SqlParameter("@indicator24", SqlDbType.Float,8),
					new SqlParameter("@indicator25", SqlDbType.Float,8),
					new SqlParameter("@indicator26", SqlDbType.Float,8),
					new SqlParameter("@indicator27", SqlDbType.Float,8),
					new SqlParameter("@indicator28", SqlDbType.Float,8),
					new SqlParameter("@indicator29", SqlDbType.Float,8),
					new SqlParameter("@indicator30", SqlDbType.Float,8),
					new SqlParameter("@indicator31", SqlDbType.Float,8),
					new SqlParameter("@indicator32", SqlDbType.Float,8),
					new SqlParameter("@indicator33", SqlDbType.Float,8),
					new SqlParameter("@indicator34", SqlDbType.Float,8),
					new SqlParameter("@indicator35", SqlDbType.Float,8),
					new SqlParameter("@indicator36", SqlDbType.Float,8),
					new SqlParameter("@indicator37", SqlDbType.Float,8),
					new SqlParameter("@indicator38", SqlDbType.Float,8),
					new SqlParameter("@indicator39", SqlDbType.Float,8),
					new SqlParameter("@indicator40", SqlDbType.Float,8),
					new SqlParameter("@indicator41", SqlDbType.Float,8),
					new SqlParameter("@indicator42", SqlDbType.Float,8),
					new SqlParameter("@indicator43", SqlDbType.Float,8),
					new SqlParameter("@indicator44", SqlDbType.Float,8),
					new SqlParameter("@indicator45", SqlDbType.Float,8),
					new SqlParameter("@indicator46", SqlDbType.Float,8),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@labor_employment_rate", SqlDbType.Float,8),
					new SqlParameter("@disposable_money_per_people", SqlDbType.Float,8)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.statistics_date;
			parameters[2].Value = model.structure_safe_good_rate;
			parameters[3].Value = model.roof_good_rate;
			parameters[4].Value = model.wall_good_rate;
			parameters[5].Value = model.slope_safe_rate;
			parameters[6].Value = model.concil_house_validate;
			parameters[7].Value = model.road_link_degree;
			parameters[8].Value = model.road_good_degree;
			parameters[9].Value = model.traffic_validate;
			parameters[10].Value = model.water_capcity_degree;
			parameters[11].Value = model.water_pipe_net_good_degree;
			parameters[12].Value = model.one_hou_one_water_meter_rate;
			parameters[13].Value = model.water_supply_validate;
			parameters[14].Value = model.elec_capcity_degree;
			parameters[15].Value = model.elec_wire_safe_degree;
			parameters[16].Value = model.one_hou_one_elec_meter_rate;
			parameters[17].Value = model.elec_supply_validate;
			parameters[18].Value = model.road_light_suff_degree;
			parameters[19].Value = model.passway_light_suff_degree;
			parameters[20].Value = model.light_validate;
			parameters[21].Value = model.outdoors_ff_good_rate;
			parameters[22].Value = model.indoors_ff_good_rate;
			parameters[23].Value = model.ff_way_good_rate;
			parameters[24].Value = model.ff_validate;
			parameters[25].Value = model.basic_facility_validate;
			parameters[26].Value = model.refuse_collect_rate;
			parameters[27].Value = model.toilet_cover_degree;
			parameters[28].Value = model.sanitation_validate;
			parameters[29].Value = model.sewage_collect_rate;
			parameters[30].Value = model.drain_safe_degree;
			parameters[31].Value = model.drain_validate;
			parameters[32].Value = model.green_validate;
			parameters[33].Value = model.environment_validate;
			parameters[34].Value = model.service_gfs_good_rate;
			parameters[35].Value = model.kindergarten_good_rate;
			parameters[36].Value = model.medical_good_rate;
			parameters[37].Value = model.parking_good_rate;
			parameters[38].Value = model.CVS_good_rate;
			parameters[39].Value = model.vegetable_market_good_rate;
			parameters[40].Value = model.commerce_validate;
			parameters[41].Value = model.cul_fitness_facility_good_rate;
			parameters[42].Value = model.older_facility_good_rate;
			parameters[43].Value = model.public_service_good_rate;
			parameters[44].Value = model.shop_front_use_rate;
			parameters[45].Value = model.shop_front_rent_level;
			parameters[46].Value = model.shop_validate;
			parameters[47].Value = model.community_validate;
			parameters[48].Value = model.indicator1;
			parameters[49].Value = model.indicator2;
			parameters[50].Value = model.indicator3;
			parameters[51].Value = model.indicator4;
			parameters[52].Value = model.indicator5;
			parameters[53].Value = model.indicator6;
			parameters[54].Value = model.indicator7;
			parameters[55].Value = model.indicator8;
			parameters[56].Value = model.indicator9;
			parameters[57].Value = model.indicator10;
			parameters[58].Value = model.indicator11;
			parameters[59].Value = model.indicator12;
			parameters[60].Value = model.indicator13;
			parameters[61].Value = model.indicator14;
			parameters[62].Value = model.indicator15;
			parameters[63].Value = model.indicator16;
			parameters[64].Value = model.indicator17;
			parameters[65].Value = model.indicator18;
			parameters[66].Value = model.indicator19;
			parameters[67].Value = model.indicator20;
			parameters[68].Value = model.indicator21;
			parameters[69].Value = model.indicator22;
			parameters[70].Value = model.indicator23;
			parameters[71].Value = model.indicator24;
			parameters[72].Value = model.indicator25;
			parameters[73].Value = model.indicator26;
			parameters[74].Value = model.indicator27;
			parameters[75].Value = model.indicator28;
			parameters[76].Value = model.indicator29;
			parameters[77].Value = model.indicator30;
			parameters[78].Value = model.indicator31;
			parameters[79].Value = model.indicator32;
			parameters[80].Value = model.indicator33;
			parameters[81].Value = model.indicator34;
			parameters[82].Value = model.indicator35;
			parameters[83].Value = model.indicator36;
			parameters[84].Value = model.indicator37;
			parameters[85].Value = model.indicator38;
			parameters[86].Value = model.indicator39;
			parameters[87].Value = model.indicator40;
			parameters[88].Value = model.indicator41;
			parameters[89].Value = model.indicator42;
			parameters[90].Value = model.indicator43;
			parameters[91].Value = model.indicator44;
			parameters[92].Value = model.indicator45;
			parameters[93].Value = model.indicator46;
			parameters[94].Value = model.lock_tables;
			parameters[95].Value = model.labor_employment_rate;
			parameters[96].Value = model.disposable_money_per_people;

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
		public bool Update(TTG.Model.TTGWeb.effect_indicator model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_effect_indicator set ");
			strSql.Append("structure_safe_good_rate=@structure_safe_good_rate,");
			strSql.Append("roof_good_rate=@roof_good_rate,");
			strSql.Append("wall_good_rate=@wall_good_rate,");
			strSql.Append("slope_safe_rate=@slope_safe_rate,");
			strSql.Append("concil_house_validate=@concil_house_validate,");
			strSql.Append("road_link_degree=@road_link_degree,");
			strSql.Append("road_good_degree=@road_good_degree,");
			strSql.Append("traffic_validate=@traffic_validate,");
			strSql.Append("water_capcity_degree=@water_capcity_degree,");
			strSql.Append("water_pipe_net_good_degree=@water_pipe_net_good_degree,");
			strSql.Append("one_hou_one_water_meter_rate=@one_hou_one_water_meter_rate,");
			strSql.Append("water_supply_validate=@water_supply_validate,");
			strSql.Append("elec_capcity_degree=@elec_capcity_degree,");
			strSql.Append("elec_wire_safe_degree=@elec_wire_safe_degree,");
			strSql.Append("one_hou_one_elec_meter_rate=@one_hou_one_elec_meter_rate,");
			strSql.Append("elec_supply_validate=@elec_supply_validate,");
			strSql.Append("road_light_suff_degree=@road_light_suff_degree,");
			strSql.Append("passway_light_suff_degree=@passway_light_suff_degree,");
			strSql.Append("light_validate=@light_validate,");
			strSql.Append("outdoors_ff_good_rate=@outdoors_ff_good_rate,");
			strSql.Append("indoors_ff_good_rate=@indoors_ff_good_rate,");
			strSql.Append("ff_way_good_rate=@ff_way_good_rate,");
			strSql.Append("ff_validate=@ff_validate,");
			strSql.Append("basic_facility_validate=@basic_facility_validate,");
			strSql.Append("refuse_collect_rate=@refuse_collect_rate,");
			strSql.Append("toilet_cover_degree=@toilet_cover_degree,");
			strSql.Append("sanitation_validate=@sanitation_validate,");
			strSql.Append("sewage_collect_rate=@sewage_collect_rate,");
			strSql.Append("drain_safe_degree=@drain_safe_degree,");
			strSql.Append("drain_validate=@drain_validate,");
			strSql.Append("green_validate=@green_validate,");
			strSql.Append("environment_validate=@environment_validate,");
			strSql.Append("service_gfs_good_rate=@service_gfs_good_rate,");
			strSql.Append("kindergarten_good_rate=@kindergarten_good_rate,");
			strSql.Append("medical_good_rate=@medical_good_rate,");
			strSql.Append("parking_good_rate=@parking_good_rate,");
			strSql.Append("CVS_good_rate=@CVS_good_rate,");
			strSql.Append("vegetable_market_good_rate=@vegetable_market_good_rate,");
			strSql.Append("commerce_validate=@commerce_validate,");
			strSql.Append("cul_fitness_facility_good_rate=@cul_fitness_facility_good_rate,");
			strSql.Append("older_facility_good_rate=@older_facility_good_rate,");
			strSql.Append("public_service_good_rate=@public_service_good_rate,");
			strSql.Append("shop_front_use_rate=@shop_front_use_rate,");
			strSql.Append("shop_front_rent_level=@shop_front_rent_level,");
			strSql.Append("shop_validate=@shop_validate,");
			strSql.Append("community_validate=@community_validate,");
			strSql.Append("indicator1=@indicator1,");
			strSql.Append("indicator2=@indicator2,");
			strSql.Append("indicator3=@indicator3,");
			strSql.Append("indicator4=@indicator4,");
			strSql.Append("indicator5=@indicator5,");
			strSql.Append("indicator6=@indicator6,");
			strSql.Append("indicator7=@indicator7,");
			strSql.Append("indicator8=@indicator8,");
			strSql.Append("indicator9=@indicator9,");
			strSql.Append("indicator10=@indicator10,");
			strSql.Append("indicator11=@indicator11,");
			strSql.Append("indicator12=@indicator12,");
			strSql.Append("indicator13=@indicator13,");
			strSql.Append("indicator14=@indicator14,");
			strSql.Append("indicator15=@indicator15,");
			strSql.Append("indicator16=@indicator16,");
			strSql.Append("indicator17=@indicator17,");
			strSql.Append("indicator18=@indicator18,");
			strSql.Append("indicator19=@indicator19,");
			strSql.Append("indicator20=@indicator20,");
			strSql.Append("indicator21=@indicator21,");
			strSql.Append("indicator22=@indicator22,");
			strSql.Append("indicator23=@indicator23,");
			strSql.Append("indicator24=@indicator24,");
			strSql.Append("indicator25=@indicator25,");
			strSql.Append("indicator26=@indicator26,");
			strSql.Append("indicator27=@indicator27,");
			strSql.Append("indicator28=@indicator28,");
			strSql.Append("indicator29=@indicator29,");
			strSql.Append("indicator30=@indicator30,");
			strSql.Append("indicator31=@indicator31,");
			strSql.Append("indicator32=@indicator32,");
			strSql.Append("indicator33=@indicator33,");
			strSql.Append("indicator34=@indicator34,");
			strSql.Append("indicator35=@indicator35,");
			strSql.Append("indicator36=@indicator36,");
			strSql.Append("indicator37=@indicator37,");
			strSql.Append("indicator38=@indicator38,");
			strSql.Append("indicator39=@indicator39,");
			strSql.Append("indicator40=@indicator40,");
			strSql.Append("indicator41=@indicator41,");
			strSql.Append("indicator42=@indicator42,");
			strSql.Append("indicator43=@indicator43,");
			strSql.Append("indicator44=@indicator44,");
			strSql.Append("indicator45=@indicator45,");
			strSql.Append("indicator46=@indicator46,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("labor_employment_rate=@labor_employment_rate,");
			strSql.Append("disposable_money_per_people=@disposable_money_per_people");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@structure_safe_good_rate", SqlDbType.Float,8),
					new SqlParameter("@roof_good_rate", SqlDbType.Float,8),
					new SqlParameter("@wall_good_rate", SqlDbType.Float,8),
					new SqlParameter("@slope_safe_rate", SqlDbType.Float,8),
					new SqlParameter("@concil_house_validate", SqlDbType.Float,8),
					new SqlParameter("@road_link_degree", SqlDbType.Float,8),
					new SqlParameter("@road_good_degree", SqlDbType.Float,8),
					new SqlParameter("@traffic_validate", SqlDbType.Float,8),
					new SqlParameter("@water_capcity_degree", SqlDbType.Float,8),
					new SqlParameter("@water_pipe_net_good_degree", SqlDbType.Float,8),
					new SqlParameter("@one_hou_one_water_meter_rate", SqlDbType.Float,8),
					new SqlParameter("@water_supply_validate", SqlDbType.Float,8),
					new SqlParameter("@elec_capcity_degree", SqlDbType.Float,8),
					new SqlParameter("@elec_wire_safe_degree", SqlDbType.Float,8),
					new SqlParameter("@one_hou_one_elec_meter_rate", SqlDbType.Float,8),
					new SqlParameter("@elec_supply_validate", SqlDbType.Float,8),
					new SqlParameter("@road_light_suff_degree", SqlDbType.Float,8),
					new SqlParameter("@passway_light_suff_degree", SqlDbType.Float,8),
					new SqlParameter("@light_validate", SqlDbType.Float,8),
					new SqlParameter("@outdoors_ff_good_rate", SqlDbType.Float,8),
					new SqlParameter("@indoors_ff_good_rate", SqlDbType.Float,8),
					new SqlParameter("@ff_way_good_rate", SqlDbType.Float,8),
					new SqlParameter("@ff_validate", SqlDbType.Float,8),
					new SqlParameter("@basic_facility_validate", SqlDbType.Float,8),
					new SqlParameter("@refuse_collect_rate", SqlDbType.Float,8),
					new SqlParameter("@toilet_cover_degree", SqlDbType.Float,8),
					new SqlParameter("@sanitation_validate", SqlDbType.Float,8),
					new SqlParameter("@sewage_collect_rate", SqlDbType.Float,8),
					new SqlParameter("@drain_safe_degree", SqlDbType.Float,8),
					new SqlParameter("@drain_validate", SqlDbType.Float,8),
					new SqlParameter("@green_validate", SqlDbType.Float,8),
					new SqlParameter("@environment_validate", SqlDbType.Float,8),
					new SqlParameter("@service_gfs_good_rate", SqlDbType.Float,8),
					new SqlParameter("@kindergarten_good_rate", SqlDbType.Float,8),
					new SqlParameter("@medical_good_rate", SqlDbType.Float,8),
					new SqlParameter("@parking_good_rate", SqlDbType.Float,8),
					new SqlParameter("@CVS_good_rate", SqlDbType.Float,8),
					new SqlParameter("@vegetable_market_good_rate", SqlDbType.Float,8),
					new SqlParameter("@commerce_validate", SqlDbType.Float,8),
					new SqlParameter("@cul_fitness_facility_good_rate", SqlDbType.Float,8),
					new SqlParameter("@older_facility_good_rate", SqlDbType.Float,8),
					new SqlParameter("@public_service_good_rate", SqlDbType.Float,8),
					new SqlParameter("@shop_front_use_rate", SqlDbType.Float,8),
					new SqlParameter("@shop_front_rent_level", SqlDbType.Float,8),
					new SqlParameter("@shop_validate", SqlDbType.Float,8),
					new SqlParameter("@community_validate", SqlDbType.Float,8),
					new SqlParameter("@indicator1", SqlDbType.Float,8),
					new SqlParameter("@indicator2", SqlDbType.Float,8),
					new SqlParameter("@indicator3", SqlDbType.Float,8),
					new SqlParameter("@indicator4", SqlDbType.Float,8),
					new SqlParameter("@indicator5", SqlDbType.Float,8),
					new SqlParameter("@indicator6", SqlDbType.Float,8),
					new SqlParameter("@indicator7", SqlDbType.Float,8),
					new SqlParameter("@indicator8", SqlDbType.Float,8),
					new SqlParameter("@indicator9", SqlDbType.Float,8),
					new SqlParameter("@indicator10", SqlDbType.Float,8),
					new SqlParameter("@indicator11", SqlDbType.Float,8),
					new SqlParameter("@indicator12", SqlDbType.Float,8),
					new SqlParameter("@indicator13", SqlDbType.Float,8),
					new SqlParameter("@indicator14", SqlDbType.Float,8),
					new SqlParameter("@indicator15", SqlDbType.Float,8),
					new SqlParameter("@indicator16", SqlDbType.Float,8),
					new SqlParameter("@indicator17", SqlDbType.Float,8),
					new SqlParameter("@indicator18", SqlDbType.Float,8),
					new SqlParameter("@indicator19", SqlDbType.Float,8),
					new SqlParameter("@indicator20", SqlDbType.Float,8),
					new SqlParameter("@indicator21", SqlDbType.Float,8),
					new SqlParameter("@indicator22", SqlDbType.Float,8),
					new SqlParameter("@indicator23", SqlDbType.Float,8),
					new SqlParameter("@indicator24", SqlDbType.Float,8),
					new SqlParameter("@indicator25", SqlDbType.Float,8),
					new SqlParameter("@indicator26", SqlDbType.Float,8),
					new SqlParameter("@indicator27", SqlDbType.Float,8),
					new SqlParameter("@indicator28", SqlDbType.Float,8),
					new SqlParameter("@indicator29", SqlDbType.Float,8),
					new SqlParameter("@indicator30", SqlDbType.Float,8),
					new SqlParameter("@indicator31", SqlDbType.Float,8),
					new SqlParameter("@indicator32", SqlDbType.Float,8),
					new SqlParameter("@indicator33", SqlDbType.Float,8),
					new SqlParameter("@indicator34", SqlDbType.Float,8),
					new SqlParameter("@indicator35", SqlDbType.Float,8),
					new SqlParameter("@indicator36", SqlDbType.Float,8),
					new SqlParameter("@indicator37", SqlDbType.Float,8),
					new SqlParameter("@indicator38", SqlDbType.Float,8),
					new SqlParameter("@indicator39", SqlDbType.Float,8),
					new SqlParameter("@indicator40", SqlDbType.Float,8),
					new SqlParameter("@indicator41", SqlDbType.Float,8),
					new SqlParameter("@indicator42", SqlDbType.Float,8),
					new SqlParameter("@indicator43", SqlDbType.Float,8),
					new SqlParameter("@indicator44", SqlDbType.Float,8),
					new SqlParameter("@indicator45", SqlDbType.Float,8),
					new SqlParameter("@indicator46", SqlDbType.Float,8),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@labor_employment_rate", SqlDbType.Float,8),
					new SqlParameter("@disposable_money_per_people", SqlDbType.Float,8),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.structure_safe_good_rate;
			parameters[1].Value = model.roof_good_rate;
			parameters[2].Value = model.wall_good_rate;
			parameters[3].Value = model.slope_safe_rate;
			parameters[4].Value = model.concil_house_validate;
			parameters[5].Value = model.road_link_degree;
			parameters[6].Value = model.road_good_degree;
			parameters[7].Value = model.traffic_validate;
			parameters[8].Value = model.water_capcity_degree;
			parameters[9].Value = model.water_pipe_net_good_degree;
			parameters[10].Value = model.one_hou_one_water_meter_rate;
			parameters[11].Value = model.water_supply_validate;
			parameters[12].Value = model.elec_capcity_degree;
			parameters[13].Value = model.elec_wire_safe_degree;
			parameters[14].Value = model.one_hou_one_elec_meter_rate;
			parameters[15].Value = model.elec_supply_validate;
			parameters[16].Value = model.road_light_suff_degree;
			parameters[17].Value = model.passway_light_suff_degree;
			parameters[18].Value = model.light_validate;
			parameters[19].Value = model.outdoors_ff_good_rate;
			parameters[20].Value = model.indoors_ff_good_rate;
			parameters[21].Value = model.ff_way_good_rate;
			parameters[22].Value = model.ff_validate;
			parameters[23].Value = model.basic_facility_validate;
			parameters[24].Value = model.refuse_collect_rate;
			parameters[25].Value = model.toilet_cover_degree;
			parameters[26].Value = model.sanitation_validate;
			parameters[27].Value = model.sewage_collect_rate;
			parameters[28].Value = model.drain_safe_degree;
			parameters[29].Value = model.drain_validate;
			parameters[30].Value = model.green_validate;
			parameters[31].Value = model.environment_validate;
			parameters[32].Value = model.service_gfs_good_rate;
			parameters[33].Value = model.kindergarten_good_rate;
			parameters[34].Value = model.medical_good_rate;
			parameters[35].Value = model.parking_good_rate;
			parameters[36].Value = model.CVS_good_rate;
			parameters[37].Value = model.vegetable_market_good_rate;
			parameters[38].Value = model.commerce_validate;
			parameters[39].Value = model.cul_fitness_facility_good_rate;
			parameters[40].Value = model.older_facility_good_rate;
			parameters[41].Value = model.public_service_good_rate;
			parameters[42].Value = model.shop_front_use_rate;
			parameters[43].Value = model.shop_front_rent_level;
			parameters[44].Value = model.shop_validate;
			parameters[45].Value = model.community_validate;
			parameters[46].Value = model.indicator1;
			parameters[47].Value = model.indicator2;
			parameters[48].Value = model.indicator3;
			parameters[49].Value = model.indicator4;
			parameters[50].Value = model.indicator5;
			parameters[51].Value = model.indicator6;
			parameters[52].Value = model.indicator7;
			parameters[53].Value = model.indicator8;
			parameters[54].Value = model.indicator9;
			parameters[55].Value = model.indicator10;
			parameters[56].Value = model.indicator11;
			parameters[57].Value = model.indicator12;
			parameters[58].Value = model.indicator13;
			parameters[59].Value = model.indicator14;
			parameters[60].Value = model.indicator15;
			parameters[61].Value = model.indicator16;
			parameters[62].Value = model.indicator17;
			parameters[63].Value = model.indicator18;
			parameters[64].Value = model.indicator19;
			parameters[65].Value = model.indicator20;
			parameters[66].Value = model.indicator21;
			parameters[67].Value = model.indicator22;
			parameters[68].Value = model.indicator23;
			parameters[69].Value = model.indicator24;
			parameters[70].Value = model.indicator25;
			parameters[71].Value = model.indicator26;
			parameters[72].Value = model.indicator27;
			parameters[73].Value = model.indicator28;
			parameters[74].Value = model.indicator29;
			parameters[75].Value = model.indicator30;
			parameters[76].Value = model.indicator31;
			parameters[77].Value = model.indicator32;
			parameters[78].Value = model.indicator33;
			parameters[79].Value = model.indicator34;
			parameters[80].Value = model.indicator35;
			parameters[81].Value = model.indicator36;
			parameters[82].Value = model.indicator37;
			parameters[83].Value = model.indicator38;
			parameters[84].Value = model.indicator39;
			parameters[85].Value = model.indicator40;
			parameters[86].Value = model.indicator41;
			parameters[87].Value = model.indicator42;
			parameters[88].Value = model.indicator43;
			parameters[89].Value = model.indicator44;
			parameters[90].Value = model.indicator45;
			parameters[91].Value = model.indicator46;
			parameters[92].Value = model.lock_tables;
			parameters[93].Value = model.labor_employment_rate;
			parameters[94].Value = model.disposable_money_per_people;
			parameters[95].Value = model.community_id;
			parameters[96].Value = model.statistics_date;

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
			strSql.Append("delete from T_effect_indicator ");
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
		public TTG.Model.TTGWeb.effect_indicator GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,statistics_date,structure_safe_good_rate,roof_good_rate,wall_good_rate,slope_safe_rate,concil_house_validate,road_link_degree,road_good_degree,traffic_validate,water_capcity_degree,water_pipe_net_good_degree,one_hou_one_water_meter_rate,water_supply_validate,elec_capcity_degree,elec_wire_safe_degree,one_hou_one_elec_meter_rate,elec_supply_validate,road_light_suff_degree,passway_light_suff_degree,light_validate,outdoors_ff_good_rate,indoors_ff_good_rate,ff_way_good_rate,ff_validate,basic_facility_validate,refuse_collect_rate,toilet_cover_degree,sanitation_validate,sewage_collect_rate,drain_safe_degree,drain_validate,green_validate,environment_validate,service_gfs_good_rate,kindergarten_good_rate,medical_good_rate,parking_good_rate,CVS_good_rate,vegetable_market_good_rate,commerce_validate,cul_fitness_facility_good_rate,older_facility_good_rate,public_service_good_rate,shop_front_use_rate,shop_front_rent_level,shop_validate,community_validate,indicator1,indicator2,indicator3,indicator4,indicator5,indicator6,indicator7,indicator8,indicator9,indicator10,indicator11,indicator12,indicator13,indicator14,indicator15,indicator16,indicator17,indicator18,indicator19,indicator20,indicator21,indicator22,indicator23,indicator24,indicator25,indicator26,indicator27,indicator28,indicator29,indicator30,indicator31,indicator32,indicator33,indicator34,indicator35,indicator36,indicator37,indicator38,indicator39,indicator40,indicator41,indicator42,indicator43,indicator44,indicator45,indicator46,lock_tables,labor_employment_rate,disposable_money_per_people from T_effect_indicator ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.effect_indicator model=new TTG.Model.TTGWeb.effect_indicator();
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
		public TTG.Model.TTGWeb.effect_indicator DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.effect_indicator model=new TTG.Model.TTGWeb.effect_indicator();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["structure_safe_good_rate"]!=null && row["structure_safe_good_rate"].ToString()!="")
				{
					model.structure_safe_good_rate=decimal.Parse(row["structure_safe_good_rate"].ToString());
				}
				if(row["roof_good_rate"]!=null && row["roof_good_rate"].ToString()!="")
				{
					model.roof_good_rate=decimal.Parse(row["roof_good_rate"].ToString());
				}
				if(row["wall_good_rate"]!=null && row["wall_good_rate"].ToString()!="")
				{
					model.wall_good_rate=decimal.Parse(row["wall_good_rate"].ToString());
				}
				if(row["slope_safe_rate"]!=null && row["slope_safe_rate"].ToString()!="")
				{
					model.slope_safe_rate=decimal.Parse(row["slope_safe_rate"].ToString());
				}
				if(row["concil_house_validate"]!=null && row["concil_house_validate"].ToString()!="")
				{
					model.concil_house_validate=decimal.Parse(row["concil_house_validate"].ToString());
				}
				if(row["road_link_degree"]!=null && row["road_link_degree"].ToString()!="")
				{
					model.road_link_degree=decimal.Parse(row["road_link_degree"].ToString());
				}
				if(row["road_good_degree"]!=null && row["road_good_degree"].ToString()!="")
				{
					model.road_good_degree=decimal.Parse(row["road_good_degree"].ToString());
				}
				if(row["traffic_validate"]!=null && row["traffic_validate"].ToString()!="")
				{
					model.traffic_validate=decimal.Parse(row["traffic_validate"].ToString());
				}
				if(row["water_capcity_degree"]!=null && row["water_capcity_degree"].ToString()!="")
				{
					model.water_capcity_degree=decimal.Parse(row["water_capcity_degree"].ToString());
				}
				if(row["water_pipe_net_good_degree"]!=null && row["water_pipe_net_good_degree"].ToString()!="")
				{
					model.water_pipe_net_good_degree=decimal.Parse(row["water_pipe_net_good_degree"].ToString());
				}
				if(row["one_hou_one_water_meter_rate"]!=null && row["one_hou_one_water_meter_rate"].ToString()!="")
				{
					model.one_hou_one_water_meter_rate=decimal.Parse(row["one_hou_one_water_meter_rate"].ToString());
				}
				if(row["water_supply_validate"]!=null && row["water_supply_validate"].ToString()!="")
				{
					model.water_supply_validate=decimal.Parse(row["water_supply_validate"].ToString());
				}
				if(row["elec_capcity_degree"]!=null && row["elec_capcity_degree"].ToString()!="")
				{
					model.elec_capcity_degree=decimal.Parse(row["elec_capcity_degree"].ToString());
				}
				if(row["elec_wire_safe_degree"]!=null && row["elec_wire_safe_degree"].ToString()!="")
				{
					model.elec_wire_safe_degree=decimal.Parse(row["elec_wire_safe_degree"].ToString());
				}
				if(row["one_hou_one_elec_meter_rate"]!=null && row["one_hou_one_elec_meter_rate"].ToString()!="")
				{
					model.one_hou_one_elec_meter_rate=decimal.Parse(row["one_hou_one_elec_meter_rate"].ToString());
				}
				if(row["elec_supply_validate"]!=null && row["elec_supply_validate"].ToString()!="")
				{
					model.elec_supply_validate=decimal.Parse(row["elec_supply_validate"].ToString());
				}
				if(row["road_light_suff_degree"]!=null && row["road_light_suff_degree"].ToString()!="")
				{
					model.road_light_suff_degree=decimal.Parse(row["road_light_suff_degree"].ToString());
				}
				if(row["passway_light_suff_degree"]!=null && row["passway_light_suff_degree"].ToString()!="")
				{
					model.passway_light_suff_degree=decimal.Parse(row["passway_light_suff_degree"].ToString());
				}
				if(row["light_validate"]!=null && row["light_validate"].ToString()!="")
				{
					model.light_validate=decimal.Parse(row["light_validate"].ToString());
				}
				if(row["outdoors_ff_good_rate"]!=null && row["outdoors_ff_good_rate"].ToString()!="")
				{
					model.outdoors_ff_good_rate=decimal.Parse(row["outdoors_ff_good_rate"].ToString());
				}
				if(row["indoors_ff_good_rate"]!=null && row["indoors_ff_good_rate"].ToString()!="")
				{
					model.indoors_ff_good_rate=decimal.Parse(row["indoors_ff_good_rate"].ToString());
				}
				if(row["ff_way_good_rate"]!=null && row["ff_way_good_rate"].ToString()!="")
				{
					model.ff_way_good_rate=decimal.Parse(row["ff_way_good_rate"].ToString());
				}
				if(row["ff_validate"]!=null && row["ff_validate"].ToString()!="")
				{
					model.ff_validate=decimal.Parse(row["ff_validate"].ToString());
				}
				if(row["basic_facility_validate"]!=null && row["basic_facility_validate"].ToString()!="")
				{
					model.basic_facility_validate=decimal.Parse(row["basic_facility_validate"].ToString());
				}
				if(row["refuse_collect_rate"]!=null && row["refuse_collect_rate"].ToString()!="")
				{
					model.refuse_collect_rate=decimal.Parse(row["refuse_collect_rate"].ToString());
				}
				if(row["toilet_cover_degree"]!=null && row["toilet_cover_degree"].ToString()!="")
				{
					model.toilet_cover_degree=decimal.Parse(row["toilet_cover_degree"].ToString());
				}
				if(row["sanitation_validate"]!=null && row["sanitation_validate"].ToString()!="")
				{
					model.sanitation_validate=decimal.Parse(row["sanitation_validate"].ToString());
				}
				if(row["sewage_collect_rate"]!=null && row["sewage_collect_rate"].ToString()!="")
				{
					model.sewage_collect_rate=decimal.Parse(row["sewage_collect_rate"].ToString());
				}
				if(row["drain_safe_degree"]!=null && row["drain_safe_degree"].ToString()!="")
				{
					model.drain_safe_degree=decimal.Parse(row["drain_safe_degree"].ToString());
				}
				if(row["drain_validate"]!=null && row["drain_validate"].ToString()!="")
				{
					model.drain_validate=decimal.Parse(row["drain_validate"].ToString());
				}
				if(row["green_validate"]!=null && row["green_validate"].ToString()!="")
				{
					model.green_validate=decimal.Parse(row["green_validate"].ToString());
				}
				if(row["environment_validate"]!=null && row["environment_validate"].ToString()!="")
				{
					model.environment_validate=decimal.Parse(row["environment_validate"].ToString());
				}
				if(row["service_gfs_good_rate"]!=null && row["service_gfs_good_rate"].ToString()!="")
				{
					model.service_gfs_good_rate=decimal.Parse(row["service_gfs_good_rate"].ToString());
				}
				if(row["kindergarten_good_rate"]!=null && row["kindergarten_good_rate"].ToString()!="")
				{
					model.kindergarten_good_rate=decimal.Parse(row["kindergarten_good_rate"].ToString());
				}
				if(row["medical_good_rate"]!=null && row["medical_good_rate"].ToString()!="")
				{
					model.medical_good_rate=decimal.Parse(row["medical_good_rate"].ToString());
				}
				if(row["parking_good_rate"]!=null && row["parking_good_rate"].ToString()!="")
				{
					model.parking_good_rate=decimal.Parse(row["parking_good_rate"].ToString());
				}
				if(row["CVS_good_rate"]!=null && row["CVS_good_rate"].ToString()!="")
				{
					model.CVS_good_rate=decimal.Parse(row["CVS_good_rate"].ToString());
				}
				if(row["vegetable_market_good_rate"]!=null && row["vegetable_market_good_rate"].ToString()!="")
				{
					model.vegetable_market_good_rate=decimal.Parse(row["vegetable_market_good_rate"].ToString());
				}
				if(row["commerce_validate"]!=null && row["commerce_validate"].ToString()!="")
				{
					model.commerce_validate=decimal.Parse(row["commerce_validate"].ToString());
				}
				if(row["cul_fitness_facility_good_rate"]!=null && row["cul_fitness_facility_good_rate"].ToString()!="")
				{
					model.cul_fitness_facility_good_rate=decimal.Parse(row["cul_fitness_facility_good_rate"].ToString());
				}
				if(row["older_facility_good_rate"]!=null && row["older_facility_good_rate"].ToString()!="")
				{
					model.older_facility_good_rate=decimal.Parse(row["older_facility_good_rate"].ToString());
				}
				if(row["public_service_good_rate"]!=null && row["public_service_good_rate"].ToString()!="")
				{
					model.public_service_good_rate=decimal.Parse(row["public_service_good_rate"].ToString());
				}
				if(row["shop_front_use_rate"]!=null && row["shop_front_use_rate"].ToString()!="")
				{
					model.shop_front_use_rate=decimal.Parse(row["shop_front_use_rate"].ToString());
				}
				if(row["shop_front_rent_level"]!=null && row["shop_front_rent_level"].ToString()!="")
				{
					model.shop_front_rent_level=decimal.Parse(row["shop_front_rent_level"].ToString());
				}
				if(row["shop_validate"]!=null && row["shop_validate"].ToString()!="")
				{
					model.shop_validate=decimal.Parse(row["shop_validate"].ToString());
				}
				if(row["community_validate"]!=null && row["community_validate"].ToString()!="")
				{
					model.community_validate=decimal.Parse(row["community_validate"].ToString());
				}
				if(row["indicator1"]!=null && row["indicator1"].ToString()!="")
				{
					model.indicator1=decimal.Parse(row["indicator1"].ToString());
				}
				if(row["indicator2"]!=null && row["indicator2"].ToString()!="")
				{
					model.indicator2=decimal.Parse(row["indicator2"].ToString());
				}
				if(row["indicator3"]!=null && row["indicator3"].ToString()!="")
				{
					model.indicator3=decimal.Parse(row["indicator3"].ToString());
				}
				if(row["indicator4"]!=null && row["indicator4"].ToString()!="")
				{
					model.indicator4=decimal.Parse(row["indicator4"].ToString());
				}
				if(row["indicator5"]!=null && row["indicator5"].ToString()!="")
				{
					model.indicator5=decimal.Parse(row["indicator5"].ToString());
				}
				if(row["indicator6"]!=null && row["indicator6"].ToString()!="")
				{
					model.indicator6=decimal.Parse(row["indicator6"].ToString());
				}
				if(row["indicator7"]!=null && row["indicator7"].ToString()!="")
				{
					model.indicator7=decimal.Parse(row["indicator7"].ToString());
				}
				if(row["indicator8"]!=null && row["indicator8"].ToString()!="")
				{
					model.indicator8=decimal.Parse(row["indicator8"].ToString());
				}
				if(row["indicator9"]!=null && row["indicator9"].ToString()!="")
				{
					model.indicator9=decimal.Parse(row["indicator9"].ToString());
				}
				if(row["indicator10"]!=null && row["indicator10"].ToString()!="")
				{
					model.indicator10=decimal.Parse(row["indicator10"].ToString());
				}
				if(row["indicator11"]!=null && row["indicator11"].ToString()!="")
				{
					model.indicator11=decimal.Parse(row["indicator11"].ToString());
				}
				if(row["indicator12"]!=null && row["indicator12"].ToString()!="")
				{
					model.indicator12=decimal.Parse(row["indicator12"].ToString());
				}
				if(row["indicator13"]!=null && row["indicator13"].ToString()!="")
				{
					model.indicator13=decimal.Parse(row["indicator13"].ToString());
				}
				if(row["indicator14"]!=null && row["indicator14"].ToString()!="")
				{
					model.indicator14=decimal.Parse(row["indicator14"].ToString());
				}
				if(row["indicator15"]!=null && row["indicator15"].ToString()!="")
				{
					model.indicator15=decimal.Parse(row["indicator15"].ToString());
				}
				if(row["indicator16"]!=null && row["indicator16"].ToString()!="")
				{
					model.indicator16=decimal.Parse(row["indicator16"].ToString());
				}
				if(row["indicator17"]!=null && row["indicator17"].ToString()!="")
				{
					model.indicator17=decimal.Parse(row["indicator17"].ToString());
				}
				if(row["indicator18"]!=null && row["indicator18"].ToString()!="")
				{
					model.indicator18=decimal.Parse(row["indicator18"].ToString());
				}
				if(row["indicator19"]!=null && row["indicator19"].ToString()!="")
				{
					model.indicator19=decimal.Parse(row["indicator19"].ToString());
				}
				if(row["indicator20"]!=null && row["indicator20"].ToString()!="")
				{
					model.indicator20=decimal.Parse(row["indicator20"].ToString());
				}
				if(row["indicator21"]!=null && row["indicator21"].ToString()!="")
				{
					model.indicator21=decimal.Parse(row["indicator21"].ToString());
				}
				if(row["indicator22"]!=null && row["indicator22"].ToString()!="")
				{
					model.indicator22=decimal.Parse(row["indicator22"].ToString());
				}
				if(row["indicator23"]!=null && row["indicator23"].ToString()!="")
				{
					model.indicator23=decimal.Parse(row["indicator23"].ToString());
				}
				if(row["indicator24"]!=null && row["indicator24"].ToString()!="")
				{
					model.indicator24=decimal.Parse(row["indicator24"].ToString());
				}
				if(row["indicator25"]!=null && row["indicator25"].ToString()!="")
				{
					model.indicator25=decimal.Parse(row["indicator25"].ToString());
				}
				if(row["indicator26"]!=null && row["indicator26"].ToString()!="")
				{
					model.indicator26=decimal.Parse(row["indicator26"].ToString());
				}
				if(row["indicator27"]!=null && row["indicator27"].ToString()!="")
				{
					model.indicator27=decimal.Parse(row["indicator27"].ToString());
				}
				if(row["indicator28"]!=null && row["indicator28"].ToString()!="")
				{
					model.indicator28=decimal.Parse(row["indicator28"].ToString());
				}
				if(row["indicator29"]!=null && row["indicator29"].ToString()!="")
				{
					model.indicator29=decimal.Parse(row["indicator29"].ToString());
				}
				if(row["indicator30"]!=null && row["indicator30"].ToString()!="")
				{
					model.indicator30=decimal.Parse(row["indicator30"].ToString());
				}
				if(row["indicator31"]!=null && row["indicator31"].ToString()!="")
				{
					model.indicator31=decimal.Parse(row["indicator31"].ToString());
				}
				if(row["indicator32"]!=null && row["indicator32"].ToString()!="")
				{
					model.indicator32=decimal.Parse(row["indicator32"].ToString());
				}
				if(row["indicator33"]!=null && row["indicator33"].ToString()!="")
				{
					model.indicator33=decimal.Parse(row["indicator33"].ToString());
				}
				if(row["indicator34"]!=null && row["indicator34"].ToString()!="")
				{
					model.indicator34=decimal.Parse(row["indicator34"].ToString());
				}
				if(row["indicator35"]!=null && row["indicator35"].ToString()!="")
				{
					model.indicator35=decimal.Parse(row["indicator35"].ToString());
				}
				if(row["indicator36"]!=null && row["indicator36"].ToString()!="")
				{
					model.indicator36=decimal.Parse(row["indicator36"].ToString());
				}
				if(row["indicator37"]!=null && row["indicator37"].ToString()!="")
				{
					model.indicator37=decimal.Parse(row["indicator37"].ToString());
				}
				if(row["indicator38"]!=null && row["indicator38"].ToString()!="")
				{
					model.indicator38=decimal.Parse(row["indicator38"].ToString());
				}
				if(row["indicator39"]!=null && row["indicator39"].ToString()!="")
				{
					model.indicator39=decimal.Parse(row["indicator39"].ToString());
				}
				if(row["indicator40"]!=null && row["indicator40"].ToString()!="")
				{
					model.indicator40=decimal.Parse(row["indicator40"].ToString());
				}
				if(row["indicator41"]!=null && row["indicator41"].ToString()!="")
				{
					model.indicator41=decimal.Parse(row["indicator41"].ToString());
				}
				if(row["indicator42"]!=null && row["indicator42"].ToString()!="")
				{
					model.indicator42=decimal.Parse(row["indicator42"].ToString());
				}
				if(row["indicator43"]!=null && row["indicator43"].ToString()!="")
				{
					model.indicator43=decimal.Parse(row["indicator43"].ToString());
				}
				if(row["indicator44"]!=null && row["indicator44"].ToString()!="")
				{
					model.indicator44=decimal.Parse(row["indicator44"].ToString());
				}
				if(row["indicator45"]!=null && row["indicator45"].ToString()!="")
				{
					model.indicator45=decimal.Parse(row["indicator45"].ToString());
				}
				if(row["indicator46"]!=null && row["indicator46"].ToString()!="")
				{
					model.indicator46=decimal.Parse(row["indicator46"].ToString());
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["labor_employment_rate"]!=null && row["labor_employment_rate"].ToString()!="")
				{
					model.labor_employment_rate=decimal.Parse(row["labor_employment_rate"].ToString());
				}
				if(row["disposable_money_per_people"]!=null && row["disposable_money_per_people"].ToString()!="")
				{
					model.disposable_money_per_people=decimal.Parse(row["disposable_money_per_people"].ToString());
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
			strSql.Append("select community_id,statistics_date,structure_safe_good_rate,roof_good_rate,wall_good_rate,slope_safe_rate,concil_house_validate,road_link_degree,road_good_degree,traffic_validate,water_capcity_degree,water_pipe_net_good_degree,one_hou_one_water_meter_rate,water_supply_validate,elec_capcity_degree,elec_wire_safe_degree,one_hou_one_elec_meter_rate,elec_supply_validate,road_light_suff_degree,passway_light_suff_degree,light_validate,outdoors_ff_good_rate,indoors_ff_good_rate,ff_way_good_rate,ff_validate,basic_facility_validate,refuse_collect_rate,toilet_cover_degree,sanitation_validate,sewage_collect_rate,drain_safe_degree,drain_validate,green_validate,environment_validate,service_gfs_good_rate,kindergarten_good_rate,medical_good_rate,parking_good_rate,CVS_good_rate,vegetable_market_good_rate,commerce_validate,cul_fitness_facility_good_rate,older_facility_good_rate,public_service_good_rate,shop_front_use_rate,shop_front_rent_level,shop_validate,community_validate,indicator1,indicator2,indicator3,indicator4,indicator5,indicator6,indicator7,indicator8,indicator9,indicator10,indicator11,indicator12,indicator13,indicator14,indicator15,indicator16,indicator17,indicator18,indicator19,indicator20,indicator21,indicator22,indicator23,indicator24,indicator25,indicator26,indicator27,indicator28,indicator29,indicator30,indicator31,indicator32,indicator33,indicator34,indicator35,indicator36,indicator37,indicator38,indicator39,indicator40,indicator41,indicator42,indicator43,indicator44,indicator45,indicator46,lock_tables,labor_employment_rate,disposable_money_per_people ");
			strSql.Append(" FROM T_effect_indicator ");
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
			strSql.Append(" community_id,statistics_date,structure_safe_good_rate,roof_good_rate,wall_good_rate,slope_safe_rate,concil_house_validate,road_link_degree,road_good_degree,traffic_validate,water_capcity_degree,water_pipe_net_good_degree,one_hou_one_water_meter_rate,water_supply_validate,elec_capcity_degree,elec_wire_safe_degree,one_hou_one_elec_meter_rate,elec_supply_validate,road_light_suff_degree,passway_light_suff_degree,light_validate,outdoors_ff_good_rate,indoors_ff_good_rate,ff_way_good_rate,ff_validate,basic_facility_validate,refuse_collect_rate,toilet_cover_degree,sanitation_validate,sewage_collect_rate,drain_safe_degree,drain_validate,green_validate,environment_validate,service_gfs_good_rate,kindergarten_good_rate,medical_good_rate,parking_good_rate,CVS_good_rate,vegetable_market_good_rate,commerce_validate,cul_fitness_facility_good_rate,older_facility_good_rate,public_service_good_rate,shop_front_use_rate,shop_front_rent_level,shop_validate,community_validate,indicator1,indicator2,indicator3,indicator4,indicator5,indicator6,indicator7,indicator8,indicator9,indicator10,indicator11,indicator12,indicator13,indicator14,indicator15,indicator16,indicator17,indicator18,indicator19,indicator20,indicator21,indicator22,indicator23,indicator24,indicator25,indicator26,indicator27,indicator28,indicator29,indicator30,indicator31,indicator32,indicator33,indicator34,indicator35,indicator36,indicator37,indicator38,indicator39,indicator40,indicator41,indicator42,indicator43,indicator44,indicator45,indicator46,lock_tables,labor_employment_rate,disposable_money_per_people ");
			strSql.Append(" FROM T_effect_indicator ");
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
			strSql.Append("select count(1) FROM T_effect_indicator ");
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
			strSql.Append(")AS Row, T.*  from T_effect_indicator T ");
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
			parameters[0].Value = "T_effect_indicator";
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

