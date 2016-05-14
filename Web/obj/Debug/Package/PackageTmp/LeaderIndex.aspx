<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true"
    CodeBehind="LeaderIndex.aspx.cs" Inherits="TTG.Web.LeaderIndex" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/common.css" rel="stylesheet" type="text/css" />
    <script src="echarts-2.2.7/build/dist/echarts.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="triangle" style="margin-left: 164px;" id="tri1">
        </div>
        <div class="triangle" style="margin-left: 348px;" id="tri2">
        </div>
        <div class="triangle" style="margin-left: 531px;" id="tri3">
        </div>
        <div class="infor" id="infor">
            <div id="drop1" class="clearfix drop">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="buxuan">
                            <a onclick="getValuePro('不选')" style="margin-left: 35px">不选<a>
                        </div>
                        <br />
                        <asp:Repeater ID="RepeaterForPro" runat="server">
                            <ItemTemplate>
                                <div class="location">
                                    <a id="<%#GetDataItem().ToString()%>" onclick="getValuePro('<%#GetDataItem().ToString()%>')">
                                        <%#GetDataItem().ToString()%>
                                    </a>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                        <asp:Button ID="hideBtn1" runat="server" Text="Button" OnClick="hideBtn1_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div id="drop2" class="clearfix drop">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <div class="buxuan">
                            <a onclick="getValueCou('不选')" style="margin-left: 35px">不选<a>
                        </div>
                        <br />
                        <asp:Repeater ID="RepeaterForCou" runat="server">
                            <ItemTemplate>
                                <div class="location">
                                    <a id="<%#Eval("community_county").ToString()%>" onclick="getValueCou('<%#Eval("community_county").ToString()%>')">
                                        <%#Eval("community_county").ToString()%>
                                    </a>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                        <asp:Button ID="hideBtn2" runat="server" Text="Button" OnClick="hideBtn2_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div id="drop3" class="clearfix drop">
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <div class="buxuan">
                            <a id="A1" onclick="getValueVil('不选')" style="margin-left: 35px">不选<a>
                        </div>
                        <br />
                        <asp:Repeater ID="RepeaterForVil" runat="server">
                            <ItemTemplate>
                                <div class="location">
                                    <a id="<%#Eval("community_name").ToString()%>" onclick="getValueVil('<%#Eval("community_name").ToString()%>')">
                                        <%#Eval("community_name").ToString()%>
                                    </a>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
        <div style="width: 100%" class="fl">
            <div class="bodytop fl">
                <div class="searchsection fl">
                    <div class="searchsectioncon" id="nim">
                        <input id="prov" type="text" class="fl svalue" runat="server" placeholder="选择省(市)"
                            readonly="readonly" /><input id="provBtn" type="button" value="" onclick="show(1)"
                                class="selectBtn" />
                    </div>
                    <div class="searchsectioncon">
                        <input id="county" type="text" class="fl svalue" runat="server" placeholder="选择区县"
                            readonly="readonly" /><input id="countyBtn" type="button" value="" class="selectBtn"
                                onclick="show(2)" />
                    </div>
                    <div class="searchsectioncon">
                        <input id="village" type="text" class="fl svalue" runat="server" placeholder="选择小区(可以直接搜索)"
                            readonly="readonly" /><input id="villageBtn" type="button" value="" class="selectBtn"
                                onclick="show(3)" />
                    </div>
                </div>
                <asp:Button ID="retirevalBtn" runat="server" Text="搜索" OnClick="retirevalBtn_Click"
                    CssClass="mybtn ls_btn" />
            </div>
            <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div style="width: 390px;" class="fl">
                        <input id="vagueinput" type="text" class="vagueinput" placeholder="直接输入小区名进行搜索" runat="server" />
                        <asp:Button ID="vaguebutton" runat="server" Text="搜索" OnClick="vaguebutton_Click"
                            CssClass="mybtn ls_btn" />
                    </div>
                    <div class="searchresult" id="searchresult" runat="server">
                        <ul>
                            <asp:Repeater ID="RepeaterCom" runat="server">
                                <ItemTemplate>

                            <li><a href="community.aspx?pro=" + <%#Eval("community_province").ToString()%> + "&cou=" + <%#Eval("community_county").ToString()%> + "&vil=" + <%#Eval("community_name").ToString()%>" onclick="hidesr()" target="_blank"><%#Eval("community_province").ToString()+Eval("community_county").ToString()+Eval("community_name").ToString()%></a> </li>          
                                    
                                </ItemTemplate>
                            </asp:Repeater>                
                        </ul>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div class="bodymiddle fl">
            <div class="bom" id="bom1" runat="server">
                <div class="bomtitle fl">
                    <p style="font-size: 29px; text-align: center; color: #63CB30; line-height: 140px;">
                        三峡库区城镇移民小区综合监测综合汇总指标</p>
                    <p style="font-size: 17px; text-align: right; color: #000; line-height: 17px;">
                        数据更新日期：2015-8-1
                        <%--<asp:Label ID="Label1" runat="server" ></asp:Label>--%>
                    </p>
                </div>
                <div class="datasection fl">
                    <!--小区部分开始-->
                    <div class="subdatasection">
                        <div class="sdsr1">
                            <div class="subdatasectionimgtop">
                                <div class="data_right">
                                    <p>
                                        所有项目覆盖小区<span>&nbsp<asp:Label ID="Labeltotalcover_community_num" runat="server"></asp:Label>&nbsp</span>个</p>
                                </div>
                            </div>
                            <div class="subdatasectionimgleft">
                                <div class="echart_yuan" id="echart_yuan1">
                                </div>
                                <div class="data_right">
                                    <p>
                                        小区数量<span>&nbsp<asp:Label ID="Labeltotalcommunity_num" runat="server"></asp:Label>&nbsp</span>个</p>
                                </div>
                            </div>
                            <div class="subdatasectionimg">
                            </div>
                            <div class="subdatasectionimgright">
                                <div class="data_right">
                                    <p>
                                        专项资金项目覆盖小区<span>&nbsp<asp:Label ID="Labeltotalspecial_cover_community_num" runat="server"></asp:Label>&nbsp</span>个</p>
                                </div>
                                <div class="echart_yuan2" id="echart_yuan2">
                                </div>
                            </div>
                            <div class="subdatasectionimgtop">
                                <div class="data_right" style="float: left; width: 100%;">
                                    <p style="float: left; width: 390px;">
                                        县城（城市）小区<span>&nbsp<asp:Label ID="Labeltotalcounty_community_num" runat="server"></asp:Label>&nbsp</span>个,
                                        集镇小区<span>&nbsp<asp:Label ID="Labeltotaltown_community_num" runat="server"></asp:Label>&nbsp</span>个</p>
                                    <p style="float: left; width: 100px; margin-left: 90px;">
                                        <span>小区</span></p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- ECharts单文件引入 -->
                    <script type="text/javascript">
                        //左上图
                        function show_lt_yuan_chart() {
                            var xc_com = document.getElementById("<%=Labeltotalcounty_community_num.ClientID %>").innerHTML - 0;
                            var jz_com = document.getElementById("<%=Labeltotaltown_community_num.ClientID %>").innerHTML - 0;
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
                                            orient: 'vertical',
                                            x: 'right',
                                            data: ['县城（城市）小区', '集镇小区']
                                        },
                                        //color: ['#00DDDD', '#0580b9'],
                                        calculable: true,
                                        series: [
                                            {
                                                name: '访问来源',
                                                type: 'pie',
                                                radius: ['50%', '70%'],
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
                                                                fontSize: '20',
                                                                fontWeight: 'bold'
                                                            }
                                                        }
                                                    }
                                                },
                                                data: [
                                                    { value: xc_com, name: '县城（城市）小区' },
                                                    { value: jz_com, name: '集镇小区' }

                                                ]
                                            }
                                        ]
                                    };
                                    myChart.setOption(option);
                                });

                        }

                        // 右上图    
                        function show_rt_yuan_chart() {
                            var all_ = document.getElementById("<%=Labeltotalcover_community_num.ClientID %>").innerHTML - 0;
                            var special_ = document.getElementById("<%=Labeltotalspecial_cover_community_num.ClientID %>").innerHTML - 0;
                            var all_com = document.getElementById("<%=Labeltotalcommunity_num.ClientID %>").innerHTML - 0;
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
                                            formatter: "{a} <br/>{b} : {c} ({d}%)"
                                        },
                                        legend: {
                                            orient: 'vertical',
                                            x: document.getElementById('echart_yuan2').offsetWidth / 3,
                                            y: 85,
                                            itemGap: 12,
                                            data: ['所有项目覆盖小区', '专项资金项目覆盖小区']
                                        },

                                        series: [
                                            {
                                                name: '1',
                                                type: 'pie',
                                                clockWise: false,
                                                radius: [90, 115],
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
                                                radius: [65, 90],
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
                                       
                    </script>
                    <!--ECharts单文件引入完毕-->
                    <!--小区部分结束-->
                    <!--人口部分开始-->
                    <div class="subdatasection">
                        <div class="sdsr2">
                            <div class="subdatasectionimgleft">
                                <div class="echart_yuan" id="echart_yuan_people1" style="width: 380px; float: none;">
                                </div>
                                <div class="data_right">
                                    <p style="line-height: 30px;">
                                        小区居民户籍人口： 总户数<span>&nbsp<asp:Label ID="Labeltotaltotal_family_num" runat="server">&nbsp</asp:Label>&nbsp</span>户<br />
                                        总人数<span>&nbsp<asp:Label ID="Labeltotaltotal_people_num" runat="server"></asp:Label>&nbsp</span>人</p>
                                </div>
                            </div>
                            <div class="subdatasectionimg" style="background-image: url(../Images/LeaderIndexImg/kuai2_lined.png)">
                            </div>
                            <div class="subdatasectionimgright" style="border-bottom: 2px solid #C0C0C0; border-top: none;">
                                <div class="echart_yuan2" id="echart_yuan_people2" style="margin-top: 40px; width: 360px;">
                                </div>
                                <div class="data_right">
                                    <p style="line-height: 30px;">
                                        劳动力就业率<span>&nbsp
                                            <asp:Label ID="Labeltotallf_having_job_rate" runat="server"></asp:Label>&nbsp</span>%<br />
                                        低保人口比例<span>&nbsp
                                            <asp:Label ID="Labeltotalpoor_people_rate" runat="server"></asp:Label>&nbsp</span>%</p>
                                </div>
                            </div>
                            <div class="subdatasectionimgtop">
                                <div class="data_right" style="width: 100%; float: left;">
                                    <p style="float: left; margin-left: 50px; line-height: 30px;">
                                        其中移民： 总户数<span>&nbsp<asp:Label ID="Labeltotalimmigrant_family_num" runat="server"></asp:Label>&nbsp</span>户<br />
                                        总人数<span>&nbsp<asp:Label ID="Labeltotalimmigrant_people_num" runat="server"></asp:Label>&nbsp</span>人</p>
                                    <p style="float: left; width: 100px; margin-left: 180px;">
                                        <span>居民</span></p>
                                    <p style="float: left; margin-left: 190px;">
                                        人均住房面积<span>&nbsp<asp:Label ID="Labeltotalaverage_house_area" runat="server"></asp:Label>&nbsp</span>㎡</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- ECharts单文件引入 -->
                    <script type="text/javascript">
                        //左下图
                        function show_lb_yuan_chart() {
                            var fam_total = document.getElementById("<%=Labeltotaltotal_family_num.ClientID %>").innerHTML - 0;
                            var peo_total = document.getElementById("<%=Labeltotaltotal_people_num.ClientID %>").innerHTML - 0;
                            var fam_im = document.getElementById("<%=Labeltotalimmigrant_family_num.ClientID %>").innerHTML - 0;
                            var peo_im = document.getElementById("<%=Labeltotalimmigrant_people_num.ClientID %>").innerHTML - 0;
                           
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
                                    option = {
                                        tooltip: {
                                            trigger: 'item',
                                            formatter: "{a} <br/>{b} : {c} ({d}%)"
                                        },
//                                        legend: {
//                                            orient: 'vertical',
//                                            x: 'left',
//                                            data: ['非移民总户数', '非移民总人数', '移民总户数', '移民总人数']
//                                        },
                                        
                                        calculable: false,
                                        series: [
                                            {
                                                name: '户数',
                                                type: 'pie',
                                                selectedMode: 'single',
                                                radius: [0, 70],

                                                // for funnel
                                                x: '20%',
                                                width: '40%',
                                                funnelAlign: 'right',
                                                //max: 1548,

                                                itemStyle: {
                                                    normal: {
                                                        label: {
                                                            position: 'inner'
                                                        },
                                                        labelLine: {
                                                            show: false
                                                        }
                                                    }
                                                },
                                                data: [
                                                    { value: fam_total-fam_im, name: '非移民总户数' },
                                                   
                                                    { value: fam_im, name: '移民总户数', selected: true }
                                                ]
                                            },
                                            {
                                                name: '人数',
                                                type: 'pie',
                                                radius: [90, 120],

                                                // for funnel
                                                x: '60%',
                                                width: '35%',
                                                funnelAlign: 'left',
                                                //max: 1048,

                                                data: [
                                                    { value: peo_total-peo_im, name: '非移民' },
                                                    { value: peo_im, name: '移民' }
                                                   
                                                ]
                                            }
                                        ]
                                    };
                                    myChart.setOption(option);
                                });

                        }

                        // 右下图    
                        function show_rb_yuan_chart() {
                            var labor_rate = document.getElementById("<%=Labeltotallf_having_job_rate.ClientID %>").innerHTML - 0;
                            var poor_rate = document.getElementById("<%=Labeltotalpoor_people_rate.ClientID %>").innerHTML - 0;
                        
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
                                        normal : {
                                            label : {
                                                show : true,
                                                position : 'center',
                                                formatter : '{b}',
                                                textStyle: {
                                                    baseline : 'bottom'
                                                }
                                            },
                                            labelLine : {
                                                show : false
                                            }
                                        }
                                    };
                                    var labelFromatter = {
                                        normal : {
                                            label : {
                                                formatter : function (params){
                                                    return (100 - params.value).toFixed(2) + '%'
                                                },
                                                textStyle: {
                                                    baseline : 'top'
                                                }
                                            }
                                        },
                                    }
                                    var labelBottom = {
                                        normal : {
                                            color: '#ccc',
                                            label : {
                                                show : true,
                                                position : 'center'
                                            },
                                            labelLine : {
                                                show : false
                                            }
                                        },
                                        emphasis: {
                                            color: 'rgba(0,0,0,0)'
                                        }
                                    };
                                    var radius = [40, 65];
                                    option = {
                                        legend: {
                                            x : 'center',
                                            y : '180',
                                            data:[
                                                '劳动力就业率','低保人口比例'
                                            ]
                                        },
                                       
                                       
                                        series : [
                                            {
                                                type : 'pie',
                                                center : ['22%', '30%'],
                                                radius : radius,
                                                x: '0%', // for funnel
                                                itemStyle : labelFromatter,
                                                data : [
                                                    {name:'other', value:100-labor_rate, itemStyle : labelBottom},
                                                    {name:'劳动力就业率', value:labor_rate,itemStyle : labelTop}
                                                ]
                                            },
                                            {
                                                type : 'pie',
                                                center : ['76%', '30%'],
                                                radius : radius,
                                                x:'20%', // for funnel
                                                itemStyle : labelFromatter,
                                                data : [
                                                    { name: 'other', value: 100-poor_rate, itemStyle: labelBottom },
                                                    { name: '低保人口比例', value: poor_rate, itemStyle: labelTop }
                                                ]
                                            },
                                           
                                        ]
                                    };
                                    myChart.setOption(option);
                                });

                        }
                                       
                    </script>
                    <!--ECharts单文件引入完毕-->
                    <!--人口部分结束-->
                    <!--支配部分开始-->
                    <div class="subdatasection" style="height: 450px;">
                        <div class="sdsr3">
                            <div class="subdatasectionimg" style="background-image: url(../Images/LeaderIndexImg/kuai3_lined.png);
                                margin-left: 150px;">
                            </div>
                            <div class="subdatasectionimgright">
                                <p>
                                    人均可支配2013年情况：<span>&nbsp<asp:Label ID="Labeltotaldisposable_income_2013" runat="server"></asp:Label>&nbsp</span>元</p>
                                <p>
                                    人均可支配当前情况：<span>&nbsp<asp:Label ID="Labeltotaldisposable_income_now" runat="server"></asp:Label>&nbsp</span>元</p>
                                <p>
                                    人均可支配收入变化情况<span>&nbsp<asp:Label ID="Labeltotalincome_change" runat="server"></asp:Label>&nbsp</span>%</p>
                            </div>
                            <div class="subdatasectionimgtop" style="text-align: center;">
                                <p style="float: left; width: 100px; margin-left: 250px;">
                                    <span>支配</span></p>
                            </div>
                        </div>
                    </div>
                    <!--支配部分结束-->
                    <div class="upthetri">
                    </div>
                    <div class="thetriparent">
                        <div class="thetri">
                        </div>
                    </div>
                    <div class="subdatasectionbot">
                        <div class="sdsb">
                            <p>
                                累积计划投资
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="LabelTotalplan_investment" runat="server"></asp:Label></span></p>
                            <p>
                                万元
                            </p>
                        </div>
                        <div class="sdsb">
                            <p>
                                累积完成投资
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="Labelfinished_investment" runat="server"></asp:Label></span></p>
                            <p>
                                万元
                            </p>
                        </div>
                        <div class="sdsb">
                            <p>
                                投资完成比例
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="Labelinvestment_rate" runat="server"></asp:Label></span></p>
                            <p>
                                %
                            </p>
                        </div>
                    </div>
                    <div class="subdatasectionbot">
                        <div class="sdsb">
                            <p>
                                累积专项资金计划
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="Labelplan_special_inves" runat="server"></asp:Label></span></p>
                            <p>
                                万元
                            </p>
                        </div>
                        <div class="sdsb">
                            <p>
                                累积专项资金完成
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="Labelcom_special_inves" runat="server"></asp:Label></span></p>
                            <p>
                                万元
                            </p>
                        </div>
                        <div class="sdsb">
                            <p>
                                专项资金完成比例
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="Labelspecial_inves_rate" runat="server"></asp:Label></span></p>
                            <p>
                                %
                            </p>
                        </div>
                    </div>
                </div>
                <div class="bom1botleft fl">
                    <div style="width: 580px; height: 400px;" id="main_total_capital">
                        <%--<img src="img/echart.png" alt="" width="100%" height="100%" />--%>
                    </div>
                    <div style="width: 518px; height: 40px; margin-top: -30px; margin-left: 20px;">
                        <table class="forechart">
                            <tr>
                                <td style="width: 58px;">
                                    计划投资
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalPlan11" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalPlan12" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalPlan13" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 58px;">
                                    完成
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalFinished11" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalFinished12" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalFinished13" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div style="display: none;">
                        <asp:TextBox ID="TextBoxTotalPlan1" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxTotalFinished1" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxTotalPlan2" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxTotalFinished2" runat="server"></asp:TextBox>
                    </div>
                    <!-- ECharts单文件引入 -->
                    <script type="text/javascript">
                        var strtotal_plan1 = document.getElementById("<%=TextBoxTotalPlan1.ClientID %>").value;
                        var mytotal_plan1 = strtotal_plan1.split('-');
                        var total_plan1 = new Array();
                        for (var i = 0; i < mytotal_plan1.length - 1; i++) {
                            total_plan1[i] = mytotal_plan1[i];
                        }

                        var strtotal_finished1 = document.getElementById("<%=TextBoxTotalFinished1.ClientID %>").value;
                        var mytotal_finished1 = strtotal_finished1.split('-');
                        var total_finished1 = new Array();
                        for (var p = 0; p < mytotal_finished1.length - 1; p++) {
                            total_finished1[p] = mytotal_finished1[p];
                        }
                        function showtotal_echart() {

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
                                                data: total_plan1,
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
                                                data: total_finished1,
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
                  
                    <p>
                        按资金来源划分的投资计划及完成情况</p>
                </div>
                <div class="bom1botmid fl">
                </div>
                <div class="bom1botright fl">
                    <div style="width: 580px; height: 400px;" id="main_total_type">
                        <%--<img src="img/echart2.png" alt="" width="100%" height="100%" />--%>
                    </div>
                    <div style="width: 518px; height: 40px; margin-top: -30px; margin-left: 20px;">
                        <table class="forecharttype">
                            <tr>
                                <td style="width: 58px;">
                                    计划投资
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalPlan21" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalPlan22" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalPlan23" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalPlan24" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalPlan25" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 58px;">
                                    完成
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalFinished21" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalFinished22" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalFinished23" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalFinished24" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelTotalFinished25" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <!-- ECharts单文件引入 -->
                    <script type="text/javascript">
                        var strtotal_plan2 = document.getElementById("<%=TextBoxTotalPlan2.ClientID %>").value;
                        var mytotal_plan2 = strtotal_plan2.split('-');
                        var total_plan2 = new Array();
                        for (var q = 0; q < mytotal_plan2.length - 1; q++) {
                            total_plan2[q] = mytotal_plan2[q];
                        }

                        var strtotal_finished2 = document.getElementById("<%=TextBoxTotalFinished2.ClientID %>").value;
                        var mytotal_finished2 = strtotal_finished2.split('-');
                        var total_finished2 = new Array();
                        for (var r = 0; r < mytotal_finished2.length - 1; r++) {
                            total_finished2[r] = mytotal_finished2[r];
                        }
                        function showtotal_typeechart() {

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
                                             
                    </script>
                    <!--ECharts文件引入完毕-->
                    <p>
                        专项资金按类别结构划分的投资计划及完成情况</p>
                </div>
            </div>
            <!-------------------------------------------------------------------------------------------->
            <div class="bom2" id="bom2" runat="server">
                <div class="bomtitlepro fl" id="bomtitlepro">
                    <p style="font-size: 29px; text-align: center; color: #63CB30; line-height: 140px;">
                        <asp:Label ID="LabelPro" runat="server"></asp:Label>城镇移民小区综合监测综合汇总指标</p>
                    <p style="font-size: 17px; text-align: right; color: #000;">
                        数据更新日期：2015-8-1
                        <%--<asp:Label ID="Label1" runat="server" ></asp:Label>--%>
                    </p>
                </div>
                <div class="datasection fl">
                    
                    <!--小区部分开始-->
                    <div class="subdatasection">
                        <div class="sdsr1">
                            <div class="subdatasectionimgtop">
                                <div class="data_right">
                                    <p>
                                        所有项目覆盖小区<span>&nbsp<asp:Label ID="Labelprovincecover_community_num" runat="server"></asp:Label>&nbsp</span>个</p>
                                </div>
                            </div>
                            <div class="subdatasectionimgleft">
                                <div class="echart_yuan" id="echart_yuan_province1">
                                </div>
                                <div class="data_right">
                                    <p>
                                        小区数量<span>&nbsp<asp:Label ID="Labelprovincecommunity_num" runat="server"></asp:Label>&nbsp</span>个</p>
                                </div>
                            </div>
                            <div class="subdatasectionimg">
                            </div>
                            <div class="subdatasectionimgright">
                                <div class="data_right">
                                    <p>
                                        专项资金项目覆盖小区<span>&nbsp<asp:Label ID="Labelprovincespecial_cover_community_num" runat="server"></asp:Label>&nbsp</span>个</p>
                                </div>
                                <div class="echart_yuan2" id="echart_yuan_province2">
                                </div>
                            </div>
                            <div class="subdatasectionimgtop">
                                <div class="data_right" style="float: left; width: 100%;">
                                    <p style="float: left; width: 390px;">
                                        县城（城市）小区<span>&nbsp<asp:Label ID="Labelprovincecounty_community_num" runat="server"></asp:Label>&nbsp</span>个,
                                        集镇小区<span>&nbsp<asp:Label ID="Labelprovincetown_community_num" runat="server"></asp:Label>&nbsp</span>个</p>
                                    <p style="float: left; width: 100px; margin-left: 90px;">
                                        <span>小区</span></p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- ECharts单文件引入 -->
                    <script type="text/javascript">
                        //左上图
                        function show_lt_yuan_provincechart() {
                            var xc_com = document.getElementById("<%=Labelprovincecounty_community_num.ClientID %>").innerHTML - 0;
                            var jz_com = document.getElementById("<%=Labelprovincetown_community_num.ClientID %>").innerHTML - 0;
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
                                            orient: 'vertical',
                                            x: 'right',
                                            data: ['县城（城市）小区', '集镇小区']
                                        },
                                        //color: ['#00DDDD', '#0580b9'],
                                        calculable: true,
                                        series: [
                                            {
                                                name: '访问来源',
                                                type: 'pie',
                                                radius: ['50%', '70%'],
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
                                                                fontSize: '20',
                                                                fontWeight: 'bold'
                                                            }
                                                        }
                                                    }
                                                },
                                                data: [
                                                    { value: xc_com, name: '县城（城市）小区' },
                                                    { value: jz_com, name: '集镇小区' }

                                                ]
                                            }
                                        ]
                                    };
                                    myChart.setOption(option);
                                });

                        }

                        // 右上图    
                        function show_rt_yuan_provincechart() {
                            var all_ = document.getElementById("<%=Labelprovincecover_community_num.ClientID %>").innerHTML - 0;
                            var special_ = document.getElementById("<%=Labelprovincespecial_cover_community_num.ClientID %>").innerHTML - 0;
                            var all_com = document.getElementById("<%=Labelprovincecommunity_num.ClientID %>").innerHTML - 0;
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
                                            formatter: "{a} <br/>{b} : {c} ({d}%)"
                                        },
                                        legend: {
                                            orient: 'vertical',
                                            x: document.getElementById('echart_yuan_province2').offsetWidth / 3,
                                            y: 85,
                                            itemGap: 12,
                                            data: ['所有项目覆盖小区', '专项资金项目覆盖小区']
                                        },

                                        series: [
                                            {
                                                name: '1',
                                                type: 'pie',
                                                clockWise: false,
                                                radius: [90, 115],
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
                                                radius: [65, 90],
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
                                       
                    </script>
                    <!--ECharts单文件引入完毕-->
                    <!--小区部分结束-->
                    <!--人口部分开始-->
                    <div class="subdatasection">
                        <div class="sdsr2">
                            <div class="subdatasectionimgleft">
                                <div class="echart_yuan" id="echart_yuan_people_province1" style="width: 380px; float: none;">
                                </div>
                                <div class="data_right">
                                    <p style="line-height: 30px;">
                                        小区居民户籍人口： 总户数<span>&nbsp<asp:Label ID="Labelprovincetotal_family_num" runat="server">&nbsp</asp:Label>&nbsp</span>户<br />
                                        总人数<span>&nbsp<asp:Label ID="Labelprovincetotal_people_num" runat="server"></asp:Label>&nbsp</span>人</p>
                                </div>
                            </div>
                            <div class="subdatasectionimg" style="background-image: url(../Images/LeaderIndexImg/kuai2_lined.png)">
                            </div>
                            <div class="subdatasectionimgright" style="border-bottom: 2px solid #C0C0C0; border-top: none;">
                                <div class="echart_yuan2" id="echart_yuan_people_province2" style="margin-top: 40px; width: 360px;">
                                </div>
                                <div class="data_right">
                                    <p style="line-height: 30px;">
                                        劳动力就业率<span>&nbsp
                                            <asp:Label ID="Labelprovincelf_having_job_rate" runat="server"></asp:Label>&nbsp</span>%<br />
                                        低保人口比例<span>&nbsp
                                            <asp:Label ID="Labelprovincepoor_people_rate" runat="server"></asp:Label>&nbsp</span>%</p>
                                </div>
                            </div>
                            <div class="subdatasectionimgtop">
                                <div class="data_right" style="width: 100%; float: left;">
                                    <p style="float: left; margin-left: 50px; line-height: 30px;">
                                        其中移民： 总户数<span>&nbsp<asp:Label ID="Labelprovinceimmigrant_family_num" runat="server"></asp:Label>&nbsp</span>户<br />
                                        总人数<span>&nbsp<asp:Label ID="Labelprovinceimmigrant_people_num" runat="server"></asp:Label>&nbsp</span>人</p>
                                    <p style="float: left; width: 100px; margin-left: 180px;">
                                        <span>居民</span></p>
                                    <p style="float: left; margin-left: 190px;">
                                        人均住房面积<span>&nbsp<asp:Label ID="Labelprovinceaverage_house_area" runat="server"></asp:Label>&nbsp</span>㎡</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- ECharts单文件引入 -->
                    <script type="text/javascript">
                        //左下图
                        function show_lb_yuan_provincechart() {
                            var fam_total = document.getElementById("<%=Labelprovincetotal_family_num.ClientID %>").innerHTML - 0;
                            var peo_total = document.getElementById("<%=Labelprovincetotal_people_num.ClientID %>").innerHTML - 0;
                            var fam_im = document.getElementById("<%=Labelprovinceimmigrant_family_num.ClientID %>").innerHTML - 0;
                            var peo_im = document.getElementById("<%=Labelprovinceimmigrant_people_num.ClientID %>").innerHTML - 0;
                           
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
                                    option = {
                                        tooltip: {
                                            trigger: 'item',
                                            formatter: "{a} <br/>{b} : {c} ({d}%)"
                                        },
//                                        legend: {
//                                            orient: 'vertical',
//                                            x: 'left',
//                                            data: ['非移民总户数', '非移民总人数', '移民总户数', '移民总人数']
//                                        },
                                        
                                        calculable: false,
                                        series: [
                                            {
                                                name: '户数',
                                                type: 'pie',
                                                selectedMode: 'single',
                                                radius: [0, 70],

                                                // for funnel
                                                x: '20%',
                                                width: '40%',
                                                funnelAlign: 'right',
                                                //max: 1548,

                                                itemStyle: {
                                                    normal: {
                                                        label: {
                                                            position: 'inner'
                                                        },
                                                        labelLine: {
                                                            show: false
                                                        }
                                                    }
                                                },
                                                data: [
                                                    { value: fam_total-fam_im, name: '非移民总户数' },
                                                   
                                                    { value: fam_im, name: '移民总户数', selected: true }
                                                ]
                                            },
                                            {
                                                name: '人数',
                                                type: 'pie',
                                                radius: [90, 120],

                                                // for funnel
                                                x: '60%',
                                                width: '35%',
                                                funnelAlign: 'left',
                                                //max: 1048,

                                                data: [
                                                    { value: peo_total-peo_im, name: '非移民' },
                                                    { value: peo_im, name: '移民' }
                                                   
                                                ]
                                            }
                                        ]
                                    };
                                    myChart.setOption(option);
                                });

                        }

                        // 右下图    
                        function show_rb_yuan_provincechart() {
                            var labor_rate = document.getElementById("<%=Labelprovincelf_having_job_rate.ClientID %>").innerHTML - 0;
                            var poor_rate = document.getElementById("<%=Labelprovincepoor_people_rate.ClientID %>").innerHTML - 0;
                        
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
                                        normal : {
                                            label : {
                                                show : true,
                                                position : 'center',
                                                formatter : '{b}',
                                                textStyle: {
                                                    baseline : 'bottom'
                                                }
                                            },
                                            labelLine : {
                                                show : false
                                            }
                                        }
                                    };
                                    var labelFromatter = {
                                        normal : {
                                            label : {
                                                formatter : function (params){
                                                    return (100 - params.value).toFixed(2) + '%'
                                                },
                                                textStyle: {
                                                    baseline : 'top'
                                                }
                                            }
                                        },
                                    }
                                    var labelBottom = {
                                        normal : {
                                            color: '#ccc',
                                            label : {
                                                show : true,
                                                position : 'center'
                                            },
                                            labelLine : {
                                                show : false
                                            }
                                        },
                                        emphasis: {
                                            color: 'rgba(0,0,0,0)'
                                        }
                                    };
                                    var radius = [40, 65];
                                    option = {
                                        legend: {
                                            x : 'center',
                                            y : '180',
                                            data:[
                                                '劳动力就业率','低保人口比例'
                                            ]
                                        },
                                       
                                       
                                        series : [
                                            {
                                                type : 'pie',
                                                center : ['22%', '30%'],
                                                radius : radius,
                                                x: '0%', // for funnel
                                                itemStyle : labelFromatter,
                                                data : [
                                                    {name:'other', value:100-labor_rate, itemStyle : labelBottom},
                                                    {name:'劳动力就业率', value:labor_rate,itemStyle : labelTop}
                                                ]
                                            },
                                            {
                                                type : 'pie',
                                                center : ['76%', '30%'],
                                                radius : radius,
                                                x:'20%', // for funnel
                                                itemStyle : labelFromatter,
                                                data : [
                                                    {name:'other', value:100-poor_rate, itemStyle : labelBottom},
                                                    {name:'低保人口比例', value:poor_rate,itemStyle : labelTop}
                                                ]
                                            },
                                           
                                        ]
                                    };
                                    myChart.setOption(option);
                                });

                        }
                                       
                    </script>
                    <!--ECharts单文件引入完毕-->
                    <!--人口部分结束-->
                    <!--支配部分开始-->
                    <div class="subdatasection" style="height: 450px;">
                        <div class="sdsr3">
                            <div class="subdatasectionimg" style="background-image: url(../Images/LeaderIndexImg/kuai3_lined.png);
                                margin-left: 150px;">
                            </div>
                            <div class="subdatasectionimgright">
                                <p>
                                    人均可支配2013年情况：<span>&nbsp<asp:Label ID="Labelprovincedisposable_income_2013" runat="server"></asp:Label>&nbsp</span>元</p>
                                <p>
                                    人均可支配当前情况：<span>&nbsp<asp:Label ID="Labelprovincedisposable_income_now" runat="server"></asp:Label>&nbsp</span>元</p>
                                <p>
                                    人均可支配收入变化情况<span>&nbsp<asp:Label ID="Labelprovinceincome_change" runat="server"></asp:Label>&nbsp</span>%</p>
                            </div>
                            <div class="subdatasectionimgtop" style="text-align: center;">
                                <p style="float: left; width: 100px; margin-left: 250px;">
                                    <span>支配</span></p>
                            </div>
                        </div>
                    </div>
                    <!--支配部分结束-->
                    <div class="upthetri">
                    </div>
                    <div class="thetriparent">
                        <div class="thetri">
                        </div>
                    </div>
                    <div class="subdatasectionbot">
                        <div class="sdsb">
                            <p>
                                累积计划投资
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="Labelprovince_plan" runat="server"></asp:Label></span></p>
                            <p>
                                万元
                            </p>
                        </div>
                        <div class="sdsb">
                            <p>
                                累积完成投资
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="Labelprovince_finished" runat="server"></asp:Label></span></p>
                            <p>
                                万元
                            </p>
                        </div>
                        <div class="sdsb">
                            <p>
                                投资完成比例
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="Labelprovince_rate" runat="server"></asp:Label></span></p>
                            <p>
                                %
                            </p>
                        </div>
                    </div>
                    <div class="subdatasectionbot">
                        <div class="sdsb">
                            <p>
                                累积专项资金计划
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="LabelProplan_special_inves" runat="server"></asp:Label></span></p>
                            <p>
                                万元
                            </p>
                        </div>
                        <div class="sdsb">
                            <p>
                                累积专项资金完成
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="LabelProcom_special_inves" runat="server"></asp:Label></span></p>
                            <p>
                                万元
                            </p>
                        </div>
                        <div class="sdsb">
                            <p>
                                专项资金完成比例
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="LabelProspecial_inves_rate" runat="server"></asp:Label></span></p>
                            <p>
                                %
                            </p>
                        </div>
                    </div>
                </div>
                <div class="bom1botleft fl">
                    <div style="width: 580px; height: 400px;" id="main_prototal_capital">
                        <%--<img src="img/echart.png" alt="" width="100%" height="100%" />--%>
                    </div>
                    <div style="width: 518px; height: 40px; margin-top: -30px; margin-left: 20px;">
                        <table class="forechart">
                            <tr>
                                <td style="width: 58px;">
                                    计划投资
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvincePlan11" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvincePlan12" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvincePlan13" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 58px;">
                                    完成
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvinceFinished11" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvinceFinished12" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvinceFinished13" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div style="display: none;">
                        <asp:TextBox ID="TextBoxProvincePlan1" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxProvinceFinished1" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxProvincePlan2" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxProvinceFinished2" runat="server"></asp:TextBox>
                    </div>
                    <!-- ECharts单文件引入 -->
                    <script type="text/javascript">
                        var strprovince_plan1 = document.getElementById("<%=TextBoxProvincePlan1.ClientID %>").value;
                        var myprovince_plan1 = strprovince_plan1.split('-');
                        var province_plan1 = new Array();
                        for (var s = 0; s < myprovince_plan1.length - 1; s++) {
                            province_plan1[s] = myprovince_plan1[s];
                        }

                        var strprovince_finished1 = document.getElementById("<%=TextBoxProvinceFinished1.ClientID %>").value;
                        var myprovince_finished1 = strprovince_finished1.split('-');
                        var province_finished1 = new Array();
                        for (var t = 0; t < myprovince_finished1.length - 1; t++) {
                            province_finished1[t] = myprovince_finished1[t];
                        }
                        function show_prototal_echart() {

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
                                                data: province_plan1,
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
                                                data: province_finished1,
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
                        按资金来源划分的投资计划及完成情况</p>
                </div>
                <div class="bom1botmid fl">
                </div>
                <div class="bom1botright fl">
                    <div style="width: 580px; height: 400px;" id="main_prototal_type">
                        <%--<img src="img/echart2.png" alt="" width="100%" height="100%" />--%>
                    </div>
                    <div style="width: 518px; height: 40px; margin-top: -30px; margin-left: 20px;">
                        <table class="forecharttype">
                            <tr>
                                <td style="width: 58px;">
                                    计划投资
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvincePlan21" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvincePlan22" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvincePlan23" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvincePlan24" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvincePlan25" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 58px;">
                                    完成
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvinceFinished21" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvinceFinished22" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvinceFinished23" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvinceFinished24" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelProvinceFinished25" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <!-- ECharts单文件引入 -->
                    <script type="text/javascript">
                        var strprovince_plan2 = document.getElementById("<%=TextBoxProvincePlan2.ClientID %>").value;
                        var myprovince_plan2 = strprovince_plan2.split('-');
                        var province_plan2 = new Array();
                        for (var u = 0; u < myprovince_plan2.length - 1; u++) {
                            province_plan2[u] = myprovince_plan2[u];
                        }

                        var strprovince_finished2 = document.getElementById("<%=TextBoxProvinceFinished2.ClientID %>").value;
                        var myprovince_finished2 = strprovince_finished2.split('-');
                        var province_finished2 = new Array();
                        for (var v = 0; v < myprovince_finished2.length - 1; v++) {
                            province_finished2[v] = myprovince_finished2[v];
                        }
                        function show_prototal_typeechart() {

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
                                             
                    </script>
                    <!--ECharts文件引入完毕-->
                    <p>
                        专项资金按类别结构划分的投资计划及完成情况</p>
                </div>
                <%--  <div class="bom1botbot fl">
                </div>--%>
            </div>
            <div class="bom2" id="bom3" runat="server">
                <p style="font-size: 29px; text-align: center; color: #63CB30; margin-top: 20px;">
                    <asp:Label ID="LabelPro2" runat="server"></asp:Label><asp:Label ID="LabelCou" runat="server"></asp:Label>城镇移民小区综合监测综合汇总指标</p>
                <p style="font-size: 17px; text-align: right; color: #000; margin-top: 7px;">
                    数据更新日期：2015-8-1
                    <%--<asp:Label ID="Label1" runat="server" ></asp:Label>--%>
                </p>
                <div class="datasection fl">
                    
                       <!--小区部分开始-->
                    <div class="subdatasection">
                        <div class="sdsr1">
                            <div class="subdatasectionimgtop">
                                <div class="data_right">
                                    <p>
                                        所有项目覆盖小区<span>&nbsp<asp:Label ID="Labelcountycover_community_num" runat="server"></asp:Label>&nbsp</span>个</p>
                                </div>
                            </div>
                            <div class="subdatasectionimgleft">
                                <div class="echart_yuan" id="echart_yuan_county1">
                                </div>
                                <div class="data_right">
                                    <p>
                                        小区数量<span>&nbsp<asp:Label ID="Labelcountycommunity_num" runat="server"></asp:Label>&nbsp</span>个</p>
                                </div>
                            </div>
                            <div class="subdatasectionimg">
                            </div>
                            <div class="subdatasectionimgright">
                                <div class="data_right">
                                    <p>
                                        专项资金项目覆盖小区<span>&nbsp<asp:Label ID="Labelcountyspecial_cover_community_num" runat="server"></asp:Label>&nbsp</span>个</p>
                                </div>
                                <div class="echart_yuan2" id="echart_yuan_county2">
                                </div>
                            </div>
                            <div class="subdatasectionimgtop">
                                <div class="data_right" style="float: left; width: 100%;">
                                    <p style="float: left; width: 390px;">
                                        县城（城市）小区<span>&nbsp<asp:Label ID="Labelcountycounty_community_num" runat="server"></asp:Label>&nbsp</span>个,
                                        集镇小区<span>&nbsp<asp:Label ID="Labelcountytown_community_num" runat="server"></asp:Label>&nbsp</span>个</p>
                                    <p style="float: left; width: 100px; margin-left: 90px;">
                                        <span>小区</span></p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- ECharts单文件引入 -->
                    <script type="text/javascript">
                        //左上图
                        function show_lt_yuan_countychart() {
                            var xc_com = document.getElementById("<%=Labelcountycounty_community_num.ClientID %>").innerHTML - 0;
                            var jz_com = document.getElementById("<%=Labelcountytown_community_num.ClientID %>").innerHTML - 0;
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
                                            orient: 'vertical',
                                            x: 'right',
                                            data: ['县城（城市）小区', '集镇小区']
                                        },
                                        //color: ['#00DDDD', '#0580b9'],
                                        calculable: true,
                                        series: [
                                            {
                                                name: '访问来源',
                                                type: 'pie',
                                                radius: ['50%', '70%'],
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
                                                                fontSize: '20',
                                                                fontWeight: 'bold'
                                                            }
                                                        }
                                                    }
                                                },
                                                data: [
                                                    { value: xc_com, name: '县城（城市）小区' },
                                                    { value: jz_com, name: '集镇小区' }

                                                ]
                                            }
                                        ]
                                    };
                                    myChart.setOption(option);
                                });

                        }

                        // 右上图    
                        function show_rt_yuan_countychart() {
                            var all_ = document.getElementById("<%=Labelcountycover_community_num.ClientID %>").innerHTML - 0;
                            var special_ = document.getElementById("<%=Labelcountyspecial_cover_community_num.ClientID %>").innerHTML - 0;
                            var all_com = document.getElementById("<%=Labelcountycommunity_num.ClientID %>").innerHTML - 0;
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
                                            formatter: "{a} <br/>{b} : {c} ({d}%)"
                                        },
                                        legend: {
                                            orient: 'vertical',
                                            x: document.getElementById('echart_yuan_county2').offsetWidth / 3,
                                            y: 85,
                                            itemGap: 12,
                                            data: ['所有项目覆盖小区', '专项资金项目覆盖小区']
                                        },

                                        series: [
                                            {
                                                name: '1',
                                                type: 'pie',
                                                clockWise: false,
                                                radius: [90, 115],
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
                                                radius: [65, 90],
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
                                       
                    </script>
                    <!--ECharts单文件引入完毕-->
                    <!--小区部分结束-->
                    <!--人口部分开始-->
                    <div class="subdatasection">
                        <div class="sdsr2">
                            <div class="subdatasectionimgleft">
                                <div class="echart_yuan" id="echart_yuan_people_county1" style="width: 380px; float: none;">
                                </div>
                                <div class="data_right">
                                    <p style="line-height: 30px;">
                                        小区居民户籍人口： 总户数<span>&nbsp<asp:Label ID="Labelcountytotal_family_num" runat="server">&nbsp</asp:Label>&nbsp</span>户<br />
                                        总人数<span>&nbsp<asp:Label ID="Labelcountytotal_people_num" runat="server"></asp:Label>&nbsp</span>人</p>
                                </div>
                            </div>
                            <div class="subdatasectionimg" style="background-image: url(../Images/LeaderIndexImg/kuai2_lined.png)">
                            </div>
                            <div class="subdatasectionimgright" style="border-bottom: 2px solid #C0C0C0; border-top: none;">
                                <div class="echart_yuan2" id="echart_yuan_people_county2" style="margin-top: 40px; width: 360px;">
                                </div>
                                <div class="data_right">
                                    <p style="line-height: 30px;">
                                        劳动力就业率<span>&nbsp
                                            <asp:Label ID="Labelcountylf_having_job_rate" runat="server"></asp:Label>&nbsp</span>%<br />
                                        低保人口比例<span>&nbsp
                                            <asp:Label ID="Labelcountypoor_people_rate" runat="server"></asp:Label>&nbsp</span>%</p>
                                </div>
                            </div>
                            <div class="subdatasectionimgtop">
                                <div class="data_right" style="width: 100%; float: left;">
                                    <p style="float: left; margin-left: 50px; line-height: 30px;">
                                        其中移民： 总户数<span>&nbsp<asp:Label ID="Labelcountyimmigrant_family_num" runat="server"></asp:Label>&nbsp</span>户<br />
                                        总人数<span>&nbsp<asp:Label ID="Labelcountyimmigrant_people_num" runat="server"></asp:Label>&nbsp</span>人</p>
                                    <p style="float: left; width: 100px; margin-left: 180px;">
                                        <span>居民</span></p>
                                    <p style="float: left; margin-left: 190px;">
                                        人均住房面积<span>&nbsp<asp:Label ID="Labelcountyaverage_house_area" runat="server"></asp:Label>&nbsp</span>㎡</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- ECharts单文件引入 -->
                    <script type="text/javascript">
                        //左下图
                        function show_lb_yuan_countychart() {
                            var fam_total = document.getElementById("<%=Labelcountytotal_family_num.ClientID %>").innerHTML - 0;
                            var peo_total = document.getElementById("<%=Labelcountytotal_people_num.ClientID %>").innerHTML - 0;
                            var fam_im = document.getElementById("<%=Labelcountyimmigrant_family_num.ClientID %>").innerHTML - 0;
                            var peo_im = document.getElementById("<%=Labelcountyimmigrant_people_num.ClientID %>").innerHTML - 0;
                           
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
                                    option = {
                                        tooltip: {
                                            trigger: 'item',
                                            formatter: "{a} <br/>{b} : {c} ({d}%)"
                                        },
//                                        legend: {
//                                            orient: 'vertical',
//                                            x: 'left',
//                                            data: ['非移民总户数', '非移民总人数', '移民总户数', '移民总人数']
//                                        },
                                        
                                        calculable: false,
                                        series: [
                                            {
                                                name: '户数',
                                                type: 'pie',
                                                selectedMode: 'single',
                                                radius: [0, 70],

                                                // for funnel
                                                x: '20%',
                                                width: '40%',
                                                funnelAlign: 'right',
                                                //max: 1548,

                                                itemStyle: {
                                                    normal: {
                                                        label: {
                                                            position: 'inner'
                                                        },
                                                        labelLine: {
                                                            show: false
                                                        }
                                                    }
                                                },
                                                data: [
                                                    { value: fam_total-fam_im, name: '非移民总户数' },
                                                   
                                                    { value: fam_im, name: '移民总户数', selected: true }
                                                ]
                                            },
                                            {
                                                name: '人数',
                                                type: 'pie',
                                                radius: [90, 120],

                                                // for funnel
                                                x: '60%',
                                                width: '35%',
                                                funnelAlign: 'left',
                                                //max: 1048,

                                                data: [
                                                    { value: peo_total-peo_im, name: '非移民' },
                                                    { value: peo_im, name: '移民' }
                                                   
                                                ]
                                            }
                                        ]
                                    };
                                    myChart.setOption(option);
                                });

                        }

                        // 右下图    
                        function show_rb_yuan_countychart() {
                            var labor_rate = document.getElementById("<%=Labelcountylf_having_job_rate.ClientID %>").innerHTML - 0;
                            var poor_rate = document.getElementById("<%=Labelcountypoor_people_rate.ClientID %>").innerHTML - 0;
                        
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
                                        normal : {
                                            label : {
                                                show : true,
                                                position : 'center',
                                                formatter : '{b}',
                                                textStyle: {
                                                    baseline : 'bottom'
                                                }
                                            },
                                            labelLine : {
                                                show : false
                                            }
                                        }
                                    };
                                    var labelFromatter = {
                                        normal : {
                                            label : {
                                                formatter : function (params){
                                                    return (100 - params.value).toFixed(2) + '%'
                                                },
                                                textStyle: {
                                                    baseline : 'top'
                                                }
                                            }
                                        },
                                    }
                                    var labelBottom = {
                                        normal : {
                                            color: '#ccc',
                                            label : {
                                                show : true,
                                                position : 'center'
                                            },
                                            labelLine : {
                                                show : false
                                            }
                                        },
                                        emphasis: {
                                            color: 'rgba(0,0,0,0)'
                                        }
                                    };
                                    var radius = [40, 65];
                                    option = {
                                        legend: {
                                            x : 'center',
                                            y : '180',
                                            data:[
                                                '劳动力就业率','低保人口比例'
                                            ]
                                        },
                                       
                                       
                                        series : [
                                            {
                                                type : 'pie',
                                                center : ['22%', '30%'],
                                                radius : radius,
                                                x: '0%', // for funnel
                                                itemStyle : labelFromatter,
                                                data : [
                                                    {name:'other', value:100-labor_rate, itemStyle : labelBottom},
                                                    {name:'劳动力就业率', value:labor_rate,itemStyle : labelTop}
                                                ]
                                            },
                                            {
                                                type : 'pie',
                                                center : ['76%', '30%'],
                                                radius : radius,
                                                x:'20%', // for funnel
                                                itemStyle : labelFromatter,
                                                data : [
                                                    {name:'other', value:100-poor_rate, itemStyle : labelBottom},
                                                    {name:'低保人口比例', value:poor_rate,itemStyle : labelTop}
                                                ]
                                            },
                                           
                                        ]
                                    };
                                    myChart.setOption(option);
                                });

                        }
                                       
                    </script>
                    <!--ECharts单文件引入完毕-->
                    <!--人口部分结束-->
                    <!--支配部分开始-->
                    <div class="subdatasection" style="height: 450px;">
                        <div class="sdsr3">
                            <div class="subdatasectionimg" style="background-image: url(../Images/LeaderIndexImg/kuai3_lined.png);
                                margin-left: 150px;">
                            </div>
                            <div class="subdatasectionimgright">
                                <p>
                                    人均可支配2013年情况：<span>&nbsp<asp:Label ID="Labelcountydisposable_income_2013" runat="server"></asp:Label>&nbsp</span>元</p>
                                <p>
                                    人均可支配当前情况：<span>&nbsp<asp:Label ID="Labelcountydisposable_income_now" runat="server"></asp:Label>&nbsp</span>元</p>
                                <p>
                                    人均可支配收入变化情况<span>&nbsp<asp:Label ID="Labelcountyincome_change" runat="server"></asp:Label>&nbsp</span>%</p>
                            </div>
                            <div class="subdatasectionimgtop" style="text-align: center;">
                                <p style="float: left; width: 100px; margin-left: 250px;">
                                    <span>支配</span></p>
                            </div>
                        </div>
                    </div>
                    <!--支配部分结束-->
                    <div class="upthetri">
                    </div>
                    <div class="thetriparent">
                        <div class="thetri">
                        </div>
                    </div>
                    <div class="subdatasectionbot">
                        <div class="sdsb1">
                            <p>
                                累积计划投资
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="LabelCouPlan" runat="server"></asp:Label></span></p>
                            <p>
                                万元
                            </p>
                        </div>
                        <div class="sdsb1">
                            <p>
                                累积完成投资
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="LabelCouFinished" runat="server"></asp:Label></span></p>
                            <p>
                                万元
                            </p>
                        </div>
                        <div class="sdsb1">
                            <p>
                                投资完成比例
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="LabelCouRate" runat="server"></asp:Label></span></p>
                            <p>
                                %
                            </p>
                        </div>
                        <div class="sdsb1">
                            <p>
                                恩格尔系数
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="Labelegr" runat="server"></asp:Label></span></p>
                            <p>
                                %
                            </p>
                        </div>
                        <div class="sdsb1">
                            <p>
                                基尼系数
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="Labeljn" runat="server"></asp:Label></span></p>
                            <p>
                                %
                            </p>
                        </div>
                    </div>
                    <div class="subdatasectionbot">
                        <div class="sdsb">
                            <p>
                                累积专项资金计划
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="Labelplan_total_special_inves" runat="server"></asp:Label></span></p>
                            <p>
                                万元
                            </p>
                        </div>
                        <div class="sdsb">
                            <p>
                                累积专项资金完成
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="Labelcomplete_total_special_inves" runat="server"></asp:Label></span></p>
                            <p>
                                万元
                            </p>
                        </div>
                        <div class="sdsb">
                            <p>
                                专项资金完成比例
                            </p>
                            <p>
                                <span>
                                    <asp:Label ID="Labelspecial_complete_rete" runat="server"></asp:Label></span></p>
                            <p>
                                %
                            </p>
                        </div>
                    </div>
                </div>
                <div class="bom1botleft fl">
                    <div style="width: 580px; height: 400px;" id="main_coutotal_capital">
                        <%--<img src="img/echart.png" alt="" width="100%" height="100%" />--%>
                    </div>
                    <div style="width: 518px; height: 40px; margin-top: -30px; margin-left: 20px;">
                        <table class="forechart">
                            <tr>
                                <td style="width: 58px;">
                                    计划投资
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouPlan11" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouPlan12" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouPlan13" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 58px;">
                                    完成
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouFinished11" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouFinished12" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouFinished13" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div style="display: none;">
                        <asp:TextBox ID="TextBoxCouPlan1" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxCouFinished1" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxCouPlan2" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBoxCouFinished2" runat="server"></asp:TextBox>
                    </div>
                    <!-- ECharts单文件引入 -->
                    <script type="text/javascript">
                        var strcou_plan1 = document.getElementById("<%=TextBoxCouPlan1.ClientID %>").value;
                        var mycou_plan1 = strcou_plan1.split('-');
                        var cou_plan1 = new Array();
                        for (var w = 0; w < mycou_plan1.length - 1; w++) {
                            cou_plan1[w] = mycou_plan1[w];
                        }

                        var strcou_finished1 = document.getElementById("<%=TextBoxCouFinished1.ClientID %>").value;
                        var mycou_finished1 = strcou_finished1.split('-');
                        var cou_finished1 = new Array();
                        for (var x = 0; x < mycou_finished1.length - 1; x++) {
                            cou_finished1[x] = mycou_finished1[x];
                        }
                        function show_coutotal_echart() {

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
                                                data: cou_plan1,
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
                                                data: cou_finished1,
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
                        按资金来源划分的投资计划及完成情况</p>
                </div>
                <div class="bom1botmid fl">
                </div>
                <div class="bom1botright fl">
                    <div style="width: 580px; height: 400px;" id="main_coutotal_type">
                        <%--<img src="img/echart2.png" alt="" width="100%" height="100%" />--%>
                    </div>
                    <div style="width: 518px; height: 40px; margin-top: -30px; margin-left: 20px;">
                        <table class="forecharttype">
                            <tr>
                                <td style="width: 58px;">
                                    计划投资
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouPlan21" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouPlan22" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouPlan23" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouPlan24" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouPlan25" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 58px;">
                                    完成
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouFinished21" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouFinished22" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouFinished23" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouFinished24" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelCouFinished25" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <!-- ECharts单文件引入 -->
                    <script type="text/javascript">
                        var strcou_plan2 = document.getElementById("<%=TextBoxCouPlan2.ClientID %>").value;
                        var mycou_plan2 = strcou_plan2.split('-');
                        var cou_plan2 = new Array();
                        for (var z = 0; z < mycou_plan2.length - 1; z++) {
                            cou_plan2[z] = mycou_plan2[z];
                        }

                        var strcou_finished2 = document.getElementById("<%=TextBoxCouFinished2.ClientID %>").value;
                        var mycou_finished2 = strcou_finished2.split('-');
                        var cou_finished2 = new Array();
                        for (var y = 0; y < mycou_finished2.length - 1; y++) {
                            cou_finished2[y] = mycou_finished2[y];
                        }
                        function show_coutotal_typeechart() {

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
                                             
                    </script>
                    <!--ECharts文件引入完毕-->
                    <p>
                        专项资金按类别结构划分的投资计划及完成情况</p>
                </div>
                <%--    <div class="bom1botbot fl">
                </div>--%>
            </div>
        </div>
    </div>
    <%--改成ClientId后放在了页面中--%>
    <%--<script src="Scripts/showinformation.js" type="text/javascript"></script>--%>
    <script type="text/javascript">
        function getValuePro(a) {
            var province = document.getElementById("<%=prov.ClientID %>");
            if (a == "不选") {
                province.value = "";
                document.getElementById("<%=county.ClientID %>").value = "";
                document.getElementById("<%=village.ClientID%>").value = "";
                document.getElementById("<%=hideBtn1.ClientID%>").click();
                hide();
            }
            else {
                province.value = a;
                document.getElementById("<%=county.ClientID %>").value = "";
                document.getElementById("<%=village.ClientID%>").value = "";
                document.getElementById("<%=hideBtn1.ClientID%>").click();
                hide();
            }
            var province = document.getElementById("<%=prov.ClientID %>");

        }

        function getValueCou(a) {
            var county = document.getElementById("<%=county.ClientID %>");
            if (a == "不选" || a == "未找到区(县)") {
                county.value = "";
                var village = document.getElementById("<%=village.ClientID%>");
                village.value = "";
                document.getElementById("<%=hideBtn2.ClientID%>").click();

            } else {

                county.value = a;
                document.getElementById("<%=hideBtn2.ClientID%>").click();
                document.getElementById("<%=village.ClientID%>").value = "";

            }
            hide();
        }

        function getValueVil(a) {
            var province = document.getElementById("<%=village.ClientID%>");
            if (a == "不选" || a == "未找到相应小区") {

                province.value = "";
            } else {
                province.value = a;
            }


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
                    if (document.getElementById(triname).style.display == "block" && document.getElementById(divname).style.display == "block") {
                        getdisplaynone(triname);
                        getdisplaynone(divname);
                    }
                    else {
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

            var provalue = document.getElementById("<%=prov.ClientID%>");
            var couvalue = document.getElementById("<%=county.ClientID%>");
            var vilvalue = document.getElementById("<%=village.ClientID%>");

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
            document.getElementById("<%=retirevalBtn.ClientID%>").click();
        }

        function showbynum(a) {
            var pro, proname;
            for (var i = 1; i <= 3; i++) {
                var bomname = "bom" + i;
                if (i == a) {
                    getdisplayblock(bomname);
                } else {

                    getdisplaynone(bomname);
                }
            }


        }

        function chooseBgimg() {

            pro = document.getElementById("bomtitlepro");
            proname = document.getElementById("<%=prov.ClientID%>").value;
            if (proname == "湖北省") {
                pro.style.backgroundImage = "url(../Images/LeaderIndexImg/hubei.png)";
            }
            else if (proname == "重庆市") {
                pro.style.backgroundImage = "url(../Images/LeaderIndexImg/chongqing.png)";
            }

        }

        function getdisplaynone(elementname) {
            var elementdisplay = document.getElementById(elementname).style.display = "none";

        }

        function getdisplayblock(elementname) {
            var elementdisplay = document.getElementById(elementname).style.display = "block";

        }

        function hidesr() {
            document.getElementById("<%=searchresult.ClientID%>").style.display = "none";
        }

        //        function changenumber() { 
        //             var spanlist=document.getElementsByTagName("span");
        //             for (var i = 0; i < spanlist.length; i++) {
        //                 var opratespan = document.getElementsByTagName("span")[i];
        //                 //var mynum = document.getElementsByTagName("span")[i].innerHTML;
        //                 var spannum = document.getElementsByTagName("span")[i].innerHTML - 0;
        //                 var num = 0;
        //                 while (num < spannum) {
        //                     setTimeout("opratespan.value=num+1", 1000 / spannum);
        //                 }
        //             }
        //             var spannum = document.getElementsByTagName("span")[1].innerHTML;
        //             var spanmynum = spannum - 0;
        //             var num = 0;
        //             while(num < 322) {
        //                 setTimeout("document.getElementsByTagName('span')[1].innerHTML = "+num, num*5);
        //                 num++;
        //             }

        //         }

        //打印斜线
        //        void function () {
        //            var arr = [], T$ = function (id) { return document.getElementById(id); },
        //                fx = function (t, b, c, d) { return c * t / d + b; };//i 0 100 200
        //            for (var i = 0; i < 200; i++) {
        //                arr.push('<div style="width:2px;height:2px;font-size:0;background-color:#FF0066;position:absolute;left:' + (i - 1+50) + 'px;top:' + (Math.ceil(fx(i, 50, 100, 200))+50) + 'px"><\/div>');
        //            }
        //            T$('chart').innerHTML = arr.join(''); //字符串的形式输出
        //           
        //        } ();
    </script>
</asp:Content>
