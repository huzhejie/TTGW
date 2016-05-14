<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.community_culture_sports.Modify" Title="修改页" %>
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
		community_culture_sports_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_culture_sports_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_culture_sports_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_culture_sports_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_otd_cul_spo_fac_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_otd_cul_spo_fac_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_otd_cul_spo_fac_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_otd_cul_spo_fac_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_squ_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_cul_squ_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_squ_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_cul_squ_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_otd_entm_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_otd_entm_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_otd_entm_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_otd_entm_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_child_plg_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_child_plg_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_child_plg_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_child_plg_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ind_actv_spa_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_ind_actv_spa_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ind_actv_spa_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_ind_actv_spa_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ind_actv_spa_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_ind_actv_spa_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_sta_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_cul_sta_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_sta_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_cul_sta_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_sta_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_cul_sta_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_room_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_cul_room_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_room_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_cul_room_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_cul_room_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_cul_room_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_fit_fac_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_fit_fac_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_fit_fac_intact_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_fit_fac_intact_rate" runat="server" Width="200px"></asp:TextBox>
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
		tccsunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset15" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset16" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset17" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset18" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset19" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset20" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tccsunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttccsunset21" runat="server" Width="200px"></asp:TextBox>
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

