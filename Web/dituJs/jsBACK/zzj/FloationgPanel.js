//GoToLocation
function toggleFlatingPanel(id) {
    var gtl = $get(id);
    if (gtl != null) {
        toggleFloatingPanelVisibility(id);
    }
    else
        alert("Go To Location is not available");
}

//OverviewMap
function toggleOverviewMap() {
    var ovm = $find("OverviewMap1");
    if (ovm != null) {
        if (ovm.isVisible()) {
            ovm.hide();
        } else {
            ovm.show();
        }
    } else {
        alert("OverviewMap is not for ready!");
    }

}


//Magnifier
function toggleMagnifier() {
    var mag = $get("Magnifier1");
    if (mag != null) {
        toggleFloatingPanelVisibility('Magnifier1');
    } else
        alert("Magnifier is not available");
}