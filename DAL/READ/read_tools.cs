using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;

namespace TTG.DAL.READ
{
    public class read_tools
    {
        /// <summary>
        /// 获取指定字段在属性列表中的位置
        /// </summary>
        /// <param name="att"></param>
        /// <param name="prop"></param>
        /// <returns></returns>
        public int getIndex(string att, PropertyInfo[] prop)
        {
            for (int i = 0; i < prop.Length; i++)
            {
                if (prop[i].Name.Equals(att))
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// 将datarow转化成实体类（excel_span_structure
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public Model.TTGWeb.excel_span_structure DataRowToSSModel(DataRow row)
        {
            TTG.Model.TTGWeb.excel_span_structure model = new TTG.Model.TTGWeb.excel_span_structure();
            if (row != null)
            {
                if (row["property"] != null)
                {
                    model.property = row["property"].ToString();
                }
                if (row["excel_name"] != null)
                {
                    model.excel_name = row["excel_name"].ToString();
                }
                if (row["table_name"] != null)
                {
                    model.table_name = row["table_name"].ToString();
                }
                if (row["row_num"] != null && row["row_num"].ToString() != "")
                {
                    model.row_num = int.Parse(row["row_num"].ToString());
                }
                if (row["column_num"] != null && row["column_num"].ToString() != "")
                {
                    model.column_num = int.Parse(row["column_num"].ToString());
                }
            }
            return model;
        }
        /// <summary>
        /// 判断一个字符串是否包含数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool contineNum(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    return true;
            }
            return false;
        }
    }
}
