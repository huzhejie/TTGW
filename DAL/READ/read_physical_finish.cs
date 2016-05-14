using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;

namespace TTG.DAL.READ
{
    public class read_physical_finish
    {
        private const string excel_name = "小区项目实物表";
        private const int title_row = 9;
        private const int start_row = 11;
        private read_excel re;
        private read_tools rt;

        public read_physical_finish(string path)
        {
            re = new read_excel();
            re.init(path);
            rt = new read_tools();
        }

        /// <summary>
        /// 读取项目实物量表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Model.TTGWeb.subproject_physical_finish_situation read_physical(int row)
        {
            const string table_name = "T_subproject_physical_finish_situation";
            Model.TTGWeb.subproject_physical_finish_situation model = new Model.TTGWeb.subproject_physical_finish_situation();
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, info);
                if (index != -1)
                {
                    string type = info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        info[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        info[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        info[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            info[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            info[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            read_insert_quality(model.subproject_id, model.project_name, row);
            return model;
        }
        /// <summary>
        /// 读取项目完成量表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="row"></param>
        private void read_insert_quality(string id, string name, int row)
        {
            const string table_name = "T_subproject_accomplish_quantity";
            Model.TTGWeb.excel_datatable edm = new DAL.TTGWeb.excel_datatable().GetModel(table_name);
            int length = edm.table_end_column - edm.table_start_column;
            int column = edm.table_start_column;
            for (int i = 0; i <= length; i++)
            {
                string content = Convert.ToString(re.readcell(title_row, column));
                string[] time = getNum(content);
                string temp = time[0] + "年" + time[1] + "日";
                Model.TTGWeb.subproject_accomplish_quantity model = new Model.TTGWeb.subproject_accomplish_quantity()
                {
                    subproject_id = id,
                    subproject_name = name,
                    statistics_date = Convert.ToDateTime(time),
                    subproject_finish_quantity = Convert.ToDecimal(re.readcell(row, column))
                };
                if (!new DAL.TTGWeb.subproject_accomplish_quantity().Add(model))
                    throw new Exception("项目完成量表插入失败！");
                column++;
            }
        }
        /// <summary>
        /// 获取title栏的时间
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string[] getNum(string str)
        {
            string[] temp = new string[2];
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    temp[count] += str[i++];
                    while (char.IsDigit(str[i]))
                    {
                        temp[count] += str[i++];
                    }
                    count++;
                    if (count == temp.Length)
                        break;
                }
            }
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }
            return temp;
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
                    if (!new DAL.TTGWeb.subproject_physical_finish_situation().Add(read_physical(i)))
                        throw new Exception("小区实物量表插入失败！");
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
            string table_name = "T_subproject_accomplish_quantity";
            Model.TTGWeb.excel_datatable edm = new DAL.TTGWeb.excel_datatable().GetModel(table_name);
            if (!(column > edm.table_start_column && column <= edm.table_end_column))
                table_name = "T_subproject_physical_finish_situation";

            //更新alter_filed表
            DAL.TTGWeb.alter_field af = new TTGWeb.alter_field();
            int count = af.getCount(table_name);
            Model.TTGWeb.alter_field afm = new Model.TTGWeb.alter_field()
            {
                field_name = attname,
                table_name = table_name,
                alter_field_unit = unit,
                alter_type = "add",
                alter_field_name = "trunset" + (count + 1)
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
            string table_name = "T_subproject_accomplish_quantity";
            Model.TTGWeb.excel_datatable edm = new DAL.TTGWeb.excel_datatable().GetModel(table_name);
            if (!(column > edm.table_start_column && column <= edm.table_end_column))
                table_name = "T_subproject_physical_finish_situation";

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
