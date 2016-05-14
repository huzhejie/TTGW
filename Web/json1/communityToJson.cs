using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TTG.Web.json1
{
    public class communityToJson : jsonTools
    {
        private DAL.GET.get_community_mainpage gcm;
        private StringBuilder result = new StringBuilder();
        public communityToJson(String province,String county,String community)
        {
            //todo
            if (province != null && county != null && community != null)
                gcm = new DAL.GET.get_community_mainpage(province, county, community);
        }

        public communityToJson(String communityID)
        {
            //todo
        }

        public String getResult()
        {
            result.Append("{");
            result.Append("\"communityType\":\"" + gcm.Community_type + "\",");
            result.Append("\"buildingYear\":\"" + gcm.Construct_year + "\",");
            result.Append("\"buildingArea\":\"" + gcm.Construction_area + "\",");
            result.Append("\"coverArea\":\"" + gcm.Floor_area.ToString("0.00") + "\",");
            result.Append("\"volumeRate\":\"" + gcm.Plot_ratio.ToString("0.00") + "\",");
            result.Append("\"greenRate\":\"" + gcm.Green_rate.ToString("0.00") + "\",");
            result.Append("\"parkingSpace\":\"" + gcm.Parking_lot + "\",");
            result.Append("\"facadeNum\":\"" + gcm.Facade + "\",");
            result.Append("\"familyNum\":\"" + gcm.Reg_family_num + "\",");
            result.Append("\"residentNum\":\"" + gcm.Reg_people_num + "\",");
            result.Append("\"immigrantFamily\":\"" + gcm.Immigrant_family_num + "\",");
            result.Append("\"immigrant\":\"" + gcm.Immigrant_people_num + "\",");
            result.Append("\"houseAreaPer\":\"" + gcm.Average_house_area.ToString("0.00") + "\",");
            result.Append("\"lowAllowanceRate\":\"" + gcm.Poor_rate.ToString("0.00") + "\",");
            //to do
            addAttribute("planedInvest");
            addValue(gcm.Founds_down);
            result.Append(",");
            addAttribute("completedInvest");
            addValue(gcm.Founds_com);
            result.Append(",");
            addAttribute("completedInvestRate");
            addValue(gcm.Founds_rate);
            result.Append(",");
            addAttribute("specialProject2013");
            addValue(gcm.Project_num_2013);
            result.Append(",");
            addAttribute("specialProject2013Rate");
            addValue(gcm.Project_com_rate_2013);
            result.Append(",");
            addAttribute("specialProject2014");
            addValue(gcm.Project_num_2014);
            result.Append(",");
            addAttribute("specialProject2014Rate");
            addValue(gcm.Project_com_rate_2014);
            result.Append(",");

            //result.Append("\"planedInvest\":\"" + gcm.Founds_down + "\",");
            
            //result.Append("\"completedInvest\":\"" + gcm.Founds_com + "\",");
            //result.Append("\"completedInvestRate\":\"" + gcm.Founds_rate.ToString("0.00") + "\",");
            //result.Append("\"specialProject2013\":\"" + gcm.Project_num_2013 + "\",");
            //result.Append("\"specialProject2013Rate\":\"" + gcm.Project_com_rate_2013.ToString("0.00") + "\",");
            //result.Append("\"specialProject2014\":\"" + gcm.Project_num_2014 + "\",");
            //result.Append("\"specialProject2014Rate\":\"" + gcm.Project_com_rate_2014.ToString("0.00") + "\",");
            //to do end
            result.Append("\"facadeUsingRate\":\"" + gcm.Facade_use_rate[0].ToString("0.00") + "\",");
            result.Append("\"employmentRate\":\"" + gcm.Employment_rate[0].ToString("0.00") + "\",");
            result.Append("\"disposableIncomePer\":\"" + gcm.Disposable_income[0].ToString("0.00") + "\",");
            result.Append("\"houseRentPer\":\"" + gcm.Average_rent[0].ToString("0.00") + "\",");
            //to do
            result.Append("\"investSituationByMoney\":[[" + gcm.Before_cons_2013 + "," + gcm.In_cons_2013 + "," + gcm.Com_cons_2013 + "],");
            result.Append("[" + gcm.Before_cons_2014+ "," + gcm.In_cons_2014 + "," + gcm.Com_cons_2014 + "]],");
            result.Append("\"investSituationByCategoryStructure\":[[" + gcm.Plan_house_safe + "," + gcm.Plan_base_fac + "," + gcm.Plan_envir_pro + "," + gcm.Plan_public_fac + "," + gcm.Plan_busin + "],");
            result.Append("[" + gcm.Com_house_safe + "," + gcm.Com_base_fac + "," + gcm.Com_envir_pro + "," + gcm.Com_public_fac + "," + gcm.Com_busin + "]],");
            result.Append(" \"changeTrend\": [{\"facadeUsingRate\": [ "+gcm.Facade_use_rate[0]+"," +gcm.Facade_use_rate[1]+"]},{\"employmentRate\": [  "+gcm.Employment_rate[0]+","+gcm.Employment_rate[1]+ "]}, ");
            result.Append("{\"disposableIncomePer\": ["+gcm.Disposable_income[0]+","+gcm.Disposable_income[1]+"]}, ");
            result.Append("{\"houseRentPer\": ["+gcm.Average_rent[0]+","+gcm.Average_rent[1]+"]}]");
            result.Append("}");
            return result.ToString();
        }

        public void addAttribute(string attr)
        {
            result.Append("\"" + attr + "\":");
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