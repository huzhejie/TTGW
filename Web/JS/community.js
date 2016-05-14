
//页面加载完毕之后，添加所有的点击事件
addEvent(window, "load", addClick);
//页面加载完之后要添加的函数
function addClick() {
    //div.comInfo处切换用
    (function () {
        var comInfoTitle1 = $getId("comInfoTitle1");
        var comInfoTitle2 = $getId("comInfoTitle2");
        var arr = getByClass(document, "comInfoContent");
        addEvent(comInfoTitle1, "click", function () {
            arr[0].style.display = "block";
            arr[1].style.display = "none";
            comInfoTitle1.style.backgroundColor = "#fff";
            comInfoTitle2.style.backgroundColor = "#87ceFA";
        }, false);

        addEvent(comInfoTitle2, "click", function () {
            arr[1].style.display = "block";
            arr[0].style.display = "none";
            comInfoTitle1.style.backgroundColor = "#87ceFA";
            comInfoTitle2.style.backgroundColor = "#fff";
        }, false);
    })();

    //根据点击显示不同的区域
    (function () {

        for (k = 1; k <= 8; k++) {
            addForproject(k);
        }
        function addForproject(a) {
            addEvent($getId("project" + a), "click", function () {
                for (i = 1; i <= 8; i++) {
                    var vilnumber = "comContent" + i;
                    var navnumber = "project" + i;
                    var vildiv = $getId(vilnumber);
                    var navdiv = $getId(navnumber);
                    if (i == a) {
                        vildiv.style.display = "block";
                        if (!hasClass(navdiv, "comLiOn")) {
                            addClass(navdiv, "comLiOn");
                        }
                    } else {
                        vildiv.style.display = "none";
                        if (hasClass(navdiv, "comLiOn")) {
                            removeClass(navdiv, "comLiOn");
                        }
                    }
                }
            }, false);
        }

    })();

    //绑定四个显示图表的按钮事件
    (function () {
        //绑定事件
        addEvent($getId("door_rateBtn"), "click", show_linechart_door, false);
        addEvent($getId("laborBtn"), "click", show_linechart_labor, false);
        addEvent($getId("incomeBtn"), "click", show_linechart_income, false);
        addEvent($getId("rentBtn"), "click", show_linechart_rent, false);

       
    })();

    //选择指标时的方法
    (function () {
        //存储指标之间的关系
        //name为2级指标的名字
        //children保存的是三级指标
        var childOp = {
            //二级列表和三级列表
            "secondAndThird": [
            {
                "name": "Water_supply_validate",
                "children": ["Water_capcity_degree", "One_hou_one_water_meter_rate", "Water_pipe_net_good_degree"]

            },
            {
                "name": "Ff_validate",
                "children": ["Outdoors_ff_good_rate", "Indoors_ff_good_rate", "Ff_way_good_rate"]
            },
            {
                "name": "Elec_supply_validate",
                "children": ["Elec_capcity_degree", "Elec_wire_safe_degree"]
            },
            {
                "name": "Traffic_validate",
                "children": ["Road_Link_degree", "Road_good_degree"]
            },
            {
                "name": "Light_validate",
                "children": ["Road_light_suff_degree", "Passway_light_suff_degree"]
            },
            {
                "name": "Sanitation_validate",
                "children": ["Refuse_collect_rate", "Toilet_cover_degree"]
            },
            {
                "name": "Drain_validate",
                "children": ["Sewage_collect_rate", "Drain_safe_degree"]
            },
            {
                "name": "Commerce_validate",
                "children": ["CVS_good_rate1", "Vegetable_market_good_rate"]
            },
            {
                "name": "Dradin_validate",
                "children": ["Sewage_collect_rate", "Drain_safe_degree"]
            }
            ]
        }
        for (var j = 1; j <= 5; j++) {
            var parentElement = $getId("choice" + j);           
            addEvent(parentElement,"click",function(e){
                var e = e || window.event;
                var keyElement = e.target || e.srcElement;
                if (keyElement && keyElement.tagName == "A") {
                    //操作点击的元素                   
                    var _this = keyElement, flag = true;//flag用于标记操作的是否是三级指标
                    responseChoice(_this, "normal");
                    for (var o in childOp.secondAndThird) {
                        //当为2级指标时三级指标相应做出变化
                        if (_this.id == childOp.secondAndThird[o].name) {
                            for (var childNum = 0; childNum < childOp.secondAndThird[o].children.length; childNum++) {
                                var childId = $getId(childOp.secondAndThird[o].children[childNum]);
                                //如果二级指标被选中则相应的三级指标全选
                                if (hasClass(_this, "oni")) {
                                    responseChoice(childId, "add");
                                } else { //如果二级指标未选中则相应的三级指标全不选
                                    responseChoice(childId, "remove");
                                }
                            }
                            flag == false;
                        }
                    }
                    if (flag) {//证明操作的是三级指标
                        //当操作的是三级指标时，如果三级指标全部被选中，则二级指标一定要选中
                        //如果三级指标全部未选中，则二级指标也未选中
                        for (var secondLevel in childOp.secondAndThird) {
                            var keySecond = childOp.secondAndThird[secondLevel];
                            var parentElement = $getId(keySecond.name);
                            for (var thirdLevel in keySecond.children) {
                                if (_this.id == keySecond.children[thirdLevel]) {
                                    flagNum = 0;//用于标记同目录下的三级指标是否都被选中
                                    for (var keyChild = 0; keyChild < keySecond.children.length; keyChild++) {
                                        var key = $getId(keySecond.children[keyChild]);
                                        if (hasClass(key, "oni")) {
                                            flagNum += 1;//如果含有"oni"则加1
                                        }
                                    }
                                    if (flagNum == keySecond.children.length) {//相等证明每个元素都有"oni"
                                        responseChoice(parentElement, "add");
                                    } else {//否则证明不是每个元素都有"oni"
                                        responseChoice(parentElement, "remove");
                                    }
                                }
                            }
                        }
                    }

                    ////
                }
            })
        }
    })();

    //div#ctnerTab切换指标类别的时候用
    (function () {
        addEvent($getId("ctnerTab"), "click", function (e) {
            var e = e || window.event;
            targetElement = e.target || e.srcElement;
            if (targetElement && targetElement.tagName == "A") {
                var keyIndex = 1;
                if (!hasClass(targetElement, 'on')) {
                    var arr = $getId("ctnerTab").getElementsByTagName("a");
                    for (var i = 0; i < arr.length; i++) {
                        if (hasClass(arr[i], "on")) {
                            removeClass(arr[i], "on");
                        }
                        if (arr[i] == targetElement) {
                            keyIndex = i + 1;
                        }
                    }

                    for (var index = 1; index <= 5; index++) {
                        var keyEle = $getId("choice" + index);
                        if (!hasClass(keyEle, 'dn')) {
                            addClass(keyEle, "dn");
                        }
                    }
                    addClass(targetElement, "on");
                    removeClass($getId("choice" + keyIndex), "dn");
                }

            }
        })
    })();
    
 
    //显示小区总资金情况
    show_viltotal_echart();

    //显示小区专项资金情况
    show_viltotal_typeechart();
};

