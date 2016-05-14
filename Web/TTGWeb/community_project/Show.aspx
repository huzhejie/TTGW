<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_project.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		county_name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcounty_name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		project_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblproject_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		project_name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblproject_name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		project_category
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblproject_category" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		project_add_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblproject_add_time" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		project_total_investment
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblproject_total_investment" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		project_proprietor
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblproject_proprietor" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		plan_to_bulid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplan_to_bulid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		biding_finish_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbiding_finish_time" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		contract_period
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcontract_period" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		project_start_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblproject_start_time" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		not_started_reason_analysis
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnot_started_reason_analysis" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		complete_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcomplete_time" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		project_delay_reason_analysis
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblproject_delay_reason_analysis" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		if_major_quality_or_security_accident_happened
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblif_major_quality_or_security_accident_happened" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		project_complete_acceptance_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblproject_complete_acceptance_time" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		complete_acceptance_quality_level
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcomplete_acceptance_quality_level" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		if_transfer
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblif_transfer" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		project_community_correlation_description
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblproject_community_correlation_description" runat="server"></asp:Label>
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
		project_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblproject_type" runat="server"></asp:Label>
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
		major_quality_or_security_accident
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmajor_quality_or_security_accident" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset17" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset18" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset19" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset20" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tciunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltciunset21" runat="server"></asp:Label>
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




