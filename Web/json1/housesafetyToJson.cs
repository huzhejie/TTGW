using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TTG.Web.json1
{
    public class housesafetyToJson : jsonTools
    {
        private DAL.GET.get_house_safety ghs;
        private StringBuilder result = new StringBuilder();
        public housesafetyToJson(String province,String county,String community)
        {
            ghs = new DAL.GET.get_house_safety(province, county, community);
        }

        public String getResult()
        {
            result.Append("{"); 
            addAttribute("basicSituation");
            #region
            result.Append("{");
            addAttribute("situation2013");
            #region
            result.Append("{");
            addAttribute("community_council_buil_num");
            addValue(ghs.System_building_2013);
            result.Append(",");
            addAttribute("community_slight_deform_split_area");
            addValue(ghs.Crack_area_2013);
            result.Append(",");
            addAttribute("community_house_foun_setm_area");
            addValue(ghs.Foundation_down_2013);
            result.Append(",");
            addAttribute("community_is_decrepit_house_area");
            addValue(ghs.Dangerous_2013);
            result.Append(",");
            addAttribute("community_roof_seepage_house_area");
            addValue(ghs.Leakage_2013);
            result.Append(",");
            addAttribute("community_exw_ct_shedding_house_area");
            addValue(ghs.Tile_fall_2013);
            result.Append(",");
            addAttribute("community_slope_not_govern_house_num");
            addValue(ghs.Slope_ndeal_2013);
            result.Append("},");
            #endregion
            addAttribute("situationNow");
            #region
            result.Append("{");
            addAttribute("community_council_buil_num");
            addValue(ghs.System_building_now);
            result.Append(",");
            addAttribute("community_slight_deform_split_area");
            addValue(ghs.Crack_area_now);
            result.Append(",");
            addAttribute("community_house_foun_setm_area");
            addValue(ghs.Foundation_down_now);
            result.Append(",");
            addAttribute("community_is_decrepit_house_area");
            addValue(ghs.Dangerous_now);
            result.Append(",");
            addAttribute("community_roof_seepage_house_area");
            addValue(ghs.Leakage_now);
            result.Append(",");
            addAttribute("community_exw_ct_shedding_house_area");
            addValue(ghs.Tile_fall_now);
            result.Append(",");
            addAttribute("community_slope_not_govern_house_num");
            addValue(ghs.Slope_ndeal_now);
            #endregion
            result.Append("}},");
            #endregion
            addAttribute("implementSituation");
            #region
            result.Append("{");
            addAttribute("plan");
            #region
            result.Append("{");
            addAttribute("community_struc_reinforce_num");
            addValue(ghs.Struct_safe_num_plan);
            result.Append(",");
            addAttribute("community_struc_reinforce_area");
            addValue(ghs.Struct_safe_area_plan);
            result.Append(",");
            addAttribute("community_roof_leakproof_num");
            addValue(ghs.Leak_proof_num_plan);
            result.Append(",");
            addAttribute("community_roof_leakproof_area");
            addValue(ghs.Leak_proof_area_plan);
            result.Append(",");
            addAttribute("community_facades_maintain_num");
            addValue(ghs.Repair_wall_num_plan);
            result.Append(",");
            addAttribute("community_facades_maintain_area");
            addValue(ghs.Repair_wall_area_plan);
            result.Append(",");
            addAttribute("community_slope_govern_house_area");
            addValue(ghs.Slope_deal_plan);
            result.Append(",");
            addAttribute("community_slope_govern_ins_pop_num");
            addValue(ghs.Slope_people_num_plan);
            result.Append("},");
            #endregion
            addAttribute("achievement");
            #region
            result.Append("{");
            addAttribute("community_struc_reinforce_num");
            addValue(ghs.Struct_safe_num_com);
            result.Append(",");
            addAttribute("community_struc_reinforce_area");
            addValue(ghs.Struct_safe_area_com);
            result.Append(",");
            addAttribute("community_roof_leakproof_num");
            addValue(ghs.Leak_proof_num_com);
            result.Append(",");
            addAttribute("community_roof_leakproof_area");
            addValue(ghs.Leak_proof_area_com);
            result.Append(",");
            addAttribute("community_facades_maintain_num");
            addValue(ghs.Repair_wall_num_com);
            result.Append(",");
            addAttribute("community_facades_maintain_area");
            addValue(ghs.Repair_wall_area_com);
            result.Append(",");
            addAttribute("community_slope_govern_house_area");
            addValue(ghs.Slope_deal_com);
            result.Append(",");
            addAttribute("community_slope_govern_ins_pop_num");
            addValue(ghs.Slope_people_num_com);
            result.Append("}");
            #endregion
            result.Append("},");
            #endregion
            addAttribute("achievementSituation");
            #region
            result.Append("{");
            addAttribute("situation2013");
            #region
            result.Append("{");
            addAttribute("structure_safe_good_rate");
            addValue(ghs.Struct_safe_rate_2013);
            result.Append(",");
            addAttribute("roof_good_rate");
            addValue(ghs.Roof_com_rate_2013);
            result.Append(",");
            addAttribute("wall_good_rate");
            addValue(ghs.Wall_com_rate_2013);
            result.Append(",");
            addAttribute("slope_safe_rate");
            addValue(ghs.Slope_stable_rate_2013);
            result.Append("},");
            #endregion
            addAttribute("situationNow");
            #region
            result.Append("{");
            addAttribute("structure_safe_good_rate");
            addValue(ghs.Struct_safe_rate_now);
            result.Append(",");
            addAttribute("roof_good_rate");
            addValue(ghs.Roof_com_rate_now);
            result.Append(",");
            addAttribute("wall_good_rate");
            addValue(ghs.Wall_com_rate_now);
            result.Append(",");
            addAttribute("slope_safe_rate");
            addValue(ghs.Slope_stable_rate_now);
            result.Append("}");
            #endregion
            result.Append("}");
            #endregion
            result.Append("}"); 
            return result.ToString();
        }

        public void addAttribute(String attr)
        {
            result.Append("\"" + attr + "\":");
        }

        public void addValue(String value)
        {
            if(value==null||value==""){
                value = "--";
            }
            else
                result.Append("\"" + value + "\"");
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