<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.community_lf_employment.Modify" Title="修改页" %>
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
		community_total_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_total_lf_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_student_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_student_lf_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_age_bet_16_and_29_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lf_age_bet_16_and_29_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_age_bet_30_and_39_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lf_age_bet_30_and_39_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_age_bet_40_and_49_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lf_age_bet_40_and_49_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_age_larger_than_50_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lf_age_larger_than_50_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_illiterate_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_illiterate_lf_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_primary_school_education_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_primary_school_education_lf_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_middle_school_education_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_middle_school_education_lf_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_senior_school_education_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_senior_school_education_lf_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_college_graduate_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_college_graduate_lf_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_average_education_year
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lf_average_education_year" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_with_no_skill_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lf_with_no_skill_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_with_junior_skill_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lf_with_junior_skill_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_with_medium_grade_skill_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lf_with_medium_grade_skill_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_with_senior_skill_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lf_with_senior_skill_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hou_with_no_job_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_hou_with_no_job_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_hou_with_no_job_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_immigrant_hou_with_no_job_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lf_having_a_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lf_having_a_job_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ai_employee_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_ai_employee_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_enterprise_employee_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_enterprise_employee_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_part_time_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_part_time_job_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_migrant_workers_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_migrant_workers_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_household_management_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_household_management_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_no_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_no_job_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_have_job_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_have_job_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_farmer_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_farmer_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_industrial_employment_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_industrial_employment_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_buil_industrial_employment_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_buil_industrial_employment_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_transport_employment_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_transport_employment_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_whs_and_retail_employment_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_whs_and_retail_employment_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_catering_accomm_employment_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_catering_accomm_employment_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_other_service_employment_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_other_service_employment_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_empm_information_platform
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_empm_information_platform" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_entp_supportive_policy
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_entp_supportive_policy" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_enp_supportive_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_enp_supportive_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_spirited_job_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_public_spirited_job_num" runat="server" Width="200px"></asp:TextBox>
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
		tcleunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset15" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset16" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset17" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset18" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset19" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset20" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset21" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset22
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset22" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset23
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset23" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset24
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset24" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset25
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset25" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset26
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset26" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset27
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset27" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset28
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset28" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset29
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset29" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset30
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset30" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset31
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset31" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset32
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset32" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset33
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset33" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset34
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset34" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset35
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset35" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset36
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset36" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcleunset37
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcleunset37" runat="server" Width="200px"></asp:TextBox>
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

