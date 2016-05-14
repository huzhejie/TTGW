using System.Data;
using System.Collections.Generic;
namespace Initialization
{
    public class community_water_supply
    {
        public const string water_supply_table = "T_community_water_supply";
        public static List<string> info() { return new List<string>() { "community_water_supply_pipe_length" }; }
        public static List<string> result() { return new List<string>() { "新建供水管长度(km)" }; }

        //public const string water_supply_column = "community_water_supply_pipe_length";
        //public const string water_supply_result_column = "新建供水管长度";
    }
    public class community_water_drain
    {
        public const string water_drain_table = "T_community_water_drain";
        public static List<string> info()
        {
            return new List<string>(){
               "community_water_drain_pipe_length",
               "community_water_drain_canal_length",
               "community_septic_tank_num"
           };
        }

        public static List<string> result()
        {
            return new List<string>(){
                "新建排水管长度(km)",
                "新建排(洪)水沟长度(km)",
                "新建化粪池数量(个)"
           };
        }
        //public const string water_drain_column1 = "community_water_drain_pipe_length";
        //public const string water_drain_column2 = "community_water_drain_canal_length ";
        //public const string water_drain_column3 = "community_septic_tank_num";
        //public const string water_drain_result_column1 = "新建排水管长度";
        //public const string water_drain_result_column2 = "新建排(洪)水沟长度";
        //public const string water_drain_result_column3 = "新建化粪池数量";
    }
    public class community_social_insurance
    {
        public const string social_insurance_table = "T_community_social_insurance";
        public const string social_insurance_result_table = "T_important_figures";
        public static List<string> info() { return new List<string>() { "community_urban_min_living_sec_pop" }; }
        public static List<string> result() { return new List<string>() { "poor_people_num" }; }
        //public const string social_insurance_column = "community_urban_min_living_sec_pop";
        //public const string social_insurance_result_column = "poor_people_num";
    }

    public class community_electricity_supply
    {
        public const string electricity_supply_table = "T_community_elec_supply";
        public static List<string> info()
        {
            return new List<string>(){
               "community_transformer_num",
               "community_elec_supply_wireways_length",
                "community_elec_supply_consumption"
           };
        }
        public static List<string> result()
        {
            return new List<string>(){
               "新增变压器数量(台)",
               "新建配电线路(km)",
               "新增变压器后增容(KVA)"
           };
        }
        //public static string electricity_supply_column1 = "community_transformer_num";
        //public const string electricity_supply_column2 = "community_elec_supply_wireways_length ";
        //public const string electricity_supply_column3 = "community_elec_supply_consumption";
        //public const string electricity_supply_result_column1 = "新增变压器数量";
        //public const string electricity_supply_result_column2 = "新建配电线路";
        //public const string electricity_supply_result_column3 = "新增变压器后增容";
    }
    public class community_light
    {
        public const string light_table = "T_community_light";
        public static List<string> info()
        {
            return new List<string>() { 
           "community_streetlight_num",
           "community_passageway_light_num"
           };
        }
        public static List<string> result()
        {
            return new List<string>() { 
           "新增室外照明设施数量(盏)",
           "新增楼栋照明设施数量(盏)"
           };
        }
        //public const string light_column1 = "community_streetlight_num";
        //public const string light_column2 = "community_passageway_light_num";
        //public const string light_result_column1 = "新增室外照明设施数量";
        //public const string light_result_column2 = "新增楼栋照明设施数量";
    }
    public class community_greenland
    {
        public const string greenland_table = "T_community_green_fields";
        public static List<string> info()
        {
            return new List<string>(){
              "community_green_fields_area",
           };
        }
        public static List<string> result()
        {
            return new List<string>()
           {
               "新增绿化面积(m2)"
           };
        }
        //public const string greenland_column = "community_public_greenland_area";
        //public const string greenland_result_column = "新增绿化面积";
    }
    public class community_road
    {
        public const string road_table = "T_community_road";
        public static List<string> info()
        {
            return new List<string>(){
               "community_road_area",
               "community_road_pavement_area",
               "community_pavement_length",
               "community_road_num"
           };
        }
        public static List<string> result()
        {
            return new List<string>(){
              "新建机动车道面积(m2)" ,
               "新建机动车道条数(条)",
               "新建人行道面积(m2)",
               "新建梯道长度(km)"
           };
        }
        //public const string road_column1 = "community_road_area";
        //public const string road_column2 = "community_road_pavement_area";
        //public const string road_column3 = "community_pavement_length";
        //public const string road_column4 = "community_road_num";
        //public const string road_result_column1 = "新建机动车道面积";
        //public const string road_result_column2 = "新建机动车道条数";
        //public const string road_result_column3 = "新建人行道面积";
        //public const string road_result_column4 = "新建梯道长度";
    }

