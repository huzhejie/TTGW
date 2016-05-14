<%@ Page Title="T_community_commerce" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_commerce.List" %>
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
		<asp:BoundField DataField="community_come_fac_num" HeaderText="community_come_fac_num" SortExpression="community_come_fac_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_come_fac_fs" HeaderText="community_come_fac_fs" SortExpression="community_come_fac_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_come_fac_gfa" HeaderText="community_come_fac_gfa" SortExpression="community_come_fac_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_come_enp_num" HeaderText="community_come_enp_num" SortExpression="community_come_enp_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_come_enp_fs" HeaderText="community_come_enp_fs" SortExpression="community_come_enp_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_come_enp_gfa" HeaderText="community_come_enp_gfa" SortExpression="community_come_enp_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_emporium_num" HeaderText="community_emporium_num" SortExpression="community_emporium_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_small_supermarket_num" HeaderText="community_small_supermarket_num" SortExpression="community_small_supermarket_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_CVS_num" HeaderText="community_CVS_num" SortExpression="community_CVS_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_restauran_num" HeaderText="community_restauran_num" SortExpression="community_restauran_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_household_appliances_store_num" HeaderText="community_household_appliances_store_num" SortExpression="community_household_appliances_store_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_agricultural_production_num" HeaderText="community_agricultural_production_num" SortExpression="community_agricultural_production_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_clothes_store_num" HeaderText="community_clothes_store_num" SortExpression="community_clothes_store_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_hardware_building_materials_store_num" HeaderText="community_hardware_building_materials_store_num" SortExpression="community_hardware_building_materials_store_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_drugstore_num" HeaderText="community_drugstore_num" SortExpression="community_drugstore_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_bookstore_num" HeaderText="community_bookstore_num" SortExpression="community_bookstore_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_other_come_enp_num" HeaderText="community_other_come_enp_num" SortExpression="community_other_come_enp_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_farm_produce_fair_num" HeaderText="community_farm_produce_fair_num" SortExpression="community_farm_produce_fair_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_farm_produce_fair_gfa" HeaderText="community_farm_produce_fair_gfa" SortExpression="community_farm_produce_fair_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_farm_produce_fair_fs" HeaderText="community_farm_produce_fair_fs" SortExpression="community_farm_produce_fair_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_farm_produce_fair_dis_ots" HeaderText="community_farm_produce_fair_dis_ots" SortExpression="community_farm_produce_fair_dis_ots" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_pedlar_market_num" HeaderText="community_pedlar_market_num" SortExpression="community_pedlar_market_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_pedlar_market_gfa" HeaderText="community_pedlar_market_gfa" SortExpression="community_pedlar_market_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_pedlar_market_fs" HeaderText="community_pedlar_market_fs" SortExpression="community_pedlar_market_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_pedlar_market_dis_ots" HeaderText="community_pedlar_market_dis_ots" SortExpression="community_pedlar_market_dis_ots" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_farm_whs_market_num" HeaderText="community_farm_whs_market_num" SortExpression="community_farm_whs_market_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_farm_whs_market_gfa" HeaderText="community_farm_whs_market_gfa" SortExpression="community_farm_whs_market_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_farm_whs_market_fs" HeaderText="community_farm_whs_market_fs" SortExpression="community_farm_whs_market_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_farm_whs_market_dis_ots" HeaderText="community_farm_whs_market_dis_ots" SortExpression="community_farm_whs_market_dis_ots" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset1" HeaderText="tccunset1" SortExpression="tccunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset2" HeaderText="tccunset2" SortExpression="tccunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset3" HeaderText="tccunset3" SortExpression="tccunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset4" HeaderText="tccunset4" SortExpression="tccunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset5" HeaderText="tccunset5" SortExpression="tccunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset6" HeaderText="tccunset6" SortExpression="tccunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset7" HeaderText="tccunset7" SortExpression="tccunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset8" HeaderText="tccunset8" SortExpression="tccunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset9" HeaderText="tccunset9" SortExpression="tccunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset10" HeaderText="tccunset10" SortExpression="tccunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset11" HeaderText="tccunset11" SortExpression="tccunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset12" HeaderText="tccunset12" SortExpression="tccunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset13" HeaderText="tccunset13" SortExpression="tccunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset14" HeaderText="tccunset14" SortExpression="tccunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset15" HeaderText="tccunset15" SortExpression="tccunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset16" HeaderText="tccunset16" SortExpression="tccunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset17" HeaderText="tccunset17" SortExpression="tccunset17" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset18" HeaderText="tccunset18" SortExpression="tccunset18" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset19" HeaderText="tccunset19" SortExpression="tccunset19" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset20" HeaderText="tccunset20" SortExpression="tccunset20" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset21" HeaderText="tccunset21" SortExpression="tccunset21" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset22" HeaderText="tccunset22" SortExpression="tccunset22" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset23" HeaderText="tccunset23" SortExpression="tccunset23" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset24" HeaderText="tccunset24" SortExpression="tccunset24" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset25" HeaderText="tccunset25" SortExpression="tccunset25" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset26" HeaderText="tccunset26" SortExpression="tccunset26" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset27" HeaderText="tccunset27" SortExpression="tccunset27" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset28" HeaderText="tccunset28" SortExpression="tccunset28" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccunset29" HeaderText="tccunset29" SortExpression="tccunset29" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
