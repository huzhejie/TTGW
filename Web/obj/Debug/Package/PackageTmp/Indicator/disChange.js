/**
 * Created by Administrator on 2015/6/11.
 */

function $getId(id){
    return document.getElementById(id);
}
var childSet = [
    { "parent":"Water_supply_validate" ,  "childList":["Water_capcity_degree","One_hou_one_water_meter_rate","Water_pipe_net_good_degree"] }
];

var childOp={
    "secondAndThird": [{
        "name": "Water_supply_validate",
        "children": {
            "child": ["Water_capcity_degree", "One_hou_one_water_meter_rate","Water_pipe_net_good_degree"]
        }
    }, {
        "name": "Ff_validate",
        "children": {
            "child": ["Outdoors_ff_good_rate", "Indoors_ff_good_rate", "Ff_way_good_rate"]
        }
    }, {
        "name": "Elec_supply_validate",
        "children": {
            "child": ["Elec_capcity_degree", "Elec_wire_safe_degree"]
        }
    }, {
        "name": "Traffic_validate",
        "children": {
            "child": ["Road_link_degree","Road_good_degree"]
        }
    }, {
        "name": "Light_validate",
        "children": {
            "child": ["Road_light_suff_degree","Passway_light_suff_degree"]
        }
    },{
        "name": "Sanitation_validate",
        "children": {
            "child": ["Refuse_collect_rate","Toilet_cover_degree"]
        }
    },{
        "name": "Drain_validate",
        "children": {
            "child": ["Sewage_collect_rate","Drain_safe_degree"]
        }
    },{
        "name": "Commerce_validate",
        "children": {
            "child": ["CVS_good_rate1","Vegetable_market_good_rate"]
        }
    },{
        "name": "Dradin_validate",
        "children": {
            "child": ["Sewage_collect_rate","Drain_safe_degree"]
        }
    }

    ]
}

window.onload = function () {
    for (var j = 1; j <= 5; j++) {
        var first = document.getElementById("choice" + j);
        var aFirstArr = first.getElementsByTagName("a");
        for (var i = 0; i < aFirstArr.length; i++) {
            aFirstArr[i].onclick = function () {
                var _this = this;
                for (var o in childOp.secondAndThird) {
                    if (_this.id == childOp.secondAndThird[o].name) {
                        responseChoice(_this);
                        for (var childNum = 0; childNum < childOp.secondAndThird[o].children.child.length; childNum++) {
                            var childId = $getId(childOp.secondAndThird[o].children.child[childNum]);
                            responseChoice(childId);
                        }
                    } else {
                        responseChoice(_this);
                    }
                }

            }
        }


    }
}



function responseChoice(choiceId){
    var _this = choiceId;
    var a = _this.getElementsByTagName("i")[0];
    if (hasClass(_this, "oni")) {
        removeClass(_this, "oni");
        var a = _this.getElementsByTagName("i")[0];
        a.style.visibility = "hidden";
    } else {
        if (_this.className === "secondTree") {
            addClass(_this, "oni");
            var a = _this.getElementsByTagName("i")[0];
            a.style.visibility = "visible";

        } else {
            addClass(_this, "oni");
            var a = _this.getElementsByTagName("i")[0];
            a.style.visibility = "visible";
        }
    }
}

function btnClick() {

    var oPa = document;
    var aResultList = [];
    var chooseId = [];
    aResultList = getByClass(oPa, "oni");

    for (var i in aResultList) {
        chooseId.push(aResultList[i].id);
    }
    var start = document.getElementById("start");
    var end = document.getElementById("end");
    var only = document.getElementById("demo");
    var json = {};
    if (chooseId.length == 0) {
        alert("��ѡ��ָ�꣡");
        return false;
    } else {
        json.ids = chooseId;
    }
    json.startDate = start.innerHTML;
    json.endDate = end.innerHTML;
    json.onlyDtae = only.value;

    var ids = document.getElementById("ids");
    ids.value = json.ids;

    var startvalue = json.startDate.replace(/(^\s*)|(\s*$)/g, "");

    var endvalue = json.endDate.replace(/(^\s*)|(\s*$)/g, "");

    var onlyvalue = json.onlyDtae.replace(/(^\s*)|(\s*$)/g, "");

    var startDate = document.getElementById("startDate");
    var endDate = document.getElementById("endDate");
    var onlyDate = document.getElementById("onlyDate");
    if (onlyvalue == "") {

        if (startvalue != "" && endvalue == "") {
            alert("��ѡ�����ʱ��");
            return false;
        }
        else if (startvalue == "" && endvalue != "") {
            alert("��ѡ��ʼʱ��");
            return false;
        }
        else if (startvalue != "" && endvalue != "") {
            startDate.value = startvalue;
            endDate.value = endvalue;
            onlyDate.value = "";
        }
        else if (startvalue == "" && endvalue == "") {
            alert("��ѡ��ʱ��");
            return false;
        }
    } else if (onlyvalue != "") {
        if (startvalue != "" || endvalue != "" ) {
            alert("��ѡ������ʱ��");
            return false;
        }
        else if (startvalue == "" && endvalue == "" ) {
            startDate.value = "";
            endDate.value = "";
            onlyDate.value = onlyvalue;
        }
    }

}

function addClass(elemId,className){
    if(elemId.className == ""){
        elemId.className = className;
    }else{
        elemId.className += " "+className;
    }
}
function removeClass(obj, cls){
    var obj_class = ' '+obj.className+' ';//��ȡ class ����, ������β����һ���ո�. ex) 'abc        bcd' -> ' abc        bcd '
    obj_class = obj_class.replace(/(\s+)/gi, ' '),//������Ŀ��ַ��滻��һ���ո�. ex) ' abc        bcd ' -> ' abc bcd '
        removed = obj_class.replace(' '+cls+' ', ' ');//��ԭ���� class �滻����β���˿ո�� class. ex) ' abc bcd ' -> 'bcd '
    removed = removed.replace(/(^\s+)|(\s+$)/g, '');//ȥ����β�ո�. ex) 'bcd ' -> 'bcd'
    obj.className = removed;//�滻ԭ���� class.
}

function hasClass(obj, cls){
    var obj_class = obj.className,//��ȡ class ����.
        obj_class_lst = obj_class.split(/\s+/);//ͨ��split���ַ���clsת��������.
    x = 0;
    for(x in obj_class_lst) {
        if(obj_class_lst[x] == cls) {//ѭ������, �ж��Ƿ����cls
            return true;
        }
    }
    return false;
}
function getByClass(oParent,className){
    var aEle = oParent.getElementsByTagName("*");
    var aResult =[];
    var re=new RegExp('\\b'+className+'\\b', 'i');
    var i=0;
    for(i;i<aEle.length;i++){
        if(re.test(aEle[i].className))
        {
            aResult.push(aEle[i]);
        }
    }
    return aResult;
}







