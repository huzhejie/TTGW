<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true"
    CodeBehind="sysManage.aspx.cs" Inherits="TTG.Web.sysManage" ValidateRequest="false"
    EnableEventValidation="true" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="./JS/laydate.js" type="text/javascript"></script>
    <link href="Css/common.css" rel="stylesheet" type="text/css" />
    <link href="UMeditor/themes/default/css/umeditor.css" rel="stylesheet" type="text/css" />
    <script src="UMeditor/third-party/jquery.min.js" type="text/javascript"></script>
    <script src="UMeditor/umeditor.config.js" charset="utf-8" type="text/javascript"></script>
    <script src="UMeditor/umeditor.min.js" charset="utf-8" type="text/javascript"></script>
    <script src="UMeditor/lang/zh-cn/zh-cn.js" type="text/javascript"></script>
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
                <p onclick="show(1)">
                    查看所有公告
                </p>
            </div>
            <div style="height: 2px; background-color: #fff; width: 100%;">
            </div>
            <div class="selects_li">
                <p onclick="javascript:show(2)">
                    发布最新公告
                </p>
            </div>
            <div style="height: 2px; background-color: #fff; width: 100%;">
            </div>
            <div class="selects_li">
                <p onclick="show(7)">
                    上传删除文件
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
                <p onclick="show(3)">
                    用户账号管理
                </p>
            </div>
            <div style="height: 2px; background-color: #fff; width: 100%;">
            </div>
            <div class="selects_li">
                <p onclick="show(4)">
                    用户权限管理
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
                <p onclick="show(5)">
                    登陆日志管理
                </p>
            </div>
            <div style="height: 2px; background-color: #fff; width: 100%;">
            </div>
            <div class="selects_li">
                <p onclick="show(6)">
                    错误日志管理
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
                <p onclick="show(8)">
                    标准表上传
                </p>
            </div>
            <div style="height: 2px; background-color: #fff; width: 100%;">
            </div>
            <div class="selects_li">
                <p onclick="show(9)">
                    生成word
                </p>
            </div>
        </div>
    </div>
    <div class="s_contentright fl">
        <div class="allanno" id="scf1">
            <p class="myp">
                所有公告
            </p>
            <div class="fl scf1head">
                <div class="fl">
                    <asp:DropDownList ID="DropDownListType" runat="server" Width="140px" Height="24px">
                        <asp:ListItem Selected="True">所有公告</asp:ListItem>
                        <asp:ListItem>综合帮扶信息</asp:ListItem>
                        <asp:ListItem>现场检测动态</asp:ListItem>
                        <asp:ListItem>区县培训及就业信息</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="fl" style="margin-left: 30px;">
                    <asp:DropDownList ID="DropDownListPublisher" runat="server" Width="140px" Height="24px">
                    </asp:DropDownList>
                </div>
                <div class="fl" style="margin-left: 30px;">
                    <input class="laydate-icon" id="demo" />
                    <input id="demoTime" runat="server" style="display: none;" />
                </div>
            </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Button ID="Search" runat="server" Text="搜索" CssClass="mybtn syssearch" OnClick="Search_Click" />
                    <div style="margin-top: 10px; width: 100%; height: 420px;" class="fl">
                        <ul>
                            <asp:Repeater ID="RepeaterInf" runat="server" OnItemCommand="RepeaterInf_ItemCommand">
                                <ItemTemplate>
                                    <li>
                                        <div style="float: left;">
                                            <a href="Announce.aspx?nfid=<%#Eval("nf_id").ToString()%>" title="<%#Eval("nf_title").ToString()%>" target="_blank">
                                                <%#trimanno(Eval("nf_title").ToString())%>
                                            </a>
                                        </div>
                                        <div class="dow">
                                            <a href="EditAnnounce.aspx?nfid=<%#Eval("nf_id").ToString()%>" target="_blank">编辑</a>
                                        </div>
                                        <div class="dow">
                                            <asp:Button ID="ButtonToDel" runat="server" Text="删除" CommandName="d" CommandArgument='<%#Eval("nf_id") %>'
                                                CssClass="sysBtn" />
                                        </div>
                                        <div class="dow">
                                            <%#DateTime.Parse(Eval("nf_time").ToString()).ToString("yyyy-MM-dd")%>
                                        </div>
                                        <div class="dow" style="width: 110px;">
                                            <span title="<%#Eval("nf_type").ToString()%>"><%#trimanno6(Eval("nf_type").ToString())%></span>
                                        </div>
                                        <div class="dow">
                                            <%#Eval("nf_depart").ToString()%>
                                        </div>
                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                    <webdiyer:AspNetPager CssClass="pages fl" CurrentPageButtonClass="cpb" PagingButtonSpacing="0"
                        ID="AspNetPager1" OnPageChanged="AspNetPager1_PageChanged" runat="server" RecordCount="2280"
                        FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" SubmitButtonText="前往"
                        TextAfterPageIndexBox="页" TextBeforePageIndexBox="到" SubmitButtonStyle="padding: 0 5px; vertical-align:bottom;border:1px solid  #ddd; ;font-size:14px;color:#000;margin-left:10px;">
                    </webdiyer:AspNetPager>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div class="newanno" id="scf2">
            <p class="myp">
                发布公告
            </p>
            <div class="mcontent">
                <span style="margin-left: 100px;">标题：</span><input id="Texttitle" type="text" class="titlebox"
                    runat="server" /><br />
                <br />
                <script type="text/plain" id="myEditor" style="width: 800px; height: 360px;">
                        
                </script>
                <asp:HiddenField ID="mytext" runat="server" />
            </div>
            <span style="float: left; margin-left: 20px;">公告类型：</span>
            <asp:DropDownList ID="DropDownListPName" runat="server" CssClass="annoselect">
                <asp:ListItem Selected="True">所有公告</asp:ListItem>
                <asp:ListItem>综合帮扶信息</asp:ListItem>
                <asp:ListItem>现场检测动态</asp:ListItem>
                <asp:ListItem>区县培训及就业信息</asp:ListItem>
            </asp:DropDownList>
            <span style="float: left; margin-left: 20px;">发布单位：</span><input id="publisherName"
                type="text" runat="server" class="annoinput" />
            <asp:Button ID="publishBtn" runat="server" Text="发布" CssClass="mybtn fr" OnClick="publishBtn_Click" />
        </div>
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
        <div class="upanddelf" id="scf8">
            <p class="myp">
                上传标准表
            </p>
            <div class="uploaddiv">

                <asp:FileUpload ID="FileUploadStantard" runat="server" Style="margin-top: 20px;" />
                <asp:Button ID="StantardUplBtn" runat="server" Text="上传" CssClass="mybtn uploadBtn"
                    OnClick="StantardUplBtn_Click" />
            </div>
            <asp:UpdatePanel ID="UpdatePanel9" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div style="margin-top: 10px; width: 100%; height: 420px;" class="fl">
                        <ul>
                            <asp:Repeater ID="RepeaterStantard" runat="server" OnItemCommand="RepeaterStantard_ItemCommand">
                                <ItemTemplate>
                                    <li>
                                        <div style="float: left;">
                                            <a href="SeeOffice.aspx?officeFile=<%#Eval("table_path").ToString()%>&path=标准表">
                                                <%#Eval("table_name").ToString()%>
                                            </a>

                                        </div>
                                        <div class="dow">
                                            <asp:Button ID="ButtonToDelStandard" runat="server" Text="删除" CommandName="delStantard" CommandArgument='<%#Eval("table_id") %>'
                                                CssClass="sysBtn" />
                                        </div>

                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                    <webdiyer:AspNetPager CssClass="pages fl" CurrentPageButtonClass="cpb" PagingButtonSpacing="0"
                        ID="AspNetPager3" OnPageChanged="AspNetPager3_PageChanged" runat="server" RecordCount="2280"
                        FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" SubmitButtonText="前往"
                        TextAfterPageIndexBox="页" TextBeforePageIndexBox="到" SubmitButtonStyle="padding: 0 5px; vertical-align:bottom;border:1px solid  #ddd; ;font-size:14px;color:#000;margin-left:10px;">
                    </webdiyer:AspNetPager>
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
        <div class="newanno" id="scf9">
            <p class="myp">
                生成word
            </p>
            <div class="uploaddiv">
            </div>
        </div>
    </div>
    <script type="text/javascript">
        //发布公告时获取相关内容  
        var um = UM.getEditor('myEditor');
        //        um.setWidth("100%");
        $(".edui-body-container").css("width", "98%");
        var um2 = UM.getEditor('myEditorU');

        function saveText() {
            var iserr = "";
            var a = document.getElementById("<%=Texttitle.ClientID%>").value;
            if (a == "") {
                iserr += "标题不能为空！";
            }
            var c = document.getElementById("<%=DropDownListPName.ClientID%>").value;
                if (c == "所有公告") {
                    iserr += "公告类型不能为空！";
                }

                var b = document.getElementById("<%=publisherName.ClientID%>").value;
                if (b == "") {
                    iserr += "发布单位不能为空！";
                }
                if (iserr != "") {
                    alert(iserr);
                    return false;
                }
                else {
                    document.getElementById("<%=mytext.ClientID%>").value = UM.getEditor('myEditor').getContent();
                }
            //(UM.getEditor('myentext').getContent());
            }


            !function () {
                laydate.skin('molv'); //切换皮肤，请查看skins下面皮肤库
                laydate({ elem: '#demo' }); //绑定元素
            }();


            //切换不同的功能块
            function show(n) {
                for (i = 1; i <= 9; i++) {
                    var elm = "scf" + i;
                    if (i != n) {
                        document.getElementById(elm).style.display = "none";

                    } else {
                        document.getElementById(elm).style.display = "block";
                    }
                }
            }

            function deliver() {
                var Tvalue = document.getElementById("demo").value;
                var hideinput = document.getElementById("<%=demoTime.ClientID%>");
                hideinput.value = Tvalue;
            }

        function checkFile() {
            var filename = document.getElementById("<%=FileUploadForFile.ClientID%>").value;
            var filetype = document.getElementById("<%=DropDownListupType.ClientID%>").value;
            var err = "";
            if (filename == "") {
                err += "请选择文件！";
            }
            if (filetype == "" || filetype == "文件类型") {
                err += "请选择文件类型";
            }

            if (err != "") {
                alert(err);
                return false;
            }
        }

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

        //显示修改权限的页面
        function showeditrig() {
            document.getElementById("edit_rig_list").style.display = "block";
            document.getElementById("add_rig").style.display = "none";
        }

        //显示增加权限的页面
        function showaddrig() {
            document.getElementById("edit_rig_list").style.display = "none";
            document.getElementById("add_rig").style.display = "block";
        }
    </script>
</asp:Content>
