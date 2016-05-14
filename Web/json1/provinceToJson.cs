using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TTG.Web.json1
{
    public class provinceToJson : jsonTools
    {
        private DAL.GET.get_province_msg gpm;
        private System.Text.StringBuilder result = new System.Text.StringBuilder();
        public provinceToJson(String province)
        {
            if (province == null) return;
            if (province.Equals("湖北省") || province.Equals("重庆市"))
                gpm = new DAL.GET.get_province_msg(province);
            else
                result.Append( "{\"error\":\"未找到该省市\"}");
        }
       
        public String getResult()
        {
            if (result.Length > 0)
                return result.ToString();
            result.Append("{");
            result.Append("\"communityNum\":\"" +gpm.provincecommunity_num+ "\",");
            result.Append("\"townCommunity\":\"" + gpm.provincetown_community_num + "\",");//jizhen
            result.Append("\"cityCommunity\":\"" + gpm.provincecounty_community_num + "\",");//chengshi
            result.Append("\"allFundCoverCommunity\":\"" + gpm.provincecover_community_num + "\",");
            result.Append("\"specialFundCoverCommunity\":\"" + gpm.provincespecial_cover_community_num + "\",");
            result.Append("\"residentNum\":\"" + gpm.provincetotal_people_num + "\",");
            result.Append("\"familyNum\":\"" + gpm.provincetotal_family_num + "\",");
            result.Append("\"immigrant\":\"" + gpm.provinceimmigrant_people_num + "\",");
            result.Append("\"immigrantFamily\":\"" + gpm.provinceimmigrant_family_num + "\",");
            result.Append("\"houseAreaPer\":\"" + gpm.provinceaverage_house_area + "\",");
            result.Append("\"employmentRate\":\"" + gpm.provincelf_having_job_rate + "\",");
            result.Append("\"lowAllowanceRate\":\"" + gpm.provincepoor_people_rate + "\",");
            result.Append("\"disposableIncomePer_2013\":\"" + gpm.provincedisposable_income_2013 + "\",");
            result.Append("\"disposableIncomePer_now\":\"" + gpm.provincedisposable_income_now + "\",");
            result.Append("\"disposableIncomePer_change\":\"" + gpm.provinceincome_change + "\",");
            result.Append("\"planedInvest\":\"" + gpm.founds_down + "\",");
            result.Append("\"completedInvest\":\"" + gpm.founds_com + "\",");
            result.Append("\"completedInvestRate\":\"" + gpm.founds_rate + "\",");

            result.Append("\"specialProject2013\":\"" + gpm.project_num_2013 + "\",");
            result.Append("\"specialProject2013Rate\":\"" + gpm.project_com_rate_2013 + "\",");
            result.Append("\"specialProject2014\":\"" + gpm.project_num_2014 + "\",");
            result.Append("\"specialProject2014Rate\":\"" + gpm.project_com_rate_2014 + "\",");

            result.Append("\"investSituationByMoney\":[[" + gpm.before_cons_2013 + "," + gpm.in_cons_2013 + "," + gpm.com_cons_2013 + "],");
            result.Append("[" +gpm.before_cons_2014+","+gpm.in_cons_2014+","+gpm.com_cons_2014+ "]],");
            result.Append("\"investSituationByCategoryStructure\":[[" + gpm.plan2[0] + "," + gpm.plan2[1] + "," + gpm.plan2[2] + "," + gpm.plan2[3] + "," + gpm.plan2[4] + "],");
            result.Append("[" + gpm.finished2[0] + "," + gpm.finished2[1] + "," + gpm.finished2[2] + "," + gpm.finished2[3] + "," + gpm.finished2[4] + "]]");

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