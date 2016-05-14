<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="allAnno.aspx.cs" Inherits="TTG.Web.allAnno" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script src="JS/laydate.js" type="text/javascript"></script>
    <link href="Css/common.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <div class="manageLeft">
        <ul>
            <li>
                公告管理
            </li>
            <li>
                <a href="allAnno.aspx" target="_self">查看所有公告</a>
            
                <a href="newAnno.aspx" target="_self">发布最新公告</a>
            
                <a href="allFiles.aspx" target="_self">上传删除文件</a>
            </li>
            <li>
                用户管理
            </li>
            <li>
                <a href="idEdit.aspx" target="_self">用户账号管理</a>
            
                <a href="userEdit.aspx" target="_self">用户权限管理</a>
            </li>
            <li>
                日志管理
            </li>
            <li>
                <a href="loginRecord.aspx" target="_self">登陆日志管理</a>
           
                <a href="mistakeLog.aspx" target="_self">错误日志管理</a>
            </li>
            <li>
                其他
            </li>
            <li>
                <a href="stantardFiles.aspx" target="_self">标准表上传</a>
           
                <a href="createWord.aspx" target="_self">生成word</a>
            </li>
        </ul>
              
    </div>
    <div class="manageRight">
        <p>
            所有公告
        </p>
        <div class="fl mt20">

            <asp:DropDownList ID="DropDownListType" runat="server" CssClass="manageSelect">
                <asp:ListItem Selected="True">所有公告</asp:ListItem>
                <asp:ListItem>综合帮扶信息</asp:ListItem>
                <asp:ListItem>现场监测动态</asp:ListItem>
                <asp:ListItem>区县培训及就业信息</asp:ListItem>
            </asp:DropDownList>

            <asp:DropDownList ID="DropDownListPublisher" runat="server" CssClass="manageSelect mf20">
            </asp:DropDownList>

            <input class="laydate-icon manageTimer" id="demo"/>
            <input id="demoTime" runat="server" class="dn"/>

        </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Button ID="Search" runat="server" Text="搜索" CssClass="mybtn manageBtn mt20" OnClick="Search_Click" />
                
                    <ul>
                        <asp:Repeater ID="RepeaterInf" runat="server" OnItemCommand="RepeaterInf_ItemCommand">
                            <ItemTemplate>
                                <li>                                 
                                        <a href="Announce.aspx?nfid=<%#Eval("nf_id").ToString()%>" title="<%#Eval("nf_title").ToString()%>" target="_blank">
                                            <%#trimanno(Eval("nf_title").ToString())%>
                                        </a>                                  
                                        <a class="dow"  style="margin-right:0px" href="EditAnnounce.aspx?nfid=<%#Eval("nf_id").ToString()%>" target="_blank">编辑</a>                        
                                        <asp:Button ID="ButtonToDel" runat="server" Text="删除" CommandName="d" CommandArgument='<%#Eval("nf_id") %>'
                                            CssClass="linkBtn dow" />
                                        <span class="dow"><%#DateTime.Parse(Eval("nf_time").ToString()).ToString("yyyy-MM-dd")%></span>
                                        <span class="dow" title="<%#Eval("nf_type").ToString()%>"> <%#trimanno6(Eval("nf_type").ToString())%> </span>
                                        <span class="dow"><%#Eval("nf_depart").ToString()%></span>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                
                <div class="fl tc width100">
                <webdiyer:AspNetPager CssClass="pages" CurrentPageButtonClass="cpb" PagingButtonSpacing="0"
                    ID="AspNetPager1" OnPageChanged="AspNetPager1_PageChanged" runat="server" RecordCount="2280"
                    FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" SubmitButtonText="前往"
                    TextAfterPageIndexBox="页" TextBeforePageIndexBox="到" SubmitButtonStyle="padding: 0 5px; vertical-align:bottom;border:1px solid  #ddd; ;font-size:14px;color:#000;margin-left:10px;">
                </webdiyer:AspNetPager>
                    </div>
            </ContentTemplate>
        </asp:UpdatePanel>

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
