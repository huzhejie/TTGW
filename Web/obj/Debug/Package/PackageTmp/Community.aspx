
<%@ Page Title="" Language="C#" AutoEventWireup="true"
    CodeBehind="Community.aspx.cs"  Inherits="TTG.Web.Community" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <title></title>
    <script src="Indicator/jquery-1.11.3.js" type="text/javascript"></script>
    <link href="Css/Main.css" rel="stylesheet" type="text/css" />
    <link href="Css/common.css" rel="stylesheet" type="text/css" />
    <script src="JS/laydate.js" type="text/javascript"></script>
    <script src="Indicator/bootstrap.js" type="text/javascript"></script>
    <script src="echarts-2.2.7/build/dist/echarts.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div class="container">
            <div class="comsection">
                <div class="cminfheader">
                    <div class="ciheadtop">
                        <p class="fl">
                            编号：<asp:Label ID="LabelCommunityId" runat="server"></asp:Label>
                        </p>
                        <p class="fr">
                            数据更新日期：<asp:Label ID="LabelLastModify" runat="server"></asp:Label>
                        </p>
                    </div>
                    <div class="ciheadline">
                    </div>
                    <div class="ciheadline">
                    </div>
                    <div class="ciheadmid">
                        <div class="locationforvil fl">
                            <p>
                                <asp:Label ID="LabelProvince" runat="server"></asp:Label>
                                <asp:Label ID="LabelCounty" runat="server"></asp:Label>
                                <asp:Label ID="LabelCommunity" runat="server"></asp:Label>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="cminfnav">
                    <div class="project" style="border-bottom: none;" id="navproj1"
                        onclick="showviltable(1)">
                        <p>
                            首页
                        </p>
                    </div>
                    <div class="project" id="navproj2" onclick="showviltable(2)">
                        <p>
                            房屋居住安全
                        </p>
                    </div>
                    <div class="project" id="navproj3" onclick="showviltable(3)">
                        <p>
                            基础设施
                        </p>
                    </div>
                    <div class="project" id="navproj4" onclick="showviltable(4)">
                        <p>
                            环保设施
                        </p>
                    </div>
                    <div class="project" id="navproj5" onclick="showviltable(5)">
                        <p>
                            公共服务设施
                        </p>
                    </div>
                    <div class="project" id="navproj6" onclick="showviltable(6)">
                        <p>
                            营商环境
                        </p>
                    </div>
                    <div class="project" id="navproj7" onclick="showviltable(7)">
                        <p>
                            帮扶项目清单
                        </p>
                    </div>
                    <div class="project" id="navproj8" onclick="showviltable(8)">
                        <p>
                            <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                            <asp:Button ID="DefaultEchartBtn" runat="server" Text="指标对比" OnClick="s_Click" CssClass="hideBtn"/>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            
                        </p>
                    </div>
                    <div class="arcgis" id="navproj9">
                        <p>
                            <a href="MapPage.aspx" style="text-decoration: none; color: #000;">GIS</a>
                        </p>
                    </div>
                </div>
                <div class="vil_default clearfix">
                    <div class="vil_default_inf" id="vilifn1" style="display: block;">
                        <div class="cminfcontent  clearfix">
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    
                                    <div class="comm_left fl">
                                        <div class="comm_lefttop ">
                                            <asp:Image ID="ImageTitle" runat="server" />

                                        </div>
                                        <div class="comm_leftbot fl">
                                            <p id="echarp">
                                                （点击右表中的有超链接的指标在此处显示年度变化趋势，趋势图中同步反映省市的水平趋势）
                                            </p>
                                            <div style="width: 580px; height: 345px; display: none; margin-left: -40px;" id="main_door_rate">
                                            </div>
                                            <div style="display: none;">
                                                <%--用来存储四个折线图的数据--%>
                                                <asp:TextBox ID="TextBoxVilDoorRate" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxCityDoorRate" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxVilEmploymentRate" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxCityEmploymentRate" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxVilPcdi" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxCityPcdi" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxVilRentLevel" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxCityRentLevel" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxTime" runat="server"></asp:TextBox>
                                                <%--用来存储2个柱状图的数据--%>
                                                <asp:TextBox ID="TextBoxVilPlan1" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxVilFinished1" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxVilPlan2" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxVilFinished2" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <script type="text/javascript">
                                            function getTime() {
                                                var lineTime = document.getElementById("<%=TextBoxTime.ClientID %>").value;
                                                var lineTimeArr = lineTime.split('@');
                                                var newArr = new Array();
                                                for (var i = 0; i < lineTimeArr.length - 1; i++) {
                                                    newArr[i] = lineTimeArr[i];
                                                }
                                                return newArr;
                                            }
                                            //显示门面使用率

                                            function show_linechart_door() {
                                                var lineTimeArr = getTime();
                                                var str_citydoor_rate = document.getElementById("<%=TextBoxCityDoorRate.ClientID %>").value;
                                                var mycitydoor_rate = str_citydoor_rate.split('-');
                                                var citydoor_rate = new Array();
                                                for (var i = 0; i < mycitydoor_rate.length - 1; i++) {
                                                    citydoor_rate[i] = mycitydoor_rate[i] - 0;
                                                }

                                                var str_vildoor_rate = document.getElementById("<%=TextBoxVilDoorRate.ClientID %>").value;
                                            var myvildoor_rate = str_vildoor_rate.split('-');
                                            var vildoor_rate = new Array();
                                            for (var s = 0; s < myvildoor_rate.length - 1; s++) {
                                                vildoor_rate[s] = myvildoor_rate[s] - 0;
                                            }
                                            document.getElementById("echarp").style.display = "none";
                                            document.getElementById("main_door_rate").style.display = "block";
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
                                            var lineTimeArr = getTime();
                                            var str_cityemployment_rate = document.getElementById("<%=TextBoxCityEmploymentRate.ClientID %>").value;
                                            var mycityemployment_rate = str_cityemployment_rate.split('-');
                                            var cityemployment_rate = new Array();
                                            for (var p = 0; p < mycityemployment_rate.length - 1; p++) {
                                                cityemployment_rate[p] = mycityemployment_rate[p] - 0;
                                            }
                                            var str_vilemployment_rate = document.getElementById("<%=TextBoxVilEmploymentRate.ClientID %>").value;
                                            var myvilemployment_rate = str_vilemployment_rate.split('-');
                                            var vilemployment_rate = new Array();
                                            for (var t = 0; t < myvilemployment_rate.length - 1; t++) {
                                                vilemployment_rate[t] = myvilemployment_rate[t] - 0;
                                            }

                                            document.getElementById("echarp").style.display = "none";
                                            document.getElementById("main_door_rate").style.display = "block";
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
                                            var lineTimeArr = getTime();
                                            var str_citypcdi = document.getElementById("<%=TextBoxCityPcdi.ClientID %>").value;
                                            var mycitypcdi = str_citypcdi.split('-');
                                            var citypcdi = new Array();
                                            for (var q = 0; q < mycitypcdi.length - 1; q++) {
                                                citypcdi[q] = mycitypcdi[q] - 0;
                                            }

                                            var str_vilpcdi = document.getElementById("<%=TextBoxVilPcdi.ClientID %>").value;
                                            var myvilpcdi = str_vilpcdi.split('-');
                                            var vilpcdi = new Array();
                                            for (var u = 0; u < myvilpcdi.length - 1; u++) {
                                                vilpcdi[u] = myvilpcdi[u] - 0;
                                            }
                                            document.getElementById("echarp").style.display = "none";
                                            document.getElementById("main_door_rate").style.display = "block";
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
                                            var lineTimeArr = getTime();
                                            var str_cityrent_level = document.getElementById("<%=TextBoxCityRentLevel.ClientID %>").value;
                                            var mycityrent_level = str_cityrent_level.split('-');
                                            var cityrent_level = new Array();
                                            for (var r = 0; r < mycityrent_level.length - 1; r++) {
                                                cityrent_level[r] = mycityrent_level[r] - 0;
                                            }


                                            var str_vilrent_level = document.getElementById("<%=TextBoxVilRentLevel.ClientID %>").value;
                                            var myvilrent_level = str_vilrent_level.split('-');
                                            var vilrent_level = new Array();
                                            for (var v = 0; v < myvilrent_level.length - 1; v++) {
                                                vilrent_level[v] = myvilrent_level[v] - 0;
                                            }

                                            document.getElementById("echarp").style.display = "none";
                                            document.getElementById("main_door_rate").style.display = "block";
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
                                        </script>
                                    </div>
                                    <div class="comm_right fl">
                                        <table class="viltotal1">
                                            <tr style="border-top: 2px solid #008000;">
                                                <td class="viltotd1">小区类型
                                                </td>
                                                <td colspan="2" class="viltotd2" style="border-right: none;">
                                                    <asp:Label ID="LabelCommunityType" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="viltotd1">建设年份
                                                </td>
                                                <td colspan="2" class="viltotd2" style="border-right: none;">
                                                    <asp:Label ID="LabelConstructYear" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="viltotd1">居民户籍人口
                                                </td>
                                                <td class="viltotd2">总户数<asp:Label ID="LabelRegFamilyNum" runat="server"></asp:Label>户
                                                </td>
                                                <td class="viltotd3">总人数<asp:Label ID="LabelRegPeopleNum" runat="server"></asp:Label>人
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="viltotd1">其中移民
                                                </td>
                                                <td class="viltotd2">户数<asp:Label ID="LabelImmigrantFamilyNum" runat="server"></asp:Label>户
                                                </td>
                                                <td class="viltotd3">人数<asp:Label ID="LabelImmigrantPeopleNum" runat="server"></asp:Label>人
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="viltotd1">建筑面积
                                                </td>
                                                <td class="viltotd2">
                                                    <asp:Label ID="LabelConstructionArea" runat="server"></asp:Label>
                                                </td>
                                                <td class="viltotd3">万㎡
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="viltotd1">占地面积
                                                </td>
                                                <td class="viltotd2">
                                                    <asp:Label ID="LabelFloorArea" runat="server"></asp:Label>
                                                </td>
                                                <td class="viltotd3">万㎡
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="viltotd1">人均住房面积
                                                </td>
                                                <td class="viltotd2">
                                                    <asp:Label ID="LabelAverageHouseArea" runat="server"></asp:Label>
                                                </td>
                                                <td class="viltotd3">㎡
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="viltotd1">容积率
                                                </td>
                                                <td class="viltotd2">
                                                    <asp:Label ID="LabelPlotRatio" runat="server"></asp:Label>
                                                </td>
                                                <td class="viltotd3">%
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="viltotd1">绿地率
                                                </td>
                                                <td class="viltotd2">
                                                    <asp:Label ID="LabelGreenRate" runat="server"></asp:Label>
                                                </td>
                                                <td class="viltotd3">%
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="viltotd1">停车位
                                                </td>
                                                <td class="viltotd2">
                                                    <asp:Label ID="LabelParkingLot" runat="server"></asp:Label>
                                                </td>
                                                <td class="viltotd3">个
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="viltotd1">门面数
                                                </td>
                                                <td class="viltotd2">
                                                    <asp:Label ID="LabelFacade" runat="server"></asp:Label>
                                                </td>
                                                <td class="viltotd3">个
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="viltotd1">

                                                    <asp:Image ID="Image1" runat="server" ImageUrl="Images/diagram_1.png" CssClass="tableimg" />
                                                    <asp:Button ID="door_rateBtn" runat="server" Text="门面使用率" CssClass="tableBtn" OnClick="door_rateBtn_Click" />
                                                </td>
                                                <td class="viltotd2">
                                                    <asp:Label ID="LabelFacadeUseRate" runat="server"></asp:Label>
                                                </td>
                                                <td class="viltotd3">%
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="viltotd1">
                                                    <asp:Image ID="Image2" runat="server" ImageUrl="Images/diagram_1.png" CssClass="tableimg" />
                                                    <asp:Button ID="laborBtn" runat="server" Text="劳动力就业率" CssClass="tableBtn" OnClick="laborBtn_Click" />
                                                </td>
                                                <td class="viltotd2">
                                                    <asp:Label ID="LabelEmploymentRate" runat="server"></asp:Label>
                                                </td>
                                                <td class="viltotd3">%
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="viltotd1">
                                                    <asp:Image ID="Image3" runat="server" ImageUrl="Images/diagram_1.png" CssClass="tableimg" />
                                                    <asp:Button ID="incomeBtn" runat="server" Text="人均可支配收入" CssClass="tableBtn" OnClick="incomeBtn_Click" />
                                                </td>
                                                <td class="viltotd2">
                                                    <asp:Label ID="LabelDisposableIncome" runat="server"></asp:Label>
                                                </td>
                                                <td class="viltotd3">元
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="viltotd1">
                                                    <asp:Image ID="Image4" runat="server" ImageUrl="Images/diagram_1.png" CssClass="tableimg" /><asp:Button ID="rentBtn" runat="server" Text="房屋租金平均水平" CssClass="tableBtn" OnClick="rentBtn_Click" />
                                                </td>
                                                <td class="viltotd2">
                                                    <asp:Label ID="LabelAverageRent" runat="server"></asp:Label>
                                                </td>
                                                <td class="viltotd3">元/㎡
                                                </td>
                                            </tr>
                                            <tr style="border-bottom: 2px solid #008000;">
                                                <td class="viltotd1">低保人口比例
                                                </td>
                                                <td class="viltotd2">
                                                    <asp:Label ID="LabelPoorRate" runat="server"></asp:Label>
                                                </td>
                                                <td class="viltotd3">%
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <div class="comm_bottom fl">
                                <div class="datacount fl">
                                    <table class="count">
                                        <tr style="border-bottom: 2px solid #008000; border-top: 2px solid #008000;">
                                            <td style="border-left: none;">累计计划投资
                                            </td>
                                            <td>
                                                <asp:Label ID="LabelPlanTotalInves" runat="server"></asp:Label>
                                            </td>
                                            <td style="width: 112px;">万元
                                            </td>
                                            <td>累计完成投资
                                            </td>
                                            <td>
                                                <asp:Label ID="LabelCompleteTotalInves" runat="server"></asp:Label>
                                            </td>
                                            <td>万元
                                            </td>
                                            <td>投资完成比率
                                            </td>
                                            <td style="width: 135px; border-right: none;">
                                                <asp:Label ID="LabelCompleteRate" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr style="border-bottom: 2px solid #008000; border-top: 2px solid #008000;">
                                            <td style="border-left: none;">累计专项资金计划
                                            </td>
                                            <td>
                                                <asp:Label ID="LabelPlanTotalSpecialInves" runat="server"></asp:Label>
                                            </td>
                                            <td style="width: 112px;">万元
                                            </td>
                                            <td>累计专项资金完成
                                            </td>
                                            <td>
                                                <asp:Label ID="LabelCompleteTotalSpecialInves" runat="server"></asp:Label>
                                            </td>
                                            <td>万元
                                            </td>
                                            <td>专项资金完成比例
                                            </td>
                                            <td style="width: 135px; border-right: none;">
                                                <asp:Label ID="LabelSpecialCompleteRete" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <div class="bom1botleft fl">
                                    <div style="width: 580px; height: 400px;" id="main_viltotal_capital">
                                        <%--<img src="img/echart.png" alt="" width="100%" height="100%" />--%>
                                    </div>
                                    <div style="width: 518px; height: 40px; margin-top: -30px; margin-left: 20px;">
                                        <table class="forechart">
                                            <tr>
                                                <td style="width: 58px;">计划投资
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelPlanSpecialInves" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelPlanCounterInves" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelPlanOtherInves" runat="server" Text="Label"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width: 58px;">完成
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelComSpecialInves" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelComCounterInves" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelComOtherInves" runat="server" Text="Label"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                    <!-- ECharts单文件引入 -->
                                    
                                    <script type="text/javascript">
                                        var str_cityplan1 = document.getElementById("<%=TextBoxVilPlan1.ClientID %>").value;
                                        var mycityplan1 = str_cityplan1.split('-');
                                        var cityplan1 = new Array();
                                        for (var x = 0; x < mycityplan1.length - 1; x++) {
                                            cityplan1[x] = mycityplan1[x];
                                        }
                                        var str_cityfinished1 = document.getElementById("<%=TextBoxVilFinished1.ClientID %>").value;
                                        var mycityfinished1 = str_cityfinished1.split('-');
                                        var cityfinished1 = new Array();
                                        for (var y = 0; y < mycityfinished1.length - 1; y++) {
                                            cityfinished1[y] = mycityfinished1[y];
                                        }
                                        function show_viltotal_echart() {

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
                                                data: ['计划投资', '完成投资']
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
                                                    data: cityplan1,
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
                                                    data: cityfinished1,
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

                                    </script>
                                    <!--ECharts文件引入完毕-->
                                    <p>
                                        按资金来源划分的投资计划及完成情况
                                    </p>
                                </div>
                                <div class="bom1botmid fl">
                                </div>
                                <div class="bom1botright fl ">
                                    <div style="width: 580px; height: 400px;" id="main_viltotal_type">
                                    </div>
                                    <div style="width: 518px; height: 40px; margin-top: -30px; margin-left: 20px;">
                                        <table class="forecharttype">
                                            <tr>
                                                <td style="width: 58px;">计划投资
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelPlanHouseSafe" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelPlanBaseFac" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelPlanEnvirPro" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelPlanPublicFac" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelPlanBusin" runat="server" Text="Label"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width: 58px;">完成
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelComHouseSafe" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelComBaseFac" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelComEnvirPro" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelComPublicFac" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="LabelComBusin" runat="server" Text="Label"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                    <!-- ECharts单文件引入 -->
                                  
                                    <script type="text/javascript">
                                        var str_cityplan2 = document.getElementById("<%=TextBoxVilPlan2.ClientID %>").value;
                                        var mycityplan2 = str_cityplan2.split('-');
                                        var cityplan2 = new Array();
                                        for (var n = 0; n < mycityplan2.length - 1; n++) {
                                            cityplan2[n] = mycityplan2[n];
                                        }
                                        var str_cityfinished2 = document.getElementById("<%=TextBoxVilFinished2.ClientID %>").value;
                                        var mycityfinished2 = str_cityfinished2.split('-');
                                        var cityfinished2 = new Array();
                                        for (var m = 0; m < mycityfinished2.length - 1; m++) {
                                            cityfinished2[m] = mycityfinished2[m];
                                        }
                                        function show_viltotal_typeechart() {

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
                                                    data: ['统建房居住安全', '基础设施', '环保设施', '公共服务设施', '营商环境']
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

                                    </script>
                                    <!--ECharts文件引入完毕-->
                                    <p>
                                        按类别结构划分的投资计划及完成情况
                                    </p>
                                </div>
                                <%--<div class="bom1botbot fl">
                            </div>--%>
                            </div>
                        </div>
                        <div class="cminffooter fl">
                            <div class="responserinf">
                                <table class="rspinftable">
                                    <tr  style="border-top: 2px solid #008000;">
                                        <td class="rsptbtd1">
                                            小区帮扶指数
                                        </td>
                                        <td class="rsptbtd2" colspan="2">
                                            <asp:Label ID="LabelHelpFigure" runat="server"></asp:Label>
                                        </td>
                                        <td class="rsptbtd3">
                                            小区发展指数
                                        </td>
                                        <td class="rsptbtd4" style="border-right: none;">
                                            <asp:Label ID="LabelDevelopFigure" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="rsptbtd1">小区地址
                                        </td>
                                        <td class="rsptbtd2" colspan="4" style="border-right: none;">

                                            <asp:Label ID="LabelAddress" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="rsptbtd1">小区管理
                                        </td>
                                        <td class="rsptbtd2">负责人:<asp:Label ID="LabelManaChargeName" runat="server"></asp:Label>

                                        </td>
                                        <td class="rsptbtd3">电话:<asp:Label ID="LabelManaChargePhone" runat="server"></asp:Label>

                                        </td>
                                        <td class="rsptbtd4">联系人:
                                        </td>
                                        <td class="rsptbtd5">电话:<asp:Label ID="LabelManaContactPhone" runat="server"></asp:Label>

                                        </td>
                                    </tr>
                                    <tr style="border-bottom: 2px solid #008000;">
                                        <td class="rsptbtd1">综合监测
                                        </td>
                                        <td class="rsptbtd2">负责人:<asp:Label ID="LabelMoniChargeName" runat="server"></asp:Label>

                                        </td>
                                        <td class="rsptbtd3">电话:
                                            <asp:Label ID="LabelMoniChargePhone" runat="server"></asp:Label>

                                        </td>
                                        <td class="rsptbtd4">工作人员
                                        </td>
                                        <td class="rsptbtd5">电话:<asp:Label ID="LabelMoniContactPhone" runat="server"></asp:Label>

                                        </td>
                                    </tr>
                                </table>
                              
                            </div>
                        </div>
                    </div>
                    <div class="vil_default_inf" id="vilifn2">
                        <div class="Residential_security">
                            <table class="TResidential_security">
                                <tr>
                                    <td rowspan="3" class="tabletitle" style="border-left: none;">基本情况
                                    </td>
                                    <td rowspan="2">小区统建房栋数
                                    </td>
                                    <td colspan="3">结构安全
                                    </td>
                                    <td colspan="2">屋顶防渗
                                    </td>
                                    <td colspan="2">外墙损坏
                                    </td>
                                    <td colspan="2" style="border-right: none;">边坡治理
                                    </td>
                                </tr>
                                <tr>
                                    <td>轻微变形开裂
                                    </td>
                                    <td>房屋地基沉降
                                    </td>
                                    <td>鉴定为危房
                                    </td>
                                    <td colspan="2">屋顶渗水房屋
                                    </td>
                                    <td colspan="2">外墙瓷砖脱落房屋
                                    </td>
                                    <td colspan="2" style="border-right: none;">边坡未治理
                                    </td>
                                </tr>
                                <tr>
                                    <td>幢
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td colspan="2">㎡
                                    </td>
                                    <td colspan="2">㎡
                                    </td>
                                    <td colspan="2" style="border-right: none;">幢
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">2013年情况
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelSystemBuilding2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelCrackArea2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelFoundationDown2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelDangerous2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelLeakage2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelTileFall2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2" style="border-right: none;">
                                        <asp:Label ID="LabelSlopeNdeal2013" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="border-bottom: 2px  solid #008000;">
                                    <td style="border-left: none;">当前情况
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelSystemBuildingNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelCrackAreaNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelFoundationDownNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelDangerousNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelLeakageNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelTileFallNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2" style="border-right: none;">
                                        <asp:Label ID="LabelSlopeNdealNow" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" rowspan="3" class="tabletitle" style="border-left: none;">实施情况
                                    </td>
                                    <td colspan="3">结构安全
                                    </td>
                                    <td colspan="2">屋顶渗漏
                                    </td>
                                    <td colspan="2">外墙损坏
                                    </td>
                                    <td colspan="2" style="border-right: none;">边坡治理
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">结构安全栋数
                                    </td>
                                    <td>结构安全面积
                                    </td>
                                    <td>屋顶防漏栋数
                                    </td>
                                    <td>屋顶防漏面积
                                    </td>
                                    <td>外墙修复栋数
                                    </td>
                                    <td>外墙修复面积
                                    </td>
                                    <td>边坡治理面积
                                    </td>
                                    <td style="border-right: none;">边坡治理涉及房屋居民人数
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">幢
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>幢
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>幢
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td style="border-right: none;">人
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" style="border-left: none;">计划
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelStructSafeNumPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLeakProofNumPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairWallNumPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelSlopePeopleNumPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelStructSafeAreaPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLeakProofAreaPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairWallAreaPlan" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelSlopeDealPlan" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="border-bottom: 2px solid #008000;">
                                    <td colspan="2" style="border-left: none;">完成
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelStructSafeNumCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLeakProofNumCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairWallNumCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelSlopePeopleNumCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelStructSafeAreaCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLeakProofAreaCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairWallAreaCom" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelSlopeDealCom" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" class="tabletitle" style="border-left: none;">目标实现情况
                                    </td>
                                    <td colspan="3">结构安全完好率
                                    </td>
                                    <td colspan="2">屋顶完好率
                                    </td>
                                    <td colspan="2">房屋外墙完好率
                                    </td>
                                    <td colspan="2" style="border-right: none;">边坡安全稳定程度
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" style="border-left: none">2013年情况
                                    </td>
                                    <td colspan="3">
                                        <asp:Label ID="LabelStructSafeRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelRoofComRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelWallComRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2" style="border-right: none;">
                                        <asp:Label ID="LabelSlopeStableRate2013" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" style="border-left: none">当前情况
                                    </td>
                                    <td colspan="3">
                                        <asp:Label ID="LabelStructSafeRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelRoofComRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelWallComRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2" style="border-right: none;">
                                        <asp:Label ID="LabelSlopeStableRateNow" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <div class="vil_default_inf" id="vilifn3">
                        <div class="basic_facility">
                            <table class="Tbasic_facility">
                                <caption class="tablecaption">
                                    交通条件、供电条件</caption>
                                <tr>
                                    <td rowspan="4" style="border-left: none;" class="tabletitle">基本情况
                                    </td>
                                    <td colspan="6">交通条件
                                    </td>
                                    <td colspan="6" style="border-right: none;">供电条件
                                    </td>
                                </tr>
                                <!--基本情况 交通条件 供电条件-->
                                <tr>
                                    <td rowspan="2">断头路（尽端式道路）
                                    </td>
                                    <td rowspan="2">小区内部分区域链接道路缺乏
                                    </td>
                                    <td rowspan="2">未硬化
                                    </td>
                                    <td colspan="2">路面损坏面积
                                    </td>
                                    <td rowspan="2">缺乏人行道
                                    </td>
                                    <td colspan="2" rowspan="2">供电量不足涉及住宅户数
                                    </td>
                                    <td colspan="2" rowspan="2">小区老化和损坏供电线路长度
                                    </td>
                                    <td colspan="2" rowspan="2" style="border-right: none;">未落实“一户一表”涉及住宅户数
                                    </td>
                                </tr>
                                <tr>
                                    <td>机动车道
                                    </td>
                                    <td>人行道
                                    </td>
                                </tr>
                                <tr>
                                    <td>条
                                    </td>
                                    <td>条
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>条
                                    </td>
                                    <td colspan="2">户
                                    </td>
                                    <td colspan="2">km
                                    </td>
                                    <td colspan="2" style="border-right: none;">户
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">2013年情况
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelBrokenRoadNum2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLackLinkNum2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelNotHardArea2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRoadBroken2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelSidewalkBroken2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLackSidewalk2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelElecInade2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelLinkDamage2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2" style="border-right: none;">
                                        <asp:Label ID="LabelNotEOneOne2013" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="border-bottom: 2px solid #008000;">
                                    <td style="border-left: none;">当前情况
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelBrokenRoadNumNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLackLinkNumNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelNotHardAreaNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRoadBrokenNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelSidewalkBrokenNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLackSidewalkNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelElecInadeNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelLinkDamageNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2" style="border-right: none;">
                                        <asp:Label ID="LabelNotEOneOneNow" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;" rowspan="3" class="tabletitle">实施情况
                                    </td>
                                    <td colspan="6">交通条件
                                    </td>
                                    <td colspan="6" style="border-right: none;">供电条件
                                    </td>
                                </tr>
                                <!--实施情况 交通条件 供电条件-->
                                <tr>
                                    <td>新增连接路数量
                                    </td>
                                    <td>新建机动车道面积
                                    </td>
                                    <td>硬化机动车道面积
                                    </td>
                                    <td>维修改造机动车道面积
                                    </td>
                                    <td>人行道地砖改造面积
                                    </td>
                                    <td>新增人行道
                                    </td>
                                    <td>新增变压器后增容
                                    </td>
                                    <td>更换变压器后增容
                                    </td>
                                    <td>变压器安装改造
                                    </td>
                                    <td>新建配电线路
                                    </td>
                                    <td>维修改造配电线路
                                    </td>
                                    <td style="border-right: none;">电表安装
                                    </td>
                                </tr>
                                <tr>
                                    <td>条
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>KVA
                                    </td>
                                    <td>KVA
                                    </td>
                                    <td>台
                                    </td>
                                    <td>km
                                    </td>
                                    <td>km
                                    </td>
                                    <td style="border-right: none;">户
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">计划
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddLinkNumPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddRoadAreaPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelHardenRoadAreaPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairRoadAreaPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelChangeSidewalkPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddSidewalkPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddTransPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelChangeTransPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairTransPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddLinePlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairLinePlan" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelInstallTransPlan" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="border-bottom: 2px solid #008000;">
                                    <td style="border-left: none;">完成
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddLinkNumCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddRoadAreaCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelHardenRoadAreaCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairRoadAreaCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelChangeSidewalkCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddSidewalkCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddTransCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelChangeTransCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairTransCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddLineCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairLineCom" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelInstallTransCom" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;" class="tabletitle">目标实现情况
                                    </td>
                                    <td colspan="3">道路通达程度
                                    </td>
                                    <td colspan="3">道路通畅程度
                                    </td>
                                    <td colspan="2">供电容量保障率
                                    </td>
                                    <td colspan="2">供电线路安全程度
                                    </td>
                                    <td colspan="2" style="border-right: none;">供电一户一表实现率
                                    </td>
                                </tr>
                                <!--目标实现情况 交通条件 供电条件-->
                                <tr>
                                    <td style="border-left: none;">2013年情况
                                    </td>
                                    <td colspan="3">
                                        <asp:Label ID="LabelRoadAccessRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="3">
                                        <asp:Label ID="LabelRoadClearRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelElecCapaGuarRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelElecLineSafeRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2" style="border-right: none;">
                                        <asp:Label ID="LabelElecDoubleOneRate2013" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="border-bottom: 2px solid #008000;">
                                    <td style="border-left: none;">当前情况
                                    </td>
                                    <td colspan="3">
                                        <asp:Label ID="LabelRoadAccessRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="3">
                                        <asp:Label ID="LabelRoadClearRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelElecCapaGuarRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelElecLineSafeRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2" style="border-right: none;">
                                        <asp:Label ID="LabelElecDoubleOneRateNow" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div class="basic_facility">
                            <table class="Tbasic_facility">
                                <caption class="tablecaption">
                                    供水条件、公共照明、消防</caption>
                                <tr>
                                    <td rowspan="3" style="border-left: none;" class="tabletitle">基本情况
                                    </td>
                                    <td colspan="5">供水条件
                                    </td>
                                    <td colspan="4">公共照明
                                    </td>
                                    <td colspan="3" style="border-right: none;">消防
                                    </td>
                                </tr>
                                <!--基本情况 供水条件 公共照明 消防-->
                                <tr>
                                    <td>供水量不足涉及住宅户数
                                    </td>
                                    <td>供水压力不足涉及住宅户数
                                    </td>
                                    <td colspan="2">小区供水管道损坏长度
                                    </td>
                                    <td>未落实"一户一表"涉及住宅
                                    </td>
                                    <td>无路灯的路段数量
                                    </td>
                                    <td>路灯数量少、照明不足的路段数量
                                    </td>
                                    <td colspan="2">小区楼道照明损坏涉及户数
                                    </td>
                                    <td>室外消火栓数量不足涉及路段
                                    </td>
                                    <td>室内消火栓不足涉及建筑数量
                                    </td>
                                    <td style="border-right: none;">消防通道不达标长度
                                    </td>
                                </tr>
                                <tr>
                                    <td>户
                                    </td>
                                    <td>户
                                    </td>
                                    <td colspan="2">km
                                    </td>
                                    <td>户
                                    </td>
                                    <td>km
                                    </td>
                                    <td>km
                                    </td>
                                    <td colspan="2">户
                                    </td>
                                    <td>km
                                    </td>
                                    <td>幢
                                    </td>
                                    <td style="border-right: none;">km
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">2013年情况
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelInadequateWater2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelWaterPressure2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelPipeDamage2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelNotOneOne2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelNoLight2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLessLight2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelLightDamage2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelOutFfLess2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelinFfLess2013" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelExitsNotCom2013" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="border-bottom: 2px solid #008000;">
                                    <td style="border-left: none;">当前情况
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelInadequateWaterNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelWaterPressureNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelPipeDamageNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelNotOneOneNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelNoLightNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLessLightNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelLightDamageNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelinFfLessNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabeloutFfLessNow" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelExitsNotComNow" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;" rowspan="3" class="tabletitle">实施情况
                                    </td>
                                    <td colspan="5">供水条件
                                    </td>
                                    <td colspan="4">公共照明
                                    </td>
                                    <td colspan="3" style="border-right: none;">消防
                                    </td>
                                </tr>
                                <!--实施情况 供水条件 公共照明 消防-->
                                <tr>
                                    <td>新增供水容量
                                    </td>
                                    <td>新增供水增压设施
                                    </td>
                                    <td>新建供水管长度
                                    </td>
                                    <td>维修改造供水管长度
                                    </td>
                                    <td>水表安装
                                    </td>
                                    <td>新增室外照明覆盖路段
                                    </td>
                                    <td>修复室外照明覆盖路段
                                    </td>
                                    <td>新增楼栋照明设施数量
                                    </td>
                                    <td>修复楼栋照明设施数量
                                    </td>
                                    <td>新增室外消防设施数量
                                    </td>
                                    <td>新增室内消防设施数量
                                    </td>
                                    <td style="border-right: none;">消防通道改造
                                    </td>
                                </tr>
                                <tr>
                                    <td>t/d
                                    </td>
                                    <td>处
                                    </td>
                                    <td>km
                                    </td>
                                    <td>km
                                    </td>
                                    <td>户
                                    </td>
                                    <td>km
                                    </td>
                                    <td>km
                                    </td>
                                    <td>盏
                                    </td>
                                    <td>盏
                                    </td>
                                    <td>套
                                    </td>
                                    <td>套
                                    </td>
                                    <td style="border-right: none;">m
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">计划
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddWaterCapPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddWaterPressPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddPipeLengthPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelrepairPipeLengthPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddMeterPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddOutLightPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairOutLightPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddInLightPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairInLightPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddOutFfPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddInFfPlan" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelRepairExitsPlan" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="border-bottom: 2px solid #008000;">
                                    <td style="border-left: none;">完成
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddWaterCapCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddWaterPressCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddPipeLengthCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairPipeLengthCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddMeterCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddOutLightCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairOutLightCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddInLightCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairInLightCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddOutFfCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddInFfCom" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelRepairExitsCom" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;" class="tabletitle">目标实现情况
                                    </td>
                                    <td colspan="2">供水能力保障程度
                                    </td>
                                    <td colspan="2">供水管网完善程度
                                    </td>
                                    <td>供水一户一表实现率
                                    </td>
                                    <td colspan="2">室外公共照明达标率
                                    </td>
                                    <td colspan="2">室内公共照明达标率
                                    </td>
                                    <td>室外消防设施达标率
                                    </td>
                                    <td>室内消防设施达标率
                                    </td>
                                    <td style="border-right: none;">消防通道达标率
                                    </td>
                                </tr>
                                <!--目标实现情况 供水条件 公共照明 消防-->
                                <tr>
                                    <td style="border-left: none;">2013年情况
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelWaterSupplyGuarRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelWaterPipeLineComRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelWaterDoubleOneRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelOutLightComRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelInLightComRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelOutFfComRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelInFfComRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelFfExitsComRate2013" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="border-bottom: 2px solid #008000;">
                                    <td style="border-left: none;">当前情况
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelWaterSupplyGuarRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelWaterPipeLineComRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelWaterDoubleOneRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelOutLightComRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelinLightComRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelOutFfComRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelInFfComRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelFfExitsComRateNow" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <div class="vil_default_inf" id="vilifn4">
                        <div class="environmentally_protective_facility">
                            <table class="Tenvironmentally_protective_facility">
                                <tr>
                                    <td rowspan="3" style="border-left: none;" class="tabletitle">基本情况
                                    </td>
                                    <td colspan="5">环卫设施
                                    </td>
                                    <td colspan="7">排污和排水
                                    </td>
                                    <td colspan="2" style="border-right: none;">绿化
                                    </td>
                                </tr>
                                <tr>
                                    <td>路边垃圾箱不足涉及路段
                                    </td>
                                    <td>住宅区垃圾箱不足涉及区域
                                    </td>
                                    <td>区域环卫设施不足
                                    </td>
                                    <td colspan="2">公厕数量不足涉及区域
                                    </td>
                                    <td>未接入城市污水管网的住宅
                                    </td>
                                    <td>生活污水直排溪沟、长江处数
                                    </td>
                                    <td colspan="2">小区排水管损坏长度
                                    </td>
                                    <td>排（洪）水沟损坏
                                    </td>
                                    <td colspan="2">排（洪）水沟不足
                                    </td>
                                    <td colspan="2" style="border-right: none;">小区绿地面积
                                    </td>
                                </tr>

                                <tr>
                                    <td>条
                                    </td>
                                    <td>处
                                    </td>
                                    <td>处
                                    </td>
                                    <td colspan="2">处
                                    </td>
                                    <td>户
                                    </td>
                                    <td>处
                                    </td>

                                    <td colspan="2">km
                                    </td>
                                    <td>km
                                    </td>
                                    <td colspan="2">V
                                    </td>
                                    <td colspan="2" style="border-right: none;">㎡
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">2013年情况
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLessRoadsideDustbin2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLessHouseDustbin2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLessSanitation2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelLessToilet2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelnotInSewageHouse2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelsewageDitch2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabeldrainPipeDamage2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabeldrainDitchDamage2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelLessDrainDitch2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2" style="border-right: none;">
                                        <asp:Label ID="LabelGreenArea2013" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="border-bottom: 2px solid #008000;">
                                    <td style="border-left: none;">当前情况
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLessRoadsideDustbinNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLessHouseDustbinNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelLessSanitationNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelLessToiletNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelnotInSewageHouseNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelSewageDitchNow" runat="server"></asp:Label>
                                    </td>

                                    <td colspan="2">
                                        <asp:Label ID="LabelDrainPipeDamageNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelDrainDitchDamageNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelLessDrainDitchNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2" style="border-right: none;">
                                        <asp:Label ID="LabelGreenAreaNow" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td rowspan="3" style="border-left: none;" class="tabletitle">实施情况
                                    </td>
                                    <td colspan="5">环卫设施
                                    </td>
                                    <td colspan="7">排污和排水
                                    </td>
                                    <td colspan="2" style="border-right: none;">绿化
                                    </td>
                                </tr>
                                <tr>
                                    <td>新增垃圾桶数量
                                    </td>
                                    <td>新增垃圾中转站数量
                                    </td>
                                    <td>维修改造垃圾中转站数量
                                    </td>
                                    <td>新增公厕
                                    </td>
                                    <td>维修改造公厕
                                    </td>
                                    <td>维修改造污水管网长度
                                    </td>
                                    <td>新建污水管网长度
                                    </td>
                                    <td>新建排水管长度
                                    </td>
                                    <td>维修改造排水管长度
                                    </td>
                                    <td>新建排（洪）水沟长度
                                    </td>
                                    <td>维修改造拍（洪）水沟长度
                                    </td>
                                    <td>新建化粪池数量
                                    </td>
                                    <td>新增绿化面积
                                    </td>
                                    <td style="border-right: none;">植树
                                    </td>
                                </tr>
                                <tr>
                                    <td>个
                                    </td>
                                    <td>个
                                    </td>
                                    <td>个
                                    </td>
                                    <td>个
                                    </td>
                                    <td>个
                                    </td>
                                    <td>km
                                    </td>
                                    <td>km
                                    </td>
                                    <td>km
                                    </td>
                                    <td>km
                                    </td>
                                    <td>km
                                    </td>
                                    <td>km
                                    </td>
                                    <td>个
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td style="border-right: none;">株
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">计划
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddDustbinPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddGarbageTransferPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairGarbageTransferPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddToiletPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairToiletPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairSewagePlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddSewagePlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddDrainPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairDrainPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddDitchPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairDitchPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddSepticTankPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddGreenPlan" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelPlantTreesPlan" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="border-bottom: 2px solid #008000;">
                                    <td style="border-left: none;">完成
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddDustbinCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddGarbageTransferCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelrepairGarbageTransferCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddToiletCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairToiletCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairSewageCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddSewageCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddDrainCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairDrainCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddDitchCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairDitchCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddSepticTankCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddGreenCom" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelPlantTreesCom" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;" class="tabletitle">目标实现情况
                                    </td>
                                    <td colspan="3">垃圾收集能力达标率
                                    </td>
                                    <td colspan="2">公共厕所覆盖程度
                                    </td>
                                    <td colspan="2">生活污水收集能力达标率
                                    </td>
                                    <td colspan="5">排水安全保障程度
                                    </td>
                                    <td colspan="2" style="border-right: none;">小区绿化率
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">2013年情况
                                    </td>
                                    <td colspan="3">
                                        <asp:Label ID="LabelGarbageCollectRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelToiletCoverageRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelSewageCollectRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="5">
                                        <asp:Label ID="LabelDrainSafeRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2" style="border-right: none;">
                                        <asp:Label ID="LabelGreenRate2013" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">当前情况
                                    </td>
                                    <td colspan="3">
                                        <asp:Label ID="LabelGarbageCollectRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelToiletCoverageRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelSewageCollectRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="5">
                                        <asp:Label ID="LabelDrainSafeRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2" style="border-right: none;">
                                        <asp:Label ID="LabelGreenRateNow" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <div class="vil_default_inf" id="vilifn5">
                        <div class="public_service_facility">
                            <table class="Tpublic_service_facility">
                                <tr>
                                    <td rowspan="3" style="border-left: none;" class="tabletitle">基本情况
                                    </td>
                                    <td colspan="4">教育
                                    </td>
                                    <td colspan="3">医疗
                                    </td>
                                    <td colspan="4">文体设施
                                    </td>
                                    <td colspan="2">社区服务
                                    </td>
                                    <td>停车
                                    </td>
                                    <td colspan="2" style="border-right: none;">商业服务
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">幼儿园容量
                                    </td>
                                    <td>教学面积
                                    </td>
                                    <td>室外活动面积
                                    </td>
                                    <td colspan="2">小区卫生室面积
                                    </td>
                                    <td>小区卫生室床位数
                                    </td>
                                    <td colspan="2">室外活动场地面积
                                    </td>
                                    <td>室内活动场地面积
                                    </td>
                                    <td>健身器材
                                    </td>
                                    <td>养老院面积
                                    </td>
                                    <td>社区综合管理用房面积
                                    </td>
                                    <td>停车场面积
                                    </td>
                                    <td>农贸市场面积
                                    </td>
                                    <td style="border-right: none;">便民超市面积
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">人
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td colspan="2">㎡
                                    </td>
                                    <td>张
                                    </td>
                                    <td colspan="2">㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>套
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td style="border-right: none;">㎡
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">2013年情况
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelKindergartenCap2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelTeachingArea2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabeloutPlayArea2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelClinicArea2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelClinicBed2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabeloutGroundArea2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelinGroundArea2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelFitnessEquipment2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelOldArea2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelManagementArea2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelParkingArea2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelFarmArea2013" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelMarketArea2013" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="border-bottom: 2px solid #008000;">
                                    <td style="border-left: none;">当前情况
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelKindergartenCapNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelTeachingAreaNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelOutPlayAreaNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelClinicAreaNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelClinicBedNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabeloutGroundAreaNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelinGroundAreaNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelFitnessEquipmentNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelOldAreaNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelManagementAreaNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelParkingAreaNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelFarmAreaNow" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelMarketAreaNow" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td rowspan="3" style="border-left: none;" class="tabletitle">实施情况
                                    </td>
                                    <td colspan="4">教育
                                    </td>
                                    <td colspan="3">医疗
                                    </td>
                                    <td colspan="4">文体设施
                                    </td>
                                    <td colspan="2">社区服务
                                    </td>
                                    <td>停车
                                    </td>
                                    <td colspan="2" style="border-right: none;">商业服务
                                    </td>
                                </tr>
                                <tr>
                                    <td>新增幼儿园容量
                                    </td>
                                    <td>改扩建幼儿园容量
                                    </td>
                                    <td>新增教学面积
                                    </td>
                                    <td>新增幼儿园活动场地
                                    </td>
                                    <td>新增卫生室面积
                                    </td>
                                    <td>维修改造卫生室面积
                                    </td>
                                    <td>新增卫生室床位数
                                    </td>
                                    <td>新增室外活动场地面积
                                    </td>
                                    <td>改造室外活动场地面积
                                    </td>
                                    <td>新增建设室内活动场所面积
                                    </td>
                                    <td>新增健身器材
                                    </td>
                                    <td>新增养老设施面积
                                    </td>
                                    <%--  <td>
                                    维修改造养老设施面积
                                </td>--%>
                                    <td>新增社区综合管理用房
                                    </td>
                                    <td>新增停车场面积
                                    </td>
                                    <td>新增农贸市场面积
                                    </td>
                                    <td style="border-right: none;">新增便民超市面积
                                    </td>
                                </tr>
                                <tr>
                                    <td>人
                                    </td>
                                    <td>人
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>个
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>套
                                    </td>
                                    <td>㎡
                                    </td>

                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td style="border-right: none;">㎡
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">计划
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddKindergartenCapPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelChangeKinderCapPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddTeachingAreaPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddKinderGroundPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddClinicPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairClinicPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddBedPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddOutGroundPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairOutGroundPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddInGroundPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddFitnessPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddOldPlan" runat="server"></asp:Label>
                                    </td>
                                   
                                    <td>
                                        <asp:Label ID="LabelAddManageHousePlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddParkingPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddFarmAreaPlan" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelAddMarketPlan" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="border-bottom: 2px solid #008000;">
                                    <td style="border-left: none;">完成
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddKindergartenCapCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelChangeKinderCapCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddTeachingAreaCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddKinderGroundCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddClinicCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairClinicCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddBedCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddOutGroundCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRepairOutGroundCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddInGroundCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddFitnessCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddOldCom" runat="server"></asp:Label>
                                    </td>
                                   
                                    <td>
                                        <asp:Label ID="LabelAddManageHouseCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddParkingCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAddFarmAreaCom" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelAddMarketCom" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;" class="tabletitle">目标实现情况
                                    </td>
                                    <td colspan="4">幼儿园配置达标率
                                    </td>
                                    <td colspan="3">社区医疗配置达标率
                                    </td>
                                    <td colspan="4">文化健身设施配置达标率
                                    </td>
                                    <td>养老设施配置达标率
                                    </td>
                                    <td>综合管理用房配置达标率
                                    </td>
                                    <td>停车设施配置达标率
                                    </td>
                                    <td>菜市场配置达标率
                                    </td>
                                    <td style="border-right: none;">便民店配置达标率
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">2013年情况
                                    </td>
                                    <td colspan="4">
                                        <asp:Label ID="LabelKinderRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="3">
                                        <asp:Label ID="LabelMedicalRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="4">
                                        <asp:Label ID="LabelCultureSportsRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelOldFacilitiesRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelManageRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelParkingRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelFarmRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelMarketRate2013" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">当前情况
                                    </td>
                                    <td colspan="4">
                                        <asp:Label ID="LabelKinderRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="3">
                                        <asp:Label ID="LabelMedicalRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="4">
                                        <asp:Label ID="LabelCultureSportsRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelOldFacilitiesRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelManageRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelParkingRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelFarmRateNow" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelMarketRateNow" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <div class="vil_default_inf" id="vilifn6">
                        
                        <div class="envionmrnt_business">
                            <table class="Tenvionmrnt_business">
                                <tr>
                                    <td rowspan="3" style="border-left: none;" class="tabletitle">基本情况
                                    </td>
                                    <td colspan="3">门面改造
                                    </td>
                                    <td colspan="2">街区改造
                                    </td>
                                    <td colspan="2" style="border-right: none;">专业市场
                                    </td>
                                </tr>
                                <tr>
                                    <td>小区门面数
                                    </td>
                                    <td>出租经营门面数
                                    </td>
                                    <td>门面平均出租租金
                                    </td>
                                    <td colspan="2">街区风貌较差
                                    </td>
                                    <td colspan="2" style="border-right: none;">缺乏专业市场
                                    </td>
                                </tr>
                                <tr>
                                    <td>个
                                    </td>
                                    <td>个
                                    </td>
                                    <td>元/㎡/月
                                    </td>
                                    <td colspan="2">v
                                    </td>
                                    <td colspan="2" style="border-right: none;">v
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">本底
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelFacadeNum2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRentFacade2013" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAverageRent2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelBlock2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2" style="border-right: none;">
                                        <asp:Label ID="LabelProfessional2013" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="border-bottom: 2px solid #008000;">
                                    <td style="border-left: none;">现状
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelFacadeNumNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelRentFacadeNow" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelAverageRentNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelBlockNow" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="2" style="border-right: none;">
                                        <asp:Label ID="LabelProfessionalNow" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td rowspan="3" style="border-left: none;" class="tabletitle">实施情况
                                    </td>
                                    <td colspan="3">门面改造
                                    </td>
                                    <td colspan="2">街区改造
                                    </td>
                                    <td colspan="2" style="border-right: none;">专业市场建设
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">改造门面数量
                                    </td>
                                    <td>改造门面面积
                                    </td>
                                    <td>改造街区长度
                                    </td>
                                    <td>改造外立面
                                    </td>
                                    <td>建设市场面积
                                    </td>
                                    <td style="border-right: none;">涉及商户数量
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">个
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>km
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td>㎡
                                    </td>
                                    <td style="border-right: none;">个
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">计划
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelChangeFacadePlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelChangeFacadeAreaPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelChangeBlockPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelChangeOutPlan" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelChangeMarketPlan" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelBusinessNumPlan" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="border-bottom: 2px solid #008000;">
                                    <td style="border-left: none;">完成
                                    </td>
                                    <td colspan="2">
                                        <asp:Label ID="LabelChangeFacadeCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelChangeFacadeAreaCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelChangeBlockCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelChangeOutCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelChangeMarketCom" runat="server"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelBusinessNumCom" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;" class="tabletitle">目标实现情况
                                    </td>
                                    <td colspan="3">门面利用率
                                    </td>
                                    <td colspan="4" style="border-right: none;">门面租金水平
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">本底
                                    </td>
                                    <td colspan="3">
                                        <asp:Label ID="LabelFacadeUseRate2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="4" style="border-right: none;">
                                        <asp:Label ID="LabelFacadeUseRateNow" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">现状
                                    </td>
                                    <td colspan="3">
                                        <asp:Label ID="LabelRentLevel2013" runat="server"></asp:Label>
                                    </td>
                                    <td colspan="4" style="border-right: none;">
                                        <asp:Label ID="LabelRentLevelNow" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <div class="vil_default_inf" id="vilifn7">
                       
                         <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>

                        <div class="project_list_index">
                              <asp:Repeater ID="Repeater1" runat="server">
                            <HeaderTemplate>
                            <table class="Tproject_list_index">
                                <tr>
                                    <td class="title" style="border-left: none;">序号</td>
                                    <td class="title">批复项目名称</td>
                                    <td class="title">单项工程</td>
                                    <td class="title">工程项目</td>
                                    <td class="title">建设状态</td>
                                    <td class="title">主要建设内容</td>
                                    <td class="title">开工日期</td>
                                    <td class="title">竣工日期</td>
                                    <td class="title">项目投资（万元）</td>
                                    <td class="title" style="border-right: none;">功能辐射型项目</td>
                                </tr>
                                 </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td class="title" style="border-left: none;"><%# Eval("project_id")%></td>
                                    <td class="title"><%# Eval("project_name")%></td>
                                    <td class="title"><%# Eval("child_name")%></td>
                                    <td class="title"><%# Eval("grand_name")%></td>
                                    <td class="title"><%# Eval("construct_state")%></td>
                                    <td class="title"><%# Eval("construct_content")%></td>
                                    <td class="title"><%# fdate(Eval("start_date").ToString())%></td>
                                    <td class="title"><%# fdate(Eval("end_date").ToString())%></td>
                                    <td class="title"><%# Eval("investment")%></td>
                                    <td class="title" style="border-right: none;"><%# Eval("is_indirect")%></td>
                                </tr>


                                 </ItemTemplate>
                            <FooterTemplate>
                            </table>
                             </FooterTemplate>
                        </asp:Repeater>
                            <!--一共12条记录-->
                            <!--这里加分页，居中-->
                            <webdiyer:AspNetPager ID="AspNetPager1" CssClass="pages fl" CurrentPageButtonClass="cpb"
                                PagingButtonSpacing="0" runat="server" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                                PrevPageText="上一页" SubmitButtonText="前往" TextAfterPageIndexBox="页" TextBeforePageIndexBox="到"
                                SubmitButtonStyle="pAdding: 0 5px; vertical-align:bottom;border:1px solid  #ddd; ;font-size:14px;color:#000;margin-left:10px;"
                                Width="100%" HorizontalAlign="Center">
                            </webdiyer:AspNetPager>
                        </div>
                           </ContentTemplate>
                    </asp:UpdatePanel>
                    </div>
                    <div class="vil_default_inf" id="vilifn8">
                      
                        <div class="indicator">
                            <div class="selecttime">
                                <span>请选择一段时间查看指标变化：</span> <span style="margin-left: 10px;">从</span>
                                <div class="laydate-icon fl" id="start" style="width: 170px;">
                                </div>
                                <span style="margin-left: 10px;">到</span>
                                <div class="laydate-icon fl" id="end" style="width: 170px; margin-left: 10px;">
                                </div>
                                <br />
                                <br />
                                <span>请选择某个时间查看相关指标：  </span>
                                <input class="laydate-icon" id="demo" style="width: 170px; margin-left: 26px;" />
                            </div>
                            <div class="selectindicator">
                                <div class="ctnerTab cominfo_tab">
                                    <a class="on">统建房居住安全</a> <a>基础设施</a> <a>环保设施</a> <a>公共服务设施</a> <a>营商环境</a>
                                </div>
                                <div class="indicatorNav rtNavs " id="choice1">
                                    <div class="navArea" style="width: 640px;">
                                        <ul>
                                            <li><a title="" class="secondTree" id="Structure_safe_good_rate"><span>结构安全完好率</span> <i></i></a></li>
                                            <li><a title="" class="secondTree" id="Roof_good_rate"><span>屋顶完好率</span>
                                                <i></i></a></li>
                                            <li><a title="" class="secondTree" id="Wall_good_rate"><span>房屋外墙完好率</span>
                                                <i></i></a></li>
                                            <li><a title="" class="secondTree" id="Slope_safe_rate"><span>边坡安全稳定程度</span>
                                                <i></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="indicatorNav rtNavs dn" id="choice2">
                                    <div class="navArea" style="width: 800px;">
                                        <div class="fl choiceSize">
                                            <ul>
                                                <li><a class="secondTree" title="" id="Water_supply_validate"><span>供水条件</span> <i></i></a></li>
                                                <li><a title="" class="thirdTree" style="font-size: 11px;" id="Water_capcity_degree">
                                                    <span>供水能力保障程度</span> <i></i></a></li>
                                                <li><a title="" class="thirdTree" id="One_hou_one_water_meter_rate">
                                                    <span>供水一户一表实现率</span> <i></i></a></li>
                                                <li><a title="" class="thirdTree" id="Water_pipe_net_good_degree"><span>供水管网完善</span> <i></i></a></li>
                                            </ul>
                                        </div>
                                        <div class="fl choiceSize">
                                            <ul>
                                                <li><a title="" class="secondTree" id="Ff_validate"><span>消防条件</span>
                                                    <i></i></a></li>
                                                <li><a title="" class="thirdTree" id="Outdoors_ff_good_rate"><span>室外消防设施达标率</span>
                                                    <i></i></a></li>
                                                <li><a title="" class="thirdTree" id="Indoors_ff_good_rate"><span>室内消防设施达标率</span>
                                                    <i></i></a></li>
                                                <li><a title="" class="thirdTree" id="Ff_way_good_rate"><span>消防通道达标率
                                                </span><i></i></a></li>
                                            </ul>
                                        </div>
                                        <div class="fl choiceSize">
                                            <ul>
                                                <li><a title="" class="secondTree" id="Elec_supply_validate"><span>供电条件</span>
                                                    <i></i></a></li>
                                                <li><a title="" class="thirdTree" id="Elec_capcity_degree"><span>供电一户一表实现率</span>
                                                    <i></i></a></li>
                                                <li><a title="" class="thirdTree" id="Elec_wire_safe_degree"><span>供电线路安全程度</span>
                                                    <i></i></a></li>
                                            </ul>
                                        </div>
                                        <div class="fl choiceSize">
                                            <ul>
                                                <li><a title="" class="secondTree" id="Traffic_validate"><span>交通条件</span>
                                                    <i></i></a></li>
                                                <li><a title="" class="thirdTree" id="RoadLink_degree"><span>道路通达程度</span>
                                                    <i></i></a></li>
                                                <li><a title="" class="thirdTree" id="Road_good_degree"><span>道路通畅程度</span>
                                                    <i></i></a></li>
                                            </ul>
                                        </div>
                                        <div class="fl choiceSize">
                                            <ul>
                                                <li><a title="" class="secondTree" id="Light_validate"><span>公共照明条件</span>
                                                    <i></i></a></li>
                                                <li><a title="" class="thirdTree" id="Road_light_suff_degree"><span>室外公共照明达标率</span> <i></i></a></li>
                                                <li><a title="" class="thirdTree" id="Passway_light_suff_degree"><span>室外公共照明达标率 </span><i></i></a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                                <div class="indicatorNav rtNavs dn" id="choice3">
                                    <div class="navArea" style="width: 480px;">
                                        <div class="fl choiceSize">
                                            <ul>
                                                <li><a title="" class="secondTree" id="Sanitation_validate"><span>环卫条件</span>
                                                    <i></i></a></li>
                                                <li><a title="" class="thirdTree" id="Refuse_collect_rate"><span>垃圾收集能力达标率
                                                </span><i></i></a></li>
                                                <li><a title="" class="thirdTree" id="Toilet_cover_degree"><span>公共厕所覆盖程度</span>
                                                    <i></i></a></li>
                                            </ul>
                                        </div>
                                        <div class="fl choiceSize">
                                            <ul>
                                                <li><a title="" class="secondTree" id="Drain_validate"><span>排（污）水</span>
                                                    <i></i></a></li>
                                                <li><a title="" class="thirdTree" id="Sewage_collect_rate"><span>污水收集能力达标率</span>
                                                    <i></i></a></li>
                                                <li><a title="" class="thirdTree" id="Drain_safe_degree"><span>排水安全保障程度</span>
                                                    <i></i></a></li>
                                            </ul>
                                        </div>
                                        <div class="fl choiceSize">
                                            <ul>
                                                <li><a title="" class="secondTree" id="Green_validate"><span>绿化目标实现评价</span>
                                                    <i></i></a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                                <div class="indicatorNav rtNavs dn" id="choice4">
                                    <div class="navArea">
                                        <ul>
                                            <li><a title="" class="secondTree specialTree" id="Service_gfs_good_rate">
                                                <span>综合管理用房配置达标率</span> <i></i></a></li>
                                            <li><a title="" class="secondTree specialTree" id="Cul_fitness_facility_good_rate">
                                                <span>文化健身设施配置达标率</span> <i></i></a></li>
                                            <li><a title="" class="secondTree specialTree" id="Kindergarten_good_rate">
                                                <span>幼儿园配置达标率</span> <i></i></a></li>
                                            <li><a title="" class="secondTree specialTree" id="Medical_good_rate">
                                                <span>社区医疗配置达标率</span> <i></i></a></li>
                                            <li>
                                                <div class="" style="height: 120px; width: 145px; float: right;">
                                                    <ul>
                                                        <li><a title="" class="secondTree specialTree" id="Commerce_validate">
                                                            <span>商务服务设施 </span><i></i></a></li>
                                                        <li><a title="" class="thirdTree" id="CVS_good_rate1" style="width: 125px; margin-left: 6px;"><span>便民店配置达标率 </span><i></i></a></li>
                                                        <li><a title="" class="thirdTree" id="Vegetable_market_good_rate"
                                                            style="width: 125px; margin-left: 6px;"><span>菜市场配置达标率 </span><i></i></a></li>
                                                    </ul>
                                                </div>
                                            </li>

                                            <li><a title="" class="secondTree specialTree" id="Parking_good_rate">
                                                <span>停车设施配置达标率</span> <i></i></a></li>
                                            <li><a title="" class="secondTree specialTree" id="Older_facility_good_rate"><span>养老设施配置达标率</span>
                                                <i></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="indicatorNav rtNavs dn" id="choice5">
                                    <div class="navArea" style="width: 320px;">
                                        <ul>
                                            <li><a title="" class="secondTree" id="Shop_front_use_rate"><span>门面利用率</span>
                                                <i></i></a></li>
                                            <li><a title="" class="secondTree" id="Shop_front_rent_level"><span>门面租金水平</span> <i></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                             
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                     
                                    <div>
                                        <asp:Button ID="Button1" runat="server" CssClass="mybtn echartBtn" Text="显示图表" OnClientClick="return btnClick()"
                                            OnClick="submit_Click"></asp:Button>
                                    </div>
                                   
                                    <div class="" style="display: none">
                                        <input id="ids" runat="server" type="text" />
                                        <input id="startDate" runat="server" type="text" />
                                        <input id="endDate" runat="server" type="text" />
                                        <input id="onlyDate" runat="server" type="text" />
                                        <input id="selectedCommunity" runat="server" type="text" />
                                        <input id="hideindicator" runat="server" type="text" />
                                        <input id="hidecom_id" runat="server" type="text" />
                                        <input id="hidecom_ectype" runat="server" type="text" />
                                        <input id="hidecom_time" runat="server" type="text" />
                                        <input id="hideonlytime" runat="server" type="text" />
                                        <input id="hidedata1" runat="server" type="text" />
                                        <input id="hidedata2" runat="server" type="text" />
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                             <div id="main" style="height: 500px; padding: 20px 10px;">
                             </div>
                            <!-- ECharts单文件引入 -->
                            
                            <script type="text/javascript">
                                function showechart() {
                                    var com_indicator = document.getElementById("hideindicator").value;
                                    com_indicator = com_indicator.trim();
                                    var com_indicator_array = com_indicator.split('-');
                                    var ci_array = new Array();
                                    for (var p = 0; p < com_indicator_array.length - 1; p++) {
                                        ci_array[p] = com_indicator_array[p];
                                    }


                                    var com_id = document.getElementById("hidecom_id").value;
                                    com_id = com_id.trim();


                                    var com_ectype = document.getElementById("hidecom_ectype").value;
                                    if (com_ectype == 1) {
                                        //取出的不同时间不同指标数据                                  
                                        var com_time = document.getElementById("hidecom_time").value;
                                        com_time = com_time.trim();
                                        var com_time_array = com_time.split('@')
                                        var ct_array = new Array();
                                        for (var x = 0; x < com_time_array.length - 1; x++) {
                                            ct_array[x] = com_time_array[x];
                                        }
                                        //取出的不同时间不同指标数据

                                        var diftime_difindicator = document.getElementById("hidedata1").value;
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

                                        var onlytime = document.getElementById("hideonlytime").value;
                                        onlytime = onlytime.trim();
                                        var timeArry = new Array();
                                        timeArry[0] = onlytime;
                                        //同一时间不同指标的值

                                        var sametime_difid = document.getElementById("hidedata2").value;
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
                                        var myChart = ec.init(document.getElementById('main'));
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


                            </script>
                            <!--ECharts文件引入完毕-->
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
<script src="Indicator/disChange.js" type="text/javascript" charset="gbk"></script>
<script type="text/javascript">

    function showviltable(a) {
        for (i = 1; i <= 8; i++) {
            var vilnumber = "vilifn" + i;
            var navnumber = "navproj" + i;
            var vildiv = document.getElementById(vilnumber);
            var navdiv = document.getElementById(navnumber);
            if (i == a) {
                vildiv.style.display = "block";
                navdiv.style.backgroundColor = "#fff";
               
            } else {
                vildiv.style.display = "none";
                navdiv.style.backgroundColor = "#63CB30";
            }
        }
       
    }

    $('.ctnerTab a').click(function () {
        if (!$(this).hasClass('on')) {
            $('.ctnerTab a').removeClass('on').eq($(this).index()).addClass('on');
            $('.rtNavs').stop(true, true).hide().eq($(this).index()).show();
        }
    });

    !function () {
        laydate.skin('molv'); //切换皮肤，请查看skins下面皮肤库
        laydate({ elem: '#demo' }); //绑定元素
    }();

    //日期范围限制
    (function () {
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


    })()



</script>
</html>
