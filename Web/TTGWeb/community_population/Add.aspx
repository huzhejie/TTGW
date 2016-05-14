<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="TTG.Web.TTGWeb.community_population.Add" Title="增加页" %>

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
		<asp:TextBox id="txtcommunity_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_total_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_total_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_reg_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_reg_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_perm_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_perm_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_man_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_man_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_female_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_female_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_younger_6_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_younger_6_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_bet_7_and_15_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_bet_7_and_15_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_bet_16_and_29_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_bet_16_and_29_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_bet_30_and_39_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_bet_30_and_39_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_bet_40_and_49_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_bet_40_and_49_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_older_50_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_older_50_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_illiteracy_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_illiteracy_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_prim_school_edu_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_prim_school_edu_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_junior_high_school_edu_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_junior_high_school_edu_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_senior_high_school_edu_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_senior_high_school_edu_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		community_junior_college_edu_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_junior_college_edu_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		average_education_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtaverage_education_time" runat="server" Width="200px"></asp:TextBox>
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
		tcpunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset13
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset14
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset14" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset15
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset15" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset16
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset16" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tcpunset17
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttcpunset17" runat="server" Width="200px"></asp:TextBox>
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
		community_family_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommunity_family_num" runat="server" Width="200px"></asp:TextBox>
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
