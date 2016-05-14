<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_population.Show" Title="显示页" %>
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
		community_total_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_total_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_reg_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_reg_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_perm_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_perm_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_man_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_man_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_female_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_female_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_younger_6_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_younger_6_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_bet_7_and_15_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_bet_7_and_15_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_bet_16_and_29_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_bet_16_and_29_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_bet_30_and_39_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_bet_30_and_39_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_bet_40_and_49_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_bet_40_and_49_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_older_50_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_older_50_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_illiteracy_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_illiteracy_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_edu_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_prim_school_edu_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_junior_high_school_edu_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_junior_high_school_edu_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_senior_high_school_edu_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_senior_high_school_edu_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_junior_college_edu_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_junior_college_edu_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		average_education_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblaverage_education_time" runat="server"></asp:Label>
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
		tcpunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcpunset17" runat="server"></asp:Label>
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
		community_family_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_family_num" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




