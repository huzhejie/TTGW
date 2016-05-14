<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditExcel.aspx.cs" Inherits="TTG.Web.EditExcel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="Css/Main.css" rel="stylesheet" type="text/css" />
    <link href="Css/common.css" rel="stylesheet" type="text/css" />
    <script src="JS/officemain.js" type="text/javascript"></script>
    <script type="text/javascript" language="javascript" event="NotifyCtrlReady" for="WebOffice1">    
	WebOffice1_NotifyCtrlReady()
    </script>
</head>
<body>
    <form id="form1" runat="server" action="upload.aspx">
    <div class="m_container">
        <div class="m_header">
           <%-- <div class="section">
                <div class="m_hleft fl">
                    <div class="m_img fr">
                        <img src="./img/logo.png" alt="" />
                    </div>
                </div>
                <div class="m_hright fl">
                    <div class="title">
                        <p style="font-size: 45px; font-weight: bold;">
                            三峡城镇小区帮扶监测信息平台</p>
                    </div>
                </div>
            </div>--%>
        </div>
        <div class="thinnav">
        </div>
        <div class="m_main">
            <div class="section">
                <div id="officecontainer">
                    <div id="officecontent">
                        <div id="divtitle">
                            <p>
                                <asp:Label ID="Label1" runat="server" Text="Label" CssClass="officetitle"></asp:Label></p>
                        </div>
                        <div style="margin-left: 550px;">
                            <div style="width: 20%; float: left;">
                                <h3 style="font-size: 15px;">
                                    输入文件名：</h3>
                            </div>
                            <div style="width: 78%; float: left;">
                                <asp:TextBox ID="filein" runat="server" Style="height: 22px; width: 300px; line-height: 22px;"></asp:TextBox>
                                <input class="mybtn" id="CreateFile2" onclick="SaveDoc()" type="button" value="修改"
                                    name="CreateFile2" />
                            </div>
                        </div>
                        <div class="fl wfdiv">
                            <script src="JS/LoadWebOffice.js" type="text/javascript"></script>
                            <div class="webalert fl">
                                <p>
                                    如果无法显示excel，请先下载下列内容，安装后重启浏览器</p>
                                <p>
                                    兼容火狐或者谷歌浏览器插件，这个是要先安装的。安装后请重启浏览器<a href="WebOffice安装/ffactivex-setup-r39.exe">点击下载</a></p>
                                <p>
                                    webOffice,确保安装兼容插件后请下载安装此控件，安装后记得重启浏览器哦<a href="WebOffice安装/WebOffice.exe">点击下载</a></p>
                                <p>
                                    温馨提示：如果下载安装后依然不能显示，请先确定你的电脑上是否安装了MicrosoftOffice， 如果已经安装可以尝试使用其他浏览器，推荐使用火狐、360或者IE</p>
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
            </div>
        </div>
        <div class="fl friendLinks">
            <div class="section">
                <div class="fl left">
                    <span>相关链接:</span> <a href="http://www.crhdc.com.cn/" target="_blank">长江水利水电开发总公司</a>
                    | <a href="http://www.3g.gov.cn/index.ycs" target="_blank">国务院三峡工程建设委员会办公室</a> |
                    <a href="http://www.cjw.com.cn/" target="_blank">水利部长江水利委员会</a> | <a href="http://www.mwr.gov.cn/"
                        target="_blank">中国水利部 </a>| <a href="http://www.mohurd.gov.cn/" target="_blank">中国建设部</a>
                    |
                </div>
                <div class="fr right">
                    子公司链接：
                    <select name="compLink" id="compLink" class="selects" onchange="window.open(this.value)">
                        <option value="#">湖北分公司</option>
                        <option value="#">重庆分公司</option>
                        <option value="#">四川分公司</option>
                        <option value="#">云南分公司</option>
                        <option value="#">贵州分公司</option>
                    </select>
                </div>
            </div>
        </div>
        <div class="myfooter">
            <div class="section" style="width: 1000px;">
                <div class="fl footleft">
                    地址：湖北省武汉市江岸区解放大道1863号 邮编：430010 联系电话：027－82820272
                    <br>
                    版权所有© Copyright © 2011 All Rights Reserved 鄂ICP备05003448
                </div>
                <div class="fr footright">
                    <a href="/News/Recruitment.aspx?cid=514">人才招聘 </a>| <a href="/News/Contact.aspx?cid=526">
                        联系我们 </a>| <a href="/News/Message.aspx?cid=516">留言反馈</a><br>
                    总访问量：32768次 <a href="/_JBRIEMS/Index.aspx" target="_blank">管理</a> <a href="http://www.cjwym.com.cn/"
                        target="_blank">技术支持</a>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
<script type="text/javascript" language="javascript">
    function WebOffice1_NotifyCtrlReady() {



        //document.all.WebOffice1.ShowToolBar = false;


        //hideAll('hideall', '', '', '');
        bToolBar_New_onclick();
        bToolBar_Open_onclick();
        bToolBar_Save_onclick();
        bToolBar_Hide_onclick();

        //加载文件
        document.all.WebOffice1.LoadOriginalFile("<%=strNewPath %>", "xls");
        //屏蔽文件菜单项
        document.all.WebOffice1.HideMenuArea("hideall", "", "", "");
    }

  

</script>
<script type="text/javascript">


    function SaveDoc() {

        var webObj = document.getElementById("WebOffice1");
        var nameinput = document.getElementById("filein");
        var file = "<%=title%>";
        var comId = "<%=communityId%>";
        var inid = "<%=invesId%>";
        webObj.HttpInit();
        webObj.HttpAddPostString("fileName", escape(file));
        webObj.HttpAddPostCurrFile("uploadFile", ""); //上传当前文件 
        var returnValue = webObj.HttpPost("http://localhost:8878/upload.aspx?comID=" + comId + "&inID=" + inid + "&state=7");
        if (returnValue == "") {
            alert("文件上传失败");
            return false;
        } else {
            alert("文件上传成功");
            return true;
        }
        }


    }
        
</script>
</html>