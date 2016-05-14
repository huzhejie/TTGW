using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using TTG.DAL.GET;

namespace TTG.Web.json1
{
    public class projectToJson : jsonTools
    {
        private StringBuilder result = new StringBuilder();
        private DAL.GET.get_project gp;

        public projectToJson(String province, String county, String community)
        {
            gp = new DAL.GET.get_project(province, county, community);
        }

        public string getResult()
        {
            result.Append("{");
            addAttribute("projectList");
            result.Append("[");
            foreach (project_data d in gp.List)
            {
                
                result.Append("{");
                addAttribute("projectID");
                addValue(d.Project_id);
                result.Append(",");
                addAttribute("projectName");
                addValue(d.Project_name);
                result.Append(",");
                addAttribute("childName");
                addValue(d.Child_name);
                result.Append(",");
                addAttribute("constructState");
                addValue(d.Construct_state);
                result.Append(",");
                addAttribute("startTime");
                addValue(d.Start_time);
                result.Append(",");
                addAttribute("finishTime");
                addValue(d.Finish_time);
                result.Append(",");
                addAttribute("projectInvest");
                addValue(d.Project_inves);
                result.Append(",");
                addAttribute("isIndirect");
                addValue(d.Is_indirect);
                result.Append(",");
                addAttribute("projectProgress");
                addValue(d.Project_progress);
                
                result.Append("}");
                result.Append(",");
            }
            if (gp.List.Count != 0)
            {
                result.Remove(result.Length - 1, 1);
            }
            result.Append("]");
            result.Append("}");

            return result.ToString();
        }

        public void addAttribute(String attr)
        {
            result.Append("\"" + attr + "\":");
        }


        public void addValue(String value)
        {
            if (value == null || value == "")
            {
                value = "--";
            }
            else
                result.Append("\"" + value + "\"");
        }

        public void addValue(double value)
        {
            if (value.ToString() == "非数字")
            {
                result.Append("--");
            }
            else
                result.Append("\"" + value.ToString("0.00") + "\"");
        }

        public void addValue(int value)
        {
            result.Append("\"" + value + "\"");
        }
    }
}