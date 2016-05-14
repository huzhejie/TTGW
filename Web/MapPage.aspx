<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MapPage.aspx.cs" Inherits="TTG.Web.MapPage" %>

<%@ Register Assembly="ESRI.ArcGIS.ADF.Web.UI.WebControls, Version=10.0.0.0, Culture=neutral, PublicKeyToken=8fc3cc631e44ad86"
    Namespace="ESRI.ArcGIS.ADF.Web.UI.WebControls" TagPrefix="esri" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head lang="en">
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <link href="dituCss/css/Main.css" rel="stylesheet" type="text/css" />
    <link href="dituCss/css/index.css" rel="stylesheet" type="text/css" />
    <link href="dituCss/css/ditu.css" rel="stylesheet" />
    <link href="dituCss/css/dituimg.css" rel="stylesheet" />
    <link href="dituCss/css/dialog.css" rel="stylesheet" />
    <link href="dituCss/css/banner.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
            /**********************此部分为页面加载时候需要的**不要移动位置*************************************/
            function SelectOneItem(name,index){
                var message="SelectItem:"+name+":"+index;
                var context="Map1";
                <%=m_SelectItemCallback %>
             }

            function btnSearch(){
                    var search=document.getElementById("searchInput").value;
                    var message="Search:"+search;
                    var context="Map1";
                    <%=m_SearchCallback %>
            }

             function searchCom(search){     //搜索框的回车事
                var message="Search:"+search;
                var context="Map1";
                <%=m_SearchCallback %>
              }

              //处理搜索的回调
            function processSearch(response, context) {
                if (response == "]") {
                    alert("抱歉，没有找到匹配项");
                    return;
                }
                var json = eval('(' + response + ')');
                showList(json);
            }
           /**********************此部分为页面加载时候需要的***************************************/


        </script>
    <title></title>
