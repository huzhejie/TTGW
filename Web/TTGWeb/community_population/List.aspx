<%@ Page Title="T_community_population" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_population.List" %>
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
		<asp:BoundField DataField="community_total_pop" HeaderText="community_total_pop" SortExpression="community_total_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_reg_pop" HeaderText="community_reg_pop" SortExpression="community_reg_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_perm_pop" HeaderText="community_perm_pop" SortExpression="community_perm_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_man_pop" HeaderText="community_man_pop" SortExpression="community_man_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_female_pop" HeaderText="community_female_pop" SortExpression="community_female_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_younger_6_pop" HeaderText="community_younger_6_pop" SortExpression="community_younger_6_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_bet_7_and_15_pop" HeaderText="community_bet_7_and_15_pop" SortExpression="community_bet_7_and_15_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_bet_16_and_29_pop" HeaderText="community_bet_16_and_29_pop" SortExpression="community_bet_16_and_29_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_bet_30_and_39_pop" HeaderText="community_bet_30_and_39_pop" SortExpression="community_bet_30_and_39_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_bet_40_and_49_pop" HeaderText="community_bet_40_and_49_pop" SortExpression="community_bet_40_and_49_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_older_50_pop" HeaderText="community_older_50_pop" SortExpression="community_older_50_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_illiteracy_pop" HeaderText="community_illiteracy_pop" SortExpression="community_illiteracy_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_prim_school_edu_pop" HeaderText="community_prim_school_edu_pop" SortExpression="community_prim_school_edu_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_junior_high_school_edu_pop" HeaderText="community_junior_high_school_edu_pop" SortExpression="community_junior_high_school_edu_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_senior_high_school_edu_pop" HeaderText="community_senior_high_school_edu_pop" SortExpression="community_senior_high_school_edu_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_junior_college_edu_pop" HeaderText="community_junior_college_edu_pop" SortExpression="community_junior_college_edu_pop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="average_education_time" HeaderText="average_education_time" SortExpression="average_education_time" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset1" HeaderText="tcpunset1" SortExpression="tcpunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset2" HeaderText="tcpunset2" SortExpression="tcpunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset3" HeaderText="tcpunset3" SortExpression="tcpunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset4" HeaderText="tcpunset4" SortExpression="tcpunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset5" HeaderText="tcpunset5" SortExpression="tcpunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset6" HeaderText="tcpunset6" SortExpression="tcpunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset7" HeaderText="tcpunset7" SortExpression="tcpunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset8" HeaderText="tcpunset8" SortExpression="tcpunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset10" HeaderText="tcpunset10" SortExpression="tcpunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset11" HeaderText="tcpunset11" SortExpression="tcpunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset12" HeaderText="tcpunset12" SortExpression="tcpunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset13" HeaderText="tcpunset13" SortExpression="tcpunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset14" HeaderText="tcpunset14" SortExpression="tcpunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset15" HeaderText="tcpunset15" SortExpression="tcpunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset16" HeaderText="tcpunset16" SortExpression="tcpunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcpunset17" HeaderText="tcpunset17" SortExpression="tcpunset17" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="check_status" HeaderText="check_status" SortExpression="check_status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lock_tables" HeaderText="lock_tables" SortExpression="lock_tables" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_family_num" HeaderText="community_family_num" SortExpression="community_family_num" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
