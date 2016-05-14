<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.community_fire_fighting.Show" Title="显示页" %>
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
		community_extinguisher_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_extinguisher_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_good_extinguisher_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_good_extinguisher_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_hydrant_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_hydrant_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ots_hydrant_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_ots_hydrant_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_good_ots_hydrant_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_good_ots_hydrant_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ind_hydrant_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_ind_hydrant_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_good_ind_hydrant_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_good_ind_hydrant_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ff_pipe_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_ff_pipe_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ff_pipe_caliber_larger_than_100mm_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_ff_pipe_caliber_larger_than_100mm_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_ff_pipe_caliber_less_than_100mm_length
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity_ff_pipe_caliber_less_than_100mm_length" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		source_of_ff_water_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsource_of_ff_water_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		natural_ff_water_source_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnatural_ff_water_source_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		municipal_administration_pipe_net_ff_water_source
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmunicipal_administration_pipe_net_ff_water_source" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ff_water_pool_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblff_water_pool_num" runat="server"></asp:Label>
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
		tcffunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcffunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcffunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcffunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcffunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcffunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcffunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcffunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcffunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcffunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcffunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcffunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcffunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcffunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcffunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltcffunset14" runat="server"></asp:Label>
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




