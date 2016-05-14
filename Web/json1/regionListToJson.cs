using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using ESRI.ArcGIS.ADF.Web.UI.WebControls;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design.Designers;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design.Editors;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design.Editors.Resources.LayerDefinitions;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Exceptions;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.RenderingEngine;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Tools;

namespace TTG.Web.json1
{
    public class regionListToJson : json1.jsonTools
    {
        private StringBuilder result = new StringBuilder();
        private DAL.GET.get_search gs;
        private DataSet ds;

        public regionListToJson(String province)
        {
            gs = new DAL.GET.get_search();
        }

        public regionListToJson(String province, String county)
        {
            gs = new DAL.GET.get_search();
            ds = gs.get_community(province, county);
        }

        public string getResult()
        {
            List<String> list = dsToList();
            result.Append("{");
            addAttribute("regionList");
            result.Append("[");
            foreach (String s in list)
            {
                addValue(s);
                result.Append(",");
            }
            result.Remove(result.Length - 1, 1);
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

        private List<String> dsToList()
        {
            List<String> list = new List<string>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                list.Add(ds.Tables[0].Rows[i]["community_name"].ToString());
            }
            return list;
        }
    }
}