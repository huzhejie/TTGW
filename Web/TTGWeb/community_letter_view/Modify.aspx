<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="TTG.Web.TTGWeb.community_letter_view.Modify" Title="修改页" %>
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
		community_lv_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lv_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lv_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_county_government_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lv_county_government_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_county_government_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lv_county_government_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_county_industry_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lv_county_industry_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_county_industry_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lv_county_industry_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_street_agency_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lv_street_agency_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_street_agency_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lv_street_agency_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_neighborhood_committee_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lv_neighborhood_committee_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_neighborhood_committee_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lv_neighborhood_committee_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_immigration_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lv_immigration_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_basic_fac_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lv_basic_fac_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_service_fac_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lv_service_fac_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_livelihood_difficulty_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lv_livelihood_difficulty_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_disputes_complaints_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_lv_disputes_complaints_num" runat="server" Width="200px"></asp:TextBox>
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
		tclvunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclvunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclvunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclvunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclvunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclvunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclvunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclvunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclvunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclvunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclvunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclvunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclvunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclvunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclvunset14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttclvunset15" runat="server" Width="200px"></asp:TextBox>
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

