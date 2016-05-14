<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="allAnno.aspx.cs" Inherits="TTG.Web.allAnno" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script src="./JS/laydate.js" type="text/javascript"></script>
    <link href="Css/common.css" rel="stylesheet" type="text/css" />
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wel">
        <p>
            欢迎您，管理员！
        </p>
    </div>
    <div class="s_contentleft fl">
        <div class="s_lititle">
            <p>
                公告管理
            </p>
        </div>
        <div class="s_li">
            <div class="selects_li">
                <p>
                    <a href="allAnno.aspx" target="_self">查看所有公告</a>
                </p>
            </div>
            <div style="height: 2px; background-color: #fff; width: 100%;">
            </div>
            <div class="selects_li">
                <p>
                    
                    <a href="newAnno.aspx" target="_self">发布最新公告</a>
                </p>
            </div>
            <div style="height: 2px; background-color: #fff; width: 100%;">
            </div>
            <div class="selects_li">
                <p>
                    
                    <a href="allFiles.aspx" target="_self">上传删除文件</a>
                </p>
            </div>
        </div>
        <div class="s_lititle">
            <p>
                用户管理
            </p>
        </div>
        <div class="s_li">
            <div class="selects_li">
                <p>
                    
                    <a href="idEdit.aspx" target="_self">用户账号管理</a>
                </p>
            </div>
            <div style="height: 2px; background-color: #fff; width: 100%;">
            </div>
            <div class="selects_li">
                <p>
                    
                    <a href="userEdit.aspx" target="_self">用户权限管理</a>
                </p>
            </div>
        </div>
        <div class="s_lititle">
            <p>
                日志管理
            </p>
        </div>
        <div class="s_li">
            <div class="selects_li">
                <p>
                    
                    <a href="loginRecord.aspx" target="_self">登陆日志管理</a>
                </p>
            </div>
            <div style="height: 2px; background-color: #fff; width: 100%;">
            </div>
            <div class="selects_li">
                <p>
                    
                    <a href="mistakeLog.aspx" target="_self">错误日志管理</a>
                </p>
            </div>
        </div>
        <div class="s_lititle">
            <p>
                其他
            </p>
        </div>
        <div class="s_li">
            <div class="selects_li">
                <p>
                    
                    <a href="stantardFiles.aspx" target="_self">标准表上传</a>
                </p>
            </div>
            <div style="height: 2px; background-color: #fff; width: 100%;">
            </div>
            <div class="selects_li">
                <p>
                    
                    <a href="createWord.aspx" target="_self">生成word</a>
                </p>
            </div>
        </div>
    </div>
    <div class="s_contentright fl">
        <div class="allanno" id="scf1">
            <p class="myp">
                所有公告
            </p>
            <div class="fl scf1head">
                <div class="fl">
                    <asp:DropDownList ID="DropDownListType" runat="server" Width="140px" Height="24px">
                        <asp:ListItem Selected="True">所有公告</asp:ListItem>
                        <asp:ListItem>综合帮扶信息</asp:ListItem>
                        <asp:ListItem>现场检测动态</asp:ListItem>
                        <asp:ListItem>区县培训及就业信息</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="fl" style="margin-left: 30px;">
                    <asp:DropDownList ID="DropDownListPublisher" runat="server" Width="140px" Height="24px">
                    </asp:DropDownList>
                </div>
                <div class="fl" style="margin-left: 30px;">
                    <input class="laydate-icon" id="demo" />
                    <input id="demoTime" runat="server" style="display: none;" />
                </div>
            </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Button ID="Search" runat="server" Text="搜索" CssClass="mybtn syssearch" OnClick="Search_Click" />
                    <div style="margin-top: 10px; width: 100%; height: 420px;" class="fl">
                        <ul>
                            <asp:Repeater ID="RepeaterInf" runat="server" OnItemCommand="RepeaterInf_ItemCommand">
                                <ItemTemplate>
                                    <li>
                                        <div style="float: left;">
                                            <a href="Announce.aspx?nfid=<%#Eval("nf_id").ToString()%>" title="<%#Eval("nf_title").ToString()%>" target="_blank">
                                                <%#trimanno(Eval("nf_title").ToString())%>
                                            </a>
                                        </div>
                                        <div class="dow">
                                            <a href="EditAnnounce.aspx?nfid=<%#Eval("nf_id").ToString()%>" target="_blank">编辑</a>
                                        </div>
                                        <div class="dow">
                                            <asp:Button ID="ButtonToDel" runat="server" Text="删除" CommandName="d" CommandArgument='<%#Eval("nf_id") %>'
                                                CssClass="sysBtn" />
                                        </div>
                                        <div class="dow">
                                            <%#DateTime.Parse(Eval("nf_time").ToString()).ToString("yyyy-MM-dd")%>
                                        </div>
                                        <div class="dow" style="width: 110px;">
                                            <span title="<%#Eval("nf_type").ToString()%>"><%#trimanno6(Eval("nf_type").ToString())%></span>
                                        </div>
                                        <div class="dow">
                                            <%#Eval("nf_depart").ToString()%>
                                        </div>
                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                    <webdiyer:AspNetPager CssClass="pages fl" CurrentPageButtonClass="cpb" PagingButtonSpacing="0"
                        ID="AspNetPager1" OnPageChanged="AspNetPager1_PageChanged" runat="server" RecordCount="2280"
                        FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" SubmitButtonText="前往"
                        TextAfterPageIndexBox="页" TextBeforePageIndexBox="到" SubmitButtonStyle="padding: 0 5px; vertical-align:bottom;border:1px solid  #ddd; ;font-size:14px;color:#000;margin-left:10px;">
                    </webdiyer:AspNetPager>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        </div>
    <script type="text/javascript">
       
            function deliver() {
                var Tvalue = document.getElementById("demo").value;
                var hideinput = document.getElementById("<%=demoTime.ClientID%>");
                hideinput.value = Tvalue;
            }

      
        !function () {
            laydate.skin('molv'); //切换皮肤，请查看skins下面皮肤库
            laydate({ elem: '#demo' }); //绑定元素
        }();
 
        </script>
</asp:Content>
