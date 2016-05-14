<%@ Page Title="T_community_project" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_project.List" %>
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
                    BorderWidth="1px" DataKeyNames="county_name,project_id,statistics_date" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="county_name" HeaderText="county_name" SortExpression="county_name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="project_id" HeaderText="project_id" SortExpression="project_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="project_name" HeaderText="project_name" SortExpression="project_name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="project_category" HeaderText="project_category" SortExpression="project_category" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="project_add_time" HeaderText="project_add_time" SortExpression="project_add_time" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="project_total_investment" HeaderText="project_total_investment" SortExpression="project_total_investment" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="project_proprietor" HeaderText="project_proprietor" SortExpression="project_proprietor" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="plan_to_bulid" HeaderText="plan_to_bulid" SortExpression="plan_to_bulid" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="biding_finish_time" HeaderText="biding_finish_time" SortExpression="biding_finish_time" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="contract_period" HeaderText="contract_period" SortExpression="contract_period" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="project_start_time" HeaderText="project_start_time" SortExpression="project_start_time" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="not_started_reason_analysis" HeaderText="not_started_reason_analysis" SortExpression="not_started_reason_analysis" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="complete_time" HeaderText="complete_time" SortExpression="complete_time" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="project_delay_reason_analysis" HeaderText="project_delay_reason_analysis" SortExpression="project_delay_reason_analysis" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="if_major_quality_or_security_accident_happened" HeaderText="if_major_quality_or_security_accident_happened" SortExpression="if_major_quality_or_security_accident_happened" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="project_complete_acceptance_time" HeaderText="project_complete_acceptance_time" SortExpression="project_complete_acceptance_time" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="complete_acceptance_quality_level" HeaderText="complete_acceptance_quality_level" SortExpression="complete_acceptance_quality_level" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="if_transfer" HeaderText="if_transfer" SortExpression="if_transfer" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="project_community_correlation_description" HeaderText="project_community_correlation_description" SortExpression="project_community_correlation_description" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="note_information" HeaderText="note_information" SortExpression="note_information" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="project_type" HeaderText="project_type" SortExpression="project_type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="major_quality_or_security_accident" HeaderText="major_quality_or_security_accident" SortExpression="major_quality_or_security_accident" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset1" HeaderText="tciunset1" SortExpression="tciunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset2" HeaderText="tciunset2" SortExpression="tciunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset3" HeaderText="tciunset3" SortExpression="tciunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset4" HeaderText="tciunset4" SortExpression="tciunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset5" HeaderText="tciunset5" SortExpression="tciunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset6" HeaderText="tciunset6" SortExpression="tciunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset7" HeaderText="tciunset7" SortExpression="tciunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset8" HeaderText="tciunset8" SortExpression="tciunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset9" HeaderText="tciunset9" SortExpression="tciunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset10" HeaderText="tciunset10" SortExpression="tciunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset11" HeaderText="tciunset11" SortExpression="tciunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset12" HeaderText="tciunset12" SortExpression="tciunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset13" HeaderText="tciunset13" SortExpression="tciunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset14" HeaderText="tciunset14" SortExpression="tciunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset15" HeaderText="tciunset15" SortExpression="tciunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset16" HeaderText="tciunset16" SortExpression="tciunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset17" HeaderText="tciunset17" SortExpression="tciunset17" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset18" HeaderText="tciunset18" SortExpression="tciunset18" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset19" HeaderText="tciunset19" SortExpression="tciunset19" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset20" HeaderText="tciunset20" SortExpression="tciunset20" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset21" HeaderText="tciunset21" SortExpression="tciunset21" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="county_name,project_id,statistics_date" DataNavigateUrlFormatString="Show.aspx?id0={0}&id1={1}&id2={2}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="county_name,project_id,statistics_date" DataNavigateUrlFormatString="Modify.aspx?id0={0}&id1={1}&id2={2}"
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
