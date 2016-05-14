<%@ Page Title="T_community_culture_sports" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_culture_sports.List" %>
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
		<asp:BoundField DataField="community_culture_sports_fs" HeaderText="community_culture_sports_fs" SortExpression="community_culture_sports_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_culture_sports_gfa" HeaderText="community_culture_sports_gfa" SortExpression="community_culture_sports_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_otd_cul_spo_fac_num" HeaderText="community_otd_cul_spo_fac_num" SortExpression="community_otd_cul_spo_fac_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_otd_cul_spo_fac_gfa" HeaderText="community_otd_cul_spo_fac_gfa" SortExpression="community_otd_cul_spo_fac_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_cul_squ_num" HeaderText="community_cul_squ_num" SortExpression="community_cul_squ_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_cul_squ_fs" HeaderText="community_cul_squ_fs" SortExpression="community_cul_squ_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_otd_entm_num" HeaderText="community_otd_entm_num" SortExpression="community_otd_entm_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_otd_entm_fs" HeaderText="community_otd_entm_fs" SortExpression="community_otd_entm_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_child_plg_num" HeaderText="community_child_plg_num" SortExpression="community_child_plg_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_child_plg_fs" HeaderText="community_child_plg_fs" SortExpression="community_child_plg_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_ind_actv_spa_num" HeaderText="community_ind_actv_spa_num" SortExpression="community_ind_actv_spa_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_ind_actv_spa_fs" HeaderText="community_ind_actv_spa_fs" SortExpression="community_ind_actv_spa_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_ind_actv_spa_gfa" HeaderText="community_ind_actv_spa_gfa" SortExpression="community_ind_actv_spa_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_cul_sta_num" HeaderText="community_cul_sta_num" SortExpression="community_cul_sta_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_cul_sta_fs" HeaderText="community_cul_sta_fs" SortExpression="community_cul_sta_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_cul_sta_gfa" HeaderText="community_cul_sta_gfa" SortExpression="community_cul_sta_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_cul_room_num" HeaderText="community_cul_room_num" SortExpression="community_cul_room_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_cul_room_fs" HeaderText="community_cul_room_fs" SortExpression="community_cul_room_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_cul_room_gfa" HeaderText="community_cul_room_gfa" SortExpression="community_cul_room_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_fit_fac_num" HeaderText="community_fit_fac_num" SortExpression="community_fit_fac_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_fit_fac_intact_rate" HeaderText="community_fit_fac_intact_rate" SortExpression="community_fit_fac_intact_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset1" HeaderText="tccsunset1" SortExpression="tccsunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset2" HeaderText="tccsunset2" SortExpression="tccsunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset3" HeaderText="tccsunset3" SortExpression="tccsunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset4" HeaderText="tccsunset4" SortExpression="tccsunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset5" HeaderText="tccsunset5" SortExpression="tccsunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset6" HeaderText="tccsunset6" SortExpression="tccsunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset7" HeaderText="tccsunset7" SortExpression="tccsunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset8" HeaderText="tccsunset8" SortExpression="tccsunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset9" HeaderText="tccsunset9" SortExpression="tccsunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset10" HeaderText="tccsunset10" SortExpression="tccsunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset11" HeaderText="tccsunset11" SortExpression="tccsunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset12" HeaderText="tccsunset12" SortExpression="tccsunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset13" HeaderText="tccsunset13" SortExpression="tccsunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset14" HeaderText="tccsunset14" SortExpression="tccsunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset15" HeaderText="tccsunset15" SortExpression="tccsunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset16" HeaderText="tccsunset16" SortExpression="tccsunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset17" HeaderText="tccsunset17" SortExpression="tccsunset17" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset18" HeaderText="tccsunset18" SortExpression="tccsunset18" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset19" HeaderText="tccsunset19" SortExpression="tccsunset19" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset20" HeaderText="tccsunset20" SortExpression="tccsunset20" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tccsunset21" HeaderText="tccsunset21" SortExpression="tccsunset21" ItemStyle-HorizontalAlign="Center"  /> 
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
