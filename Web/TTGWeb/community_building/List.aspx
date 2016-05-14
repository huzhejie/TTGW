<%@ Page Title="T_community_building" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_building.List" %>
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
		<asp:BoundField DataField="community_building_total_gfa" HeaderText="community_building_total_gfa" SortExpression="community_building_total_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_building_total_fs" HeaderText="community_building_total_fs" SortExpression="community_building_total_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_building_total_num" HeaderText="community_building_total_num" SortExpression="community_building_total_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_house_gfa" HeaderText="community_house_gfa" SortExpression="community_house_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_house_fs" HeaderText="community_house_fs" SortExpression="community_house_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_house_num" HeaderText="community_house_num" SortExpression="community_house_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_edu_gfa" HeaderText="community_edu_gfa" SortExpression="community_edu_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_edu_fs" HeaderText="community_edu_fs" SortExpression="community_edu_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_edu_num" HeaderText="community_edu_num" SortExpression="community_edu_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_medical_gfa" HeaderText="community_medical_gfa" SortExpression="community_medical_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_medical_fs" HeaderText="community_medical_fs" SortExpression="community_medical_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_medical_num" HeaderText="community_medical_num" SortExpression="community_medical_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_culture_sports_gfa" HeaderText="community_culture_sports_gfa" SortExpression="community_culture_sports_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_culture_sports_fs" HeaderText="community_culture_sports_fs" SortExpression="community_culture_sports_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_culture_sports_num" HeaderText="community_culture_sports_num" SortExpression="community_culture_sports_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_service_gfa" HeaderText="community_service_gfa" SortExpression="community_service_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_service_fs" HeaderText="community_service_fs" SortExpression="community_service_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_service_num" HeaderText="community_service_num" SortExpression="community_service_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_other_building_gfa" HeaderText="community_other_building_gfa" SortExpression="community_other_building_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_other_building_fs" HeaderText="community_other_building_fs" SortExpression="community_other_building_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_other_building_num" HeaderText="community_other_building_num" SortExpression="community_other_building_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset1" HeaderText="tcbunset1" SortExpression="tcbunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset2" HeaderText="tcbunset2" SortExpression="tcbunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset3" HeaderText="tcbunset3" SortExpression="tcbunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset4" HeaderText="tcbunset4" SortExpression="tcbunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset5" HeaderText="tcbunset5" SortExpression="tcbunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset6" HeaderText="tcbunset6" SortExpression="tcbunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset7" HeaderText="tcbunset7" SortExpression="tcbunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset8" HeaderText="tcbunset8" SortExpression="tcbunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset9" HeaderText="tcbunset9" SortExpression="tcbunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset10" HeaderText="tcbunset10" SortExpression="tcbunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset11" HeaderText="tcbunset11" SortExpression="tcbunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset12" HeaderText="tcbunset12" SortExpression="tcbunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset13" HeaderText="tcbunset13" SortExpression="tcbunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset14" HeaderText="tcbunset14" SortExpression="tcbunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset15" HeaderText="tcbunset15" SortExpression="tcbunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset16" HeaderText="tcbunset16" SortExpression="tcbunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset17" HeaderText="tcbunset17" SortExpression="tcbunset17" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset18" HeaderText="tcbunset18" SortExpression="tcbunset18" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset19" HeaderText="tcbunset19" SortExpression="tcbunset19" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset20" HeaderText="tcbunset20" SortExpression="tcbunset20" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcbunset21" HeaderText="tcbunset21" SortExpression="tcbunset21" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
