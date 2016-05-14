<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.Community_Base.Show" Title="显示页" %>
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
		community_name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_location
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_location" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_county
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_county" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_feature
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_feature" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_function_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_function_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_function_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_function_type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_county
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldistance_to_county" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_street_committees
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldistance_to_street_committees" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_main_business_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldistance_to_main_business_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_main_education_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldistance_to_main_education_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_railway_station
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldistance_to_railway_station" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_coach_station
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldistance_to_coach_station" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_passenger_quay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldistance_to_passenger_quay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_main_street
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldistance_to_main_street" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_collector_street
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldistance_to_collector_street" runat="server"></asp:Label>
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
		tbcunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltbcunset17" runat="server"></asp:Label>
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
	<tr>
	<td height="25" width="30%" align="right">
		community_wcommunity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_wcommunity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_category
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_category" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_construct_year
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_construct_year" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_province
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_province" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




