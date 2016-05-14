<%@ Page Title="T_community_lf_employment" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_lf_employment.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="community_id,statistics_date" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="community_id" HeaderText="community_id" SortExpression="community_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_total_lf_pop" HeaderText="community_total_lf_pop" SortExpression="community_total_lf_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_student_lf_pop" HeaderText="community_student_lf_pop" SortExpression="community_student_lf_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lf_age_bet_16_and_29_pop" HeaderText="community_lf_age_bet_16_and_29_pop" SortExpression="community_lf_age_bet_16_and_29_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lf_age_bet_30_and_39_pop" HeaderText="community_lf_age_bet_30_and_39_pop" SortExpression="community_lf_age_bet_30_and_39_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lf_age_bet_40_and_49_pop" HeaderText="community_lf_age_bet_40_and_49_pop" SortExpression="community_lf_age_bet_40_and_49_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lf_age_larger_than_50_pop" HeaderText="community_lf_age_larger_than_50_pop" SortExpression="community_lf_age_larger_than_50_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_illiterate_lf_pop" HeaderText="community_illiterate_lf_pop" SortExpression="community_illiterate_lf_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_primary_school_education_lf_pop" HeaderText="community_primary_school_education_lf_pop" SortExpression="community_primary_school_education_lf_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_middle_school_education_lf_pop" HeaderText="community_middle_school_education_lf_pop" SortExpression="community_middle_school_education_lf_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_senior_school_education_lf_pop" HeaderText="community_senior_school_education_lf_pop" SortExpression="community_senior_school_education_lf_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_college_graduate_lf_pop" HeaderText="community_college_graduate_lf_pop" SortExpression="community_college_graduate_lf_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lf_average_education_year" HeaderText="community_lf_average_education_year" SortExpression="community_lf_average_education_year" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lf_with_no_skill_pop" HeaderText="community_lf_with_no_skill_pop" SortExpression="community_lf_with_no_skill_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lf_with_junior_skill_pop" HeaderText="community_lf_with_junior_skill_pop" SortExpression="community_lf_with_junior_skill_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lf_with_medium_grade_skill_pop" HeaderText="community_lf_with_medium_grade_skill_pop" SortExpression="community_lf_with_medium_grade_skill_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lf_with_senior_skill_pop" HeaderText="community_lf_with_senior_skill_pop" SortExpression="community_lf_with_senior_skill_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_hou_with_no_job_num" HeaderText="community_hou_with_no_job_num" SortExpression="community_hou_with_no_job_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_immigrant_hou_with_no_job_num" HeaderText="community_immigrant_hou_with_no_job_num" SortExpression="community_immigrant_hou_with_no_job_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lf_having_a_job_pop" HeaderText="community_lf_having_a_job_pop" SortExpression="community_lf_having_a_job_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_ai_employee_pop" HeaderText="community_ai_employee_pop" SortExpression="community_ai_employee_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_enterprise_employee_pop" HeaderText="community_enterprise_employee_pop" SortExpression="community_enterprise_employee_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_part_time_job_pop" HeaderText="community_part_time_job_pop" SortExpression="community_part_time_job_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_migrant_workers_pop" HeaderText="community_migrant_workers_pop" SortExpression="community_migrant_workers_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_household_management_pop" HeaderText="community_household_management_pop" SortExpression="community_household_management_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_no_job_pop" HeaderText="community_no_job_pop" SortExpression="community_no_job_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_have_job_pop" HeaderText="community_have_job_pop" SortExpression="community_have_job_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_farmer_pop" HeaderText="community_farmer_pop" SortExpression="community_farmer_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_industrial_employment_pop" HeaderText="community_industrial_employment_pop" SortExpression="community_industrial_employment_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_buil_industrial_employment_pop" HeaderText="community_buil_industrial_employment_pop" SortExpression="community_buil_industrial_employment_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_transport_employment_pop" HeaderText="community_transport_employment_pop" SortExpression="community_transport_employment_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_whs_and_retail_employment_pop" HeaderText="community_whs_and_retail_employment_pop" SortExpression="community_whs_and_retail_employment_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_catering_accomm_employment_pop" HeaderText="community_catering_accomm_employment_pop" SortExpression="community_catering_accomm_employment_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_other_service_employment_pop" HeaderText="community_other_service_employment_pop" SortExpression="community_other_service_employment_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_empm_information_platform" HeaderText="community_empm_information_platform" SortExpression="community_empm_information_platform" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_entp_supportive_policy" HeaderText="community_entp_supportive_policy" SortExpression="community_entp_supportive_policy" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_enp_supportive_num" HeaderText="community_enp_supportive_num" SortExpression="community_enp_supportive_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_public_spirited_job_num" HeaderText="community_public_spirited_job_num" SortExpression="community_public_spirited_job_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset1" HeaderText="tcleunset1" SortExpression="tcleunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset2" HeaderText="tcleunset2" SortExpression="tcleunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset3" HeaderText="tcleunset3" SortExpression="tcleunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset4" HeaderText="tcleunset4" SortExpression="tcleunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset5" HeaderText="tcleunset5" SortExpression="tcleunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset6" HeaderText="tcleunset6" SortExpression="tcleunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset7" HeaderText="tcleunset7" SortExpression="tcleunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset8" HeaderText="tcleunset8" SortExpression="tcleunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset9" HeaderText="tcleunset9" SortExpression="tcleunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset10" HeaderText="tcleunset10" SortExpression="tcleunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset11" HeaderText="tcleunset11" SortExpression="tcleunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset12" HeaderText="tcleunset12" SortExpression="tcleunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset13" HeaderText="tcleunset13" SortExpression="tcleunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset14" HeaderText="tcleunset14" SortExpression="tcleunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset15" HeaderText="tcleunset15" SortExpression="tcleunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset16" HeaderText="tcleunset16" SortExpression="tcleunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset17" HeaderText="tcleunset17" SortExpression="tcleunset17" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset18" HeaderText="tcleunset18" SortExpression="tcleunset18" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset19" HeaderText="tcleunset19" SortExpression="tcleunset19" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset20" HeaderText="tcleunset20" SortExpression="tcleunset20" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset21" HeaderText="tcleunset21" SortExpression="tcleunset21" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset22" HeaderText="tcleunset22" SortExpression="tcleunset22" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset23" HeaderText="tcleunset23" SortExpression="tcleunset23" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset24" HeaderText="tcleunset24" SortExpression="tcleunset24" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset25" HeaderText="tcleunset25" SortExpression="tcleunset25" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset26" HeaderText="tcleunset26" SortExpression="tcleunset26" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset27" HeaderText="tcleunset27" SortExpression="tcleunset27" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset28" HeaderText="tcleunset28" SortExpression="tcleunset28" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset29" HeaderText="tcleunset29" SortExpression="tcleunset29" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset30" HeaderText="tcleunset30" SortExpression="tcleunset30" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset31" HeaderText="tcleunset31" SortExpression="tcleunset31" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset32" HeaderText="tcleunset32" SortExpression="tcleunset32" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset33" HeaderText="tcleunset33" SortExpression="tcleunset33" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset34" HeaderText="tcleunset34" SortExpression="tcleunset34" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset35" HeaderText="tcleunset35" SortExpression="tcleunset35" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset36" HeaderText="tcleunset36" SortExpression="tcleunset36" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcleunset37" HeaderText="tcleunset37" SortExpression="tcleunset37" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="community_id,statistics_date" DataNavigateUrlFormatString="Show.aspx?id0={0}&id1={1}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="community_id,statistics_date" DataNavigateUrlFormatString="Modify.aspx?id0={0}&id1={1}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
