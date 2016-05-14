<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true"
    CodeBehind="MutipleHasPublish.aspx.cs" Inherits="TTG.Web.MutipleHasPublish" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="examTable">
       
            <div class="examTop fl">
              
                   
                        <img src="Images/wait_to_check_se.png" alt="" />
                    <span>已经发布的数据</span>
                </div>
         <div class="examTop fr">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                       
                            <asp:TextBox ID="TextBoxCom" runat="server" CssClass="manageInput"
                                placeholder="请输入小区名"></asp:TextBox>
                            <asp:TextBox ID="TextBoxInves" runat="server" CssClass="manageInput" placeholder="请输入调查员"></asp:TextBox>
                            <asp:TextBox ID="TextBoxArea" runat="server" CssClass="manageInput"
                                placeholder="请输入片区负责人"></asp:TextBox>
                            <asp:Button ID="btnQueryRig" runat="server" class="mybtn" Text="查询" onclick="btnQueryRig_Click" />
                        
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>

        <div class="longline fl">
        </div>
       
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table>
                        <thead>
                            <tr>
                                <th>数据表名</th>
                                <th>小区名</th>
                                <th>调查员</th>
                                <th>片区负责人</th>
                                <th>填写时间</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="RepeaterAidInf" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><a href="ReadOnlyExcel.aspx?officeFile=<%#Eval("excel_name").ToString()%>&comId=<%#Eval("community_id").ToString()%>&time=<%#DateTime.Parse(Eval("fill_time").ToString()).ToString("yyyy")%>" target="_blank">
                                                <%#Eval("excel_name").ToString()%>
                                            </a></td>
                                        <td><%#Eval("community_name").ToString()%></td>
                                        <td> <%#toName(Eval("investigator_id").ToString())%></td>
                                        <td><%#toName(Eval("areaChief_id").ToString())%></td>
                                        <td> <%#DateTime.Parse(Eval("fill_time").ToString()).ToString("yyyy-MM-dd")%></td>
                                    </tr>
                                   
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                     <div class="fl tc width100">
                    <webdiyer:AspNetPager ID="AspNetPager1" CssClass="pages fl" CurrentPageButtonClass="cpb"
                        PagingButtonSpacing="0" runat="server" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                        PrevPageText="上一页" SubmitButtonText="前往" TextAfterPageIndexBox="页" TextBeforePageIndexBox="到"
                        SubmitButtonStyle="padding: 0 5px; vertical-align:bottom;border:1px solid  #ddd; ;font-size:14px;color:#000;margin-left:10px;"
                        OnPageChanged="AspNetPager1_PageChanged" Width="100%" HorizontalAlign="Center">
                    </webdiyer:AspNetPager>
                         </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    
</asp:Content>
