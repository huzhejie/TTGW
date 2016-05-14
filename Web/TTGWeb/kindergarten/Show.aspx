<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.kindergarten.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
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
		type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltype" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		floor_space
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfloor_space" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gross_floor_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblgross_floor_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		students_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstudents_amount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		teachers_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblteachers_amount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		class_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblclass_amount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		teachers_students_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblteachers_students_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		activity_room_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblactivity_room_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		activity_room_area_if_suff
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblactivity_room_area_if_suff" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		otds_activity_room_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblotds_activity_room_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		otds_activity_room_area_if_suff
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblotds_activity_room_area_if_suff" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		afforest_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblafforest_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		afforest_area_if_suff
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblafforest_area_if_suff" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		school_bus_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblschool_bus_amount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pick_up_students_amount_daily
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpick_up_students_amount_daily" runat="server"></asp:Label>
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
	<tr>
	<td height="25" width="30%" align="right">
		tkunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltkunset17" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