//根据情况，给元素加上或者删除"oni"类
function responseChoice(choiceId, type) {
    var _this = choiceId;
    var a = _this.getElementsByTagName("i")[0];
    if (type == "normal") {//normal时，若是有oni，则删除，没有则加上
        if (hasClass(_this, "oni")) {
            removeClass(_this, "oni");
            a.style.visibility = "hidden";
        } else {
            addClass(_this, "oni");
            a.style.visibility = "visible";
        }
    } else if (type == "remove") {//remove时没有则不变，有则删除
        if (hasClass(_this, "oni")) {
            removeClass(_this, "oni");
            a.style.visibility = "hidden";
        }
    } else if (type == "add") {//add时有则不变，没有则加上
        if (!hasClass(_this, "oni")) {
            addClass(_this, "oni");
            a.style.visibility = "visible";
        }
    }
}

//在显示echarts前，县判断其已选数据是否合理
function checkFile() {

    var oPa = document;
    var aResultList = [];
    var chooseId = [];
    aResultList = getByClass(oPa, "oni");

    for (var i in aResultList) {
        chooseId.push(aResultList[i].id);
    }
    var start = $getId("start");
    var end = $getId("end");
    var only = $getId("demo");
    var json = {};
    if (chooseId.length == 0) {
        alert("请选择指标！");
        return false;
    } else {
        json.ids = chooseId;
    }
    json.startDate = start.innerHTML;
    json.endDate = end.innerHTML;
    json.onlyDtae = only.value;

    var ids = $getId("ids");
    ids.value = json.ids;

    var startvalue = json.startDate.replace(/(^\s*)|(\s*$)/g, "");

    var endvalue = json.endDate.replace(/(^\s*)|(\s*$)/g, "");

    var onlyvalue = json.onlyDtae.replace(/(^\s*)|(\s*$)/g, "");

    var startDate = $getId("startDate");
    var endDate = $getId("endDate");
    var onlyDate = $getId("onlyDate");
    if (onlyvalue == "") {

        if (startvalue != "" && endvalue == "") {
            alert("请选择结束时间");
            return false;
        }
        else if (startvalue == "" && endvalue != "") {
            alert("请选择开始时间");
            return false;
        }
        else if (startvalue != "" && endvalue != "") {
            startDate.value = startvalue;
            endDate.value = endvalue;
            onlyDate.value = "";
        }
        else if (startvalue == "" && endvalue == "") {
            alert("请选择时间");
            return false;
        }
    } else if (onlyvalue != "") {
        if (startvalue != "" || endvalue != "") {
            alert("请选择合理的时间");
            return false;
        }
        else if (startvalue == "" && endvalue == "") {
            startDate.value = "";
            endDate.value = "";
            onlyDate.value = onlyvalue;
        }
    }

}

