using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TTG.DAL.READ
{
    public class read_labor_force
    {
        private read_excel re;
        private const string excel_name = "居民就业现状表";
        private const int start_row = 6;
        public read_labor_force(string path)
        {
            re = new read_excel();
            re.init(path);
        }
        /// <summary>
        /// 读取劳动力表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private TTG.Model.TTGWeb.labor_force read_labor(int row)
        {
            TTG.Model.TTGWeb.labor_force lfm = new Model.TTGWeb.labor_force()
            {
                id = Convert.ToString(re.readcell(row,0)),
                statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                    1)
            };
            read_tools rt = new read_tools();
            const string table_name = "T_labor_force";
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] labor_info = lfm.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, labor_info);
                if (index != -1)
                {
                    string type = labor_info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        labor_info[index].SetValue(lfm, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        labor_info[index].SetValue(lfm, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        labor_info[index].SetValue(lfm, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(labor_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            labor_info[index].SetValue(lfm, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            labor_info[index].SetValue(lfm, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return lfm;
        }
        /// <summary>
        /// 读取插入劳动力表
        /// </summary>
        /// <param name="id"></param>
        public void read_and_insert()
        {
            int max_row = re.getMaxRow();
            for (int i = start_row; i < max_row; i++)
            {
                string num = Convert.ToString(re.readcell(i, 0));
                if (!num.Equals("0"))
                {
                    TTG.Model.TTGWeb.labor_force lfm = read_labor(i);
                    if (!new TTG.DAL.TTGWeb.labor_force().Add(lfm))
                        throw new Exception("劳动力表插入失败！");
                }
            }
        }
        /// <summary>
        /// 插入一列
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="attname"></param>
        /// <param name="unit"></param>
        public void insert_line(int column, string attname, string unit)
        {
            string table_name = "T_labor_force";
            //更新alter_filed表
            DAL.TTGWeb.alter_field af = new TTGWeb.alter_field();
            int count = af.getCount(table_name);
            Model.TTGWeb.alter_field afm = new Model.TTGWeb.alter_field()
            {
                field_name = attname,
                table_name = table_name,
                alter_field_unit = unit,
                alter_type = "add",
                alter_field_name = "tlfunset" + (count + 1)
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
                    if(!es.Update(list[i]))
                        throw new Exception(table_name+"表"+attname+"字段更新失败！");
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
            string table_name = "T_labor_force";
            TTGWeb.excel_structure es = new TTGWeb.excel_structure();
            string property = es.getProperty(excel_name, table_name, column);
            //删除预留字段对应表
            TTGWeb.alter_field af = new TTGWeb.alter_field();
            if (af.isExist(property, table_name))
                if (!af.Delete(property, table_name))
                    throw new Exception("预留字段对应表删除失败！");

            if (!es.delete(column, table_name))
                throw new Exception(property + "字段删除失败！");
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
