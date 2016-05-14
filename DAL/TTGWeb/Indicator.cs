using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TTG.Model.TTGWeb;

namespace TTG.DAL.TTGWeb
{
    public class Indicator
    {
        private double structure_safe_good_rate;

        public double Structure_safe_good_rate
        {
            get { return structure_safe_good_rate; }
            set { structure_safe_good_rate = value; }
        }
        private double roof_good_rate;

        public double Roof_good_rate
        {
            get { return roof_good_rate; }
            set { roof_good_rate = value; }
        }
        private double wall_good_rate;

        public double Wall_good_rate
        {
            get { return wall_good_rate; }
            set { wall_good_rate = value; }
        }
        private double slope_safe_rate;

        public double Slope_safe_rate
        {
            get { return slope_safe_rate; }
            set { slope_safe_rate = value; }
        }
        private double concil_house_validate;

        public double Concil_house_validate
        {
            get { return concil_house_validate; }
            set { concil_house_validate = value; }
        }
        private double road_link_degree;

        public double Road_link_degree
        {
            get { return road_link_degree; }
            set { road_link_degree = value; }
        }
        private double road_good_degree;

        public double Road_good_degree
        {
            get { return road_good_degree; }
            set { road_good_degree = value; }
        }
        private double traffic_validate;

        public double Traffic_validate
        {
            get { return traffic_validate; }
            set { traffic_validate = value; }
        }
        private double water_capcity_degree;

        public double Water_capcity_degree
        {
            get { return water_capcity_degree; }
            set { water_capcity_degree = value; }
        }
        private double water_pipe_net_good_degree;

        public double Water_pipe_net_good_degree
        {
            get { return water_pipe_net_good_degree; }
            set { water_pipe_net_good_degree = value; }
        }
        private double one_hou_one_water_meter_rate;

        public double One_hou_one_water_meter_rate
        {
            get { return one_hou_one_water_meter_rate; }
            set { one_hou_one_water_meter_rate = value; }
        }
        private double water_supply_validate;

        public double Water_supply_validate
        {
            get { return water_supply_validate; }
            set { water_supply_validate = value; }
        }
        private double elec_capcity_degree;

        public double Elec_capcity_degree
        {
            get { return elec_capcity_degree; }
            set { elec_capcity_degree = value; }
        }
        private double elec_wire_safe_degree;

        public double Elec_wire_safe_degree
        {
            get { return elec_wire_safe_degree; }
            set { elec_wire_safe_degree = value; }
        }
        private double one_hou_one_elec_meter_rate;

        public double One_hou_one_elec_meter_rate
        {
            get { return one_hou_one_elec_meter_rate; }
            set { one_hou_one_elec_meter_rate = value; }
        }
        private double elec_supply_validate;

        public double Elec_supply_validate
        {
            get { return elec_supply_validate; }
            set { elec_supply_validate = value; }
        }
        private double road_light_suff_degree;

        public double Road_light_suff_degree
        {
            get { return road_light_suff_degree; }
            set { road_light_suff_degree = value; }
        }
        private double passway_light_suff_degree;

        public double Passway_light_suff_degree
        {
            get { return passway_light_suff_degree; }
            set { passway_light_suff_degree = value; }
        }
        private double light_validate;

        public double Light_validate
        {
            get { return light_validate; }
            set { light_validate = value; }
        }
        private double outdoors_ff_good_rate;

        public double Outdoors_ff_good_rate
        {
            get { return outdoors_ff_good_rate; }
            set { outdoors_ff_good_rate = value; }
        }
        private double indoors_ff_good_rate;

        public double Indoors_ff_good_rate
        {
            get { return indoors_ff_good_rate; }
            set { indoors_ff_good_rate = value; }
        }
        private double ff_way_good_rate;

        public double Ff_way_good_rate
        {
            get { return ff_way_good_rate; }
            set { ff_way_good_rate = value; }
        }
        private double ff_validate;

        public double Ff_validate
        {
            get { return ff_validate; }
            set { ff_validate = value; }
        }
        private double basic_facility_validate;

        public double Basic_facility_validate
        {
            get { return basic_facility_validate; }
            set { basic_facility_validate = value; }
        }
        private double refuse_collect_rate;

        public double Refuse_collect_rate
        {
            get { return refuse_collect_rate; }
            set { refuse_collect_rate = value; }
        }
        private double toilet_cover_degree;

        public double Toilet_cover_degree
        {
            get { return toilet_cover_degree; }
            set { toilet_cover_degree = value; }
        }
        private double sanitation_validate;

        public double Sanitation_validate
        {
            get { return sanitation_validate; }
            set { sanitation_validate = value; }
        }
        private double sewage_collect_rate;

        public double Sewage_collect_rate
        {
            get { return sewage_collect_rate; }
            set { sewage_collect_rate = value; }
        }
        private double drain_safe_degree;

        public double Drain_safe_degree
        {
            get { return drain_safe_degree; }
            set { drain_safe_degree = value; }
        }
        private double drain_validate;

        public double Drain_validate
        {
            get { return drain_validate; }
            set { drain_validate = value; }
        }
        private double green_validate;

        public double Green_validate
        {
            get { return green_validate; }
            set { green_validate = value; }
        }
        private double environment_validate;

        public double Environment_validate
        {
            get { return environment_validate; }
            set { environment_validate = value; }
        }
        private double service_gfs_good_rate;

