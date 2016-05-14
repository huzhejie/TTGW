<%@ Page Title="T_community_management_responsible" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_management_responsible.List" %>
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
                    BorderWidth="1px" DataKeyNames="community_id" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="community_address" HeaderText="community_address" SortExpression="community_address" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_id" HeaderText="community_id" SortExpression="community_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_manage_charge_person_name" HeaderText="community_manage_charge_person_name" SortExpression="community_manage_charge_person_name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_manage_charge_person_telphone" HeaderText="community_manage_charge_person_telphone" SortExpression="community_manage_charge_person_telphone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_monitor_charge_person_name" HeaderText="community_monitor_charge_person_name" SortExpression="community_monitor_charge_person_name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_monitor_charge_person_telphone" HeaderText="community_monitor_charge_person_telphone" SortExpression="community_monitor_charge_person_telphone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_contacts_telephone" HeaderText="community_contacts_telephone" SortExpression="community_contacts_telephone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_staff_telephone" HeaderText="community_staff_telephone" SortExpression="community_staff_telephone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmrunset1" HeaderText="tcmrunset1" SortExpression="tcmrunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmrunset2" HeaderText="tcmrunset2" SortExpression="tcmrunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmrunset3" HeaderText="tcmrunset3" SortExpression="tcmrunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmrunset4" HeaderText="tcmrunset4" SortExpression="tcmrunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmrunset5" HeaderText="tcmrunset5" SortExpression="tcmrunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmrunset6" HeaderText="tcmrunset6" SortExpression="tcmrunset6" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="community_id" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="community_id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
