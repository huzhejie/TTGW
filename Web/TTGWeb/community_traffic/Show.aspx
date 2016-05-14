<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_traffic.Show" Title="显示页" %>
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
		community_passenger_station_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_passenger_station_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_station_waiting_room_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_station_waiting_room_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_station_parking_lot_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_station_parking_lot_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_bus_trips
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_bus_trips" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_quay_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_quay_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_passenger_and_goods_quay_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_passenger_and_goods_quay_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_goods_quay_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_goods_quay_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_passenger_quay_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_passenger_quay_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_docking_point
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_docking_point" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_passenger_quay_waiting_room_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_passenger_quay_waiting_room_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_passenger_quay_parking_lot_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_passenger_quay_parking_lot_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_passenger_quay_ship_trips
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_passenger_quay_ship_trips" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_passenger_quay_dis_to_county
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_passenger_quay_dis_to_county" runat="server"></asp:Label>
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
		tctunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltctunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltctunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltctunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltctunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltctunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltctunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltctunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltctunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltctunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltctunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltctunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltctunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltctunset13" runat="server"></asp:Label>
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




