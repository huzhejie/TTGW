<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.wcommunity.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		wcommunity_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblwcommunity_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		wcommunity_name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblwcommunity_name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		kindergarten_capacity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblkindergarten_capacity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		integrated_management_building_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblintegrated_management_building_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		medical_bed_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmedical_bed_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		parking_space_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblparking_space_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		convenience_stores_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblconvenience_stores_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		vegetable_market_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblvegetable_market_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		culture_fitness_facility_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblculture_fitness_facility_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		facilities_for_elders_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfacilities_for_elders_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltwunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltwunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltwunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltwunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltwunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltwunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltwunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltwunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltwunset9" runat="server"></asp:Label>
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
		statistics_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstatistics_date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		wcommunity_family_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblwcommunity_family_num" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




