﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.community_traffic.Modify" Title="修改页" %>
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
		<asp:label id="lblcommunity_id" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_passenger_station_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_passenger_station_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_station_waiting_room_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_station_waiting_room_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_station_parking_lot_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_station_parking_lot_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_bus_trips
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_bus_trips" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_quay_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_quay_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_passenger_and_goods_quay_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_passenger_and_goods_quay_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_goods_quay_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_goods_quay_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_passenger_quay_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_passenger_quay_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_docking_point
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_docking_point" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_passenger_quay_waiting_room_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_passenger_quay_waiting_room_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_passenger_quay_parking_lot_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_passenger_quay_parking_lot_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_passenger_quay_ship_trips
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_passenger_quay_ship_trips" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_passenger_quay_dis_to_county
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_passenger_quay_dis_to_county" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		statistics_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblstatistics_date" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttctunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttctunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttctunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttctunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttctunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttctunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttctunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttctunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttctunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttctunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttctunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttctunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tctunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttctunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lock_tables
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlock_tables" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		check_status
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcheck_status" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
