<%@ Page Title="" Language="C#" MasterPageFile="~/Subpage.Master" AutoEventWireup="true"
    CodeBehind="SingleListqx.aspx.cs" Inherits="TTG.Web.SingleListqx" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/indexCss.css" rel="stylesheet" type="text/css" />
    <link href="Css/allinone_thumbnailsBanner.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery-ui.min.js" type="text/javascript"></script>
    <script src="Scripts/allinone_thumbnailsBanner.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="subdetail">
        <div class="helpcontent">
            <div class="item fl">
                区县培训及就业信息</div>
            <div class="longline fl">
            </div>
            <div style="width: 100%" class="m_content fl">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="subhelpcontentlist fl">
                            <ul class="downloadList1">
                                <asp:Repeater ID="RepeaterTrainingRecruitment" runat="server">
                                    <ItemTemplate>
                                         <li>
                                            <div style="float: left;margin-left:20px;">
                                                <a href="Announce.aspx?nfid=<%#Eval("nf_id").ToString()%>">
                                                    <%#trimanno(Eval("nf_title").ToString())%>
                                                </a>
                                            </div>
                                            <div class="dow">
                                                <%#DateTime.Parse(Eval("nf_time").ToString()).ToString("yyyy-MM-dd")%></div>
                                        </li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                        <%--     <div class="contentleft fl">
                 <ul class="downloadList1" >           
                                <li>
                                    <div style="float:left;"><a href="Announce.aspx">湖北省三峡办调研夷移民小区综合帮扶工作 </a> </div>             <div class="dow" >2015-6-8</div>
                                </li>
                                <li>
                                    <div style="float:left;"><a href="Announce.aspx">三峡库区城镇移民小区综合帮扶工作交流会在... </a> </div>             <div class="dow" >2015-6-7</div>
                                </li>
                                <li>
                                   <div style="float:left;"><a href="Announce.aspx">[三峡工委]关注库区重点民生问题 推动移民小区...</a> </div>             <div class="dow" >2015-6-6</div>
                                </li>
                                <li>
                                   <div style="float:left;"><a href="Announce.aspx">国务院三峡办调研重大项目和小区帮扶项目申报... </a> </div>             <div class="dow" >2015-6-5</div>
                                </li>
                                <li>
                                   <div style="float:left;"><a href="Announce.aspx">国务院三峡办调研“三县”三峡后续工作重大项目... </a> </div>             <div class="dow" >2015-6-4</div>
                                </li>
                                <li>
                                    <div style="float:left;"><a href="Announce.aspx">国务院三峡办调研库区城镇移民帮扶工作</a> </div>            <div class="dow" >2015-6-3</div>
                                </li>
                                <li>
                                    <div style="float:left;"><a href="Announce.aspx">湖北省三峡办调研夷移民小区综合帮扶工作 </a> </div>             <div class="dow" >2015-6-8</div>
                                </li>
                                <li>
                                    <div style="float:left;"><a href="Announce.aspx">三峡库区城镇移民小区综合帮扶工作交流会在... </a> </div>             <div class="dow" >2015-6-7</div>
                                </li>
                                <li>
                                   <div style="float:left;"><a href="Announce.aspx">[三峡工委]关注库区重点民生问题 推动移民小区...</a> </div>             <div class="dow" >2015-6-6</div>
                                </li>
                                <li>
                                   <div style="float:left;"><a href="Announce.aspx">国务院三峡办调研重大项目和小区帮扶项目申报... </a> </div>             <div class="dow" >2015-6-5</div>
                                </li>
                                <li>
                                   <div style="float:left;"><a href="Announce.aspx">国务院三峡办调研“三县”三峡后续工作重大项目... </a> </div>             <div class="dow" >2015-6-4</div>
                                </li>
                                <li>
                                    <div style="float:left;"><a href="Announce.aspx">国务院三峡办调研库区城镇移民帮扶工作</a> </div>            <div class="dow" >2015-6-3</div>
                                </li>

                            </ul>
                           
            </div>
            <div class="contentright fl">
                      <ul class="downloadList1" >             
                                <li>
                                    <div style="float:left;"><a href="Announce.aspx">湖北省三峡办调研夷移民小区综合帮扶工作 </a> </div>             <div class="dow" >2015-6-8</div>
                                </li>
                                <li>
                                    <div style="float:left;"><a href="Announce.aspx">三峡库区城镇移民小区综合帮扶工作交流会在... </a> </div>             <div class="dow" >2015-6-7</div>
                                </li>
                                <li>
                                   <div style="float:left;"><a href="Announce.aspx">[三峡工委]关注库区重点民生问题 推动移民小区...</a> </div>             <div class="dow" >2015-6-6</div>
                                </li>
                                <li>
                                   <div style="float:left;"><a href="Announce.aspx">国务院三峡办调研重大项目和小区帮扶项目申报... </a> </div>             <div class="dow" >2015-6-5</div>
                                </li>
                                <li>
                                   <div style="float:left;"><a href="Announce.aspx">国务院三峡办调研“三县”三峡后续工作重大项目... </a> </div>             <div class="dow" >2015-6-4</div>
                                </li>
                                <li>
                                    <div style="float:left;"><a href="Announce.aspx">国务院三峡办调研库区城镇移民帮扶工作</a> </div>            <div class="dow" >2015-6-3</div>
                                </li>
                                <li>
                                    <div style="float:left;"><a href="Announce.aspx">湖北省三峡办调研夷移民小区综合帮扶工作 </a> </div>             <div class="dow" >2015-6-8</div>
                                </li>
                                <li>
                                    <div style="float:left;"><a href="Announce.aspx">三峡库区城镇移民小区综合帮扶工作交流会在... </a> </div>             <div class="dow" >2015-6-7</div>
                                </li>
                                <li>
                                   <div style="float:left;"><a href="Announce.aspx">[三峡工委]关注库区重点民生问题 推动移民小区...</a> </div>             <div class="dow" >2015-6-6</div>
                                </li>
                                <li>
                                   <div style="float:left;"><a href="Announce.aspx">国务院三峡办调研重大项目和小区帮扶项目申报... </a> </div>             <div class="dow" >2015-6-5</div>
                                </li>
                                <li>
                                   <div style="float:left;"><a href="Announce.aspx">国务院三峡办调研“三县”三峡后续工作重大项目... </a> </div>             <div class="dow" >2015-6-4</div>
                                </li>
                                <li>
                                    <div style="float:left;"><a href="Announce.aspx">国务院三峡办调研库区城镇移民帮扶工作</a> </div>            <div class="dow" >2015-6-3</div>
                                </li>

                            </ul>
            </div>
                        --%>
                        <webdiyer:AspNetPager ID="AspNetPager1" OnPageChanged="AspNetPager1_PageChanged"
                            CssClass="pages fl" CurrentPageButtonClass="cpb" PagingButtonSpacing="0" runat="server"
                            RecordCount="2280" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" Width="100%" HorizontalAlign="Center"
                            SubmitButtonText="前往" TextAfterPageIndexBox="页" TextBeforePageIndexBox="到" SubmitButtonStyle="padding: 0 5px; vertical-align:bottom;border:1px solid  #ddd; ;font-size:14px;color:#000;margin-left:10px;">
                        </webdiyer:AspNetPager>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>
</asp:Content>
