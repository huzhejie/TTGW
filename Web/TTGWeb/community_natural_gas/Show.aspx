<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_natural_gas.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		community_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_gas_regulating_station_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_gas_regulating_station_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_natural_gas_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_natural_gas_pipe_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		low_pressure_natural_gas_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllow_pressure_natural_gas_pipe_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		middle_pressuse_natural_gas_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmiddle_pressuse_natural_gas_pipe_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		intermediate_pressure_natural_gas_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblintermediate_pressure_natural_gas_pipe_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		statistics_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstatistics_date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcngunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcngunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcngunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcngunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcngunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcngunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcngunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcngunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcngunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcngunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lock_tables
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllock_tables" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		check_status
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcheck_status" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




