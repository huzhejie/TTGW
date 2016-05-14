<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true"
    CodeBehind="MutipleAnalysis.aspx.cs" Inherits="TTG.Web.MutipleAnalysis" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<link href="Css/bootstrap.min.css" rel="stylesheet" type="text/css" />--%>
    <link href="Css/indexCss.css" rel="stylesheet" type="text/css" />
    <link href="Css/allinone_thumbnailsBanner.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="subdetail">
        <div class="choosecontent">
            <select id="selectvalue" onchange="showdiv()">
                <option selected="selected" value="1">未发布数据</option>
                <option value="2">工作报告</option>
                <option value="3">监测日志</option>
            </select>
        </div>
        <div class="helpcontent" id="helpcontent1" runat="server">
            <div class="examineitem fl">
                <div style="width: 48px; height: 48px; float: left; margin-right: 20px;">
                    <img src="Images/wait_to_check_se.png" alt="" width="100%" height="100%" /></div>
                <span style="margin-top: 5px; font-size: 20px; font-weight: bold;">未发布数据</span>
                <a href="MutipleHasPublish.aspx" style="margin-top: 5px; float: right; color: Blue;
                    font-size: 16px" target="_blank">查看已经发布的数据>></a>
            </div>
            <div class="longline fl">
            </div>
            <div style="width: 100%; height: 650px;" class="m_content fl">
                <div style="width: 100%; float: left; font-weight: bold; font-size: 17px;" class="m_content fl">
                    <div style="float: left; margin-left: 20px; font-size: 17px;">
                        数据表名
                    </div>
                    <div class="dow" style="width: 85px;">
                        填写时间</div>
                    <div class="dow" style="width: 110px;">
                        片区负责人</div>
                    <div class="dow" style="width: 110px;">
                        调查员</div>
                    <div class="dow" style="width: 110px;">
                        小区名</div>
                </div>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="subhelpcontentlist fl">
                            <ul class="downloadList1">
                                <asp:Repeater ID="RepeaterAidInf" runat="server">
                                    <ItemTemplate>
                                        <li>
                                            <div style="float: left; margin-left: 20px;">
                                                <a href="DataExcel.aspx?officeFile=<%#Eval("excel_name").ToString()%>&comId=<%#Eval("community_id").ToString()%>&invesId=<%#Eval("investigator_id").ToString()%>" target="_blank">
                                                    <%#Eval("excel_name").ToString()%>
                                                </a>
                                            </div>
                                            <div class="dow">
                                                <%#DateTime.Parse(Eval("fill_time").ToString()).ToString("yyyy-MM-dd")%></div>
                                            <div class="dow" style="width: 110px;">
                                                <%#toName(Eval("areaChief_id").ToString())%></div>
                                            <div class="dow" style="width: 110px;">
                                                <%#toName(Eval("investigator_id").ToString())%></div>
                                            <div class="dow" style="width: 110px;">
                                                <%#Eval("community_name").ToString()%></div>
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
        <div class="helpcontent" id="helpcontent2" runat="server" style="display: none">
            <div class="examineitem fl">
                <div style="width: 48px; height: 48px; float: left; margin-right: 20px;">
                    <img src="Images/wait_to_check_se.png" alt="" width="100%" height="100%" /></div>
                <span style="margin-top: 5px; font-size: 20px; font-weight: bold;">工作报告</span>
                <div style="margin-top: 5px; float: right;">
                   
                            <span>上传报告：</span>
                            <asp:FileUpload ID="FileUploadBg" runat="server" />
                            <span>请添加文件标题：</span>
                            <asp:TextBox ID="TextBoxBgTitle" runat="server"></asp:TextBox>
                            <asp:Button ID="ButtonBg" runat="server" Text="上传" CssClass="mybtn" onclick="ButtonBg_Click" />
                      
                         <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                          </ContentTemplate>
                        <Triggers>
                            <asp:PostBackTrigger ControlID="ButtonBg" />
                        </Triggers>
                    </asp:UpdatePanel>
                </div>
                <%-- <a href="MutipleHasPublish.aspx" style="margin-top: 5px; float: right; color: Blue;
                    font-size: 16px" target="_blank">查看已经发布的数据>></a>--%>
            </div>
            <div class="longline fl">
            </div>
            <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Always">
                <ContentTemplate>
                    <div style="width: 100%; height: 650px;" class="m_content fl">
                        <div style="width: 100%; float: left; font-weight: bold; font-size: 17px;" class="m_content fl">
                            <div style="float: left; margin-left: 20px; font-size: 17px;">
                                数据表名
                            </div>
                            <div class="dow" style="width: 85px;">
                                填写时间</div>
                            <div class="dow" style="width: 110px;">
                                片区负责人</div>
                            <div class="dow" style="width: 110px;">
                                调查员</div>
                            <div class="dow" style="width: 110px;">
                                小区名</div>
                        </div>
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <div class="subhelpcontentlist fl">
                                    <ul class="downloadList1">
                                        <asp:Repeater ID="Repeater1" runat="server">
                                            <ItemTemplate>
                                                <%--<li>
                                            <div style="float: left; margin-left: 20px;">
                                                   <a href="DataExcel.aspx?officeFile=<%#Eval("excel_name").ToString()%>" target="_blank">
                                                    <%#Eval("excel_name").ToString()%>
                                                </a>
                                            </div>
                                          
                                        <div class="dow">
                                            <%#DateTime.Parse(Eval("fill_time").ToString()).ToString("yyyy-MM-dd")%></div>
                                             <div class="dow" style="width: 110px;">
                                            <%#toName(Eval("areaChief_id").ToString())%></div>
                                        <div class="dow" style="width: 110px;">
                                            <%#toName(Eval("investigator_id").ToString())%></div>
                                        <div class="dow" style="width: 110px;">
                                            <%#Eval("community_name").ToString()%></div>
                                        </li>--%>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                                <webdiyer:AspNetPager ID="AspNetPager2" CssClass="pages fl" CurrentPageButtonClass="cpb"
                                    PagingButtonSpacing="0" runat="server" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                                    PrevPageText="上一页" SubmitButtonText="前往" TextAfterPageIndexBox="页" TextBeforePageIndexBox="到"
                                    SubmitButtonStyle="padding: 0 5px; vertical-align:bottom;border:1px solid  #ddd; ;font-size:14px;color:#000;margin-left:10px;"
                                    OnPageChanged="AspNetPager1_PageChanged" Width="100%" HorizontalAlign="Center">
                                </webdiyer:AspNetPager>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    <div class="helpcontent" id="helpcontent3" runat="server" style="display: none">
        <div class="examineitem fl">
            <div style="width: 48px; height: 48px; float: left; margin-right: 20px;">
                <img src="Images/wait_to_check_se.png" alt="" width="100%" height="100%" /></div>
            <span style="margin-top: 5px; font-size: 20px; font-weight: bold;">监测日志</span>
            <%--  <a href="MutipleHasPublish.aspx" style="margin-top: 5px; float: right; color: Blue;
                    font-size: 16px" target="_blank">查看已经发布的数据>></a>--%>
        </div>
        <div class="longline fl">
        </div>
        <div style="width: 100%; height: 650px;" class="m_content fl">
            <div style="width: 100%; float: left; font-weight: bold; font-size: 17px;" class="m_content fl">
                <div style="float: left; margin-left: 20px; font-size: 17px;">
                    数据表名
                </div>
                <div class="dow" style="width: 85px;">
                    填写时间</div>
                <div class="dow" style="width: 110px;">
                    片区负责人</div>
                <div class="dow" style="width: 110px;">
                    调查员</div>
                <div class="dow" style="width: 110px;">
                    小区名</div>
            </div>
            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <ContentTemplate>
                    <div class="subhelpcontentlist fl">
                        <ul class="downloadList1">
                            <asp:Repeater ID="Repeater2" runat="server">
                                <ItemTemplate>
                                    <%--<li>
                                            <div style="float: left; margin-left: 20px;">
                                                   <a href="DataExcel.aspx?officeFile=<%#Eval("excel_name").ToString()%>" target="_blank">
                                                    <%#Eval("excel_name").ToString()%>
                                                </a>
                                            </div>
                                          
                                        <div class="dow">
                                            <%#DateTime.Parse(Eval("fill_time").ToString()).ToString("yyyy-MM-dd")%></div>
                                             <div class="dow" style="width: 110px;">
                                            <%#toName(Eval("areaChief_id").ToString())%></div>
                                        <div class="dow" style="width: 110px;">
                                            <%#toName(Eval("investigator_id").ToString())%></div>
                                        <div class="dow" style="width: 110px;">
                                            <%#Eval("community_name").ToString()%></div>
                                        </li>--%>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                    <webdiyer:AspNetPager ID="AspNetPager3" CssClass="pages fl" CurrentPageButtonClass="cpb"
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
    <script type="text/javascript">
        function showdiv() {
            var selectObj = document.getElementById("selectvalue");
            var index = selectObj.selectedIndex;
            var num = selectObj.options[index].value - 0;

            if (num == 1) {
                document.getElementById("<%=helpcontent1.ClientID %>").style.display = "block";
                document.getElementById("<%=helpcontent2.ClientID %>").style.display = "none";
                document.getElementById("<%=helpcontent3.ClientID %>").style.display = "none";

            } else if (num == 2) {
                document.getElementById("<%=helpcontent1.ClientID %>").style.display = "none";
                document.getElementById("<%=helpcontent2.ClientID %>").style.display = "block";
                document.getElementById("<%=helpcontent3.ClientID %>").style.display = "none";

            } else if (num == 3) {
                document.getElementById("<%=helpcontent1.ClientID %>").style.display = "none";
                document.getElementById("<%=helpcontent2.ClientID %>").style.display = "none";
                document.getElementById("<%=helpcontent3.ClientID %>").style.display = "block";

            }
        }

        function showdiv2() {
            var selectObj = document.getElementById("selectvalue");
            selectObj.selectedIndex = 1;
            document.getElementById("<%=helpcontent1.ClientID %>").style.display = "none";
            document.getElementById("<%=helpcontent2.ClientID %>").style.display = "block";
            document.getElementById("<%=helpcontent3.ClientID %>").style.display = "none";

        }
    </script>
</asp:Content>
