function getValuePro(a) {
    var province = document.getElementById("ctl00_ContentPlaceHolder1_prov");
    if (a == "不选") {
        province.value = "";
        document.getElementById("ctl00_ContentPlaceHolder1_county").value = "";
        document.getElementById("ctl00_ContentPlaceHolder1_village").value = "";
        document.getElementById("ctl00_ContentPlaceHolder1_hideBtn1").click();
        hide();
    }
    else {
        province.value = a;
        document.getElementById("ctl00_ContentPlaceHolder1_county").value = "";
        document.getElementById("ctl00_ContentPlaceHolder1_village").value = "";
        document.getElementById("ctl00_ContentPlaceHolder1_hideBtn1").click();
        hide();
    }
    var province = document.getElementById("ctl00_ContentPlaceHolder1_prov");

}

function getValueCou(a) {
    var county = document.getElementById("ctl00_ContentPlaceHolder1_county");
    if (a == "不选" || a == "未找到区(县)") {
        county.value = "";
        var village = document.getElementById("ctl00_ContentPlaceHolder1_village");
        village.value = "";
        document.getElementById("ctl00_ContentPlaceHolder1_hideBtn2").click();

    } else {

        county.value = a;
        document.getElementById("ctl00_ContentPlaceHolder1_hideBtn2").click();
        document.getElementById("ctl00_ContentPlaceHolder1_village").value = "";

    }
    hide();
}

function getValueVil(a) {
    var province = document.getElementById("ctl00_ContentPlaceHolder1_village");
    if (a == "不选" || a == "未找到相应小区") {

        province.value = "";
    } else {
        province.value = a;
    }

    // document.getElementById("ContentPlaceHolder1_hideBtn3").click();
    hide();
}
function show(a) {
    for (i = 1; i <= 3; i++) {
        var divname = "drop" + i;
        var triname = "tri" + i;
        if (i != a) {

            getdisplaynone(divname);
            getdisplaynone(triname);
        } else {
            if (document.getElementById(triname).style.display == "block" && document.getElementById(divname).style.display == "block" )
            {
                getdisplaynone(triname);
                getdisplaynone(divname);
            }
            else
            {
                getdisplayblock(triname);
                getdisplayblock(divname)
            }
        }
    }

}

function hide() {
    getdisplaynone("drop1");
    getdisplaynone("drop2");
    getdisplaynone("drop3");
    getdisplaynone("tri1");
    getdisplaynone("tri2");
    getdisplaynone("tri3");
}

function showbom() {

    var provalue = document.getElementById("ctl00_ContentPlaceHolder1_prov");
    var couvalue = document.getElementById("ctl00_ContentPlaceHolder1_county");
    var vilvalue = document.getElementById("ctl00_ContentPlaceHolder1_village");

    if (provalue.value == "" && couvalue.value == "" && vilvalue.value == "") {

        showbynum(1);
    }
    else if (provalue.value != "" && couvalue.value == "" && vilvalue.value == "") {

        showbynum(2);

    } else if (provalue.value != "" && couvalue.value != "" && vilvalue.value == "") {

        showbynum(3);
    } else if (provalue.value != "" && couvalue.value != "" && vilvalue.value != "") {

        window.open("community.aspx?pro=" + provalue.value + "&cou=" + couvalue.value + "&vil=" + vilvalue.value);
    }
    document.getElementById("ctl00_ContentPlaceHolder1_retirevalBtn").click();
}

function showbynum(a) {

    for (i = 1; i <= 3; i++) {
        var bomname = "bom" + i;
        if (i == a) {

            getdisplayblock(bomname);
        } else {

            getdisplaynone(bomname);
        }
    }
}

function getdisplaynone(elementname)
{
    var elementdisplay = document.getElementById(elementname).style.display="none";
 
}

function getdisplayblock(elementname) {
    var elementdisplay = document.getElementById(elementname).style.display="block";

}

function hidesr() {
    document.getElementById("ctl00_ContentPlaceHolder1_searchresult").style.display="none";
}