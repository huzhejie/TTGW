<%@ Page Title="T_community_environmental_hygiene" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_environmental_hygiene.List" %>
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
		<asp:BoundField DataField="community_refuse_transfer_station_num" HeaderText="community_refuse_transfer_station_num" SortExpression="community_refuse_transfer_station_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_refuse_transfer_station_dis_ots" HeaderText="community_refuse_transfer_station_dis_ots" SortExpression="community_refuse_transfer_station_dis_ots" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_refuse_collection_point_num" HeaderText="community_refuse_collection_point_num" SortExpression="community_refuse_collection_point_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_dustbin_num" HeaderText="community_dustbin_num" SortExpression="community_dustbin_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="rubbish_produce_amount" HeaderText="rubbish_produce_amount" SortExpression="rubbish_produce_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="live_rubbish_produce_year_amount" HeaderText="live_rubbish_produce_year_amount" SortExpression="live_rubbish_produce_year_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="solid_rubbish_produce_amount" HeaderText="solid_rubbish_produce_amount" SortExpression="solid_rubbish_produce_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="environmental_fee_charge_amount" HeaderText="environmental_fee_charge_amount" SortExpression="environmental_fee_charge_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_public_toilet_num" HeaderText="community_public_toilet_num" SortExpression="community_public_toilet_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_public_toilet_space_num" HeaderText="community_public_toilet_space_num" SortExpression="community_public_toilet_space_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_public_toilet_inside_300m_num" HeaderText="community_public_toilet_inside_300m_num" SortExpression="community_public_toilet_inside_300m_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_public_toilet_cover_road_length" HeaderText="community_public_toilet_cover_road_length" SortExpression="community_public_toilet_cover_road_length" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcehunset1" HeaderText="tcehunset1" SortExpression="tcehunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcehunset2" HeaderText="tcehunset2" SortExpression="tcehunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcehunset3" HeaderText="tcehunset3" SortExpression="tcehunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcehunset4" HeaderText="tcehunset4" SortExpression="tcehunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcehunset5" HeaderText="tcehunset5" SortExpression="tcehunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcehunset6" HeaderText="tcehunset6" SortExpression="tcehunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcehunset7" HeaderText="tcehunset7" SortExpression="tcehunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcehunset8" HeaderText="tcehunset8" SortExpression="tcehunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcehunset9" HeaderText="tcehunset9" SortExpression="tcehunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcehunset10" HeaderText="tcehunset10" SortExpression="tcehunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcehunset11" HeaderText="tcehunset11" SortExpression="tcehunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_public_toilet_area_num" HeaderText="community_public_toilet_area_num" SortExpression="community_public_toilet_area_num" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
