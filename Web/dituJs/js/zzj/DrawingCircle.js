var x, y;

//原理同measureD
function DrawingCircle() {
    var svg = $getId("SVGContainerA"),
    svgD = $getId("SVGContainerD"),
    svgC = $getId("SVGContainerC");

    svgD.style.display = "none";
    svg.style.display  = "none";
    svgC.style.display = "block";
    svgC.innerHTML = '<svg id="svgC" xmlns="http://www.w3.org/2000/svg" version="1.1" width="100%" height="100%" style="z-index:582;"></svg>';

    addEventHandler(svgC, "click", function () {
        drawC();
    });
    
}


function drawC() {                 //通过Svg创建圆形
    var svg = $getId("svgC"),

    childList = svg.childNodes,    //把先前的元素的子节点集合
    e = e || window.event,
    point = e.offsetX + "," + e.offsetY + " ",
    map = $find("Map1"),
    mapPoint = map.toMapPoint(x, y),
    x = e.offsetX,
    y = e.offsetY,

    svgns = "http://www.w3.org/2000/svg",
    p = document.createElementNS(svgns, "circle");

    for (var i = 0, len = childList.length; i < len; i++) {
        svg.removeChild(childList[i]);    //把先前的circle清除
    }
    
    //Svg创建圆形
    p.setAttribute("cx", x);
    p.setAttribute("cy", y);
    p.setAttribute("r",100);
    p.setAttribute("fill", "green");
    p.setAttribute("opacity",0.5);
    
    svg.appendChild(p);
}
