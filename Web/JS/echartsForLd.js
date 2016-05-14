//三峡库区
//生成三峡库区所有echarts
function showTotal()
{
    show_lt_yuan_chart();
    show_rt_yuan_chart();
    show_lb_yuan_chart();
    show_rb_yuan_chart();
    show_income_yuan_chart();
    showtotal_echart();
    showtotal_typeechart();
}

//show_lt_yuan_chart()显示小区数量的图
function show_lt_yuan_chart() {
    //县城小区
    var xc_com = $getId(Labeltotalcounty_community_numID).innerHTML - 0;
    //集镇小区
    var jz_com = $getId(Labeltotaltown_community_numID).innerHTML - 0;
    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts',
             'echarts/theme/macarons',
             'echarts/chart/pie' // 使用柱状图就加载pie模块，按需加载
    ],
        function (ec) {
            // 基于准备好的dom，初始化echarts图表
            var myChart = ec.init(document.getElementById('echart_yuan1'));
            option = {
                tooltip: {
                    trigger: 'item',
                    formatter: "{a} <br/>{b} : {c} ({d}%)"
                },
                legend: {
                    orient: 'horizontal',
                    x: 'center',
                    y:'250',
                    data: ['县城小区', '集镇小区']
                },
                //color: ['#00DDDD', '#0580b9'],
                calculable: true,
                series: [
                    {
                        name: '访问来源',
                        type: 'pie',
                        radius: ['40%', '57%'],
                        center: ['50%', '43%'],
                        itemStyle: {
                            normal: {
                                label: {
                                    show: false
                                },
                                labelLine: {
                                    show: false
                                }
                            },
                            emphasis: {
                                label: {
                                    show: true,
                                    position: 'center',
                                    textStyle: {
                                        fontSize: '14',
                                        fontWeight: 'bold'
                                    }
                                }
                            }
                        },
                        data: [
                            { value: xc_com, name: '县城小区' },
                            { value: jz_com, name: '集镇小区' }

                        ]
                    }
                ]
            };
            myChart.setOption(option);
        });

}

//show_rt_yuan_chart()显示项目覆盖小区数量的图  
function show_rt_yuan_chart() {
    //所有小区
    var all_ = $getId(Labeltotalcover_community_numID).innerHTML - 0;
    //专项资金项目覆盖小区
    var special_ = $getId(Labeltotalspecial_cover_community_numID).innerHTML - 0;
    //所有项目覆盖小区
    var all_com = $getId(Labeltotalcommunity_numID).innerHTML - 0;
    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts',
             'echarts/theme/macarons',
             'echarts/chart/pie' // 使用柱状图就加载pie模块，按需加载
    ],
        function (ec) {
            // 基于准备好的dom，初始化echarts图表
            var myChart = ec.init(document.getElementById('echart_yuan2'));
            var dataStyle = {
                normal: {
                    label: { show: false },
                    labelLine: { show: false }
                }
            };
            var placeHolderStyle = {
                normal: {
                    color: 'rgba(0,0,0,0)',
                    label: { show: false },
                    labelLine: { show: false }
                },
                emphasis: {
                    color: 'rgba(0,0,0,0)'
                }
            };
            option = {

                tooltip: {
                    show: true,
                    formatter: "{a} <br/>{b} :{d}%"
                },
                legend: {
                    orient: 'vertical',
                    x: document.getElementById('echart_yuan2').offsetWidth / 3+20,
                    y: 165,
                    itemGap: 12,
                    data: ['所有项目覆盖小区', '专项资金项目覆盖小区']
                },

                series: [
                    {
                        name: '1',
                        type: 'pie',
                        clockWise: false,
                        radius: [85, 110],
                        itemStyle: dataStyle,
                        data: [
                            {
                                value: parseInt((all_ / all_com) * 100) - 0,
                                name: '所有项目覆盖小区'
                            },
                            {
                                value: parseInt((1 - all_ / all_com) * 100) - 0,
                                name: 'invisible',
                                itemStyle: placeHolderStyle
                            }
                        ]
                    },
                    {
                        name: '2',
                        type: 'pie',
                        clockWise: false,
                        radius: [60, 85],
                        itemStyle: dataStyle,
                        data: [
                            {
                                value: parseInt((special_ / all_com) * 100) - 0,
                                name: '专项资金项目覆盖小区'
                            },
                            {
                                value: parseInt((1 - special_ / all_com) * 100) - 0,
                                name: 'invisible',
                                itemStyle: placeHolderStyle
                            }
                        ]
                    },

                ]
            };
            myChart.setOption(option);
        });

}

