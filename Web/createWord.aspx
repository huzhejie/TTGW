<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="createWord.aspx.cs" Inherits="TTG.Web.createWord" %>


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
            生成word
        </p>
        <div>
        </div>
    </div>
   
</asp:Content>
