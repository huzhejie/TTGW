//绑定页面加载时要执行的内容
function addClick(id, fn) {
    addEvent($getId(id), "click", fn);
}

//绑定选择位置的按钮的事件
addClick("provBtn", function () {
    show(1);
});
addClick("countyBtn", function () {
    show(2)
});
addClick("villageBtn", function () {
    show(3)
});

//绑定选择省市区县的事件
function bindProLocation() {
    addEvent($getId("proLocation"), "click", function (e) {
        var e = e || window.event;
        var element = e.target || e.srcElement;
        if (element && element.tagName == "A") {
            //var key = element.innerHTML;
            var key = element.innerText || element.textContent;
            getValuePro(key);
        }
    });
}

//绑定选择省市区县的事件
function bindCouLocation() {
    addEvent($getId("couLocation"),"click", function (e) {
        var e = e || window.event;
        var element = e.target || e.srcElement;
        if (element && element.tagName == "A") {
            //var key = element.innerHTML;
            var key = element.innerText || element.textContent;
            getValueCou(key);
        }
    });
}

//绑定选择省市区县的事件
function bindComLocation() {
    addEvent($getId("comLocation"),"click", function (e) {
        var e = e || window.event;
        var element = e.target || e.srcElement;
        if (element && element.tagName == "A") {
            //var key = element.innerHTML;
            var key = element.innerText || element.textContent;
            getValueVil(key);
        }
    });
}
//得到所选的省市
function getValuePro(a) {
    var province = $getId(provID);
    if (a == "不选") {
        province.value = "";
    }
    else {
        province.value = a;
    }
    $getId(countyID).value = "";
    $getId(villageID).value = "";
    //触发hideBtn1的点击事件，从后台获取相关数据
    $getId(hideBtn1ID).click();
    setDisplay(["drop1", "drop2", "drop3", "tri1", "tri2", "tri3"], "none");

}

//得到所选的区县
function getValueCou(a) {
    var county = $getId(countyID);
    if (a == "不选" || a == "未找到区(县)") {
        county.value = "";
        var village = $getId(villageID);
        village.value = "";
        //触发hideBtn2的点击事件，从后台获取相关数据
        $getId(hideBtn2ID).click();

    } else {

        county.value = a;
        //触发hideBtn2的点击事件，从后台获取相关数据
        $getId(hideBtn2ID).click();
        $getId(villageID).value = "";

    }
    setDisplay(["drop1", "drop2", "drop3", "tri1", "tri2", "tri3"], "none");
}

//得到所选的小区
function getValueVil(a) {
    //获取的选取的小区名
    var community = $getId(villageID);
    if (a == "不选" || a == "未找到相应小区") {
        community.value = "";
    } else {
        community.value = a;
    }
    setDisplay(["drop1", "drop2", "drop3", "tri1", "tri2", "tri3"], "none");
}

//用来显示和隐藏显示省市、区县、小区的块
function show(a) {
    for (i = 1; i <= 3; i++) {
        var divname = "drop" + i;
        var triname = "tri" + i;
        if (i != a) {

            setDisplay([divname, triname], "none");

        } else {
            //如果已经显示则隐藏
            if ($getId(triname).style.display == "block" && $getId(divname).style.display == "block") {
                setDisplay([divname, triname], "none");
            }
                //如果隐藏则显示
            else {
                setDisplay([divname, triname], "block");

                if (a == 1) {//显示省市div时绑定其事件
                    bindProLocation();
                    //绑定"不选"按钮的事件
                    addClick("aPro", function () {
                        getValuePro('不选')
                    });
                } else if (a == 2) {//显示区县div时绑定其事件
                    bindCouLocation();
                    //绑定"不选"按钮的事件
                    addClick("aCou", function () {
                        getValueCou('不选')
                    });
                
                } else if (a == 3) {//显示小区div时绑定其事件
                    bindComLocation();
                    //绑定"不选"按钮的事件
                    addClick("aVil", function () {
                        getValueVil('不选')
                    });
                }
            }

        }
    }

}

