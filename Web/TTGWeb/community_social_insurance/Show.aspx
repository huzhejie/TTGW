<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_social_insurance.Show" Title="显示页" %>
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
		community_urban_min_living_sec_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_urban_min_living_sec_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_very_poor_household_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_very_poor_household_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_large_med_resv_immg_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_large_med_resv_immg_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_chongqing_immg_poor_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_chongqing_immg_poor_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_medicare_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_medicare_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_endow_insu_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_endow_insu_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_unemp_insu_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_unemp_insu_pop" runat="server"></asp:Label>
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
		tcsiunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsiunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsiunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsiunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsiunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsiunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsiunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsiunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsiunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsiunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsiunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsiunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsiunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcsiunset7" runat="server"></asp:Label>
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
		poor_people_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpoor_people_rate" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




