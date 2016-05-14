<%@ Page Title="" Language="C#" MasterPageFile="~/Manage.Master" AutoEventWireup="true"
    CodeBehind="LeaderIndex.aspx.cs" Inherits="TTG.Web.LeaderIndex" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--搜索框的所有内容-->
    <div class="pr clearfix">
        <!--这三个是显示省市区县小区信息的倒三角-->
        <div class="triangle" style="margin-left: 164px;" id="tri1">
        </div>
        <div class="triangle" style="margin-left: 348px;" id="tri2">
        </div>
        <div class="triangle" style="margin-left: 531px;" id="tri3">
        </div>
        <!--绝对定为的三个块，用于显示要选择的内容-->
        <div class="infor" id="infor">
            <!--省市的弹出块-->
            <div id="drop1" class="clearfix drop">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div>
                            <a id="aPro" style="margin-left: 35px">不选</a>
                        </div>
                        <br />
                        <div id="proLocation">
                            <asp:Repeater ID="RepeaterForPro" runat="server">
                                <ItemTemplate>
                                    <a id="<%#GetDataItem().ToString()%>" class="location"><%#GetDataItem().ToString()%></a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <asp:Button ID="hideBtn1" runat="server" Text="Button" OnClick="hideBtn1_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <!--区县的弹出块-->
            <div id="drop2" class="clearfix drop">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <div>
                            <a id="aCou" style="margin-left: 35px">不选</a>
                        </div>
                        <br />
                        <div id="couLocation">
                            <asp:Repeater ID="RepeaterForCou" runat="server">
                                <ItemTemplate>
                                    <a id="<%#Eval("community_county").ToString()%>" class="location"><%#Eval("community_county").ToString()%></a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <asp:Button ID="hideBtn2" runat="server" Text="Button" OnClick="hideBtn2_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <!--小区的弹出块-->
            <div id="drop3" class="clearfix drop">
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <div>
                            <a id="aVil" style="margin-left: 35px">不选</a>
                        </div>
                        <br />
                        <div id="comLocation">
                            <asp:Repeater ID="RepeaterForVil" runat="server">
                                <ItemTemplate>
                                    <a id="<%#Eval("community_name").ToString()%>" class="location"><%#Eval("community_name").ToString()%></a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
        <!--两个搜索小区的搜索框-->
        <!--这里是三个下拉的搜索框-->
        <div class="fl">
            <div class="fl clearfix">
                <div class="searchSection clearfix">
                    <div class="selectLocation">
                        <input id="prov" type="text" class="fl sValue" runat="server" placeholder="选择省(市)"
                            readonly="readonly" /><input id="provBtn" type="button" value="" class="selectBtn" />
                    </div>
                    <div class="selectLocation">
                        <input id="county" type="text" class="fl sValue" runat="server" placeholder="选择区县"
                            readonly="readonly" /><input id="countyBtn" type="button" value="" class="selectBtn" />
                    </div>
                    <div class="selectLocation">
                        <input id="village" type="text" class="fl sValue" runat="server" placeholder="选择小区"
                            readonly="readonly" /><input id="villageBtn" type="button" value="" class="selectBtn" />
                    </div>
                </div>
                <asp:Button ID="retirevalBtn" runat="server" Text="搜索" OnClick="retirevalBtn_Click"
                    CssClass="mybtn locBtn" />
            </div>
            <!--这里是单独搜索小区的input-->
            <div class="fl mt20  pr">
                <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <input id="vagueInput" type="text" class="vagueInput" placeholder="直接输入小区名进行搜索" runat="server" />
                        <asp:Button ID="vaguebutton" runat="server" Text="搜索" OnClick="vaguebutton_Click"
                            CssClass="mybtn ls_btn" />
                        <div class="searchResult" id="searchresult" runat="server">
                            <ul>
                                <asp:Repeater ID="RepeaterCom" runat="server">
                                    <ItemTemplate>
                                        <li><a href="Community.aspx?pro=<%#Eval("community_province").ToString()%>&cou=<%#Eval("community_county").ToString()%>&vil=<%#Eval("community_name").ToString()%>"
                                            target="_blank">
                                            <%#Eval("community_province").ToString()+Eval("community_county").ToString()+Eval("community_name").ToString()%>
                                        </a></li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>
    <!--搜索框的所有内容结束-->
    <!--主要信息-->
    <div class="mt20">
        <!--id为bom1的块主要显示三峡库区的总信息-->
        <div class="mb20" id="bom1" runat="server">
            <!--三峡库区标题-->
            <div class="ldTitle ldTitleImg">
                <p>
                    三峡库区城镇移民小区帮扶综合监测汇总指标
                </p>
                <p>
                    数据更新日期：2015-9-30
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </p>
            </div>
            <!--三峡库区数据-->
            <div>
                <!--小区基本信息-->
                <div>
                    <div class="dataTitle">
                        <p>
                            小区基本信息
                        </p>
                    </div>
                    <div class="dataContent clearfix">
                        <div class="dataContentLeft">
                            <a class="dataOn">小区个数</a> <a>人口情况</a> <a>经济情况</a> <a>居民收入情况</a>
                        </div>
                        <div class="dataContentRight">
                            <div class="subDataContentRight" id="DataContent1">
                                <!--小区个数-->
                                <div class="subDataContent">
                                    <div class="ContentTitle">
                                        <p>
                                            小区个数
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts">
                                            <div class="echart_yuan" id="echart_yuan1">
                                            </div>
                                        </div>
                                        <div class="data">
                                            <p>
                                                小区数量:<span>&nbsp<asp:Label ID="Labeltotalcommunity_num" runat="server"></asp:Label>&nbsp</span>个
                                            </p>
                                            <p>
                                                县城（城市）小区<span>&nbsp<asp:Label ID="Labeltotalcounty_community_num" runat="server"></asp:Label>&nbsp</span>个,
                                            </p>
                                            <p>
                                                集镇小区<span>&nbsp<asp:Label ID="Labeltotaltown_community_num" runat="server"></asp:Label>&nbsp</span>个
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <!--人口情况-->
                                <div class="subDataContent">
                                    <div class="ContentTitle">
                                        <p>
                                            人口情况
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts">
                                            <div class="echart_yuan" id="echart_yuan_people1">
                                            </div>
                                        </div>
                                        <div class="data p35">
                                            <p style="margin-left: 50px;">
                                                小区居民户籍人口：<br />
                                                总户数<span>&nbsp<asp:Label ID="Labeltotaltotal_family_num" runat="server">&nbsp</asp:Label>&nbsp</span>户,
                                                <br />
                                                总人数<span>&nbsp<asp:Label ID="Labeltotaltotal_people_num" runat="server"></asp:Label>&nbsp</span>人
                                                <br />
                                                其中移民：<br />
                                                总户数<span>&nbsp<asp:Label ID="Labeltotalimmigrant_family_num" runat="server"></asp:Label>&nbsp</span>户,
                                                <br />
                                                总人数<span>&nbsp<asp:Label ID="Labeltotalimmigrant_people_num" runat="server"></asp:Label>&nbsp</span>人
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <!--经济情况-->
                                <div class="subDataContent">
                                    <div class="ContentTitle">
                                        <p>
                                            经济情况
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts">
                                            <div class="echart_yuan" id="echart_yuan_people2">
                                            </div>
                                        </div>
                                        <div class="data">
                                            <p>
                                                劳动力就业率<span>&nbsp
                                                    <asp:Label ID="Labeltotallf_having_job_rate" runat="server"></asp:Label>&nbsp</span>%
                                                <br />
                                                低保人口比例<span>&nbsp
                                                    <asp:Label ID="Labeltotalpoor_people_rate" runat="server"></asp:Label>&nbsp</span>%
                                                <br />
                                                人均住房面积<span>&nbsp<asp:Label ID="Labeltotalaverage_house_area" runat="server"></asp:Label>&nbsp</span>㎡
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <!--居民收入情况-->
                                <div class="subDataContent">
                                    <div class="ContentTitle">
                                        <p>
                                            居民收入情况
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts">
                                            <div class="echart_yuan" id="echart_yuan_income">
                                            </div>
                                        </div>
                                        <div class="data">
                                            <p style="margin-left: -30px;">
                                                人均可支配2013年情况：<span>&nbsp<asp:Label ID="Labeltotaldisposable_income_2013" runat="server"></asp:Label>&nbsp</span>元
                                                <br />
                                                人均可支配当前情况：<span>&nbsp<asp:Label ID="Labeltotaldisposable_income_now" runat="server"></asp:Label>&nbsp</span>元
                                                <br />
                                                人均可支配收入变化情况<span>&nbsp<asp:Label ID="Labeltotalincome_change" runat="server"></asp:Label>&nbsp</span>%
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!--项目基本信息-->
                <div class="mt50">
                    <div class="dataTitle">
                        <p>
                            项目基本信息</p>
                    </div>
                    <div class="dataContent clearfix child500">
                        <div class="dataContentLeft">
                            <a class="dataOn">项目覆盖小区</a> <a>专项资金项目进展</a> <a>专项资金投资情况</a>
                        </div>
                        <div class="dataContentRight">
                            <div class="subDataContentRight" id="DataContent2">
                                <!--项目覆盖小区-->
                                <div class="subDataContent" style="height: 500px;">
                                    <div class="ContentTitle">
                                        <p>
                                            项目覆盖小区
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts">
                                            <div class="echart_yuan" id="echart_yuan2">
                                            </div>
                                        </div>
                                        <div class="data">
                                            <p style="margin-top: 120px;">
                                                专项资金项目覆盖小区<span>&nbsp<asp:Label ID="Labeltotalspecial_cover_community_num" runat="server"></asp:Label>&nbsp</span>个
                                            </p>
                                            <p>
                                                所有项目覆盖小区<span>&nbsp<asp:Label ID="Labeltotalcover_community_num" runat="server"></asp:Label>&nbsp</span>个
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <!--专项资金项目-->
                                <div class="subDataContent normalSpan" style="height: 500px;">
                                    <div class="ContentTitle">
                                        <p>
                                            专项资金项目进展
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts" style="width: 500px;">
                                            <div style="width: 500px; height: 320px;" id="main_total_capital">
                                            </div>
                                            <table class="forechart">
                                                <tr>
                                                    <td style="width: 58px;">
                                                        待建
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelbefore_cons_2013" runat="server"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelbefore_cons_2014" runat="server"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 58px;">
                                                        在建
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelin_cons_2013" runat="server"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelin_cons_2014" runat="server"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 58px;">
                                                        完建
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelcom_cons_2013" runat="server"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelcom_cons_2014" runat="server"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                            <div style="display: none;">
                                                <asp:TextBox ID="TextBoxTotalBefore" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxTotalIn" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxTotalCom" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxTotalPlan2" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxTotalFinished2" runat="server"></asp:TextBox>
                                            </div>
                                            <p>
                                                专项资金项目进展情况
                                            </p>
                                        </div>
                                        <div class="data p50" style="width: 260px; margin-left: -40px;">
                                            <p class="mt20">
                                                2011～2013年:<br />
                                                专项资金项目
                                                <asp:Label ID="Labelproject_num_2013" runat="server"></asp:Label>个<br />
                                                专项资金项目完工比例
                                                <asp:Label ID="Labelproject_com_rate_2013" runat="server"></asp:Label>%<br />
                                                2014年后:<br />
                                                专项资金项目
                                                <asp:Label ID="Labelproject_num_2014" runat="server"></asp:Label>个<br />
                                                专项资金项目单项工程完工比例
                                                <asp:Label ID="Labelproject_com_rate_2014" runat="server"></asp:Label>%<br />
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <!--专项资金投资-->
                                <div class="subDataContent normalSpan" style="height: 500px;">
                                    <div class="ContentTitle">
                                        <p>
                                            专项资金投资情况
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts" style="width: 500px;">
                                            <div style="width: 500px; height: 320px;" id="main_total_type">
                                            </div>
                                            <table class="forechart td70">
                                                <tr>
                                                    <td style="width: 58px;">
                                                        投资类别
                                                    </td>
                                                    <td>
                                                        房屋居住安全
                                                    </td>
                                                    <td>
                                                        基础设施
                                                    </td>
                                                    <td>
                                                        环保设施
                                                    </td>
                                                    <td>
                                                        公共服务设施
                                                    </td>
                                                    <td>
                                                        就业与创业扶持
                                                    </td>
                                                </tr>
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
                                            <p>
                                                专项资金按类别结构划分的投资下达及完成情况
                                            </p>
                                        </div>
                                        <div class="data" style="width: 260px; margin-left: -40px;">
                                            <p style="margin-top: 70px;">
                                                累积专项资金下达 <span>
                                                    <asp:Label ID="Labelfounds_down" runat="server"></asp:Label></span>万元
                                                <br />
                                                累积专项资金完成<span>
                                                    <asp:Label ID="Labelfounds_com" runat="server"></asp:Label></span>万元
                                                <br />
                                                专项资金完成比例<span>
                                                    <asp:Label ID="Labelfounds_rate" runat="server"></asp:Label>
                                                    %</span>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--id为bom2的块主要显示省市的总信息-->
        <div class="mb20 dn" id="bom2" runat="server">
            <!--省市标题-->
            <div class="ldTitle ldTitleImg" id="bomtitlepro">
                <p>
                    <asp:Label ID="LabelPro" runat="server"></asp:Label>城镇移民小区帮扶综合监测汇总指标
                </p>
                <p>
                    数据更新日期：2015-9-30
                    <%--<asp:Label ID="Label1" runat="server" ></asp:Label>--%>
                </p>
            </div>
            <div>
                <!--小区基本信息-->
                <div>
                    <div class="dataTitle">
                        <p>
                            小区基本信息</p>
                    </div>
                    <div class="dataContent clearfix">
                        <div class="dataContentLeft">
                            <a class="dataOn">小区个数</a> <a>人口情况</a> <a>经济情况</a> <a>居民收入情况</a>
                        </div>
                        <div class="dataContentRight">
                            <div class="subDataContentRight" id="DataContent3">
                                <!--小区个数-->
                                <div class="subDataContent">
                                    <div class="ContentTitle">
                                        <p>
                                            小区个数
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts">
                                            <div class="echart_yuan" id="echart_yuan_province1">
                                            </div>
                                        </div>
                                        <div class="data">
                                            <p>
                                                小区数量:<span>&nbsp<asp:Label ID="Labelprovincecommunity_num" runat="server"></asp:Label>&nbsp</span>个
                                            </p>
                                            <p>
                                                县城（城市）小区<span>&nbsp<asp:Label ID="Labelprovincecounty_community_num" runat="server"></asp:Label>&nbsp</span>个,
                                            </p>
                                            <p>
                                                集镇小区<span>&nbsp<asp:Label ID="Labelprovincetown_community_num" runat="server"></asp:Label>&nbsp</span>个
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <!--人口情况-->
                                <div class="subDataContent">
                                    <div class="ContentTitle">
                                        <p>
                                            人口情况
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts">
                                            <div class="echart_yuan" id="echart_yuan_people_province1">
                                            </div>
                                        </div>
                                        <div class="data p35">
                                            <p style="margin-left: 50px;">
                                                小区居民户籍人口：<br />
                                                总户数<span>&nbsp<asp:Label ID="Labelprovincetotal_family_num" runat="server">&nbsp</asp:Label>&nbsp</span>户,
                                                <br />
                                                总人数<span>&nbsp<asp:Label ID="Labelprovincetotal_people_num" runat="server"></asp:Label>&nbsp</span>人
                                                <br />
                                                其中移民：<br />
                                                总户数<span>&nbsp<asp:Label ID="Labelprovinceimmigrant_family_num" runat="server"></asp:Label>&nbsp</span>户,
                                                <br />
                                                总人数<span>&nbsp<asp:Label ID="Labelprovinceimmigrant_people_num" runat="server"></asp:Label>&nbsp</span>人
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <!--经济情况-->
                                <div class="subDataContent">
                                    <div class="ContentTitle">
                                        <p>
                                            经济情况
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts">
                                            <div class="echart_yuan" id="echart_yuan_people_province2">
                                            </div>
                                        </div>
                                        <div class="data">
                                            <p>
                                                劳动力就业率<span>&nbsp
                                                    <asp:Label ID="Labelprovincelf_having_job_rate" runat="server"></asp:Label>&nbsp</span>%
                                            </p>
                                            <p>
                                                低保人口比例<span>&nbsp
                                                    <asp:Label ID="Labelprovincepoor_people_rate" runat="server"></asp:Label>&nbsp</span>%
                                            </p>
                                            <p>
                                                人均住房面积<span>&nbsp<asp:Label ID="Labelprovinceaverage_house_area" runat="server"></asp:Label>&nbsp</span>㎡
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <!--居民收入情况-->
                                <div class="subDataContent">
                                    <div class="ContentTitle">
                                        <p>
                                            居民收入情况
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts">
                                            <div class="echart_yuan" id="echart_yuan_income_province">
                                            </div>
                                        </div>
                                        <div class="data">
                                            <p style="margin-left: -30px;">
                                                人均可支配2013年情况：<span>&nbsp<asp:Label ID="Labelprovincedisposable_income_2013" runat="server"></asp:Label>&nbsp</span>元
                                                <br />
                                                人均可支配当前情况：<span>&nbsp<asp:Label ID="Labelprovincedisposable_income_now" runat="server"></asp:Label>&nbsp</span>元
                                                <br />
                                                人均可支配收入变化情况<span>&nbsp<asp:Label ID="Labelprovinceincome_change" runat="server"></asp:Label>&nbsp</span>%
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!--项目基本信息-->
                <div class="mt50">
                    <div class="dataTitle">
                        <p>
                            项目基本信息</p>
                    </div>
                    <div class="dataContent clearfix child500">
                        <div class="dataContentLeft">
                            <a class="dataOn">项目覆盖小区</a> <a>专项资金项目进展</a> <a>专项资金投资情况</a>
                        </div>
                        <div class="dataContentRight">
                            <div class="subDataContentRight" id="DataContent4">
                                <div class="subDataContent" style="height: 500px;">
                                    <div class="ContentTitle">
                                        <p>
                                            项目覆盖小区
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts">
                                            <div class="echart_yuan" id="echart_yuan_province2">
                                            </div>
                                        </div>
                                        <div class="data">
                                            <p style="margin-top: 120px;">
                                                专项资金项目覆盖小区<span>&nbsp<asp:Label ID="Labelprovincespecial_cover_community_num" runat="server"></asp:Label>&nbsp</span>个
                                            </p>
                                            <p>
                                                所有项目覆盖小区<span>&nbsp<asp:Label ID="Labelprovincecover_community_num" runat="server"></asp:Label>&nbsp</span>个
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <div class="subDataContent  normalSpan" style="height: 500px;">
                                    <div class="ContentTitle">
                                        <p>
                                            专项资金项目进展
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts" style="width: 500px;">
                                            <div style="width: 500px; height: 320px;" id="main_prototal_capital">
                                            </div>
                                            <table class="forechart">
                                                <tr>
                                                    <td style="width: 58px;">
                                                        待建
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelprovince_before_cons_2013" runat="server"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelprovince_before_cons_2014" runat="server"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 58px;">
                                                        在建
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelprovince_in_cons_2013" runat="server"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelprovince_in_cons_2014" runat="server"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 58px;">
                                                        完建
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelprovince_com_cons_2013" runat="server"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelprovince_com_cons_2014" runat="server"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                            <div style="display: none;">
                                                <asp:TextBox ID="TextBoxProvinceBefore" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxProvinceIn" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxProvinceCom" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxProvincePlan2" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxProvinceFinished2" runat="server"></asp:TextBox>
                                            </div>
                                            <p>
                                                专项资金项目进展情况
                                            </p>
                                        </div>
                                        <div class="data p50" style="width: 260px; margin-left: -40px;">
                                            <p class="mt20">
                                                2011～2013年:<br />
                                                专项资金项目<asp:Label ID="Labelprovince_project_num_2013" runat="server"></asp:Label>个<br />
                                                专项资金项目完工比例<asp:Label ID="Labelprovince_project_com_rate_2013" runat="server"></asp:Label>%<br />
                                                2014年后:<br />
                                                专项资金项目<asp:Label ID="Labelprovince_project_num_2014" runat="server"></asp:Label>个<br />
                                                专项资金项目单项工程完工比例<asp:Label ID="Labelprovince_project_com_rate_2014" runat="server"></asp:Label>%<br />
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <div class="subDataContent  normalSpan" style="height: 500px;">
                                    <div class="ContentTitle">
                                        <p>
                                            专项资金投资情况
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts " style="width: 500px;">
                                            <div style="width: 500px; height: 320px;" id="main_prototal_type">
                                            </div>
                                            <table class="forechart td70">
                                                <tr>
                                                    <td style="width: 58px;">
                                                        投资类别
                                                    </td>
                                                    <td>
                                                        房屋居住安全
                                                    </td>
                                                    <td>
                                                        基础设施
                                                    </td>
                                                    <td>
                                                        环保设施
                                                    </td>
                                                    <td>
                                                        公共服务设施
                                                    </td>
                                                    <td>
                                                        就业与创业扶持
                                                    </td>
                                                </tr>
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
                                            <p>
                                                专项资金按类别结构划分的投资下达及完成情况
                                            </p>
                                        </div>
                                        <div class="data" style="width: 260px; margin-left: -40px;">
                                            <p>
                                                累积专项资金下达<span>
                                                    <asp:Label ID="Labelprovince_founds_down" runat="server"></asp:Label></span>万元
                                                <br />
                                                累积专项资金完成<span>
                                                    <asp:Label ID="Labelprovince_founds_com" runat="server"></asp:Label></span>万元
                                                <br />
                                                专项资金完成比例 <span>
                                                    <asp:Label ID="Labelprovince_founds_rate" runat="server"></asp:Label>%</span>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--id为bom3的块主要显示区县的总信息-->
        <div class="mb20 dn" id="bom3" runat="server">
            <!--小区标题-->
            <div class="ldTitle">
                <p>
                    <asp:Label ID="LabelPro2" runat="server"></asp:Label><asp:Label ID="LabelCou" runat="server"></asp:Label>城镇移民小区综合监测综合汇总指标
                </p>
                <p>
                    数据更新日期：2015-9-30
                    <%--<asp:Label ID="Label1" runat="server" ></asp:Label>--%>
                </p>
            </div>
            <div>
                <!--小区基本信息-->
                <div>
                    <div class="dataTitle">
                        <p>
                            小区基本信息</p>
                    </div>
                    <div class="dataContent clearfix">
                        <div class="dataContentLeft">
                            <a class="dataOn">小区个数</a> <a>人口情况</a> <a>经济情况</a> <a>居民收入情况</a>
                        </div>
                        <div class="dataContentRight">
                            <div class="subDataContentRight" id="DataContent5">
                                <!--小区个数-->
                                <div class="subDataContent">
                                    <div class="ContentTitle">
                                        <p>
                                            小区个数
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts">
                                            <div class="echart_yuan" id="echart_yuan_county1">
                                            </div>
                                        </div>
                                        <div class="data">
                                            <p>
                                                小区数量:<span>&nbsp<asp:Label ID="Labelcountycommunity_num" runat="server"></asp:Label>&nbsp</span>个
                                            </p>
                                            <p>
                                                县城（城市）小区<span>&nbsp<asp:Label ID="Labelcountycounty_community_num" runat="server"></asp:Label>&nbsp</span>个,
                                            </p>
                                            <p>
                                                集镇小区<span>&nbsp<asp:Label ID="Labelcountytown_community_num" runat="server"></asp:Label>&nbsp</span>个
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <!--人口情况-->
                                <div class="subDataContent">
                                    <div class="ContentTitle">
                                        <p>
                                            人口情况
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts">
                                            <div class="echart_yuan" id="echart_yuan_people_county1">
                                            </div>
                                        </div>
                                        <div class="data p35">
                                            <p style="margin-left: 50px;">
                                                小区居民户籍人口：<br />
                                                总户数<span>&nbsp<asp:Label ID="Labelcountytotal_family_num" runat="server">&nbsp</asp:Label>&nbsp</span>户,
                                                <br />
                                                总人数<span>&nbsp<asp:Label ID="Labelcountytotal_people_num" runat="server"></asp:Label>&nbsp</span>人
                                                <br />
                                                其中移民：<br />
                                                总户数<span>&nbsp<asp:Label ID="Labelcountyimmigrant_family_num" runat="server"></asp:Label>&nbsp</span>户,
                                                <br />
                                                总人数<span>&nbsp<asp:Label ID="Labelcountyimmigrant_people_num" runat="server"></asp:Label>&nbsp</span>人
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <!--经济情况-->
                                <div class="subDataContent">
                                    <div class="ContentTitle">
                                        <p>
                                            经济情况
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts">
                                            <div class="echart_yuan" id="echart_yuan_people_county2">
                                            </div>
                                        </div>
                                        <div class="data">
                                            <p style="margin-top: 0px;">
                                                劳动力就业率<span>&nbsp
                                                    <asp:Label ID="Labelcountylf_having_job_rate" runat="server"></asp:Label>&nbsp</span>%
                                                <br />
                                                低保人口比例<span>&nbsp
                                                    <asp:Label ID="Labelcountypoor_people_rate" runat="server"></asp:Label>&nbsp</span>%
                                                <br />
                                                人均住房面积<span>&nbsp<asp:Label ID="Labelcountyaverage_house_area" runat="server"></asp:Label>&nbsp</span>㎡
                                                <br />
                                                恩格尔系数<span>
                                                    <asp:Label ID="Labelegr" runat="server"></asp:Label>
                                                    %</span>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <div class="subDataContent">
                                    <div class="ContentTitle">
                                        <p>
                                            居民收入情况</p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts">
                                            <div class="echart_yuan" id="echart_yuan_income_county">
                                            </div>
                                        </div>
                                        <div class="data">
                                            <p style="margin-left: -30px;">
                                                人均可支配2013年情况：<span>&nbsp<asp:Label ID="Labelcountydisposable_income_2013" runat="server"></asp:Label>&nbsp</span>元
                                                <br />
                                                人均可支配当前情况：<span>&nbsp<asp:Label ID="Labelcountydisposable_income_now" runat="server"></asp:Label>&nbsp</span>元
                                                <br />
                                                人均可支配收入变化情况<span>&nbsp<asp:Label ID="Labelcountyincome_change" runat="server"></asp:Label>&nbsp</span>%
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!--项目基本信息-->
                <div class="mt50">
                    <div class="dataTitle">
                        <p>
                            项目基本信息</p>
                    </div>
                    <div class="dataContent clearfix child500">
                        <div class="dataContentLeft" style="height: 500px;">
                            <a class="dataOn">项目覆盖小区</a> <a>专项资金项目进展</a> <a>专项资金投资情况</a>
                        </div>
                        <div class="dataContentRight">
                            <div class="subDataContentRight" id="DataContent6">
                                <div class="subDataContent" style="height: 500px;">
                                    <div class="ContentTitle">
                                        <p>
                                            项目覆盖小区
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts">
                                            <div class="echart_yuan" id="echart_yuan_county2">
                                            </div>
                                        </div>
                                        <div class="data" style="width: 260px; margin-left: -40px;">
                                            <p style="margin-top: 30px;">
                                                专项资金项目覆盖小区<span>&nbsp<asp:Label ID="Labelcountyspecial_cover_community_num" runat="server"></asp:Label>&nbsp</span>个
                                            </p>
                                            <p>
                                                所有项目覆盖小区<span>&nbsp<asp:Label ID="Labelcountycover_community_num" runat="server"></asp:Label>&nbsp</span>个
                                            </p>
                                            <p>
                                                <a href="ReadOnlyExcel.aspx?Pro=<%=excelProvince%>&Cou=<%=excelCounty%>&officeFile=2014及以后专项资金项目.xlsx"
                                                    target="_blank">专项资金项目 >></a>
                                            </p>
                                            <p>
                                                <a href="ReadOnlyExcel.aspx?Pro=<%=excelProvince%>&Cou=<%=excelCounty%>&officeFile=对口支援及其他项目.xlsx"
                                                    target="_blank">对口支援及其他项目 >></a>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <div class="subDataContent  normalSpan" style="height: 500px;">
                                    <div class="ContentTitle">
                                        <p>
                                            专项资金项目进展
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts " style="width: 500px;">
                                            <div style="width: 500px; height: 320px;" id="main_coutotal_capital">
                                            </div>
                                            <table class="forechart">
                                                <tr>
                                                    <td style="width: 58px;">
                                                        待建
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelcounty_before_cons_2013" runat="server"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelcounty_before_cons_2014" runat="server"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 58px;">
                                                        在建
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelcounty_in_cons_2013" runat="server"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelcounty_in_cons_2014" runat="server"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 58px;">
                                                        完建
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelcounty_com_cons_2013" runat="server"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Labelcounty_com_cons_2014" runat="server"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                            <div style="display: none;">
                                                <asp:TextBox ID="TextBoxCountyBefore" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxCountyIn" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxCountyCom" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxCouPlan2" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="TextBoxCouFinished2" runat="server"></asp:TextBox>
                                            </div>
                                            <p>
                                                专项资金项目进展情况
                                            </p>
                                        </div>
                                        <div class="data p50" style="width: 260px; margin-left: -40px;">
                                            <div style="display: none;">
                                            </div>
                                            <p style="margin-top: 40px;">
                                                2011～2013年:<br />
                                                专项资金项目<asp:Label ID="Labelcounty_project_num_2013" runat="server"></asp:Label>个<br />
                                                专项资金项目完工比例<asp:Label ID="Labelcounty_project_com_rate_2013" runat="server"></asp:Label>%<br />
                                                2014年后:<br />
                                                专项资金项目<asp:Label ID="Labelcounty_project_num_2014" runat="server"></asp:Label>个<br />
                                                专项资金项目单项工程完工比例<asp:Label ID="Labelcounty_project_com_rate_2014" runat="server"></asp:Label>%<br />
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <div class="subDataContent  normalSpan" style="height: 500px;">
                                    <div class="ContentTitle">
                                        <p>
                                            专项资金投资情况
                                        </p>
                                    </div>
                                    <div class="contentMain">
                                        <div class="echarts " style="width: 500px;">
                                            <div style="width: 500px; height: 320px;" id="main_coutotal_type">
                                            </div>
                                            <table class="forechart td70">
                                                <tr>
                                                    <td style="width: 58px;">
                                                        投资类别
                                                    </td>
                                                    <td>
                                                        房屋居住安全
                                                    </td>
                                                    <td>
                                                        基础设施
                                                    </td>
                                                    <td>
                                                        环保设施
                                                    </td>
                                                    <td>
                                                        公共服务设施
                                                    </td>
                                                    <td>
                                                        就业与创业扶持
                                                    </td>
                                                </tr>
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
                                            <p>
                                                专项资金按类别结构划分的投资下达及完成情况
                                            </p>
                                        </div>
                                        <div class="data" style="width: 260px; margin-left: -40px;">
                                            <p style="margin-top: 70px;">
                                                累积专项资金下达 <span>
                                                    <asp:Label ID="Labelcounty_founds_down" runat="server"></asp:Label></span>万元
                                                <br />
                                                累积专项资金完成 <span>
                                                    <asp:Label ID="Labelcounty_founds_com" runat="server"></asp:Label></span> 万元
                                                <br />
                                                专项资金完成比例 <span>
                                                    <asp:Label ID="Labelcounty_founds_rate" runat="server"></asp:Label>%</span>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div>
            <a href="MutipleHasPublish.aspx" target="_blank" style="color:Blue;text-decoration:underline;">已经发布的数据 》》</a>
        </div>
    </div>
    <!--主要信息完毕-->
    <script type="text/javascript">

        //在选择小区时用到的控件ID
        var provID = "<%=prov.ClientID %>";
        var countyID = "<%=county.ClientID %>";
        var villageID = "<%=village.ClientID%>";
        var hideBtn1ID = "<%=hideBtn1.ClientID%>";
        var hideBtn2ID = "<%=hideBtn2.ClientID%>";
        var searchresultID = "<%=searchresult.ClientID%>";


        //三峡库区所有echarts中用到的ID
        //县城小区
        var Labeltotalcounty_community_numID = "<%=Labeltotalcounty_community_num.ClientID %>";
        //集镇小区
        var Labeltotaltown_community_numID = "<%=Labeltotaltown_community_num.ClientID %>";
        //所有小区
        var Labeltotalcover_community_numID = "<%=Labeltotalcover_community_num.ClientID %>";
        //专项资金项目覆盖小区
        var Labeltotalspecial_cover_community_numID = "<%=Labeltotalspecial_cover_community_num.ClientID %>";
        //所有项目覆盖小区
        var Labeltotalcommunity_numID = "<%=Labeltotalcommunity_num.ClientID %>";
        //总户数
        var Labeltotaltotal_family_numID = "<%=Labeltotaltotal_family_num.ClientID %>";
        //总人数
        var Labeltotaltotal_people_numID = "<%=Labeltotaltotal_people_num.ClientID %>";
        //移民总户数
        var Labeltotalimmigrant_family_numID = "<%=Labeltotalimmigrant_family_num.ClientID %>";
        //移民总人数
        var Labeltotalimmigrant_people_numID = "<%=Labeltotalimmigrant_people_num.ClientID %>";
        //劳动力就业率
        var Labeltotallf_having_job_rateID = "<%=Labeltotallf_having_job_rate.ClientID %>";
        //低保人口比例
        var Labeltotalpoor_people_rateID = "<%=Labeltotalpoor_people_rate.ClientID %>";
        //人均可支配收入变化
        var Labeltotalincome_changeID = "<%=Labeltotalincome_change.ClientID %>";
        //资金柱状图
        var TextBoxTotalBeforeID = "<%=TextBoxTotalBefore.ClientID %>";
        var TextBoxTotalComID = "<%=TextBoxTotalCom.ClientID %>";
        var TextBoxTotalInID = "<%=TextBoxTotalIn.ClientID %>";
        //专项资金柱状图
        var TextBoxTotalPlan2ID = "<%=TextBoxTotalPlan2.ClientID %>";
        var TextBoxTotalFinished2ID = "<%=TextBoxTotalFinished2.ClientID %>";


        //省市所有echarts中用到的ID
        //县城小区
        var Labelprovincecounty_community_numID = "<%=Labelprovincecounty_community_num.ClientID %>";
        //集镇小区
        var Labelprovincetown_community_numID = "<%=Labelprovincetown_community_num.ClientID %>";
        //所有小区
        var Labelprovincecover_community_numID = "<%=Labelprovincecover_community_num.ClientID %>";
        //专项资金项目覆盖小区
        var Labelprovincespecial_cover_community_numID = "<%=Labelprovincespecial_cover_community_num.ClientID %>";
        //所有项目覆盖小区
        var Labelprovincecommunity_numID = "<%=Labelprovincecommunity_num.ClientID %>";
        //居民总户数
        var Labelprovincetotal_family_numID = "<%=Labelprovincetotal_family_num.ClientID %>";
        //居民总人数
        var Labelprovincetotal_people_numID = "<%=Labelprovincetotal_people_num.ClientID %>";
        //移民总户数
        var Labelprovinceimmigrant_family_numID = "<%=Labelprovinceimmigrant_family_num.ClientID %>";
        //移民总人数
        var Labelprovinceimmigrant_people_numID = "<%=Labelprovinceimmigrant_people_num.ClientID %>";
        //劳动力就业率
        var Labelprovincelf_having_job_rateID = "<%=Labelprovincelf_having_job_rate.ClientID %>";
        //低保人口比例
        var Labelprovincepoor_people_rateID = "<%=Labelprovincepoor_people_rate.ClientID %>";
        //人均可支配收入变化
        var Labelprovinceincome_changeID = "<%=Labelprovinceincome_change.ClientID %>";
        //资金柱状图
        var TextBoxProvinceBeforeID = "<%=TextBoxProvinceBefore.ClientID %>";
        var TextBoxProvinceInID = "<%=TextBoxProvinceIn.ClientID %>";
        var TextBoxProvinceComID = "<%=TextBoxProvinceCom.ClientID %>";
        //专项资金柱状图
        var TextBoxProvincePlan2ID = "<%=TextBoxProvincePlan2.ClientID %>";
        var TextBoxProvinceFinished2ID = "<%=TextBoxProvinceFinished2.ClientID %>";

        //区县所有echarts中用到的ID
        //县城小区
        var Labelcountycounty_community_numID = "<%=Labelcountycounty_community_num.ClientID %>";
        //集镇小区
        var Labelcountytown_community_numID = "<%=Labelcountytown_community_num.ClientID %>";
        //所有小区
        var Labelcountycover_community_numID = "<%=Labelcountycover_community_num.ClientID %>";
        //专项资金项目覆盖小区
        var Labelcountyspecial_cover_community_numID = "<%=Labelcountyspecial_cover_community_num.ClientID %>";
        //所有项目覆盖小区
        var Labelcountycommunity_numID = "<%=Labelcountycommunity_num.ClientID %>";
        //居民总户数
        var Labelcountytotal_family_numID = "<%=Labelcountytotal_family_num.ClientID %>";
        //居民总人数
        var Labelcountytotal_people_numID = "<%=Labelcountytotal_people_num.ClientID %>";
        //移民总户数
        var Labelcountyimmigrant_family_numID = "<%=Labelcountyimmigrant_family_num.ClientID %>";
        //移民总人数
        var Labelcountyimmigrant_people_numID = "<%=Labelcountyimmigrant_people_num.ClientID %>";
        //劳动力就业率
        var Labelcountylf_having_job_rateID = "<%=Labelcountylf_having_job_rate.ClientID %>";
        //低保人口比例
        var Labelcountypoor_people_rateID = "<%=Labelcountypoor_people_rate.ClientID %>";
        //人均可支配收入变化
        var Labelcountyincome_changeID = "<%=Labelcountyincome_change.ClientID %>";
        //资金柱状图
        var TextBoxCountyBeforeID = "<%=TextBoxCountyBefore.ClientID %>";
        var TextBoxCountyInID = "<%=TextBoxCountyIn.ClientID %>";
        var TextBoxCountyComID = "<%=TextBoxCountyCom.ClientID %>";

        //专项资金柱状图
        var TextBoxCouPlan2ID = "<%=TextBoxCouPlan2.ClientID %>";
        var TextBoxCouFinished2ID = "<%=TextBoxCouFinished2.ClientID %>";
    </script>
    <script src="echarts-2.2.7/build/dist/echarts.js" type="text/javascript"></script>
    <script src="JS/util.js" type="text/javascript"></script>
    <script src="JS/leaderIndex.js" type="text/javascript"></script>
    <script src="JS/echartsForLd.js" type="text/javascript"></script>
</asp:Content>
