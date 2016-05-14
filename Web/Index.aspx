<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Index.aspx.cs" Inherits="TTG.Web.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <title>主页</title>
    <link href="Css/common.css" rel="stylesheet" />
    <!--用于轮播图的css，js 可能会引起冲突-->
    <link href="Css/homepiccss.css" rel="stylesheet" type="text/css" />
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
    <!--用于轮播图的css，js 可能会引起冲突-->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="detail clearfix">
        <div class="width50 fl">
            <!--轮播图内容-->
            <div class="area">
                <a id="prev" class="prevBtn qq" href="javascript:void(0)"></a><a id="next" class="nextBtn qq"
                    href="javascript:void(0)"></a>
                <div id="js" class="js">
                    <div class="box01">
                        <img src="Images/threeGorges0.jpg" alt="" height="100%" />
                        <img style="display: none" src="Images/threeGorges1.jpg" alt="" height="100%" />
                        <img style="display: none" src="Images/threeGorges2.jpg" alt="" height="100%" />
                        <img style="display: none" src="Images/threeGorges3.jpg" alt="" height="100%" />
                        <img style="display: none" src="Images/threeGorges4.jpg" alt="" height="100%" />
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
            <!--轮播图内容结束-->
        </div>
        <div class="width50 fl">
            <p class="homeTitle">
                最新监测信息
            </p>
            <p class="enTitle">
                New Monitoring Information                  
            </p>
            <div class="shortline">
            </div>

            <ul>
                <asp:Repeater ID="RepeaterNew" runat="server">
                    <ItemTemplate>
                        <li class="clearfix height30">
                            <div class="fl">
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
    <div class="detail clearfix">
        <div class="width50 fl">
            <p class="homeTitle">
                现场监测动态
            </p>
            <p class="enTitle">
                Dynamic Monitoring Information<a style="float: right; margin-right: 20px" href="SingleListxc.aspx" target="_blank"><span style="margin-right: 7px;">更多</span>
                    <img src="Images/more.png" alt="" style="width: 13px; height: 13px;" /></a>
            </p>
            <div class="shortline">
            </div>
            <ul>
                <asp:Repeater ID="RepeaterFielddetection" runat="server">
                    <ItemTemplate>
                        <li>
                            <div class="fl">
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
        <div class="width50 fl">
            <p class="homeTitle">
                综合帮扶信息
            </p>
            <p class="enTitle">
                Integrated Support Information <a style="float: right; margin-right: 20px" href="SingleListbf.aspx" target="_blank"><span
                    style="margin-right: 7px;">更多</span>
                    <img src="Images/more.png" alt="" style="width: 13px; height: 13px;" /></a>
            </p>
            <div class="shortline">
            </div>

            <ul>
                <asp:Repeater ID="RepeaterAidInf" runat="server">
                    <ItemTemplate>
                        <li>
                            <div class="fl">
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
    <div class="detail clearfix">
        <div class="width50 fl">
            <p class="homeTitle">
                小区帮扶标准规范
            </p>
            <p class="enTitle">
                Community Support Regulations<a style="float: right; margin-right: 20px" href="SingleListxq.aspx" target="_blank"><span style="margin-right: 7px;">更多</span>
                    <img src="Images/more.png" alt="" style="width: 13px; height: 13px;" /></a>
            </p>
            <div class="shortline">
            </div>
            <ul>
                <asp:Repeater ID="RepeaterAidStandard" runat="server" OnItemCommand="RepeaterAidStandard_ItemCommand">
                    <ItemTemplate>
                        <li>
                            <div class="fl">
                                <%#trimanno(Eval("file_name").ToString())%>
                            </div>
                            <div class="dow">
                                <asp:ImageButton ID="ImageButtonForRas" runat="server" ImageUrl="Images/download.png"
                                    CommandName="d" CommandArgument='<%#Eval("file_address") %>' />
                            </div>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
        <div class="width50 fl">
            <p class="homeTitle">
                居住环境规程规范
            </p>
            <p class="enTitle">
                Living Enviroment Regulations<a style="float: right; margin-right: 20px" href="SingleListjz.aspx" target="_blank"><span style="margin-right: 7px;">更多</span>
                    <img src="Images/more.png" alt="" style="width: 13px; height: 13px;" /></a>
            </p>
            <div class="shortline">
            </div>

            <ul>
                <asp:Repeater ID="RepeaterLiveCondition" runat="server" OnItemCommand="RepeaterLiveCondition_ItemCommand">
                    <ItemTemplate>
                        <li>
                            <div class="fl">
                                <%#Eval("file_name").ToString()%>
                            </div>
                            <div class="dow">
                                <asp:ImageButton ID="ImageButtonForRas" runat="server" ImageUrl="Images/download.png"
                                    CommandName="d" CommandArgument='<%#Eval("file_address") %>' />
                            </div>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>

        </div>

    </div>
    <div class="detail clearfix">

        <p class="homeTitle">
            区县培训及就业信息
        </p>
        <p class="enTitle">
            Training And Recruitment<a style="float: right; margin-right: 20px" target="_blank" href="SingleListqx.aspx"><span style="margin-right: 7px;">更多</span>
                <img src="Images/more.png" alt="" style="width: 13px; height: 13px;" /></a>
        </p>
        <div class="longline fl">
        </div>
        <ul>
            <asp:Repeater ID="RepeaterTrainingRecruitment" runat="server">
                <ItemTemplate>
                    <li class="width50 fl">
                        <div class="fl">
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
</asp:Content>
