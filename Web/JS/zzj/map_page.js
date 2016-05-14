function $getId(id) {
    return document.getElementById(id); //定义获取ID的方法
}

//显示列表的入口函数
function showList(json) {
  //  $getId("mapInfo").removeChild($getId("mapIndex"));
    var choiceText1 = '';
    choiceText1 += '<ul class="toolbar clearfix">';
    choiceText1 += '<li class="toolItem city-item"><label>所有地区' + json[0].type + '</label><i class="icon-cater arrow"></i></li> ';
    choiceText1 += '<li class="toolItem  tag-item  botn-line" ><label>所有学校</label><i class="icon-cater arrow"></i></li>';
    choiceText1 += '<li class="toolItem" ><label><a  href="javascript:back();">返回</a></label></li>';
    choiceText1 += '</ul>';
    $getId("mapInfo").innerHTML = choiceText1;
  
    Output(json);
  
}

//处理图层选择的回调事件
function ProcessSelectLayer(response, context) {
    var json = eval('(' + response + ')');
    showList(json);
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

//将地图上的点转换成为屏幕上的点
function toScreenPoint(x,y)
{
    var map = $find("Map1");
    var point = new ESRI.ADF.Geometries.Point(x, y, map.get_spatialReference());
    point = map.toScreenPoint(point);
    return point;
}