//显示图表时创建一个弹出层用于显示折线图
function createShowDiv() {
    //创建一个块用于显示echarts
    //用于承载echarts
    var showDivBg = document.createElement("div");
    //echarts画在这个div中
    var showDiv = document.createElement("div");
    //上方蓝边
    var showDivTitle = document.createElement("div");

    showDivBg.className = "showDivBg";
    showDivBg.setAttribute("id", "showDivBg");

    showDiv.className = "showDiv";
    showDiv.setAttribute("id", "main_door_rate");

    showDivTitle.className = "showDivTitle";
    addEvent(showDivTitle, "click", deleteEcharts, false);
    //将创建的元素添加到body中
    document.body.appendChild(showDivBg);
    showDivBg.appendChild(showDivTitle);
    showDivBg.appendChild(showDiv);

}

//当showDivBg存在时,将其删除
function deleteEcharts() {
    var keyElement = $getId("showDivBg");
    if (keyElement) {
        keyElement.innerHTML = "";
        keyElement.parentNode.removeChild(keyElement);
        keyElement = null;
    }
}

//获得时间
function getTime() {
    var lineTime = $getId(TextBoxTimeID).value;
    var lineTimeArr = lineTime.split('@');
    var newArr = new Array();
    for (var i = 0; i < lineTimeArr.length - 1; i++) {
        newArr[i] = lineTimeArr[i];
    }
    return newArr;
}

