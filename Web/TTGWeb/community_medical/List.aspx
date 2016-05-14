<%@ Page Title="T_community_medical" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TTG.Web.TTGWeb.community_medical.List" %>
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
		<asp:BoundField DataField="community_medical_inst_num" HeaderText="community_medical_inst_num" SortExpression="community_medical_inst_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_medical_inst_fs" HeaderText="community_medical_inst_fs" SortExpression="community_medical_inst_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_medical_inst_gfa" HeaderText="community_medical_inst_gfa" SortExpression="community_medical_inst_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_hospital_num" HeaderText="community_hospital_num" SortExpression="community_hospital_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_hospital_gfa" HeaderText="community_hospital_gfa" SortExpression="community_hospital_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_hospital_fs" HeaderText="community_hospital_fs" SortExpression="community_hospital_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_hospital_bed_num" HeaderText="community_hospital_bed_num" SortExpression="community_hospital_bed_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_hospital_dis_ots" HeaderText="community_hospital_dis_ots" SortExpression="community_hospital_dis_ots" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_heal_sta_num" HeaderText="community_heal_sta_num" SortExpression="community_heal_sta_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_heal_sta_fs" HeaderText="community_heal_sta_fs" SortExpression="community_heal_sta_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_heal_sta_gfa" HeaderText="community_heal_sta_gfa" SortExpression="community_heal_sta_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_heal_sta_bed_num" HeaderText="community_heal_sta_bed_num" SortExpression="community_heal_sta_bed_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_heal_sta_dis_ots" HeaderText="community_heal_sta_dis_ots" SortExpression="community_heal_sta_dis_ots" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_clinic_num" HeaderText="community_clinic_num" SortExpression="community_clinic_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_clinic_fs" HeaderText="community_clinic_fs" SortExpression="community_clinic_fs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_clinic_gfa" HeaderText="community_clinic_gfa" SortExpression="community_clinic_gfa" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_clinic_bed_num" HeaderText="community_clinic_bed_num" SortExpression="community_clinic_bed_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="community_clinic_dis_ots" HeaderText="community_clinic_dis_ots" SortExpression="community_clinic_dis_ots" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="statistics_date" HeaderText="statistics_date" SortExpression="statistics_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset1" HeaderText="tcmunset1" SortExpression="tcmunset1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset2" HeaderText="tcmunset2" SortExpression="tcmunset2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset3" HeaderText="tcmunset3" SortExpression="tcmunset3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset4" HeaderText="tcmunset4" SortExpression="tcmunset4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset5" HeaderText="tcmunset5" SortExpression="tcmunset5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset6" HeaderText="tcmunset6" SortExpression="tcmunset6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset7" HeaderText="tcmunset7" SortExpression="tcmunset7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset8" HeaderText="tcmunset8" SortExpression="tcmunset8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset9" HeaderText="tcmunset9" SortExpression="tcmunset9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset10" HeaderText="tcmunset10" SortExpression="tcmunset10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset11" HeaderText="tcmunset11" SortExpression="tcmunset11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset12" HeaderText="tcmunset12" SortExpression="tcmunset12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset13" HeaderText="tcmunset13" SortExpression="tcmunset13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset14" HeaderText="tcmunset14" SortExpression="tcmunset14" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset15" HeaderText="tcmunset15" SortExpression="tcmunset15" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset16" HeaderText="tcmunset16" SortExpression="tcmunset16" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset17" HeaderText="tcmunset17" SortExpression="tcmunset17" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tcmunset18" HeaderText="tcmunset18" SortExpression="tcmunset18" ItemStyle-HorizontalAlign="Center"  /> 
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
