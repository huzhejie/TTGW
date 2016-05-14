using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TTG.DAL.READ
{
    public class read_project_physical
    {
        private string excel_name = "小区项目实物表";
        private string table_name = "T_project_physical";
        private const int title_row = 1;
        private const int start_row = 3;
        private Model.TTGWeb.project_physical model;

        private read_excel re;
        private read_tools rt;

        public read_project_physical(string path)
        {
            re = new read_excel();
            re.init(path);
            rt = new read_tools();
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
        /// 读取内容
        /// </summary>
        /// <param name="row"></param>
        private Model.TTGWeb.project_physical read_table(int row)
        {
            model = new Model.TTGWeb.project_physical()
            {
                fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                if (attname.Equals("complete_amount"))          //如果是完成数量
                {
                    string content = Convert.ToString(re.readcell(title_row, list[i].row_column_num));
                    string[] time = getNum(content);
                    //string temp = time[0] + "年" + time[1] + "日";
                    //model.complete_time = Convert.ToDateTime(temp);
                    model.year = Convert.ToInt32(time[0]);
                    model.june_quantity = Convert.ToDecimal(re.readcell(row, list[i].row_column_num++));
                    model.december_quantity = Convert.ToDecimal(re.readcell(row, list[i].row_column_num++));
                    continue;
                }
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
                        else if (in_type.Equals("System.DateTime"))
                            info[index].SetValue(model, Convert.ToDateTime(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return model;
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
                    if (!new DAL.TTGWeb.project_physical().Add(read_table(i)))
                        throw new Exception("小区实物量表插入失败！");
                }
            }
        }
        /// <summary>
        /// 插入一行
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
        /// 删掉一列
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
