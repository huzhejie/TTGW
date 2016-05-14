<%@ Page Title="T_community_letter_view" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_letter_view.List" %>
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
		<asp:BoundField DataField="community_lv_num" HeaderText="community_lv_num" SortExpression="community_lv_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lv_pop" HeaderText="community_lv_pop" SortExpression="community_lv_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lv_county_government_num" HeaderText="community_lv_county_government_num" SortExpression="community_lv_county_government_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lv_county_government_pop" HeaderText="community_lv_county_government_pop" SortExpression="community_lv_county_government_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lv_county_industry_num" HeaderText="community_lv_county_industry_num" SortExpression="community_lv_county_industry_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lv_county_industry_pop" HeaderText="community_lv_county_industry_pop" SortExpression="community_lv_county_industry_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lv_street_agency_num" HeaderText="community_lv_street_agency_num" SortExpression="community_lv_street_agency_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lv_street_agency_pop" HeaderText="community_lv_street_agency_pop" SortExpression="community_lv_street_agency_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lv_neighborhood_committee_num" HeaderText="community_lv_neighborhood_committee_num" SortExpression="community_lv_neighborhood_committee_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lv_neighborhood_committee_pop" HeaderText="community_lv_neighborhood_committee_pop" SortExpression="community_lv_neighborhood_committee_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lv_immigration_num" HeaderText="community_lv_immigration_num" SortExpression="community_lv_immigration_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lv_basic_fac_num" HeaderText="community_lv_basic_fac_num" SortExpression="community_lv_basic_fac_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lv_service_fac_num" HeaderText="community_lv_service_fac_num" SortExpression="community_lv_service_fac_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lv_livelihood_difficulty_num" HeaderText="community_lv_livelihood_difficulty_num" SortExpression="community_lv_livelihood_difficulty_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_lv_disputes_complaints_num" HeaderText="community_lv_disputes_complaints_num" SortExpression="community_lv_disputes_complaints_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclvunset1" HeaderText="tclvunset1" SortExpression="tclvunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclvunset2" HeaderText="tclvunset2" SortExpression="tclvunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclvunset3" HeaderText="tclvunset3" SortExpression="tclvunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclvunset4" HeaderText="tclvunset4" SortExpression="tclvunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclvunset5" HeaderText="tclvunset5" SortExpression="tclvunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclvunset6" HeaderText="tclvunset6" SortExpression="tclvunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclvunset7" HeaderText="tclvunset7" SortExpression="tclvunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclvunset8" HeaderText="tclvunset8" SortExpression="tclvunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclvunset9" HeaderText="tclvunset9" SortExpression="tclvunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclvunset10" HeaderText="tclvunset10" SortExpression="tclvunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclvunset11" HeaderText="tclvunset11" SortExpression="tclvunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclvunset12" HeaderText="tclvunset12" SortExpression="tclvunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclvunset13" HeaderText="tclvunset13" SortExpression="tclvunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclvunset14" HeaderText="tclvunset14" SortExpression="tclvunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclvunset15" HeaderText="tclvunset15" SortExpression="tclvunset15" ItemStyle-HorizontalAlign="Center"  /> 
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
