<%@ Page Title="T_road" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.road.List" %>
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
                    BorderWidth="1px" DataKeyNames="id,statistics_date" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="id" HeaderText="id" SortExpression="id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="name" HeaderText="name" SortExpression="name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community" HeaderText="community" SortExpression="community" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="road_class" HeaderText="road_class" SortExpression="road_class" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="width" HeaderText="width" SortExpression="width" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pavement_width" HeaderText="pavement_width" SortExpression="pavement_width" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_road_length" HeaderText="community_road_length" SortExpression="community_road_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="structure" HeaderText="structure" SortExpression="structure" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="is_dead_end_road" HeaderText="is_dead_end_road" SortExpression="is_dead_end_road" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="damage_road_length" HeaderText="damage_road_length" SortExpression="damage_road_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="large_slope_road_length" HeaderText="large_slope_road_length" SortExpression="large_slope_road_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="no_hard_road_length" HeaderText="no_hard_road_length" SortExpression="no_hard_road_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lack_width_road_length" HeaderText="lack_width_road_length" SortExpression="lack_width_road_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="is_somewhere_no_link" HeaderText="is_somewhere_no_link" SortExpression="is_somewhere_no_link" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="no_afforest_road_length" HeaderText="no_afforest_road_length" SortExpression="no_afforest_road_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="less_afforest_road_length" HeaderText="less_afforest_road_length" SortExpression="less_afforest_road_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="street_light_amount" HeaderText="street_light_amount" SortExpression="street_light_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="good_street_light_amount" HeaderText="good_street_light_amount" SortExpression="good_street_light_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="road_hydrant_amount" HeaderText="road_hydrant_amount" SortExpression="road_hydrant_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="good_road_hydrant_amount" HeaderText="good_road_hydrant_amount" SortExpression="good_road_hydrant_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="road_dustbin_amount" HeaderText="road_dustbin_amount" SortExpression="road_dustbin_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="good_road_dustbin_amount" HeaderText="good_road_dustbin_amount" SortExpression="good_road_dustbin_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="road_parking_space_num" HeaderText="road_parking_space_num" SortExpression="road_parking_space_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="parking_space_use_rate" HeaderText="parking_space_use_rate" SortExpression="parking_space_use_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="note_information" HeaderText="note_information" SortExpression="note_information" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset1" HeaderText="trunset1" SortExpression="trunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset2" HeaderText="trunset2" SortExpression="trunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset3" HeaderText="trunset3" SortExpression="trunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset4" HeaderText="trunset4" SortExpression="trunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset5" HeaderText="trunset5" SortExpression="trunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset6" HeaderText="trunset6" SortExpression="trunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset7" HeaderText="trunset7" SortExpression="trunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset8" HeaderText="trunset8" SortExpression="trunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset9" HeaderText="trunset9" SortExpression="trunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset10" HeaderText="trunset10" SortExpression="trunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset11" HeaderText="trunset11" SortExpression="trunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset12" HeaderText="trunset12" SortExpression="trunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset13" HeaderText="trunset13" SortExpression="trunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset14" HeaderText="trunset14" SortExpression="trunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset15" HeaderText="trunset15" SortExpression="trunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset16" HeaderText="trunset16" SortExpression="trunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset17" HeaderText="trunset17" SortExpression="trunset17" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset18" HeaderText="trunset18" SortExpression="trunset18" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset19" HeaderText="trunset19" SortExpression="trunset19" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset20" HeaderText="trunset20" SortExpression="trunset20" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset21" HeaderText="trunset21" SortExpression="trunset21" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset22" HeaderText="trunset22" SortExpression="trunset22" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset23" HeaderText="trunset23" SortExpression="trunset23" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trunset24" HeaderText="trunset24" SortExpression="trunset24" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="id,statistics_date" DataNavigateUrlFormatString="Show.aspx?id0={0}&id1={1}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="id,statistics_date" DataNavigateUrlFormatString="Modify.aspx?id0={0}&id1={1}"
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
