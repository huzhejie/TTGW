<%@ Page Title="T_Community_Base" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.Community_Base.List" %>
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
		<asp:BoundField DataField="community_name" HeaderText="community_name" SortExpression="community_name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_location" HeaderText="community_location" SortExpression="community_location" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_county" HeaderText="community_county" SortExpression="community_county" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_type" HeaderText="community_type" SortExpression="community_type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_feature" HeaderText="community_feature" SortExpression="community_feature" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_function_area" HeaderText="community_function_area" SortExpression="community_function_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_function_type" HeaderText="community_function_type" SortExpression="community_function_type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="distance_to_county" HeaderText="distance_to_county" SortExpression="distance_to_county" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="distance_to_street_committees" HeaderText="distance_to_street_committees" SortExpression="distance_to_street_committees" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="distance_to_main_business_area" HeaderText="distance_to_main_business_area" SortExpression="distance_to_main_business_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="distance_to_main_education_area" HeaderText="distance_to_main_education_area" SortExpression="distance_to_main_education_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="distance_to_railway_station" HeaderText="distance_to_railway_station" SortExpression="distance_to_railway_station" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="distance_to_coach_station" HeaderText="distance_to_coach_station" SortExpression="distance_to_coach_station" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="distance_to_passenger_quay" HeaderText="distance_to_passenger_quay" SortExpression="distance_to_passenger_quay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="distance_to_main_street" HeaderText="distance_to_main_street" SortExpression="distance_to_main_street" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="distance_to_collector_street" HeaderText="distance_to_collector_street" SortExpression="distance_to_collector_street" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset1" HeaderText="tbcunset1" SortExpression="tbcunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset2" HeaderText="tbcunset2" SortExpression="tbcunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset3" HeaderText="tbcunset3" SortExpression="tbcunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset4" HeaderText="tbcunset4" SortExpression="tbcunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset5" HeaderText="tbcunset5" SortExpression="tbcunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset6" HeaderText="tbcunset6" SortExpression="tbcunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset7" HeaderText="tbcunset7" SortExpression="tbcunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset8" HeaderText="tbcunset8" SortExpression="tbcunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset9" HeaderText="tbcunset9" SortExpression="tbcunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset10" HeaderText="tbcunset10" SortExpression="tbcunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset11" HeaderText="tbcunset11" SortExpression="tbcunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset12" HeaderText="tbcunset12" SortExpression="tbcunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset13" HeaderText="tbcunset13" SortExpression="tbcunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset14" HeaderText="tbcunset14" SortExpression="tbcunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset15" HeaderText="tbcunset15" SortExpression="tbcunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset16" HeaderText="tbcunset16" SortExpression="tbcunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tbcunset17" HeaderText="tbcunset17" SortExpression="tbcunset17" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_wcommunity" HeaderText="community_wcommunity" SortExpression="community_wcommunity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_category" HeaderText="community_category" SortExpression="community_category" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_construct_year" HeaderText="community_construct_year" SortExpression="community_construct_year" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_province" HeaderText="community_province" SortExpression="community_province" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
