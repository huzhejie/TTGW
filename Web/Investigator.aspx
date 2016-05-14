<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true"
    CodeBehind="Investigator.aspx.cs" Inherits="TTG.Web.Investigator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/common.css" rel="stylesheet" type="text/css" />
    <script src="./JS/laydate.js" type="text/javascript"></script>
    <script src="Scripts/jquery.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery-ui.min.js" type="text/javascript"></script>
    <script src="Scripts/main.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="communityList">
            <ul id="communityChoice">
                <li>小区一览</li>
                <asp:Repeater ID="RepeaterCommunity" runat="server">
                    <ItemTemplate>
                        <li><a><span><%#Eval("community_name").ToString()+"("+Eval("community_id").ToString()+")"%></span><i></i></a></li>
                        <div class="hr">
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
        <div class="communityContent">

            <div class="opreateMoudle clearfix">
                <p>修改数据表</p>

                <div class="longline fl mb20">
                </div>

                <p>开始时间：</p>
                <div class="laydate-icon" id="start">
                </div>
                <p class="mf20">结束时间：</p>
                <div class="laydate-icon" id="end">
                </div>
                <!--隐藏域，用于向后台传值-->
                <div style="display: none;">
                    <input id="hidestart" name="startt" type="text" runat="server" />
                    <input id="et" name="endt" type="text" runat="server" />
                    <input id="com" name="comunt" type="text" runat="server" />
                </div>


                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>

                        <asp:Button ID="btnSearch" runat="server" Text="查找" CssClass="mybtn fr" OnClick="btnSearch_Click"></asp:Button>
                        <div class="fl mt20">
                            <span>请选择要修改的文件：</span>


                            <asp:DropDownList ID="DropDownList1" runat="server" Width="280px" Height="25px">
                            </asp:DropDownList>
                        </div>

                    </ContentTemplate>
                </asp:UpdatePanel>

                <asp:Button ID="btnOk" runat="server" Text="确定" CssClass="mybtn fr mt20" Style="margin-right: -50px;" OnClick="btnOk_Click"></asp:Button>


            </div>


            <div class="opreateMoudle clearfix">

                <p>增加数据表</p>

                <div class="longline fl mb20">
                </div>
                <div class="fl">
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                        <ContentTemplate>

                            <span>请选择要添加的文件：</span>
                            <asp:DropDownList ID="DropDownList2" runat="server" Height="23px">
                            </asp:DropDownList>

                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                <asp:Button ID="btnOk2" runat="server" Text="确定" CssClass="mybtn fr" OnClick="btnOk2_Click"></asp:Button>

            </div>
            <div class="opreateMoudle clearfix">

                <p>上传小区图片</p>

                <div class="longline fl mb20">
                </div>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>

                        <p>说明：点增加图片按钮可一次上传多张图片，可为每张图片写上一句不超过20个字的描述。单张图片大小不大于1024k</p>
                        
                        <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="Red" Text=""></asp:Label>
                        <div class="fl">
                            <p>请选择图片：</p><br /><br />
                            <p id="MyFile">
                                <input onclick="addFile()" type="button" value="增加图片(Add)" class="mybtn" style="width: 100px;" />
                            </p>
                            <br />
                            <input id="File1" type="file" name="File" runat="server" style="width: 300px" />
                        </div>

                        <asp:Button ID="btnUpload" runat="server" Text="上传" CssClass="mybtn fr mt50" OnClick="btnUpload_Click" />

                    </ContentTemplate>
                    <Triggers>
                        <asp:PostBackTrigger ControlID="btnUpload" />
                    </Triggers>
                </asp:UpdatePanel>
            </div>
            <div class="opreateMoudle clearfix">

                <p>上传监测日志 <a href="MonitorLog.aspx" style="color: blue; font-weight: normal; text-decoration: none;" target="_blank">查看所有日志>></a></p>

                <div class="longline fl mb20">
                </div>
                <p>
                    <span>请选择文件:</span>
                    <asp:FileUpload ID="FileUploadRz" runat="server" />
                </p>
                <p>
                    <span>请输入文件名:</span>
                    <asp:TextBox ID="TextBoxRzTitle" runat="server"></asp:TextBox>
                </p>

                <asp:Button ID="ButtonRz" runat="server" Text="上传" CssClass="mybtn fr"
                    OnClick="ButtonRz_Click" />



            </div>

        </div>
    </div>
    <script src="JS/util.js" type="text/javascript"></script>
    <script type="text/javascript">
        var etID = "<%=et.ClientID%>";
        var hidestartID = "<%=hidestart.ClientID%>";
        var comID = "<%=com.ClientID%>";            
    </script>
    <script src="JS/investigator.js" type="text/javascript"></script>
</asp:Content>
