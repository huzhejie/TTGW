<%@ Page Title="T_community_social_insurance" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_social_insurance.List" %>
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
		<asp:BoundField DataField="community_urban_min_living_sec_pop" HeaderText="community_urban_min_living_sec_pop" SortExpression="community_urban_min_living_sec_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_very_poor_household_pop" HeaderText="community_very_poor_household_pop" SortExpression="community_very_poor_household_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_large_med_resv_immg_pop" HeaderText="community_large_med_resv_immg_pop" SortExpression="community_large_med_resv_immg_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_chongqing_immg_poor_pop" HeaderText="community_chongqing_immg_poor_pop" SortExpression="community_chongqing_immg_poor_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_medicare_pop" HeaderText="community_medicare_pop" SortExpression="community_medicare_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_endow_insu_pop" HeaderText="community_endow_insu_pop" SortExpression="community_endow_insu_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_unemp_insu_pop" HeaderText="community_unemp_insu_pop" SortExpression="community_unemp_insu_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsiunset1" HeaderText="tcsiunset1" SortExpression="tcsiunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsiunset2" HeaderText="tcsiunset2" SortExpression="tcsiunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsiunset3" HeaderText="tcsiunset3" SortExpression="tcsiunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsiunset4" HeaderText="tcsiunset4" SortExpression="tcsiunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsiunset5" HeaderText="tcsiunset5" SortExpression="tcsiunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsiunset6" HeaderText="tcsiunset6" SortExpression="tcsiunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsiunset7" HeaderText="tcsiunset7" SortExpression="tcsiunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="poor_people_rate" HeaderText="poor_people_rate" SortExpression="poor_people_rate" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
