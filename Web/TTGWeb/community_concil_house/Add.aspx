﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="TTG.Web.TTGWeb.community_concil_house.Add" Title="增加页" %>

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
		<asp:TextBox id="txtcommunity_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_council_buil_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_council_buil_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_conhou_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_conhou_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_conhou_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_conhou_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_conhou_unit_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_conhou_unit_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_conhou_floor_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_conhou_floor_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_conhou_suite_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_conhou_suite_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_conhou_family_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_conhou_family_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_conhou_people_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_conhou_people_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		statistics_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstatistics_date" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcchunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcchunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcchunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcchunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcchunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcchunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcchunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcchunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcchunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcchunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcchunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcchunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcchunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcchunset8" runat="server" Width="200px"></asp:TextBox>
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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