</head>
<body>
    <div class="" style="">
        
        <div class="m_header" id="topHeader">
            
                <img src="Images/title_img.png" alt="" />
            
        </div>

        <!--搜索栏-->
        <div class="thinnav" id="topNav" >
            <input type="text" id="searchInput" />
            <button style="" id="btnSearch">
                搜索
            </button>
        </div>
        <!--搜索栏-->
        <!--地图主要部分-->
        <div class="m_main" style="position: relative; width: 100%;">
            <!--放置地图-->
            <form id="form1" runat="server">
            <div id="MapHolder" >
              
              
              
               <!--Svg Container 用于绘图的三个panel--->
                <div id="SVGContainerA" class="drawingPanel">
                </div>
                <div id="SVGContainerD" class="drawingPanel">           
                </div>
                <div id="SVGContainerC" class="drawingPanelC">
                </div>
                <!--Svg Container 用于绘图的三个panel--->
               
               
                <esri:MapResourceManager ID="MapResourceManager1" runat="server">
                    <ResourceItems>
                        <esri:MapResourceItem Definition="&lt;Definition DataSourceDefinition=&quot;In Memory&quot; DataSourceType=&quot;GraphicsLayer&quot; Identity=&quot;&quot; ResourceDefinition=&quot;&quot; /&gt;"
                            DisplaySettings="visible=True:transparency=0:mime=True:imgFormat=PNG8:height=100:width=100:dpi=96:color=:transbg=False:displayInToc=True:dynamicTiling="
                            LayerDefinitions="" Name="Buffer" />
                        <esri:MapResourceItem Definition="&lt;Definition DataSourceDefinition=&quot;http://localhost/arcgis/services&quot; DataSourceType=&quot;ArcGIS Server Internet&quot; Identity=&quot;Uz6KdRH1PwWQbGLPcZzsKt+MQf/4Q6RO&quot; ResourceDefinition=&quot;图层@万州&quot; /&gt;"
                            DisplaySettings="visible=True:transparency=0:mime=True:imgFormat=PNG8:height=100:width=100:dpi=96:color=:transbg=False:displayInToc=True:dynamicTiling="
                            LayerDefinitions="" Name="MapResourceItem0" />
                    </ResourceItems>
                </esri:MapResourceManager>

                <!--地图切换-->
                <div class="zone_change">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>涪陵</asp:ListItem>
                        <asp:ListItem Value="万州">万州</asp:ListItem>
                        <asp:ListItem Value="长寿">长寿</asp:ListItem>
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
                <!--地图切换-->

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
                    WebResourceLocation="/aspnet_client/ESRI/WebADF/" 
                    >
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
                        <esri:Tool ClientAction="" DefaultImage="~/Images/zzj/full_screen.net.png" JavaScriptFile=""
                            Name="FullScreen" Text="全屏" ToolTip="全屏" />
                        
                        <esri:Tool ClientAction="DrawingCircle();" JavaScriptFile="" Name="buff" 
                            Text="缓冲分析" DefaultImage="~/Images/zzj/buffer.png"/>
                      
                    </ToolbarItems>
                </esri:Toolbar>

                <esri:OverviewMap ID="OverviewMap1" runat='server'  Map="Map1"
                    MapResourceManager="MapResourceManager1" OverviewMapResource="MapResourceItem0"
                    StaticMode="False" />
                <esri:Map ID="Map1" runat="server" style=" width: 100%; height: 100%; z-index: -1 " MapResourceManager="MapResourceManager1">
                </esri:Map>

                <a class="link3d" href="http://localhost:8089/sl-broswer/browser/index.html" title="3D地图" target="_blank">
                </a>    
            </div>


            </form>
            <!--放置地图-->
            <!--左边栏-->
            <div class="mapChoice" id="mapChoicePanel">
                <div class="fl" id="tangramScroll">
                    <div id="mapInfo">
                        <div class="mapIndexBox" id="mapIndex">
                            <div class="mapSpecialBox">
                                <ul class="mapIndexList" id="mapIndexList">
                                    <li>
                                        <div class="mapListItem cater">
                                        </div>
                                        <span class="cityListTitle">找医院</span> </li>
                                    <li>
                                        <div class="mapListItem hotel">
                                        </div>
                                        <span class="cityListTitle">找学校</span> </li>
                                    <li>
                                        <div class="mapListItem movie">
                                        </div>
                                        <span class="cityListTitle">找小区</span> </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            
            <div id="shad" class="mapInfo">
                <div id="MapInfoTab" class="mapInfoTab " title="收起左栏" style="top: 195px;" onclick="show()">
                    <div class="mapinfo_but_con">
                        <span class="mapinfo_but_span"></span>
                    </div>
                </div>
            </div>
            <!--左边栏-->

        </div>
        <!--地图主要部分-->

        <!--底部连接-->
        <div class="fl friendLinks" id="friendLink">
            <div class="section">
                <div class="fl left">
                    <span>相关链接:</span> <a href="http://www.crhdc.com.cn/" target="_blank">长江水利水电开发总公司</a>
                    | <a href="http://www.3g.gov.cn/index.ycs" target="_blank">国务院三峡工程建设委员会办公室</a> |
                    <a href="http://www.cjw.gov.cn/Index.html" target="_blank">水利部长江水利委员会</a> | <a href="http://www.mwr.gov.cn/"
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
        <!--底部连接-->
    </div>
 
    <script src="echarts-2.2.7/build/dist/echarts.js" type="text/javascript"></script>
    <script src="JS/util.js" type="text/javascript"></script>
    <!--zzj js 代码-->

    <!--基本的数据定义-->
    <script src="dituJs/js/zzj/base.js" type="text/javascript"></script>
    <!--基本的数据定义-->

    <!--处理回调函数-->
    <script type="text/javascript" src="dituJs/js/zzj/map_page.js"></script> 
    <!--处理回调函数-->
    
    <!--地图弹出还有Init函数-->
    <script type="text/javascript" src="dituJs/js/zzj/callout.js"></script>
    <!--地图弹出还有Init函数-->

    <script type="text/javascript">
       Sys.Application.add_init(init);//加载页面初始化的Arcgis函数
        window.onload = function () {
            indexShow();
        } 
    function showProject(){         //显示项目图层
        var message="ShowProject:"+index;
        index++;
        var context="Map1";
        <%=m_ShowProjectCallback %>
    }
    
    function startCallback(x, y) {  //自定义callout前台调用函数
        //返回屏幕坐标用于查询内容
        var message = "Callout:"+x + "&" + y;
        var context = "Map1";
        <%=m_CalloutCallback %>
    }
    //点击某一个子选项的操作
    
   
    function processSelectItem(response){  //处理子项的回调
        var json=eval('('+response+')');
        selectProcess(json);
    }
    
    function EnterPress(e){     //搜索框的回车事件
        var e=e||window.event;
        if(e.keyCode==13){
            var search=document.getElementById("searchInput").value;
            var message="Search:"+search;
            var context="Map1";
            <%=m_SearchCallback %>
        }
        return false;
    }

   

    function SelectBuffer(clear){           //处理缓冲区的部分
        var isIE=false;
        var n=navigator.userAgent;
        var result =n.search(/Trident/i);
        if(result>0)
            isIE=true;
        var message="Buffer:"+bufferX+":"+bufferY+":"+clear+":"+isIE;
        var context="Map1";
      
        <%=m_BufferCallback %>
    }

    function ClearBuffer(){    //清理缓冲区分析图形
        var message="ClearBuffer:";
        var context="Map1";
        <%=m_ClearBufferCallback %>
    }

   function indexShow(){   //左边栏的列表
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
    
    </script>


    <!--地图鹰眼函数-->
    <script type="text/javascript" src="dituJs/js/zzj/FloationgPanel.js"></script>
    <!--地图鹰眼函数-->

    <!--页面结构变化的函数-->
    <script src="dituJs/js/zzj/pageOperate.js" type="text/javascript"></script>  
    <!--页面结构变化的函数-->

    <!--页面左边栏项目变化的函数-->
    <script src="dituJs/js/zzj/itemChange.js" type="text/javascript"></script>
    <!--页面左边栏项目变化的函数-->
    
    <!--测量距离的函数-->
    <script type="text/javascript" src="dituJs/js/zzj/MeasureD.js"></script>
    <!--测量距离的函数-->

    <!--测量面积的函数-->
    <script type="text/javascript" src="dituJs/js/zzj/MeasureA.js"></script>
    <!--测量面积的函数-->

    <!--缓冲分析无偏移SVG-->
    <script src="dituJs/js/zzj/DrawingCircle.js" type="text/javascript"></script>
    <!--缓冲分析无偏移SVG-->

    <!--弹框轮播的插件-->
    <script type="text/javascript" src="dituJs/js/zzj/babyzone.js"></script>
    <!--弹框轮播的插件-->

     <!--左边栏滚动条-->
    <script type="text/javascript" src="dituJs/js/zzj/jscroll.js"></script>
    <!--左边栏滚动条-->
</body>
</html>
