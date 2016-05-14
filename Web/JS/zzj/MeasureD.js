var x;
var y;
var startPath = false;
var path;
var pathStyle = "stroke: rgb(255, 99, 25);stroke-width: 3px;";
var startPoint;
var distance = 0;
var isFirst = true;
var time = null;
var order = 0;

var trace = 0;

//工具条的操作
function MeasureDClientAction() {
    var svg = document.getElementById("SVGContainer");

    //为svg容器添加点击事件
    svg.onclick = function (e) {
        SVGClickFunction(e);
    }

    //为svg容器添加鼠标移动事件
    svg.onmousemove = function (e) {
        SVGMoveFunction(e);
    }

    //添加一个svg元素用于画线
    svg.innerHTML = '<svg id="svg" xmlns="http://www.w3.org/2000/svg" version="1.1" width="100%" height="100%" style="z-index:598;cursor:url(' + "'images/zzj/ruler.cur),auto'" + '"></svg>';
    //将距离累计进行清零
    distance = 0;

}

function SVGClickFunction(e) {
    var e = e || window.event;
    x = e.offsetX;
    y = e.offsetY;

    var map = $find("Map1");
    var mapPoint = map.toMapPoint(x, y);
    if (startPath) {
        var d = CaculateDistance(startPoint, mapPoint);
        distance += d;
    }

    var divStr = '<div class="distance'+order+'" style="width:10px;height:10px;position:absolute;left:' + (x - 5.5) + 'px;top:' + (y - 5.5) + 'px;z-index:-1;background:url(images/zzj/circle.png)"></div>'
    var container = document.getElementById("SVGContainer");
    container.innerHTML += divStr;
    
    var svgns="http://www.w3.org/2000/svg";
    var p = document.createElementNS(svgns,"path");
    p.setAttribute("class", "distance" + order);
    p.setAttribute("ondblclick", "SVGDBClickFunction(event)");
    p.setAttribute("stroke", "rgb(255, 99, 25)");
    p.setAttribute("stroke-width", "3px");
    var d = "M" + x + " " + y + " L" + x + " " + y;
    p.setAttribute("d", d);

    var svg = document.getElementById("svg");
    svg.appendChild(p);

    startPath = true;
    startPoint = mapPoint;

    //实时显示距离
    clearTimeout(time);
    time = setTimeout(function () {
        trace++;
        if (isFirst) {
            var firstStr = '<div class="distance' + order + '" onmousemove="NullFunction(event)" onclick="NullFunction(event)" style="border:1px solid #ff0000;border-radius:3px;position:absolute;left:' + (x - 30) + 'px;top:' + (y + 6) + 'px;background-color:white;padding:2px 2px 2px 2px;">起点</div>'
            container.innerHTML += firstStr;

            isFirst = false;
        } else {
            var firstStr = '<div class="distance' + order + '" onmousemove="NullFunction(event)" onclick="NullFunction(event)" style="border:1px solid #ff0000;border-radius:3px;position:absolute;left:' + (x - 30) + 'px;top:' + (y + 6) + 'px;background-color:white;padding:2px 2px 2px 2px;">' + Math.round(distance) + " 米" + '</div>';
            container.innerHTML += firstStr;
        }
    }, 200);
}

//单击事件
function SVGMoveFunction(e) {
    if (startPath) { 
        var e = e || window.event;
        var d = 'M' + x + ' ' + y + ' ' + 'L' + e.offsetX + ' ' + e.offsetY;

        var pArr = document.getElementsByTagName("path");
        pArr[pArr.length - 1].setAttribute("d", d);
    }
}

//双击事件
function SVGDBClickFunction(e) {
    clearTimeout(time);

    isFirst = true;
    startPath = false;

    var container = document.getElementById("SVGContainer");
    var moPoint = getByClass(container, "distance"+order);
    var last = moPoint[moPoint.length - 1];

    var divStr = '<div class="distance' + order + '" onmousemove="NullFunction(event)" onclick="NullFunction(event)" style="position:absolute;left:' + parseFloat(last.style.left) + 'px;top:' + (parseFloat(last.style.top) + 12) + 'px;background-color:white;border:1px solid #ff0000;border-radius:3px;padding:2px 2px 2px 2px;cursor:auto;">全长 ' + Math.round(distance) + " 米" + '</div>';
    divStr += '<div class="distance' + order + '"onclick="DeletePath(event,this)" onmousemove="NullFunction(event)" style="width:13px;height:13px;position:absolute;left:' + (parseFloat(last.style.left) + 5) + 'px;top:' + (parseFloat(last.style.top) - 16) + 'px;backgound-color:white;border:1px solid #ff0000;border-radius:3px;background:url(images/zzj/close.png);cursor:auto"></div>';

    container.innerHTML += divStr;
    distance = 0;
    order++;
}

//删除路径的函数
function DeletePath(e,source) {
    var container = document.getElementById("SVGContainer");
    var divs = getByClass(container, source.className);
    for (var i = 0; i < divs.length; i++) {
        divs[i].parentNode.removeChild(divs[i]);
    }

    var svg = document.getElementById("svg");
    var pathArr = svg.getElementsByTagName('*');
    var paths=[];
    for (var i = 0; i < pathArr.length; i++) {
        if (pathArr[i].className.baseVal == source.className || pathArr[i].className.animVal == source.className)
            paths.push(pathArr[i]);
    }

    for (var k = 0; k < paths.length; k++) {
        paths[k].parentNode.removeChild(paths[k]);
    }

        e = e || window.event;
    if (e.stopPropagation()) {
        e.stopPropagation();
    } else {
        e.cancelBubble = true;
    }
}

//阻止冒泡传递
function NullFunction(e) {
    e = e || window.event;
    if (e.stopPropagation()) {
        e.stopPropagation();
    } else {
        e.cancelBubble = true;
    }
}

//计算距离
//将屏幕上的点转换成为地图上的点之后就可以计算出距离
function CaculateDistance(startPoint, endPoint) {
    var x1 = startPoint.get_x();
    var y1 = startPoint.get_y();

    var x2 = endPoint.get_x();
    var y2 = endPoint.get_y();

    var x = x2 - x1;
    var y = y2 - y1;

    var distance = Math.pow(x, 2) + Math.pow(y, 2);
    distance = Math.pow(distance, 0.5);
    return distance;
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