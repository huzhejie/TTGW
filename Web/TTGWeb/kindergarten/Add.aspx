<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="TTG.Web.TTGWeb.kindergarten.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		name
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtname" runat="server" Width="200px"></asp:TextBox>
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
		type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttype" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		floor_space
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfloor_space" runat="server" Width="200px"></asp:TextBox>
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
		students_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstudents_amount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		teachers_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtteachers_amount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		class_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtclass_amount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		teachers_students_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtteachers_students_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		activity_room_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtactivity_room_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		activity_room_area_if_suff
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtactivity_room_area_if_suff" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		otds_activity_room_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtotds_activity_room_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		otds_activity_room_area_if_suff
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtotds_activity_room_area_if_suff" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		afforest_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtafforest_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		afforest_area_if_suff
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtafforest_area_if_suff" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		school_bus_amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtschool_bus_amount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pick_up_students_amount_daily
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpick_up_students_amount_daily" runat="server" Width="200px"></asp:TextBox>
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
		tkunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset15" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset16" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tkunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttkunset17" runat="server" Width="200px"></asp:TextBox>
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
