<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_education.Show" Title="显示页" %>
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
		community_edu_inst_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_edu_inst_num" runat="server"></asp:Label>
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
		community_edu_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_edu_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_kdg_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pri_kdg_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_pri_kdg_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_kdg_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_kdg_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_stu_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_kdg_stu_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_class_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_kdg_class_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_actv_room_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_kdg_actv_room_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_otd_actv_spa_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_kdg_otd_actv_spa_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_greenland_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_kdg_greenland_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_dist_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_kdg_dist_ots" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_prim_school_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_prim_school_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_prim_school_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_stu_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_prim_school_stu_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_class_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_prim_school_class_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_plg_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_prim_school_plg_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_dist_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_prim_school_dist_ots" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_mid_school_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_mid_school_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_mid_school_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_mid_school_gfa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_mid_school_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_mid_school_fs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_mid_school_stu_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_mid_school_stu_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_mid_school_class_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_mid_school_class_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_mid_school_plg_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_mid_school_plg_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_mid_school_dist_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_mid_school_dist_ots" runat="server"></asp:Label>
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
		tceunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset17" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset18" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset19" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset20" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset21" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset22
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset22" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset23
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset23" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset24
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset24" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset25
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset25" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset26
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset26" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset27
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltceunset27" runat="server"></asp:Label>
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




