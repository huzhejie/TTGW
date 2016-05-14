<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Index.aspx.cs" Inherits="TTG.Web.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
   
    <link href="Css/allinone_thumbnailsBanner.css" rel="stylesheet" type="text/css" />
    <link href="Css/homepiccss.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery-ui.min.js" type="text/javascript"></script>
    <script src="Scripts/allinone_thumbnailsBanner.js" type="text/javascript"></script>
    <script src="JS/homepicjquery.js" type="text/javascript"></script>
    <script src="JS/homepicjs.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $(".area").hover(function () {
                $(this).find(".qq").show(100);
            }
	  , function () {
	      $(this).find(".qq").hide(100);
	  });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="detailspecial" style="margin-top: 20px; height: 410px;">
        <div class="helpcontent clearfix">
            <div class="infleft fl">
                <div class="area">
                    <a id="prev" class="prevBtn qq" href="javascript:void(0)"></a><a id="next" class="nextBtn qq"
                        href="javascript:void(0)"></a>
                    <div id="js" class="js">
                        <div class="box01">
                            <img src="Images/threeGorges0.jpg" alt=""  height="100%" />
                            <img style="display: none" src="Images/threeGorges1.jpg" alt=""  height="100%" />
                            <img style="display: none" src="Images/threeGorges2.jpg" alt=""  height="100%" />
                            <img style="display: none" src="Images/threeGorges3.jpg" alt=""  height="100%" />
                            <img style="display: none" src="Images/threeGorges4.jpg" alt=""  height="100%" />
                        </div>
                        <div class="bg">
                        </div>
                        <div id="jsNav" class="jsNav">
                            <a class="trigger imgSelected" href="javascript:void(0)">1</a>
                            <a class="trigger" href="javascript:void(0)">2</a>
                            <a class="trigger" href="javascript:void(0)">3</a>
                            <a class="trigger" href="javascript:void(0)">4</a>
                            <a class="trigger" href="javascript:void(0)">5</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="infright fl" style="width:480px;margin-left:32px;">
                <p class="hometitle">
                    最新监测信息</p>
                <p class="moretitle" style="width: 100%">
                    New Monitoring Information
                   <%-- <a style="float: right; margin-right: 20px" href="SingleListxc.aspx" target="_blank"><span style="margin-right: 7px;">更多</span>
                        <img src="Images/more.png" alt="" style="width: 13px; height: 13px;" /></a>--%>
                </p>
                <div class="shortline fl">
                </div>
                <div class="listm fl">
                    <ul class="downloadList1">
                        <asp:Repeater ID="RepeaterNew" runat="server">
                            <ItemTemplate>
                                <li class="clearfix" style="height:32px;">
                                    <div style="float: left;">
                                        <a href="Announce.aspx?nfid=<%#Eval("nf_id").ToString()%>" target="_blank">
                                            <%#trimanno(Eval("nf_title").ToString())%>
                                        </a>
                                    </div>
                                    <div class="dow">
                                        <%#Eval("date").ToString()%>

                                    </div>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div class="detail">
        <div class="helpinf">
            <div class="infleft fl">
                <%--<div class="item fl">--%>
                <p class="hometitle">
                    现场监测动态</p>
                <p class="moretitle" style="width: 100%">
                    Dynamic Monitoring Information<a style="float: right; margin-right: 20px" href="SingleListxc.aspx" target="_blank"><span style="margin-right: 7px;">更多</span>
                        <img src="Images/more.png" alt="" style="width: 13px; height: 13px;" /></a>
                </p>
                <div class="shortline fl">
                </div>
                <div class="listm fl">
                    <ul class="downloadList1">
                        <asp:Repeater ID="RepeaterFielddetection" runat="server">
                            <ItemTemplate>
                                <li>
                                    <div style="float: left;">
                                        <a href="Announce.aspx?nfid=<%#Eval("nf_id").ToString()%>" target="_blank">
                                            <%#trimanno(Eval("nf_title").ToString())%>
                                        </a>
                                    </div>
                                    <div class="dow">
                                        <%#Eval("date").ToString()%></div>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
            <div class="infright fl">
                <p class="hometitle">
                    综合帮扶信息</p>
                <p class="moretitle" style="width: 100%">
                    Integrated Support Information <a style="float: right; margin-right: 20px" href="SingleListbf.aspx" target="_blank"><span
                        style="margin-right: 7px;">更多</span>
                        <img src="Images/more.png" alt="" style="width: 13px; height: 13px;" /></a>
                </p>
                <div class="shortline fl">
                </div>
                <div class="listm fl ">
                    <ul class="downloadList1">
                        <asp:Repeater ID="RepeaterAidInf" runat="server">
                            <ItemTemplate>
                                <li>
                                    <div style="float: left;">
                                        <a href="Announce.aspx?nfid=<%#Eval("nf_id").ToString()%>" target="_blank">
                                            <%#trimanno(Eval("nf_title").ToString())%>
                                        </a>
                                    </div>
                                    <div class="dow">
                                        <%#Eval("date").ToString()%></div>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div class="detail">
        <div class="helpinf">
            <div class="infleft fl">
                <p class="hometitle">
                    小区帮扶标准规范</p>
                <p class="moretitle" style="width: 100%">
                    Community Support Regulations<a style="float: right; margin-right: 20px" href="SingleListxq.aspx" target="_blank"><span style="margin-right: 7px;">更多</span>
                        <img src="Images/more.png" alt="" style="width: 13px; height: 13px;" /></a></p>
                <div class="shortline fl">
                </div>
                <div class="listm fl">
                    <ul class="downloadList1">
                        <asp:Repeater ID="RepeaterAidStandard" runat="server" OnItemCommand="RepeaterAidStandard_ItemCommand">
                            <ItemTemplate>
                                <li>
                                    <div style="float: left;">
                                        <%#trimanno(Eval("file_name").ToString())%>
                                    </div>
                                    <div class="dow">
                                        <asp:ImageButton ID="ImageButtonForRas" runat="server" ImageUrl="Images/download.png"
                                            CommandName="d" CommandArgument='<%#Eval("file_address") %>' /></div>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
            <div class="infright fl">
                <p class="hometitle">
                    居住环境规程规范</p>
                <p class="moretitle" style="width: 100%">
                    Living Enviroment Regulations<a style="float: right; margin-right: 20px" href="SingleListjz.aspx" target="_blank"><span style="margin-right: 7px;">更多</span>
                        <img src="Images/more.png" alt="" style="width: 13px; height: 13px;" /></a></p>
                <div class="shortline fl">
                </div>
                <div class="listm fl">
                    <ul class="downloadList1">
                        <asp:Repeater ID="RepeaterLiveCondition" runat="server" OnItemCommand="RepeaterLiveCondition_ItemCommand">
                            <ItemTemplate>
                                <li>
                                    <div style="float: left;">
                                        <%#Eval("file_name").ToString()%>
                                    </div>
                                    <div class="dow">
                                        <asp:ImageButton ID="ImageButtonForRas" runat="server" ImageUrl="Images/download.png"
                                            CommandName="d" CommandArgument='<%#Eval("file_address") %>' /></div>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div class="detailspecial">
        <div class="helpcontent">
            <p class="hometitle">
                区县培训及就业信息</p>
            <p class="moretitle" style="width: 100%">
                Training And Recruitment<a style="float: right; margin-right: 20px" target="_blank" href="SingleListqx.aspx"><span style="margin-right: 7px;">更多</span>
                    <img src="Images/more.png" alt="" style="width: 13px; height: 13px;" /></a></p>
            <div class="longline fl">
            </div>
            <div class="helpcontentlist fl">
                <ul class="downloadList1">
                    <asp:Repeater ID="RepeaterTrainingRecruitment" runat="server">
                        <ItemTemplate>
                            <li>
                                <div style="float: left;">
                                    <a href="Announce.aspx?nfid=<%#Eval("nf_id").ToString()%>" target="_blank">
                                        <%#trimanno(Eval("nf_title").ToString())%>
                                    </a>
                                </div>
                                <div class="dow">
                                    <%#Eval("date").ToString()%></div>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>
