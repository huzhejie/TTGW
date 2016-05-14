<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="TTG.Web.TTGWeb.community_water_drain.Add" Title="增加页" %>

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
		community_water_drain_mechanism
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_water_drain_mechanism" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_domestic_sewage_consumption
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_domestic_sewage_consumption" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_drain_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_water_drain_pipe_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_drain_main_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_water_drain_main_pipe_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_drain_pipe_branch_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_water_drain_pipe_branch_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_drain_service_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_water_drain_service_pipe_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_drain_canal_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_water_drain_canal_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_water_open_drain_canal_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_water_open_drain_canal_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_septic_tank_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_septic_tank_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_septic_tank_capacity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_septic_tank_capacity" runat="server" Width="200px"></asp:TextBox>
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
		tcwdunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcwdunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcwdunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcwdunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcwdunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcwdunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcwdunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcwdunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcwdunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcwdunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcwdunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcwdunset10" runat="server" Width="200px"></asp:TextBox>
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
