using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TTG.Web.json1
{
    public class environmentToJson : jsonTools
    {
        private DAL.GET.get_env_protect gs;
        private StringBuilder result = new StringBuilder();
        public environmentToJson(String province,String county,String community)
        {
            gs = new DAL.GET.get_env_protect(province, county, community);
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
            addAttribute("community_road_lack_rd_length");
            addValue(gs.Less_roadside_dustbin_2013);
            result.Append(",");
            addAttribute("community_insuf_resd_area");
            addValue(gs.Less_house_dustbin_2013);
            result.Append(",");
            addAttribute("community_regional_insuf_sf_num");
            addValue(gs.Less_sanitation_2013);
            result.Append(",");
            addAttribute("community_toilet_insuf_pt_area");
            addValue(gs.Less_toilet_2013);
            result.Append(",");
            addAttribute("community_not_access_uspn_house_num");
            addValue(gs.Not_in_sewage_house_2013);
            result.Append(",");
            addAttribute("community_sewage_straight_to_cj_num");
            addValue(gs.Sewage_ditch_2013);
            result.Append(",");
            addAttribute("community_pipe_damage_length");
            addValue(gs.Drain_pipe_damage_2013);
            result.Append(",");
            addAttribute("community_gutter_damage");
            addValue(gs.Drain_ditch_damage_2013);
            result.Append(",");
            addAttribute("community_insuf_gutter");
            addValue(gs.Less_drain_ditch_2013);
            result.Append(",");
            addAttribute("community_greenland_area");
            addValue(gs.Green_area_2013);
            
            result.Append("},");
            #endregion
            addAttribute("situationNow");
            #region
            result.Append("{");

            addAttribute("community_road_lack_rd_length");
            addValue(gs.Less_roadside_dustbin_now);
            result.Append(",");
            addAttribute("community_insuf_resd_area");
            addValue(gs.Less_house_dustbin_now);
            result.Append(",");
            addAttribute("community_regional_insuf_sf_num");
            addValue(gs.Less_sanitation_now);
            result.Append(",");
            addAttribute("community_toilet_insuf_pt_area");
            addValue(gs.Less_toilet_now);
            result.Append(",");
            addAttribute("community_not_access_uspn_house_num");
            addValue(gs.Not_in_sewage_house_now);
            result.Append(",");
            addAttribute("community_sewage_straight_to_cj_num");
            addValue(gs.Sewage_ditch_now);
            result.Append(",");
            addAttribute("community_pipe_damage_length");
            addValue(gs.Drain_pipe_damage_now);
            result.Append(",");
            addAttribute("community_gutter_damage");
            addValue(gs.Drain_ditch_damage_now);
            result.Append(",");
            addAttribute("community_insuf_gutter");
            addValue(gs.Less_drain_ditch_now);
            result.Append(",");
            addAttribute("community_greenland_area");
            addValue(gs.Green_area_now);
            
            result.Append("}");
            #endregion
            result.Append("},");
            #endregion
            addAttribute("implementSituation");
            #region
            result.Append("{");
            addAttribute("plan");
            #region
            result.Append("{");
            addAttribute("community_added_ashbin_num");
            addValue(gs.Add_dustbin_plan);
            result.Append(",");
            addAttribute("community_added_waste_transfer_station_num");
            addValue(gs.Add_garbage_transfer_plan);
            result.Append(",");
            addAttribute("community_waste_transfer_station_maintain_reform_num");
            addValue(gs.Repair_garbage_transfer_plan);
            result.Append(",");
            addAttribute("community_added_public_toilet_num");
            addValue(gs.Add_toilet_plan);
            result.Append(",");
            addAttribute("community_public_toilet_maintain_reform_num");
            addValue(gs.Repair_toilet_plan);
            result.Append(",");
            addAttribute("community_maintain_ref_uspn_len");
            addValue(gs.Repair_sewage_plan);
            result.Append(",");
            addAttribute("community_added_uspn_len");
            addValue(gs.Add_sewage_plan);
            result.Append(",");
            addAttribute("community_added_water_drain_pipe_len");
            addValue(gs.Add_drain_plan);
            result.Append(",");
            addAttribute("community_added_gutter_len");
            addValue(gs.Add_ditch_plan);
            result.Append(",");
            addAttribute("community_maintain_ref_gutter_len");
            addValue(gs.Repair_ditch_plan);
            result.Append(",");
            addAttribute("community_added_septic_tank_num");
            addValue(gs.Add_septic_tank_plan);
            result.Append(",");
            addAttribute("community_added_green_area");
            addValue(gs.Add_green_plan);
            result.Append(",");
            addAttribute("community_tree_plant_num");
            addValue(gs.Plant_trees_plan);
           
            result.Append("},");
            #endregion
            addAttribute("achievement");
            #region
            result.Append("{");
            addAttribute("community_added_ashbin_num");
            addValue(gs.Add_dustbin_com);
            result.Append(",");
            addAttribute("community_added_waste_transfer_station_num");
            addValue(gs.Add_garbage_transfer_com);
            result.Append(",");
            addAttribute("community_waste_transfer_station_maintain_reform_num");
            addValue(gs.Repair_garbage_transfer_com);
            result.Append(",");
            addAttribute("community_added_public_toilet_num");
            addValue(gs.Add_toilet_com);
            result.Append(",");
            addAttribute("community_public_toilet_maintain_reform_num");
            addValue(gs.Repair_toilet_com);
            result.Append(",");
            addAttribute("community_maintain_ref_uspn_len");
            addValue(gs.Repair_sewage_com);
            result.Append(",");
            addAttribute("community_added_uspn_len");
            addValue(gs.Add_sewage_com);
            result.Append(",");
            addAttribute("community_added_water_drain_pipe_len");
            addValue(gs.Add_drain_com);
            result.Append(",");
            addAttribute("community_added_gutter_len");
            addValue(gs.Add_ditch_com);
            result.Append(",");
            addAttribute("community_maintain_ref_gutter_len");
            addValue(gs.Repair_ditch_com);
            result.Append(",");
            addAttribute("community_added_septic_tank_num");
            addValue(gs.Add_septic_tank_com);
            result.Append(",");
            addAttribute("community_added_green_area");
            addValue(gs.Add_green_com);
            result.Append(",");
            addAttribute("community_tree_plant_num");
            addValue(gs.Plant_trees_com);
           
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
            addAttribute("refuse_collect_rate");
            addValue(gs.Garbage_collect_rate_2013);
            result.Append(",");
            addAttribute("toilet_cover_degree");
            addValue(gs.Toilet_coverage_rate_2013);
            result.Append(",");
            addAttribute("sewage_collect_rate");
            addValue(gs.Sewage_collect_rate_2013);
            result.Append(",");
            addAttribute("drain_safe_degree");
            addValue(gs.Drain_safe_rate_2013);
            result.Append(",");
            addAttribute("green_rate");
            addValue(gs.Green_rate_2013);

            result.Append("},");
            #endregion
            addAttribute("situationNow");
            #region
            result.Append("{");
            addAttribute("refuse_collect_rate");
            addValue(gs.Garbage_collect_rate_now);
            result.Append(",");
            addAttribute("toilet_cover_degree");
            addValue(gs.Toilet_coverage_rate_now.ToString());
            result.Append(",");
            addAttribute("sewage_collect_rate");
            addValue(gs.Sewage_collect_rate_now);
            result.Append(",");
            addAttribute("drain_safe_degree");
            addValue(gs.Drain_safe_rate_now);
            result.Append(",");
            addAttribute("green_rate");
            addValue(gs.Green_rate_now);

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
            if (value == null || value == "")
            {
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