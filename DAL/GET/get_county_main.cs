using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TTG.DAL.GET
{
    public class get_county_main
    {
        #region 字段
        private get_tools gt = new get_tools();
        private int community_num,   //小区数目
            county_community_num,       //县城小区数目
            town_community_num,         //集镇小区数目
            project_cover_num,          //所有项目覆盖小区
            special_cover_num,          //专项资金项目覆盖小区
            family_num,                 //户籍人口户数
            people_num,                 //户籍人口人数
            immigrant_family_num,           //移民人口户数
            immigrant_people_num;           //移民人口人数
        private double enger_figuer,        //恩格尔系数
            jini_figure,            //基尼系数
            average_house_area,         //人均住房面积
            employment_rate,            //劳动力就业率
            poor_rate,                  //低保人口比例
            average_income_2013,        //2013年人均可支配收入
            average_income,             //当前人均可支配收入
            income_change_situation;        //人均可支配收入变化情况
        private double plan_total_inves,           //累计计划投资
            complete_total_inves,                  //累计完成投资
            complete_rate,                              //投资完成比率
            plan_total_special_inves,                    //累计专项资金计划
            complete_total_special_inves,                //累计专项资金完成
            special_complete_rete;                      //专项资金完成比率
        private double plan_special_inves,                  //计划投资——专项投资
            plan_counter_inves,                             //计划投资——对口支援投资
            plan_other_inves,                               //计划投资——其他投资
            com_special_inves,                              //完成投资——专项投资
            com_counter_inves,                              //完成投资——对口支援投资
            com_other_inves;                                //完成投资——其他投资
        private double plan_house_safe,                     //计划投资——统建房安全
            plan_base_fac,                           //计划投资——基础设施
            plan_envir_pro,                         //计划投资——环保设施
            plan_public_fac,                        //计划投资——公共设施
            plan_busin,                             //计划投资——营商环境
            com_house_safe,                         //完成投资——统建房安全
            com_base_fac,                           //完成投资——基础设施
            com_envir_pro,                          //完成投资——环保设施
            com_public_fac,                         //完成投资——公共设施
            com_busin;                              //完成投资——营商环境

        public string  project_num_2013, project_num_2014, project_com_rate_2013,
            project_com_rate_2014, founds_down, founds_com, founds_rate, before_cons_2013, in_cons_2013, com_cons_2013,
            before_cons_2014, in_cons_2014, com_cons_2014;
        #endregion

        #region 属性

        public int Community_num
        {
            get { return community_num; }
            set { community_num = value; }
        }

        public int County_community_num
        {
            get { return county_community_num; }
            set { county_community_num = value; }
        }

        public int Town_community_num
        {
            get { return town_community_num; }
            set { town_community_num = value; }
        }

        public int Project_cover_num
        {
            get { return project_cover_num; }
            set { project_cover_num = value; }
        }

        public int Special_cover_num
        {
            get { return special_cover_num; }
            set { special_cover_num = value; }
        }

        public int Family_num
        {
            get { return family_num; }
            set { family_num = value; }
        }

        public int People_num
        {
            get { return people_num; }
            set { people_num = value; }
        }

        public int Immigrant_family_num
        {
            get { return immigrant_family_num; }
            set { immigrant_family_num = value; }
        }

        public int Immigrant_people_num
        {
            get { return immigrant_people_num; }
            set { immigrant_people_num = value; }
        }

        public double Enger_figuer
        {
            get { return enger_figuer; }
            set { enger_figuer = value; }
        }

        public double Jini_figure
        {
            get { return jini_figure; }
            set { jini_figure = value; }
        }

        public double Average_house_area
        {
            get { return average_house_area; }
            set { average_house_area = value; }
        }

        public double Employment_rate
        {
            get { return employment_rate; }
            set { employment_rate = value; }
        }

        public double Poor_rate
        {
            get { return poor_rate; }
            set { poor_rate = value; }
        }

        public double Average_income_2013
        {
            get { return average_income_2013; }
            set { average_income_2013 = value; }
        }

        public double Average_income
        {
            get { return average_income; }
            set { average_income = value; }
        }

        public double Income_change_situation
        {
            get { return income_change_situation; }
            set { income_change_situation = value; }
        }

        public double Plan_total_inves
        {
            get { return plan_total_inves; }
            set { plan_total_inves = value; }
        }

        public double Complete_total_inves
        {
            get { return complete_total_inves; }
            set { complete_total_inves = value; }
        }

        public double Complete_rate
        {
            get { return complete_rate; }
            set { complete_rate = value; }
        }

        public double Plan_total_special_inves
        {
            get { return plan_total_special_inves; }
            set { plan_total_special_inves = value; }
        }

        public double Complete_total_special_inves
        {
            get { return complete_total_special_inves; }
            set { complete_total_special_inves = value; }
        }

        public double Special_complete_rete
        {
            get { return special_complete_rete; }
            set { special_complete_rete = value; }
        }

        public double Plan_special_inves
        {
            get { return plan_special_inves; }
            set { plan_special_inves = value; }
        }

        public double Plan_counter_inves
        {
            get { return plan_counter_inves; }
            set { plan_counter_inves = value; }
        }

        public double Plan_other_inves
        {
            get { return plan_other_inves; }
            set { plan_other_inves = value; }
        }

        public double Com_special_inves
        {
            get { return com_special_inves; }
            set { com_special_inves = value; }
        }

        public double Com_counter_inves
        {
            get { return com_counter_inves; }
            set { com_counter_inves = value; }
        }

        public double Com_other_inves
        {
            get { return com_other_inves; }
            set { com_other_inves = value; }
        }

        public double Plan_house_safe
        {
            get { return plan_house_safe; }
            set { plan_house_safe = value; }
        }

        public double Plan_base_fac
        {
            get { return plan_base_fac; }
            set { plan_base_fac = value; }
        }

        public double Plan_envir_pro
        {
            get { return plan_envir_pro; }
            set { plan_envir_pro = value; }
        }

        public double Plan_public_fac
        {
            get { return plan_public_fac; }
            set { plan_public_fac = value; }
        }

        public double Plan_busin
        {
            get { return plan_busin; }
            set { plan_busin = value; }
        }

        public double Com_house_safe
        {
            get { return com_house_safe; }
            set { com_house_safe = value; }
        }

        public double Com_base_fac
        {
            get { return com_base_fac; }
            set { com_base_fac = value; }
        }

        public double Com_envir_pro
        {
            get { return com_envir_pro; }
            set { com_envir_pro = value; }
        }

        public double Com_public_fac
        {
            get { return com_public_fac; }
            set { com_public_fac = value; }
        }

        public double Com_busin
        {
            get { return com_busin; }
            set { com_busin = value; }
        }

        #endregion 

        public get_county_main()
        {
            query_message();
        }

        private void query_message()
        {
            community_num = 35;
            county_community_num = 21;
            town_community_num = 14;
            project_cover_num = 27;
            special_cover_num = 25;
            enger_figuer = 36.8;
            family_num = 32472;
            people_num = 97417;
            immigrant_family_num = 21474;
            immigrant_people_num = 64423;
            average_house_area = 24.24;
            employment_rate = 85.83;
            poor_rate = 4.55;
            jini_figure = 44;
            average_income_2013 = 16386;
            average_income = 18123;
            income_change_situation = (average_income - average_income_2013) / average_income_2013 * 100;
            plan_total_inves = 65373.91;
            complete_total_inves = 18523.6;
            complete_rate = 28.33;
            plan_total_special_inves = 30161.6;
            complete_total_special_inves = 4567.6;
            special_complete_rete = 15.14;
            plan_special_inves = 30161.6;
            plan_counter_inves = 805;
            plan_other_inves = 52416.68;
            com_special_inves = 4567.6;
            com_counter_inves = 250;
            com_other_inves = 28865.5;
            plan_house_safe = 0;
            plan_base_fac = 15451;
            plan_envir_pro = 1446;
            plan_public_fac = 9234;
            plan_busin = 4030.6;
            com_house_safe = 0;
            com_base_fac = 2860.4;
            com_envir_pro = 368;
            com_public_fac = 129.2;
            com_busin = 1210;

            project_num_2013 = "11";
            project_com_rate_2013 = "45.45";
            project_num_2014 = "2";
            project_com_rate_2014 = "0";
            founds_down = "30161.6";
            founds_com = "4567.6";
            founds_rate = "15.14";

            before_cons_2013 = "3";
            in_cons_2013 = "3";
            com_cons_2013 = "5";
            before_cons_2014 = "8";
            in_cons_2014 = "4";
            com_cons_2014 = "0";
        }
    }
}
