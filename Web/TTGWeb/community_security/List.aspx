<%@ Page Title="T_community_security" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_security.List" %>
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
		<asp:BoundField DataField="community_unit_can_build_guard_room_num" HeaderText="community_unit_can_build_guard_room_num" SortExpression="community_unit_can_build_guard_room_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_unit_with_guard_room_num" HeaderText="community_unit_with_guard_room_num" SortExpression="community_unit_with_guard_room_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_unit_can_install_mf_num" HeaderText="community_unit_can_install_mf_num" SortExpression="community_unit_can_install_mf_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_unit_with_mf_num" HeaderText="community_unit_with_mf_num" SortExpression="community_unit_with_mf_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_unit_can_build_fence_num" HeaderText="community_unit_can_build_fence_num" SortExpression="community_unit_can_build_fence_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_unit_with_fence_num" HeaderText="community_unit_with_fence_num" SortExpression="community_unit_with_fence_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_emergency_shelter_area" HeaderText="community_emergency_shelter_area" SortExpression="community_emergency_shelter_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_civil_air_defence_facilities_num" HeaderText="community_civil_air_defence_facilities_num" SortExpression="community_civil_air_defence_facilities_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_civil_air_defence_facilities_area" HeaderText="community_civil_air_defence_facilities_area" SortExpression="community_civil_air_defence_facilities_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_unit_can_build_gate_num" HeaderText="community_unit_can_build_gate_num" SortExpression="community_unit_can_build_gate_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_with_gate_num" HeaderText="community_with_gate_num" SortExpression="community_with_gate_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsunset1" HeaderText="tcsunset1" SortExpression="tcsunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsunset2" HeaderText="tcsunset2" SortExpression="tcsunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsunset3" HeaderText="tcsunset3" SortExpression="tcsunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsunset4" HeaderText="tcsunset4" SortExpression="tcsunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsunset5" HeaderText="tcsunset5" SortExpression="tcsunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsunset6" HeaderText="tcsunset6" SortExpression="tcsunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsunset7" HeaderText="tcsunset7" SortExpression="tcsunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsunset8" HeaderText="tcsunset8" SortExpression="tcsunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsunset9" HeaderText="tcsunset9" SortExpression="tcsunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsunset10" HeaderText="tcsunset10" SortExpression="tcsunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsunset11" HeaderText="tcsunset11" SortExpression="tcsunset11" ItemStyle-HorizontalAlign="Center"  /> 
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