//显示门面使用率
function show_linechart_door() {
    //如果echarts已经存在，则删除
    deleteEcharts();
    createShowDiv();
    var lineTimeArr = getTime();
    //省市门面使用率
    var str_citydoor_rate = $getId(TextBoxCityDoorRateID).value;
    var mycitydoor_rate = str_citydoor_rate.split('-');
    var citydoor_rate = new Array();
    for (var i = 0; i < mycitydoor_rate.length - 1; i++) {
        citydoor_rate[i] = mycitydoor_rate[i] - 0;
    }
    //小区门面使用率
    var str_vildoor_rate = $getId(TextBoxVilDoorRateID).value;
    var myvildoor_rate = str_vildoor_rate.split('-');
    var vildoor_rate = new Array();
    for (var s = 0; s < myvildoor_rate.length - 1; s++) {
        vildoor_rate[s] = myvildoor_rate[s] - 0;
    }

    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts', 'echarts/chart/line' // 使用折线图就加载line模块，按需加载
    ],
    function (ec) {
        // 基于准备好的dom，初始化echarts图表
        var myChart = ec.init(document.getElementById('main_door_rate'));
        option = {
            //title: {
            //   text: '未来一周气温变化',
            //   subtext: '纯属虚构'
            //},
            tooltip: {
                trigger: 'axis'
            },
            legend: {
                data: ['小区门面使用率', '市门面使用率']
            },

            calculable: true,
            xAxis: [
                        {
                            type: 'category',
                            boundaryGap: false,
                            data: lineTimeArr
                        }
            ],
            yAxis: [
                        {
                            type: 'value',
                            axisLabel: {
                                formatter: '{value} %'
                            }
                        }
            ],
            series: [
                {
                    name: '小区门面使用率',
                    type: 'line',
                    data: vildoor_rate,
                    markPoint: {
                        data: [
                            { type: 'max', name: '最大值' },
                            { type: 'min', name: '最小值' }
                        ]
                    },
                    markLine: {
                        data: [
                            { type: 'average', name: '平均值' }
                        ]
                    }
                },
                {
                    name: '市门面使用率',
                    type: 'line',
                    data: citydoor_rate,

                    markPoint: {
                        data: [

                           { type: 'max', name: '最大值' },
                            { type: 'min', name: '最小值' }
                        ]
                    },
                    markLine: {
                        data: [
                           { type: 'average', name: '平均值' }
                        ]
                    }
                }
            ]
        };
        myChart.setOption(option);
    });
}

//显示劳动力就业率
function show_linechart_labor() {
    //如果echarts已经存在，则删除
    deleteEcharts();
    createShowDiv();
    var lineTimeArr = getTime();
    //省市劳动力就业率
    var str_cityemployment_rate = $getId(TextBoxCityEmploymentRateID).value;
    var mycityemployment_rate = str_cityemployment_rate.split('-');
    var cityemployment_rate = new Array();
    for (var p = 0; p < mycityemployment_rate.length - 1; p++) {
        cityemployment_rate[p] = mycityemployment_rate[p] - 0;
    }
    //小区劳动力就业率
    var str_vilemployment_rate = $getId(TextBoxVilEmploymentRateID).value;
    var myvilemployment_rate = str_vilemployment_rate.split('-');
    var vilemployment_rate = new Array();
    for (var t = 0; t < myvilemployment_rate.length - 1; t++) {
        vilemployment_rate[t] = myvilemployment_rate[t] - 0;
    }
    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts', 'echarts/chart/line' // 使用折线图就加载line模块，按需加载
    ],
    function (ec) {
        // 基于准备好的dom，初始化echarts图表
        var myChart = ec.init(document.getElementById('main_door_rate'));
        option = {

            tooltip: {
                trigger: 'axis'
            },
            legend: {
                data: ['小区劳动力就业率', '市劳动力就业率']
            },

            calculable: true,
            xAxis: [
                        {
                            type: 'category',
                            boundaryGap: false,
                            data: lineTimeArr
                        }
            ],
            yAxis: [
                        {
                            type: 'value',
                            axisLabel: {
                                formatter: '{value} %'
                            }
                        }
            ],
            series: [
                {
                    name: '小区劳动力就业率',
                    type: 'line',
                    data: vilemployment_rate,
                    markPoint: {
                        data: [
                            { type: 'max', name: '最大值' },
                            { type: 'min', name: '最小值' }
                        ]
                    },
                    markLine: {
                        data: [
                            { type: 'average', name: '平均值' }
                        ]
                    }
                },
                {
                    name: '市劳动力就业率',
                    type: 'line',
                    data: cityemployment_rate,
                    markPoint: {
                        data: [
                        // {name : '周最低', value : -2, xAxis: 1, yAxis: -1.5}
                           { type: 'max', name: '最大值' },
                            { type: 'min', name: '最小值' }
                        ]
                    },
                    markLine: {
                        data: [
                            { type: 'average', name: '平均值' }
                        ]
                    }
                }
            ]
        };
        myChart.setOption(option);
    });
}

