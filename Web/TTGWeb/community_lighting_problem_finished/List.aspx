<%@ Page Title="T_community_lighting_problem_finished" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_lighting_problem_finished.List" %>
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
		<asp:BoundField DataField="community_added_otd_road_light_num" HeaderText="community_added_otd_road_light_num" SortExpression="community_added_otd_road_light_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_added_light_road_len" HeaderText="community_added_light_road_len" SortExpression="community_added_light_road_len" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_added_otd_exercise_yard_light_num" HeaderText="community_added_otd_exercise_yard_light_num" SortExpression="community_added_otd_exercise_yard_light_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_repa_passageway_light_num" HeaderText="community_repa_passageway_light_num" SortExpression="community_repa_passageway_light_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_repa_passageway_light_line_len" HeaderText="community_repa_passageway_light_line_len" SortExpression="community_repa_passageway_light_line_len" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_added_passageway_light_num" HeaderText="community_added_passageway_light_num" SortExpression="community_added_passageway_light_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_added_passageway_light_line_len" HeaderText="community_added_passageway_light_line_len" SortExpression="community_added_passageway_light_line_len" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_repa_otd_light_facility_num" HeaderText="community_repa_otd_light_facility_num" SortExpression="community_repa_otd_light_facility_num" ItemStyle-HorizontalAlign="Center"  /> 
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
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_added_otd_road_light_num_f_update" HeaderText="community_added_otd_road_light_num_f_update" SortExpression="community_added_otd_road_light_num_f_update" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_added_light_road_len_f_update" HeaderText="community_added_light_road_len_f_update" SortExpression="community_added_light_road_len_f_update" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_added_passageway_light_num_f_update" HeaderText="community_added_passageway_light_num_f_update" SortExpression="community_added_passageway_light_num_f_update" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_added_passageway_light_line_len_f_update" HeaderText="community_added_passageway_light_line_len_f_update" SortExpression="community_added_passageway_light_line_len_f_update" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
