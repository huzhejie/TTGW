<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="userEdit.aspx.cs" Inherits="TTG.Web.userEdit" %>
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
        <div class="useredit" id="scf4">
            <p class="myp">
                权限管理
            </p>
            <div class="edit_rig_list" id="edit_rig_list">
                <asp:UpdatePanel ID="UpdatePanel6" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <div style="text-align: right; margin-top: 20px;">
                            <asp:Label ID="LabelRig" runat="server" Text="小区名："></asp:Label><asp:TextBox ID="txtRigComu"
                                runat="server" CssClass="SearchUserName"></asp:TextBox>
                            <asp:Label ID="Label1" runat="server" Text="调查员："></asp:Label><asp:TextBox ID="txtRigInve"
                                runat="server" CssClass="SearchUserName"></asp:TextBox>
                            <asp:Label ID="Label2" runat="server" Text="片区负责人："></asp:Label><asp:TextBox ID="txtRigResp"
                                runat="server" CssClass="SearchUserName"></asp:TextBox>
                            <asp:Button ID="btnQueryRig" runat="server" class="mybtn" Text="查询" OnClick="btnQueryRig_Click"
                                Style="height: 24px; line-height: 24px" />
                        </div>
                        <div style="width: 100%; margin-top: 6px;">
                            <asp:GridView ID="GridViewRig" runat="server" AutoGenerateColumns="False" DataKeyNames="community_id"
                                CssClass="GridViewStyle" OnPageIndexChanging="GridViewRig_PageIndexChanging"
                                EnableModelValidation="True" OnRowDataBound="userRig_RowDataBound" OnRowCancelingEdit="GridViewRig_RowCancelingEdit"
                                AllowPaging="True" OnRowEditing="GridViewRig_RowEditing" OnRowUpdating="GridViewRig_RowUpdating"
                                OnRowDeleting="GridViewRig_RowDeleting">
                                <Columns>
                                    <asp:TemplateField>
                                        <HeaderTemplate>
                                            <asp:CheckBox ID="chkAllRig" runat="server" AutoPostBack="True" OnCheckedChanged="chkAllRig_CheckedChanged" />
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkCheckRig" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="30px" />
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="序号" HeaderStyle-Width="50px" ItemStyle-Width="50px" ReadOnly="true">
                                        <HeaderStyle Width="50px"></HeaderStyle>
                                        <ItemStyle Width="50px"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="community_name" HeaderText="小区名" ReadOnly="True" SortExpression="community_name"
                                        ControlStyle-Width="92px" ItemStyle-Width="96px" ItemStyle-Height="35px" />
                                    <asp:BoundField DataField="community_id" HeaderText="小区编号" ReadOnly="True" SortExpression="community_id"
                                        ControlStyle-Width="92px" ItemStyle-Width="96px" ItemStyle-Height="35px" />
                                    <asp:BoundField DataField="investigator_id" HeaderText="调查员" SortExpression="investigator_id"
                                        ControlStyle-Width="137px" ItemStyle-Width="141px" />
                                    <asp:BoundField DataField="areaChief_id" HeaderText="片区负责人" SortExpression="areaChief_id"
                                        ControlStyle-Width="137px" ItemStyle-Width="141px" />
                                    <asp:CommandField ShowEditButton="True" ItemStyle-Width="153px" ItemStyle-Height="35px" />
                                    <asp:CommandField ShowDeleteButton="True" />
                                </Columns>
                                <EmptyDataTemplate>
                                    <span>没有符合条件的数据!</span>
                                </EmptyDataTemplate>
                                <PagerTemplate>
                                    <div>
                                        <asp:LinkButton ID="btnFirst" runat="server" CssClass="link" CommandName="Pager"
                                            CommandArgument="First" OnCommand="NavigateToPageRig">首页</asp:LinkButton>&nbsp;
                                        <asp:LinkButton ID="btnPrev" runat="server" CssClass="link" CommandName="Pager" CommandArgument="Prev"
                                            OnCommand="NavigateToPageRig">前一页</asp:LinkButton>&nbsp;
                                        <asp:LinkButton ID="btnNext" runat="server" CssClass="link" CommandName="Pager" CommandArgument="Next"
                                            OnCommand="NavigateToPageRig">下一页</asp:LinkButton>&nbsp;
                                        <asp:LinkButton ID="btnLast" runat="server" CssClass="link" CommandName="Pager" CommandArgument="Last"
                                            OnCommand="NavigateToPageRig">尾页</asp:LinkButton>&nbsp;&nbsp;
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
                                <%--  <asp:Button ID="AddButtonRig" runat="server" class="mybtn" Style="height: 24px; line-height: 24px;
                                    width: 60px;" Text="新增" OnClientClick="showaddrig()" />--%>
                                <asp:Button ID="lbDeleteRig" runat="server" class="mybtn" Text="删除 " OnClick="lbDeleteRig_Click"
                                    Style="height: 24px; line-height: 24px; width: 60px;" />
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div class="add_rig" id="add_rig">
                <asp:UpdatePanel ID="UpdatePanel8" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        小区：<asp:TextBox ID="TextBoxCom" runat="server"></asp:TextBox>
                        调查员：<asp:TextBox ID="TextBoxInves" runat="server"></asp:TextBox>
                        片区负责人：<asp:TextBox ID="TextBoxResp" runat="server"></asp:TextBox>
                        <asp:Button ID="addRig" runat="server" Text="添加" CssClass="mybtn" Style="height: 24px; line-height: 24px; width: 60px;"
                            OnClick="addRig_Click" />
                        <asp:Button ID="cleartxtRig" runat="server" Text="清空" CssClass="mybtn" Style="height: 24px; line-height: 24px; width: 60px;"
                            OnClick="cleartxtRig_Click" />
                        <asp:Button ID="Button4" runat="server" Text="返回" OnClientClick="showeditrig()" OnClick="gobackrig_Click"
                            Style="height: 24px; line-height: 24px; width: 60px;" CssClass="mybtn" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
        </div>
</asp:Content>
