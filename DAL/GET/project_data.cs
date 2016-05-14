using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTG.DAL.GET
{
    public class project_data
    {
        private string project_id, project_name,        //项目名称、编号
            child_name,            //单项工程名称
            construct_state,        //建设状态
            start_time,             //开工时间
            finish_time,            //竣工日期
            is_indirect;            //功能辐射性项目
        private string subproject_id;       //子项目编号

        private double project_progress;           //项目形象进度

        public double Project_progress
        {
            get { return project_progress; }
            set { project_progress = value; }
        }

        public string Subproject_id
        {
            get { return subproject_id; }
            set { subproject_id = value; }
        }
        private string excel_name;              //所在excel表名

        public string Excel_name
        {
            get { return excel_name; }
            set { excel_name = value; }
        }

        public string Finish_time
        {
            get { return finish_time; }
            set { finish_time = value; }
        }

        public string Start_time
        {
            get { return start_time; }
            set { start_time = value; }
        }
        private double project_inves;               //项目投资

        public double Project_inves
        {
            get { return project_inves; }
            set { project_inves = value; }
        }

        public string Project_id
        {
            get { return project_id; }
            set { project_id = value; }
        }

        public string Project_name
        {
            get { return project_name; }
            set { project_name = value; }
        }

        public string Child_name
        {
            get { return child_name; }
            set { child_name = value; }
        }

        public string Construct_state
        {
            get { return construct_state; }
            set { construct_state = value; }
        }

        public string Is_indirect
        {
            get { return is_indirect; }
            set { is_indirect = value; }
        }
    }
}
