﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_road_problem.Show" Title="显示页" %>
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
		community_road_not_hardening_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_not_hardening_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_large_slope_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_large_slope_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_insuf_width_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_insuf_width_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_pavement_damage_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_pavement_damage_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_sidewalk_cb_damage_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_sidewalk_cb_damage_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_broken_road_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_broken_road_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_sarea_lack_lroad
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_sarea_lack_lroad" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_to_city_pasway_pavement_damage
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_to_city_pasway_pavement_damage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_to_city_pasway_pavement_insuf_width
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_to_city_pasway_pavement_insuf_width" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lack_motorway
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lack_motorway" runat="server"></asp:Label>
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




