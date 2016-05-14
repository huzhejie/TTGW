<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_water_supply.Show" Title="显示页" %>
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
		community_water_supply_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_water_supply_pipe_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_supply_main_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_water_supply_main_pipe_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_supply_pipe_branch_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_water_supply_pipe_branch_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_supply_service_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_water_supply_service_pipe_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_supply_consumption
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_water_supply_consumption" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_per_capita_water_supply_consumption
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_per_capita_water_supply_consumption" runat="server"></asp:Label>
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
		tcwsunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwsunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwsunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwsunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwsunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwsunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwsunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwsunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwsunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwsunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwsunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwsunset6" runat="server"></asp:Label>
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




