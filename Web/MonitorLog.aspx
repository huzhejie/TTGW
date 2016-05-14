<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="MonitorLog.aspx.cs" Inherits="TTG.Web.MonitorLog" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <link href="Css/indexCss.css" rel="stylesheet" type="text/css" />
    <link href="Css/allinone_thumbnailsBanner.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="examTable" runat="server">
            <div class="examTop fl">

                <img src="Images/wait_to_check_se.png" alt="" />

                <span>监测日志</span>

            </div>
            <div class="longline fl">

            </div>
             <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <ContentTemplate>
                    <table>
                        <thead>
                            <tr>
                                <th>检测日志</th>
                                <th>调查员</th>
                                <th>调查员ID</th>
                                <th>上传日期</th>
                                
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="RepeaterLog" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><a href="ReadOnlyExcel.aspx?officeFile=<%#Eval("file_path").ToString()%>&dcyId=<%#Eval("investigator_id").ToString()%>" target="_blank">
                                            <%#Eval("file_name").ToString()%>
                                        </a></td>                                      
                                        <td><%#toName(Eval("investigator_id").ToString())%></td>
                                        <td><%#Eval("investigator_id").ToString()%></td>
                                        <td><%#DateTime.Parse(Eval("fill_time").ToString()).ToString("yyyy-MM-dd")%></td>

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
