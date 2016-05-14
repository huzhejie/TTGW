<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.community_service.Modify" Title="修改页" %>
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
		community_comm_serv_fac_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_comm_serv_fac_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_comm_serv_fac_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_comm_serv_fac_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_comm_serv_cen_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_comm_serv_cen_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_comm_serv_cen_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_comm_serv_cen_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_comm_serv_cen_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_comm_serv_cen_dis_ots" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_empm_supt_cen_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_empm_supt_cen_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_empm_supt_cen_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_empm_supt_cen_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_empm_supt_cen_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_empm_supt_cen_dis_ots" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_police_sta_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_police_sta_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_police_sta_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_police_sta_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_police_sta_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_police_sta_dis_ots" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prop_magm_unit_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_prop_magm_unit_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_no_prop_magm_unit_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_no_prop_magm_unit_num" runat="server" Width="200px"></asp:TextBox>
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
		tcsrunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsrunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsrunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsrunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsrunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsrunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsrunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsrunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsrunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsrunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsrunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsrunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsrunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsrunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsrunset13" runat="server" Width="200px"></asp:TextBox>
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

