using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;

namespace TTG.DAL.READ
{
    public class read_enterprise
    {
        private const string excel_name = "小区周边经济环境现状";
        private const string table_name = "T_enterprise";
        private const int start_row = 4;
        private read_excel re;
        private read_tools rt;

        public read_enterprise(string path)
        {
            re = new read_excel();
            re.init(path);
            rt = new read_tools();
        }

        /// <summary>
        /// 读取统建房明细表
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.enterprise read_enter(int row)
        {
            Model.TTGWeb.enterprise enter = new Model.TTGWeb.enterprise()
            {
                statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] enter_info = enter.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, enter_info);
                if (index != -1)
                {
                    string type = enter_info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        enter_info[index].SetValue(enter, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        enter_info[index].SetValue(enter, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        enter_info[index].SetValue(enter, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(enter_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            enter_info[index].SetValue(enter, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            enter_info[index].SetValue(enter, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return enter;
        }

        /// <summary>
        /// 读取并插入
        /// </summary>
        public void read_and_insert()
        {
            int max_row = re.getMaxRow();
            for (int i = start_row; i < max_row; i++)
            {
                string num = Convert.ToString(re.readcell(i, 0));
                if (!num.Equals("0"))
                {
                    if (!new DAL.TTGWeb.enterprise().Add(read_enter(i)))
                        throw new Exception("企业表插入失败！");
                }
            }
        }
        /// <summary>
        /// 插入一列
        /// </summary>
        /// <param name="column"></param>
        /// <param name="attname"></param>
        /// <param name="unit"></param>
        public void insert_line(int column, string attname, string unit)
        {
            //更新alter_filed表
            DAL.TTGWeb.alter_field af = new TTGWeb.alter_field();
            int count = af.getCount(table_name);
            Model.TTGWeb.alter_field afm = new Model.TTGWeb.alter_field()
            {
                field_name = attname,
                table_name = table_name,
                alter_field_unit = unit,
                alter_type = "add",
                alter_field_name = "teunset" + (count + 1)
            };
            if (!af.Add(afm))
                throw new Exception("新增字段添加失败！");

            //更新excel_structure表
            TTGWeb.excel_structure es = new TTGWeb.excel_structure();
            List<Model.TTGWeb.excel_structure> list = new TTGWeb.excel_structure().getMessage(excel_name, table_name);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].row_column_num >= column)
                {
                    list[i].row_column_num++;
                    if (!es.Update(list[i]))
                        throw new Exception(table_name + "表" + attname + "字段更新失败！");
                }

            }

            //向excel_structure表中插入数据
            if (!es.Add(new Model.TTGWeb.excel_structure()
            {
                excel_name = excel_name,
                property = attname,
                row_column_num = column,
                table_name = table_name

            }))
                throw new Exception("新增字段插入失败！");
        }

        /// <summary>
        /// 删除一列
        /// </summary>
        /// <param name="column"></param>
        public void delete_line(int column)
        {
            TTGWeb.excel_structure es = new TTGWeb.excel_structure();
            string property = es.getProperty(excel_name, table_name, column);
            //删除预留字段对应表的数据
            TTGWeb.alter_field af = new TTGWeb.alter_field();
            if (af.isExist(property, table_name))
                if (!af.Delete(property, table_name))
                    throw new Exception("预留字段对应表删除失败！");
            //删除excel_structure表中的数据
            if (!es.delete(column, table_name))
                throw new Exception(property + "字段删除失败！");
            //更新excel_structure表
            List<Model.TTGWeb.excel_structure> list = es.getMessage(excel_name, table_name);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].row_column_num > column)
                {
                    list[i].row_column_num--;
                    if (!es.Update(list[i]))
                    {
                        throw new Exception(list[i].property + "字段更新失败！");
                    }
                }

            }
        }
    }
}
