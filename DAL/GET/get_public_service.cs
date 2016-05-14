using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TTG.DAL.GET
{
    public class get_public_service
    {
        #region 字段
        private get_tools gt = new get_tools();
        private string province_name, county_name, community_name, community_id;
        private DateTime last_modify;
        private int kindergarten_cap_2013, kindergarten_cap_now,        //幼儿园容量（人）
            clinic_bed_2013, clinic_bed_now,            //小区卫生室床位数
            fitness_equipment_2013, fitness_equipment_now;      //健身器材（套数）
        private double teaching_area_2013, teaching_area_now,       //教学面积
            out_play_area_2013, out_play_area_now,          //室外活动面积
            clinic_area_2013, clinic_area_now,      //小区卫生室面积
            out_ground_area_2013, out_ground_area_now,      //室外活动场地面积
            in_ground_area_2013, in_ground_area_now,        //室内活动场地面积
            old_area_2013, old_area_now,            //养老院面积
            management_area_2013, management_area_now,      //社区综合管理用房面积
            parking_area_2013, parking_area_now,            //停车场面积
            farm_area_2013, farm_area_now,              //农贸市场面积
            market_area_2013, market_area_now;          //便民超市面积
        private int add_kindergarten_cap_plan, add_kindergarten_cap_com,        //新增幼儿园容量
            change_kinder_cap_plan, change_kinder_cap_com,      //改扩建幼儿园容量
            add_bed_plan, add_bed_com,      //新增卫生室床位数
            add_fitness_plan, add_fitness_com;      //新增健身器材
        private double add_teaching_area_plan, add_teaching_area_com,      //新增教学面积
            add_kinder_ground_plan, add_kinder_ground_com,      //新增幼儿园活动场地
            add_clinic_plan, add_clinic_com,            //新增卫生室面积
            repair_clinic_plan, repair_clinic_com,      //维修改造卫生室面积
            add_out_ground_plan, add_out_ground_com,        //新增室外活动场地面积
            repair_out_ground_plan, repair_out_ground_com,      //改造室外活动场地面积
            add_in_ground_plan, add_in_ground_com,      //新增建设室内活动场所面积
            add_old_plan, add_old_com,                  //新增养老设施面积
            add_manage_house_plan, add_manage_house_com,    //新增社区综合管理用房
            add_parking_plan, add_parking_com,              //新增停车场面积
            add_farm_area_plan, add_farm_area_com,          //新增农贸市场面积
            add_market_plan, add_market_com;                //新增便民超市面积
        private double kinder_rate_2013, kinder_rate_now,       //幼儿园配置达标率
            medical_rate_2013, medical_rate_now,                //社区医疗配置达标率
            culture_sports_rate_2013, culture_sports_rate_now,      //文化健身设施配置达标率
            old_facilities_rate_2013, old_facilities_rate_now,      //养老设施配置达标率
            manage_rate_2013, manage_rate_now,                      //综合管理用房配置达标率
            parking_rate_2013, parking_rate_now,                //停车设施配置达标率
            farm_rate_2013, farm_rate_now,                  //菜市场配置达标率
            market_rate_2013, market_rate_now;              //便民店配置达标率

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

        public int Kindergarten_cap_2013
        {
            get { return kindergarten_cap_2013; }
            set { kindergarten_cap_2013 = value; }
        }

        public int Kindergarten_cap_now
        {
            get { return kindergarten_cap_now; }
            set { kindergarten_cap_now = value; }
        }

        public int Clinic_bed_2013
        {
            get { return clinic_bed_2013; }
            set { clinic_bed_2013 = value; }
        }

        public int Clinic_bed_now
        {
            get { return clinic_bed_now; }
            set { clinic_bed_now = value; }
        }

        public int Fitness_equipment_2013
        {
            get { return fitness_equipment_2013; }
            set { fitness_equipment_2013 = value; }
        }

        public int Fitness_equipment_now
        {
            get { return fitness_equipment_now; }
            set { fitness_equipment_now = value; }
        }

        public double Teaching_area_2013
        {
            get { return teaching_area_2013; }
            set { teaching_area_2013 = value; }
        }

        public double Teaching_area_now
        {
            get { return teaching_area_now; }
            set { teaching_area_now = value; }
        }

        public double Out_play_area_2013
        {
            get { return out_play_area_2013; }
            set { out_play_area_2013 = value; }
        }

        public double Out_play_area_now
        {
            get { return out_play_area_now; }
            set { out_play_area_now = value; }
        }

        public double Clinic_area_2013
        {
            get { return clinic_area_2013; }
            set { clinic_area_2013 = value; }
        }

        public double Clinic_area_now
        {
            get { return clinic_area_now; }
            set { clinic_area_now = value; }
        }

        public double Out_ground_area_2013
        {
            get { return out_ground_area_2013; }
            set { out_ground_area_2013 = value; }
        }

        public double Out_ground_area_now
        {
            get { return out_ground_area_now; }
            set { out_ground_area_now = value; }
        }

        public double In_ground_area_2013
        {
            get { return in_ground_area_2013; }
            set { in_ground_area_2013 = value; }
        }

        public double In_ground_area_now
        {
            get { return in_ground_area_now; }
            set { in_ground_area_now = value; }
        }

        public double Old_area_2013
        {
            get { return old_area_2013; }
            set { old_area_2013 = value; }
        }

        public double Old_area_now
        {
            get { return old_area_now; }
            set { old_area_now = value; }
        }

        public double Management_area_2013
        {
            get { return management_area_2013; }
            set { management_area_2013 = value; }
        }

        public double Management_area_now
        {
            get { return management_area_now; }
            set { management_area_now = value; }
        }

        public double Parking_area_2013
        {
            get { return parking_area_2013; }
            set { parking_area_2013 = value; }
        }

        public double Parking_area_now
        {
            get { return parking_area_now; }
            set { parking_area_now = value; }
        }

        public double Farm_area_2013
        {
            get { return farm_area_2013; }
            set { farm_area_2013 = value; }
        }

        public double Farm_area_now
        {
            get { return farm_area_now; }
            set { farm_area_now = value; }
        }

        public double Market_area_2013
        {
            get { return market_area_2013; }
            set { market_area_2013 = value; }
        }

        public double Market_area_now
        {
            get { return market_area_now; }
            set { market_area_now = value; }
        }

        public int Add_kindergarten_cap_plan
        {
            get { return add_kindergarten_cap_plan; }
            set { add_kindergarten_cap_plan = value; }
        }

        public int Add_kindergarten_cap_com
        {
            get { return add_kindergarten_cap_com; }
            set { add_kindergarten_cap_com = value; }
        }

        public int Change_kinder_cap_plan
        {
            get { return change_kinder_cap_plan; }
            set { change_kinder_cap_plan = value; }
        }

        public int Change_kinder_cap_com
        {
            get { return change_kinder_cap_com; }
            set { change_kinder_cap_com = value; }
        }

        public int Add_bed_plan
        {
            get { return add_bed_plan; }
            set { add_bed_plan = value; }
        }

        public int Add_bed_com
        {
            get { return add_bed_com; }
            set { add_bed_com = value; }
        }

        public int Add_fitness_plan
        {
            get { return add_fitness_plan; }
            set { add_fitness_plan = value; }
        }

        public int Add_fitness_com
        {
            get { return add_fitness_com; }
            set { add_fitness_com = value; }
        }

        public double Add_teaching_area_plan
        {
            get { return add_teaching_area_plan; }
            set { add_teaching_area_plan = value; }
        }

        public double Add_teaching_area_com
        {
            get { return add_teaching_area_com; }
            set { add_teaching_area_com = value; }
        }

        public double Add_kinder_ground_plan
        {
            get { return add_kinder_ground_plan; }
            set { add_kinder_ground_plan = value; }
        }

        public double Add_kinder_ground_com
        {
            get { return add_kinder_ground_com; }
            set { add_kinder_ground_com = value; }
        }

        public double Add_clinic_plan
        {
            get { return add_clinic_plan; }
            set { add_clinic_plan = value; }
        }

        public double Add_clinic_com
        {
            get { return add_clinic_com; }
            set { add_clinic_com = value; }
        }

        public double Repair_clinic_plan
        {
            get { return repair_clinic_plan; }
            set { repair_clinic_plan = value; }
        }

        public double Repair_clinic_com
        {
            get { return repair_clinic_com; }
            set { repair_clinic_com = value; }
        }

        public double Add_out_ground_plan
        {
            get { return add_out_ground_plan; }
            set { add_out_ground_plan = value; }
        }

        public double Add_out_ground_com
        {
            get { return add_out_ground_com; }
            set { add_out_ground_com = value; }
        }

        public double Repair_out_ground_plan
        {
            get { return repair_out_ground_plan; }
            set { repair_out_ground_plan = value; }
        }

        public double Repair_out_ground_com
        {
            get { return repair_out_ground_com; }
            set { repair_out_ground_com = value; }
        }

        public double Add_in_ground_plan
        {
            get { return add_in_ground_plan; }
            set { add_in_ground_plan = value; }
        }

        public double Add_in_ground_com
        {
            get { return add_in_ground_com; }
            set { add_in_ground_com = value; }
        }

        public double Add_old_plan
        {
            get { return add_old_plan; }
            set { add_old_plan = value; }
        }

        public double Add_old_com
        {
            get { return add_old_com; }
            set { add_old_com = value; }
        }

        public double Add_manage_house_plan
        {
            get { return add_manage_house_plan; }
            set { add_manage_house_plan = value; }
        }

        public double Add_manage_house_com
        {
            get { return add_manage_house_com; }
            set { add_manage_house_com = value; }
        }

        public double Add_parking_plan
        {
            get { return add_parking_plan; }
            set { add_parking_plan = value; }
        }

        public double Add_parking_com
        {
            get { return add_parking_com; }
            set { add_parking_com = value; }
        }

        public double Add_farm_area_plan
        {
            get { return add_farm_area_plan; }
            set { add_farm_area_plan = value; }
        }

        public double Add_farm_area_com
        {
            get { return add_farm_area_com; }
            set { add_farm_area_com = value; }
        }

        public double Add_market_plan
        {
            get { return add_market_plan; }
            set { add_market_plan = value; }
        }

        public double Add_market_com
        {
            get { return add_market_com; }
            set { add_market_com = value; }
        }

        public double Kinder_rate_2013
        {
            get { return kinder_rate_2013; }
            set { kinder_rate_2013 = value; }
        }

        public double Kinder_rate_now
        {
            get { return kinder_rate_now; }
            set { kinder_rate_now = value; }
        }

        public double Medical_rate_2013
        {
            get { return medical_rate_2013; }
            set { medical_rate_2013 = value; }
        }

        public double Medical_rate_now
        {
            get { return medical_rate_now; }
            set { medical_rate_now = value; }
        }

        public double Culture_sports_rate_2013
        {
            get { return culture_sports_rate_2013; }
            set { culture_sports_rate_2013 = value; }
        }

        public double Culture_sports_rate_now
        {
            get { return culture_sports_rate_now; }
            set { culture_sports_rate_now = value; }
        }

        public double Old_facilities_rate_2013
        {
            get { return old_facilities_rate_2013; }
            set { old_facilities_rate_2013 = value; }
        }

        public double Old_facilities_rate_now
        {
            get { return old_facilities_rate_now; }
            set { old_facilities_rate_now = value; }
        }

        public double Manage_rate_2013
        {
            get { return manage_rate_2013; }
            set { manage_rate_2013 = value; }
        }

        public double Manage_rate_now
        {
            get { return manage_rate_now; }
            set { manage_rate_now = value; }
        }

        public double Parking_rate_2013
        {
            get { return parking_rate_2013; }
            set { parking_rate_2013 = value; }
        }

        public double Parking_rate_now
        {
            get { return parking_rate_now; }
            set { parking_rate_now = value; }
        }

        public double Farm_rate_2013
        {
            get { return farm_rate_2013; }
            set { farm_rate_2013 = value; }
        }

        public double Farm_rate_now
        {
            get { return farm_rate_now; }
            set { farm_rate_now = value; }
        }

        public double Market_rate_2013
        {
            get { return market_rate_2013; }
            set { market_rate_2013 = value; }
        }

        public double Market_rate_now
        {
            get { return market_rate_now; }
            set { market_rate_now = value; }
        }

        #endregion

        public get_public_service(string province, string county, string community)
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
            //query_message_7();
            //query_message_8();
            //query_message_9();
            query_message_10();
            query_message_11();
            query_message_12();
            query_message_13();
        }

        #region 方法
        /// <summary>
        /// 小区基本信息表 —— 小区编号，最后修改时间
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
        /// 小区教育表
        /// </summary>
        private void query_message_12()
        {
            string sql = "select * from T_community_education where community_id = @id order by statistics_date";
            SqlParameter[] parameter = { new SqlParameter("@id", SqlDbType.VarChar, 50) { Value = community_id } };
            DataSet ds = gt.sql_query(sql, parameter);
            kindergarten_cap_2013 = Convert.ToInt32(ds.Tables[0].Rows[0]["community_kdg_stu_num"]);         //2013年幼儿园学生数
            teaching_area_2013 = Convert.ToDouble(ds.Tables[0].Rows[0]["community_kdg_actv_room_area"]);        //2013年教学面积
            out_play_area_2013 = Convert.ToDouble(ds.Tables[0].Rows[0]["community_kdg_otd_actv_spa_area"]);     //2013年室外活动面积

            string sql2 = "select * from T_community_education where community_id = @id order by statistics_date desc";
            DataSet ds2 = gt.sql_query(sql2, parameter);
            kindergarten_cap_now = Convert.ToInt32(ds.Tables[0].Rows[0]["community_kdg_stu_num"]);         //当前幼儿园学生数
            teaching_area_now = Convert.ToDouble(ds.Tables[0].Rows[0]["community_kdg_actv_room_area"]);        //当前教学面积
            out_play_area_now = Convert.ToDouble(ds.Tables[0].Rows[0]["community_kdg_otd_actv_spa_area"]);     //当前室外活动面积
        }
        /// <summary>
        /// 停车场面积
        /// </summary>
        public void query_message_13()
        {
            string sql = "select community_public_parking_lot_area from T_community_parking_lot where community_id = @id order by statistics_date";
            SqlParameter[] parameter = { new SqlParameter("@id", SqlDbType.VarChar, 50) { Value = community_id } };
            DataSet ds = gt.sql_query(sql, parameter);

            parking_area_2013 = Convert.ToDouble(ds.Tables[0].Rows[0]["community_public_parking_lot_area"]);
            int count = ds.Tables[0].Rows.Count;
            parking_area_now = Convert.ToDouble(ds.Tables[0].Rows[count - 1]["community_public_parking_lot_area"]);
        }
        /// <summary>
        /// 小区医疗表 —— 医疗
        /// </summary>
        private void query_message_2()
        {
            string sql = "select community_clinic_fs, community_clinic_bed_num from T_community_medical where community_id = @id order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);
            clinic_area_2013 = Convert.ToDouble(ds.Tables[0].Rows[0]["community_clinic_fs"]);
            clinic_bed_2013 = Convert.ToInt32(ds.Tables[0].Rows[0]["community_clinic_bed_num"]);
            int count = ds.Tables[0].Rows.Count;
            clinic_area_now = Convert.ToDouble(ds.Tables[0].Rows[count - 1]["community_clinic_fs"]);
            clinic_bed_now = Convert.ToInt32(ds.Tables[0].Rows[count - 1]["community_clinic_bed_num"]);
        }
        /// <summary>
        /// 小区文体表 —— 文体
        /// </summary>
        private void query_message_3()
        {
            string sql = "select community_otd_cul_spo_fac_gfa, community_ind_actv_spa_fs, community_fit_fac_num from T_community_culture_sports where community_id = @id order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);
            out_ground_area_2013 = Convert.ToDouble(ds.Tables[0].Rows[0]["community_otd_cul_spo_fac_gfa"]);
            in_ground_area_2013 = Convert.ToDouble(ds.Tables[0].Rows[0]["community_ind_actv_spa_fs"]);
            fitness_equipment_2013 = Convert.ToInt32(ds.Tables[0].Rows[0]["community_fit_fac_num"]);

            int count = ds.Tables[0].Rows.Count;
            out_ground_area_now = Convert.ToDouble(ds.Tables[0].Rows[count - 1]["community_otd_cul_spo_fac_gfa"]);
            in_ground_area_now = Convert.ToDouble(ds.Tables[0].Rows[count - 1]["community_ind_actv_spa_fs"]);
            fitness_equipment_now = Convert.ToInt32(ds.Tables[0].Rows[count-1]["community_fit_fac_num"]);
        }
        /// <summary>
        /// 社区表 —— 社区服务
        /// </summary>
        private void query_message_4()
        {
            //string sql = "select facilities_for_elders_area, integrated_management_building_area from T_wcommunity where community_name = @name order by statistics_date";
            //SqlParameter[] parameter2 = {
            //                                new SqlParameter("@name", SqlDbType.VarChar, 50){Value = community_name}
            //                            };
            //SqlParameter[] parameter = {
            //                               new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
            //                           };
            //DataSet ds = gt.sql_query(sql, parameter2);
            //old_area_2013 = Convert.ToDouble(ds.Tables[0].Rows[0]["facilities_for_elders_area"]);
            //management_area_2013 = Convert.ToDouble(ds.Tables[0].Rows[0]["integrated_management_building_area"]);

            //int count = ds.Tables[0].Rows.Count;
            //old_area_now = Convert.ToDouble(ds.Tables[0].Rows[count-1]["facilities_for_elders_area"]);
            //management_area_now = Convert.ToDouble(ds.Tables[0].Rows[count-1]["integrated_management_building_area"]);

            string sql = "select community_old_fs, community_comm_serv_cen_fs from T_community_service where community_id = @id order by statistics_date";
            SqlParameter[] parameter = { new SqlParameter("@id", SqlDbType.VarChar, 50) { Value = community_id } };
            DataSet ds = gt.sql_query(sql, parameter);

            old_area_2013 = Convert.ToDouble(ds.Tables[0].Rows[0]["community_old_fs"]);
            management_area_2013 = Convert.ToDouble(ds.Tables[0].Rows[0]["community_comm_serv_cen_fs"]);

            int count = ds.Tables[0].Rows.Count;
            old_area_now = Convert.ToDouble(ds.Tables[0].Rows[count-1]["community_old_fs"]);
            management_area_now = Convert.ToDouble(ds.Tables[0].Rows[count-1]["community_comm_serv_cen_fs"]);
        }
        /// <summary>
        /// 小区商贸表 —— 农贸市场面积, 便民超市面积
        /// </summary>
        private void query_message_5()
        {
            string sql = "select community_farm_produce_fair_fs, community_convinent_market_fs from T_community_commerce where community_id = @id order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);
            farm_area_2013 = Convert.ToDouble(ds.Tables[0].Rows[0]["community_farm_produce_fair_fs"]);
            market_area_2013 = Convert.ToDouble(ds.Tables[0].Rows[0]["community_convinent_market_fs"]);

            int count = ds.Tables[0].Rows.Count;
            farm_area_now = Convert.ToDouble(ds.Tables[0].Rows[count - 1]["community_farm_produce_fair_fs"]);
            market_area_now = Convert.ToDouble(ds.Tables[0].Rows[count - 1]["community_convinent_market_fs"]);
        }
        /// <summary>
        /// 项目实物表 —— 计划、完成
        /// </summary>
        private void query_message_6()
        {
            StringBuilder sql = new StringBuilder("select physical_class_content, summary, june_quantity from T_project_physical ");
            sql.Append("where county_name = @county ");
            sql.Append("and community = @community ");
            sql.Append("and physical_class = @class ");
            //sql.Append("and year = @year ");
            SqlParameter[] parameter = {
                                           new SqlParameter("@county",SqlDbType.VarChar, 50){Value = county_name},
                                           new SqlParameter("@community",SqlDbType.VarChar, 50){Value = community_name},
                                           new SqlParameter("@class", SqlDbType.VarChar, 20){Value = "公共服务设施"}
                                           //new SqlParameter("@year",SqlDbType.Int, 4){Value = last_modify.Year}
                                       };

            DataSet ds = gt.sql_query(sql.ToString(), parameter);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                string str = Convert.ToString(ds.Tables[0].Rows[i]["physical_class_content"]);
                if (str.Equals("新增幼儿园容量(人)"))
                {
                    add_kindergarten_cap_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    add_kindergarten_cap_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("改扩建幼儿园容量(人)"))
                {
                    change_kinder_cap_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    change_kinder_cap_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增教学面积(m2)"))
                {
                    add_teaching_area_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_teaching_area_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增幼儿园活动场地(m2)"))
                {
                    add_kinder_ground_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_kinder_ground_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增卫生室面积(m2)"))
                {
                    add_clinic_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_clinic_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("维修改造卫生室面积(m2)"))
                {
                    repair_clinic_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    repair_clinic_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增卫生室床位数(个)"))
                {
                    add_bed_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    add_bed_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增室外活动场地面积(m2)"))
                {
                    add_out_ground_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_out_ground_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("改造室外活动场地面积(m2)"))
                {
                    repair_out_ground_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    repair_out_ground_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增建设室内活动场所面积(m2)"))
                {
                    add_in_ground_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_in_ground_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增健身器材(套)"))
                {
                    add_fitness_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    add_fitness_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增养老设施面积(m2)"))
                {
                    add_old_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_old_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增社区综合管理用房(m2)"))
                {
                    add_manage_house_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_manage_house_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增停车场面积(m2)"))
                {
                    add_parking_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_parking_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增农贸市场面积(m2)"))
                {
                    add_farm_area_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_farm_area_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("新增便民超市面积(m2)"))
                {
                    add_market_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    add_market_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
            }
        }
        /// <summary>
        /// 社区医疗配置达标率
        /// </summary>
        private void query_message_7()
        {
            string sql = "select community_heal_sta_bed_num from T_community_medical where community_id = @id order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 50){Value = community_id}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);
            double bed = Convert.ToDouble(ds.Tables[0].Rows[0]["community_heal_sta_bed_num"]);
            const double goal = 4.55;
            if (bed / 1000 > goal)
            {
                medical_rate_2013 = 100;
            }
            else
            {
                medical_rate_2013 = bed / 1000 / goal * 100;
            }

            int count = ds.Tables[0].Rows.Count;
            double bed2 = Convert.ToDouble(ds.Tables[0].Rows[count - 1]["community_heal_sta_bed_num"]);
            if (bed2 / 1000 > goal)
            {
                medical_rate_now = 100;
            }
            else
            {
                medical_rate_now = bed2 / 100 / goal * 100;
            }
        }
        /// <summary>
        /// 文体设施达标率
        /// </summary>
        private void query_message_8()
        {
            string sql = "select community_culture_sports_fs from T_community_culture_sports where community_id = @id order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 50){Value = community_id}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);
            double area = Convert.ToDouble(ds.Tables[0].Rows[0]["community_culture_sports_fs"]) / 1000;
            const double goal = 45;
            if (area > goal)
            {
                culture_sports_rate_2013 = 100;
            }
            else
            {
                culture_sports_rate_2013 = area / goal * 100;
            }
            double area2 = Convert.ToDouble(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["community_culture_sports_fs"]);
            if (area2 > goal)
            {
                culture_sports_rate_now = 100;
            }
            else
            {
                culture_sports_rate_now = area2 / goal * 100;
            }
        }
        /// <summary>
        /// 养老设施达标率
        /// </summary>
        private void query_message_9()
        {
            string sql = "select facilities_for_elders_area, integrated_management_building_area from T_wcommunity where community_name = @name order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@name", SqlDbType.VarChar, 50){Value = community_name}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);
            double area = Convert.ToDouble(ds.Tables[0].Rows[0]["facilities_for_elders_area"]) / 1000;
            double manage = Convert.ToDouble(ds.Tables[0].Rows[0]["integrated_management_building_area"]) / 1000;
            const double goal = 96;
            const double goal2 = 59;
            if (area > goal)
            {
                old_facilities_rate_2013 = 100;
            }
            else
            {
                old_facilities_rate_2013 = area / goal * 100;
            }
            if (manage > goal2)
            {
                manage_rate_2013 = 100;
            }
            else
            {
                manage_rate_2013 = manage / goal2 * 100;
            }

            int count = ds.Tables[0].Rows.Count;
            double area2 = Convert.ToDouble(ds.Tables[0].Rows[count - 1]["facilities_for_elders_area"]) / 1000;
            double manage2 = Convert.ToDouble(ds.Tables[0].Rows[count - 1]["integrated_management_building_area"]) / 1000;
            if (area2 > goal)
            {
                old_facilities_rate_now = 100;
            }
            else
            {
                old_facilities_rate_now = area2 / goal * 100;
            }
            if (manage2 > goal2)
            {
                manage_rate_now = 100;
            }
            else
            {
                manage_rate_now = manage2 / goal2 * 100;
            }
        }
        /// <summary>
        /// 停车达标率
        /// </summary>
        private void query_message_10()
        {
            string sql = "select parking_space_num from T_wcommunity where community_name = @name order by statistics_date";
            SqlParameter[] parameter2 = { new SqlParameter("@name", SqlDbType.VarChar, 50) { Value = community_name } };

            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 50){Value = community_id}
                                       };
            DataSet ds = gt.sql_query(sql, parameter2);
            double parking = Convert.ToDouble(ds.Tables[0].Rows[0]["parking_space_num"]);

            string sql2 = "select community_family_num from T_community_population where community_id = @id order by statistics_date";
            DataSet ds2 = gt.sql_query(sql2, parameter);
            double family = Convert.ToDouble(ds2.Tables[0].Rows[0]["community_family_num"]);

            double rate = parking / family;
            const double goal = 10;
            if (rate < goal)
            {
                parking_rate_2013 = rate / goal * 100;
            }
            else
            {
                parking_rate_2013 = 100;
            }

            int count1 = ds.Tables[0].Rows.Count;
            double parking2 = Convert.ToDouble(ds.Tables[0].Rows[count1 - 1]["parking_space_num"]);
            int count2 = ds2.Tables[0].Rows.Count;
            double family2 = Convert.ToDouble(ds2.Tables[0].Rows[count2 -1]["community_family_num"]);
            double rate2 = parking2/family2;
            if(rate>goal){
                parking_rate_now = 100;
            }else {
                parking_rate_now = rate2 / goal * 100;
            }
        }
        /// <summary>
        /// 剩下的
        /// </summary>
        private void query_message_11()
        {
            string sql = "select * from T_wcommunity where community_name = @name order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@name", SqlDbType.VarChar, 50){Value = community_name}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);
            //菜市场配置达标率
            double market = Convert.ToDouble(ds.Tables[0].Rows[0]["vegetable_market_area"]) / 1000;
            const double goal = 50;
            if (market > goal)
            {
                farm_rate_2013 = 100;
            }
            else
            {
                farm_rate_2013 = market / goal * 100;
            }
            int count = ds.Tables[0].Rows.Count;
            double market2 = Convert.ToDouble(ds.Tables[0].Rows[count-1]["vegetable_market_area"]) / 1000;
            if (market2 > goal)
            {
                farm_rate_now = 100;
            }
            else
            {
                farm_rate_now = market2 / goal * 100;
            }
            //便民超市配置达标率
            double store = Convert.ToDouble(ds.Tables[0].Rows[0]["convenience_stores_area"]) / 1000;
            const double goal2 = 100;
            if (store > goal2)
            {
                market_rate_2013 = 100;
            }
            else
            {
                market_rate_2013 = store / goal2 * 100;
            }
            double store2 = Convert.ToDouble(ds.Tables[0].Rows[count - 1]["convenience_stores_area"]) / 1000;
            if (store2 > goal2)
            {
                market_rate_now = 100;
            }
            else
            {
                market_rate_now = store2 / goal2 * 100;
            }

            //幼儿园配置达标率
            double kingder = Convert.ToDouble(ds.Tables[0].Rows[0]["kindergarten_capacity"]) / 1000;
            const double goal3 = 12;
            if (kingder > goal3)
            {
                kinder_rate_2013 = 100;
            }
            else
            {
                kinder_rate_2013 = kingder / goal3 * 100;
            }

            double kingder2 = Convert.ToDouble(ds.Tables[0].Rows[count - 1]["kindergarten_capacity"]) / 1000;
            if (kingder2 > goal3)
            {
                kinder_rate_now = 100;
            }
            else
            {
                kinder_rate_now = kingder2 / goal3 * 100;
            }

            //医疗设施配置达标率
            double medical = Convert.ToDouble(ds.Tables[0].Rows[0]["medical_bed_num"]) / 1000;
            double goal4 = 4.55;
            if (medical > goal4)
                medical_rate_2013 = 100;
            else
                medical_rate_2013 = medical / goal4 * 100;

            double medical2 = Convert.ToDouble(ds.Tables[0].Rows[count - 1]["medical_bed_num"]) / 1000;
            if (medical2 > goal4)
                medical_rate_now = 100;
            else
                medical_rate_now = medical2 / goal4 * 100;

            //文化设施配置达标率
            double culture = Convert.ToDouble(ds.Tables[0].Rows[0]["culture_fitness_facility_area"]) / 1000;
            double goal5 = 45;
            if (culture > goal5)
                culture_sports_rate_2013 = 100;
            else
                culture_sports_rate_2013 = culture / goal5 * 100;

            double culture2 = Convert.ToDouble(ds.Tables[0].Rows[count - 1]["culture_fitness_facility_area"]) / 1000;
            if (culture2 > goal5)
                culture_sports_rate_now = 100;
            else
                culture_sports_rate_now = culture2 / goal5 * 100;

            //养老设施配置达标率
            double old = Convert.ToDouble(ds.Tables[0].Rows[0]["facilities_for_elders_area"])/1000;
            double goal6 = 96;
            if (old > goal6)
                old_facilities_rate_2013 = 100;
            else
                old_facilities_rate_2013 = old / goal6 * 100;

            double old2 = Convert.ToDouble(ds.Tables[0].Rows[count-1]["facilities_for_elders_area"]) / 1000;
            if (old2 > goal6)
                old_facilities_rate_now = 100;
            else
                old_facilities_rate_now = old2 / goal6 * 100;

            //综合管理用房配置达标率
            double manage = Convert.ToDouble(ds.Tables[0].Rows[0]["integrated_management_building_area"]) / 100;
            double goal7 = 59;
            if (manage > goal7)
                manage_rate_2013 = 100;
            else
                manage_rate_2013 = manage / goal7 * 100;

            double manage2 = Convert.ToDouble(ds.Tables[0].Rows[count - 1]["integrated_management_building_area"]) / 1000;
            if (manage2 > goal7)
                manage_rate_now = 100;
            else
                manage_rate_now = manage2 / goal7 * 100;

           
        }

        #endregion
    }
}
