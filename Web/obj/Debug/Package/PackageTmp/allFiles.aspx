<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="allFiles.aspx.cs" Inherits="TTG.Web.allFiles" %>

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
        <div class="upanddelf" id="scf7">
            <p class="myp">
                所有文件
            </p>
            <div class="uploaddiv">
                <asp:FileUpload ID="FileUploadForFile" runat="server" Style="margin-top: 20px;" />
                <asp:DropDownList ID="DropDownListupType" runat="server" Width="140px" Height="20px">
                    <asp:ListItem Selected="True">文件类型</asp:ListItem>
                    <asp:ListItem>小区帮扶标准规范</asp:ListItem>
                    <asp:ListItem>居住环境规程规范</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="uploadFileBtn" runat="server" Text="上传" CssClass="mybtn uploadBtn"
                    OnClick="uploadFileBtn_Click" />
            </div>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="fl" style="margin-top: 20px; margin-left: 37px;">
                        <asp:DropDownList ID="DropDownListFileType" runat="server" Width="140px" Height="20px">
                            <asp:ListItem Selected="True">所有文件</asp:ListItem>
                            <asp:ListItem>小区帮扶标准规范</asp:ListItem>
                            <asp:ListItem>居住环境规程规范</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <asp:Button ID="SearchFileBtn" runat="server" Text="搜索" CssClass="mybtn searchBtn"
                        OnClick="SearchFileBtn_Click" />
                    <div style="margin-top: 13px; width: 100%; height: 420px;" class="fl">
                        <ul>
                            <asp:Repeater ID="Repeaterfile" runat="server" OnItemCommand="Repeaterfile_ItemCommand">
                                <ItemTemplate>
                                    <li>
                                        <div style="float: left;">
                                            <a href="SeeOffice.aspx?officeFile=<%#Eval("file_address").ToString()%>&path=主页可下载文件/+<%#Eval("file_type").ToString()%>" title="<%#Eval("file_name").ToString()%>">
                                                <%#trimanno(Eval("file_name").ToString())%>
                                            </a>
                                        </div>
                                        <div class="dow">
                                            <asp:Button ID="ButtonToDel" runat="server" Text="删除" CommandName="d" CommandArgument='<%#Eval("file_no") %>'
                                                CssClass="sysBtn" />
                                        </div>
                                        <div class="dow">
                                            <%#DateTime.Parse(Eval("time").ToString()).ToString("yyyy-MM-dd")%>
                                        </div>
                                        <div class="dow" style="width: 130px;">
                                            <%#Eval("file_type").ToString()%>
                                        </div>
                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                    <webdiyer:AspNetPager CssClass="pages fl" CurrentPageButtonClass="cpb" PagingButtonSpacing="0"
                        ID="AspNetPager2" OnPageChanged="AspNetPager2_PageChanged" runat="server" RecordCount="2280"
                        FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" SubmitButtonText="前往"
                        TextAfterPageIndexBox="页" TextBeforePageIndexBox="到" SubmitButtonStyle="padding: 0 5px; vertical-align:bottom;border:1px solid  #ddd; ;font-size:14px;color:#000;margin-left:10px;">
                    </webdiyer:AspNetPager>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
