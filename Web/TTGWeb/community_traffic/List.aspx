<%@ Page Title="T_community_traffic" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_traffic.List" %>
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
		<asp:BoundField DataField="community_passenger_station_num" HeaderText="community_passenger_station_num" SortExpression="community_passenger_station_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_station_waiting_room_area" HeaderText="community_station_waiting_room_area" SortExpression="community_station_waiting_room_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_station_parking_lot_area" HeaderText="community_station_parking_lot_area" SortExpression="community_station_parking_lot_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_bus_trips" HeaderText="community_bus_trips" SortExpression="community_bus_trips" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_quay_num" HeaderText="community_quay_num" SortExpression="community_quay_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_passenger_and_goods_quay_num" HeaderText="community_passenger_and_goods_quay_num" SortExpression="community_passenger_and_goods_quay_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_goods_quay_num" HeaderText="community_goods_quay_num" SortExpression="community_goods_quay_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_passenger_quay_num" HeaderText="community_passenger_quay_num" SortExpression="community_passenger_quay_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_docking_point" HeaderText="community_docking_point" SortExpression="community_docking_point" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_passenger_quay_waiting_room_area" HeaderText="community_passenger_quay_waiting_room_area" SortExpression="community_passenger_quay_waiting_room_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_passenger_quay_parking_lot_area" HeaderText="community_passenger_quay_parking_lot_area" SortExpression="community_passenger_quay_parking_lot_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_passenger_quay_ship_trips" HeaderText="community_passenger_quay_ship_trips" SortExpression="community_passenger_quay_ship_trips" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_passenger_quay_dis_to_county" HeaderText="community_passenger_quay_dis_to_county" SortExpression="community_passenger_quay_dis_to_county" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tctunset1" HeaderText="tctunset1" SortExpression="tctunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tctunset2" HeaderText="tctunset2" SortExpression="tctunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tctunset3" HeaderText="tctunset3" SortExpression="tctunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tctunset4" HeaderText="tctunset4" SortExpression="tctunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tctunset5" HeaderText="tctunset5" SortExpression="tctunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tctunset6" HeaderText="tctunset6" SortExpression="tctunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tctunset7" HeaderText="tctunset7" SortExpression="tctunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tctunset8" HeaderText="tctunset8" SortExpression="tctunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tctunset9" HeaderText="tctunset9" SortExpression="tctunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tctunset10" HeaderText="tctunset10" SortExpression="tctunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tctunset11" HeaderText="tctunset11" SortExpression="tctunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tctunset12" HeaderText="tctunset12" SortExpression="tctunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tctunset13" HeaderText="tctunset13" SortExpression="tctunset13" ItemStyle-HorizontalAlign="Center"  /> 
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
