<%@ Page Title="T_enterprise" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.enterprise.List" %>
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
                    BorderWidth="1px" DataKeyNames="id,statistics_date" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="id" HeaderText="id" SortExpression="id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="county" HeaderText="county" SortExpression="county" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="communty" HeaderText="communty" SortExpression="communty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="name" HeaderText="name" SortExpression="name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="address" HeaderText="address" SortExpression="address" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="distance_to_community" HeaderText="distance_to_community" SortExpression="distance_to_community" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="type" HeaderText="type" SortExpression="type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="main_product" HeaderText="main_product" SortExpression="main_product" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="area" HeaderText="area" SortExpression="area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="stuff_amount" HeaderText="stuff_amount" SortExpression="stuff_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="immigrant_stuff_amount" HeaderText="immigrant_stuff_amount" SortExpression="immigrant_stuff_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lf_average_salary" HeaderText="lf_average_salary" SortExpression="lf_average_salary" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="note_information" HeaderText="note_information" SortExpression="note_information" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="teunset1" HeaderText="teunset1" SortExpression="teunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="teunset2" HeaderText="teunset2" SortExpression="teunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="teunset3" HeaderText="teunset3" SortExpression="teunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="teunset4" HeaderText="teunset4" SortExpression="teunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="teunset5" HeaderText="teunset5" SortExpression="teunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="teunset6" HeaderText="teunset6" SortExpression="teunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="teunset7" HeaderText="teunset7" SortExpression="teunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="teunset8" HeaderText="teunset8" SortExpression="teunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="teunset9" HeaderText="teunset9" SortExpression="teunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="teunset10" HeaderText="teunset10" SortExpression="teunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="teunset11" HeaderText="teunset11" SortExpression="teunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="teunset12" HeaderText="teunset12" SortExpression="teunset12" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="id,statistics_date" DataNavigateUrlFormatString="Show.aspx?id0={0}&id1={1}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="id,statistics_date" DataNavigateUrlFormatString="Modify.aspx?id0={0}&id1={1}"
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
