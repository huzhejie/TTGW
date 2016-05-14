using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace TTG.DAL.READ
{
    public class read_indicator
    {
        private const string excel_name = "小区相关指标分析";
        private read_excel re;
        private read_tools rt;

        public read_indicator(string path)
        {
            re = new read_excel();
            re.init(path);
            rt = new read_tools();
        }
        /// <summary>
        /// 读取小区指标分析表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Model.TTGWeb.Community_Indicator read_indi(string id)
        {
            const string table_name = "T_Community_Indicator";
            Model.TTGWeb.Community_Indicator cim = new Model.TTGWeb.Community_Indicator()
            {
                community_id = id,
                statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            };
            List<Model.TTGWeb.excel_span_structure> list = new DAL.TTGWeb.excel_span_structure().getMessage(excel_name, table_name);
            PropertyInfo[] indi_info = cim.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                Model.TTGWeb.alter_field afm = new DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, indi_info);
                if (index != -1)
                {
                    string type = indi_info[index].PropertyType.Name;
                    object obj = re.readcell(list[i].row_num, list[i].column_num);
                    if (type.Equals("String"))
                        indi_info[index].SetValue(cim, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        indi_info[index].SetValue(cim, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        indi_info[index].SetValue(cim, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(indi_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            indi_info[index].SetValue(cim, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            indi_info[index].SetValue(cim, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段类型： " + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段： " + attname);
            }
            return cim;
        }
        /// <summary>
        /// 读取并插入
        /// </summary>
        /// <param name="id"></param>
        public void read_and_insert(string id)
        {
            if(!new DAL.TTGWeb.Community_Indicator().Add(read_indi(id)))
                throw new Exception("小区指标分析表插入失败！");
        }
        /// <summary>
        /// 插入一行
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="attname"></param>
        /// <param name="unit"></param>
        public void insert_line(int row, int column, string attname, string unit)
        {
            string table_name = "T_Community_Indicator";
            //更新alter_filed表
            DAL.TTGWeb.alter_field af = new TTGWeb.alter_field();
            int count = af.getCount(table_name);
            if (!af.Add(new Model.TTGWeb.alter_field()
            {
                table_name = table_name,
                field_name = attname,
                alter_field_unit = unit,
                alter_type = "add",
                alter_field_name = "tciunset" + (count + 1)
            }))
                throw new Exception("预留字段对应表插入失败！");
            //更新excel_datatable表
            if (column == 7)
            {
                Model.TTGWeb.excel_datatable edm = new Model.TTGWeb.excel_datatable();
                edm.table_end_row++;
                if (new DAL.TTGWeb.excel_datatable().Update(edm))
                    throw new Exception("数据库范围表更新失败！");
            }
            //更新excel_span_structure表
            DAL.TTGWeb.excel_span_structure ess = new TTGWeb.excel_span_structure();
            DataSet ds2 = ess.GetList("excel_name='" + excel_name + "' and row_num>=" + row + " and column_num=" + column);
            int num2 = ds2.Tables[0].Rows.Count;
            List<TTG.Model.TTGWeb.excel_span_structure> less = new List<Model.TTGWeb.excel_span_structure>();
            for (int i = 0; i < num2; i++)
            {
                less.Add(rt.DataRowToSSModel(ds2.Tables[0].Rows[i]));
                less[i].row_num++;
            }
            for (int i = 0; i < num2; i++)
            {
                if (!ess.Update(less[i]))
                {
                    throw new Exception(less[i].table_name + "表" + less[i].property + "字段更新失败！");
                }
            }
            //如果插入的是跨列表，在跨列表上新增一行
            if (ess.isExist(table_name))
            {
                if (!ess.Add(new Model.TTGWeb.excel_span_structure()
                {
                    table_name = table_name,
                    excel_name = excel_name,
                    property = attname,
                    row_num = row,
                    column_num = column
                }))
                    throw new Exception("新增字段插入失败！");
            }
        }
        /// <summary>
        /// 删除一行
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public void delete_line(int row, int column)
        {
            string table_name = "T_Community_Indicator";
            DAL.TTGWeb.excel_span_structure ess = new TTGWeb.excel_span_structure();
            DAL.TTGWeb.alter_field af = new TTGWeb.alter_field();
            string property = ess.getProperty(excel_name, table_name, row, column);
            if (!af.isExist(property, table_name))
            {
                if (!af.Delete(property, table_name))
                    throw new Exception("预留字段对应表插入失败！");
            }
            //更新excel_datatable表
            if (column == 7)
            {
                Model.TTGWeb.excel_datatable edm = new Model.TTGWeb.excel_datatable();
                edm.table_end_row--;
                if (new DAL.TTGWeb.excel_datatable().Update(edm))
                    throw new Exception("数据库范围表更新失败！");
            }
            //删除字段
            if (!ess.delete(row, column, table_name))
                throw new Exception("字段删除失败！");
            //更新excel_span_structure表
            DataSet ds2 = ess.GetList("excel_name='" + excel_name + "' and row_num>" + row + " and column_num=" + column);
            int num2 = ds2.Tables[0].Rows.Count;
            List<TTG.Model.TTGWeb.excel_span_structure> less = new List<Model.TTGWeb.excel_span_structure>();
            for (int i = 0; i < num2; i++)
            {
                less.Add(rt.DataRowToSSModel(ds2.Tables[0].Rows[i]));
                less[i].row_num--;
            }
            for (int i = 0; i < num2; i++)
            {
                if (!ess.Update(less[i]))
                {
                    throw new Exception(less[i].table_name + "表" + less[i].property + "字段更新失败！");
                }
            }
        }
    }
}
