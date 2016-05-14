<%@ Page Title="T_community_parking_lot" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_parking_lot.List" %>
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
		<asp:BoundField DataField="community_parking_space_num" HeaderText="community_parking_space_num" SortExpression="community_parking_space_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_parking_rate" HeaderText="community_parking_rate" SortExpression="community_parking_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_parking_space_use_rate" HeaderText="community_parking_space_use_rate" SortExpression="community_parking_space_use_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_public_parking_lot_num" HeaderText="community_public_parking_lot_num" SortExpression="community_public_parking_lot_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_public_grand_parking_lot_num" HeaderText="community_public_grand_parking_lot_num" SortExpression="community_public_grand_parking_lot_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_public_underg_parking_lot_num" HeaderText="community_public_underg_parking_lot_num" SortExpression="community_public_underg_parking_lot_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_public_overg_parking_lot_num" HeaderText="community_public_overg_parking_lot_num" SortExpression="community_public_overg_parking_lot_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_public_parking_lot_area" HeaderText="community_public_parking_lot_area" SortExpression="community_public_parking_lot_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_public_parking_space_num" HeaderText="community_public_parking_space_num" SortExpression="community_public_parking_space_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_public_parking_lot_area_rate" HeaderText="community_public_parking_lot_area_rate" SortExpression="community_public_parking_lot_area_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="dis_150m_public_parking_lot_num" HeaderText="dis_150m_public_parking_lot_num" SortExpression="dis_150m_public_parking_lot_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="dis_150m_public_parking_lot_area" HeaderText="dis_150m_public_parking_lot_area" SortExpression="dis_150m_public_parking_lot_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="dis_150m_public_parking_space_num" HeaderText="dis_150m_public_parking_space_num" SortExpression="dis_150m_public_parking_space_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcplunset1" HeaderText="tcplunset1" SortExpression="tcplunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcplunset2" HeaderText="tcplunset2" SortExpression="tcplunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcplunset3" HeaderText="tcplunset3" SortExpression="tcplunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcplunset4" HeaderText="tcplunset4" SortExpression="tcplunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcplunset5" HeaderText="tcplunset5" SortExpression="tcplunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcplunset6" HeaderText="tcplunset6" SortExpression="tcplunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcplunset7" HeaderText="tcplunset7" SortExpression="tcplunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcplunset8" HeaderText="tcplunset8" SortExpression="tcplunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcplunset9" HeaderText="tcplunset9" SortExpression="tcplunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcplunset10" HeaderText="tcplunset10" SortExpression="tcplunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcplunset11" HeaderText="tcplunset11" SortExpression="tcplunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcplunset12" HeaderText="tcplunset12" SortExpression="tcplunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcplunset13" HeaderText="tcplunset13" SortExpression="tcplunset13" ItemStyle-HorizontalAlign="Center"  /> 
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
