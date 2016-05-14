<%@ Page Title="T_community_land" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_land.List" %>
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
		<asp:BoundField DataField="community_total_land_area" HeaderText="community_total_land_area" SortExpression="community_total_land_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_house_land_area" HeaderText="community_house_land_area" SortExpression="community_house_land_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_public_building_land_area" HeaderText="community_public_building_land_area" SortExpression="community_public_building_land_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_land_area" HeaderText="community_road_land_area" SortExpression="community_road_land_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_public_greenland_area" HeaderText="community_public_greenland_area" SortExpression="community_public_greenland_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_industry_land_area" HeaderText="community_industry_land_area" SortExpression="community_industry_land_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_warehousing_land_area" HeaderText="community_warehousing_land_area" SortExpression="community_warehousing_land_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_traffic_land_area" HeaderText="community_traffic_land_area" SortExpression="community_traffic_land_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_municipal_administration_land_area" HeaderText="community_municipal_administration_land_area" SortExpression="community_municipal_administration_land_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_other_land_area" HeaderText="community_other_land_area" SortExpression="community_other_land_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclunset1" HeaderText="tclunset1" SortExpression="tclunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclunset2" HeaderText="tclunset2" SortExpression="tclunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclunset3" HeaderText="tclunset3" SortExpression="tclunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclunset4" HeaderText="tclunset4" SortExpression="tclunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclunset5" HeaderText="tclunset5" SortExpression="tclunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclunset6" HeaderText="tclunset6" SortExpression="tclunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclunset7" HeaderText="tclunset7" SortExpression="tclunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclunset8" HeaderText="tclunset8" SortExpression="tclunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclunset9" HeaderText="tclunset9" SortExpression="tclunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tclunset10" HeaderText="tclunset10" SortExpression="tclunset10" ItemStyle-HorizontalAlign="Center"  /> 
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
