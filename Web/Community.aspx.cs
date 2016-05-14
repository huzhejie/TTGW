using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using TTG.DAL.TTGWeb;
using TTG.DAL.GET;
using System.Reflection;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;

namespace TTG.Web
{
    public partial class Community : System.Web.UI.Page
    {

        public string community_id = "";
        public string com_name = "";
        public string com_province = "";
        public string com_county = "";
        /// <summary>
        /// 初始化页面中所有表格的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            com_name = Request["vil"].ToString();
            com_county = Request["cou"].ToString();
            com_province = Request["pro"].ToString();

            string key=com_county.Substring(com_county.Length-1,1);

          
            
            LabelProvince.Text = com_province;
            LabelCounty.Text = com_county;
            LabelCommunity.Text = com_name;

            AspNetPager1.PageSize = 12;
            //计算项目总数初始化分页数量
            TTG.DAL.GET.get_project getProject = new get_project(com_province, com_county, com_name);
            List<project_data> totalList = getProject.List;
            AspNetPager1.RecordCount = totalList.Count;
            //初始化柱状图数据
            getBarChartData();
            //初始化折线图数据
            getLineChartData();
            
            //填写表数据
            togetCommunityMainPage();
            togetHouseSafety();
            togetBaseFacilities();
            togetEnvProtect();
            togetPublicServices();
            togetBusiness();
            togetFirstList();
            showEchartBtn.Attributes.Add("OnClick", "return checkFile()");
            string url = "MapPage.aspx?province=" + com_province + "&counity=" + com_county + "&commuity=" + com_name;
            GisUrl.HRef = url;

          

        }

        /// <summary>
        /// 获得第一页项目清单
        /// </summary>
        private void togetFirstList() {
            TTG.DAL.GET.get_project getProject = new get_project(com_province, com_county, com_name);
            List<project_data> totalList = getProject.List;
         

            List<project_data> newList = new List<project_data>();
            for (int i = 0; i < AspNetPager1.PageSize && i < totalList.Count; i++) {
                newList.Add(totalList[i]);
            }
            
            
            Repeater1.DataSource = newList;
            Repeater1.DataBind();
        }

