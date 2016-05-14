using System;
namespace TTG.Model.TTGWeb
{
	/// <summary>
	/// Community_Indicator:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Community_Indicator
	{
		public Community_Indicator()
		{}
		#region Model
		private string _community_id;
		private decimal? _community_pop_total_density;
		private decimal? _community_pop_pure_density;
		private decimal? _community_plot_ratio;
		private decimal? _community_conhou_struc_safe_problem_rate;
		private decimal? _community_conhou_seepage_rate;
		private decimal? _community_conhou_tile_paint_cra_holl_rate;
		private decimal? _community_road_density;
		private decimal? _road_per_capita_availability;
		private decimal? _no_hard_road_rate;
		private decimal? _damage_road_rate;
		private decimal? _large_slope_road_rate;
		private decimal? _lack_width_road_rate;
		private decimal? _need_new_repair_road_rate;
		private decimal? _need_improve_link_ots_road;
		private decimal? _no_brick_road_rate;
		private decimal? _damage_brick_road_rate;
		private decimal? _tap_water_fam_rate;
		private decimal? _no_water_meter_house_rate;
		private decimal? _water_supply_insuff_family_rate;
		private decimal? _water_pressure_insuff_family_rate;
		private decimal? _caliber_samll_pipe_lenth_rate;
		private decimal? _damage_pipe_lenth_rate;
		private decimal? _senescent_erosive_pipe_length_rate;
		private decimal? _sewage_collection_rate;
		private decimal? _sewage_handle_rate;
		private decimal? _not_reasonable_drain_pipe_rate;
		private decimal? _caliber_samll_drain_pipe_rate;
		private decimal? _septic_tank_capacity_small_rate;
		private decimal? _senescent_erosive_drain_pipe_length_rate;
		private decimal? _damage_drain_pipe_rate;
		private decimal? _broken_leaking_septic_tank_rate;
		private decimal? _no_link_drain_pipe_net_famliy_rate;
		private decimal? _elec_reliable_rate;
		private decimal? _elec_capacity_lack_family_rate;
		private decimal? _senescent_elec_wireways_rate;
		private decimal? _no_elec_meter_house_rate;
		private decimal? _not_norm_transformer_rate;
		private decimal? _no_light_road_length_rate;
		private decimal? _lack_light_road_rate;
		private decimal? _damage_road_light_rate;
		private decimal? _passway_light_wireway_damage_house_rate;
		private decimal? _passway_light_wireway_damage_family_rate;
		private decimal? _greenland_rate;
		private decimal? _greenland_per_capita_area;
		private decimal? _no_lack_afforest_road_length_rate;
		private decimal? _no_lack_afforest_house_rate;
		private decimal? _lack_otds_hydrant_road_length_rate;
		private decimal? _lack_inds_hydrant_house_rate;
		private decimal? _extinguisher_insuff_building_rate;
		private decimal? _ff_pipe_damage_length_rate;
		private decimal? _ff_road_block_building_rate;
		private decimal? _rubbish_collection_rate;
		private decimal? _rubbish_handle_rate;
		private decimal? _dustbin_lack_road_length_rate;
		private decimal? _dustbin_lack_house_rate;
		private decimal? _long_term_rubbish_stack_rate;
		private decimal? _education_fs_indicator;
		private decimal? _education_gfa_indicator;
		private decimal? _medical_fs_indicator;
		private decimal? _medical_gfa_indicator;
		private decimal? _culture_sports_fs_indicator;
		private decimal? _culture_sports_gfa_indicator;
		private decimal? _community_service_fs_indicator;
		private decimal? _community_service_gfa_indicator;
		private decimal? _commerce_fs_indicator;
		private decimal? _commerce_gfa_indicator;
		private decimal? _farm_produce_fair_fs_indicator;
		private decimal? _farm_produce_fair_gfa_indicator;
		private DateTime _statistics_date;
		private string _tciunset1;
		private string _tciunset2;
		private string _tciunset3;
		private string _tciunset4;
		private string _tciunset5;
		private string _tciunset6;
		private string _tciunset7;
		private string _tciunset8;
		private string _tciunset9;
		private string _tciunset10;
		private string _tciunset11;
		private string _tciunset12;
		private string _tciunset13;
		private string _tciunset14;
		private string _tciunset15;
		private string _tciunset16;
		private string _tciunset17;
		private string _tciunset18;
		private string _tciunset19;
		private string _tciunset20;
		private string _tciunset21;
		private string _tciunset22;
		private string _tciunset23;
		private string _tciunset24;
		private string _tciunset25;
		private string _tciunset26;
		private string _tciunset27;
		private string _tciunset28;
		private string _tciunset29;
		private string _tciunset30;
		private string _tciunset31;
		private string _tciunset32;
		private string _tciunset33;
		private string _tciunset34;
		private string _tciunset35;
		private string _tciunset36;
		private string _tciunset37;
		private string _tciunset38;
		private string _tciunset39;
		private string _tciunset40;
		private string _tciunset41;
		private string _tciunset42;
		private string _tciunset43;
		private string _tciunset44;
		private string _tciunset45;
		private string _tciunset46;
		private string _tciunset47;
		private string _tciunset48;
		private string _tciunset49;
		private string _tciunset50;
		private string _tciunset51;
		private string _tciunset52;
		private string _tciunset53;
		private string _tciunset54;
		private string _tciunset55;
		private string _tciunset56;
		private string _tciunset57;
		private string _tciunset58;
		private string _tciunset59;
		private string _tciunset60;
		private string _tciunset61;
		private string _tciunset62;
		private string _tciunset63;
		private string _tciunset64;
		private string _tciunset65;
		private string _tciunset66;
		private string _tciunset67;
		private string _tciunset68;
		private string _tciunset69;
		private int _check_status;
		private int _lock_tables=0;
		private decimal? _house_area_per_people;
		private decimal? _community_help_figure;
		private decimal? _community_develop_figure;
		private decimal? _community_engel_coefficient;
		private decimal? _community_gini_coefficient;
		/// <summary>
		/// 
		/// </summary>
		public string community_id
		{
			set{ _community_id=value;}
			get{return _community_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_pop_total_density
		{
			set{ _community_pop_total_density=value;}
			get{return _community_pop_total_density;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_pop_pure_density
		{
			set{ _community_pop_pure_density=value;}
			get{return _community_pop_pure_density;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_plot_ratio
		{
			set{ _community_plot_ratio=value;}
			get{return _community_plot_ratio;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_conhou_struc_safe_problem_rate
		{
			set{ _community_conhou_struc_safe_problem_rate=value;}
			get{return _community_conhou_struc_safe_problem_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_conhou_seepage_rate
		{
			set{ _community_conhou_seepage_rate=value;}
			get{return _community_conhou_seepage_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_conhou_tile_paint_cra_holl_rate
		{
			set{ _community_conhou_tile_paint_cra_holl_rate=value;}
			get{return _community_conhou_tile_paint_cra_holl_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_road_density
		{
			set{ _community_road_density=value;}
			get{return _community_road_density;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? road_per_capita_availability
		{
			set{ _road_per_capita_availability=value;}
			get{return _road_per_capita_availability;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? no_hard_road_rate
		{
			set{ _no_hard_road_rate=value;}
			get{return _no_hard_road_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? damage_road_rate
		{
			set{ _damage_road_rate=value;}
			get{return _damage_road_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? large_slope_road_rate
		{
			set{ _large_slope_road_rate=value;}
			get{return _large_slope_road_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? lack_width_road_rate
		{
			set{ _lack_width_road_rate=value;}
			get{return _lack_width_road_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? need_new_repair_road_rate
		{
			set{ _need_new_repair_road_rate=value;}
			get{return _need_new_repair_road_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? need_improve_link_ots_road
		{
			set{ _need_improve_link_ots_road=value;}
			get{return _need_improve_link_ots_road;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? no_brick_road_rate
		{
			set{ _no_brick_road_rate=value;}
			get{return _no_brick_road_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? damage_brick_road_rate
		{
			set{ _damage_brick_road_rate=value;}
			get{return _damage_brick_road_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? tap_water_fam_rate
		{
			set{ _tap_water_fam_rate=value;}
			get{return _tap_water_fam_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? no_water_meter_house_rate
		{
			set{ _no_water_meter_house_rate=value;}
			get{return _no_water_meter_house_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? water_supply_insuff_family_rate
		{
			set{ _water_supply_insuff_family_rate=value;}
			get{return _water_supply_insuff_family_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? water_pressure_insuff_family_rate
		{
			set{ _water_pressure_insuff_family_rate=value;}
			get{return _water_pressure_insuff_family_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? caliber_samll_pipe_lenth_rate
		{
			set{ _caliber_samll_pipe_lenth_rate=value;}
			get{return _caliber_samll_pipe_lenth_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? damage_pipe_lenth_rate
		{
			set{ _damage_pipe_lenth_rate=value;}
			get{return _damage_pipe_lenth_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? senescent_erosive_pipe_length_rate
		{
			set{ _senescent_erosive_pipe_length_rate=value;}
			get{return _senescent_erosive_pipe_length_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? sewage_collection_rate
		{
			set{ _sewage_collection_rate=value;}
			get{return _sewage_collection_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? sewage_handle_rate
		{
			set{ _sewage_handle_rate=value;}
			get{return _sewage_handle_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? not_reasonable_drain_pipe_rate
		{
			set{ _not_reasonable_drain_pipe_rate=value;}
			get{return _not_reasonable_drain_pipe_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? caliber_samll_drain_pipe_rate
		{
			set{ _caliber_samll_drain_pipe_rate=value;}
			get{return _caliber_samll_drain_pipe_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? septic_tank_capacity_small_rate
		{
			set{ _septic_tank_capacity_small_rate=value;}
			get{return _septic_tank_capacity_small_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? senescent_erosive_drain_pipe_length_rate
		{
			set{ _senescent_erosive_drain_pipe_length_rate=value;}
			get{return _senescent_erosive_drain_pipe_length_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? damage_drain_pipe_rate
		{
			set{ _damage_drain_pipe_rate=value;}
			get{return _damage_drain_pipe_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? broken_leaking_septic_tank_rate
		{
			set{ _broken_leaking_septic_tank_rate=value;}
			get{return _broken_leaking_septic_tank_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? no_link_drain_pipe_net_famliy_rate
		{
			set{ _no_link_drain_pipe_net_famliy_rate=value;}
			get{return _no_link_drain_pipe_net_famliy_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? elec_reliable_rate
		{
			set{ _elec_reliable_rate=value;}
			get{return _elec_reliable_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? elec_capacity_lack_family_rate
		{
			set{ _elec_capacity_lack_family_rate=value;}
			get{return _elec_capacity_lack_family_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? senescent_elec_wireways_rate
		{
			set{ _senescent_elec_wireways_rate=value;}
			get{return _senescent_elec_wireways_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? no_elec_meter_house_rate
		{
			set{ _no_elec_meter_house_rate=value;}
			get{return _no_elec_meter_house_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? not_norm_transformer_rate
		{
			set{ _not_norm_transformer_rate=value;}
			get{return _not_norm_transformer_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? no_light_road_length_rate
		{
			set{ _no_light_road_length_rate=value;}
			get{return _no_light_road_length_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? lack_light_road_rate
		{
			set{ _lack_light_road_rate=value;}
			get{return _lack_light_road_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? damage_road_light_rate
		{
			set{ _damage_road_light_rate=value;}
			get{return _damage_road_light_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? passway_light_wireway_damage_house_rate
		{
			set{ _passway_light_wireway_damage_house_rate=value;}
			get{return _passway_light_wireway_damage_house_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? passway_light_wireway_damage_family_rate
		{
			set{ _passway_light_wireway_damage_family_rate=value;}
			get{return _passway_light_wireway_damage_family_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? greenland_rate
		{
			set{ _greenland_rate=value;}
			get{return _greenland_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? greenland_per_capita_area
		{
			set{ _greenland_per_capita_area=value;}
			get{return _greenland_per_capita_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? no_lack_afforest_road_length_rate
		{
			set{ _no_lack_afforest_road_length_rate=value;}
			get{return _no_lack_afforest_road_length_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? no_lack_afforest_house_rate
		{
			set{ _no_lack_afforest_house_rate=value;}
			get{return _no_lack_afforest_house_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? lack_otds_hydrant_road_length_rate
		{
			set{ _lack_otds_hydrant_road_length_rate=value;}
			get{return _lack_otds_hydrant_road_length_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? lack_inds_hydrant_house_rate
		{
			set{ _lack_inds_hydrant_house_rate=value;}
			get{return _lack_inds_hydrant_house_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? extinguisher_insuff_building_rate
		{
			set{ _extinguisher_insuff_building_rate=value;}
			get{return _extinguisher_insuff_building_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ff_pipe_damage_length_rate
		{
			set{ _ff_pipe_damage_length_rate=value;}
			get{return _ff_pipe_damage_length_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ff_road_block_building_rate
		{
			set{ _ff_road_block_building_rate=value;}
			get{return _ff_road_block_building_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? rubbish_collection_rate
		{
			set{ _rubbish_collection_rate=value;}
			get{return _rubbish_collection_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? rubbish_handle_rate
		{
			set{ _rubbish_handle_rate=value;}
			get{return _rubbish_handle_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? dustbin_lack_road_length_rate
		{
			set{ _dustbin_lack_road_length_rate=value;}
			get{return _dustbin_lack_road_length_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? dustbin_lack_house_rate
		{
			set{ _dustbin_lack_house_rate=value;}
			get{return _dustbin_lack_house_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? long_term_rubbish_stack_rate
		{
			set{ _long_term_rubbish_stack_rate=value;}
			get{return _long_term_rubbish_stack_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? education_fs_indicator
		{
			set{ _education_fs_indicator=value;}
			get{return _education_fs_indicator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? education_gfa_indicator
		{
			set{ _education_gfa_indicator=value;}
			get{return _education_gfa_indicator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? medical_fs_indicator
		{
			set{ _medical_fs_indicator=value;}
			get{return _medical_fs_indicator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? medical_gfa_indicator
		{
			set{ _medical_gfa_indicator=value;}
			get{return _medical_gfa_indicator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? culture_sports_fs_indicator
		{
			set{ _culture_sports_fs_indicator=value;}
			get{return _culture_sports_fs_indicator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? culture_sports_gfa_indicator
		{
			set{ _culture_sports_gfa_indicator=value;}
			get{return _culture_sports_gfa_indicator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_service_fs_indicator
		{
			set{ _community_service_fs_indicator=value;}
			get{return _community_service_fs_indicator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_service_gfa_indicator
		{
			set{ _community_service_gfa_indicator=value;}
			get{return _community_service_gfa_indicator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? commerce_fs_indicator
		{
			set{ _commerce_fs_indicator=value;}
			get{return _commerce_fs_indicator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? commerce_gfa_indicator
		{
			set{ _commerce_gfa_indicator=value;}
			get{return _commerce_gfa_indicator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? farm_produce_fair_fs_indicator
		{
			set{ _farm_produce_fair_fs_indicator=value;}
			get{return _farm_produce_fair_fs_indicator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? farm_produce_fair_gfa_indicator
		{
			set{ _farm_produce_fair_gfa_indicator=value;}
			get{return _farm_produce_fair_gfa_indicator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime statistics_date
		{
			set{ _statistics_date=value;}
			get{return _statistics_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset1
		{
			set{ _tciunset1=value;}
			get{return _tciunset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset2
		{
			set{ _tciunset2=value;}
			get{return _tciunset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset3
		{
			set{ _tciunset3=value;}
			get{return _tciunset3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset4
		{
			set{ _tciunset4=value;}
			get{return _tciunset4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset5
		{
			set{ _tciunset5=value;}
			get{return _tciunset5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset6
		{
			set{ _tciunset6=value;}
			get{return _tciunset6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset7
		{
			set{ _tciunset7=value;}
			get{return _tciunset7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset8
		{
			set{ _tciunset8=value;}
			get{return _tciunset8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset9
		{
			set{ _tciunset9=value;}
			get{return _tciunset9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset10
		{
			set{ _tciunset10=value;}
			get{return _tciunset10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset11
		{
			set{ _tciunset11=value;}
			get{return _tciunset11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset12
		{
			set{ _tciunset12=value;}
			get{return _tciunset12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset13
		{
			set{ _tciunset13=value;}
			get{return _tciunset13;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset14
		{
			set{ _tciunset14=value;}
			get{return _tciunset14;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset15
		{
			set{ _tciunset15=value;}
			get{return _tciunset15;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset16
		{
			set{ _tciunset16=value;}
			get{return _tciunset16;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset17
		{
			set{ _tciunset17=value;}
			get{return _tciunset17;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset18
		{
			set{ _tciunset18=value;}
			get{return _tciunset18;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset19
		{
			set{ _tciunset19=value;}
			get{return _tciunset19;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset20
		{
			set{ _tciunset20=value;}
			get{return _tciunset20;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset21
		{
			set{ _tciunset21=value;}
			get{return _tciunset21;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset22
		{
			set{ _tciunset22=value;}
			get{return _tciunset22;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset23
		{
			set{ _tciunset23=value;}
			get{return _tciunset23;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset24
		{
			set{ _tciunset24=value;}
			get{return _tciunset24;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset25
		{
			set{ _tciunset25=value;}
			get{return _tciunset25;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset26
		{
			set{ _tciunset26=value;}
			get{return _tciunset26;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset27
		{
			set{ _tciunset27=value;}
			get{return _tciunset27;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset28
		{
			set{ _tciunset28=value;}
			get{return _tciunset28;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset29
		{
			set{ _tciunset29=value;}
			get{return _tciunset29;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset30
		{
			set{ _tciunset30=value;}
			get{return _tciunset30;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset31
		{
			set{ _tciunset31=value;}
			get{return _tciunset31;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset32
		{
			set{ _tciunset32=value;}
			get{return _tciunset32;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset33
		{
			set{ _tciunset33=value;}
			get{return _tciunset33;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset34
		{
			set{ _tciunset34=value;}
			get{return _tciunset34;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset35
		{
			set{ _tciunset35=value;}
			get{return _tciunset35;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset36
		{
			set{ _tciunset36=value;}
			get{return _tciunset36;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset37
		{
			set{ _tciunset37=value;}
			get{return _tciunset37;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset38
		{
			set{ _tciunset38=value;}
			get{return _tciunset38;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset39
		{
			set{ _tciunset39=value;}
			get{return _tciunset39;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset40
		{
			set{ _tciunset40=value;}
			get{return _tciunset40;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset41
		{
			set{ _tciunset41=value;}
			get{return _tciunset41;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset42
		{
			set{ _tciunset42=value;}
			get{return _tciunset42;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset43
		{
			set{ _tciunset43=value;}
			get{return _tciunset43;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset44
		{
			set{ _tciunset44=value;}
			get{return _tciunset44;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset45
		{
			set{ _tciunset45=value;}
			get{return _tciunset45;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset46
		{
			set{ _tciunset46=value;}
			get{return _tciunset46;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset47
		{
			set{ _tciunset47=value;}
			get{return _tciunset47;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset48
		{
			set{ _tciunset48=value;}
			get{return _tciunset48;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset49
		{
			set{ _tciunset49=value;}
			get{return _tciunset49;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset50
		{
			set{ _tciunset50=value;}
			get{return _tciunset50;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset51
		{
			set{ _tciunset51=value;}
			get{return _tciunset51;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset52
		{
			set{ _tciunset52=value;}
			get{return _tciunset52;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset53
		{
			set{ _tciunset53=value;}
			get{return _tciunset53;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset54
		{
			set{ _tciunset54=value;}
			get{return _tciunset54;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset55
		{
			set{ _tciunset55=value;}
			get{return _tciunset55;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset56
		{
			set{ _tciunset56=value;}
			get{return _tciunset56;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset57
		{
			set{ _tciunset57=value;}
			get{return _tciunset57;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset58
		{
			set{ _tciunset58=value;}
			get{return _tciunset58;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset59
		{
			set{ _tciunset59=value;}
			get{return _tciunset59;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset60
		{
			set{ _tciunset60=value;}
			get{return _tciunset60;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset61
		{
			set{ _tciunset61=value;}
			get{return _tciunset61;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset62
		{
			set{ _tciunset62=value;}
			get{return _tciunset62;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset63
		{
			set{ _tciunset63=value;}
			get{return _tciunset63;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset64
		{
			set{ _tciunset64=value;}
			get{return _tciunset64;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset65
		{
			set{ _tciunset65=value;}
			get{return _tciunset65;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset66
		{
			set{ _tciunset66=value;}
			get{return _tciunset66;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset67
		{
			set{ _tciunset67=value;}
			get{return _tciunset67;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset68
		{
			set{ _tciunset68=value;}
			get{return _tciunset68;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tciunset69
		{
			set{ _tciunset69=value;}
			get{return _tciunset69;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int check_status
		{
			set{ _check_status=value;}
			get{return _check_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int lock_tables
		{
			set{ _lock_tables=value;}
			get{return _lock_tables;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? house_area_per_people
		{
			set{ _house_area_per_people=value;}
			get{return _house_area_per_people;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_help_figure
		{
			set{ _community_help_figure=value;}
			get{return _community_help_figure;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_develop_figure
		{
			set{ _community_develop_figure=value;}
			get{return _community_develop_figure;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_engel_coefficient
		{
			set{ _community_engel_coefficient=value;}
			get{return _community_engel_coefficient;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? community_gini_coefficient
		{
			set{ _community_gini_coefficient=value;}
			get{return _community_gini_coefficient;}
		}
		#endregion Model

	}
}

