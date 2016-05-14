<%@ Page Title="T_community_immigrant" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_immigrant.List" %>
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
		<asp:BoundField DataField="immigrant_total_family_num" HeaderText="immigrant_total_family_num" SortExpression="immigrant_total_family_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="immigrant_total_population" HeaderText="immigrant_total_population" SortExpression="immigrant_total_population" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_pure_resident_pop" HeaderText="community_pure_resident_pop" SortExpression="community_pure_resident_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_depart_pop" HeaderText="community_depart_pop" SortExpression="community_depart_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_enp_staves" HeaderText="community_enp_staves" SortExpression="community_enp_staves" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_enp_laidoff_staves" HeaderText="community_enp_laidoff_staves" SortExpression="community_enp_laidoff_staves" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_have_land_pop" HeaderText="community_have_land_pop" SortExpression="community_have_land_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_rural_to_town_pop" HeaderText="community_rural_to_town_pop" SortExpression="community_rural_to_town_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcimunset1" HeaderText="tcimunset1" SortExpression="tcimunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcimunset2" HeaderText="tcimunset2" SortExpression="tcimunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcimunset3" HeaderText="tcimunset3" SortExpression="tcimunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcimunset4" HeaderText="tcimunset4" SortExpression="tcimunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcimunset5" HeaderText="tcimunset5" SortExpression="tcimunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcimunset6" HeaderText="tcimunset6" SortExpression="tcimunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcimunset7" HeaderText="tcimunset7" SortExpression="tcimunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
