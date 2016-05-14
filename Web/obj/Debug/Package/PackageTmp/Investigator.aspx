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
    <div class="communitycontent">
        <div id="communitylist">
            <ul id="communityChoice" class="leftSelect">
                <li class="com_head" style="background: #63CB30">小区一览</li>
                <asp:Repeater ID="RepeaterCommunity" runat="server">
                    <ItemTemplate>

                        <li><a><span><%#Eval("community_name").ToString()+"("+Eval("community_id").ToString()+")"%></span> <i></i></a></li>
                        <div class="hr">
                        </div>

                    </ItemTemplate>
                </asp:Repeater>
               <%-- <li><a><span>浮现小区</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>科大小区</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>柳树沟</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>郑家湾</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>刘家湾</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>郑家花园</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>水果市场</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>韩家老屋</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>范家湾</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>大坪</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>谭家坝</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>杨贵店</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>邓家坝</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>后河</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>北斗夫子岩</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>王家岭</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>桑树拐</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>韩家老屋</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>周家湾</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>庙嘴</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>九里</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>金堂湾小区</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>营沱小区</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>巴山路小区</span> <i></i></a></li>
                <div class="hr">
                </div>
                <li><a><span>破产企业小区</span> <i></i></a></li>--%>
            </ul>
        </div>
        <div class="mylist">
            <%--<div id="bg" class="xixi1">
		                    <div id="font1" class="tab1" onclick="setTab03Syn(1);">修改或增加数据表</div>
		                    <div id="font2" class="tab2" onclick="setTab03Syn(2);">添加小区相关图片</div>
		                   <div id="font3" class="tab3" onclick="setTab03Syn(3);">添加通知公告</div>
	                    </div>--%>
            <div class="updateoffice">
                <div class="imgtitle">
                    <span>修改数据表</span>
                </div>
                <div style="width: 100%; height: 2px; background-color: #63CB30;">
                </div>
                <div class="list1">
                    <div style="width: 81%; height: 25px; float: left; margin-top: 15px;">
                        <div style="float: left; line-height: 25px;">
                            <span>开始时间：</span>
                        </div>
                        <div class="laydate-icon fl" id="start" style="width: 170px; float: left;">
                        </div>
                        <div style="float: left; line-height: 25px; margin-left: 20px;">
                            <span>结束时间：</span>
                        </div>
                        <div class="laydate-icon fl" id="end" style="width: 170px; float: left;">
                        </div>
                        <div style="display: none;">
                            <input id="hidestart" name="startt" type="text" runat="server" />
                            <input id="et" name="endt" type="text" runat="server" />
                            <input id="com" name="comunt" type="text" runat="server" />
                        </div>
                    </div>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div style="width: 15%; height: 25px; float: left; margin-top: 15px">
                                <asp:Button ID="btnSearch" runat="server" Text="查找" CssClass="mybtn" OnClick="btnSearch_Click">
                                </asp:Button>
                            </div>
                            <div style="width: 81%; height: 25px; float: left; margin-top: 15px">
                                <div style="float: left; line-height: 25px;">
                                    <span style="font-size: 14px">请选择要修改的文件：</span>
                                </div>
                                <div style="float: left;">
                                    <asp:DropDownList ID="DropDownList1" runat="server" Width="280px" Height="23px">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <div style="width: 15%; height: 25px; float: left; margin-top: 15px">
                        <asp:Button ID="btnOk" runat="server" Text="确定" CssClass="mybtn" OnClick="btnOk_Click">
                        </asp:Button>
                    </div>
                </div>
            </div>
            <div class="addoffice" style="margin-top: 10px;">
                <div class="imgtitle">
                    <span>增加数据表</span>
                </div>
                <div style="width: 100%; height: 2px; background-color: #63CB30;">
                </div>
                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate>
                        <div style="margin-top: 15px; width: 81%; float: left;">
                            <span style="font-size: 14px">请选择要添加的文件：</span>
                            <asp:DropDownList ID="DropDownList2" runat="server" Height="23px">
                            </asp:DropDownList>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <div style="width: 15%; height: 25px; float: left; margin-top: 15px">
                    <asp:Button ID="btnOk2" runat="server" Text="确定" CssClass="mybtn" OnClick="btnOk2_Click">
                    </asp:Button>
                </div>
            </div>
            <div class="addimg" style="margin-top: 10px;">
                <div class="imgtitle">
                    <span>上传小区图片</span>
                </div>
                <div style="width: 100%; height: 2px; background-color: #63CB30;">
                </div>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <div style="margin-top: 15px;">
                            <font color="black" face="宋体" size="2">说明：点增加图片按钮可一次上传多张图片，可为每张图片写上一句不超过20个字的描述。单张图片大小不大于1024k</font>
                        </div>
                        <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="Red" Text=""></asp:Label>
                        <div style="margin-top: 15px; width: 100%; float: left;">
                            <span style="font-size: 14px">请选择图片：</span><br />
                            <p id="MyFile">
                                <input onclick="addFile()" type="button" value="增加图片(Add)" class="mybtn" style="width: 100px;" /></p>
                            <div style="height: 2px;">
                            </div>
                            <input id="File1" type="file" name="File" runat="server" style="width: 300px" />
                        </div>
                        <div style="width: 15%; margin-left: 565px;">
                            <asp:Button ID="btnUpload" runat="server" Text="上传" CssClass="mybtn" OnClick="btnUpload_Click" />
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:PostBackTrigger ControlID="btnUpload" />
                    </Triggers>
                </asp:UpdatePanel>
            </div>
            <div class="addimg">
                <div class="imgtitle">
                    <span>上传监测日志</span>
                </div>
                <div style="width: 100%; height: 2px; background-color: #63CB30;">
                </div>
               <%-- <div class="uploaddoc">
                    <p>
                        上传报告&nbsp&nbsp&nbsp<a href="MutipleAnalysis.aspx" style="color:blue;font-weight:normal;text-decoration:none;" target="_blank">查看所有报告>></a></p>
                    <div class="adddoc">                       
                        <p>
                            <span>请选择文件:</span>
                            <asp:FileUpload ID="FileUploadBg" runat="server" />
                             </p>
                            <p>
                            <span>请添加文件标题：</span>
                            <asp:TextBox ID="TextBoxBgTitle" runat="server"></asp:TextBox>
                        </p>
                        <div style="width: 15%; margin-left: 565px;">
                            <asp:Button ID="ButtonBg" runat="server" Text="上传" CssClass="mybtn" 
                                onclick="ButtonBg_Click"/>
                        </div>
                    </div>
                </div>--%>
                <div class="uploaddoc">
                    <p>
                        上传监测日志&nbsp&nbsp&nbsp<a href="MonitorLog.aspx" style="color:blue;font-weight:normal;text-decoration:none;" target="_blank">查看所有日志>></a></p>
                    <div class="adddoc"> 
                        
                        <p>
                            <span>请选择文件:</span>
                            <asp:FileUpload ID="FileUploadRz" runat="server" />
                            </p>
                            <p>
                            <span>请添加文件标题:</span>
                            <asp:TextBox ID="TextBoxRzTitle" runat="server"></asp:TextBox>
                        </p>
                        <div style="width: 15%; margin-left: 565px;">
                            <asp:Button ID="ButtonRz" runat="server" Text="上传" CssClass="mybtn" 
                                onclick="ButtonRz_Click"/>
                        </div>
                    </div>
                </div>
            </div>
            <%--<div class="cardcontent" style="margin-top: 10px;">
                <div class="imgtitle">
                    <span>添加卡片内容</span>
                </div>
                <div style="width: 100%; height: 2px; background-color: #63CB30;">
                </div>
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <div style="margin-top: 15px;">
                            <font color="black" face="宋体" size="2">说明：以下为地区卡片中要显示的内容</font>
                        </div>
                        
                        <div style="margin-top: 10px;">
                            <span style="font-size: 14px; font-weight: bold;">管理人员信息</span><br />
                        </div>
                        <div style="margin-top: 15px; width: 82%; float: left;">
                            <span style="font-size: 14px">负责人:</span><br />
                            <asp:TextBox ID="TextBox1" runat="server" Style="width: 280px; height: 25px; font-size: 17px;
                                line-height: 25px;"></asp:TextBox>
                            <br />
                            <span style="font-size: 14px">负责人电话:</span><br />
                            <asp:TextBox ID="TextBox2" runat="server" Style="width: 280px; height: 25px; font-size: 17px;
                                line-height: 25px;"></asp:TextBox><br />
                            <br />
                            <span style="font-size: 14px">联系人:</span><br />
                            <asp:TextBox ID="TextBox3" runat="server" Style="width: 280px; height: 25px; font-size: 17px;
                                line-height: 25px;"></asp:TextBox>
                            <br />
                            <span style="font-size: 14px">联系人电话:</span><br />
                            <asp:TextBox ID="TextBox4" runat="server" Style="width: 280px; height: 25px; font-size: 17px;
                                line-height: 25px;"></asp:TextBox>
                        </div>
                        <div style="margin-top: 250px; width: 15%; float: left;">
                            <asp:Button ID="btnSubmit" runat="server" Text="提交" CssClass="mybtn" OnClick="btnSubmit_Click">
                            </asp:Button>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>--%>
        </div>
    </div>

    <script src="Scripts/select.js" type="text/javascript"></script>
    <script type="text/javascript">
        !function () {
            laydate.skin('molv'); //切换皮肤，请查看skins下面皮肤库
            laydate({ elem: '#demo' }); //绑定元素
        } ();

        //日期范围限制
        var start = {
            elem: '#start',
            format: 'YYYY-MM-DD',
            min: '1979-01-01', //设定最小日期为当前日期laydate.now(),
            max: '2099-06-16', //最大日期
            istime: true,
            istoday: false,
            choose: function (datas) {
                end.min = datas; //开始日选好后，重置结束日的最小日期
                end.start = datas //将结束日的初始值设定为开始日
            }
        };

        var end = {
            elem: '#end',
            format: 'YYYY-MM-DD',
            min: laydate.now(),
            max: '2099-06-16',
            istime: true,
            istoday: false,
            choose: function (datas) {
                start.max = datas; //结束日选好后，充值开始日的最大日期
            }
        };
        laydate(start);
        laydate(end);

        //自定义日期格式
        laydate({
            elem: '#test1',
            format: 'YYYY年MM月DD日',
            festival: true, //显示节日
            choose: function (datas) { //选择日期完毕的回调
                alert('得到：' + datas);
            }
        });

        //日期范围限定在昨天到明天
        laydate({
            elem: '#hello3',
            min: laydate.now(-1), //-1代表昨天，-2代表前天，以此类推
            max: laydate.now(+1) //+1代表明天，+2代表后天，以此类推
        });


        function sendServer() {
            var txt = document.getElementById("Text1").value;

        }


        function transValue() {
            var ediv = document.getElementById("end");
            var etime = ediv.innerHTML;
            var etext = document.getElementById("<%=et.ClientID%>");
            if (etime != "") {
                etext.value = etime;
            } else {
                alert("请选择结束时间");
                return false;

            }

            var sdiv = document.getElementById("start");
            var stime = sdiv.innerHTML;
            var stext = document.getElementById("<%=hidestart.ClientID%>");
            if (stime != "") {
                stext.value = stime;
            } else {
                alert("请选择开始时间");
                return false;
            }

            var a = document.getElementById("communityChoice");
            var aArr = a.getElementsByTagName("a");

            for (i = 0; i < aArr.length; i++) {
                if (hasClass(aArr[i], "oni")) {
                    var e = aArr[i].getElementsByTagName("span");
                    var cvalue = e[0].innerHTML;
                    var com = document.getElementById("<%=com.ClientID%>");
                    com.value = cvalue;
                }
            }            
            return true;
        }

        function transIdValue() {
            var a = document.getElementById("communityChoice");
            var aArr = a.getElementsByTagName("a");

            for (i = 0; i < aArr.length; i++) {
                if (hasClass(aArr[i], "oni")) {
                    var e = aArr[i].getElementsByTagName("span");
                    var cvalue = e[0].innerHTML;
                    var com = document.getElementById("<%=com.ClientID%>");
                    com.value = cvalue;
                   
                    return true;
                }
            }
            return false;
        }
    </script>
</asp:Content>
