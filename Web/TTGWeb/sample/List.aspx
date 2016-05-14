<%@ Page Title="T_sample" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.sample.List" %>
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
		<asp:BoundField DataField="sample_house_num" HeaderText="sample_house_num" SortExpression="sample_house_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sample_family_pop" HeaderText="sample_family_pop" SortExpression="sample_family_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sample_labor_force_pop" HeaderText="sample_labor_force_pop" SortExpression="sample_labor_force_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sample_employment_lf_pop" HeaderText="sample_employment_lf_pop" SortExpression="sample_employment_lf_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sample_primary_industry_lf_pop" HeaderText="sample_primary_industry_lf_pop" SortExpression="sample_primary_industry_lf_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sample_secondary_industry_lf_pop" HeaderText="sample_secondary_industry_lf_pop" SortExpression="sample_secondary_industry_lf_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sample_tertiary_industry_lf_pop" HeaderText="sample_tertiary_industry_lf_pop" SortExpression="sample_tertiary_industry_lf_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sample_PCDI" HeaderText="sample_PCDI" SortExpression="sample_PCDI" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sample_wages_income" HeaderText="sample_wages_income" SortExpression="sample_wages_income" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sample_family_run_pure_income" HeaderText="sample_family_run_pure_income" SortExpression="sample_family_run_pure_income" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sample_property_income" HeaderText="sample_property_income" SortExpression="sample_property_income" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sample_transfer_income" HeaderText="sample_transfer_income" SortExpression="sample_transfer_income" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sample_CONSP" HeaderText="sample_CONSP" SortExpression="sample_CONSP" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tsunset1" HeaderText="tsunset1" SortExpression="tsunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tsunset2" HeaderText="tsunset2" SortExpression="tsunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tsunset3" HeaderText="tsunset3" SortExpression="tsunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tsunset4" HeaderText="tsunset4" SortExpression="tsunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tsunset5" HeaderText="tsunset5" SortExpression="tsunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tsunset6" HeaderText="tsunset6" SortExpression="tsunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tsunset7" HeaderText="tsunset7" SortExpression="tsunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tsunset8" HeaderText="tsunset8" SortExpression="tsunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tsunset9" HeaderText="tsunset9" SortExpression="tsunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tsunset10" HeaderText="tsunset10" SortExpression="tsunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tsunset11" HeaderText="tsunset11" SortExpression="tsunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tsunset12" HeaderText="tsunset12" SortExpression="tsunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
