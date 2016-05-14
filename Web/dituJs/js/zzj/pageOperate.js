function show() {
    if (mapInfoTab.title == "收起左栏") {
        panel.style.left = "-326px";
        mapHolder.style.marginLeft = "0px";
        mapInfoTab.title = "显示左栏";
        shad.style.left = "0px";
    } else {
        panel.style.left = "0px";
        mapHolder.style.marginLeft = "326px";
        mapInfoTab.title = "收起左栏";
        shad.style.left = "326px";
    }
}

function fullScreen() {
    var tool = document.getElementById("fullscreen");
    if (tool.Text != "返回") {
        panel.style.display = "none";
        mapHolder.style.marginLeft = "0px";
        topNav.style.display = "none";
        topHeader.style.display = "none";
        friendLink.style.display = "none";
        footer.style.display = "none";
        var holder = $getId("MapHolder");
        holder.style.height = window.innerHeight + "px";
        tool.Text = "返回";
    } else {
        panel.style.display = "block";
        topHeader.style.display = "block";
        mapHolder.style.marginLeft = "326px";
        topNav.style.display = "block";
        friendLink.style.display = "block";
        footer.style.display = "block";
        tool.Text = "全屏";
    }
}


$getId("btnSearch").onclick = btnSearch;