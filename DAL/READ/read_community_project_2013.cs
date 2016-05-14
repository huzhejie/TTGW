using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TTG.DAL.READ
{
    public class read_community_project_2013
    {
        private read_excel re;
        private read_tools rt;
        private const int row_num = 1;
        private const int start_row = 5;

        private const string excel_name = "2013及之前专项资金项目";
        public read_community_project_2013(string path)
        {
            re = new read_excel();
            re.init(path);
            rt = new read_tools();
        }

        /// <summary>
        /// 读取2013年度三峡后续工作项目表
        /// </summary>
        private void read_row(int row)
        {
            
        }
    }
}
