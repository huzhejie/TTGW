<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="mistakeLog.aspx.cs" Inherits="TTG.Web.mistakeLog" %>
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
        <div class="mistakercd" id="scf6">
            <p class="myp">
                错误日志
            </p>
            <div style="width: 100%; margin-top: 40px;">
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
                        <div style="text-align: right; margin-top: 10px;">
                            <asp:Button ID="DeleteButtonErr" runat="server" class="mybtn" Text="删除日志 " OnClick="lbDeleteErr_Click"
                                Style="height: 24px; line-height: 24px; width: 60px;" />
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
        </div>
</asp:Content>
