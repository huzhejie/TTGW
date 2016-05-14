<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.excel_datatable.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		excel_name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblexcel_name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		table_name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltable_name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		table_start_column
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltable_start_column" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		table_start_row
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltable_start_row" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		table_end_column
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltable_end_column" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		table_end_row
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltable_end_row" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