//show_lb_yuan_chart()显示移民占比的图
function show_lb_yuan_chart() {
    //总户数
    var fam_total = $getId(Labeltotaltotal_family_numID).innerHTML - 0;
    //总人数
    var peo_total = $getId(Labeltotaltotal_people_numID).innerHTML - 0;
    //移民户数
    var fam_im = $getId(Labeltotalimmigrant_family_numID).innerHTML - 0;
    //移民人数
    var peo_im = $getId(Labeltotalimmigrant_people_numID).innerHTML - 0;
    //移民户数占比
    var imf_rate = (fam_im * 100 / fam_total).toFixed(2);
    //移民人数占比
    var peo_rate = (peo_im * 100 / peo_total).toFixed(2);
    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts',
             'echarts/theme/macarons',
             'echarts/chart/pie' // 使用柱状图就加载pie模块，按需加载
    ],
        function (ec) {
            // 基于准备好的dom，初始化echarts图表
            var myChart = ec.init(document.getElementById('echart_yuan_people1'));
            var labelTop = {
                normal: {
                    label: {
                        show: true,
                        position: 'center',
                        formatter: '{b}',
                        textStyle: {
                            baseline: 'bottom'
                        }
                    },
                    labelLine: {
                        show: false
                    }
                }
            };
            var labelFromatter = {
                normal: {
                    label: {
                        formatter: function (params) {
                            return (100 - params.value).toFixed(2) + '%'
                        },
                        textStyle: {
                            baseline: 'top'
                        }
                    }
                },
            };
            var labelBottom = {
                normal: {
                    color: '#ccc',
                    label: {
                        show: true,
                        position: 'center'
                    },
                    labelLine: {
                        show: false
                    }
                },
                emphasis: {
                    color: 'rgba(0,0,0,0)'
                }
            };
            var radius = [50, 75];
            option = {
                legend: {
                    x: 'center',
                    y: '240',
                    data: [
                        '移民户数占比', '移民人数占比'
                    ]
                },


                series: [
                    {
                        type: 'pie',
                        center: ['32%', '40%'],
                        radius: radius,
                        x: '0%', // for funnel
                        itemStyle: labelFromatter,
                        data: [
                            { name: 'other', value: 100 - imf_rate, itemStyle: labelBottom },
                            { name: '移民户数占比', value: imf_rate, itemStyle: labelTop }
                        ]
                    },
                    {
                        type: 'pie',
                        center: ['70%', '40%'],
                        radius: radius,
                        x: '20%', // for funnel
                        itemStyle: labelFromatter,
                        data: [
                            { name: 'other', value: 100 - peo_rate, itemStyle: labelBottom },
                            { name: '移民人数占比', value: peo_rate, itemStyle: labelTop }
                        ]
                    },

                ]
            };
            myChart.setOption(option);
        });

}

// show_rb_yuan_chart（）显示劳动力就业率和低保人口比例     
function show_rb_yuan_chart() {
    //劳动力就业率
    var labor_rate = $getId(Labeltotallf_having_job_rateID).innerHTML - 0;
    //低保人口比例
    var poor_rate = $getId(Labeltotalpoor_people_rateID).innerHTML - 0;

    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts',
             'echarts/theme/macarons',
             'echarts/chart/pie' // 使用柱状图就加载pie模块，按需加载
    ],
        function (ec) {
            // 基于准备好的dom，初始化echarts图表
            var myChart = ec.init(document.getElementById('echart_yuan_people2'));
            var labelTop = {
                normal: {
                    label: {
                        show: true,
                        position: 'center',
                        formatter: '{b}',
                        textStyle: {
                            baseline: 'bottom'
                        }
                    },
                    labelLine: {
                        show: false
                    }
                }
            };
            var labelFromatter = {
                normal: {
                    label: {
                        formatter: function (params) {
                            return (100 - params.value).toFixed(2) + '%'
                        },
                        textStyle: {
                            baseline: 'top'
                        }
                    }
                },
            };
            var labelBottom = {
                normal: {
                    color: '#ccc',
                    label: {
                        show: true,
                        position: 'center'
                    },
                    labelLine: {
                        show: false
                    }
                },
                emphasis: {
                    color: 'rgba(0,0,0,0)'
                }
            };
            var radius = [50, 75];
            option = {
                legend: {
                    x: 'center',
                    y: '240',
                    data: [
                        '劳动力就业率', '低保人口比例'
                    ]
                },


                series: [
                    {
                        type: 'pie',
                        center: ['32%', '40%'],
                        radius: radius,
                        x: '0%', // for funnel
                        itemStyle: labelFromatter,
                        data: [
                            { name: 'other', value: 100 - labor_rate, itemStyle: labelBottom },
                            { name: '劳动力就业率', value: labor_rate, itemStyle: labelTop }
                        ]
                    },
                    {
                        type: 'pie',
                        center: ['70%', '40%'],
                        radius: radius,
                        x: '20%', // for funnel
                        itemStyle: labelFromatter,
                        data: [
                            { name: 'other', value: 100 - poor_rate, itemStyle: labelBottom },
                            { name: '低保人口比例', value: poor_rate, itemStyle: labelTop }
                        ]
                    },

                ]
            };
            myChart.setOption(option);
        });

}

