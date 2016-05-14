window.onload = function () {
    var list= document.getElementById("communityChoice");
    addEvent(list, "click", function (e) {
        var e = e || window.event;
        var targetElement = e.target || e.srcElement;
        if (targetElement && targetElement.tagName == "A") {
            var aCount = list.getElementsByTagName("a");
            for (var n = 0; n < aCount.length; n++) {
                if (hasClass(aCount[n], "oni")) {
                    removeClass(aCount[n], "oni");
                    var p = aCount[n].getElementsByTagName("i")[0];
                    p.style.visibility = "hidden";
                }
            }
            var a = targetElement.getElementsByTagName("i")[0];
            a.style.visibility = "visible";
            addClass(targetElement, "oni");
        }
    })
  
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


!function () {
    laydate.skin('molv'); //切换皮肤，请查看skins下面皮肤库
    laydate({ elem: '#demo' }); //绑定元素
}();

//日期范围限制
var start = {
    elem: '#start',
    format: 'YYYY-MM-DD',
    min: '1979-01-01', //设定最小日期为当前日期laydate.now(),
    max: '2099-06-16', //最大日期
    istime: true,
    istoday: false,
    choose: function (datas) {
        end.min = datas; //开始日选好后，重置结束日的最小日期
        end.start = datas //将结束日的初始值设定为开始日
    }
};

var end = {
    elem: '#end',
    format: 'YYYY-MM-DD',
    min: laydate.now(),
    max: '2099-06-16',
    istime: true,
    istoday: false,
    choose: function (datas) {
        start.max = datas; //结束日选好后，充值开始日的最大日期
    }
};
//定义时间格式
laydate(start);
laydate(end);


function transValue() {
    var ediv = document.getElementById("end");
    var etime = ediv.innerHTML;
    var etext = document.getElementById(etID);
    if (etime != "") {
        etext.value = etime;
    } else {
        alert("请选择结束时间");
        return false;

    }

    var sdiv = document.getElementById("start");
    var stime = sdiv.innerHTML;
    var stext = document.getElementById(hidestartID);
    if (stime != "") {
        stext.value = stime;
    } else {
        alert("请选择开始时间");
        return false;
    }

    var a = document.getElementById("communityChoice");
    var aArr = a.getElementsByTagName("a");
    var com = document.getElementById(comID);
    for (i = 0; i < aArr.length; i++) {
        if (hasClass(aArr[i], "oni")) {
            var e = aArr[i].getElementsByTagName("span");
            var cvalue = e[0].innerHTML;
           
            com.value = cvalue;
        }
    }
   
    return true;
}

function transIdValue() {
    var a = document.getElementById("communityChoice");
    var aArr = a.getElementsByTagName("a");
    var com = document.getElementById(comID);
    for (i = 0; i < aArr.length; i++) {
        if (hasClass(aArr[i], "oni")) {
            var e = aArr[i].getElementsByTagName("span");
            var cvalue = e[0].innerHTML;
           
            com.value = cvalue;

            return true;
        }
    }
    if (com.value == "") {
        alert("请选择小区");
        return false;
    }
    return false;
}