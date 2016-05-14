<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_water_drain.Show" Title="显示页" %>
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
		community_water_drain_mechanism
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_water_drain_mechanism" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_domestic_sewage_consumption
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_domestic_sewage_consumption" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_drain_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_water_drain_pipe_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_drain_main_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_water_drain_main_pipe_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_drain_pipe_branch_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_water_drain_pipe_branch_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_drain_service_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_water_drain_service_pipe_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_drain_canal_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_water_drain_canal_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_open_drain_canal_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_water_open_drain_canal_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_septic_tank_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_septic_tank_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_septic_tank_capacity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_septic_tank_capacity" runat="server"></asp:Label>
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
		tcwdunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwdunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwdunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwdunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwdunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwdunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwdunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwdunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwdunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwdunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcwdunset10" runat="server"></asp:Label>
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




