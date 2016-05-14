var index = 0, //测试图层显示
        data, //全局数据
        PageSize = 9, //每页个数
        Page = 1, //当前页码
        BeginNO, //起始页码
        EndNO, //结束页码
/****************页面部分结构*******************/
        choicePanel = $getId("mapChoicePanel"),
        choice = $getId("choice"),
        panel = $getId("mapChoicePanel"),
        mapHolder = $getId("MapHolder"),
        topHeader = $getId("topHeader"),
        mapInfoTab = $getId("MapInfoTab"),
        topNav = $getId("topNav"),
        friendLink = $getId("friendLink"),
        footer = $getId("footer"),
        shad = $getId("MapInfoTab"),
        mapCp = $getId("tangramScrollPanel"),
        tempStr;
/****************页面部分结构*******************/

//事件监听的兼容
function addEventHandler(target, type, func) {
    if (target.addEventListener) {
        target.addEventListener(type, func, false);       //W3C
    } else if (target.attachEvent) {
        target.attachEvent("on" + type, func);
    } else {
        target["on" + type] = func;
    }
}

function detachEventHandler(target, type, func) {
    if (target.addEventListener) {
        target.removeEventListener(type, func, false);  //W3C
    } else if (target.attachEvent) {
        target.detachEvent("on" + type, func);
    } else {
        target["on" + type] = null;
    }
}

//根据类名或者ID获取 collection
function g(selector) {
    var method = selector.substr(0, 1) == '.' ? 'getElementsByClassName' : 'getElementById';
    return document[method](selector.substr(1));
}


function $getId(id) {
    return document.getElementById(id); //定义获取ID的方法
}

//是否为兄弟节点
function siblings(elem) {
    var a = [];
    var b = elem.parentNode.children;
    for (var i = 0; i < b.length; i++) {
        if (b[i] !== elem) a.push(b[i]);
    }
    return a;
}

//通过类名获取collection
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

