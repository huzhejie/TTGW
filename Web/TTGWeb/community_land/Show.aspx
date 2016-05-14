<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_land.Show" Title="显示页" %>
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
		community_total_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_total_land_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_house_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_house_land_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_building_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_public_building_land_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_road_land_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_greenland_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_public_greenland_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_industry_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_industry_land_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_warehousing_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_warehousing_land_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_traffic_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_traffic_land_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_municipal_administration_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_municipal_administration_land_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_other_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_other_land_area" runat="server"></asp:Label>
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
		tclunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclunset10" runat="server"></asp:Label>
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




