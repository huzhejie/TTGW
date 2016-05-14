<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_immigrant.Show" Title="显示页" %>
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
		immigrant_total_family_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblimmigrant_total_family_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		immigrant_total_population
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblimmigrant_total_population" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pure_resident_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_pure_resident_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_depart_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_depart_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_enp_staves
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_enp_staves" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_enp_laidoff_staves
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_enp_laidoff_staves" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_have_land_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_have_land_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_rural_to_town_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_rural_to_town_pop" runat="server"></asp:Label>
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
		tcimunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcimunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcimunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcimunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcimunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcimunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcimunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcimunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcimunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcimunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcimunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcimunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcimunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcimunset7" runat="server"></asp:Label>
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




