﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_water_supply_problem.Show" Title="显示页" %>
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
		community_fill_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_fill_type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_insuf_ws_res_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_insuf_ws_res_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_insuf_ws_house_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_insuf_ws_house_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_insuf_wp_res_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_insuf_wp_res_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_insuf_wp_house_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_insuf_wp_house_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_not_imple_ohot_res_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_not_imple_ohot_res_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_not_imple_ohot_house_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_not_imple_ohot_house_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_insuf_pipe_size_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_insuf_pipe_size_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_insuf_pipe_size_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_insuf_pipe_size_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_damage_leakage_pipe_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_damage_leakage_pipe_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_damage_leakage_pipe_house_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_damage_leakage_pipe_house_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_aging_corrosion_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_aging_corrosion_pipe_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_aging_corrosion_pipe_house_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_aging_corrosion_pipe_house_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_insuf_pn_coverage
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_insuf_pn_coverage" runat="server"></asp:Label>
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
		check_status
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcheck_status" runat="server"></asp:Label>
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
		lock_tables
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllock_tables" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>