//人均可支配收入变化情况   
function show_income_yuan_chart() {
    //人均可支配收入变化情况
    var income_change_rate = $getId(Labeltotalincome_changeID).innerHTML - 0;
 
    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts',
             'echarts/theme/macarons',
             'echarts/chart/pie' // 使用柱状图就加载pie模块，按需加载
    ],
        function (ec) {
            // 基于准备好的dom，初始化echarts图表
            var myChart = ec.init(document.getElementById('echart_yuan_income'));
            var labelTop = {
                normal: {
                    label: {
                        show: true,
                        position: 'center',
                        formatter: '{b}',
                        textStyle: {
                            baseline: 'bottom'
                        }
                    },
                    labelLine: {
                        show: false
                    }
                }
            };
            var labelFromatter = {
                normal: {
                    label: {
                        formatter: function (params) {
                            return (100 - params.value).toFixed(2) + '%'
                        },
                        textStyle: {
                            baseline: 'top'
                        }
                    }
                },
            }
            var labelBottom = {
                normal: {
                    color: '#ccc',
                    label: {
                        show: true,
                        position: 'center'
                    },
                    labelLine: {
                        show: false
                    }
                },
                emphasis: {
                    color: 'rgba(0,0,0,0)'
                }
            };
            var radius = [55, 85];
            option = {
                legend: {
                    x: 'center',
                    y: '240',
                    data: [
                        '人均可支配收入'
                    ]
                },


                series: [
                    {
                        type: 'pie',
                        center: ['50%', '40%'],
                        radius: radius,
                        x: '0%', // for funnel
                        itemStyle: labelFromatter,
                        data: [
                            { name: 'other', value: 100 - income_change_rate, itemStyle: labelBottom },
                            { name: '人均可支配收入', value: income_change_rate, itemStyle: labelTop }
                        ]
                    }                  
                ]
            };
            myChart.setOption(option);
        });

}

//按资金来源划分的投资计划及完成情况
function showtotal_echart() {
    
    //待建
    var before = $getId(TextBoxTotalBeforeID).value;
    var beforeArray = before.split('-');
    var newBeforeArray = [];
    var i = 0;
    for (i = 0; i < beforeArray.length - 1; i++) {
        newBeforeArray[i] = beforeArray[i];
    }
    //在建
    var inCons = $getId(TextBoxTotalInID).value;
    var inArray = inCons.split('-');
    var newInArray = [];
    for (i = 0; i < inArray.length - 1; i++) {
        newInArray[i] = inArray[i];
    }
    //在建
    var com = $getId(TextBoxTotalComID).value;
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
            var myChart = ec.init(document.getElementById('main_total_capital'));
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
                            formatter: '{value}个'
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

//专项资金按类别结构划分的投资计划及完成情况
function showtotal_typeechart() {
    var strtotal_plan2 = $getId(TextBoxTotalPlan2ID).value;
    var mytotal_plan2 = strtotal_plan2.split('-');
    var total_plan2 = new Array();
    for (var q = 0; q < mytotal_plan2.length - 1; q++) {
        total_plan2[q] = mytotal_plan2[q];
    }

    var strtotal_finished2 = $getId(TextBoxTotalFinished2ID).value;
    var mytotal_finished2 = strtotal_finished2.split('-');
    var total_finished2 = new Array();
    for (var r = 0; r < mytotal_finished2.length - 1; r++) {
        total_finished2[r] = mytotal_finished2[r];
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
            var myChart = ec.init(document.getElementById('main_total_type'));
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
                        //横坐标无法全部显示，所以显示在了其下方的table里面
                        //data: ['统建房居住安全', '基础设施', '环保设施', '公共服务设施', '营商环境']
                        data: ['', '', '', '', '']
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
                        data: total_plan2,
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
                        data: total_finished2,
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




//省市
//生成省市所有echarts
function showProvince() {
    show_lt_yuan_provincechart();
    show_rt_yuan_provincechart();
    show_lb_yuan_provincechart();
    show_rb_yuan_provincechart();
    show_income_yuan_provincechart();
    show_prototal_echart();
    show_prototal_typeechart();
}
//show_lt_yuan_provincechart()显示小区数量的图
function show_lt_yuan_provincechart() {
    //县城小区
    var xc_com = $getId(Labelprovincecounty_community_numID).innerHTML - 0;
    //集镇小区
    var jz_com = $getId(Labelprovincetown_community_numID).innerHTML - 0;
    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts',
             'echarts/theme/macarons',
             'echarts/chart/pie' // 使用柱状图就加载pie模块，按需加载
    ],
        function (ec) {
            // 基于准备好的dom，初始化echarts图表
            var myChart = ec.init(document.getElementById('echart_yuan_province1'));
            option = {
                tooltip: {
                    trigger: 'item',
                    formatter: "{a} <br/>{b} : {c} ({d}%)"
                },
                legend: {
                    orient: 'horizontal',
                    x: 'center',
                    y:'250',
                    data: ['县城小区', '集镇小区']
                },
                //color: ['#00DDDD', '#0580b9'],
                calculable: true,
                series: [
                    {
                        name: '访问来源',
                        type: 'pie',
                        radius: ['40%', '57%'],
                        center: ['50%', '43%'],
                        itemStyle: {
                            normal: {
                                label: {
                                    show: false
                                },
                                labelLine: {
                                    show: false
                                }
                            },
                            emphasis: {
                                label: {
                                    show: true,
                                    position: 'center',
                                    textStyle: {
                                        fontSize: '14',
                                        fontWeight: 'bold'
                                    }
                                }
                            }
                        },
                        data: [
                            { value: xc_com, name: '县城小区' },
                            { value: jz_com, name: '集镇小区' }

                        ]
                    }
                ]
            };
            myChart.setOption(option);
        });

}

//show_rt_yuan_provincechart()显示项目覆盖小区数量的图
function show_rt_yuan_provincechart() {
    //所有小区
    var all_ = $getId(Labelprovincecover_community_numID).innerHTML - 0;
    //专项资金项目覆盖小区
    var special_ = $getId(Labelprovincespecial_cover_community_numID).innerHTML - 0;
    //所有项目覆盖小区
    var all_com = $getId(Labelprovincecommunity_numID).innerHTML - 0;
    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts',
             'echarts/theme/macarons',
             'echarts/chart/pie' // 使用柱状图就加载pie模块，按需加载
    ],
        function (ec) {
            // 基于准备好的dom，初始化echarts图表
            var myChart = ec.init(document.getElementById('echart_yuan_province2'));
            var dataStyle = {
                normal: {
                    label: { show: false },
                    labelLine: { show: false }
                }
            };
            var placeHolderStyle = {
                normal: {
                    color: 'rgba(0,0,0,0)',
                    label: { show: false },
                    labelLine: { show: false }
                },
                emphasis: {
                    color: 'rgba(0,0,0,0)'
                }
            };
            option = {

                tooltip: {
                    show: true,
                    formatter: "{a} <br/>{b} : {d}%"
                },
                legend: {
                    orient: 'vertical',
                    x: document.getElementById('echart_yuan_province2').offsetWidth / 3+20,
                    y: 165,
                    itemGap: 12,
                    data: ['所有项目覆盖小区', '专项资金项目覆盖小区']
                },

                series: [
                    {
                        name: '1',
                        type: 'pie',
                        clockWise: false,
                        radius: [85, 110],
                        itemStyle: dataStyle,
                        data: [
                            {
                                value: parseInt((all_ / all_com) * 100) - 0,
                                name: '所有项目覆盖小区'
                            },
                            {
                                value: parseInt((1 - all_ / all_com) * 100) - 0,
                                name: 'invisible',
                                itemStyle: placeHolderStyle
                            }
                        ]
                    },
                    {
                        name: '2',
                        type: 'pie',
                        clockWise: false,
                        radius: [60, 85],
                        itemStyle: dataStyle,
                        data: [
                            {
                                value: parseInt((special_ / all_com) * 100) - 0,
                                name: '专项资金项目覆盖小区'
                            },
                            {
                                value: parseInt((1 - special_ / all_com) * 100) - 0,
                                name: 'invisible',
                                itemStyle: placeHolderStyle
                            }
                        ]
                    },

                ]
            };
            myChart.setOption(option);
        });

}

