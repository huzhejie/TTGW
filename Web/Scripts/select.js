/**
* Created by Administrator on 2015/6/11.
*/

window.onload = function () {
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

