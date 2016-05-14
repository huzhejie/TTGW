using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TTG.DAL.GET
{
    public class get_base_facilities
    {
        #region 字段
        private get_tools gt = new get_tools();
        private string province_name, county_name, community_name, community_id;
        private DateTime last_mosdify;
        private int broken_road_num_2013, broken_road_num_now,      //断头路条数
            lack_link_num_2013, lack_link_num_now;                   //小区内部分区域连接路缺乏
        private double not_hard_area_2013, not_hard_area_now,            //未硬化面积
            road_broken_2013, road_broken_now,               //机动车道路面损坏面积
            sidewalk_broken_2013, sidewalk_broken_now;      //人行道路面损坏面积
        private int lack_sidewalk_2013, lack_sidewalk_now,      //缺乏人行道条数
            inadequate_water_2013, inadequate_water_now,         //供水量不足涉及住宅户数
            water_pressure_2013, water_pressure_now,             //供水压力不足涉及住宅户数
            not_one_one_2013, not_one_one_now,                   //供水条件未落实一户一表设计住宅户数
            elec_inade_2013, elec_inade_now,                     //供电量不足涉及住宅户数
            not_e_one_one_2013, not_e_one_one_now,               //供电条件未落实“一户一表”涉及住宅户数
            light_damage_2013,light_damage_now,                     //小区楼道照明损坏涉及户数
            in_ff_less_2013, in_ff_less_now;                         //室内消火栓不足涉及建筑数量
        private double pipe_damage_2013, pipe_damage_now,        //小区供水管道损坏长度
            link_damage_2013, link_damage_now,                   //小区老化和损坏供电线路长度
            no_light_2013, no_light_now,                         //无路灯路段数量
            less_light_2013, less_light_now,                     //路灯数量少、照度不足的路段数量
            out_ff_less_2013, out_ff_less_now,                   //室外消火栓数量不足涉及路段
            exits_not_com_2013, exits_not_com_now;              //消防通道不达标长度
        private int add_link_num_plan, add_link_num_com,        //新增连接路数量
            add_water_press_plan, add_water_press_com,           //新增供水增压设施
            add_meter_plan, add_meter_com,                       //水表安装户数
            repair_trans_plan, repair_trans_com,                 //变压器安装改造
            install_trans_plan, install_trans_com,               //电表安装
            add_in_light_plan, add_in_light_com,                     //新增楼栋照明设施数量
            repair_in_light_plan, repair_in_light_com,               //修复楼栋照明设施数量
            add_out_ff_plan, add_out_ff_com,                         //新增室外消防设施数量
            add_in_ff_plan, add_in_ff_com;                       //新增室内消防设施数量
        private double add_road_area_plan, add_road_area_com,        //新建机动车道面积
            harden_road_area_plan, harden_road_area_com,             //硬化机动车道面积
            repair_road_area_plan, repair_road_area_com,             //维修改造机动车道面积
            change_sidewalk_plan, change_sidewalk_com,               //人行道地砖改造面积
            add_sidewalk_plan, add_sidewalk_com,                     //新增人行道
            add_water_cap_plan, add_water_cap_com,                   //新增供水容量
            add_pipe_length_plan, add_pipe_length_com,               //新建供水管长度
            repair_pipe_length_plan, repair_pipe_length_com,         //维修改造供水管长度
            add_trans_plan, add_trans_com,                           //新增变压器后增容
            change_trans_plan, change_trans_com,                     //更换变压器后增容
            add_line_plan, add_line_com,                             //新建配电线路
            repair_line_plan, repair_line_com,                       //维修改造配电线路
            add_out_light_plan, add_out_light_com,                   //新增室外照明覆盖路段
            repair_out_light_plan, repair_out_light_com,             //修复室外照明覆盖路段
            repair_exits_plan, repair_exits_com;                     //消防通道改造
        private double road_access_rate_2013, road_access_rate_now,     //道路通达程度
            road_clear_rate_2013, road_clear_rate_now,               //道路通畅程度
            water_supply_guar_rate_2013, water_supply_guar_rate_now,     //供水能力保障程度
            water_pipe_line_com_rate_2013, water_pipe_line_com_rate_now, //供水管网完善程度
            water_double_one_rate_2013, water_double_one_rate_now,           //供水一户一表实现率
            elec_capa_guar_rate_2013, elec_capa_guar_rate_now,           //供电容量保障率
            elec_line_safe_rate_2013, elec_line_safe_rate_now,           //供电线路安全程度
            elec_double_one_rate_2013, elec_double_one_rate_now,         //供电一户一表实现率
            out_light_com_rate_2013, out_light_com_rate_now,             //室外公共照明达标率
            in_light_com_rate_2013, in_light_com_rate_now,               //室内公共照明达标率
            out_ff_com_rate_2013, out_ff_com_rate_now,                   //室外消防设施达标率
            in_ff_com_rate_2013, in_ff_com_rate_now,                     //室内消防设施达标率
            ff_exits_com_rate_2013, ff_exits_com_rate_now;              //消防通道达标率

        #endregion

        #region 属性
        public string Community_id
        {
            get { return community_id; }
            set { community_id = value; }
        }

        public DateTime Last_mosdify
        {
            get { return last_mosdify; }
            set { last_mosdify = value; }
        }

        public int Broken_road_num_2013
        {
            get { return broken_road_num_2013; }
            set { broken_road_num_2013 = value; }
        }

        public int Broken_road_num_now
        {
            get { return broken_road_num_now; }
            set { broken_road_num_now = value; }
        }

        public int Lack_link_num_2013
        {
            get { return lack_link_num_2013; }
            set { lack_link_num_2013 = value; }
        }

        public int Lack_link_num_now
        {
            get { return lack_link_num_now; }
            set { lack_link_num_now = value; }
        }

        public double Not_hard_area_2013
        {
            get { return not_hard_area_2013; }
            set { not_hard_area_2013 = value; }
        }

        public double Not_hard_area_now
        {
            get { return not_hard_area_now; }
            set { not_hard_area_now = value; }
        }

        public double Road_broken_2013
        {
            get { return road_broken_2013; }
            set { road_broken_2013 = value; }
        }

        public double Road_broken_now
        {
            get { return road_broken_now; }
            set { road_broken_now = value; }
        }

        public double Sidewalk_broken_2013
        {
            get { return sidewalk_broken_2013; }
            set { sidewalk_broken_2013 = value; }
        }

        public double Sidewalk_broken_now
        {
            get { return sidewalk_broken_now; }
            set { sidewalk_broken_now = value; }
        }

        public int Lack_sidewalk_2013
        {
            get { return lack_sidewalk_2013; }
            set { lack_sidewalk_2013 = value; }
        }

        public int Lack_sidewalk_now
        {
            get { return lack_sidewalk_now; }
            set { lack_sidewalk_now = value; }
        }

        public int Inadequate_water_2013
        {
            get { return inadequate_water_2013; }
            set { inadequate_water_2013 = value; }
        }

        public int Inadequate_water_now
        {
            get { return inadequate_water_now; }
            set { inadequate_water_now = value; }
        }

        public int Water_pressure_2013
        {
            get { return water_pressure_2013; }
            set { water_pressure_2013 = value; }
        }

        public int Water_pressure_now
        {
            get { return water_pressure_now; }
            set { water_pressure_now = value; }
        }

        public int Not_one_one_2013
        {
            get { return not_one_one_2013; }
            set { not_one_one_2013 = value; }
        }

        public int Not_one_one_now
        {
            get { return not_one_one_now; }
            set { not_one_one_now = value; }
        }

        public int Elec_inade_2013
        {
            get { return elec_inade_2013; }
            set { elec_inade_2013 = value; }
        }

        public int Elec_inade_now
        {
            get { return elec_inade_now; }
            set { elec_inade_now = value; }
        }

        public int Not_e_one_one_2013
        {
            get { return not_e_one_one_2013; }
            set { not_e_one_one_2013 = value; }
        }

        public int Not_e_one_one_now
        {
            get { return not_e_one_one_now; }
            set { not_e_one_one_now = value; }
        }

        public int Light_damage_2013
        {
            get { return light_damage_2013; }
            set { light_damage_2013 = value; }
        }

        public int Light_damage_now
        {
            get { return light_damage_now; }
            set { light_damage_now = value; }
        }

        public int In_ff_less_2013
        {
            get { return in_ff_less_2013; }
            set { in_ff_less_2013 = value; }
        }

        public int In_ff_less_now
        {
            get { return in_ff_less_now; }
            set { in_ff_less_now = value; }
        }

        public double Pipe_damage_2013
        {
            get { return pipe_damage_2013; }
            set { pipe_damage_2013 = value; }
        }

        public double Pipe_damage_now
        {
            get { return pipe_damage_now; }
            set { pipe_damage_now = value; }
        }

        public double Link_damage_2013
        {
            get { return link_damage_2013; }
            set { link_damage_2013 = value; }
        }

        public double Link_damage_now
        {
            get { return link_damage_now; }
            set { link_damage_now = value; }
        }

        public double No_light_2013
        {
            get { return no_light_2013; }
            set { no_light_2013 = value; }
        }

        public double No_light_now
        {
            get { return no_light_now; }
            set { no_light_now = value; }
        }

        public double Less_light_2013
        {
            get { return less_light_2013; }
            set { less_light_2013 = value; }
        }

        public double Less_light_now
        {
            get { return less_light_now; }
            set { less_light_now = value; }
        }

        public double Out_ff_less_2013
        {
            get { return out_ff_less_2013; }
            set { out_ff_less_2013 = value; }
        }

        public double Out_ff_less_now
        {
            get { return out_ff_less_now; }
            set { out_ff_less_now = value; }
        }

        public double Exits_not_com_2013
        {
            get { return exits_not_com_2013; }
            set { exits_not_com_2013 = value; }
        }

        public double Exits_not_com_now
        {
            get { return exits_not_com_now; }
            set { exits_not_com_now = value; }
        }

        public int Add_link_num_plan
        {
            get { return add_link_num_plan; }
            set { add_link_num_plan = value; }
        }

        public int Add_link_num_com
        {
            get { return add_link_num_com; }
            set { add_link_num_com = value; }
        }

        public int Add_water_press_plan
        {
            get { return add_water_press_plan; }
            set { add_water_press_plan = value; }
        }

        public int Add_water_press_com
        {
            get { return add_water_press_com; }
            set { add_water_press_com = value; }
        }

        public int Add_meter_plan
        {
            get { return add_meter_plan; }
            set { add_meter_plan = value; }
        }

        public int Add_meter_com
        {
            get { return add_meter_com; }
            set { add_meter_com = value; }
        }

        public int Repair_trans_plan
        {
            get { return repair_trans_plan; }
            set { repair_trans_plan = value; }
        }

        public int Repair_trans_com
        {
            get { return repair_trans_com; }
            set { repair_trans_com = value; }
        }

        public int Install_trans_plan
        {
            get { return install_trans_plan; }
            set { install_trans_plan = value; }
        }

        public int Install_trans_com
        {
            get { return install_trans_com; }
            set { install_trans_com = value; }
        }

        public int Add_in_light_plan
        {
            get { return add_in_light_plan; }
            set { add_in_light_plan = value; }
        }

        public int Add_in_light_com
        {
            get { return add_in_light_com; }
            set { add_in_light_com = value; }
        }

        public int Repair_in_light_plan
        {
            get { return repair_in_light_plan; }
            set { repair_in_light_plan = value; }
        }

        public int Repair_in_light_com
        {
            get { return repair_in_light_com; }
            set { repair_in_light_com = value; }
        }

        public int Add_out_ff_plan
        {
            get { return add_out_ff_plan; }
            set { add_out_ff_plan = value; }
        }

        public int Add_out_ff_com
        {
            get { return add_out_ff_com; }
            set { add_out_ff_com = value; }
        }

        public int Add_in_ff_plan
        {
            get { return add_in_ff_plan; }
            set { add_in_ff_plan = value; }
        }

        public int Add_in_ff_com
        {
            get { return add_in_ff_com; }
            set { add_in_ff_com = value; }
        }

        public double Add_road_area_plan
        {
            get { return add_road_area_plan; }
            set { add_road_area_plan = value; }
        }

        public double Add_road_area_com
        {
            get { return add_road_area_com; }
            set { add_road_area_com = value; }
        }

        public double Harden_road_area_plan
        {
            get { return harden_road_area_plan; }
            set { harden_road_area_plan = value; }
        }

        public double Harden_road_area_com
        {
            get { return harden_road_area_com; }
            set { harden_road_area_com = value; }
        }

        public double Repair_road_area_plan
        {
            get { return repair_road_area_plan; }
            set { repair_road_area_plan = value; }
        }

        public double Repair_road_area_com
        {
            get { return repair_road_area_com; }
            set { repair_road_area_com = value; }
        }

        public double Change_sidewalk_plan
        {
            get { return change_sidewalk_plan; }
            set { change_sidewalk_plan = value; }
        }

        public double Change_sidewalk_com
        {
            get { return change_sidewalk_com; }
            set { change_sidewalk_com = value; }
        }

        public double Add_sidewalk_plan
        {
            get { return add_sidewalk_plan; }
            set { add_sidewalk_plan = value; }
        }

        public double Add_sidewalk_com
        {
            get { return add_sidewalk_com; }
            set { add_sidewalk_com = value; }
        }

        public double Add_water_cap_plan
        {
            get { return add_water_cap_plan; }
            set { add_water_cap_plan = value; }
        }

        public double Add_water_cap_com
        {
            get { return add_water_cap_com; }
            set { add_water_cap_com = value; }
        }

        public double Add_pipe_length_plan
        {
            get { return add_pipe_length_plan; }
            set { add_pipe_length_plan = value; }
        }

        public double Add_pipe_length_com
        {
            get { return add_pipe_length_com; }
            set { add_pipe_length_com = value; }
        }

        public double Repair_pipe_length_plan
        {
            get { return repair_pipe_length_plan; }
            set { repair_pipe_length_plan = value; }
        }

        public double Repair_pipe_length_com
        {
            get { return repair_pipe_length_com; }
            set { repair_pipe_length_com = value; }
        }

        public double Add_trans_plan
        {
            get { return add_trans_plan; }
            set { add_trans_plan = value; }
        }

        public double Add_trans_com
        {
            get { return add_trans_com; }
            set { add_trans_com = value; }
        }

        public double Change_trans_plan
        {
            get { return change_trans_plan; }
            set { change_trans_plan = value; }
        }

        public double Change_trans_com
        {
            get { return change_trans_com; }
            set { change_trans_com = value; }
        }

        public double Add_line_plan
        {
            get { return add_line_plan; }
            set { add_line_plan = value; }
        }

        public double Add_line_com
        {
            get { return add_line_com; }
            set { add_line_com = value; }
        }

        public double Repair_line_plan
        {
            get { return repair_line_plan; }
            set { repair_line_plan = value; }
        }

        public double Repair_line_com
        {
            get { return repair_line_com; }
            set { repair_line_com = value; }
        }

        public double Add_out_light_plan
        {
            get { return add_out_light_plan; }
            set { add_out_light_plan = value; }
        }

        public double Add_out_light_com
        {
            get { return add_out_light_com; }
            set { add_out_light_com = value; }
        }

        public double Repair_out_light_plan
        {
            get { return repair_out_light_plan; }
            set { repair_out_light_plan = value; }
        }

        public double Repair_out_light_com
        {
            get { return repair_out_light_com; }
            set { repair_out_light_com = value; }
        }

        public double Repair_exits_plan
        {
            get { return repair_exits_plan; }
            set { repair_exits_plan = value; }
        }

        public double Repair_exits_com
        {
            get { return repair_exits_com; }
            set { repair_exits_com = value; }
        }

        public double Road_access_rate_2013
        {
            get { return road_access_rate_2013; }
            set { road_access_rate_2013 = value; }
        }

        public double Road_access_rate_now
        {
            get { return road_access_rate_now; }
            set { road_access_rate_now = value; }
        }

        public double Road_clear_rate_2013
        {
            get { return road_clear_rate_2013; }
            set { road_clear_rate_2013 = value; }
        }

        public double Road_clear_rate_now
        {
            get { return road_clear_rate_now; }
            set { road_clear_rate_now = value; }
        }

        public double Water_supply_guar_rate_2013
        {
            get { return water_supply_guar_rate_2013; }
            set { water_supply_guar_rate_2013 = value; }
        }

        public double Water_supply_guar_rate_now
        {
            get { return water_supply_guar_rate_now; }
            set { water_supply_guar_rate_now = value; }
        }

        public double Water_pipe_line_com_rate_2013
        {
            get { return water_pipe_line_com_rate_2013; }
            set { water_pipe_line_com_rate_2013 = value; }
        }

        public double Water_pipe_line_com_rate_now
        {
            get { return water_pipe_line_com_rate_now; }
            set { water_pipe_line_com_rate_now = value; }
        }

        public double Water_double_one_rate_2013
        {
            get { return water_double_one_rate_2013; }
            set { water_double_one_rate_2013 = value; }
        }

        public double Water_double_one_rate_now
        {
            get { return water_double_one_rate_now; }
            set { water_double_one_rate_now = value; }
        }

        public double Elec_capa_guar_rate_2013
        {
            get { return elec_capa_guar_rate_2013; }
            set { elec_capa_guar_rate_2013 = value; }
        }

        public double Elec_capa_guar_rate_now
        {
            get { return elec_capa_guar_rate_now; }
            set { elec_capa_guar_rate_now = value; }
        }

        public double Elec_line_safe_rate_2013
        {
            get { return elec_line_safe_rate_2013; }
            set { elec_line_safe_rate_2013 = value; }
        }

        public double Elec_line_safe_rate_now
        {
            get { return elec_line_safe_rate_now; }
            set { elec_line_safe_rate_now = value; }
        }

        public double Elec_double_one_rate_2013
        {
            get { return elec_double_one_rate_2013; }
            set { elec_double_one_rate_2013 = value; }
        }

        public double Elec_double_one_rate_now
        {
            get { return elec_double_one_rate_now; }
            set { elec_double_one_rate_now = value; }
        }

        public double Out_light_com_rate_2013
        {
            get { return out_light_com_rate_2013; }
            set { out_light_com_rate_2013 = value; }
        }

        public double Out_light_com_rate_now
        {
            get { return out_light_com_rate_now; }
            set { out_light_com_rate_now = value; }
        }

        public double In_light_com_rate_2013
        {
            get { return in_light_com_rate_2013; }
            set { in_light_com_rate_2013 = value; }
        }

        public double In_light_com_rate_now
        {
            get { return in_light_com_rate_now; }
            set { in_light_com_rate_now = value; }
        }

        public double Out_ff_com_rate_2013
        {
            get { return out_ff_com_rate_2013; }
            set { out_ff_com_rate_2013 = value; }
        }

        public double Out_ff_com_rate_now
        {
            get { return out_ff_com_rate_now; }
            set { out_ff_com_rate_now = value; }
        }

        public double In_ff_com_rate_2013
        {
            get { return in_ff_com_rate_2013; }
            set { in_ff_com_rate_2013 = value; }
        }

        public double In_ff_com_rate_now
        {
            get { return in_ff_com_rate_now; }
            set { in_ff_com_rate_now = value; }
        }

        public double Ff_exits_com_rate_2013
        {
            get { return ff_exits_com_rate_2013; }
            set { ff_exits_com_rate_2013 = value; }
        }

        public double Ff_exits_com_rate_now
        {
            get { return ff_exits_com_rate_now; }
            set { ff_exits_com_rate_now = value; }
        }

        #endregion


        public get_base_facilities(string province, string county, string community)
        {
            province_name = province;
            county_name = county;
            community_name = community;
            query_message_1();
            query_message_2();
            query_message_3();
            query_message_4();
            query_message_5();
            query_message_6();
            query_message_7();
            query_message_8();
            query_message_9();
            query_message_10();
            query_message_11();
            query_message_12();
            query_message_13();
        }

        #region 方法
        /// <summary>
        /// 小区基本信息表—— 小区编号，最后修改时间
        /// </summary>
        private void query_message_1()
        {
            string sql = "select community_id, statistics_date from T_Community_Base where community_province = @province and community_county like @county and community_name = @community order by statistics_date desc";
            SqlParameter[] parameters = {
                                            new SqlParameter("@province", SqlDbType.VarChar, 50){Value = province_name},
                                            new SqlParameter("@county", SqlDbType.VarChar, 50){Value = "%"+county_name+"%"},
                                            new SqlParameter("@community",SqlDbType.VarChar,50){Value = community_name}
                                        };
            DataRow row = gt.get_content(sql, parameters);
            community_id = Convert.ToString(row["community_id"]);
            last_mosdify = Convert.ToDateTime(row["statistics_date"]);
        }
        /// <summary>
        /// 小区道路问题表 —— 断头路（尽端式道路），小区内部分区域连接路缺乏，未硬化，路面损坏面积机动车道
        /// </summary>
        private void query_message_2()
        {
            StringBuilder sb = new StringBuilder("select community_broken_road_num, community_sarea_lack_lroad, community_road_not_hardening_area, community_to_city_pasway_pavement_damage ");
            sb.Append(" from T_community_road_problem where ");
            sb.Append("community_id = @id");
            sb.Append(" and complete_year = @year");

            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = 2013}
                                       };

            DataRow row = gt.get_content(sb.ToString(), parameter);
            broken_road_num_2013 = Convert.ToInt32(row["community_broken_road_num"]);
            lack_link_num_2013 = Convert.ToInt32(row["community_sarea_lack_lroad"]);
            not_hard_area_2013 = Convert.ToDouble(row["community_road_not_hardening_area"]);
            road_broken_2013 = Convert.ToDouble(row["community_to_city_pasway_pavement_damage"]);

            sb = new StringBuilder("select community_broken_road_num, community_sarea_lack_lroad, community_road_not_hardening_area, community_to_city_pasway_pavement_damage ");
            sb.Append("from T_community_road_problem where ");
            sb.Append("community_id = @id ");
            sb.Append("and complete_year = @year ");
            sb.Append("and (community_fill_type = @type1 or community_fill_type = @type2 or community_fill_type = @type3)");

            SqlParameter[] parameters = {
                                            new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = last_mosdify.Year},
                                           new SqlParameter("@type1",SqlDbType.VarChar,20){Value = "本底剩余"},
                                           new SqlParameter("@type2", SqlDbType.VarChar,20){Value = "新增剩余"},
                                           new SqlParameter("@type3",SqlDbType.VarChar,20){Value = "新增"}
                                        };

            DataSet ds = gt.sql_query(sb.ToString(), parameters);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                broken_road_num_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_broken_road_num"]);
                lack_link_num_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_sarea_lack_lroad"]);
                not_hard_area_now += Convert.ToDouble(ds.Tables[0].Rows[i]["community_road_not_hardening_area"]);
                road_broken_now += Convert.ToDouble(ds.Tables[0].Rows[i]["community_to_city_pasway_pavement_damage"]);
            }
        }
        /// <summary>
        /// 小区宅间路问题表 —— 路面损坏面积（人行道）、缺乏人行道
        /// </summary>
        private void query_message_3()
        {
            StringBuilder sb = new StringBuilder("select community_psw_damage_length, community_some_runit_lack_lroad_num ");
            sb.Append("from T_community_bet_dwellings_road_problem where ");
            sb.Append("community_id = @id ");
            sb.Append("and complete_year = @year");

            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = 2013}
                                       };

            DataRow row = gt.get_content(sb.ToString(), parameter);
            sidewalk_broken_2013 = Convert.ToDouble(row["community_psw_damage_length"]);
            lack_link_num_2013 = Convert.ToInt32(row["community_some_runit_lack_lroad_num"]);

            sb = new StringBuilder("select community_psw_damage_length, community_some_runit_lack_lroad_num ");
            sb.Append("from T_community_bet_dwellings_road_problem where ");
            sb.Append("community_id = @id ");
            sb.Append("and complete_year = @year ");
            sb.Append("and (community_fill_type = @type1 or community_fill_type = @type2 or community_fill_type = @type3)");

            SqlParameter[] parameters = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = last_mosdify.Year},
                                           new SqlParameter("@type1",SqlDbType.VarChar,20){Value = "本底剩余"},
                                           new SqlParameter("@type2", SqlDbType.VarChar,20){Value = "新增剩余"},
                                           new SqlParameter("@type3",SqlDbType.VarChar,20){Value = "新增"}
                                        };
            DataSet ds = gt.sql_query(sb.ToString(), parameters);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                sidewalk_broken_now += Convert.ToDouble(ds.Tables[0].Rows[i]["community_psw_damage_length"]);
                lack_link_num_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_some_runit_lack_lroad_num"]);
            }
        }
        /// <summary>
        /// 小区供水问题表 —— 供水不足涉及住宅户数、供水压力不足涉及住宅户数、小区供水管道损坏长度、未落实一户一表涉及住宅户数
        /// </summary>
        private void query_message_4()
        {
            StringBuilder sb = new StringBuilder("select community_insuf_ws_house_num, community_insuf_wp_house_num, community_aging_corrosion_pipe_length, community_not_imple_ohot_house_num ");
            sb.Append("from T_community_water_supply_problem where ");
            sb.Append("community_id = @id ");
            sb.Append("and complete_year = @year");
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = 2013}
                                       };
            DataRow row = gt.get_content(sb.ToString(), parameter);
            inadequate_water_2013 = Convert.ToInt32(row["community_insuf_ws_house_num"]);
            water_pressure_2013 = Convert.ToInt32(row["community_insuf_wp_house_num"]);
            pipe_damage_2013 = Convert.ToDouble(row["community_aging_corrosion_pipe_length"]);
            not_one_one_2013 = Convert.ToInt32(row["community_not_imple_ohot_house_num"]);

            sb = new StringBuilder("select community_insuf_ws_house_num, community_insuf_wp_house_num, community_aging_corrosion_pipe_length, community_not_imple_ohot_house_num ");
            sb.Append("from T_community_water_supply_problem where ");
            sb.Append("community_id = @id ");
            sb.Append("and complete_year = @year ");
            sb.Append("and (community_fill_type = @type1 or community_fill_type = @type2 or community_fill_type = @type3)");
            SqlParameter[] parameters = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = last_mosdify.Year},
                                           new SqlParameter("@type1",SqlDbType.VarChar,20){Value = "本底剩余"},
                                           new SqlParameter("@type2", SqlDbType.VarChar,20){Value = "新增剩余"},
                                           new SqlParameter("@type3",SqlDbType.VarChar,20){Value = "新增"}
                                        };
            DataSet ds = gt.sql_query(sb.ToString(), parameters);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                inadequate_water_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_insuf_ws_house_num"]);
                water_pressure_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_insuf_wp_house_num"]);
                pipe_damage_now += Convert.ToDouble(ds.Tables[0].Rows[i]["community_aging_corrosion_pipe_length"]);
                not_one_one_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_not_imple_ohot_house_num"]);
            }
        }
        /// <summary>
        /// 小区供电问题表 —— 供电条件
        /// </summary>
        private void query_message_5()
        {
            StringBuilder sb = new StringBuilder("select community_transformer_cap_ins_hou_num, community_senescent_elec_wireways_length, community_no_one_hou_one_meter_hou_num ");
            sb.Append("from T_community_elec_supply_problem where ");
            sb.Append("community_id = @id ");
            sb.Append("and complete_year = @year");
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = 2013}
                                       };
            DataRow row = gt.get_content(sb.ToString(), parameter);
            elec_inade_2013 = Convert.ToInt32(row["community_transformer_cap_ins_hou_num"]);
            link_damage_2013 = Convert.ToDouble(row["community_senescent_elec_wireways_length"]);
            not_e_one_one_2013 = Convert.ToInt32(row["community_no_one_hou_one_meter_hou_num"]);

            sb = new StringBuilder("select community_transformer_cap_ins_hou_num, community_senescent_elec_wireways_length, community_no_one_hou_one_meter_hou_num ");
            sb.Append("from T_community_elec_supply_problem where ");
            sb.Append("community_id = @id ");
            sb.Append("and complete_year = @year ");
            sb.Append("and (community_fill_type = @type1 or community_fill_type = @type2 or community_fill_type = @type3)");
            SqlParameter[] parameters = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = last_mosdify.Year},
                                           new SqlParameter("@type1",SqlDbType.VarChar,20){Value = "本底剩余"},
                                           new SqlParameter("@type2", SqlDbType.VarChar,20){Value = "新增剩余"},
                                           new SqlParameter("@type3",SqlDbType.VarChar,20){Value = "新增"}
                                        };
            DataSet ds = gt.sql_query(sb.ToString(), parameters);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                elec_inade_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_transformer_cap_ins_hou_num"]);
                link_damage_now += Convert.ToDouble(ds.Tables[0].Rows[i]["community_senescent_elec_wireways_length"]);
                not_e_one_one_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_no_one_hou_one_meter_hou_num"]);
            }
        }
        /// <summary>
        /// 小区照明问题表 —— 公共照明
        /// </summary>
        private void query_message_6()
        {
            StringBuilder sb = new StringBuilder("select community_road_wout_slamp_length, community_road_lack_slamp_insuf_light_length, community_corridor_light_damage_house_num ");
            sb.Append("from T_community_lighting_problem where ");
            sb.Append("community_id = @id ");
            sb.Append("and complete_year = @year");
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = 2013}
                                       };
            DataRow row = gt.get_content(sb.ToString(), parameter);
            no_light_2013 = Convert.ToDouble(row["community_road_wout_slamp_length"]);
            less_light_2013 = Convert.ToDouble(row["community_road_lack_slamp_insuf_light_length"]);
            light_damage_2013 = Convert.ToInt32(row["community_corridor_light_damage_house_num"]);

            sb = new StringBuilder("select community_road_wout_slamp_length, community_road_lack_slamp_insuf_light_length, community_corridor_light_damage_house_num ");
            sb.Append("from T_community_lighting_problem where ");
            sb.Append("community_id = @id ");
            sb.Append("and complete_year = @year ");
            sb.Append("and (community_fill_type = @type1 or community_fill_type = @type2 or community_fill_type = @type3)");
            SqlParameter[] parameters = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = last_mosdify.Year},
                                           new SqlParameter("@type1",SqlDbType.VarChar,20){Value = "本底剩余"},
                                           new SqlParameter("@type2", SqlDbType.VarChar,20){Value = "新增剩余"},
                                           new SqlParameter("@type3",SqlDbType.VarChar,20){Value = "新增"}
                                        };
            DataSet ds = gt.sql_query(sb.ToString(), parameters);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                no_light_now += Convert.ToDouble(ds.Tables[0].Rows[i]["community_road_wout_slamp_length"]);
                less_light_now += Convert.ToDouble(ds.Tables[0].Rows[i]["community_road_lack_slamp_insuf_light_length"]);
                light_damage_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_corridor_light_damage_house_num"]);
            }
        }
        /// <summary>
        /// 小区消防问题表 —— 消防
        /// </summary>
        private void query_message_7()
        {
            StringBuilder sb = new StringBuilder("select community_road_lack_outdoor_fh_length, community_lack_indoor_fh_building_num, community_unreach_length ");
            sb.Append("from T_community_ff_problem where ");
            sb.Append("community_id = @id ");
            sb.Append("and complete_year = @year");
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = 2013}
                                       };
            DataRow row = gt.get_content(sb.ToString(), parameter);
            out_ff_less_2013 = Convert.ToDouble(row["community_road_lack_outdoor_fh_length"]);
            in_ff_less_2013 = Convert.ToInt32(row["community_lack_indoor_fh_building_num"]);
            exits_not_com_2013 = Convert.ToDouble(row["community_unreach_length"]);

            sb = new StringBuilder("select community_road_lack_outdoor_fh_length, community_lack_indoor_fh_building_num, community_unreach_length ");
            sb.Append("from T_community_ff_problem where ");
            sb.Append("community_id = @id ");
            sb.Append("and complete_year = @year ");
            sb.Append("and (community_fill_type = @type1 or community_fill_type = @type2 or community_fill_type = @type3)");
            SqlParameter[] parameters = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = last_mosdify.Year},
                                           new SqlParameter("@type1",SqlDbType.VarChar,20){Value = "本底剩余"},
                                           new SqlParameter("@type2", SqlDbType.VarChar,20){Value = "新增剩余"},
                                           new SqlParameter("@type3",SqlDbType.VarChar,20){Value = "新增"}
                                        };
            DataSet ds = gt.sql_query(sb.ToString(), parameters);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                out_ff_less_now += Convert.ToDouble(ds.Tables[0].Rows[i]["community_road_lack_outdoor_fh_length"]);
                in_ff_less_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_lack_indoor_fh_building_num"]);
                exits_not_com_now += Convert.ToDouble(ds.Tables[0].Rows[i]["community_unreach_length"]);
            }
        }
        /// <summary>
        /// 小区项目实物表 —— 计划、完成
        /// </summary>
        private void query_message_8()
        {
            StringBuilder sql = new StringBuilder("select physical_class_content, summary, june_quantity from T_project_physical ");
            sql.Append("where county_name = @county ");
            sql.Append("and community = @community ");
            sql.Append("and physical_class = @class ");
            //sql.Append("and year = @year ");
            SqlParameter[] parameter = {
                                           new SqlParameter("@county",SqlDbType.VarChar, 50){Value = county_name},
                                           new SqlParameter("@community",SqlDbType.VarChar, 50){Value = community_name},
                                           new SqlParameter("@class", SqlDbType.VarChar, 20){Value = "基础设施"}
                                           //new SqlParameter("@year",SqlDbType.Int, 4){Value = DateTime.Now.Year}
                                       };

            DataSet ds = gt.sql_query(sql.ToString(), parameter);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                string str = Convert.ToString(ds.Tables[0].Rows[i]["physical_class_content"]);
                if (str.Equals("新增连接路数量(条)"))
                {
                    add_link_num_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    add_link_num_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新建机动车道面积(m2)"))
                {
                    add_road_area_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_road_area_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("硬化机动车道面积(m2)"))
                {
                    harden_road_area_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    harden_road_area_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("除硬化外维修改造机动车道面积(m2)"))
                {
                    repair_road_area_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    repair_road_area_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("人行道地砖改造面积"))
                {
                    change_sidewalk_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    change_sidewalk_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新建人行道面积(m2)"))
                {
                    add_sidewalk_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_sidewalk_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增供水容量(t/d)"))
                {
                    add_water_cap_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_water_cap_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增供水增压设施(处)"))
                {
                    add_water_press_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    add_water_press_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新建供水管长度(km)"))
                {
                    add_pipe_length_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_pipe_length_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("维修改造供水管长度(km)"))
                {
                    repair_pipe_length_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    repair_pipe_length_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("水表安装(户)"))
                {
                    add_meter_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    add_meter_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增变压器后增容(KVA)"))
                {
                    add_trans_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_trans_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("更换变压器后增容(KVA)"))
                {
                    change_trans_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    change_trans_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("变压器安装改造(台)"))
                {
                    repair_trans_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    repair_trans_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新建配电线路(km)"))
                {
                    add_line_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_line_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("维修改造配电线路(km)"))
                {
                    repair_line_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    repair_line_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("电表安装(户)"))
                {
                    install_trans_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    install_trans_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增室外照明设施覆盖路段(km)"))
                {
                    add_out_light_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_out_light_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("修复室外照明设施覆盖路段(km)"))
                {
                    repair_out_light_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    repair_out_light_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增楼栋照明设施数量(盏)"))
                {
                    add_in_light_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    add_in_light_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("修复楼栋照明设施数量(盏)"))
                {
                    repair_in_light_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    repair_in_light_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增室外消防设施数量(套)"))
                {
                    add_out_ff_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    add_out_ff_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增室内消防设施数量(套)"))
                {
                    add_in_ff_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    add_in_ff_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("消防通道改造(m)"))
                {
                    repair_exits_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    repair_exits_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
            }
        }
        /// <summary>
        /// 小区道路表 —— 道路通达程度、道路通畅程度
        /// </summary>
        private void query_message_9()
        {
            StringBuilder sb = new StringBuilder("select community_road_num, community_road_area from T_community_road where ");
            sb.Append("community_id = @id order by statistics_date");

            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar,20){Value = community_id}
                                       };
            DataSet ds = gt.sql_query(sb.ToString(), parameter);
            double road = Convert.ToDouble(ds.Tables[0].Rows[0]["community_road_num"]);      //2013年小区道路数目
            double area = Convert.ToDouble(ds.Tables[0].Rows[0]["community_road_area"]);       //2013年小区道路总面积

            if (road == 0)
            {
                road_access_rate_2013 = 0;
            }
            else
            {
                road_access_rate_2013 = (1 - lack_link_num_2013 / road) * 100;
            }
            if (area == 0)
            {
                road_clear_rate_2013 = (1 - (road_broken_2013 + sidewalk_broken_2013) / area) * 100;
            }

            int count = ds.Tables[0].Rows.Count;
            road = Convert.ToDouble(ds.Tables[0].Rows[count-1]["community_road_num"]);
            area = Convert.ToDouble(ds.Tables[0].Rows[count-1]["community_road_area"]);
            road_access_rate_now = (1 - lack_link_num_now / road) * 100;
            road_clear_rate_now = (1 - (road_broken_now + sidewalk_broken_now) / area) * 100;
        }
        /// <summary>
        /// 供水
        /// </summary>
        private void query_message_10()
        {
            string sql = "select community_family_num from T_community_population where community_id = @id order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
                                       };
            DataSet ds1 = gt.sql_query(sql, parameter);

            double family = Convert.ToDouble(ds1.Tables[0].Rows[0]["community_family_num"]);
            water_supply_guar_rate_2013 = (1 - (inadequate_water_2013 + water_pressure_2013) / family) * 100;

            sql = "select community_water_supply_pipe_length from T_community_water_supply where community_id = @id order by statistics_date";
            DataSet ds2 = gt.sql_query(sql, parameter);
            double length = Convert.ToDouble(ds2.Tables[0].Rows[0]["community_water_supply_pipe_length"]);
            water_pipe_line_com_rate_2013 = (1 - pipe_damage_2013 / length) * 100;

            water_double_one_rate_2013 = (1 - not_one_one_2013 / family) * 100;

            int count = ds1.Tables[0].Rows.Count;
            family = Convert.ToDouble(ds1.Tables[0].Rows[count-1]["community_family_num"]);
            water_supply_guar_rate_now = (1 - (inadequate_water_now + water_pressure_now) / family) * 100;
            count = ds2.Tables[0].Rows.Count;
            length = Convert.ToDouble(ds2.Tables[0].Rows[count-1]["community_water_supply_pipe_length"]);
            water_pipe_line_com_rate_now = (1 - pipe_damage_now / length) * 100;
            water_double_one_rate_now = (1 - not_one_one_now / family) * 100;
        }
        /// <summary>
        /// 供电
        /// </summary>
        private void query_message_11()
        {
            const double goal = 2.5;        //供电户均容量达标阈值
            string sql = "select community_family_num from T_community_population where community_id = @id order by statistics_date";               //查询小区户数
            SqlParameter[] parameter = {
                                            new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
                                        };
            DataSet ds1 = gt.sql_query(sql, parameter);
            double family = Convert.ToDouble(ds1.Tables[0].Rows[0]["community_family_num"]);        //2013年小区居民户数

            sql = "select community_elec_supply_consumption, community_elec_supply_wireways_length from T_community_elec_supply where community_id = @id order by statistics_date";        //查询小区供电总容量、供电线路总长度
            DataSet ds2 = gt.sql_query(sql, parameter);
            double elec = Convert.ToDouble(ds2.Tables[0].Rows[0]["community_elec_supply_consumption"]);     //2013年小区供电总容量

            double temp = elec / family;
            if (temp > goal)
            {
                elec_capa_guar_rate_2013 = 100;
            }
            else
            {
                elec_capa_guar_rate_2013 = temp / goal * 100;
            }

            double length = Convert.ToDouble(ds2.Tables[0].Rows[0]["community_elec_supply_wireways_length"]);       //2013年供电线路总长度
            elec_line_safe_rate_2013 = (1 - link_damage_2013 / length) * 100;

            elec_double_one_rate_2013 = (1 - not_e_one_one_2013 / family) * 100;

            int count = ds1.Tables[0].Rows.Count;
            family = Convert.ToDouble(ds1.Tables[0].Rows[count-1]["community_family_num"]);        //当前小区居民户数
            count = ds2.Tables[0].Rows.Count;
            elec = Convert.ToDouble(ds2.Tables[0].Rows[count-1]["community_elec_supply_consumption"]);     //当前小区供电总容量
            temp = elec / family;
            if (temp > goal)
            {
                elec_capa_guar_rate_now = 100;
            }
            else
            {
                elec_capa_guar_rate_now = temp / goal * 100;
            }
            length = Convert.ToDouble(ds2.Tables[0].Rows[count - 1]["community_elec_supply_wireways_length"]);      //当前供电线路总长度
            elec_line_safe_rate_now = (1 - link_damage_now / length) * 100;
            elec_double_one_rate_now = (1 - not_e_one_one_now / family) * 100;
        }
        /// <summary>
        /// 公共照明
        /// </summary>
        private void query_message_12()
        {
            string sql = "select community_road_length from T_community_road where community_id = @id order by statistics_date";        //查询小区道路总长度
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
                                       };
            DataSet ds1 = gt.sql_query(sql, parameter);
            double length = Convert.ToDouble(ds1.Tables[0].Rows[0]["community_road_length"]);       //2013年小区道路长度
            out_light_com_rate_2013 = (1 - (no_light_2013 + less_light_2013) / length) * 100;

            sql = "select community_family_num from T_community_population where community_id = @id order by statistics_date";               //查询小区户数
            DataSet ds2 = gt.sql_query(sql, parameter);
            double family = Convert.ToDouble(ds2.Tables[0].Rows[0]["community_family_num"]);        //2013年居民户数
            in_light_com_rate_2013 = (1 - light_damage_2013 / family) * 100;

            int count = ds1.Tables[0].Rows.Count;
            length = Convert.ToDouble(ds1.Tables[0].Rows[count - 1]["community_road_length"]);       //当前小区道路长度
            out_light_com_rate_now = (1 - (no_light_now + less_light_now) / length) * 100;

            family = Convert.ToDouble(ds2.Tables[0].Rows[count - 1]["community_family_num"]);           //当前居民户数
            in_light_com_rate_now = (1 - light_damage_now / family) * 100;
        }
        /// <summary>
        /// 消防
        /// </summary>
        private void query_message_13()
        {
            string sql = "select community_road_length from T_community_road where community_id = @id order by statistics_date";        //查询小区道路长度
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
                                       };
            DataSet ds1 = gt.sql_query(sql, parameter);
            double length = Convert.ToDouble(ds1.Tables[0].Rows[0]["community_road_length"]);       //2013年小区道路长度
            out_ff_com_rate_2013 = (1 - out_ff_less_2013 / length) * 100;

            sql = "select community_council_buil_num from T_community_concil_house where community_id = @id order by statistics_date";      //查询小区房屋数目
            DataSet ds2 = gt.sql_query(sql, parameter);
            double house = Convert.ToDouble(ds2.Tables[0].Rows[0]["community_council_buil_num"]);       //2013小区房屋数目
            in_ff_com_rate_2013 = (1 - in_ff_less_2013 / house) * 100;

            sql = "select community_ff_pass_length from T_community_fire_fighting where community_id = @id order by statistics_date";       //查询小区消防通道长度
            DataSet ds3 = gt.sql_query(sql, parameter);
            double exits = Convert.ToDouble(ds3.Tables[0].Rows[0]["community_ff_pass_length"]);         //2013年消防通道长度
            ff_exits_com_rate_2013 = (1 - exits_not_com_2013 / exits) * 100;

            int count = ds1.Tables[0].Rows.Count;
            length = Convert.ToDouble(ds1.Tables[0].Rows[count - 1]["community_road_length"]);       //当前小区道路长度
            out_ff_com_rate_now = (1 - out_ff_less_now / length) * 100;

            count = ds2.Tables[0].Rows.Count;
            house = Convert.ToDouble(ds2.Tables[0].Rows[count - 1]["community_council_buil_num"]);       //当前小区房屋数目
            in_ff_com_rate_now = (1 - in_ff_less_now / house) * 100;

            count = ds3.Tables[0].Rows.Count;
            exits = Convert.ToDouble(ds3.Tables[0].Rows[count - 1]["community_ff_pass_length"]);         //当前消防通道长度
            ff_exits_com_rate_now = (1 - exits_not_com_now / exits) * 100;
        }

        #endregion
    }
}
