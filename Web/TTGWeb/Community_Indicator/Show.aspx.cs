using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace TTG.Web.TTGWeb.Community_Indicator
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string community_id = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					community_id= Request.Params["id0"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					statistics_date= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(community_id,statistics_date);
			}
		}
		
	private void ShowInfo(string community_id,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.Community_Indicator bll=new TTG.BLL.TTGWeb.Community_Indicator();
		TTG.Model.TTGWeb.Community_Indicator model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_pop_total_density.Text=model.community_pop_total_density.ToString();
		this.lblcommunity_pop_pure_density.Text=model.community_pop_pure_density.ToString();
		this.lblcommunity_plot_ratio.Text=model.community_plot_ratio.ToString();
		this.lblcommunity_conhou_struc_safe_problem_rate.Text=model.community_conhou_struc_safe_problem_rate.ToString();
		this.lblcommunity_conhou_seepage_rate.Text=model.community_conhou_seepage_rate.ToString();
		this.lblcommunity_conhou_tile_paint_cra_holl_rate.Text=model.community_conhou_tile_paint_cra_holl_rate.ToString();
		this.lblcommunity_road_density.Text=model.community_road_density.ToString();
		this.lblroad_per_capita_availability.Text=model.road_per_capita_availability.ToString();
		this.lblno_hard_road_rate.Text=model.no_hard_road_rate.ToString();
		this.lbldamage_road_rate.Text=model.damage_road_rate.ToString();
		this.lbllarge_slope_road_rate.Text=model.large_slope_road_rate.ToString();
		this.lbllack_width_road_rate.Text=model.lack_width_road_rate.ToString();
		this.lblneed_new_repair_road_rate.Text=model.need_new_repair_road_rate.ToString();
		this.lblneed_improve_link_ots_road.Text=model.need_improve_link_ots_road.ToString();
		this.lblno_brick_road_rate.Text=model.no_brick_road_rate.ToString();
		this.lbldamage_brick_road_rate.Text=model.damage_brick_road_rate.ToString();
		this.lbltap_water_fam_rate.Text=model.tap_water_fam_rate.ToString();
		this.lblno_water_meter_house_rate.Text=model.no_water_meter_house_rate.ToString();
		this.lblwater_supply_insuff_family_rate.Text=model.water_supply_insuff_family_rate.ToString();
		this.lblwater_pressure_insuff_family_rate.Text=model.water_pressure_insuff_family_rate.ToString();
		this.lblcaliber_samll_pipe_lenth_rate.Text=model.caliber_samll_pipe_lenth_rate.ToString();
		this.lbldamage_pipe_lenth_rate.Text=model.damage_pipe_lenth_rate.ToString();
		this.lblsenescent_erosive_pipe_length_rate.Text=model.senescent_erosive_pipe_length_rate.ToString();
		this.lblsewage_collection_rate.Text=model.sewage_collection_rate.ToString();
		this.lblsewage_handle_rate.Text=model.sewage_handle_rate.ToString();
		this.lblnot_reasonable_drain_pipe_rate.Text=model.not_reasonable_drain_pipe_rate.ToString();
		this.lblcaliber_samll_drain_pipe_rate.Text=model.caliber_samll_drain_pipe_rate.ToString();
		this.lblseptic_tank_capacity_small_rate.Text=model.septic_tank_capacity_small_rate.ToString();
		this.lblsenescent_erosive_drain_pipe_length_rate.Text=model.senescent_erosive_drain_pipe_length_rate.ToString();
		this.lbldamage_drain_pipe_rate.Text=model.damage_drain_pipe_rate.ToString();
		this.lblbroken_leaking_septic_tank_rate.Text=model.broken_leaking_septic_tank_rate.ToString();
		this.lblno_link_drain_pipe_net_famliy_rate.Text=model.no_link_drain_pipe_net_famliy_rate.ToString();
		this.lblelec_reliable_rate.Text=model.elec_reliable_rate.ToString();
		this.lblelec_capacity_lack_family_rate.Text=model.elec_capacity_lack_family_rate.ToString();
		this.lblsenescent_elec_wireways_rate.Text=model.senescent_elec_wireways_rate.ToString();
		this.lblno_elec_meter_house_rate.Text=model.no_elec_meter_house_rate.ToString();
		this.lblnot_norm_transformer_rate.Text=model.not_norm_transformer_rate.ToString();
		this.lblno_light_road_length_rate.Text=model.no_light_road_length_rate.ToString();
		this.lbllack_light_road_rate.Text=model.lack_light_road_rate.ToString();
		this.lbldamage_road_light_rate.Text=model.damage_road_light_rate.ToString();
		this.lblpassway_light_wireway_damage_house_rate.Text=model.passway_light_wireway_damage_house_rate.ToString();
		this.lblpassway_light_wireway_damage_family_rate.Text=model.passway_light_wireway_damage_family_rate.ToString();
		this.lblgreenland_rate.Text=model.greenland_rate.ToString();
		this.lblgreenland_per_capita_area.Text=model.greenland_per_capita_area.ToString();
		this.lblno_lack_afforest_road_length_rate.Text=model.no_lack_afforest_road_length_rate.ToString();
		this.lblno_lack_afforest_house_rate.Text=model.no_lack_afforest_house_rate.ToString();
		this.lbllack_otds_hydrant_road_length_rate.Text=model.lack_otds_hydrant_road_length_rate.ToString();
		this.lbllack_inds_hydrant_house_rate.Text=model.lack_inds_hydrant_house_rate.ToString();
		this.lblextinguisher_insuff_building_rate.Text=model.extinguisher_insuff_building_rate.ToString();
		this.lblff_pipe_damage_length_rate.Text=model.ff_pipe_damage_length_rate.ToString();
		this.lblff_road_block_building_rate.Text=model.ff_road_block_building_rate.ToString();
		this.lblrubbish_collection_rate.Text=model.rubbish_collection_rate.ToString();
		this.lblrubbish_handle_rate.Text=model.rubbish_handle_rate.ToString();
		this.lbldustbin_lack_road_length_rate.Text=model.dustbin_lack_road_length_rate.ToString();
		this.lbldustbin_lack_house_rate.Text=model.dustbin_lack_house_rate.ToString();
		this.lbllong_term_rubbish_stack_rate.Text=model.long_term_rubbish_stack_rate.ToString();
		this.lbleducation_fs_indicator.Text=model.education_fs_indicator.ToString();
		this.lbleducation_gfa_indicator.Text=model.education_gfa_indicator.ToString();
		this.lblmedical_fs_indicator.Text=model.medical_fs_indicator.ToString();
		this.lblmedical_gfa_indicator.Text=model.medical_gfa_indicator.ToString();
		this.lblculture_sports_fs_indicator.Text=model.culture_sports_fs_indicator.ToString();
		this.lblculture_sports_gfa_indicator.Text=model.culture_sports_gfa_indicator.ToString();
		this.lblcommunity_service_fs_indicator.Text=model.community_service_fs_indicator.ToString();
		this.lblcommunity_service_gfa_indicator.Text=model.community_service_gfa_indicator.ToString();
		this.lblcommerce_fs_indicator.Text=model.commerce_fs_indicator.ToString();
		this.lblcommerce_gfa_indicator.Text=model.commerce_gfa_indicator.ToString();
		this.lblfarm_produce_fair_fs_indicator.Text=model.farm_produce_fair_fs_indicator.ToString();
		this.lblfarm_produce_fair_gfa_indicator.Text=model.farm_produce_fair_gfa_indicator.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltciunset1.Text=model.tciunset1;
		this.lbltciunset2.Text=model.tciunset2;
		this.lbltciunset3.Text=model.tciunset3;
		this.lbltciunset4.Text=model.tciunset4;
		this.lbltciunset5.Text=model.tciunset5;
		this.lbltciunset6.Text=model.tciunset6;
		this.lbltciunset7.Text=model.tciunset7;
		this.lbltciunset8.Text=model.tciunset8;
		this.lbltciunset9.Text=model.tciunset9;
		this.lbltciunset10.Text=model.tciunset10;
		this.lbltciunset11.Text=model.tciunset11;
		this.lbltciunset12.Text=model.tciunset12;
		this.lbltciunset13.Text=model.tciunset13;
		this.lbltciunset14.Text=model.tciunset14;
		this.lbltciunset15.Text=model.tciunset15;
		this.lbltciunset16.Text=model.tciunset16;
		this.lbltciunset17.Text=model.tciunset17;
		this.lbltciunset18.Text=model.tciunset18;
		this.lbltciunset19.Text=model.tciunset19;
		this.lbltciunset20.Text=model.tciunset20;
		this.lbltciunset21.Text=model.tciunset21;
		this.lbltciunset22.Text=model.tciunset22;
		this.lbltciunset23.Text=model.tciunset23;
		this.lbltciunset24.Text=model.tciunset24;
		this.lbltciunset25.Text=model.tciunset25;
		this.lbltciunset26.Text=model.tciunset26;
		this.lbltciunset27.Text=model.tciunset27;
		this.lbltciunset28.Text=model.tciunset28;
		this.lbltciunset29.Text=model.tciunset29;
		this.lbltciunset30.Text=model.tciunset30;
		this.lbltciunset31.Text=model.tciunset31;
		this.lbltciunset32.Text=model.tciunset32;
		this.lbltciunset33.Text=model.tciunset33;
		this.lbltciunset34.Text=model.tciunset34;
		this.lbltciunset35.Text=model.tciunset35;
		this.lbltciunset36.Text=model.tciunset36;
		this.lbltciunset37.Text=model.tciunset37;
		this.lbltciunset38.Text=model.tciunset38;
		this.lbltciunset39.Text=model.tciunset39;
		this.lbltciunset40.Text=model.tciunset40;
		this.lbltciunset41.Text=model.tciunset41;
		this.lbltciunset42.Text=model.tciunset42;
		this.lbltciunset43.Text=model.tciunset43;
		this.lbltciunset44.Text=model.tciunset44;
		this.lbltciunset45.Text=model.tciunset45;
		this.lbltciunset46.Text=model.tciunset46;
		this.lbltciunset47.Text=model.tciunset47;
		this.lbltciunset48.Text=model.tciunset48;
		this.lbltciunset49.Text=model.tciunset49;
		this.lbltciunset50.Text=model.tciunset50;
		this.lbltciunset51.Text=model.tciunset51;
		this.lbltciunset52.Text=model.tciunset52;
		this.lbltciunset53.Text=model.tciunset53;
		this.lbltciunset54.Text=model.tciunset54;
		this.lbltciunset55.Text=model.tciunset55;
		this.lbltciunset56.Text=model.tciunset56;
		this.lbltciunset57.Text=model.tciunset57;
		this.lbltciunset58.Text=model.tciunset58;
		this.lbltciunset59.Text=model.tciunset59;
		this.lbltciunset60.Text=model.tciunset60;
		this.lbltciunset61.Text=model.tciunset61;
		this.lbltciunset62.Text=model.tciunset62;
		this.lbltciunset63.Text=model.tciunset63;
		this.lbltciunset64.Text=model.tciunset64;
		this.lbltciunset65.Text=model.tciunset65;
		this.lbltciunset66.Text=model.tciunset66;
		this.lbltciunset67.Text=model.tciunset67;
		this.lbltciunset68.Text=model.tciunset68;
		this.lbltciunset69.Text=model.tciunset69;
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblhouse_area_per_people.Text=model.house_area_per_people.ToString();
		this.lblcommunity_help_figure.Text=model.community_help_figure.ToString();
		this.lblcommunity_develop_figure.Text=model.community_develop_figure.ToString();
		this.lblcommunity_engel_coefficient.Text=model.community_engel_coefficient.ToString();
		this.lblcommunity_gini_coefficient.Text=model.community_gini_coefficient.ToString();

	}


    }
}
