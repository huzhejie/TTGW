using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TTG.DAL.GET
{
    public class get_env_protect
    {
        #region 字段
        private get_tools gt = new get_tools();
        private string province_name, county_name, community_name, community_id;
        private DateTime last_modify;

        private int less_roadside_dustbin_2013, less_roadside_dustbin_now,      //路边垃圾箱不足涉及路段
            less_house_dustbin_2013, less_house_dustbin_now,                    //住宅区垃圾箱设置不足涉及区域
            less_sanitation_2013, less_sanitation_now,              //区域环卫设施不足
            less_toilet_2013, less_toilet_now,                  //公厕数量不足涉及区域
            not_in_sewage_house_2013, not_in_sewage_house_now,  //未接入城市污水管网的住宅
            sewage_ditch_2013, sewage_ditch_now;                //生活污水直排溪沟、长江处数
        private double drain_pipe_damage_2013, drain_pipe_damage_now,       //小区排水管损坏长度
            drain_ditch_damage_2013, drain_ditch_damage_now,        //排(洪)水沟损坏
            green_area_2013, green_area_now;        //小区绿地面积
        private string less_drain_ditch_2013 = "";
        private string less_drain_ditch_now = "";     //排(洪)水沟不足
        private int add_dustbin_plan, add_dustbin_com,      //新增垃圾桶箱数量
            add_garbage_transfer_plan, add_garbage_transfer_com,    //新增垃圾中转站数量
            repair_garbage_transfer_plan, repair_garbage_transfer_com,  //维修改造垃圾中转站数量
            add_toilet_plan, add_toilet_com,        //新增公厕
            repair_toilet_plan, repair_toilet_com,      //维修改造公厕
            add_septic_tank_plan, add_septic_tank_com,      //新建化粪池数量
            plant_trees_plan, plant_trees_com;          //植树
        private double repair_sewage_plan, repair_sewage_com,       //维修改造污水管网长度
            add_sewage_plan, add_sewage_com,        //新建污水管网长度
            add_drain_plan, add_drain_com,      //新建排水管长度
            repair_drain_plan, repair_drain_com,        //维修改造排水管长度
            add_ditch_plan, add_ditch_com,          //新建排(洪)水沟长度
            repair_ditch_plan, repair_ditch_com,        //维修改造排(洪)水沟长度
            add_green_plan, add_green_com;              //新增绿化面积
        private double garbage_collect_rate_2013, garbage_collect_rate_now,     //垃圾收集能力达标率
            toilet_coverage_rate_2013, toilet_coverage_rate_now,            //公共厕所覆盖程度
            sewage_collect_rate_2013, sewage_collect_rate_now,          //生活污水收集能力达标率
            drain_safe_rate_2013, drain_safe_rate_now,          //排水安全保障程度
            green_rate_2013, green_rate_now;                //小区绿化率

        #endregion

        #region 属性

        public string Community_id
        {
            get { return community_id; }
            set { community_id = value; }
        }

        public DateTime Last_modify
        {
            get { return last_modify; }
            set { last_modify = value; }
        }

        public int Less_roadside_dustbin_2013
        {
            get { return less_roadside_dustbin_2013; }
            set { less_roadside_dustbin_2013 = value; }
        }

        public int Less_roadside_dustbin_now
        {
            get { return less_roadside_dustbin_now; }
            set { less_roadside_dustbin_now = value; }
        }

        public int Less_house_dustbin_2013
        {
            get { return less_house_dustbin_2013; }
            set { less_house_dustbin_2013 = value; }
        }

        public int Less_house_dustbin_now
        {
            get { return less_house_dustbin_now; }
            set { less_house_dustbin_now = value; }
        }

        public int Less_sanitation_2013
        {
            get { return less_sanitation_2013; }
            set { less_sanitation_2013 = value; }
        }

        public int Less_sanitation_now
        {
            get { return less_sanitation_now; }
            set { less_sanitation_now = value; }
        }

        public int Less_toilet_2013
        {
            get { return less_toilet_2013; }
            set { less_toilet_2013 = value; }
        }

        public int Less_toilet_now
        {
            get { return less_toilet_now; }
            set { less_toilet_now = value; }
        }

        public int Not_in_sewage_house_2013
        {
            get { return not_in_sewage_house_2013; }
            set { not_in_sewage_house_2013 = value; }
        }

        public int Not_in_sewage_house_now
        {
            get { return not_in_sewage_house_now; }
            set { not_in_sewage_house_now = value; }
        }

        public int Sewage_ditch_2013
        {
            get { return sewage_ditch_2013; }
            set { sewage_ditch_2013 = value; }
        }

        public int Sewage_ditch_now
        {
            get { return sewage_ditch_now; }
            set { sewage_ditch_now = value; }
        }

        public double Drain_pipe_damage_2013
        {
            get { return drain_pipe_damage_2013; }
            set { drain_pipe_damage_2013 = value; }
        }

        public double Drain_pipe_damage_now
        {
            get { return drain_pipe_damage_now; }
            set { drain_pipe_damage_now = value; }
        }

        public double Drain_ditch_damage_2013
        {
            get { return drain_ditch_damage_2013; }
            set { drain_ditch_damage_2013 = value; }
        }

        public double Drain_ditch_damage_now
        {
            get { return drain_ditch_damage_now; }
            set { drain_ditch_damage_now = value; }
        }

        public double Green_area_2013
        {
            get { return green_area_2013; }
            set { green_area_2013 = value; }
        }

        public double Green_area_now
        {
            get { return green_area_now; }
            set { green_area_now = value; }
        }

        public string Less_drain_ditch_2013
        {
            get { return less_drain_ditch_2013; }
            set { less_drain_ditch_2013 = value; }
        }

        public string Less_drain_ditch_now
        {
            get { return less_drain_ditch_now; }
            set { less_drain_ditch_now = value; }
        }

        public int Add_dustbin_plan
        {
            get { return add_dustbin_plan; }
            set { add_dustbin_plan = value; }
        }

        public int Add_dustbin_com
        {
            get { return add_dustbin_com; }
            set { add_dustbin_com = value; }
        }

        public int Add_garbage_transfer_plan
        {
            get { return add_garbage_transfer_plan; }
            set { add_garbage_transfer_plan = value; }
        }

        public int Add_garbage_transfer_com
        {
            get { return add_garbage_transfer_com; }
            set { add_garbage_transfer_com = value; }
        }

        public int Repair_garbage_transfer_plan
        {
            get { return repair_garbage_transfer_plan; }
            set { repair_garbage_transfer_plan = value; }
        }

        public int Repair_garbage_transfer_com
        {
            get { return repair_garbage_transfer_com; }
            set { repair_garbage_transfer_com = value; }
        }

        public int Add_toilet_plan
        {
            get { return add_toilet_plan; }
            set { add_toilet_plan = value; }
        }

        public int Add_toilet_com
        {
            get { return add_toilet_com; }
            set { add_toilet_com = value; }
        }

        public int Repair_toilet_plan
        {
            get { return repair_toilet_plan; }
            set { repair_toilet_plan = value; }
        }

        public int Repair_toilet_com
        {
            get { return repair_toilet_com; }
            set { repair_toilet_com = value; }
        }

        public int Add_septic_tank_plan
        {
            get { return add_septic_tank_plan; }
            set { add_septic_tank_plan = value; }
        }

        public int Add_septic_tank_com
        {
            get { return add_septic_tank_com; }
            set { add_septic_tank_com = value; }
        }

        public int Plant_trees_plan
        {
            get { return plant_trees_plan; }
            set { plant_trees_plan = value; }
        }

        public int Plant_trees_com
        {
            get { return plant_trees_com; }
            set { plant_trees_com = value; }
        }

        public double Repair_sewage_plan
        {
            get { return repair_sewage_plan; }
            set { repair_sewage_plan = value; }
        }

        public double Repair_sewage_com
        {
            get { return repair_sewage_com; }
            set { repair_sewage_com = value; }
        }

        public double Add_sewage_plan
        {
            get { return add_sewage_plan; }
            set { add_sewage_plan = value; }
        }

        public double Add_sewage_com
        {
            get { return add_sewage_com; }
            set { add_sewage_com = value; }
        }

        public double Add_drain_plan
        {
            get { return add_drain_plan; }
            set { add_drain_plan = value; }
        }

        public double Add_drain_com
        {
            get { return add_drain_com; }
            set { add_drain_com = value; }
        }

        public double Repair_drain_plan
        {
            get { return repair_drain_plan; }
            set { repair_drain_plan = value; }
        }

        public double Repair_drain_com
        {
            get { return repair_drain_com; }
            set { repair_drain_com = value; }
        }

        public double Add_ditch_plan
        {
            get { return add_ditch_plan; }
            set { add_ditch_plan = value; }
        }

        public double Add_ditch_com
        {
            get { return add_ditch_com; }
            set { add_ditch_com = value; }
        }

        public double Repair_ditch_plan
        {
            get { return repair_ditch_plan; }
            set { repair_ditch_plan = value; }
        }

        public double Repair_ditch_com
        {
            get { return repair_ditch_com; }
            set { repair_ditch_com = value; }
        }

        public double Add_green_plan
        {
            get { return add_green_plan; }
            set { add_green_plan = value; }
        }

        public double Add_green_com
        {
            get { return add_green_com; }
            set { add_green_com = value; }
        }

        public double Garbage_collect_rate_2013
        {
            get { return garbage_collect_rate_2013; }
            set { garbage_collect_rate_2013 = value; }
        }

        public double Garbage_collect_rate_now
        {
            get { return garbage_collect_rate_now; }
            set { garbage_collect_rate_now = value; }
        }

        public double Toilet_coverage_rate_2013
        {
            get { return toilet_coverage_rate_2013; }
            set { toilet_coverage_rate_2013 = value; }
        }

        public double Toilet_coverage_rate_now
        {
            get { return toilet_coverage_rate_now; }
            set { toilet_coverage_rate_now = value; }
        }

        public double Sewage_collect_rate_2013
        {
            get { return sewage_collect_rate_2013; }
            set { sewage_collect_rate_2013 = value; }
        }

        public double Sewage_collect_rate_now
        {
            get { return sewage_collect_rate_now; }
            set { sewage_collect_rate_now = value; }
        }

        public double Drain_safe_rate_2013
        {
            get { return drain_safe_rate_2013; }
            set { drain_safe_rate_2013 = value; }
        }

        public double Drain_safe_rate_now
        {
            get { return drain_safe_rate_now; }
            set { drain_safe_rate_now = value; }
        }

        public double Green_rate_2013
        {
            get { return green_rate_2013; }
            set { green_rate_2013 = value; }
        }

        public double Green_rate_now
        {
            get { return green_rate_now; }
            set { green_rate_now = value; }
        }

        #endregion

        public get_env_protect(string province, string county, string community)
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
            last_modify = Convert.ToDateTime(row["statistics_date"]);
        }
        /// <summary>
        /// 小区环卫问题表 —— 环卫
        /// </summary>
        private void query_message_2()
        {
            StringBuilder sb = new StringBuilder("select community_road_lack_rd_num, community_insuf_resd_area, community_regional_insuf_sf_num, community_toilet_insuf_pt_area from T_community_sanitation_problem where ");
            sb.Append("complete_year = @year ");
            sb.Append("and community_id = @id");

            SqlParameter[] parameter = {
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = 2013},
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
                                       };

            DataRow row = gt.get_content(sb.ToString(), parameter);
            less_roadside_dustbin_2013 = Convert.ToInt32(row["community_road_lack_rd_num"]);
            less_house_dustbin_2013 = Convert.ToInt32(row["community_insuf_resd_area"]);
            less_sanitation_2013 = Convert.ToInt32(row["community_regional_insuf_sf_num"]);
            less_toilet_2013 = Convert.ToInt32(row["community_toilet_insuf_pt_area"]);

            sb = new StringBuilder("select community_road_lack_rd_num, community_insuf_resd_area, community_regional_insuf_sf_num, community_toilet_insuf_pt_area from T_community_sanitation_problem where ");
            sb.Append("complete_year = @year ");
            sb.Append("and community_id = @id ");
            sb.Append("and (community_fill_type = @type1 or community_fill_type = @type2 or community_fill_type = @type3)");

            SqlParameter[] parameters = {
                                            new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = last_modify.Year},
                                           new SqlParameter("@type1",SqlDbType.VarChar,20){Value = "本底剩余"},
                                           new SqlParameter("@type2", SqlDbType.VarChar,20){Value = "新增剩余"},
                                           new SqlParameter("@type3",SqlDbType.VarChar,20){Value = "新增"}
                                        };
            DataSet ds = gt.sql_query(sb.ToString(), parameters);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                less_roadside_dustbin_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_road_lack_rd_num"]);
                less_house_dustbin_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_insuf_resd_area"]);
                less_sanitation_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_regional_insuf_sf_num"]);
                less_toilet_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_toilet_insuf_pt_area"]);
            }
        }
        /// <summary>
        /// 小区排水问题表 —— 排污和排水
        /// </summary>
        private void query_message_3()
        {
            StringBuilder sb = new StringBuilder("select community_not_access_uspn_house_num, community_sewage_straight_to_cj_num, community_pipe_damage_length, community_gutter_damage, community_insuf_gutter ");
            sb.Append("from T_community_water_drain_problem where ");
            sb.Append("complete_year = @year ");
            sb.Append("and community_id = @id");

            SqlParameter[] parameter = {
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = 2013},
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
                                       };

            DataRow row = gt.get_content(sb.ToString(), parameter);

            not_in_sewage_house_2013 = Convert.ToInt32(row["community_not_access_uspn_house_num"]);
            sewage_ditch_2013 = Convert.ToInt32(row["community_sewage_straight_to_cj_num"]);
            drain_pipe_damage_2013 = Convert.ToDouble(row["community_pipe_damage_length"]);
            drain_ditch_damage_2013 = Convert.ToDouble(row["community_gutter_damage"]);
            less_drain_ditch_2013 = Convert.ToString(row["community_insuf_gutter"]);

            sb = new StringBuilder("select community_not_access_uspn_house_num, community_sewage_straight_to_cj_num, community_pipe_damage_length, community_gutter_damage, community_insuf_gutter ");
            sb.Append("from T_community_water_drain_problem where ");
            sb.Append("complete_year = @year ");
            sb.Append("and community_id = @id ");
            sb.Append("and (community_fill_type = @type1 or community_fill_type = @type2 or community_fill_type = @type3)");

            SqlParameter[] parameters = {
                                            new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = last_modify.Year},
                                           new SqlParameter("@type1",SqlDbType.VarChar,20){Value = "本底剩余"},
                                           new SqlParameter("@type2", SqlDbType.VarChar,20){Value = "新增剩余"},
                                           new SqlParameter("@type3",SqlDbType.VarChar,20){Value = "新增"}
                                        };
            DataSet ds = gt.sql_query(sb.ToString(), parameters);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                not_in_sewage_house_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_not_access_uspn_house_num"]);
                sewage_ditch_now += Convert.ToInt32(ds.Tables[0].Rows[i]["community_sewage_straight_to_cj_num"]);
                drain_pipe_damage_now += Convert.ToDouble(ds.Tables[0].Rows[i]["community_pipe_damage_length"]);
                drain_ditch_damage_now += Convert.ToDouble(ds.Tables[0].Rows[i]["community_gutter_damage"]);
                less_drain_ditch_now = Convert.ToString(ds.Tables[0].Rows[i]["community_insuf_gutter"]);
            }
        }
        /// <summary>
        /// 小区绿化表 —— 绿地面积
        /// </summary>
        private void query_message_4()
        {
            string sql = "select * from T_community_green_fields where community_id = @id order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);
            green_area_2013 = Convert.ToDouble(ds.Tables[0].Rows[0]["community_green_fields_area"]);
            int count = ds.Tables[0].Rows.Count - 1;
            green_area_now = Convert.ToDouble(ds.Tables[0].Rows[count]["community_green_fields_area"]) + Convert.ToDouble(ds.Tables[0].Rows[count]["community_green_fields_bet_dwellings_area"])
                + Convert.ToDouble(ds.Tables[0].Rows[count]["community_road_green_fields_area"]) + Convert.ToDouble(ds.Tables[0].Rows[count]["community_public_accomm_green_fields_area"]);
        }
        /// <summary>
        /// 项目实物表 —— 计划、完成
        /// </summary>
        private void query_message_5()
        {
            StringBuilder sql = new StringBuilder("select physical_class_content, summary, june_quantity from T_project_physical ");
            sql.Append("where county_name = @county ");
            sql.Append("and community = @community ");
            sql.Append("and physical_class = @class ");
            //sql.Append("and year = @year ");
            SqlParameter[] parameter = {
                                           new SqlParameter("@county",SqlDbType.VarChar, 50){Value = county_name},
                                           new SqlParameter("@community",SqlDbType.VarChar, 50){Value = community_name},
                                           new SqlParameter("@class", SqlDbType.VarChar, 20){Value = "环保设施"}
                                           //new SqlParameter("@year",SqlDbType.Int, 4){Value = last_modify.Year}
                                       };

            DataSet ds = gt.sql_query(sql.ToString(), parameter);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                string str = Convert.ToString(ds.Tables[0].Rows[i]["physical_class_content"]);
                if (str.Equals("新增垃圾桶箱数量(个)"))
                {
                    add_dustbin_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    add_dustbin_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增垃圾中转站数量(个)"))
                {
                    add_garbage_transfer_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    add_garbage_transfer_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("维修改造垃圾中转站数量(个)"))
                {
                    repair_garbage_transfer_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    repair_garbage_transfer_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增公厕(个)"))
                {
                    add_toilet_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    add_toilet_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("维修改造公厕(个)"))
                {
                    repair_toilet_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    repair_toilet_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("维修改造污水管网长度(km)"))
                {
                    repair_sewage_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    repair_sewage_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新建污水管网长度(km)"))
                {
                    add_sewage_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_sewage_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新建排水管长度(km)"))
                {
                    add_drain_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_drain_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("维修改造排水管长度(km)"))
                {
                    repair_drain_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    repair_drain_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新建排(洪)水沟长度(km)"))
                {
                    add_ditch_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_ditch_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("维修改造排(洪)水沟长度(km)"))
                {
                    repair_ditch_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    repair_ditch_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新建化粪池数量(个)"))
                {
                    add_septic_tank_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    add_septic_tank_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增绿化面积(m2)"))
                {
                    add_green_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_green_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("植树(株)"))
                {
                    plant_trees_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    plant_trees_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
            }
        }
        /// <summary>
        /// 小区环境卫生表 —— 环卫
        /// </summary>
        private void query_message_6()
        {
            string sql = "select community_dustbin_num, rubbish_collection_plan_num, community_public_toilet_num, community_public_toilet_plan_num from T_community_environmental_hygiene where community_id = @id order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);
            double num1 = Convert.ToDouble(ds.Tables[0].Rows[0]["community_dustbin_num"]);      //垃圾收集装置数量
            double num2 = Convert.ToDouble(ds.Tables[0].Rows[0]["rubbish_collection_plan_num"]);        //应设垃圾收集装置数量
            garbage_collect_rate_2013 = num1 / num2 * 100;

            double num3 = Convert.ToDouble(ds.Tables[0].Rows[0]["community_public_toilet_num"]);            //公测数量
            double num4 = Convert.ToDouble(ds.Tables[0].Rows[0]["community_public_toilet_plan_num"]);       //公厕应设数量
            toilet_coverage_rate_2013 = num3 / num4 * 100;

            int count = ds.Tables[0].Rows.Count;
            num1 = Convert.ToDouble(ds.Tables[0].Rows[count-1]["community_dustbin_num"]);      //垃圾收集装置数量
            num2 = Convert.ToDouble(ds.Tables[0].Rows[count-1]["rubbish_collection_plan_num"]);        //应设垃圾收集装置数量
            garbage_collect_rate_now = num1 / num2 * 100;

            num3 = Convert.ToDouble(ds.Tables[0].Rows[count-1]["community_public_toilet_num"]);            //公测数量
            num4 = Convert.ToDouble(ds.Tables[0].Rows[count-1]["community_public_toilet_plan_num"]);       //公厕应设数量
            toilet_coverage_rate_now = num3 / num4 * 100;
        }
        /// <summary>
        /// 排水
        /// </summary>
        private void query_message_7()
        {
            string sql = "select community_not_access_uspn_res_num from T_community_water_drain_problem where community_id = @id order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
                                       };
            DataSet ds1 = gt.sql_query(sql, parameter);
            double num1 = Convert.ToDouble(ds1.Tables[0].Rows[0]["community_not_access_uspn_res_num"]);     //未接入排水管网的住宅栋数

            sql = "select community_council_buil_num from T_community_concil_house where community_id = @id order by statistics_date";
            DataSet ds2 = gt.sql_query(sql, parameter);
            double num2 = Convert.ToDouble(ds2.Tables[0].Rows[0]["community_council_buil_num"]);        //房屋栋数

            sewage_collect_rate_2013 = (1 - num1 / num2) * 100;

            sql = "select community_water_drain_pipe_length from T_community_water_drain where community_id = @id order by statistics_date";
            DataSet ds3 = gt.sql_query(sql, parameter);
            double num3 = Convert.ToDouble(ds3.Tables[0].Rows[0]["community_water_drain_pipe_length"]);     //排水管长度

            drain_safe_rate_2013 = (1 - (drain_pipe_damage_2013 + drain_ditch_damage_2013) / num3) * 100;

            int count = ds1.Tables[0].Rows.Count;
            num1 = Convert.ToDouble(ds1.Tables[0].Rows[count-1]["community_not_access_uspn_res_num"]);
            count = ds2.Tables[0].Rows.Count;
            num2 = Convert.ToDouble(ds2.Tables[0].Rows[count-1]["community_council_buil_num"]);
            count = ds3.Tables[0].Rows.Count;
            sewage_collect_rate_now = (1 - num1 / num2) * 100;

            num3 = Convert.ToDouble(ds3.Tables[0].Rows[count-1]["community_water_drain_pipe_length"]);
            drain_safe_rate_now = (1 - (drain_pipe_damage_now + drain_ditch_damage_now) / num3) * 100;
        }
        /// <summary>
        /// 绿地率
        /// </summary>
        private void query_message_8()
        {
            string sql = "select community_green_fields_area from T_community_green_fields where community_id = @id order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
                                       };
            DataSet ds1 = gt.sql_query(sql, parameter);
            double num1 = Convert.ToDouble(ds1.Tables[0].Rows[0]["community_green_fields_area"]);       //小区绿地面积

            sql = "select community_total_land_area from T_community_land where community_id = @id order by statistics_date";
            DataSet ds2 = gt.sql_query(sql, parameter);
            double num2 = Convert.ToDouble(ds2.Tables[0].Rows[0]["community_total_land_area"]);     //小区占地面积

            green_rate_2013 = num1 / (num2 * 10000) * 100;
            int count = ds1.Tables[0].Rows.Count;
            num1 = Convert.ToDouble(ds1.Tables[0].Rows[count-1]["community_green_fields_area"]);       //小区绿地面积
            count = ds2.Tables[0].Rows.Count;
            num2 = Convert.ToDouble(ds2.Tables[0].Rows[count-1]["community_total_land_area"]);     //小区占地面积
            green_rate_now = num1 / (num2 * 10000) * 100;
        }

        #endregion
    }
}
