<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="newAnno.aspx.cs" Inherits="TTG.Web.newAnno" ValidateRequest="false"
    EnableEventValidation="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/common.css" rel="stylesheet" type="text/css" />
    <link href="UMeditor/themes/default/css/umeditor.css" rel="stylesheet" type="text/css" />
    <script src="UMeditor/third-party/jquery.min.js" type="text/javascript"></script>
    <script src="UMeditor/umeditor.config.js" charset="utf-8" type="text/javascript"></script>
    <script src="UMeditor/umeditor.min.js" charset="utf-8" type="text/javascript"></script>
    <script src="UMeditor/lang/zh-cn/zh-cn.js" type="text/javascript"></script>
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
            发布公告
        </p>
        <div class="mb20">
            <span style="margin-left: 100px;">标题：</span>
            <input id="Texttitle" type="text" class="manageBotInput" style="width:500px;" runat="server" /><br />
            <br />
            <script type="text/plain" id="myEditor" style="width: 800px; height: 380px;">                        
            </script>
            <asp:HiddenField ID="mytext" runat="server" />
        </div>
        <div>
            <span>公告类型：</span>
            <asp:DropDownList ID="DropDownListPName" runat="server" CssClass="manageSelect">
                <asp:ListItem Selected="True">所有公告</asp:ListItem>
                <asp:ListItem>综合帮扶信息</asp:ListItem>
                <asp:ListItem>现场监测动态</asp:ListItem>
                <asp:ListItem>区县培训及就业信息</asp:ListItem>
            </asp:DropDownList>
            <span class="mf20">发布单位：</span>
            <input id="publisherName" type="text" runat="server" class="manageBotInput" />
            <asp:Button ID="publishBtn" runat="server" Text="发布" CssClass="mybtn manageBtn" OnClick="publishBtn_Click" />
        </div>
    </div>
    <script type="text/javascript">
        //发布公告时获取相关内容  
        var um = UM.getEditor('myEditor');
        $(".edui-body-container").css("width", "98%");

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

    </script>
</asp:Content>
