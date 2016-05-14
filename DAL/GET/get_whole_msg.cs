using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTG.DAL.GET
{
    public class get_whole_msg
    {
        private string totalcommunity_num, totalcounty_community_num, totalcover_community_num,
            totaldisposable_income_2013, totaldisposable_income_now, totalimmigrant_family_num,
            totalimmigrant_people_num, totalincome_change, totallf_having_job_rate,
            totalpoor_people_rate, totalspecial_cover_community_num, totaltotal_family_num,
            totaltotal_people_num, totaltown_community_num, totalaverage_house_area,
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

        public string Totalcommunity_num
        {
            get { return totalcommunity_num; }
            set { totalcommunity_num = value; }
        }

        public string Totalcounty_community_num
        {
            get { return totalcounty_community_num; }
            set { totalcounty_community_num = value; }
        }

        public string Totalcover_community_num
        {
            get { return totalcover_community_num; }
            set { totalcover_community_num = value; }
        }

        public string Totaldisposable_income_2013
        {
            get { return totaldisposable_income_2013; }
            set { totaldisposable_income_2013 = value; }
        }

        public string Totaldisposable_income_now
        {
            get { return totaldisposable_income_now; }
            set { totaldisposable_income_now = value; }
        }

        public string Totalimmigrant_family_num
        {
            get { return totalimmigrant_family_num; }
            set { totalimmigrant_family_num = value; }
        }

        public string Totalimmigrant_people_num
        {
            get { return totalimmigrant_people_num; }
            set { totalimmigrant_people_num = value; }
        }

        public string Totalincome_change
        {
            get { return totalincome_change; }
            set { totalincome_change = value; }
        }

        public string Totallf_having_job_rate
        {
            get { return totallf_having_job_rate; }
            set { totallf_having_job_rate = value; }
        }

        public string Totalpoor_people_rate
        {
            get { return totalpoor_people_rate; }
            set { totalpoor_people_rate = value; }
        }

        public string Totalspecial_cover_community_num
        {
            get { return totalspecial_cover_community_num; }
            set { totalspecial_cover_community_num = value; }
        }

        public string Totaltotal_family_num
        {
            get { return totaltotal_family_num; }
            set { totaltotal_family_num = value; }
        }

        public string Totaltotal_people_num
        {
            get { return totaltotal_people_num; }
            set { totaltotal_people_num = value; }
        }

        public string Totaltown_community_num
        {
            get { return totaltown_community_num; }
            set { totaltown_community_num = value; }
        }

        public string Totalaverage_house_area
        {
            get { return totalaverage_house_area; }
            set { totalaverage_house_area = value; }
        }

        public string Plan_investment
        {
            get { return plan_investment; }
            set { plan_investment = value; }
        }

        public string Finished_investment
        {
            get { return finished_investment; }
            set { finished_investment = value; }
        }

        public string Investment_rate
        {
            get { return investment_rate; }
            set { investment_rate = value; }
        }
        private double[] plan1 = new double[3], finished1 = new double[3];

        public double[] Plan1
        {
            get { return plan1; }
            set { plan1 = value; }
        }

        public double[] Finished1
        {
            get { return finished1; }
            set { finished1 = value; }
        }
        private double[] plan2 = new double[5], finished2 = new double[5];

        public double[] Plan2
        {
            get { return plan2; }
            set { plan2 = value; }
        }

        public double[] Finished2
        {
            get { return finished2; }
            set { finished2 = value; }
        }

        public get_whole_msg()
        {
            get_msg();
        }
        private void get_msg(){
            totalcommunity_num = "321";
            totalcounty_community_num = "217";
            totalcover_community_num = "210";
            totaldisposable_income_2013 = "13610";
            totaldisposable_income_now = "15005";
            totalimmigrant_family_num = "227897";
            totalimmigrant_people_num = "683692";
            totalincome_change = "10.48";
            totallf_having_job_rate = "87.51";
            totalpoor_people_rate = "7.89";
            totalspecial_cover_community_num = "186";
            totaltotal_family_num = "445805";
            totaltotal_people_num = "1134180";
            totaltown_community_num = "104";
            totalaverage_house_area = "38.65";
            plan_investment = "358043";
            finished_investment = "178214";
            investment_rate = "49.77";
            plan1 = new double[3] { 188909, 10492, 147099 };
            finished1 = new double[3] { 86469, 3878, 89906 };
            plan2 = new double[5] { 14142, 99490, 41110, 27507, 6660 };
            finished2 = new double[5] { 5580, 44170, 26324, 8714, 1680 };
            plan_special_inves = "188909";
            com_special_inves = "86469";
            special_inves_rate = "45.77";

            //新增
            project_num_2013 = "153";
            project_com_rate_2013 = "52.29";
            project_num_2014 = "34";
            project_com_rate_2014 = "4.76";
            founds_down = "193000.1";
            founds_com = "87088.21";
            founds_rate = "45.12";
            before_cons_2013 = "19";
            in_cons_2013 = "54";
            com_cons_2013 = "80";
            before_cons_2014 = "48";
            in_cons_2014 = "12";
            com_cons_2014 = "3";
        }

    }
}
