<%@ Page Title="T_labor_force" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.labor_force.List" %>
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
                    BorderWidth="1px" DataKeyNames="id,statistics_date" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="id" HeaderText="id" SortExpression="id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="county" HeaderText="county" SortExpression="county" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community" HeaderText="community" SortExpression="community" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lf_have_a_job_pop" HeaderText="lf_have_a_job_pop" SortExpression="lf_have_a_job_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lf_have_a_steady_job_pop" HeaderText="lf_have_a_steady_job_pop" SortExpression="lf_have_a_steady_job_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="empm_information_platform_num" HeaderText="empm_information_platform_num" SortExpression="empm_information_platform_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="empm_information_platform_information_num" HeaderText="empm_information_platform_information_num" SortExpression="empm_information_platform_information_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="public_spirited_job_pop" HeaderText="public_spirited_job_pop" SortExpression="public_spirited_job_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="clean_keeping_pop" HeaderText="clean_keeping_pop" SortExpression="clean_keeping_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="security_guard_pop" HeaderText="security_guard_pop" SortExpression="security_guard_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="farm_produce_fair_administrator_pop" HeaderText="farm_produce_fair_administrator_pop" SortExpression="farm_produce_fair_administrator_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="other_job_pop" HeaderText="other_job_pop" SortExpression="other_job_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="enp_supportive_num" HeaderText="enp_supportive_num" SortExpression="enp_supportive_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="small_manual_processing_enp_num" HeaderText="small_manual_processing_enp_num" SortExpression="small_manual_processing_enp_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="food_enp_num" HeaderText="food_enp_num" SortExpression="food_enp_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sewing_embroidery_enp_num" HeaderText="sewing_embroidery_enp_num" SortExpression="sewing_embroidery_enp_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="other_enp_supportive_num" HeaderText="other_enp_supportive_num" SortExpression="other_enp_supportive_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="note_information" HeaderText="note_information" SortExpression="note_information" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset1" HeaderText="tlfunset1" SortExpression="tlfunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset2" HeaderText="tlfunset2" SortExpression="tlfunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset3" HeaderText="tlfunset3" SortExpression="tlfunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset4" HeaderText="tlfunset4" SortExpression="tlfunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset5" HeaderText="tlfunset5" SortExpression="tlfunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset6" HeaderText="tlfunset6" SortExpression="tlfunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset7" HeaderText="tlfunset7" SortExpression="tlfunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset8" HeaderText="tlfunset8" SortExpression="tlfunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset9" HeaderText="tlfunset9" SortExpression="tlfunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset10" HeaderText="tlfunset10" SortExpression="tlfunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset11" HeaderText="tlfunset11" SortExpression="tlfunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset12" HeaderText="tlfunset12" SortExpression="tlfunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset13" HeaderText="tlfunset13" SortExpression="tlfunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset14" HeaderText="tlfunset14" SortExpression="tlfunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset15" HeaderText="tlfunset15" SortExpression="tlfunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset16" HeaderText="tlfunset16" SortExpression="tlfunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tlfunset17" HeaderText="tlfunset17" SortExpression="tlfunset17" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="id,statistics_date" DataNavigateUrlFormatString="Show.aspx?id0={0}&id1={1}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="id,statistics_date" DataNavigateUrlFormatString="Modify.aspx?id0={0}&id1={1}"
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