    public class community_parking_lot
    {
        public const string parking_lot_table = "T_community_parking_lot";
        public static List<string> info()
        {
            return new List<string>(){
                "community_parking_space_num",
             "community_public_parking_lot_area"
           };
        }
        public static List<string> result()
        {
            return new List<string>(){
                 "新增停车位数量(个)",
                 "新增停车场面积(m2)"
           };
        }
        //public const string parking_lot_column1 = "community_parking_space_num";
        //public const string parking_lot_column2 = "community_public_parking_lot_area";
        //public const string parking_lot_result_column1 = "新增停车位数量";
        //public const string parking_lot_result_column2 = "新增停车场面积";
    }
    public class community_kindergarten
    {
        public const string kindergarten_table = "T_community_education";
        public static List<string> info()
        {
            return new List<string>(){
               "community_kdg_stu_num",
                "community_kdg_actv_room_area",
                "community_kdg_otd_actv_spa_area"
           };
        }
        public static List<string> result()
        {
            return new List<string>(){
             "新增幼儿园容量(人)",
             "新增教学面积(m2)",
             "新增幼儿园活动场地(m2)"
           };
        }
        //public const string kindergarten_column1 = "community_kdg_stu_num";
        //public const string kindergarten_column2 = "community_kdg_actv_room_area";
        //public const string kindergarten_column3 = "community_kdg_otd_actv_spa_area";
        //public const string kindergarten_result_column1 = "新增幼儿园容量";
        //public const string kindergarten_result_column2 = "新增教学面积";
        //public const string kindergarten_result_column3 = "新增幼儿园活动场地";
    }

