/**
* Created by Administrator on 2015/6/11.
*/

window.onload = function () {
    //选择一个小区作为标记
    //    var firsta = document.getElementById("communityChoice");

    //    var choice = firsta.getElementsByTagName("a");

    //    for (var s = 0; s < choice.length; s++) {
    //        var aspan = choice[s].getElementsByTagName("span");
    //        if (aspan[0].innerHTML == "曲阜小区") {
    //            var choicei = choice[s].getElementsByTagName("i")[0];
    //            choicei.style.visibility = "visible";
    //            addClass(choice[s], "oni");
    //        }



    //    }
    //for (var j = 1; j < 6; j++) {
    var first = document.getElementById("communityChoice");
    var aFirstArr = first.getElementsByTagName("a");

    for (var i = 0; i < aFirstArr.length; i++) {
        aFirstArr[i].onclick = function () {
            var _this = this;

            var m = first.getElementsByTagName("i");
            var aFirstArr2 = first.getElementsByTagName("a");
            for (var n = 0; n < m.length; n++) {
                if (hasClass(aFirstArr2[n], "oni")) {
                    removeClass(aFirstArr2[n], "oni");
                    var p = first.getElementsByTagName("i")[n];
                    p.style.visibility = "hidden";
                }
            }
            
            var a = _this.getElementsByTagName("i")[0];
            a.style.visibility = "visible";
            addClass(_this, "oni");
        }
    }

    // }

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


var i = 1
function addFile() {
    if (i < 8) {
        var str = '<br/><div style="height:2px;"></div> <input type="file" name="File" runat="server" style="width: 300px"/>';
        document.getElementById('MyFile').insertAdjacentHTML("beforeEnd", str);
    } else {
    alert("您一次最多只能上传8张图片！");
    }
    i++;
}

//function sendServer() {
//    var txt = document.getElementById("Text1").value;

//}


//function transValue() {


//    var ediv = document.getElementById("end");
//    var etime = ediv.innerHTML;
//    var etext = document.getElementById("ctl00_ContentPlaceHolder1_et");
//    if (etime != "") {
//        etext.value = etime;
//    } else {
//        alert("请选择结束时间");
//        return false;

//    }

//    var sdiv = document.getElementById("start");
//    var stime = sdiv.innerHTML;
//    var stext = document.getElementById("ctl00_ContentPlaceHolder1_hidestart");
//    if (stime != "") {
//        stext.value = stime;
//    } else {
//        alert("请选择开始时间");
//        return false;
//    }

//    var a = document.getElementById("communityChoice");
//    var aArr = a.getElementsByTagName("a");

//    for (i = 0; i < aArr.length; i++) {
//        if (hasClass(aArr[i], "oni")) {
//            var e = aArr[i].getElementsByTagName("span");
//            var cvalue = e[0].innerHTML;
//            var com = document.getElementById("ctl00_ContentPlaceHolder1_com");
//            com.value = cvalue;
//        }




//    }
//}