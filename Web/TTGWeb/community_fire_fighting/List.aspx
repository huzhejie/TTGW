<%@ Page Title="T_community_fire_fighting" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_fire_fighting.List" %>
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
		<asp:BoundField DataField="community_extinguisher_num" HeaderText="community_extinguisher_num" SortExpression="community_extinguisher_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_good_extinguisher_rate" HeaderText="community_good_extinguisher_rate" SortExpression="community_good_extinguisher_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_hydrant_num" HeaderText="community_hydrant_num" SortExpression="community_hydrant_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_ots_hydrant_num" HeaderText="community_ots_hydrant_num" SortExpression="community_ots_hydrant_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_good_ots_hydrant_rate" HeaderText="community_good_ots_hydrant_rate" SortExpression="community_good_ots_hydrant_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_ind_hydrant_num" HeaderText="community_ind_hydrant_num" SortExpression="community_ind_hydrant_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_good_ind_hydrant_rate" HeaderText="community_good_ind_hydrant_rate" SortExpression="community_good_ind_hydrant_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_ff_pipe_length" HeaderText="community_ff_pipe_length" SortExpression="community_ff_pipe_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_ff_pipe_caliber_larger_than_100mm_length" HeaderText="community_ff_pipe_caliber_larger_than_100mm_length" SortExpression="community_ff_pipe_caliber_larger_than_100mm_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_ff_pipe_caliber_less_than_100mm_length" HeaderText="community_ff_pipe_caliber_less_than_100mm_length" SortExpression="community_ff_pipe_caliber_less_than_100mm_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="source_of_ff_water_num" HeaderText="source_of_ff_water_num" SortExpression="source_of_ff_water_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="natural_ff_water_source_num" HeaderText="natural_ff_water_source_num" SortExpression="natural_ff_water_source_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="municipal_administration_pipe_net_ff_water_source" HeaderText="municipal_administration_pipe_net_ff_water_source" SortExpression="municipal_administration_pipe_net_ff_water_source" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ff_water_pool_num" HeaderText="ff_water_pool_num" SortExpression="ff_water_pool_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcffunset1" HeaderText="tcffunset1" SortExpression="tcffunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcffunset2" HeaderText="tcffunset2" SortExpression="tcffunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcffunset3" HeaderText="tcffunset3" SortExpression="tcffunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcffunset4" HeaderText="tcffunset4" SortExpression="tcffunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcffunset5" HeaderText="tcffunset5" SortExpression="tcffunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcffunset6" HeaderText="tcffunset6" SortExpression="tcffunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcffunset7" HeaderText="tcffunset7" SortExpression="tcffunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcffunset8" HeaderText="tcffunset8" SortExpression="tcffunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcffunset9" HeaderText="tcffunset9" SortExpression="tcffunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcffunset10" HeaderText="tcffunset10" SortExpression="tcffunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcffunset11" HeaderText="tcffunset11" SortExpression="tcffunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcffunset12" HeaderText="tcffunset12" SortExpression="tcffunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcffunset13" HeaderText="tcffunset13" SortExpression="tcffunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcffunset14" HeaderText="tcffunset14" SortExpression="tcffunset14" ItemStyle-HorizontalAlign="Center"  /> 
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
