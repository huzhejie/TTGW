<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.Community_Indicator.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		community_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pop_total_density
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_pop_total_density" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pop_pure_density
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_pop_pure_density" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_plot_ratio
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_plot_ratio" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_conhou_struc_safe_problem_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_conhou_struc_safe_problem_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_conhou_seepage_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_conhou_seepage_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_conhou_tile_paint_cra_holl_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_conhou_tile_paint_cra_holl_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_density
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_density" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_per_capita_availability
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblroad_per_capita_availability" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_hard_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblno_hard_road_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		damage_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldamage_road_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		large_slope_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllarge_slope_road_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lack_width_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllack_width_road_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		need_new_repair_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblneed_new_repair_road_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		need_improve_link_ots_road
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblneed_improve_link_ots_road" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_brick_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblno_brick_road_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		damage_brick_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldamage_brick_road_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tap_water_fam_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltap_water_fam_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_water_meter_house_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblno_water_meter_house_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		water_supply_insuff_family_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblwater_supply_insuff_family_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		water_pressure_insuff_family_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblwater_pressure_insuff_family_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		caliber_samll_pipe_lenth_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcaliber_samll_pipe_lenth_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		damage_pipe_lenth_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldamage_pipe_lenth_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		senescent_erosive_pipe_length_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsenescent_erosive_pipe_length_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sewage_collection_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsewage_collection_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sewage_handle_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsewage_handle_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		not_reasonable_drain_pipe_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnot_reasonable_drain_pipe_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		caliber_samll_drain_pipe_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcaliber_samll_drain_pipe_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		septic_tank_capacity_small_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblseptic_tank_capacity_small_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		senescent_erosive_drain_pipe_length_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsenescent_erosive_drain_pipe_length_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		damage_drain_pipe_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldamage_drain_pipe_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		broken_leaking_septic_tank_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbroken_leaking_septic_tank_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_link_drain_pipe_net_famliy_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblno_link_drain_pipe_net_famliy_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		elec_reliable_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblelec_reliable_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		elec_capacity_lack_family_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblelec_capacity_lack_family_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		senescent_elec_wireways_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsenescent_elec_wireways_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_elec_meter_house_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblno_elec_meter_house_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		not_norm_transformer_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnot_norm_transformer_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_light_road_length_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblno_light_road_length_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lack_light_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllack_light_road_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		damage_road_light_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldamage_road_light_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		passway_light_wireway_damage_house_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpassway_light_wireway_damage_house_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		passway_light_wireway_damage_family_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpassway_light_wireway_damage_family_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		greenland_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblgreenland_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		greenland_per_capita_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblgreenland_per_capita_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_lack_afforest_road_length_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblno_lack_afforest_road_length_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_lack_afforest_house_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblno_lack_afforest_house_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lack_otds_hydrant_road_length_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllack_otds_hydrant_road_length_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lack_inds_hydrant_house_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllack_inds_hydrant_house_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		extinguisher_insuff_building_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblextinguisher_insuff_building_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ff_pipe_damage_length_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblff_pipe_damage_length_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ff_road_block_building_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblff_road_block_building_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		rubbish_collection_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblrubbish_collection_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		rubbish_handle_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblrubbish_handle_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		dustbin_lack_road_length_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldustbin_lack_road_length_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		dustbin_lack_house_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldustbin_lack_house_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		long_term_rubbish_stack_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllong_term_rubbish_stack_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		education_fs_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbleducation_fs_indicator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		education_gfa_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbleducation_gfa_indicator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		medical_fs_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmedical_fs_indicator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		medical_gfa_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmedical_gfa_indicator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		culture_sports_fs_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblculture_sports_fs_indicator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		culture_sports_gfa_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblculture_sports_gfa_indicator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_service_fs_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_service_fs_indicator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_service_gfa_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_service_gfa_indicator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		commerce_fs_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommerce_fs_indicator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		commerce_gfa_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommerce_gfa_indicator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		farm_produce_fair_fs_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfarm_produce_fair_fs_indicator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		farm_produce_fair_gfa_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfarm_produce_fair_gfa_indicator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		statistics_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstatistics_date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset17" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset18" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset19" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset20" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset21" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset22
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset22" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset23
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset23" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset24
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset24" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset25
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset25" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset26
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset26" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset27
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset27" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset28
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset28" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset29
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset29" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset30
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset30" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset31
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset31" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset32
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset32" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset33
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset33" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset34
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset34" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset35
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset35" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset36
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset36" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset37
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset37" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset38
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset38" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset39
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset39" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset40
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset40" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset41
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset41" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset42
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset42" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset43
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset43" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset44
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset44" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset45
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset45" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset46
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset46" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset47
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset47" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset48
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset48" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset49
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset49" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset50
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset50" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset51
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset51" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset52
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset52" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset53
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset53" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset54
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset54" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset55
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset55" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset56
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset56" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset57
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset57" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset58
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset58" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset59
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset59" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset60
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset60" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset61
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset61" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset62
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset62" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset63
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset63" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset64
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset64" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset65
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset65" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset66
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset66" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset67
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset67" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset68
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset68" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset69
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset69" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		check_status
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcheck_status" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lock_tables
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllock_tables" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		house_area_per_people
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblhouse_area_per_people" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_help_figure
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_help_figure" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_develop_figure
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_develop_figure" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_engel_coefficient
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_engel_coefficient" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_gini_coefficient
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_gini_coefficient" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




