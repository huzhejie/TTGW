<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TTG.Web.TTGWeb.concil_house.Show" Title="显示页" %>
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
		<asp:Label id="lblid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommunity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		building
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbuilding" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		unit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblunit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		structure
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstructure" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		floor
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfloor" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		house
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblhouse" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		finish_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfinish_time" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gross_floor_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblgross_floor_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tiled_wall_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltiled_wall_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		family_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfamily_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pop_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpop_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		slight_deform_cra_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblslight_deform_cra_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		base_subs_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbase_subs_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		dila_buil_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldila_buil_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		stru_safety_prob_fam_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstru_safety_prob_fam_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		slight_deform_cra_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblslight_deform_cra_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		seepage_buil_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblseepage_buil_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		seepage_fam_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblseepage_fam_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		seepage_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblseepage_pop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tile_paint_cra_holl_buil_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltile_paint_cra_holl_buil_area" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		note_information
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnote_information" runat="server"></asp:Label>
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
		tchunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset14" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset15" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset16" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset17" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset18" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset19" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset20" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltchunset21" runat="server"></asp:Label>
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




