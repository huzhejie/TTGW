<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="idEdit.aspx.cs" Inherits="TTG.Web.idEdit" %>

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
                用户管理
            </p>
            <div id="edit_user_list">
                <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <div class="tr mt20">
                           <span>用户名：</span>
                            <asp:TextBox ID="txtSearchName" runat="server" CssClass="manageInput"></asp:TextBox>
                           <span>用户账号：</span>
                            <asp:TextBox ID="txtSearchId" runat="server" CssClass="manageInput"></asp:TextBox>
                            <asp:DropDownList ID="DropDownListUser" runat="server" CssClass="manageSelect">
                                <asp:ListItem Selected="True">全部类型</asp:ListItem>
                                <asp:ListItem>外部领导</asp:ListItem>
                                <asp:ListItem>内部领导</asp:ListItem>
                                <asp:ListItem>综合分析员</asp:ListItem>
                                <asp:ListItem>片区负责人</asp:ListItem>
                                <asp:ListItem>调查员</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Button ID="btnQueryUsr" runat="server" class="mybtn" Text="查询" OnClick="btnQueryUsr_Click"/>
                        </div>
                        <div class="tc" style="margin-top:6px;">
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
                            <div class="tr" style="margin-top: 10px;">
                                <asp:Button ID="AddButtonUsr" runat="server" class="mybtn" Text="新增用户" Style="width: 60px;"
                                    OnClientClick="showadduser()" />
                                <asp:Button ID="lbDeleteUsr" runat="server" class="mybtn" Text="删除用户 " OnClick="lbDeleteUsr_Click"
                                    Style="width: 60px;" />
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div class="addUser clearfix" id="add_user">
                <asp:UpdatePanel ID="UpdatePanel7" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>

                          
                            <span>用户账号：</span>
                           
                            <asp:TextBox ID="Tbuserid" runat="server" CssClass="manageInput"></asp:TextBox>
                       
                       
                            <span>用户名：</span>
                           
                            <asp:TextBox ID="Tbusername" runat="server" CssClass="manageInput"></asp:TextBox>
                        
                            <span>用户密码：</span>
                            <asp:TextBox ID="Tbuserpwd" runat="server" CssClass="manageInput"></asp:TextBox>
                       
                            <span>用户类型：</span>
                            <asp:DropDownList ID="DropDownListAddUser" runat="server" CssClass="manageSelect">
                                <asp:ListItem Selected="True"></asp:ListItem>
                                <asp:ListItem>外部领导</asp:ListItem>
                                <asp:ListItem>内部领导</asp:ListItem>
                                <asp:ListItem>综合分析员</asp:ListItem>
                                <asp:ListItem>片区负责人</asp:ListItem>
                                <asp:ListItem>调查员</asp:ListItem>
                            </asp:DropDownList>
                               
                           
                                <asp:Button ID="addUser" runat="server" Text="添加" CssClass="mybtn" OnClick="addUser_Click" />
                                <asp:Button ID="cleartxt" runat="server" Text="清空" CssClass="mybtn" OnClick="cleartxt_Click"/>
                                <asp:Button ID="goback" runat="server" Text="返回" OnClientClick="showedituser()" OnClick="goback_Click"
                                    CssClass="mybtn" />
                            
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    
    <script type="text/javascript">
        //显示编辑用户的页面
        function showedituser() {
            document.getElementById("edit_user_list").style.display = "block";
            document.getElementById("add_user").style.display = "none";
        }

        //显示增加用户的页面
        function showadduser() {
            document.getElementById("edit_user_list").style.display = "none";
            document.getElementById("add_user").style.display = "block";
        }
    </script>
</asp:Content>