//显示人均可支配收入
function show_linechart_income() {
    //如果echarts已经存在，则删除
    deleteEcharts();

    createShowDiv();
    var lineTimeArr = getTime();
    //省市人均可支配收入
    var str_citypcdi = $getId(TextBoxCityPcdiID).value;
    var mycitypcdi = str_citypcdi.split('-');
    var citypcdi = new Array();
    for (var q = 0; q < mycitypcdi.length - 1; q++) {
        citypcdi[q] = mycitypcdi[q] - 0;
    }
    //小区人均可支配收入
    var str_vilpcdi = $getId(TextBoxVilPcdiID).value;
    var myvilpcdi = str_vilpcdi.split('-');
    var vilpcdi = new Array();
    for (var u = 0; u < myvilpcdi.length - 1; u++) {
        vilpcdi[u] = myvilpcdi[u] - 0;
    }

    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts', 'echarts/chart/line' // 使用折线图就加载line模块，按需加载
    ],
    function (ec) {
        // 基于准备好的dom，初始化echarts图表
        var myChart = ec.init(document.getElementById('main_door_rate'));
        option = {
            //title: {
            //   text: '未来一周气温变化',
            //   subtext: '纯属虚构'
            //},
            tooltip: {
                trigger: 'axis'
            },
            legend: {
                data: ['小区人均可支配收入', '市人均可支配收入']
            },

            calculable: true,
            xAxis: [
                        {
                            type: 'category',
                            boundaryGap: false,
                            data: lineTimeArr
                        }
            ],
            yAxis: [
                        {
                            type: 'value',
                            axisLabel: {
                                formatter: '{value} 元'
                            }
                        }
            ],
            series: [
                {
                    name: '小区人均可支配收入',
                    type: 'line',
                    data: vilpcdi,
                    markPoint: {
                        data: [
                            { type: 'max', name: '最大值' },
                            { type: 'min', name: '最小值' }
                        ]
                    },
                    markLine: {
                        data: [
                            { type: 'average', name: '平均值' }
                        ]
                    }
                },
                {
                    name: '市人均可支配收入',
                    type: 'line',
                    data: citypcdi,
                    markPoint: {
                        data: [
                        // {name : '周最低', value : -2, xAxis: 1, yAxis: -1.5}
                           { type: 'max', name: '最大值' },
                            { type: 'min', name: '最小值' }
                        ]
                    },
                    markLine: {
                        data: [
                           { type: 'average', name: '平均值' }
                        ]
                    }
                }
            ]
        };
        myChart.setOption(option);
    });
}

//显示房屋租金平均水平
function show_linechart_rent() {
    //如果echarts已经存在，则删除
    deleteEcharts();

    createShowDiv();
    var lineTimeArr = getTime();
    //省市房屋租金平均水平
    var str_cityrent_level = $getId(TextBoxCityRentLevelID).value;
    var mycityrent_level = str_cityrent_level.split('-');
    var cityrent_level = new Array();
    for (var r = 0; r < mycityrent_level.length - 1; r++) {
        cityrent_level[r] = mycityrent_level[r] - 0;
    }

    //省市房屋租金平均水平
    var str_vilrent_level = $getId(TextBoxVilRentLevelID).value;
    var myvilrent_level = str_vilrent_level.split('-');
    var vilrent_level = new Array();
    for (var v = 0; v < myvilrent_level.length - 1; v++) {
        vilrent_level[v] = myvilrent_level[v] - 0;
    }
    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts', 'echarts/chart/line' // 使用折线图就加载line模块，按需加载
    ],
    function (ec) {
        // 基于准备好的dom，初始化echarts图表
        var myChart = ec.init(document.getElementById('main_door_rate'));
        option = {
            //title: {
            //   text: '未来一周气温变化',
            //   subtext: '纯属虚构'
            //},
            tooltip: {
                trigger: 'axis'
            },
            legend: {
                data: ['小区房屋租金平均水平', '市房屋租金平均水平']
            },

            calculable: true,
            xAxis: [
                        {
                            type: 'category',
                            boundaryGap: false,
                            data: lineTimeArr
                        }
            ],
            yAxis: [
                        {
                            type: 'value',
                            axisLabel: {
                                formatter: '{value} 元'
                            }
                        }
            ],
            series: [
                {
                    name: '小区房屋租金平均水平',
                    type: 'line',
                    data: vilrent_level,
                    markPoint: {
                        data: [
                            { type: 'max', name: '最大值' },
                            { type: 'min', name: '最小值' }
                        ]
                    },
                    markLine: {
                        data: [
                            { type: 'average', name: '平均值' }
                        ]
                    }
                },
                {
                    name: '市房屋租金平均水平',
                    type: 'line',
                    data: cityrent_level,
                    markPoint: {
                        data: [
                        // {name : '周最低', value : -2, xAxis: 1, yAxis: -1.5}
                           { type: 'max', name: '最大值' },
                            { type: 'min', name: '最小值' }
                        ]
                    },
                    markLine: {
                        data: [
                            { type: 'average', name: '平均值' }
                        ]
                    }
                }
            ]
        };
        myChart.setOption(option);
    });
}