    public class community_medical
    {
        public const string medical_talbe = "T_community_medical";
        public static List<string> info()
        {
            return new List<string>(){
              "community_clinic_fs",
              "community_clinic_bed_num"
           };
        }
        public static List<string> result()
        {
            return new List<string>(){
           "新增卫生室面积(m2)",
           "新增卫生室床位数(个)"
           };
        }
        //public const string medical_column1 = "community_clinic_fs";
        //public const string medical_column2 = "community_clinic_bed_num";
        //public const string medical_result_column1 = "新增卫生室面积";
        //public const string medical_result_column2 = "新增卫生室床位数";
    }
    //这个有点特别
    public class community_sports
    {
        public const string sports_table = "T_community_culture_sports";
        public static List<string> info()
        {
            return new List<string>(){
            "community_otd_cul_spo_fac_gfa",
            "community_ind_actv_spa_fs",
            "community_fit_fac_num",
            "community_culture_sports_fs"
           };
        }
        public static List<string> result()
        {
            return new List<string>(){
            "新增室外活动场地面积(m2)",
            "新增建设室内活动场所面积(m2)",
            "新增健身器材(套)"
           };
        }
        //public const string sports_column1 = "community_otd_cul_spo_fac_gfa";
        //public const string sports_column2 = "community_ind_actv_spa_fs";
        //public const string sports_column3 = "community_fit_fac_num";
        //public const string sports_column4 = "community_culture_sports_fs"; //列4等于结果中列1和列2的和
        //public const string sports_result_column1 = "新增室外活动场地面积 ";
        //public const string sports_result_column2 = "新增建设室内活动场所面积";
        //public const string sports_result_column3 = "新增健身器材";
    }
    public class community_servece
    {
        public const string service_table = "T_community_service";
        public static List<string> info()
        {
            return new List<string>(){
               "community_comm_serv_cen_fs",
               "community_old_fs"
           };
        }
        public static List<string> result()
        {
            return new List<string>(){
                "新增社区综合管理用房(m2)",
                 "新增养老设施面积(m2)"
           };
        }
        //public const string service_column1 = "community_comm_serv_cen_fs";
        //public const string service_column2 = "";
        //public const string service_result_column1= "新增社区综合管理用房";
        //public const string service_result_column2 = "新增养老设施面积";

    }
    public class community_commerce
    {
        public const string commerce_table = "T_community_commerce";
        public static List<string> info()
        {
            return new List<string>(){
               "community_farm_produce_fair_fs",
               "community_convinent_market_fs"
           };
        }
        public static List<string> result()
        {
            return new List<string>(){
                "新增农贸市场面积(m2)",
                "新增便民超市面积(m2)"
           };
        }
        //public const string commerce_column1 = "community_farm_produce_fair_fs";
        //public const string commerce_column2 = "";
        //public const string commerce_result_column1 = "新增农贸市场面积";
        //public const string commerce_result_column2 = "新增便民超市面积";
    }
    public class fire_fighting
    {
        public static string fire_fighting_table = "T_community_fire_fighting";
        public static List<string> info()
        {
            return new List<string>(){
            "community_ots_hydrant_num",
            "community_ind_hydrant_num",
            //"community_ff_not_attain_pass_length"
           };
        }
        public static List<string> result()
        {
            return new List<string>(){
            "新增室外消防设施数量(套)",
            "新增室内消防设施数量(套)",
           // ""
           };
        }
        //public const string fire_fighting_column1 = "community_ots_hydrant_num";
        //public const string fire_fighting_column2 = "community_ind_hydrant_num";
        //public const string fire_fighting_column3 = "community_ff_not_attain_pass_length";
        //public const string fire_fighting_result_column1 = "新增室外消防设施数量";
        //public const string fire_fighting_result_column2 = "新增室内消防设施数量";
        //public const string fire_fighting_result_column3="";
    }
    public class community_environment
    {
        public const string environment_table = "T_community_environmental_hygiene";
        public static List<string> info()
        {
            return new List<string>(){
            "community_refuse_transfer_station_num",
            "community_dustbin_num",
            "community_public_toilet_num"
           };
        }
        public static List<string> result()
        {
            return new List<string>(){
            "新增垃圾中转站数量(个)",
            "新增垃圾桶箱数量(个)",
            "新增公厕(个)"
           };
        }
        //public const string environment_column1 = "community_refuse_transfer_station_num";
        //public const string environment_column2 = "community_dustbin_num";
        //public const string environment_column3 = "community_public_toilet_num";
        //public const string environment_result_column1 = "新增垃圾中转站数量";
        //public const string environment_result_column2 = "新增垃圾桶箱数量";
        //public const string environment_result_column3 = "新增公厕";
    }
    public class community_store
    {
        public const string store_table = "T_community_shop_front";
        public const string store_result_table = "T_important_figures";
        public static List<string> info()
        {
            return new List<string>(){
            "community_immigrant_shop_front_num",
            "community_average_rent_of_shop_front",
            "county_average_rent"
           };
        }
        public static List<string> result()
        {
            return new List<string>(){
            "facade_num",
            "average_rent",
            "county_average_rent"
           };
        }
        //public const string store_column1 = "community_immigrant_shop_front_num";
        //public const string store_column2 = "community_average_rent_of_shop_front";
        //public const string store_column3 = "county_average_rent";
        //public const string store_result_column1 = "facade_num";
        //public const string store_result_column2 = "average_rent";
        //public const string store_result_column3 = "county_average_rent";
    }
    public class community_employment
    {
        public const string employment_table = "T_community_lf_employment";
        public const string employment_result_table = "T_important_figures";
        public static List<string> info()
        {
            return new List<string>(){
            "community_total_lf_pop",
            "community_have_job_pop"
           };
        }
        public static List<string> result()
        {
            return new List<string>(){
            "labor_num",
            "employed_labor_num"
           };
        }
        //public const string employment_column1 = "community_total_lf_pop";
        //public const string employment_column2 = "community_have_job_pop";
        //public const string employment_result_column1 = "labor_num";
        //public const string employment_result_column2 = "employed_labor_num";
    }
    public class OtherTables
    {
        public static List<string> getOtherTable()
        {
            return new List<string>(){
        "T_Community_Base",
        "T_community_population",
        "T_community_immigrant",
        "T_community_traffic",
        "T_community_natural_gas",
        "T_community_security",
        "T_community_geologic_hazard",
        "T_community_letter_view"
        };
        }
    }
}
