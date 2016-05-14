<%@ Page Title="T_effect_indicator" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.effect_indicator.List" %>
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
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="structure_safe_good_rate" HeaderText="structure_safe_good_rate" SortExpression="structure_safe_good_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="roof_good_rate" HeaderText="roof_good_rate" SortExpression="roof_good_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="wall_good_rate" HeaderText="wall_good_rate" SortExpression="wall_good_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="slope_safe_rate" HeaderText="slope_safe_rate" SortExpression="slope_safe_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="concil_house_validate" HeaderText="concil_house_validate" SortExpression="concil_house_validate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="road_link_degree" HeaderText="road_link_degree" SortExpression="road_link_degree" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="road_good_degree" HeaderText="road_good_degree" SortExpression="road_good_degree" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="traffic_validate" HeaderText="traffic_validate" SortExpression="traffic_validate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="water_capcity_degree" HeaderText="water_capcity_degree" SortExpression="water_capcity_degree" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="water_pipe_net_good_degree" HeaderText="water_pipe_net_good_degree" SortExpression="water_pipe_net_good_degree" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="one_hou_one_water_meter_rate" HeaderText="one_hou_one_water_meter_rate" SortExpression="one_hou_one_water_meter_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="water_supply_validate" HeaderText="water_supply_validate" SortExpression="water_supply_validate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="elec_capcity_degree" HeaderText="elec_capcity_degree" SortExpression="elec_capcity_degree" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="elec_wire_safe_degree" HeaderText="elec_wire_safe_degree" SortExpression="elec_wire_safe_degree" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="one_hou_one_elec_meter_rate" HeaderText="one_hou_one_elec_meter_rate" SortExpression="one_hou_one_elec_meter_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="elec_supply_validate" HeaderText="elec_supply_validate" SortExpression="elec_supply_validate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="road_light_suff_degree" HeaderText="road_light_suff_degree" SortExpression="road_light_suff_degree" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="passway_light_suff_degree" HeaderText="passway_light_suff_degree" SortExpression="passway_light_suff_degree" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="light_validate" HeaderText="light_validate" SortExpression="light_validate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="outdoors_ff_good_rate" HeaderText="outdoors_ff_good_rate" SortExpression="outdoors_ff_good_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indoors_ff_good_rate" HeaderText="indoors_ff_good_rate" SortExpression="indoors_ff_good_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ff_way_good_rate" HeaderText="ff_way_good_rate" SortExpression="ff_way_good_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ff_validate" HeaderText="ff_validate" SortExpression="ff_validate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="basic_facility_validate" HeaderText="basic_facility_validate" SortExpression="basic_facility_validate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="refuse_collect_rate" HeaderText="refuse_collect_rate" SortExpression="refuse_collect_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="toilet_cover_degree" HeaderText="toilet_cover_degree" SortExpression="toilet_cover_degree" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sanitation_validate" HeaderText="sanitation_validate" SortExpression="sanitation_validate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sewage_collect_rate" HeaderText="sewage_collect_rate" SortExpression="sewage_collect_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="drain_safe_degree" HeaderText="drain_safe_degree" SortExpression="drain_safe_degree" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="drain_validate" HeaderText="drain_validate" SortExpression="drain_validate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="green_validate" HeaderText="green_validate" SortExpression="green_validate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="environment_validate" HeaderText="environment_validate" SortExpression="environment_validate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="service_gfs_good_rate" HeaderText="service_gfs_good_rate" SortExpression="service_gfs_good_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="kindergarten_good_rate" HeaderText="kindergarten_good_rate" SortExpression="kindergarten_good_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="medical_good_rate" HeaderText="medical_good_rate" SortExpression="medical_good_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="parking_good_rate" HeaderText="parking_good_rate" SortExpression="parking_good_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CVS_good_rate" HeaderText="CVS_good_rate" SortExpression="CVS_good_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="vegetable_market_good_rate" HeaderText="vegetable_market_good_rate" SortExpression="vegetable_market_good_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="commerce_validate" HeaderText="commerce_validate" SortExpression="commerce_validate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cul_fitness_facility_good_rate" HeaderText="cul_fitness_facility_good_rate" SortExpression="cul_fitness_facility_good_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="older_facility_good_rate" HeaderText="older_facility_good_rate" SortExpression="older_facility_good_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="public_service_good_rate" HeaderText="public_service_good_rate" SortExpression="public_service_good_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="shop_front_use_rate" HeaderText="shop_front_use_rate" SortExpression="shop_front_use_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="shop_front_rent_level" HeaderText="shop_front_rent_level" SortExpression="shop_front_rent_level" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="shop_validate" HeaderText="shop_validate" SortExpression="shop_validate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_validate" HeaderText="community_validate" SortExpression="community_validate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator1" HeaderText="indicator1" SortExpression="indicator1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator2" HeaderText="indicator2" SortExpression="indicator2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator3" HeaderText="indicator3" SortExpression="indicator3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator4" HeaderText="indicator4" SortExpression="indicator4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator5" HeaderText="indicator5" SortExpression="indicator5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator6" HeaderText="indicator6" SortExpression="indicator6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator7" HeaderText="indicator7" SortExpression="indicator7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator8" HeaderText="indicator8" SortExpression="indicator8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator9" HeaderText="indicator9" SortExpression="indicator9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator10" HeaderText="indicator10" SortExpression="indicator10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator11" HeaderText="indicator11" SortExpression="indicator11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator12" HeaderText="indicator12" SortExpression="indicator12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator13" HeaderText="indicator13" SortExpression="indicator13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator14" HeaderText="indicator14" SortExpression="indicator14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator15" HeaderText="indicator15" SortExpression="indicator15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator16" HeaderText="indicator16" SortExpression="indicator16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator17" HeaderText="indicator17" SortExpression="indicator17" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator18" HeaderText="indicator18" SortExpression="indicator18" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator19" HeaderText="indicator19" SortExpression="indicator19" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator20" HeaderText="indicator20" SortExpression="indicator20" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator21" HeaderText="indicator21" SortExpression="indicator21" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator22" HeaderText="indicator22" SortExpression="indicator22" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator23" HeaderText="indicator23" SortExpression="indicator23" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator24" HeaderText="indicator24" SortExpression="indicator24" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator25" HeaderText="indicator25" SortExpression="indicator25" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator26" HeaderText="indicator26" SortExpression="indicator26" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator27" HeaderText="indicator27" SortExpression="indicator27" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator28" HeaderText="indicator28" SortExpression="indicator28" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator29" HeaderText="indicator29" SortExpression="indicator29" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator30" HeaderText="indicator30" SortExpression="indicator30" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator31" HeaderText="indicator31" SortExpression="indicator31" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator32" HeaderText="indicator32" SortExpression="indicator32" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator33" HeaderText="indicator33" SortExpression="indicator33" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator34" HeaderText="indicator34" SortExpression="indicator34" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator35" HeaderText="indicator35" SortExpression="indicator35" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator36" HeaderText="indicator36" SortExpression="indicator36" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator37" HeaderText="indicator37" SortExpression="indicator37" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator38" HeaderText="indicator38" SortExpression="indicator38" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator39" HeaderText="indicator39" SortExpression="indicator39" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator40" HeaderText="indicator40" SortExpression="indicator40" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator41" HeaderText="indicator41" SortExpression="indicator41" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator42" HeaderText="indicator42" SortExpression="indicator42" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator43" HeaderText="indicator43" SortExpression="indicator43" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator44" HeaderText="indicator44" SortExpression="indicator44" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator45" HeaderText="indicator45" SortExpression="indicator45" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="indicator46" HeaderText="indicator46" SortExpression="indicator46" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="labor_employment_rate" HeaderText="labor_employment_rate" SortExpression="labor_employment_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="disposable_money_per_people" HeaderText="disposable_money_per_people" SortExpression="disposable_money_per_people" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
