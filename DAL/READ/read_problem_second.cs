using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TTG.DAL.READ
{
    public class read_problem_second
    {
        private const string excel_name = "小区效果标准表续表";
        private read_excel re = new read_excel();
        private read_tools rt = new read_tools();
        private int start_row = 6;

        public read_problem_second(string path)
        {
            re.init(path);
        }

        /// <summary>
        /// 将第row行数据插入到数据库中
        /// </summary>
        /// <param name="properties">model类的字段列表</param>
        /// <param name="list">model类中表结构</param>
        /// <param name="model">model类</param>
        /// <param name="row">第row行</param>
        private void insert_tables(PropertyInfo[] properties, List<Model.TTGWeb.excel_structure> list, Object model, int row)
        {
            for (int i = 0; i < list.Count; i++)
            {
                string attribute = list[i].property;            //获取字段名
                int index = rt.getIndex(attribute, properties);         //获取字段在字段列表中位置
                if (index != -1)
                {
                    string type = properties[index].PropertyType.Name;          //获取字段类型
                    object obj = re.readcell(row, list[i].row_column_num);          //读取excel表中的内容
                    if (type.Equals("String"))
                        properties[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        properties[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        properties[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else if (type.Equals("DateTime"))
                        properties[index].SetValue(model, DateTime.FromOADate(Convert.ToDouble(obj)), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(properties[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            properties[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            properties[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else if (type.Equals("System.DateTime"))
                            properties[index].SetValue(model, DateTime.FromOADate(Convert.ToDouble(obj)), null);
                        else
                            throw new Exception("找不到字段类型： " + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段： " + attribute);
            }
        }
        /// <summary>
        /// 读取幼儿园问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="time">填报时间</param>
        /// <param name="row">行号</param>
        /// <param name="year">年份</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_kindergarten_problem read_kindergarten(string id, string type, DateTime time, int row, int year)
        {
            Model.TTGWeb.community_kindergarten_problem model = new Model.TTGWeb.community_kindergarten_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = time,
                complete_year = year
            };
            const string table_name = "T_community_kindergarten_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 读取小区医疗问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="time">填报时间</param>
        /// <param name="row">行号</param>
        /// <param name="year">问题年份</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_medical_problem read_medical(string id, string type, DateTime time, int row, int year)
        {
            Model.TTGWeb.community_medical_problem model = new Model.TTGWeb.community_medical_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = time,
                complete_year = year
            };
            const string table_name = "T_community_medical_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 读取小区文体问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="time">填报时间</param>
        /// <param name="row">行号</param>
        /// <param name="year">问题年份</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_cultrue_sports_problem read_culture_sports(string id, string type, DateTime time, int row, int year)
        {
            Model.TTGWeb.community_cultrue_sports_problem model = new Model.TTGWeb.community_cultrue_sports_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = time,
                complete_year = year
            };
            const string table_name = "T_community_cultrue_sports_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 读取小区商贸服务问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="time">填报时间</param>
        /// <param name="row">行号</param>
        /// <param name="year">问题年份</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_commerce_service_problem read_commerce(string id, string type, DateTime time, int row, int year)
        {
            Model.TTGWeb.community_commerce_service_problem model = new Model.TTGWeb.community_commerce_service_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = time,
                complete_year = year
            };
            const string table_name = "T_community_commerce_service_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 读取小区商气人气问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="time">填报时间</param>
        /// <param name="row">行号</param>
        /// <param name="year">问题年份</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_business_pop_problem read_business(string id, string type, DateTime time, int row, int year)
        {
            Model.TTGWeb.community_business_pop_problem model = new Model.TTGWeb.community_business_pop_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = time,
                complete_year = year
            };
            const string table_name = "T_community_business_pop_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 读取小区社区服务问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="time">填报时间</param>
        /// <param name="row">行号</param>
        /// <param name="year">问题年份</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_service_problem read_service(string id, string type, DateTime time, int row, int year)
        {
            Model.TTGWeb.community_service_problem model = new Model.TTGWeb.community_service_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = time,
                complete_year = year
            };
            const string table_name = "T_community_service_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 读取小区停车问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="time">填报时间</param>
        /// <param name="row">行号</param>
        /// <param name="year">问题年份</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_parking_problem read_parking(string id, string type, DateTime time, int row, int year)
        {
            Model.TTGWeb.community_parking_problem model = new Model.TTGWeb.community_parking_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = time,
                complete_year = year
            };
            const string table_name = "T_community_parking_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }

        private void insert_line(string id, string type, DateTime time, int row, int year)
        {
            if (!new DAL.TTGWeb.community_kindergarten_problem().Add(read_kindergarten(id, type, time, row, year)))
                throw new Exception("幼儿园问题表插入失败！");
            if (!new DAL.TTGWeb.community_medical_problem().Add(read_medical(id, type, time, row, year)))
                throw new Exception("小区医疗问题表插入失败！");
            if (!new DAL.TTGWeb.community_cultrue_sports_problem().Add(read_culture_sports(id, type, time, row, year)))
                throw new Exception("小区文体问题表插入失败！");
            if (!new DAL.TTGWeb.community_commerce_service_problem().Add(read_commerce(id, type, time, row, year)))
                throw new Exception("小区商贸服务问题表插入失败！");
            if (!new DAL.TTGWeb.community_business_pop_problem().Add(read_business(id, type, time, row, year)))
                throw new Exception("小区商气人气问题表插入失败！");
            if (!new DAL.TTGWeb.community_service_problem().Add(read_service(id, type, time, row, year)))
                throw new Exception("小区社区服务问题表插入失败！");
            if (!new DAL.TTGWeb.community_parking_problem().Add(read_parking(id, type, time, row, year)))
                throw new Exception("小区停车问题表插入失败！");
        }
        /// <summary>
        /// 读取并插入
        /// </summary>
        /// <param name="id">小区编号</param>
        public void read_and_insert(string id)
        {
            DateTime time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            int max = re.getMaxRow();
            string temp = Convert.ToString(re.readcell(start_row, 0));
            while (start_row < max && (!temp.Equals("0")))
            {
                if (temp.Equals("2013年本底"))
                {
                    insert_line(id, "本底", time, start_row, 2013);
                    start_row++;
                }
                else
                {
                    int year = get_year(temp);
                    int span = re.getSpanRows(start_row, 0);
                    for (int i = 0; i < span; )
                    {
                        string type = Convert.ToString(re.readcell(start_row, 1));
                        if (type.Equals("解决"))
                        {
                            int spans = re.getSpanRows(start_row, 1);
                            for (int j = 0; j < spans; j++)
                            {
                                string type_temp = Convert.ToString(re.readcell(start_row, 2));
                                insert_line(id, type + type_temp, time, start_row, year);
                                start_row++;
                                i++;
                            }
                        }
                        else
                        {
                            insert_line(id, type, time, start_row, year);
                            start_row++;
                            i++;
                        }
                    }
                }
                try
                {
                    temp = Convert.ToString(re.readcell(start_row, 0));
                }
                catch (Exception)
                {
                    break;
                }
            }
        }
        /// <summary>
        /// 获取年份
        /// </summary>
        /// <param name="str">包含年份的字符串</param>
        /// <returns>年份</returns>
        private int get_year(string str)
        {
            return Convert.ToInt32(str.Substring(0, str.Length - 1));
        }
    }
}
