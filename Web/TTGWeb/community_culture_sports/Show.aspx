<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_culture_sports.Show" Title="显示页" %>
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
		community_culture_sports_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_culture_sports_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_culture_sports_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_culture_sports_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_otd_cul_spo_fac_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_otd_cul_spo_fac_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_otd_cul_spo_fac_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_otd_cul_spo_fac_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_squ_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_cul_squ_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_squ_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_cul_squ_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_otd_entm_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_otd_entm_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_otd_entm_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_otd_entm_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_child_plg_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_child_plg_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_child_plg_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_child_plg_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ind_actv_spa_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_ind_actv_spa_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ind_actv_spa_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_ind_actv_spa_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ind_actv_spa_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_ind_actv_spa_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_sta_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_cul_sta_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_sta_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_cul_sta_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_sta_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_cul_sta_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_room_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_cul_room_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_room_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_cul_room_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_room_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_cul_room_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_fit_fac_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_fit_fac_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_fit_fac_intact_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_fit_fac_intact_rate" runat="server"></asp:Label>
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
		tccsunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset17" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset18" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset19" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset20" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltccsunset21" runat="server"></asp:Label>
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




