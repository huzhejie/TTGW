<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="idEdit.aspx.cs" Inherits="TTG.Web.idEdit" %>
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
    <div class="idedit" id="scf3">
            <p class="myp">
                用户管理
            </p>
            <div class="edit_user_list" id="edit_user_list">
                <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <div style="text-align: right; margin-top: 20px;">
                            <asp:Label ID="LabelUsrname" runat="server" Text="用户名："></asp:Label><asp:TextBox
                                ID="txtSearchName" runat="server" CssClass="SearchUserName"></asp:TextBox>
                            <asp:Label ID="Labeluserid" runat="server" Text="用户账号："></asp:Label><asp:TextBox
                                ID="txtSearchId" runat="server" CssClass="SearchUserName"></asp:TextBox>
                            <asp:DropDownList ID="DropDownListUser" runat="server" Width="160px" Height="24px">
                                <asp:ListItem Selected="True">全部类型</asp:ListItem>
                                <asp:ListItem>外部领导</asp:ListItem>
                                <asp:ListItem>内部领导</asp:ListItem>
                                <asp:ListItem>综合分析员</asp:ListItem>
                                <asp:ListItem>片区负责人</asp:ListItem>
                                <asp:ListItem>调查员</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Button ID="btnQueryUsr" runat="server" class="mybtn" Text="查询" OnClick="btnQueryUsr_Click"
                                Style="height: 24px; line-height: 24px" />
                        </div>
                        <div style="width: 100%; margin-top: 6px;">
                            <asp:GridView ID="GridViewUsr" runat="server" AutoGenerateColumns="False" DataKeyNames="userId"
                                OnPageIndexChanging="GridViewUsr_PageIndexChanging" EnableModelValidation="True"
                                OnRowDataBound="userUsr_RowDataBound" OnRowCancelingEdit="GridViewUsr_RowCancelingEdit"
                                AllowPaging="True" CssClass="GridViewStyle" OnRowEditing="GridViewUsr_RowEditing"
                                OnRowUpdating="GridViewUsr_RowUpdating" OnRowDeleting="GridViewUsr_RowDeleting">
                                <Columns>
                                    <asp:TemplateField>
                                        <HeaderTemplate>
                                            <asp:CheckBox ID="chkAllUsr" runat="server" AutoPostBack="True" OnCheckedChanged="chkAllUsr_CheckedChanged" />
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkCheckUsr" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="30px" />
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="序号" HeaderStyle-Width="50px" ItemStyle-Width="50px" ReadOnly="true">
                                        <HeaderStyle Width="50px"></HeaderStyle>
                                        <ItemStyle Width="50px"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="userId" HeaderText="用户账号" SortExpression="userId" ReadOnly="True"
                                        ControlStyle-Width="92px" ItemStyle-Width="96px" ItemStyle-Height="35px" />
                                    <asp:BoundField DataField="userName" HeaderText="用户名" SortExpression="userName" ControlStyle-Width="119px"
                                        ItemStyle-Width="123px" ItemStyle-Height="35px" />
                                    <asp:BoundField DataField="userPwd" HeaderText="用户密码" SortExpression="userPwd" ControlStyle-Width="129px"
                                        ItemStyle-Height="35px" ItemStyle-Width="133px" />
                                    <asp:BoundField DataField="userType" HeaderText="用户类型" SortExpression="userType"
                                        ControlStyle-Width="129px" ItemStyle-Width="133px" ItemStyle-Height="35px" />
                                    <asp:CommandField ShowEditButton="True" ItemStyle-Width="153px" ItemStyle-Height="35px" />
                                    <asp:CommandField ShowDeleteButton="True" />
                                </Columns>
                                <EmptyDataTemplate>
                                    <span>没有符合条件的数据!</span>
                                </EmptyDataTemplate>
                                <PagerTemplate>
                                    <div>
                                        <asp:LinkButton ID="btnFirst" runat="server" CssClass="link" CommandName="Pager"
                                            CommandArgument="First" OnCommand="NavigateToPageUsr">首页</asp:LinkButton>&nbsp;
                                        <asp:LinkButton ID="btnPrev" runat="server" CssClass="link" CommandName="Pager" CommandArgument="Prev"
                                            OnCommand="NavigateToPageUsr">前一页</asp:LinkButton>&nbsp;
                                        <asp:LinkButton ID="btnNext" runat="server" CssClass="link" CommandName="Pager" CommandArgument="Next"
                                            OnCommand="NavigateToPageUsr">下一页</asp:LinkButton>&nbsp;
                                        <asp:LinkButton ID="btnLast" runat="server" CssClass="link" CommandName="Pager" CommandArgument="Last"
                                            OnCommand="NavigateToPageUsr">尾页</asp:LinkButton>&nbsp;&nbsp;
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
                                <asp:Button ID="AddButtonUsr" runat="server" class="mybtn" Text="新增用户" Style="height: 24px; line-height: 24px; width: 60px;"
                                    OnClientClick="showadduser()" />
                                <asp:Button ID="lbDeleteUsr" runat="server" class="mybtn" Text="删除用户 " OnClick="lbDeleteUsr_Click"
                                    Style="height: 24px; line-height: 24px; width: 60px;" />
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div class="add_user clearfix" id="add_user">
                <asp:UpdatePanel ID="UpdatePanel7" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>

                        <div class="adduser_div ">
                            <span>用户账号：</span>
                            <br />
                            <asp:TextBox ID="Tbuserid" runat="server" CssClass="adduser_txt"></asp:TextBox>
                        </div>
                        <div class="adduser_div ">
                            <span>用户名：</span>
                            <br />
                            <asp:TextBox ID="Tbusername" runat="server" CssClass="adduser_txt"></asp:TextBox>
                        </div>
                        <div class="adduser_div ">
                            <span>用户密码：</span><br />
                            <asp:TextBox ID="Tbuserpwd" runat="server" CssClass="adduser_txt"></asp:TextBox>
                        </div>
                        <div class="adduser_div ">
                            <span>用户类型：</span><br />
                            <asp:DropDownList ID="DropDownListAddUser" runat="server" CssClass="adduser_txt">
                                <asp:ListItem Selected="True"></asp:ListItem>
                                <asp:ListItem>外部领导</asp:ListItem>
                                <asp:ListItem>内部领导</asp:ListItem>
                                <asp:ListItem>综合分析员</asp:ListItem>
                                <asp:ListItem>片区负责人</asp:ListItem>
                                <asp:ListItem>调查员</asp:ListItem>
                            </asp:DropDownList>
                            <div class="adduser_btn_div ">
                                <asp:Button ID="addUser" runat="server" Text="添加" CssClass="mybtn adduser_btn" Style="float: left;"
                                    OnClick="addUser_Click" />
                                <asp:Button ID="cleartxt" runat="server" Text="清空" CssClass="mybtn adduser_btn" OnClick="cleartxt_Click"
                                    Style="float: left; margin-left: 90px;" />
                                <asp:Button ID="goback" runat="server" Text="返回" OnClientClick="showedituser()" OnClick="goback_Click"
                                    CssClass="mybtn adduser_btn" />
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
        </div>
</asp:Content>