//show_lb_yuan_provincechart()显示移民占比的图
function show_lb_yuan_provincechart() {
    //居民总户数
    var fam_total = $getId(Labelprovincetotal_family_numID).innerHTML - 0;
    //居民总人数
    var peo_total = $getId(Labelprovincetotal_people_numID).innerHTML - 0;
    //移民总户数
    var fam_im = $getId(Labelprovinceimmigrant_family_numID).innerHTML - 0;
    //移民总人数
    var peo_im = $getId(Labelprovinceimmigrant_people_numID).innerHTML - 0;
    //移民户数占比
    var imf_rate = (fam_im * 100 / fam_total).toFixed(2);
    //移民人数占比
    var peo_rate = (peo_im * 100 / peo_total).toFixed(2);
    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts',
             'echarts/theme/macarons',
             'echarts/chart/pie' // 使用柱状图就加载pie模块，按需加载
    ],
        function (ec) {
            // 基于准备好的dom，初始化echarts图表
            var myChart = ec.init(document.getElementById('echart_yuan_people_province1'));
            var labelTop = {
                normal: {
                    label: {
                        show: true,
                        position: 'center',
                        formatter: '{b}',
                        textStyle: {
                            baseline: 'bottom'
                        }
                    },
                    labelLine: {
                        show: false
                    }
                }
            };
            var labelFromatter = {
                normal: {
                    label: {
                        formatter: function (params) {
                            return (100 - params.value).toFixed(2) + '%'
                        },
                        textStyle: {
                            baseline: 'top'
                        }
                    }
                },
            }
            var labelBottom = {
                normal: {
                    color: '#ccc',
                    label: {
                        show: true,
                        position: 'center'
                    },
                    labelLine: {
                        show: false
                    }
                },
                emphasis: {
                    color: 'rgba(0,0,0,0)'
                }
            };
            var radius = [50, 75];
            option = {
                legend: {
                    x: 'center',
                    y: '240',
                    data: [
                        '移民户数占比', '移民人数占比'
                    ]
                },


                series: [
                    {
                        type: 'pie',
                        center: ['32%', '40%'],
                        radius: radius,
                        x: '0%', // for funnel
                        itemStyle: labelFromatter,
                        data: [
                            { name: 'other', value: 100 - imf_rate, itemStyle: labelBottom },
                            { name: '移民户数占比', value: imf_rate, itemStyle: labelTop }
                        ]
                    },
                    {
                        type: 'pie',
                        center: ['70%', '40%'],
                        radius: radius,
                        x: '20%', // for funnel
                        itemStyle: labelFromatter,
                        data: [
                            { name: 'other', value: 100 - peo_rate, itemStyle: labelBottom },
                            { name: '移民人数占比', value: peo_rate, itemStyle: labelTop }
                        ]
                    },

                ]
            };
            myChart.setOption(option);
        });

}

