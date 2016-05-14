<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.community_road.Modify" Title="修改页" %>
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
		community_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_14_and_24_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_width_bet_14_and_24_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_14_and_24_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_width_bet_14_and_24_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_10_and_14_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_width_bet_10_and_14_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_10_and_14_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_width_bet_10_and_14_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_6_and_9_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_width_bet_6_and_9_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_6_and_9_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_width_bet_6_and_9_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_3_and_5_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_width_bet_3_and_5_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_width_bet_3_and_5_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_width_bet_3_and_5_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_pavement_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_pavement_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_pavement_colorful_brick_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_pavement_colorful_brick_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_bet_dwellings_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_bet_dwellings_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pavement_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_pavement_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_pavement_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_pavement_area" runat="server" Width="200px"></asp:TextBox>
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
		community_road_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset15" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset16" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcrunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcrunset17" runat="server" Width="200px"></asp:TextBox>
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