        public double Service_gfs_good_rate
        {
            get { return service_gfs_good_rate; }
            set { service_gfs_good_rate = value; }
        }
        private double kindergarten_good_rate;

        public double Kindergarten_good_rate
        {
            get { return kindergarten_good_rate; }
            set { kindergarten_good_rate = value; }
        }
        private double medical_good_rate;

        public double Medical_good_rate
        {
            get { return medical_good_rate; }
            set { medical_good_rate = value; }
        }
        private double parking_good_rate;

        public double Parking_good_rate
        {
            get { return parking_good_rate; }
            set { parking_good_rate = value; }
        }
        private double CVS_good_rate;

        public double CVS_good_rate1
        {
            get { return CVS_good_rate; }
            set { CVS_good_rate = value; }
        }
        private double vegetable_market_good_rate;

        public double Vegetable_market_good_rate
        {
            get { return vegetable_market_good_rate; }
            set { vegetable_market_good_rate = value; }
        }
        private double commerce_validate;

        public double Commerce_validate
        {
            get { return commerce_validate; }
            set { commerce_validate = value; }
        }
        private double cul_fitness_facility_good_rate;

        public double Cul_fitness_facility_good_rate
        {
            get { return cul_fitness_facility_good_rate; }
            set { cul_fitness_facility_good_rate = value; }
        }
        private double older_facility_good_rate;

        public double Older_facility_good_rate
        {
            get { return older_facility_good_rate; }
            set { older_facility_good_rate = value; }
        }
        private double public_service_good_rate;

        public double Public_service_good_rate
        {
            get { return public_service_good_rate; }
            set { public_service_good_rate = value; }
        }
        private double shop_front_use_rate;

        public double Shop_front_use_rate
        {
            get { return shop_front_use_rate; }
            set { shop_front_use_rate = value; }
        }
        private double shop_front_rent_level;

        public double Shop_front_rent_level
        {
            get { return shop_front_rent_level; }
            set { shop_front_rent_level = value; }
        }
        private double shop_validate;

        public double Shop_validate
        {
            get { return shop_validate; }
            set { shop_validate = value; }
        }
        private double community_validate;