//显示小区总资金情况
function show_viltotal_echart() {
    //待建
    var before = $getId(TextBoxBeforeID).value;
    var beforeArray = before.split('-');
    var newBeforeArray = [];
    var i = 0;
    for (i = 0; i < beforeArray.length - 1; i++) {
        newBeforeArray[i] = beforeArray[i];
    }
    //在建
    var inCons = $getId(TextBoxInID).value;
    var inArray = inCons.split('-');
    var newInArray = [];
    for (i = 0; i < inArray.length - 1; i++) {
        newInArray[i] = inArray[i];
    }
    //在建
    var com = $getId(TextBoxComID).value;
    var comArray = inCons.split('-');
    var newComArray = [];
    for (i = 0; i < comArray.length - 1; i++) {
        newComArray[i] = comArray[i];
    }

    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts', 'echarts/chart/bar' // 使用柱状图就加载bar模块，按需加载
    ],
      function (ec) {
          // 基于准备好的dom，初始化echarts图表
          var myChart = ec.init(document.getElementById('main_viltotal_capital'));
          option = {
              //                                        title : {
              //                                           text: '按资金来源划分的投资计划及完成情况',
              //       
              //                                        },
              tooltip: {
                  trigger: 'axis'
              },
              legend: {
                  data: ['待建', '在建','完建']
              },

              calculable: true,
              xAxis: [
                  {
                      type: 'category',
                      data: ['2011-2013年项目', '2014年后单项工程']
                  }
              ],
              yAxis: [
                  {
                      type: 'value',
                      axisLabel: {
                          formatter: '{value} 个'
                      }
                  }
              ],
              series: [
                  {
                      name: '待建',
                      type: 'bar',
                      data: newBeforeArray,
                      markPoint: {
                          data: [
                          // {type : 'max', name: '最大值'},
                          // {type : 'min', name: '最小值'}
                          ]
                      },
                      markLine: {
                          data: [
                          // {type : 'average', name: '平均值'}
                          ]
                      }
                  },
                  {
                      name: '在建',
                      type: 'bar',
                      data: newInArray,
                      markPoint: {
                          data: [
                          // {type : 'max', name: '最大值'},
                          // {type : 'min', name: '最小值'}
                          ]
                      },
                      markLine: {
                          data: [
                          // {type : 'average', name : '平均值'}
                          ]
                      }
                  },
                   {
                       name: '完建',
                       type: 'bar',
                       data: newComArray,
                       markPoint: {
                           data: [
                           // {type : 'max', name: '最大值'},
                           // {type : 'min', name: '最小值'}
                          ]
                       },
                       markLine: {
                           data: [
                           // {type : 'average', name : '平均值'}
                          ]
                       }
                   }
              ]
          };
          myChart.setOption(option);
      });

}

