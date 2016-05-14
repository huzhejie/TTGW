<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.labor_force.Show" Title="显示页" %>
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
		<asp:Label id="lblid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		county
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcounty" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lf_have_a_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllf_have_a_job_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lf_have_a_steady_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllf_have_a_steady_job_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		empm_information_platform_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblempm_information_platform_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		empm_information_platform_information_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblempm_information_platform_information_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		public_spirited_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpublic_spirited_job_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		clean_keeping_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblclean_keeping_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		security_guard_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsecurity_guard_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		farm_produce_fair_administrator_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfarm_produce_fair_administrator_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		other_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblother_job_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		enp_supportive_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblenp_supportive_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		small_manual_processing_enp_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsmall_manual_processing_enp_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		food_enp_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfood_enp_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sewing_embroidery_enp_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsewing_embroidery_enp_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		other_enp_supportive_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblother_enp_supportive_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		note_information
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnote_information" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		statistics_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstatistics_date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tlfunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltlfunset17" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		check_status
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcheck_status" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lock_tables
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllock_tables" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