        /// <summary>
        /// 项目清单换页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            TTG.DAL.GET.get_project getProject = new get_project(com_name, com_province, com_county);
            List<project_data> totalList = getProject.List;
            List<project_data> newList = new List<project_data>();
            int StartIndex = AspNetPager1.PageSize * (AspNetPager1.CurrentPageIndex - 1) + 1;
            int EndIndex = StartIndex + AspNetPager1.PageSize - 1;
            if (EndIndex <= totalList.Count-1)
            {
                for (int i = StartIndex; i <= EndIndex; i++)
                {
                    newList.Add(totalList[i]);
                }
            }
            else {
                for (int i = StartIndex; i <= totalList.Count - 1; i++)
                {
                    newList.Add(totalList[i]);
                }
            }
            this.Repeater1.DataSource = newList;
            this.Repeater1.DataBind();

        }
        /// <summary>
        /// 获取小区主页面数据
        /// </summary>
        private void togetCommunityMainPage()
        {
            //TTG.DAL.GET.get_community_mainpage getMainPage = new DAL.GET.get_community_mainpage(com_name, com_province, com_county);
            TTG.DAL.GET.get_community_mainpage getMainPage = new DAL.GET.get_community_mainpage(com_province, com_county, com_name);
            LabelCommunityId.Text = getMainPage.Community_id;
            //LabelLastModify.Text = getMainPage.Last_modify.ToShortDateString();
            LabelLastModify.Text = "2015-9-30";
            community_id = getMainPage.Community_id;
            //根据id初始化左上角图片
            TTG.DAL.TTGWeb.image_info DIIN = new TTG.DAL.TTGWeb.image_info();
            DataSet ds = DIIN.getFitstImg(community_id);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ImageTitle.ImageUrl = "~/小区图片/" + com_province + "/" + com_county + "/" + com_name + "/" + ds.Tables[0].Rows[0][0];
            }
            else
            {
                ImageTitle.ImageUrl = "~/小区图片/default.jpg";
            }
            hidecom_id.Value = community_id;

            #region 首页数据
            //在首页表格中添加值
            //小区类型
            LabelCommunityType.Text = getMainPage.Community_type;
            //建设年份
            LabelConstructYear.Text = getMainPage.Construct_year.ToString();
            //居民户籍人口户数
            LabelRegFamilyNum.Text = getMainPage.Reg_family_num.ToString();
            //居民户籍人口人数
            LabelRegPeopleNum.Text = getMainPage.Reg_people_num.ToString();
            //移民人口户数
            LabelImmigrantFamilyNum.Text = getMainPage.Immigrant_family_num.ToString();
            //移民人口人数
            LabelImmigrantPeopleNum.Text = getMainPage.Immigrant_people_num.ToString();
            //建筑面积
            LabelConstructionArea.Text = Convert.ToDouble(getMainPage.Construction_area).ToString("0.00");
            //占地面积
            LabelFloorArea.Text = Convert.ToDouble(getMainPage.Floor_area).ToString("0.00");
            //人均住房面积
            LabelAverageHouseArea.Text = getNoNaN(Convert.ToDouble(getMainPage.Average_house_area).ToString("0.00").ToString());
            //容积率           //暂时无法计算
            LabelPlotRatio.Text = Convert.ToDouble(getMainPage.Plot_ratio).ToString("0.00");

            //绿地率
            LabelGreenRate.Text = Convert.ToDouble(getMainPage.Green_rate).ToString("0.00");
            //停车位
            LabelParkingLot.Text = getMainPage.Parking_lot.ToString();
            //门面数
            LabelFacade.Text = getMainPage.Facade.ToString();
            //门面使用率
            LabelFacadeUseRate.Text = Convert.ToDouble(getMainPage.Facade_use_rate[getMainPage.Facade_use_rate.Length - 1]).ToString("0.00");
            //劳动力就业率
            LabelEmploymentRate.Text = Convert.ToDouble(getMainPage.Employment_rate[getMainPage.Employment_rate.Length - 1]).ToString("0.00");
            //人均可支配收入
            LabelDisposableIncome.Text = getMainPage.Disposable_income[getMainPage.Disposable_income.Length - 1].ToString();
            //房屋平均租金水平
            LabelAverageRent.Text = getMainPage.Average_rent[getMainPage.Average_rent.Length - 1].ToString();
            //低保人口比例
            LabelPoorRate.Text = getNoNaN(Convert.ToDouble(getMainPage.Poor_rate).ToString("0.00").ToString());
            //小区区位特色
            LabelPositionAdvantage.Text = getMainPage.Position_advantage.ToString();
            //小区存在的主要问题及解决程度描述
            LabelMainProblemSolution.Text = getMainPage.Main_problem_solution.ToString();
            //2013年及之前专项资金项目个数
            LabelProjectNum2013.Text = getMainPage.Project_num_2013.ToString();
            //2014年及之后专项资金项目个数
            LabelProjectNum2014.Text = getMainPage.Project_num_2014.ToString();
            //2013年项目完工比例
            LabelProjectComRate2013.Text = getNoNaN(Convert.ToDouble(getMainPage.Project_com_rate_2013).ToString("0.00"));
            //2014年项目完工比例
            LabelProjectComRate2014.Text =getNoNaN(Convert.ToDouble(getMainPage.Project_com_rate_2014).ToString("0.00"));
            //累计专项资金下达
            LabelFoundsDown.Text = getMainPage.Founds_down.ToString();
            //累计专项资金完成
            LabelFoundsCom.Text = getMainPage.Founds_com.ToString();
            //专项资金完成比率
            LabelFoundsRate.Text = Convert.ToDouble(getMainPage.Founds_rate).ToString("0.00");
            //2013年待建项目
            LabelBeforeCons2013.Text = getMainPage.Before_cons_2013.ToString();
            //2013在建项目
            LabelComCons2013.Text = getMainPage.Com_cons_2013.ToString();
            //2013完建项目
            LabelInCons2013.Text = getMainPage.In_cons_2013.ToString();
            //2014待建项目
            LabelBeforeCons2014.Text = getMainPage.Before_cons_2014.ToString();
            //2014在建项目
            LabelComCons2014.Text = getMainPage.Com_cons_2014.ToString();
            //2014完建项目
            LabelInCons2014.Text = getMainPage.In_cons_2014.ToString();
            //计划投资——统建房安全
            LabelPlanHouseSafe.Text = getMainPage.Plan_house_safe.ToString();
            //计划投资——基础设施
            LabelPlanBaseFac.Text = getMainPage.Plan_base_fac.ToString();
            //计划投资——环保设施
            LabelPlanEnvirPro.Text = getMainPage.Plan_envir_pro.ToString();
            //计划投资——公共设施
            LabelPlanPublicFac.Text = getMainPage.Plan_public_fac.ToString();
            //计划投资——营商环境
            LabelPlanBusin.Text = getMainPage.Plan_busin.ToString();
            //完成投资——统建房安全
            LabelComHouseSafe.Text = getMainPage.Com_house_safe.ToString();
            //完成投资——基础设施
            LabelComBaseFac.Text = getMainPage.Com_base_fac.ToString();
            //完成投资——环保设施
            LabelComEnvirPro.Text = getMainPage.Com_envir_pro.ToString();
            //完成投资——公共设施
            LabelComPublicFac.Text = getMainPage.Com_public_fac.ToString();
            //完成投资——营商环境
            LabelComBusin.Text = getMainPage.Com_busin.ToString();
            ////小区帮扶指数
            //LabelHelpFigure.Text = getMainPage.Help_figure.ToString();
            ////小区发展指数
            //LabelDevelopFigure.Text = getMainPage.Develop_figure.ToString();
            //小区地址
            LabelAddress.Text = getMainPage.Address.ToString();
            //小区管理负责人姓名
            LabelManaChargeName.Text = getMainPage.Mana_charge_name;
            //小区管理负责人电话
            LabelManaChargePhone.Text = getMainPage.Mana_charge_phone;
            //小区管理联系人电话
            LabelManaContactPhone.Text = getMainPage.Mana_contact_phone;
            //综合监测负责人姓名
            LabelMoniChargeName.Text = getMainPage.Moni_charge_name;
            //综合监测负责人电话
            LabelMoniChargePhone.Text = getMainPage.Moni_charge_phone;
            //综合监测联系人电话
            LabelMoniContactPhone.Text = getMainPage.Moni_contact_phone;
            #endregion 首页数据
        }

        /// <summary>
        /// 获取小区房屋居住安全数据
        /// </summary>
        private void togetHouseSafety()
        {
            #region 房屋居住安全

            TTG.DAL.GET.get_house_safety getHouseSafety = new DAL.GET.get_house_safety(com_province, com_county, com_name);
            //2013年小区统建房栋数
            LabelSystemBuilding2013.Text = getHouseSafety.System_building_2013.ToString();
            //当前小区统建房栋数
            LabelSystemBuildingNow.Text = getHouseSafety.System_building_now.ToString();
            //2013年轻微变形开裂面积
            LabelCrackArea2013.Text = getHouseSafety.Crack_area_2013.ToString();
            //当前轻微变形开裂面积
            LabelCrackAreaNow.Text = getHouseSafety.Crack_area_now.ToString();
            //2013年房屋地基沉降面积
            LabelFoundationDown2013.Text = getHouseSafety.Foundation_down_2013.ToString();
            //当前房屋地基沉降面积
            LabelFoundationDownNow.Text = getHouseSafety.Foundation_down_now.ToString();
            //2013年危房面积
            LabelDangerous2013.Text = getHouseSafety.Dangerous_2013.ToString();
            //当前危房面积
            LabelDangerousNow.Text = getHouseSafety.Dangerous_now.ToString();
            //2013年屋顶漏水面积
            LabelLeakage2013.Text = getHouseSafety.Leakage_2013.ToString();
            //当前屋顶漏水面积
            LabelLeakageNow.Text = getHouseSafety.Leakage_now.ToString();
            //2013年瓷砖脱落面积
            LabelTileFall2013.Text = getHouseSafety.Leakage_now.ToString();
            //当前瓷砖陀螺面积
            LabelTileFallNow.Text = getHouseSafety.Tile_fall_now.ToString();
            //2013年边坡未治理幢数
            LabelSlopeNdeal2013.Text = getHouseSafety.Slope_ndeal_2013.ToString();
            //当前边坡未治理幢数
            LabelSlopeNdealNow.Text = getHouseSafety.Slope_ndeal_now.ToString();
            //计划结构安全幢数
            LabelStructSafeNumPlan.Text = getHouseSafety.Struct_safe_num_plan.ToString();
            //完成结构安全幢数
            LabelStructSafeNumCom.Text = getHouseSafety.Struct_safe_num_com.ToString();
            //计划屋顶防漏幢数
            LabelLeakProofNumPlan.Text = getHouseSafety.Leak_proof_num_plan.ToString();
            //完成屋顶防漏幢数
            LabelLeakProofNumCom.Text = getHouseSafety.Leak_proof_num_com.ToString();
            //计划外墙修复幢数
            LabelRepairWallNumPlan.Text = getHouseSafety.Repair_wall_num_plan.ToString();
            //完成外墙修复幢数
            LabelRepairWallNumCom.Text = getHouseSafety.Repair_wall_num_com.ToString();
            //计划边坡未治理设计房屋居民人数
            LabelSlopePeopleNumPlan.Text = getHouseSafety.Slope_people_num_plan.ToString();
            //完成边坡未治理涉及房屋居民人数
            LabelSlopePeopleNumCom.Text = getHouseSafety.Slope_people_num_com.ToString();
            //计划结构安全面积
            LabelStructSafeAreaPlan.Text = getHouseSafety.Struct_safe_area_plan.ToString();
            //完成结构安全面积
            LabelStructSafeAreaCom.Text = getHouseSafety.Struct_safe_area_com.ToString();
            //计划屋顶防漏面积
            LabelLeakProofAreaPlan.Text = getHouseSafety.Leak_proof_area_plan.ToString();
            //完成屋顶防漏面积
            LabelLeakProofAreaCom.Text = getHouseSafety.Leak_proof_area_com.ToString();
            //计划外墙修复面积
            LabelRepairWallAreaPlan.Text = getHouseSafety.Repair_wall_area_plan.ToString();
            //完成外墙修复面积
            LabelRepairWallAreaCom.Text = getHouseSafety.Repair_wall_area_com.ToString();
            //计划边坡治理面积
            LabelSlopeDealPlan.Text = getHouseSafety.Slope_deal_plan.ToString();
            //完成边坡治理面积
            LabelSlopeDealCom.Text = getHouseSafety.Slope_deal_com.ToString();
            //2013年结构完好率
            LabelStructSafeRate2013.Text = getPercent(getHouseSafety.Struct_safe_rate_2013.ToString());
            //当前结构完好率
            LabelStructSafeRateNow.Text = getPercent(getHouseSafety.Struct_safe_rate_now.ToString());
            //2013年屋顶完好率
            LabelRoofComRate2013.Text = getPercent(getHouseSafety.Roof_com_rate_2013.ToString());
            //当前屋顶完好率
            LabelRoofComRateNow.Text = getPercent(getHouseSafety.Roof_com_rate_now.ToString());
            //2013年房屋外墙完好率
            LabelWallComRate2013.Text = getPercent(getHouseSafety.Wall_com_rate_2013.ToString());
            //当前房屋外墙完好率
            LabelWallComRateNow.Text = getPercent(getHouseSafety.Wall_com_rate_now.ToString());
            //2013年边坡安全稳定程度
            LabelSlopeStableRate2013.Text = getPercent(getHouseSafety.Struct_safe_rate_2013.ToString());
            //当前边坡安全稳定程度
            LabelSlopeStableRateNow.Text = getPercent(getHouseSafety.Slope_stable_rate_now.ToString());
            #endregion 房屋居住安全
        }

        /// <summary>
        /// 获取小区基础设施数据
        /// </summary>
        private void togetBaseFacilities()
        {
            #region 基础设施
            TTG.DAL.GET.get_base_facilities getBaseFacilities = new DAL.GET.get_base_facilities(com_province, com_county, com_name);
            //断头路条数
            LabelBrokenRoadNum2013.Text = getBaseFacilities.Broken_road_num_2013.ToString();
            LabelBrokenRoadNumNow.Text = getBaseFacilities.Broken_road_num_now.ToString();
            //小区内部分区域连接路缺乏
            LabelLackLinkNum2013.Text = getBaseFacilities.Lack_link_num_2013.ToString();
            LabelLackLinkNumNow.Text = getBaseFacilities.Lack_link_num_now.ToString();
            //未硬化面积
            LabelNotHardArea2013.Text = getBaseFacilities.Not_hard_area_2013.ToString();
            LabelNotHardAreaNow.Text = getBaseFacilities.Not_hard_area_now.ToString();
            //机动车道路面损坏面积
            LabelRoadBroken2013.Text = getBaseFacilities.Road_broken_2013.ToString();
            LabelRoadBrokenNow.Text = getBaseFacilities.Road_broken_now.ToString();
            //人行道路面损坏面积
            LabelSidewalkBroken2013.Text = getBaseFacilities.Sidewalk_broken_2013.ToString();
            LabelSidewalkBrokenNow.Text = getBaseFacilities.Sidewalk_broken_now.ToString();
            //缺乏人行道条数
            LabelLackSidewalk2013.Text = getBaseFacilities.Lack_sidewalk_2013.ToString();
            LabelLackSidewalkNow.Text = getBaseFacilities.Lack_sidewalk_now.ToString();
            //供水量不足涉及住宅户数
            LabelInadequateWater2013.Text = getBaseFacilities.Inadequate_water_2013.ToString();
            LabelInadequateWaterNow.Text = getBaseFacilities.Inadequate_water_now.ToString();
            //供水压力不足涉及住宅户数
            LabelWaterPressure2013.Text = getBaseFacilities.Water_pressure_2013.ToString();
            LabelWaterPressureNow.Text = getBaseFacilities.Water_pressure_now.ToString();
            //供水条件未落实一户一表设计住宅户数
            LabelNotOneOne2013.Text = getBaseFacilities.Not_one_one_2013.ToString();
            LabelNotOneOneNow.Text = getBaseFacilities.Not_one_one_now.ToString();
            //供电量不足涉及住宅户数
            LabelElecInade2013.Text = getBaseFacilities.Elec_inade_2013.ToString();
            LabelElecInadeNow.Text = getBaseFacilities.Elec_inade_now.ToString();
            //供电条件未落实“一户一表”涉及住宅户数
            LabelNotEOneOne2013.Text = getBaseFacilities.Not_e_one_one_2013.ToString();
            LabelNotEOneOneNow.Text = getBaseFacilities.Not_e_one_one_now.ToString();
            //小区楼道照明损坏涉及户数
            LabelLightDamage2013.Text = getBaseFacilities.Light_damage_2013.ToString();
            LabelLightDamageNow.Text = getBaseFacilities.Light_damage_now.ToString();
            //室内消火栓不足涉及建筑数量
            LabelinFfLess2013.Text = getBaseFacilities.In_ff_less_2013.ToString();
            LabelinFfLessNow.Text = getBaseFacilities.In_ff_less_now.ToString();
            //小区供水管道损坏长度
            LabelPipeDamage2013.Text = getBaseFacilities.Pipe_damage_2013.ToString();
            LabelPipeDamageNow.Text = getBaseFacilities.Pipe_damage_now.ToString();
            //小区老化和损坏供电线路长度
            LabelLinkDamage2013.Text = getBaseFacilities.Link_damage_2013.ToString();
            LabelLinkDamageNow.Text = getBaseFacilities.Link_damage_now.ToString();
            //无路灯路段数量
            LabelNoLight2013.Text = getBaseFacilities.No_light_2013.ToString();
            LabelNoLightNow.Text = getBaseFacilities.No_light_now.ToString();
            //路灯数量少、照度不足的路段数量
            LabelLessLight2013.Text = getBaseFacilities.Less_light_2013.ToString();
            LabelLessLightNow.Text = getBaseFacilities.Less_light_now.ToString();
            //室外消火栓数量不足涉及路段
            LabelOutFfLess2013.Text = getBaseFacilities.Out_ff_less_2013.ToString();
            LabeloutFfLessNow.Text = getBaseFacilities.Out_ff_less_now.ToString();
            //消防通道不达标长度
            LabelExitsNotCom2013.Text = getBaseFacilities.Exits_not_com_2013.ToString();
            LabelExitsNotComNow.Text = getBaseFacilities.Exits_not_com_now.ToString();
            //新增连接路数量
            LabelAddLinkNumPlan.Text = getBaseFacilities.Add_link_num_plan.ToString();
            LabelAddLinkNumCom.Text = getBaseFacilities.Add_link_num_com.ToString();
            //新增供水增压设施
            LabelAddWaterPressPlan.Text = getBaseFacilities.Add_water_press_plan.ToString();
            LabelAddWaterPressCom.Text = getBaseFacilities.Add_water_press_com.ToString();
            //水表安装户数
            LabelAddMeterPlan.Text = getBaseFacilities.Add_meter_plan.ToString();
            LabelAddMeterCom.Text = getBaseFacilities.Add_meter_com.ToString();
            //变压器安装改造
            LabelRepairTransPlan.Text = getBaseFacilities.Repair_trans_plan.ToString();
            LabelRepairTransCom.Text = getBaseFacilities.Repair_trans_com.ToString();
            //电表安装
            LabelInstallTransPlan.Text = getBaseFacilities.Install_trans_plan.ToString();
            LabelInstallTransCom.Text = getBaseFacilities.Install_trans_com.ToString();
            //新增楼栋照明设施数量
            LabelAddInLightPlan.Text = getBaseFacilities.Add_in_light_plan.ToString();
            LabelAddInLightCom.Text = getBaseFacilities.Add_in_light_com.ToString();
            //修复楼栋照明设施数量
            LabelRepairInLightPlan.Text = getBaseFacilities.Repair_in_light_plan.ToString();
            LabelRepairInLightCom.Text = getBaseFacilities.Repair_in_light_com.ToString();
            //新增室外消防设施数量
            LabelAddOutFfPlan.Text = getBaseFacilities.Add_out_ff_plan.ToString();
            LabelAddOutFfCom.Text = getBaseFacilities.Add_out_ff_com.ToString();
            //新增室内消防设施数量
            LabelAddInFfPlan.Text = getBaseFacilities.Add_in_ff_plan.ToString();
            LabelAddInFfCom.Text = getBaseFacilities.Add_in_ff_com.ToString();
            //新建机动车道面积
            LabelAddRoadAreaPlan.Text = getBaseFacilities.Add_road_area_plan.ToString();
            LabelAddRoadAreaCom.Text = getBaseFacilities.Add_road_area_com.ToString();
            //硬化机动车道面积
            LabelHardenRoadAreaPlan.Text = getBaseFacilities.Harden_road_area_plan.ToString();
            LabelHardenRoadAreaCom.Text = getBaseFacilities.Harden_road_area_com.ToString();
            //维修改造机动车道面积
            LabelRepairRoadAreaPlan.Text = getBaseFacilities.Repair_road_area_plan.ToString();
            LabelRepairRoadAreaCom.Text = getBaseFacilities.Repair_road_area_com.ToString();
            //人行道地砖改造面积
            LabelChangeSidewalkPlan.Text = getBaseFacilities.Change_sidewalk_plan.ToString();
            LabelChangeSidewalkCom.Text = getBaseFacilities.Change_sidewalk_com.ToString();
            //新增人行道
            LabelAddSidewalkPlan.Text = getBaseFacilities.Add_sidewalk_plan.ToString();
            LabelAddSidewalkCom.Text = getBaseFacilities.Add_sidewalk_com.ToString();
            //新增供水容量
            LabelAddWaterCapPlan.Text = getBaseFacilities.Add_water_cap_plan.ToString();
            LabelAddWaterCapCom.Text = getBaseFacilities.Add_water_cap_com.ToString();
            //新建供水管长度
            LabelAddPipeLengthPlan.Text = getBaseFacilities.Add_pipe_length_plan.ToString();
            LabelAddPipeLengthCom.Text = getBaseFacilities.Add_pipe_length_com.ToString();
            //维修改造供水管长度
            LabelrepairPipeLengthPlan.Text = getBaseFacilities.Repair_pipe_length_plan.ToString();
            LabelRepairPipeLengthCom.Text = getBaseFacilities.Repair_pipe_length_com.ToString();
            //新增变压器后增容
            LabelAddTransPlan.Text = getBaseFacilities.Add_trans_plan.ToString();
            LabelAddTransCom.Text = getBaseFacilities.Add_trans_com.ToString();
            //更换变压器后增容
            LabelChangeTransPlan.Text = getBaseFacilities.Change_trans_plan.ToString();
            LabelChangeTransCom.Text = getBaseFacilities.Change_trans_com.ToString();
            //新建配电线路
            LabelAddLinePlan.Text = getBaseFacilities.Add_line_plan.ToString();
            LabelAddLineCom.Text = getBaseFacilities.Add_line_com.ToString();
            //维修改造配电线路
            LabelRepairLinePlan.Text = getBaseFacilities.Repair_line_plan.ToString();
            LabelRepairLineCom.Text = getBaseFacilities.Repair_line_com.ToString();
            //新增室外照明覆盖路段
            LabelAddOutLightPlan.Text = getBaseFacilities.Add_out_light_plan.ToString();
            LabelAddOutLightCom.Text = getBaseFacilities.Add_out_light_com.ToString();
            //修复室外照明覆盖路段
            LabelRepairOutLightPlan.Text = getBaseFacilities.Repair_out_light_plan.ToString();
            LabelRepairOutLightCom.Text = getBaseFacilities.Repair_out_light_com.ToString();
            //消防通道改造
            LabelRepairExitsPlan.Text = getBaseFacilities.Repair_exits_plan.ToString();
            LabelRepairExitsCom.Text = getBaseFacilities.Repair_exits_com.ToString();
            //道路通达程度
            LabelRoadAccessRate2013.Text = getPercent(getBaseFacilities.Road_access_rate_2013.ToString());
            LabelRoadAccessRateNow.Text = getPercent(getBaseFacilities.Road_access_rate_now.ToString());
            //道路通畅程度
            LabelRoadClearRate2013.Text = getPercent(getBaseFacilities.Road_clear_rate_2013.ToString());
            LabelRoadClearRateNow.Text = getPercent(getBaseFacilities.Road_clear_rate_now.ToString());
            //供水能力保障程度
            LabelWaterSupplyGuarRate2013.Text = getPercent(getBaseFacilities.Water_supply_guar_rate_2013.ToString());
            LabelWaterSupplyGuarRateNow.Text = getPercent(getBaseFacilities.Water_supply_guar_rate_now.ToString());
            //供水管网完善程度
            LabelWaterPipeLineComRate2013.Text = getPercent(getBaseFacilities.Water_pipe_line_com_rate_2013.ToString());
            LabelWaterPipeLineComRateNow.Text = getPercent(getBaseFacilities.Water_pipe_line_com_rate_now.ToString());
            //供水一户一表实现率
            LabelWaterDoubleOneRate2013.Text = getPercent(getBaseFacilities.Water_pipe_line_com_rate_2013.ToString());
            LabelWaterDoubleOneRateNow.Text = getPercent(getBaseFacilities.Water_pipe_line_com_rate_now.ToString());
            //供电容量保障率
            LabelElecCapaGuarRate2013.Text = getPercent(getBaseFacilities.Elec_capa_guar_rate_2013.ToString());
            LabelElecCapaGuarRateNow.Text = getPercent(getBaseFacilities.Elec_capa_guar_rate_now.ToString());
            //供电线路安全程度
            LabelElecLineSafeRate2013.Text = getPercent(getBaseFacilities.Elec_line_safe_rate_2013.ToString());
            LabelElecLineSafeRateNow.Text = getPercent(getBaseFacilities.Elec_line_safe_rate_now.ToString());
            //供电一户一表实现率
            LabelElecDoubleOneRate2013.Text = getPercent(getBaseFacilities.Elec_double_one_rate_2013.ToString());
            LabelElecDoubleOneRateNow.Text = getPercent(getBaseFacilities.Elec_double_one_rate_now.ToString());
            //室外公共照明达标率（无）
            LabelOutLightComRate2013.Text = getPercent(getBaseFacilities.Out_light_com_rate_2013.ToString());
            LabelOutLightComRateNow.Text = getPercent(getBaseFacilities.Out_light_com_rate_now.ToString());
            //室内公共照明达标率
            LabelInLightComRate2013.Text = getPercent(getBaseFacilities.In_light_com_rate_2013.ToString());
            LabelinLightComRateNow.Text = getPercent(getBaseFacilities.In_light_com_rate_now.ToString());
            //室外消防设施达标率
            LabelOutFfComRate2013.Text = getPercent(getBaseFacilities.Out_ff_com_rate_2013.ToString());
            LabelOutFfComRateNow.Text = getPercent(getBaseFacilities.Out_ff_com_rate_now.ToString());
            //室内消防设施达标率(非数字)
            LabelInFfComRate2013.Text = getPercent(getBaseFacilities.In_ff_com_rate_2013.ToString());
            LabelInFfComRateNow.Text = getPercent(getBaseFacilities.In_ff_com_rate_now.ToString());
            //消防通道达标率
            LabelFfExitsComRate2013.Text = getPercent(getBaseFacilities.Ff_exits_com_rate_2013.ToString());
            LabelFfExitsComRateNow.Text = getPercent(getBaseFacilities.Ff_exits_com_rate_now.ToString());
            #endregion 基础设施
        }

        /// <summary>
        /// 获取环保设施数据
        /// </summary>
        private void togetEnvProtect()
        {
            #region 环保设施
            TTG.DAL.GET.get_env_protect getEnvProtect = new DAL.GET.get_env_protect(com_province, com_county, com_name);

            //路边垃圾箱不足涉及路段
            LabelLessRoadsideDustbin2013.Text = getEnvProtect.Less_roadside_dustbin_2013.ToString();
            LabelLessRoadsideDustbinNow.Text = getEnvProtect.Less_roadside_dustbin_now.ToString();
            //住宅区垃圾箱设置不足涉及区域
            LabelLessHouseDustbin2013.Text = getEnvProtect.Less_house_dustbin_2013.ToString();
            LabelLessHouseDustbinNow.Text = getEnvProtect.Less_house_dustbin_now.ToString();
            //区域环卫设施不足
            LabelLessSanitation2013.Text = getEnvProtect.Less_roadside_dustbin_2013.ToString();
            LabelLessSanitationNow.Text = getEnvProtect.Less_roadside_dustbin_now.ToString();
            //公厕数量不足涉及区域
            LabelLessToilet2013.Text = getEnvProtect.Less_sanitation_2013.ToString();
            LabelLessToiletNow.Text = getEnvProtect.Less_sanitation_now.ToString();
            //未接入城市污水管网的住宅
            LabelnotInSewageHouse2013.Text = getEnvProtect.Not_in_sewage_house_2013.ToString();
            LabelnotInSewageHouseNow.Text = getEnvProtect.Not_in_sewage_house_now.ToString();
            //生活污水直排溪沟、长江处数
            LabelsewageDitch2013.Text = getEnvProtect.Sewage_ditch_2013.ToString();
            LabelSewageDitchNow.Text = getEnvProtect.Sewage_ditch_now.ToString();
            //小区排水管损坏长度
            LabeldrainPipeDamage2013.Text = getEnvProtect.Drain_pipe_damage_2013.ToString();
            LabelDrainPipeDamageNow.Text = getEnvProtect.Drain_pipe_damage_now.ToString();
            //排(洪)水沟损坏
            LabeldrainDitchDamage2013.Text = getEnvProtect.Drain_ditch_damage_2013.ToString();
            LabelDrainDitchDamageNow.Text = getEnvProtect.Drain_ditch_damage_now.ToString();
            //小区绿地面积
            LabelGreenArea2013.Text = getEnvProtect.Green_area_2013.ToString();
            LabelGreenAreaNow.Text = getEnvProtect.Green_area_now.ToString();
            //排(洪)水沟不足
            LabelLessDrainDitch2013.Text = getEnvProtect.Less_drain_ditch_2013.ToString();
            LabelLessDrainDitchNow.Text = getEnvProtect.Less_drain_ditch_now.ToString();
            //新增垃圾桶箱数量
            LabelAddDustbinPlan.Text = getEnvProtect.Add_dustbin_plan.ToString();
            LabelAddDustbinCom.Text = getEnvProtect.Add_dustbin_com.ToString();
            //新增垃圾中转站数量
            LabelAddGarbageTransferPlan.Text = getEnvProtect.Add_garbage_transfer_plan.ToString();
            LabelAddGarbageTransferCom.Text = getEnvProtect.Add_garbage_transfer_com.ToString();
            //维修改造垃圾中转站数量
            LabelRepairGarbageTransferPlan.Text = getEnvProtect.Repair_garbage_transfer_plan.ToString();
            LabelrepairGarbageTransferCom.Text = getEnvProtect.Repair_garbage_transfer_com.ToString();
            //新增公厕
            LabelAddToiletPlan.Text = getEnvProtect.Add_toilet_plan.ToString();
            LabelAddToiletCom.Text = getEnvProtect.Add_toilet_com.ToString();
            //维修改造公厕
            LabelRepairToiletPlan.Text = getEnvProtect.Repair_toilet_plan.ToString();
            LabelRepairToiletCom.Text = getEnvProtect.Repair_toilet_com.ToString();
            //新建化粪池数量
            LabelAddSepticTankPlan.Text = getEnvProtect.Add_septic_tank_plan.ToString();
            LabelAddSepticTankCom.Text = getEnvProtect.Add_septic_tank_com.ToString();
            //植树
            LabelPlantTreesPlan.Text = getEnvProtect.Plant_trees_plan.ToString();
            LabelPlantTreesCom.Text = getEnvProtect.Plant_trees_com.ToString();
            //维修改造污水管网长度
            LabelRepairSewagePlan.Text = getEnvProtect.Repair_sewage_plan.ToString();
            LabelRepairSewageCom.Text = getEnvProtect.Repair_sewage_com.ToString();
            //新建污水管网长度
            LabelAddSewagePlan.Text = getEnvProtect.Add_sewage_plan.ToString();
            LabelAddSewageCom.Text = getEnvProtect.Add_sewage_com.ToString();
            //新建排水管长度
            LabelAddDrainPlan.Text = getEnvProtect.Add_drain_plan.ToString();
            LabelAddDrainCom.Text = getEnvProtect.Add_drain_com.ToString();
            //维修改造排水管长度
            LabelRepairDrainPlan.Text = getEnvProtect.Repair_drain_plan.ToString();
            LabelRepairDrainCom.Text = getEnvProtect.Repair_drain_com.ToString();
            //新建排(洪)水沟长度
            LabelAddDitchPlan.Text = getEnvProtect.Add_ditch_plan.ToString();
            LabelAddDitchCom.Text = getEnvProtect.Add_ditch_com.ToString();
            //维修改造排(洪)水沟长度
            LabelRepairDitchPlan.Text = getEnvProtect.Repair_ditch_plan.ToString();
            LabelRepairDitchCom.Text = getEnvProtect.Repair_ditch_com.ToString();
            //新增绿化面积
            LabelAddGreenPlan.Text = getEnvProtect.Add_green_plan.ToString();
            LabelAddGreenCom.Text = getEnvProtect.Add_green_com.ToString();
            //垃圾收集能力达标率
            LabelGarbageCollectRate2013.Text = getPercent(getEnvProtect.Garbage_collect_rate_2013.ToString());
            LabelGarbageCollectRateNow.Text = getPercent(getEnvProtect.Garbage_collect_rate_now.ToString());
            //公共厕所覆盖程度
            LabelToiletCoverageRate2013.Text = getPercent(getEnvProtect.Toilet_coverage_rate_2013.ToString());
            LabelToiletCoverageRateNow.Text = getPercent(getEnvProtect.Toilet_coverage_rate_now.ToString());
            //生活污水收集能力达标率
            LabelSewageCollectRate2013.Text = getPercent(getEnvProtect.Sewage_collect_rate_2013.ToString());
            LabelSewageCollectRateNow.Text = getPercent(getEnvProtect.Sewage_collect_rate_now.ToString());
            //排水安全保障程度
            LabelDrainSafeRate2013.Text = getPercent(getEnvProtect.Drain_safe_rate_2013.ToString());
            LabelDrainSafeRateNow.Text = getPercent(getEnvProtect.Drain_safe_rate_now.ToString());
            //小区绿化率
            LabelGreenRate2013.Text = getPercent(getEnvProtect.Green_rate_2013.ToString());
            LabelGreenRateNow.Text = getPercent(getEnvProtect.Green_rate_now.ToString());
            #endregion 环保设施
        }


        /// <summary>
        /// 获取公共服务设施数据
        /// </summary>
        private void togetPublicServices()
        {
            #region 公共服务设施
            TTG.DAL.GET.get_public_service getPublicServices = new DAL.GET.get_public_service(com_province, com_county, com_name);

            //幼儿园容量（人）
            LabelKindergartenCap2013.Text = getPublicServices.Kindergarten_cap_2013.ToString();
            LabelKindergartenCapNow.Text = getPublicServices.Kindergarten_cap_now.ToString();
            //小区卫生室床位数
            LabelClinicBed2013.Text = getPublicServices.Clinic_bed_2013.ToString();
            LabelClinicBedNow.Text = getPublicServices.Clinic_bed_now.ToString();
            //健身器材（套数）
            LabelFitnessEquipment2013.Text = getPublicServices.Fitness_equipment_2013.ToString();
            LabelFitnessEquipmentNow.Text = getPublicServices.Fitness_equipment_now.ToString();
            //教学面积
            LabelTeachingArea2013.Text = getPublicServices.Teaching_area_2013.ToString();
            LabelTeachingAreaNow.Text = getPublicServices.Teaching_area_now.ToString();
            //室外活动面积
            LabeloutPlayArea2013.Text = getPublicServices.Out_play_area_2013.ToString();
            LabelOutPlayAreaNow.Text = getPublicServices.Out_play_area_now.ToString();
            //小区卫生室面积
            LabelClinicArea2013.Text = getPublicServices.Clinic_area_2013.ToString();
            LabelClinicAreaNow.Text = getPublicServices.Clinic_area_now.ToString();
            //室外活动场地面积
            LabeloutGroundArea2013.Text = getPublicServices.Out_ground_area_2013.ToString();
            LabeloutGroundAreaNow.Text = getPublicServices.Out_ground_area_now.ToString();
            //室内活动场地面积
            LabelinGroundArea2013.Text = getPublicServices.In_ground_area_2013.ToString();
            LabelinGroundAreaNow.Text = getPublicServices.In_ground_area_now.ToString();
            //养老院面积
            LabelOldArea2013.Text = getPublicServices.Old_area_2013.ToString();
            LabelOldAreaNow.Text = getPublicServices.Old_area_now.ToString();
            //社区综合管理用房面积
            LabelManagementArea2013.Text = getPublicServices.Management_area_2013.ToString();
            LabelManagementAreaNow.Text = getPublicServices.Management_area_now.ToString();
            //停车场面积
            LabelParkingArea2013.Text = Convert.ToDouble(getPublicServices.Parking_area_2013.ToString()).ToString("0.00")+"W";
            LabelParkingAreaNow.Text = Convert.ToDouble(getPublicServices.Parking_area_now.ToString()).ToString("0.00")+"W";
            //农贸市场面积
            LabelFarmArea2013.Text = getPublicServices.Farm_area_2013.ToString()+"W";
            LabelFarmAreaNow.Text = getPublicServices.Farm_area_now.ToString()+"W";
            //便民超市面积
            LabelMarketArea2013.Text = getPublicServices.Market_area_now.ToString();
            LabelMarketAreaNow.Text = getPublicServices.Market_area_now.ToString();
            //新增幼儿园容量
            LabelAddKindergartenCapPlan.Text = getPublicServices.Add_kindergarten_cap_plan.ToString();
            LabelAddKindergartenCapCom.Text = getPublicServices.Add_kindergarten_cap_com.ToString();
            //改扩建幼儿园容量
            LabelChangeKinderCapPlan.Text = getPublicServices.Change_kinder_cap_plan.ToString();
            LabelChangeKinderCapCom.Text = getPublicServices.Change_kinder_cap_com.ToString();
            //新增卫生室床位数
            LabelAddBedPlan.Text = getPublicServices.Add_bed_plan.ToString();
            LabelAddBedCom.Text = getPublicServices.Add_bed_com.ToString();
            //新增健身器材
            LabelAddFitnessPlan.Text = getPublicServices.Add_fitness_plan.ToString();
            LabelAddFitnessCom.Text = getPublicServices.Add_fitness_com.ToString();
            //新增教学面积
            LabelAddTeachingAreaPlan.Text = getPublicServices.Add_teaching_area_plan.ToString();
            LabelAddTeachingAreaCom.Text = getPublicServices.Add_teaching_area_com.ToString();
            //新增幼儿园活动场地
            LabelAddKinderGroundPlan.Text = getPublicServices.Add_kindergarten_cap_plan.ToString();
            LabelAddKinderGroundCom.Text = getPublicServices.Add_kindergarten_cap_com.ToString();
            //新增卫生室面积
            LabelAddClinicPlan.Text = getPublicServices.Add_clinic_plan.ToString();
            LabelAddClinicCom.Text = getPublicServices.Add_clinic_com.ToString();
            //维修改造卫生室面积
            LabelRepairClinicPlan.Text = getPublicServices.Repair_clinic_plan.ToString();
            LabelRepairClinicCom.Text = getPublicServices.Repair_clinic_com.ToString();
            //新增室外活动场地面积
            LabelAddOutGroundPlan.Text = getPublicServices.Add_out_ground_plan.ToString();
            LabelAddOutGroundCom.Text = getPublicServices.Add_out_ground_com.ToString();
            //改造室外活动场地面积
            LabelRepairOutGroundPlan.Text = getPublicServices.Repair_out_ground_plan.ToString();
            LabelRepairOutGroundCom.Text = getPublicServices.Repair_out_ground_com.ToString();
            //新增建设室内活动场所面积
            LabelAddInGroundPlan.Text = getPublicServices.Add_in_ground_plan.ToString();
            LabelAddInGroundCom.Text = getPublicServices.Add_in_ground_com.ToString();
            //新增养老设施面积
            LabelAddOldPlan.Text = getPublicServices.Add_old_plan.ToString();
            LabelAddOldCom.Text = getPublicServices.Add_old_com.ToString();
            //新增社区综合管理用房
            LabelAddManageHousePlan.Text = getPublicServices.Add_manage_house_plan.ToString();
            LabelAddManageHouseCom.Text = getPublicServices.Add_manage_house_com.ToString();
            //新增停车场面积
            LabelAddParkingPlan.Text = getPublicServices.Add_parking_plan.ToString();
            LabelAddParkingCom.Text = getPublicServices.Add_parking_com.ToString();
            //新增农贸市场面积
            LabelAddFarmAreaPlan.Text = getPublicServices.Add_farm_area_plan.ToString();
            LabelAddFarmAreaCom.Text = getPublicServices.Add_farm_area_com.ToString();
            //新增便民超市面积
            LabelAddMarketPlan.Text = getPublicServices.Add_market_plan.ToString();
            LabelAddMarketCom.Text = getPublicServices.Add_market_com.ToString();
            //幼儿园配置达标率
            LabelKinderRate2013.Text = getPercent(getPublicServices.Kinder_rate_2013.ToString());
            LabelKinderRateNow.Text = getPercent(getPublicServices.Kinder_rate_now.ToString());
            //社区医疗配置达标率
            LabelMedicalRate2013.Text = getPercent(getPublicServices.Medical_rate_2013.ToString());
            LabelMedicalRateNow.Text = getPercent(getPublicServices.Medical_rate_now.ToString());
            //文化健身设施配置达标率
            LabelCultureSportsRate2013.Text = getPercent(getPublicServices.Culture_sports_rate_2013.ToString());
            LabelCultureSportsRateNow.Text = getPercent(getPublicServices.Culture_sports_rate_now.ToString());
            //养老设施配置达标率
            LabelOldFacilitiesRate2013.Text = getPercent(getPublicServices.Old_facilities_rate_2013.ToString());
            LabelOldFacilitiesRateNow.Text = getPercent(getPublicServices.Old_facilities_rate_now.ToString());
            //综合管理用房配置达标率
            LabelManageRate2013.Text = getPercent(getPublicServices.Manage_rate_2013.ToString());
            LabelManageRateNow.Text = getPercent(getPublicServices.Manage_rate_now.ToString());
            //停车设施配置达标率
            LabelParkingRate2013.Text = getPercent(getPublicServices.Parking_rate_2013.ToString());
            LabelParkingRateNow.Text = getPercent(getPublicServices.Parking_rate_now.ToString());
            //菜市场配置达标率
            LabelFarmRate2013.Text = getPercent(getPublicServices.Farm_area_2013.ToString());
            LabelFarmRateNow.Text = getPercent(getPublicServices.Farm_area_now.ToString());
            //便民店配置达标率
            LabelMarketRate2013.Text = getPercent(getPublicServices.Market_rate_2013.ToString());
            LabelMarketRateNow.Text = getPercent(getPublicServices.Market_rate_now.ToString());
            #endregion 公共服务设施
        }

        /// <summary>
        /// 获取营商环境数据
        /// </summary>
        private void togetBusiness()
        {
            #region 营商环境
            TTG.DAL.GET.get_business getBusiness = new DAL.GET.get_business(com_province, com_county, com_name);
            //小区门面数
            LabelFacadeNum2013.Text = getBusiness.Facade_num_2013.ToString();
            LabelFacadeNumNow.Text = getBusiness.Facade_num_now.ToString();
            //出租经营门面数
            LabelRentFacade2013.Text = getBusiness.Rent_facade_2013.ToString();
            LabelRentFacadeNow.Text = getBusiness.Rent_facade_now.ToString();
            //门面平均出租租金
            LabelAverageRent2013.Text = getBusiness.Average_rent_2013.ToString();
            LabelAverageRentNow.Text = getBusiness.Average_rent_now.ToString();
            //街区风貌较差
            LabelBlock2013.Text = getBusiness.Block_2013.ToString();
            LabelBlockNow.Text = getBusiness.Block_now.ToString();
            //缺乏专业市场\
            LabelProfessional2013.Text = getBusiness.Professional_2013.ToString();
            LabelProfessionalNow.Text = getBusiness.Professional_now.ToString();
            //改造门面数量
            LabelChangeFacadePlan.Text = getBusiness.Change_facade_plan.ToString();
            LabelChangeFacadeCom.Text = getBusiness.Change_facade_com.ToString();
            //涉及商户数量
            LabelBusinessNumPlan.Text = getBusiness.Business_num_plan.ToString();
            LabelBusinessNumCom.Text = getBusiness.Business_num_com.ToString();
            //改造门面面积
            LabelChangeFacadeAreaPlan.Text = getBusiness.Change_facade_area_plan.ToString();
            LabelChangeFacadeAreaCom.Text = getBusiness.Change_facade_area_com.ToString();
            //改造街区长度
            LabelChangeBlockPlan.Text = getBusiness.Change_block_plan.ToString();
            LabelChangeBlockCom.Text = getBusiness.Change_block_com.ToString();
            //改造外立面
            LabelChangeOutPlan.Text = getBusiness.Change_block_plan.ToString();
            LabelChangeOutCom.Text = getBusiness.Change_block_com.ToString();
            //建设市场面积
            LabelChangeMarketPlan.Text = getBusiness.Change_market_plan.ToString();
            LabelChangeMarketCom.Text = getBusiness.Change_market_com.ToString();
            //门面利用率
            LabelFacadeUseRate2013.Text = getPercent(getBusiness.Facade_use_rate_2013.ToString());
            LabelFacadeUseRateNow.Text = getPercent(getBusiness.Facade_use_rate_now.ToString());
            //门面利用率
            LabelRentLevel2013.Text = getPercent(getBusiness.Rent_level_2013.ToString());
            LabelRentLevelNow.Text = getPercent(getBusiness.Rent_level_now.ToString());
            #endregion 营商环境
        }
       /// <summary>
       /// 获得四个折线图的数据
       /// </summary>
        private void getLineChartData()
        {
            TTG.DAL.GET.get_community_mainpage getMainPage = new DAL.GET.get_community_mainpage(com_province, com_county, com_name);
                
            #region 图表    
            //将值保存为字符串传到页面
            string dooruserrate = "";
            string employmentrate = "";
            string pcdi = "";
            string rentrate = "";
            //小区信息
            //小区门面使用率
            double[] FacadeUseRate = getMainPage.Facade_use_rate;
            //小区劳动力就业率
            double[] EmploymentRate = getMainPage.Employment_rate;
            //小区人均可支配收入
            double[] DisposableIncome = getMainPage.Disposable_income;
            //小区房屋平均租金水平
            double[] AverageRent = getMainPage.Average_rent;

            for (int i = 0; i < FacadeUseRate.Length; i++)
            {
                if (FacadeUseRate[i] != 0)
                {
                    dooruserrate += Convert.ToDouble(FacadeUseRate[i]).ToString("0.00") + "-";
                    employmentrate += Convert.ToDouble(EmploymentRate[i]).ToString("0.00") + "-";
                    pcdi += Convert.ToDouble(DisposableIncome[i]).ToString("0.00") + "-";
                    rentrate += Convert.ToDouble(AverageRent[i]).ToString("0.00") + "-";
                }
            }           
            TextBoxVilDoorRate.Text = dooruserrate;
            TextBoxVilEmploymentRate.Text = employmentrate;
            TextBoxVilPcdi.Text = pcdi;
            TextBoxVilRentLevel.Text = rentrate;


            //市信息

            //将值保存为字符串传到页面
            string CityDoor_rate = "";
            string CityEmployment_rate = "";
            string CityPcdi = "";
            string CityRent_level = "";

            double[] FacadeCounty = getMainPage.Facade_county;
            //小区劳动力就业率
            double[] EmploymentCounty = getMainPage.Employment_county;
            //小区人均可支配收入
            double[] DisposableCounty = getMainPage.Disposable_county;
            //小区房屋平均租金水平
            double[] AverageCounty = getMainPage.Average_county;
            for (int i = 0; i < FacadeCounty.Length; i++)
            {
                if (FacadeCounty[i] != 0)
                {
                    CityDoor_rate += Convert.ToDouble(FacadeCounty[i]).ToString("0.00") + "-";
                    CityEmployment_rate += Convert.ToDouble(EmploymentCounty[i]).ToString("0.00") + "-";
                    CityPcdi += Convert.ToDouble(DisposableCounty[i]).ToString("0.00") + "-";
                    CityRent_level += Convert.ToDouble(AverageCounty[i]).ToString("0.00") + "-";
                }
            }     
            TextBoxCityEmploymentRate.Text = CityEmployment_rate;
            TextBoxCityPcdi.Text = CityPcdi;
            TextBoxCityRentLevel.Text = CityRent_level;
            TextBoxCityDoorRate.Text = CityDoor_rate;

            //时间
            string linTime = "";
            string[] time = getMainPage.Time;
            for (int i = 0; i < time.Length; i++)
            {
                if (time[i] != "")
                {
                    linTime += time[i].ToString().Substring(0,6) + "@";
                    
                }
            }
            //TextBoxTime.Text = linTime;
            TextBoxTime.Text = "2013@2014@2015@2016@2017@";
            #endregion 图表

        }

        /// <summary>
        /// 获得两个柱状图的数据
        /// </summary>
       private void getBarChartData() {
           //在建待建完建
           string beforeConstruct = "";
           string inConstruct = "";
           string comConstruct = "";
           //按类别结构划分
           string vilPlancCategory = "";          
           string vilFinishedCategory = "";

           TTG.DAL.GET.get_community_mainpage getMainPage = new DAL.GET.get_community_mainpage(com_province, com_county, com_name);

           //待建
           beforeConstruct = getMainPage.Before_cons_2013.ToString() + "-" + getMainPage.Before_cons_2014.ToString() + "-";     
           //在建
           inConstruct = getMainPage.In_cons_2013.ToString() + "-" + getMainPage.In_cons_2014.ToString() + "-";
           //完建
           comConstruct = getMainPage.Com_cons_2013.ToString() + "-" + getMainPage.Com_cons_2014.ToString() + "-";
           TextBoxBefore.Text = beforeConstruct;
           TextBoxIn.Text = inConstruct;
           TextBoxCom.Text = comConstruct;

           //按类别结构划分计划投资
           vilPlancCategory = getMainPage.Plan_house_safe.ToString() + "-" + getMainPage.Plan_base_fac.ToString() + "-" + getMainPage.Plan_envir_pro.ToString() + "-" + getMainPage.Plan_public_fac.ToString() + "-" + getMainPage.Plan_busin.ToString() + "-";

           //按类别结构划分完成投资
           vilFinishedCategory = getMainPage.Com_house_safe.ToString() + "-" + getMainPage.Com_base_fac.ToString() + "-" + getMainPage.Com_envir_pro.ToString() + "-" + getMainPage.Com_public_fac.ToString() + "-" + getMainPage.Com_busin.ToString() + "-";
           
           TextBoxVilPlan2.Text = vilPlancCategory;
           TextBoxVilFinished2.Text = vilFinishedCategory;
           
           
       }

        /// <summary>
        /// 根据选择的数据得到相应的折线或者柱状图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       protected void showEchartBtn_Click(object sender, EventArgs e)
       {
           showChart();
       }
        /// <summary>
        /// 指标对比页面缺省时的图表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       protected void s_Click(object sender, EventArgs e)
       {
           string startTime = startDate.Value;
           string endTime = endDate.Value;
           string onlyTime = onlyDate.Value;
           if ((startTime == "" || endTime == "") && onlyTime == "")
           {
               showDefaultChart();
           }                   
       }
        /// <summary>
        /// 缺省时生成的图表
        /// </summary>
       public void showDefaultChart() {
           ids.Value = "Structure_safe_good_rate,Roof_good_rate,Wall_good_rate,Slope_safe_rate";
           startDate.Value = "2015-01-14";
           endDate.Value = "2017-01-18";
           showChart();
          
       }

        /// <summary>
        /// 指标对比页面动态生成图表
        /// </summary>
       private void showChart() {
           String cn_indicator = "";//所选指标的中文名字以“-”符号链接起来的string
           String cn_time = "";//所选时间“XXXX年XX月”以@符号链接起来的string
           String onlytime = "";
           String indicatorForYear = "";//用@符号将同一小区不同时间不同指标存入，其中“@”区分同一指标的不同时间的值，不同指标之间用“-”分开
           String difindicator_sameyear = "";//不同指标同一时间，用“-”隔开

           int echartType = 0;
           String indicator = ids.Value;
           String startdate = startDate.Value;
           String enddate = endDate.Value;
           String onlydate = onlyDate.Value;

           String[] indicators = indicator.Split(',');
           for (int i = 0; i < indicators.Length; i++)
           {
               cn_indicator += GetTranslation(indicators[i]) + "-";
           }
           hideindicator.Value = cn_indicator;
           SortedList storeIndicator = new SortedList();
           SortedList storevalue = new SortedList();


           if (startdate != "" && enddate != "")
           {
               String[] date1 = startdate.Split('-');
               String[] date2 = enddate.Split('-');
               int start = int.Parse(date1[0]);//这里获得年份
               int end = int.Parse(date2[0]);
               if (end > start)
               {
                   for (int i = start; i <= end; i++)
                   {
                       cn_time += i + "年" + "@";
                   }
                   hidecom_time.Value = cn_time;
                   for (int i = start; i <= end; i++)
                   {
                       Indicator id = new Indicator(community_id, i);
                       storeIndicator.Add("" + community_id + "-" + i + "年", id);
                   }
                   if (end > start && indicators.Length >= 1)
                   {
                       for (int i = 0; i < indicators.Length; i++)
                       {
                           for (int j = start; j <= end; j++)
                           {
                               //同一指标不同时间的值
                               Indicator c_indicator = (Indicator)storeIndicator["" + community_id + "-" + j + "年"];
                               indicatorForYear += getIndicatorValue(indicators[i], c_indicator).ToString() + "@";
                           }
                           //不同指标之间用“-”隔开
                           indicatorForYear += "-";

                       }
                       hidedata1.Value = indicatorForYear;
                       echartType = 1;
                       //ClientScript.RegisterStartupScript(ClientScript.GetType(), "showscript", "<script>showechart();</script>");
                       ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "", "showechart();", true);
                   }
               }
               else
               {
                   ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "", "alert('结束时间必须大于开始时间!');", true);
               }
           }
           else if (onlydate != "") //同一时间不同指标
           {
               String[] date3 = onlydate.Split('-');
               onlytime = date3[0].ToString();
               hideonlytime.Value = onlytime;
               Indicator id = new Indicator(community_id, int.Parse(onlytime));
               storeIndicator.Add("" + community_id + "-" + onlytime + "年", id);
               if (indicators.Length > 0)
               {
                   for (int i = 0; i < indicators.Length; i++)
                   {
                       Indicator c_indicator = (Indicator)storeIndicator["" + community_id + "-" + onlytime + "年"];
                       difindicator_sameyear += getIndicatorValue(indicators[i], c_indicator).ToString() + "-";

                   }

                   echartType = 2;
                   hidedata2.Value = difindicator_sameyear;

                   ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "showechart", "<script>showechart();</script>", false);
                   
                 
               }
           }
           else
           {
               echartType = 0;

               ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "showechart", "<script>showechart();</script> ", false);
             
           }
           hidecom_ectype.Value = echartType.ToString();
           
       }

       //public string fdate(DateTime time)
       //{
       //    DateTime temp = Convert.ToDateTime("1996-9-16");
       //    if (DateTime.Compare(time, temp) == 0)
       //        return "——";
       //    else
       //        return time.ToString();
       //}

       public string fdate(string time)
       {
           DateTime temp = Convert.ToDateTime("1996-9-6");
           if (time.Equals(temp.ToString())||time=="")
               return "——";
           else
               return time.ToString();
       }

        /// <summary>
        /// 获取英文字段的中文翻译
        /// </summary>
        /// <param name="columnname"></param>
        /// <returns></returns>
        private string GetTranslation(string columnname)
        {
            String s = TTG.DBUtility.TTGutil.getchinese(columnname);
            string name = (s == null) ? columnname : s; //如果此英文字段有翻译，则返回其中文翻译，若无，则保留此英文翻译。  
            return name;
        }

        /// <summary>
        /// 获得字段对应的值
        /// </summary>
        /// <param name="property"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public double getIndicatorValue(String property, Indicator id)
        {
            Type ty = typeof(Indicator);
            PropertyInfo pi = ty.GetProperty(property);
            double value = (double)pi.GetValue(id, null);
            return value;
        }

        /// <summary>
        ///点击门面使用率按钮显示相应图表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void door_rateBtn_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "show_linechart_door", "<script>show_linechart_door();</script> ", false);
        }

        /// <summary>
        /// 点击劳动力就业率按钮显示相应图表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void laborBtn_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "show_linechart_labor", "<script>show_linechart_labor();</script> ", false);
        }

        /// <summary>
        /// 点击人均可支配收入按钮显示相应图表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void incomeBtn_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "show_linechart_income", "<script>show_linechart_income();</script> ", false);
        }

        /// <summary>
        /// 点击房屋租金平均水平按钮显示相应图表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void rentBtn_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "show_linechart_rent", "<script>show_linechart_rent();</script> ", false);
        }
  
        private string  getPercent(string str){
            if (str != "非数字")
            {
                if (str== "100")
                {
                    return "100%";
                }
                else if (str == "0")
                {
                    return "0";
                }
                else if (str == "正无穷大")
                {
                    return "--";
                }
                else
                {
                    return str = Convert.ToDouble(str).ToString("0.00") + "%";
                }
            }
            else
            {
                return "--";
            }
           
        }

        private string getNoNaN(string str) {
            if (str == "正无穷大"||str == "非数字") {
                str = "--";
            }
            
            return str;
        }
    }
}