        public double Community_validate
        {
            get { return community_validate; }
            set { community_validate = value; }
        }
        public Indicator(String community_id, DateTime statistics_date)
        {
            calculateStructure_safe_good_rate(community_id, statistics_date);
            calculateRoof_good_rate(community_id, statistics_date);
            calculateWall_good_rate(community_id, statistics_date);
            calculateSlope_safe_rate(community_id, statistics_date);
            calculateConcil_house_validate(community_id, statistics_date);
            //calculateRoad_link_degree(community_id, statistics_date);
            //calculateRoad_good_degree(community_id, statistics_date);
            calculateTraffic_validate(community_id, statistics_date);
            calculateWater_capcity_degree(community_id, statistics_date);
            calculateWater_pipe_net_good_degree(community_id, statistics_date);
            calculateOne_hou_one_water_meter_rate(community_id, statistics_date);
            calculateWater_supply_validate(community_id, statistics_date);
            calculateElec_capcity_degree(community_id, statistics_date);
            calculateElec_wire_safe_degree(community_id, statistics_date);
            calculateOne_hou_one_elec_meter_rate(community_id, statistics_date);
            calculateElec_supply_validate(community_id, statistics_date);
            calculateRoad_light_suff_degree(community_id, statistics_date);
            calculatePassway_light_suff_degree(community_id, statistics_date);
            calculateLight_validate(community_id, statistics_date);
            calculateOutdoors_ff_good_rate(community_id, statistics_date);
            calculateIndoors_ff_good_rate(community_id, statistics_date);
            calculateFf_way_good_rate(community_id, statistics_date);
            calculateFf_validate(community_id, statistics_date);
            calculateBasic_facility_validate(community_id, statistics_date);
            //calculateRefuse_collect_rate(community_id, statistics_date);
            calculateToilet_cover_degree(community_id, statistics_date);
            calculateSanitation_validate(community_id, statistics_date);
            calculateSewage_collect_rate(community_id, statistics_date);
            //calculateDrain_safe_degree(community_id, statistics_date);
            calculateDrain_validate(community_id, statistics_date);
            calculateGreen_validate(community_id, statistics_date);
            calculateEnvironment_validate(community_id, statistics_date);
            calculateService_gfs_good_rate(community_id, statistics_date);
            calculateKindergarten_good_rate(community_id, statistics_date);
            calculateMedical_good_rate(community_id, statistics_date);
            calculateParking_good_rate(community_id, statistics_date);
            calculateCVS_good_rate(community_id, statistics_date);
            calculateVegetable_market_good_rate(community_id, statistics_date);
            calculateCommerce_validate(community_id, statistics_date);
            calculateCul_fitness_facility_good_rate(community_id, statistics_date);
            calculateOlder_facility_good_rate(community_id, statistics_date);
            calculatePublic_service_good_rate(community_id, statistics_date);
            calculateShop_front_use_rate(community_id, statistics_date);
            calculateShop_front_rent_level(community_id, statistics_date);
            calculateShop_validate(community_id, statistics_date);
            calculateCommunity_validate(community_id, statistics_date);
        }
        public Indicator(String communtiy_id, int year)
        {
            Random ra = new Random(year);
            structure_safe_good_rate = Math.Round((double)ra.Next(10, 100), 2);
            roof_good_rate = Math.Round((double)ra.Next(10, 100), 2);
            wall_good_rate = Math.Round((double)ra.Next(10, 100), 2);
            slope_safe_rate = Math.Round((double)ra.Next(10, 100), 2);
            concil_house_validate = Math.Round((double)ra.Next(10, 100), 2);
            road_link_degree = Math.Round((double)ra.Next(10, 100), 2);
            road_good_degree = Math.Round((double)ra.Next(10, 100), 2);
            traffic_validate = Math.Round((double)ra.Next(10, 100), 2);
            water_capcity_degree = Math.Round((double)ra.Next(10, 100), 2);
            water_pipe_net_good_degree = Math.Round((double)ra.Next(10, 100), 2);
            one_hou_one_water_meter_rate = Math.Round((double)ra.Next(10, 100), 2);
            water_supply_validate = Math.Round((double)ra.Next(10, 100), 2);
            elec_capcity_degree = Math.Round((double)ra.Next(10, 100), 2);
            elec_wire_safe_degree = Math.Round((double)ra.Next(10, 100), 2);
            one_hou_one_elec_meter_rate = Math.Round((double)ra.Next(10, 100), 2);
            elec_supply_validate = Math.Round((double)ra.Next(10, 100), 2);
            road_light_suff_degree = Math.Round((double)ra.Next(10, 100), 2);
            passway_light_suff_degree = Math.Round((double)ra.Next(10, 100), 2);
            light_validate = Math.Round((double)ra.Next(10, 100), 2);
            outdoors_ff_good_rate = Math.Round((double)ra.Next(10, 100), 2);
            indoors_ff_good_rate = Math.Round((double)ra.Next(10, 100), 2);
            ff_way_good_rate = Math.Round((double)ra.Next(10, 100), 2);
            ff_validate = Math.Round((double)ra.Next(10, 100), 2);
            basic_facility_validate = Math.Round((double)ra.Next(10, 100), 2);
            refuse_collect_rate = Math.Round((double)ra.Next(10, 100), 2);
            toilet_cover_degree = Math.Round((double)ra.Next(10, 100), 2);
            sanitation_validate = Math.Round((double)ra.Next(10, 100), 2);
            sewage_collect_rate = Math.Round((double)ra.Next(10, 100), 2);
            drain_safe_degree = Math.Round((double)ra.Next(10, 100), 2);
            drain_validate = Math.Round((double)ra.Next(10, 100), 2);
            green_validate = Math.Round((double)ra.Next(10, 100), 2);
            environment_validate = Math.Round((double)ra.Next(10, 100), 2);
            service_gfs_good_rate = Math.Round((double)ra.Next(10, 100), 2);
            kindergarten_good_rate = Math.Round((double)ra.Next(10, 100), 2);
            medical_good_rate = Math.Round((double)ra.Next(10, 100), 2);
            parking_good_rate = Math.Round((double)ra.Next(10, 100), 2);
            CVS_good_rate = Math.Round((double)ra.Next(10, 100), 2);
            vegetable_market_good_rate = Math.Round((double)ra.Next(10, 100), 2);
            commerce_validate = Math.Round((double)ra.Next(10, 100), 2);
            cul_fitness_facility_good_rate = Math.Round((double)ra.Next(10, 100), 2);
            older_facility_good_rate = Math.Round((double)ra.Next(10, 100), 2);
            public_service_good_rate = Math.Round((double)ra.Next(10, 100), 2);
            shop_front_use_rate = Math.Round((double)ra.Next(10, 100), 2);
            shop_front_rent_level = Math.Round((double)ra.Next(10, 100), 2);
            shop_validate = Math.Round((double)ra.Next(10, 100), 2);
            community_validate = Math.Round((double)ra.Next(10, 100), 2);
        }
        public double getStructure_safe_good_rate()
        {
            return structure_safe_good_rate;
        }
        public double getRoof_good_rate()
        {
            return roof_good_rate;
        }
        public double getWall_good_rate()
        {
            return wall_good_rate;
        }
        public double getSlope_safe_rate()
        {
            return slope_safe_rate;
        }
        public double getConcil_house_validate()
        {
            return concil_house_validate;
        }
        public double getRoad_link_degree()
        {
            return road_link_degree;
        }
        public double getRoad_good_degree()
        {
            return road_good_degree;
        }
        public double getTraffic_validate()
        {
            return traffic_validate;
        }
        public double getWater_capcity_degree()
        {
            return water_capcity_degree;
        }
        public double getWater_pipe_net_good_degree()
        {
            return water_pipe_net_good_degree;
        }
        public double getOne_hou_one_water_meter_rate()
        {
            return one_hou_one_water_meter_rate;
        }
        public double getWater_supply_validate()
        {
            return water_supply_validate;
        }
        public double getElec_capcity_degree()
        {
            return elec_capcity_degree;
        }
        public double getElec_wire_safe_degree()
        {
            return elec_wire_safe_degree;
        }
        public double getOne_hou_one_elec_meter_rate()
        {
            return one_hou_one_elec_meter_rate;
        }
        public double getElec_supply_validate()
        {
            return elec_supply_validate;
        }
        public double getRoad_light_suff_degree()
        {
            return road_light_suff_degree;
        }
        public double getPassway_light_suff_degree()
        {
            return passway_light_suff_degree;
        }
        public double getLight_validate()
        {
            return light_validate;
        }
        public double getOutdoors_ff_good_rate()
        {
            return outdoors_ff_good_rate;
        }
        public double getIndoors_ff_good_rate()
        {
            return indoors_ff_good_rate;
        }
        public double getFf_way_good_rate()
        {
            return ff_way_good_rate;
        }
        public double getFf_validate()
        {
            return ff_validate;
        }
        public double getBasic_facility_validate()
        {
            return basic_facility_validate;
        }
        public double getRefuse_collect_rate()
        {
            return refuse_collect_rate;
        }
        public double getToilet_cover_degree()
        {
            return toilet_cover_degree;
        }
        public double getSanitation_validate()
        {
            return sanitation_validate;
        }
        public double getSewage_collect_rate()
        {
            return sewage_collect_rate;
        }
        public double getDrain_safe_degree()
        {
            return drain_safe_degree;
        }
        public double getDrain_validate()
        {
            return drain_validate;
        }
        public double getGreen_validate()
        {
            return green_validate;
        }
        public double getEnvironment_validate()
        {
            return environment_validate;
        }
        public double getService_gfs_good_rate()
        {
            return service_gfs_good_rate;
        }
        public double getKindergarten_good_rate()
        {
            return kindergarten_good_rate;
        }
        public double getMedical_good_rate()
        {
            return medical_good_rate;
        }
        public double getParking_good_rate()
        {
            return parking_good_rate;
        }
        public double getCVS_good_rate()
        {
            return CVS_good_rate;
        }
        public double getVegetable_market_good_rate()
        {
            return vegetable_market_good_rate;
        }
        public double getCommerce_validate()
        {
            return commerce_validate;
        }
        public double getCul_fitness_facility_good_rate()
        {
            return cul_fitness_facility_good_rate;
        }
        public double getOlder_facility_good_rate()
        {
            return older_facility_good_rate;
        }
        public double getPublic_service_good_rate()
        {
            return public_service_good_rate;
        }
        public double getShop_front_use_rate()
        {
            return shop_front_use_rate;
        }
        public double getShop_front_rent_level()
        {
            return shop_front_rent_level;
        }
        public double getShop_validate()
        {
            return shop_validate;
        }
        public double getCommunity_validate()
        {
            return community_validate;
        }
        //计算结构安全完好率
        private void calculateStructure_safe_good_rate(String community_id, DateTime statistics_date)
        {

            DAL.TTGWeb.community_concil_house dcch = new community_concil_house();
            Model.TTGWeb.community_concil_house mcch = dcch.GetModel(community_id, statistics_date);
            if (mcch.community_council_buil_num != 0)
            {
                DAL.TTGWeb.community_council_building_problem dccbp = new community_council_building_problem();
                Model.TTGWeb.community_council_building_problem mccbp = dccbp.GetModel(community_id, "本底", statistics_date);
                structure_safe_good_rate = (1 - (double)(mccbp.community_slight_deform_split_num + mccbp.community_house_foun_setm_num + mccbp.community_is_decrepit_house_num) / (double)mcch.community_council_buil_num) * 100;
            }
            else
            {
                structure_safe_good_rate = -1;
            }


        }
        //计算屋顶完好率
        private void calculateRoof_good_rate(String community_id, DateTime statistics_date)
        {
            DAL.TTGWeb.community_concil_house dcch = new community_concil_house();
            Model.TTGWeb.community_concil_house mcch = dcch.GetModel(community_id, statistics_date);
            if (mcch.community_council_buil_num != 0)
            {
                DAL.TTGWeb.community_council_building_problem dccbp = new community_council_building_problem();
                Model.TTGWeb.community_council_building_problem mccbp = dccbp.GetModel(community_id, "本底", statistics_date);
                roof_good_rate = (1 - (double)(mccbp.community_roof_seepage_house_num) / (double)mcch.community_council_buil_num) * 100;
            }
            else
            {
                roof_good_rate = -1;
            }
        }
        //计算墙壁完好率
        private void calculateWall_good_rate(String community_id, DateTime statistics_date)
        {
            DAL.TTGWeb.community_concil_house dcch = new community_concil_house();
            Model.TTGWeb.community_concil_house mcch = dcch.GetModel(community_id, statistics_date);
            if (mcch.community_council_buil_num != 0)
            {
                DAL.TTGWeb.community_council_building_problem dccbp = new community_council_building_problem();
                Model.TTGWeb.community_council_building_problem mccbp = dccbp.GetModel(community_id, "本底", statistics_date);
                wall_good_rate = (1 - (double)(mccbp.community_exw_ct_shedding_house_num) / (double)mcch.community_council_buil_num) * 100;
            }
            else
            {
                wall_good_rate = -1;
            }
        }
        //计算斜坡安全率
        private void calculateSlope_safe_rate(String community_id, DateTime statistics_date)
        {
            DAL.TTGWeb.community_concil_house dcch = new community_concil_house();
            Model.TTGWeb.community_concil_house mcch = dcch.GetModel(community_id, statistics_date);
            if (mcch.community_council_buil_num != 0)
            {
                DAL.TTGWeb.community_council_building_problem dccbp = new community_council_building_problem();
                Model.TTGWeb.community_council_building_problem mccbp = dccbp.GetModel(community_id, "本底", statistics_date);
                slope_safe_rate = (1 - (double)(mccbp.community_slope_not_govern_house_num) / (double)mcch.community_council_buil_num) * 100;
            }
            else
            {
                slope_safe_rate = -1;
            }
        }
        //计算统建房有效率
        private void calculateConcil_house_validate(String community_id, DateTime statistics_date)
        {
            DAL.TTGWeb.community_concil_house dcch = new community_concil_house();
            Model.TTGWeb.community_concil_house mcch = dcch.GetModel(community_id, statistics_date);
            if (mcch.community_council_buil_num != 0)
            {
                concil_house_validate = (structure_safe_good_rate + roof_good_rate + wall_good_rate + slope_safe_rate) / 4;
            }
            else
            {
                concil_house_validate = -1;
            }
        }
        //给的数据表中没有道路总条数，在这里用道路的总长度代替
        //private void calculateRoad_link_degree(String community_id, DateTime statistics_date)
        //{
        //    community_road dcr = new community_road();
        //    Model.TTGWeb.community_road mcr = dcr.GetModel(community_id, statistics_date);
        //    community_road_problem dcrp = new community_road_problem();
        //    Model.TTGWeb.community_road_problem mcrp = dcrp.GetModel(community_id, "本底", statistics_date);
        //    road_link_degree = (1 - Double.Parse(mcrp.community_sarea_lack_lroad) / (double)mcr.community_road_length) * 100;
        //}
        //计算道路完好指数
        //private void calculateRoad_good_degree(String community_id, DateTime statistics_date)
        //{
        //    community_road dcr = new community_road();
        //    Model.TTGWeb.community_road mcr = dcr.GetModel(community_id, statistics_date);
        //    community_road_problem dcrp = new community_road_problem();
        //    Model.TTGWeb.community_road_problem mcrp = dcrp.GetModel(community_id, "本底", statistics_date);
        //    road_good_degree = (1 - Double.Parse(mcrp.community_to_city_pasway_pavement_damage) / (double)mcr.community_road_area) * 100;
        //}
        //计算交通有效率
        private void calculateTraffic_validate(String community_id, DateTime statistics_date)
        {
            traffic_validate = (road_link_degree + road_good_degree) / 2;
        }
        //计算水容量指数？？？
        private void calculateWater_capcity_degree(String community_id, DateTime statistics_date)
        {
            community_population dcp = new community_population();
            Model.TTGWeb.community_population mcp = dcp.GetModel(community_id, statistics_date);
            community_water_supply_problem dcwsp = new community_water_supply_problem();
            Model.TTGWeb.community_water_supply_problem mcwsp = dcwsp.GetModel(community_id, "本底", statistics_date);
            water_capcity_degree = (1 - (double)(mcwsp.community_insuf_ws_house_num + mcwsp.community_insuf_wp_house_num) / ((double)mcp.community_perm_pop / 3)) * 100;
        }
        //计算水管损坏率
        private void calculateWater_pipe_net_good_degree(String community_id, DateTime statistics_date)
        {
            community_water_supply dcws = new community_water_supply();
            Model.TTGWeb.community_water_supply mcws = dcws.GetModel(community_id, statistics_date);
            community_water_supply_problem dcwsp = new community_water_supply_problem();
            Model.TTGWeb.community_water_supply_problem mcwsp = dcwsp.GetModel(community_id, "本底", statistics_date);
            water_pipe_net_good_degree = (1 - (double)(mcwsp.community_aging_corrosion_pipe_length) / (double)mcws.community_water_supply_pipe_length) * 100;
        }
        //计算一户一表率
        private void calculateOne_hou_one_water_meter_rate(String community_id, DateTime statistics_date)
        {
            community_population dcp = new community_population();
            Model.TTGWeb.community_population mcp = dcp.GetModel(community_id, statistics_date);
            community_water_supply_problem dcwsp = new community_water_supply_problem();
            Model.TTGWeb.community_water_supply_problem mcwsp = dcwsp.GetModel(community_id, "本底", statistics_date);
            one_hou_one_water_meter_rate = (1 - (double)(mcwsp.community_not_imple_ohot_house_num) / ((double)mcp.community_perm_pop / 3)) * 100;
        }
        //计算供水有效率
        private void calculateWater_supply_validate(String community_id, DateTime statistics_date)
        {
            water_supply_validate = (one_hou_one_water_meter_rate + water_capcity_degree + water_pipe_net_good_degree) / 3;
        }
        //阈值暂设为100
        private void calculateElec_capcity_degree(String community_id, DateTime statistics_date)
        {
            community_population dcp = new community_population();
            Model.TTGWeb.community_population mcp = dcp.GetModel(community_id, statistics_date);
            community_elec_supply dces = new community_elec_supply();
            Model.TTGWeb.community_elec_supply mces = dces.GetModel(community_id, statistics_date);
            //community_elec_supply_problem dcesp = new community_elec_supply_problem();
            //Model.TTGWeb.community_elec_supply_problem mcesp = dcesp.GetModel(community_id, "本底", statistics_date);
            double temp = (double)mces.community_elec_supply_consumption / ((double)mcp.community_perm_pop / 3);
            if (temp >= 2.5)
            {
                elec_capcity_degree = 100;
            }
            else
            {
                elec_capcity_degree = temp / 2.5 * 100;
            }
        }
        private void calculateElec_wire_safe_degree(String community_id, DateTime statistics_date)
        {
            //community_population dcp = new community_population();
            //Model.TTGWeb.community_population mcp = dcp.GetModel(community_id, statistics_date);
            community_elec_supply dces = new community_elec_supply();
            Model.TTGWeb.community_elec_supply mces = dces.GetModel(community_id, statistics_date);
            community_elec_supply_problem dcesp = new community_elec_supply_problem();
            Model.TTGWeb.community_elec_supply_problem mcesp = dcesp.GetModel(community_id, "本底", statistics_date);
            elec_wire_safe_degree = (1 - (double)(mcesp.community_senescent_elec_wireways_length) / (double)mces.community_elec_supply_wireways_length) * 100;

        }
        private void calculateOne_hou_one_elec_meter_rate(String community_id, DateTime statistics_date)
        {
            community_population dcp = new community_population();
            Model.TTGWeb.community_population mcp = dcp.GetModel(community_id, statistics_date);
            community_elec_supply_problem dcesp = new community_elec_supply_problem();
            Model.TTGWeb.community_elec_supply_problem mcesp = dcesp.GetModel(community_id, "本底", statistics_date);
            one_hou_one_elec_meter_rate = (1 - (double)(mcesp.community_no_one_hou_one_meter_hou_num) / ((double)mcp.community_perm_pop / 3)) * 100;

        }
        private void calculateElec_supply_validate(String community_id, DateTime statistics_date)
        {
            elec_supply_validate = (elec_capcity_degree + elec_wire_safe_degree + one_hou_one_elec_meter_rate) / 3;
        }
        private void calculateRoad_light_suff_degree(String community_id, DateTime statistics_date)
        {
            community_road dcr = new community_road();
            Model.TTGWeb.community_road mcr = dcr.GetModel(community_id, statistics_date);
            community_lighting_problem dclp = new community_lighting_problem();
            Model.TTGWeb.community_lighting_problem mclp = dclp.GetModel(community_id, "本底", statistics_date);
            road_light_suff_degree = (1 - (double)(mclp.community_road_lack_slamp_insuf_light_length + mclp.community_road_wout_slamp_length) / (double)mcr.community_road_length) * 100;
        }
        private void calculatePassway_light_suff_degree(String community_id, DateTime statistics_date)
        {
            community_population dcp = new community_population();
            Model.TTGWeb.community_population mcp = dcp.GetModel(community_id, statistics_date);
            community_lighting_problem dclp = new community_lighting_problem();
            Model.TTGWeb.community_lighting_problem mclp = dclp.GetModel(community_id, "本底", statistics_date);
            one_hou_one_elec_meter_rate = (1 - (double)(mclp.community_corridor_light_damage_house_num) / ((double)mcp.community_perm_pop / 3)) * 100;

        }
        private void calculateLight_validate(String community_id, DateTime statistics_date)
        {
            light_validate = (passway_light_suff_degree + road_light_suff_degree) / 2;
        }
        private void calculateOutdoors_ff_good_rate(String community_id, DateTime statistics_date)
        {
            community_road dcr = new community_road();
            Model.TTGWeb.community_road mcr = dcr.GetModel(community_id, statistics_date);
            community_ff_problem dcfp = new community_ff_problem();
            Model.TTGWeb.community_ff_problem mcfp = dcfp.GetModel(community_id, "本底", statistics_date);
            outdoors_ff_good_rate = (1 - (double)(mcfp.community_road_lack_outdoor_fh_length) / (double)mcr.community_road_length) * 100;

        }
        private void calculateIndoors_ff_good_rate(String community_id, DateTime statistics_date)
        {
            community_building dcb = new community_building();
            Model.TTGWeb.community_building mcb = dcb.GetModel(community_id, statistics_date);
            community_ff_problem dcfp = new community_ff_problem();
            Model.TTGWeb.community_ff_problem mcfp = dcfp.GetModel(community_id, "本底", statistics_date);
            outdoors_ff_good_rate = (1 - (double)(mcfp.community_lack_indoor_fh_building_num) / (double)mcb.community_building_total_num) * 100;
        }
        //没有存储与消防通道有关的信息，因此用影响的建筑物幢数表示。
        private void calculateFf_way_good_rate(String community_id, DateTime statistics_date)
        {
            community_building dcb = new community_building();
            Model.TTGWeb.community_building mcb = dcb.GetModel(community_id, statistics_date);
            community_ff_problem dcfp = new community_ff_problem();
            Model.TTGWeb.community_ff_problem mcfp = dcfp.GetModel(community_id, "本底", statistics_date);
            ff_way_good_rate = (1 - (double)(mcfp.community_mer_wout_12_12_by_building_num + mcfp.community_fr_less_4_4_building + mcfp.community_lack_fe_building_num) / (double)mcb.community_building_total_num) * 100;
        }
        private void calculateFf_validate(String community_id, DateTime statistics_date)
        {
            ff_validate = (ff_way_good_rate + indoors_ff_good_rate + outdoors_ff_good_rate) / 3;
        }
        private void calculateBasic_facility_validate(String community_id, DateTime statistics_date)
        {
            basic_facility_validate = (traffic_validate + water_supply_validate + elec_supply_validate + light_validate + ff_validate) / 5;
        }
        //private void calculateRefuse_collect_rate(String community_id, DateTime statistics_date)
        //{
        //    community_environmental_hygiene dceh = new community_environmental_hygiene();
        //    Model.TTGWeb.community_environmental_hygiene mech = dceh.GetModel(community_id, statistics_date);
        //    community_sanitation_problem dcsp = new community_sanitation_problem();
        //    Model.TTGWeb.community_sanitation_problem mcsp = dcsp.GetModel(community_id, "本底", statistics_date);
        //    refuse_collect_rate = (1 - (double)(mcsp.community_bsa_etc_hc_garbage_stack_amount + mcsp.communiyt_along_rs_garbage_stack_amount) / (double)mech.rubbish_produce_amount) * 100;
        //}
        //此指标暂时无法计算
        private void calculateToilet_cover_degree(String community_id, DateTime statistics_date)
        {
            toilet_cover_degree = -1;
        }
        private void calculateSanitation_validate(String community_id, DateTime statistics_date)
        {
            sanitation_validate = refuse_collect_rate;
        }
        private void calculateSewage_collect_rate(String community_id, DateTime statistics_date)
        {
            community_building dcb = new community_building();
            Model.TTGWeb.community_building mcb = dcb.GetModel(community_id, statistics_date);
            community_water_drain_problem dcwdp = new community_water_drain_problem();
            Model.TTGWeb.community_water_drain_problem mcwdp = dcwdp.GetModel(community_id, "本底", statistics_date);
            sewage_collect_rate = (1 - (double)(mcwdp.community_not_access_uspn_res_num) / (double)mcb.community_building_total_num) * 100;

        }
        //缺少数据元，此指标计算有误。
        //private void calculateDrain_safe_degree(String community_id, DateTime statistics_date)
        //{
        //    community_water_drain dcwd = new community_water_drain();
        //    Model.TTGWeb.community_water_drain mcwd = dcwd.GetModel(community_id, statistics_date);
        //    community_water_drain_problem dcwdp = new community_water_drain_problem();
        //    Model.TTGWeb.community_water_drain_problem mcwdp = dcwdp.GetModel(community_id, "本底", statistics_date);
        //    drain_safe_degree = (1 - (double)(mcwdp.community_pipe_aging_corrosion_num + Double.Parse(mcwdp.community_pipe_damage_num + mcwdp.community_gutter_damage)) / (double)(mcwd.community_water_drain_pipe_length + mcwd.community_water_drain_canal_length));
        //}
        private void calculateDrain_validate(String community_id, DateTime statistics_date)
        {
            drain_validate = (sewage_collect_rate + drain_safe_degree) / 2;
        }
        //绿地率规划目标暂时设为0.5
        private void calculateGreen_validate(String community_id, DateTime statistics_date)
        {
            community_green_fields dcgf = new community_green_fields();
            Model.TTGWeb.community_green_fields mcgf = dcgf.GetModel(community_id, statistics_date);
            community_land dcl = new community_land();
            Model.TTGWeb.community_land mcl = dcl.GetModel(community_id, statistics_date);
            double temp = (double)mcgf.community_green_fields_area / (double)mcl.community_total_land_area;
            if (temp >= 0.15)
            {
                green_validate = 100;
            }
            else
            {
                green_validate = temp / 0.15 * 100;
            }

        }
        private void calculateEnvironment_validate(String community_id, DateTime statistics_date)
        {
            environment_validate = (sanitation_validate + drain_validate + green_validate) / 3;
        }
        private void calculateService_gfs_good_rate(String community_id, DateTime statistics_date)
        {
            community_service dcs = new community_service();
            Model.TTGWeb.community_service mcs = dcs.GetModel(community_id, statistics_date);
            community_population dcp = new community_population();
            Model.TTGWeb.community_population mcp = dcp.GetModel(community_id, statistics_date);
            double temp = (double)mcs.community_comm_serv_fac_gfa / (double)mcp.community_perm_pop * 1000;
            if (temp >= 59)
            {
                service_gfs_good_rate = 100;
            }
            else
            {
                service_gfs_good_rate = temp / 59 * 100;
            }
        }
        private void calculateKindergarten_good_rate(String community_id, DateTime statistics_date)
        {
            community_education dce = new community_education();
            Model.TTGWeb.community_education mce = dce.GetModel(community_id, statistics_date);
            community_population dcp = new community_population();
            Model.TTGWeb.community_population mcp = dcp.GetModel(community_id, statistics_date);
            double temp = (double)mce.community_kdg_stu_num / (double)mcp.community_perm_pop * 1000;
            if (temp >= 12)
            {
                kindergarten_good_rate = 100;
            }
            else
            {
                kindergarten_good_rate = temp / 12 * 100;
            }
        }

