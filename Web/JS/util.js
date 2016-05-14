//$getId
function $getId(id) {
    return document.getElementById(id);
}


//设置display属性
//设置element的隐藏与显示属性，参数可以是字符串和数组
//数组中以字符串的形式保存元素的id
function setDisplay(elementname, state) {
    if (Object.prototype.toString.call(elementname) == "[object Array]") {
        for (var i = 0; i < elementname.length; i++) {
            $getId(elementname[i]).style.display = state;
        }
    } else if (typeof elementname == "string") {
        $getId(elementname).style.display = state;
    }
}

//绑定监听事件
function addEvent(oElement, sEvent, fnHandler) {
    if(oElement.addEventListener){
        oElement.addEventListener(sEvent, fnHandler, false);
    }else if(oElement.attachEvent){ 
        oElement.attachEvent("on" + sEvent, fnHandler);
    } 
}

//给elemId元素添加类className
function addClass(elemId, className) {
    if (elemId.className == "") {
        elemId.className = className;
    } else {
        elemId.className += " " + className;
    }
}

//obj元素删除类cls
function removeClass(obj, cls) {
    var obj_class = ' ' + obj.className + ' ';//获取 class 内容, 并在首尾各加一个空格
    obj_class = obj_class.replace(/(\s+)/gi, ' '),//将多余的空字符替换成一个空格.
        removed = obj_class.replace(' ' + cls + ' ', ' ');//在原来的 class 替换掉首尾加了空格的
    removed = removed.replace(/(^\s+)|(\s+$)/g, '');//去掉首尾空格
    obj.className = removed;//替换原来的 class.
}

//obj元素是否含有类cls
function hasClass(obj, cls) {
    var obj_class = obj.className;//获取 class 内容.
    if (obj_class) {
        var obj_class_lst = obj_class.split(/\s+/);//通过split空字符将cls转换成数组.
        x = 0;
        for (x in obj_class_lst) {
            if (obj_class_lst[x] == cls) {//循环数组, 判断是否包含cls
                return true;
            }
        }
    }
    return false;
}

//通过类名获取元素
function getByClass(oParent, className) {
    var aEle = oParent.getElementsByTagName("*");
    var aResult = [];
    var re = new RegExp('\\b' + className + '\\b', 'i');
    var i = 0;
    for (i; i < aEle.length; i++) {
        if (re.test(aEle[i].className)) {
            aResult.push(aEle[i]);
        }
    }
    return aResult;
}
