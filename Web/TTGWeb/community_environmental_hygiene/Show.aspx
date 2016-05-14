<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_environmental_hygiene.Show" Title="显示页" %>
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
		community_refuse_transfer_station_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_refuse_transfer_station_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_refuse_transfer_station_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_refuse_transfer_station_dis_ots" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_refuse_collection_point_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_refuse_collection_point_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_dustbin_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_dustbin_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		rubbish_produce_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblrubbish_produce_amount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		live_rubbish_produce_year_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllive_rubbish_produce_year_amount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		solid_rubbish_produce_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsolid_rubbish_produce_amount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		environmental_fee_charge_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblenvironmental_fee_charge_amount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_toilet_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_public_toilet_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_toilet_space_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_public_toilet_space_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_toilet_inside_300m_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_public_toilet_inside_300m_num" runat="server"></asp:Label>
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
		community_public_toilet_cover_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_public_toilet_cover_road_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcehunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcehunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcehunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcehunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcehunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcehunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcehunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcehunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcehunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcehunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcehunset11" runat="server"></asp:Label>
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
		community_public_toilet_area_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_public_toilet_area_num" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




