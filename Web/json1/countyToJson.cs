using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TTG.Web.json1
{
    public class countyToJson : jsonTools
    {
        private DAL.GET.get_county_main gcd;
        private System.Text.StringBuilder result = new System.Text.StringBuilder();
        public countyToJson(String province,String county)
        {
            //获取对应区县列表
            if (county == null) return;
            if (province.Equals("湖北省"))
                gcd = new DAL.GET.get_county_main();
            else if (province.Equals("重庆市"))
                gcd = new DAL.GET.get_county_main();
            else
                result.Append("{\"error\":\"未找到该区县\"}");
        }
       
        public String getResult()
        {
            if (result.Length > 0)
                return result.ToString();
            result.Append("{");
            result.Append("\"communityNum\":\"" +gcd.Community_num+ "\",");
            result.Append("\"townCommunity\":\"" + gcd.Town_community_num + "\",");//jizhen
            result.Append("\"cityCommunity\":\"" + gcd.County_community_num + "\",");//chengshi
            result.Append("\"allFundCoverCommunity\":\"" + gcd.Project_cover_num + "\",");
            result.Append("\"specialFundCoverCommunity\":\"" + gcd.Special_cover_num + "\",");
            result.Append("\"residentNum\":\"" + gcd.People_num + "\",");
            result.Append("\"familyNum\":\"" + gcd.Family_num + "\",");
            result.Append("\"immigrant\":\"" + gcd.Immigrant_people_num + "\",");
            result.Append("\"immigrantFamily\":\"" + gcd.Immigrant_family_num + "\",");
            result.Append("\"houseAreaPer\":\"" + gcd.Average_house_area.ToString("0.00") + "\",");
            result.Append("\"employmentRate\":\"" + gcd.Employment_rate.ToString("0.00") + "\",");
            result.Append("\"lowAllowanceRate\":\"" + gcd.Poor_rate.ToString("0.00") + "\",");
            result.Append("\"disposableIncomePer_2013\":\"" + gcd.Average_income_2013.ToString("0.00") + "\",");
            result.Append("\"disposableIncomePer_now\":\"" + gcd.Average_income.ToString("0.00") + "\",");
            result.Append("\"disposableIncomePer_change\":\"" + gcd.Income_change_situation.ToString("0.00") + "\",");

            result.Append("\"specialProject2013\":\"" + gcd.project_num_2013 + "\",");
            result.Append("\"specialProject2013Rate\":\"" + gcd.project_com_rate_2013 + "\",");
            result.Append("\"specialProject2014\":\"" + gcd.project_num_2014 + "\",");
            result.Append("\"specialProject2014Rate\":\"" + gcd.project_com_rate_2014 + "\",");
            result.Append("\"planedInvest\":\"" + gcd.founds_down + "\",");
            result.Append("\"completedInvest\":\"" + gcd.founds_com + "\",");
            result.Append("\"completedInvestRate\":\"" + gcd.founds_rate + "\",");


            result.Append("\"engelCoefficient\":\"" + gcd.Enger_figuer.ToString("0.00") + "\",");
            result.Append("\"giniCoefficient\":\"" + gcd.Jini_figure.ToString("0.00") + "\",");
            result.Append("\"investSituationByMoney\":[[" + gcd.Plan_special_inves + "," + gcd.Plan_counter_inves + "," + gcd.Plan_other_inves + "],");
            result.Append("[" +gcd.Com_special_inves+","+gcd.Com_counter_inves+","+gcd.Com_other_inves+ "]],");
            result.Append("\"investSituationByCategoryStructure\":[[" + gcd.Plan_house_safe + "," + gcd.Plan_base_fac + "," + gcd.Plan_envir_pro + "," + gcd.Plan_public_fac + "," + gcd.Plan_busin + "],");
            result.Append("[" + gcd.Com_house_safe + "," + gcd.Com_base_fac + "," + gcd.Com_envir_pro + "," + gcd.Com_public_fac + "," + gcd.Com_busin + "]]");

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
            result.Append("\"" + value + "\"");
        }
    }
}