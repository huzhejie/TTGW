<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="TTG.Web.TTGWeb.labor_force.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtid" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		county
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcounty" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lf_have_a_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlf_have_a_job_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lf_have_a_steady_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlf_have_a_steady_job_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		empm_information_platform_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtempm_information_platform_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		empm_information_platform_information_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtempm_information_platform_information_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		public_spirited_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpublic_spirited_job_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		clean_keeping_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtclean_keeping_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		security_guard_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsecurity_guard_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		farm_produce_fair_administrator_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfarm_produce_fair_administrator_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		other_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtother_job_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		enp_supportive_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtenp_supportive_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		small_manual_processing_enp_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsmall_manual_processing_enp_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		food_enp_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfood_enp_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sewing_embroidery_enp_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsewing_embroidery_enp_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		other_enp_supportive_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtother_enp_supportive_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		note_information
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnote_information" runat="server" Width="200px"></asp:TextBox>
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
		tlfunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset15" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset16" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttlfunset17" runat="server" Width="200px"></asp:TextBox>
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
		lock_tables
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlock_tables" runat="server" Width="200px"></asp:TextBox>
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
