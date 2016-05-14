<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="newAnno.aspx.cs" Inherits="TTG.Web.newAnno" ValidateRequest="false"
    EnableEventValidation="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" >
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

    </script>
</asp:Content>
