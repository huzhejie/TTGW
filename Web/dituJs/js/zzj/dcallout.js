var mapID = "Map1";
var calloutID = "myCalloutID";
var graphicFeatureID = "myGraphicFeature";
var count = 0;
var geom;
var full = false;
var bufferX, bufferY;
//左边栏修改
function fullLeftShow() {

    if (mapInfoTab.title == "收起左栏") {
        panel.style.top = "200px";
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
//初始化函数
function init() {
    //获得地图的js对象然后添加放缩处理函数函数
    map = $find(mapID);
    map.add_extentChanged(changePosition);
    map.add_extentChanging(changePosition);
    //初始化的时候将鹰眼功能隐藏起来
    var ovm = $find("OverviewMap1");
    if (ovm) {
        ovm.hide();
    }
    //对工具条的状态进行判断
    var toolbar = $find("Toolbar1"); //microsoft ajax $find will return a component or null
    //处理工具条选择是所产生的事件
    toolbar.add_onToolSelected(function (sender, tool) {
        var svg = document.getElementById("SVGContainer");
        //如果点击的是测量面积或测量距离的功能就将svg的容器显示出来
        if (tool.name == "MeasureD" || tool.name == "MeasureA") {
            svg.style.display = "block";
        } else {
            //如果是其他的功能项就将svg容器隐藏起来避免影响地图获得鼠标事件
            svg.style.display = "none";
            //如果是全屏就进行一下操作
            if (tool.name == "FullScreen") {
               
                var panel = $getId("mapChoicePanel");
                var mapHolder = $getId("MapHolder");
                var topNav = $getId("topNav");
                var topHeader = $getId("topHeader");
                var friendLink = $getId("friendLink");
                var footer = $getId("footer");
                var holder = $getId("MapHolder");
                var tab = $getId("MapInfoTab");
                //将一些内容隐藏起来
                if (!full) {
                    panel.style.display = "none";
                    mapHolder.style.marginLeft = "0px";
                    topNav.style.display = "none";
                    topHeader.style.display = "none";
                    friendLink.style.display = "none";
                    footer.style.display = "none";
                    tab.style.display = "none";
                    holder.style.height = window.innerHeight + "px";
                    full = true;
               
                } else {//退出全屏模式
                    panel.style.display = "block";
                    if (parseFloat(panel.style.left) < 0) {
                        panel.style.left = "0px";
                        mapHolder.style.marginLeft = "326px";
                        mapInfoTab.title = "收起左栏";
                        shad.style.left = "326px";
                    }
                    topHeader.style.display = "block";
                    mapHolder.style.marginLeft = "326px";
                    topNav.style.display = "block";
                    friendLink.style.display = "block";
                    footer.style.display = "block";
                    tab.style.display = "block";
                    holder.style.height = "544px";
                    full = false;
                }
            } else if (tool.tool.name == "BufferAnalysis") {    //进入缓冲区分析状态
               
                tool.tool.name = "ClearBuffer";
                BufferAnalysis();
            } else if (tool.tool.name == "ClearBuffer") {       //清除缓冲区分析状态
                tool.tool.name = "BufferAnalysis";
                ClearBuffer();
            }
        }
    });
}

function $getId(id) {
    return document.getElementById(id); //定义获取ID的方法
}

//根据地图的更改改变callout的位置
function changePosition() {
    var screenPoint;
    var mapBounds;
    var callout = $find(calloutID);
    if (geom && callout) {
        screenPoint = map.toScreenPoint(geom);
        mapBounds = Sys.UI.DomElement.getBounds($get(mapID));
        callout.setPosition(screenPoint.offsetX, screenPoint.offsetY);
    }
}
//清除函数
function clearCallout(mID, cID) {
    var callout = $find(cID);
    callout.hide();
    var graphicFeature = $find(graphicFeatureID);
    var m = $find(mID);
    m.removeGraphic(graphicFeature); //removeGraphic is the method of esri
    ClearBuffer();
}
//添加单点
function createOnePoint(geometry) {
    map = $find(mapID);
    var defaultSymbol = new ESRI.ADF.Graphics.MarkerSymbol('images/zzj/location.png', 5, 5); //创建出一个鼠标点击点完的点
    defaultSymbol.set_width(20);
    defaultSymbol.set_height(20);
    var graphicFeature = $find(graphicFeatureID); 
    if (graphicFeature) {
        graphicFeature.set_geometry(geometry);
    } else {
        graphicFeature = $create(ESRI.ADF.Graphics.GraphicFeature, {
            "id": graphicFeatureID,
            "geometry": geometry,
            "symbol": defaultSymbol
        });
    }
    map.addGraphic(graphicFeature);
}

//创建callout
function createCallout(geometry, json) {
//    获得map对象
      map = $find(mapID);
      //好吧，这个函数式干嘛的我也不知道..
      //获取一组整数坐标，这些坐标表示 DOM 元素的位置、宽度和高度。 此成员是静态的，可在不创建类实例的情况下调用。
    var mapBounds = Sys.UI.DomElement.getBounds($get(mapID));
//    获得当前集合图形的屏幕坐标
    var screenPoint = map.toScreenPoint(geometry);
//    获得弹窗对象
    var myCallout = $find(calloutID);
    //如果弹窗对象为空就创建
    if (!myCallout) {
        myCallout = $create(ESRI.ADF.UI.Callout, {
            "id": calloutID,
            "parent": document.getElementById(mapID),
            "animate": true,
            "autoHide": false,
            "arrowImageUrl": "images/zzj/nullArro.png"
        }, null);
        //定义弹窗的显示样式
        var template = String.format('<link rel="stylesheet" href="css/zzj/callout.css">' +
        '<div id="callout" class="showDiv">' +
        '<div class="showDivHeader">' +
        '<div class="headerTitle">' +
        '<p class="addTitle">' +
        '<a href="#" class="title" target="_blank" title="{{@name}}">{{@name}}</a>' +
        '<a href="Detail.aspx" class="ndetail" target="_blank"> 详情>></a>' +
        '<a href="SVG.aspx" class="ndetail" target="_blank"> 目标评价>></a>' +
        '</p></div>' +
        '<div class="headerButton">' +
        '<div class="buttonImg">' +
        '<img src="images/zzj/iw_close.gif" onclick="clearCallout(\&#39;{0}\&#39;,\&#39;{1}\&#39;)"></div>' +
        '</div></div>' +
        '<div class="showDivBody">' +
        '<div class="bodyContent">' +
       /*
        '<div id="banner">'+	
	    '<div id="banner_bg"></div>'+
	    '<a href="#" id="banner_info"></a>'+
        '<ul id="mySelectList"></ul>'+
        '<div id="banner_list">'+
        '<a href="#" target="_blank"><img src="imgs/p1.jpg" title="橡树小屋的blog1" alt="橡树小屋的blog" style="display:none;"/>'+
		'<table class="table-bordered" style="border:1px solid; width:478px;height:286px;" caption="">'+
		    '<tr>'+
				'<td>建设年份</td><td colspan="2">{{@address}}</td>'+
				'</tr>'+
				'<tr>'+
					'<td>居民户籍人口</td><td>总户数  户</td> <td>总人数  人</td>'+
				'</tr>'+
				'<tr>'+
					'<td>其中移民</td><td>户数  户</td><td> 人数  人</td>'+
				'</tr>'+
				'<tr>'+
					'<td>建筑面积</td><td></td><td>万m2</td>'+  
				'</tr>'+
				'<tr>'+
					'<td>占地面积</td><td></td><td>万m2</td>'+ 
				'</tr>'+
				'<tr>'+
					'<td>门面数</td><td></td><td>个</td>'+  	
				'</tr>'+
				'<tr>'+ 
					'<td>门面使用率</td><td></td><td>%</td>'+  	
				 '</tr>'+
				 '<tr>'+ 
					'<td>劳动力就业率</td><td></td><td>%</td>'+  	
				 '</tr>'+
				 '<tr>'+ 
					'<td>人均可支配收入</td><td></td><td>元</td>'+  	
				 '</tr>'+
				 '<tr>'+ 
					'<td>累计计划投资</td><td></td><td>万元</td>'+  	
				 '</tr>'+
				   '<tr>'+ 
					'<td>累计完成投资</td><td></td><td>万元</td>'+  	
				 '</tr>'+
				    '<tr>'+
					'<td>累计完成投资</td><td colspan="2">%</td>'+
				 '</tr>'+
			'</table>'+	
		'</a>'+
        '<a href="#" target="_blank">'+
           '<img src="{{@url-img}}" title="按资金来源划分的投资计划及完成情况" alt="按资金来源划分的投资计划及完成情况" />'+
        '</a>'+
        '<a href="#" target="_blank">'+
            '<img src="imgs/p3.jpg" title="按类别结构划分的投资计划及完成情况" alt="按类别结构划分的投资计划及完成情况" />'+
            '</a>'+
	     '</div>'+
         '</div>'+
         '</div>'+
         */
          '<div id="luanpo">'+
            '<ul id="imgs">'+
            '<li>a</li>'+
            '<li>b</li>'+
            '<li>c</li>'+
            '<li>d</li>'+
        '</ul>'+
        '<ul id="num">'+
            '<li class="a">1</li>'+
            '<li class="b">2</li>'+
            '<li class="b">3</li>'+
            '<li class="b">4</li>'+
        '</ul>'+
        '</div>'+
         '</div>'+
         '<script type="text/javascript" language="javascript">'+
            ' lunbo();' +
         '</script>'+
        '</div>', mapID, calloutID,true);
        myCallout.set_template(template);
    }
    //插入数据
    myCallout.setContent({
        'url-detail': json.UrlDetail,
        'name': json.Name,
        'url-img2': json.UrlImag,
        'url-img': "images/dajijiedao.png",
        'address': json.Address
       // 'content': json.Content,
       // 'showBuffer':json.ShowBuffer
    });
    checkPosition(screenPoint.offsetX, screenPoint.offsetY, myCallout);
}


//使用getgeometry
function clickPoint() {
//    利用$find函数中返回callout对象
    var callout = $find(calloutID);
    if (callout) {
        callout.hide();
    }
// 利用$find函数获得map对象
    map = $find(mapID);
// 将map的鼠标模式定义为自定义模式
    map.set_mouseMode(ESRI.ADF.UI.MouseMode.Custom);
// 开始在地图上进行图形输入
    map.getGeometry(ESRI.ADF.Graphics.ShapeType.Point,                             //规定输入的图形类型为点类型
		            function (geometry) {                                          //当图形输入完成之后执行该函数
		                geom = geometry;                                            //保存图形输入的函数
		                createOnePoint(geometry)                                    //根据获几何图形在地图上创建一个定点
		                var screenPoint = map.toScreenPoint(geometry);              //将地图获得的点转换成为屏幕上的点
		                startCallback(screenPoint.offsetX, screenPoint.offsetY);    //调用该函数开始后台的回调进行查询
		            },
		            null, null, null, 'pointer', true);     //设置其他的相关属性
}

//前台的处理函数，处理后台ajax流程返回的结果，这个函数的参数是固定的
function ProcessCallout(response, context) {
   
    if (response == " ") {
        alert("没有选中有效元素,请选择学校、医院或者小区");
        clearCallout(mapID, calloutID);
        return;
    }
    var json = eval('(' + response + ')');
    bufferX = json.x;
    bufferY = json.y;
    createCallout(geom, json);
}

//处理左边的选择小区的时候所产生的callout
function selectProcess(json) {
    bufferX = json.x;
    bufferY = json.y;
    //获得地图对象
    map = $find(mapID);
    //取消地图的图形输入
    map.cancelGetGeometry();
    //将鼠标的输入模式设置称为自定义模式
    map.set_mouseMode(ESRI.ADF.UI.MouseMode.Custom);
    //获得图形输入
    map.getGeometry(ESRI.ADF.Graphics.ShapeType.Point, null, null, null, null, null, true);
    //获得地图当前显示的中心点
    var point = map.get_center();
    geom = point;
    //调用该函数在地图上创建一个顶点
    createOnePoint(point);
    //创建并显示弹窗
    createCallout(point, json);
    //取消图形输入
    map.cancelGetGeometry();
    //将鼠标模式设定称为移动模式
    map.set_mouseMode(ESRI.ADF.UI.MouseMode.Pan);
}


//核对位置
function checkPosition(x, y, callout) {
    var width = document.getElementById(mapID).offsetWidth;
    var height = document.getElementById(mapID).offsetHeight;
    var s = 0;
    //如果x加上callout的宽度超出边界的话,就移动callout的位置
    if (x + 345 > width) {
        x = width - 345;
        s++;
    }
    if (y + 320 > height) {
        y = height - 350;
        s++;
    }
    callout.setPosition(x, y);
    callout.show();
    if (s == 2) {
        map = $find(mapID);
        map.panTo(map.toMapPoint(width, height), true);
    }
}

function BufferAnalysis() {      //缓冲区分析函数
    map = $find(mapID);
    map.set_mouseMode(ESRI.ADF.UI.MouseMode.Custom);
    map.getGeometry(ESRI.ADF.Graphics.ShapeType.Point,
		            function (geometry) {
		                bufferX = geometry.get_x();
		                bufferY = geometry.get_y();
		                SelectBuffer(false);
		            },
		            null, null, null, 'pointer', true);
}
function MoveCallout() {         //根据缓冲区大小移动callout
    var x = geom.get_x() + 1000;
    var y = geom.get_y();
    var map = $find(mapID);
    var sPoint1 = map.toScreenPoint(map.toMapPoint(x, y));
    var sPoint2 = map.toScreenPoint(geom);
    var callout = $find(calloutID);
    var position = callout.getPosition();
    position[0] = position[0] + ( sPoint1.offsetX - sPoint2.offsetX );
    callout.setPosition(position[0],position[1]);
}


function lunbo() {
    var imgs = document.getElementById('imgs').getElementsByTagName('li');
    var nums = document.getElementById("num").getElementsByTagName("li");
    var luanpo = document.getElementById("luanpo");
    var oimg = document.getElementById('imgs');
    var iNow = 0;
    var dt = null;
    oimg.style.width = imgs.length * imgs[0].offsetWidth + "px";

    function tab() {
        for (var i = 0; i < nums.length; i++) {
            nums[i].index = i;
            nums[i].onclick = function () {
                clearInterval(dt);
                iNow = this.index;
                for (var i = 0; i < nums.length; i++) {
                    nums[i].className = "b";
                }
                this.className = "a";
                oimg.style.left = -(imgs[0].offsetWidth * iNow) + "px";    //这边可以加上我前面所写的那个缓动框架            
            }
            nums[i].onmouseout = function () {
                start();
            }
        }
    }

    function start() {
        clearInterval(dt);
        dt = setInterval(function () {
            if (iNow > nums.length - 2) {
                iNow = 0;
            } else {
                iNow++;
            }
            for (var k = 0; k < nums.length; k++) {
                if (iNow == nums[k].index) { nums[k].className = 'a'; } else { nums[k].className = 'b'; }
            }
            oimg.style.left = -(imgs[0].offsetWidth * iNow) + "px";    //这边可以加上我前面所写的那个缓动框架
        }, 3000);
        tab();
    }

    start();


}