<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="TTG.Web.TTGWeb.concil_house.Add" Title="增加页" %>

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
		<asp:TextBox id="txtid" runat="server" Width="200px"></asp:TextBox>
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
		building
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbuilding" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		unit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtunit" runat="server" Width="200px"></asp:TextBox>
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
		floor
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfloor" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		house
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txthouse" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		finish_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfinish_time" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gross_floor_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgross_floor_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tiled_wall_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttiled_wall_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		family_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfamily_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pop_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpop_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		slight_deform_cra_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtslight_deform_cra_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		base_subs_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbase_subs_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		dila_buil_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdila_buil_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		stru_safety_prob_fam_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstru_safety_prob_fam_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		slight_deform_cra_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtslight_deform_cra_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		seepage_buil_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtseepage_buil_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		seepage_fam_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtseepage_fam_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		seepage_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtseepage_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tile_paint_cra_holl_buil_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttile_paint_cra_holl_buil_area" runat="server" Width="200px"></asp:TextBox>
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
		<asp:TextBox id="txtstatistics_date" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset15" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset16" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset17" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset18
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset18" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset19
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset19" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset20
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset20" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tchunset21
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttchunset21" runat="server" Width="200px"></asp:TextBox>
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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