//显示小区专项资金情况
function show_viltotal_typeechart() {
    //计划专项资金
    var str_cityplan2 = $getId(TextBoxVilPlan2ID).value;
    var mycityplan2 = str_cityplan2.split('-');
    var cityplan2 = new Array();
    for (var n = 0; n < mycityplan2.length - 1; n++) {
        cityplan2[n] = mycityplan2[n];
    }

    //完成专项资金
    var str_cityfinished2 = $getId(TextBoxVilFinished2ID).value;
    var mycityfinished2 = str_cityfinished2.split('-');
    var cityfinished2 = new Array();
    for (var m = 0; m < mycityfinished2.length - 1; m++) {
        cityfinished2[m] = mycityfinished2[m];
    }


    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts', 'echarts/chart/bar' // 使用柱状图就加载bar模块，按需加载
    ],
     function (ec) {
         // 基于准备好的dom，初始化echarts图表
         var myChart = ec.init(document.getElementById('main_viltotal_type'));
         option = {
             //                                        title : {
             //                                           text: '按资金来源划分的投资计划及完成情况',
             //       
             //                                        },
             tooltip: {
                 trigger: 'axis'
             },
             legend: {
                 data: ['计划投资', '完成投资']
             },

             calculable: true,
             xAxis: [
                 {
                     type: 'category',
                     data: ['房屋居住安全', '基础设施', '环保设施', '公共服务设施', '就业与创业扶持']
                 }
             ],
             yAxis: [
                 {
                     type: 'value',
                     axisLabel: {
                         formatter: '{value} 万元'
                     }
                 }
             ],
             series: [
                 {
                     name: '计划投资',
                     type: 'bar',
                     data: cityplan2,
                     markPoint: {
                         data: [
                         // {type : 'max', name: '最大值'},
                         // {type : 'min', name: '最小值'}
                         ]
                     },
                     markLine: {
                         data: [
                         // {type : 'average', name: '平均值'}
                         ]
                     }
                 },
                 {
                     name: '完成投资',
                     type: 'bar',
                     data: cityfinished2,
                     markPoint: {
                         data: [
                         // {type : 'max', name: '最大值'},
                         // {type : 'min', name: '最小值'}
                         ]
                     },
                     markLine: {
                         data: [
                         // {type : 'average', name : '平均值'}
                         ]
                     }
                 }
             ]
         };
         myChart.setOption(option);
     });

}

