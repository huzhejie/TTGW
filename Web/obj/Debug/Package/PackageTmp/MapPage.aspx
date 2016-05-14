<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MapPage.aspx.cs" Inherits="TTG.Web.MapPage" %>

<%@ Register Assembly="ESRI.ArcGIS.ADF.Web.UI.WebControls, Version=10.0.0.0, Culture=neutral, PublicKeyToken=8fc3cc631e44ad86"
    Namespace="ESRI.ArcGIS.ADF.Web.UI.WebControls" TagPrefix="esri" %>
    <%@ Register Assembly="ESRI.ArcGIS.ADF.Web.DataSources, Version=10.0.0.0, Culture=neutral, PublicKeyToken=8fc3cc631e44ad86"
    Namespace="ESRI.ArcGIS.ADF.Web.UI.WebControls" TagPrefix="esri" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head lang="en">
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <link href="dituCss/css/Main.css" rel="stylesheet" type="text/css" />
    <link href="dituCss/css/index.css" rel="stylesheet" />
    <link href="dituCss/css/ditu.css" rel="stylesheet" />
    <link href="dituCss/css/dituimg.css" rel="stylesheet" />
    <link href="dituCss/css/dialog.css" rel="stylesheet" />
    <link href="dituCss/css/zzj/map_page.css" rel="Stylesheet" />
    <style type="text/css">
        .searchItem:hover
        {
            background-color: #f6f6f6;
            cursor: pointer;
        }
        .scrollDiv
        {
            float: left;
            width: 9px;
            margin: 5px 5px 5px 0px;
            position: relative;
        }
    </style>
    <style type="text/css">
        #banner
        {
            position: relative;
            width: 478px;
            height: 320px;
            border: 1px solid #666;
            overflow: hidden;
        }
        #banner_list img
        {
            border: 0px;
        }
        #banner_bg
        {
            position: absolute;
            bottom: 0;
            background-color: #000;
            height: 30px;
            filter: Alpha(Opacity=30);
            opacity: 0.3;
            z-index: 1000;
            cursor: pointer;
            width: 478px;
        }
        #banner_info
        {
            position: absolute;
            bottom: 0;
            left: 5px;
            line-height: 30px;
            color: #fff;
            z-index: 1001;
        }
        #banner_text
        {
            position: absolute;
            width: 120px;
            z-index: 1002;
            right: 3px;
            bottom: 3px;
        }
        #banner ul
        {
            position: absolute;
            list-style-type: none;
            filter: Alpha(Opacity=75);
            opacity: 0.75;
            border: 1px solid #fff;
            z-index: 1002;
            margin: 0;
            padding: 0;
            bottom: 3px;
            right: 5px;
        }
        #banner ul li
        {
            padding: 0px 8px;
            float: left;
            display: block;
            color: #FFF;
            border: #fff 1px solid;
            background-color: #6f4f67;
            cursor: pointer;
        }
        #banner ul li.onset
        {
            background-color: #900;
        }
        #banner_list a
        {
            position: absolute;
        }
        .table-bordered th, .table-bordered td
        {
            border: 1px solid #ddd !important;
            text-align: center;
        }
    </style>
    <title></title>
