using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TTG.Web.json1
{
    public class mainToJson : jsonTools
    {
        private DAL.GET.get_whole_msg gwm = new DAL.GET.get_whole_msg();
        private StringBuilder result = new StringBuilder();

        public String getResult()
        {
            result.Append("{");
            result.Append("\"number\":\"" + "0" + "\",");
            result.Append("\"name\":\"" + "" + "\",");
            result.Append("\"communityNum\":\"" + gwm.Totalcommunity_num + "\",");
            result.Append("\"cityCommunity\":\"" + gwm.Totalcounty_community_num + "\",");
            result.Append("\"townCommunity\":\"" + gwm.Totaltown_community_num + "\",");
            result.Append("\"allFundCoverCommunity\":\"" + gwm.Totalcover_community_num + "\",");
            result.Append("\"specialFundCoverCommunity\":\"" + gwm.Totalspecial_cover_community_num + "\",");
            result.Append("\"residentNum\":\"" + gwm.Totaltotal_people_num + "\",");
            result.Append("\"familyNum\":\"" + gwm.Totaltotal_family_num + "\",");
            result.Append("\"immigrant\":\"" + gwm.Totalimmigrant_people_num + "\",");
            result.Append("\"immigrantFamily\":\"" + gwm.Totalimmigrant_family_num + "\",");
            result.Append("\"houseAreaPer\":\"" + gwm.Totalaverage_house_area + "\",");
            result.Append("\"employmentRate\":\"" + gwm.Totallf_having_job_rate + "\",");
            result.Append("\"lowAllowanceRate\":\"" + gwm.Totalpoor_people_rate + "\",");
            result.Append("\"disposableIncomePer_2013\":\"" + gwm.Totaldisposable_income_2013 + "\",");
            result.Append("\"disposableIncomePer_now\":\"" + gwm.Totaldisposable_income_now + "\",");
            result.Append("\"disposableIncomePer_change\":\"" + gwm.Totalincome_change + "\",");
            result.Append("\"planedInvest\":\"" + gwm.founds_down + "\",");
            result.Append("\"completedInvest\":\"" + gwm.founds_com + "\",");
            result.Append("\"completedInvestRate\":\"" + gwm.founds_rate + "\",");

            result.Append("\"specialProject2013\":\"" + gwm.project_num_2013 + "\",");
            result.Append("\"specialProject2013Rate\":\"" + gwm.project_com_rate_2013 + "\",");
            result.Append("\"specialProject2014\":\"" + gwm.project_num_2014 + "\",");
            result.Append("\"specialProject2014Rate\":\"" + gwm.project_com_rate_2014 + "\",");

            result.Append("\"investSituationByMoney\":[[" + gwm.before_cons_2013 + "," + gwm.in_cons_2013 + "," + gwm.com_cons_2013 + "],");
            result.Append("[" + gwm.before_cons_2014+ "," + gwm.in_cons_2014 + "," + gwm.com_cons_2014 + "]],");
            result.Append("\"investSituationByCategoryStructure\":[[" + gwm.Plan2[0] + "," + gwm.Plan2[1] + "," + gwm.Plan2[2] + "," + gwm.Plan2[3] + "," + gwm.Plan2[4] + "],");
            result.Append("[" + gwm.Finished2[0] + "," + gwm.Finished2[1] + "," + gwm.Finished2[2] + "," + gwm.Finished2[3] + "," + gwm.Finished2[4] + "]]");

            result.Append("}");
            return result.ToString();
        }

        void jsonTools.addAttribute(string attr)
        {
            throw new NotImplementedException();
        }

        void jsonTools.addValue(string value)
        {
            throw new NotImplementedException();
        }

        public void addValue(double value)
        {
            if (value.ToString() == "非数字")
            {
                result.Append("--");
            }
            else
                result.Append("\"" + value.ToString("0.00") + "\"");
            
        }

        public void addValue(int value)
        {
            if (value == null)
            {
                result.Append("\"" + "--" + "\"");
            }
        }
    }
}