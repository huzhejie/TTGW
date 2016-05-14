<%@ Page Title="T_community_concil_house" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_concil_house.List" %>
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
		<asp:BoundField DataField="community_council_buil_num" HeaderText="community_council_buil_num" SortExpression="community_council_buil_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_conhou_gfa" HeaderText="community_conhou_gfa" SortExpression="community_conhou_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_conhou_fs" HeaderText="community_conhou_fs" SortExpression="community_conhou_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_conhou_unit_num" HeaderText="community_conhou_unit_num" SortExpression="community_conhou_unit_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_conhou_floor_num" HeaderText="community_conhou_floor_num" SortExpression="community_conhou_floor_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_conhou_suite_num" HeaderText="community_conhou_suite_num" SortExpression="community_conhou_suite_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_conhou_family_num" HeaderText="community_conhou_family_num" SortExpression="community_conhou_family_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_conhou_people_num" HeaderText="community_conhou_people_num" SortExpression="community_conhou_people_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcchunset1" HeaderText="tcchunset1" SortExpression="tcchunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcchunset2" HeaderText="tcchunset2" SortExpression="tcchunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcchunset3" HeaderText="tcchunset3" SortExpression="tcchunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcchunset4" HeaderText="tcchunset4" SortExpression="tcchunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcchunset5" HeaderText="tcchunset5" SortExpression="tcchunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcchunset6" HeaderText="tcchunset6" SortExpression="tcchunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcchunset8" HeaderText="tcchunset8" SortExpression="tcchunset8" ItemStyle-HorizontalAlign="Center"  /> 
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
