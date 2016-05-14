<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_road.Show" Title="显示页" %>
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
		community_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_14_and_24_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_width_bet_14_and_24_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_14_and_24_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_width_bet_14_and_24_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_10_and_14_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_width_bet_10_and_14_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_10_and_14_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_width_bet_10_and_14_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_6_and_9_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_width_bet_6_and_9_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_6_and_9_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_width_bet_6_and_9_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_3_and_5_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_width_bet_3_and_5_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_3_and_5_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_width_bet_3_and_5_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_pavement_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_pavement_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_pavement_colorful_brick_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_pavement_colorful_brick_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_bet_dwellings_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_bet_dwellings_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pavement_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_pavement_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pavement_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_pavement_area" runat="server"></asp:Label>
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
		community_road_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcrunset17" runat="server"></asp:Label>
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




