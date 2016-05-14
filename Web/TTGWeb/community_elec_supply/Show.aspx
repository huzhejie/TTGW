<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_elec_supply.Show" Title="显示页" %>
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
		community_load_dispatching_office_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_load_dispatching_office_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_transformer_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_transformer_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		below_100kva_transformer_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbelow_100kva_transformer_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		at_100_500kva_transformer_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblat_100_500kva_transformer_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		at_500_1000kva_transformer_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblat_500_1000kva_transformer_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		more_1000kva_transformer_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmore_1000kva_transformer_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_elec_supply_wireways_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_elec_supply_wireways_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_power_transmission_line_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_power_transmission_line_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_high_voltage_distr_line_legth
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_high_voltage_distr_line_legth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_low_voltage_distr_line_legth
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_low_voltage_distr_line_legth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_elec_supply_consumption
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_elec_supply_consumption" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_resident_elec_consumption
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_resident_elec_consumption" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_elec_days
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblno_elec_days" runat="server"></asp:Label>
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
		tcesunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcesunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcesunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcesunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcesunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcesunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcesunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcesunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcesunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcesunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcesunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcesunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcesunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcesunset13" runat="server"></asp:Label>
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




