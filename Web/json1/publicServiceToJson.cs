using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TTG.Web.json1
{
    public class publicServiceToJson : jsonTools
    {
        private DAL.GET.get_public_service gps;
        private StringBuilder result = new StringBuilder();

        public publicServiceToJson(String province, String county, String community)
        {
            gps = new DAL.GET.get_public_service(province, county, community);
        }
        public String getResult()
        {
            result.Append("{");
            addAttribute("basicSituation");
            #region basicSituation
            result.Append("{");
            addAttribute("situation2013");
            #region situation2013
            result.Append("{");
            addAttribute("kindergarten_capacity");
            addValue(gps.Kindergarten_cap_2013);
            result.Append(",");
            addAttribute("community_edu_area");
            addValue(gps.Teaching_area_2013);
            result.Append(",");
            addAttribute("otds_activity_room_area");
            addValue(gps.Out_play_area_2013);
            result.Append(",");
            addAttribute("community_clinic_area");
            addValue(gps.Clinic_area_2013);
            result.Append(",");
            addAttribute("community_clinic_bed_num");
            addValue(gps.Clinic_bed_2013);
            result.Append(",");
            addAttribute("community_otd_cul_spo_fac_area");
            addValue(gps.Out_ground_area_2013);
            result.Append(",");
            addAttribute("community_ind_actv_spa_area");
            addValue(gps.In_ground_area_2013);
            result.Append(",");
            addAttribute("community_fit_fac_num");
            addValue(gps.Fitness_equipment_2013);
            result.Append(",");
            addAttribute("community_nursingHome_area");
            addValue(gps.Old_area_2013);
            result.Append(",");
            addAttribute("integrated_management_building_area");
            addValue(gps.Management_area_2013);
            result.Append(",");
            addAttribute("community_parking_lot_area");
            addValue(gps.Parking_area_2013);
            result.Append(",");
            addAttribute("community_farm_produce_fair_gfa");
            addValue(gps.Farm_area_2013);
            result.Append(",");
            addAttribute("convenience_stores_area");
            addValue(gps.Market_area_2013);
            result.Append("},");
            #endregion
            addAttribute("situationNow");
            #region situationNow
            result.Append("{");
            addAttribute("kindergarten_capacity");
            addValue(gps.Kindergarten_cap_now);
            result.Append(",");
            addAttribute("community_edu_area");
            addValue(gps.Teaching_area_now);
            result.Append(",");
            addAttribute("otds_activity_room_area");
            addValue(gps.Out_play_area_now);
            result.Append(",");
            addAttribute("community_clinic_area");
            addValue(gps.Clinic_area_now);
            result.Append(",");
            addAttribute("community_clinic_bed_num");
            addValue(gps.Clinic_bed_now);
            result.Append(",");
            addAttribute("community_otd_cul_spo_fac_area");
            addValue(gps.Out_ground_area_now);
            result.Append(",");
            addAttribute("community_ind_actv_spa_area");
            addValue(gps.In_ground_area_now);
            result.Append(",");
            addAttribute("community_fit_fac_num");
            addValue(gps.Fitness_equipment_now);
            result.Append(",");
            addAttribute("community_nursingHome_area");
            addValue(gps.Old_area_now);
            result.Append(",");
            addAttribute("integrated_management_building_area");
            addValue(gps.Management_area_now);
            result.Append(",");
            addAttribute("community_parking_lot_area");
            addValue(gps.Parking_area_now);
            result.Append(",");
            addAttribute("community_farm_produce_fair_gfa");
            addValue(gps.Farm_area_now);
            result.Append(",");
            addAttribute("convenience_stores_area");
            addValue(gps.Market_area_now);
            result.Append("}");
            #endregion
            result.Append("},");
            #endregion
            addAttribute("implementSituation");
            #region implementSituation
            result.Append("{");
            addAttribute("plan");
            #region
            result.Append("{");
            addAttribute("community_added_kindergarten_capacity");
            addValue(gps.Add_kindergarten_cap_plan);
            result.Append(",");
            addAttribute("community_recon_kindergarten_capacity");
            addValue(gps.Change_kinder_cap_plan);
            result.Append(",");
            addAttribute("community_added_edu_area");
            addValue(gps.Add_teaching_area_plan);
            result.Append(",");
            addAttribute("community_added_kindergarten_exercise_yard_area");
            addValue(gps.Add_kinder_ground_plan);
            result.Append(",");
            addAttribute("community_added_clinic_area");
            addValue(gps.Add_clinic_plan);
            result.Append(",");
            addAttribute("community_maintain_reform_clinic_area");
            addValue(gps.Repair_clinic_plan);
            result.Append(",");
            addAttribute("community_added_clinic_bed_num");
            addValue(gps.Add_bed_plan);
            result.Append(",");
            addAttribute("community_added_otd_exercise_yard_area");
            addValue(gps.Add_out_ground_plan);
            result.Append(",");
            addAttribute("community_recon_otd_exercise_yard_area");
            addValue(gps.Repair_out_ground_plan);
            result.Append(",");
            addAttribute("community_added_ind_exercise_yard_area");
            addValue(gps.Add_in_ground_plan);
            result.Append(",");
            addAttribute("community_added_fitness_equipment_num");
            addValue(gps.Add_fitness_plan);
            result.Append(",");
            addAttribute("community_added_pension_faci_area");
            addValue(gps.Add_old_plan);
            result.Append(",");
            addAttribute("community_added_integrated_manage_house_area");
            addValue(gps.Add_manage_house_plan);
            result.Append(",");
            addAttribute("community_add_parking_lot_area");
            addValue(gps.Add_parking_plan);
            result.Append(",");
            addAttribute("community_added_farm_produce_fair_area");
            addValue(gps.Add_farm_area_plan);
            result.Append(",");
            addAttribute("community_added_cvs_area");
            addValue(gps.Add_market_plan);
            result.Append("},");
            #endregion achievement
            addAttribute("achievement");
            #region
            result.Append("{");
            addAttribute("community_added_kindergarten_capacity");
            addValue(gps.Add_kindergarten_cap_com);
            result.Append(",");
            addAttribute("community_recon_kindergarten_capacity");
            addValue(gps.Change_kinder_cap_com);
            result.Append(",");
            addAttribute("community_added_edu_area");
            addValue(gps.Add_teaching_area_com);
            result.Append(",");
            addAttribute("community_added_kindergarten_exercise_yard_area");
            addValue(gps.Add_kinder_ground_com);
            result.Append(",");
            addAttribute("community_added_clinic_area");
            addValue(gps.Add_clinic_com);
            result.Append(",");
            addAttribute("community_maintain_reform_clinic_area");
            addValue(gps.Repair_clinic_com);
            result.Append(",");
            addAttribute("community_added_clinic_bed_num");
            addValue(gps.Add_bed_com);
            result.Append(",");
            addAttribute("community_added_otd_exercise_yard_area");
            addValue(gps.Add_out_ground_com);
            result.Append(",");
            addAttribute("community_recon_otd_exercise_yard_area");
            addValue(gps.Repair_out_ground_com);
            result.Append(",");
            addAttribute("community_added_ind_exercise_yard_area");
            addValue(gps.Add_in_ground_com);
            result.Append(",");
            addAttribute("community_added_fitness_equipment_num");
            addValue(gps.Add_fitness_com);
            result.Append(",");
            addAttribute("community_added_pension_faci_area");
            addValue(gps.Add_old_com);
            //todo 维修改造养老设施面积
            result.Append(",");
            addAttribute("community_added_integrated_manage_house_area");
            addValue(gps.Add_manage_house_com);
            result.Append(",");
            addAttribute("community_add_parking_lot_area");
            addValue(gps.Add_parking_com);
            result.Append(",");
            addAttribute("community_added_farm_produce_fair_area");
            addValue(gps.Add_farm_area_com);
            result.Append(",");
            addAttribute("community_added_cvs_area");
            addValue(gps.Add_market_com);
            result.Append("}");
            #endregion
            result.Append("},");
            #endregion
            addAttribute("achievementSituation");
            #region achievementSituation
            result.Append("{");
            addAttribute("situation2013");
            #region
            result.Append("{");
            addAttribute("kindergarten_good_rate");
            addValue(gps.Kinder_rate_2013);
            result.Append(",");
            addAttribute("medical_good_rate");
            addValue(gps.Medical_rate_2013);
            result.Append(",");
            addAttribute("cul_fitness_facility_good_rate");
            addValue(gps.Culture_sports_rate_2013);
            result.Append(",");
            addAttribute("older_facility_good_rate");
            addValue(gps.Old_facilities_rate_2013);
            result.Append(",");
            addAttribute("parking_good_rate");
            addValue(gps.Parking_rate_2013);
            result.Append(",");
            addAttribute("vegetable_market_good_rate");
            addValue(gps.Farm_rate_2013);
            result.Append(",");
            addAttribute("CVS_good_rate");
            addValue(gps.Market_rate_2013);
            result.Append("},");
            #endregion
            addAttribute("situationNow");
            #region
            result.Append("{");
            addAttribute("kindergarten_good_rate");
            addValue(gps.Kinder_rate_now);
            result.Append(",");
            addAttribute("medical_good_rate");
            addValue(gps.Medical_rate_now);
            result.Append(",");
            addAttribute("cul_fitness_facility_good_rate");
            addValue(gps.Culture_sports_rate_now);
            result.Append(",");
            addAttribute("older_facility_good_rate");
            addValue(gps.Old_facilities_rate_now);
            result.Append(",");
            addAttribute("parking_good_rate");
            addValue(gps.Parking_rate_now);
            result.Append(",");
            addAttribute("vegetable_market_good_rate");
            addValue(gps.Farm_rate_now);
            result.Append(",");
            addAttribute("CVS_good_rate");
            addValue(gps.Market_rate_now);
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
            }else
            result.Append("\"" + value + "\"");
        }

        public void addValue(double value)
        {
            result.Append("\"" + value.ToString("0.00") + "\"");
        }

        public void addValue(int value)
        {
            result.Append("\"" + value + "\"");
        }

    }
}