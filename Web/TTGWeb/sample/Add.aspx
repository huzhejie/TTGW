<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="TTG.Web.TTGWeb.sample.Add" Title="增加页" %>

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
		sample_house_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsample_house_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sample_family_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsample_family_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sample_labor_force_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsample_labor_force_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sample_employment_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsample_employment_lf_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sample_primary_industry_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsample_primary_industry_lf_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sample_secondary_industry_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsample_secondary_industry_lf_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sample_tertiary_industry_lf_pop
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsample_tertiary_industry_lf_pop" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sample_PCDI
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsample_PCDI" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sample_wages_income
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsample_wages_income" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sample_family_run_pure_income
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsample_family_run_pure_income" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sample_property_income
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsample_property_income" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sample_transfer_income
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsample_transfer_income" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sample_CONSP
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsample_CONSP" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tsunset1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttsunset1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tsunset2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttsunset2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tsunset3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttsunset3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tsunset4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttsunset4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tsunset5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttsunset5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tsunset6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttsunset6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tsunset7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttsunset7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tsunset8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttsunset8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tsunset9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttsunset9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tsunset10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttsunset10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tsunset11
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttsunset11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tsunset12
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttsunset12" runat="server" Width="200px"></asp:TextBox>
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
		<asp:TextBox id="txtstatistics_date" runat="server" Width="200px"></asp:TextBox>
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
