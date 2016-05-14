using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Maticsoft.DBUtility;
using System.Web.UI.WebControls;

namespace TTG.Web
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string path = "E:\\TTG\\data\\涪陵入系统151007\\涪陵入系统2014\\";
            //string[] folders = {
            //                       "FLJZXQ01珍溪集镇", "FLJZXQ05蔺市集镇", "FLXCXQ01红光小区", "FLXCXQ02青龙湾小区",
            //                       "FLXCXQ03青龙小区", "FLXCXQ04联合食品小区", "FLXCXQ05祥瑞小区", "FLXCXQ06荔枝园小区",
            //                       "FLXCXQ07天子殿小区", "FLXCXQ08敦仁小区", "FLXCXQ09稻香五组小区", "FLXCXQ10饮食服务小区",
            //                       "FLXCXQ11海怡天小区", "FLXCXQ12稻香一组小区", "FLXCXQ13大塘小区", "FLXCXQ14荔香民苑小区",
            //                       "FLXCXQ15长运小区","FLXCXQ16航务处小区","FLXCXQ17商贸小区","FLXCXQ18嘉和小区",
            //                       "FLXCXQ19顺江居委小区","FLXCXQ20大自然新光小区","FLXCXQ21江东小区"
            //                   };
            //string[] ids = {
            //                   "FLJZXQ01", "FLJZXQ05", "FLXCXQ01", "FLXCXQ02", "FLXCXQ03", "FLXCXQ04", "FLXCXQ05", "FLXCXQ06", "FLXCXQ07", "FLXCXQ08", "FLXCXQ09", "FLXCXQ10", 
            //                    "FLXCXQ11", "FLXCXQ12", "FLXCXQ13", "FLXCXQ14", "FLXCXQ15", "FLXCXQ16", "FLXCXQ17", "FLXCXQ18", "FLXCXQ19", "FLXCXQ20", "FLXCXQ21"
            //               };

            //for (int i = 0; i < folders.Length; i++)
            //{
            //    string temp = path + folders[i];
            //    //社区调查表
            //    DAL.READ.read_wcommunity wcommunity = new DAL.READ.read_wcommunity(path + folders[i] + "\\社区调查表.xls");
            //    wcommunity.read_and_insert();
            //    //小区给排水情况表
            //    DAL.READ.read_water_supply water_supply = new DAL.READ.read_water_supply(path + folders[i] + "\\小区给排水基本情况.xlsx");
            //    water_supply.read_and_insert(ids[i]);
            //    //小区功能定位及人口基本情况
            //    DAL.READ.read_community_base community_base = new DAL.READ.read_community_base(temp + "\\小区功能定位及人口基本情况.xlsx");
            //    community_base.read_and_insert(ids[i]);
            //    //小区供电、照明及绿化基本情况
            //    DAL.READ.read_elec_supply elec_supply = new DAL.READ.read_elec_supply(temp + "\\小区供电、照明及绿化基本情况.xlsx");
            //    elec_supply.read_and_insert(ids[i]);
            //    //小区管理及监测人员
            //    DAL.READ.read_management management = new DAL.READ.read_management(temp + "\\小区管理及监测人员.xlsx");
            //    management.read_and_insert();
            //    //小区交通基本情况
            //    DAL.READ.read_community_road community_road = new DAL.READ.read_community_road(temp + "\\小区交通基本情况.xlsx");
            //    community_road.read_and_insert(ids[i]);
            //    //小区教育及医疗基本情况
            //    DAL.READ.read_community_education education = new DAL.READ.read_community_education(temp + "\\小区教育及医疗基本情况.xlsx");
            //    education.read_and_insert(ids[i]);
            //    //小区商贸及社区服务基本情况
            //    DAL.READ.read_community_culture_sports culture_sports = new DAL.READ.read_community_culture_sports(temp + "\\小区商贸及社区服务基本情况.xlsx");
            //    culture_sports.read_and_insert(ids[i]);
            //    //小区消防、环卫、安防及其他基本情况
            //    DAL.READ.read_fire_fighting fire_fighting = new DAL.READ.read_fire_fighting(temp + "\\小区消防、环卫、安防及其他基本情况.xlsx");
            //    fire_fighting.read_and_insert(ids[i]);
            //    //小区效果标准表——填写
            //    DAL.READ.read_problems_first problem_first = new DAL.READ.read_problems_first(temp + "\\小区效果标准表-填写.xlsx");
            //    problem_first.read_and_insert(ids[i]);
            //    //小区效果标准表续表-填写.xlsx
            //    DAL.READ.read_problem_second problem_second = new DAL.READ.read_problem_second(temp + "\\小区效果标准表续表-填写.xlsx");
            //    problem_second.read_and_insert(ids[i]);
            //    //小区移民门面经营及劳动力就业基本情况.xlsx
            //    DAL.READ.read_shop_front shop_front = new DAL.READ.read_shop_front(temp + "\\小区移民门面经营及劳动力就业基本情况.xlsx");
            //    shop_front.read_and_insert(ids[i]);
            //    //小区用地、住房基本情况.xlsx
            //    DAL.READ.read_community_land land = new DAL.READ.read_community_land(temp + "\\小区用地、住房基本情况.xlsx");
            //    land.read_and_insert(ids[i]);
            //    //重要指标年度更新.xlsx
            //    DAL.READ.read_important_figures important_figures = new DAL.READ.read_important_figures(temp + "\\重要指标年度更新.xlsx");
            //    important_figures.read_and_insert(ids[i]);
            //}
            ////更新2014年数据
            //for (int i = 22; i < folders.Length; i++)
            //{
            //    string temp = path + folders[i];
            //    //社区调查表
            //    DAL.READ.read_wcommunity wcommunity = new DAL.READ.read_wcommunity(path + folders[i] + "\\社区调查表.xls");
            //    wcommunity.read_and_insert();
            //    //小区给排水情况表
            //    DAL.READ.read_water_supply water_supply = new DAL.READ.read_water_supply(path + folders[i] + "\\小区给排水基本情况.xlsx");
            //    water_supply.read_and_insert(ids[i]);
            //    //小区功能定位及人口基本情况
            //    DAL.READ.read_community_base community_base = new DAL.READ.read_community_base(temp + "\\小区功能定位及人口基本情况.xlsx");
            //    community_base.read_and_insert(ids[i]);
            //    //小区供电、照明及绿化基本情况
            //    DAL.READ.read_elec_supply elec_supply = new DAL.READ.read_elec_supply(temp + "\\小区供电、照明及绿化基本情况.xlsx");
            //    elec_supply.read_and_insert(ids[i]);
            //    ////小区管理及监测人员
            //    //DAL.READ.read_management management = new DAL.READ.read_management(temp + "\\小区管理及监测人员.xlsx");
            //    //management.read_and_insert();
            //    //小区交通基本情况
            //    DAL.READ.read_community_road community_road = new DAL.READ.read_community_road(temp + "\\小区交通基本情况.xlsx");
            //    community_road.read_and_insert(ids[i]);
            //    //小区教育及医疗基本情况
            //    DAL.READ.read_community_education education = new DAL.READ.read_community_education(temp + "\\小区教育及医疗基本情况.xlsx");
            //    education.read_and_insert(ids[i]);
            //    //小区商贸及社区服务基本情况
            //    DAL.READ.read_community_culture_sports culture_sports = new DAL.READ.read_community_culture_sports(temp + "\\小区商贸及社区服务基本情况.xlsx");
            //    culture_sports.read_and_insert(ids[i]);
            //    //小区消防、环卫、安防及其他基本情况
            //    DAL.READ.read_fire_fighting fire_fighting = new DAL.READ.read_fire_fighting(temp + "\\小区消防、环卫、安防及其他基本情况.xlsx");
            //    fire_fighting.read_and_insert(ids[i]);
            //    //小区移民门面经营及劳动力就业基本情况.xlsx
            //    DAL.READ.read_shop_front shop_front = new DAL.READ.read_shop_front(temp + "\\小区移民门面经营及劳动力就业基本情况.xlsx");
            //    shop_front.read_and_insert(ids[i]);
            //    //小区用地、住房基本情况.xlsx
            //    DAL.READ.read_community_land land = new DAL.READ.read_community_land(temp + "\\小区用地、住房基本情况.xlsx");
            //    land.read_and_insert(ids[i]);
            //}
            ////2013年及之前专项资金项目
            //DAL.READ.read_previous_project previous_project = new DAL.READ.read_previous_project("E:\\TTG\\data\\涪陵入系统151007\\涪陵入系统151007\\2013及之前专项资金项目.xlsx");
            //try
            //{
            //    previous_project.read_and_insert();
            //}
            //catch (Exception)
            //{
            //}
            ////2014年及之后专项资金项目
            //DAL.READ.read_subsequent_project subsequent_project = new DAL.READ.read_subsequent_project("E:\\TTG\\data\\涪陵入系统151007\\涪陵入系统151007\\2014及以后专项资金项目.xlsx");
            //subsequent_project.read_and_insert();
            ////对口支援及其他项目
            //DAL.READ.read_counterpart_project counterpart_project = new DAL.READ.read_counterpart_project("E:\\TTG\\data\\涪陵入系统151007\\涪陵入系统151007\\对口支援及其他项目.xlsx");
            //counterpart_project.read_and_insert();
            ////项目实物表s
            //DAL.READ.read_project_physical project_physical = new DAL.READ.read_project_physical("E:\\TTG\\data\\涪陵入系统151007\\涪陵入系统151007\\小区项目实物表.xlsx");
            //project_physical.read_and_insert();

            //string[] communityName = {"蔺市集镇", "红光小区","青龙湾小区", "青龙小区", "联合食品小区", "祥瑞小区", "荔枝园小区", "天子殿小区",
            //                             "敦仁小区", "稻香五组小区", "饮食服务小区", "海怡天小区", "稻香一组小区", "大塘小区", "荔香民苑小区",
            //                             "长运小区", "航务处小区", "商贸小区", "嘉和小区", "顺江居委小区", "大自然新光小区", "江东小区"
            //                          };
            //for (int i = 0; i < communityName.Length; i++)
            //    Csharp.Update.update_community_all_info(new System.Data.SqlClient.SqlConnection(PubConstant.ConnectionString),
            //        "重庆市", "涪陵", communityName[i], 2013);

            //string a = "  as dad sd s   ";
            //DAL.READ.read_excel re = new DAL.READ.read_excel();
            //a = re.replaceBlank(a);
            //Response.Write(a);
            
            Response.Write("success");
        }
    }
}