<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.road.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblname" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_class
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblroad_class" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		width
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblwidth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pavement_width
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpavement_width" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		structure
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstructure" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_dead_end_road
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblis_dead_end_road" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		damage_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldamage_road_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		large_slope_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllarge_slope_road_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_hard_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblno_hard_road_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lack_width_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllack_width_road_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_somewhere_no_link
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblis_somewhere_no_link" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_afforest_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblno_afforest_road_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		less_afforest_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblless_afforest_road_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		street_light_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstreet_light_amount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		good_street_light_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblgood_street_light_amount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_hydrant_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblroad_hydrant_amount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		good_road_hydrant_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblgood_road_hydrant_amount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_dustbin_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblroad_dustbin_amount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		good_road_dustbin_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblgood_road_dustbin_amount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_parking_space_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblroad_parking_space_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		parking_space_use_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblparking_space_use_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		note_information
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnote_information" runat="server"></asp:Label>
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
		lock_tables
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllock_tables" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset17" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset18" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset19" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset20" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset21" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset22
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset22" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset23
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset23" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset24
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrunset24" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




