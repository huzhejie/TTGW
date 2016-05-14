function pageChange(jsonLength) {

    var Pages = Math.floor((jsonLength.length - 1) / PageSize) + 1; //总页数  

        if (Page < 1) Page = 1;  //如果当前页码小于1
        if (Page > Pages) Page = Pages; //如果当前页码大于总数

        var Temp = "";
        BeginNO = (Page - 1) * PageSize + 1; //开始编号
        EndNO = Page * PageSize; //结束编号
        if (EndNO > jsonLength.length) EndNO = jsonLength.length;
        if (EndNO == 0) BeginNO = 0;
        if (Page > 1 && Page !== 1) {
            Temp += "<span><a href='javascript:void(0)' onclick='GotoPage(" + (Page - 1) + ")'>前一页</a></span>&nbsp;";
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

        var choiceText = '',
            str = " ",
       // var divPos = document.createElement("div"); //创建地图上的对象
       // divPos.setAttribute("className", "BMap");
            divPosStr = '',
            itemNum = (EndNO - BeginNO) + 2;
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
            str += '<div class="row addr"><span class="ngrey" title=""></span></div>';
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
            SelectOneItem(source.innerHTML, source.type); //innerHTML代表名称 type代表的是选中的类型
    }


    function GotoPage(num) {  //跳转页
        Page = num;
        var removeItem = $getId("tangramScrollPanel");
        removeItem.parentNode.removeChild(removeItem);
        var removeScroll = $getId("scrollBg");
        removeScroll.parentNode.removeChild(removeScroll);
        Output(data);
    }
    
    function back() {
        var baseStr = '<div class="fl" id="tangramScroll"><div id="mapInfo"><div class="mapIndexBox" id="mapIndex">';
        baseStr += '<div class="mapSpecialBox">';
        baseStr += '<ul class="mapIndexList" id="mapIndexList">';
        baseStr += '<li><div class="mapListItem cater"></div> <span class="cityListTitle">找医院</span></li>';
        baseStr += '<li><div class="mapListItem hotel"></div><span class="cityListTitle">找学校</span></li>';
        baseStr += '<li><div class="mapListItem movie"></div><span class="cityListTitle">找小区</span></li>';
        baseStr += '</ul>';
        baseStr += '</div></div></div>';
        choicePanel.innerHTML = baseStr;
        indexShow();
        var objs = getByClass(mapHolder, "BMap_Marker");
        for (var i = 0; i < objs.length; i++) {
            objs[i].parentNode.removeChild(objs[i]);
        }
    }

 