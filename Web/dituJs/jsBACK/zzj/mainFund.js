require.config({
    paths: {
        echarts: 'echarts-2.2.1/build/dist'
    }
});
// 使用
require(['echarts', 'echarts/chart/bar' // 使用柱状图就加载bar模块，按需加载
                                ],
                                function (ec) {
                                    // 基于准备好的dom，初始化echarts图表
                                    var myChart = ec.init(document.getElementById('mainFund')),
                                        option = {
                                            title: {
                                                text: '按资金来源划分的投资计划及完成情况',
                                                x: 80
                                                // subtext: '纯属虚构'
                                            },
                                            tooltip: {
                                                trigger: 'axis'
                                            },
                                            legend: {
                                                data: ['计划投资', '完成投资'],
                                                x: 160,
                                                y: 30
                                            },
                                            toolbox: {
                                                show: false,
                                                feature: {
                                                    mark: { show: true },
                                                    dataView: { show: true, readOnly: false },
                                                    magicType: { show: true, type: ['line', 'bar'] },
                                                    restore: { show: true },
                                                    saveAsImage: { show: true }
                                                }
                                            },
                                            calculable: true,
                                            xAxis: [
                                            {
                                                type: 'category',
                                                data: ['专项投资', '对口支援投资', '其他投资']
                                            }
                                        ],
                                            yAxis: [
                                            {
                                                type: 'value'
                                            }
                                        ],
                                            series: [
                                            {
                                                name: '计划投资',
                                                type: 'bar',
                                                data: [100, 36, 88]
                                            },
                                            {
                                                name: '完成投资',
                                                type: 'bar',
                                                data: [77, 66, 88]
                                            }
                                        ]
                                        };
                                    myChart.setOption(option);
                                });
     