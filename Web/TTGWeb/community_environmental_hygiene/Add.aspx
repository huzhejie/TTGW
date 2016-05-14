<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="TTG.Web.TTGWeb.community_environmental_hygiene.Add" Title="增加页" %>

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
		community_refuse_transfer_station_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_refuse_transfer_station_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_refuse_transfer_station_dis_ots
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_refuse_transfer_station_dis_ots" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_refuse_collection_point_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_refuse_collection_point_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_dustbin_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_dustbin_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		rubbish_produce_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtrubbish_produce_amount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		live_rubbish_produce_year_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlive_rubbish_produce_year_amount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		solid_rubbish_produce_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsolid_rubbish_produce_amount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		environmental_fee_charge_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtenvironmental_fee_charge_amount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_toilet_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_public_toilet_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_toilet_space_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_public_toilet_space_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_toilet_inside_300m_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_public_toilet_inside_300m_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		statistics_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstatistics_date" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_toilet_cover_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_public_toilet_cover_road_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcehunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcehunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcehunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcehunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcehunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcehunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcehunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcehunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcehunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcehunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcehunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcehunset11" runat="server" Width="200px"></asp:TextBox>
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
	<tr>
	<td height="25" width="30%" align="right">
		community_public_toilet_area_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_public_toilet_area_num" runat="server" Width="200px"></asp:TextBox>
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
