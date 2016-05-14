using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TTG.DAL.GET
{
    public class get_project
    {
        private get_tools gt = new get_tools();
        private string province_name, county_name, community_name, community_id;
        private DateTime last_modify;
        private List<project_data> list = new List<project_data>();

        public List<project_data> List
        {
            get { return list; }
            set { list = value; }
        }

        public get_project(string province, string county, string community)
        {
            province_name = province;
            county_name = county;
            community_name = community;
            query_message_1();
            //query_message_2();
            //query_message_3();
            query_message_4();
            query_message_5();
        }

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
        /// 2013年及之前专项资金项目、对口支援项目
        /// </summary>
        //private void query_message_2()
        //{
        //    string sql = "select project_id from T_project_community where county_name = @county and community_name = @community";
        //    SqlParameter[] parameter = {
        //                                   new SqlParameter("@county", SqlDbType.VarChar, 50){Value = county_name},
        //                                   new SqlParameter("@community", SqlDbType.VarChar, 50){Value = community_name}
        //                               };

        //    DataSet ds = gt.sql_query(sql, parameter);
        //    int count = ds.Tables[0].Rows.Count;
        //    for (int i = 0; i < count; i++)
        //    {
        //        project_data pd = new project_data();
        //        string pid = Convert.ToString(ds.Tables[0].Rows[i]["project_id"]);
        //        pd.Project_id = pid;
        //        sql = "select * from T_previously_special_project where project_id = @pid";
        //        SqlParameter[] temp_para = {
        //                                       new SqlParameter("@pid", SqlDbType.VarChar, 50){Value = pid}
        //                                   };
        //        string sql2 = "select * from T_counterpart_and_other_project where project_id = @pid";
        //        DataSet ds_temp = gt.sql_query(sql, temp_para);
        //        if (ds_temp.Tables[0].Rows.Count > 0)
        //        {
        //            DataRow row = ds_temp.Tables[0].Rows[0];
        //            pd.Project_name = Convert.ToString(row["project_name"]);
        //            pd.Child_name = "————";
        //            pd.Grand_name = "————";
        //            if (row["start_date"] == System.DBNull.Value)
        //                pd.Start_date = Convert.ToDateTime("1996-9-16");
        //            else
        //                pd.Start_date = Convert.ToDateTime(row["start_date"]);
        //            if (row["finish_date"] == System.DBNull.Value)
        //                pd.End_date = Convert.ToDateTime("1996-9-16");
        //            else
        //                pd.End_date = Convert.ToDateTime(row["finish_date"]);
        //            DateTime now = DateTime.Now;
        //            if (now < pd.Start_date)
        //            {
        //                pd.Construct_state = "未开工";
        //            }
        //            else if (now <= pd.End_date)
        //            {
        //                pd.Construct_state = "正在建设中";
        //            }
        //            else
        //            {
        //                pd.Construct_state = "已完工";
        //            }
        //            pd.Investment = Convert.ToDouble(row["total_investment"]);
        //            pd.Is_indirect = Convert.ToString(row["project_indirect_serve_community"]);
        //        }
        //        else
        //        {
        //            ds_temp = gt.sql_query(sql2, temp_para);
        //            DataRow row = ds_temp.Tables[0].Rows[0];
        //            pd.Project_name = Convert.ToString(row["project_name"]);
        //            pd.Child_name = "————";
        //            pd.Grand_name = "————";
        //            if (row["start_date"] == System.DBNull.Value)
        //                pd.Start_date = Convert.ToDateTime("1996-9-16");
        //            else
        //                pd.Start_date = Convert.ToDateTime(row["start_date"]);
        //            if (row["finish_date"] == System.DBNull.Value)
        //                pd.End_date = Convert.ToDateTime("1996-9-16");
        //            else
        //                pd.End_date = Convert.ToDateTime(row["finish_date"]);
        //            DateTime now = DateTime.Now;
        //            if (now < pd.Start_date)
        //            {
        //                pd.Construct_state = "未开工";
        //            }
        //            else if (now <= pd.End_date)
        //            {
        //                pd.Construct_state = "正在建设中";
        //            }
        //            else
        //            {
        //                pd.Construct_state = "已完工";
        //            }
        //            pd.Investment = Convert.ToDouble(row["total_investment"]);
        //            pd.Is_indirect = "否";
        //        }
                
        //        list.Add(pd);
        //    }
        //}
        /// <summary>
        /// 2014年及之后专项资金项目
        /// </summary>
        //private void query_message_3()
        //{
        //    string sql = "select * from T_grandson_project where involve_community = @community and county_name = @county";
        //    SqlParameter[] parameter = {
        //                                   new SqlParameter("@county", SqlDbType.VarChar, 50){Value = county_name},
        //                                   new SqlParameter("@community", SqlDbType.VarChar, 50){Value = community_name}
        //                               };
        //    DataSet ds = gt.sql_query(sql, parameter);
        //    int count = ds.Tables[0].Rows.Count;
        //    for (int i = 0; i < count; i++)
        //    {
        //        project_data pd = new project_data();
        //        pd.Grand_name = Convert.ToString(ds.Tables[0].Rows[i]["grandson_project_name"]);
        //        if (ds.Tables[0].Rows[i]["start_date"] == System.DBNull.Value)
        //            pd.Start_date = Convert.ToDateTime("1996-9-6");
        //        else
        //            pd.Start_date = Convert.ToDateTime(ds.Tables[0].Rows[i]["start_date"]);
        //        if (ds.Tables[0].Rows[i]["finish_date"] == System.DBNull.Value)
        //            pd.End_date = Convert.ToDateTime("1996-9-6");
        //        else
        //            pd.End_date = Convert.ToDateTime(ds.Tables[0].Rows[i]["finish_date"]);
        //        string pid1 = Convert.ToString(ds.Tables[0].Rows[i]["subproject_id"]);
        //        sql = "select * from T_subproject_new where subproject_id = @pid";
        //        SqlParameter[] temp_p = {
        //                                    new SqlParameter("@pid", SqlDbType.VarChar, 50){Value = pid1}
        //                                };
        //        DataRow row = gt.get_content(sql, temp_p);
        //        pd.Child_name = Convert.ToString(row["subproject_name"]);
        //        sql = "select * from T_subsequent_project where project_id = @pid";
        //        SqlParameter[] temp_p2 = {
        //                                     new SqlParameter("@pid", SqlDbType.VarChar, 50){Value = Convert.ToString(row["project_id"])}
        //                                 };
        //        row = gt.get_content(sql, temp_p2);
        //        pd.Project_id = Convert.ToString(row["project_id"]);
        //        pd.Project_name = Convert.ToString(row["project_name"]);
        //        //pd.Start_date = Convert.ToDateTime(row["start_date"]);
        //        //pd.End_date = Convert.ToDateTime(row["finish_date"]);
        //        DateTime now = DateTime.Now;
        //        if (now < pd.Start_date)
        //        {
        //            pd.Construct_state = "未开工";
        //        }
        //        else if (now <= pd.End_date)
        //        {
        //            pd.Construct_state = "正在建设中";
        //        }
        //        else
        //        {
        //            pd.Construct_state = "已完工";
        //        }
        //        pd.Construct_content = Convert.ToString(ds.Tables[0].Rows[i]["plan_construct_content"]);
        //        pd.Investment = Convert.ToDouble(row["total_investment"]);
        //        pd.Is_indirect = Convert.ToString(ds.Tables[0].Rows[i]["project_indirect_serve_community"]);
        //        list.Add(pd);
        //    }
        //}
        /// <summary>
        /// 2013年及之前专项资金项目、对口支援或其他项目
        /// </summary>
        private void query_message_4()
        {
            int month = judge_month();          //判断当前应用第几月份的数据
            string sql = "select project_id from T_project_community where county_name = @county and community_name = @community";
            SqlParameter[] parameter = {
                                           new SqlParameter("@county", SqlDbType.VarChar, 50){Value = county_name},
                                           new SqlParameter("@community", SqlDbType.VarChar, 50){Value = community_name}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);          //查询涉及小区的项目 可能是2013年项目或者对口支援或其他项目
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            { 
                string pro_id = Convert.ToString(ds.Tables[0].Rows[i]["project_id"]);       //项目编号
                int pro_type = judge(pro_id);       //项目类型
                project_data project = new project_data() { Project_id = pro_id, Child_name = "--" };
                if (pro_type == 0)              //2013年及之前专项资金项目
                {
                    string sql2 = "select project_name, start_date, finish_date, total_investment, radial_project from T_previously_special_project where project_id = @pro_id";
                    SqlParameter[] parameter2 = { new SqlParameter("@pro_id", SqlDbType.VarChar, 50) { Value = pro_id } };
                    DataRow dr2 = gt.get_content(sql2, parameter2);     //获取2013年项目的基本信息

                    project.Start_time = Convert.ToString(dr2["start_date"]);       //开工日期
                    project.Project_name = Convert.ToString(dr2["project_name"]);       //项目名称
                    project.Finish_time = Convert.ToString(dr2["finish_date"]);         //完工日期
                    project.Project_inves = Convert.ToDouble(dr2["total_investment"]);      //项目总投资
                    project.Is_indirect = Convert.ToString(dr2["radial_project"]);          //辐射性项目
                    project.Excel_name = "2013及之前专项资金项目.xlsx";                  //所在的excel表格
                }
                else
                {               //对口支援或其他项目
                    string sql2 = "select project_name, total_investment, start_date, finish_date, radial_project from T_counterpart_and_other_project where project_id = @pro_id";
                    SqlParameter[] parameter2 = { new SqlParameter("@pro_id", SqlDbType.VarChar, 50) { Value = pro_id } };
                    DataRow dr2 = gt.get_content(sql2, parameter2);     //获取对口支援项目或其他项目的基本信息

                    project.Start_time = Convert.ToString(dr2["start_date"]);       //开工日期
                    project.Project_name = Convert.ToString(dr2["project_name"]);       //项目名称
                    project.Finish_time = Convert.ToString(dr2["finish_date"]);         //完工日期
                    project.Project_inves = Convert.ToDouble(dr2["total_investment"]);      //项目总投资
                    project.Is_indirect = Convert.ToString(dr2["radial_project"]);          //辐射性项目
                    project.Excel_name = "对口支援及其他项目.xlsx";                      //所在的excel表格
                }

                string sql3 = "select * from T_construction_phase where project_id = @pro_id order by year desc";
                SqlParameter[] parameter3 = { new SqlParameter("@pro_id", SqlDbType.VarChar, 50) { Value = pro_id } };
                DataRow dr3 = gt.get_content(sql3, parameter3);     //查询建设状态信息

                string sql4 = "select * from T_figure_progress where project_id = @pro_id order by year desc";
                DataRow dr4 = gt.get_content(sql4, parameter3);         //查询项目形象进度

                if (month == 3)
                {
                    project.Project_progress = Convert.ToDouble(dr4["march_progress"]);
                    project.Construct_state = Convert.ToString(dr3["march_phase"]);
                }
                else if (month == 6)
                {
                    project.Construct_state = Convert.ToString(dr3["june_phase"]);
                    project.Project_progress = Convert.ToDouble(dr4["june_progress"]);
                }
                else if (month == 9)
                {
                    project.Project_progress = Convert.ToDouble(dr4["september_progress"]);
                    project.Construct_state = Convert.ToString(dr3["september_phase"]);
                }
                else
                {
                    project.Project_progress = Convert.ToDouble(dr4["december_progress"]);
                    project.Construct_state = Convert.ToString(dr3["december_phase"]);
                }

                list.Add(project);
            }
        }
        /// <summary>
        /// 2014年及之后专项资金项目
        /// </summary>
        private void query_message_5()
        {
            int month = judge_month();          //判断当前应用几月份的数据
            string sql = "select * from T_subproject_new where involve_community = @community";
            SqlParameter[] parameter = { new SqlParameter("@community", SqlDbType.VarChar, 50) { Value = community_name } };
            DataSet ds = gt.sql_query(sql, parameter);          //查询涉及该小区的所有的子项目

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dr = ds.Tables[0].Rows[i];
                string pro_id = Convert.ToString(dr["project_id"]);     //父项目编号
                project_data project = new project_data()
                {
                    Child_name = Convert.ToString(dr["subproject_name"]),
                    Subproject_id = Convert.ToString(dr["subproject_id"]),          //子项目编号
                    Start_time = Convert.ToString(dr["start_date"]),
                    Finish_time = Convert.ToString(dr["finish_date"]),
                    Is_indirect = Convert.ToString(dr["radial_project"]),
                    Project_id = pro_id
                };

                //查找该项目的父项目的相关信息
                string sql2 = "select project_name from T_subsequent_project where project_id = @pro_id";
                SqlParameter[] parameter2 = { new SqlParameter("@pro_id", SqlDbType.VarChar, 50) { Value = pro_id } };
                DataRow dr2 = gt.get_content(sql2, parameter2);

                project.Project_name = Convert.ToString(dr2["project_name"]);       //项目名称

                //查找该子项目的建设状态
                string sql3 = "select * from T_construction_phase where project_id = @sub_id order by year";
                SqlParameter[] parameter4 = { new SqlParameter("@sub_id", SqlDbType.VarChar, 50) { Value = Convert.ToString(dr["subproject_id"]) } };
                DataRow dr3 = gt.get_content(sql3, parameter4);

                //查询子项目的项目形象进度
                string sql5 = "select * from T_figure_progress where project_id = @sub_id order by year desc";
                DataRow dr5 = gt.get_content(sql5, parameter4);

                if (month == 3)
                {
                    project.Construct_state = Convert.ToString(dr3["march_phase"]);
                    project.Project_progress = Convert.ToDouble(dr5["march_progress"]);
                }
                else if (month == 6)
                {
                    project.Construct_state = Convert.ToString(dr3["june_phase"]);
                    project.Project_progress = Convert.ToDouble(dr5["june_progress"]);
                }
                else if (month == 9)
                {
                    project.Construct_state = Convert.ToString(dr3["september_phase"]);
                    project.Project_progress = Convert.ToDouble(dr5["september_progress"]);
                }
                else
                {
                    project.Construct_state = Convert.ToString(dr3["december_phase"]);
                    project.Project_progress = Convert.ToDouble(dr5["december_progress"]);
                }

                //查找该子项目对应的孙项目并计算项目投资
                double inves = 0;           //项目投资
                string sql4 = "select total_investment from T_grandson_project where subproject_id = @sub_id";
                
                DataSet ds4 = gt.sql_query(sql4, parameter4);
                for (int j = 0; j < ds4.Tables[0].Rows.Count; j++)
                {
                    inves += Convert.ToDouble(ds4.Tables[0].Rows[j]["total_investment"]);
                }
                project.Project_inves = inves;
                project.Excel_name = "2014及以后专项资金项目.xlsx";          //项目所在excel表格
                list.Add(project);
            }
        }

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
    }
}
