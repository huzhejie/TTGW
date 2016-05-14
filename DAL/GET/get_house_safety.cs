using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TTG.DAL.GET
{
    public class get_house_safety
    {
        #region 字段
        private get_tools gt = new get_tools();
        private int year = DateTime.Now.Year - 1;       //问题表更新的最新年份
        private string province,                //省市名
            county,                             //区县名
            community;                          //小区名
        private DateTime last_modify;           //最后修改时间
        private string community_id;            //小区编号
        private int system_building_2013,           //2013年小区统建房栋数
            system_building_now;                    //当前小区统建房栋数
        private double crack_area_2013,             //2013年轻微变形开裂面积
            crack_area_now,                         //当前轻微变形开裂面积
            foundation_down_2013,                   //2013年房屋地基沉降面积
            foundation_down_now,                    //当前房屋地基沉降面积
            dangerous_2013,                    //2013年危房面积
            dangerous_now,                      //当前危房面积
            leakage_2013,                   //2013年屋顶漏水面积
            leakage_now,                //当前屋顶漏水面积
            tile_fall_2013,             //2013年瓷砖脱落面积
            tile_fall_now;                  //当前瓷砖陀螺面积
        private int slope_ndeal_2013,            //2013年边坡未治理幢数
            slope_ndeal_now,            //当前边坡未治理幢数
            struct_safe_num_plan,           //计划结构安全幢数
            struct_safe_num_com,                //完成结构安全幢数
            leak_proof_num_plan,            //计划屋顶防漏幢数
            leak_proof_num_com,             //完成屋顶防漏幢数
            repair_wall_num_plan,           //计划外墙修复幢数
            repair_wall_num_com,            //完成外墙修复幢数
            slope_people_num_plan,          //计划边坡未治理设计房屋居民人数
            slope_people_num_com;           //完成边坡未治理涉及房屋居民人数
        private double struct_safe_area_plan,           //计划结构安全面积
            struct_safe_area_com,           //完成结构安全面积
            leak_proof_area_plan,           //计划屋顶防漏面积
            leak_proof_area_com,            //完成屋顶防漏面积
            repair_wall_area_plan,          //计划外墙修复面积
            repair_wall_area_com,           //完成外墙修复面积
            slope_deal_plan,                //计划边坡治理面积
            slope_deal_com,                 //完成边坡治理面积
            struct_safe_rate_2013,          //2013年结构完好率
            struct_safe_rate_now,           //当前结构完好率
            roof_com_rate_2013,             //2013年屋顶完好率
            roof_com_rate_now,              //当前屋顶完好率
            wall_com_rate_2013,          //2013年房屋外墙完好率
            wall_com_rate_now,          //当前房屋外墙完好率
            slope_stable_rate_2013,         //2013年边坡安全稳定程度
            slope_stable_rate_now;          //当前边坡安全稳定程度

        #endregion 

        #region 属性

        public DateTime Last_modify
        {
            get { return last_modify; }
            set { last_modify = value; }
        }

        public string Community_id
        {
            get { return community_id; }
            set { community_id = value; }
        }

        public int System_building_2013
        {
            get { return system_building_2013; }
            set { system_building_2013 = value; }
        }

        public int System_building_now
        {
            get { return system_building_now; }
            set { system_building_now = value; }
        }

        public double Crack_area_2013
        {
            get { return crack_area_2013; }
            set { crack_area_2013 = value; }
        }

        public double Crack_area_now
        {
            get { return crack_area_now; }
            set { crack_area_now = value; }
        }

        public double Foundation_down_2013
        {
            get { return foundation_down_2013; }
            set { foundation_down_2013 = value; }
        }

        public double Foundation_down_now
        {
            get { return foundation_down_now; }
            set { foundation_down_now = value; }
        }

        public double Dangerous_2013
        {
            get { return dangerous_2013; }
            set { dangerous_2013 = value; }
        }

        public double Dangerous_now
        {
            get { return dangerous_now; }
            set { dangerous_now = value; }
        }

        public double Leakage_2013
        {
            get { return leakage_2013; }
            set { leakage_2013 = value; }
        }

        public double Leakage_now
        {
            get { return leakage_now; }
            set { leakage_now = value; }
        }

        public double Tile_fall_2013
        {
            get { return tile_fall_2013; }
            set { tile_fall_2013 = value; }
        }

        public double Tile_fall_now
        {
            get { return tile_fall_now; }
            set { tile_fall_now = value; }
        }

        public int Slope_ndeal_2013
        {
            get { return slope_ndeal_2013; }
            set { slope_ndeal_2013 = value; }
        }

        public int Slope_ndeal_now
        {
            get { return slope_ndeal_now; }
            set { slope_ndeal_now = value; }
        }

        public int Struct_safe_num_plan
        {
            get { return struct_safe_num_plan; }
            set { struct_safe_num_plan = value; }
        }

        public int Struct_safe_num_com
        {
            get { return struct_safe_num_com; }
            set { struct_safe_num_com = value; }
        }

        public int Leak_proof_num_plan
        {
            get { return leak_proof_num_plan; }
            set { leak_proof_num_plan = value; }
        }

        public int Leak_proof_num_com
        {
            get { return leak_proof_num_com; }
            set { leak_proof_num_com = value; }
        }

        public int Repair_wall_num_plan
        {
            get { return repair_wall_num_plan; }
            set { repair_wall_num_plan = value; }
        }

        public int Repair_wall_num_com
        {
            get { return repair_wall_num_com; }
            set { repair_wall_num_com = value; }
        }

        public int Slope_people_num_plan
        {
            get { return slope_people_num_plan; }
            set { slope_people_num_plan = value; }
        }

        public int Slope_people_num_com
        {
            get { return slope_people_num_com; }
            set { slope_people_num_com = value; }
        }

        public double Struct_safe_area_plan
        {
            get { return struct_safe_area_plan; }
            set { struct_safe_area_plan = value; }
        }

        public double Struct_safe_area_com
        {
            get { return struct_safe_area_com; }
            set { struct_safe_area_com = value; }
        }

        public double Leak_proof_area_plan
        {
            get { return leak_proof_area_plan; }
            set { leak_proof_area_plan = value; }
        }

        public double Leak_proof_area_com
        {
            get { return leak_proof_area_com; }
            set { leak_proof_area_com = value; }
        }

        public double Repair_wall_area_plan
        {
            get { return repair_wall_area_plan; }
            set { repair_wall_area_plan = value; }
        }

        public double Repair_wall_area_com
        {
            get { return repair_wall_area_com; }
            set { repair_wall_area_com = value; }
        }

        public double Slope_deal_plan
        {
            get { return slope_deal_plan; }
            set { slope_deal_plan = value; }
        }

        public double Slope_deal_com
        {
            get { return slope_deal_com; }
            set { slope_deal_com = value; }
        }

        public double Struct_safe_rate_2013
        {
            get { return struct_safe_rate_2013; }
            set { struct_safe_rate_2013 = value; }
        }

        public double Struct_safe_rate_now
        {
            get { return struct_safe_rate_now; }
            set { struct_safe_rate_now = value; }
        }

        public double Roof_com_rate_2013
        {
            get { return roof_com_rate_2013; }
            set { roof_com_rate_2013 = value; }
        }

        public double Roof_com_rate_now
        {
            get { return roof_com_rate_now; }
            set { roof_com_rate_now = value; }
        }

        public double Wall_com_rate_2013
        {
            get { return wall_com_rate_2013; }
            set { wall_com_rate_2013 = value; }
        }

        public double Wall_com_rate_now
        {
            get { return wall_com_rate_now; }
            set { wall_com_rate_now = value; }
        }

        public double Slope_stable_rate_2013
        {
            get { return slope_stable_rate_2013; }
            set { slope_stable_rate_2013 = value; }
        }

        public double Slope_stable_rate_now
        {
            get { return slope_stable_rate_now; }
            set { slope_stable_rate_now = value; }
        }

        #endregion

        public get_house_safety(string province, string county, string community)
        {
            this.community = community;
            this.county = county;
            this.province = province;
            query_message_1();
            query_message_2();
            query_message_3();
            query_message_4();
            query_message_5();
        }

        #region 方法
        /// <summary>
        /// 小区基本信息表—— 小区编号，最后修改时间
        /// </summary>
        private void query_message_1()
        {
            string sql = "select community_id, statistics_date from T_Community_Base where community_province = @province and community_county like @county and community_name = @community order by statistics_date desc";
            SqlParameter[] parameters = {
                                            new SqlParameter("@province", SqlDbType.VarChar, 50){Value = province},
                                            new SqlParameter("@county", SqlDbType.VarChar, 50){Value = "%"+county+"%"},
                                            new SqlParameter("@community",SqlDbType.VarChar,50){Value = community}
                                        };
            DataRow row = gt.get_content(sql, parameters);
            community_id = Convert.ToString(row["community_id"]);
            last_modify = Convert.ToDateTime(row["statistics_date"]);
        }
        /// <summary>
        /// 小区统建房表——小区统建房幢数2013、now
        /// </summary>
        private void query_message_2()
        {
            string sql = "select community_council_buil_num from T_community_concil_house where community_id = @id order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id",SqlDbType.VarChar,20){Value = community_id}
                                       };
            DataSet set = gt.sql_query(sql, parameter);
            system_building_2013 = Convert.ToInt32(set.Tables[0].Rows[0]["community_council_buil_num"]);
            int num = set.Tables[0].Rows.Count;
            system_building_now = Convert.ToInt32(set.Tables[0].Rows[num - 1]["community_council_buil_num"]);
        }
        /// <summary>
        /// 小区统建房问题表——轻微变形开裂面积、房屋地基沉降面积、鉴定为危房面积、屋顶渗水面积、外墙瓷砖剥落面积、边坡未治理幢数
        /// </summary>
        private void query_message_3()
        {
            string sql = "select community_slight_deform_split_area, community_house_foun_setm_area, community_is_decrepit_house_area, community_roof_seepage_house_area, community_exw_ct_shedding_house_area, community_slope_not_govern_house_num from T_community_council_building_problem where community_id = @id and complete_year = @year";
            SqlParameter[] parameter ={
                                          new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                          new SqlParameter("@year",SqlDbType.Int,4){Value = 2013}
                                      };
            DataRow row = gt.get_content(sql, parameter);
            crack_area_2013 = Convert.ToDouble(row["community_slight_deform_split_area"]);
            foundation_down_2013 = Convert.ToDouble(row["community_house_foun_setm_area"]);
            dangerous_2013 = Convert.ToDouble(row["community_is_decrepit_house_area"]);
            leakage_2013 = Convert.ToDouble(row["community_roof_seepage_house_area"]);
            tile_fall_2013 = Convert.ToDouble(row["community_exw_ct_shedding_house_area"]);
            slope_ndeal_2013 = Convert.ToInt32(row["community_slope_not_govern_house_num"]);

            //将本底剩余、新增剩余、新增相加才能得到当前的情况。
            int year = last_modify.Year;
            sql = "select community_slight_deform_split_area, community_house_foun_setm_area, community_is_decrepit_house_area, community_roof_seepage_house_area, community_exw_ct_shedding_house_area, community_slope_not_govern_house_num from T_community_council_building_problem where community_id = @id and complete_year = @year" +
                " and (community_fill_type = @type1 or community_fill_type = @type2 or community_fill_type = @type3)";
            //parameter[1].Value = year;
            SqlParameter[] parameters = {
                                               new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                               new SqlParameter("@year",SqlDbType.Int, 4){Value = year},
                                               new SqlParameter("@type1",SqlDbType.VarChar,20){Value="本底剩余"},
                                               new SqlParameter("@type2",SqlDbType.VarChar,20){Value = "新增剩余"},
                                               new SqlParameter("@type3",SqlDbType.VarChar,20){Value = "新增"}
                                           };
            DataSet ds = gt.sql_query(sql, parameters);
            int count = ds.Tables[0].Rows.Count;            //数据有几条
            for (int i = 0; i < count; i++)
            {
                crack_area_now += Convert.ToDouble(row["community_slight_deform_split_area"]);
                foundation_down_now += Convert.ToDouble(row["community_house_foun_setm_area"]);
                dangerous_now += Convert.ToDouble(row["community_is_decrepit_house_area"]);
                leakage_now += Convert.ToDouble(row["community_roof_seepage_house_area"]);
                tile_fall_now += Convert.ToDouble(row["community_exw_ct_shedding_house_area"]);
                slope_ndeal_now += Convert.ToInt32(row["community_slope_not_govern_house_num"]);
            }
        }
        /// <summary>
        /// 项目实物表——计划、完成
        /// </summary>
        private void query_message_4()
        {
            StringBuilder sql = new StringBuilder("select physical_class_content, summary, june_quantity from T_project_physical ");
            sql.Append("where county_name = @county ");
            sql.Append("and community = @community ");
            sql.Append("and physical_class = @class ");
            //sql.Append("and year = @year ");
            SqlParameter[] parameter = {
                                           new SqlParameter("@county",SqlDbType.VarChar, 50){Value = county},
                                           new SqlParameter("@community",SqlDbType.VarChar, 50){Value = community},
                                           new SqlParameter("@class", SqlDbType.VarChar, 20){Value = "统建房居住安全"}
                                           //new SqlParameter("@year",SqlDbType.Int, 4){Value = 2015}
                                       };

            DataSet ds = gt.sql_query(sql.ToString(), parameter);
            string[] content = { "结构安全栋数(栋)", "结构安全面积(m2)", "屋顶防漏栋数(栋)", "屋顶防漏面积(m2)", "外墙修复栋数(栋)", "外墙修复面积(m2)", "边坡治理面积(m2)", "边坡治理涉及房屋居民人数(人)" };
            const int num = 8;
            double[] finished = new double[num], plan = new double[num];
            for (int i = 0; i < content.Length; i++)
            {
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    if (Convert.ToString(ds.Tables[0].Rows[j]["physical_class_content"]).Equals(content[i]))
                    {
                        finished[i] += Convert.ToDouble(ds.Tables[0].Rows[j]["june_quantity"]);
                        plan[i] += Convert.ToDouble(ds.Tables[0].Rows[j]["summary"]);
                        break;
                    }
                }
            }
            struct_safe_num_com = Convert.ToInt32(finished[0]);
            struct_safe_num_plan = Convert.ToInt32(plan[0]);
            struct_safe_area_com = finished[1];
            struct_safe_area_plan = plan[1];
            leak_proof_num_com = Convert.ToInt32(finished[2]);
            leak_proof_num_plan = Convert.ToInt32(plan[2]);
            leak_proof_area_com = finished[3];
            leak_proof_area_plan = plan[3];
            repair_wall_num_com = Convert.ToInt32(finished[4]);
            repair_wall_num_plan = Convert.ToInt32(plan[4]);
            repair_wall_area_com = finished[5];
            repair_wall_area_plan = plan[5];
            slope_deal_com = finished[6];
            slope_deal_plan = plan[6];
            slope_people_num_com = Convert.ToInt32(finished[7]);
            slope_people_num_plan = Convert.ToInt32(plan[7]);
        }
        /// <summary>
        /// 小区统建房问题表 —— 结构安全率、屋顶完好率、外墙完好率、边坡完好程度
        /// </summary>
        private void query_message_5()
        {
            if (system_building_2013 == 0)
            {
                struct_safe_rate_2013 = 0;
                roof_com_rate_2013 = 0;
                wall_com_rate_2013 = 0;
                slope_stable_rate_2013 = 0;
            }
            else
            {
                StringBuilder sql = new StringBuilder("select top 1 community_slight_deform_split_num, community_house_foun_setm_num, community_is_decrepit_house_num, community_roof_seepage_house_num, community_exw_ct_shedding_house_num from T_community_council_building_problem ");
                sql.Append("where community_id = @id ");
                sql.Append("and complete_year = @year ");

                SqlParameter[] parameter = {
                                               new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                               new SqlParameter("@year",SqlDbType.Int, 4){Value = 2013}
                                           };
                DataRow row = gt.get_content(sql.ToString(),parameter);
                struct_safe_rate_2013 = (1 - (Convert.ToDouble(row["community_slight_deform_split_num"]) +
                    Convert.ToDouble(row["community_house_foun_setm_num"]) +
                    Convert.ToDouble(row["community_is_decrepit_house_num"])) / system_building_2013) * 100;

                roof_com_rate_2013 = (1 - Convert.ToDouble(row["community_roof_seepage_house_num"]) / system_building_2013) * 100;

                wall_com_rate_2013 = (1 - Convert.ToDouble(row["community_exw_ct_shedding_house_num"]) / system_building_2013) * 100;

                slope_stable_rate_2013 = (1 - slope_ndeal_2013 / system_building_2013) * 100;
            }

            if (system_building_now == 0)
            {
                struct_safe_rate_now = 0;
                roof_com_rate_now = 0;
                wall_com_rate_now = 0;
                slope_stable_rate_now = 0;
            }
            else
            {
                //当前年份的本底剩余，新增剩余，新增相加才能得到当年的现状
                StringBuilder sql = new StringBuilder("select community_slight_deform_split_num, community_house_foun_setm_num, community_is_decrepit_house_num, community_roof_seepage_house_num, community_exw_ct_shedding_house_num from T_community_council_building_problem ");
                sql.Append("where community_id = @id ");
                sql.Append("and complete_year = @year ");
                sql.Append("and (community_fill_type = @type1 or community_fill_type = @type2 or community_fill_type = @type3)");
                SqlParameter[] parameter = {
                                               new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                               new SqlParameter("@year",SqlDbType.Int, 4){Value = last_modify.Year},
                                               new SqlParameter("@type1",SqlDbType.VarChar,20){Value="本底剩余"},
                                               new SqlParameter("@type2",SqlDbType.VarChar,20){Value = "新增剩余"},
                                               new SqlParameter("@type3",SqlDbType.VarChar,20){Value = "新增"}
                                           };
                DataSet ds = gt.sql_query(sql.ToString(), parameter);

                int count = ds.Tables[0].Rows.Count;        //行数
                double num1 = 0, num2 = 0, num3 = 0;        //变形开裂房屋数目，地基沉降房屋数目，危房幢数
                double num4 = 0, num5 = 0;        //屋顶渗水房屋数目，外墙损坏房屋数目，边坡未治理房屋数目
                for (int i = 0; i < count; i++)
                {
                    num1 += Convert.ToDouble(ds.Tables[0].Rows[i]["community_slight_deform_split_num"]);
                    num2 += Convert.ToDouble(ds.Tables[0].Rows[i]["community_house_foun_setm_num"]);
                    num3 += Convert.ToDouble(ds.Tables[0].Rows[i]["community_is_decrepit_house_num"]);
                    num4 += Convert.ToDouble(ds.Tables[0].Rows[i]["community_roof_seepage_house_num"]);
                    num5 += Convert.ToDouble(ds.Tables[0].Rows[i]["community_exw_ct_shedding_house_num"]);
                }

                struct_safe_rate_now = (1 - (num1 + num2 + num3) / system_building_now) * 100;
                roof_com_rate_now = (1 - num4 / system_building_now) * 100;
                wall_com_rate_now = (1 - num5 / system_building_now) * 100;
                slope_stable_rate_now = (1 - slope_ndeal_now / system_building_now) * 100;
            }
        }
        #endregion
    }
}