// show_rb_yuan_provincechart（）显示劳动力就业率和低保人口比例  
function show_rb_yuan_provincechart() {
    //劳动力就业率
    var labor_rate = $getId(Labelprovincelf_having_job_rateID).innerHTML - 0;
    //低保人口比例
    var poor_rate = $getId(Labelprovincepoor_people_rateID).innerHTML - 0;

    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts',
             'echarts/theme/macarons',
             'echarts/chart/pie' // 使用柱状图就加载pie模块，按需加载
    ],
        function (ec) {
            // 基于准备好的dom，初始化echarts图表
            var myChart = ec.init(document.getElementById('echart_yuan_people_province2'));
            var labelTop = {
                normal: {
                    label: {
                        show: true,
                        position: 'center',
                        formatter: '{b}',
                        textStyle: {
                            baseline: 'bottom'
                        }
                    },
                    labelLine: {
                        show: false
                    }
                }
            };
            var labelFromatter = {
                normal: {
                    label: {
                        formatter: function (params) {
                            return (100 - params.value).toFixed(2) + '%'
                        },
                        textStyle: {
                            baseline: 'top'
                        }
                    }
                },
            }
            var labelBottom = {
                normal: {
                    color: '#ccc',
                    label: {
                        show: true,
                        position: 'center'
                    },
                    labelLine: {
                        show: false
                    }
                },
                emphasis: {
                    color: 'rgba(0,0,0,0)'
                }
            };
            var radius = [50, 75];
            option = {
                legend: {
                    x: 'center',
                    y: '240',
                    data: [
                        '劳动力就业率', '低保人口比例'
                    ]
                },


                series: [
                    {
                        type: 'pie',
                        center: ['32%', '40%'],
                        radius: radius,
                        x: '0%', // for funnel
                        itemStyle: labelFromatter,
                        data: [
                            { name: 'other', value: 100 - labor_rate, itemStyle: labelBottom },
                            { name: '劳动力就业率', value: labor_rate, itemStyle: labelTop }
                        ]
                    },
                    {
                        type: 'pie',
                        center: ['70%', '40%'],
                        radius: radius,
                        x: '20%', // for funnel
                        itemStyle: labelFromatter,
                        data: [
                            { name: 'other', value: 100 - poor_rate, itemStyle: labelBottom },
                            { name: '低保人口比例', value: poor_rate, itemStyle: labelTop }
                        ]
                    },

                ]
            };
            myChart.setOption(option);
        });

}