//根据所选的内容判断应该显示哪个块
function showbom() {
    var provalue = $getId(provID).value;
    var couvalue = $getId(countyID).value;
    var vilvalue = $getId(villageID).value;

    if (provalue == "" && couvalue == "" && vilvalue == "") {
        showbynum(1);
    }
    else if (provalue != "" && couvalue == "" && vilvalue == "") {
        showbynum(2);
    }
    else if (provalue != "" && couvalue != "" && vilvalue == "") {

        showbynum(3);
    } else if (provalue != "" && couvalue != "" && vilvalue != "") {
        window.open("community.aspx?pro=" + provalue + "&cou=" + couvalue + "&vil=" + vilvalue);
    }
}

//选择要显示不同的内容时，相应的块状态改为display：block
//1，2，3分别代表总数据，省市数据，区县数据
function showbynum(a) {
    var pro, proname;
    for (var i = 1; i <= 3; i++) {
        var bomname = "bom" + i;
        if (i == a) {
            setDisplay(bomname, "block");
        } else {
            setDisplay(bomname, "none");
        }
    }
}

//在改变了显示内容之后改变bomtitlepro的背景图片
//头部标题背后有一个水印地图，在选择重庆和湖北时需要切换
function chooseBgimg() {

    pro = $getId("bomtitlepro");
    proname = $getId(provID).value;
    if (proname == "湖北省") {
        pro.style.backgroundImage = "url(../Images/LeaderIndexImg/hubei.png)";
    }
    else if (proname == "重庆市") {
        pro.style.backgroundImage = "url(../Images/LeaderIndexImg/chongqing.png)";
    }

}

//显示searchresult块
function showSr() {
    var searchResult = $getId(searchresultID);
    searchResult.style.display = "block";
    //在显示searchresult块的同时给其添加事件
    //当点击连接时隐藏searchresult
    var keyElement = searchResult.getElementsByTagName("ul")[0];
    addEvent(keyElement, "click", function (e) {
        var e = e || window.event;
        var element = e.target || e.srcElement;
        if (element) {
            hideSr();
        }
    })
}
//隐藏searchresult块
function hideSr() {
    $getId(searchresultID).style.display = "none";
}

//幻灯片效果的轮播代码
//给导航标签绑定事件
(function () {
    //所有类名含有dataContentLeft的div
    var navArr = getByClass(document, "dataContentLeft");
    for (var i = 0; i < navArr.length; i++) {
        (function () {
            var key = i+1;
            //div中所有的A标签
            var aArr = navArr[i].getElementsByTagName("a");
            for (var k = 0; k < aArr.length; k++) {
                (function () {
                    var aKey = k;
                    //为每一个a标签绑定事件
                    addEvent(aArr[aKey], "click", function () {
                        if (key % 2 == 1) {
                            scrollDiv("DataContent" + key, -aKey * 400);                           
                        } else if (key % 2 == 0) {
                            scrollDiv("DataContent" + key, -aKey * 500);
                        }    
                        
                        for(var aIndex=0;aIndex<aArr.length;aIndex++){
                            if(aIndex!=aKey){
                                if(hasClass(aArr[aIndex],"dataOn")){
                                    removeClass(aArr[aIndex],"dataOn");
                                }
                               }
                            }
                            if(!hasClass(this,"dataOn")){
                                addClass(this,"dataOn");
                            } 
                                           
                    })
                })();
            }
        })()

    }
})()
//根据所选内容，滚动到相应的位置
//aimHeight表示要滚动到的位置
//element表示滚动的元素id
function scrollDiv(element, aimHeight) {
    var element = $getId(element),
        elementTop = element.offsetTop,//当前top值
        shortTop = aimHeight - elementTop,//差值，需要滚动的高度
        changeTop = shortTop> 0 ? 50 : -50;//判断每次要滚动的是负值还是正值
    if (elementTop != aimHeight) {//不想等则改变
        var timer = setInterval(function () {
            var elementTop = element.offsetTop;
            element.style.top = elementTop + changeTop + "px";
            if (element.offsetTop == aimHeight) {
                clearInterval(timer);
            }
        }, 20)
    }
}