<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_security.Show" Title="显示页" %>
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
		community_unit_can_build_guard_room_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_unit_can_build_guard_room_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_unit_with_guard_room_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_unit_with_guard_room_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_unit_can_install_mf_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_unit_can_install_mf_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_unit_with_mf_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_unit_with_mf_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_unit_can_build_fence_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_unit_can_build_fence_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_unit_with_fence_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_unit_with_fence_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_emergency_shelter_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_emergency_shelter_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_civil_air_defence_facilities_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_civil_air_defence_facilities_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_civil_air_defence_facilities_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_civil_air_defence_facilities_area" runat="server"></asp:Label>
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
		community_unit_can_build_gate_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_unit_can_build_gate_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_with_gate_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_with_gate_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsunset11" runat="server"></asp:Label>
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




