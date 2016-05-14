using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TTG.DAL.READ
{
    public class read_wcommunity
    {
        private read_excel re;
        private read_tools rt;
        private const string excel_name = "社区调查表";

        public read_wcommunity(string path)
        {
            re = new read_excel();
            re.init(path);
            rt = new read_tools();
        }
        /// <summary>
        /// 读取社会调查表
        /// </summary>
        /// <returns></returns>
        private TTG.Model.TTGWeb.wcommunity read_wco()
        {
            const string table_name="T_wcommunity";
            TTG.Model.TTGWeb.wcommunity wco = new Model.TTGWeb.wcommunity() {
                //statistics_date = Convert.ToDateTime("2013/1/1") 
                statistics_date = Convert.ToDateTime("2014/1/1")
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] wco_info = wco.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm = new DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, wco_info);
                if (index != -1)
                {
                    string type = wco_info[index].PropertyType.Name;
                    object obj = re.readcell(list[i].row_column_num, 2);
                    if (type.Equals("String"))
                        wco_info[index].SetValue(wco, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        wco_info[index].SetValue(wco, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        wco_info[index].SetValue(wco, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(wco_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            wco_info[index].SetValue(wco, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            wco_info[index].SetValue(wco, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return wco;
        }
        /// <summary>
        /// 插入社会调查表
        /// </summary>
        /// <returns></returns>
        private bool insert_wco()
        {
            return new DAL.TTGWeb.wcommunity().Add(read_wco());
        }
        /// <summary>
        /// 读取并插入社会调查表
        /// </summary>
        public void read_and_insert()
        {
            if (!insert_wco())
                throw new Exception("社区调查表插入失败！");
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
            string table_name = "T_wcommunity";
            //更新alter_filed表
            TTG.DAL.TTGWeb.alter_field af = new TTGWeb.alter_field();
            int count = af.getCount(table_name);
            if (!af.Add(new Model.TTGWeb.alter_field()
            {
                field_name = attname,
                table_name = table_name,
                alter_field_unit = unit,
                alter_type = "add",
                alter_field_name = "twunset" + (count + 1)
            }))
            {
                throw new Exception("预留字段对应表插入失败！");
            }
            //更新excel_datetable表
            TTG.DAL.TTGWeb.excel_datatable ed = new TTGWeb.excel_datatable();
            TTG.Model.TTGWeb.excel_datatable edm = ed.GetModel(table_name);
            edm.table_end_row++;
            if (!ed.Update(edm))
            {
                throw new Exception("数据库范围表更新失败！");
            }
            //更新excel_structure表
            TTG.DAL.TTGWeb.excel_structure es = new TTGWeb.excel_structure();
            List<TTG.Model.TTGWeb.excel_structure> list = es.getMessage(excel_name, table_name);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].row_column_num >= row)
                    list[i].row_column_num++;
            }
            for (int i = 0; i < list.Count; i++)
                if (!es.Update(list[i]))
                    throw new Exception(list[i].table_name + "表" + list[i].property + "字段插入失败！");
            if (!es.Add(new Model.TTGWeb.excel_structure()
            {
                table_name = table_name,
                excel_name = excel_name,
                property = attname,
                row_column_num = row
            }))
                throw new Exception("新增字段插入失败！");
        }

        /// <summary>
        /// 删除一行
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public void delete_line(int row, int column)
        {
            const string table_name = "T_wcommunity";
            DAL.TTGWeb.excel_structure es = new TTGWeb.excel_structure();
            string property = es.getProperty(excel_name, table_name, row);
            //更新alter_filed表
            DAL.TTGWeb.alter_field af = new TTGWeb.alter_field();
            if (af.isExist(property, table_name))
            {
                if (!af.Delete(property, table_name))
                    throw new Exception("预留字段对应表删除失败！");
            }
            //更新excel_datatable表
            TTG.DAL.TTGWeb.excel_datatable ed = new TTGWeb.excel_datatable();
            TTG.Model.TTGWeb.excel_datatable edm = ed.GetModel(table_name);
            edm.table_end_row--;
            if (!ed.Update(edm))
            {
                throw new Exception("数据库范围表更新失败！");
            }
            //删除字段
            if (!es.delete(row, table_name))
                throw new Exception("字段删除失败！");
            //更新excel_structure表
            List<TTG.Model.TTGWeb.excel_structure> list = es.getMessage(excel_name, table_name);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].row_column_num > row)
                    list[i].row_column_num--;
            }
            for (int i = 0; i < list.Count; i++)
                if (!es.Update(list[i]))
                    throw new Exception(list[i].table_name + "表" + list[i].property + "字段插入失败！");
        }
    }
}
