using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:Community_Indicator
	/// </summary>
	public partial class Community_Indicator
	{
		public Community_Indicator()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Community_Indicator");
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
		public bool Add(TTG.Model.TTGWeb.Community_Indicator model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Community_Indicator(");
			strSql.Append("community_id,community_pop_total_density,community_pop_pure_density,community_plot_ratio,community_conhou_struc_safe_problem_rate,community_conhou_seepage_rate,community_conhou_tile_paint_cra_holl_rate,community_road_density,road_per_capita_availability,no_hard_road_rate,damage_road_rate,large_slope_road_rate,lack_width_road_rate,need_new_repair_road_rate,need_improve_link_ots_road,no_brick_road_rate,damage_brick_road_rate,tap_water_fam_rate,no_water_meter_house_rate,water_supply_insuff_family_rate,water_pressure_insuff_family_rate,caliber_samll_pipe_lenth_rate,damage_pipe_lenth_rate,senescent_erosive_pipe_length_rate,sewage_collection_rate,sewage_handle_rate,not_reasonable_drain_pipe_rate,caliber_samll_drain_pipe_rate,septic_tank_capacity_small_rate,senescent_erosive_drain_pipe_length_rate,damage_drain_pipe_rate,broken_leaking_septic_tank_rate,no_link_drain_pipe_net_famliy_rate,elec_reliable_rate,elec_capacity_lack_family_rate,senescent_elec_wireways_rate,no_elec_meter_house_rate,not_norm_transformer_rate,no_light_road_length_rate,lack_light_road_rate,damage_road_light_rate,passway_light_wireway_damage_house_rate,passway_light_wireway_damage_family_rate,greenland_rate,greenland_per_capita_area,no_lack_afforest_road_length_rate,no_lack_afforest_house_rate,lack_otds_hydrant_road_length_rate,lack_inds_hydrant_house_rate,extinguisher_insuff_building_rate,ff_pipe_damage_length_rate,ff_road_block_building_rate,rubbish_collection_rate,rubbish_handle_rate,dustbin_lack_road_length_rate,dustbin_lack_house_rate,long_term_rubbish_stack_rate,education_fs_indicator,education_gfa_indicator,medical_fs_indicator,medical_gfa_indicator,culture_sports_fs_indicator,culture_sports_gfa_indicator,community_service_fs_indicator,community_service_gfa_indicator,commerce_fs_indicator,commerce_gfa_indicator,farm_produce_fair_fs_indicator,farm_produce_fair_gfa_indicator,statistics_date,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,tciunset15,tciunset16,tciunset17,tciunset18,tciunset19,tciunset20,tciunset21,tciunset22,tciunset23,tciunset24,tciunset25,tciunset26,tciunset27,tciunset28,tciunset29,tciunset30,tciunset31,tciunset32,tciunset33,tciunset34,tciunset35,tciunset36,tciunset37,tciunset38,tciunset39,tciunset40,tciunset41,tciunset42,tciunset43,tciunset44,tciunset45,tciunset46,tciunset47,tciunset48,tciunset49,tciunset50,tciunset51,tciunset52,tciunset53,tciunset54,tciunset55,tciunset56,tciunset57,tciunset58,tciunset59,tciunset60,tciunset61,tciunset62,tciunset63,tciunset64,tciunset65,tciunset66,tciunset67,tciunset68,tciunset69,check_status,lock_tables,house_area_per_people,community_help_figure,community_develop_figure,community_engel_coefficient,community_gini_coefficient)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_pop_total_density,@community_pop_pure_density,@community_plot_ratio,@community_conhou_struc_safe_problem_rate,@community_conhou_seepage_rate,@community_conhou_tile_paint_cra_holl_rate,@community_road_density,@road_per_capita_availability,@no_hard_road_rate,@damage_road_rate,@large_slope_road_rate,@lack_width_road_rate,@need_new_repair_road_rate,@need_improve_link_ots_road,@no_brick_road_rate,@damage_brick_road_rate,@tap_water_fam_rate,@no_water_meter_house_rate,@water_supply_insuff_family_rate,@water_pressure_insuff_family_rate,@caliber_samll_pipe_lenth_rate,@damage_pipe_lenth_rate,@senescent_erosive_pipe_length_rate,@sewage_collection_rate,@sewage_handle_rate,@not_reasonable_drain_pipe_rate,@caliber_samll_drain_pipe_rate,@septic_tank_capacity_small_rate,@senescent_erosive_drain_pipe_length_rate,@damage_drain_pipe_rate,@broken_leaking_septic_tank_rate,@no_link_drain_pipe_net_famliy_rate,@elec_reliable_rate,@elec_capacity_lack_family_rate,@senescent_elec_wireways_rate,@no_elec_meter_house_rate,@not_norm_transformer_rate,@no_light_road_length_rate,@lack_light_road_rate,@damage_road_light_rate,@passway_light_wireway_damage_house_rate,@passway_light_wireway_damage_family_rate,@greenland_rate,@greenland_per_capita_area,@no_lack_afforest_road_length_rate,@no_lack_afforest_house_rate,@lack_otds_hydrant_road_length_rate,@lack_inds_hydrant_house_rate,@extinguisher_insuff_building_rate,@ff_pipe_damage_length_rate,@ff_road_block_building_rate,@rubbish_collection_rate,@rubbish_handle_rate,@dustbin_lack_road_length_rate,@dustbin_lack_house_rate,@long_term_rubbish_stack_rate,@education_fs_indicator,@education_gfa_indicator,@medical_fs_indicator,@medical_gfa_indicator,@culture_sports_fs_indicator,@culture_sports_gfa_indicator,@community_service_fs_indicator,@community_service_gfa_indicator,@commerce_fs_indicator,@commerce_gfa_indicator,@farm_produce_fair_fs_indicator,@farm_produce_fair_gfa_indicator,@statistics_date,@tciunset1,@tciunset2,@tciunset3,@tciunset4,@tciunset5,@tciunset6,@tciunset7,@tciunset8,@tciunset9,@tciunset10,@tciunset11,@tciunset12,@tciunset13,@tciunset14,@tciunset15,@tciunset16,@tciunset17,@tciunset18,@tciunset19,@tciunset20,@tciunset21,@tciunset22,@tciunset23,@tciunset24,@tciunset25,@tciunset26,@tciunset27,@tciunset28,@tciunset29,@tciunset30,@tciunset31,@tciunset32,@tciunset33,@tciunset34,@tciunset35,@tciunset36,@tciunset37,@tciunset38,@tciunset39,@tciunset40,@tciunset41,@tciunset42,@tciunset43,@tciunset44,@tciunset45,@tciunset46,@tciunset47,@tciunset48,@tciunset49,@tciunset50,@tciunset51,@tciunset52,@tciunset53,@tciunset54,@tciunset55,@tciunset56,@tciunset57,@tciunset58,@tciunset59,@tciunset60,@tciunset61,@tciunset62,@tciunset63,@tciunset64,@tciunset65,@tciunset66,@tciunset67,@tciunset68,@tciunset69,@check_status,@lock_tables,@house_area_per_people,@community_help_figure,@community_develop_figure,@community_engel_coefficient,@community_gini_coefficient)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_pop_total_density", SqlDbType.Float,8),
					new SqlParameter("@community_pop_pure_density", SqlDbType.Float,8),
					new SqlParameter("@community_plot_ratio", SqlDbType.Float,8),
					new SqlParameter("@community_conhou_struc_safe_problem_rate", SqlDbType.Float,8),
					new SqlParameter("@community_conhou_seepage_rate", SqlDbType.Float,8),
					new SqlParameter("@community_conhou_tile_paint_cra_holl_rate", SqlDbType.Float,8),
					new SqlParameter("@community_road_density", SqlDbType.Float,8),
					new SqlParameter("@road_per_capita_availability", SqlDbType.Float,8),
					new SqlParameter("@no_hard_road_rate", SqlDbType.Float,8),
					new SqlParameter("@damage_road_rate", SqlDbType.Float,8),
					new SqlParameter("@large_slope_road_rate", SqlDbType.Float,8),
					new SqlParameter("@lack_width_road_rate", SqlDbType.Float,8),
					new SqlParameter("@need_new_repair_road_rate", SqlDbType.Float,8),
					new SqlParameter("@need_improve_link_ots_road", SqlDbType.Float,8),
					new SqlParameter("@no_brick_road_rate", SqlDbType.Float,8),
					new SqlParameter("@damage_brick_road_rate", SqlDbType.Float,8),
					new SqlParameter("@tap_water_fam_rate", SqlDbType.Float,8),
					new SqlParameter("@no_water_meter_house_rate", SqlDbType.Float,8),
					new SqlParameter("@water_supply_insuff_family_rate", SqlDbType.Float,8),
					new SqlParameter("@water_pressure_insuff_family_rate", SqlDbType.Float,8),
					new SqlParameter("@caliber_samll_pipe_lenth_rate", SqlDbType.Float,8),
					new SqlParameter("@damage_pipe_lenth_rate", SqlDbType.Float,8),
					new SqlParameter("@senescent_erosive_pipe_length_rate", SqlDbType.Float,8),
					new SqlParameter("@sewage_collection_rate", SqlDbType.Float,8),
					new SqlParameter("@sewage_handle_rate", SqlDbType.Float,8),
					new SqlParameter("@not_reasonable_drain_pipe_rate", SqlDbType.Float,8),
					new SqlParameter("@caliber_samll_drain_pipe_rate", SqlDbType.Float,8),
					new SqlParameter("@septic_tank_capacity_small_rate", SqlDbType.Float,8),
					new SqlParameter("@senescent_erosive_drain_pipe_length_rate", SqlDbType.Float,8),
					new SqlParameter("@damage_drain_pipe_rate", SqlDbType.Float,8),
					new SqlParameter("@broken_leaking_septic_tank_rate", SqlDbType.Float,8),
					new SqlParameter("@no_link_drain_pipe_net_famliy_rate", SqlDbType.Float,8),
					new SqlParameter("@elec_reliable_rate", SqlDbType.Float,8),
					new SqlParameter("@elec_capacity_lack_family_rate", SqlDbType.Float,8),
					new SqlParameter("@senescent_elec_wireways_rate", SqlDbType.Float,8),
					new SqlParameter("@no_elec_meter_house_rate", SqlDbType.Float,8),
					new SqlParameter("@not_norm_transformer_rate", SqlDbType.Float,8),
					new SqlParameter("@no_light_road_length_rate", SqlDbType.Float,8),
					new SqlParameter("@lack_light_road_rate", SqlDbType.Float,8),
					new SqlParameter("@damage_road_light_rate", SqlDbType.Float,8),
					new SqlParameter("@passway_light_wireway_damage_house_rate", SqlDbType.Float,8),
					new SqlParameter("@passway_light_wireway_damage_family_rate", SqlDbType.Float,8),
					new SqlParameter("@greenland_rate", SqlDbType.Float,8),
					new SqlParameter("@greenland_per_capita_area", SqlDbType.Float,8),
					new SqlParameter("@no_lack_afforest_road_length_rate", SqlDbType.Float,8),
					new SqlParameter("@no_lack_afforest_house_rate", SqlDbType.Float,8),
					new SqlParameter("@lack_otds_hydrant_road_length_rate", SqlDbType.Float,8),
					new SqlParameter("@lack_inds_hydrant_house_rate", SqlDbType.Float,8),
					new SqlParameter("@extinguisher_insuff_building_rate", SqlDbType.Float,8),
					new SqlParameter("@ff_pipe_damage_length_rate", SqlDbType.Float,8),
					new SqlParameter("@ff_road_block_building_rate", SqlDbType.Float,8),
					new SqlParameter("@rubbish_collection_rate", SqlDbType.Float,8),
					new SqlParameter("@rubbish_handle_rate", SqlDbType.Float,8),
					new SqlParameter("@dustbin_lack_road_length_rate", SqlDbType.Float,8),
					new SqlParameter("@dustbin_lack_house_rate", SqlDbType.Float,8),
					new SqlParameter("@long_term_rubbish_stack_rate", SqlDbType.Float,8),
					new SqlParameter("@education_fs_indicator", SqlDbType.Float,8),
					new SqlParameter("@education_gfa_indicator", SqlDbType.Float,8),
					new SqlParameter("@medical_fs_indicator", SqlDbType.Float,8),
					new SqlParameter("@medical_gfa_indicator", SqlDbType.Float,8),
					new SqlParameter("@culture_sports_fs_indicator", SqlDbType.Float,8),
					new SqlParameter("@culture_sports_gfa_indicator", SqlDbType.Float,8),
					new SqlParameter("@community_service_fs_indicator", SqlDbType.Float,8),
					new SqlParameter("@community_service_gfa_indicator", SqlDbType.Float,8),
					new SqlParameter("@commerce_fs_indicator", SqlDbType.Float,8),
					new SqlParameter("@commerce_gfa_indicator", SqlDbType.Float,8),
					new SqlParameter("@farm_produce_fair_fs_indicator", SqlDbType.Float,8),
					new SqlParameter("@farm_produce_fair_gfa_indicator", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset21", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset22", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset23", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset24", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset25", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset26", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset27", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset28", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset29", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset30", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset31", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset32", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset33", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset34", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset35", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset36", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset37", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset38", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset39", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset40", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset41", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset42", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset43", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset44", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset45", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset46", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset47", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset48", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset49", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset50", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset51", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset52", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset53", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset54", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset55", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset56", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset57", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset58", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset59", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset60", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset61", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset62", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset63", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset64", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset65", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset66", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset67", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset68", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset69", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@house_area_per_people", SqlDbType.Float,8),
					new SqlParameter("@community_help_figure", SqlDbType.Float,8),
					new SqlParameter("@community_develop_figure", SqlDbType.Float,8),
					new SqlParameter("@community_engel_coefficient", SqlDbType.Float,8),
					new SqlParameter("@community_gini_coefficient", SqlDbType.Float,8)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_pop_total_density;
			parameters[2].Value = model.community_pop_pure_density;
			parameters[3].Value = model.community_plot_ratio;
			parameters[4].Value = model.community_conhou_struc_safe_problem_rate;
			parameters[5].Value = model.community_conhou_seepage_rate;
			parameters[6].Value = model.community_conhou_tile_paint_cra_holl_rate;
			parameters[7].Value = model.community_road_density;
			parameters[8].Value = model.road_per_capita_availability;
			parameters[9].Value = model.no_hard_road_rate;
			parameters[10].Value = model.damage_road_rate;
			parameters[11].Value = model.large_slope_road_rate;
			parameters[12].Value = model.lack_width_road_rate;
			parameters[13].Value = model.need_new_repair_road_rate;
			parameters[14].Value = model.need_improve_link_ots_road;
			parameters[15].Value = model.no_brick_road_rate;
			parameters[16].Value = model.damage_brick_road_rate;
			parameters[17].Value = model.tap_water_fam_rate;
			parameters[18].Value = model.no_water_meter_house_rate;
			parameters[19].Value = model.water_supply_insuff_family_rate;
			parameters[20].Value = model.water_pressure_insuff_family_rate;
			parameters[21].Value = model.caliber_samll_pipe_lenth_rate;
			parameters[22].Value = model.damage_pipe_lenth_rate;
			parameters[23].Value = model.senescent_erosive_pipe_length_rate;
			parameters[24].Value = model.sewage_collection_rate;
			parameters[25].Value = model.sewage_handle_rate;
			parameters[26].Value = model.not_reasonable_drain_pipe_rate;
			parameters[27].Value = model.caliber_samll_drain_pipe_rate;
			parameters[28].Value = model.septic_tank_capacity_small_rate;
			parameters[29].Value = model.senescent_erosive_drain_pipe_length_rate;
			parameters[30].Value = model.damage_drain_pipe_rate;
			parameters[31].Value = model.broken_leaking_septic_tank_rate;
			parameters[32].Value = model.no_link_drain_pipe_net_famliy_rate;
			parameters[33].Value = model.elec_reliable_rate;
			parameters[34].Value = model.elec_capacity_lack_family_rate;
			parameters[35].Value = model.senescent_elec_wireways_rate;
			parameters[36].Value = model.no_elec_meter_house_rate;
			parameters[37].Value = model.not_norm_transformer_rate;
			parameters[38].Value = model.no_light_road_length_rate;
			parameters[39].Value = model.lack_light_road_rate;
			parameters[40].Value = model.damage_road_light_rate;
			parameters[41].Value = model.passway_light_wireway_damage_house_rate;
			parameters[42].Value = model.passway_light_wireway_damage_family_rate;
			parameters[43].Value = model.greenland_rate;
			parameters[44].Value = model.greenland_per_capita_area;
			parameters[45].Value = model.no_lack_afforest_road_length_rate;
			parameters[46].Value = model.no_lack_afforest_house_rate;
			parameters[47].Value = model.lack_otds_hydrant_road_length_rate;
			parameters[48].Value = model.lack_inds_hydrant_house_rate;
			parameters[49].Value = model.extinguisher_insuff_building_rate;
			parameters[50].Value = model.ff_pipe_damage_length_rate;
			parameters[51].Value = model.ff_road_block_building_rate;
			parameters[52].Value = model.rubbish_collection_rate;
			parameters[53].Value = model.rubbish_handle_rate;
			parameters[54].Value = model.dustbin_lack_road_length_rate;
			parameters[55].Value = model.dustbin_lack_house_rate;
			parameters[56].Value = model.long_term_rubbish_stack_rate;
			parameters[57].Value = model.education_fs_indicator;
			parameters[58].Value = model.education_gfa_indicator;
			parameters[59].Value = model.medical_fs_indicator;
			parameters[60].Value = model.medical_gfa_indicator;
			parameters[61].Value = model.culture_sports_fs_indicator;
			parameters[62].Value = model.culture_sports_gfa_indicator;
			parameters[63].Value = model.community_service_fs_indicator;
			parameters[64].Value = model.community_service_gfa_indicator;
			parameters[65].Value = model.commerce_fs_indicator;
			parameters[66].Value = model.commerce_gfa_indicator;
			parameters[67].Value = model.farm_produce_fair_fs_indicator;
			parameters[68].Value = model.farm_produce_fair_gfa_indicator;
			parameters[69].Value = model.statistics_date;
			parameters[70].Value = model.tciunset1;
			parameters[71].Value = model.tciunset2;
			parameters[72].Value = model.tciunset3;
			parameters[73].Value = model.tciunset4;
			parameters[74].Value = model.tciunset5;
			parameters[75].Value = model.tciunset6;
			parameters[76].Value = model.tciunset7;
			parameters[77].Value = model.tciunset8;
			parameters[78].Value = model.tciunset9;
			parameters[79].Value = model.tciunset10;
			parameters[80].Value = model.tciunset11;
			parameters[81].Value = model.tciunset12;
			parameters[82].Value = model.tciunset13;
			parameters[83].Value = model.tciunset14;
			parameters[84].Value = model.tciunset15;
			parameters[85].Value = model.tciunset16;
			parameters[86].Value = model.tciunset17;
			parameters[87].Value = model.tciunset18;
			parameters[88].Value = model.tciunset19;
			parameters[89].Value = model.tciunset20;
			parameters[90].Value = model.tciunset21;
			parameters[91].Value = model.tciunset22;
			parameters[92].Value = model.tciunset23;
			parameters[93].Value = model.tciunset24;
			parameters[94].Value = model.tciunset25;
			parameters[95].Value = model.tciunset26;
			parameters[96].Value = model.tciunset27;
			parameters[97].Value = model.tciunset28;
			parameters[98].Value = model.tciunset29;
			parameters[99].Value = model.tciunset30;
			parameters[100].Value = model.tciunset31;
			parameters[101].Value = model.tciunset32;
			parameters[102].Value = model.tciunset33;
			parameters[103].Value = model.tciunset34;
			parameters[104].Value = model.tciunset35;
			parameters[105].Value = model.tciunset36;
			parameters[106].Value = model.tciunset37;
			parameters[107].Value = model.tciunset38;
			parameters[108].Value = model.tciunset39;
			parameters[109].Value = model.tciunset40;
			parameters[110].Value = model.tciunset41;
			parameters[111].Value = model.tciunset42;
			parameters[112].Value = model.tciunset43;
			parameters[113].Value = model.tciunset44;
			parameters[114].Value = model.tciunset45;
			parameters[115].Value = model.tciunset46;
			parameters[116].Value = model.tciunset47;
			parameters[117].Value = model.tciunset48;
			parameters[118].Value = model.tciunset49;
			parameters[119].Value = model.tciunset50;
			parameters[120].Value = model.tciunset51;
			parameters[121].Value = model.tciunset52;
			parameters[122].Value = model.tciunset53;
			parameters[123].Value = model.tciunset54;
			parameters[124].Value = model.tciunset55;
			parameters[125].Value = model.tciunset56;
			parameters[126].Value = model.tciunset57;
			parameters[127].Value = model.tciunset58;
			parameters[128].Value = model.tciunset59;
			parameters[129].Value = model.tciunset60;
			parameters[130].Value = model.tciunset61;
			parameters[131].Value = model.tciunset62;
			parameters[132].Value = model.tciunset63;
			parameters[133].Value = model.tciunset64;
			parameters[134].Value = model.tciunset65;
			parameters[135].Value = model.tciunset66;
			parameters[136].Value = model.tciunset67;
			parameters[137].Value = model.tciunset68;
			parameters[138].Value = model.tciunset69;
			parameters[139].Value = model.check_status;
			parameters[140].Value = model.lock_tables;
			parameters[141].Value = model.house_area_per_people;
			parameters[142].Value = model.community_help_figure;
			parameters[143].Value = model.community_develop_figure;
			parameters[144].Value = model.community_engel_coefficient;
			parameters[145].Value = model.community_gini_coefficient;

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
		public bool Update(TTG.Model.TTGWeb.Community_Indicator model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Community_Indicator set ");
			strSql.Append("community_pop_total_density=@community_pop_total_density,");
			strSql.Append("community_pop_pure_density=@community_pop_pure_density,");
			strSql.Append("community_plot_ratio=@community_plot_ratio,");
			strSql.Append("community_conhou_struc_safe_problem_rate=@community_conhou_struc_safe_problem_rate,");
			strSql.Append("community_conhou_seepage_rate=@community_conhou_seepage_rate,");
			strSql.Append("community_conhou_tile_paint_cra_holl_rate=@community_conhou_tile_paint_cra_holl_rate,");
			strSql.Append("community_road_density=@community_road_density,");
			strSql.Append("road_per_capita_availability=@road_per_capita_availability,");
			strSql.Append("no_hard_road_rate=@no_hard_road_rate,");
			strSql.Append("damage_road_rate=@damage_road_rate,");
			strSql.Append("large_slope_road_rate=@large_slope_road_rate,");
			strSql.Append("lack_width_road_rate=@lack_width_road_rate,");
			strSql.Append("need_new_repair_road_rate=@need_new_repair_road_rate,");
			strSql.Append("need_improve_link_ots_road=@need_improve_link_ots_road,");
			strSql.Append("no_brick_road_rate=@no_brick_road_rate,");
			strSql.Append("damage_brick_road_rate=@damage_brick_road_rate,");
			strSql.Append("tap_water_fam_rate=@tap_water_fam_rate,");
			strSql.Append("no_water_meter_house_rate=@no_water_meter_house_rate,");
			strSql.Append("water_supply_insuff_family_rate=@water_supply_insuff_family_rate,");
			strSql.Append("water_pressure_insuff_family_rate=@water_pressure_insuff_family_rate,");
			strSql.Append("caliber_samll_pipe_lenth_rate=@caliber_samll_pipe_lenth_rate,");
			strSql.Append("damage_pipe_lenth_rate=@damage_pipe_lenth_rate,");
			strSql.Append("senescent_erosive_pipe_length_rate=@senescent_erosive_pipe_length_rate,");
			strSql.Append("sewage_collection_rate=@sewage_collection_rate,");
			strSql.Append("sewage_handle_rate=@sewage_handle_rate,");
			strSql.Append("not_reasonable_drain_pipe_rate=@not_reasonable_drain_pipe_rate,");
			strSql.Append("caliber_samll_drain_pipe_rate=@caliber_samll_drain_pipe_rate,");
			strSql.Append("septic_tank_capacity_small_rate=@septic_tank_capacity_small_rate,");
			strSql.Append("senescent_erosive_drain_pipe_length_rate=@senescent_erosive_drain_pipe_length_rate,");
			strSql.Append("damage_drain_pipe_rate=@damage_drain_pipe_rate,");
			strSql.Append("broken_leaking_septic_tank_rate=@broken_leaking_septic_tank_rate,");
			strSql.Append("no_link_drain_pipe_net_famliy_rate=@no_link_drain_pipe_net_famliy_rate,");
			strSql.Append("elec_reliable_rate=@elec_reliable_rate,");
			strSql.Append("elec_capacity_lack_family_rate=@elec_capacity_lack_family_rate,");
			strSql.Append("senescent_elec_wireways_rate=@senescent_elec_wireways_rate,");
			strSql.Append("no_elec_meter_house_rate=@no_elec_meter_house_rate,");
			strSql.Append("not_norm_transformer_rate=@not_norm_transformer_rate,");
			strSql.Append("no_light_road_length_rate=@no_light_road_length_rate,");
			strSql.Append("lack_light_road_rate=@lack_light_road_rate,");
			strSql.Append("damage_road_light_rate=@damage_road_light_rate,");
			strSql.Append("passway_light_wireway_damage_house_rate=@passway_light_wireway_damage_house_rate,");
			strSql.Append("passway_light_wireway_damage_family_rate=@passway_light_wireway_damage_family_rate,");
			strSql.Append("greenland_rate=@greenland_rate,");
			strSql.Append("greenland_per_capita_area=@greenland_per_capita_area,");
			strSql.Append("no_lack_afforest_road_length_rate=@no_lack_afforest_road_length_rate,");
			strSql.Append("no_lack_afforest_house_rate=@no_lack_afforest_house_rate,");
			strSql.Append("lack_otds_hydrant_road_length_rate=@lack_otds_hydrant_road_length_rate,");
			strSql.Append("lack_inds_hydrant_house_rate=@lack_inds_hydrant_house_rate,");
			strSql.Append("extinguisher_insuff_building_rate=@extinguisher_insuff_building_rate,");
			strSql.Append("ff_pipe_damage_length_rate=@ff_pipe_damage_length_rate,");
			strSql.Append("ff_road_block_building_rate=@ff_road_block_building_rate,");
			strSql.Append("rubbish_collection_rate=@rubbish_collection_rate,");
			strSql.Append("rubbish_handle_rate=@rubbish_handle_rate,");
			strSql.Append("dustbin_lack_road_length_rate=@dustbin_lack_road_length_rate,");
			strSql.Append("dustbin_lack_house_rate=@dustbin_lack_house_rate,");
			strSql.Append("long_term_rubbish_stack_rate=@long_term_rubbish_stack_rate,");
			strSql.Append("education_fs_indicator=@education_fs_indicator,");
			strSql.Append("education_gfa_indicator=@education_gfa_indicator,");
			strSql.Append("medical_fs_indicator=@medical_fs_indicator,");
			strSql.Append("medical_gfa_indicator=@medical_gfa_indicator,");
			strSql.Append("culture_sports_fs_indicator=@culture_sports_fs_indicator,");
			strSql.Append("culture_sports_gfa_indicator=@culture_sports_gfa_indicator,");
			strSql.Append("community_service_fs_indicator=@community_service_fs_indicator,");
			strSql.Append("community_service_gfa_indicator=@community_service_gfa_indicator,");
			strSql.Append("commerce_fs_indicator=@commerce_fs_indicator,");
			strSql.Append("commerce_gfa_indicator=@commerce_gfa_indicator,");
			strSql.Append("farm_produce_fair_fs_indicator=@farm_produce_fair_fs_indicator,");
			strSql.Append("farm_produce_fair_gfa_indicator=@farm_produce_fair_gfa_indicator,");
			strSql.Append("tciunset1=@tciunset1,");
			strSql.Append("tciunset2=@tciunset2,");
			strSql.Append("tciunset3=@tciunset3,");
			strSql.Append("tciunset4=@tciunset4,");
			strSql.Append("tciunset5=@tciunset5,");
			strSql.Append("tciunset6=@tciunset6,");
			strSql.Append("tciunset7=@tciunset7,");
			strSql.Append("tciunset8=@tciunset8,");
			strSql.Append("tciunset9=@tciunset9,");
			strSql.Append("tciunset10=@tciunset10,");
			strSql.Append("tciunset11=@tciunset11,");
			strSql.Append("tciunset12=@tciunset12,");
			strSql.Append("tciunset13=@tciunset13,");
			strSql.Append("tciunset14=@tciunset14,");
			strSql.Append("tciunset15=@tciunset15,");
			strSql.Append("tciunset16=@tciunset16,");
			strSql.Append("tciunset17=@tciunset17,");
			strSql.Append("tciunset18=@tciunset18,");
			strSql.Append("tciunset19=@tciunset19,");
			strSql.Append("tciunset20=@tciunset20,");
			strSql.Append("tciunset21=@tciunset21,");
			strSql.Append("tciunset22=@tciunset22,");
			strSql.Append("tciunset23=@tciunset23,");
			strSql.Append("tciunset24=@tciunset24,");
			strSql.Append("tciunset25=@tciunset25,");
			strSql.Append("tciunset26=@tciunset26,");
			strSql.Append("tciunset27=@tciunset27,");
			strSql.Append("tciunset28=@tciunset28,");
			strSql.Append("tciunset29=@tciunset29,");
			strSql.Append("tciunset30=@tciunset30,");
			strSql.Append("tciunset31=@tciunset31,");
			strSql.Append("tciunset32=@tciunset32,");
			strSql.Append("tciunset33=@tciunset33,");
			strSql.Append("tciunset34=@tciunset34,");
			strSql.Append("tciunset35=@tciunset35,");
			strSql.Append("tciunset36=@tciunset36,");
			strSql.Append("tciunset37=@tciunset37,");
			strSql.Append("tciunset38=@tciunset38,");
			strSql.Append("tciunset39=@tciunset39,");
			strSql.Append("tciunset40=@tciunset40,");
			strSql.Append("tciunset41=@tciunset41,");
			strSql.Append("tciunset42=@tciunset42,");
			strSql.Append("tciunset43=@tciunset43,");
			strSql.Append("tciunset44=@tciunset44,");
			strSql.Append("tciunset45=@tciunset45,");
			strSql.Append("tciunset46=@tciunset46,");
			strSql.Append("tciunset47=@tciunset47,");
			strSql.Append("tciunset48=@tciunset48,");
			strSql.Append("tciunset49=@tciunset49,");
			strSql.Append("tciunset50=@tciunset50,");
			strSql.Append("tciunset51=@tciunset51,");
			strSql.Append("tciunset52=@tciunset52,");
			strSql.Append("tciunset53=@tciunset53,");
			strSql.Append("tciunset54=@tciunset54,");
			strSql.Append("tciunset55=@tciunset55,");
			strSql.Append("tciunset56=@tciunset56,");
			strSql.Append("tciunset57=@tciunset57,");
			strSql.Append("tciunset58=@tciunset58,");
			strSql.Append("tciunset59=@tciunset59,");
			strSql.Append("tciunset60=@tciunset60,");
			strSql.Append("tciunset61=@tciunset61,");
			strSql.Append("tciunset62=@tciunset62,");
			strSql.Append("tciunset63=@tciunset63,");
			strSql.Append("tciunset64=@tciunset64,");
			strSql.Append("tciunset65=@tciunset65,");
			strSql.Append("tciunset66=@tciunset66,");
			strSql.Append("tciunset67=@tciunset67,");
			strSql.Append("tciunset68=@tciunset68,");
			strSql.Append("tciunset69=@tciunset69,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("house_area_per_people=@house_area_per_people,");
			strSql.Append("community_help_figure=@community_help_figure,");
			strSql.Append("community_develop_figure=@community_develop_figure,");
			strSql.Append("community_engel_coefficient=@community_engel_coefficient,");
			strSql.Append("community_gini_coefficient=@community_gini_coefficient");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_pop_total_density", SqlDbType.Float,8),
					new SqlParameter("@community_pop_pure_density", SqlDbType.Float,8),
					new SqlParameter("@community_plot_ratio", SqlDbType.Float,8),
					new SqlParameter("@community_conhou_struc_safe_problem_rate", SqlDbType.Float,8),
					new SqlParameter("@community_conhou_seepage_rate", SqlDbType.Float,8),
					new SqlParameter("@community_conhou_tile_paint_cra_holl_rate", SqlDbType.Float,8),
					new SqlParameter("@community_road_density", SqlDbType.Float,8),
					new SqlParameter("@road_per_capita_availability", SqlDbType.Float,8),
					new SqlParameter("@no_hard_road_rate", SqlDbType.Float,8),
					new SqlParameter("@damage_road_rate", SqlDbType.Float,8),
					new SqlParameter("@large_slope_road_rate", SqlDbType.Float,8),
					new SqlParameter("@lack_width_road_rate", SqlDbType.Float,8),
					new SqlParameter("@need_new_repair_road_rate", SqlDbType.Float,8),
					new SqlParameter("@need_improve_link_ots_road", SqlDbType.Float,8),
					new SqlParameter("@no_brick_road_rate", SqlDbType.Float,8),
					new SqlParameter("@damage_brick_road_rate", SqlDbType.Float,8),
					new SqlParameter("@tap_water_fam_rate", SqlDbType.Float,8),
					new SqlParameter("@no_water_meter_house_rate", SqlDbType.Float,8),
					new SqlParameter("@water_supply_insuff_family_rate", SqlDbType.Float,8),
					new SqlParameter("@water_pressure_insuff_family_rate", SqlDbType.Float,8),
					new SqlParameter("@caliber_samll_pipe_lenth_rate", SqlDbType.Float,8),
					new SqlParameter("@damage_pipe_lenth_rate", SqlDbType.Float,8),
					new SqlParameter("@senescent_erosive_pipe_length_rate", SqlDbType.Float,8),
					new SqlParameter("@sewage_collection_rate", SqlDbType.Float,8),
					new SqlParameter("@sewage_handle_rate", SqlDbType.Float,8),
					new SqlParameter("@not_reasonable_drain_pipe_rate", SqlDbType.Float,8),
					new SqlParameter("@caliber_samll_drain_pipe_rate", SqlDbType.Float,8),
					new SqlParameter("@septic_tank_capacity_small_rate", SqlDbType.Float,8),
					new SqlParameter("@senescent_erosive_drain_pipe_length_rate", SqlDbType.Float,8),
					new SqlParameter("@damage_drain_pipe_rate", SqlDbType.Float,8),
					new SqlParameter("@broken_leaking_septic_tank_rate", SqlDbType.Float,8),
					new SqlParameter("@no_link_drain_pipe_net_famliy_rate", SqlDbType.Float,8),
					new SqlParameter("@elec_reliable_rate", SqlDbType.Float,8),
					new SqlParameter("@elec_capacity_lack_family_rate", SqlDbType.Float,8),
					new SqlParameter("@senescent_elec_wireways_rate", SqlDbType.Float,8),
					new SqlParameter("@no_elec_meter_house_rate", SqlDbType.Float,8),
					new SqlParameter("@not_norm_transformer_rate", SqlDbType.Float,8),
					new SqlParameter("@no_light_road_length_rate", SqlDbType.Float,8),
					new SqlParameter("@lack_light_road_rate", SqlDbType.Float,8),
					new SqlParameter("@damage_road_light_rate", SqlDbType.Float,8),
					new SqlParameter("@passway_light_wireway_damage_house_rate", SqlDbType.Float,8),
					new SqlParameter("@passway_light_wireway_damage_family_rate", SqlDbType.Float,8),
					new SqlParameter("@greenland_rate", SqlDbType.Float,8),
					new SqlParameter("@greenland_per_capita_area", SqlDbType.Float,8),
					new SqlParameter("@no_lack_afforest_road_length_rate", SqlDbType.Float,8),
					new SqlParameter("@no_lack_afforest_house_rate", SqlDbType.Float,8),
					new SqlParameter("@lack_otds_hydrant_road_length_rate", SqlDbType.Float,8),
					new SqlParameter("@lack_inds_hydrant_house_rate", SqlDbType.Float,8),
					new SqlParameter("@extinguisher_insuff_building_rate", SqlDbType.Float,8),
					new SqlParameter("@ff_pipe_damage_length_rate", SqlDbType.Float,8),
					new SqlParameter("@ff_road_block_building_rate", SqlDbType.Float,8),
					new SqlParameter("@rubbish_collection_rate", SqlDbType.Float,8),
					new SqlParameter("@rubbish_handle_rate", SqlDbType.Float,8),
					new SqlParameter("@dustbin_lack_road_length_rate", SqlDbType.Float,8),
					new SqlParameter("@dustbin_lack_house_rate", SqlDbType.Float,8),
					new SqlParameter("@long_term_rubbish_stack_rate", SqlDbType.Float,8),
					new SqlParameter("@education_fs_indicator", SqlDbType.Float,8),
					new SqlParameter("@education_gfa_indicator", SqlDbType.Float,8),
					new SqlParameter("@medical_fs_indicator", SqlDbType.Float,8),
					new SqlParameter("@medical_gfa_indicator", SqlDbType.Float,8),
					new SqlParameter("@culture_sports_fs_indicator", SqlDbType.Float,8),
					new SqlParameter("@culture_sports_gfa_indicator", SqlDbType.Float,8),
					new SqlParameter("@community_service_fs_indicator", SqlDbType.Float,8),
					new SqlParameter("@community_service_gfa_indicator", SqlDbType.Float,8),
					new SqlParameter("@commerce_fs_indicator", SqlDbType.Float,8),
					new SqlParameter("@commerce_gfa_indicator", SqlDbType.Float,8),
					new SqlParameter("@farm_produce_fair_fs_indicator", SqlDbType.Float,8),
					new SqlParameter("@farm_produce_fair_gfa_indicator", SqlDbType.Float,8),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset21", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset22", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset23", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset24", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset25", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset26", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset27", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset28", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset29", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset30", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset31", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset32", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset33", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset34", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset35", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset36", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset37", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset38", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset39", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset40", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset41", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset42", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset43", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset44", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset45", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset46", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset47", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset48", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset49", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset50", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset51", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset52", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset53", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset54", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset55", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset56", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset57", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset58", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset59", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset60", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset61", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset62", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset63", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset64", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset65", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset66", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset67", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset68", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset69", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@house_area_per_people", SqlDbType.Float,8),
					new SqlParameter("@community_help_figure", SqlDbType.Float,8),
					new SqlParameter("@community_develop_figure", SqlDbType.Float,8),
					new SqlParameter("@community_engel_coefficient", SqlDbType.Float,8),
					new SqlParameter("@community_gini_coefficient", SqlDbType.Float,8),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_pop_total_density;
			parameters[1].Value = model.community_pop_pure_density;
			parameters[2].Value = model.community_plot_ratio;
			parameters[3].Value = model.community_conhou_struc_safe_problem_rate;
			parameters[4].Value = model.community_conhou_seepage_rate;
			parameters[5].Value = model.community_conhou_tile_paint_cra_holl_rate;
			parameters[6].Value = model.community_road_density;
			parameters[7].Value = model.road_per_capita_availability;
			parameters[8].Value = model.no_hard_road_rate;
			parameters[9].Value = model.damage_road_rate;
			parameters[10].Value = model.large_slope_road_rate;
			parameters[11].Value = model.lack_width_road_rate;
			parameters[12].Value = model.need_new_repair_road_rate;
			parameters[13].Value = model.need_improve_link_ots_road;
			parameters[14].Value = model.no_brick_road_rate;
			parameters[15].Value = model.damage_brick_road_rate;
			parameters[16].Value = model.tap_water_fam_rate;
			parameters[17].Value = model.no_water_meter_house_rate;
			parameters[18].Value = model.water_supply_insuff_family_rate;
			parameters[19].Value = model.water_pressure_insuff_family_rate;
			parameters[20].Value = model.caliber_samll_pipe_lenth_rate;
			parameters[21].Value = model.damage_pipe_lenth_rate;
			parameters[22].Value = model.senescent_erosive_pipe_length_rate;
			parameters[23].Value = model.sewage_collection_rate;
			parameters[24].Value = model.sewage_handle_rate;
			parameters[25].Value = model.not_reasonable_drain_pipe_rate;
			parameters[26].Value = model.caliber_samll_drain_pipe_rate;
			parameters[27].Value = model.septic_tank_capacity_small_rate;
			parameters[28].Value = model.senescent_erosive_drain_pipe_length_rate;
			parameters[29].Value = model.damage_drain_pipe_rate;
			parameters[30].Value = model.broken_leaking_septic_tank_rate;
			parameters[31].Value = model.no_link_drain_pipe_net_famliy_rate;
			parameters[32].Value = model.elec_reliable_rate;
			parameters[33].Value = model.elec_capacity_lack_family_rate;
			parameters[34].Value = model.senescent_elec_wireways_rate;
			parameters[35].Value = model.no_elec_meter_house_rate;
			parameters[36].Value = model.not_norm_transformer_rate;
			parameters[37].Value = model.no_light_road_length_rate;
			parameters[38].Value = model.lack_light_road_rate;
			parameters[39].Value = model.damage_road_light_rate;
			parameters[40].Value = model.passway_light_wireway_damage_house_rate;
			parameters[41].Value = model.passway_light_wireway_damage_family_rate;
			parameters[42].Value = model.greenland_rate;
			parameters[43].Value = model.greenland_per_capita_area;
			parameters[44].Value = model.no_lack_afforest_road_length_rate;
			parameters[45].Value = model.no_lack_afforest_house_rate;
			parameters[46].Value = model.lack_otds_hydrant_road_length_rate;
			parameters[47].Value = model.lack_inds_hydrant_house_rate;
			parameters[48].Value = model.extinguisher_insuff_building_rate;
			parameters[49].Value = model.ff_pipe_damage_length_rate;
			parameters[50].Value = model.ff_road_block_building_rate;
			parameters[51].Value = model.rubbish_collection_rate;
			parameters[52].Value = model.rubbish_handle_rate;
			parameters[53].Value = model.dustbin_lack_road_length_rate;
			parameters[54].Value = model.dustbin_lack_house_rate;
			parameters[55].Value = model.long_term_rubbish_stack_rate;
			parameters[56].Value = model.education_fs_indicator;
			parameters[57].Value = model.education_gfa_indicator;
			parameters[58].Value = model.medical_fs_indicator;
			parameters[59].Value = model.medical_gfa_indicator;
			parameters[60].Value = model.culture_sports_fs_indicator;
			parameters[61].Value = model.culture_sports_gfa_indicator;
			parameters[62].Value = model.community_service_fs_indicator;
			parameters[63].Value = model.community_service_gfa_indicator;
			parameters[64].Value = model.commerce_fs_indicator;
			parameters[65].Value = model.commerce_gfa_indicator;
			parameters[66].Value = model.farm_produce_fair_fs_indicator;
			parameters[67].Value = model.farm_produce_fair_gfa_indicator;
			parameters[68].Value = model.tciunset1;
			parameters[69].Value = model.tciunset2;
			parameters[70].Value = model.tciunset3;
			parameters[71].Value = model.tciunset4;
			parameters[72].Value = model.tciunset5;
			parameters[73].Value = model.tciunset6;
			parameters[74].Value = model.tciunset7;
			parameters[75].Value = model.tciunset8;
			parameters[76].Value = model.tciunset9;
			parameters[77].Value = model.tciunset10;
			parameters[78].Value = model.tciunset11;
			parameters[79].Value = model.tciunset12;
			parameters[80].Value = model.tciunset13;
			parameters[81].Value = model.tciunset14;
			parameters[82].Value = model.tciunset15;
			parameters[83].Value = model.tciunset16;
			parameters[84].Value = model.tciunset17;
			parameters[85].Value = model.tciunset18;
			parameters[86].Value = model.tciunset19;
			parameters[87].Value = model.tciunset20;
			parameters[88].Value = model.tciunset21;
			parameters[89].Value = model.tciunset22;
			parameters[90].Value = model.tciunset23;
			parameters[91].Value = model.tciunset24;
			parameters[92].Value = model.tciunset25;
			parameters[93].Value = model.tciunset26;
			parameters[94].Value = model.tciunset27;
			parameters[95].Value = model.tciunset28;
			parameters[96].Value = model.tciunset29;
			parameters[97].Value = model.tciunset30;
			parameters[98].Value = model.tciunset31;
			parameters[99].Value = model.tciunset32;
			parameters[100].Value = model.tciunset33;
			parameters[101].Value = model.tciunset34;
			parameters[102].Value = model.tciunset35;
			parameters[103].Value = model.tciunset36;
			parameters[104].Value = model.tciunset37;
			parameters[105].Value = model.tciunset38;
			parameters[106].Value = model.tciunset39;
			parameters[107].Value = model.tciunset40;
			parameters[108].Value = model.tciunset41;
			parameters[109].Value = model.tciunset42;
			parameters[110].Value = model.tciunset43;
			parameters[111].Value = model.tciunset44;
			parameters[112].Value = model.tciunset45;
			parameters[113].Value = model.tciunset46;
			parameters[114].Value = model.tciunset47;
			parameters[115].Value = model.tciunset48;
			parameters[116].Value = model.tciunset49;
			parameters[117].Value = model.tciunset50;
			parameters[118].Value = model.tciunset51;
			parameters[119].Value = model.tciunset52;
			parameters[120].Value = model.tciunset53;
			parameters[121].Value = model.tciunset54;
			parameters[122].Value = model.tciunset55;
			parameters[123].Value = model.tciunset56;
			parameters[124].Value = model.tciunset57;
			parameters[125].Value = model.tciunset58;
			parameters[126].Value = model.tciunset59;
			parameters[127].Value = model.tciunset60;
			parameters[128].Value = model.tciunset61;
			parameters[129].Value = model.tciunset62;
			parameters[130].Value = model.tciunset63;
			parameters[131].Value = model.tciunset64;
			parameters[132].Value = model.tciunset65;
			parameters[133].Value = model.tciunset66;
			parameters[134].Value = model.tciunset67;
			parameters[135].Value = model.tciunset68;
			parameters[136].Value = model.tciunset69;
			parameters[137].Value = model.check_status;
			parameters[138].Value = model.lock_tables;
			parameters[139].Value = model.house_area_per_people;
			parameters[140].Value = model.community_help_figure;
			parameters[141].Value = model.community_develop_figure;
			parameters[142].Value = model.community_engel_coefficient;
			parameters[143].Value = model.community_gini_coefficient;
			parameters[144].Value = model.community_id;
			parameters[145].Value = model.statistics_date;

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
			strSql.Append("delete from T_Community_Indicator ");
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
		public TTG.Model.TTGWeb.Community_Indicator GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_pop_total_density,community_pop_pure_density,community_plot_ratio,community_conhou_struc_safe_problem_rate,community_conhou_seepage_rate,community_conhou_tile_paint_cra_holl_rate,community_road_density,road_per_capita_availability,no_hard_road_rate,damage_road_rate,large_slope_road_rate,lack_width_road_rate,need_new_repair_road_rate,need_improve_link_ots_road,no_brick_road_rate,damage_brick_road_rate,tap_water_fam_rate,no_water_meter_house_rate,water_supply_insuff_family_rate,water_pressure_insuff_family_rate,caliber_samll_pipe_lenth_rate,damage_pipe_lenth_rate,senescent_erosive_pipe_length_rate,sewage_collection_rate,sewage_handle_rate,not_reasonable_drain_pipe_rate,caliber_samll_drain_pipe_rate,septic_tank_capacity_small_rate,senescent_erosive_drain_pipe_length_rate,damage_drain_pipe_rate,broken_leaking_septic_tank_rate,no_link_drain_pipe_net_famliy_rate,elec_reliable_rate,elec_capacity_lack_family_rate,senescent_elec_wireways_rate,no_elec_meter_house_rate,not_norm_transformer_rate,no_light_road_length_rate,lack_light_road_rate,damage_road_light_rate,passway_light_wireway_damage_house_rate,passway_light_wireway_damage_family_rate,greenland_rate,greenland_per_capita_area,no_lack_afforest_road_length_rate,no_lack_afforest_house_rate,lack_otds_hydrant_road_length_rate,lack_inds_hydrant_house_rate,extinguisher_insuff_building_rate,ff_pipe_damage_length_rate,ff_road_block_building_rate,rubbish_collection_rate,rubbish_handle_rate,dustbin_lack_road_length_rate,dustbin_lack_house_rate,long_term_rubbish_stack_rate,education_fs_indicator,education_gfa_indicator,medical_fs_indicator,medical_gfa_indicator,culture_sports_fs_indicator,culture_sports_gfa_indicator,community_service_fs_indicator,community_service_gfa_indicator,commerce_fs_indicator,commerce_gfa_indicator,farm_produce_fair_fs_indicator,farm_produce_fair_gfa_indicator,statistics_date,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,tciunset15,tciunset16,tciunset17,tciunset18,tciunset19,tciunset20,tciunset21,tciunset22,tciunset23,tciunset24,tciunset25,tciunset26,tciunset27,tciunset28,tciunset29,tciunset30,tciunset31,tciunset32,tciunset33,tciunset34,tciunset35,tciunset36,tciunset37,tciunset38,tciunset39,tciunset40,tciunset41,tciunset42,tciunset43,tciunset44,tciunset45,tciunset46,tciunset47,tciunset48,tciunset49,tciunset50,tciunset51,tciunset52,tciunset53,tciunset54,tciunset55,tciunset56,tciunset57,tciunset58,tciunset59,tciunset60,tciunset61,tciunset62,tciunset63,tciunset64,tciunset65,tciunset66,tciunset67,tciunset68,tciunset69,check_status,lock_tables,house_area_per_people,community_help_figure,community_develop_figure,community_engel_coefficient,community_gini_coefficient from T_Community_Indicator ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.Community_Indicator model=new TTG.Model.TTGWeb.Community_Indicator();
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
		public TTG.Model.TTGWeb.Community_Indicator DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.Community_Indicator model=new TTG.Model.TTGWeb.Community_Indicator();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_pop_total_density"]!=null && row["community_pop_total_density"].ToString()!="")
				{
					model.community_pop_total_density=decimal.Parse(row["community_pop_total_density"].ToString());
				}
				if(row["community_pop_pure_density"]!=null && row["community_pop_pure_density"].ToString()!="")
				{
					model.community_pop_pure_density=decimal.Parse(row["community_pop_pure_density"].ToString());
				}
				if(row["community_plot_ratio"]!=null && row["community_plot_ratio"].ToString()!="")
				{
					model.community_plot_ratio=decimal.Parse(row["community_plot_ratio"].ToString());
				}
				if(row["community_conhou_struc_safe_problem_rate"]!=null && row["community_conhou_struc_safe_problem_rate"].ToString()!="")
				{
					model.community_conhou_struc_safe_problem_rate=decimal.Parse(row["community_conhou_struc_safe_problem_rate"].ToString());
				}
				if(row["community_conhou_seepage_rate"]!=null && row["community_conhou_seepage_rate"].ToString()!="")
				{
					model.community_conhou_seepage_rate=decimal.Parse(row["community_conhou_seepage_rate"].ToString());
				}
				if(row["community_conhou_tile_paint_cra_holl_rate"]!=null && row["community_conhou_tile_paint_cra_holl_rate"].ToString()!="")
				{
					model.community_conhou_tile_paint_cra_holl_rate=decimal.Parse(row["community_conhou_tile_paint_cra_holl_rate"].ToString());
				}
				if(row["community_road_density"]!=null && row["community_road_density"].ToString()!="")
				{
					model.community_road_density=decimal.Parse(row["community_road_density"].ToString());
				}
				if(row["road_per_capita_availability"]!=null && row["road_per_capita_availability"].ToString()!="")
				{
					model.road_per_capita_availability=decimal.Parse(row["road_per_capita_availability"].ToString());
				}
				if(row["no_hard_road_rate"]!=null && row["no_hard_road_rate"].ToString()!="")
				{
					model.no_hard_road_rate=decimal.Parse(row["no_hard_road_rate"].ToString());
				}
				if(row["damage_road_rate"]!=null && row["damage_road_rate"].ToString()!="")
				{
					model.damage_road_rate=decimal.Parse(row["damage_road_rate"].ToString());
				}
				if(row["large_slope_road_rate"]!=null && row["large_slope_road_rate"].ToString()!="")
				{
					model.large_slope_road_rate=decimal.Parse(row["large_slope_road_rate"].ToString());
				}
				if(row["lack_width_road_rate"]!=null && row["lack_width_road_rate"].ToString()!="")
				{
					model.lack_width_road_rate=decimal.Parse(row["lack_width_road_rate"].ToString());
				}
				if(row["need_new_repair_road_rate"]!=null && row["need_new_repair_road_rate"].ToString()!="")
				{
					model.need_new_repair_road_rate=decimal.Parse(row["need_new_repair_road_rate"].ToString());
				}
				if(row["need_improve_link_ots_road"]!=null && row["need_improve_link_ots_road"].ToString()!="")
				{
					model.need_improve_link_ots_road=decimal.Parse(row["need_improve_link_ots_road"].ToString());
				}
				if(row["no_brick_road_rate"]!=null && row["no_brick_road_rate"].ToString()!="")
				{
					model.no_brick_road_rate=decimal.Parse(row["no_brick_road_rate"].ToString());
				}
				if(row["damage_brick_road_rate"]!=null && row["damage_brick_road_rate"].ToString()!="")
				{
					model.damage_brick_road_rate=decimal.Parse(row["damage_brick_road_rate"].ToString());
				}
				if(row["tap_water_fam_rate"]!=null && row["tap_water_fam_rate"].ToString()!="")
				{
					model.tap_water_fam_rate=decimal.Parse(row["tap_water_fam_rate"].ToString());
				}
				if(row["no_water_meter_house_rate"]!=null && row["no_water_meter_house_rate"].ToString()!="")
				{
					model.no_water_meter_house_rate=decimal.Parse(row["no_water_meter_house_rate"].ToString());
				}
				if(row["water_supply_insuff_family_rate"]!=null && row["water_supply_insuff_family_rate"].ToString()!="")
				{
					model.water_supply_insuff_family_rate=decimal.Parse(row["water_supply_insuff_family_rate"].ToString());
				}
				if(row["water_pressure_insuff_family_rate"]!=null && row["water_pressure_insuff_family_rate"].ToString()!="")
				{
					model.water_pressure_insuff_family_rate=decimal.Parse(row["water_pressure_insuff_family_rate"].ToString());
				}
				if(row["caliber_samll_pipe_lenth_rate"]!=null && row["caliber_samll_pipe_lenth_rate"].ToString()!="")
				{
					model.caliber_samll_pipe_lenth_rate=decimal.Parse(row["caliber_samll_pipe_lenth_rate"].ToString());
				}
				if(row["damage_pipe_lenth_rate"]!=null && row["damage_pipe_lenth_rate"].ToString()!="")
				{
					model.damage_pipe_lenth_rate=decimal.Parse(row["damage_pipe_lenth_rate"].ToString());
				}
				if(row["senescent_erosive_pipe_length_rate"]!=null && row["senescent_erosive_pipe_length_rate"].ToString()!="")
				{
					model.senescent_erosive_pipe_length_rate=decimal.Parse(row["senescent_erosive_pipe_length_rate"].ToString());
				}
				if(row["sewage_collection_rate"]!=null && row["sewage_collection_rate"].ToString()!="")
				{
					model.sewage_collection_rate=decimal.Parse(row["sewage_collection_rate"].ToString());
				}
				if(row["sewage_handle_rate"]!=null && row["sewage_handle_rate"].ToString()!="")
				{
					model.sewage_handle_rate=decimal.Parse(row["sewage_handle_rate"].ToString());
				}
				if(row["not_reasonable_drain_pipe_rate"]!=null && row["not_reasonable_drain_pipe_rate"].ToString()!="")
				{
					model.not_reasonable_drain_pipe_rate=decimal.Parse(row["not_reasonable_drain_pipe_rate"].ToString());
				}
				if(row["caliber_samll_drain_pipe_rate"]!=null && row["caliber_samll_drain_pipe_rate"].ToString()!="")
				{
					model.caliber_samll_drain_pipe_rate=decimal.Parse(row["caliber_samll_drain_pipe_rate"].ToString());
				}
				if(row["septic_tank_capacity_small_rate"]!=null && row["septic_tank_capacity_small_rate"].ToString()!="")
				{
					model.septic_tank_capacity_small_rate=decimal.Parse(row["septic_tank_capacity_small_rate"].ToString());
				}
				if(row["senescent_erosive_drain_pipe_length_rate"]!=null && row["senescent_erosive_drain_pipe_length_rate"].ToString()!="")
				{
					model.senescent_erosive_drain_pipe_length_rate=decimal.Parse(row["senescent_erosive_drain_pipe_length_rate"].ToString());
				}
				if(row["damage_drain_pipe_rate"]!=null && row["damage_drain_pipe_rate"].ToString()!="")
				{
					model.damage_drain_pipe_rate=decimal.Parse(row["damage_drain_pipe_rate"].ToString());
				}
				if(row["broken_leaking_septic_tank_rate"]!=null && row["broken_leaking_septic_tank_rate"].ToString()!="")
				{
					model.broken_leaking_septic_tank_rate=decimal.Parse(row["broken_leaking_septic_tank_rate"].ToString());
				}
				if(row["no_link_drain_pipe_net_famliy_rate"]!=null && row["no_link_drain_pipe_net_famliy_rate"].ToString()!="")
				{
					model.no_link_drain_pipe_net_famliy_rate=decimal.Parse(row["no_link_drain_pipe_net_famliy_rate"].ToString());
				}
				if(row["elec_reliable_rate"]!=null && row["elec_reliable_rate"].ToString()!="")
				{
					model.elec_reliable_rate=decimal.Parse(row["elec_reliable_rate"].ToString());
				}
				if(row["elec_capacity_lack_family_rate"]!=null && row["elec_capacity_lack_family_rate"].ToString()!="")
				{
					model.elec_capacity_lack_family_rate=decimal.Parse(row["elec_capacity_lack_family_rate"].ToString());
				}
				if(row["senescent_elec_wireways_rate"]!=null && row["senescent_elec_wireways_rate"].ToString()!="")
				{
					model.senescent_elec_wireways_rate=decimal.Parse(row["senescent_elec_wireways_rate"].ToString());
				}
				if(row["no_elec_meter_house_rate"]!=null && row["no_elec_meter_house_rate"].ToString()!="")
				{
					model.no_elec_meter_house_rate=decimal.Parse(row["no_elec_meter_house_rate"].ToString());
				}
				if(row["not_norm_transformer_rate"]!=null && row["not_norm_transformer_rate"].ToString()!="")
				{
					model.not_norm_transformer_rate=decimal.Parse(row["not_norm_transformer_rate"].ToString());
				}
				if(row["no_light_road_length_rate"]!=null && row["no_light_road_length_rate"].ToString()!="")
				{
					model.no_light_road_length_rate=decimal.Parse(row["no_light_road_length_rate"].ToString());
				}
				if(row["lack_light_road_rate"]!=null && row["lack_light_road_rate"].ToString()!="")
				{
					model.lack_light_road_rate=decimal.Parse(row["lack_light_road_rate"].ToString());
				}
				if(row["damage_road_light_rate"]!=null && row["damage_road_light_rate"].ToString()!="")
				{
					model.damage_road_light_rate=decimal.Parse(row["damage_road_light_rate"].ToString());
				}
				if(row["passway_light_wireway_damage_house_rate"]!=null && row["passway_light_wireway_damage_house_rate"].ToString()!="")
				{
					model.passway_light_wireway_damage_house_rate=decimal.Parse(row["passway_light_wireway_damage_house_rate"].ToString());
				}
				if(row["passway_light_wireway_damage_family_rate"]!=null && row["passway_light_wireway_damage_family_rate"].ToString()!="")
				{
					model.passway_light_wireway_damage_family_rate=decimal.Parse(row["passway_light_wireway_damage_family_rate"].ToString());
				}
				if(row["greenland_rate"]!=null && row["greenland_rate"].ToString()!="")
				{
					model.greenland_rate=decimal.Parse(row["greenland_rate"].ToString());
				}
				if(row["greenland_per_capita_area"]!=null && row["greenland_per_capita_area"].ToString()!="")
				{
					model.greenland_per_capita_area=decimal.Parse(row["greenland_per_capita_area"].ToString());
				}
				if(row["no_lack_afforest_road_length_rate"]!=null && row["no_lack_afforest_road_length_rate"].ToString()!="")
				{
					model.no_lack_afforest_road_length_rate=decimal.Parse(row["no_lack_afforest_road_length_rate"].ToString());
				}
				if(row["no_lack_afforest_house_rate"]!=null && row["no_lack_afforest_house_rate"].ToString()!="")
				{
					model.no_lack_afforest_house_rate=decimal.Parse(row["no_lack_afforest_house_rate"].ToString());
				}
				if(row["lack_otds_hydrant_road_length_rate"]!=null && row["lack_otds_hydrant_road_length_rate"].ToString()!="")
				{
					model.lack_otds_hydrant_road_length_rate=decimal.Parse(row["lack_otds_hydrant_road_length_rate"].ToString());
				}
				if(row["lack_inds_hydrant_house_rate"]!=null && row["lack_inds_hydrant_house_rate"].ToString()!="")
				{
					model.lack_inds_hydrant_house_rate=decimal.Parse(row["lack_inds_hydrant_house_rate"].ToString());
				}
				if(row["extinguisher_insuff_building_rate"]!=null && row["extinguisher_insuff_building_rate"].ToString()!="")
				{
					model.extinguisher_insuff_building_rate=decimal.Parse(row["extinguisher_insuff_building_rate"].ToString());
				}
				if(row["ff_pipe_damage_length_rate"]!=null && row["ff_pipe_damage_length_rate"].ToString()!="")
				{
					model.ff_pipe_damage_length_rate=decimal.Parse(row["ff_pipe_damage_length_rate"].ToString());
				}
				if(row["ff_road_block_building_rate"]!=null && row["ff_road_block_building_rate"].ToString()!="")
				{
					model.ff_road_block_building_rate=decimal.Parse(row["ff_road_block_building_rate"].ToString());
				}
				if(row["rubbish_collection_rate"]!=null && row["rubbish_collection_rate"].ToString()!="")
				{
					model.rubbish_collection_rate=decimal.Parse(row["rubbish_collection_rate"].ToString());
				}
				if(row["rubbish_handle_rate"]!=null && row["rubbish_handle_rate"].ToString()!="")
				{
					model.rubbish_handle_rate=decimal.Parse(row["rubbish_handle_rate"].ToString());
				}
				if(row["dustbin_lack_road_length_rate"]!=null && row["dustbin_lack_road_length_rate"].ToString()!="")
				{
					model.dustbin_lack_road_length_rate=decimal.Parse(row["dustbin_lack_road_length_rate"].ToString());
				}
				if(row["dustbin_lack_house_rate"]!=null && row["dustbin_lack_house_rate"].ToString()!="")
				{
					model.dustbin_lack_house_rate=decimal.Parse(row["dustbin_lack_house_rate"].ToString());
				}
				if(row["long_term_rubbish_stack_rate"]!=null && row["long_term_rubbish_stack_rate"].ToString()!="")
				{
					model.long_term_rubbish_stack_rate=decimal.Parse(row["long_term_rubbish_stack_rate"].ToString());
				}
				if(row["education_fs_indicator"]!=null && row["education_fs_indicator"].ToString()!="")
				{
					model.education_fs_indicator=decimal.Parse(row["education_fs_indicator"].ToString());
				}
				if(row["education_gfa_indicator"]!=null && row["education_gfa_indicator"].ToString()!="")
				{
					model.education_gfa_indicator=decimal.Parse(row["education_gfa_indicator"].ToString());
				}
				if(row["medical_fs_indicator"]!=null && row["medical_fs_indicator"].ToString()!="")
				{
					model.medical_fs_indicator=decimal.Parse(row["medical_fs_indicator"].ToString());
				}
				if(row["medical_gfa_indicator"]!=null && row["medical_gfa_indicator"].ToString()!="")
				{
					model.medical_gfa_indicator=decimal.Parse(row["medical_gfa_indicator"].ToString());
				}
				if(row["culture_sports_fs_indicator"]!=null && row["culture_sports_fs_indicator"].ToString()!="")
				{
					model.culture_sports_fs_indicator=decimal.Parse(row["culture_sports_fs_indicator"].ToString());
				}
				if(row["culture_sports_gfa_indicator"]!=null && row["culture_sports_gfa_indicator"].ToString()!="")
				{
					model.culture_sports_gfa_indicator=decimal.Parse(row["culture_sports_gfa_indicator"].ToString());
				}
				if(row["community_service_fs_indicator"]!=null && row["community_service_fs_indicator"].ToString()!="")
				{
					model.community_service_fs_indicator=decimal.Parse(row["community_service_fs_indicator"].ToString());
				}
				if(row["community_service_gfa_indicator"]!=null && row["community_service_gfa_indicator"].ToString()!="")
				{
					model.community_service_gfa_indicator=decimal.Parse(row["community_service_gfa_indicator"].ToString());
				}
				if(row["commerce_fs_indicator"]!=null && row["commerce_fs_indicator"].ToString()!="")
				{
					model.commerce_fs_indicator=decimal.Parse(row["commerce_fs_indicator"].ToString());
				}
				if(row["commerce_gfa_indicator"]!=null && row["commerce_gfa_indicator"].ToString()!="")
				{
					model.commerce_gfa_indicator=decimal.Parse(row["commerce_gfa_indicator"].ToString());
				}
				if(row["farm_produce_fair_fs_indicator"]!=null && row["farm_produce_fair_fs_indicator"].ToString()!="")
				{
					model.farm_produce_fair_fs_indicator=decimal.Parse(row["farm_produce_fair_fs_indicator"].ToString());
				}
				if(row["farm_produce_fair_gfa_indicator"]!=null && row["farm_produce_fair_gfa_indicator"].ToString()!="")
				{
					model.farm_produce_fair_gfa_indicator=decimal.Parse(row["farm_produce_fair_gfa_indicator"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tciunset1"]!=null)
				{
					model.tciunset1=row["tciunset1"].ToString();
				}
				if(row["tciunset2"]!=null)
				{
					model.tciunset2=row["tciunset2"].ToString();
				}
				if(row["tciunset3"]!=null)
				{
					model.tciunset3=row["tciunset3"].ToString();
				}
				if(row["tciunset4"]!=null)
				{
					model.tciunset4=row["tciunset4"].ToString();
				}
				if(row["tciunset5"]!=null)
				{
					model.tciunset5=row["tciunset5"].ToString();
				}
				if(row["tciunset6"]!=null)
				{
					model.tciunset6=row["tciunset6"].ToString();
				}
				if(row["tciunset7"]!=null)
				{
					model.tciunset7=row["tciunset7"].ToString();
				}
				if(row["tciunset8"]!=null)
				{
					model.tciunset8=row["tciunset8"].ToString();
				}
				if(row["tciunset9"]!=null)
				{
					model.tciunset9=row["tciunset9"].ToString();
				}
				if(row["tciunset10"]!=null)
				{
					model.tciunset10=row["tciunset10"].ToString();
				}
				if(row["tciunset11"]!=null)
				{
					model.tciunset11=row["tciunset11"].ToString();
				}
				if(row["tciunset12"]!=null)
				{
					model.tciunset12=row["tciunset12"].ToString();
				}
				if(row["tciunset13"]!=null)
				{
					model.tciunset13=row["tciunset13"].ToString();
				}
				if(row["tciunset14"]!=null)
				{
					model.tciunset14=row["tciunset14"].ToString();
				}
				if(row["tciunset15"]!=null)
				{
					model.tciunset15=row["tciunset15"].ToString();
				}
				if(row["tciunset16"]!=null)
				{
					model.tciunset16=row["tciunset16"].ToString();
				}
				if(row["tciunset17"]!=null)
				{
					model.tciunset17=row["tciunset17"].ToString();
				}
				if(row["tciunset18"]!=null)
				{
					model.tciunset18=row["tciunset18"].ToString();
				}
				if(row["tciunset19"]!=null)
				{
					model.tciunset19=row["tciunset19"].ToString();
				}
				if(row["tciunset20"]!=null)
				{
					model.tciunset20=row["tciunset20"].ToString();
				}
				if(row["tciunset21"]!=null)
				{
					model.tciunset21=row["tciunset21"].ToString();
				}
				if(row["tciunset22"]!=null)
				{
					model.tciunset22=row["tciunset22"].ToString();
				}
				if(row["tciunset23"]!=null)
				{
					model.tciunset23=row["tciunset23"].ToString();
				}
				if(row["tciunset24"]!=null)
				{
					model.tciunset24=row["tciunset24"].ToString();
				}
				if(row["tciunset25"]!=null)
				{
					model.tciunset25=row["tciunset25"].ToString();
				}
				if(row["tciunset26"]!=null)
				{
					model.tciunset26=row["tciunset26"].ToString();
				}
				if(row["tciunset27"]!=null)
				{
					model.tciunset27=row["tciunset27"].ToString();
				}
				if(row["tciunset28"]!=null)
				{
					model.tciunset28=row["tciunset28"].ToString();
				}
				if(row["tciunset29"]!=null)
				{
					model.tciunset29=row["tciunset29"].ToString();
				}
				if(row["tciunset30"]!=null)
				{
					model.tciunset30=row["tciunset30"].ToString();
				}
				if(row["tciunset31"]!=null)
				{
					model.tciunset31=row["tciunset31"].ToString();
				}
				if(row["tciunset32"]!=null)
				{
					model.tciunset32=row["tciunset32"].ToString();
				}
				if(row["tciunset33"]!=null)
				{
					model.tciunset33=row["tciunset33"].ToString();
				}
				if(row["tciunset34"]!=null)
				{
					model.tciunset34=row["tciunset34"].ToString();
				}
				if(row["tciunset35"]!=null)
				{
					model.tciunset35=row["tciunset35"].ToString();
				}
				if(row["tciunset36"]!=null)
				{
					model.tciunset36=row["tciunset36"].ToString();
				}
				if(row["tciunset37"]!=null)
				{
					model.tciunset37=row["tciunset37"].ToString();
				}
				if(row["tciunset38"]!=null)
				{
					model.tciunset38=row["tciunset38"].ToString();
				}
				if(row["tciunset39"]!=null)
				{
					model.tciunset39=row["tciunset39"].ToString();
				}
				if(row["tciunset40"]!=null)
				{
					model.tciunset40=row["tciunset40"].ToString();
				}
				if(row["tciunset41"]!=null)
				{
					model.tciunset41=row["tciunset41"].ToString();
				}
				if(row["tciunset42"]!=null)
				{
					model.tciunset42=row["tciunset42"].ToString();
				}
				if(row["tciunset43"]!=null)
				{
					model.tciunset43=row["tciunset43"].ToString();
				}
				if(row["tciunset44"]!=null)
				{
					model.tciunset44=row["tciunset44"].ToString();
				}
				if(row["tciunset45"]!=null)
				{
					model.tciunset45=row["tciunset45"].ToString();
				}
				if(row["tciunset46"]!=null)
				{
					model.tciunset46=row["tciunset46"].ToString();
				}
				if(row["tciunset47"]!=null)
				{
					model.tciunset47=row["tciunset47"].ToString();
				}
				if(row["tciunset48"]!=null)
				{
					model.tciunset48=row["tciunset48"].ToString();
				}
				if(row["tciunset49"]!=null)
				{
					model.tciunset49=row["tciunset49"].ToString();
				}
				if(row["tciunset50"]!=null)
				{
					model.tciunset50=row["tciunset50"].ToString();
				}
				if(row["tciunset51"]!=null)
				{
					model.tciunset51=row["tciunset51"].ToString();
				}
				if(row["tciunset52"]!=null)
				{
					model.tciunset52=row["tciunset52"].ToString();
				}
				if(row["tciunset53"]!=null)
				{
					model.tciunset53=row["tciunset53"].ToString();
				}
				if(row["tciunset54"]!=null)
				{
					model.tciunset54=row["tciunset54"].ToString();
				}
				if(row["tciunset55"]!=null)
				{
					model.tciunset55=row["tciunset55"].ToString();
				}
				if(row["tciunset56"]!=null)
				{
					model.tciunset56=row["tciunset56"].ToString();
				}
				if(row["tciunset57"]!=null)
				{
					model.tciunset57=row["tciunset57"].ToString();
				}
				if(row["tciunset58"]!=null)
				{
					model.tciunset58=row["tciunset58"].ToString();
				}
				if(row["tciunset59"]!=null)
				{
					model.tciunset59=row["tciunset59"].ToString();
				}
				if(row["tciunset60"]!=null)
				{
					model.tciunset60=row["tciunset60"].ToString();
				}
				if(row["tciunset61"]!=null)
				{
					model.tciunset61=row["tciunset61"].ToString();
				}
				if(row["tciunset62"]!=null)
				{
					model.tciunset62=row["tciunset62"].ToString();
				}
				if(row["tciunset63"]!=null)
				{
					model.tciunset63=row["tciunset63"].ToString();
				}
				if(row["tciunset64"]!=null)
				{
					model.tciunset64=row["tciunset64"].ToString();
				}
				if(row["tciunset65"]!=null)
				{
					model.tciunset65=row["tciunset65"].ToString();
				}
				if(row["tciunset66"]!=null)
				{
					model.tciunset66=row["tciunset66"].ToString();
				}
				if(row["tciunset67"]!=null)
				{
					model.tciunset67=row["tciunset67"].ToString();
				}
				if(row["tciunset68"]!=null)
				{
					model.tciunset68=row["tciunset68"].ToString();
				}
				if(row["tciunset69"]!=null)
				{
					model.tciunset69=row["tciunset69"].ToString();
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["house_area_per_people"]!=null && row["house_area_per_people"].ToString()!="")
				{
					model.house_area_per_people=decimal.Parse(row["house_area_per_people"].ToString());
				}
				if(row["community_help_figure"]!=null && row["community_help_figure"].ToString()!="")
				{
					model.community_help_figure=decimal.Parse(row["community_help_figure"].ToString());
				}
				if(row["community_develop_figure"]!=null && row["community_develop_figure"].ToString()!="")
				{
					model.community_develop_figure=decimal.Parse(row["community_develop_figure"].ToString());
				}
				if(row["community_engel_coefficient"]!=null && row["community_engel_coefficient"].ToString()!="")
				{
					model.community_engel_coefficient=decimal.Parse(row["community_engel_coefficient"].ToString());
				}
				if(row["community_gini_coefficient"]!=null && row["community_gini_coefficient"].ToString()!="")
				{
					model.community_gini_coefficient=decimal.Parse(row["community_gini_coefficient"].ToString());
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
			strSql.Append("select community_id,community_pop_total_density,community_pop_pure_density,community_plot_ratio,community_conhou_struc_safe_problem_rate,community_conhou_seepage_rate,community_conhou_tile_paint_cra_holl_rate,community_road_density,road_per_capita_availability,no_hard_road_rate,damage_road_rate,large_slope_road_rate,lack_width_road_rate,need_new_repair_road_rate,need_improve_link_ots_road,no_brick_road_rate,damage_brick_road_rate,tap_water_fam_rate,no_water_meter_house_rate,water_supply_insuff_family_rate,water_pressure_insuff_family_rate,caliber_samll_pipe_lenth_rate,damage_pipe_lenth_rate,senescent_erosive_pipe_length_rate,sewage_collection_rate,sewage_handle_rate,not_reasonable_drain_pipe_rate,caliber_samll_drain_pipe_rate,septic_tank_capacity_small_rate,senescent_erosive_drain_pipe_length_rate,damage_drain_pipe_rate,broken_leaking_septic_tank_rate,no_link_drain_pipe_net_famliy_rate,elec_reliable_rate,elec_capacity_lack_family_rate,senescent_elec_wireways_rate,no_elec_meter_house_rate,not_norm_transformer_rate,no_light_road_length_rate,lack_light_road_rate,damage_road_light_rate,passway_light_wireway_damage_house_rate,passway_light_wireway_damage_family_rate,greenland_rate,greenland_per_capita_area,no_lack_afforest_road_length_rate,no_lack_afforest_house_rate,lack_otds_hydrant_road_length_rate,lack_inds_hydrant_house_rate,extinguisher_insuff_building_rate,ff_pipe_damage_length_rate,ff_road_block_building_rate,rubbish_collection_rate,rubbish_handle_rate,dustbin_lack_road_length_rate,dustbin_lack_house_rate,long_term_rubbish_stack_rate,education_fs_indicator,education_gfa_indicator,medical_fs_indicator,medical_gfa_indicator,culture_sports_fs_indicator,culture_sports_gfa_indicator,community_service_fs_indicator,community_service_gfa_indicator,commerce_fs_indicator,commerce_gfa_indicator,farm_produce_fair_fs_indicator,farm_produce_fair_gfa_indicator,statistics_date,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,tciunset15,tciunset16,tciunset17,tciunset18,tciunset19,tciunset20,tciunset21,tciunset22,tciunset23,tciunset24,tciunset25,tciunset26,tciunset27,tciunset28,tciunset29,tciunset30,tciunset31,tciunset32,tciunset33,tciunset34,tciunset35,tciunset36,tciunset37,tciunset38,tciunset39,tciunset40,tciunset41,tciunset42,tciunset43,tciunset44,tciunset45,tciunset46,tciunset47,tciunset48,tciunset49,tciunset50,tciunset51,tciunset52,tciunset53,tciunset54,tciunset55,tciunset56,tciunset57,tciunset58,tciunset59,tciunset60,tciunset61,tciunset62,tciunset63,tciunset64,tciunset65,tciunset66,tciunset67,tciunset68,tciunset69,check_status,lock_tables,house_area_per_people,community_help_figure,community_develop_figure,community_engel_coefficient,community_gini_coefficient ");
			strSql.Append(" FROM T_Community_Indicator ");
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
			strSql.Append(" community_id,community_pop_total_density,community_pop_pure_density,community_plot_ratio,community_conhou_struc_safe_problem_rate,community_conhou_seepage_rate,community_conhou_tile_paint_cra_holl_rate,community_road_density,road_per_capita_availability,no_hard_road_rate,damage_road_rate,large_slope_road_rate,lack_width_road_rate,need_new_repair_road_rate,need_improve_link_ots_road,no_brick_road_rate,damage_brick_road_rate,tap_water_fam_rate,no_water_meter_house_rate,water_supply_insuff_family_rate,water_pressure_insuff_family_rate,caliber_samll_pipe_lenth_rate,damage_pipe_lenth_rate,senescent_erosive_pipe_length_rate,sewage_collection_rate,sewage_handle_rate,not_reasonable_drain_pipe_rate,caliber_samll_drain_pipe_rate,septic_tank_capacity_small_rate,senescent_erosive_drain_pipe_length_rate,damage_drain_pipe_rate,broken_leaking_septic_tank_rate,no_link_drain_pipe_net_famliy_rate,elec_reliable_rate,elec_capacity_lack_family_rate,senescent_elec_wireways_rate,no_elec_meter_house_rate,not_norm_transformer_rate,no_light_road_length_rate,lack_light_road_rate,damage_road_light_rate,passway_light_wireway_damage_house_rate,passway_light_wireway_damage_family_rate,greenland_rate,greenland_per_capita_area,no_lack_afforest_road_length_rate,no_lack_afforest_house_rate,lack_otds_hydrant_road_length_rate,lack_inds_hydrant_house_rate,extinguisher_insuff_building_rate,ff_pipe_damage_length_rate,ff_road_block_building_rate,rubbish_collection_rate,rubbish_handle_rate,dustbin_lack_road_length_rate,dustbin_lack_house_rate,long_term_rubbish_stack_rate,education_fs_indicator,education_gfa_indicator,medical_fs_indicator,medical_gfa_indicator,culture_sports_fs_indicator,culture_sports_gfa_indicator,community_service_fs_indicator,community_service_gfa_indicator,commerce_fs_indicator,commerce_gfa_indicator,farm_produce_fair_fs_indicator,farm_produce_fair_gfa_indicator,statistics_date,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,tciunset15,tciunset16,tciunset17,tciunset18,tciunset19,tciunset20,tciunset21,tciunset22,tciunset23,tciunset24,tciunset25,tciunset26,tciunset27,tciunset28,tciunset29,tciunset30,tciunset31,tciunset32,tciunset33,tciunset34,tciunset35,tciunset36,tciunset37,tciunset38,tciunset39,tciunset40,tciunset41,tciunset42,tciunset43,tciunset44,tciunset45,tciunset46,tciunset47,tciunset48,tciunset49,tciunset50,tciunset51,tciunset52,tciunset53,tciunset54,tciunset55,tciunset56,tciunset57,tciunset58,tciunset59,tciunset60,tciunset61,tciunset62,tciunset63,tciunset64,tciunset65,tciunset66,tciunset67,tciunset68,tciunset69,check_status,lock_tables,house_area_per_people,community_help_figure,community_develop_figure,community_engel_coefficient,community_gini_coefficient ");
			strSql.Append(" FROM T_Community_Indicator ");
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
			strSql.Append("select count(1) FROM T_Community_Indicator ");
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
			strSql.Append(")AS Row, T.*  from T_Community_Indicator T ");
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
			parameters[0].Value = "T_Community_Indicator";
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
        /// 获取一个对象实体
        /// </summary>
        /// <param name="community_id"></param>
        /// <returns></returns>
        public TTG.Model.TTGWeb.Community_Indicator getModel(string community_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 community_id,community_pop_total_density,community_pop_pure_density,community_plot_ratio,community_conhou_struc_safe_problem_rate,community_conhou_seepage_rate,community_conhou_tile_paint_cra_holl_rate,community_road_density,road_per_capita_availability,no_hard_road_rate,damage_road_rate,large_slope_road_rate,lack_width_road_rate,need_new_repair_road_rate,need_improve_link_ots_road,no_brick_road_rate,damage_brick_road_rate,tap_water_fam_rate,no_water_meter_house_rate,water_supply_insuff_family_rate,water_pressure_insuff_family_rate,caliber_samll_pipe_lenth_rate,damage_pipe_lenth_rate,senescent_erosive_pipe_length_rate,sewage_collection_rate,sewage_handle_rate,not_reasonable_drain_pipe_rate,caliber_samll_drain_pipe_rate,septic_tank_capacity_small_rate,senescent_erosive_drain_pipe_length_rate,damage_drain_pipe_rate,broken_leaking_septic_tank_rate,no_link_drain_pipe_net_famliy_rate,elec_reliable_rate,elec_capacity_lack_family_rate,senescent_elec_wireways_rate,no_elec_meter_house_rate,not_norm_transformer_rate,no_light_road_length_rate,lack_light_road_rate,damage_road_light_rate,passway_light_wireway_damage_house_rate,passway_light_wireway_damage_family_rate,greenland_rate,greenland_per_capita_area,no_lack_afforest_road_length_rate,no_lack_afforest_house_rate,lack_otds_hydrant_road_length_rate,lack_inds_hydrant_house_rate,extinguisher_insuff_building_rate,ff_pipe_damage_length_rate,ff_road_block_building_rate,rubbish_collection_rate,rubbish_handle_rate,dustbin_lack_road_length_rate,dustbin_lack_house_rate,long_term_rubbish_stack_rate,education_fs_indicator,education_gfa_indicator,medical_fs_indicator,medical_gfa_indicator,culture_sports_fs_indicator,culture_sports_gfa_indicator,community_service_fs_indicator,community_service_gfa_indicator,commerce_fs_indicator,commerce_gfa_indicator,farm_produce_fair_fs_indicator,farm_produce_fair_gfa_indicator,statistics_date,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,tciunset15,tciunset16,tciunset17,tciunset18,tciunset19,tciunset20,tciunset21,tciunset22,tciunset23,tciunset24,tciunset25,tciunset26,tciunset27,tciunset28,tciunset29,tciunset30,tciunset31,tciunset32,tciunset33,tciunset34,tciunset35,tciunset36,tciunset37,tciunset38,tciunset39,tciunset40,tciunset41,tciunset42,tciunset43,tciunset44,tciunset45,tciunset46,tciunset47,tciunset48,tciunset49,tciunset50,tciunset51,tciunset52,tciunset53,tciunset54,tciunset55,tciunset56,tciunset57,tciunset58,tciunset59,tciunset60,tciunset61,tciunset62,tciunset63,tciunset64,tciunset65,tciunset66,tciunset67,tciunset68,tciunset69,check_status,lock_tables,house_area_per_people,community_help_figure,community_develop_figure,community_engel_coefficient,community_gini_coefficient from T_Community_Indicator ");
            strSql.Append(" where community_id=@community_id order by statistics_date desc");
            SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20)		};
            parameters[0].Value = community_id;

            TTG.Model.TTGWeb.Community_Indicator model = new TTG.Model.TTGWeb.Community_Indicator();
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

