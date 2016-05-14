<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="TTG.Web.TTGWeb.community_shop_front.Add" Title="增加页" %>

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
		<asp:TextBox id="txtcommunity_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_shop_front_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_shop_front_in_main_street_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_shop_front_in_main_street_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_shop_front_in_collector_street_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_shop_front_in_collector_street_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_shop_front_in_alley_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_shop_front_in_alley_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_back_street_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_back_street_shop_front_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_shop_front_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_shop_front_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_immigrant_shop_front_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_shop_front_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_immigrant_shop_front_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_run_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_immigrant_run_shop_front_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_run_shop_front_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_immigrant_run_shop_front_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_rent_out_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_immigrant_rent_out_shop_front_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_rent_out_shop_front_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_immigrant_rent_out_shop_front_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_unused_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_immigrant_unused_shop_front_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_immigrant_unused_shop_front_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_immigrant_unused_shop_front_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_shop_front_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_shop_front_amount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_catering_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_catering_shop_front_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_accommodation_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_accommodation_shop_front_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_commodity_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_commodity_shop_front_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_means_of_production_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_means_of_production_shop_front_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_automobile_service_shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_automobile_service_shop_front_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_other__shop_front_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_other__shop_front_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_average_rent_of_shop_front
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_average_rent_of_shop_front" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_average_rent_time_of_shop_front
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_average_rent_time_of_shop_front" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_average_price_shop_front
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_average_price_shop_front" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		statistics_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstatistics_date" runat="server" Width="200px"></asp:TextBox>
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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
