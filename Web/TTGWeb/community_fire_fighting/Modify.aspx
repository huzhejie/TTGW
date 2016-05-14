<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.community_fire_fighting.Modify" Title="修改页" %>
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
		community_extinguisher_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_extinguisher_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_good_extinguisher_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_good_extinguisher_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hydrant_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_hydrant_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ots_hydrant_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_ots_hydrant_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_good_ots_hydrant_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_good_ots_hydrant_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ind_hydrant_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_ind_hydrant_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_good_ind_hydrant_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_good_ind_hydrant_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ff_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_ff_pipe_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ff_pipe_caliber_larger_than_100mm_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_ff_pipe_caliber_larger_than_100mm_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ff_pipe_caliber_less_than_100mm_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_ff_pipe_caliber_less_than_100mm_length" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		source_of_ff_water_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsource_of_ff_water_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		natural_ff_water_source_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnatural_ff_water_source_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		municipal_administration_pipe_net_ff_water_source
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtmunicipal_administration_pipe_net_ff_water_source" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ff_water_pool_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtff_water_pool_num" runat="server" Width="200px"></asp:TextBox>
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
		tcffunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcffunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcffunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcffunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcffunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcffunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcffunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcffunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcffunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcffunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcffunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcffunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcffunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcffunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcffunset14" runat="server" Width="200px"></asp:TextBox>
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

