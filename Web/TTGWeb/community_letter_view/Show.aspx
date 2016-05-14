<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_letter_view.Show" Title="显示页" %>
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
		<asp:Label id="lblcommunity_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lv_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lv_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_county_government_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lv_county_government_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_county_government_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lv_county_government_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_county_industry_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lv_county_industry_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_county_industry_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lv_county_industry_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_street_agency_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lv_street_agency_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_street_agency_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lv_street_agency_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_neighborhood_committee_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lv_neighborhood_committee_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_neighborhood_committee_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lv_neighborhood_committee_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_immigration_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lv_immigration_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_basic_fac_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lv_basic_fac_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_service_fac_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lv_service_fac_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_livelihood_difficulty_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lv_livelihood_difficulty_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_lv_disputes_complaints_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_lv_disputes_complaints_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		statistics_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstatistics_date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclvunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclvunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclvunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclvunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclvunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclvunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclvunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclvunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclvunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclvunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclvunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclvunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclvunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclvunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tclvunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltclvunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lock_tables
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllock_tables" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		check_status
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcheck_status" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




