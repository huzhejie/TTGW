<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.community_elec_supply.Modify" Title="修改页" %>
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
		<asp:label id="lblcommunity_id" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_load_dispatching_office_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_load_dispatching_office_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_transformer_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_transformer_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		below_100kva_transformer_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbelow_100kva_transformer_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		at_100_500kva_transformer_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtat_100_500kva_transformer_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		at_500_1000kva_transformer_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtat_500_1000kva_transformer_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		more_1000kva_transformer_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtmore_1000kva_transformer_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_elec_supply_wireways_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_elec_supply_wireways_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_power_transmission_line_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_power_transmission_line_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_high_voltage_distr_line_legth
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_high_voltage_distr_line_legth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_low_voltage_distr_line_legth
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_low_voltage_distr_line_legth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_elec_supply_consumption
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_elec_supply_consumption" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_resident_elec_consumption
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_resident_elec_consumption" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_elec_days
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtno_elec_days" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		statistics_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblstatistics_date" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcesunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcesunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcesunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcesunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcesunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcesunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcesunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcesunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcesunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcesunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcesunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcesunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcesunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcesunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lock_tables
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlock_tables" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		check_status
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcheck_status" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

