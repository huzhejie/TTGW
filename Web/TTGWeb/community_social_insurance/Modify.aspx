<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.community_social_insurance.Modify" Title="修改页" %>
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
		community_urban_min_living_sec_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_urban_min_living_sec_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_very_poor_household_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_very_poor_household_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_large_med_resv_immg_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_large_med_resv_immg_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_chongqing_immg_poor_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_chongqing_immg_poor_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_medicare_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_medicare_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_endow_insu_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_endow_insu_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_unemp_insu_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_unemp_insu_pop" runat="server" Width="200px"></asp:TextBox>
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
		tcsiunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsiunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsiunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsiunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsiunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsiunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsiunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsiunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsiunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsiunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsiunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsiunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcsiunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcsiunset7" runat="server" Width="200px"></asp:TextBox>
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
		poor_people_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpoor_people_rate" runat="server" Width="200px"></asp:TextBox>
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

