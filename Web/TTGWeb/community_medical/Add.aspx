<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="TTG.Web.TTGWeb.community_medical.Add" Title="增加页" %>

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
		community_medical_inst_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_medical_inst_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_medical_inst_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_medical_inst_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_medical_inst_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_medical_inst_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hospital_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_hospital_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hospital_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_hospital_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hospital_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_hospital_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hospital_bed_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_hospital_bed_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hospital_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_hospital_dis_ots" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_heal_sta_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_heal_sta_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_heal_sta_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_heal_sta_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_heal_sta_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_heal_sta_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_heal_sta_bed_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_heal_sta_bed_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_heal_sta_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_heal_sta_dis_ots" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_clinic_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_clinic_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_clinic_fs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_clinic_fs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_clinic_gfa
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_clinic_gfa" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_clinic_bed_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_clinic_bed_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_clinic_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_clinic_dis_ots" runat="server" Width="200px"></asp:TextBox>
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
		tcmunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset15" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset16" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset17" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcmunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcmunset18" runat="server" Width="200px"></asp:TextBox>
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
