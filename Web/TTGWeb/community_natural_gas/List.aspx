﻿<%@ Page Title="T_community_natural_gas" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_natural_gas.List" %>
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
		<asp:BoundField DataField="community_gas_regulating_station_num" HeaderText="community_gas_regulating_station_num" SortExpression="community_gas_regulating_station_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_natural_gas_pipe_length" HeaderText="community_natural_gas_pipe_length" SortExpression="community_natural_gas_pipe_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="low_pressure_natural_gas_pipe_length" HeaderText="low_pressure_natural_gas_pipe_length" SortExpression="low_pressure_natural_gas_pipe_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="middle_pressuse_natural_gas_pipe_length" HeaderText="middle_pressuse_natural_gas_pipe_length" SortExpression="middle_pressuse_natural_gas_pipe_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="intermediate_pressure_natural_gas_pipe_length" HeaderText="intermediate_pressure_natural_gas_pipe_length" SortExpression="intermediate_pressure_natural_gas_pipe_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcngunset1" HeaderText="tcngunset1" SortExpression="tcngunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcngunset2" HeaderText="tcngunset2" SortExpression="tcngunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcngunset3" HeaderText="tcngunset3" SortExpression="tcngunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcngunset4" HeaderText="tcngunset4" SortExpression="tcngunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcngunset5" HeaderText="tcngunset5" SortExpression="tcngunset5" ItemStyle-HorizontalAlign="Center"  /> 
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