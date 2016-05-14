<%@ Page Title="T_kindergarten" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.kindergarten.List" %>
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
                    BorderWidth="1px" DataKeyNames="name,community,statistics_date" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="name" HeaderText="name" SortExpression="name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community" HeaderText="community" SortExpression="community" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="type" HeaderText="type" SortExpression="type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="floor_space" HeaderText="floor_space" SortExpression="floor_space" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gross_floor_area" HeaderText="gross_floor_area" SortExpression="gross_floor_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="students_amount" HeaderText="students_amount" SortExpression="students_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="teachers_amount" HeaderText="teachers_amount" SortExpression="teachers_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="class_amount" HeaderText="class_amount" SortExpression="class_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="teachers_students_rate" HeaderText="teachers_students_rate" SortExpression="teachers_students_rate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="activity_room_area" HeaderText="activity_room_area" SortExpression="activity_room_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="activity_room_area_if_suff" HeaderText="activity_room_area_if_suff" SortExpression="activity_room_area_if_suff" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="otds_activity_room_area" HeaderText="otds_activity_room_area" SortExpression="otds_activity_room_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="otds_activity_room_area_if_suff" HeaderText="otds_activity_room_area_if_suff" SortExpression="otds_activity_room_area_if_suff" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="afforest_area" HeaderText="afforest_area" SortExpression="afforest_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="afforest_area_if_suff" HeaderText="afforest_area_if_suff" SortExpression="afforest_area_if_suff" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="school_bus_amount" HeaderText="school_bus_amount" SortExpression="school_bus_amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pick_up_students_amount_daily" HeaderText="pick_up_students_amount_daily" SortExpression="pick_up_students_amount_daily" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="note_information" HeaderText="note_information" SortExpression="note_information" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset1" HeaderText="tkunset1" SortExpression="tkunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset2" HeaderText="tkunset2" SortExpression="tkunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset3" HeaderText="tkunset3" SortExpression="tkunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset4" HeaderText="tkunset4" SortExpression="tkunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset5" HeaderText="tkunset5" SortExpression="tkunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset6" HeaderText="tkunset6" SortExpression="tkunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset7" HeaderText="tkunset7" SortExpression="tkunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset8" HeaderText="tkunset8" SortExpression="tkunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset9" HeaderText="tkunset9" SortExpression="tkunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset10" HeaderText="tkunset10" SortExpression="tkunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset11" HeaderText="tkunset11" SortExpression="tkunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset12" HeaderText="tkunset12" SortExpression="tkunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset13" HeaderText="tkunset13" SortExpression="tkunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset14" HeaderText="tkunset14" SortExpression="tkunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset15" HeaderText="tkunset15" SortExpression="tkunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset16" HeaderText="tkunset16" SortExpression="tkunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tkunset17" HeaderText="tkunset17" SortExpression="tkunset17" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="name,community,statistics_date" DataNavigateUrlFormatString="Show.aspx?id0={0}&id1={1}&id2={2}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="name,community,statistics_date" DataNavigateUrlFormatString="Modify.aspx?id0={0}&id1={1}&id2={2}"
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
