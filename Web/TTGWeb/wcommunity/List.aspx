<%@ Page Title="T_wcommunity" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.wcommunity.List" %>
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
                    BorderWidth="1px" DataKeyNames="wcommunity_id,statistics_date" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="wcommunity_id" HeaderText="wcommunity_id" SortExpression="wcommunity_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="wcommunity_name" HeaderText="wcommunity_name" SortExpression="wcommunity_name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="kindergarten_capacity" HeaderText="kindergarten_capacity" SortExpression="kindergarten_capacity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="integrated_management_building_area" HeaderText="integrated_management_building_area" SortExpression="integrated_management_building_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="medical_bed_num" HeaderText="medical_bed_num" SortExpression="medical_bed_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="parking_space_num" HeaderText="parking_space_num" SortExpression="parking_space_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="convenience_stores_area" HeaderText="convenience_stores_area" SortExpression="convenience_stores_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="vegetable_market_area" HeaderText="vegetable_market_area" SortExpression="vegetable_market_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="culture_fitness_facility_area" HeaderText="culture_fitness_facility_area" SortExpression="culture_fitness_facility_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="facilities_for_elders_area" HeaderText="facilities_for_elders_area" SortExpression="facilities_for_elders_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="twunset1" HeaderText="twunset1" SortExpression="twunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="twunset2" HeaderText="twunset2" SortExpression="twunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="twunset3" HeaderText="twunset3" SortExpression="twunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="twunset4" HeaderText="twunset4" SortExpression="twunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="twunset5" HeaderText="twunset5" SortExpression="twunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="twunset6" HeaderText="twunset6" SortExpression="twunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="twunset7" HeaderText="twunset7" SortExpression="twunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="twunset8" HeaderText="twunset8" SortExpression="twunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="twunset9" HeaderText="twunset9" SortExpression="twunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="wcommunity_family_num" HeaderText="wcommunity_family_num" SortExpression="wcommunity_family_num" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="wcommunity_id,statistics_date" DataNavigateUrlFormatString="Show.aspx?id0={0}&id1={1}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="wcommunity_id,statistics_date" DataNavigateUrlFormatString="Modify.aspx?id0={0}&id1={1}"
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
