<%@ Page Title="T_community_elec_supply" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_elec_supply.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="community_id,statistics_date" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="community_id" HeaderText="community_id" SortExpression="community_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_load_dispatching_office_num" HeaderText="community_load_dispatching_office_num" SortExpression="community_load_dispatching_office_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_transformer_num" HeaderText="community_transformer_num" SortExpression="community_transformer_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="below_100kva_transformer_num" HeaderText="below_100kva_transformer_num" SortExpression="below_100kva_transformer_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="at_100_500kva_transformer_num" HeaderText="at_100_500kva_transformer_num" SortExpression="at_100_500kva_transformer_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="at_500_1000kva_transformer_num" HeaderText="at_500_1000kva_transformer_num" SortExpression="at_500_1000kva_transformer_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="more_1000kva_transformer_num" HeaderText="more_1000kva_transformer_num" SortExpression="more_1000kva_transformer_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_elec_supply_wireways_length" HeaderText="community_elec_supply_wireways_length" SortExpression="community_elec_supply_wireways_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_power_transmission_line_length" HeaderText="community_power_transmission_line_length" SortExpression="community_power_transmission_line_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_high_voltage_distr_line_legth" HeaderText="community_high_voltage_distr_line_legth" SortExpression="community_high_voltage_distr_line_legth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_low_voltage_distr_line_legth" HeaderText="community_low_voltage_distr_line_legth" SortExpression="community_low_voltage_distr_line_legth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_elec_supply_consumption" HeaderText="community_elec_supply_consumption" SortExpression="community_elec_supply_consumption" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_resident_elec_consumption" HeaderText="community_resident_elec_consumption" SortExpression="community_resident_elec_consumption" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="no_elec_days" HeaderText="no_elec_days" SortExpression="no_elec_days" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcesunset1" HeaderText="tcesunset1" SortExpression="tcesunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcesunset2" HeaderText="tcesunset2" SortExpression="tcesunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcesunset3" HeaderText="tcesunset3" SortExpression="tcesunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcesunset4" HeaderText="tcesunset4" SortExpression="tcesunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcesunset5" HeaderText="tcesunset5" SortExpression="tcesunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcesunset6" HeaderText="tcesunset6" SortExpression="tcesunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcesunset7" HeaderText="tcesunset7" SortExpression="tcesunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcesunset8" HeaderText="tcesunset8" SortExpression="tcesunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcesunset9" HeaderText="tcesunset9" SortExpression="tcesunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcesunset10" HeaderText="tcesunset10" SortExpression="tcesunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcesunset11" HeaderText="tcesunset11" SortExpression="tcesunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcesunset12" HeaderText="tcesunset12" SortExpression="tcesunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcesunset13" HeaderText="tcesunset13" SortExpression="tcesunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="community_id,statistics_date" DataNavigateUrlFormatString="Show.aspx?id0={0}&id1={1}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="community_id,statistics_date" DataNavigateUrlFormatString="Modify.aspx?id0={0}&id1={1}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
