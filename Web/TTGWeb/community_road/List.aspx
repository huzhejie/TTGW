<%@ Page Title="T_community_road" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_road.List" %>
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
		<asp:BoundField DataField="community_road_length" HeaderText="community_road_length" SortExpression="community_road_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_area" HeaderText="community_road_area" SortExpression="community_road_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_width_bet_14_and_24_length" HeaderText="community_road_width_bet_14_and_24_length" SortExpression="community_road_width_bet_14_and_24_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_width_bet_14_and_24_area" HeaderText="community_road_width_bet_14_and_24_area" SortExpression="community_road_width_bet_14_and_24_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_width_bet_10_and_14_length" HeaderText="community_road_width_bet_10_and_14_length" SortExpression="community_road_width_bet_10_and_14_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_width_bet_10_and_14_area" HeaderText="community_road_width_bet_10_and_14_area" SortExpression="community_road_width_bet_10_and_14_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_width_bet_6_and_9_length" HeaderText="community_road_width_bet_6_and_9_length" SortExpression="community_road_width_bet_6_and_9_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_width_bet_6_and_9_area" HeaderText="community_road_width_bet_6_and_9_area" SortExpression="community_road_width_bet_6_and_9_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_width_bet_3_and_5_length" HeaderText="community_road_width_bet_3_and_5_length" SortExpression="community_road_width_bet_3_and_5_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_width_bet_3_and_5_area" HeaderText="community_road_width_bet_3_and_5_area" SortExpression="community_road_width_bet_3_and_5_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_pavement_area" HeaderText="community_road_pavement_area" SortExpression="community_road_pavement_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_pavement_colorful_brick_area" HeaderText="community_road_pavement_colorful_brick_area" SortExpression="community_road_pavement_colorful_brick_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_bet_dwellings_length" HeaderText="community_road_bet_dwellings_length" SortExpression="community_road_bet_dwellings_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length" HeaderText="community_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length" SortExpression="community_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_pavement_length" HeaderText="community_pavement_length" SortExpression="community_pavement_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_pavement_area" HeaderText="community_pavement_area" SortExpression="community_pavement_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_num" HeaderText="community_road_num" SortExpression="community_road_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset1" HeaderText="tcrunset1" SortExpression="tcrunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset2" HeaderText="tcrunset2" SortExpression="tcrunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset3" HeaderText="tcrunset3" SortExpression="tcrunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset4" HeaderText="tcrunset4" SortExpression="tcrunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset5" HeaderText="tcrunset5" SortExpression="tcrunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset6" HeaderText="tcrunset6" SortExpression="tcrunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset7" HeaderText="tcrunset7" SortExpression="tcrunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset8" HeaderText="tcrunset8" SortExpression="tcrunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset9" HeaderText="tcrunset9" SortExpression="tcrunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset10" HeaderText="tcrunset10" SortExpression="tcrunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset11" HeaderText="tcrunset11" SortExpression="tcrunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset12" HeaderText="tcrunset12" SortExpression="tcrunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset13" HeaderText="tcrunset13" SortExpression="tcrunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset14" HeaderText="tcrunset14" SortExpression="tcrunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset15" HeaderText="tcrunset15" SortExpression="tcrunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset16" HeaderText="tcrunset16" SortExpression="tcrunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcrunset17" HeaderText="tcrunset17" SortExpression="tcrunset17" ItemStyle-HorizontalAlign="Center"  /> 
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
