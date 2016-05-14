using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TTG.DAL.READ
{
    public class read_problems_first
    {
        private read_excel re = new read_excel();
        private read_tools rt = new read_tools();
        private const string excel_name = "小区效果标准表";
        private int start_row = 6;          //起始行
        public read_problems_first(string path)
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
        /// 读取小区统建房问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="fill_time">填报时间</param>
        /// <param name="row">第row行</param>
        /// <returns>返回实体类</returns>
        private Model.TTGWeb.community_council_building_problem read_building(string id, string type, DateTime fill_time, int row, int year)
        {
            Model.TTGWeb.community_council_building_problem model = new Model.TTGWeb.community_council_building_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = fill_time,
                complete_year = year
            };
            const string table_name = "T_community_council_building_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 读取小区道路问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="fill_time">填报时间</param>
        /// <param name="row">行号</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_road_problem read_road(string id, string type, DateTime fill_time, int row, int year)
        {
            Model.TTGWeb.community_road_problem model = new Model.TTGWeb.community_road_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = fill_time,
                complete_year = year
            };
            const string table_name = "T_community_road_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 读取小区宅间路问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">小区类型</param>
        /// <param name="fill_time">填报时间</param>
        /// <param name="row">行号</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_bet_dwellings_road_problem read_bet_dwelling(string id, string type, DateTime fill_time, int row, int year)
        {
            Model.TTGWeb.community_bet_dwellings_road_problem model = new Model.TTGWeb.community_bet_dwellings_road_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = fill_time,
                complete_year = year
            };
            const string table_name = "T_community_bet_dwellings_road_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 读取小区供水问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="fill_time">填报时间</param>
        /// <param name="row">行号</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_water_supply_problem read_water_supply(string id, string type, DateTime fill_time, int row, int year)
        {
            Model.TTGWeb.community_water_supply_problem model = new Model.TTGWeb.community_water_supply_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = fill_time,
                complete_year = year
            };
            const string table_name = "T_community_water_supply_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 读取小区供电问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="fill_time">填报时间</param>
        /// <param name="row">行号</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_elec_supply_problem read_elec_supply(string id, string type, DateTime fill_time, int row, int year)
        {
            Model.TTGWeb.community_elec_supply_problem model = new Model.TTGWeb.community_elec_supply_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = fill_time,
                complete_year = year
            };
            const string table_name = "T_community_elec_supply_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 读取小区照明问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="fill_time">填报时间</param>
        /// <param name="row">行号</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_lighting_problem read_lingting(string id, string type, DateTime fill_time, int row, int year)
        {
            Model.TTGWeb.community_lighting_problem model = new Model.TTGWeb.community_lighting_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = fill_time,
                complete_year = year
            };
            const string table_name = "T_community_lighting_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 读取小区绿化问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="fill_time">填报时间</param>
        /// <param name="row">行号</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_greening_problem read_greening(string id, string type, DateTime fill_time, int row, int year)
        {
            Model.TTGWeb.community_greening_problem model = new Model.TTGWeb.community_greening_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = fill_time,
                complete_year = year
            };
            const string table_name = "T_community_greening_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 读取小区消防问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="fill_time">填报时间</param>
        /// <param name="row">行号</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_ff_problem read_fire(string id, string type, DateTime fill_time, int row, int year)
        {
            Model.TTGWeb.community_ff_problem model = new Model.TTGWeb.community_ff_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = fill_time,
                complete_year = year
            };
            const string table_name = "T_community_ff_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 读取小区排水问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="fill_time">填报时间</param>
        /// <param name="row">行号</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_water_drain_problem read_water_drain(string id, string type, DateTime fill_time, int row, int year)
        {
            Model.TTGWeb.community_water_drain_problem model = new Model.TTGWeb.community_water_drain_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = fill_time,
                complete_year = year
            };
            const string table_name = "T_community_water_drain_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 读取小区环卫问题表
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="fill_time">填报时间</param>
        /// <param name="row">行号</param>
        /// <returns>实体类</returns>
        private Model.TTGWeb.community_sanitation_problem read_sanitation(string id, string type, DateTime fill_time, int row, int year)
        {
            Model.TTGWeb.community_sanitation_problem model = new Model.TTGWeb.community_sanitation_problem()
            {
                community_id = id,
                community_fill_type = type,
                statistics_date = fill_time,
                complete_year = year
            };
            const string table_name = "T_community_sanitation_problem";
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            insert_tables(properties, list, model, row);
            return model;
        }
        /// <summary>
        /// 将第row行数据插入数据库中
        /// </summary>
        /// <param name="id">小区编号</param>
        /// <param name="type">填报类型</param>
        /// <param name="time">填报时间</param>
        /// <param name="row">行号</param>
        private void insert_line(string id, string type, DateTime time, int row, int year)
        {
            if (!new DAL.TTGWeb.community_council_building_problem().Add(read_building(id, type, time, row, year)))
                throw new Exception("统建房插入失败！");
            if (!new DAL.TTGWeb.community_road_problem().Add(read_road(id, type, time, row, year)))
            {
                throw new Exception("小区道路问题表插入失败！");
            }
            if (!new DAL.TTGWeb.community_bet_dwellings_road_problem().Add(read_bet_dwelling(id, type, time, row, year)))
                throw new Exception("小区宅间路问题表插入失败！");
            if (!new DAL.TTGWeb.community_water_supply_problem().Add(read_water_supply(id, type, time, row, year)))
                throw new Exception("小区供水问题表插入失败！");
            if (!new DAL.TTGWeb.community_elec_supply_problem().Add(read_elec_supply(id, type, time, row, year)))
                throw new Exception("小区供电问题表插入失败！");
            if (!new DAL.TTGWeb.community_lighting_problem().Add(read_lingting(id, type, time, row, year)))
                throw new Exception("小区照明问题表插入失败！");
            if (!new DAL.TTGWeb.community_greening_problem().Add(read_greening(id, type, time, row, year)))
                throw new Exception("小区绿化问题表插入失败！");
            if (!new DAL.TTGWeb.community_ff_problem().Add(read_fire(id, type, time, row, year)))
                throw new Exception("小区消防问题表插入失败！");
            if (!new DAL.TTGWeb.community_water_drain_problem().Add(read_water_drain(id, type, time, row, year)))
                throw new Exception("小区排水问题表插入失败！");
            if (!new DAL.TTGWeb.community_sanitation_problem().Add(read_sanitation(id, type, time, row, year)))
                throw new Exception("小区环卫问题表插入失败！");
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
