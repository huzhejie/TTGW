<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.community_parking_lot.Modify" Title="修改页" %>
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
		community_parking_space_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_parking_space_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_parking_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_parking_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_parking_space_use_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_parking_space_use_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_parking_lot_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_public_parking_lot_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_grand_parking_lot_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_public_grand_parking_lot_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_underg_parking_lot_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_public_underg_parking_lot_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_overg_parking_lot_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_public_overg_parking_lot_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_parking_lot_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_public_parking_lot_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_parking_space_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_public_parking_space_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_parking_lot_area_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_public_parking_lot_area_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		dis_150m_public_parking_lot_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdis_150m_public_parking_lot_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		dis_150m_public_parking_lot_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdis_150m_public_parking_lot_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		dis_150m_public_parking_space_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdis_150m_public_parking_space_num" runat="server" Width="200px"></asp:TextBox>
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
		tcplunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcplunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcplunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcplunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcplunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcplunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcplunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcplunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcplunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcplunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcplunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcplunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcplunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcplunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcplunset13" runat="server" Width="200px"></asp:TextBox>
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

