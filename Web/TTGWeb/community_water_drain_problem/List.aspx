<%@ Page Title="T_community_water_drain_problem" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_water_drain_problem.List" %>
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
                    BorderWidth="1px" DataKeyNames="community_id,community_fill_type,statistics_date" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="community_id" HeaderText="community_id" SortExpression="community_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_fill_type" HeaderText="community_fill_type" SortExpression="community_fill_type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_pipe_no_reasonable_num" HeaderText="community_pipe_no_reasonable_num" SortExpression="community_pipe_no_reasonable_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_form_warea_num" HeaderText="community_form_warea_num" SortExpression="community_form_warea_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_form_warea_affect_res_num" HeaderText="community_form_warea_affect_res_num" SortExpression="community_form_warea_affect_res_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_not_access_uspn_res_num" HeaderText="community_not_access_uspn_res_num" SortExpression="community_not_access_uspn_res_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_not_access_uspn_house_num" HeaderText="community_not_access_uspn_house_num" SortExpression="community_not_access_uspn_house_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_insuf_pipe_size_num" HeaderText="community_insuf_pipe_size_num" SortExpression="community_insuf_pipe_size_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_pipe_aging_corrosion_num" HeaderText="community_pipe_aging_corrosion_num" SortExpression="community_pipe_aging_corrosion_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_pipe_damage_num" HeaderText="community_pipe_damage_num" SortExpression="community_pipe_damage_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_septic_small_volume_num" HeaderText="community_septic_small_volume_num" SortExpression="community_septic_small_volume_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_septic_damage_leaking_num" HeaderText="community_septic_damage_leaking_num" SortExpression="community_septic_damage_leaking_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_sewage_straight_to_cj_num" HeaderText="community_sewage_straight_to_cj_num" SortExpression="community_sewage_straight_to_cj_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_gutter_damage" HeaderText="community_gutter_damage" SortExpression="community_gutter_damage" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_insuf_gutter" HeaderText="community_insuf_gutter" SortExpression="community_insuf_gutter" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset1" HeaderText="tciunset1" SortExpression="tciunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset2" HeaderText="tciunset2" SortExpression="tciunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset3" HeaderText="tciunset3" SortExpression="tciunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset4" HeaderText="tciunset4" SortExpression="tciunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset5" HeaderText="tciunset5" SortExpression="tciunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset6" HeaderText="tciunset6" SortExpression="tciunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset7" HeaderText="tciunset7" SortExpression="tciunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset8" HeaderText="tciunset8" SortExpression="tciunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset9" HeaderText="tciunset9" SortExpression="tciunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset10" HeaderText="tciunset10" SortExpression="tciunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset11" HeaderText="tciunset11" SortExpression="tciunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset12" HeaderText="tciunset12" SortExpression="tciunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset13" HeaderText="tciunset13" SortExpression="tciunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset14" HeaderText="tciunset14" SortExpression="tciunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset15" HeaderText="tciunset15" SortExpression="tciunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tciunset16" HeaderText="tciunset16" SortExpression="tciunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_pipe_damage_length" HeaderText="community_pipe_damage_length" SortExpression="community_pipe_damage_length" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="community_id,community_fill_type,statistics_date" DataNavigateUrlFormatString="Show.aspx?id0={0}&id1={1}&id2={2}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="community_id,community_fill_type,statistics_date" DataNavigateUrlFormatString="Modify.aspx?id0={0}&id1={1}&id2={2}"
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
