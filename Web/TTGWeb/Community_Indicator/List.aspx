<%@ Page Title="T_Community_Indicator" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.Community_Indicator.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="community_id,statistics_date" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="community_id" HeaderText="community_id" SortExpression="community_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_pop_total_density" HeaderText="community_pop_total_density" SortExpression="community_pop_total_density" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_pop_pure_density" HeaderText="community_pop_pure_density" SortExpression="community_pop_pure_density" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_plot_ratio" HeaderText="community_plot_ratio" SortExpression="community_plot_ratio" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_conhou_struc_safe_problem_rate" HeaderText="community_conhou_struc_safe_problem_rate" SortExpression="community_conhou_struc_safe_problem_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_conhou_seepage_rate" HeaderText="community_conhou_seepage_rate" SortExpression="community_conhou_seepage_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_conhou_tile_paint_cra_holl_rate" HeaderText="community_conhou_tile_paint_cra_holl_rate" SortExpression="community_conhou_tile_paint_cra_holl_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_density" HeaderText="community_road_density" SortExpression="community_road_density" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="road_per_capita_availability" HeaderText="road_per_capita_availability" SortExpression="road_per_capita_availability" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="no_hard_road_rate" HeaderText="no_hard_road_rate" SortExpression="no_hard_road_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="damage_road_rate" HeaderText="damage_road_rate" SortExpression="damage_road_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="large_slope_road_rate" HeaderText="large_slope_road_rate" SortExpression="large_slope_road_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lack_width_road_rate" HeaderText="lack_width_road_rate" SortExpression="lack_width_road_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="need_new_repair_road_rate" HeaderText="need_new_repair_road_rate" SortExpression="need_new_repair_road_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="need_improve_link_ots_road" HeaderText="need_improve_link_ots_road" SortExpression="need_improve_link_ots_road" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="no_brick_road_rate" HeaderText="no_brick_road_rate" SortExpression="no_brick_road_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="damage_brick_road_rate" HeaderText="damage_brick_road_rate" SortExpression="damage_brick_road_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tap_water_fam_rate" HeaderText="tap_water_fam_rate" SortExpression="tap_water_fam_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="no_water_meter_house_rate" HeaderText="no_water_meter_house_rate" SortExpression="no_water_meter_house_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="water_supply_insuff_family_rate" HeaderText="water_supply_insuff_family_rate" SortExpression="water_supply_insuff_family_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="water_pressure_insuff_family_rate" HeaderText="water_pressure_insuff_family_rate" SortExpression="water_pressure_insuff_family_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="caliber_samll_pipe_lenth_rate" HeaderText="caliber_samll_pipe_lenth_rate" SortExpression="caliber_samll_pipe_lenth_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="damage_pipe_lenth_rate" HeaderText="damage_pipe_lenth_rate" SortExpression="damage_pipe_lenth_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="senescent_erosive_pipe_length_rate" HeaderText="senescent_erosive_pipe_length_rate" SortExpression="senescent_erosive_pipe_length_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sewage_collection_rate" HeaderText="sewage_collection_rate" SortExpression="sewage_collection_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sewage_handle_rate" HeaderText="sewage_handle_rate" SortExpression="sewage_handle_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="not_reasonable_drain_pipe_rate" HeaderText="not_reasonable_drain_pipe_rate" SortExpression="not_reasonable_drain_pipe_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="caliber_samll_drain_pipe_rate" HeaderText="caliber_samll_drain_pipe_rate" SortExpression="caliber_samll_drain_pipe_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="septic_tank_capacity_small_rate" HeaderText="septic_tank_capacity_small_rate" SortExpression="septic_tank_capacity_small_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="senescent_erosive_drain_pipe_length_rate" HeaderText="senescent_erosive_drain_pipe_length_rate" SortExpression="senescent_erosive_drain_pipe_length_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="damage_drain_pipe_rate" HeaderText="damage_drain_pipe_rate" SortExpression="damage_drain_pipe_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="broken_leaking_septic_tank_rate" HeaderText="broken_leaking_septic_tank_rate" SortExpression="broken_leaking_septic_tank_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="no_link_drain_pipe_net_famliy_rate" HeaderText="no_link_drain_pipe_net_famliy_rate" SortExpression="no_link_drain_pipe_net_famliy_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="elec_reliable_rate" HeaderText="elec_reliable_rate" SortExpression="elec_reliable_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="elec_capacity_lack_family_rate" HeaderText="elec_capacity_lack_family_rate" SortExpression="elec_capacity_lack_family_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="senescent_elec_wireways_rate" HeaderText="senescent_elec_wireways_rate" SortExpression="senescent_elec_wireways_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="no_elec_meter_house_rate" HeaderText="no_elec_meter_house_rate" SortExpression="no_elec_meter_house_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="not_norm_transformer_rate" HeaderText="not_norm_transformer_rate" SortExpression="not_norm_transformer_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="no_light_road_length_rate" HeaderText="no_light_road_length_rate" SortExpression="no_light_road_length_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lack_light_road_rate" HeaderText="lack_light_road_rate" SortExpression="lack_light_road_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="damage_road_light_rate" HeaderText="damage_road_light_rate" SortExpression="damage_road_light_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="passway_light_wireway_damage_house_rate" HeaderText="passway_light_wireway_damage_house_rate" SortExpression="passway_light_wireway_damage_house_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="passway_light_wireway_damage_family_rate" HeaderText="passway_light_wireway_damage_family_rate" SortExpression="passway_light_wireway_damage_family_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="greenland_rate" HeaderText="greenland_rate" SortExpression="greenland_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="greenland_per_capita_area" HeaderText="greenland_per_capita_area" SortExpression="greenland_per_capita_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="no_lack_afforest_road_length_rate" HeaderText="no_lack_afforest_road_length_rate" SortExpression="no_lack_afforest_road_length_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="no_lack_afforest_house_rate" HeaderText="no_lack_afforest_house_rate" SortExpression="no_lack_afforest_house_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lack_otds_hydrant_road_length_rate" HeaderText="lack_otds_hydrant_road_length_rate" SortExpression="lack_otds_hydrant_road_length_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lack_inds_hydrant_house_rate" HeaderText="lack_inds_hydrant_house_rate" SortExpression="lack_inds_hydrant_house_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="extinguisher_insuff_building_rate" HeaderText="extinguisher_insuff_building_rate" SortExpression="extinguisher_insuff_building_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ff_pipe_damage_length_rate" HeaderText="ff_pipe_damage_length_rate" SortExpression="ff_pipe_damage_length_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ff_road_block_building_rate" HeaderText="ff_road_block_building_rate" SortExpression="ff_road_block_building_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="rubbish_collection_rate" HeaderText="rubbish_collection_rate" SortExpression="rubbish_collection_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="rubbish_handle_rate" HeaderText="rubbish_handle_rate" SortExpression="rubbish_handle_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="dustbin_lack_road_length_rate" HeaderText="dustbin_lack_road_length_rate" SortExpression="dustbin_lack_road_length_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="dustbin_lack_house_rate" HeaderText="dustbin_lack_house_rate" SortExpression="dustbin_lack_house_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="long_term_rubbish_stack_rate" HeaderText="long_term_rubbish_stack_rate" SortExpression="long_term_rubbish_stack_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="education_fs_indicator" HeaderText="education_fs_indicator" SortExpression="education_fs_indicator" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="education_gfa_indicator" HeaderText="education_gfa_indicator" SortExpression="education_gfa_indicator" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="medical_fs_indicator" HeaderText="medical_fs_indicator" SortExpression="medical_fs_indicator" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="medical_gfa_indicator" HeaderText="medical_gfa_indicator" SortExpression="medical_gfa_indicator" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="culture_sports_fs_indicator" HeaderText="culture_sports_fs_indicator" SortExpression="culture_sports_fs_indicator" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="culture_sports_gfa_indicator" HeaderText="culture_sports_gfa_indicator" SortExpression="culture_sports_gfa_indicator" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_service_fs_indicator" HeaderText="community_service_fs_indicator" SortExpression="community_service_fs_indicator" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_service_gfa_indicator" HeaderText="community_service_gfa_indicator" SortExpression="community_service_gfa_indicator" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="commerce_fs_indicator" HeaderText="commerce_fs_indicator" SortExpression="commerce_fs_indicator" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="commerce_gfa_indicator" HeaderText="commerce_gfa_indicator" SortExpression="commerce_gfa_indicator" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="farm_produce_fair_fs_indicator" HeaderText="farm_produce_fair_fs_indicator" SortExpression="farm_produce_fair_fs_indicator" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="farm_produce_fair_gfa_indicator" HeaderText="farm_produce_fair_gfa_indicator" SortExpression="farm_produce_fair_gfa_indicator" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset1" HeaderText="tciunset1" SortExpression="tciunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset2" HeaderText="tciunset2" SortExpression="tciunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset3" HeaderText="tciunset3" SortExpression="tciunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset4" HeaderText="tciunset4" SortExpression="tciunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset5" HeaderText="tciunset5" SortExpression="tciunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset6" HeaderText="tciunset6" SortExpression="tciunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset7" HeaderText="tciunset7" SortExpression="tciunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset8" HeaderText="tciunset8" SortExpression="tciunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset9" HeaderText="tciunset9" SortExpression="tciunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset10" HeaderText="tciunset10" SortExpression="tciunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset11" HeaderText="tciunset11" SortExpression="tciunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset12" HeaderText="tciunset12" SortExpression="tciunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset13" HeaderText="tciunset13" SortExpression="tciunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset14" HeaderText="tciunset14" SortExpression="tciunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset15" HeaderText="tciunset15" SortExpression="tciunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset16" HeaderText="tciunset16" SortExpression="tciunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset17" HeaderText="tciunset17" SortExpression="tciunset17" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset18" HeaderText="tciunset18" SortExpression="tciunset18" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset19" HeaderText="tciunset19" SortExpression="tciunset19" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset20" HeaderText="tciunset20" SortExpression="tciunset20" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset21" HeaderText="tciunset21" SortExpression="tciunset21" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset22" HeaderText="tciunset22" SortExpression="tciunset22" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset23" HeaderText="tciunset23" SortExpression="tciunset23" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset24" HeaderText="tciunset24" SortExpression="tciunset24" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset25" HeaderText="tciunset25" SortExpression="tciunset25" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset26" HeaderText="tciunset26" SortExpression="tciunset26" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset27" HeaderText="tciunset27" SortExpression="tciunset27" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset28" HeaderText="tciunset28" SortExpression="tciunset28" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset29" HeaderText="tciunset29" SortExpression="tciunset29" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset30" HeaderText="tciunset30" SortExpression="tciunset30" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset31" HeaderText="tciunset31" SortExpression="tciunset31" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset32" HeaderText="tciunset32" SortExpression="tciunset32" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset33" HeaderText="tciunset33" SortExpression="tciunset33" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset34" HeaderText="tciunset34" SortExpression="tciunset34" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset35" HeaderText="tciunset35" SortExpression="tciunset35" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset36" HeaderText="tciunset36" SortExpression="tciunset36" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset37" HeaderText="tciunset37" SortExpression="tciunset37" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset38" HeaderText="tciunset38" SortExpression="tciunset38" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset39" HeaderText="tciunset39" SortExpression="tciunset39" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset40" HeaderText="tciunset40" SortExpression="tciunset40" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset41" HeaderText="tciunset41" SortExpression="tciunset41" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset42" HeaderText="tciunset42" SortExpression="tciunset42" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset43" HeaderText="tciunset43" SortExpression="tciunset43" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset44" HeaderText="tciunset44" SortExpression="tciunset44" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset45" HeaderText="tciunset45" SortExpression="tciunset45" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset46" HeaderText="tciunset46" SortExpression="tciunset46" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset47" HeaderText="tciunset47" SortExpression="tciunset47" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset48" HeaderText="tciunset48" SortExpression="tciunset48" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset49" HeaderText="tciunset49" SortExpression="tciunset49" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset50" HeaderText="tciunset50" SortExpression="tciunset50" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset51" HeaderText="tciunset51" SortExpression="tciunset51" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset52" HeaderText="tciunset52" SortExpression="tciunset52" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset53" HeaderText="tciunset53" SortExpression="tciunset53" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset54" HeaderText="tciunset54" SortExpression="tciunset54" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset55" HeaderText="tciunset55" SortExpression="tciunset55" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset56" HeaderText="tciunset56" SortExpression="tciunset56" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset57" HeaderText="tciunset57" SortExpression="tciunset57" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset58" HeaderText="tciunset58" SortExpression="tciunset58" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset59" HeaderText="tciunset59" SortExpression="tciunset59" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset60" HeaderText="tciunset60" SortExpression="tciunset60" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset61" HeaderText="tciunset61" SortExpression="tciunset61" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset62" HeaderText="tciunset62" SortExpression="tciunset62" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset63" HeaderText="tciunset63" SortExpression="tciunset63" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset64" HeaderText="tciunset64" SortExpression="tciunset64" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset65" HeaderText="tciunset65" SortExpression="tciunset65" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset66" HeaderText="tciunset66" SortExpression="tciunset66" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset67" HeaderText="tciunset67" SortExpression="tciunset67" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset68" HeaderText="tciunset68" SortExpression="tciunset68" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset69" HeaderText="tciunset69" SortExpression="tciunset69" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="house_area_per_people" HeaderText="house_area_per_people" SortExpression="house_area_per_people" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_help_figure" HeaderText="community_help_figure" SortExpression="community_help_figure" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_develop_figure" HeaderText="community_develop_figure" SortExpression="community_develop_figure" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_engel_coefficient" HeaderText="community_engel_coefficient" SortExpression="community_engel_coefficient" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_gini_coefficient" HeaderText="community_gini_coefficient" SortExpression="community_gini_coefficient" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="community_id,statistics_date" DataNavigateUrlFormatString="Show.aspx?id0={0}&id1={1}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="community_id,statistics_date" DataNavigateUrlFormatString="Modify.aspx?id0={0}&id1={1}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
