<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_service.Show" Title="显示页" %>
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
		community_comm_serv_fac_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_comm_serv_fac_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_comm_serv_fac_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_comm_serv_fac_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_comm_serv_cen_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_comm_serv_cen_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_comm_serv_cen_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_comm_serv_cen_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_comm_serv_cen_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_comm_serv_cen_dis_ots" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_empm_supt_cen_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_empm_supt_cen_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_empm_supt_cen_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_empm_supt_cen_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_empm_supt_cen_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_empm_supt_cen_dis_ots" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_police_sta_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_police_sta_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_police_sta_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_police_sta_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_police_sta_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_police_sta_dis_ots" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prop_magm_unit_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_prop_magm_unit_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_no_prop_magm_unit_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_no_prop_magm_unit_num" runat="server"></asp:Label>
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
		tcsrunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsrunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsrunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsrunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsrunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsrunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsrunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsrunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsrunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsrunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsrunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsrunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsrunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsrunset13" runat="server"></asp:Label>
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




