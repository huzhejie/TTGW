<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.wcommunity.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		wcommunity_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblwcommunity_id" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		wcommunity_name
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtwcommunity_name" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		kindergarten_capacity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtkindergarten_capacity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		integrated_management_building_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtintegrated_management_building_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		medical_bed_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtmedical_bed_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		parking_space_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtparking_space_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		convenience_stores_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtconvenience_stores_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		vegetable_market_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtvegetable_market_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		culture_fitness_facility_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtculture_fitness_facility_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		facilities_for_elders_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfacilities_for_elders_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttwunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttwunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttwunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttwunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttwunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttwunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttwunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttwunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		twunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttwunset9" runat="server" Width="200px"></asp:TextBox>
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
		statistics_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblstatistics_date" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		wcommunity_family_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtwcommunity_family_num" runat="server" Width="200px"></asp:TextBox>
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

