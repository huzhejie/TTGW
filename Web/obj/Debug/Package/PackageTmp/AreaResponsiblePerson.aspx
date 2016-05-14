<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true"
    CodeBehind="AreaResponsiblePerson.aspx.cs" Inherits="TTG.Web.AreaResponsiblePerson" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Css/indexCss.css" rel="stylesheet" type="text/css" />
    <link href="Css/allinone_thumbnailsBanner.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="subdetail">
        <div class="helpcontent">
            <div class="examineitem fl">
                <div style="width: 48px; height: 48px; float: left; margin-right: 20px;">
                    <img src="Images/wait_to_check_se.png" alt="" width="100%" height="100%" /></div>
                <span style="margin-top: 5px;font-size:19px;font-weight:bold;">未审核数据</span>
                 <a href="AreaHasVerify.aspx" style="margin-top: 5px; float:right;color:Blue;font-size:16px" target="_blank">查看已经审核的数据>></a>
            </div>
            <div class="longline fl">
            </div>
            <div style="width: 100%; height: 650px;" class="m_content fl">
            <div style="width: 100%; ;float:left;font-weight:bold;font-size: 17px;" class="m_content fl">
                    <div style="float: left; margin-left: 20px;font-size: 17px;" >
                        数据表名
                    </div>
                    <div class="dow" style="width: 85px;">
                        填写时间</div>
                    <div class="dow" style="width: 110px; ">
                        调查员</div>
                    <div class="dow" style="width: 110px;">
                        小区名</div>
                        <div class="dow" style="width: 110px;">
                        小区ID</div>
                </div>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="subhelpcontentlist fl">
                            <ul class="downloadList1">
                                <asp:Repeater ID="RepeaterAidInf" runat="server">
                                    <ItemTemplate>
                                        <li>
                                            <div style="float: left; margin-left: 20px;">
                                                  <a href="EvaluateExcel.aspx?officeFile=<%#Eval("excel_name").ToString()%>&comId=<%#Eval("community_id").ToString()%>&invesId=<%#Eval("investigator_id").ToString()%>" target="_blank">
                                                    <%#Eval("excel_name").ToString()%>
                                                </a>
                                            </div>
                                          
                                        <div class="dow">
                                            <%#DateTime.Parse(Eval("fill_time").ToString()).ToString("yyyy-MM-dd")%></div>
                                    <div class="dow" style="width: 110px;">
                                            <%#toName(Eval("investigator_id").ToString())%></div>
                                        <div class="dow" style="width: 110px;">
                                            <%#Eval("community_name").ToString()%></div>
                                             <div class="dow" style="width: 110px;">
                                            <%#Eval("community_id").ToString()%></div>
                                        </li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                        <webdiyer:AspNetPager ID="AspNetPager1" CssClass="pages fl" CurrentPageButtonClass="cpb"
                            PagingButtonSpacing="0" runat="server" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                            PrevPageText="上一页" SubmitButtonText="前往" TextAfterPageIndexBox="页" TextBeforePageIndexBox="到"
                            SubmitButtonStyle="padding: 0 5px; vertical-align:bottom;border:1px solid  #ddd; ;font-size:14px;color:#000;margin-left:10px;"
                            OnPageChanged="AspNetPager1_PageChanged" Width="100%" HorizontalAlign="Center">
                        </webdiyer:AspNetPager>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>
</asp:Content>
