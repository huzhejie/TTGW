<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.community_security.Modify" Title="修改页" %>
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
		community_unit_can_build_guard_room_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_unit_can_build_guard_room_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_unit_with_guard_room_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_unit_with_guard_room_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_unit_can_install_mf_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_unit_can_install_mf_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_unit_with_mf_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_unit_with_mf_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_unit_can_build_fence_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_unit_can_build_fence_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_unit_with_fence_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_unit_with_fence_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_emergency_shelter_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_emergency_shelter_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_civil_air_defence_facilities_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_civil_air_defence_facilities_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_civil_air_defence_facilities_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_civil_air_defence_facilities_area" runat="server" Width="200px"></asp:TextBox>
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
		community_unit_can_build_gate_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_unit_can_build_gate_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_with_gate_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_with_gate_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsunset11" runat="server" Width="200px"></asp:TextBox>
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

