<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_building.Show" Title="显示页" %>
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
		community_building_total_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_building_total_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_building_total_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_building_total_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_building_total_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_building_total_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_house_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_house_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_house_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_house_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_house_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_house_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_edu_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_edu_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_edu_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_edu_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_edu_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_edu_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_medical_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_medical_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_medical_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_medical_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_medical_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_medical_num" runat="server"></asp:Label>
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
		community_culture_sports_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_culture_sports_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_culture_sports_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_culture_sports_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_service_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_service_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_service_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_service_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_service_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_service_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_other_building_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_other_building_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_other_building_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_other_building_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_other_building_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_other_building_num" runat="server"></asp:Label>
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
		tcbunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset17" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset18" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset19" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset20" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcbunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcbunset21" runat="server"></asp:Label>
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
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




