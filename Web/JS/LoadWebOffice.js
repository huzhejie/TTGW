//var s = ""
//s += "<object id=WebOffice1 height=768 width='100%' style='LEFT: 0px; TOP: 0px'  classid='clsid:E77E049B-23FC-4DB8-B756-60529A35FAD5' codebase='WebOffice.cab#Version=7,0,1,0'>"
//s +="<param name='_ExtentX' value='6350'><param name='_ExtentY' value='6350'>"
//s +="</object>"

//demo中的源码

//var s = ""

//if (navigator.userAgent.indexOf("Firefox") > 0) {

//    s = "<object id='WebOffice1' type='application/x-itst-activex' align='baseline' border='0'"
//		+ "WIDTH='1000px' HEIGHT=800px' "
//		+ "clsid='{E77E049B-23FC-4DB8-B756-60529A35FAD5}'"
//		+ "event_NotifyCtrlReady='WebOffice1_NotifyCtrlReady'>"
//		+ "</object>";

//} else if (navigator.userAgent.indexOf("Chrome") > 0) {

//    s = "<object id='WebOffice1' type='application/x-itst-activex' align='baseline' border='0'"
//		+ "WIDTH='1000px' HEIGHT=800px' "
//		+ "clsid='{E77E049B-23FC-4DB8-B756-60529A35FAD5}'"
//		+ "event_NotifyCtrlReady='WebOffice1_NotifyCtrlReady'>"
//		+ "</object>";

//}else
//{


//    s += "<object id=WebOffice1 height=800 width=1000px;"
//    s += "  "
//    s += " classid='clsid:E77E049B-23FC-4DB8-B756-60529A35FAD5' "
//    s += "codebase='WebOffice.cab#Version=7,0,1,0'>"
//    s += "<param name='_ExtentX' value='6350'><param name='_ExtentY' value='6350'>"

//    s += "</OBJECT>"
//}

//document.write(s)

//网站上的源码
var Sys = {};

var ua = navigator.userAgent.toLowerCase();

var s;

(s = ua.match(/msie ([\d.]+)/)) ? Sys.ie = s[1] :
(s = ua.match(/firefox\/([\d.]+)/)) ? Sys.firefox = s[1] :
(s = ua.match(/chrome\/([\d.]+)/)) ? Sys.chrome = s[1] :
(s = ua.match(/opera.([\d.]+)/)) ? Sys.opera = s[1] :
(s = ua.match(/version\/([\d.]+).*safari/)) ? Sys.safari = s[1] : 0;


if (Sys.ie) {
    var s = ""
    s += "<object id=WebOffice1 height=800 width=1000 style='LEFT: 0px; TOP: 0px'  classid='clsid:E77E049B-23FC-4DB8-B756-60529A35FAD5' codebase='./WebOffice.cab#version=7,0,1,0'>"
    s += "<param name='_ExtentX' value='6350'><param name='_ExtentY' value='6350'>"
    s += "</OBJECT>"
    document.write(s);
}

if (Sys.firefox || Sys.chrome) {

    var s = ""
    s += "<object id=WebOffice1 TYPE='application/x-itst-activex'  clsid='{E77E049B-23FC-4DB8-B756-60529A35FAD5}' event_NotifyCtrlReady='WebOffice1_NotifyCtrlReady' progid='' height=800 width=1000 style='LEFT: 0px; TOP: 0px' codeBase='Weboffice.cab#version=7,0,1,0' >"
    s += "<param name='_ExtentX' value='6350'><param name='_ExtentY' value='6350'>"
    s += "</OBJECT>"
    document.write(s);
} 
//    <script type="text/javascript">




//        var s;

//        (s = ua.match(/msie ([\d.]+)/)) ? Sys.ie = s[1] :

//        (s = ua.match(/firefox\/([\d.]+)/)) ? Sys.firefox = s[1] :

//        (s = ua.match(/chrome\/([\d.]+)/)) ? Sys.chrome = s[1] :

//        (s = ua.match(/opera.([\d.]+)/)) ? Sys.opera = s[1] :

//        (s = ua.match(/version\/([\d.]+).*safari/)) ? Sys.safari = s[1] : 0;
//        var curWwwPath = window.document.location.href;
//        //获取主机地址之后的目录，如： uimcardprj/share/meun.jsp   
//        var pathName = window.document.location.pathname;
//        var pos = curWwwPath.indexOf(pathName);
//        var mulu = pathName.substring(0, pathName.substr(1).indexOf('/') + 1);
//        var smart = pathName.substring(mulu.length + 1, pathName.lastIndexOf("/"));
//        //获取主机地址，如： http://localhost:8083  
//        var localhostPath = curWwwPath.substring(0, pos);
//        var isInstalled = false;
//        var version = null;
//        if (Sys.firefox || Sys.chrome) {
//            var mimetype = navigator.mimeTypes["application/x-itst-activex"];
//            if (mimetype) {
//                var plugin = mimetype.enabledPlugin;
//                if (plugin) {
//                    //the plugins has done
//                    alert("1");
//                }
//            } else {
//                 alert("2");
//            }
//        } 

//        
//    </script>