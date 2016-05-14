<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true" CodeBehind="EditAnnounce.aspx.cs" Inherits="TTG.Web.EditAnnounce" ValidateRequest="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/common.css" rel="stylesheet" type="text/css" />
     <link href="UMeditor/themes/default/css/umeditor.css" rel="stylesheet" type="text/css" />
    <%--<script src="Scripts/jquery-1.8.3.js" type="text/javascript"></script>--%>
    <script src="UMeditor/third-party/jquery.min.js" type="text/javascript"></script>
    <script src="UMeditor/umeditor.config.js" charset="utf-8" type="text/javascript"></script>
    <script src="UMeditor/umeditor.min.js" charset="utf-8" type="text/javascript"></script>
    <script src="UMeditor/lang/zh-cn/zh-cn.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="editanno">
            <p class="myp">
                修改公告</p>
            <div class="mcontent">
             <span style="margin-left: 120px;">标题：</span><input id="Texttitle" type="text" class="titlebox"
                    runat="server" /><br />
                <br />
                <script type="text/plain" id="myEditorU" style="width: 800px; height: 360px;">
                        
                </script>
                <asp:HiddenField ID="mytextu" runat="server" />
            </div>
            <input id="Texthide" type="text" style="display: none;" runat="server" />
              <span style="float: left; margin-left: 20px;">公告类型：</span>
            <asp:DropDownList ID="DropDownListPName" runat="server" CssClass="annoselect">
                <asp:ListItem Selected="True">所有公告</asp:ListItem>
                <asp:ListItem>综合帮扶信息</asp:ListItem>
                <asp:ListItem>现场检测动态</asp:ListItem>
                <asp:ListItem>区县培训及就业信息</asp:ListItem>
            </asp:DropDownList>
            <span style="float: left; margin-left: 20px;">发布单位：</span><input id="publisherName"
                type="text" runat="server" class="annoinput" />
           
            <asp:Button ID="modifyBtn" runat="server" Text="修改" CssClass="mybtn fr"
                OnClick="modifyBtn_Click" />
        </div>
        <script type="text/javascript">
            var um = UM.getEditor('myEditorU');
            $(".edui-body-container").css("width", "98%");

            function setUMContent() {
                var value = document.getElementById("<%=Texthide.ClientID%>").value;               
                um.setContent(value);
            }



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
                    document.getElementById("<%=mytextu.ClientID%>").value = UM.getEditor('myEditorU').getContent();
                }
                
            }
        </script>
</asp:Content>
