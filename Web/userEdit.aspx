<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="userEdit.aspx.cs" Inherits="TTG.Web.userEdit" %>

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
            权限管理
        </p>
        <div id="edit_rig_list">
            <asp:UpdatePanel ID="UpdatePanel6" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="tr mt20">
                        <asp:Label ID="LabelRig" runat="server" Text="小区名："></asp:Label><asp:TextBox ID="txtRigComu"
                            runat="server" CssClass="manageInput"></asp:TextBox>
                        <asp:Label ID="Label1" runat="server" Text="调查员："></asp:Label><asp:TextBox ID="txtRigInve"
                            runat="server" CssClass="manageInput"></asp:TextBox>
                        <asp:Label ID="Label2" runat="server" Text="片区负责人："></asp:Label><asp:TextBox ID="txtRigResp"
                            runat="server" CssClass="manageInput"></asp:TextBox>
                        <asp:Button ID="btnQueryRig" runat="server" class="mybtn" Text="查询" OnClick="btnQueryRig_Click" />
                    </div>
                    <div class="tc" style="margin-top: 6px;">
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
                        <div class="tr" style="margin-top: 10px;">

                            <asp:Button ID="lbDeleteRig" runat="server" class="mybtn" Text="删除 " OnClick="lbDeleteRig_Click" />
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