//人均可支配收入变化情况   
function show_income_yuan_provincechart() {
    //人均可支配收入变化情况
    var income_change_rate = $getId(Labelprovinceincome_changeID).innerHTML - 0;

    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts',
             'echarts/theme/macarons',
             'echarts/chart/pie' // 使用柱状图就加载pie模块，按需加载
    ],
        function (ec) {
            // 基于准备好的dom，初始化echarts图表
            var myChart = ec.init(document.getElementById('echart_yuan_income_province'));
            var labelTop = {
                normal: {
                    label: {
                        show: true,
                        position: 'center',
                        formatter: '{b}',
                        textStyle: {
                            baseline: 'bottom'
                        }
                    },
                    labelLine: {
                        show: false
                    }
                }
            };
            var labelFromatter = {
                normal: {
                    label: {
                        formatter: function (params) {
                            return (100 - params.value).toFixed(2) + '%'
                        },
                        textStyle: {
                            baseline: 'top'
                        }
                    }
                },
            }
            var labelBottom = {
                normal: {
                    color: '#ccc',
                    label: {
                        show: true,
                        position: 'center'
                    },
                    labelLine: {
                        show: false
                    }
                },
                emphasis: {
                    color: 'rgba(0,0,0,0)'
                }
            };
            var radius = [55, 85];
            option = {
                legend: {
                    x: 'center',
                    y: '240',
                    data: [
                        '人均可支配收入'
                    ]
                },


                series: [
                    {
                        type: 'pie',
                        center: ['50%', '40%'],
                        radius: radius,
                        x: '0%', // for funnel
                        itemStyle: labelFromatter,
                        data: [
                            { name: 'other', value: 100 - income_change_rate, itemStyle: labelBottom },
                            { name: '人均可支配收入', value: income_change_rate, itemStyle: labelTop }
                        ]
                    }
                ]
            };
            myChart.setOption(option);
        });

}
//按资金来源划分的投资计划及完成情况
function show_prototal_echart() {
    //待建
    var before = $getId(TextBoxProvinceBeforeID).value;
    var beforeArray = before.split('-');
    var newBeforeArray = [];
    var i = 0;
    for (i = 0; i < beforeArray.length - 1; i++) {
        newBeforeArray[i] = beforeArray[i];
    }
    //在建
    var inCons = $getId(TextBoxProvinceInID).value;
    var inArray = inCons.split('-');
    var newInArray = [];
    for (i = 0; i < inArray.length - 1; i++) {
        newInArray[i] = inArray[i];
    }
    //在建
    var com = $getId(TextBoxProvinceComID).value;
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
            var myChart = ec.init(document.getElementById('main_prototal_capital'));
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

//专项资金按类别结构划分的投资计划及完成情况
function show_prototal_typeechart() {
    var strprovince_plan2 = $getId(TextBoxProvincePlan2ID).value;
    var myprovince_plan2 = strprovince_plan2.split('-');
    var province_plan2 = new Array();
    for (var u = 0; u < myprovince_plan2.length - 1; u++) {
        province_plan2[u] = myprovince_plan2[u];
    }

    var strprovince_finished2 = $getId(TextBoxProvinceFinished2ID).value;
    var myprovince_finished2 = strprovince_finished2.split('-');
    var province_finished2 = new Array();
    for (var v = 0; v < myprovince_finished2.length - 1; v++) {
        province_finished2[v] = myprovince_finished2[v];
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
            var myChart = ec.init(document.getElementById('main_prototal_type'));
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
                        //data: ['统建房居住安全', '基础设施', '环保设施', '公共服务设施', '营商环境']
                        data: ['', '', '', '', '']
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
                        data: province_plan2,
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
                        data: province_finished2,
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



//区县
//生成区县所有echarts
function showCommunity() {
    show_lt_yuan_countychart();
    show_rt_yuan_countychart();
    show_lb_yuan_countychart();
    show_rb_yuan_countychart();
    show_income_yuan_countychart();
    show_coutotal_echart();
    show_coutotal_typeechart();
}
//show_lb_yuan_countychart()显示小区数量的图
function show_lt_yuan_countychart() {
    //县城小区
    var xc_com = $getId(Labelcountycounty_community_numID).innerHTML - 0;
    //集镇小区
    var jz_com = $getId(Labelcountytown_community_numID).innerHTML - 0;
    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts',
             'echarts/theme/macarons',
             'echarts/chart/pie' // 使用柱状图就加载pie模块，按需加载
    ],
        function (ec) {
            // 基于准备好的dom，初始化echarts图表
            var myChart = ec.init(document.getElementById('echart_yuan_county1'));
            option = {
                tooltip: {
                    trigger: 'item',
                    formatter: "{a} <br/>{b} : {c} ({d}%)"
                },
                legend: {
                    orient: 'horizontal',
                    x: 'center',
                    y:'250',
                    data: ['县城小区', '集镇小区']
                },
                //color: ['#00DDDD', '#0580b9'],
                calculable: true,
                series: [
                    {
                        name: '访问来源',
                        type: 'pie',
                        radius: ['40%', '57%'],
                        center: ['50%', '43%'],
                        itemStyle: {
                            normal: {
                                label: {
                                    show: false
                                },
                                labelLine: {
                                    show: false
                                }
                            },
                            emphasis: {
                                label: {
                                    show: true,
                                    position: 'center',
                                    textStyle: {
                                        fontSize: '14',
                                        fontWeight: 'bold'
                                    }
                                }
                            }
                        },
                        data: [
                            { value: xc_com, name: '县城小区' },
                            { value: jz_com, name: '集镇小区' }

                        ]
                    }
                ]
            };
            myChart.setOption(option);
        });

}

//show_rt_yuan_countychart()显示项目覆盖小区数量的图
function show_rt_yuan_countychart() {
    //所有小区
    var all_ = $getId(Labelcountycover_community_numID).innerHTML - 0;
    //专项资金项目覆盖小区
    var special_ = $getId(Labelcountyspecial_cover_community_numID).innerHTML - 0;
    //所有项目覆盖小区
    var all_com = $getId(Labelcountycommunity_numID).innerHTML - 0;
    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts',
             'echarts/theme/macarons',
             'echarts/chart/pie' // 使用柱状图就加载pie模块，按需加载
    ],
        function (ec) {
            // 基于准备好的dom，初始化echarts图表
            var myChart = ec.init(document.getElementById('echart_yuan_county2'));
            var dataStyle = {
                normal: {
                    label: { show: false },
                    labelLine: { show: false }
                }
            };
            var placeHolderStyle = {
                normal: {
                    color: 'rgba(0,0,0,0)',
                    label: { show: false },
                    labelLine: { show: false }
                },
                emphasis: {
                    color: 'rgba(0,0,0,0)'
                }
            };
            option = {

                tooltip: {
                    show: true,
                    formatter: "{a} <br/>{b} : {d}%"
                },
                legend: {
                    orient: 'vertical',
                    x: document.getElementById('echart_yuan_county2').offsetWidth / 3+20,
                    y: 165,
                    itemGap: 12,
                    data: ['所有项目覆盖小区', '专项资金项目覆盖小区']
                },

                series: [
                    {
                        name: '1',
                        type: 'pie',
                        clockWise: false,
                        radius: [85, 110],
                        itemStyle: dataStyle,
                        data: [
                            {
                                value: parseInt((all_ / all_com) * 100) - 0,
                                name: '所有项目覆盖小区'
                            },
                            {
                                value: parseInt((1 - all_ / all_com) * 100) - 0,
                                name: 'invisible',
                                itemStyle: placeHolderStyle
                            }
                        ]
                    },
                    {
                        name: '2',
                        type: 'pie',
                        clockWise: false,
                        radius: [60, 85],
                        itemStyle: dataStyle,
                        data: [
                            {
                                value: parseInt((special_ / all_com) * 100) - 0,
                                name: '专项资金项目覆盖小区'
                            },
                            {
                                value: parseInt((1 - special_ / all_com) * 100) - 0,
                                name: 'invisible',
                                itemStyle: placeHolderStyle
                            }
                        ]
                    },

                ]
            };
            myChart.setOption(option);
        });

}

