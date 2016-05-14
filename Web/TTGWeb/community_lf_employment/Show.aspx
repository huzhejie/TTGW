<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_lf_employment.Show" Title="显示页" %>
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
		<asp:Label id="lblcommunity_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_total_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_total_lf_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_student_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_student_lf_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_age_bet_16_and_29_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lf_age_bet_16_and_29_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_age_bet_30_and_39_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lf_age_bet_30_and_39_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_age_bet_40_and_49_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lf_age_bet_40_and_49_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_age_larger_than_50_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lf_age_larger_than_50_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_illiterate_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_illiterate_lf_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_primary_school_education_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_primary_school_education_lf_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_middle_school_education_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_middle_school_education_lf_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_senior_school_education_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_senior_school_education_lf_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_college_graduate_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_college_graduate_lf_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_average_education_year
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lf_average_education_year" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_with_no_skill_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lf_with_no_skill_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_with_junior_skill_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lf_with_junior_skill_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_with_medium_grade_skill_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lf_with_medium_grade_skill_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_with_senior_skill_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lf_with_senior_skill_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hou_with_no_job_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_hou_with_no_job_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_hou_with_no_job_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_immigrant_hou_with_no_job_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_having_a_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lf_having_a_job_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ai_employee_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_ai_employee_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_enterprise_employee_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_enterprise_employee_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_part_time_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_part_time_job_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_migrant_workers_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_migrant_workers_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_household_management_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_household_management_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_no_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_no_job_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_have_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_have_job_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farmer_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_farmer_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_industrial_employment_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_industrial_employment_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_buil_industrial_employment_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_buil_industrial_employment_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_transport_employment_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_transport_employment_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_whs_and_retail_employment_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_whs_and_retail_employment_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_catering_accomm_employment_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_catering_accomm_employment_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_other_service_employment_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_other_service_employment_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_empm_information_platform
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_empm_information_platform" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_entp_supportive_policy
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_entp_supportive_policy" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_enp_supportive_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_enp_supportive_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_spirited_job_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_public_spirited_job_num" runat="server"></asp:Label>
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
		tcleunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset17" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset18" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset19" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset20" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset21" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset22
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset22" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset23
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset23" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset24
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset24" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset25
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset25" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset26
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset26" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset27
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset27" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset28
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset28" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset29
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset29" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset30
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset30" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset31
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset31" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset32
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset32" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset33
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset33" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset34
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset34" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset35
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset35" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset36
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset36" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset37
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcleunset37" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lock_tables
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllock_tables" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		check_status
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcheck_status" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




