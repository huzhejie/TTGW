<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="TTG.Web.TTGWeb.community_management_responsible.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		community_address
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_address" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_manage_charge_person_name
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_manage_charge_person_name" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_manage_charge_person_telphone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_manage_charge_person_telphone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_monitor_charge_person_name
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_monitor_charge_person_name" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_monitor_charge_person_telphone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_monitor_charge_person_telphone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_contacts_telephone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_contacts_telephone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_staff_telephone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_staff_telephone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmrunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmrunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmrunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmrunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmrunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmrunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmrunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmrunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmrunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmrunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmrunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmrunset6" runat="server" Width="200px"></asp:TextBox>
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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
