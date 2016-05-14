using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace TTG.DAL.GET
{
    /// <summary>
    /// 获取项目进度
    /// </summary>
    public class get_project_progress
    {
        private get_tools gt = new get_tools();
        private List<project_model> list = new List<project_model>();       //存储项目基本信息

        public List<project_model> List
        {
            get { return list; }
            set { list = value; }
        }


        public void get_progress(string county, string community)
        {
            int month = get_month();        //获取当前最新的月份
            string sql = "select project_id from T_project_community where county_name = @county and community_name = @community";      //查询涉及该小区项目的编号（项目可能为2013年专项资金项目也可能为对口支援项目）
            SqlParameter[] parameter = {
                                           new SqlParameter("@county", SqlDbType.VarChar, 50){Value = county},
                                           new SqlParameter("@community", SqlDbType.VarChar, 50){Value = community}
                                       };
            DataSet ds = gt.sql_query(sql, parameter);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                string pro_id = Convert.ToString(ds.Tables[0].Rows[i]["project_id"]);
                int type = judge(pro_id);
                SqlParameter[] parameter2 = { new SqlParameter("@pro_id", SqlDbType.VarChar, 50) { Value = pro_id } };
                project_model pm = new project_model() { Project_id = pro_id, Community = community };
                if (type == 0)          //2013年专项资金项目
                {
                    string sql2 = "select * from T_previously_special_project where project_id = @pro_id";
                    DataRow dr2 = gt.get_content(sql2, parameter2);         //查询该项目的基本信息

                    pm.Project_name = Convert.ToString(dr2["project_name"]);
                }
                else
                {
                    string sql2 = "select * from T_counterpart_and_other_project where project_id = @pro_id";
                    DataRow dr2 = gt.get_content(sql2, parameter2);
                    pm.Project_name = Convert.ToString(dr2["project_name"]);
                }
                string sql3 = "select * from T_figure_progress where project_id = @pro_id order by year desc";
                DataRow dr3 = gt.get_content(sql3, parameter2);     //查询该项目的形象进度
                if (month == 3)
                    pm.Figure_progress = Convert.ToDouble(dr3["march_progress"]);
                else if (month == 6)
                    pm.Figure_progress = Convert.ToDouble(dr3["june_progress"]);
                else if (month == 9)
                    pm.Figure_progress = Convert.ToDouble(dr3["september_progress"]);
                else if (month == 12)
                    pm.Figure_progress = Convert.ToDouble(dr3["december_progress"]);
                list.Add(pm);
            }

            string sql4 = "select * from T_subproject_new where involve_community = @community";
            SqlParameter[] parameter4 = { new SqlParameter("@community", SqlDbType.VarChar, 50) { Value = community } };
            DataSet ds4 = gt.sql_query(sql4, parameter4);           //与该小区相关的子项目的信息
            for (int i = 0; i < ds4.Tables[0].Rows.Count; i++)
            {
                string pro_id = Convert.ToString(ds4.Tables[0].Rows[i]["subproject_id"]);       //子项目编号
                project_model pm = new project_model()
                {
                    Community = community,
                    Project_id = pro_id,
                    Project_name = Convert.ToString(ds4.Tables[0].Rows[i]["subproject_name"])
                };
                SqlParameter[] parameter2 = { new SqlParameter("@pro_id", SqlDbType.VarChar, 50) { Value = pro_id } };
                string sql3 = "select * from T_figure_progress where project_id = @pro_id order by year desc";
                DataRow dr3 = gt.get_content(sql3, parameter2);     //查询该项目的形象进度
                if (month == 3)
                    pm.Figure_progress = Convert.ToDouble(dr3["march_progress"]);
                else if (month == 6)
                    pm.Figure_progress = Convert.ToDouble(dr3["june_progress"]);
                else if (month == 9)
                    pm.Figure_progress = Convert.ToDouble(dr3["september_progress"]);
                else if (month == 12)
                    pm.Figure_progress = Convert.ToDouble(dr3["december_progress"]);
                list.Add(pm);
            }
        }

        private int get_month()
        {
            int month = DateTime.Now.Month;
            if (month < 6)
                return 3;
            else if (month < 9)
                return 6;
            else if (month < 12)
                return 9;
            else
                return 12;
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
    }

    /// <summary>
    /// 项目model
    /// </summary>
    public class project_model
    {
        string project_id;

        public string Project_id
        {
            get { return project_id; }
            set { project_id = value; }
        }
        string project_name;

        public string Project_name
        {
            get { return project_name; }
            set { project_name = value; }
        }
        string community;

        public string Community
        {
            get { return community; }
            set { community = value; }
        }
        double figure_progress;     //项目形象进度

        public double Figure_progress
        {
            get { return figure_progress; }
            set { figure_progress = value; }
        }
    }
}
