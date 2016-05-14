window.onload = function () {

       var first = document.getElementById("choice1");

    var aFirstArr = first.getElementsByTagName("a");
    for (var i = 0; i < aFirstArr.length; i++) {
        aFirstArr[i].onclick = function () {
            var _this = this;
            var m = first.getElementsByTagName("i");
            var aFirstArr2 = first.getElementsByTagName("a");
            for (var n = 0; n < m.length; n++) {                                       
                removeClass(aFirstArr2[n], "oni");
                var p = first.getElementsByTagName("i")[n];
                p.style.visibility = "hidden";
            }
            var a = _this.getElementsByTagName("i")[0];
            a.style.visibility = "visible";
             addClass(_this, "oni");
        }
    }

    var second = document.getElementById("choice2");
    var aFirstArrSec = second.getElementsByTagName("a");
    for (var m = 0; m < aFirstArrSec.length; m++) {
        aFirstArrSec[m].onclick = function () {
            var _this = this;
            if (hasClass(_this, "oni")) {
                removeClass(_this, "oni");
                _this.getElementsByTagName("i")[0].style.visibility = "hidden";
            } else {
                addClass(_this, "oni");
                _this.getElementsByTagName("i")[0].style.visibility = "visible";
            }
        }
    }

}

function addClass(elemId, className) {
    if (elemId.className == "") {
        elemId.className = className;
    } else {
        elemId.className += " " + className;
    }
}
function removeClass(obj, cls) {
    var obj_class = ' ' + obj.className + ' '; //获取 class 内容, 并在首尾各加一个空格. ex) 'abc        bcd' -> ' abc        bcd '
    obj_class = obj_class.replace(/(\s+)/gi, ' '), //将多余的空字符替换成一个空格. ex) ' abc        bcd ' -> ' abc bcd '
        removed = obj_class.replace(' ' + cls + ' ', ' '); //在原来的 class 替换掉首尾加了空格的 class. ex) ' abc bcd ' -> 'bcd '
    removed = removed.replace(/(^\s+)|(\s+$)/g, ''); //去掉首尾空格. ex) 'bcd ' -> 'bcd'
    obj.className = removed; //替换原来的 class.
}

function hasClass(obj, cls) {
    var obj_class = obj.className, //获取 class 内容.
        obj_class_lst = obj_class.split(/\s+/); //通过split空字符将cls转换成数组.
    x = 0;
    for (x in obj_class_lst) {
        if (obj_class_lst[x] == cls) {//循环数组, 判断是否包含cls
            return true;
        }
    }
    return false;
}
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
