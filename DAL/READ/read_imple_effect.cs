using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;

namespace TTG.DAL.READ
{
    public class read_imple_effect
    {
        private const string excel_name = "小区效果标准表";
        private const int start_row1 = 6;
        private read_excel re;
        private read_tools rt;

        public read_imple_effect(string path)
        {
            re = new read_excel();
            re.init(path);
            rt = new read_tools();
        }
        /// <summary>
        /// 读取统建房问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_council_building_problem read_council(string id,string fill_type,int row,string year)
        {
            const string table_name = "T_community_council_building_problem";
            Model.TTGWeb.community_council_building_problem ccbp = new Model.TTGWeb.community_council_building_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("")?Convert.ToDateTime("2013年"):Convert.ToDateTime(year)
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] council_info = ccbp.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, council_info);
                if (index != -1)
                {
                    string type = council_info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        council_info[index].SetValue(ccbp, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        council_info[index].SetValue(ccbp, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        council_info[index].SetValue(ccbp, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(council_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            council_info[index].SetValue(ccbp, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            council_info[index].SetValue(ccbp, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return ccbp;
        }
        /// <summary>
        /// 读取道路问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_road_problem read_road(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_road_problem";
            Model.TTGWeb.community_road_problem crp = new Model.TTGWeb.community_road_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("")?Convert.ToDateTime("2013年"):Convert.ToDateTime(year)
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] road_info = crp.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, road_info);
                if (index != -1)
                {
                    string type = road_info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        road_info[index].SetValue(crp, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        road_info[index].SetValue(crp, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        road_info[index].SetValue(crp, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(road_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            road_info[index].SetValue(crp, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            road_info[index].SetValue(crp, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return crp;
        }
        /// <summary>
        /// 读取宅间路问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_bet_dwellings_road_problem read_betroad(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_bet_dwellings_road_problem";
            Model.TTGWeb.community_bet_dwellings_road_problem cbdrp = new Model.TTGWeb.community_bet_dwellings_road_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("") ? Convert.ToDateTime("2013年") : Convert.ToDateTime(year)
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] road_info = cbdrp.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, road_info);
                if (index != -1)
                {
                    string type = road_info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        road_info[index].SetValue(cbdrp, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        road_info[index].SetValue(cbdrp, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        road_info[index].SetValue(cbdrp, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(road_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            road_info[index].SetValue(cbdrp, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            road_info[index].SetValue(cbdrp, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return cbdrp;
        }
        /// <summary>
        /// 读取小区供水问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_water_supply_problem read_watersupply(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_water_supply_problem";
            Model.TTGWeb.community_water_supply_problem cwsp = new Model.TTGWeb.community_water_supply_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("") ? Convert.ToDateTime("2013年") : Convert.ToDateTime(year)
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] water_info = cwsp.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, water_info);
                if (index != -1)
                {
                    string type = water_info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        water_info[index].SetValue(cwsp, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        water_info[index].SetValue(cwsp, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        water_info[index].SetValue(cwsp, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(water_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            water_info[index].SetValue(cwsp, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            water_info[index].SetValue(cwsp, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return cwsp;
        }
        /// <summary>
        /// 读取小区供电问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_elec_supply_problem read_elec_supply(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_elec_supply_problem";
            Model.TTGWeb.community_elec_supply_problem cesp = new Model.TTGWeb.community_elec_supply_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("") ? Convert.ToDateTime("2013年") : Convert.ToDateTime(year)
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] elec_info = cesp.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, elec_info);
                if (index != -1)
                {
                    string type = elec_info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        elec_info[index].SetValue(cesp, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        elec_info[index].SetValue(cesp, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        elec_info[index].SetValue(cesp, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(elec_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            elec_info[index].SetValue(cesp, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            elec_info[index].SetValue(cesp, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return cesp;
        }
        /// <summary>
        /// 读取小区照明问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_lighting_problem read_lighting(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_lighting_problem";
            Model.TTGWeb.community_lighting_problem clp = new Model.TTGWeb.community_lighting_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("") ? Convert.ToDateTime("2013年") : Convert.ToDateTime(year)
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] light_info = clp.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, light_info);
                if (index != -1)
                {
                    string type = light_info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        light_info[index].SetValue(clp, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        light_info[index].SetValue(clp, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        light_info[index].SetValue(clp, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(light_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            light_info[index].SetValue(clp, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            light_info[index].SetValue(clp, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return clp;
        }
        /// <summary>
        /// 读取小区绿化文体表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_greening_problem read_green(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_greening_problem";
            Model.TTGWeb.community_greening_problem model = new Model.TTGWeb.community_greening_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("") ? Convert.ToDateTime("2013年") : Convert.ToDateTime(year)
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
            return model;
        }
        /// <summary>
        /// 读取小区消防问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_ff_problem read_ff(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_ff_problem";
            Model.TTGWeb.community_ff_problem model = new Model.TTGWeb.community_ff_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("") ? Convert.ToDateTime("2013年") : Convert.ToDateTime(year)
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
            return model;
        }
        /// <summary>
        /// 读取小区排水问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_water_drain_problem read_drain(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_water_drain_problem";
            Model.TTGWeb.community_water_drain_problem model = new Model.TTGWeb.community_water_drain_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("") ? Convert.ToDateTime("2013年") : Convert.ToDateTime(year)
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
            return model;
        }
        /// <summary>
        /// 读取小区环卫问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_sanitation_problem read_sanitation(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_sanitation_problem";
            Model.TTGWeb.community_sanitation_problem model = new Model.TTGWeb.community_sanitation_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("") ? Convert.ToDateTime("2013年") : Convert.ToDateTime(year)
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
            return model;
        }
        /// <summary>
        /// 读取小区统建房问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_council_building_problem_finished read_building_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_council_building_problem_finished";
            Model.TTGWeb.community_council_building_problem_finished model = new Model.TTGWeb.community_council_building_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
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
            return model;
        }
        /// <summary>
        /// 读取小区道路问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_road_problem_finished read_road_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_road_problem_finished";
            Model.TTGWeb.community_road_problem_finished model = new Model.TTGWeb.community_road_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
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
            return model;
        }
        /// <summary>
        /// 读取小区宅间路问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_bet_dwellings_road_problem_finished read_bet_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_bet_dwellings_road_problem_finished";
            Model.TTGWeb.community_bet_dwellings_road_problem_finished model = new Model.TTGWeb.community_bet_dwellings_road_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
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
            return model;
        }
        /// <summary>
        /// 读取小区供水问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_water_supply_problem_finished read_water_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_water_supply_problem_finished";
            Model.TTGWeb.community_water_supply_problem_finished model = new Model.TTGWeb.community_water_supply_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
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
            return model;
        }
        /// <summary>
        /// 读取小区供电问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_elec_supply_problem_finished read_elec_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_elec_supply_problem_finished";
            Model.TTGWeb.community_elec_supply_problem_finished model = new Model.TTGWeb.community_elec_supply_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
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
            return model;
        }
        /// <summary>
        /// 读取小区照明问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_lighting_problem_finished read_lighting_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_lighting_problem_finished";
            Model.TTGWeb.community_lighting_problem_finished model = new Model.TTGWeb.community_lighting_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
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
            return model;
        }
        /// <summary>
        /// 读取小区绿化问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_greening_problem_finished read_greeen_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_greening_problem_finished";
            Model.TTGWeb.community_greening_problem_finished model = new Model.TTGWeb.community_greening_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
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
            return model;
        }
        /// <summary>
        /// 读取小区消防问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_ff_problem_finished read_ff_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_ff_problem_finished";
            Model.TTGWeb.community_ff_problem_finished model = new Model.TTGWeb.community_ff_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
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
            return model;
        }
        /// <summary>
        /// 读取小区排水问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_water_drain_problem_finished read_drain_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_water_drain_problem_finished";
            Model.TTGWeb.community_water_drain_problem_finished model = new Model.TTGWeb.community_water_drain_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
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
            return model;
        }
        /// <summary>
        /// 读取小区环卫问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_sanitation_problem_finished read_sanitation_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_sanitation_problem_finished";
            Model.TTGWeb.community_sanitation_problem_finished model = new Model.TTGWeb.community_sanitation_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
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
            return model;
        }
        /// <summary>
        /// 读取并插入问题表,返回值为完成效果表的起始行
        /// </summary>
        /// <param name="id"></param>
        private int read_insert_problem(string id)
        {
            int row = start_row1;
            int column = 0;
            string content = Convert.ToString(re.readcell(row, column++));
            string s1, s2, temp1 = "", temp2 = "";
            string fill_type, year;
            while (!content.Equals("年度"))
            {
                if (content.Equals("0"))
                    content = temp1;
                if (content.Equals("问题总量"))
                {
                    year = "2013年";
                }
                else if (content.Equals("解决总量"))
                {
                    year = "2016年2月";
                }
                else
                {
                    year = content;
                }
                temp1 = content;

                s1 = Convert.ToString(re.readcell(row, column++));
                s2 = Convert.ToString(re.readcell(row, column));
                if (s2.Equals("0"))
                {
                    fill_type = s1;
                }
                else if (s1.Equals("0"))
                {
                    fill_type = temp2 + s2;
                }
                else
                {
                    fill_type = s1 + s2;
                }
                temp2 = s1;
                column = 0;

                //读取表
                if (!new DAL.TTGWeb.community_council_building_problem().Add(read_council(id, fill_type, row, year)))
                    throw new Exception("小区统建房问题表插入失败！");
                if (!new DAL.TTGWeb.community_road_problem().Add(read_road(id, fill_type, row, year)))
                    throw new Exception("小区道路问题表插入失败！");
                if (!new DAL.TTGWeb.community_bet_dwellings_road_problem().Add(read_betroad(id, fill_type, row, year)))
                    throw new Exception("小区宅间路问题表插入失败！");
                if (!new DAL.TTGWeb.community_water_supply_problem().Add(read_watersupply(id, fill_type, row, year)))
                    throw new Exception("小区供水问题表插入失败！");
                if (!new DAL.TTGWeb.community_elec_supply_problem().Add(read_elec_supply(id, fill_type, row, year)))
                    throw new Exception("小区供电问题表插入失败！");
                if (!new DAL.TTGWeb.community_lighting_problem().Add(read_lighting(id, fill_type, row, year)))
                    throw new Exception("小区照明问题表插入失败！");
                if (!new DAL.TTGWeb.community_greening_problem().Add(read_green(id, fill_type, row, year)))
                    throw new Exception("小区绿化问题表插入失败！");
                if (!new DAL.TTGWeb.community_ff_problem().Add(read_ff(id, fill_type, row, year)))
                    throw new Exception("小区消防问题表插入失败！");
                if (!new DAL.TTGWeb.community_water_drain_problem().Add(read_drain(id, fill_type, row, year)))
                    throw new Exception("小区排水问题表插入失败！");
                if (!new TTGWeb.community_sanitation_problem().Add(read_sanitation(id, fill_type, row, year)))
                    throw new Exception("小区环卫问题表插入失败！");

                row++;
                content = Convert.ToString(re.readcell(row, column++));
            }
            return row + 2;
        }
        /// <summary>
        /// 读取并插入问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        private void read_insert_finished(string id, int row)
        {
            int column = 0;
            int trow = row;
            string year = "", project;
            string content = Convert.ToString(re.readcell(row, column));
            while (!content.Equals("合计"))
            {
                while (!content.Contains("年"))
                {
                    content = Convert.ToString(re.readcell(++trow, column));
                }
                year = content;
                content = Convert.ToString(re.readcell(row, column));
                while (!content.Contains("年"))
                {
                    content = Convert.ToString(re.readcell(row, column));
                    if (content.Contains("年"))
                    {
                        year = content + "2月";
                        project = "0";
                    }else{
                        project = content;
                    }

                    //读取表
                    if (!new DAL.TTGWeb.community_council_building_problem_finished().Add(read_building_f(id, row, year, project)))
                        throw new Exception("统建房问题完成表插入失败！");
                    if (!new TTGWeb.community_road_problem_finished().Add(read_road_f(id, row, year, project)))
                        throw new Exception("小区道路问题完成表插入失败！");
                    if (!new TTGWeb.community_bet_dwellings_road_problem_finished().Add(read_bet_f(id, row, year, project)))
                        throw new Exception("小区宅间路问题完成表插入失败！");
                    if (!new TTGWeb.community_water_supply_problem_finished().Add(read_water_f(id, row, year, project)))
                        throw new Exception("小区供水问题完成表插入失败！");
                    if (!new TTGWeb.community_elec_supply_problem_finished().Add(read_elec_f(id, row, year, project)))
                        throw new Exception("小区供电问题完成表插入失败！");
                    if (!new TTGWeb.community_lighting_problem_finished().Add(read_lighting_f(id, row, year, project)))
                        throw new Exception("小区照明问题完成表插入失败！");
                    if (!new TTGWeb.community_greening_problem_finished().Add(read_greeen_f(id, row, year, project)))
                        throw new Exception("小区绿化问题完成表插入失败");
                    if (!new TTGWeb.community_ff_problem_finished().Add(read_ff_f(id, row, year, project)))
                        throw new Exception("小区消防问题完成表插入失败！");
                    if (!new TTGWeb.community_water_drain_problem_finished().Add(read_drain_f(id, row, year, project)))
                        throw new Exception("小区排水问题完成表插入失败！");
                    if (!new TTGWeb.community_sanitation_problem_finished().Add(read_sanitation_f(id, row, year, project)))
                        throw new Exception("小区环卫问题完成表插入失败！");
                    row++;
                }

                content = Convert.ToString(re.readcell(row, column));
            }

            year += "2日";
            project = "0";

            //读取表
            if (!new DAL.TTGWeb.community_council_building_problem_finished().Add(read_building_f(id, row, year, project)))
                throw new Exception("统建房问题完成表插入失败！");
            if (!new TTGWeb.community_road_problem_finished().Add(read_road_f(id, row, year, project)))
                throw new Exception("小区道路问题完成表插入失败！");
            if (!new TTGWeb.community_bet_dwellings_road_problem_finished().Add(read_bet_f(id, row, year, project)))
                throw new Exception("小区宅间路问题完成表插入失败！");
            if (!new TTGWeb.community_water_supply_problem_finished().Add(read_water_f(id, row, year, project)))
                throw new Exception("小区供水问题完成表插入失败！");
            if (!new TTGWeb.community_elec_supply_problem_finished().Add(read_elec_f(id, row, year, project)))
                throw new Exception("小区供电问题完成表插入失败！");
            if (!new TTGWeb.community_lighting_problem_finished().Add(read_lighting_f(id, row, year, project)))
                throw new Exception("小区照明问题完成表插入失败！");
            if (!new TTGWeb.community_greening_problem_finished().Add(read_greeen_f(id, row, year, project)))
                throw new Exception("小区绿化问题完成表插入失败");
            if (!new TTGWeb.community_ff_problem_finished().Add(read_ff_f(id, row, year, project)))
                throw new Exception("小区消防问题完成表插入失败！");
            if (!new TTGWeb.community_water_drain_problem_finished().Add(read_drain_f(id, row, year, project)))
                throw new Exception("小区排水问题完成表插入失败！");
            if (!new TTGWeb.community_sanitation_problem_finished().Add(read_sanitation_f(id, row, year, project)))
                throw new Exception("小区环卫问题完成表插入失败！");
        }
        /// <summary>
        /// 读取并插入
        /// </summary>
        /// <param name="id"></param>
        public void read_and_insert(string id)
        {
            read_insert_finished(id, read_insert_problem(id));
        }
        /// <summary>
        /// 插入一列
        /// </summary>
        /// <param name="flag">标志插入列是在上半部分还是下半部分（0：上，1：下）</param>
        /// <param name="column">插入第几列</param>
        /// <param name="attname"></param>
        /// <param name="unit"></param>
        public void insert_line(int flag, int column, string attname, string unit)
        {
            //获取被修改的表名
            string table_name = new DAL.TTGWeb.excel_datatable().getTable(excel_name, column, flag);
            //修改alter_field表
            TTGWeb.alter_field af = new TTGWeb.alter_field();
            int count = af.getCount(table_name);
            Model.TTGWeb.alter_field afm = new Model.TTGWeb.alter_field()
            {
                table_name = table_name,
                field_name = attname,
                alter_field_unit = unit,
                alter_field_name = "tciunset" + (count + 1),
                alter_type = "add"
            };
            if (!af.Add(afm))
                throw new Exception("预留字段对应表插入失败！");

            List<Model.TTGWeb.excel_datatable> list = new TTGWeb.excel_datatable().getModelList(excel_name, column, flag);
            TTGWeb.excel_structure es = new TTGWeb.excel_structure();
            //更新excel_datatable表
            for (int i = 0; i < list.Count; i++)
            {
                list[i].table_start_column++;
                list[i].table_end_column++;
            }
            Model.TTGWeb.excel_datatable edm = new DAL.TTGWeb.excel_datatable().GetModel(table_name);
            edm.table_end_column++;
            list.Add(edm);
            for (int i = 0; i < list.Count; i++)
            {
                if (!new TTGWeb.excel_datatable().Update(list[i]))
                    throw new Exception(list[i].table_name + "： 数据库范围表更新失败！");
            }
            //更新excle_structure表
            for (int i = 0; i < list.Count; i++)
            {
                List<Model.TTGWeb.excel_structure> les = es.getMessage(excel_name, list[i].table_name);
                for (int j = 0; j < les.Count; j++)
                {
                    if (les[j].row_column_num >= column)
                    {
                        les[j].row_column_num++;
                        if (!es.Update(les[j]))
                            throw new Exception(les[j].table_name + "表" + les[j].property + "字段更新失败！");
                    }
                }
            }
            //插入字段
            if (!es.Add(new Model.TTGWeb.excel_structure()
            {
                table_name = table_name,
                excel_name = excel_name,
                property = attname,
                row_column_num = column
            }))
                throw new Exception("新增字段插入失败！");
        }
        /// <summary>
        /// 删除一列
        /// </summary>
        /// <param name="column"></param>
        /// <param name="flag"></param>
        public void delete_line(int column, int flag)
        {
            //获取被删除的字段所在表
            string table_name = new TTGWeb.excel_datatable().getTable(excel_name, column, flag);
            //更新alter_filed表，如果有必要的话
            string attname = new TTGWeb.excel_structure().getProperty(excel_name, table_name, column);
            TTGWeb.alter_field af = new TTGWeb.alter_field();
            if (af.isExist(attname, table_name))
            {
                if (!af.Delete(attname, table_name))
                    throw new Exception("预留字段对应表删除失败！");
            }

            //更新excel_datatable表
            List<Model.TTGWeb.excel_datatable> list = new TTGWeb.excel_datatable().getModelList(excel_name, column, flag);
            for (int i = 0; i < list.Count; i++)
            {
                list[i].table_start_column--;
                list[i].table_end_column--;
            }
            Model.TTGWeb.excel_datatable edm = new DAL.TTGWeb.excel_datatable().GetModel(table_name);
            edm.table_end_column--;
            list.Add(edm);
            for (int i = 0; i < list.Count; i++)
            {
                if (!new TTGWeb.excel_datatable().Update(list[i]))
                    throw new Exception(list[i].table_name + "： 数据库范围表更新失败！");
            }

            //删除字段
            TTGWeb.excel_structure es = new TTGWeb.excel_structure();
            if (!es.delete(column, table_name))
                throw new Exception(attname + "字段删除失败！");

            //更新excel_structure表
            for (int i = 0; i < list.Count; i++)
            {
                List<Model.TTGWeb.excel_structure> les = es.getMessage(excel_name, list[i].table_name);
                for (int j = 0; j < les.Count; j++)
                {
                    if (les[j].row_column_num > column)
                    {
                        les[j].row_column_num--;
                        if (!es.Update(les[j]))
                            throw new Exception(les[j].table_name + "表" + les[j].property + "字段更新失败！");
                    }
                }
            }
        }
    }
}