//show_lb_yuan_countychart()显示移民占比的图
function show_lb_yuan_countychart() {
    //居民总户数
    var fam_total = $getId(Labelcountytotal_family_numID).innerHTML - 0;
    //居民总人数
    var peo_total = $getId(Labelcountytotal_people_numID).innerHTML - 0;
    //移民总户数
    var fam_im = $getId(Labelcountyimmigrant_family_numID).innerHTML - 0;
    //移民总人数
    var peo_im = $getId(Labelcountyimmigrant_people_numID).innerHTML - 0;
    //移民户数占比
    var imf_rate = (fam_im * 100 / fam_total).toFixed(2);
    //移民人数占比
    var peo_rate = (peo_im * 100 / peo_total).toFixed(2);
    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts',
             'echarts/theme/macarons',
             'echarts/chart/pie' // 使用柱状图就加载pie模块，按需加载
    ],
        function (ec) {
            // 基于准备好的dom，初始化echarts图表
            var myChart = ec.init(document.getElementById('echart_yuan_people_county1'));
            var labelTop = {
                normal: {
                    label: {
                        show: true,
                        position: 'center',
                        formatter: '{b}',
                        textStyle: {
                            baseline: 'bottom'
                        }
                    },
                    labelLine: {
                        show: false
                    }
                }
            };
            var labelFromatter = {
                normal: {
                    label: {
                        formatter: function (params) {
                            return (100 - params.value).toFixed(2) + '%'
                        },
                        textStyle: {
                            baseline: 'top'
                        }
                    }
                },
            }
            var labelBottom = {
                normal: {
                    color: '#ccc',
                    label: {
                        show: true,
                        position: 'center'
                    },
                    labelLine: {
                        show: false
                    }
                },
                emphasis: {
                    color: 'rgba(0,0,0,0)'
                }
            };
            var radius = [50, 75];
            option = {
                legend: {
                    x: 'center',
                    y: '240',
                    data: [
                        '移民户数占比', '移民人数占比'
                    ]
                },


                series: [
                    {
                        type: 'pie',
                        center: ['32%', '40%'],
                        radius: radius,
                        x: '0%', // for funnel
                        itemStyle: labelFromatter,
                        data: [
                            { name: 'other', value: 100 - imf_rate, itemStyle: labelBottom },
                            { name: '移民户数占比', value: imf_rate, itemStyle: labelTop }
                        ]
                    },
                    {
                        type: 'pie',
                        center: ['70%', '40%'],
                        radius: radius,
                        x: '20%', // for funnel
                        itemStyle: labelFromatter,
                        data: [
                            { name: 'other', value: 100 - peo_rate, itemStyle: labelBottom },
                            { name: '移民人数占比', value: peo_rate, itemStyle: labelTop }
                        ]
                    },

                ]
            };
            myChart.setOption(option);
        });

}

