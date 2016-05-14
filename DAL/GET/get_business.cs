using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TTG.DAL.GET
{
    public class get_business
    {
        #region 字段
        private get_tools gt = new get_tools();
        private string province_name, county_name, community_name, community_id;
        private DateTime last_modify;
        private int facade_num_2013, facade_num_now,        //小区门面数
            rent_facade_2013, rent_facade_now;              //出租经营门面数
        private double average_rent_2013, average_rent_now;     //门面平均出租租金
        private string block_2013, block_now = "",                   //街区风貌较差
            professional_2013, professional_now="";                //缺乏专业市场
        private int change_facade_plan, change_facade_com,      //改造门面数量
            business_num_plan, business_num_com;                //涉及商户数量
        private double change_facade_area_plan, change_facade_area_com,     //改造门面面积
            change_block_plan, change_block_com,                    //改造街区长度
            change_out_plan, change_out_com,            //改造外立面
            change_market_plan, change_market_com;          //建设市场面积
        private double facade_use_rate_2013, facade_use_rate_now,       //门面利用率
            rent_level_2013, rent_level_now;                //门面利用率

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

        public int Facade_num_2013
        {
            get { return facade_num_2013; }
            set { facade_num_2013 = value; }
        }

        public int Facade_num_now
        {
            get { return facade_num_now; }
            set { facade_num_now = value; }
        }

        public int Rent_facade_2013
        {
            get { return rent_facade_2013; }
            set { rent_facade_2013 = value; }
        }

        public int Rent_facade_now
        {
            get { return rent_facade_now; }
            set { rent_facade_now = value; }
        }

        public double Average_rent_2013
        {
            get { return average_rent_2013; }
            set { average_rent_2013 = value; }
        }

        public double Average_rent_now
        {
            get { return average_rent_now; }
            set { average_rent_now = value; }
        }

        public string Block_2013
        {
            get { return block_2013; }
            set { block_2013 = value; }
        }

        public string Block_now
        {
            get { return block_now; }
            set { block_now = value; }
        }

        public string Professional_2013
        {
            get { return professional_2013; }
            set { professional_2013 = value; }
        }

        public string Professional_now
        {
            get { return professional_now; }
            set { professional_now = value; }
        }

        public int Change_facade_plan
        {
            get { return change_facade_plan; }
            set { change_facade_plan = value; }
        }

        public int Change_facade_com
        {
            get { return change_facade_com; }
            set { change_facade_com = value; }
        }

        public int Business_num_plan
        {
            get { return business_num_plan; }
            set { business_num_plan = value; }
        }

        public int Business_num_com
        {
            get { return business_num_com; }
            set { business_num_com = value; }
        }

        public double Change_facade_area_plan
        {
            get { return change_facade_area_plan; }
            set { change_facade_area_plan = value; }
        }

        public double Change_facade_area_com
        {
            get { return change_facade_area_com; }
            set { change_facade_area_com = value; }
        }

        public double Change_block_plan
        {
            get { return change_block_plan; }
            set { change_block_plan = value; }
        }

        public double Change_block_com
        {
            get { return change_block_com; }
            set { change_block_com = value; }
        }

        public double Change_out_plan
        {
            get { return change_out_plan; }
            set { change_out_plan = value; }
        }

        public double Change_out_com
        {
            get { return change_out_com; }
            set { change_out_com = value; }
        }

        public double Change_market_plan
        {
            get { return change_market_plan; }
            set { change_market_plan = value; }
        }

        public double Change_market_com
        {
            get { return change_market_com; }
            set { change_market_com = value; }
        }

        public double Facade_use_rate_2013
        {
            get { return facade_use_rate_2013; }
            set { facade_use_rate_2013 = value; }
        }

        public double Facade_use_rate_now
        {
            get { return facade_use_rate_now; }
            set { facade_use_rate_now = value; }
        }

        public double Rent_level_2013
        {
            get { return rent_level_2013; }
            set { rent_level_2013 = value; }
        }

        public double Rent_level_now
        {
            get { return rent_level_now; }
            set { rent_level_now = value; }
        }

        #endregion

        public get_business(string province, string county, string community)
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
        /// 小区门面表 —— 
        /// </summary>
        private void query_message_2()
        {
            string sql = "select community_shop_front_num, community_immigrant_rent_out_shop_front_num, community_average_rent_of_shop_front from T_community_shop_front where community_id = @id order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);
            facade_num_2013 = Convert.ToInt32(ds.Tables[0].Rows[0]["community_shop_front_num"]);
            rent_facade_2013 = Convert.ToInt32(ds.Tables[0].Rows[0]["community_immigrant_rent_out_shop_front_num"]);
            average_rent_2013 = Convert.ToDouble(ds.Tables[0].Rows[0]["community_average_rent_of_shop_front"]);

            int count = ds.Tables[0].Rows.Count;
            facade_num_now = Convert.ToInt32(ds.Tables[0].Rows[count-1]["community_shop_front_num"]);
            rent_facade_now = Convert.ToInt32(ds.Tables[0].Rows[count-1]["community_immigrant_rent_out_shop_front_num"]);
            average_rent_now = Convert.ToDouble(ds.Tables[0].Rows[count-1]["community_average_rent_of_shop_front"]);
        }
        /// <summary>
        /// 小区商气人气表
        /// </summary>
        private void query_message_3()
        {
            StringBuilder sb = new StringBuilder("select community_block_bad, community_lack_prof_market from T_community_business_pop_problem where ");
            sb.Append("community_id = @id and complete_year = @year ");
            SqlParameter[] parameter = {
                                         new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                         new SqlParameter("@year", SqlDbType.Int, 4){Value = 2013}
                                     };
            DataRow row = gt.get_content(sb.ToString(), parameter);
            block_2013 = Convert.ToString(row["community_block_bad"]);
            professional_2013 = Convert.ToString(row["community_lack_prof_market"]);

            sb = new StringBuilder("select community_block_bad, community_lack_prof_market from T_community_business_pop_problem where ");
            sb.Append("community_id = @id and complete_year = @year ");
            sb.Append("and (community_fill_type = @type1 or community_fill_type = @type2 or community_fill_type = @type3)");

            SqlParameter[] parameters = {
                                            new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id},
                                           new SqlParameter("@year", SqlDbType.Int, 4){Value = last_modify.Year},
                                           new SqlParameter("@type1",SqlDbType.VarChar,20){Value = "本底剩余"},
                                           new SqlParameter("@type2", SqlDbType.VarChar,20){Value = "新增剩余"},
                                           new SqlParameter("@type3",SqlDbType.VarChar,20){Value = "新增"}
                                        };
            DataSet ds = gt.sql_query(sb.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                block_now = Convert.ToString(ds.Tables[0].Rows[0]["community_block_bad"]);
                professional_now = Convert.ToString(ds.Tables[0].Rows[0]["community_lack_prof_market"]);
            }
        }
        /// <summary>
        /// 小区项目实物表 —— 计划、完成
        /// </summary>
        private void query_message_4()
        {
            StringBuilder sql = new StringBuilder("select physical_class_content, summary, june_quantity from T_project_physical ");
            sql.Append("where county_name = @county ");
            sql.Append("and community = @community ");
            sql.Append("and physical_class = @class ");
            //sql.Append("and year = @year ");
            SqlParameter[] parameter = {
                                           new SqlParameter("@county",SqlDbType.VarChar, 50){Value = county_name},
                                           new SqlParameter("@community",SqlDbType.VarChar, 50){Value = community_name},
                                           new SqlParameter("@class", SqlDbType.VarChar, 20){Value = "就业与创业扶持"}
                                           //new SqlParameter("@year",SqlDbType.Int, 4){Value = last_modify.Year}
                                       };

            DataSet ds = gt.sql_query(sql.ToString(), parameter);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                string str = Convert.ToString(ds.Tables[0].Rows[i]["physical_class_content"]);
                if (str.Equals("改造门面数量(个)"))
                {
                    change_facade_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    change_facade_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("改造门面面积(m2)"))
                {
                    change_facade_area_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    change_facade_area_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("改造街区长度(km)"))
                {
                    change_block_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    change_block_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("改造外立面(m2)"))
                {
                    change_out_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    change_out_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("建设市场面积(m2)"))
                {
                    change_market_plan += Convert.ToDouble(ds.Tables[0].Rows[i]["summary"]);
                    change_market_com += Convert.ToDouble(ds.Tables[0].Rows[i]["june_quantity"]);
                }
                else if (str.Equals("涉及商户数量(个)"))
                {
                    business_num_plan += Convert.ToInt32(ds.Tables[0].Rows[i]["summary"]);
                    business_num_com += Convert.ToInt32(ds.Tables[0].Rows[i]["june_quantity"]);
                }
            }
        }
        /// <summary>
        /// 门面利用率
        /// </summary>
        private void query_message_5()
        {
            if (facade_num_2013 < 50)
            {
                facade_use_rate_2013 = 0;
            }
            else
            {
                facade_use_rate_2013 = rent_facade_2013 / facade_num_2013 * 100;
            }

            if (facade_num_now < 50)
            {
                facade_use_rate_now = 0;
            }
            else
            {
                facade_use_rate_now = rent_facade_now / facade_num_now * 100;
            }
        }
        /// <summary>
        /// 门面租金水平
        /// </summary>
        private void query_message_6()
        {
            string sql = "select county_average_rent from T_community_shop_front where community_id = @id order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 20){Value = community_id}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);
            double rent = Convert.ToDouble(ds.Tables[0].Rows[0]["county_average_rent"]);        //区县平均租金水平
            if (facade_num_2013 < 50)
            {
                rent_level_2013 = 0;
            }
            else
            {
                if (average_rent_2013 > rent)
                {
                    rent_level_2013 = 100;
                }
                else
                {
                    rent_level_2013 = average_rent_2013 / rent * 100;
                }
            }

            int count = ds.Tables[0].Rows.Count;
            rent = Convert.ToDouble(ds.Tables[0].Rows[count-1]["county_average_rent"]);
            if (facade_num_now < 50)
            {
                rent_level_now = 0;
            }
            else
            {
                if (average_rent_now > rent)
                {
                    rent_level_now = 100;
                }
                else
                {
                    rent_level_now = average_rent_now / rent * 100;
                }
            }
        }

        #endregion
    }
}
