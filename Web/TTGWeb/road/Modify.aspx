<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.road.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		id
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblid" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		name
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtname" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_class
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtroad_class" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		width
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtwidth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pavement_width
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpavement_width" runat="server" Width="200px"></asp:TextBox>
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
		structure
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstructure" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_dead_end_road
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtis_dead_end_road" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		damage_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdamage_road_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		large_slope_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlarge_slope_road_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_hard_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtno_hard_road_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lack_width_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlack_width_road_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_somewhere_no_link
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtis_somewhere_no_link" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		no_afforest_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtno_afforest_road_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		less_afforest_road_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtless_afforest_road_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		street_light_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstreet_light_amount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		good_street_light_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgood_street_light_amount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_hydrant_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtroad_hydrant_amount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		good_road_hydrant_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgood_road_hydrant_amount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_dustbin_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtroad_dustbin_amount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		good_road_dustbin_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgood_road_dustbin_amount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		road_parking_space_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtroad_parking_space_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		parking_space_use_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtparking_space_use_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		note_information
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnote_information" runat="server" Width="200px"></asp:TextBox>
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
		check_status
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcheck_status" runat="server" Width="200px"></asp:TextBox>
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
		trunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset15" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset16" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset17" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset18" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset19" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset20" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset21" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset22
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset22" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset23
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset23" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trunset24
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrunset24" runat="server" Width="200px"></asp:TextBox>
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

