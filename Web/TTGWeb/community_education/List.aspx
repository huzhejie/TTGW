<%@ Page Title="T_community_education" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_education.List" %>
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
		<asp:BoundField DataField="community_edu_inst_num" HeaderText="community_edu_inst_num" SortExpression="community_edu_inst_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_edu_fs" HeaderText="community_edu_fs" SortExpression="community_edu_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_edu_gfa" HeaderText="community_edu_gfa" SortExpression="community_edu_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_kdg_num" HeaderText="community_kdg_num" SortExpression="community_kdg_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_pri_kdg_num" HeaderText="community_pri_kdg_num" SortExpression="community_pri_kdg_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_kdg_fs" HeaderText="community_kdg_fs" SortExpression="community_kdg_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_kdg_gfa" HeaderText="community_kdg_gfa" SortExpression="community_kdg_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_kdg_stu_num" HeaderText="community_kdg_stu_num" SortExpression="community_kdg_stu_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_kdg_class_num" HeaderText="community_kdg_class_num" SortExpression="community_kdg_class_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_kdg_actv_room_area" HeaderText="community_kdg_actv_room_area" SortExpression="community_kdg_actv_room_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_kdg_otd_actv_spa_area" HeaderText="community_kdg_otd_actv_spa_area" SortExpression="community_kdg_otd_actv_spa_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_kdg_greenland_area" HeaderText="community_kdg_greenland_area" SortExpression="community_kdg_greenland_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_kdg_dist_ots" HeaderText="community_kdg_dist_ots" SortExpression="community_kdg_dist_ots" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_prim_school_num" HeaderText="community_prim_school_num" SortExpression="community_prim_school_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_prim_school_gfa" HeaderText="community_prim_school_gfa" SortExpression="community_prim_school_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_prim_school_fs" HeaderText="community_prim_school_fs" SortExpression="community_prim_school_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_prim_school_stu_num" HeaderText="community_prim_school_stu_num" SortExpression="community_prim_school_stu_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_prim_school_class_num" HeaderText="community_prim_school_class_num" SortExpression="community_prim_school_class_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_prim_school_plg_area" HeaderText="community_prim_school_plg_area" SortExpression="community_prim_school_plg_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_prim_school_dist_ots" HeaderText="community_prim_school_dist_ots" SortExpression="community_prim_school_dist_ots" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_mid_school_num" HeaderText="community_mid_school_num" SortExpression="community_mid_school_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_mid_school_gfa" HeaderText="community_mid_school_gfa" SortExpression="community_mid_school_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_mid_school_fs" HeaderText="community_mid_school_fs" SortExpression="community_mid_school_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_mid_school_stu_num" HeaderText="community_mid_school_stu_num" SortExpression="community_mid_school_stu_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_mid_school_class_num" HeaderText="community_mid_school_class_num" SortExpression="community_mid_school_class_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_mid_school_plg_area" HeaderText="community_mid_school_plg_area" SortExpression="community_mid_school_plg_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_mid_school_dist_ots" HeaderText="community_mid_school_dist_ots" SortExpression="community_mid_school_dist_ots" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset1" HeaderText="tceunset1" SortExpression="tceunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset2" HeaderText="tceunset2" SortExpression="tceunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset3" HeaderText="tceunset3" SortExpression="tceunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset4" HeaderText="tceunset4" SortExpression="tceunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset5" HeaderText="tceunset5" SortExpression="tceunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset6" HeaderText="tceunset6" SortExpression="tceunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset7" HeaderText="tceunset7" SortExpression="tceunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset8" HeaderText="tceunset8" SortExpression="tceunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset9" HeaderText="tceunset9" SortExpression="tceunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset10" HeaderText="tceunset10" SortExpression="tceunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset11" HeaderText="tceunset11" SortExpression="tceunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset12" HeaderText="tceunset12" SortExpression="tceunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset13" HeaderText="tceunset13" SortExpression="tceunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset14" HeaderText="tceunset14" SortExpression="tceunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset15" HeaderText="tceunset15" SortExpression="tceunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset16" HeaderText="tceunset16" SortExpression="tceunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset17" HeaderText="tceunset17" SortExpression="tceunset17" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset18" HeaderText="tceunset18" SortExpression="tceunset18" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset19" HeaderText="tceunset19" SortExpression="tceunset19" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset20" HeaderText="tceunset20" SortExpression="tceunset20" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset21" HeaderText="tceunset21" SortExpression="tceunset21" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset22" HeaderText="tceunset22" SortExpression="tceunset22" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset23" HeaderText="tceunset23" SortExpression="tceunset23" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset24" HeaderText="tceunset24" SortExpression="tceunset24" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset25" HeaderText="tceunset25" SortExpression="tceunset25" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset26" HeaderText="tceunset26" SortExpression="tceunset26" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tceunset27" HeaderText="tceunset27" SortExpression="tceunset27" ItemStyle-HorizontalAlign="Center"  /> 
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
