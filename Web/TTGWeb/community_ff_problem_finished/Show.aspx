﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_ff_problem_finished.Show" Title="显示页" %>
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
		community_added_otd_ff_facility_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_added_otd_ff_facility_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_added_ind_hydrant_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_added_ind_hydrant_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_added_extinguisher_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_added_extinguisher_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_maintain_repl_ff_pipe_len
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_maintain_repl_ff_pipe_len" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ff_aisle_reform_len
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_ff_aisle_reform_len" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ff_aisle_reform_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_ff_aisle_reform_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ff_aisle_remove_len
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_ff_aisle_remove_len" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_rep_repl_otd_ff_facil_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_rep_repl_otd_ff_facil_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_fire_brigade_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_fire_brigade_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_fire_brigade_level
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_fire_brigade_level" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_added_ff_aisle_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_added_ff_aisle_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_added_ff_aisle_len
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_added_ff_aisle_len" runat="server"></asp:Label>
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



