<%@ Page Title="T_community_water_drain" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_water_drain.List" %>
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
		<asp:BoundField DataField="community_water_drain_mechanism" HeaderText="community_water_drain_mechanism" SortExpression="community_water_drain_mechanism" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_domestic_sewage_consumption" HeaderText="community_domestic_sewage_consumption" SortExpression="community_domestic_sewage_consumption" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_water_drain_pipe_length" HeaderText="community_water_drain_pipe_length" SortExpression="community_water_drain_pipe_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_water_drain_main_pipe_length" HeaderText="community_water_drain_main_pipe_length" SortExpression="community_water_drain_main_pipe_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_water_drain_pipe_branch_length" HeaderText="community_water_drain_pipe_branch_length" SortExpression="community_water_drain_pipe_branch_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_water_drain_service_pipe_length" HeaderText="community_water_drain_service_pipe_length" SortExpression="community_water_drain_service_pipe_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_water_drain_canal_length" HeaderText="community_water_drain_canal_length" SortExpression="community_water_drain_canal_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_water_open_drain_canal_length" HeaderText="community_water_open_drain_canal_length" SortExpression="community_water_open_drain_canal_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_septic_tank_num" HeaderText="community_septic_tank_num" SortExpression="community_septic_tank_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_septic_tank_capacity" HeaderText="community_septic_tank_capacity" SortExpression="community_septic_tank_capacity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcwdunset1" HeaderText="tcwdunset1" SortExpression="tcwdunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcwdunset2" HeaderText="tcwdunset2" SortExpression="tcwdunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcwdunset3" HeaderText="tcwdunset3" SortExpression="tcwdunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcwdunset4" HeaderText="tcwdunset4" SortExpression="tcwdunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcwdunset5" HeaderText="tcwdunset5" SortExpression="tcwdunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcwdunset6" HeaderText="tcwdunset6" SortExpression="tcwdunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcwdunset7" HeaderText="tcwdunset7" SortExpression="tcwdunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcwdunset8" HeaderText="tcwdunset8" SortExpression="tcwdunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcwdunset9" HeaderText="tcwdunset9" SortExpression="tcwdunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcwdunset10" HeaderText="tcwdunset10" SortExpression="tcwdunset10" ItemStyle-HorizontalAlign="Center"  /> 
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
