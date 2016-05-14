<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_parking_lot.Show" Title="显示页" %>
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
		community_parking_space_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_parking_space_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_parking_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_parking_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_parking_space_use_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_parking_space_use_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_parking_lot_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_public_parking_lot_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_grand_parking_lot_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_public_grand_parking_lot_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_underg_parking_lot_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_public_underg_parking_lot_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_overg_parking_lot_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_public_overg_parking_lot_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_parking_lot_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_public_parking_lot_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_parking_space_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_public_parking_space_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_parking_lot_area_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_public_parking_lot_area_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		dis_150m_public_parking_lot_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldis_150m_public_parking_lot_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		dis_150m_public_parking_lot_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldis_150m_public_parking_lot_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		dis_150m_public_parking_space_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldis_150m_public_parking_space_num" runat="server"></asp:Label>
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
		tcplunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcplunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcplunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcplunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcplunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcplunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcplunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcplunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcplunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcplunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcplunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcplunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcplunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcplunset13" runat="server"></asp:Label>
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




