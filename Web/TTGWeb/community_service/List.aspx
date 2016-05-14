<%@ Page Title="T_community_service" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_service.List" %>
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
		<asp:BoundField DataField="community_comm_serv_fac_fs" HeaderText="community_comm_serv_fac_fs" SortExpression="community_comm_serv_fac_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_comm_serv_fac_gfa" HeaderText="community_comm_serv_fac_gfa" SortExpression="community_comm_serv_fac_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_comm_serv_cen_fs" HeaderText="community_comm_serv_cen_fs" SortExpression="community_comm_serv_cen_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_comm_serv_cen_gfa" HeaderText="community_comm_serv_cen_gfa" SortExpression="community_comm_serv_cen_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_comm_serv_cen_dis_ots" HeaderText="community_comm_serv_cen_dis_ots" SortExpression="community_comm_serv_cen_dis_ots" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_empm_supt_cen_fs" HeaderText="community_empm_supt_cen_fs" SortExpression="community_empm_supt_cen_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_empm_supt_cen_gfa" HeaderText="community_empm_supt_cen_gfa" SortExpression="community_empm_supt_cen_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_empm_supt_cen_dis_ots" HeaderText="community_empm_supt_cen_dis_ots" SortExpression="community_empm_supt_cen_dis_ots" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_police_sta_fs" HeaderText="community_police_sta_fs" SortExpression="community_police_sta_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_police_sta_gfa" HeaderText="community_police_sta_gfa" SortExpression="community_police_sta_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_police_sta_dis_ots" HeaderText="community_police_sta_dis_ots" SortExpression="community_police_sta_dis_ots" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_prop_magm_unit_num" HeaderText="community_prop_magm_unit_num" SortExpression="community_prop_magm_unit_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_no_prop_magm_unit_num" HeaderText="community_no_prop_magm_unit_num" SortExpression="community_no_prop_magm_unit_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsrunset1" HeaderText="tcsrunset1" SortExpression="tcsrunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsrunset2" HeaderText="tcsrunset2" SortExpression="tcsrunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsrunset3" HeaderText="tcsrunset3" SortExpression="tcsrunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsrunset4" HeaderText="tcsrunset4" SortExpression="tcsrunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsrunset5" HeaderText="tcsrunset5" SortExpression="tcsrunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsrunset6" HeaderText="tcsrunset6" SortExpression="tcsrunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsrunset7" HeaderText="tcsrunset7" SortExpression="tcsrunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsrunset8" HeaderText="tcsrunset8" SortExpression="tcsrunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsrunset9" HeaderText="tcsrunset9" SortExpression="tcsrunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsrunset10" HeaderText="tcsrunset10" SortExpression="tcsrunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsrunset11" HeaderText="tcsrunset11" SortExpression="tcsrunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsrunset12" HeaderText="tcsrunset12" SortExpression="tcsrunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcsrunset13" HeaderText="tcsrunset13" SortExpression="tcsrunset13" ItemStyle-HorizontalAlign="Center"  /> 
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
