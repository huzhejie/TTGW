<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.community_commerce.Modify" Title="修改页" %>
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
		community_come_fac_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_come_fac_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_come_fac_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_come_fac_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_come_fac_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_come_fac_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_come_enp_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_come_enp_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_come_enp_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_come_enp_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_come_enp_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_come_enp_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_emporium_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_emporium_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_small_supermarket_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_small_supermarket_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_CVS_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_CVS_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_restauran_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_restauran_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_household_appliances_store_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_household_appliances_store_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_agricultural_production_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_agricultural_production_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_clothes_store_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_clothes_store_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hardware_building_materials_store_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_hardware_building_materials_store_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_drugstore_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_drugstore_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_bookstore_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_bookstore_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_other_come_enp_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_other_come_enp_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_produce_fair_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_farm_produce_fair_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_produce_fair_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_farm_produce_fair_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_produce_fair_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_farm_produce_fair_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_produce_fair_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_farm_produce_fair_dis_ots" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pedlar_market_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_pedlar_market_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pedlar_market_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_pedlar_market_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pedlar_market_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_pedlar_market_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pedlar_market_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_pedlar_market_dis_ots" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_whs_market_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_farm_whs_market_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_whs_market_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_farm_whs_market_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_whs_market_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_farm_whs_market_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farm_whs_market_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_farm_whs_market_dis_ots" runat="server" Width="200px"></asp:TextBox>
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
		tccunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset15" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset16" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset17" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset18" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset19" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset20" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset21" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset22
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset22" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset23
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset23" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset24
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset24" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset25
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset25" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset26
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset26" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset27
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset27" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset28
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset28" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccunset29
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccunset29" runat="server" Width="200px"></asp:TextBox>
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
		check_status
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcheck_status" runat="server" Width="200px"></asp:TextBox>
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

