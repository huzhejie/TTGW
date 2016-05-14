﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="loginRecord.aspx.cs" Inherits="TTG.Web.loginRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script src="./JS/laydate.js" type="text/javascript"></script>
    <link href="Css/common.css" rel="stylesheet" type="text/css"/>
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
    <div class="loginrecord" id="scf5">
            <p class="myp">
                登录日志
            </p>
            <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div style="width: 100%; margin-top: 40px;">
                        <asp:GridView ID="GridViewLoginLog" runat="server" EnableModelValidation="True" CssClass="GridViewStyle"
                            AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="loginLog_id" OnRowDataBound="loginLog_RowDataBound">
                            <Columns>
                                <asp:TemplateField>
                                    <HeaderTemplate>
                                        <asp:CheckBox ID="chkAllLog" runat="server" AutoPostBack="True" OnCheckedChanged="chkAllLog_CheckedChanged" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="chkCheckLog" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="30px" />
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="序号" HeaderStyle-Width="50px" ItemStyle-Width="50px">
                                    <HeaderStyle Width="50px"></HeaderStyle>
                                    <ItemStyle Width="50px"></ItemStyle>
                                </asp:BoundField>
                                <asp:BoundField DataField="loginLog_id" HeaderText="loginLog_id" InsertVisible="False"
                                    ReadOnly="True" SortExpression="loginLog_id" ItemStyle-Width="98px" ItemStyle-Height="35px" />
                                <asp:BoundField DataField="createTime" HeaderText="createTime" SortExpression="createTime"
                                    ItemStyle-Width="146px" ItemStyle-Height="35px" />
                                <asp:BoundField DataField="loginLogLevel" HeaderText="loginLogLevel" SortExpression="loginLogLevel"
                                    ItemStyle-Width="118px" ItemStyle-Height="35px" />
                                <asp:BoundField DataField="loginLogMessage" HeaderText="loginLogMessage" SortExpression="loginLogMessage"
                                    ItemStyle-Width="343px" ItemStyle-Height="35px" />
                            </Columns>
                            <PagerTemplate>
                                <div>
                                    <asp:LinkButton ID="btnFirst" runat="server" CssClass="link" CommandName="Pager"
                                        CommandArgument="First" OnCommand="NavigateToPageLog">首页</asp:LinkButton>&nbsp;
                                    <asp:LinkButton ID="btnPrev" runat="server" CssClass="link" CommandName="Pager" CommandArgument="Prev"
                                        OnCommand="NavigateToPageLog">前一页</asp:LinkButton>&nbsp;
                                    <asp:LinkButton ID="btnNext" runat="server" CssClass="link" CommandName="Pager" CommandArgument="Next"
                                        OnCommand="NavigateToPageLog">下一页</asp:LinkButton>&nbsp;
                                    <asp:LinkButton ID="btnLast" runat="server" CssClass="link" CommandName="Pager" CommandArgument="Last"
                                        OnCommand="NavigateToPageLog">尾页</asp:LinkButton>&nbsp;&nbsp;
                                </div>
                            </PagerTemplate>
                            <FooterStyle CssClass="FooterStyle" />
                            <RowStyle CssClass="RowStyle" />
                            <EmptyDataRowStyle CssClass="EmptyRowStyle" />
                            <PagerStyle CssClass="PagerStyle" />
                            <SelectedRowStyle CssClass="SelectedRowStyle" />
                            <HeaderStyle CssClass="HeaderStyle" />
                            <EditRowStyle CssClass="EditRowStyle" />
                            <AlternatingRowStyle CssClass="AltRowStyle" />
                        </asp:GridView>
                        <div style="text-align: right; margin-top: 10px;">
                            <asp:Button ID="Button1" runat="server" class="mybtn" Text="删除日志" OnClick="lbDeleteLog_Click"
                                Style="height: 24px; line-height: 24px; width: 60px;" />
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        </div>
</asp:Content>
