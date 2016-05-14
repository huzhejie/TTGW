<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="TTG.Web.TTGWeb.community_education.Add" Title="增加页" %>

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
		community_edu_inst_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_edu_inst_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_edu_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_edu_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_edu_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_edu_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_kdg_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pri_kdg_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_pri_kdg_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_kdg_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_kdg_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_stu_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_kdg_stu_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_class_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_kdg_class_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_actv_room_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_kdg_actv_room_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_otd_actv_spa_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_kdg_otd_actv_spa_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_greenland_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_kdg_greenland_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_kdg_dist_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_kdg_dist_ots" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_prim_school_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_prim_school_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_prim_school_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_stu_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_prim_school_stu_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_class_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_prim_school_class_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_plg_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_prim_school_plg_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_dist_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_prim_school_dist_ots" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_mid_school_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_mid_school_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_mid_school_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_mid_school_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_mid_school_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_mid_school_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_mid_school_stu_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_mid_school_stu_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_mid_school_class_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_mid_school_class_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_mid_school_plg_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_mid_school_plg_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_mid_school_dist_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_mid_school_dist_ots" runat="server" Width="200px"></asp:TextBox>
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
		tceunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset15" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset16" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset17" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset18" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset19" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset20" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset21" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset22
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset22" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset23
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset23" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset24
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset24" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset25
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset25" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset26
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset26" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tceunset27
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttceunset27" runat="server" Width="200px"></asp:TextBox>
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
