<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.Community_Indicator.Modify" Title="修改页" %>
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
		<asp:label id="lblcommunity_id" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pop_total_density
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_pop_total_density" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pop_pure_density
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_pop_pure_density" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_plot_ratio
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_plot_ratio" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_conhou_struc_safe_problem_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_conhou_struc_safe_problem_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_conhou_seepage_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_conhou_seepage_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_conhou_tile_paint_cra_holl_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_conhou_tile_paint_cra_holl_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_density
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_density" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_per_capita_availability
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtroad_per_capita_availability" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_hard_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtno_hard_road_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		damage_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdamage_road_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		large_slope_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlarge_slope_road_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lack_width_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlack_width_road_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		need_new_repair_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtneed_new_repair_road_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		need_improve_link_ots_road
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtneed_improve_link_ots_road" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_brick_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtno_brick_road_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		damage_brick_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdamage_brick_road_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tap_water_fam_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttap_water_fam_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_water_meter_house_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtno_water_meter_house_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		water_supply_insuff_family_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtwater_supply_insuff_family_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		water_pressure_insuff_family_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtwater_pressure_insuff_family_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		caliber_samll_pipe_lenth_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcaliber_samll_pipe_lenth_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		damage_pipe_lenth_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdamage_pipe_lenth_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		senescent_erosive_pipe_length_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsenescent_erosive_pipe_length_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sewage_collection_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsewage_collection_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sewage_handle_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsewage_handle_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		not_reasonable_drain_pipe_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnot_reasonable_drain_pipe_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		caliber_samll_drain_pipe_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcaliber_samll_drain_pipe_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		septic_tank_capacity_small_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtseptic_tank_capacity_small_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		senescent_erosive_drain_pipe_length_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsenescent_erosive_drain_pipe_length_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		damage_drain_pipe_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdamage_drain_pipe_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		broken_leaking_septic_tank_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbroken_leaking_septic_tank_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_link_drain_pipe_net_famliy_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtno_link_drain_pipe_net_famliy_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		elec_reliable_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtelec_reliable_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		elec_capacity_lack_family_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtelec_capacity_lack_family_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		senescent_elec_wireways_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsenescent_elec_wireways_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_elec_meter_house_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtno_elec_meter_house_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		not_norm_transformer_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnot_norm_transformer_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_light_road_length_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtno_light_road_length_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lack_light_road_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlack_light_road_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		damage_road_light_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdamage_road_light_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		passway_light_wireway_damage_house_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpassway_light_wireway_damage_house_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		passway_light_wireway_damage_family_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpassway_light_wireway_damage_family_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		greenland_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgreenland_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		greenland_per_capita_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgreenland_per_capita_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_lack_afforest_road_length_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtno_lack_afforest_road_length_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_lack_afforest_house_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtno_lack_afforest_house_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lack_otds_hydrant_road_length_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlack_otds_hydrant_road_length_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lack_inds_hydrant_house_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlack_inds_hydrant_house_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		extinguisher_insuff_building_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtextinguisher_insuff_building_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ff_pipe_damage_length_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtff_pipe_damage_length_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ff_road_block_building_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtff_road_block_building_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		rubbish_collection_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtrubbish_collection_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		rubbish_handle_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtrubbish_handle_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		dustbin_lack_road_length_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdustbin_lack_road_length_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		dustbin_lack_house_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdustbin_lack_house_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		long_term_rubbish_stack_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlong_term_rubbish_stack_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		education_fs_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txteducation_fs_indicator" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		education_gfa_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txteducation_gfa_indicator" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		medical_fs_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtmedical_fs_indicator" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		medical_gfa_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtmedical_gfa_indicator" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		culture_sports_fs_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtculture_sports_fs_indicator" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		culture_sports_gfa_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtculture_sports_gfa_indicator" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_service_fs_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_service_fs_indicator" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_service_gfa_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_service_gfa_indicator" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		commerce_fs_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommerce_fs_indicator" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		commerce_gfa_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommerce_gfa_indicator" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		farm_produce_fair_fs_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfarm_produce_fair_fs_indicator" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		farm_produce_fair_gfa_indicator
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfarm_produce_fair_gfa_indicator" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		statistics_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblstatistics_date" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset15" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset16" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset17" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset18" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset19" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset20" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset21" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset22
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset22" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset23
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset23" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset24
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset24" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset25
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset25" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset26
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset26" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset27
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset27" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset28
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset28" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset29
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset29" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset30
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset30" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset31
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset31" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset32
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset32" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset33
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset33" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset34
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset34" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset35
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset35" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset36
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset36" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset37
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset37" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset38
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset38" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset39
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset39" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset40
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset40" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset41
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset41" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset42
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset42" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset43
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset43" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset44
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset44" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset45
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset45" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset46
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset46" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset47
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset47" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset48
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset48" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset49
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset49" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset50
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset50" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset51
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset51" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset52
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset52" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset53
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset53" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset54
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset54" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset55
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset55" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset56
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset56" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset57
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset57" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset58
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset58" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset59
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset59" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset60
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset60" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset61
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset61" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset62
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset62" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset63
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset63" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset64
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset64" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset65
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset65" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset66
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset66" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset67
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset67" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset68
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset68" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset69
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset69" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		check_status
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcheck_status" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lock_tables
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlock_tables" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		house_area_per_people
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txthouse_area_per_people" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_help_figure
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_help_figure" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_develop_figure
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_develop_figure" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_engel_coefficient
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_engel_coefficient" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_gini_coefficient
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_gini_coefficient" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

