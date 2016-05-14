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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace TTG.Web.TTGWeb.Community_Indicator
{
    public partial class Modify : Page
    {       

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
		this.txtcommunity_pop_total_density.Text=model.community_pop_total_density.ToString();
		this.txtcommunity_pop_pure_density.Text=model.community_pop_pure_density.ToString();
		this.txtcommunity_plot_ratio.Text=model.community_plot_ratio.ToString();
		this.txtcommunity_conhou_struc_safe_problem_rate.Text=model.community_conhou_struc_safe_problem_rate.ToString();
		this.txtcommunity_conhou_seepage_rate.Text=model.community_conhou_seepage_rate.ToString();
		this.txtcommunity_conhou_tile_paint_cra_holl_rate.Text=model.community_conhou_tile_paint_cra_holl_rate.ToString();
		this.txtcommunity_road_density.Text=model.community_road_density.ToString();
		this.txtroad_per_capita_availability.Text=model.road_per_capita_availability.ToString();
		this.txtno_hard_road_rate.Text=model.no_hard_road_rate.ToString();
		this.txtdamage_road_rate.Text=model.damage_road_rate.ToString();
		this.txtlarge_slope_road_rate.Text=model.large_slope_road_rate.ToString();
		this.txtlack_width_road_rate.Text=model.lack_width_road_rate.ToString();
		this.txtneed_new_repair_road_rate.Text=model.need_new_repair_road_rate.ToString();
		this.txtneed_improve_link_ots_road.Text=model.need_improve_link_ots_road.ToString();
		this.txtno_brick_road_rate.Text=model.no_brick_road_rate.ToString();
		this.txtdamage_brick_road_rate.Text=model.damage_brick_road_rate.ToString();
		this.txttap_water_fam_rate.Text=model.tap_water_fam_rate.ToString();
		this.txtno_water_meter_house_rate.Text=model.no_water_meter_house_rate.ToString();
		this.txtwater_supply_insuff_family_rate.Text=model.water_supply_insuff_family_rate.ToString();
		this.txtwater_pressure_insuff_family_rate.Text=model.water_pressure_insuff_family_rate.ToString();
		this.txtcaliber_samll_pipe_lenth_rate.Text=model.caliber_samll_pipe_lenth_rate.ToString();
		this.txtdamage_pipe_lenth_rate.Text=model.damage_pipe_lenth_rate.ToString();
		this.txtsenescent_erosive_pipe_length_rate.Text=model.senescent_erosive_pipe_length_rate.ToString();
		this.txtsewage_collection_rate.Text=model.sewage_collection_rate.ToString();
		this.txtsewage_handle_rate.Text=model.sewage_handle_rate.ToString();
		this.txtnot_reasonable_drain_pipe_rate.Text=model.not_reasonable_drain_pipe_rate.ToString();
		this.txtcaliber_samll_drain_pipe_rate.Text=model.caliber_samll_drain_pipe_rate.ToString();
		this.txtseptic_tank_capacity_small_rate.Text=model.septic_tank_capacity_small_rate.ToString();
		this.txtsenescent_erosive_drain_pipe_length_rate.Text=model.senescent_erosive_drain_pipe_length_rate.ToString();
		this.txtdamage_drain_pipe_rate.Text=model.damage_drain_pipe_rate.ToString();
		this.txtbroken_leaking_septic_tank_rate.Text=model.broken_leaking_septic_tank_rate.ToString();
		this.txtno_link_drain_pipe_net_famliy_rate.Text=model.no_link_drain_pipe_net_famliy_rate.ToString();
		this.txtelec_reliable_rate.Text=model.elec_reliable_rate.ToString();
		this.txtelec_capacity_lack_family_rate.Text=model.elec_capacity_lack_family_rate.ToString();
		this.txtsenescent_elec_wireways_rate.Text=model.senescent_elec_wireways_rate.ToString();
		this.txtno_elec_meter_house_rate.Text=model.no_elec_meter_house_rate.ToString();
		this.txtnot_norm_transformer_rate.Text=model.not_norm_transformer_rate.ToString();
		this.txtno_light_road_length_rate.Text=model.no_light_road_length_rate.ToString();
		this.txtlack_light_road_rate.Text=model.lack_light_road_rate.ToString();
		this.txtdamage_road_light_rate.Text=model.damage_road_light_rate.ToString();
		this.txtpassway_light_wireway_damage_house_rate.Text=model.passway_light_wireway_damage_house_rate.ToString();
		this.txtpassway_light_wireway_damage_family_rate.Text=model.passway_light_wireway_damage_family_rate.ToString();
		this.txtgreenland_rate.Text=model.greenland_rate.ToString();
		this.txtgreenland_per_capita_area.Text=model.greenland_per_capita_area.ToString();
		this.txtno_lack_afforest_road_length_rate.Text=model.no_lack_afforest_road_length_rate.ToString();
		this.txtno_lack_afforest_house_rate.Text=model.no_lack_afforest_house_rate.ToString();
		this.txtlack_otds_hydrant_road_length_rate.Text=model.lack_otds_hydrant_road_length_rate.ToString();
		this.txtlack_inds_hydrant_house_rate.Text=model.lack_inds_hydrant_house_rate.ToString();
		this.txtextinguisher_insuff_building_rate.Text=model.extinguisher_insuff_building_rate.ToString();
		this.txtff_pipe_damage_length_rate.Text=model.ff_pipe_damage_length_rate.ToString();
		this.txtff_road_block_building_rate.Text=model.ff_road_block_building_rate.ToString();
		this.txtrubbish_collection_rate.Text=model.rubbish_collection_rate.ToString();
		this.txtrubbish_handle_rate.Text=model.rubbish_handle_rate.ToString();
		this.txtdustbin_lack_road_length_rate.Text=model.dustbin_lack_road_length_rate.ToString();
		this.txtdustbin_lack_house_rate.Text=model.dustbin_lack_house_rate.ToString();
		this.txtlong_term_rubbish_stack_rate.Text=model.long_term_rubbish_stack_rate.ToString();
		this.txteducation_fs_indicator.Text=model.education_fs_indicator.ToString();
		this.txteducation_gfa_indicator.Text=model.education_gfa_indicator.ToString();
		this.txtmedical_fs_indicator.Text=model.medical_fs_indicator.ToString();
		this.txtmedical_gfa_indicator.Text=model.medical_gfa_indicator.ToString();
		this.txtculture_sports_fs_indicator.Text=model.culture_sports_fs_indicator.ToString();
		this.txtculture_sports_gfa_indicator.Text=model.culture_sports_gfa_indicator.ToString();
		this.txtcommunity_service_fs_indicator.Text=model.community_service_fs_indicator.ToString();
		this.txtcommunity_service_gfa_indicator.Text=model.community_service_gfa_indicator.ToString();
		this.txtcommerce_fs_indicator.Text=model.commerce_fs_indicator.ToString();
		this.txtcommerce_gfa_indicator.Text=model.commerce_gfa_indicator.ToString();
		this.txtfarm_produce_fair_fs_indicator.Text=model.farm_produce_fair_fs_indicator.ToString();
		this.txtfarm_produce_fair_gfa_indicator.Text=model.farm_produce_fair_gfa_indicator.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txttciunset1.Text=model.tciunset1;
		this.txttciunset2.Text=model.tciunset2;
		this.txttciunset3.Text=model.tciunset3;
		this.txttciunset4.Text=model.tciunset4;
		this.txttciunset5.Text=model.tciunset5;
		this.txttciunset6.Text=model.tciunset6;
		this.txttciunset7.Text=model.tciunset7;
		this.txttciunset8.Text=model.tciunset8;
		this.txttciunset9.Text=model.tciunset9;
		this.txttciunset10.Text=model.tciunset10;
		this.txttciunset11.Text=model.tciunset11;
		this.txttciunset12.Text=model.tciunset12;
		this.txttciunset13.Text=model.tciunset13;
		this.txttciunset14.Text=model.tciunset14;
		this.txttciunset15.Text=model.tciunset15;
		this.txttciunset16.Text=model.tciunset16;
		this.txttciunset17.Text=model.tciunset17;
		this.txttciunset18.Text=model.tciunset18;
		this.txttciunset19.Text=model.tciunset19;
		this.txttciunset20.Text=model.tciunset20;
		this.txttciunset21.Text=model.tciunset21;
		this.txttciunset22.Text=model.tciunset22;
		this.txttciunset23.Text=model.tciunset23;
		this.txttciunset24.Text=model.tciunset24;
		this.txttciunset25.Text=model.tciunset25;
		this.txttciunset26.Text=model.tciunset26;
		this.txttciunset27.Text=model.tciunset27;
		this.txttciunset28.Text=model.tciunset28;
		this.txttciunset29.Text=model.tciunset29;
		this.txttciunset30.Text=model.tciunset30;
		this.txttciunset31.Text=model.tciunset31;
		this.txttciunset32.Text=model.tciunset32;
		this.txttciunset33.Text=model.tciunset33;
		this.txttciunset34.Text=model.tciunset34;
		this.txttciunset35.Text=model.tciunset35;
		this.txttciunset36.Text=model.tciunset36;
		this.txttciunset37.Text=model.tciunset37;
		this.txttciunset38.Text=model.tciunset38;
		this.txttciunset39.Text=model.tciunset39;
		this.txttciunset40.Text=model.tciunset40;
		this.txttciunset41.Text=model.tciunset41;
		this.txttciunset42.Text=model.tciunset42;
		this.txttciunset43.Text=model.tciunset43;
		this.txttciunset44.Text=model.tciunset44;
		this.txttciunset45.Text=model.tciunset45;
		this.txttciunset46.Text=model.tciunset46;
		this.txttciunset47.Text=model.tciunset47;
		this.txttciunset48.Text=model.tciunset48;
		this.txttciunset49.Text=model.tciunset49;
		this.txttciunset50.Text=model.tciunset50;
		this.txttciunset51.Text=model.tciunset51;
		this.txttciunset52.Text=model.tciunset52;
		this.txttciunset53.Text=model.tciunset53;
		this.txttciunset54.Text=model.tciunset54;
		this.txttciunset55.Text=model.tciunset55;
		this.txttciunset56.Text=model.tciunset56;
		this.txttciunset57.Text=model.tciunset57;
		this.txttciunset58.Text=model.tciunset58;
		this.txttciunset59.Text=model.tciunset59;
		this.txttciunset60.Text=model.tciunset60;
		this.txttciunset61.Text=model.tciunset61;
		this.txttciunset62.Text=model.tciunset62;
		this.txttciunset63.Text=model.tciunset63;
		this.txttciunset64.Text=model.tciunset64;
		this.txttciunset65.Text=model.tciunset65;
		this.txttciunset66.Text=model.tciunset66;
		this.txttciunset67.Text=model.tciunset67;
		this.txttciunset68.Text=model.tciunset68;
		this.txttciunset69.Text=model.tciunset69;
		this.txtcheck_status.Text=model.check_status.ToString();
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txthouse_area_per_people.Text=model.house_area_per_people.ToString();
		this.txtcommunity_help_figure.Text=model.community_help_figure.ToString();
		this.txtcommunity_develop_figure.Text=model.community_develop_figure.ToString();
		this.txtcommunity_engel_coefficient.Text=model.community_engel_coefficient.ToString();
		this.txtcommunity_gini_coefficient.Text=model.community_gini_coefficient.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txtcommunity_pop_total_density.Text))
			{
				strErr+="community_pop_total_density格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_pop_pure_density.Text))
			{
				strErr+="community_pop_pure_density格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_plot_ratio.Text))
			{
				strErr+="community_plot_ratio格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_conhou_struc_safe_problem_rate.Text))
			{
				strErr+="community_conhou_struc_safe_problem_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_conhou_seepage_rate.Text))
			{
				strErr+="community_conhou_seepage_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_conhou_tile_paint_cra_holl_rate.Text))
			{
				strErr+="community_conhou_tile_paint_cra_holl_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_density.Text))
			{
				strErr+="community_road_density格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtroad_per_capita_availability.Text))
			{
				strErr+="road_per_capita_availability格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtno_hard_road_rate.Text))
			{
				strErr+="no_hard_road_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdamage_road_rate.Text))
			{
				strErr+="damage_road_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlarge_slope_road_rate.Text))
			{
				strErr+="large_slope_road_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlack_width_road_rate.Text))
			{
				strErr+="lack_width_road_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtneed_new_repair_road_rate.Text))
			{
				strErr+="need_new_repair_road_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtneed_improve_link_ots_road.Text))
			{
				strErr+="need_improve_link_ots_road格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtno_brick_road_rate.Text))
			{
				strErr+="no_brick_road_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdamage_brick_road_rate.Text))
			{
				strErr+="damage_brick_road_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txttap_water_fam_rate.Text))
			{
				strErr+="tap_water_fam_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtno_water_meter_house_rate.Text))
			{
				strErr+="no_water_meter_house_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtwater_supply_insuff_family_rate.Text))
			{
				strErr+="water_supply_insuff_family_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtwater_pressure_insuff_family_rate.Text))
			{
				strErr+="water_pressure_insuff_family_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcaliber_samll_pipe_lenth_rate.Text))
			{
				strErr+="caliber_samll_pipe_lenth_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdamage_pipe_lenth_rate.Text))
			{
				strErr+="damage_pipe_lenth_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsenescent_erosive_pipe_length_rate.Text))
			{
				strErr+="senescent_erosive_pipe_length_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsewage_collection_rate.Text))
			{
				strErr+="sewage_collection_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsewage_handle_rate.Text))
			{
				strErr+="sewage_handle_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtnot_reasonable_drain_pipe_rate.Text))
			{
				strErr+="not_reasonable_drain_pipe_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcaliber_samll_drain_pipe_rate.Text))
			{
				strErr+="caliber_samll_drain_pipe_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtseptic_tank_capacity_small_rate.Text))
			{
				strErr+="septic_tank_capacity_small_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsenescent_erosive_drain_pipe_length_rate.Text))
			{
				strErr+="senescent_erosive_drain_pipe_length_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdamage_drain_pipe_rate.Text))
			{
				strErr+="damage_drain_pipe_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtbroken_leaking_septic_tank_rate.Text))
			{
				strErr+="broken_leaking_septic_tank_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtno_link_drain_pipe_net_famliy_rate.Text))
			{
				strErr+="no_link_drain_pipe_net_famliy_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtelec_reliable_rate.Text))
			{
				strErr+="elec_reliable_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtelec_capacity_lack_family_rate.Text))
			{
				strErr+="elec_capacity_lack_family_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsenescent_elec_wireways_rate.Text))
			{
				strErr+="senescent_elec_wireways_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtno_elec_meter_house_rate.Text))
			{
				strErr+="no_elec_meter_house_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtnot_norm_transformer_rate.Text))
			{
				strErr+="not_norm_transformer_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtno_light_road_length_rate.Text))
			{
				strErr+="no_light_road_length_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlack_light_road_rate.Text))
			{
				strErr+="lack_light_road_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdamage_road_light_rate.Text))
			{
				strErr+="damage_road_light_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpassway_light_wireway_damage_house_rate.Text))
			{
				strErr+="passway_light_wireway_damage_house_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpassway_light_wireway_damage_family_rate.Text))
			{
				strErr+="passway_light_wireway_damage_family_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtgreenland_rate.Text))
			{
				strErr+="greenland_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtgreenland_per_capita_area.Text))
			{
				strErr+="greenland_per_capita_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtno_lack_afforest_road_length_rate.Text))
			{
				strErr+="no_lack_afforest_road_length_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtno_lack_afforest_house_rate.Text))
			{
				strErr+="no_lack_afforest_house_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlack_otds_hydrant_road_length_rate.Text))
			{
				strErr+="lack_otds_hydrant_road_length_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlack_inds_hydrant_house_rate.Text))
			{
				strErr+="lack_inds_hydrant_house_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtextinguisher_insuff_building_rate.Text))
			{
				strErr+="extinguisher_insuff_building_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtff_pipe_damage_length_rate.Text))
			{
				strErr+="ff_pipe_damage_length_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtff_road_block_building_rate.Text))
			{
				strErr+="ff_road_block_building_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtrubbish_collection_rate.Text))
			{
				strErr+="rubbish_collection_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtrubbish_handle_rate.Text))
			{
				strErr+="rubbish_handle_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdustbin_lack_road_length_rate.Text))
			{
				strErr+="dustbin_lack_road_length_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdustbin_lack_house_rate.Text))
			{
				strErr+="dustbin_lack_house_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlong_term_rubbish_stack_rate.Text))
			{
				strErr+="long_term_rubbish_stack_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txteducation_fs_indicator.Text))
			{
				strErr+="education_fs_indicator格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txteducation_gfa_indicator.Text))
			{
				strErr+="education_gfa_indicator格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtmedical_fs_indicator.Text))
			{
				strErr+="medical_fs_indicator格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtmedical_gfa_indicator.Text))
			{
				strErr+="medical_gfa_indicator格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtculture_sports_fs_indicator.Text))
			{
				strErr+="culture_sports_fs_indicator格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtculture_sports_gfa_indicator.Text))
			{
				strErr+="culture_sports_gfa_indicator格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_service_fs_indicator.Text))
			{
				strErr+="community_service_fs_indicator格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_service_gfa_indicator.Text))
			{
				strErr+="community_service_gfa_indicator格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommerce_fs_indicator.Text))
			{
				strErr+="commerce_fs_indicator格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommerce_gfa_indicator.Text))
			{
				strErr+="commerce_gfa_indicator格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtfarm_produce_fair_fs_indicator.Text))
			{
				strErr+="farm_produce_fair_fs_indicator格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtfarm_produce_fair_gfa_indicator.Text))
			{
				strErr+="farm_produce_fair_gfa_indicator格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttciunset1.Text.Trim().Length==0)
			{
				strErr+="tciunset1不能为空！\\n";	
			}
			if(this.txttciunset2.Text.Trim().Length==0)
			{
				strErr+="tciunset2不能为空！\\n";	
			}
			if(this.txttciunset3.Text.Trim().Length==0)
			{
				strErr+="tciunset3不能为空！\\n";	
			}
			if(this.txttciunset4.Text.Trim().Length==0)
			{
				strErr+="tciunset4不能为空！\\n";	
			}
			if(this.txttciunset5.Text.Trim().Length==0)
			{
				strErr+="tciunset5不能为空！\\n";	
			}
			if(this.txttciunset6.Text.Trim().Length==0)
			{
				strErr+="tciunset6不能为空！\\n";	
			}
			if(this.txttciunset7.Text.Trim().Length==0)
			{
				strErr+="tciunset7不能为空！\\n";	
			}
			if(this.txttciunset8.Text.Trim().Length==0)
			{
				strErr+="tciunset8不能为空！\\n";	
			}
			if(this.txttciunset9.Text.Trim().Length==0)
			{
				strErr+="tciunset9不能为空！\\n";	
			}
			if(this.txttciunset10.Text.Trim().Length==0)
			{
				strErr+="tciunset10不能为空！\\n";	
			}
			if(this.txttciunset11.Text.Trim().Length==0)
			{
				strErr+="tciunset11不能为空！\\n";	
			}
			if(this.txttciunset12.Text.Trim().Length==0)
			{
				strErr+="tciunset12不能为空！\\n";	
			}
			if(this.txttciunset13.Text.Trim().Length==0)
			{
				strErr+="tciunset13不能为空！\\n";	
			}
			if(this.txttciunset14.Text.Trim().Length==0)
			{
				strErr+="tciunset14不能为空！\\n";	
			}
			if(this.txttciunset15.Text.Trim().Length==0)
			{
				strErr+="tciunset15不能为空！\\n";	
			}
			if(this.txttciunset16.Text.Trim().Length==0)
			{
				strErr+="tciunset16不能为空！\\n";	
			}
			if(this.txttciunset17.Text.Trim().Length==0)
			{
				strErr+="tciunset17不能为空！\\n";	
			}
			if(this.txttciunset18.Text.Trim().Length==0)
			{
				strErr+="tciunset18不能为空！\\n";	
			}
			if(this.txttciunset19.Text.Trim().Length==0)
			{
				strErr+="tciunset19不能为空！\\n";	
			}
			if(this.txttciunset20.Text.Trim().Length==0)
			{
				strErr+="tciunset20不能为空！\\n";	
			}
			if(this.txttciunset21.Text.Trim().Length==0)
			{
				strErr+="tciunset21不能为空！\\n";	
			}
			if(this.txttciunset22.Text.Trim().Length==0)
			{
				strErr+="tciunset22不能为空！\\n";	
			}
			if(this.txttciunset23.Text.Trim().Length==0)
			{
				strErr+="tciunset23不能为空！\\n";	
			}
			if(this.txttciunset24.Text.Trim().Length==0)
			{
				strErr+="tciunset24不能为空！\\n";	
			}
			if(this.txttciunset25.Text.Trim().Length==0)
			{
				strErr+="tciunset25不能为空！\\n";	
			}
			if(this.txttciunset26.Text.Trim().Length==0)
			{
				strErr+="tciunset26不能为空！\\n";	
			}
			if(this.txttciunset27.Text.Trim().Length==0)
			{
				strErr+="tciunset27不能为空！\\n";	
			}
			if(this.txttciunset28.Text.Trim().Length==0)
			{
				strErr+="tciunset28不能为空！\\n";	
			}
			if(this.txttciunset29.Text.Trim().Length==0)
			{
				strErr+="tciunset29不能为空！\\n";	
			}
			if(this.txttciunset30.Text.Trim().Length==0)
			{
				strErr+="tciunset30不能为空！\\n";	
			}
			if(this.txttciunset31.Text.Trim().Length==0)
			{
				strErr+="tciunset31不能为空！\\n";	
			}
			if(this.txttciunset32.Text.Trim().Length==0)
			{
				strErr+="tciunset32不能为空！\\n";	
			}
			if(this.txttciunset33.Text.Trim().Length==0)
			{
				strErr+="tciunset33不能为空！\\n";	
			}
			if(this.txttciunset34.Text.Trim().Length==0)
			{
				strErr+="tciunset34不能为空！\\n";	
			}
			if(this.txttciunset35.Text.Trim().Length==0)
			{
				strErr+="tciunset35不能为空！\\n";	
			}
			if(this.txttciunset36.Text.Trim().Length==0)
			{
				strErr+="tciunset36不能为空！\\n";	
			}
			if(this.txttciunset37.Text.Trim().Length==0)
			{
				strErr+="tciunset37不能为空！\\n";	
			}
			if(this.txttciunset38.Text.Trim().Length==0)
			{
				strErr+="tciunset38不能为空！\\n";	
			}
			if(this.txttciunset39.Text.Trim().Length==0)
			{
				strErr+="tciunset39不能为空！\\n";	
			}
			if(this.txttciunset40.Text.Trim().Length==0)
			{
				strErr+="tciunset40不能为空！\\n";	
			}
			if(this.txttciunset41.Text.Trim().Length==0)
			{
				strErr+="tciunset41不能为空！\\n";	
			}
			if(this.txttciunset42.Text.Trim().Length==0)
			{
				strErr+="tciunset42不能为空！\\n";	
			}
			if(this.txttciunset43.Text.Trim().Length==0)
			{
				strErr+="tciunset43不能为空！\\n";	
			}
			if(this.txttciunset44.Text.Trim().Length==0)
			{
				strErr+="tciunset44不能为空！\\n";	
			}
			if(this.txttciunset45.Text.Trim().Length==0)
			{
				strErr+="tciunset45不能为空！\\n";	
			}
			if(this.txttciunset46.Text.Trim().Length==0)
			{
				strErr+="tciunset46不能为空！\\n";	
			}
			if(this.txttciunset47.Text.Trim().Length==0)
			{
				strErr+="tciunset47不能为空！\\n";	
			}
			if(this.txttciunset48.Text.Trim().Length==0)
			{
				strErr+="tciunset48不能为空！\\n";	
			}
			if(this.txttciunset49.Text.Trim().Length==0)
			{
				strErr+="tciunset49不能为空！\\n";	
			}
			if(this.txttciunset50.Text.Trim().Length==0)
			{
				strErr+="tciunset50不能为空！\\n";	
			}
			if(this.txttciunset51.Text.Trim().Length==0)
			{
				strErr+="tciunset51不能为空！\\n";	
			}
			if(this.txttciunset52.Text.Trim().Length==0)
			{
				strErr+="tciunset52不能为空！\\n";	
			}
			if(this.txttciunset53.Text.Trim().Length==0)
			{
				strErr+="tciunset53不能为空！\\n";	
			}
			if(this.txttciunset54.Text.Trim().Length==0)
			{
				strErr+="tciunset54不能为空！\\n";	
			}
			if(this.txttciunset55.Text.Trim().Length==0)
			{
				strErr+="tciunset55不能为空！\\n";	
			}
			if(this.txttciunset56.Text.Trim().Length==0)
			{
				strErr+="tciunset56不能为空！\\n";	
			}
			if(this.txttciunset57.Text.Trim().Length==0)
			{
				strErr+="tciunset57不能为空！\\n";	
			}
			if(this.txttciunset58.Text.Trim().Length==0)
			{
				strErr+="tciunset58不能为空！\\n";	
			}
			if(this.txttciunset59.Text.Trim().Length==0)
			{
				strErr+="tciunset59不能为空！\\n";	
			}
			if(this.txttciunset60.Text.Trim().Length==0)
			{
				strErr+="tciunset60不能为空！\\n";	
			}
			if(this.txttciunset61.Text.Trim().Length==0)
			{
				strErr+="tciunset61不能为空！\\n";	
			}
			if(this.txttciunset62.Text.Trim().Length==0)
			{
				strErr+="tciunset62不能为空！\\n";	
			}
			if(this.txttciunset63.Text.Trim().Length==0)
			{
				strErr+="tciunset63不能为空！\\n";	
			}
			if(this.txttciunset64.Text.Trim().Length==0)
			{
				strErr+="tciunset64不能为空！\\n";	
			}
			if(this.txttciunset65.Text.Trim().Length==0)
			{
				strErr+="tciunset65不能为空！\\n";	
			}
			if(this.txttciunset66.Text.Trim().Length==0)
			{
				strErr+="tciunset66不能为空！\\n";	
			}
			if(this.txttciunset67.Text.Trim().Length==0)
			{
				strErr+="tciunset67不能为空！\\n";	
			}
			if(this.txttciunset68.Text.Trim().Length==0)
			{
				strErr+="tciunset68不能为空！\\n";	
			}
			if(this.txttciunset69.Text.Trim().Length==0)
			{
				strErr+="tciunset69不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txthouse_area_per_people.Text))
			{
				strErr+="house_area_per_people格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_help_figure.Text))
			{
				strErr+="community_help_figure格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_develop_figure.Text))
			{
				strErr+="community_develop_figure格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_engel_coefficient.Text))
			{
				strErr+="community_engel_coefficient格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_gini_coefficient.Text))
			{
				strErr+="community_gini_coefficient格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.lblcommunity_id.Text;
			decimal community_pop_total_density=decimal.Parse(this.txtcommunity_pop_total_density.Text);
			decimal community_pop_pure_density=decimal.Parse(this.txtcommunity_pop_pure_density.Text);
			decimal community_plot_ratio=decimal.Parse(this.txtcommunity_plot_ratio.Text);
			decimal community_conhou_struc_safe_problem_rate=decimal.Parse(this.txtcommunity_conhou_struc_safe_problem_rate.Text);
			decimal community_conhou_seepage_rate=decimal.Parse(this.txtcommunity_conhou_seepage_rate.Text);
			decimal community_conhou_tile_paint_cra_holl_rate=decimal.Parse(this.txtcommunity_conhou_tile_paint_cra_holl_rate.Text);
			decimal community_road_density=decimal.Parse(this.txtcommunity_road_density.Text);
			decimal road_per_capita_availability=decimal.Parse(this.txtroad_per_capita_availability.Text);
			decimal no_hard_road_rate=decimal.Parse(this.txtno_hard_road_rate.Text);
			decimal damage_road_rate=decimal.Parse(this.txtdamage_road_rate.Text);
			decimal large_slope_road_rate=decimal.Parse(this.txtlarge_slope_road_rate.Text);
			decimal lack_width_road_rate=decimal.Parse(this.txtlack_width_road_rate.Text);
			decimal need_new_repair_road_rate=decimal.Parse(this.txtneed_new_repair_road_rate.Text);
			decimal need_improve_link_ots_road=decimal.Parse(this.txtneed_improve_link_ots_road.Text);
			decimal no_brick_road_rate=decimal.Parse(this.txtno_brick_road_rate.Text);
			decimal damage_brick_road_rate=decimal.Parse(this.txtdamage_brick_road_rate.Text);
			decimal tap_water_fam_rate=decimal.Parse(this.txttap_water_fam_rate.Text);
			decimal no_water_meter_house_rate=decimal.Parse(this.txtno_water_meter_house_rate.Text);
			decimal water_supply_insuff_family_rate=decimal.Parse(this.txtwater_supply_insuff_family_rate.Text);
			decimal water_pressure_insuff_family_rate=decimal.Parse(this.txtwater_pressure_insuff_family_rate.Text);
			decimal caliber_samll_pipe_lenth_rate=decimal.Parse(this.txtcaliber_samll_pipe_lenth_rate.Text);
			decimal damage_pipe_lenth_rate=decimal.Parse(this.txtdamage_pipe_lenth_rate.Text);
			decimal senescent_erosive_pipe_length_rate=decimal.Parse(this.txtsenescent_erosive_pipe_length_rate.Text);
			decimal sewage_collection_rate=decimal.Parse(this.txtsewage_collection_rate.Text);
			decimal sewage_handle_rate=decimal.Parse(this.txtsewage_handle_rate.Text);
			decimal not_reasonable_drain_pipe_rate=decimal.Parse(this.txtnot_reasonable_drain_pipe_rate.Text);
			decimal caliber_samll_drain_pipe_rate=decimal.Parse(this.txtcaliber_samll_drain_pipe_rate.Text);
			decimal septic_tank_capacity_small_rate=decimal.Parse(this.txtseptic_tank_capacity_small_rate.Text);
			decimal senescent_erosive_drain_pipe_length_rate=decimal.Parse(this.txtsenescent_erosive_drain_pipe_length_rate.Text);
			decimal damage_drain_pipe_rate=decimal.Parse(this.txtdamage_drain_pipe_rate.Text);
			decimal broken_leaking_septic_tank_rate=decimal.Parse(this.txtbroken_leaking_septic_tank_rate.Text);
			decimal no_link_drain_pipe_net_famliy_rate=decimal.Parse(this.txtno_link_drain_pipe_net_famliy_rate.Text);
			decimal elec_reliable_rate=decimal.Parse(this.txtelec_reliable_rate.Text);
			decimal elec_capacity_lack_family_rate=decimal.Parse(this.txtelec_capacity_lack_family_rate.Text);
			decimal senescent_elec_wireways_rate=decimal.Parse(this.txtsenescent_elec_wireways_rate.Text);
			decimal no_elec_meter_house_rate=decimal.Parse(this.txtno_elec_meter_house_rate.Text);
			decimal not_norm_transformer_rate=decimal.Parse(this.txtnot_norm_transformer_rate.Text);
			decimal no_light_road_length_rate=decimal.Parse(this.txtno_light_road_length_rate.Text);
			decimal lack_light_road_rate=decimal.Parse(this.txtlack_light_road_rate.Text);
			decimal damage_road_light_rate=decimal.Parse(this.txtdamage_road_light_rate.Text);
			decimal passway_light_wireway_damage_house_rate=decimal.Parse(this.txtpassway_light_wireway_damage_house_rate.Text);
			decimal passway_light_wireway_damage_family_rate=decimal.Parse(this.txtpassway_light_wireway_damage_family_rate.Text);
			decimal greenland_rate=decimal.Parse(this.txtgreenland_rate.Text);
			decimal greenland_per_capita_area=decimal.Parse(this.txtgreenland_per_capita_area.Text);
			decimal no_lack_afforest_road_length_rate=decimal.Parse(this.txtno_lack_afforest_road_length_rate.Text);
			decimal no_lack_afforest_house_rate=decimal.Parse(this.txtno_lack_afforest_house_rate.Text);
			decimal lack_otds_hydrant_road_length_rate=decimal.Parse(this.txtlack_otds_hydrant_road_length_rate.Text);
			decimal lack_inds_hydrant_house_rate=decimal.Parse(this.txtlack_inds_hydrant_house_rate.Text);
			decimal extinguisher_insuff_building_rate=decimal.Parse(this.txtextinguisher_insuff_building_rate.Text);
			decimal ff_pipe_damage_length_rate=decimal.Parse(this.txtff_pipe_damage_length_rate.Text);
			decimal ff_road_block_building_rate=decimal.Parse(this.txtff_road_block_building_rate.Text);
			decimal rubbish_collection_rate=decimal.Parse(this.txtrubbish_collection_rate.Text);
			decimal rubbish_handle_rate=decimal.Parse(this.txtrubbish_handle_rate.Text);
			decimal dustbin_lack_road_length_rate=decimal.Parse(this.txtdustbin_lack_road_length_rate.Text);
			decimal dustbin_lack_house_rate=decimal.Parse(this.txtdustbin_lack_house_rate.Text);
			decimal long_term_rubbish_stack_rate=decimal.Parse(this.txtlong_term_rubbish_stack_rate.Text);
			decimal education_fs_indicator=decimal.Parse(this.txteducation_fs_indicator.Text);
			decimal education_gfa_indicator=decimal.Parse(this.txteducation_gfa_indicator.Text);
			decimal medical_fs_indicator=decimal.Parse(this.txtmedical_fs_indicator.Text);
			decimal medical_gfa_indicator=decimal.Parse(this.txtmedical_gfa_indicator.Text);
			decimal culture_sports_fs_indicator=decimal.Parse(this.txtculture_sports_fs_indicator.Text);
			decimal culture_sports_gfa_indicator=decimal.Parse(this.txtculture_sports_gfa_indicator.Text);
			decimal community_service_fs_indicator=decimal.Parse(this.txtcommunity_service_fs_indicator.Text);
			decimal community_service_gfa_indicator=decimal.Parse(this.txtcommunity_service_gfa_indicator.Text);
			decimal commerce_fs_indicator=decimal.Parse(this.txtcommerce_fs_indicator.Text);
			decimal commerce_gfa_indicator=decimal.Parse(this.txtcommerce_gfa_indicator.Text);
			decimal farm_produce_fair_fs_indicator=decimal.Parse(this.txtfarm_produce_fair_fs_indicator.Text);
			decimal farm_produce_fair_gfa_indicator=decimal.Parse(this.txtfarm_produce_fair_gfa_indicator.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tciunset1=this.txttciunset1.Text;
			string tciunset2=this.txttciunset2.Text;
			string tciunset3=this.txttciunset3.Text;
			string tciunset4=this.txttciunset4.Text;
			string tciunset5=this.txttciunset5.Text;
			string tciunset6=this.txttciunset6.Text;
			string tciunset7=this.txttciunset7.Text;
			string tciunset8=this.txttciunset8.Text;
			string tciunset9=this.txttciunset9.Text;
			string tciunset10=this.txttciunset10.Text;
			string tciunset11=this.txttciunset11.Text;
			string tciunset12=this.txttciunset12.Text;
			string tciunset13=this.txttciunset13.Text;
			string tciunset14=this.txttciunset14.Text;
			string tciunset15=this.txttciunset15.Text;
			string tciunset16=this.txttciunset16.Text;
			string tciunset17=this.txttciunset17.Text;
			string tciunset18=this.txttciunset18.Text;
			string tciunset19=this.txttciunset19.Text;
			string tciunset20=this.txttciunset20.Text;
			string tciunset21=this.txttciunset21.Text;
			string tciunset22=this.txttciunset22.Text;
			string tciunset23=this.txttciunset23.Text;
			string tciunset24=this.txttciunset24.Text;
			string tciunset25=this.txttciunset25.Text;
			string tciunset26=this.txttciunset26.Text;
			string tciunset27=this.txttciunset27.Text;
			string tciunset28=this.txttciunset28.Text;
			string tciunset29=this.txttciunset29.Text;
			string tciunset30=this.txttciunset30.Text;
			string tciunset31=this.txttciunset31.Text;
			string tciunset32=this.txttciunset32.Text;
			string tciunset33=this.txttciunset33.Text;
			string tciunset34=this.txttciunset34.Text;
			string tciunset35=this.txttciunset35.Text;
			string tciunset36=this.txttciunset36.Text;
			string tciunset37=this.txttciunset37.Text;
			string tciunset38=this.txttciunset38.Text;
			string tciunset39=this.txttciunset39.Text;
			string tciunset40=this.txttciunset40.Text;
			string tciunset41=this.txttciunset41.Text;
			string tciunset42=this.txttciunset42.Text;
			string tciunset43=this.txttciunset43.Text;
			string tciunset44=this.txttciunset44.Text;
			string tciunset45=this.txttciunset45.Text;
			string tciunset46=this.txttciunset46.Text;
			string tciunset47=this.txttciunset47.Text;
			string tciunset48=this.txttciunset48.Text;
			string tciunset49=this.txttciunset49.Text;
			string tciunset50=this.txttciunset50.Text;
			string tciunset51=this.txttciunset51.Text;
			string tciunset52=this.txttciunset52.Text;
			string tciunset53=this.txttciunset53.Text;
			string tciunset54=this.txttciunset54.Text;
			string tciunset55=this.txttciunset55.Text;
			string tciunset56=this.txttciunset56.Text;
			string tciunset57=this.txttciunset57.Text;
			string tciunset58=this.txttciunset58.Text;
			string tciunset59=this.txttciunset59.Text;
			string tciunset60=this.txttciunset60.Text;
			string tciunset61=this.txttciunset61.Text;
			string tciunset62=this.txttciunset62.Text;
			string tciunset63=this.txttciunset63.Text;
			string tciunset64=this.txttciunset64.Text;
			string tciunset65=this.txttciunset65.Text;
			string tciunset66=this.txttciunset66.Text;
			string tciunset67=this.txttciunset67.Text;
			string tciunset68=this.txttciunset68.Text;
			string tciunset69=this.txttciunset69.Text;
			int check_status=int.Parse(this.txtcheck_status.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			decimal house_area_per_people=decimal.Parse(this.txthouse_area_per_people.Text);
			decimal community_help_figure=decimal.Parse(this.txtcommunity_help_figure.Text);
			decimal community_develop_figure=decimal.Parse(this.txtcommunity_develop_figure.Text);
			decimal community_engel_coefficient=decimal.Parse(this.txtcommunity_engel_coefficient.Text);
			decimal community_gini_coefficient=decimal.Parse(this.txtcommunity_gini_coefficient.Text);


			TTG.Model.TTGWeb.Community_Indicator model=new TTG.Model.TTGWeb.Community_Indicator();
			model.community_id=community_id;
			model.community_pop_total_density=community_pop_total_density;
			model.community_pop_pure_density=community_pop_pure_density;
			model.community_plot_ratio=community_plot_ratio;
			model.community_conhou_struc_safe_problem_rate=community_conhou_struc_safe_problem_rate;
			model.community_conhou_seepage_rate=community_conhou_seepage_rate;
			model.community_conhou_tile_paint_cra_holl_rate=community_conhou_tile_paint_cra_holl_rate;
			model.community_road_density=community_road_density;
			model.road_per_capita_availability=road_per_capita_availability;
			model.no_hard_road_rate=no_hard_road_rate;
			model.damage_road_rate=damage_road_rate;
			model.large_slope_road_rate=large_slope_road_rate;
			model.lack_width_road_rate=lack_width_road_rate;
			model.need_new_repair_road_rate=need_new_repair_road_rate;
			model.need_improve_link_ots_road=need_improve_link_ots_road;
			model.no_brick_road_rate=no_brick_road_rate;
			model.damage_brick_road_rate=damage_brick_road_rate;
			model.tap_water_fam_rate=tap_water_fam_rate;
			model.no_water_meter_house_rate=no_water_meter_house_rate;
			model.water_supply_insuff_family_rate=water_supply_insuff_family_rate;
			model.water_pressure_insuff_family_rate=water_pressure_insuff_family_rate;
			model.caliber_samll_pipe_lenth_rate=caliber_samll_pipe_lenth_rate;
			model.damage_pipe_lenth_rate=damage_pipe_lenth_rate;
			model.senescent_erosive_pipe_length_rate=senescent_erosive_pipe_length_rate;
			model.sewage_collection_rate=sewage_collection_rate;
			model.sewage_handle_rate=sewage_handle_rate;
			model.not_reasonable_drain_pipe_rate=not_reasonable_drain_pipe_rate;
			model.caliber_samll_drain_pipe_rate=caliber_samll_drain_pipe_rate;
			model.septic_tank_capacity_small_rate=septic_tank_capacity_small_rate;
			model.senescent_erosive_drain_pipe_length_rate=senescent_erosive_drain_pipe_length_rate;
			model.damage_drain_pipe_rate=damage_drain_pipe_rate;
			model.broken_leaking_septic_tank_rate=broken_leaking_septic_tank_rate;
			model.no_link_drain_pipe_net_famliy_rate=no_link_drain_pipe_net_famliy_rate;
			model.elec_reliable_rate=elec_reliable_rate;
			model.elec_capacity_lack_family_rate=elec_capacity_lack_family_rate;
			model.senescent_elec_wireways_rate=senescent_elec_wireways_rate;
			model.no_elec_meter_house_rate=no_elec_meter_house_rate;
			model.not_norm_transformer_rate=not_norm_transformer_rate;
			model.no_light_road_length_rate=no_light_road_length_rate;
			model.lack_light_road_rate=lack_light_road_rate;
			model.damage_road_light_rate=damage_road_light_rate;
			model.passway_light_wireway_damage_house_rate=passway_light_wireway_damage_house_rate;
			model.passway_light_wireway_damage_family_rate=passway_light_wireway_damage_family_rate;
			model.greenland_rate=greenland_rate;
			model.greenland_per_capita_area=greenland_per_capita_area;
			model.no_lack_afforest_road_length_rate=no_lack_afforest_road_length_rate;
			model.no_lack_afforest_house_rate=no_lack_afforest_house_rate;
			model.lack_otds_hydrant_road_length_rate=lack_otds_hydrant_road_length_rate;
			model.lack_inds_hydrant_house_rate=lack_inds_hydrant_house_rate;
			model.extinguisher_insuff_building_rate=extinguisher_insuff_building_rate;
			model.ff_pipe_damage_length_rate=ff_pipe_damage_length_rate;
			model.ff_road_block_building_rate=ff_road_block_building_rate;
			model.rubbish_collection_rate=rubbish_collection_rate;
			model.rubbish_handle_rate=rubbish_handle_rate;
			model.dustbin_lack_road_length_rate=dustbin_lack_road_length_rate;
			model.dustbin_lack_house_rate=dustbin_lack_house_rate;
			model.long_term_rubbish_stack_rate=long_term_rubbish_stack_rate;
			model.education_fs_indicator=education_fs_indicator;
			model.education_gfa_indicator=education_gfa_indicator;
			model.medical_fs_indicator=medical_fs_indicator;
			model.medical_gfa_indicator=medical_gfa_indicator;
			model.culture_sports_fs_indicator=culture_sports_fs_indicator;
			model.culture_sports_gfa_indicator=culture_sports_gfa_indicator;
			model.community_service_fs_indicator=community_service_fs_indicator;
			model.community_service_gfa_indicator=community_service_gfa_indicator;
			model.commerce_fs_indicator=commerce_fs_indicator;
			model.commerce_gfa_indicator=commerce_gfa_indicator;
			model.farm_produce_fair_fs_indicator=farm_produce_fair_fs_indicator;
			model.farm_produce_fair_gfa_indicator=farm_produce_fair_gfa_indicator;
			model.statistics_date=statistics_date;
			model.tciunset1=tciunset1;
			model.tciunset2=tciunset2;
			model.tciunset3=tciunset3;
			model.tciunset4=tciunset4;
			model.tciunset5=tciunset5;
			model.tciunset6=tciunset6;
			model.tciunset7=tciunset7;
			model.tciunset8=tciunset8;
			model.tciunset9=tciunset9;
			model.tciunset10=tciunset10;
			model.tciunset11=tciunset11;
			model.tciunset12=tciunset12;
			model.tciunset13=tciunset13;
			model.tciunset14=tciunset14;
			model.tciunset15=tciunset15;
			model.tciunset16=tciunset16;
			model.tciunset17=tciunset17;
			model.tciunset18=tciunset18;
			model.tciunset19=tciunset19;
			model.tciunset20=tciunset20;
			model.tciunset21=tciunset21;
			model.tciunset22=tciunset22;
			model.tciunset23=tciunset23;
			model.tciunset24=tciunset24;
			model.tciunset25=tciunset25;
			model.tciunset26=tciunset26;
			model.tciunset27=tciunset27;
			model.tciunset28=tciunset28;
			model.tciunset29=tciunset29;
			model.tciunset30=tciunset30;
			model.tciunset31=tciunset31;
			model.tciunset32=tciunset32;
			model.tciunset33=tciunset33;
			model.tciunset34=tciunset34;
			model.tciunset35=tciunset35;
			model.tciunset36=tciunset36;
			model.tciunset37=tciunset37;
			model.tciunset38=tciunset38;
			model.tciunset39=tciunset39;
			model.tciunset40=tciunset40;
			model.tciunset41=tciunset41;
			model.tciunset42=tciunset42;
			model.tciunset43=tciunset43;
			model.tciunset44=tciunset44;
			model.tciunset45=tciunset45;
			model.tciunset46=tciunset46;
			model.tciunset47=tciunset47;
			model.tciunset48=tciunset48;
			model.tciunset49=tciunset49;
			model.tciunset50=tciunset50;
			model.tciunset51=tciunset51;
			model.tciunset52=tciunset52;
			model.tciunset53=tciunset53;
			model.tciunset54=tciunset54;
			model.tciunset55=tciunset55;
			model.tciunset56=tciunset56;
			model.tciunset57=tciunset57;
			model.tciunset58=tciunset58;
			model.tciunset59=tciunset59;
			model.tciunset60=tciunset60;
			model.tciunset61=tciunset61;
			model.tciunset62=tciunset62;
			model.tciunset63=tciunset63;
			model.tciunset64=tciunset64;
			model.tciunset65=tciunset65;
			model.tciunset66=tciunset66;
			model.tciunset67=tciunset67;
			model.tciunset68=tciunset68;
			model.tciunset69=tciunset69;
			model.check_status=check_status;
			model.lock_tables=lock_tables;
			model.house_area_per_people=house_area_per_people;
			model.community_help_figure=community_help_figure;
			model.community_develop_figure=community_develop_figure;
			model.community_engel_coefficient=community_engel_coefficient;
			model.community_gini_coefficient=community_gini_coefficient;

			TTG.BLL.TTGWeb.Community_Indicator bll=new TTG.BLL.TTGWeb.Community_Indicator();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
