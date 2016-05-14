<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="mistakeLog.aspx.cs" Inherits="TTG.Web.mistakeLog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script src="./JS/laydate.js" type="text/javascript"></script>
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
                错误日志
            </p>
            <div class="tc mt50">
                <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:GridView ID="GridViewErrLog" runat="server" AutoGenerateColumns="False" PageSize="7"
                            CssClass="GridViewStyle" DataKeyNames="errorLog_id" EnableModelValidation="True"
                            OnRowDataBound="errorLog_RowDataBound" AllowPaging="True">
                            <Columns>
                                <asp:TemplateField>
                                    <HeaderTemplate>
                                        <asp:CheckBox ID="chkAllErr" runat="server" AutoPostBack="True" OnCheckedChanged="chkAllErr_CheckedChanged" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="chkCheckErr" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="14px" />
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="序号" HeaderStyle-Width="17px" ItemStyle-Width="17px"></asp:BoundField>
                                <asp:BoundField DataField="errorLog_id" HeaderText="errorLog_id" InsertVisible="False"
                                    ItemStyle-Width="84px" ItemStyle-Height="49px" ReadOnly="True" SortExpression="errorLog_id" />
                                <asp:BoundField DataField="createTime" HeaderText="createTime" SortExpression="createTime"
                                    ItemStyle-Width="78px" ItemStyle-Height="49px" />
                                <asp:BoundField DataField="errorLogOrigin" HeaderText="errorLogOrigin" SortExpression="errorLogOrigin"
                                    ItemStyle-Width="252px" ItemStyle-Height="49px" />
                                <asp:BoundField DataField="errorLogMessage" HeaderText="errorLogMessage" SortExpression="errorLogMessage"
                                    ItemStyle-Width="124px" ItemStyle-Height="49px" />
                                <asp:BoundField DataField="stackTrace" HeaderText="stackTrace" SortExpression="stackTrace"
                                    ItemStyle-Width="265px" ItemStyle-Height="49px" />
                            </Columns>
                            <PagerTemplate>
                                <div>
                                    <asp:LinkButton ID="btnFirst" runat="server" CssClass="link" CommandName="Pager"
                                        CommandArgument="First" OnCommand="NavigateToPageErr">首页</asp:LinkButton>&nbsp;
                                    <asp:LinkButton ID="btnPrev" runat="server" CssClass="link" CommandName="Pager" CommandArgument="Prev"
                                        OnCommand="NavigateToPageErr">前一页</asp:LinkButton>&nbsp;
                                    <asp:LinkButton ID="btnNext" runat="server" CssClass="link" CommandName="Pager" CommandArgument="Next"
                                        OnCommand="NavigateToPageErr">下一页</asp:LinkButton>&nbsp;
                                    <asp:LinkButton ID="btnLast" runat="server" CssClass="link" CommandName="Pager" CommandArgument="Last"
                                        OnCommand="NavigateToPageErr">尾页</asp:LinkButton>&nbsp;&nbsp;
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
                        <div class="tr" style="margin-top: 10px;">
                            <asp:Button ID="DeleteButtonErr" runat="server" class="mybtn" Text="删除日志 " OnClick="lbDeleteErr_Click"
                                Style="width: 60px;" />
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
       
</asp:Content>
