﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.community_water_drain_problem.Modify" Title="修改页" %>
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
		community_fill_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblcommunity_fill_type" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pipe_no_reasonable_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_pipe_no_reasonable_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_form_warea_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_form_warea_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_form_warea_affect_res_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_form_warea_affect_res_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_not_access_uspn_res_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_not_access_uspn_res_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_not_access_uspn_house_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_not_access_uspn_house_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_insuf_pipe_size_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_insuf_pipe_size_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pipe_aging_corrosion_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_pipe_aging_corrosion_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pipe_damage_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_pipe_damage_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_septic_small_volume_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_septic_small_volume_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_septic_damage_leaking_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_septic_damage_leaking_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_sewage_straight_to_cj_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_sewage_straight_to_cj_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_gutter_damage
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_gutter_damage" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_insuf_gutter
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_insuf_gutter" runat="server" Width="200px"></asp:TextBox>
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
		tciunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset15" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttciunset16" runat="server" Width="200px"></asp:TextBox>
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
		community_pipe_damage_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_pipe_damage_length" runat="server" Width="200px"></asp:TextBox>
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

