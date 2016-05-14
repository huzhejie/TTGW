<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="stantardFiles.aspx.cs" Inherits="TTG.Web.stantardFiles" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/common.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="manageLeft">
        <ul>
            <li>公告管理
            </li>
            <li>
                <a href="allAnno.aspx" target="_self">查看所有公告</a>

                <a href="newAnno.aspx" target="_self">发布最新公告</a>

                <a href="allFiles.aspx" target="_self">上传删除文件</a>
            </li>
            <li>用户管理
            </li>
            <li>
                <a href="idEdit.aspx" target="_self">用户账号管理</a>

                <a href="userEdit.aspx" target="_self">用户权限管理</a>
            </li>
            <li>日志管理
            </li>
            <li>
                <a href="loginRecord.aspx" target="_self">登陆日志管理</a>

                <a href="mistakeLog.aspx" target="_self">错误日志管理</a>
            </li>
            <li>其他
            </li>
            <li>
                <a href="stantardFiles.aspx" target="_self">标准表上传</a>

                <a href="createWord.aspx" target="_self">生成word</a>
            </li>
        </ul>

    </div>
    <div class="manageRight">

        <p>
            上传标准表
        </p>
        <div class="fl mt20">

            <asp:FileUpload ID="FileUploadStantard" runat="server" />
            <asp:Button ID="StantardUplBtn" runat="server" Text="上传" CssClass="mybtn"
                OnClick="StantardUplBtn_Click" />
        </div>
        <asp:UpdatePanel ID="UpdatePanel9" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <ul>
                    <asp:Repeater ID="RepeaterStantard" runat="server" OnItemCommand="RepeaterStantard_ItemCommand">
                        <ItemTemplate>
                            <li>

                                <a href="SeeOffice.aspx?officeFile=<%#Eval("table_path").ToString()%>&path=标准表">
                                    <%#Eval("table_name").ToString()%>
                                </a>

                                <asp:Button ID="ButtonToDelStandard" runat="server" Text="删除" CommandName="delStantard" CommandArgument='<%#Eval("table_id") %>'
                                    CssClass="linkBtn dow" />

                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
                <div class="fl tc width100">
                    <webdiyer:AspNetPager CssClass="pages" CurrentPageButtonClass="cpb" PagingButtonSpacing="0"
                        ID="AspNetPager3" OnPageChanged="AspNetPager3_PageChanged" runat="server" RecordCount="2280"
                        FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" SubmitButtonText="前往"
                        TextAfterPageIndexBox="页" TextBeforePageIndexBox="到" SubmitButtonStyle="padding: 0 5px; vertical-align:bottom;border:1px solid  #ddd; ;font-size:14px;color:#000;margin-left:10px;">
                    </webdiyer:AspNetPager>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

    </div>
</asp:Content>
