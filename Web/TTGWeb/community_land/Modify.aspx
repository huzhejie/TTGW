<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.community_land.Modify" Title="修改页" %>
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
		community_total_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_total_land_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_house_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_house_land_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_building_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_public_building_land_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_road_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_road_land_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_public_greenland_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_public_greenland_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_industry_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_industry_land_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_warehousing_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_warehousing_land_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_traffic_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_traffic_land_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_municipal_administration_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_municipal_administration_land_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_other_land_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_other_land_area" runat="server" Width="200px"></asp:TextBox>
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
		tclunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclunset10" runat="server" Width="200px"></asp:TextBox>
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

