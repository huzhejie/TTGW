using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTG.DAL.GET
{
    public class get_county_data
    {
        private string countycommunity_num, countycounty_community_num,
            countycover_community_num, countydisposable_income_2013,
            countydisposable_income_now, countyimmigrant_family_num,
            countyimmigrant_people_num, countyincome_change,
            countylf_having_job_rate, countypoor_people_rate,
            countyspecial_cover_community_num, countytotal_family_num,
            countytotal_people_num, countytown_community_num,
            countyaverage_house_area, plan_investment, finished_investment, investment_rate,
            enger_figure, gini_figure;
        private double[] plan1 = new double[3], finished1 = new double[3], plan2 = new double[5], finished2 = new double[5];

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

        public string Enger_figure
        {
            get { return enger_figure; }
            set { enger_figure = value; }
        }

        public string Gini_figure
        {
            get { return gini_figure; }
            set { gini_figure = value; }
        }

        public string Countycommunity_num
        {
            get { return countycommunity_num; }
            set { countycommunity_num = value; }
        }

        public string Countycounty_community_num
        {
            get { return countycounty_community_num; }
            set { countycounty_community_num = value; }
        }

        public string Countycover_community_num
        {
            get { return countycover_community_num; }
            set { countycover_community_num = value; }
        }

        public string Countydisposable_income_2013
        {
            get { return countydisposable_income_2013; }
            set { countydisposable_income_2013 = value; }
        }

        public string Countydisposable_income_now
        {
            get { return countydisposable_income_now; }
            set { countydisposable_income_now = value; }
        }

        public string Countyimmigrant_family_num
        {
            get { return countyimmigrant_family_num; }
            set { countyimmigrant_family_num = value; }
        }

        public string Countyimmigrant_people_num
        {
            get { return countyimmigrant_people_num; }
            set { countyimmigrant_people_num = value; }
        }

        public string Countyincome_change
        {
            get { return countyincome_change; }
            set { countyincome_change = value; }
        }

        public string Countylf_having_job_rate
        {
            get { return countylf_having_job_rate; }
            set { countylf_having_job_rate = value; }
        }

        public string Countypoor_people_rate
        {
            get { return countypoor_people_rate; }
            set { countypoor_people_rate = value; }
        }

        public string Countyspecial_cover_community_num
        {
            get { return countyspecial_cover_community_num; }
            set { countyspecial_cover_community_num = value; }
        }

        public string Countytotal_family_num
        {
            get { return countytotal_family_num; }
            set { countytotal_family_num = value; }
        }

        public string Countytotal_people_num
        {
            get { return countytotal_people_num; }
            set { countytotal_people_num = value; }
        }

        public string Countytown_community_num
        {
            get { return countytown_community_num; }
            set { countytown_community_num = value; }
        }

        public string Countyaverage_house_area
        {
            get { return countyaverage_house_area; }
            set { countyaverage_house_area = value; }
        }

        public get_county_data(string county)
        {
            if (county.Equals("开县"))
            {
                get_county1();
            }
            else
            {
                get_county2();
            }
        }
        /// <summary>
        /// 开县
        /// </summary>
        private void get_county1()
        {
            countycommunity_num = "23";
            countycounty_community_num = "8";
            countycover_community_num = "19";
            countydisposable_income_2013 = "14005";
            countydisposable_income_now = "15103";
            countyimmigrant_family_num = "7831";
            countyimmigrant_people_num = "30234";
            countyincome_change = "7.8%";
            countylf_having_job_rate = "74.6";
            countypoor_people_rate = "4.7";
            countyspecial_cover_community_num = "7";
            countytotal_family_num = "12891";
            countytotal_people_num = "51564";
            countytown_community_num = "15";
            countyaverage_house_area = "37.2";
            plan_investment = "1430";
            finished_investment = "675";
            investment_rate = "47.2%";
            enger_figure = "51%";
            gini_figure = "0.34";
            plan1 = new double[3] { 590, 360, 480 };
            finished1 = new double[3] { 235, 85, 355 };
            plan2 = new double[5] { 310, 520, 250, 275, 75 };
            finished2 = new double[5] { 140, 210, 158, 102, 65 };
        }
        /// <summary>
        /// 巴东
        /// </summary>
        private void get_county2()
        {
            countycommunity_num = "8";
            countycounty_community_num = "5";
            countycover_community_num = "19";
            countydisposable_income_2013 = "13121";
            countydisposable_income_now = "13408";
            countyimmigrant_family_num = "6675";
            countyimmigrant_people_num = "25365";
            countyincome_change = "9.2%";
            countylf_having_job_rate = "82.7";
            countypoor_people_rate = "5.1";
            countyspecial_cover_community_num = "4";
            countytotal_family_num = "11531";
            countytotal_people_num = "40359";
            countytown_community_num = "3";
            countyaverage_house_area = "47.5";
            plan_investment = "594";
            finished_investment = "364";
            investment_rate = "61.28%";
            enger_figure = "53%";
            gini_figure = "0.38";
            plan1 = new double[3] { 231, 105, 258 };
            finished1 = new double[3] { 112, 55, 197 };
            plan2 = new double[5] { 98, 207, 104, 113, 72 };
            finished2 = new double[5] { 62, 115, 71, 84, 32 };
        }
    }
}
