﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="TTG.Web.TTGWeb.community_bet_dwellings_road_problem_finished.Add" Title="增加页" %>

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
		community_road_bet_dwellings_maintain_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_bet_dwellings_maintain_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_bet_dwellings_harden_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_bet_dwellings_harden_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_added_stairways_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_added_stairways_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_added_stairways_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_added_stairways_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pavement_maintain_len
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_pavement_maintain_len" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pavement_parapet_matain_len
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_pavement_parapet_matain_len" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_added_pavement_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_added_pavement_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_added_pavement_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_added_pavement_area" runat="server" Width="200px"></asp:TextBox>
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
		check_status
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcheck_status" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset10" runat="server" Width="200px"></asp:TextBox>
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
		community_added_pavement_num_f_update
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_added_pavement_num_f_update" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_added_pavement_area_f_update
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_added_pavement_area_f_update" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_added_stairways_num_f_update
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_added_stairways_num_f_update" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_added_stairways_area_f_update
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_added_stairways_area_f_update" runat="server" Width="200px"></asp:TextBox>
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
