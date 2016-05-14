<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_light.Show" Title="显示页" %>
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
		community_streetlight_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_streetlight_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_energy_efficient_streetlight_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_energy_efficient_streetlight_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_good_streetlight_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_good_streetlight_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_otd_exercise_yard_light_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_otd_exercise_yard_light_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_otd_good_exercise_yard_light_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_otd_good_exercise_yard_light_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_passageway_light_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_passageway_light_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_good_passageway_light_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_good_passageway_light_rate" runat="server"></asp:Label>
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
		tcltunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcltunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcltunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcltunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcltunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcltunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcltunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcltunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcltunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcltunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcltunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcltunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcltunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcltunset7" runat="server"></asp:Label>
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




