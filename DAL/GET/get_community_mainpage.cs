using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TTG.DAL.GET
{
    //小区主页面
    public class get_community_mainpage
    {
        #region 字段
        private string position_msg;            //异常用字符串： 位置信息
        private string error1 = "Error 01: Can't find this community.\n";    //异常用字符串： 无法找到该小区
        private string error2 = "Error 02: can't find this field.\n";        //异常用字符串： 无法找到该字段

        private get_tools gt = new get_tools();
        private string province,                //省市名
            county,                             //区县名
            community;                          //小区名
        private DateTime last_modify;           //最后修改该日期
        private string community_id;            //小区编号
        private string community_type;          //小区类型
        private int construct_year;             //建设年份
        private int reg_family_num,         //居民户籍人口户数
            reg_people_num,                 //居民户籍人口人数
            immigrant_family_num,           //移民人口户数
            immigrant_people_num;           //移民人口人数
        private double construction_area,           //建筑面积
            floor_area;                             //占地面积
        private double average_house_area;          //人均住房面积
        private double plot_ratio;                  //容积率           
        private double green_rate;                  //绿地率
        private int parking_lot;                    //停车位
        private int facade;                         //门面数
        private double[] facade_use_rate = new double[2];           //门面使用率
        private double[] employment_rate = new double[2];           //劳动力就业率
        private double[] disposable_income = new double[2];             //人均可支配收入
        private double[] average_rent = new double[2];              //房屋平均租金水平
        private string[] time = { "2013/1/1", "2014/1/1" };

     
        private double[] facade_county = new double[2], employment_county = new double[2],
            disposable_county = new double[2], average_county = new double[2];

       
        private double poor_rate;                   //低保人口比例
        //private double plan_total_inves,           //累计计划投资
        //    complete_total_inves,                  //累计完成投资
        //    complete_rate,                              //投资完成比率
        //    plan_total_special_inves,                    //累计专项资金计划
        //    complete_total_special_inves,                //累计专项资金完成
        //    special_complete_rete;                      //专项资金完成比率
        //private double plan_special_inves,                  //计划投资——专项投资
        //    plan_counter_inves,                             //计划投资——对口支援投资
        //    plan_other_inves,                               //计划投资——其他投资
        //    com_special_inves,                              //完成投资——专项投资
        //    com_counter_inves,                              //完成投资——对口支援投资
        //    com_other_inves;                                //完成投资——其他投资
        private double plan_house_safe,                     //计划投资——统建房安全
            plan_base_fac,                           //计划投资——基础设施
            plan_envir_pro,                         //计划投资——环保设施
            plan_public_fac,                        //计划投资——公共设施
            plan_busin,                             //计划投资——营商环境
            com_house_safe,                         //完成投资——统建房安全
            com_base_fac,                           //完成投资——基础设施
            com_envir_pro,                          //完成投资——环保设施
            com_public_fac,                         //完成投资——公共设施
            com_busin;                              //完成投资——营商环境
        private double help_figure,                 //小区帮扶指数
            develop_figure;                         //小区发展指数
        private string address;                     //小区地址
        private string mana_charge_name,                //小区管理负责人姓名
            mana_charge_phone,                      //小区管理负责人电话
            mana_contact_phone,                     //小区管理联系人电话
            moni_charge_name,                       //综合监测负责人姓名
            moni_charge_phone,                      //综合监测负责人电话
            moni_contact_phone;                     //综合监测联系人电话

        #region 新增字段
        private string position_advantage,              //小区区位特色
            main_problem_solution;                      //小区存在的主要问题及解决程度描述
        private int project_num_2013,           //2013年及之前专项资金项目个数
            project_num_2014;               //2014年及之后专项资金项目个数
        private double project_com_rate_2013,       //2013年项目完工比例
            project_com_rate_2014,          //2014年项目完工比例
            founds_down,        //累计专项资金下达
            founds_com,         //累计专项资金完成
            founds_rate;        //专项资金完成比率
        private int before_cons_2013,       //2013年待建项目
            in_cons_2013,           //2013在建项目
            com_cons_2013,          //2013完建项目
            before_cons_2014,       //2014待建项目
            in_cons_2014,           //2014在建项目
            com_cons_2014;          //2014完建项目
        #endregion

        #endregion 字段

        #region 属性
        public string[] Time
        {
            get { return time; }
            set { time = value; }
        }
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
        public string Community_type
        {
            get { return community_type; }
            set { community_type = value; }
        }
        public int Construct_year
        {
            get { return construct_year; }
            set { construct_year = value; }
        }
        public int Reg_family_num
        {
            get { return reg_family_num; }
            set { reg_family_num = value; }
        }

        public int Immigrant_people_num
        {
            get { return immigrant_people_num; }
            set { immigrant_people_num = value; }
        }

        public int Immigrant_family_num
        {
            get { return immigrant_family_num; }
            set { immigrant_family_num = value; }
        }

        public int Reg_people_num
        {
            get { return reg_people_num; }
            set { reg_people_num = value; }
        }

        public double Floor_area
        {
            get { return floor_area; }
            set { floor_area = value; }
        }

        public double Construction_area
        {
            get { return construction_area; }
            set { construction_area = value; }
        }

        public double Average_house_area
        {
            get { return average_house_area; }
            set { average_house_area = value; }
        }

        public double Plot_ratio
        {
            get { return plot_ratio; }
            set { plot_ratio = value; }
        }

        public double Green_rate
        {
            get { return green_rate; }
            set { green_rate = value; }
        }

        public int Parking_lot
        {
            get { return parking_lot; }
            set { parking_lot = value; }
        }

        public int Facade
        {
            get { return facade; }
            set { facade = value; }
        }

        public double[] Facade_use_rate
        {
            get { return facade_use_rate; }
            set { facade_use_rate = value; }
        }

        public double[] Employment_rate
        {
            get { return employment_rate; }
            set { employment_rate = value; }
        }

        public double[] Disposable_income
        {
            get { return disposable_income; }
            set { disposable_income = value; }
        }

        public double[] Average_rent
        {
            get { return average_rent; }
            set { average_rent = value; }
        }
        public double[] Average_county
        {
            get { return average_county; }
            set { average_county = value; }
        }

        public double[] Disposable_county
        {
            get { return disposable_county; }
            set { disposable_county = value; }
        }

        public double[] Employment_county
        {
            get { return employment_county; }
            set { employment_county = value; }
        }

        public double[] Facade_county
        {
            get { return facade_county; }
            set { facade_county = value; }
        }
        public double Poor_rate
        {
            get { return poor_rate; }
            set { poor_rate = value; }
        }

        //public double Plan_total_inves
        //{
        //    get { return plan_total_inves; }
        //    set { plan_total_inves = value; }
        //}

        //public double Complete_total_inves
        //{
        //    get { return complete_total_inves; }
        //    set { complete_total_inves = value; }
        //}

        //public double Complete_rate
        //{
        //    get { return complete_rate; }
        //    set { complete_rate = value; }
        //}

        //public double Plan_total_special_inves
        //{
        //    get { return plan_total_special_inves; }
        //    set { plan_total_special_inves = value; }
        //}

        //public double Complete_total_special_inves
        //{
        //    get { return complete_total_special_inves; }
        //    set { complete_total_special_inves = value; }
        //}

        //public double Special_complete_rete
        //{
        //    get { return special_complete_rete; }
        //    set { special_complete_rete = value; }
        //}

        //public double Plan_special_inves
        //{
        //    get { return plan_special_inves; }
        //    set { plan_special_inves = value; }
        //}

        //public double Plan_counter_inves
        //{
        //    get { return plan_counter_inves; }
        //    set { plan_counter_inves = value; }
        //}

        //public double Plan_other_inves
        //{
        //    get { return plan_other_inves; }
        //    set { plan_other_inves = value; }
        //}

        //public double Com_special_inves
        //{
        //    get { return com_special_inves; }
        //    set { com_special_inves = value; }
        //}

        //public double Com_counter_inves
        //{
        //    get { return com_counter_inves; }
        //    set { com_counter_inves = value; }
        //}

        //public double Com_other_inves
        //{
        //    get { return com_other_inves; }
        //    set { com_other_inves = value; }
        //}

        public double Plan_house_safe
        {
            get { return plan_house_safe; }
            set { plan_house_safe = value; }
        }

        public double Plan_base_fac
        {
            get { return plan_base_fac; }
            set { plan_base_fac = value; }
        }

        public double Plan_envir_pro
        {
            get { return plan_envir_pro; }
            set { plan_envir_pro = value; }
        }

        public double Plan_public_fac
        {
            get { return plan_public_fac; }
            set { plan_public_fac = value; }
        }

        public double Plan_busin
        {
            get { return plan_busin; }
            set { plan_busin = value; }
        }

        public double Com_house_safe
        {
            get { return com_house_safe; }
            set { com_house_safe = value; }
        }

        public double Com_base_fac
        {
            get { return com_base_fac; }
            set { com_base_fac = value; }
        }

        public double Com_envir_pro
        {
            get { return com_envir_pro; }
            set { com_envir_pro = value; }
        }

        public double Com_public_fac
        {
            get { return com_public_fac; }
            set { com_public_fac = value; }
        }

        public double Com_busin
        {
            get { return com_busin; }
            set { com_busin = value; }
        }

        public double Help_figure
        {
            get { return help_figure; }
            set { help_figure = value; }
        }

        public double Develop_figure
        {
            get { return develop_figure; }
            set { develop_figure = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Mana_charge_name
        {
            get { return mana_charge_name; }
            set { mana_charge_name = value; }
        }

        public string Mana_charge_phone
        {
            get { return mana_charge_phone; }
            set { mana_charge_phone = value; }
        }

        public string Mana_contact_phone
        {
            get { return mana_contact_phone; }
            set { mana_contact_phone = value; }
        }

        public string Moni_charge_name
        {
            get { return moni_charge_name; }
            set { moni_charge_name = value; }
        }

        public string Moni_charge_phone
        {
            get { return moni_charge_phone; }
            set { moni_charge_phone = value; }
        }

        public string Moni_contact_phone
        {
            get { return moni_contact_phone; }
            set { moni_contact_phone = value; }
        }

        public int Before_cons_2013
        {
            get { return before_cons_2013; }
            set { before_cons_2013 = value; }
        }

        public int In_cons_2013
        {
            get { return in_cons_2013; }
            set { in_cons_2013 = value; }
        }

        public int Com_cons_2013
        {
            get { return com_cons_2013; }
            set { com_cons_2013 = value; }
        }

        public int Before_cons_2014
        {
            get { return before_cons_2014; }
            set { before_cons_2014 = value; }
        }

        public int In_cons_2014
        {
            get { return in_cons_2014; }
            set { in_cons_2014 = value; }
        }

        public int Com_cons_2014
        {
            get { return com_cons_2014; }
            set { com_cons_2014 = value; }
        }

        public double Project_com_rate_2013
        {
            get { return project_com_rate_2013; }
            set { project_com_rate_2013 = value; }
        }

        public double Project_com_rate_2014
        {
            get { return project_com_rate_2014; }
            set { project_com_rate_2014 = value; }
        }

        public double Founds_down
        {
            get { return founds_down; }
            set { founds_down = value; }
        }

        public double Founds_com
        {
            get { return founds_com; }
            set { founds_com = value; }
        }

        public double Founds_rate
        {
            get { return founds_rate; }
            set { founds_rate = value; }
        }

        public int Project_num_2013
        {
            get { return project_num_2013; }
            set { project_num_2013 = value; }
        }

        public int Project_num_2014
        {
            get { return project_num_2014; }
            set { project_num_2014 = value; }
        }

        public string Position_advantage
        {
            get { return position_advantage; }
            set { position_advantage = value; }
        }

        public string Main_problem_solution
        {
            get { return main_problem_solution; }
            set { main_problem_solution = value; }
        }

        #endregion 属性

        public get_community_mainpage(string convince, string county, string community)
        {
            this.province = convince;
            this.county = county;
            this.community = community;
            position_msg = province+"/"+county+"/"+community;
            query_message_1();
            query_message_2();
            query_message_3();
            query_message_4();
            query_message_5();
            query_message_6();
            //query_message_7();
            //query_message_8();
            query_message_9();
            query_message_10();
            query_message_11();
            query_message_12();
            query_message_13();
            query_message_14();
            query_message_15();
        }

        #region 获取属性方法
        /// <summary>
        /// 获取小区编号，最后修改日期，小区类型，建设年份
        /// </summary>
        private void query_message_1()
        {
            string str_sql = "select community_category, community_construct_year, community_id, statistics_date from T_Community_Base where community_province = @province and community_county like @county and community_name = @community order by statistics_date desc";
            SqlParameter[] parameters = {
                                            new SqlParameter("@province", SqlDbType.VarChar, 50),
                                            new SqlParameter("@county", SqlDbType.VarChar, 50),
                                            new SqlParameter("@community",SqlDbType.VarChar,50)
                                        };
            parameters[0].Value = province;
            parameters[1].Value = "%"+county+"%";
            parameters[2].Value = community;
            DataSet result = gt.sql_query(str_sql, parameters);
            try
            {

                community_id = Convert.ToString(result.Tables[0].Rows[0]["community_id"]);
                last_modify = Convert.ToDateTime(result.Tables[0].Rows[0]["statistics_date"]);
                community_type = Convert.ToString(result.Tables[0].Rows[0]["community_category"]);
                construct_year = Convert.ToInt32(result.Tables[0].Rows[0]["community_construct_year"]);
            }
            catch (Exception)
            {
                throw new Exception(error1+position_msg);
            }
        }
        /// <summary>
        /// 查询户籍总人口人数和户数
        /// </summary>
        private void query_message_2()
        {
            string str_sql = "select community_reg_pop from T_community_population where community_id = @id order by statistics_date desc";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar,20)
                                       };
            parameter[0].Value = community_id;
            change c = new change(gt.get_content(gt.sql_query(str_sql, parameter)));
            try
            {
                reg_people_num = c.to_int("community_reg_pop");
            }
            catch (Exception)
            {
                throw new Exception(error2+position_msg+": reg_people_num");
            }
            reg_family_num = reg_people_num / 3;
            //reg_family_num = c.to_int("community_family_num");
        }
        /// <summary>
        /// 查询移民总人口人数和户数
        /// </summary>
        private void query_message_3()
        {
            string str_sql = "select immigrant_total_population, immigrant_total_family_num from T_community_immigrant where community_id = @id order by statistics_date desc";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar,20)
                                       };
            parameter[0].Value = community_id;
            change c = new change(gt.get_content(gt.sql_query(str_sql, parameter)));
            try
            {
                immigrant_people_num = c.to_int("immigrant_total_population");
            }
            catch (Exception)
            {
                throw new Exception(error2 + position_msg + ": immigrant_total_population");
            }
            immigrant_family_num = immigrant_people_num / 3;
            //immigrant_family_num = c.to_int("immigrant_total_family_num");
        }
        /// <summary>
        /// 查询占地面积、建筑面积和人均住房面积、绿地率
        /// </summary>
        private void query_message_4()
        {
            string str_sql = "select community_total_land_area from T_community_land where community_id = @id order by statistics_date desc";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id",SqlDbType.VarChar,20){Value = community_id}
                                       };
            change c = new change(gt.get_content(gt.sql_query(str_sql, parameter)));
            floor_area = c.to_double("community_total_land_area");          //占地面积

            str_sql = "select community_building_total_fs, community_house_fs from T_community_building where community_id = @id order by statistics_date desc";
            c = new change(gt.get_content(gt.sql_query(str_sql, parameter)));
            construction_area = c.to_double("community_building_total_fs");         //建筑面积

            plot_ratio = construction_area / floor_area *100;                   //容积率

            average_house_area = c.to_double("community_house_fs") * 10000 / reg_people_num;            //人均住房面积

            str_sql = "select community_green_fields_area, community_green_fields_bet_dwellings_area, community_road_green_fields_area, community_public_accomm_green_fields_area from T_community_green_fields where community_id = @id order by statistics_date desc";
            c = new change(gt.get_content(gt.sql_query(str_sql, parameter)));
            green_rate = (c.to_double("community_green_fields_area") + c.to_double("community_green_fields_bet_dwellings_area") + c.to_double("community_road_green_fields_area") + c.to_double("community_public_accomm_green_fields_area")) / (floor_area * 10000) * 100;     //绿地率
        }
        /// <summary>
        /// 查询小区停车位数量和门面数目、低保人口比例
        /// </summary>
        private void query_message_5()
        {
            string str_sql = "select community_parking_space_num from T_community_parking_lot where community_id = @id order by statistics_date desc";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id",SqlDbType.VarChar,20){Value = community_id}
                                       };
            change c = new change(gt.get_content(str_sql, parameter));
            parking_lot = c.to_int("community_parking_space_num");              //停车位个数

            str_sql = "select community_shop_front_num from T_community_shop_front where community_id = @id order by statistics_date desc";
            c = new change(gt.get_content(str_sql, parameter));
            facade = c.to_int("community_shop_front_num");                      //门面个数

            str_sql = "select community_urban_min_living_sec_pop from T_community_social_insurance where community_id = @id order by statistics_date desc";
            c = new change(gt.get_content(str_sql, parameter));
            poor_rate = c.to_double("community_urban_min_living_sec_pop") / reg_people_num *100;

        }
        /// <summary>
        /// 获取小区帮扶指数和小区发展指数
        /// </summary>
        private void query_message_6()
        {
            string str_sql = "select help_figure, develop_figure from T_important_figures where community_id = @id";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id",SqlDbType.VarChar,20){Value = community_id}
                                       };
            change c = new change(gt.get_content(str_sql, parameter));
            help_figure = c.to_double("help_figure");
            develop_figure = c.to_double("develop_figure");

            str_sql = "select * from T_community_management_responsible where community_id = @id";
            c = new change(gt.get_content(str_sql, parameter));
            address = c.to_string("community_address");
            mana_charge_name = c.to_string("community_manage_charge_person_name");
            mana_charge_phone = c.to_string("community_manage_charge_person_telphone");
            mana_contact_phone = c.to_string("community_monitor_charge_person_telphone");
            moni_charge_name = c.to_string("community_monitor_charge_person_name");
            moni_charge_phone = c.to_string("community_staff_telephone");
            moni_contact_phone = c.to_string("community_monitor_charge_person_telphone");
        }
        /// <summary>
        /// 累计计划投资、累计完成投资、完成比率、累计计划专项投资、累计完成专项投资、专项完成比率
        /// </summary>
        //private void query_message_7()
        //{
        //    string sql = "select project_id from T_project_community where county_name = @county and community_name = @community";
        //    SqlParameter[] parameter = {
        //                                   new SqlParameter("@county", SqlDbType.VarChar, 50){Value = county},
        //                                   new SqlParameter("@community", SqlDbType.VarChar, 50){Value = community}
        //                               };
        //    DataSet ds = gt.sql_query(sql, parameter);
        //    int length = ds.Tables[0].Rows.Count;
        //    double sum1 = 0;            //计划总投资
        //    double sum3 = 0;            //计划专项资金总投资
        //    for (int i = 0; i < length; i++)
        //    {
        //        string project_id = Convert.ToString(ds.Tables[0].Rows[i]["project_id"]);       //通过查询项目小区对应表获取项目编号，该项目可能是2013年专项资金项目或者对口支援项目
        //        int type = judge(project_id);       //获取项目的类型
        //        if (type == 0)              //该项目是2013年专项资金项目
        //        {
        //            string query1 = "select total_investment, follow_up_special_founds, plan_support_founds, other_matching_founds from T_previously_special_project where project_id = @project_id";
        //            SqlParameter[] temp_parameter = {
        //                                                new SqlParameter("@project_id", SqlDbType.VarChar, 50){Value = project_id}
        //                                            };
        //            DataRow row = gt.get_content(query1, temp_parameter);           //获取2013年计划总投资
        //            double invest1 = Convert.ToDouble(row["total_investment"]);      //2013年计划投资
        //            sum1 += invest1;
        //            double special1 = Convert.ToDouble(row["follow_up_special_founds"]);        //2013年计划专项投资
        //            sum3 += special1;
        //            plan_special_inves += Convert.ToDouble(row["follow_up_special_founds"]);
        //            plan_counter_inves += Convert.ToDouble(row["plan_support_founds"]);
        //            plan_other_inves += Convert.ToDouble(row["other_matching_founds"]);
        //        }
        //    }

        //    string query2 = "select total_investment, apply_for_founds, conterpart_founds, other_matching_founds from T_subsequent_project where project_id in(" +
        //        "select distinct project_id from T_subproject_new where subproject_id in(" +
        //        "select subproject_id from T_grandson_project where county_name = @county and involve_community = @community))";
        //    DataSet ds2 = gt.sql_query(query2, parameter);          //查询2014年专项资金项目总计划投资
        //    int length2 = ds2.Tables[0].Rows.Count;
        //    for (int i = 0; i < length2; i++)
        //    {
        //        double invest2 = Convert.ToDouble(ds2.Tables[0].Rows[i]["total_investment"]);
        //        sum1 += invest2;
        //        double special2 = Convert.ToDouble(ds2.Tables[0].Rows[i]["apply_for_founds"]);      //2014年项目计划专项资金
        //        sum3 += special2;
        //        plan_special_inves += Convert.ToDouble(ds2.Tables[0].Rows[i]["apply_for_founds"]);
        //        plan_counter_inves += Convert.ToDouble(ds2.Tables[0].Rows[i]["conterpart_founds"]);
        //        plan_other_inves += Convert.ToDouble(ds2.Tables[0].Rows[i]["other_matching_founds"]);
        //    }
        //    plan_total_inves = sum1;
        //    plan_total_special_inves = sum3;

        //    double sum2 = 0;            //累计完成投资
        //    double sum4 = 0;            //累计完成专项投资
        //    string query3 = "select summary, special_support_founds, conterpart_founds, other_matching_founds from T_investment_finish_situation " +
        //        "where (project_id in(" +
        //        "select project_id from T_project_community " +
        //        "where county_name = @county and community_name = @community" +
        //        ") or project_id in(" +
        //        "select grandson_project_id from T_grandson_project " +
        //        "where county_name = @county and involve_community = @community" +
        //        ") )and month = @month";
        //    SqlParameter[] temp_para2 = {
        //                                    new SqlParameter("@county", SqlDbType.VarChar, 50){Value = county},
        //                                    new SqlParameter("@community", SqlDbType.VarChar, 50){Value = community},
        //                                    new SqlParameter("@month", SqlDbType.Int, 4){Value = judge_month()}
        //                                };
        //    DataSet ds3 = gt.sql_query(query3, temp_para2);
        //    int length3 = ds3.Tables[0].Rows.Count;
        //    for (int i = 0; i < length3; i++)
        //    {
        //        sum2 += Convert.ToDouble(ds3.Tables[0].Rows[i]["summary"]);
        //        sum4 += Convert.ToDouble(ds3.Tables[0].Rows[i]["special_support_founds"]);
        //        com_special_inves += Convert.ToDouble(ds3.Tables[0].Rows[i]["special_support_founds"]);
        //        com_counter_inves += Convert.ToDouble(ds3.Tables[0].Rows[i]["conterpart_founds"]);
        //        com_other_inves += Convert.ToDouble(ds3.Tables[0].Rows[i]["other_matching_founds"]);
        //    }
        //    complete_total_inves = sum2;
        //    complete_total_special_inves = sum4;

        //    if (plan_total_inves != 0)
        //        complete_rate = complete_total_inves / plan_total_inves;
        //    if (sum3 != 0)
        //        special_complete_rete = sum4 / sum3;
        //}
        /// <summary>
        /// 房屋居住安全等资金计划与完成
        /// </summary>
        //private void query_message_8()
        //{
        //    string sql = "select project_id from T_project_community where county_name = @county and community_name = @community";
        //    SqlParameter[] parameter = {
        //                                   new SqlParameter("@county", SqlDbType.VarChar, 50){Value = county},
        //                                   new SqlParameter("@community", SqlDbType.VarChar, 50){Value = community}
        //                               };
        //    DataSet ds = gt.sql_query(sql, parameter);
        //    int length = ds.Tables[0].Rows.Count;
        //    for (int i = 0; i < length; i++)
        //    {
        //        string project_id = Convert.ToString(ds.Tables[0].Rows[i]["project_id"]);       //通过查询项目小区对应表获取项目编号，该项目可能是2013年专项资金项目或者对口支援项目
        //        int type = judge(project_id);       //获取项目的类型
        //        if (type == 0)              //该项目是2013年专项资金项目
        //        {
        //            string query1 = "select total_investment, project_type from T_previously_special_project where project_id = @project_id";
        //            SqlParameter[] temp_parameter = {
        //                                                new SqlParameter("@project_id", SqlDbType.VarChar, 50){Value = project_id}
        //                                            };
        //            DataRow row = gt.get_content(query1, temp_parameter);
        //            string ptype = Convert.ToString(row["project_type"]);
        //            if (ptype.Equals("基础设施"))
        //                plan_base_fac += Convert.ToDouble(row["total_investment"]);
        //            else if (ptype.Equals("环保设施"))
        //                plan_envir_pro += Convert.ToDouble(row["total_investment"]);
        //            else if (ptype.Equals("就业与创业扶持"))
        //                plan_busin += Convert.ToDouble(row["total_investment"]);
        //            else if (ptype.Equals("房屋居住安全"))
        //                plan_house_safe += Convert.ToDouble(row["total_investment"]);
        //            else if (ptype.Equals("公共服务设施"))
        //                plan_public_fac += Convert.ToDouble(row["total_investment"]);

        //        }
        //    }

        //    string query2 = "select total_investment, grandson_project_type from T_grandson_project where "+
        //                "county_name = @county and involve_community = @community";
        //    DataSet ds2 = gt.sql_query(query2, parameter);          //查询2014年专项资金项目总计划投资
        //    int length2 = ds2.Tables[0].Rows.Count;
        //    for (int i = 0; i < length2; i++)
        //    {
        //        DataRow row = ds2.Tables[0].Rows[i];
        //        string ptype = Convert.ToString(row["grandson_project_type"]);
        //        if (ptype.Equals("基础设施"))
        //            plan_base_fac += Convert.ToDouble(row["total_investment"]);
        //        else if (ptype.Equals("环保设施"))
        //            plan_envir_pro += Convert.ToDouble(row["total_investment"]);
        //        else if (ptype.Equals("就业与创业扶持"))
        //            plan_busin += Convert.ToDouble(row["total_investment"]);
        //        else if (ptype.Equals("房屋居住安全"))
        //            plan_house_safe += Convert.ToDouble(row["total_investment"]);
        //        else if (ptype.Equals("公共服务设施"))
        //            plan_public_fac += Convert.ToDouble(row["total_investment"]);
        //    }


        //    //完成情况
        //    //2013年
        //    string query3 = "select summary, project_type from T_investment_finish_situation as inves, T_previously_special_project as pre where pre.project_id = inves.project_id and inves.project_id in (select distinct project_id from T_project_community where county_name = @county and community_name = @community)and inves.month = @month";
        //    SqlParameter[] temp = {
        //                            new SqlParameter("@county", SqlDbType.VarChar, 50){Value = county},
        //                            new SqlParameter("@community", SqlDbType.VarChar, 50){Value = community},
        //                            new SqlParameter("@month", SqlDbType.Int, 4){Value = judge_month()}
        //                        };
        //    DataSet ds3 = gt.sql_query(query3, temp);
        //    int length3 = ds3.Tables[0].Rows.Count;
        //    for (int i = 0; i < length3; i++)
        //    {
        //        DataRow row = ds3.Tables[0].Rows[i];
        //        string ptype = Convert.ToString(row["project_type"]);
        //        if (ptype.Equals("基础设施"))
        //            com_base_fac += Convert.ToDouble(row["summary"]);
        //        else if (ptype.Equals("环保设施"))
        //            com_envir_pro += Convert.ToDouble(row["summary"]);
        //        else if (ptype.Equals("就业与创业扶持"))
        //            com_busin += Convert.ToDouble(row["summary"]);
        //        else if (ptype.Equals("房屋居住安全"))
        //            com_house_safe += Convert.ToDouble(row["summary"]);
        //        else if (ptype.Equals("公共服务设施"))
        //            com_public_fac += Convert.ToDouble(row["summary"]);
        //    }
        //    //2014年及之后
        //    string query4 = "select  summary, grandson_project_type " +
        //        "from T_investment_finish_situation as inves, T_grandson_project as grand " +
        //        "where county_name = @county and involve_community = @community " +
        //        "and grandson_project_id = inves.project_id and inves.month = @month";
        //    DataSet ds4 = gt.sql_query(query4, temp);
        //    int length4 = ds4.Tables[0].Rows.Count;
        //    for (int i = 0; i < length4; i++)
        //    {
        //        DataRow row = ds4.Tables[0].Rows[i];
        //        string ptype = Convert.ToString(row["grandson_project_type"]);
        //        if (ptype.Equals("基础设施"))
        //            com_base_fac += Convert.ToDouble(row["summary"]);
        //        else if (ptype.Equals("环保设施"))
        //            com_envir_pro += Convert.ToDouble(row["summary"]);
        //        else if (ptype.Equals("就业与创业扶持"))
        //            com_busin += Convert.ToDouble(row["summary"]);
        //        else if (ptype.Equals("房屋居住安全"))
        //            com_house_safe += Convert.ToDouble(row["summary"]);
        //        else if (ptype.Equals("公共服务设施"))
        //            com_public_fac += Convert.ToDouble(row["summary"]);
        //    }
        //}



        /// <summary>
        /// 判断项目类型是专项资金（0）还是对口支援（1）还是其他投资（2）
        /// </summary>
        /// <param name="project_id"></param>
        /// <returns></returns>
        private int judge(string project_id)
        {
            char type = project_id[project_id.Length - 1];
            if (type == 'Z')
            {
                return 0;
            }
            else if (type == 'D')
                return 1;
            else if (type == 'Q')
                return 2;
            return 0;
        }
        /// <summary>
        /// 判断当前属于第几个季度
        /// </summary>
        /// <returns></returns>
        private int judge_month()
        {
            int month = DateTime.Now.Month;
            if (month < 6)
                return 3;
            else if (month < 9)
                return 6;
            else if (month <= 12)
                return 9;
            else
                return 12;
        }
        /// <summary>
        /// 率
        /// </summary>
        private void query_message_9()
        {
            //门面使用率
            string sql = "select community_shop_front_num, community_immigrant_rent_out_shop_front_num from T_community_shop_front where community_id = @id order by statistics_date";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 50){Value = community_id}
                                       };
            string sql11 = "select rent_facade_num from T_important_figures where community_id = @id order by fill_time";
            DataSet ds11 = gt.sql_query(sql11, parameter);      //重要指标年度更新表中出租经营门面数量
            double temp11 = Convert.ToDouble(ds11.Tables[0].Rows[0]["rent_facade_num"]);        //出租经营门面数量

            DataSet ds = gt.sql_query(sql, parameter);          //小区移民门面中小区门面数量
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < facade_use_rate.Length && i< count; i++)
            {
                facade_use_rate[i] = temp11 / Convert.ToDouble(ds.Tables[0].Rows[i]["community_shop_front_num"]) * 100;
            }
            facade_county = facade_use_rate;
            //劳动力就业率
            string sql2 = "select community_have_job_pop,  community_total_lf_pop from T_community_lf_employment where community_id = @id order by statistics_date";
            DataSet ds2 = gt.sql_query(sql2, parameter);
            count = ds2.Tables[0].Rows.Count;
            for (int i = 0; i < count && i < employment_rate.Length; i++)
            {
                employment_rate[i] = Convert.ToDouble(ds2.Tables[0].Rows[i]["community_have_job_pop"]) / Convert.ToDouble(ds2.Tables[0].Rows[i]["community_total_lf_pop"]) * 100;
            }
            employment_county = employment_rate;

            //人均可支配收入
            string sql3 = "select disposable_money_per_people from T_important_figures where community_id = @id order by fill_time";
            DataSet ds3 = gt.sql_query(sql3, parameter);
            disposable_income[0] = Convert.ToDouble(ds3.Tables[0].Rows[0]["disposable_money_per_people"]);
            disposable_income[1] = disposable_income[0] * 0.9;

            disposable_county = disposable_income;
            //房屋平均租金水平
            //string sql4 = "select community_average_rent_of_shop_front from T_community_shop_front where community_id = @id order by statistics_date";
            string sql4 = "select house_rent from T_important_figures where community_id = @id order by fill_time";
            DataSet ds4 = gt.sql_query(sql4, parameter);
            average_rent[0] = Convert.ToDouble(ds4.Tables[0].Rows[0]["house_rent"]);
            average_rent[1] = average_rent[0] * 0.9;
            average_county = average_rent;
        }
        /// <summary>
        /// 查询小区重要指标年度更新表, 小区区位特色，主要问题及解决方案
        /// </summary>
        private void query_message_10()
        {
            string sql = "select positon_advantage, problem_solution from T_important_figures where community_id = @id order by fill_time desc";
            SqlParameter[] parameter = {
                                           new SqlParameter("@id", SqlDbType.VarChar, 50){Value = community_id}
                                       };
            DataRow row = gt.get_content(sql, parameter);
            position_advantage = Convert.ToString(row["positon_advantage"]);
            main_problem_solution = Convert.ToString(row["problem_solution"]);
        }
        /// <summary>
        /// 查询2013年及之前项目的个数及完工比率
        /// </summary>
        private void query_message_11()
        {
            string sql = "select project_id from T_project_community where county_name = @county and community_name = @community";
            SqlParameter[] parameter = {
                                           new SqlParameter("@county", SqlDbType.VarChar, 50){Value = county},
                                           new SqlParameter("@community", SqlDbType.VarChar, 50){Value = community}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);      //查询与该小区所相关的所有项目，项目可能是2013年及之前的项目或者对口支援项目
            int row = ds.Tables[0].Rows.Count;              //结果集的行数
            int count = 0;              //2013年及之前专项资金项目的个数
            int com_count = 0;          //已完工的2013年及之前的专项资金项目个数
            for (int i = 0; i < row; i++)
            {
                string project_id = Convert.ToString(ds.Tables[0].Rows[i]["project_id"]);   //第i行的项目编号
                int type = judge(project_id);           //判断项目的类型
                if (type == 0)              //是专项资金项目
                {
                    count++;
                    string sql2 = "select finish_date from T_previously_special_project where project_id = @id";
                    SqlParameter[] parameter2 = {
                                                    new SqlParameter("@id", SqlDbType.VarChar, 50){Value = project_id}
                                                };
                    DataRow dr = gt.get_content(sql2, parameter2);          //查询对应项目的完工日期
                    string date = Convert.ToString(dr["finish_date"]);
                    if (!date.Equals("0"))
                        com_count++;
                }
            }

            project_num_2013 = count;
            project_com_rate_2013 = Convert.ToDouble(com_count) / count * 100;
        }
        /// <summary>
        /// 查询2014年及之后专项资金项目的个数及完工比例
        /// </summary>
        private void query_message_12()
        {
            string sql = "select distinct project_id from T_subproject_new where involve_community = @community";
            SqlParameter[] parameter = {
                                           new SqlParameter("@community", SqlDbType.VarChar, 50){Value = community}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);          //查询该小区涉及的2014年及之后专项资金项目
            project_num_2014 = ds.Tables[0].Rows.Count;             //该小区涉及的2014专项资金项目个数

            string sql2 = "select finish_date from T_subproject_new where involve_community = @community";      //查询该小区所涉及的单项项目的完工日期
            DataSet ds2 = gt.sql_query(sql2, parameter);
            int count = ds2.Tables[0].Rows.Count;
            int com_count = 0;
            for (int i = 0; i < count; i++)
            {
                string date = Convert.ToString(ds2.Tables[0].Rows[i]["finish_date"]);
                if (!date.Equals("0"))
                    com_count++;
            }
            project_com_rate_2014 = Convert.ToDouble(com_count) / count * 100;
        }
        /// <summary>
        /// 查询资金投资到位及完成情况
        /// </summary>
        private void query_message_13()
        {
            string sql = "select project_id from T_project_community where county_name = @county and community_name = @community";
            SqlParameter[] parameter = {
                                           new SqlParameter("@county", SqlDbType.VarChar, 50){Value = county},
                                           new SqlParameter("@community", SqlDbType.VarChar, 50){Value = community}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);      //查询与该小区所相关的所有项目，项目可能是2013年及之前的项目或者对口支援项目
            int row = ds.Tables[0].Rows.Count;              //结果集的行数
            double inves1 = 0;                           //2013年项目总投资
            double inves3 = 0;              //2013年项目已完成投资
            for (int i = 0; i < row; i++)
            {
                string project_id = Convert.ToString(ds.Tables[0].Rows[i]["project_id"]);   //第i行的项目编号
                int type = judge(project_id);           //判断项目的类型
                if (type == 0)              //是专项资金项目
                {
                    string sql2 = "select plan_investment from T_follow_up_investment_plan where project_id = @pro_id";
                    SqlParameter[] parameter2 = { new SqlParameter("@pro_id", SqlDbType.VarChar, 50) { Value = project_id } };
                    DataSet ds2 = gt.sql_query(sql2, parameter2);       //查询该项目的后规年度投资计划
                    int count = ds2.Tables[0].Rows.Count;
                    for (int j = 0; j < count; j++)
                    {
                        inves1 += Convert.ToDouble(ds2.Tables[0].Rows[j]["plan_investment"]);
                    }

                    string sql5 = "select special_support_founds from T_investment_finish_situation where project_id = @pro_id and month = @month order by year desc";
                    SqlParameter[] parameter5 = {
                                                    new SqlParameter("@pro_id", SqlDbType.VarChar, 50){Value = project_id},
                                                    new SqlParameter("@month", SqlDbType.Int){Value = judge_month()}
                                                };
                    DataRow dr5 = gt.get_content(sql5, parameter5);     //2013年项目最近月份的完成投资
                    inves3 += Convert.ToDouble(dr5["special_support_founds"]);
                }
            }

            //查询2014年项目的投资
            double inves2 = 0;          //2014年项目投资
            double inves4 = 0;          //2014年项目完成投资
            string sql3 = "select distinct project_id from T_subproject_new where involve_community = @community";
            SqlParameter[] parameter3 = {
                                            new SqlParameter("@community", SqlDbType.VarChar, 50){Value = community}
                                        };
            DataSet ds3 = gt.sql_query(sql3, parameter3);       //查询该小区涉及的2014年项目
            for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
            {
                string project_id = Convert.ToString(ds3.Tables[0].Rows[i]["project_id"]);
                string sql4 = "select follow_up_special_founds from T_subsequent_project where project_id = @pro_id";
                SqlParameter[] parameter4 = { new SqlParameter("@pro_id", SqlDbType.VarChar, 50) { Value = project_id } };
                DataRow dr4 = gt.get_content(sql4, parameter4);
                inves2 += Convert.ToDouble(dr4["follow_up_special_founds"]);
            }

            founds_down = inves1 + inves2;

            string sql6 = "select subproject_id from T_subproject_new where involve_community = @community";
            DataSet ds6 = gt.sql_query(sql6, parameter3);       //查询该小区涉及的2014年项目单项项目的编号
            for (int i = 0; i < ds6.Tables[0].Rows.Count; i++)
            {
                string sql7 = "select grandson_project_id from T_grandson_project where subproject_id = @sub_id";
                SqlParameter[] parameter7 = {
                                                new SqlParameter("@sub_id", SqlDbType.VarChar, 50){Value = ds6.Tables[0].Rows[i]["subproject_id"]}
                                            };
                DataSet ds7 = gt.sql_query(sql7, parameter7);           //该子项目下的所有孙项目
                for (int j = 0; j < ds7.Tables[0].Rows.Count; j++)
                {
                    string sql8 = "select special_support_founds from T_investment_finish_situation where project_id = @pro_id and month = @month order by year desc";
                    SqlParameter[] parameter8 = {
                                                    new SqlParameter("@pro_id", SqlDbType.VarChar, 50){Value = ds7.Tables[0].Rows[j]["grandson_project_id"]},
                                                    new SqlParameter("@month", SqlDbType.Int){Value = judge_month()}
                                                };
                    DataRow dr8 = gt.get_content(sql8, parameter8);     //通过孙项目编号查询已完成投资
                    inves4 += Convert.ToDouble(dr8["special_support_founds"]);
                }
            }

            founds_com = inves3 + inves4;
            founds_rate = founds_com / founds_down * 100;
        }
        /// <summary>
        /// 查询待建、在建、完建项目
        /// </summary>
        private void query_message_14()
        {
            string sql = "select project_id from T_project_community where county_name = @county and community_name = @community";
            SqlParameter[] parameter = {
                                           new SqlParameter("@county", SqlDbType.VarChar, 50){Value = county},
                                           new SqlParameter("@community", SqlDbType.VarChar, 50){Value = community}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);      //查询与该小区所相关的所有项目，项目可能是2013年及之前的项目或者对口支援项目
            int row = ds.Tables[0].Rows.Count;              //结果集的行数
            for (int i = 0; i < row; i++)
            {
                string project_id = Convert.ToString(ds.Tables[0].Rows[i]["project_id"]);   //第i行的项目编号
                int type = judge(project_id);           //判断项目的类型
                if (type == 0)              //是专项资金项目
                {
                    string sql2 = "select * from T_figure_progress where project_id = @pro_id order by year desc";
                    SqlParameter[] parameter2 = { new SqlParameter("@pro_id", SqlDbType.VarChar, 50) { Value = project_id } };
                    DataRow dr2 = gt.get_content(sql2, parameter2);         //获取项目形象进度
                    int month = judge_month();
                    double figure = 0;
                    if (month == 3)
                    {
                        figure = Convert.ToDouble(dr2["march_progress"]);
                    }
                    else if (month == 6)
                    {
                        figure = Convert.ToDouble(dr2["june_progress"]);
                    }
                    else if (month == 9)
                    {
                        figure = Convert.ToDouble(dr2["september_progress"]);
                    }
                    else if (month == 12)
                    {
                        figure = Convert.ToDouble(dr2["december_progress"]);
                    }
                    if (figure == 0)
                        before_cons_2013++;
                    else if (figure == 1)
                        com_cons_2013++;
                    else
                        in_cons_2013++;
                }
            }

            string sql3 = "select subproject_id from T_subproject_new where involve_community = @community";
            SqlParameter[] parameter3 = { new SqlParameter("@community", SqlDbType.VarChar, 50) { Value = community } };
            DataSet ds3 = gt.sql_query(sql3, parameter3);           //查询涉及该小区的2014年项目单项项目编号
            for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
            {
                string sub_id = Convert.ToString(ds3.Tables[0].Rows[0]["subproject_id"]);
                string sql2 = "select * from T_figure_progress where project_id = @pro_id order by year desc";
                SqlParameter[] parameter2 = { new SqlParameter("@pro_id", SqlDbType.VarChar, 50) { Value = sub_id } };
                DataRow dr2 = gt.get_content(sql2, parameter2);         //获取项目形象进度
                int month = judge_month();
                double figure = 0;
                if (month == 3)
                {
                    figure = Convert.ToDouble(dr2["march_progress"]);
                }
                else if (month == 6)
                {
                    figure = Convert.ToDouble(dr2["june_progress"]);
                }
                else if (month == 9)
                {
                    figure = Convert.ToDouble(dr2["september_progress"]);
                }
                else if (month == 12)
                {
                    figure = Convert.ToDouble(dr2["december_progress"]);
                }
                if (figure == 0)
                    before_cons_2014++;
                else if (figure == 1)
                    com_cons_2014++;
                else
                    in_cons_2014++;
            }
        }
        /// <summary>
        /// 房屋居住安全等项目类别统计
        /// </summary>
        private void query_message_15()
        {
            int month = judge_month();          //当前应采用几月的数据
            //2013年项目
            string sql = "select project_id from T_project_community where county_name = @county and community_name = @community";
            SqlParameter[] parameter = {
                                           new SqlParameter("@county", SqlDbType.VarChar, 50){Value = county},
                                           new SqlParameter("@community", SqlDbType.VarChar, 50){Value = community}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);          //查询2013年项目的项目编号（也有可能是对口支援项目）
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string pro_id = Convert.ToString(ds.Tables[0].Rows[i]["project_id"]);       //项目编号
                int type = judge(pro_id);           //判断该项目是什么类型的
                if (type == 0)          //该项目是2013年专项资金项目
                {
                    string sql2 = "select project_type from T_previously_special_project where project_id = @pro_id";
                    SqlParameter[] parameter2 = { new SqlParameter("@pro_id", SqlDbType.VarChar, 50) { Value = pro_id } };
                    string pro_type = Convert.ToString(gt.get_content(sql2, parameter2)["project_type"]);       //获取该项目的项目类别

                    string sql3 = "select plan_investment from T_follow_up_investment_plan where project_id = @pro_id";
                    DataSet ds3 = gt.sql_query(sql3, parameter2);       //获取该项目的后规投资金额
                    double inves = 0;       //后规投资下达总金额
                    for (int j = 0; j < ds3.Tables[0].Rows.Count; j++)
                    {
                        inves += Convert.ToDouble(ds3.Tables[0].Rows[j]["plan_investment"]);
                    }

                    string sql6 = "select special_support_founds from T_investment_finish_situation where project_id = @pro_id and month = @month order by year desc";
                    SqlParameter[] parameter6 = {
                                                    new SqlParameter("@pro_id", SqlDbType.VarChar, 50){Value = pro_id},
                                                    new SqlParameter("@month", SqlDbType.Int){Value = judge_month()}
                                                };
                    DataRow dr6 = gt.get_content(sql6, parameter6);     //获取该项目的最新的完成投资
                    double inves_com = Convert.ToDouble(dr6["special_support_founds"]);     //项目完成投资

                    //根据项目类型累加相应的金额
                    if (pro_type.Equals("房屋居住安全")){
                        plan_house_safe += inves;
                        com_house_safe += inves_com;
                    }
                    else if (pro_type.Equals("基础设施")){
                        plan_base_fac += inves;
                        com_base_fac += inves_com;
                    }
                    else if (pro_type.Equals("环保设施")){
                        plan_envir_pro += inves;
                        com_envir_pro += inves_com;
                    }
                    else if (pro_type.Equals("公共服务设施")){
                        plan_public_fac += inves;
                        com_public_fac += inves_com;
                    }
                    else if (pro_type.Equals("就业与创业扶持"))
                    {
                        plan_busin += inves;
                        com_busin += inves_com;
                    }
                }
            }
            //2014年专项资金项目
            string sql4 = "select subproject_id from T_subproject_new where involve_community = @community";
            SqlParameter[] parameter4 = { new SqlParameter("@community", SqlDbType.VarChar, 50) { Value = community } };
            DataSet ds4 = gt.sql_query(sql4, parameter4);       //查询涉及该小区的子项目的编号

            for (int i = 0; i < ds4.Tables[0].Rows.Count; i++)
            {
                string pro_id = Convert.ToString(ds4.Tables[0].Rows[i]["subproject_id"]);     //子项目编号
                string sql5 = "select * from T_grandson_project where subproject_id = @pro_id";
                SqlParameter[] parameter5 = { new SqlParameter("@pro_id", SqlDbType.VarChar, 50) { Value = pro_id } };
                DataRow dr5 = gt.get_content(sql5, parameter5);     //孙项目的相应的数据和类别

                string pro_type = Convert.ToString(dr5["grandson_project_type"]);       //孙项目类别
                double inves = Convert.ToDouble(dr5["special_founds"]);          //专项资金下达金额

                string sql6 = "select special_support_founds from T_investment_finish_situation where project_id = @pro_id and month = @month order by year desc";
                SqlParameter[] parameter6 = {
                                                new SqlParameter("@pro_id", SqlDbType.VarChar, 50){Value = Convert.ToString(dr5["grandson_project_id"])},
                                                new SqlParameter("@month", SqlDbType.Int){Value = month}
                                            };
                DataRow dr6 = gt.get_content(sql6, parameter6);     //获取项目完成投资
                double inves_com = Convert.ToDouble(dr6["special_support_founds"]);         //2014年孙项目完成投资
                //根据项目类型累加相应的金额
                if (pro_type.Equals("房屋居住安全"))
                {
                    plan_house_safe += inves;
                    com_house_safe += inves_com;
                }
                else if (pro_type.Equals("基础设施"))
                {
                    plan_base_fac += inves;
                    com_base_fac += inves_com;
                }
                else if (pro_type.Equals("环保设施"))
                {
                    plan_envir_pro += inves;
                    com_envir_pro += inves_com;
                }
                else if (pro_type.Equals("公共服务设施"))
                {
                    plan_public_fac += inves;
                    com_public_fac += inves_com;
                }
                else if (pro_type.Equals("就业与创业扶持"))
                {
                    plan_busin += inves;
                    com_busin += inves_com;
                }
            }
        }

        #endregion

        /// <summary>
        /// 内部类，将object转化成想要的数据类型
        /// </summary>
        private class change
        {
            DataRow result;
            public change(DataRow dr)
            {
                result = dr;
            }
            public int to_int(string property)
            {
                return Convert.ToInt32(result[property]);
            }
            public double to_double(string property)
            {
                return Convert.ToDouble(result[property]);
            }
            public string to_string(string property)
            {
                return Convert.ToString(result[property]);
            }
            public DateTime to_datetime(string property)
            {
                return Convert.ToDateTime(result[property]);
            }
        }
    }
}
