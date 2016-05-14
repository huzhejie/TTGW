<%@ Page Title="T_concil_house" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.concil_house.List" %>
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
                    BorderWidth="1px" DataKeyNames="id,statistics_date" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="id" HeaderText="id" SortExpression="id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community" HeaderText="community" SortExpression="community" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="building" HeaderText="building" SortExpression="building" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="unit" HeaderText="unit" SortExpression="unit" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="structure" HeaderText="structure" SortExpression="structure" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="floor" HeaderText="floor" SortExpression="floor" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="house" HeaderText="house" SortExpression="house" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="finish_time" HeaderText="finish_time" SortExpression="finish_time" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gross_floor_area" HeaderText="gross_floor_area" SortExpression="gross_floor_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tiled_wall_area" HeaderText="tiled_wall_area" SortExpression="tiled_wall_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="family_num" HeaderText="family_num" SortExpression="family_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pop_num" HeaderText="pop_num" SortExpression="pop_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="slight_deform_cra_area" HeaderText="slight_deform_cra_area" SortExpression="slight_deform_cra_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="base_subs_area" HeaderText="base_subs_area" SortExpression="base_subs_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="dila_buil_area" HeaderText="dila_buil_area" SortExpression="dila_buil_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="stru_safety_prob_fam_num" HeaderText="stru_safety_prob_fam_num" SortExpression="stru_safety_prob_fam_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="slight_deform_cra_pop" HeaderText="slight_deform_cra_pop" SortExpression="slight_deform_cra_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="seepage_buil_area" HeaderText="seepage_buil_area" SortExpression="seepage_buil_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="seepage_fam_num" HeaderText="seepage_fam_num" SortExpression="seepage_fam_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="seepage_pop" HeaderText="seepage_pop" SortExpression="seepage_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tile_paint_cra_holl_buil_area" HeaderText="tile_paint_cra_holl_buil_area" SortExpression="tile_paint_cra_holl_buil_area" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="note_information" HeaderText="note_information" SortExpression="note_information" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset1" HeaderText="tchunset1" SortExpression="tchunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset2" HeaderText="tchunset2" SortExpression="tchunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset3" HeaderText="tchunset3" SortExpression="tchunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset4" HeaderText="tchunset4" SortExpression="tchunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset5" HeaderText="tchunset5" SortExpression="tchunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset6" HeaderText="tchunset6" SortExpression="tchunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset7" HeaderText="tchunset7" SortExpression="tchunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset8" HeaderText="tchunset8" SortExpression="tchunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset9" HeaderText="tchunset9" SortExpression="tchunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset10" HeaderText="tchunset10" SortExpression="tchunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset11" HeaderText="tchunset11" SortExpression="tchunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset12" HeaderText="tchunset12" SortExpression="tchunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset13" HeaderText="tchunset13" SortExpression="tchunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset14" HeaderText="tchunset14" SortExpression="tchunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset15" HeaderText="tchunset15" SortExpression="tchunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset16" HeaderText="tchunset16" SortExpression="tchunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset17" HeaderText="tchunset17" SortExpression="tchunset17" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset18" HeaderText="tchunset18" SortExpression="tchunset18" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset19" HeaderText="tchunset19" SortExpression="tchunset19" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset20" HeaderText="tchunset20" SortExpression="tchunset20" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tchunset21" HeaderText="tchunset21" SortExpression="tchunset21" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="id,statistics_date" DataNavigateUrlFormatString="Show.aspx?id0={0}&id1={1}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="id,statistics_date" DataNavigateUrlFormatString="Modify.aspx?id0={0}&id1={1}"
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