        private void calculateMedical_good_rate(String community_id, DateTime statistics_date)
        {
            community_medical dcm = new community_medical();
            Model.TTGWeb.community_medical mcm = dcm.GetModel(community_id, statistics_date);
            community_population dcp = new community_population();
            Model.TTGWeb.community_population mcp = dcp.GetModel(community_id, statistics_date);
            double temp = (double)(mcm.community_clinic_bed_num + mcm.community_heal_sta_bed_num + mcm.community_hospital_bed_num) / (double)mcp.community_perm_pop * 1000;
            if (temp >= 4.55)
            {
                medical_good_rate = 100;
            }
            else
            {
                medical_good_rate = temp / 4.55 * 100;
            }
        }
        private void calculateParking_good_rate(String community_id, DateTime statistics_date)
        {
            community_parking_lot dcpl = new community_parking_lot();
            Model.TTGWeb.community_parking_lot mcpl = dcpl.GetModel(community_id, statistics_date);
            community_population dcp = new community_population();
            Model.TTGWeb.community_population mcp = dcp.GetModel(community_id, statistics_date);
            double temp = (double)mcpl.community_parking_space_num / ((double)mcp.community_perm_pop / 3);
            if (temp >= 0.1)
            {
                parking_good_rate = 100;
            }
            else
            {
                parking_good_rate = temp / 0.1 * 100;
            }
        }
        private void calculateCVS_good_rate(String community_id, DateTime statistics_date)
        {
            community_commerce dcc = new community_commerce();
            Model.TTGWeb.community_commerce mcc = dcc.GetModel(community_id, statistics_date);
            community_population dcp = new community_population();
            Model.TTGWeb.community_population mcp = dcp.GetModel(community_id, statistics_date);
            double temp = (double)(mcc.community_CVS_num + mcc.community_small_supermarket_num) / ((double)mcp.community_perm_pop / 3);
            if (temp >= 100)
            {
                CVS_good_rate = 100;
            }
            else
            {
                CVS_good_rate = temp / 100 * 100;
            }
        }
        private void calculateVegetable_market_good_rate(String community_id, DateTime statistics_date)
        {
            community_commerce dcc = new community_commerce();
            Model.TTGWeb.community_commerce mcc = dcc.GetModel(community_id, statistics_date);
            community_population dcp = new community_population();
            Model.TTGWeb.community_population mcp = dcp.GetModel(community_id, statistics_date);
            double temp = (double)(mcc.community_farm_whs_market_gfa + mcc.community_farm_produce_fair_gfa) / (double)mcp.community_perm_pop * 1000;
            if (temp >= 50)
            {
                vegetable_market_good_rate = 100;
            }
            else
            {
                vegetable_market_good_rate = temp / 50 * 100;
            }
        }
        private void calculateCommerce_validate(String community_id, DateTime statistics_date)
        {
            commerce_validate = (vegetable_market_good_rate + CVS_good_rate) / 2;
        }
        private void calculateCul_fitness_facility_good_rate(String community_id, DateTime statistics_date)
        {
            community_culture_sports dccs = new community_culture_sports();
            Model.TTGWeb.community_culture_sports mccs = dccs.GetModel(community_id, statistics_date);
            community_population dcp = new community_population();
            Model.TTGWeb.community_population mcp = dcp.GetModel(community_id, statistics_date);
            double temp = (double)(mccs.community_culture_sports_gfa) / (double)mcp.community_perm_pop * 1000;
            if (temp >= 45)
            {
                cul_fitness_facility_good_rate = 100;
            }
            else
            {
                cul_fitness_facility_good_rate = temp / 45 * 100;
            }

        }
        //未告知养老设施是什么，无法计算
        private void calculateOlder_facility_good_rate(String community_id, DateTime statistics_date)
        {
            older_facility_good_rate = -1;
        }
        private void calculatePublic_service_good_rate(String community_id, DateTime statistics_date)
        {
            public_service_good_rate = (service_gfs_good_rate + kindergarten_good_rate + medical_good_rate + parking_good_rate + commerce_validate + cul_fitness_facility_good_rate + older_facility_good_rate) / 7;
        }
        private void calculateShop_front_use_rate(String community_id, DateTime statistics_date)
        {
            community_shop_front dcsf = new community_shop_front();
            Model.TTGWeb.community_shop_front mcsf = dcsf.GetModel(community_id, statistics_date);
            if (mcsf.community_shop_front_amount < 50)
            {
                shop_front_use_rate = -1;
            }
            else
            {
                shop_front_use_rate = (double)mcsf.community_immigrant_run_shop_front_num / (double)mcsf.community_shop_front_amount * 100;
            }
        }
        //暂设租金平均值为1000
        private void calculateShop_front_rent_level(String community_id, DateTime statistics_date)
        {
            community_shop_front dcsf = new community_shop_front();
            Model.TTGWeb.community_shop_front mcsf = dcsf.GetModel(community_id, statistics_date);
            if (mcsf.community_shop_front_amount < 50)
            {
                shop_front_rent_level = -1;
            }
            else
            {
                if (mcsf.community_average_rent_of_shop_front >= 1000)
                {
                    shop_front_rent_level = 100;
                }
                else
                {
                    shop_front_rent_level = (double)mcsf.community_average_rent_of_shop_front / 1000 * 100;
                }
            }
        }
        private void calculateShop_validate(String community_id, DateTime statistics_date)
        {
            community_shop_front dcsf = new community_shop_front();
            Model.TTGWeb.community_shop_front mcsf = dcsf.GetModel(community_id, statistics_date);
            if (mcsf.community_shop_front_amount < 50)
            {
                shop_validate = -1;
            }
            else
            {
                shop_validate = (shop_front_rent_level + shop_front_use_rate) / 2;
            }
        }
        private void calculateCommunity_validate(String community_id, DateTime statistics_date)
        {
            double temp1, temp2, temp3, temp4, temp5;
            if (concil_house_validate == -1)
            {
                temp1 = 0;
            }
            else
            {
                temp1 = concil_house_validate;
            }
            if (basic_facility_validate == -1)
            {
                temp2 = 0;
            }
            else
            {
                temp2 = basic_facility_validate;
            }
            if (sanitation_validate == -1)
            {
                temp3 = 0;
            }
            else
            {
                temp3 = sanitation_validate;
            }
            if (public_service_good_rate == -1)
            {
                temp4 = 0;
            }
            else
            {
                temp4 = public_service_good_rate;
            }
            if (shop_validate == -1)
            {
                temp5 = 0;
            }
            else
            {
                temp5 = shop_validate;
            }
            community_validate = (temp1 + temp2 + temp3 + temp4 + temp5) / 5;
        }
    }

}
