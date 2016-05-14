<%@ Page Title="T_community_shop_front" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_shop_front.List" %>
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
		<asp:BoundField DataField="community_shop_front_num" HeaderText="community_shop_front_num" SortExpression="community_shop_front_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_shop_front_in_main_street_num" HeaderText="community_shop_front_in_main_street_num" SortExpression="community_shop_front_in_main_street_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_shop_front_in_collector_street_num" HeaderText="community_shop_front_in_collector_street_num" SortExpression="community_shop_front_in_collector_street_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_shop_front_in_alley_num" HeaderText="community_shop_front_in_alley_num" SortExpression="community_shop_front_in_alley_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_back_street_shop_front_num" HeaderText="community_back_street_shop_front_num" SortExpression="community_back_street_shop_front_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_shop_front_area" HeaderText="community_shop_front_area" SortExpression="community_shop_front_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_immigrant_shop_front_num" HeaderText="community_immigrant_shop_front_num" SortExpression="community_immigrant_shop_front_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_immigrant_shop_front_area" HeaderText="community_immigrant_shop_front_area" SortExpression="community_immigrant_shop_front_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_immigrant_run_shop_front_num" HeaderText="community_immigrant_run_shop_front_num" SortExpression="community_immigrant_run_shop_front_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_immigrant_run_shop_front_area" HeaderText="community_immigrant_run_shop_front_area" SortExpression="community_immigrant_run_shop_front_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_immigrant_rent_out_shop_front_num" HeaderText="community_immigrant_rent_out_shop_front_num" SortExpression="community_immigrant_rent_out_shop_front_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_immigrant_rent_out_shop_front_area" HeaderText="community_immigrant_rent_out_shop_front_area" SortExpression="community_immigrant_rent_out_shop_front_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_immigrant_unused_shop_front_num" HeaderText="community_immigrant_unused_shop_front_num" SortExpression="community_immigrant_unused_shop_front_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_immigrant_unused_shop_front_area" HeaderText="community_immigrant_unused_shop_front_area" SortExpression="community_immigrant_unused_shop_front_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_shop_front_amount" HeaderText="community_shop_front_amount" SortExpression="community_shop_front_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_catering_shop_front_num" HeaderText="community_catering_shop_front_num" SortExpression="community_catering_shop_front_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_accommodation_shop_front_num" HeaderText="community_accommodation_shop_front_num" SortExpression="community_accommodation_shop_front_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_commodity_shop_front_num" HeaderText="community_commodity_shop_front_num" SortExpression="community_commodity_shop_front_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_means_of_production_shop_front_num" HeaderText="community_means_of_production_shop_front_num" SortExpression="community_means_of_production_shop_front_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_automobile_service_shop_front_num" HeaderText="community_automobile_service_shop_front_num" SortExpression="community_automobile_service_shop_front_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_other__shop_front_num" HeaderText="community_other__shop_front_num" SortExpression="community_other__shop_front_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_average_rent_of_shop_front" HeaderText="community_average_rent_of_shop_front" SortExpression="community_average_rent_of_shop_front" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_average_rent_time_of_shop_front" HeaderText="community_average_rent_time_of_shop_front" SortExpression="community_average_rent_time_of_shop_front" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_average_price_shop_front" HeaderText="community_average_price_shop_front" SortExpression="community_average_price_shop_front" ItemStyle-HorizontalAlign="Center"  /> 
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
