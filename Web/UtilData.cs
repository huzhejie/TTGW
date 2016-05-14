using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Text;
using System.Data;
using ESRI.ArcGIS.ADF.Web.UI.WebControls;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design.Designers;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design.Editors;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design.Editors.Resources.LayerDefinitions;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Exceptions;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.RenderingEngine;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Tools;

namespace TTG.Web
{
    public class UtilData
    {
        /// <summary>
        /// 将DataTable 转换成为json字符串
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ToJson(DataTable dt)
        {
            if (dt == null)
                return "";

            StringBuilder jsonString = new StringBuilder();
            jsonString.Append("[");
            DataRowCollection drc = dt.Rows;
            for (int i = 0; i < drc.Count; i++)
            {
                jsonString.Append("{");
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    string strKey = dt.Columns[j].ColumnName;
                    if (strKey == "Shape")
                        continue;
                    string strValue = drc[i][j].ToString();
                    Type type = dt.Columns[j].DataType;
                    jsonString.Append("\"" + strKey + "\":");
                    strValue = StringFormat(strValue, type);
                    if (j < dt.Columns.Count - 1)
                    {
                        jsonString.Append(strValue + ",");
                    }
                    else
                    {
                        jsonString.Append(strValue);
                    }
                }
                jsonString.Append("},");
            }
            jsonString.Remove(jsonString.Length - 1, 1);
            jsonString.Append("]");
            return jsonString.ToString();
        }

        /// <summary>
        /// 将sortedlist转换成为json字符串
        /// </summary>
        /// <param name="sl"></param>
        /// <returns></returns>
        public static string ToJson(SortedList sl)
        {
            if (sl == null)
                return "";

            StringBuilder jsonString = new StringBuilder();
            jsonString.Append("{");

            for (int i = 0; i < sl.Count; i++)
            {
                string strKey = sl.GetKey(i).ToString();
                string strValue = sl.GetByIndex(i).ToString();
                System.Type type = sl.GetByIndex(i).GetType();
                jsonString.Append("\"" + strKey + "\":");
                strValue = StringFormat(strValue, type);
                jsonString.Append(strValue);

                if (i < sl.Count - 1)
                    jsonString.Append(",");
            }
            jsonString.Append("}");

            return jsonString.ToString();
        }

        /// <summary>
        /// 格式化字符型、日期型、布尔型
        /// </summary>
        /// <param name="str"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private static string StringFormat(string str, Type type)
        {
            if (type == typeof(string))
            {
                str = String2Json(str);
                str = "\"" + str + "\"";
            }
            else if (type == typeof(DateTime))
            {
                str = "\"" + str + "\"";
            }
            else if (type == typeof(bool))
            {
                str = str.ToLower();
            }
            else if (type != typeof(string) && string.IsNullOrEmpty(str))
            {
                str = "\"" + str + "\"";
            }
            return str;
        }

        /// <summary>
        /// 过滤特殊字符
        /// </summary>
        /// <param name="s">字符串</param>
        /// <returns>json字符串</returns>
        private static string String2Json(String s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s.ToCharArray()[i];
                switch (c)
                {
                    case '\"':
                        sb.Append("\\\""); break;
                    case '\\':
                        sb.Append("\\\\"); break;
                    case '/':
                        sb.Append("\\/"); break;
                    case '\b':
                        sb.Append("\\b"); break;
                    case '\f':
                        sb.Append("\\f"); break;
                    case '\n':
                        sb.Append("\\n"); break;
                    case '\r':
                        sb.Append("\\r"); break;
                    case '\t':
                        sb.Append("\\t"); break;
                    default:
                        sb.Append(c); break;
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 从数据库获取callout需要用到的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static SortedList getCalloutDataById(int id)
        {
            SortedList data = new SortedList();

            data.Add("UrlDetail", "www.baidu.com");//详细信息的跳转页面
            data.Add("Name", "样例名称" + id);//名字
            data.Add("UrlImag", "");//图片的保存地址
            data.Add("Address", "样例名称" + id + "对应的地址");//对应的地址
            data.Add("Content", "样例名称" + id + "对应的概要信息内容");//对应的概要信息
            return data;
        }
    }
}