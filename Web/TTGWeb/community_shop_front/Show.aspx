<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_shop_front.Show" Title="显示页" %>
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
		community_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_shop_front_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_shop_front_in_main_street_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_shop_front_in_main_street_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_shop_front_in_collector_street_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_shop_front_in_collector_street_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_shop_front_in_alley_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_shop_front_in_alley_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_back_street_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_back_street_shop_front_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_shop_front_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_shop_front_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_immigrant_shop_front_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_shop_front_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_immigrant_shop_front_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_run_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_immigrant_run_shop_front_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_run_shop_front_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_immigrant_run_shop_front_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_rent_out_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_immigrant_rent_out_shop_front_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_rent_out_shop_front_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_immigrant_rent_out_shop_front_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_unused_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_immigrant_unused_shop_front_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_unused_shop_front_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_immigrant_unused_shop_front_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_shop_front_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_shop_front_amount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_catering_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_catering_shop_front_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_accommodation_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_accommodation_shop_front_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_commodity_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_commodity_shop_front_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_means_of_production_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_means_of_production_shop_front_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_automobile_service_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_automobile_service_shop_front_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_other__shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_other__shop_front_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_average_rent_of_shop_front
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_average_rent_of_shop_front" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_average_rent_time_of_shop_front
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_average_rent_time_of_shop_front" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_average_price_shop_front
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_average_price_shop_front" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		statistics_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstatistics_date" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




