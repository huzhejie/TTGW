var addPolygon = true;
var order = 0;

//工具条的操作
function MeasureAClientAction() {
    var svg = document.getElementById("SVGContainerA");

    var svgD = document.getElementById("SVGContainerD");
    svgD.style.display = "none";
    svg.onclick = function (e) {
        ContainerClick(e);
    }
    svg.onmousemove = function (e) {
        ContainerMousemove(e);
    }
    svg.ondblclick = function (e) {
        ContainerDBClick(e);
    }
    svg.innerHTML = '<svg id="svgA" xmlns="http://www.w3.org/2000/svg" version="1.1" width="100%" height="100%" style="z-index:582;cursor:url('+"'images/zzj/ruler.cur),auto'"+'"></svg>';
    distance = 0;
}

function ContainerClick(e) {
    var e = e || window.event;
    var point = e.offsetX + "," + e.offsetY + " ";
    var svg = document.getElementById("svgA");
    if (addPolygon) {
        var polygonStr = '<polygon class="area' + order + '" points="' + point + point + '"style="fill:rgba(70%,70%,70%,0.3);stroke:#ff0000;stroke-width:2"/>'
        var svgns = "http://www.w3.org/2000/svg";
        var poly = document.createElementNS(svgns, "polygon");
        poly.setAttribute("class", "area" + order);
        poly.setAttribute("points", point + point);
        var style = "fill:rgba(70%,70%,70%,0.3);stroke:#ff0000;stroke-width:2";
        poly.setAttribute("style", style);
        svg.appendChild(poly);
        addPolygon = false;
    }else{
        var polygonArr = document.getElementsByTagName("polygon");
        var list = polygonArr[polygonArr.length - 1].points;
        var last = list.getItem(list.length - 1);
        last.x = e.offsetX;
        last.y = e.offsetY;
        var item = svg.createSVGPoint();
        item.x = e.offsetX;
        item.y = e.offsetY;
        list.appendItem(item);
    }
}

function ContainerDBClick(e) {             //创建出删除的
    var e = e || window.event;
    if (!addPolygon) {
        var polygonArr = document.getElementsByTagName("polygon");
        var list = polygonArr[polygonArr.length - 1].points;
        var last = list.getItem(list.length - 1);
        last.x = e.offsetX;
        last.y = e.offsetY;
        addPolygon = true;
        var container = document.getElementById("SVGContainerA");
        var divStr = '<div class="area' + order + '" onmousemove="NullFunction(event)" onclick="NullFunction(event)" style="position:absolute;left:' + last.x + 'px;top:' + last.y + 'px;background-color:white;border:1px solid #ff0000;border-radius:3px;padding:2px 2px 2px 2px;cursor:auto">总面积 ' + Math.round(CaculateArea(list)) + " 平方米" + '</div>';
        divStr += '<div class="area' + order + '" onclick="DeletePolygon(event,this)" style="width:13px;height:13px;position:absolute;left:' + (last.x + 5) + 'px;top:' + (last.y - 16) + 'px;backgound-color:white;border:1px solid #ff0000;border-radius:3px;background:url(images/zzj/close.png);cursor:auto"></div>';
        container.innerHTML += divStr;
        order++;
    }
}

//删除路径的函数
function DeletePolygon(e, source) {
    var container = document.getElementById("SVGContainerA");
    var divs = getByClass(container, source.className);
    for (var i = 0; i < divs.length; i++){
        divs[i].parentNode.removeChild(divs[i]);
    }
    var svg = document.getElementById("svgA");
    var pathArr = svg.getElementsByTagName('*');
    var paths = [];
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

function ContainerMousemove(e) {
    var e = e || window.event;
    if (!addPolygon) {
        var polygonArr = document.getElementsByTagName("polygon");
        var list = polygonArr[polygonArr.length - 1].points;
        var last = list.getItem(list.length - 1);
        last.x = e.offsetX;
        last.y = e.offsetY;
    }
}

function CaculateArea(points) {
    var area = 0;
    var map = $find("Map1");
    for (var i = 1; i < points.numberOfItems - 2; i++) {
        area += det(map.toMapPoint(points.getItem(0).x, points.getItem(0).y), map.toMapPoint(points.getItem(i).x, points.getItem(i).y), map.toMapPoint(points.getItem(i + 1).x, points.getItem(i + 1).y))
    }
    return 0.5 * Math.abs(area);
}

function det(point, point1, point2) {
    var temp1 = point1.get_x() - point.get_x();
    var temp2 = point2.get_y() - point.get_y();
    temp1 = temp1 * temp2;

    var temp3 = point1.get_y() - point.get_y();
    var temp4 = point2.get_x() - point.get_x();
    temp3 = temp3 * temp4;

    temp1 = temp1 - temp3;
    return temp1;
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