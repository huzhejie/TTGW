<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_medical.Show" Title="显示页" %>
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
		community_medical_inst_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_medical_inst_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_medical_inst_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_medical_inst_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_medical_inst_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_medical_inst_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hospital_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_hospital_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hospital_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_hospital_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hospital_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_hospital_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hospital_bed_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_hospital_bed_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hospital_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_hospital_dis_ots" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_heal_sta_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_heal_sta_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_heal_sta_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_heal_sta_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_heal_sta_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_heal_sta_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_heal_sta_bed_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_heal_sta_bed_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_heal_sta_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_heal_sta_dis_ots" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_clinic_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_clinic_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_clinic_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_clinic_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_clinic_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_clinic_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_clinic_bed_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_clinic_bed_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_clinic_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_clinic_dis_ots" runat="server"></asp:Label>
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
		tcmunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset17" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcmunset18" runat="server"></asp:Label>
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