// show_rb_yuan_countychart（）显示劳动力就业率和低保人口比例      
function show_rb_yuan_countychart() {
    //劳动力就业率
    var labor_rate = $getId(Labelcountylf_having_job_rateID).innerHTML - 0;
    //低保人口比例
    var poor_rate = $getId(Labelcountypoor_people_rateID).innerHTML - 0;

    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts',
             'echarts/theme/macarons',
             'echarts/chart/pie' // 使用柱状图就加载pie模块，按需加载
    ],
        function (ec) {
            // 基于准备好的dom，初始化echarts图表
            var myChart = ec.init(document.getElementById('echart_yuan_people_county2'));
            var labelTop = {
                normal: {
                    label: {
                        show: true,
                        position: 'center',
                        formatter: '{b}',
                        textStyle: {
                            baseline: 'bottom'
                        }
                    },
                    labelLine: {
                        show: false
                    }
                }
            };
            var labelFromatter = {
                normal: {
                    label: {
                        formatter: function (params) {
                            return (100 - params.value).toFixed(2) + '%'
                        },
                        textStyle: {
                            baseline: 'top'
                        }
                    }
                },
            }
            var labelBottom = {
                normal: {
                    color: '#ccc',
                    label: {
                        show: true,
                        position: 'center'
                    },
                    labelLine: {
                        show: false
                    }
                },
                emphasis: {
                    color: 'rgba(0,0,0,0)'
                }
            };
            var radius = [50, 75];
            option = {
                legend: {
                    x: 'center',
                    y: '240',
                    data: [
                        '劳动力就业率', '低保人口比例'
                    ]
                },


                series: [
                    {
                        type: 'pie',
                        center: ['32%', '40%'],
                        radius: radius,
                        x: '0%', // for funnel
                        itemStyle: labelFromatter,
                        data: [
                            { name: 'other', value: 100 - labor_rate, itemStyle: labelBottom },
                            { name: '劳动力就业率', value: labor_rate, itemStyle: labelTop }
                        ]
                    },
                    {
                        type: 'pie',
                        center: ['70%', '40%'],
                        radius: radius,
                        x: '20%', // for funnel
                        itemStyle: labelFromatter,
                        data: [
                            { name: 'other', value: 100 - poor_rate, itemStyle: labelBottom },
                            { name: '低保人口比例', value: poor_rate, itemStyle: labelTop }
                        ]
                    },

                ]
            };
            myChart.setOption(option);
        });

}

//人均可支配收入变化情况   
function show_income_yuan_countychart() {
    //人均可支配收入变化情况
    var income_change_rate = $getId(Labelcountyincome_changeID).innerHTML - 0;

    require.config({
        paths: {
            echarts: 'echarts-2.2.7/build/dist'
        }
    });
    // 使用
    require(['echarts',
             'echarts/theme/macarons',
             'echarts/chart/pie' // 使用柱状图就加载pie模块，按需加载
    ],
        function (ec) {
            // 基于准备好的dom，初始化echarts图表
            var myChart = ec.init(document.getElementById('echart_yuan_income_county'));
            var labelTop = {
                normal: {
                    label: {
                        show: true,
                        position: 'center',
                        formatter: '{b}',
                        textStyle: {
                            baseline: 'bottom'
                        }
                    },
                    labelLine: {
                        show: false
                    }
                }
            };
            var labelFromatter = {
                normal: {
                    label: {
                        formatter: function (params) {
                            return (100 - params.value).toFixed(2) + '%'
                        },
                        textStyle: {
                            baseline: 'top'
                        }
                    }
                },
            }
            var labelBottom = {
                normal: {
                    color: '#ccc',
                    label: {
                        show: true,
                        position: 'center'
                    },
                    labelLine: {
                        show: false
                    }
                },
                emphasis: {
                    color: 'rgba(0,0,0,0)'
                }
            };
            var radius = [55, 85];
            option = {
                legend: {
                    x: 'center',
                    y: '240',
                    data: [
                        '人均可支配收入'
                    ]
                },


                series: [
                    {
                        type: 'pie',
                        center: ['50%', '40%'],
                        radius: radius,
                        x: '0%', // for funnel
                        itemStyle: labelFromatter,
                        data: [
                            { name: 'other', value: 100 - income_change_rate, itemStyle: labelBottom },
                            { name: '人均可支配收入', value: income_change_rate, itemStyle: labelTop }
                        ]
                    }
                ]
            };
            myChart.setOption(option);
        });

}
//按资金来源划分的投资计划及完成情况
function show_coutotal_echart() {
     //待建
    var before = $getId(TextBoxCountyBeforeID).value;
    var beforeArray = before.split('-');
    var newBeforeArray = [];
    var i = 0;
    for (i = 0; i < beforeArray.length - 1; i++) {
        newBeforeArray[i] = beforeArray[i];
    }
    //在建
    var inCons = $getId(TextBoxCountyInID).value;
    var inArray = inCons.split('-');
    var newInArray = [];
    for (i = 0; i < inArray.length - 1; i++) {
        newInArray[i] = inArray[i];
    }
    //在建
    var com = $getId(TextBoxCountyComID).value;
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
            var myChart = ec.init(document.getElementById('main_coutotal_capital'));
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
                        show: true,
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
                        name: '待建',
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

//专项资金按类别结构划分的投资计划及完成情况
function show_coutotal_typeechart() {
    var strcou_plan2 = $getId(TextBoxCouPlan2ID).value;
    var mycou_plan2 = strcou_plan2.split('-');
    var cou_plan2 = new Array();
    for (var z = 0; z < mycou_plan2.length - 1; z++) {
        cou_plan2[z] = mycou_plan2[z];
    }

    var strcou_finished2 = $getId(TextBoxCouFinished2ID).value;
    var mycou_finished2 = strcou_finished2.split('-');
    var cou_finished2 = new Array();
    for (var y = 0; y < mycou_finished2.length - 1; y++) {
        cou_finished2[y] = mycou_finished2[y];
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
            var myChart = ec.init(document.getElementById('main_coutotal_type'));
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
                        // data: ['房屋居住安全', '基础设施', '环保设施', '公共服务设施', '就业与创业扶持']
                        data: ['', '', '', '', '']
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
                        data: cou_plan2,
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
                        data: cou_finished2,
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