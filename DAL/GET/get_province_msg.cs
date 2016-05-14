using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTG.DAL.GET
{
    public class get_province_msg
    {
        public string provincecommunity_num, provincecounty_community_num, provincecover_community_num,
            provincedisposable_income_2013, provincedisposable_income_now, provinceimmigrant_family_num,
            provinceimmigrant_people_num, provinceincome_change, provincelf_having_job_rate,
            provincepoor_people_rate, provincespecial_cover_community_num, provincetotal_family_num,
            provincetotal_people_num, provincetown_community_num, provinceaverage_house_area,
            plan_investment, finished_investment, investment_rate, plan_special_inves, com_special_inves, special_inves_rate;
        //新增
        public string project_num_2013, project_num_2014, project_com_rate_2013,
            project_com_rate_2014, founds_down, founds_com, founds_rate, before_cons_2013, in_cons_2013, com_cons_2013,
            before_cons_2014, in_cons_2014, com_cons_2014;

        public string Plan_special_inves
        {
            get { return plan_special_inves; }
            set { plan_special_inves = value; }
        }

        public string Com_special_inves
        {
            get { return com_special_inves; }
            set { com_special_inves = value; }
        }

        public string Special_inves_rate
        {
            get { return special_inves_rate; }
            set { special_inves_rate = value; }
        }
        public double[] plan1, finished1, plan2, finished2;

        public get_province_msg(string province)
        {
            if (province.Equals("湖北省"))
                hubei();
            else if (province.Equals("重庆市"))
                chongqing();
        }

        /// <summary>
        /// 湖北省
        /// </summary>
        private void hubei(){
            provincecommunity_num = "37";
            provincecounty_community_num = "25";
            provincecover_community_num = "24";
            provincedisposable_income_2013 = "12430";
            provincedisposable_income_now = "13861";
            provinceimmigrant_family_num = "23616";
            provinceimmigrant_people_num = "70847";
            provinceincome_change = "11.51";
            provincelf_having_job_rate = "77.16";
            provincepoor_people_rate = "9.75";
            provincespecial_cover_community_num = "23";
            provincetotal_family_num = "37362";
            provincetotal_people_num = "112086";
            provincetown_community_num = "12";
            provinceaverage_house_area = "52.21";
            plan_investment = "60433";
            finished_investment = "17003.47";
            investment_rate = "28.14";
            plan1 = new double[3] { 23612, 6210, 30611 };
            finished1 = new double[3] { 3384.47, 2780, 10839 };
            plan2 = new double[5] { 272, 12110, 4370, 4680, 2180 };
            finished2 = new double[5] { 0, 1960, 470, 954, 0 };
            plan_special_inves = "23611.9";
            com_special_inves = "3384.47";
            special_inves_rate = "14.33";
            //新增
            project_num_2013 = "7";
            project_com_rate_2013 = "28.57";
            project_num_2014 = "9";
            project_com_rate_2014 = "10.53";
            founds_down = "23611.9";
            founds_com = "3313.47";
            founds_rate = "14.03";
            before_cons_2013 = "1";
            in_cons_2013 = "4";
            com_cons_2013 = "2";
            before_cons_2014 = "14";
            in_cons_2014 = "3";
            com_cons_2014 = "2";
        }
        /// <summary>
        /// 重庆市
        /// </summary>
        private void chongqing()
        {
            provincecommunity_num = "284";
            provincecounty_community_num = "192";
            provincecover_community_num = "186";
            provincedisposable_income_2013 = "14010";
            provincedisposable_income_now = "15552";
            provinceimmigrant_family_num = "204281";
            provinceimmigrant_people_num = "612845";
            provinceincome_change = "11.01";
            provincelf_having_job_rate = "88.72";
            provincepoor_people_rate = "7.69";
            provincespecial_cover_community_num = "163";
            provincetotal_family_num = "408443";
            provincetotal_people_num = "1022094";
            provincetown_community_num = "92";
            provinceaverage_house_area = "37.16";
            plan_investment = "297610";
            finished_investment = "156645";
            investment_rate = "52.63";
            plan1 = new double[3] { 165297, 4282, 11648 };
            finished1 = new double[3] { 83084, 1098, 79067 };
            plan2 = new double[5] { 13870, 87380, 36740, 22827, 4480 };
            finished2 = new double[5] { 5580, 42210, 25854, 7760, 1680 };
            plan_special_inves = "165297";
            com_special_inves = "83084";
            special_inves_rate = "50.26";
            //新增
            project_num_2013 = "146";
            project_com_rate_2013 = "53.42";
            project_num_2014 = "25";
            project_com_rate_2014 = "2.27";
            founds_down = "169388.2";
            founds_com = "83774.74";
            founds_rate = "49.46";
            before_cons_2013 = "18";
            in_cons_2013 = "50";
            com_cons_2013 = "78";
            before_cons_2014 = "34";
            in_cons_2014 = "9";
            com_cons_2014 = "1";
        }
    }
}