//动态显示echarts的函数
function showechart() {
    var com_indicator = $getId("hideindicator").value;
    com_indicator = com_indicator.trim();
    var com_indicator_array = com_indicator.split('-');
    var ci_array = new Array();
    for (var p = 0; p < com_indicator_array.length - 1; p++) {
        ci_array[p] = com_indicator_array[p];
    }


    var com_id = $getId("hidecom_id").value;
    com_id = com_id.trim();


    var com_ectype = $getId("hidecom_ectype").value;
    if (com_ectype == 1) {
        //取出的不同时间不同指标数据                                  
        var com_time = $getId("hidecom_time").value;
        com_time = com_time.trim();
        var com_time_array = com_time.split('@')
        var ct_array = new Array();
        for (var x = 0; x < com_time_array.length - 1; x++) {
            ct_array[x] = com_time_array[x];
        }
        //取出的不同时间不同指标数据

        var diftime_difindicator = $getId("hidedata1").value;
        var difindicator_array = diftime_difindicator.split('-');
        var dtime_did = new Array();
        for (var i = 0; i < difindicator_array.length - 1; i++) {
            var same_indicator = difindicator_array[i].split('@'); //同一指标不同时间的值分开
            var s_indicator = new Array(); //去除same_indicator中最后一个空值，生成新的数组
            for (var k = 0; k < same_indicator.length - 1; k++) {
                s_indicator[k] = same_indicator[k]; //同一指标不同时间的值
            }
            dtime_did[i] = s_indicator; //数组ditime_did1中每一个索引存一个指标不同时间的值tem5
        }

        //以下是多时间、多或单指标 的折线图
        require.config({
            paths: {
                echarts: 'echarts-2.2.7/build/dist'
            }
        });
        // 使用
        require(['echarts', 'echarts/chart/line' // 使用折线图就加载line模块，按需加载
        ],
    function (ec) {
        // 基于准备好的dom，初始化echarts图表
        var myChart = ec.init(document.getElementById('main'));
        var option = {
            //                                        title: {
            //                                            text: com_id + '情况',
            //                                            x: 0,
            //                                            y: 0

            //                                        },
            tooltip: {
                trigger: 'axis'
            },
            legend: {
                data: ci_array,
                x: 80,
                y: 30
            },
            calculable: true,
            xAxis: [{
                type: 'category',
                data: ct_array
            }],
            yAxis: [{
                type: 'value',
                axisLabel: {
                    formatter: '{value} %'
                }

            }]
        };
        var series = [];
        for (var i = 0; i < ci_array.length; i++) { //循环构造出每条serial
            var serial = {};
            serial.name = ci_array[i];

            serial.data = dtime_did[i];
            serial.smooth = 'true';
            //下面都是固定值，也可以动态修改
            serial.type = 'line';
            serial.markPoint = {
                data: [{
                    type: 'max',
                    name: '最大值'
                },
                {
                    type: 'min',
                    name: '最小值'
                }]
            };
            serial.markLine = {
                smooth: 'true',
                data: [
                //                    { type: 'average', name: '平均值' }
                ]
            };
            series.push(serial); //push为数组方法，将指定的数据加入到数组尾部
        }

        option.series = series;
        myChart.setOption(option);
    });
    }
    else if (com_ectype = 2) {
        //取出同一时间不同指标

        var onlytime = $getId("hideonlytime").value;
        onlytime = onlytime.trim();
        var timeArry = new Array();
        timeArry[0] = onlytime;
        //同一时间不同指标的值

        var sametime_difid = $getId("hidedata2").value;
        var sametime_difid_array = sametime_difid.split('-');
        var dif_indicator_array = new Array();
        for (var m = 0; m < sametime_difid_array.length - 1; m++) {
            dif_indicator_array[m] = sametime_difid_array[m]; //去除最后一个空值，所有指标的值存入dif_indicator_array
        }

        //  以下是单时间、多或单指标 的柱状图
        require.config({
            paths: {
                echarts: 'echarts-2.2.7/build/dist'
            }
        });
        // 使用
        require(['echarts', 'echarts/chart/bar' // 使用柱状图就加载bar模块，按需加载
        ],
    function (ec) {
        // 基于准备好的dom，初始化echarts图表
        var myChart = ec.init($getId('main'));
        var option = {
            tooltip: {
                trigger: 'axis'
            },
            legend: {
                data: ci_array,
                x: 80,
                y: 30
            },
            calculable: true,
            xAxis: [{
                type: 'category',
                data: [onlytime]
            }],
            yAxis: [{
                type: 'value',
                axisLabel: {
                    formatter: '{value} %'
                }
            }]
        };
        var series = [];
        for (var i = 0; i < dif_indicator_array.length; i++) { //循环构造出每条serial
            var serial = {};
            serial.name = ci_array[i];

            serial.data = [dif_indicator_array[i]];

            //下面都是固定值，也可以动态修改
            serial.type = 'bar';
            serial.markPoint = {
                data: [{
                    type: 'max',
                    name: '最大值'
                },
                {
                    type: 'min',
                    name: '最小值'
                }]
            };
            //serial.smooth = 'ture';
            serial.markLine = {
                //smooth: 'true',
                data: [
                //                    { type: 'average', name: '平均值' }
                ]
            };
            series.push(serial); //push为数组方法，将指定的数据加入到数组尾部
        }

        option.series = series;
        myChart.setOption(option);
    });
    }

    else if (com_ectype == 0) {
        alert("选择错误！请重新选择！");

    }

}


//用于显示选择时间控件 日期范围限制
(function () {
    laydate.skin('molv');
    laydate({ elem: '#demo' }); //绑定元素


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
    laydate(start);
    laydate(end);

    //自定义日期格式
    laydate({
        elem: '#test1',
        format: 'YYYY年MM月DD日',
        festival: true, //显示节日
        choose: function (datas) { //选择日期完毕的回调
            alert('得到：' + datas);
        }
    });

    //日期范围限定在昨天到明天
    laydate({
        elem: '#hello3',
        min: laydate.now(-1), //-1代表昨天，-2代表前天，以此类推
        max: laydate.now(+1) //+1代表明天，+2代表后天，以此类推
    });

})();

