<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Community.aspx.cs"
    Inherits="TTG.Web.Community" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>小区信息</title>
    <link href="Css/Main.css" rel="stylesheet" type="text/css" />
    <link href="Css/common.css" rel="stylesheet" type="text/css" />
    <script src="JS/laydate.js" type="text/javascript"></script>
    <script src="echarts-2.2.7/build/dist/echarts.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="container">
        <div class="section">
            <!-- 头部-->
            <div class="comHeaderTop">
                <p class="fl">
                    编号：<asp:Label ID="LabelCommunityId" runat="server"></asp:Label>
                </p>
                <p class="fr">
                    数据更新日期：<asp:Label ID="LabelLastModify" runat="server"></asp:Label>
                </p>
            </div>
            <div class="comHeaderMid">
                <p>
                    <asp:Label ID="LabelProvince" runat="server"></asp:Label>
                    <asp:Label ID="LabelCounty" runat="server"></asp:Label>
                    <asp:Label ID="LabelCommunity" runat="server"></asp:Label>
                </p>
            </div>
            <!--导航栏-->
            <ul class="comNav">
                <li id="project1" class="comLiOn">
                    <p>
                        首页
                    </p>
                </li>
                <li id="project2">
                    <p>
                        房屋居住安全
                    </p>
                </li>
                <li id="project3">
                    <p>
                        基础设施
                    </p>
                </li>
                <li id="project4">
                    <p>
                        环保设施
                    </p>
                </li>
                <li id="project5">
                    <p>
                        公共服务设施
                    </p>
                </li>
                <li id="project6">
                    <p>
                        就业与创业扶持
                    </p>
                </li>
                <li id="project7">
                    <p>
                        帮扶项目清单
                    </p>
                </li>
                <li id="project8">
                    <p>
                        <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                                <asp:Button ID="DefaultEchartBtn" runat="server" Text="指标对比" OnClick="s_Click" CssClass="hideBtn" />
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </p>
                </li>
                <li style="width: 108px;" id="project9">
                    <p>
                        <a id="GisUrl" runat="server" target="_blank">GIS</a>
                    </p>
                </li>
            </ul>
            <!--主要信息 显示区域-->
            <div class="pr clearfix">
                <!--id为comContent1的显示基本情况-->
                <div class="dn" id="comContent1" style="display: block;">
                    <div class="mt20  clearfix">
                        <div class="fl">
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <div class="comBase">
                                        <div>
                                            <asp:Image ID="ImageTitle" runat="server" Style="width: 480px;" />
                                        </div>
                                        <div>
                                            <div class="comInfo">
                                                <div class="comInfoTitle">
                                                    <div id="comInfoTitle1" style="background-color: #fff;">
                                                        <span>小区区位特色</span>
                                                    </div>
                                                    <div id="comInfoTitle2">
                                                        <span>小区存在的主要问题及解决程度描述</span>
                                                    </div>
                                                </div>
                                                <div class="comInfoContent">
                                                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label ID="LabelPositionAdvantage" runat="server"></asp:Label>
                                                </div>
                                                <div class="comInfoContent dn">
                                                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label ID="LabelMainProblemSolution"
                                                        runat="server"></asp:Label></div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="comBase">
                                        <table>
                                            <tr>
                                                <td class="td1">
                                                    小区类型
                                                </td>
                                                <td colspan="2" class="td2" style="border-right: none;">
                                                    <asp:Label ID="LabelCommunityType" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="td1">
                                                    建设年份
                                                </td>
                                                <td colspan="2" class="td2" style="border-right: none;">
                                                    <asp:Label ID="LabelConstructYear" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="td1">
                                                    居民户籍人口
                                                </td>
                                                <td class="td2">
                                                    总户数<asp:Label ID="LabelRegFamilyNum" runat="server"></asp:Label>户
                                                </td>
                                                <td class="td3">
                                                    总人数<asp:Label ID="LabelRegPeopleNum" runat="server"></asp:Label>人
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="td1">
                                                    其中移民
                                                </td>
                                                <td class="td2">
                                                    户数<asp:Label ID="LabelImmigrantFamilyNum" runat="server"></asp:Label>户
                                                </td>
                                                <td class="td3">
                                                    人数<asp:Label ID="LabelImmigrantPeopleNum" runat="server"></asp:Label>人
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="td1">
                                                    建筑面积
                                                </td>
                                                <td class="td2">
                                                    <asp:Label ID="LabelConstructionArea" runat="server"></asp:Label>
                                                </td>
                                                <td class="td3">
                                                    万㎡
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="td1">
                                                    占地面积
                                                </td>
                                                <td class="td2">
                                                    <asp:Label ID="LabelFloorArea" runat="server"></asp:Label>
                                                </td>
                                                <td class="td3">
                                                    万㎡
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="td1">
                                                    人均住房面积
                                                </td>
                                                <td class="td2">
                                                    <asp:Label ID="LabelAverageHouseArea" runat="server"></asp:Label>
                                                </td>
                                                <td class="td3">
                                                    ㎡
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="td1">
                                                    容积率
                                                </td>
                                                <td class="td2">
                                                    <asp:Label ID="LabelPlotRatio" runat="server"></asp:Label>
                                                </td>
                                                <td class="td3">
                                                    %
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="td1">
                                                    绿地率
                                                </td>
                                                <td class="td2">
                                                    <asp:Label ID="LabelGreenRate" runat="server"></asp:Label>
                                                </td>
                                                <td class="td3">
                                                    %
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="td1">
                                                    停车位
                                                </td>
                                                <td class="td2">
                                                    <asp:Label ID="LabelParkingLot" runat="server"></asp:Label>
                                                </td>
                                                <td class="td3">
                                                    个
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="td1">
                                                    门面数
                                                </td>
                                                <td class="td2">
                                                    <asp:Label ID="LabelFacade" runat="server"></asp:Label>
                                                </td>
                                                <td class="td3">
                                                    个
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="td1">
                                                    <asp:Image ID="Image1" runat="server" ImageUrl="Images/diagram_1.png" CssClass="tableimg" />
                                                    <input id="door_rateBtn" type="button" value="门面使用率" class="tableBtn" />
                                                </td>
                                                <td class="td2">
                                                    <asp:Label ID="LabelFacadeUseRate" runat="server"></asp:Label>
                                                </td>
                                                <td class="td3">
                                                    %
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="td1">
                                                    <asp:Image ID="Image2" runat="server" ImageUrl="Images/diagram_1.png" CssClass="tableimg" />
                                                    <input id="laborBtn" type="button" value="劳动力就业率" class="tableBtn" />
                                                </td>
                                                <td class="td2">
                                                    <asp:Label ID="LabelEmploymentRate" runat="server"></asp:Label>
                                                </td>
                                                <td class="td3">
                                                    %
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="td1">
                                                    <asp:Image ID="Image3" runat="server" ImageUrl="Images/diagram_1.png" CssClass="tableimg" />
                                                    <input id="incomeBtn" type="button" value="人均可支配收入" class="tableBtn" />
                                                </td>
                                                <td class="td2">
                                                    <asp:Label ID="LabelDisposableIncome" runat="server"></asp:Label>
                                                </td>
                                                <td class="td3">
                                                    元
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="td1">
                                                    <asp:Image ID="Image4" runat="server" ImageUrl="Images/diagram_1.png" CssClass="tableimg" />
                                                    <input id="rentBtn" type="button" value="房屋租金平均水平" class="tableBtn" />
                                                </td>
                                                <td class="td2">
                                                    <asp:Label ID="LabelAverageRent" runat="server"></asp:Label>
                                                </td>
                                                <td class="td3">
                                                    元/㎡/月
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="td1">
                                                    低保人口比例
                                                </td>
                                                <td class="td2">
                                                    <asp:Label ID="LabelPoorRate" runat="server"></asp:Label>
                                                </td>
                                                <td class="td3">
                                                    %
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                        <div class="mt20 fl">
                            <table class="count">
                                <tr>
                                    <td colspan="2" style="border-left: none;">
                                        2011～2013年专项资金项目
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelProjectNum2013" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td>
                                        个
                                    </td>
                                    <td colspan="2">
                                        2011～2013年专项资金项目完工比例
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelProjectComRate2013" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        %
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" style="border-left: none;">
                                        2014年后专项资金项目
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelProjectNum2014" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td>
                                        个
                                    </td>
                                    <td colspan="2">
                                        2014年后专项资金项目单项工程完工比例
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelProjectComRate2014" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td style="border-right: none;">
                                        %
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-left: none;">
                                        累计专项资金下达
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelFoundsDown" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        万元
                                    </td>
                                    <td>
                                        累计专项资金完成
                                    </td>
                                    <td>
                                        <asp:Label ID="LabelFoundsCom" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        万元
                                    </td>
                                    <td>
                                        专项资金完成比例
                                    </td>
                                    <td style="border-right: none;">
                                        <asp:Label ID="LabelFoundsRate" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                            <div class="comEchart">
                                <div style="width: 580px; height: 400px;" id="main_viltotal_capital">
                                </div>
                                <div style="width: 520px; height: 50px; margin-top: -30px;">
                                    <table class="comEchartTable">
                                        <tr>
                                            <td style="width: 58px;">
                                                待建
                                            </td>
                                            <td>
                                                <asp:Label ID="LabelBeforeCons2013" runat="server" Text="Label"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="LabelBeforeCons2014" runat="server" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 58px;">
                                                在建
                                            </td>
                                            <td>
                                                <asp:Label ID="LabelInCons2013" runat="server" Text="Label"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="LabelInCons2014" runat="server" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 58px;">
                                                完建
                                            </td>
                                            <td>
                                                <asp:Label ID="LabelComCons2013" runat="server" Text="Label"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="LabelComCons2014" runat="server" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <p>
                                    专项资金项目进展情况
                                </p>
                            </div>
                            <div class="comEchartMid">
                            </div>
                            <div class="comEchart" style="margin-left: 0px">
                                <div style="width: 580px; height: 400px;" id="main_viltotal_type">
                                </div>
                                <div style="width: 520px; height: 50px; margin-top: -30px;">
                                    <table class="comEchartTable td100">
                                        <tr>
                                            <td style="width: 58px;">
                                                计划投资
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
                                            <td style="width: 58px;">
                                                完成
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
                                <p>
                                    按类别结构划分的投资计划及完成情况
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class="mt20 fl">
                        <table class="footTable">
                            <tr>
                                <td class="td1">
                                    小区地址
                                </td>
                                <td class="td2" colspan="4" style="border-right: none;">
                                    <asp:Label ID="LabelAddress" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="td1">
                                    小区管理
                                </td>
                                <td class="td2">
                                    负责人:<asp:Label ID="LabelManaChargeName" runat="server"></asp:Label>
                                </td>
                                <td class="td3">
                                    电话:<asp:Label ID="LabelManaChargePhone" runat="server"></asp:Label>
                                </td>
                                <td class="td4">
                                    联系人:
                                </td>
                                <td class="td5">
                                    电话:<asp:Label ID="LabelManaContactPhone" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr style="border-bottom: 2px solid #008000;">
                                <td class="td1">
                                    综合监测
                                </td>
                                <td class="td2">
                                    负责人:<asp:Label ID="LabelMoniChargeName" runat="server"></asp:Label>
                                </td>
                                <td class="td3">
                                    电话:
                                    <asp:Label ID="LabelMoniChargePhone" runat="server"></asp:Label>
                                </td>
                                <td class="td4">
                                    工作人员
                                </td>
                                <td class="td5">
                                    电话:<asp:Label ID="LabelMoniContactPhone" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <!--comContent1中生成折线图传值用的textbox-->
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
                    <asp:TextBox ID="TextBoxBefore" runat="server"></asp:TextBox>
                    <asp:TextBox ID="TextBoxIn" runat="server"></asp:TextBox>
                    <asp:TextBox ID="TextBoxCom" runat="server"></asp:TextBox>
                    <asp:TextBox ID="TextBoxVilPlan2" runat="server"></asp:TextBox>
                    <asp:TextBox ID="TextBoxVilFinished2" runat="server"></asp:TextBox>
                </div>
                <!--id为comContent2的显示房屋居住安全-->
                <div class="dn" id="comContent2">
                    <div class="dataTable">
                        <!--基本情况-->
                        <p>
                            基本情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td rowspan="3" class="fw" style="border-left: none;">
                                    基本情况
                                </td>
                                <td>
                                    统建房
                                </td>
                                <td colspan="3">
                                    结构安全
                                </td>
                                <td colspan="2">
                                    屋顶防渗
                                </td>
                                <td colspan="2">
                                    外墙损坏
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    边坡治理
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td>
                                    小区统建房栋数
                                </td>
                                <td>
                                    轻微变形开裂
                                </td>
                                <td>
                                    房屋地基沉降
                                </td>
                                <td>
                                    鉴定为危房
                                </td>
                                <td colspan="2">
                                    屋顶渗水房屋
                                </td>
                                <td colspan="2">
                                    外墙瓷砖脱落房屋
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    边坡未治理
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td>
                                    幢
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td colspan="2">
                                    ㎡
                                </td>
                                <td colspan="2">
                                    ㎡
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    幢
                                </td>
                            </tr>
                            <tr class="alternateDouble td8">
                                <td style="border-left: none;">
                                    2013年情况
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
                            <tr class="alternateDouble td8" style="border-bottom: 2px  solid #008000;">
                                <td style="border-left: none;">
                                    当前情况
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
                        </table>
                        <!--实施情况-->
                        <p>
                            实施情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td rowspan="3" class="fw firstDoubleTd" style="border-left: none;">
                                    实施情况
                                </td>
                                <td colspan="4">
                                    结构安全
                                </td>
                                <td colspan="2">
                                    屋顶渗漏
                                </td>
                                <td colspan="2">
                                    外墙损坏
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    边坡治理
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td colspan="2">
                                    结构安全栋数
                                </td>
                                <td colspan="2">
                                    结构安全面积
                                </td>
                                <td>
                                    屋顶防漏栋数
                                </td>
                                <td>
                                    屋顶防漏面积
                                </td>
                                <td>
                                    外墙修复栋数
                                </td>
                                <td>
                                    外墙修复面积
                                </td>
                                <td>
                                    边坡治理面积
                                </td>
                                <td style="border-right: none;">
                                    边坡治理涉及房屋居民人数
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td colspan="2">
                                    幢
                                </td>
                                <td colspan="2">
                                    ㎡
                                </td>
                                <td>
                                    幢
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    幢
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td style="border-right: none;">
                                    人
                                </td>
                            </tr>
                            <tr class="alternateDouble td9">
                                <td style="border-left: none;" class="firstDoubleTd">
                                    计划
                                </td>
                                <td colspan="2">
                                    <asp:Label ID="LabelStructSafeNumPlan" runat="server"></asp:Label>
                                </td>
                                <td colspan="2">
                                    <asp:Label ID="LabelStructSafeAreaPlan" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelLeakProofNumPlan" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelLeakProofAreaPlan" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelRepairWallNumPlan" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelRepairWallAreaPlan" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelSlopeDealPlan" runat="server"></asp:Label>
                                </td>
                                <td style="border-right: none;">
                                    <asp:Label ID="LabelSlopePeopleNumPlan" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr class="alternateDouble td9" style="border-bottom: 2px solid #008000;">
                                <td style="border-left: none;" class="firstDoubleTd">
                                    <a href="ReadOnlyExcel.aspx?Pro=<%=com_province%>&Cou=<%=com_county%>&officeFile=2014及以后专项资金项目.xlsx">
                                        完成</a>
                                </td>
                                <td colspan="2">
                                    <asp:Label ID="LabelStructSafeNumCom" runat="server"></asp:Label>
                                </td>
                                <td colspan="2">
                                    <asp:Label ID="LabelStructSafeAreaCom" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelLeakProofNumCom" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelLeakProofAreaCom" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelRepairWallNumCom" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelRepairWallAreaCom" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelSlopeDealCom" runat="server"></asp:Label>
                                </td>
                                <td style="border-right: none;">
                                    <asp:Label ID="LabelSlopePeopleNumCom" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                        <!--目标实现情况-->
                        <p>
                            目标实现情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td class="fw" style="border-left: none;">
                                    目标实现情况
                                </td>
                                <td colspan="4">
                                    结构安全完好率
                                </td>
                                <td colspan="2">
                                    屋顶完好率
                                </td>
                                <td colspan="2">
                                    房屋外墙完好率
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    边坡安全稳定程度
                                </td>
                            </tr>
                            <tr class="alternateDouble td5">
                                <td style="border-left: none">
                                    2013年情况
                                </td>
                                <td colspan="4">
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
                            <tr class="alternateDouble td5">
                                <td style="border-left: none">
                                    当前情况
                                </td>
                                <td colspan="4">
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
                <!--id为comContent3显示基础设施-->
                <div class="dn" id="comContent3">
                    <div class="dataTable">
                        <p class="tableCotent">
                            交通条件、供电条件</p>
                        <p>
                            基本情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td rowspan="3" style="border-left: none;" class="fw">
                                    基本情况
                                </td>
                                <td colspan="6">
                                    交通条件
                                </td>
                                <td colspan="6" style="border-right: none;">
                                    供电条件
                                </td>
                            </tr>
                            <!--基本情况 交通条件 供电条件-->
                            <tr class="alternateSingle">
                                <td>
                                    断头路（尽端式道路）
                                </td>
                                <td>
                                    小区内部分区域链接道路缺乏
                                </td>
                                <td>
                                    未硬化
                                </td>
                                <td>
                                    机动车道损坏面积
                                </td>
                                <td>
                                    人行道损坏面积
                                </td>
                                <td>
                                    缺乏人行道
                                </td>
                                <td colspan="2">
                                    供电量不足涉及住宅户数
                                </td>
                                <td colspan="2">
                                    小区老化和损坏供电线路长度
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    未落实“一户一表”涉及住宅户数
                                </td>
                            </tr>
                            <%-- <tr>
                                <td>
                                    机动车道
                                </td>
                                <td>
                                    人行道
                                </td>
                            </tr>--%>
                            <tr class="alternateSingle">
                                <td>
                                    条
                                </td>
                                <td>
                                    条
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    条
                                </td>
                                <td colspan="2">
                                    户
                                </td>
                                <td colspan="2">
                                    km
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    户
                                </td>
                            </tr>
                            <tr class="alternateDouble td10">
                                <td style="border-left: none;">
                                    2013年情况
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
                            <tr class="alternateDouble td10" style="border-bottom: 2px solid #008000;">
                                <td style="border-left: none;">
                                    当前情况
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
                        </table>
                        <p>
                            实施情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td style="border-left: none;" rowspan="3" class="fw firstDoubleTd">
                                    实施情况
                                </td>
                                <td colspan="6">
                                    交通条件
                                </td>
                                <td colspan="6" style="border-right: none;">
                                    供电条件
                                </td>
                            </tr>
                            <!--实施情况 交通条件 供电条件-->
                            <tr class="alternateSingle">
                                <td>
                                    新增连接路数量
                                </td>
                                <td>
                                    新建机动车道面积
                                </td>
                                <td>
                                    硬化机动车道面积
                                </td>
                                <td>
                                    维修改造机动车道面积
                                </td>
                                <td>
                                    人行道地砖改造面积
                                </td>
                                <td>
                                    新增人行道
                                </td>
                                <td>
                                    新增变压器后增容
                                </td>
                                <td>
                                    更换变压器后增容
                                </td>
                                <td>
                                    变压器安装改造
                                </td>
                                <td>
                                    新建配电线路
                                </td>
                                <td>
                                    维修改造配电线路
                                </td>
                                <td style="border-right: none;">
                                    电表安装
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td>
                                    条
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    KVA
                                </td>
                                <td>
                                    KVA
                                </td>
                                <td>
                                    台
                                </td>
                                <td>
                                    km
                                </td>
                                <td>
                                    km
                                </td>
                                <td style="border-right: none;">
                                    户
                                </td>
                            </tr>
                            <tr class="alternateDouble td13">
                                <td style="border-left: none;" class="firstDoubleTd">
                                    计划
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
                            <tr class="alternateDouble td13" style="border-bottom: 2px solid #008000;">
                                <td style="border-left: none;" class="firstDoubleTd">
                                    <a href="ReadOnlyExcel.aspx?Pro=<%=com_province%>&Cou=<%=com_county%>&officeFile=2014及以后专项资金项目.xlsx">
                                        完成</a>
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
                        </table>
                        <p>
                            目标实现情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td style="border-left: none;" class="fw">
                                    目标实现情况
                                </td>
                                <td colspan="3">
                                    道路通达程度
                                </td>
                                <td colspan="3">
                                    道路通畅程度
                                </td>
                                <td colspan="2">
                                    供电容量保障率
                                </td>
                                <td colspan="2">
                                    供电线路安全程度
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    供电一户一表实现率
                                </td>
                            </tr>
                            <!--目标实现情况 交通条件 供电条件-->
                            <tr class="alternateDouble td6">
                                <td style="border-left: none;">
                                    2013年情况
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
                            <tr class="alternateDouble td6" style="border-bottom: 2px solid #008000;">
                                <td style="border-left: none;">
                                    当前情况
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
                        <p class="tableCotent">
                            供水条件、公共照明、消防</p>
                        <p>
                            基本情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td rowspan="3" style="border-left: none;" class="fw firstDoubleTd">
                                    基本情况
                                </td>
                                <td colspan="5">
                                    供水条件
                                </td>
                                <td colspan="4">
                                    公共照明
                                </td>
                                <td colspan="3" style="border-right: none;">
                                    消防
                                </td>
                            </tr>
                            <!--基本情况 供水条件 公共照明 消防-->
                            <tr class="alternateSingle">
                                <td>
                                    供水量不足涉及住宅户数
                                </td>
                                <td>
                                    供水压力不足涉及住宅户数
                                </td>
                                <td colspan="2">
                                    小区供水管道损坏长度
                                </td>
                                <td>
                                    未落实"一户一表"涉及住宅
                                </td>
                                <td>
                                    无路灯的路段数量
                                </td>
                                <td>
                                    路灯数量少、照明不足的路段数量
                                </td>
                                <td colspan="2">
                                    小区楼道照明损坏涉及户数
                                </td>
                                <td>
                                    室外消火栓数量不足涉及路段
                                </td>
                                <td>
                                    室内消火栓不足涉及建筑数量
                                </td>
                                <td style="border-right: none;">
                                    消防通道不达标长度
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td>
                                    户
                                </td>
                                <td>
                                    户
                                </td>
                                <td colspan="2">
                                    km
                                </td>
                                <td>
                                    户
                                </td>
                                <td>
                                    km
                                </td>
                                <td>
                                    km
                                </td>
                                <td colspan="2">
                                    户
                                </td>
                                <td>
                                    km
                                </td>
                                <td>
                                    幢
                                </td>
                                <td style="border-right: none;">
                                    km
                                </td>
                            </tr>
                            <tr class="alternateDouble td11">
                                <td style="border-left: none;" class="firstDoubleTd">
                                    2013年情况
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
                            <tr class="alternateDouble td11" style="border-bottom: 2px solid #008000;">
                                <td style="border-left: none;" class="firstDoubleTd">
                                    当前情况
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
                        </table>
                        <p>
                            实施情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td style="border-left: none;" rowspan="3" class="fw">
                                    实施情况
                                </td>
                                <td colspan="5">
                                    供水条件
                                </td>
                                <td colspan="4">
                                    公共照明
                                </td>
                                <td colspan="3" style="border-right: none;">
                                    消防
                                </td>
                            </tr>
                            <!--实施情况 供水条件 公共照明 消防-->
                            <tr class="alternateSingle">
                                <td>
                                    新增供水容量
                                </td>
                                <td>
                                    新增供水增压设施
                                </td>
                                <td>
                                    新建供水管长度
                                </td>
                                <td>
                                    维修改造供水管长度
                                </td>
                                <td>
                                    水表安装
                                </td>
                                <td>
                                    新增室外照明覆盖路段
                                </td>
                                <td>
                                    修复室外照明覆盖路段
                                </td>
                                <td>
                                    新增楼栋照明设施数量
                                </td>
                                <td>
                                    修复楼栋照明设施数量
                                </td>
                                <td>
                                    新增室外消防设施数量
                                </td>
                                <td>
                                    新增室内消防设施数量
                                </td>
                                <td style="border-right: none;">
                                    消防通道改造
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td>
                                    t/d
                                </td>
                                <td>
                                    处
                                </td>
                                <td>
                                    km
                                </td>
                                <td>
                                    km
                                </td>
                                <td>
                                    户
                                </td>
                                <td>
                                    km
                                </td>
                                <td>
                                    km
                                </td>
                                <td>
                                    盏
                                </td>
                                <td>
                                    盏
                                </td>
                                <td>
                                    套
                                </td>
                                <td>
                                    套
                                </td>
                                <td style="border-right: none;">
                                    m
                                </td>
                            </tr>
                            <tr class="alternateDouble td13">
                                <td style="border-left: none;">
                                    计划
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
                            <tr class="alternateDouble td13" style="border-bottom: 2px solid #008000;">
                                <td style="border-left: none;">
                                    <a href="ReadOnlyExcel.aspx?Pro=<%=com_province%>&Cou=<%=com_county%>&officeFile=2014及以后专项资金项目.xlsx">
                                        完成</a>
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
                        </table>
                        <p>
                            目标实现情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td style="border-left: none;" class="fw firstDoubleTd">
                                    目标实现情况
                                </td>
                                <td colspan="2">
                                    供水能力保障程度
                                </td>
                                <td colspan="2">
                                    供水管网完善程度
                                </td>
                                <td>
                                    供水一户一表实现率
                                </td>
                                <td colspan="2">
                                    室外公共照明达标率
                                </td>
                                <td colspan="2">
                                    室内公共照明达标率
                                </td>
                                <td>
                                    室外消防设施达标率
                                </td>
                                <td>
                                    室内消防设施达标率
                                </td>
                                <td style="border-right: none;">
                                    消防通道达标率
                                </td>
                            </tr>
                            <!--目标实现情况 供水条件 公共照明 消防-->
                            <tr class="alternateDouble td9">
                                <td style="border-left: none;" class="firstDoubleTd">
                                    2013年情况
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
                            <tr class="alternateDouble td9" style="border-bottom: 2px solid #008000;">
                                <td style="border-left: none;" class="firstDoubleTd">
                                    当前情况
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
                <!--id为comContent4显示环保设施-->
                <div class="dn" id="comContent4">
                    <div class="dataTable">
                        <p>
                            基本情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td rowspan="3" style="border-left: none;" class="fw">
                                    基本情况
                                </td>
                                <td colspan="5">
                                    环卫设施
                                </td>
                                <td colspan="7">
                                    排污和排水
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    绿化
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td>
                                    路边垃圾箱不足涉及路段
                                </td>
                                <td>
                                    住宅区垃圾箱不足涉及区域
                                </td>
                                <td>
                                    区域环卫设施不足
                                </td>
                                <td colspan="2">
                                    公厕数量不足涉及区域
                                </td>
                                <td>
                                    未接入城市污水管网的住宅
                                </td>
                                <td>
                                    生活污水直排溪沟、长江处数
                                </td>
                                <td colspan="2">
                                    小区排水管损坏长度
                                </td>
                                <td>
                                    排（洪）水沟损坏
                                </td>
                                <td colspan="2">
                                    排（洪）水沟不足
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    小区绿地面积
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td>
                                    条
                                </td>
                                <td>
                                    处
                                </td>
                                <td>
                                    处
                                </td>
                                <td colspan="2">
                                    处
                                </td>
                                <td>
                                    户
                                </td>
                                <td>
                                    处
                                </td>
                                <td colspan="2">
                                    km
                                </td>
                                <td>
                                    km
                                </td>
                                <td colspan="2">
                                    V
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    ㎡
                                </td>
                            </tr>
                            <tr class="alternateDouble td11">
                                <td style="border-left: none;">
                                    2013年情况
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
                            <tr class="alternateDouble td11" style="border-bottom: 2px solid #008000;">
                                <td style="border-left: none;">
                                    当前情况
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
                        </table>
                        <p>
                            实施情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td rowspan="3" style="border-left: none;" class="fw firstDoubleTd">
                                    实施情况
                                </td>
                                <td colspan="5">
                                    环卫设施
                                </td>
                                <td colspan="7">
                                    排污和排水
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    绿化
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td>
                                    新增垃圾桶数量
                                </td>
                                <td>
                                    新增垃圾中转站数量
                                </td>
                                <td>
                                    维修改造垃圾中转站数量
                                </td>
                                <td>
                                    新增公厕
                                </td>
                                <td>
                                    维修改造公厕
                                </td>
                                <td>
                                    维修改造污水管网长度
                                </td>
                                <td>
                                    新建污水管网长度
                                </td>
                                <td>
                                    新建排水管长度
                                </td>
                                <td>
                                    维修改造排水管长度
                                </td>
                                <td>
                                    新建排（洪）水沟长度
                                </td>
                                <td>
                                    维修改造拍（洪）水沟长度
                                </td>
                                <td>
                                    新建化粪池数量
                                </td>
                                <td>
                                    新增绿化面积
                                </td>
                                <td style="border-right: none;">
                                    植树
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td>
                                    个
                                </td>
                                <td>
                                    个
                                </td>
                                <td>
                                    个
                                </td>
                                <td>
                                    个
                                </td>
                                <td>
                                    个
                                </td>
                                <td>
                                    km
                                </td>
                                <td>
                                    km
                                </td>
                                <td>
                                    km
                                </td>
                                <td>
                                    km
                                </td>
                                <td>
                                    km
                                </td>
                                <td>
                                    km
                                </td>
                                <td>
                                    个
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td style="border-right: none;">
                                    株
                                </td>
                            </tr>
                            <tr class="alternateDouble td15">
                                <td style="border-left: none;" class="firstDoubleTd">
                                    计划
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
                            <tr class="alternateDouble td15" style="border-bottom: 2px solid #008000;">
                                <td style="border-left: none;" class="firstDoubleTd">
                                    <a href="ReadOnlyExcel.aspx?Pro=<%=com_province%>&Cou=<%=com_county%>&officeFile=2014及以后专项资金项目.xlsx">
                                        完成</a>
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
                        </table>
                        <p>
                            目标实现情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td style="border-left: none;" class="fw">
                                    目标实现情况
                                </td>
                                <td colspan="3">
                                    垃圾收集能力达标率
                                </td>
                                <td colspan="2">
                                    公共厕所覆盖程度
                                </td>
                                <td colspan="2">
                                    生活污水收集能力达标率
                                </td>
                                <td colspan="5">
                                    排水安全保障程度
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    小区绿化率
                                </td>
                            </tr>
                            <tr class="alternateDouble td6">
                                <td style="border-left: none;">
                                    2013年情况
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
                            <tr class="alternateDouble td6">
                                <td style="border-left: none;">
                                    当前情况
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
                <!--id为comContent5显示公共服务设施-->
                <div class="dn" id="comContent5">
                    <div class="dataTable">
                        <p>
                            基本情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td rowspan="3" style="border-left: none;" class="fw">
                                    基本情况
                                </td>
                                <td colspan="4">
                                    教育
                                </td>
                                <td colspan="3">
                                    医疗
                                </td>
                                <td colspan="4">
                                    文体设施
                                </td>
                                <td colspan="2">
                                    社区服务
                                </td>
                                <td>
                                    停车
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    商业服务
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td colspan="2">
                                    幼儿园容量
                                </td>
                                <td>
                                    教学面积
                                </td>
                                <td>
                                    室外活动面积
                                </td>
                                <td colspan="2">
                                    小区卫生室面积
                                </td>
                                <td>
                                    小区卫生室床位数
                                </td>
                                <td colspan="2">
                                    室外活动场地面积
                                </td>
                                <td>
                                    室内活动场地面积
                                </td>
                                <td>
                                    健身器材
                                </td>
                                <td>
                                    养老院面积
                                </td>
                                <td>
                                    社区综合管理用房面积
                                </td>
                                <td>
                                    停车场面积
                                </td>
                                <td>
                                    农贸市场面积
                                </td>
                                <td style="border-right: none;">
                                    便民超市面积
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td colspan="2">
                                    人
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td colspan="2">
                                    ㎡
                                </td>
                                <td>
                                    张
                                </td>
                                <td colspan="2">
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    套
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td style="border-right: none;">
                                    ㎡
                                </td>
                            </tr>
                            <tr class="alternateDouble td14">
                                <td style="border-left: none;">
                                    2013年情况
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
                            <tr class="alternateDouble td14" style="border-bottom: 2px solid #008000;">
                                <td style="border-left: none;">
                                    当前情况
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
                        </table>
                        <p>
                            实施情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td rowspan="3" style="border-left: none;" class="fw firstDoubleTd">
                                    实施情况
                                </td>
                                <td colspan="4">
                                    教育
                                </td>
                                <td colspan="3">
                                    医疗
                                </td>
                                <td colspan="4">
                                    文体设施
                                </td>
                                <td colspan="2">
                                    社区服务
                                </td>
                                <td>
                                    停车
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    商业服务
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td>
                                    新增幼儿园容量
                                </td>
                                <td>
                                    改扩建幼儿园容量
                                </td>
                                <td>
                                    新增教学面积
                                </td>
                                <td>
                                    新增幼儿园活动场地
                                </td>
                                <td>
                                    新增卫生室面积
                                </td>
                                <td>
                                    维修改造卫生室面积
                                </td>
                                <td>
                                    新增卫生室床位数
                                </td>
                                <td>
                                    新增室外活动场地面积
                                </td>
                                <td>
                                    改造室外活动场地面积
                                </td>
                                <td>
                                    新增建设室内活动场所面积
                                </td>
                                <td>
                                    新增健身器材
                                </td>
                                <td>
                                    新增养老设施面积
                                </td>
                                <%--  <td>
                                    维修改造养老设施面积
                                </td>--%>
                                <td>
                                    新增社区综合管理用房
                                </td>
                                <td>
                                    新增停车场面积
                                </td>
                                <td>
                                    新增农贸市场面积
                                </td>
                                <td style="border-right: none;">
                                    新增便民超市面积
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td>
                                    人
                                </td>
                                <td>
                                    人
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    个
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    套
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td style="border-right: none;">
                                    ㎡
                                </td>
                            </tr>
                            <tr class="alternateDouble td17">
                                <td style="border-left: none;" class="firstDoubleTd">
                                    计划
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
                            <tr class="alternateDouble td17" style="border-bottom: 2px solid #008000;">
                                <td style="border-left: none;" class="firstDoubleTd">
                                    <a href="ReadOnlyExcel.aspx?Pro=<%=com_province%>&Cou=<%=com_county%>&officeFile=2014及以后专项资金项目.xlsx">
                                        完成</a>
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
                        </table>
                        <p>
                            目标实现情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td style="border-left: none;" class="fw">
                                    目标实现情况
                                </td>
                                <td colspan="4">
                                    幼儿园配置达标率
                                </td>
                                <td colspan="3">
                                    社区医疗配置达标率
                                </td>
                                <td colspan="4">
                                    文化健身设施配置达标率
                                </td>
                                <td>
                                    养老设施配置达标率
                                </td>
                                <td>
                                    综合管理用房配置达标率
                                </td>
                                <td>
                                    停车设施配置达标率
                                </td>
                                <td>
                                    菜市场配置达标率
                                </td>
                                <td style="border-right: none;">
                                    便民店配置达标率
                                </td>
                            </tr>
                            <tr class="alternateDouble td9">
                                <td style="border-left: none;">
                                    2013年情况
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
                            <tr class="alternateDouble td9">
                                <td style="border-left: none;">
                                    当前情况
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
                <!--id为comContent6显示就业与创业扶持-->
                <div class="dn" id="comContent6">
                    <div class="dataTable">
                        <p>
                            基本情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td rowspan="3" style="border-left: none;" class="fw">
                                    基本情况
                                </td>
                                <td colspan="3">
                                    门面改造
                                </td>
                                <td colspan="2">
                                    街区改造
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    专业市场
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td>
                                    小区门面数
                                </td>
                                <td>
                                    出租经营门面数
                                </td>
                                <td>
                                    门面平均出租租金
                                </td>
                                <td colspan="2">
                                    街区风貌较差
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    缺乏专业市场
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td>
                                    个
                                </td>
                                <td>
                                    个
                                </td>
                                <td>
                                    元/㎡/年
                                </td>
                                <td colspan="2">
                                    v
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    v
                                </td>
                            </tr>
                            <tr class="alternateDouble td6">
                                <td style="border-left: none;">
                                    本底
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
                            <tr class="alternateDouble td6" style="border-bottom: 2px solid #008000;">
                                <td style="border-left: none;">
                                    当前情况
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
                        </table>
                        <p>
                            实施情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td rowspan="3" style="border-left: none;" class="fw firstDoubleTd">
                                    实施情况
                                </td>
                                <td colspan="3">
                                    门面改造
                                </td>
                                <td colspan="2">
                                    街区改造
                                </td>
                                <td colspan="2" style="border-right: none;">
                                    专业市场建设
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td colspan="2">
                                    改造门面数量
                                </td>
                                <td>
                                    改造门面面积
                                </td>
                                <td>
                                    改造街区长度
                                </td>
                                <td>
                                    改造外立面
                                </td>
                                <td>
                                    建设市场面积
                                </td>
                                <td style="border-right: none;">
                                    涉及商户数量
                                </td>
                            </tr>
                            <tr class="alternateSingle">
                                <td colspan="2">
                                    个
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    km
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td>
                                    ㎡
                                </td>
                                <td style="border-right: none;">
                                    个
                                </td>
                            </tr>
                            <tr class="alternateDouble td7">
                                <td style="border-left: none;" class="firstDoubleTd">
                                    计划
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
                            <tr class="alternateDouble td7" style="border-bottom: 2px solid #008000;">
                                <td style="border-left: none;" class="firstDoubleTd">
                                    <a href="ReadOnlyExcel.aspx?Pro=<%=com_province%>&Cou=<%=com_county%>&officeFile=2014及以后专项资金项目.xlsx">
                                        完成</a>
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
                        </table>
                        <p>
                            目标实现情况</p>
                        <table class="comData">
                            <tr class="impIndex">
                                <td style="border-left: none;" class="fw">
                                    目标实现情况
                                </td>
                                <td colspan="3">
                                    门面利用率
                                </td>
                                <td colspan="4" style="border-right: none;">
                                    门面租金水平
                                </td>
                            </tr>
                            <tr class="alternateDouble td3">
                                <td style="border-left: none;">
                                    本底
                                </td>
                                <td colspan="3">
                                    <asp:Label ID="LabelFacadeUseRate2013" runat="server"></asp:Label>
                                </td>
                                <td colspan="4" style="border-right: none;">
                                    <asp:Label ID="LabelFacadeUseRateNow" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr class="alternateDouble td3">
                                <td style="border-left: none;">
                                    现状
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
                <!--id为comContent7显示帮扶项目清单-->
                <div class="dn" id="comContent7">
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="dataTable">
                                <asp:Repeater ID="Repeater1" runat="server">
                                    <HeaderTemplate>
                                        <table class="comData">
                                            <tr class="impIndex">
                                                <td class="title" style="border-left: none;">
                                                    序号
                                                </td>
                                                <td class="title">
                                                    批复项目名称
                                                </td>
                                                <td class="title">
                                                    单项工程
                                                </td>
                                                <%--<td class="title">
                                                    工程项目
                                                </td>--%>
                                                <td class="title">
                                                    建设状态
                                                </td>
                                                <%-- <td class="title">
                                                    主要建设内容
                                                </td>--%>
                                                <td class="title">
                                                    开工日期
                                                </td>
                                                <td class="title">
                                                    完工日期
                                                </td>
                                                <td class="title">
                                                    项目投资（万元）
                                                </td>
                                                <td class="title" style="border-right: none;">
                                                    功能辐射型项目
                                                </td>
                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td class="title" style="border-left: none;">
                                                <a href="ReadOnlyExcel.aspx?Pro=<%=com_province%>&Cou=<%=com_county%>&officeFile=<%# Eval("Excel_name")%>"
                                                    target="_blank">
                                                    <%# Eval("project_id")%></a>
                                            </td>
                                            <td class="title">
                                                <%# Eval("project_name")%>
                                            </td>
                                            <td class="title">
                                                <%# Eval("child_name")%>
                                            </td>
                                            <td class="title">
                                                <%# Eval("construct_state")%>
                                            </td>
                                            <td class="title">
                                                <%# fdate(Eval("start_time").ToString())%>
                                            </td>
                                            <td class="title">
                                                <%# fdate(Eval("finish_time").ToString())%>
                                            </td>
                                            <td class="title">
                                                <%# Eval("project_inves")%>
                                            </td>
                                            <td class="title" style="border-right: none;">
                                                <%# Eval("is_indirect")%>
                                            </td>
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
                <!--id为comContent8显示指标对比页面-->
                <div class="dn" id="comContent8">
                    <div class="indicatorTime">
                        <span>请选择一段时间查看指标变化：</span>
                        <div class="laydate-icon fl" id="start">
                        </div>
                        <span style="margin-left: 20px">到</span>
                        <div class="laydate-icon fl" id="end">
                        </div>
                        <br />
                        <br />
                        <span>请选择某个时间查看相关指标： </span>
                        <input class="laydate-icon" id="demo" />
                    </div>
                    <div class="selectindicator">
                        <div class="incaterTab" id="ctnerTab">
                            <a class="on">房屋居住安全</a> <a>基础设施</a> <a>环保设施</a> <a>公共服务设施</a> <a>就业与创业扶持</a>
                        </div>
                        <div id="choice1">
                            <div class="navArea" style="width: 640px;">
                                <ul>
                                    <li><a title="" class="secondTree" id="Structure_safe_good_rate">结构安全完好率<i></i></a></li>
                                    <li><a title="" class="secondTree" id="Roof_good_rate">屋顶完好率 <i></i></a></li>
                                    <li><a title="" class="secondTree" id="Wall_good_rate">房屋外墙完好率 <i></i></a></li>
                                    <li><a title="" class="secondTree" id="Slope_safe_rate">边坡安全稳定程度 <i></i></a></li>
                                </ul>
                            </div>
                        </div>
                        <div class="dn" id="choice2">
                            <div class="navArea" style="width: 800px;">
                                <div class="fl choiceSize">
                                    <ul>
                                        <li><a class="secondTree" title="" id="Water_supply_validate">供水条件 <i></i></a></li>
                                        <li><a title="" class="thirdTree" style="font-size: 11px;" id="Water_capcity_degree">
                                            供水能力保障程度 <i></i></a></li>
                                        <li><a title="" class="thirdTree" id="One_hou_one_water_meter_rate">供水一户一表实现率 <i></i>
                                        </a></li>
                                        <li><a title="" class="thirdTree" id="Water_pipe_net_good_degree">供水管网完善 <i></i></a>
                                        </li>
                                    </ul>
                                </div>
                                <div class="fl choiceSize">
                                    <ul>
                                        <li><a title="" class="secondTree" id="Ff_validate">消防条件 <i></i></a></li>
                                        <li><a title="" class="thirdTree" id="Outdoors_ff_good_rate">室外消防设施达标率 <i></i></a>
                                        </li>
                                        <li><a title="" class="thirdTree" id="Indoors_ff_good_rate">室内消防设施达标率 <i></i></a>
                                        </li>
                                        <li><a title="" class="thirdTree" id="Ff_way_good_rate">消防通道达标率 <i></i></a></li>
                                    </ul>
                                </div>
                                <div class="fl choiceSize">
                                    <ul>
                                        <li><a title="" class="secondTree" id="Elec_supply_validate">供电条件 <i></i></a></li>
                                        <li><a title="" class="thirdTree" id="Elec_capcity_degree">供电一户一表实现率 <i></i></a>
                                        </li>
                                        <li><a title="" class="thirdTree" id="Elec_wire_safe_degree">供电线路安全程度 <i></i></a>
                                        </li>
                                    </ul>
                                </div>
                                <div class="fl choiceSize">
                                    <ul>
                                        <li><a title="" class="secondTree" id="Traffic_validate">交通条件 <i></i></a></li>
                                        <li><a title="" class="thirdTree" id="Road_Link_degree">道路通达程度 <i></i></a></li>
                                        <li><a title="" class="thirdTree" id="Road_good_degree">道路通畅程度 <i></i></a></li>
                                    </ul>
                                </div>
                                <div class="fl choiceSize">
                                    <ul>
                                        <li><a title="" class="secondTree" id="Light_validate">公共照明条件 <i></i></a></li>
                                        <li><a title="" class="thirdTree" id="Road_light_suff_degree">室外公共照明达标率 <i></i></a>
                                        </li>
                                        <li><a title="" class="thirdTree" id="Passway_light_suff_degree">室外公共照明达标率<i></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class="dn" id="choice3">
                            <div class="navArea" style="width: 480px;">
                                <div class="fl choiceSize">
                                    <ul>
                                        <li><a title="" class="secondTree" id="Sanitation_validate">环卫条件 <i></i></a></li>
                                        <li><a title="" class="thirdTree" id="Refuse_collect_rate">垃圾收集能力达标率 <i></i></a>
                                        </li>
                                        <li><a title="" class="thirdTree" id="Toilet_cover_degree">公共厕所覆盖程度 <i></i></a></li>
                                    </ul>
                                </div>
                                <div class="fl choiceSize">
                                    <ul>
                                        <li><a title="" class="secondTree" id="Drain_validate">排（污）水 <i></i></a></li>
                                        <li><a title="" class="thirdTree" id="Sewage_collect_rate">污水收集能力达标率 <i></i></a>
                                        </li>
                                        <li><a title="" class="thirdTree" id="Drain_safe_degree">排水安全保障程度 <i></i></a></li>
                                    </ul>
                                </div>
                                <div class="fl choiceSize">
                                    <ul>
                                        <li><a title="" class="secondTree" id="Green_validate">绿化目标实现评价 <i></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class="dn" id="choice4">
                            <div class="navArea">
                                <ul>
                                    <li><a title="" class="secondTree specialTree" id="Service_gfs_good_rate">综合管理用房配置达标率
                                        <i></i></a></li>
                                    <li><a title="" class="secondTree specialTree" id="Cul_fitness_facility_good_rate">文化健身设施配置达标率
                                        <i></i></a></li>
                                    <li><a title="" class="secondTree specialTree" id="Kindergarten_good_rate">幼儿园配置达标率
                                        <i></i></a></li>
                                    <li><a title="" class="secondTree specialTree" id="Medical_good_rate">社区医疗配置达标率 <i></i>
                                    </a></li>
                                    <li>
                                        <div class="" style="height: 120px; width: 145px; float: right;">
                                            <ul>
                                                <li><a title="" class="secondTree specialTree" id="Commerce_validate">商务服务设施 <i></i>
                                                </a></li>
                                                <li><a title="" class="thirdTree" id="CVS_good_rate1" style="width: 125px; margin-left: 6px;">
                                                    便民店配置达标率 <i></i></a></li>
                                                <li><a title="" class="thirdTree" id="Vegetable_market_good_rate" style="width: 125px;
                                                    margin-left: 6px;">菜市场配置达标率 <i></i></a></li>
                                            </ul>
                                        </div>
                                    </li>
                                    <li><a title="" class="secondTree specialTree" id="Parking_good_rate">停车设施配置达标率 <i></i>
                                    </a></li>
                                    <li><a title="" class="secondTree specialTree" id="Older_facility_good_rate">养老设施配置达标率
                                        <i></i></a></li>
                                </ul>
                            </div>
                        </div>
                        <div class="dn" id="choice5">
                            <div class="navArea" style="width: 320px;">
                                <ul>
                                    <li><a title="" class="secondTree" id="Shop_front_use_rate">门面利用率 <i></i></a></li>
                                    <li><a title="" class="secondTree" id="Shop_front_rent_level">门面租金水平 <i></i></a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div>
                                <asp:Button ID="showEchartBtn" runat="server" CssClass="mybtn echartBtn" Text="显示图表"
                                    OnClick="showEchartBtn_Click"></asp:Button>
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
                    <div id="main">
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
<script type="text/javascript">
    //保存四个折线图的横坐标时间的控件ID
    var TextBoxTimeID = "<%=TextBoxTime.ClientID %>";
    //省市门面使用率
    var TextBoxCityDoorRateID = "<%=TextBoxCityDoorRate.ClientID %>";
    //小区门面使用率
    var TextBoxVilDoorRateID = "<%=TextBoxVilDoorRate.ClientID %>";
    //省市劳动力就业率
    var TextBoxCityEmploymentRateID = "<%=TextBoxCityEmploymentRate.ClientID %>";
    //小区劳动力就业率
    var TextBoxVilEmploymentRateID = "<%=TextBoxVilEmploymentRate.ClientID %>";
    //省市人均可支配收入
    var TextBoxCityPcdiID = "<%=TextBoxCityPcdi.ClientID %>";
    //小区人均可支配收入
    var TextBoxVilPcdiID = "<%=TextBoxVilPcdi.ClientID %>";
    //省市房屋租金平均水平
    var TextBoxCityRentLevelID = "<%=TextBoxCityRentLevel.ClientID %>";
    //小区房屋租金平均水平
    var TextBoxVilRentLevelID = "<%=TextBoxVilRentLevel.ClientID %>";


    //在建待建完建
    var TextBoxBeforeID = "<%=TextBoxBefore.ClientID %>";
    var TextBoxInID = "<%=TextBoxIn.ClientID %>";
    var TextBoxComID = "<%=TextBoxCom.ClientID %>";
    //小区专项资金
    var TextBoxVilPlan2ID = "<%=TextBoxVilPlan2.ClientID %>";
    var TextBoxVilFinished2ID = "<%=TextBoxVilFinished2.ClientID %>";
</script>
<script src="echarts-2.2.7/build/dist/echarts.js" type="text/javascript"></script>
<script src="JS/util.js" type="text/javascript"></script>
<script src="JS/community.js" type="text/javascript"></script>
</html>
