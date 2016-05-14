<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.Community_Base.Modify" Title="修改页" %>
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
		community_name
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_name" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_location
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_location" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_county
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_county" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_type" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_feature
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_feature" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_function_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_function_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_function_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_function_type" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_county
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdistance_to_county" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_street_committees
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdistance_to_street_committees" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_main_business_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdistance_to_main_business_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_main_education_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdistance_to_main_education_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_railway_station
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdistance_to_railway_station" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_coach_station
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdistance_to_coach_station" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_passenger_quay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdistance_to_passenger_quay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_main_street
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdistance_to_main_street" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		distance_to_collector_street
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdistance_to_collector_street" runat="server" Width="200px"></asp:TextBox>
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
		tbcunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset15" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset16" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tbcunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttbcunset17" runat="server" Width="200px"></asp:TextBox>
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
		community_wcommunity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_wcommunity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_category
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_category" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_construct_year
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_construct_year" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_province
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_province" runat="server" Width="200px"></asp:TextBox>
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