</head>
<body>
    <div class="m_container">
        <div class="m_header" id="topHeader">
            <div class="section">
                <div class="m_hleft fl">
                    <div class="m_img fr">
                        <img src="Images/logo.png" alt="" />
                    </div>
                </div>
                <div class="m_hright fl">
                    <div class="title">
                        <p style="font-size: 45px; font-weight: bold;">
                            三峡城镇小区帮扶监测信息平台</p>
                    </div>
                </div>
            </div>
        </div>
        <div class="thinnav" id="topNav" style="height: 30px; background-color: #63CB30;
            vertical-align: middle; position: relative;">
            <input type="text" id="searchInput" style="position: absolute; top: 2px; right: 80px;
                padding: 2px 4px;" />
            <button style="position: absolute; top: 2px; right: 40px; padding: 2px 4px;" id="btnSearch">
                搜索
            </button>
        </div>
        <div class="m_main" style="position: relative; width: 100%;">
            <!--放置地图-->
            <form id="form1" runat="server">
            <div id="MapHolder" style="height: 544px; overflow: hidden; position: relative; text-align: left;
                margin-left: 311px; background-image: url(http://webmap0.map.bdstatic.com/image/api/bg.png);">
                <div id="SVGContainerA" style="width: 100%; height: 100%; position: absolute; left: 0px;
                    top: 0px; z-index: 580; display: none; cursor: url('images/zzj/ruler.cur'),auto;">
                    <!--<svg id="svg" xmlns="http://www.w3.org/2000/svg" version="1.1" width="100%" height="100%" style="z-index:598;">
		            </svg>-->
                </div>
                <div id="SVGContainerD" style="width: 100%; height: 100%; position: absolute; left: 0px;
                    top: 0px; z-index: 590; display: none; cursor: url('images/zzj/ruler.cur'),auto;">
                    <!--<svg id="svg" xmlns="http://www.w3.org/2000/svg" version="1.1" width="100%" height="100%" style="z-index:598;">
		            </svg>-->
                </div>
                <esri:MapResourceManager ID="MapResourceManager1" runat="server">
                    <ResourceItems>
                        <esri:MapResourceItem Definition="&lt;Definition DataSourceDefinition=&quot;In Memory&quot; DataSourceType=&quot;GraphicsLayer&quot; Identity=&quot;&quot; ResourceDefinition=&quot;&quot; /&gt;"
                            DisplaySettings="visible=True:transparency=0:mime=True:imgFormat=PNG8:height=100:width=100:dpi=96:color=:transbg=False:displayInToc=True:dynamicTiling="
                            LayerDefinitions="" Name="Buffer" />
                        <esri:MapResourceItem Definition="&lt;Definition DataSourceDefinition=&quot;http://localhost/arcgis/services&quot; DataSourceType=&quot;ArcGIS Server Internet&quot; Identity=&quot;Uz6KdRH1PwWQbGLPcZzsKt+MQf/4Q6RO&quot; ResourceDefinition=&quot;图层@涪陵&quot; /&gt;"
                            DisplaySettings="visible=True:transparency=0:mime=True:imgFormat=PNG8:height=100:width=100:dpi=96:color=:transbg=False:displayInToc=True:dynamicTiling="
                            LayerDefinitions="" Name="MapResourceItem0" />
                    </ResourceItems>
                </esri:MapResourceManager>
                <div class="zone_change">
                    <!--   <a href="#" onclick="return false" class="zone_change_inner zone_change_shadow">
                    <span>开县</span>
                    <i>
                        <em>
                        </em>
                    </i>
                    <b></b>
                </a>  -->
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>涪陵</asp:ListItem>
                        <asp:ListItem Value="万州">万州</asp:ListItem>
                        <asp:ListItem Value="万寿">万寿</asp:ListItem>
                        <asp:ListItem>云阳</asp:ListItem>
                        <asp:ListItem>兴山</asp:ListItem>
                        <asp:ListItem>夷陵</asp:ListItem>
                        <asp:ListItem>奉节</asp:ListItem>
                        <asp:ListItem>巴东</asp:ListItem>
                        <asp:ListItem>开县</asp:ListItem>
                        <asp:ListItem>忠县</asp:ListItem>
                        <asp:ListItem>武隆</asp:ListItem>
                        <asp:ListItem>石柱</asp:ListItem>
                        <asp:ListItem>巫山</asp:ListItem>
                        <asp:ListItem>丰都</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <!--放置在地图上层的div 放置工具条 参考资料书-->
                <esri:Toolbar ID="Toolbar1" runat='server' Height='50px' Width='650px' Style="position: absolute;
                    top: 0; right: 0; z-index: 604" BuddyControlType="Map" Group="Toolbar1_Group"
                    ToolbarItemDefaultStyle-BackColor="White" ToolbarItemDefaultStyle-Font-Names="Arial"
                    ToolbarItemDefaultStyle-Font-Size="Smaller" ToolbarItemDisabledStyle-BackColor="White"
                    ToolbarItemDisabledStyle-Font-Names="Arial" ToolbarItemDisabledStyle-Font-Size="Smaller"
                    ToolbarItemDisabledStyle-ForeColor="Gray" ToolbarItemHoverStyle-BackColor="White"
                    ToolbarItemHoverStyle-Font-Bold="True" ToolbarItemHoverStyle-Font-Italic="True"
                    ToolbarItemHoverStyle-Font-Names="Arial" ToolbarItemHoverStyle-Font-Size="Smaller"
                    ToolbarItemSelectedStyle-BackColor="White" ToolbarItemSelectedStyle-Font-Bold="True"
                    ToolbarItemSelectedStyle-Font-Names="Arial" ToolbarItemSelectedStyle-Font-Size="Smaller"
                    WebResourceLocation="/aspnet_client/ESRI/WebADF/">
                    <BuddyControls>
                        <esri:BuddyControl Name="Map1" />
                    </BuddyControls>
                    <ToolbarItems>
                        <esri:Tool ClientAction="DragRectangle" DefaultImage="esriZoomIn.gif" JavaScriptFile=""
                            Name="MapZoomIn" SelectedImage="esriZoomInD.gif" ServerActionAssembly="ESRI.ArcGIS.ADF.Web.UI.WebControls"
                            ServerActionClass="ESRI.ArcGIS.ADF.Web.UI.WebControls.Tools.MapZoomIn" Text="放大"
                            ToolTip="放大" />
                        <esri:Tool ClientAction="DragRectangle" DefaultImage="esriZoomOut.gif" JavaScriptFile=""
                            Name="MapZoomOut" SelectedImage="esriZoomOutD.gif" ServerActionAssembly="ESRI.ArcGIS.ADF.Web.UI.WebControls"
                            ServerActionClass="ESRI.ArcGIS.ADF.Web.UI.WebControls.Tools.MapZoomOut" Text="缩小"
                            ToolTip="缩小" />
                        <esri:Tool ClientAction="DragImage" DefaultImage="esriPan.gif" JavaScriptFile=""
                            Name="MapPan" SelectedImage="esriPanD.gif" ServerActionAssembly="ESRI.ArcGIS.ADF.Web.UI.WebControls"
                            ServerActionClass="ESRI.ArcGIS.ADF.Web.UI.WebControls.Tools.MapPan" Text="移动"
                            ToolTip="移动" />
                        <esri:Command ClientAction="" DefaultImage="esriFullExt.gif" JavaScriptFile="" Name="MapFullExtent"
                            ServerActionAssembly="ESRI.ArcGIS.ADF.Web.UI.WebControls" ServerActionClass="ESRI.ArcGIS.ADF.Web.UI.WebControls.Tools.MapFullExtent"
                            Text="全图" ToolTip="显示全图" />
                        <esri:Command BuddyItem="MapForward" ClientAction="ToolbarMapBack" DefaultImage="esriBack.gif"
                            Disabled="True" DisabledImage="esriBack.gif" JavaScriptFile="" Name="MapBack"
                            SelectedImage="esriBackD.gif" Text="回退" ToolTip="回退" />
                        <esri:Command BuddyItem="MapBack" ClientAction="ToolbarMapForward" DefaultImage="esriForward.gif"
                            Disabled="True" DisabledImage="esriForward.gif" JavaScriptFile="" Name="MapForward"
                            SelectedImage="esriForwardD.gif" Text="前进" ToolTip="前进" />
                        <esri:Tool ClientAction="toggleOverviewMap();" DefaultImage="~/images/zzj/show-overview-map.png"
                            JavaScriptFile="" Name="Overview" Text="鹰眼" ToolTip="鹰眼" />
                        <esri:Tool ClientAction="MeasureDClientAction();" DefaultImage="~/images/zzj/measure-line.png"
                            JavaScriptFile="" Name="MeasureD" Text="测距" ToolTip="测量距离" />
                        <esri:Tool ClientAction="MeasureAClientAction();" DefaultImage="~/images/zzj/measure-poly.png"
                            JavaScriptFile="" Name="MeasureA" Text="测面积" ToolTip="测量面积" />
                        <esri:Tool ClientAction="" DefaultImage="~/images/zzj/full_screen.png" JavaScriptFile=""
                            Name="FullScreen" Text="全屏" ToolTip="全屏" />
                        <esri:Tool ClientAction="" DefaultImage="~/images/zzj/buffer.png" JavaScriptFile=""
                            Name="BufferAnalysis" Text="缓冲" ToolTip="查看元素的影响范围" />
                    </ToolbarItems>
                </esri:Toolbar>

                <esri:OverviewMap ID="OverviewMap1" runat='server' Height='200px' Width='200px' Map="Map1"
                    MapResourceManager="MapResourceManager1" OverviewMapResource="MapResourceItem0"
                    Style="position: absolute; top: 50px; right: 0px; z-index: 600; visibility: hidden"
                    StaticMode="False" />
                <esri:Map ID="Map1" runat="server" Width="100%" Height="100%" MapResourceManager="MapResourceManager1"
                    Style="width: 100%; height: 100%; z-index: -1">
                </esri:Map>
                
                    
                        <a href="http://localhost:8089/sl-broswer/browser/index.html" title="3D地图"style="position: absolute; bottom: 60px; right: 10px; z-index: 604;
                        width: 49px; height: 46px; background: url(images/maptype.png) 0px -46px no-repeat transparent;" target="_blank">
                         
                        </a>
                   
                
            </div>


            </form>
            <div class="mapChoice" id="mapChoicePanel">
                <div class="fl" id="tangramScroll">
                    <div id="mapInfo">
                        <div class="mapIndexBox" id="mapIndex">
                            <div class="mapSpecialBox">
                                <ul class="mapIndexList" id="mapIndexList">
                                    <li>
                                        <div class="mapListItem cater">
                                        </div>
                                        <span class="city-list-title">找医院</span> </li>
                                    <li>
                                        <div class="mapListItem hotel">
                                        </div>
                                        <span class="city-list-title">找学校</span> </li>
                                    <li>
                                        <div class="mapListItem movie">
                                        </div>
                                        <span class="city-list-title">找小区</span> </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="shad" class="mapInfo">
                <div id="MapInfoTab" class="mapinfo_but " title="收起左栏" style="top: 195px;" onclick="show()">
                    <div class="mapinfo_but_con">
                        <span class="mapinfo_but_span"></span>
                    </div>
                </div>
            </div>
        </div>
        <div class="fl friendLinks" id="friendLink">
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
        f
        <div class="myfooter" id="footer">
            <div class="section" style="width: 1000px;">
                <div class="fl footleft">
                    地址：湖北省武汉市江岸区解放大道1863号 邮编：430010 联系电话：027－82820272
                    <br />
                    版权所有© Copyright © 2011 All Rights Reserved 鄂ICP备05003448
                </div>
                <div class="fr footright">
                    <a href="/News/Recruitment.aspx?cid=514">人才招聘 </a>| <a href="/News/Contact.aspx?cid=526">
                        联系我们 </a>| <a href="/News/Message.aspx?cid=516">留言反馈</a><br />
                    总访问量：32768次 <a href="/_JBRIEMS/Index.aspx" target="_blank">管理</a> <a href="http://www.cjwym.com.cn/"
                        target="_blank">技术支持</a>
                </div>
            </div>
        </div>
    </div>
    <!-- <script type="text/javascript" src="dituJs/js/zzj/jquery.js"></script>-->
    <!--<script type="text/javascript" src="dituJs/js/zzj/jquery-ui.js"></script>-->
    <script src="echarts-2.2.7/build/dist/echarts.js" type="text/javascript"></script>
    <script type="text/javascript" src="dituJs/js/data.js"></script>
    <script type="text/javascript" src="dituJs/js/zzj/callout.js"></script>
    <script type="text/javascript" src="dituJs/js/zzj/FloationgPanel.js"></script>
    <script type="text/javascript" src="dituJs/js/zzj/map_page.js"></script>
    <!--<script type="text/javascript" src="dituJs/js/index.js"></script>-->
    <script type="text/javascript" src="dituJs/js/zzj/MeasureD.js"></script>
    <script type="text/javascript" src="dituJs/js/zzj/MeasureA.js"></script>
    <script type="text/javascript" src="dituJs/js/babyzone.js"></script>
    <script type="text/javascript" src="dituJs/js/jscroll.js"></script>
    <!--zzj js 代码-->
    <script type="text/javascript">
    //测试图层显示
    var index=0;
    Sys.Application.add_init(init);
    //显示项目图层
    function showProject(){
        var message="ShowProject:"+index;
        index++;
        var context="Map1";
        <%=m_ShowProjectCallback %>
    }
     //自定义callout前台调用函数
    function startCallback(x, y) {
        //返回屏幕坐标用于查询内容
        var message = "Callout:"+x + "&" + y;
        var context = "Map1";
        <%=m_CalloutCallback %>
    }
    //点击某一个子选项的操作
    function SelectOneItem(name,index){
        var message="SelectItem:"+name+":"+index;
        var context="Map1";
        <%=m_SelectItemCallback %>
    }
    //处理子项的回调
    function processSelectItem(response){
        var json=eval('('+response+')');
        selectProcess(json);
    }
    //搜索框的回车事件
    function EnterPress(e){
        var e=e||window.event;
        if(e.keyCode==13){
            var search=document.getElementById("searchInput").value;
            var message="Search:"+search;
            var context="Map1";
            <%=m_SearchCallback %>
        }
        return false;
    }

    function btnSearch(){
         var search=document.getElementById("searchInput").value;
            var message="Search:"+search;
            var context="Map1";
            <%=m_SearchCallback %>
    }
    //处理缓冲区的部分
    function SelectBuffer(clear){
        var isIE=false;
        var n=navigator.userAgent;
        var result =n.search(/Trident/i);
        if(result>0)
            isIE=true;
        var message="Buffer:"+bufferX+":"+bufferY+":"+clear+":"+isIE;
        var context="Map1";
        <%=m_BufferCallback %>
    }
    //清理缓冲区分析图形
    function ClearBuffer(){
        var message="ClearBuffer:";
        var context="Map1";
        <%=m_ClearBufferCallback %>
    }
    </script>
    <script type="text/javascript">
    
    var data; //全局数据
    var PageSize = 9; //每页个数
    var Page = 1; //当前页码
    var BeginNO;
    var EndNO;
    var choicePanel = $getId("mapChoicePanel");
    var choice = $getId("choice");
    var panel = $getId("mapChoicePanel");
    var mapHolder = $getId("MapHolder");
    var topHeader = $getId("topHeader");
    var mapInfoTab = $getId("MapInfoTab");
    var topNav = $getId("topNav");
    var friendLink = $getId("friendLink");
    var footer = $getId("footer");
    var shad = $getId("MapInfoTab");
    var mapCp = $getId("tangramScrollPanel");
    var tempStr;


    
    function $getId(id) {
        return document.getElementById(id); //定义获取ID的方法
    }

    function siblings(elem) {
        var a = [];
        var b = elem.parentNode.children;
        for (var i = 0; i < b.length; i++) {
            if (b[i] !== elem) a.push(b[i]);
        }
        return a;
    }
    function getByClass(oParent, sClass) {
        var aEle = oParent.getElementsByTagName('*');
        var aResult = [];
        var re = new RegExp('\\b' + sClass + '\\b', 'i');
        var i = 0;
        for (i = 0; i < aEle.length; i++) {
            if (re.test(aEle[i].className)) {
                aResult.push(aEle[i]);
            }
        }
        return aResult;
    }
  
    function show() {
        if (mapInfoTab.title == "收起左栏") {
            panel.style.left = "-326px";
            mapHolder.style.marginLeft = "0px";
            mapInfoTab.title = "显示左栏";
            shad.style.left = "0px";
        } else {
            panel.style.left = "0px";
            mapHolder.style.marginLeft = "326px";
            mapInfoTab.title = "收起左栏";
            shad.style.left = "326px";
        }
    }
    function pageChange(jsonLength) {
        var Pages = Math.floor((jsonLength.length - 1) / PageSize) + 1; //总页数
        if (Page < 1) Page = 1;  //如果当前页码小于1
        if (Page > Pages) Page = Pages; //如果当前页码大于总数
        var Temp = "";
        BeginNO = (Page - 1) * PageSize + 1; //开始编号
        EndNO = Page * PageSize; //结束编号
        if (EndNO > jsonLength.length) EndNO = jsonLength.length;
        if (EndNO == 0) BeginNO = 0;
        // if(!(Page <= Pages)) Page = Pages;
        // $("total").innerHTML = "Total:<strong class='f90'>" + sites.length + "</strong>&nbsp;&nbsp;Show:<strong class='f90'>" + BeginNO + "-" + EndNO + "</strong>";
        //分页
        if (Page > 1 && Page !== 1) {
            Temp += "<span><a href='javascript:void(0)' onclick='GotoPage(" + (Page - 1) + ")'>前一页</a></span>&nbsp;";
            //"<a href='javascript:void(0)' onclick='GotoPage(1)'>&lt;&lt;Index</a>" +
        } else {
            Temp += "前一页&nbsp;";
        }
        //完美的翻页列表
        var PageFrontSum = 3; //当页前显示个数
        var PageBackSum = 3; //当页后显示个数
        var PageFront = PageFrontSum - (Page - 1);
        var PageBack = PageBackSum - (Pages - Page);
        if (PageFront > 0 && PageBack < 0) PageBackSum += PageFront; //前少后多，前剩余空位给后
        if (PageBack > 0 && PageFront < 0) PageFrontSum += PageBack; //后少前多，后剩余空位给前
        var PageFrontBegin = Page - PageFrontSum;
        if (PageFrontBegin < 1) PageFrontBegin = 1;
        var PageFrontEnd = Page + PageBackSum;
        if (PageFrontEnd > Pages) PageFrontEnd = Pages;
        if (PageFrontBegin != 1) Temp += '<a href="javascript:void(0)" onclick="GotoPage(' + (Page - 10) + ')" title="前10页">..</a>';
        for (var i = PageFrontBegin; i < Page; i++) {
            Temp += " <a href='javascript:void(0)' onclick='GotoPage(" + i + ")'>" + i + "</a>";
        }
        Temp += " <strong class='f90'>" + Page + "</strong>";
        for (var i = Page + 1; i <= PageFrontEnd; i++) {
            Temp += " <a href='javascript:void(0)' onclick='GotoPage(" + i + ")'>" + i + "</a>";
        }
        if (PageFrontEnd != Pages) {
            Temp += " <a href='javascript:void(0)' onclick='GotoPage(" + (Page + 10) + ")' title='后10页'>..</a>";
        }
        if (Page != Pages) {
            Temp += "&nbsp;&nbsp;<a href='javascript:void(0)' onclick='GotoPage(" + (Page + 1) + ");'>下一页</a> ";
            //      "<a href='javascript:void(0)' onclick='GotoPage(" + Pages + ")'>Last&gt;&gt;</a>"
        } else {
            Temp += "&nbsp;&nbsp;下一页"
        }
        tempStr = Temp;
    }
    function Output(jsonStr) {
        data = jsonStr;
        pageChange(jsonStr); //输出数据
        if (EndNO == 0) { //如果为空
            $getId("mapInfo").innerHTML += "<h1>没有搜索结果</h1>";
            return;
        }
        var choiceText = '';
        var str = " ";
       // var divPos = document.createElement("div"); //创建地图上的对象
       // divPos.setAttribute("className", "BMap");
        var divPosStr = '';
        var itemNum = (EndNO - BeginNO) + 2;
        choiceListHeight = itemNum * 80;
        choiceText += '<div class="fl tangramScrollPanel" id="tangramScrollPanel"><div class="choiceList" id="choiceList" style="height:' + choiceListHeight + 'px"><div class="searchContent" id="content">';
        choiceText += '<ul id="myChoi" class="">';
        for (var o = BeginNO - 1; o < EndNO; o++) {
            str += '<li class="searchItem" >';
            str += '<div class="mb5 cf">';
            str += '<div class="choiceListR">';
            str += '<div class="imgWrap"> <a target="_blank" >  ';
            str += '<img style="width:71px;height:58px;" src="' + jsonStr[o].url + '">';
            str += '</a></div></div>';
            str += '<div class="ml30 mr85">';
            str += '<div class="row">';
            str += '<span><a href="#"  id="' + o + '" class="nblue" type="' + jsonStr[o].type + '" >' + jsonStr[o].name + '</a></span>';
            str += '<br/>';
            str += '<div class="row addr"><span class="ngrey" title="' + jsonStr[o].address + '">' + jsonStr[o].address + '</span></div>';
            str += '</div></div>';
            str += "</li>";
           //divPosStr += '<span class="BMap_Marker BMap_noprint" style="position: absolute; padding: 0px; margin: 0px; border: 0px; cursor: pointer; width: 21px; height: 32px; left: 23px; top:47px; z-index: 997;" title="虾皇潜江油焖大虾(虎泉街旗舰店)">aaa</span>';
        }
        choiceText += str;
        choiceText += "</ul>";
        choiceText += '</div></div><div id="pager" style="margin:36px 0;z-index:555;">  <div id="pagelist" style="text-align: center;">';
        choiceText += tempStr;
        choiceText += '</div> </div></div>';
       //divPos.innerHTML = divPosStr;
       //mapHolder.appendChild(divPos);
        $getId("mapInfo").innerHTML += choiceText;
        new addScroll('mapChoicePanel', 'tangramScrollPanel', 'scrollDiv');
        clickShow(); //调用鼠标点击事件
    }
    //鼠标点击事件
    function clickShow() {
        var links = $getId("content").getElementsByTagName("a");
        for (var i = 0; i < links.length; i++) {
            links[i].onclick = function () {
                showLink(this);
                return false;
            }
        }
    }

    //鼠标点击完显示内容
    function showLink(source) {
        //innerHTML代表名称
// type代表的是选中的类型
        SelectOneItem(source.innerHTML, source.type);
    }

    function GotoPage(num) { //跳转页
        Page = num;
        //  alert($getId("mapInfo").childNodes[1].innerHTML);
        var removeItem = $getId("tangramScrollPanel");
        removeItem.parentNode.removeChild(removeItem);
        var removeScroll = $getId("scrollBg");
        removeScroll.parentNode.removeChild(removeScroll);
        // var removeScroll= $getId("mapChoicePanel").siblings($getId("tangramScroll"));
        //  removeScroll.remove();
        // $getId("mapInfo").removeChild();
        //for(var i in removeScroll){
        //    removeScroll[i].remove();
        Output(data);
    }
    window.onload = function () {
        
        indexShow();
    }
    function back() {
        var baseStr = '<div class="fl" id="tangramScroll"><div id="mapInfo"><div class="mapIndexBox" id="mapIndex">';
        baseStr += '<div class="mapSpecialBox">';
        baseStr += '<ul class="mapIndexList" id="mapIndexList">';
        baseStr += '<li><div class="mapListItem cater"></div> <span class="city-list-title">找医院</span> </li>';
        baseStr += '<li><div class="mapListItem hotel"></div><span class="city-list-title">找学校</span>    </li>';
        baseStr += '<li><div class="mapListItem movie"></div><span class="city-list-title">找小区</span></li>';

        baseStr += '</ul>';
        baseStr += '</div></div></div>';
        choicePanel.innerHTML = baseStr;
        indexShow();
        var objs = getByClass(mapHolder, "BMap_Marker");
        for (var i = 0; i < objs.length; i++) {
            objs[i].parentNode.removeChild(objs[i]);
        }
    }
    function indexShow(){
        var objUl = $getId("mapIndexList");
        var objLi;
        objLi = objUl.getElementsByTagName("li");
        for (var index = 0; index < objLi.length; index++) {
            (function () {
                var temp = index;
                window.selectId = temp;
                objLi[index].onclick = function () {            
                    //根据点击的项目从后台获取对应的数据项目
                        var message = "SelectLayer:" + temp;
                        var context = "Map1";
                        <%=m_SelectLayerCallback %>
                }
            })();
        }
    }
    function fullScreen() {
        var tool=document.getElementById("fullscreen");
        if (tool.Text != "返回") {
            panel.style.display = "none";
            mapHolder.style.marginLeft = "0px";
            topNav.style.display = "none";
            topHeader.style.display="none";
            friendLink.style.display = "none";
            footer.style.display = "none";
            var holder=$getId("MapHolder");
            holder.style.height=window.innerHeight+"px";
            tool.Text = "返回";
        } else {
            panel.style.display = "block";
            topHeader.style.display = "block";
            mapHolder.style.marginLeft = "326px";
            topNav.style.display = "block";
            friendLink.style.display = "block";
            footer.style.display = "block";
            tool.Text = "全屏";
        }
    }

    
    $getId("btnSearch").onclick = btnSearch;
    </script>
</body>
</html>
