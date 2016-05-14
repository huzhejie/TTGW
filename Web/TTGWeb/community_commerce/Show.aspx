<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_commerce.Show" Title="显示页" %>
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
		community_come_fac_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_come_fac_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_come_fac_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_come_fac_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_come_fac_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_come_fac_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_come_enp_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_come_enp_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_come_enp_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_come_enp_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_come_enp_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_come_enp_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_emporium_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_emporium_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_small_supermarket_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_small_supermarket_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_CVS_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_CVS_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_restauran_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_restauran_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_household_appliances_store_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_household_appliances_store_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_agricultural_production_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_agricultural_production_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_clothes_store_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_clothes_store_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hardware_building_materials_store_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_hardware_building_materials_store_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_drugstore_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_drugstore_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_bookstore_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_bookstore_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_other_come_enp_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_other_come_enp_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_produce_fair_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_farm_produce_fair_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_produce_fair_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_farm_produce_fair_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_produce_fair_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_farm_produce_fair_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_produce_fair_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_farm_produce_fair_dis_ots" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pedlar_market_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_pedlar_market_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pedlar_market_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_pedlar_market_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pedlar_market_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_pedlar_market_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pedlar_market_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_pedlar_market_dis_ots" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_whs_market_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_farm_whs_market_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_whs_market_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_farm_whs_market_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_whs_market_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_farm_whs_market_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_whs_market_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_farm_whs_market_dis_ots" runat="server"></asp:Label>
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
		tccunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset17" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset18" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset19" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset20" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset21" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset22
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset22" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset23
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset23" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset24
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset24" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset25
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset25" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset26
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset26" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset27
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset27" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset28
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset28" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset29
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccunset29" runat="server"></asp:Label>
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
		check_status
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcheck_status" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




